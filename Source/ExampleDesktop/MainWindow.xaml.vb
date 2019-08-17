Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		PrintDocument()

		Dim odd = GetRandomOddNumber()
		Dim even = GetRandomEvenNumber()

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


	End Sub

#Region "Output Methods"

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
		MessageTextBox.Text = ""
	End Sub
#End Region
End Class