Imports DevExpress.Utils.Serializing
Imports System.Drawing

Namespace E5198

    Public Class CustomFontConverter
        Inherits PrintingSystemXmlSerializer.FontConverter

        Protected Overrides Function CreateObject(ByVal values As String()) As Object
            Dim font As Font = TryCast(MyBase.CreateObject(values), Font)
            If values.Length > 0 Then
                Dim fontFamily As FontFamily = GetFamily(values(0))
                If fontFamily IsNot Nothing Then Return New Font(fontFamily, font.Size, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont)
            End If

            Return font
        End Function
    End Class
End Namespace
