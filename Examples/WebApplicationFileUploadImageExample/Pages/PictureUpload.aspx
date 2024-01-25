<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureUpload.aspx.cs" Inherits="WebApplicationFileUploadImageExample.Pages.PictureUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Image ID="imgShow" runat="server" Style="background:#fff; " />
            </div>
            <div>
                <asp:FileUpload ID="fileSelect" runat="server" accept="image/*" />
            </div>
            <div>
                <asp:Button ID="btnUpload" runat="server" Text="上傳圖片" OnClick="btnUpload_Click"/>
                <asp:Label ID="labTipMsg" runat="server" Style="color: Red"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
