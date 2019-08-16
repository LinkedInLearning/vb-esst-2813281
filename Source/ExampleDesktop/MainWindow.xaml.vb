Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim myDate1 = #3/3/1953#
		Dim myDate2 = New Date(1963,4,4)
		Dim myTime As Date = #5:06:10 PM#



		' code here

		OutputToScreen("--Integer------")
		OutputToScreen(myInteger)
		OutputToScreen("--Double------")
		OutputToScreen(myDouble.ToString())

		OutputBlankLine()

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim myDouble As Double
		
			' code here
		

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