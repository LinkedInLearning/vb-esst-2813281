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
	Private Sub AndDemo(sender As Object, e As RoutedEventArgs) Handles ButtonE.Click

		If DayTextBox.Text = "Monday" And TimeTextBox.Text = "3:00" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
			PizzaAwardTextBox.Text += "Free Pizza!" + vbCrLf
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
			PizzaAwardTextBox.Text += "No Pizza, Here's a coupon." + vbCrLf
		End If

	End Sub

	Private Sub OrDemo(sender As Object, e As RoutedEventArgs) Handles ButtonG.Click
		If DayTextBox.Text = "Monday" Or TimeTextBox.Text = "3:00" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
			PizzaAwardTextBox.Text += "Free Pizza!" + vbCrLf
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
			PizzaAwardTextBox.Text += "No Pizza, Here's a coupon." + vbCrLf
		End If
	End Sub



	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		LowNumberOutput.Text = ""
		HighNumberOutput.Text = ""
		OtherNumberOutput.Text = ""
	End sub

	Private Async Sub AndSlow(sender As Object, e As RoutedEventArgs) Handles ButtonH.Click
		SlowMessageTextBlock.Text = "processing..."
		If IsNetWorkAvailable() And Await IsDatabaseOnline() Then
			SlowMessageTextBlock.Text = "And: Can access database."
		Else
			SlowMessageTextBlock.Text = "And: Cannot access database."
		End If
	End Sub

	Private Async Sub AndAlsoSlow(sender As Object, e As RoutedEventArgs) Handles ButtonJ.Click
		SlowMessageTextBlock.Text = "processing..."
		If IsNetWorkAvailable() AndAlso Await IsDatabaseOnline() Then
			SlowMessageTextBlock.Text = "AndAlso: Can access database."
		Else
			SlowMessageTextBlock.Text = "AndAlso: Cannot access database."
		End If
	End Sub


End Class