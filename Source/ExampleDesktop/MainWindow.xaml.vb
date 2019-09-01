Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		Dim startDate As Date
		Dim interval As integer
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			OutputToScreen("Cannot parse the start date.")
			Exit Sub
		End If
		If Integer.TryParse(IntervalTextBox.Text, interval) = False Then

			OutputToScreen("Cannot parse the interval.")
			Exit Sub
		End If

		
		OutputToScreen("Original Date: " + startDate.ToLongDateString)
		OutputToScreen("Number of days and months to add: " + interval.ToString)
		Dim newDate = startDate.AddDays(interval).AddMonths(interval)
		OutputToScreen("Calculated End date: " + newDate.ToLongDateString)
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