<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="Servicio.aspx.cs" Inherits="SistemaPiscina.Presentacion.Servicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-primary">
        <br />
        <table class="mx-auto" style="width:30%;">
            <tr style="margin-top: 10%;">
                <td>
                    <asp:TextBox ID="Tbid" runat="server" class="form-control" placeholder="ID" ReadOnly="True" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="Tbnombre" runat="server" class="form-control" placeholder="Servicio" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="Tbcosto" runat="server" class="form-control" placeholder="Costo" Width="100%"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td align="center">
                    <asp:Button ID="Btnguardar" runat="server" Text="Registrar" class="btn btn-success" OnClick="Btnguardar_Click" Width="50%"  />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Btnmodificar" runat="server" Text="Modificar" class="btn btn-warning" OnClick="Btnmodificar_Click" Visible="False" Width="50%" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Btnlimpiar" runat="server" Text="Limpiar" class="btn btn-light" Width="50%" OnClick="Btnlimpiar_Click" />
                </td>
            </tr>
        </table>
        <br />
        <table width="60%" align="center">
            <tr>
                <td>
                    <asp:GridView ID="Grillaservicios" runat="server" class="table table-dark" OnSelectedIndexChanged="Grillaservicios_SelectedIndexChanged">
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
