Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles GoButton.Click
		' Add code here
		Dim counter As Integer = 22
		ShowResults(counter)
	End Sub
	Sub ShowResults(message As string)
		MessageTextBox.Text = message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
			MessageTextBox.Text = ""
	End Sub
End Class
