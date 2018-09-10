<%@ Page Title="MovieList" Language="C#" MasterPageFile="~/Webform/Site.Master" AutoEventWireup="true" CodeBehind="MovieList.aspx.cs" Inherits="MarvelMovies.Webform.MovieList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%: Scripts.Render("~/bundles/mb") %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 id="table-name">WebForm(Model Binding)</h2>
    <table class="table movie-list-table">
        <tr class="movie-header">
            <th>Movie</th>
            <th>Director</th>
            <th>Plot</th>
            <th>ImdbRating</th>
            <th>ImdbID</th>
        </tr>
        <asp:ListView ID="movieList" runat="server"
            DataKeyNames="ID"
            ItemType="MarvelMovies.Models.Movie"
            SelectMethod="GetMovies">

            <EmptyDataTemplate>
                <tr>
                    <td>No data was returned</td>
                </tr>
            </EmptyDataTemplate>
            <ItemTemplate>
                <tr>
                    <td class="movie-overview-wrapper" id="movie-<%#: Item.ID %>">
                        <div class="movie-overview">
                            <div class="poster-wrapper">
                                <img class="poster" src="/Images/<%#:Item.Poster %>" width="100" />
                            </div>
                            <div class="movie-title">
                                <%#: Item.Title%>  (<%#: Item.Released.Year %>)
                            </div>
                        </div>
                    </td>
                    <td class="movie-extra">
                        <%#:Item.Director %>
                    </td>
                    <td class="movie-extra">
                        <div class="plot">
                            <%#:Item.Plot %>
                        </div>
                    </td>
                    <td class="movie-extra">
                        <%#: Item.ImdbRating %>(<%#: Item.ImdbVotes%>)
                    </td>
                    <td class="movie-extra">
                        <%#:Item.ImdbID %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </table>
</asp:Content>
