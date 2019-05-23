_Files to look at:_

- [Default.aspx.cs](/CS/WebFormsDashboardUseDifferentCaches/Default.aspx.cs) (VB: [Default.aspx.vb](/VB/WebFormsDashboardUseDifferentCaches/Default.aspx.vb))
- [CacheManager.cs](/CS/WebFormsDashboardUseDifferentCaches/CacheManager.cs) (VB: [CacheManager.vb](/VB/WebFormsDashboardUseDifferentCaches/CacheManager.vb))

# How to Reset the Cache Forcedly in Web Forms Dashboard

To refresh the data source cache on the server side, pass a unique parameter value to the [ASPxDashboard.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters) event.

For instance, you can store a unique GUID value within a session as a parameter and update its value in your code when it is necessary to refresh the cache.

Use the **Refresh Cache** button to update the cache forcedly.

Note that you can refresh the data source cache on the client side. For this, call the [ASPxClientDashboard.ReloadData](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_ASPxClientDashboard_ReloadData) or [DashboardControl.reloadData](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl#js_DevExpress_Dashboard_DashboardControl_reloadData) client methods.

See [Manage an In-Memory Data Cache](https://docs.devexpress.com/Dashboard/400984) for details.
