Imports System.Drawing
Imports DevExpress.Drawing

Namespace E5198
	Partial Public Class SampleReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()

			customFontStyle.Font = New DXFont("Miss Fajardose", 48.0F, DXFontStyle.Regular, DXGraphicsUnit.Point)
		End Sub
	End Class
End Namespace
