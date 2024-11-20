<%@ Page Title="Agregar vehiculo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddForm.aspx.cs" Inherits="RegistroAutos.AddForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="mb-3">
        <label for="autoID" class="form-label">ID:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="autoID" placeholder="Inserte el ID">
        </asp:TextBox>
    </div>

    <div class="mb-3">
        <label for="autoModelo">Modelo:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="autoModelo" placeholder="Inserte el Modelo"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label for="autoMarca" class="form-label">Marca:</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="autoMarca" placeholder="Inserte la marca"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label for="autoFecha" class="form-label">Fecha de fabricación</label>
        <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="autoFecha" placeholder="Inserte la fecha de fabricacion"></asp:TextBox>

    </div>

    <div>
        <asp:CheckBox runat="server" id="chkUsado" />
        <asp:Label runat="server" Text="Usado" CssClass="form-check-label"></asp:Label>
    </div>

    <div>
        <asp:CheckBox runat="server" id="chkImportado" />
        <asp:Label runat="server" Text="Importado" CssClass="form-check-label"></asp:Label>
    </div>

    <asp:Button CssClass="btn btn-primary mx-auto p-2" runat="server" Text="Confirmar" ID="btnConfirmar" OnClick="btnConfirmar_Click" />
    <asp:Button CssClass="btn btn-primary" runat="server" Text="Modificar" ID="btnModificar" OnClick="btnModificar_Click" />
    <asp:Button CssClass="btn btn-primary" runat="server" Text="Eliminar" ID="btnEliminar" OnClick="btnEliminar_Click" />
    <a href="Default.aspx" class="link-danger link-opacity-10-hover mx-auto p-2" id="btnCancelar">Cancelar</a>
    <asp:Label runat="server" ID="lblError" Visible="false" Text="El ID ya existe, ingrese otro"></asp:Label>
</asp:Content>
