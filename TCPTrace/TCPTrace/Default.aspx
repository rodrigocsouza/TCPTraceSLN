<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TCPTrace.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Porta a ser levantada:<br />
        <asp:TextBox ID="txbPortaEscuta" runat="server"></asp:TextBox>
        <br />
        Servidor de destino:<br />
        <asp:TextBox ID="txbServidor" runat="server"></asp:TextBox>
        <br />
        Porta de destino:<br />
        <asp:TextBox ID="txbServidorPorta" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnIniciar" runat="server" onclick="btnIniciar_Click" 
            Text="Iniciar" />
&nbsp;<asp:Button ID="btnParar" runat="server" onclick="btnParar_Click" Text="Parar" />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
