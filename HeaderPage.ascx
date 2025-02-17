<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderPage.ascx.cs" Inherits="LoginGG.FormRegrister1" %>
<div>
    <div runat="server" class="container-fluid bg-primary py-5 hero-header mb-5">
        <div class="row py-3">
            <div class="col-12 text-center">
                <h6 class="display-3 text-white animated fff">Thí sinh đăng ký thi</h6>
            </div>
        </div>
    </div>
<div>

</div>
<div class="">
        <div class="container">
            <form class="a1" >
                    <div class="section-title mb-4">
                        <h5 class="position-relative d-inline-block text-primary text-uppercase">Đăng ký thi: HSK2</h5>
                    </div>
                <div class="row rd">

                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">Chọn đợt thi <span class="text-danger">*</span></label>
                        <asp:DropDownList ID="ddlDotThi" runat="server" CssClass="form-control" style="background-color: #005a9c;color: #ffffff;font-weight:bold;">
                             <asp:ListItem Value="08/12/2024">08/12/2024</asp:ListItem>
    <asp:ListItem Value="15/12/2024">15/12/2024</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                            <label class="font_helB">Hình thức thi<span class="text-danger">*</span></label>
                <asp:DropDownList ID="ddlHinhThucThi" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Thi giấy">Thi giấy</asp:ListItem>
                    <asp:ListItem Value="Thi trực tuyến">Thi trực tuyến</asp:ListItem>
                </asp:DropDownList>                        
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">*HỌ TÊN<span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" ID="txthoten" CssClass="form-control"></asp:TextBox>                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* TÊN TIẾNG TRUNG</label>
                        <asp:TextBox ID="txttentheonn" runat="server" CssClass="form-control" />

                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* LOẠI GIẤY TỜ</label>
                <asp:DropDownList ID="ddlloaigiayto" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Loại 1 ">Loại 1</asp:ListItem>
                    <asp:ListItem Value="Loại 2 ">Loại 2</asp:ListItem>
                </asp:DropDownList>     
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* SỐ CMND/HC/CCCD<span class="text-danger">*</span></label>
                      <asp:TextBox ID="txtcccd" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* GIỚI TÍNH</label>
                        <asp:DropDownList ID="ddlgioitinh" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Nam">Nam</asp:ListItem>
                            <asp:ListItem Value="Nữ">Nữ</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* NGÀY SINH<span class="text-danger">*</span></label>
                    <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control" TextMode="Date" />
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* EMAIL<span class="text-danger">*</span></label>
                    <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"  />
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* ĐIỆN THOẠI<span class="text-danger">*</span></label>
                        <asp:TextBox ID="txtsdt" runat="server" CssClass="form-control"  />

                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-12" style="margin-bottom:10px">
                        <label class="font_helB">* Địa chỉ nhận Chứng chỉ<span class="text-danger">*</span></label>
                        <asp:TextBox ID="txtdiachinhanchungchi" runat="server" CssClass="form-control"  />
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">
                            * SỐ NĂM HỌC TIẾNG <span class="text-danger">*</span>
                        </label>
                        <asp:DropDownList ID="ddlsonam" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Năm 1">Năm 1</asp:ListItem>
                            <asp:ListItem Value="Năm 2">Năm 2</asp:ListItem>
                             <asp:ListItem Value="Năm 3">Năm 3</asp:ListItem>
                             <asp:ListItem Value="Năm 4">Năm 4</asp:ListItem>
                             <asp:ListItem Value="Năm 5">Năm 5</asp:ListItem>
                            <asp:ListItem Value="Năm 6">Năm 6</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-6">
                        &nbsp;
                    </div>
                </div>

                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* TẢI LÊN ẢNH MẶT TRƯỚC CMND/HC/CCCD<span class="text-danger">*</span></label>
                        <asp:FileUpload ID="fuFilemattruoccccd" runat="server" CssClass="form-control" Accept="image/png, image/gif, image/jpeg, image/jpg" />
                        <i style="color:red">Định dạng file ảnh: gif, png, jpg</i>
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* TẢI LÊN ẢNH MẶT SAU CMND/HC/CCCD<span class="text-danger">*</span></label>
                        <asp:FileUpload ID="fuFilematsaucccd" runat="server" CssClass="form-control" Accept="image/png, image/gif, image/jpeg, image/jpg" />
                        <i style="color:red">Định dạng file ảnh: gif, png, jpg</i>
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* TẢI LÊN ẢNH THẺ (4x6)<span class="text-danger">*</span></label>
                        <asp:FileUpload ID="fuFileanhthe" runat="server" CssClass="form-control" Accept="image/png, image/gif, image/jpeg, image/jpg" />
                        <i style="color:red">Định dạng file ảnh: gif, png, jpg</i>
                    </div>
                    <div class="col-sm-6" style="margin-bottom:10px">
                        <label class="font_helB">* TẢI LÊN BIÊN LAI NỘP TIỀN<span class="text-danger">*</span></label>
                        <asp:FileUpload ID="fuFileanhnopbienlai" runat="server" CssClass="form-control" Accept="image/png, image/gif, image/jpeg, image/jpg" />
                        <i style="color:red">Định dạng file ảnh: gif, png, jpg</i>
                    </div>
                </div>
                <div class="row rd">
                    <div class="col-sm-12">
                        <div class="form-group row">
                            <label class="col-sm-2 font_helB"><b>Mã xác nhận(*)</b></label>
                            <%--<div class="col-sm-2">
                                <img alt="Captcha" src="/dangky/CaptchaImage" style="">
                            </div>
                            <div class="col-sm-2">
                                <input type="text" id="capchar" name="capchar" class="form-control" required="">
                            </div>--%>
                            <div class="col-sm-6" style="text-align:right">
                                <asp:Button CssClass="btn btn-success" runat="server" Text="Đăng ký" ID="btndangky" OnClick="btndangky_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <hr>
                <div class="row rd">
                    <div class="col-sm-4" style="margin-bottom:10px">
                        <h3>Nộp qua ngân hàng</h3>
                        Tên tài khoản	: Trường Đại học Sư Phạm Hà Nội p<br>
                        - Số tài khoản	: 34510102030405<br>
                        - Tên Ngân hàng	: Mb Bank <br><br>
                        <h5 style="color:red">
                            Nội dung chuyển tiền cần ghi rõ:<br> "NỘP LỆ PHÍ THI HSK + Họ tên thí sinh + số CMND của thí sinh + Cấp độ thi + ngày thi"
                        </h5>
                    </div>
                    <div class="col-sm-4" style="margin-bottom:10px">
                        <img src="/images/sea_qr.jpg" class="mw-100">
                    </div>
                    <div class="col-sm-4" style="margin-bottom:10px">
                        <h3>Nộp trực tiếp</h3>
                        Trung tâm phục vụ sinh viên - Phòng 201, trường Đại học Đông Á, số 33 Xô Viết Nghệ Tĩnh, Hòa Cường Nam, Hải Châu, Đà Nẵng
                    </div>
                </div>
            </form>

        </div>
    </div>
   </div>
<style>
    .col-12 {
    flex: 0 0 auto;
    width: 100%;
}
    .hero-header {
    background-image: url('https://tophinhanhdep.com/wp-content/uploads/2021/10/1920X1080-Wallpapers.jpg');
    background-size: cover;
     background-position: center;
     background-repeat: no-repeat;
}

    .py-3 {
    padding-top: 1rem !important;
    padding-bottom: 1rem !important;
}
    .text-white {
    color: #fff !important;
}
    .fff {
    font-size: 40px;
}
    label {
    display: inline-block;
    max-width: 100%;
    margin-bottom: 5px;
    font-weight: 700;
}
    .form-control {
    display: block;
    width: 100%;
    font-size: 1rem;
    font-weight: 400;
    line-height: 1.5;
    color: #6B6A75;
    background-color: #fff;
    background-clip: padding-box;
    border: 1px solid #ced4da;
    appearance: none;
    border-radius: 2px;
    transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}
    .rd {
    margin-bottom: 15px;
}
    .row {

    display: flex;
    flex-wrap: wrap;
}
.form-control:read-only {
    background-color: #e9ecef;
    opacity: 1;
}
</style>