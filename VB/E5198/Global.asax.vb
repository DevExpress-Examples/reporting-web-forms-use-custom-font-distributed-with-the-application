Imports DevExpress.Utils.Serializing
Imports System
Imports System.Drawing
Imports System.Web

Namespace E5198

    Public Class [Global]
        Inherits HttpApplication

        Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Call PrintingSystemXmlSerializer.UnregisterConverter(GetType(Font))
            Call PrintingSystemXmlSerializer.RegisterConverter(New CustomFontConverter())
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize()
        End Sub

        Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
