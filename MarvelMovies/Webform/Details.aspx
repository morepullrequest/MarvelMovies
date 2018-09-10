<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="MarvelMovies.Webform.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%: Scripts.Render("~/bundles/mb") %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:FormView ID="movieDetail" runat="server"
            ItemType="MarvelMovies.Models.Movie"
            SelectMethod="GetMovie"
            RenderOuterTable="false">
            <EmptyDataTemplate>
                Empty
            </EmptyDataTemplate>
            <ItemTemplate>
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="/Webform/MovieList.aspx">WebForm(Model binding)</a></li>
                    <li class="breadcrumb-item active"><%#: Item.Title %></li>
                </ol>
                <div class="detail-container">

                    <img class="detail-poster" src="/Images/<%#: Item.Poster %>" />

                    <dl class="dl-horizontal">
                        <dt>Title
                        </dt>

                        <dd><%#: Item.Title %>
                        </dd>
                        <dt>Rated
                        </dt>

                        <dd><%#: Item.Rated %>
                        </dd>

                        <dt>Released Date
                        </dt>

                        <dd><%#: Item.Released %>
                        </dd>

                        <dt>Runtime
                        </dt>

                        <dd><%#: Item.Runtime %>
                        </dd>

                        <dt>Genre
                        </dt>

                        <dd><%#: Item.Genre %>
                        </dd>

                        <dt>Director
                        </dt>

                        <dd><%#: Item.Director %>
                        </dd>

                        <dt>Actors
                        </dt>

                        <dd><%#: Item.Actors %>
                        </dd>

                        <dt>Plot
                        </dt>

                        <dd><%#: Item.Plot %>
                        </dd>

                        <dt>IMDB Rating
                        </dt>

                        <dd><%#: Item.ImdbRating %>/10 (<%#: Item.ImdbVotes %>)
                        </dd>


                        <dt>Imdb ID
                        </dt>

                        <dd>
                            <a href="https://www.imdb.com/title/<%#: Item.ImdbID %>"><%#: Item.ImdbID %></a>
                        </dd>
                    </dl>
                </div>
            </ItemTemplate>
        </asp:FormView>
    </form>
</asp:Content>
