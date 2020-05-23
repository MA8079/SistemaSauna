<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Sistema.Master" AutoEventWireup="true" CodeBehind="Casilleros.aspx.cs" Inherits="SistemaPiscina.Presentacion.Casilleros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row ">
            <div class="col-4  bg-secondary" ">
                <div style="width:300px;" class="mx-auto">
                    <table  align="center" style="margin-top:30%;margin-bottom:10%;width:100%;">
                    
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbnumero" runat="server" class="form-control" placeholder="Número"  width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:TextBox ID="Tbestado" runat="server" class="form-control" placeholder="Estado"  width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td align="center">
                            <asp:Button ID="Btnguardar" runat="server" Text="Guardar" class="form-control bg-success" Font-Bold="True" ForeColor="White" width="100%" OnClick="Btnguardar_Click"/>
                        </td>
                    </tr>
                    
                </table>
                </div>
                
            </div>
            <div class="col-8 bg-success">
                <div style="width:400px" class="mx-auto">
                    <br />
                    <table class="table table-dark table-hover" style="width:100%;">
                        <tr>
                            <td>Acción</td>
                            <td>ID</td>
                            <td>Número</td>
                            <td>Estado</td>
                        </tr>
                    </table>
                </div>
                <div style="width:400px;height:300px;overflow:auto;" class="mx-auto">
                    <asp:GridView ID="Grillacasillero" runat="server" class="table table-dark table-hover" ShowHeader="False">
                       <Columns>
                          <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                       </Columns>
                    </asp:GridView>                        
                </div>
                <br />
            </div>
        </div>
    </div>
</asp:Content>
