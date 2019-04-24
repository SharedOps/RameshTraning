<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdoEx.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Id:
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox><br/>
            Enter Your FirstName :
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox><br/>
            Enter Your LastName:            
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox><br/>
            Enter Your City:
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox><br/>

            <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
            <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
            <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" /><br/>
            <asp:Label ID="lblmsg" runat="server" ></asp:Label>
            <asp:GridView ID="grdcustomer" runat="server"></asp:GridView>
            
        
            </div>
    </form>
</body>
</html>
