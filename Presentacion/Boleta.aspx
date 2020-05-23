<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="Boleta.aspx.cs" Inherits="SistemaPiscina.Presentacion.Boleta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid ">
        <div class="row">
            <div class="col-4 bg-info pt-3 pb-3">
                <table class="mx-auto" style="width: 80%; border: 2px;">
                    <tr>
                        <td>RUC
                        </td>
                        <td>
                            <asp:Label ID="Lbruc" runat="server" Text="1012598410" class="form-control"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Cliente
                        </td>
                        <td>
                            <asp:Label ID="Lbcliente" runat="server" class="form-control"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Servicio
                        </td>
                        <td>
                            <asp:Label ID="Lbservicio" runat="server" class="form-control"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Total
                        </td>
                        <td>
                            <asp:Label ID="Lbtotal" runat="server" class="form-control"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Fecha
                        </td>
                        <td>
                            <asp:Label ID="Lbfecha" runat="server" class="form-control"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="pt-3" align="center">
                            <asp:Button ID="Btnvolver" runat="server" Text="Volver" class="form-control bg-warning" Style="width: 100%" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Btnvolver_Click" />
                        </td>
                        <td class="pt-3" align="center">
                            <asp:Button ID="Btnguardar" runat="server" Text="Guardar" class="form-control bg-success" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Btnguardar_Click" Style="width: 100%;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="pt-2" align="center" colspan="2">
                            <asp:Label ID="LbMensaje" runat="server" class="modal-dialog"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-8 bg-danger">
                <table class="container-fluid">
                    <tr>
                        <td >
                            <asp:GridView ID="Grillaboleta" runat="server" class="table table-dark table-hover"></asp:GridView>
                        </td>
                    </tr>
                </table>

            </div>
        </div>

    </div>
</asp:Content>
