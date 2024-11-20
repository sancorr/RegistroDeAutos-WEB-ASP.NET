<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RegistroAutos.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col">
            <asp:GridView DataKeyNames="Id" runat="server" ID="dgvRegistros" OnSelectedIndexChanged="dgvRegistros_SelectedIndexChanged" AutoGenerateColumns="false" CssClass="table table-dark table-striped table-bordered mt-4">
                <Columns>                   
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Marca" DataField="Marca" />
                    <asp:BoundField HeaderText="Fecha de fabricación" DataField="FechaFabricacion" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Ver detalle" HeaderText="Accion" />
                </Columns>
            </asp:GridView>
            <a href="AddForm.aspx">Agregar vehiculo</a>
        </div>
    </div>

</asp:Content>
