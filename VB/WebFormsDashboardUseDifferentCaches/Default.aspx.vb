Imports System
Imports System.Web.Hosting
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Excel
Imports DevExpress.DataAccess.Sql

Namespace WebFormsDashboardUseDifferentCaches
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
			ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)

			' Uncomment this string to allow end users to create new data sources based on predefined connection strings.
			'ASPxDashboard1.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());

			Dim dataSourceStorage As New DataSourceInMemoryStorage()

			' Registers an SQL data source.
			Dim sqlDataSource As New DashboardSqlDataSource("SQL Data Source", "NWindConnectionString")
			Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("SalesPerson").SelectAllColumns().Build("Sales Person")
			sqlDataSource.Queries.Add(query)
			dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml())

			' Registers an Object data source.
			Dim objDataSource As New DashboardObjectDataSource("Object Data Source")
			dataSourceStorage.RegisterDataSource("objDataSource", objDataSource.SaveToXml())

			' Registers an Excel data source.
			Dim excelDataSource As New DashboardExcelDataSource("Excel Data Source")
			excelDataSource.FileName = HostingEnvironment.MapPath("~/App_Data/Sales.xlsx")
			excelDataSource.SourceOptions = New ExcelSourceOptions(New ExcelWorksheetSettings("Sheet1"))
			dataSourceStorage.RegisterDataSource("excelDataSource", excelDataSource.SaveToXml())

			ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)

			AddHandler ASPxDashboard1.CustomParameters, AddressOf ASPxDashboard1_CustomParameters
		End Sub

		Private Sub ASPxDashboard1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
			e.Parameters.Add(New DashboardParameter("Param1",GetType(Guid),CacheManager.UniqueCacheParam))
		End Sub

		Protected Sub DataLoading(ByVal sender As Object, ByVal e As DataLoadingWebEventArgs)
			If e.DataSourceName = "Object Data Source" Then
				e.Data = Invoices.CreateData()
			End If
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			CacheManager.ResetCache()
		End Sub
	End Class
End Namespace