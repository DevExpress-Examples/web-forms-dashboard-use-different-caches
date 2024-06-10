using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Sql;
using DevExpress.DashboardCommon;

namespace WebFormsDashboardUseDifferentCaches {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);

            // Uncomment this string to allow end users to create new data sources based on predefined connection strings.
            //ASPxDashboard1.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());

            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            // Registers an SQL data source.
            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("SQL Data Source", "NWindConnectionString");
            SelectQuery query = SelectQueryFluentBuilder
                .AddTable("SalesPerson")
                .SelectAllColumns()
                .Build("Sales Person");
            sqlDataSource.Queries.Add(query);
            dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml());

            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage);
        }

        protected void ASPxDashboard1_DataSourceCacheKeyCreated(object sender, DataSourceCacheKeyCreatedEventArgs e) {
            e.Key.CustomData.Add("SessionId", CacheManager.UniqueCacheParam.ToString());
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            CacheManager.ResetCache();
        }
    }
}