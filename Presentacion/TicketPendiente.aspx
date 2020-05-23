<%@ Page Title="Pendiente" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="TicketPendiente.aspx.cs" Inherits="SistemaPiscina.Presentacion.TicketPendiente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-warning pt-3 pb-3">
        <div class="row">
            <div class="col-8">
                <asp:GridView ID="GrillaTicket" runat="server" class="table table-dark table-striped " OnSelectedIndexChanged="GrillaTicket_SelectedIndexChanged" Width="681px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-4">
                <table  widht="40%" align="center">
                    <tr>
                        <td class="pt-xl-5">
                            <asp:Button ID="Btngenerar" runat="server" Text="Generar Boleta" class="form-control btn-success" OnClick="Btngenerar_Click" Visible="False" />
                        </td>
                    </tr>
                </table>                
            </div>
        </div>
    </div>
</asp:Content>
