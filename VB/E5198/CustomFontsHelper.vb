Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Web

Namespace E5198
	Public Module CustomFontsHelper

'INSTANT VB NOTE: The variable fontCollection was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private fontCollection_Renamed As PrivateFontCollection
		Public ReadOnly Property FontCollection() As FontCollection
			Get
				If fontCollection_Renamed Is Nothing Then
					fontCollection_Renamed = New PrivateFontCollection()
					fontCollection_Renamed.AddFontFile(HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf"))
				End If
				Return fontCollection_Renamed
			End Get
		End Property

		Public Function GetFamily(ByVal familyName As String) As FontFamily
			Return FontCollection.Families.FirstOrDefault(Function(ff) ff.Name = familyName)
		End Function
	End Module
End Namespace
