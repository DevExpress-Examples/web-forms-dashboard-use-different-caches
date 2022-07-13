<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Default.aspx.cs" Inherits="WebFormsDashboardUseDifferentCaches.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function onBeforeRender(sender) {
        var control = sender.GetDashboardControl();
        control.registerExtension(new DevExpress.Dashboard.DashboardPanelExtension(control, { dashboardThumbnail: "./Content/DashboardThumbnail/{0}.png" }));
    }
</script>
    <div style="position: absolute; top: 5px; left: 5px">
        <dx:ASPxButton runat="server" Text="Reset Cache" OnClick="ASPxButton1_Click"></dx:ASPxButton>
    </div>
    <div style="position: absolute; top: 43px; bottom: 0; right: 0; left: 0; border-top: 1px solid #cfcfcf">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" OnCustomParameters="ASPxDashboard1_CustomParameters" 
            Width="100%" Height="100%">
            <ClientSideEvents BeforeRender="onBeforeRender" />
        </dx:ASPxDashboard>
    </div>
</asp:Content>