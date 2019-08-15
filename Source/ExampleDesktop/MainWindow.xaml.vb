Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myLong As Long = Long.MaxValue

		'Dim targetInteger As Integer
		'Dim targetLong As Long




	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myLong As Long = Long.MaxValue

		Dim targetInteger As Integer
		Dim targetLong As Long

		' add explicit conversion to long


		OutputToScreen(targetLong)

		' add explicit conversion to integer


		OutputToScreen(targetInteger)

	End Sub

	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click
		

	End Sub

	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Sub OutputFormattedToScreen(message As String, number As Object)
		Dim formatted As IFormattable = number
		'Dim newString = formatted.ToString("G", Nothing)
		MessageTextBox.Text += $"{message} {formatted.ToString("N0", Nothing)}{vbCrLf}"
	End Sub

	Sub OutputLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

End Class