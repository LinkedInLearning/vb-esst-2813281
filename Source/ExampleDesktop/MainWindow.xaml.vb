Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myLong As Long = Long.MaxValue

		Dim targetInteger As Integer
		Dim targetLong As Long

		targetLong = myInteger
		OutputToScreen(targetLong)

		Try
			targetInteger = myLong
		Catch ex As Exception

			OutputToScreen(ex.Message)
		End Try

		OutputToScreen(targetInteger)


	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myLong As Long = Long.MaxValue

		Dim targetInteger As Integer
		Dim targetLong As Long

		targetLong = CLng(myInteger) ' widening
		targetLong = Convert.ToInt64(myInteger)
		OutputToScreen(targetLong)

		If myLong < Integer.MaxValue And myLong > Integer.MinValue Then
			targetInteger = CInt(600) ' narrowing
			targetInteger = Convert.ToInt32(myLong) ' narrowing
		End If

		OutputToScreen(targetInteger)

	End Sub

	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click
		' ranges of data types
		OutputToScreen($"Byte Max: {Byte.MaxValue}")
		OutputToScreen($"Byte Min: {Byte.MinValue}")
		OutputLine()

		OutputFormattedToScreen($"Short Max:", Short.MaxValue)
		OutputFormattedToScreen($"Short Min:", Short.MinValue)
		OutputLine()

		OutputFormattedToScreen($"Integer Max:", Integer.MaxValue)
		OutputFormattedToScreen($"Integer Min:", Integer.MinValue)
		OutputLine()

		OutputFormattedToScreen($"Long Max:", Long.MaxValue)
		OutputFormattedToScreen($"Long Min:", Long.MinValue)
		OutputLine()

		OutputFormattedToScreen($"UShort Max:", UShort.MaxValue)
		OutputToScreen($"UShort Min: {UShort.MinValue}")
		OutputLine()

		OutputFormattedToScreen($"UInteger Max:", UInteger.MaxValue)
		OutputToScreen($"UInteger Min: {UInteger.MinValue}")
		OutputLine()

		OutputFormattedToScreen($"ULong Max:", ULong.MaxValue)
		OutputToScreen($"ULong Min: {ULong.MinValue}")
		OutputLine()
		OutputToScreen($"Single Max: {Single.MaxValue}")
		OutputToScreen($"Single Min: {Single.MinValue}")
		'	OutputFormattedToScreen($"Single Max:", Single.MaxValue)
		OutputLine()

		OutputToScreen($"Double Max: {Double.MaxValue}")
		OutputToScreen($"Double Min: {Double.MinValue}")
		OutputLine()

		OutputFormattedToScreen($"Decimal Max:", Decimal.MaxValue)
		OutputFormattedToScreen($"Decimal Min:", Decimal.MinValue)

		OutputLine()

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