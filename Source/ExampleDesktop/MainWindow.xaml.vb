Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim myDate1 = #3/3/1953#
		Dim myDate2 = New Date(1963, 4, 4)
		Dim myTime1 As Date = #5:06:10 PM#

		' more readable with named parameters

		Dim myDate3 = New Date(year:=1974, month:=4, day:=5)
		Dim myTime2 = New Date(year:=2007, month:=2, day:=27, hour:=16, minute:=30, second:=55)
		' code here

		' current date-time
		Dim currentDate = DateTime.Now

		OutputToScreen($"myDate1: {myDate1}")
		OutputToScreen($"myDate2: {myDate2}")
		OutputToScreen($"myDate3: {myDate3}")
		OutputLine()
		OutputToScreen($"currentDate: {currentDate}")
		OutputLine()
		OutputToScreen($"myTime2: {myTime1}")
		OutputToScreen($"myTime2: {myTime2}")
		OutputToScreen($"myTime2 Formatted: {myTime2.ToLongTimeString}")

		OutputBlankLine()

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

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

	Private Sub ButtonC_Click(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
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

		Dim numberDays As TimeSpan ' the distance between dates
		OutputToScreen("Original Date: " + startDate.ToLongDateString)
		Dim newDate = startDate.AddDays(5)
		OutputToScreen("Add Days: " + newDate.ToLongDateString)
		numberDays = endDate.Subtract(startDate)

		OutputToScreen("Days between: " + numberDays.TotalDays.ToString)
		'OutputToScreen("Months between: " + numberDays.TotalDays)
		'OutputToScreen("Days between: " + numberDays.Days)
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