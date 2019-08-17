Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim computerName As String
		computerName = "Webserver14"
		Dim outputText = "The current computer name is " + computerName
		OutputToScreen(outputText)

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim x As Double
		x = 6
		' breakpoints cannot be set on comments
		' Or other non-runnable lines
		Dim y As Double = 7
		Dim result As String
		Dim fraction As Double = x / 5
		result = $"Your answer is {fraction}"

	End Sub

#Region "Output Methods"

	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub

	Sub OutputLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub
#End Region
End Class