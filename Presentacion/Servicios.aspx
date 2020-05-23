<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MaestraDefault.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="SistemaPiscina.Presentacion.Servicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="demo" class="carousel slide" data-ride="carousel">
        <ul class="carousel-indicators">
            <li data-target="#demo" data-slide-to="0" class="active"></li>
            <li data-target="#demo" data-slide-to="1"></li>
            <li data-target="#demo" data-slide-to="2"></li>
        </ul>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="/Imagenes/VaporSauna.jpg" alt="Sauna de Vapor" width="100%" height="80%">
                <div class="carousel-caption">
                    <h3>Sauna de Vapor</h3>
                    
                </div>
            </div>
            <div class="carousel-item">
                <img src="/Imagenes/Piscina.jpg" alt="piscina" width="100%" height="80%">
                <div class="carousel-caption">
                    <h3>Piscina</h3>
                    
                </div>
            </div>
            <div class="carousel-item">
                <img src="/Imagenes/Hidromasaje.png" alt="Hidromasaje" width="100%" height="80%">
                <div class="carousel-caption">
                    <h3>Hidromasaje</h3>
                    
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#demo" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </a>
        <a class="carousel-control-next" href="#demo" data-slide="next">
            <span class="carousel-control-next-icon"></span>
        </a>
    </div>


</asp:Content>
