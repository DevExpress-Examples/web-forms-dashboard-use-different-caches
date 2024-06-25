<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/188188660/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828692)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx.cs](/CS/WebFormsDashboardUseDifferentCaches/Default.aspx.cs) (VB: [Default.aspx.vb](/VB/WebFormsDashboardUseDifferentCaches/Default.aspx.vb))
* [CacheManager.cs](/CS/WebFormsDashboardUseDifferentCaches/CacheManager.cs) (VB: [CacheManager.vb](/VB/WebFormsDashboardUseDifferentCaches/CacheManager.vb))
<!-- default file list end -->

# Dashboard for Web Forms - How to Reset the Cache Forcedly in Web Forms Dashboard

To refresh the data source cache on the server side, pass a unique parameter value to the [ASPxDashboard.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters) event.

For instance, you can store a unique GUID value within a session as a parameter and update its value in your code when it is necessary to refresh the cache.

Use the **Refresh Cache** button to update the cache forcedly.

Note that you can refresh the data source cache on the client side. For this, call the [ASPxClientDashboard.ReloadData](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_ASPxClientDashboard_ReloadData) or [DashboardControl.reloadData](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl#js_DevExpress_Dashboard_DashboardControl_reloadData) client methods.

## Documentation

- [Manage an In-Memory Data Cache](https://docs.devexpress.com/Dashboard/400984)

## More Examples

- [Dashboard for MVC - How to Reset the Cache Forcedly in MVC Dashboard](https://github.com/DevExpress-Examples/mvc-dashboard-use-different-caches)
- [Dashboard for ASP.NET Core - How to Reset the Cache Forcedly in ASP.NET Core Dashboard](https://github.com/DevExpress-Examples/aspnet-core-dashboard-use-different-caches)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-dashboard-use-different-caches&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-dashboard-use-different-caches&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
