<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <style>
        #Contenido_TipoRdl label {
            margin-left: 10px;
        }
    </style>
    <div class="row mt-5">
        <div class="col-12 col-md-6 con-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white text-center">
                    <h5>Registrar Cliente</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="NombreTxt">Nombre</label>
                        <asp:TextBox runat="server" ID="NombreTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombreTxt" CssClass="text-danger" runat="server" ErrorMessage="Debes ingresar el nombre" ControlToValidate="NombreTxt">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="RutTxt">RUT</label>
                        <asp:TextBox runat="server" ID="RutTxt" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidatorRutTxt" CssClass="text-danger" runat="server" ErrorMessage="CustomValidator" ControlToValidate="RutTxt" 
                            OnServerValidate="CustomValidatorRutTxt_ServerValidate" ValidateEmptyText="true">
                        </asp:CustomValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="CafeDdl">Cafe Favorito</label>
                        <asp:DropDownList runat="server" ID="CafeDdl" CssClass="form-select">

                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="TipoRdl">Tipo del Cliente</label>
                        <asp:RadioButtonList runat="server" ID="TipoRdl">
                            <asp:ListItem Value="1" Text="Silver" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="GuardarBtn" CssClass="btn btn-dark" Text="Registrar" OnClick="RegistrarBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
