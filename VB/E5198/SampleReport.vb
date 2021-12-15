Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Text


Namespace E5198
	Partial Public Class SampleReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()

			customFontStyle.Font = New Font(FontCollection.Families(0), 48F, FontStyle.Regular, GraphicsUnit.Point)
		End Sub

		Private Shared fontCollection_Renamed As PrivateFontCollection
		Public Shared ReadOnly Property FontCollection() As FontCollection
			Get
				If fontCollection_Renamed Is Nothing Then
					fontCollection_Renamed = New PrivateFontCollection()
					fontCollection_Renamed.AddFontFile(HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf"))
				End If
				Return fontCollection_Renamed
			End Get
		End Property
	End Class
End Namespace
