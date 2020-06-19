<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProjetoMVCB38.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
                <div class="form-group" >
                    <asp:Label for="CPF" runat="server">CPF</asp:Label>
                    <input name="cpf" type="number" runat="server" class="form-control" />
                </div>
                <div class="form-group" >
                    <asp:Label for="Nome completo" runat="server" >Nome completo</asp:Label>
                    <input name="txtNomeB38" type="text" runat="server" class="form-control"/>
                </div>
                <div class="form-group" >
                    <asp:Label for="Nome da mãe" runat="server">Nome da mãe</asp:Label>
                    <input name="txtNomeMaeB38" type="text" runat="server" class="form-control"/>
                </div>
                <div style="width:100%; display:inline-flex; justify-content:center;" >
                    <asp:Button CssClass="btn btn-success" Text="ENVIAR" runat="server" />
                </div>
        </div>
    </form>
</body>
</html>
