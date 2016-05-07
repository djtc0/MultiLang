<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultiLangPrj.WebForm1" %>
<%@ Import Namespace="Resources" %>
<%@ Register Src="~/Controls/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <a href="WebForm2.aspx">WebForm2.aspx</a><br /><br />
    <asp:Label ID="Label1" Text="<%$Resources:Resource, String1 %>" runat="server" Font-Bold="true" />
    <br />
    <br />
    <span><%=Resources.Resource.String1 %></span>
     <br />
    <br />
    <span><%=Resource.String1 %></span>
    <br />
    <br />
    Literal:
    <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resource, String1 %>"></asp:Literal>
    
     
    <%--Não funciona--%>
    <%--<br />
    <br />
    Literal3:
    <asp:Literal ID="Literal3" runat="server" Text="<%=Resources.Resource.String1 %>"></asp:Literal>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
</asp:Content>
