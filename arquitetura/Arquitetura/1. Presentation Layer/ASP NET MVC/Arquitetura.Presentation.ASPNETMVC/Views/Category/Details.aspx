<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Arquitetura.Presentation.ASPNETMVC.CategoryService.Category>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">CategoryID</div>
        <div class="display-field"><%: Model.CategoryID %></div>
        
        <div class="display-label">CategoryName</div>
        <div class="display-field"><%: Model.CategoryName %></div>
        
        <div class="display-label">Description</div>
        <div class="display-field"><%: Model.Description %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.CategoryID }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

