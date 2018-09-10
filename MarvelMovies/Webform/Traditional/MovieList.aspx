<%@ Page Title="MovieList" Language="C#" MasterPageFile="~/Webform/Site.Master" AutoEventWireup="true" CodeBehind="MovieList.aspx.cs" Inherits="MarvelMovies.Webform.Traditional.MovieList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%: Scripts.Render("~/bundles/tr") %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MovieContext %>" SelectCommand="SELECT * FROM [Movies]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>

        <h2 id="table-name">WebForm(SqlDataSource)</h2>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No Movies Data</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <ItemTemplate>
                <tr>
                    <td class="movie-overview-wrapper" id="movie-<%# Eval("ID") %>">

                        <div class="movie-overview">
                            <div class="poster-wrapper">
                                <img class="poster" src="/Images/<%# Eval("Poster") %>" width="100" />
                            </div>
                            <div class="movie-title">
                                <%# Eval("Title") %>  (<%# Eval("Released.Year") %>)
                            </div>
                        </div>
                    </td>

                    <td class="movie-extra">
                        <%# Eval("Director") %>
                    </td>
                    <td class="movie-extra">
                        <div class="plot">
                            <%# Eval("Plot") %>
                        </div>
                    </td>
                    <td class="movie-extra">
                        <%# Eval("ImdbRating") %>(<%# Eval("ImdbVotes") %>)
                    </td>
                    <td class="movie-extra">
                        <%# Eval("ImdbID") %>
                    </td>

                </tr>
            </ItemTemplate>
            <LayoutTemplate>

                <table id="itemPlaceholderContainer" runat="server" class="table movie-list-table">
                    <tr runat="server" class="movie-header">
                        <th runat="server">Movie</th>
                        <th runat="server">Director</th>
                        <th runat="server">Plot</th>
                        <th runat="server">ImdbRating</th>
                        <th runat="server">ImdbID</th>
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>

            </LayoutTemplate>

        </asp:ListView>
</asp:Content>
