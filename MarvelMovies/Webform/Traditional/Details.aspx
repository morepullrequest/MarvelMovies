<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="MarvelMovies.Webform.Traditional.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%: Scripts.Render("~/bundles/tr") %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:SqlDataSource
            ID="SqlDataSource1"
            runat="server"
            ConnectionString="<%$ ConnectionStrings:MovieContext %>"
            SelectCommand="SELECT * FROM [Movies] WHERE ([ID] = @ID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="ID" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <EmptyDataTemplate>
                Empty
            </EmptyDataTemplate>
            <ItemTemplate>
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="/Webform/Traditional/MovieList.aspx">WebForm(SqlDataSource)</a></li>
                    <li class="breadcrumb-item active"><%# Eval("Title") %></li>
                </ol>
                <div class="detail-container">
                    <img class="detail-poster" src="/Images/<%# Eval("Poster") %>" />
                    <dl class="dl-horizontal">
                        <dt>Title
                        </dt>

                        <dd><%# Eval("Title") %>
                        </dd>
                        <dt>Rated
                        </dt>

                        <dd><%# Eval("Rated") %>
                        </dd>

                        <dt>Released Date
                        </dt>

                        <dd><%# Eval("Released") %>
                        </dd>

                        <dt>Runtime
                        </dt>

                        <dd><%# Eval("Runtime") %>
                        </dd>

                        <dt>Genre
                        </dt>

                        <dd><%# Eval("Genre") %>
                        </dd>

                        <dt>Director
                        </dt>

                        <dd><%# Eval("Director") %>
                        </dd>

                        <dt>Actors
                        </dt>

                        <dd><%# Eval("Actors") %>
                        </dd>

                        <dt>Plot
                        </dt>

                        <dd><%# Eval("Plot") %>
                        </dd>

                        <dt>IMDB Rating
                        </dt>

                        <dd><%# Eval("ImdbRating") %>/10 (<%# Eval("ImdbVotes") %>)
                        </dd>


                        <dt>Imdb ID
                        </dt>

                        <dd>
                            <a href="https://www.imdb.com/title/<%# Eval("ImdbID") %>"><%# Eval("ImdbID") %></a>
                        </dd>
                    </dl>
                </div>
            </ItemTemplate>
        </asp:FormView>
    </form>
</asp:Content>
