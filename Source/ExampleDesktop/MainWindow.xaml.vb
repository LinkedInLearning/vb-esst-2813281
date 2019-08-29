Option Strict Off

Class MainWindow
	Dim _counter As Integer = 0
	Private Sub Catch1Demo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		_counter += 1
		FileATextBox.Text = _counter
		FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")




	End Sub

	Private Sub Catch2Demo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		_counter += 1
		FileATextBox.Text = _counter

		FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")

	End Sub

	Private Sub Catch3Demo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		_counter += 1
		FileATextBox.Text = _counter
		FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
		Dim result = ErrorMaker.WorkWithNumbers(7)

	End Sub

#Region "Output"
	Public Sub OutputToScreen(message As String)

	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()


		FileATextBox.Text = ""
		FileBTextBox.Text = ""

	End Sub

#End Region
End Class