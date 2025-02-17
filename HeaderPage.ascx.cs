using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginGG.Controller;
using LoginGG.DataAccess;
namespace LoginGG
{
    public partial class FormRegrister1 : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session != null && Session.Keys.Count > 0)
            //{
            //    foreach (string key in Session.Keys)
            //    {
            //        Response.Write($"Key: {key}, Value: {Session[key]}<br />");
            //    }
            //}
            //else
            //{
            //    Response.Write("Session is empty.<br />");
            //}
        }

        protected void btndangky_Click(object sender, EventArgs e)
        {
            try
            {
                string userEmail = Session["Email"]?.ToString();
                if (string.IsNullOrEmpty(userEmail)) {
                    Response.Write("Vui long dang nhap ");
                    return;
                }
                string bienlaiPath,anhthePath,cccdmattrcPath,cccdmatsauPath=null;
                var hnueemail = new HnueEmailDataContext();
                var hnueDangky = new HnueDangKyDataContext();
                var lst = hnueemail.HnueEmails.FirstOrDefault(i => i.Email == userEmail);
                if (lst == null)
                {
                    Response.Write("Khong tim thay tai khoan ");
                    return;
                }
                var check = hnueDangky.HnueDangKyThis.FirstOrDefault(i => i.EmailUser == lst.Email&& i.dot_thi.Equals(ddlDotThi.SelectedValue));
                if (check != null) {
                    Response.Write("Ban da dang ky dot thi nay");
                    return;
                }
                if (fuFileanhnopbienlai.HasFile)
                {
                    string ext = Path.GetExtension(fuFileanhnopbienlai.FileName).ToLower();
                    if(ext!=".jqg"&&ext!=".jpeg"&&ext!=".png"&&ext!=".gif")
                    {
                        Response.Write("Vui long nhap dung dinh dang file anh (jpg, jpeg, png, gif) ");
                        return;
                    }
                    string fileName = $"bienlai_{userEmail}_{Guid.NewGuid()}{ext}";
                    string uploadFolder = "~/DesktopModules/LoginGG/uploads/bienlai/";
                    string physicalPath = Server.MapPath(uploadFolder);
                    if (!Directory.Exists(physicalPath))
                    {
                        Directory.CreateDirectory(physicalPath);
                    }
                    fuFileanhnopbienlai.SaveAs(Path.Combine(physicalPath, fileName));
                    bienlaiPath = $"{uploadFolder}{fileName}";
                }
                else
                {
                    Response.Write("Vui long upload file bien lai ");
                    return;
                }
                if (fuFileanhthe.HasFile)
                {
                    string ext = Path.GetExtension(fuFileanhthe.FileName).ToLower();
                    if (ext != ".jqg" && ext != ".jpeg" && ext != ".png" && ext != ".gif")
                    {
                        Response.Write("Vui long nhap dung dinh dang file anh (jpg, jpeg, png, gif) ");
                        return;
                    }
                    string fileName = $"anhthe_{userEmail}_{Guid.NewGuid()}{ext}";
                    string uploadFolder = "~/DesktopModules/LoginGG/uploads/anhthe/";
                    string physicalPath = Server.MapPath(uploadFolder);
                    if (!Directory.Exists(physicalPath))
                    {
                        Directory.CreateDirectory(physicalPath);
                    }
                    fuFileanhthe.SaveAs(Path.Combine(physicalPath, fileName));
                    anhthePath = $"{uploadFolder}{fileName}";
                }
                else
                {
                    Response.Write("Vui long upload file anh the ");
                    return;
                }
                if (fuFilematsaucccd.HasFile)
                {
                    string ext = Path.GetExtension(fuFilematsaucccd.FileName).ToLower();
                    if (ext != ".jqg" && ext != ".jpeg" && ext != ".png" && ext != ".gif")
                    {
                        Response.Write("Vui long nhap dung dinh dang file anh (jpg, jpeg, png, gif) ");
                        return;
                    }
                    string fileName = $"cccdmatsau_{userEmail}_{Guid.NewGuid()}{ext}";
                    string uploadFolder = "~/DesktopModules/LoginGG/uploads/cccdmatsau/";
                    string physicalPath = Server.MapPath(uploadFolder);
                    if (!Directory.Exists(physicalPath))
                    {
                        Directory.CreateDirectory(physicalPath);
                    }
                    fuFilematsaucccd.SaveAs(Path.Combine(physicalPath, fileName));
                    cccdmatsauPath = $"{uploadFolder}{fileName}";
                }
                else
                {
                    Response.Write("Vui long upload file can cuoc cong dan mat sau ");
                    return;
                }
                if (fuFilemattruoccccd.HasFile)
                {
                    string ext = Path.GetExtension(fuFilemattruoccccd.FileName).ToLower();
                    if (ext != ".jqg" && ext != ".jpeg" && ext != ".png" && ext != ".gif")
                    {
                        Response.Write("Vui long nhap dung dinh dang file anh (jpg, jpeg, png, gif) ");
                        return;
                    }
                    string fileName = $"cccdmattrc_{userEmail}_{Guid.NewGuid()}{ext}";
                    string uploadFolder = "~/DesktopModules/LoginGG/uploads/cccdmattrc/";
                    string physicalPath = Server.MapPath(uploadFolder);
                    if (!Directory.Exists(physicalPath))
                    {
                        Directory.CreateDirectory(physicalPath);
                    }
                    fuFilemattruoccccd.SaveAs(Path.Combine(physicalPath, fileName));
                    cccdmattrcPath = $"{uploadFolder}{fileName}";
                }
                else
                {
                    Response.Write("Vui long upload file can cuoc cong dan mat truoc ");
                    return;
                }
                var dangky = new HnueDangKyThi
                {
                    dot_thi = ddlDotThi.SelectedValue,
                    hinh_thuc_thi=ddlHinhThucThi.SelectedValue,
                    ho_ten=txthoten.Text,
                    ten_theonn=txttentheonn.Text,
                    loai_giay_to=ddlloaigiayto.SelectedValue,
                    cccd=txtcccd.Text,
                    gioi_tinh=ddlgioitinh.SelectedValue,
                    ngay_sinh=txtNgaySinh.Text,
                    email=txtemail.Text,
                    EmailUser = Session["Email"]?.ToString(),
                    so_dien_thoai=txtsdt.Text,
                    dia_chi=txtdiachinhanchungchi.Text,
                    so_nam_hoc_nn=ddlsonam.SelectedValue,
                    file_anh_the_url=anhthePath,
                    file_bienlai_noptien_url=bienlaiPath,
                    file_cccd_sau_url=cccdmatsauPath,
                    file_cccd_truoc_url=cccdmattrcPath
                };
                hnueDangky.HnueDangKyThis.InsertOnSubmit(dangky);
                hnueDangky.SubmitChanges();
                Response.Write("Thanh cong");
            }
            catch (Exception ex) {
                Response.Write($"Có lỗi xảy ra: {ex.Message}");
            }

        }
    }
}