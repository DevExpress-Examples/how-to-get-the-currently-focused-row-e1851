Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Xpf.Grid

Namespace DXGrid_FocusedRow

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 99
				list.Add(New TestData() With {.Number1 = i, .Number2 = i * 10, _
				.Text1 = "row " & i, .Text2 = "ROW " & i})
			Next i

			DataContext = list
		End Sub
	End Class

	Public Class TestData
		Private privateNumber1 As Integer
		Public Property Number1() As Integer
			Get
				Return privateNumber1
			End Get
			Set(ByVal value As Integer)
				privateNumber1 = value
			End Set
		End Property
		Private privateNumber2 As Integer
		Public Property Number2() As Integer
			Get
				Return privateNumber2
			End Get
			Set(ByVal value As Integer)
				privateNumber2 = value
			End Set
		End Property
		Private privateText1 As String
		Public Property Text1() As String
			Get
				Return privateText1
			End Get
			Set(ByVal value As String)
				privateText1 = value
			End Set
		End Property
		Private privateText2 As String
		Public Property Text2() As String
			Get
				Return privateText2
			End Get
			Set(ByVal value As String)
				privateText2 = value
			End Set
		End Property
	End Class

End Namespace
