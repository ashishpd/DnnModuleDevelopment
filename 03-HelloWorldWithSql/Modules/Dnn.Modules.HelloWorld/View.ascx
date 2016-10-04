<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Dnn.Modules.HelloWorld.View" %>
<asp:Panel runat="server">
    Task:
    <asp:TextBox runat="server" ID="txtTask"></asp:TextBox>
    <br/>
    <asp:Button runat="server" ID="btnCreate" Text="Create Task" OnClick="btnCreate_OnClick"/>
    <br/>
    Current Tasks:
    <asp:Label runat="server" ID="lblTasks"/>
</asp:Panel>