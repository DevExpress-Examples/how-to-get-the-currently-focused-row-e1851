Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Wpf.Grid

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

    Public Class MyView
        Inherits TableView
        Public Shared ReadOnly FocusedRowProperty As DependencyProperty = _
        DependencyProperty.Register("FocusedRow", GetType(Object), GetType(MyView), _
                                    New UIPropertyMetadata(Nothing, AddressOf FocusedRowChangedCallback))

        Private Shared Sub FocusedRowChangedCallback(ByVal d As DependencyObject, _
                                               ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, MyView).OnFocusedRowChanged()
        End Sub

        Public Shadows Property FocusedRow() As Object
            Get
                Return GetValue(FocusedRowProperty)
            End Get
            Set(ByVal value As Object)
                SetValue(FocusedRowProperty, value)
            End Set
        End Property

        Public Sub New()
            AddHandler FocusedRowChanged, AddressOf OnFocusedRowChanged
        End Sub

        Private Sub OnFocusedRowChanged()
            FocusedRowHandle = Grid.DataController.FindRowByRowValue(FocusedRow)
        End Sub

        Private Sub OnFocusedRowChanged(ByVal sender As Object, _
                                        ByVal e As FocusedRowChangedEventArgs)
            FocusedRow = Grid.GetRow(FocusedRowHandle)
        End Sub
    End Class
End Namespace
