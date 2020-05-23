<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="SistemaPiscina.Presentacion.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-warning">
        <div class="row">
            <div class="col-5 pt-3 pb-3">
                <table class="mx-auto">
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbid" runat="server" class="form-control" placeholder="ID Usuario"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbusuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbpass" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>                  
                    <tr>
                        <td align="center" >
                            <asp:Button ID="Btnguardar" runat="server" Text="Guardar"  class="btn btn-success" Width="80%" OnClick="Btnguardar_Click" />
                        </td>
                    </tr>                    
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" class="btn btn-danger" Width="80%" Visible="False" OnClick="Btneliminar_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btnlimpiar" runat="server" Text="Limpiar" class="btn btn-secondary" Width="80%" OnClick="Btnlimpiar_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-7 pt-3">
                <asp:GridView ID="Grillausuario" runat="server" class="table table-dark table-hover" OnSelectedIndexChanged="Grillausuario_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
