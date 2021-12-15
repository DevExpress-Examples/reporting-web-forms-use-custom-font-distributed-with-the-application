Imports System.Drawing


Namespace E5198
	Partial Public Class SampleReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()

			customFontStyle.Font = New Font(CustomFontsHelper.GetFamily("Miss Fajardose"), 48F, FontStyle.Regular, GraphicsUnit.Point)
		End Sub
	End Class
End Namespace
