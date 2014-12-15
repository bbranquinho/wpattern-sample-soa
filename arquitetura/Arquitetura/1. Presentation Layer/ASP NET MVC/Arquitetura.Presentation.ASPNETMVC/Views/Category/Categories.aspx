<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Arquitetura.Presentation.ASPNETMVC.CategoryService.Category>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Categories
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Categories</h2>

    <table>
        <tr>
            <th></th>
            <th>
                CategoryID
            </th>
            <th>
                CategoryName
            </th>
            <th>
                Description
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.CategoryID }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.CategoryID })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.CategoryID })%>
            </td>
            <td>
                <%: item.CategoryID %>
            </td>
            <td>
                <%: item.CategoryName %>
            </td>
            <td>
                <%: item.Description %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

