<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MensajesWebForm.aspx.cs" Inherits="MensajesWebApplication.MensajesWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
       <style type="text/css">  
        body form {
	    width:400px;
	    height:400px;
	    margin:0 auto;
        background-color:#D5EDEF;
        }
    </style>
</head>
<body>
    <form id="Mensajes" runat="server">
    <div>
         <h1 class="text-center">Mensajeria</h1> 
        <asp:TextBox ID="MensajeIdTextBox" runat="server" CssClass="form-control " placeholder="Mensaje Id"></asp:TextBox><br/><br/>
        <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control " placeholder="Email"></asp:TextBox><br/><br/>
        <asp:TextBox ID="AsuntoTextBox" runat="server" CssClass="form-control " placeholder="Asunto"></asp:TextBox><br/><br/>
        <asp:TextBox ID="MensajeTextBox" runat="server" CssClass="form-control " placeholder="Mensaje"></asp:TextBox><br/><br/>
    </div>
        <asp:LinkButton ID="EnviarButton" runat="server" CssClass="btn btn-info" Text="Enviar" OnClick="EnviarButton_Click"><span class="glyphicon glyphicon-send"></span>&nbsp;Enviar</asp:LinkButton>
    </form>
</body>
</html>
