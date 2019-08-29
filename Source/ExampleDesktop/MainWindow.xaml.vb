Option Strict Off

Class MainWindow




	Private Sub FileOpen(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		FileATextBox.Text = ErrorMaker.OpenFile(System.AppDomain.CurrentDomain.BaseDirectory & "\example.txt")


	End Sub


	Private Sub FileException(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


		FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")

	End Sub

	Private Sub DivisionException(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

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