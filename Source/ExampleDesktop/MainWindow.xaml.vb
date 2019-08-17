Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		' Challenge: Part 1
		' allow the user to choose the max value
		' by entering an integer in the NumberTextBox. 
		' Don't forget to validate the input 
		' from NumberTextBox to prevent non integer values.
		Dim maxValue As Integer

		If Integer.TryParse(NumberTextBox.Text, maxValue) = False Then
			OutputToScreen("Cannot parse value, try again.")
			Exit Sub

		End If
		Dim odd = GetRandomOddNumber(maxValue)

		OutputToScreen(odd)
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		' Challenge: Part 1
		' allow the user to choose the max value
		' by entering an integer in the NumberTextBox.
		' Don't forget to validate the input 
		' from NumberTextBox to prevent non integer values.
		Dim maxValue As Integer

		If Integer.TryParse(NumberTextBox.Text, maxValue) = False Then
			OutputToScreen("Cannot parse value, try again.")
			Exit Sub
		End If
		Dim even = GetRandomEvenNumber(maxValue)
		OutputToScreen(even)

	End Sub

	Private Sub RunCode3(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		' Challenge: Part 2
		' show a random squared value
		' when this button is clicked
		' when this button is clicked
		' 2, 4, 9, 16, 25, 36 etc.
		' reuse or refactor the code in Module NumberGenerator
		Dim maxValue As Integer

		If Integer.TryParse(NumberTextBox.Text, maxValue) = False Then
			OutputToScreen("Cannot parse value, try again.")
			Exit Sub
		End If
		Dim squared = GetRandomSquaredNumber(maxValue)
		OutputToScreen(squared)
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