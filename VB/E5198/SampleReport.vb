Imports System.Drawing

Namespace E5198

    Public Partial Class SampleReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            customFontStyle.Font = New Font(GetFamily("Miss Fajardose"), 48F, FontStyle.Regular, GraphicsUnit.Point)
        End Sub
    End Class
End Namespace
