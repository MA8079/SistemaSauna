<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="RegistroTicket.aspx.cs" Inherits="SistemaPiscina.Presentacion.RegistroTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-7 bg-success pt-5">
                
                <table style="width: 100%;" align="center">                    
                    <tr>
                        <td>
                        <asp:GridView ID="Grillaclientes" runat="server" class="table table-dark table-hover" OnSelectedIndexChanged="Grillaclientes_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    </tr>
                    
                </table>
            </div>
            <div class="col-5 bg-secondary ">
                <table widht="40%" align="center">
                    <br />
                    <tr style="margin-top: 10%;">
                        <td>
                            <asp:TextBox ID="Tbid" runat="server" class="form-control" placeholder="ID" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbcliente" runat="server" class="form-control" placeholder="Cliente"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbcodigo" runat="server" class="form-control" placeholder="Código"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DdlServicio" runat="server" AutoPostBack="True" class="form-control" OnSelectedIndexChanged="DdlServicio_SelectedIndexChanged" Width="100%"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbcosto" runat="server" class="form-control" placeholder="S/"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="Ddlcasillero" runat="server" class="form-control" AutoPostBack="True" Width="100%"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbfecha" runat="server" class="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbestado" runat="server" class="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btnguardar" runat="server" Text="Registrar" class="btn btn-success" Style="width: 50%;" BorderStyle="None" OnClick="Btnguardar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btnmodificar" runat="server" Text="Modificar" class="btn btn-warning" Style="width: 50%;" BorderStyle="None" OnClick="Btnmodificar_Click" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btnlimpiar" runat="server" Text="Limpiar" class="btn btn-warning" Style="width: 50%;" BorderStyle="None" Enabled="True" OnClick="Btnlimpiar_Click" />
                        </td>
                    </tr>
                </table>
                <br />
            </div>
        </div>
    </div>
    <div class="container-fluid bg-info pt-4">
        <table class="mx-auto">
            <td>
                <asp:GridView ID="Grillatickets" runat="server" class="table table-dark" OnSelectedIndexChanged="Grillatickets_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </table>
    </div>
</asp:Content>
