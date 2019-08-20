Option Strict Off

Class MainWindow

	Private Sub SelectCaseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim currentNumber = GetNextNumber()
		CurrentNumberOutput.Text = currentNumber

		Select Case currentNumber
			Case 1 To 3
				Text1.Text &= currentNumber & vbCrLf
			Case 5, 7, 9
				Text2.Text &= currentNumber & vbCrLf
			Case 4, 6, 8
				Text3.Text &= currentNumber & vbCrLf
			Case 10 To 15, 17 To 19
				Text4.Text &= currentNumber & vbCrLf

			Case Is < 30
				Text5.Text &= currentNumber & vbCrLf
			Case Else
				text6.Text &= currentNumber & vbCrLf


		End Select

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