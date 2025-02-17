using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DotNetNuke.Entities.Users;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using LoginGG.Controller;
using LoginGG.DataAccess;
namespace LoginGG
{
    public partial class FormLoginCallBack : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string code = Request.QueryString["code"];
            if (string.IsNullOrEmpty(code))
            {
                Response.Redirect(GetGoogleLoginUrl());
                return;
            }
            Response.Write($"<p>Authorization Code: {code}</p>");

            string accessToken = GetAccessToken(code);
            Response.Write($"<p>AccessToken: {accessToken}</p>");
            UserInfo userInfo = GetUserInfo(accessToken);
            Response.Write($"<p>Email: {userInfo.Email}</p>");
            Response.Write($"<p>name: {userInfo.Name}</p>");
            Response.Write($"<p>profilepicture: {userInfo.ProfilePicture}</p>");
            Response.Redirect("Đăng-ký-khóa-học");
        }
        private String GetAccessToken(string code)
        {
            string tokenEndpoint = "https://oauth2.googleapis.com/token";
            string clientId = "1015768219619-tc6unf3879bau316f32n2sosei14lii8.apps.googleusercontent.com";
            string clientSecret = "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";
            string redirectUri = "http://dnnregrister.com/LoadFormGG";



            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
            {
                { "code", code },
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "redirect_uri", redirectUri },
                { "grant_type", "authorization_code" }
            };

                var content = new FormUrlEncodedContent(values);
                //var response =  client.PostAsync(tokenEndpoint, content).GetAwaiter().GetResult();
                //response.EnsureSuccessStatusCode();
                try
                {
                    var response = client.PostAsync(tokenEndpoint, content).GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        // Đọc nội dung phản hồi lỗi
                        var errorResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        Console.WriteLine($"Error: {errorResponse}");
                        throw new Exception($"Failed to get access token: {errorResponse}");
                    }
                    var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var json = JObject.Parse(responseString);
                    string accessToken = json["access_token"]?.ToString();

                    return accessToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi:{e.Message}");
                    throw;
                }
            }
        }

        private UserInfo GetUserInfo(string accessToken)
        {
            string userInfoEndpoint = "https://www.googleapis.com/oauth2/v2/userinfo";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var response = client.GetAsync(userInfoEndpoint).GetAwaiter().GetResult();
                var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                var userInfoResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
                string email = userInfoResponse["email"];
                string name = userInfoResponse["name"];
                string imgurl = userInfoResponse["picture"];
                using (var context=new HnueEmailDataContext())
                {
                    var lst=context.HnueEmails.SingleOrDefault(i=>i.Email== email);
                    if(lst==null)
                    {
                        var newHnueEmail = new HnueEmail()
                        {
                            Email = email,
                            Fullname= name,
                            PictureUrl = imgurl,
                            Accesstoken= accessToken
                        };
                        context.HnueEmails.InsertOnSubmit(newHnueEmail);
                    }
                    else
                    {
                        lst.Accesstoken=accessToken;
                    }    
                    context.SubmitChanges();
                }
                Session["AccessToken"] = accessToken;
                Session["Email"] = email;
                Session["Name"] = name;
                Session["ProfilePicture"] = imgurl;
                return new UserInfo
                {
                    Accesstoken = accessToken,
                    Email = userInfoResponse["email"],
                    Name = userInfoResponse["name"],
                    ProfilePicture = userInfoResponse["picture"]
                };

            }

        }

        private string GetGoogleLoginUrl()
        {
            string clientId = "1015768219619-tc6unf3879bau316f32n2sosei14lii8.apps.googleusercontent.com";
            string redirectUri = "http://dnnregrister.com/LoadFormGG";
            string scope = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
            string state = Guid.NewGuid().ToString();

            return $"https://accounts.google.com/o/oauth2/v2/auth?client_id={clientId}&redirect_uri={redirectUri}&response_type=code&scope={scope}&state={state}&prompt=select_account";
        }
    }
    public class UserInfo
    {
        public string Accesstoken { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
    }
}