<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFile.aspx.cs" Inherits="WebApplicationFileUploadExample.UploadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            請選擇要上傳的文件：<asp:FileUpload ID="fileup" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="開始上傳"  OnClick="btnUpload_Click"/>
            <br />
            <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
