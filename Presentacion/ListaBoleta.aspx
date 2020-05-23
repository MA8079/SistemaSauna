<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="ListaBoleta.aspx.cs" Inherits="SistemaPiscina.Presentacion.ListaBoleta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-warning pb-2">
        <div style="width: 800px" class="mx-auto pt-4">
            <table class="table table-dark table-hover" style="text-align:center;">
                <tr>
                    <td style="width: 0.001%;">ID</td>
                    <td style="width: 13.5%;">RUC</td>
                    <td style="width:32%;">Cliente</td>
                    <td style="width:17.2%;">Servicio</td>
                    <td style="width:10.2%;">Total</td>
                    <td>Fecha</td>
                </tr>                                             
            </table>
        </div>
        <div style="width:800px;height:300px; overflow:auto"  class="mx-auto bg-dark" >
            <asp:GridView ID="Grillaboleta" runat="server" class="table table-dark table-hover pt-0" ShowHeader="False"></asp:GridView>
        </div>
    </div>
</asp:Content>
