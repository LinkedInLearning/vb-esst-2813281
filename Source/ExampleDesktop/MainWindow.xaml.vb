Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub IfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim odd = GetRandomOddNumber(401)
		CurrentRandomOutput.Text = odd


		If odd < 100 Then
			LowNumberOutput.Text += odd.ToString() + vbCrLf
		End If
	End Sub

	Private Sub IfElseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim odd = GetRandomOddNumber(401)
		CurrentRandomOutput.Text = odd
		If odd < 100 Then
			LowNumberOutput.Text += odd.ToString() + vbCrLf
		Else
			OtherNumberOutput.Text += odd.ToString() + vbCrLf
		End If

	End Sub

	Private Sub IfElseIfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

		Dim odd = GetRandomOddNumber(401)
		CurrentRandomOutput.Text = odd
		If odd < 100 Then
			LowNumberOutput.Text += odd.ToString() + vbCrLf
		ElseIf odd > 300 Then
			HighNumberOutput.Text += odd.ToString() + vbCrLf

		Else
			OtherNumberOutput.Text += odd.ToString() + vbCrLf
		End If

	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		LowNumberOutput.Text = ""
		HighNumberOutput.Text = ""
		OtherNumberOutput.Text = ""
	End Sub






End Class