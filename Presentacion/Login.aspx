<%@ Page Title="Login" Language="C#" MasterPageFile="~/Presentacion/MaestraDefault.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaPiscina.Presentacion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-info pt-5 pb-5">
        <div class="container-sm bg-info" style="width:30%;height:50%;">
            <table class="table table-dark">
                <tr>
                    <td>
                        <asp:TextBox ID="TbUsuario" runat="server" class="form-control" placeholder="Usuario" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TbPass" runat="server" class="form-control" placeholder="Password" TextMode="Password" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="BtnEntrar" runat="server" Text="Ingresar" class="btn btn-warning" OnClick="BtnEntrar_Click" />
                        <br />
                        <br />
                        <asp:Label ID="LbError" runat="server" class="modal-dialog"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        
    </div>
</asp:Content>
