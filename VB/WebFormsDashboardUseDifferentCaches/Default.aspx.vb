Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DashboardCommon

Namespace WebFormsDashboardUseDifferentCaches

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardFileStorage As DashboardFileStorage = New DashboardFileStorage("~/App_Data/Dashboards")
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)
            ' Uncomment this string to allow end users to create new data sources based on predefined connection strings.
            'ASPxDashboard1.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());
            Dim dataSourceStorage As DataSourceInMemoryStorage = New DataSourceInMemoryStorage()
            ' Registers an SQL data source.
            Dim sqlDataSource As DashboardSqlDataSource = New DashboardSqlDataSource("SQL Data Source", "NWindConnectionString")
            Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("SalesPerson").SelectAllColumns().Build("Sales Person")
            sqlDataSource.Queries.Add(query)
            dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml())
            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)
        End Sub

        Protected Sub ASPxDashboard1_DataSourceCacheKeyCreated(ByVal sender As Object, ByVal e As DataSourceCacheKeyCreatedEventArgs)
            e.Key.CustomData.Add("SessionId", CacheManager.UniqueCacheParam.ToString())
        End Sub

        Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            CacheManager.ResetCache()
        End Sub
    End Class
End Namespace
