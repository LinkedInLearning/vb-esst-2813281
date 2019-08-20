Option Strict Off

Class MainWindow

	Private Sub SelectCaseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim currentNumber = GetNextNumber()
		CurrentNumberOutput.Text = currentNumber



	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		Text1.Text = ""
		Text2.Text = ""
		Text3.Text = ""
		Text4.Text = ""
		Text5.Text = ""
		text6.Text = ""
	End Sub

End Class