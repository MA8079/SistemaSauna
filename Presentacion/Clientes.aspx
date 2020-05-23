<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="SistemaPiscina.Presentacion.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-primary">
        <br />
        <table width="30%" align="center">
            <tr style="margin-top: 10%;">
                <td>
                    <asp:TextBox ID="Tbid" runat="server" class="form-control" placeholder="ID" ReadOnly="True" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="Tbnombre" runat="server" class="form-control" placeholder="Nombres" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="Tbapellido" runat="server" class="form-control" placeholder="Apellidos" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="Tbdni" runat="server" class="form-control" placeholder="DNI" Width="100%" MaxLength="8"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbtelefono" runat="server" class="form-control" placeholder="Teléfono" Width="100%"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Btnguardar" runat="server" Text="Registrar" class="btn btn-success" OnClick="Btnguardar_Click" Style="width: 50%;" BorderStyle="None" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Btnmodificar" runat="server" Text="Modificar" class="btn btn-warning" OnClick="Btnmodificar_Click" Style="width: 50%;" BorderStyle="None" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Btnlimpiar" runat="server" Text="Limpiar" class="btn btn-warning" OnClick="Btnlimpiar_Click" Style="width: 50%;" BorderStyle="None" Enabled="True" />
                </td>
            </tr>
        </table>
        <br />
        <table width="60%" align="center">
            <tr>
                <td>
                    <asp:GridView ID="GridviewClientes" runat="server" class="table table-dark" OnSelectedIndexChanged="GridviewClientes_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
    </div>

</asp:Content>
