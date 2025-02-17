<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormLogin.ascx.cs" Inherits="LoginGG.FormRegrister" %>
<div >
    <h3>Đăng nhập</h3>
    <div class="form-login">
        <div class="div-username">
            <asp:Label runat="server" CssClass="lbusername">Tên đăng nhập</asp:Label>
            <asp:TextBox runat="server" CssClass="txt"  ID="txtusername"></asp:TextBox>
        </div>
        <div class="div-passwprd">
            <asp:Label runat="server" CssClass="lbpassword">Mật khẩu</asp:Label>
            <asp:TextBox runat="server" CssClass="txt" ID="txtpassword" TextMode="Password"></asp:TextBox>
        </div>
        <div class="div-signin">
            <asp:Button Text="Đăng nhập" runat="server" CssClass="btnlogin" ID="btnlogin" />
            <asp:Button runat="server" ID="btnlogingg" Text="Đăng nhập với Google" CssClass="btngoogle" OnClick="btnlogingg_Click" />
            <i class="fa-brands fa-google"></i>

        </div>
    </div>
</div>
<style>
    .form-login{
        width:30%;
    }
    
.div-username, .div-passwprd {
    margin-bottom: 20px;
}

/* Thiết lập phong cách cho Label */
.lbpassword,.lbusername {
    font-weight: bold;
    display: block;
    margin-bottom: 5px;
}

/* Thiết lập cho TextBox */
.txt {
    width: 100%;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
}

/* Nút đăng nhập */
.div-signin {
    align-items: center;
}

.btnlogin {
    background-color: #4285F4;
    color: white;
    padding: 10px 15px;
    border: none;
    border-radius: 4px;
    font-size: 16px;
    cursor: pointer;
    width: 100%;
    margin-bottom: 10px;
}

.btnlogin:hover {
    background-color: #357AE8;
}

.btngoogle {
    display: flex;
    align-items: center;
    justify-content: center;
    background-color: white;
    color: #000;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    cursor: pointer;
    font-size: 16px;
    font-weight: bold;
    width: 100%;
    margin-bottom: 10px;
}
.btngoogle {
    content: url('https://upload.wikimedia.org/wikipedia/commons/5/53/Google_%22G%22_Logo.svg');
    display: inline-block;
    margin-right: 10px;
    
}
.btngoogle:hover {
    background-color: #f7f7f7;
}
</style>
