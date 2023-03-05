Imports DevExpress.Drawing
Imports DevExpress.Utils.Serializing
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.SessionState

Namespace E5198
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			Dim fontFilePath As String = HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf")
			Dim fontData() As Byte = System.IO.File.ReadAllBytes(fontFilePath)
			DXFontRepository.Instance.AddFont(fontData)

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
