<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Default.aspx.cs" Inherits="WebFormsDashboardUseDifferentCaches.Default" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Dashboard.v19.1.Web.WebForms, Version=19.1.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function onBeforeRender(sender) {
        var control = sender.GetDashboardControl();
        control.registerExtension(new DevExpress.Dashboard.DashboardPanelExtension(control, { dashboardThumbnail: "./Content/DashboardThumbnail/{0}.png" }));
    }
</script>
    <div style="position: absolute; top: 0; left: 0">
        <dx:ASPxButton runat="server" Text="Reset Cache" OnClick="ASPxButton1_Click"></dx:ASPxButton>
        </div>
    <div style="position: absolute; top: 33px; bottom: 0; right: 0; left: 0; border-top: 1px solid #cfcfcf">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" Width="100%" Height="100%" UseNeutralFilterMode="true" ondataloading="DataLoading">
            <ClientSideEvents BeforeRender="onBeforeRender" />
        </dx:ASPxDashboard>
    </div>
</asp:Content>