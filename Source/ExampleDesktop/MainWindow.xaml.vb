Option Strict Off

Class MainWindow

	Private Async Sub NewDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		Dim colorNamesArray(20) As String
		Dim oddNumbersArray(10) As Integer

		Dim colorNamesList As New List(Of String)
		Dim oddNumbersList = New List(Of Integer)

		colorNamesArray(3) = "Blue"

		ReDim colorNamesArray(30)

	End Sub

	Public Sub OutputToScreen(message As String)
		OutputList.Items.Insert(0, message)
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.Items.Clear()

	End Sub

End Class