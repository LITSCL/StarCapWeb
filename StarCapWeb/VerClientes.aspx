<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCapWeb.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="mt-5">
        <asp:DropDownList ID="NivelDdl" runat="server" AutoPostBack="true" OnSelectedIndexChanged="NivelDdl_SelectedIndexChanged">
            <asp:ListItem Value="1" Selected="True" Text="Silver"></asp:ListItem>
            <asp:ListItem Value="2" Selected="False" Text="Gold"></asp:ListItem>
            <asp:ListItem Value="3" Selected="False" Text="Platinum"></asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="TodosChx" Checked="true" runat="server" AutoPostBack="true" OnCheckedChanged="TodosChx_CheckedChanged" Text="Ver todos" />
    </div>

    <div class="mt-5">
        <asp:GridView ID="ClientesGrid" runat="server" AutoGenerateColumns="false" CssClass="table table-hover" OnRowCommand="ClientesGrid_RowCommand" EmptyDataText="No hay clientes registrados">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Nivel" DataField="NivelTxt" />
            <asp:BoundField HeaderText="Favorito" DataField="codigoBebidaFavorita" />
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <asp:Button ID="Eliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("Rut") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
    </div>
</asp:Content>
