Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = 43218765
		Dim myLong As Long = 9988776655
		

		OutputToScreen("--No format--")
		OutputToScreen(myInteger)
		OutputToScreen(myLong)
		OutputBlankLine()

		OutputToScreen("--Number------")
		OutputToScreen(myInteger.ToString("N"))
		OutputToScreen(myLong.ToString("N"))
		OutputBlankLine()

		OutputToScreen("--Exponent-------")
		OutputToScreen(myInteger.ToString("E"))
		OutputToScreen(myLong.ToString("E"))
		OutputBlankLine()

		OutputToScreen("--Currency--------")
		OutputToScreen(myInteger.ToString("C"))
		OutputToScreen(myLong.ToString("C"))
		OutputBlankLine
		Dim myByte As Byte = 127
	
		OutputToScreen("--Hexadecimal--------")
		OutputToScreen(myByte)
		OutputToScreen(myByte.ToString("X"))
		

		' learn more about format strings
		'	https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		
		Dim myDate As Date = #10/21/2025#
		OutputToScreen("--Date--------")
		OutputToScreen(myDate)
		OutputToScreen(myDate.ToString("D"))

		' learn more about data format strings
		' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings

	End Sub

	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click


	End Sub

	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text +=  vbCrLf
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