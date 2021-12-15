Imports System.Web
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Text

Namespace E5198

    Public Partial Class SampleReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            customFontStyle.Font = New Font(FontCollection.Families(0), 48F, FontStyle.Regular, GraphicsUnit.Point)
        End Sub

        Private Shared fontCollectionField As PrivateFontCollection

        Public Shared ReadOnly Property FontCollection As FontCollection
            Get
                If fontCollectionField Is Nothing Then
                    fontCollectionField = New PrivateFontCollection()
                    fontCollectionField.AddFontFile(HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf"))
                End If

                Return fontCollectionField
            End Get
        End Property
    End Class
End Namespace
