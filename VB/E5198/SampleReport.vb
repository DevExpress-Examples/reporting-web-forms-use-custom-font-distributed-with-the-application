Imports DevExpress.Drawing
Imports System.Drawing

Namespace E5198

    Public Partial Class SampleReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            customFontStyle.Font = New DXFont("Miss Fajardose", 48F, DXFontStyle.Regular, DXGraphicsUnit.Point)
        End Sub
    End Class
End Namespace
