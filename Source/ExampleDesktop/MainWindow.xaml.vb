Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = 43218765
		Dim myLong As Long = 9988776655

		OutputToScreen("--No format--")
		' code here

		OutputBlankLine()
		OutputToScreen("--Number------")
		' code here

		OutputBlankLine()
		OutputToScreen("--Exponent-------")
		' code here

		OutputBlankLine()
		OutputToScreen("--Currency--------")
		' code here

		OutputBlankLine()
		OutputToScreen("--Hexadecimal--------")
		' code here


#Region "Learn More"
		' learn more about format strings
		'	https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
#End Region
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click


		OutputToScreen("--Date--------")
		' code here


#Region "Learn More"
		' learn more about data format strings
		' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
#End Region

	End Sub



	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text += vbCrLf
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