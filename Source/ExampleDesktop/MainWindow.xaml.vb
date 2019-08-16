Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		' current date-time


		' more readable with named parameters



		'OutputToScreen($"literalDate: {literalDate}")
		'OutputToScreen($"parsedDate: {parsedDate}")
		'OutputToScreen($"fromDateClass: {fromDateClass}")

		'OutputLine()
		'OutputToScreen($"currentDate: {currentDate}")
		'OutputLine()

		'OutputToScreen($"readableDate: {readableDate}")
	End Sub
	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim literalTime As Date = #5:06:10 PM#
		' more readable with named parameters
		Dim fromDateClass = New Date(year:=2007, month:=2, day:=27, hour:=16, minute:=30, second:=55)

		OutputToScreen($"literalTime: {literalTime}")
		OutputToScreen($"fromDateClass: {fromDateClass}")
		OutputToScreen($"fromDateClass Formatted: {fromDateClass.ToLongTimeString}")

		OutputBlankLine()
	End Sub

	Private Sub RunCode3(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim startDate, endDate As Date
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			OutputToScreen("Cannot parse the start date.")
			Exit Sub
		End If
		If Date.TryParse(EndDateTextBox.Text, endDate) = False Then

			OutputToScreen("Cannot parse the end date.")
			Exit Sub
		End If

		OutputToScreen(startDate.ToLongDateString)
		OutputToScreen(endDate.ToShortDateString)

		OutputToScreen("custom date format: " + startDate.ToString("yyyy--MM--dd"))
		OutputToScreen($"EndDate, Day: {endDate.Day}")
		OutputToScreen($"EndDate, DayOfWeek: {endDate.DayOfWeek}")
		OutputToScreen($"EndDate, DayOfYear: {endDate.DayOfYear}")
		OutputToScreen($"EndDate, IsDaylightSaving: {endDate.IsDaylightSavingTime}")

	End Sub

	Private Sub RunCode4(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		' how many days between days
		Dim startDate, endDate As Date
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			OutputToScreen("Cannot parse the start date.")
			Exit Sub
		End If
		If Date.TryParse(EndDateTextBox.Text, endDate) = False Then

			OutputToScreen("Cannot parse the end date.")
			Exit Sub
		End If

		Dim myTimeSpan As TimeSpan ' the distance between dates
		OutputToScreen("Original Date: " + startDate.ToLongDateString)
		Dim newDate = startDate.AddDays(5)
		OutputToScreen("Add Days: " + newDate.ToLongDateString)
		myTimeSpan = endDate.Subtract(startDate)

		OutputToScreen("Days between: " + myTimeSpan.TotalDays.ToString)
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