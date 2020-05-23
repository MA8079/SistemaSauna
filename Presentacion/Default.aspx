﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MaestraDefault.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaPiscina.Presentacion.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div id="demo" class="carousel slide" data-ride="carousel" style="width:100%;height:80%;">

            <!-- Indicators -->
            <ul class="carousel-indicators">
                <li data-target="#demo" data-slide-to="0" class="active"></li>
                <li data-target="#demo" data-slide-to="1"></li>
                <li data-target="#demo" data-slide-to="2"></li>
            </ul>

            <!-- The slideshow -->
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="/Imagenes/SaunaSolo.jpg" alt="SaunaSolo" style="width:100%;height:80%;">
                </div>
                <div class="carousel-item">
                    <img src="/Imagenes/SaunaVapor.jpg" alt="SaunadeVapor" style="width:100%;height:80%;">
                </div>
                <div class="carousel-item">
                    <img src="/Imagenes/SaunaGrupo.jpg" alt="SaunaGrupo" style="width:100%;height:80%;">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="carousel-control-prev" href="#demo" data-slide="prev">
                <span class="carousel-control-prev-icon"></span>
            </a>
            <a class="carousel-control-next" href="#demo" data-slide="next">
                <span class="carousel-control-next-icon"></span>
            </a>

        </div>

    

</asp:Content>
