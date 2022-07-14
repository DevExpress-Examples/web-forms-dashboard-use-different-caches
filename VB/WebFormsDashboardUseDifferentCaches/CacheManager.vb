Imports System
Imports System.Web

Namespace WebFormsDashboardUseDifferentCaches

    Public Class CacheManager

        Public Shared Sub ResetCache()
            If HttpContext.Current.Session IsNot Nothing Then HttpContext.Current.Session("UniqueCacheParam") = Guid.NewGuid()
        End Sub

        Public Shared ReadOnly Property UniqueCacheParam As Guid
            Get
                If HttpContext.Current.Session Is Nothing Then
                    Return Guid.Empty
                Else
                    If HttpContext.Current.Session("UniqueCacheParam") Is Nothing Then Call ResetCache()
                    Return CType(HttpContext.Current.Session("UniqueCacheParam"), Guid)
                End If
            End Get
        End Property
    End Class
End Namespace
