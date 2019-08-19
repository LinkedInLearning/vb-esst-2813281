Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub IfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim odd = GetRandomOddNumber(401)
		CurrentNumberTextBlock.Text = odd
		If odd < 100 Then
			Message1TextBox.Text += odd.ToString() + vbCrLf
		End If
	End Sub

	Private Sub IfElseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim odd = GetRandomOddNumber(401)
		CurrentNumberTextBlock.Text = odd
		If odd < 100 Then
			Message1TextBox.Text += odd.ToString() + vbCrLf
		Else
			Message3TextBox.Text += odd.ToString() + vbCrLf
		End If

	End Sub

	Private Sub IfElseIfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

		Dim odd = GetRandomOddNumber(401)
		CurrentNumberTextBlock.Text = odd
		If odd < 100 Then
			Message1TextBox.Text += odd.ToString() + vbCrLf
			ElseIf	odd > 300 Then
			Message2TextBox.Text += odd.ToString() + vbCrLf
		Else
			Message3TextBox.Text += odd.ToString() + vbCrLf
		End If

	End Sub
	Private Sub AndDemo(sender As Object, e As RoutedEventArgs) Handles ButtonE.Click

		If DayTextBox.Text = "Monday" And TimeTextBox.Text = "3:00" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
		End If

	End Sub

	Private Sub OrDemo(sender As Object, e As RoutedEventArgs) Handles ButtonG.Click
		If DayTextBox.Text = "Monday" Or TimeTextBox.Text = "3:00" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
		End If
	End Sub



	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
			Clear()
	End Sub

	Private sub Clear()
		Message1TextBox.Text = ""
			Message2TextBox.Text = ""
			Message3TextBox.Text = ""
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