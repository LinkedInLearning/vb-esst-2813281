Imports System.Runtime.CompilerServices

Class MainWindow


	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click


		Dim title As String = "Code explorer is a WPF application."
		OutputToScreen(title)

		Dim thisMessage As String = "I'll use for showing code examples. "
		OutputToScreen(thisMessage)


	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim counter As Integer = 15

		OutputToScreen(counter)
		OutputLine()
		counter += 12
		OutputToScreen(counter)

	End Sub


	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputLine()
		MessageTextBox.Text += "»-»-»-»-»-»-»-»-»-»-»-»" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
