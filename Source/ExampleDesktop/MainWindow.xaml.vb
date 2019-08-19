Option Strict Off
Imports System.Globalization

Class MainWindow

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

End Class