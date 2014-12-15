<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Arquitetura.Presentation.ASPNETMVC.CategoryService.Category>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">CategoryID</div>
        <div class="display-field"><%: Model.CategoryID %></div>
        
        <div class="display-label">CategoryName</div>
        <div class="display-field"><%: Model.CategoryName %></div>
        
        <div class="display-label">Description</div>
        <div class="display-field"><%: Model.Description %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

