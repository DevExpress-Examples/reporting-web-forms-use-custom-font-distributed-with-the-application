Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Web

Namespace E5198
	Public Module CustomFontsHelper

'INSTANT VB NOTE: The field fontCollection was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private fontCollection_Conflict As PrivateFontCollection
		Public ReadOnly Property FontCollection() As FontCollection
			Get
				If fontCollection_Conflict Is Nothing Then
					fontCollection_Conflict = New PrivateFontCollection()
					fontCollection_Conflict.AddFontFile(HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf"))
				End If
				Return fontCollection_Conflict
			End Get
		End Property

		Public Function GetFamily(ByVal familyName As String) As FontFamily
			Return FontCollection.Families.FirstOrDefault(Function(ff) ff.Name = familyName)
		End Function
	End Module
End Namespace
