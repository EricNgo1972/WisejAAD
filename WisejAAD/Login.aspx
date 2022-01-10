<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WisejAAD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp runat="server" ViewStateMode="Disabled">
                        <LoggedInTemplate>
                            <ul >
                                <li class="navbar-text">Hello, <%: Context.User.Identity.Name  %>!</li>
                            </ul>
                               <asp:Button runat="server" Text="Login" OnClick="SignIn_Click" />
                            <asp:Button runat="server" Text="Logout" OnClick="Logout_Click" />

                        </LoggedInTemplate>
                      
                    </asp>
        
    </form>
</body>
</html>
