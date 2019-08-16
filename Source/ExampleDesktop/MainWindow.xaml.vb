Option Strict on
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer
		Dim myDouble As Double


		' code here

		myInteger = Integer.Parse(InputTextBox.Text,NumberStyles.Any)
		myDouble = Double.Parse (InputTextBox.Text, NumberStyles.Any)

		OutputToScreen("--Integer------")
		OutputToScreen(myInteger.ToString())
		OutputToScreen("--Double------")
		OutputToScreen(myDouble.ToString())

		OutputBlankLine()


	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		
		Dim myDouble As Double
		

		
			If Double.TryParse(InputTextBox.Text, myDouble) Then
				OutputToScreen(myDouble.ToString())
			Else
			OutputToScreen ("Cannot parse that value.  Try again.")
			End If

		

	

	End Sub



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
		Clear()
	End Sub

	Private Sub Clear()
		MessageTextBox.Text = ""
	End Sub
End Class