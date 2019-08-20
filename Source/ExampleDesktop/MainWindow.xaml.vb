Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub ForDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		For index = 1 To 10
			OutputToScreen(index)
		Next

	End Sub

	Private Sub StepDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		For index = 0 To 200 Step 5
			OutputToScreen(index)
		Next

	End Sub

	Private Sub DownDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

		For index = 100 To 50 Step -5
			OutputToScreen(index)
		Next


	End Sub

		Private Sub ButtonD_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click

		End Sub

	Private Sub NestedDraw1(sender As Object, e As RoutedEventArgs) Handles ButtonF.Click
		For x = 100 To 400 Step 30
			For y = 360 To 480 Step 20
				Dim point As New Point(x, y)
				polyline1.Points.Add(point)
			Next
		Next
	End Sub

	Private Sub NestedDraw2(sender As Object, e As RoutedEventArgs) Handles ButtonG.Click
		For x = 450 To 750 Step 40
			For y = 360 To 480 Step 20
				Dim point As New Point(x, y + (60 * Math.Sin(x)))
				polyline2.Points.Add(point)
			Next
		Next
	End Sub
	Public Sub OutputToScreen(message As String)
		OutputTextBox.Text &= message & vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputTextBox.Text = ""

	End Sub


End Class