Option Strict Off

Class MainWindow

	Private Async Sub DoDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim engineStatus As Integer



	End Sub
	Public Sub EndLessLoop()
		Do

		Loop While True
		'--------------

		Do

		Loop Until True
		'--------------

		Do While True

		Loop
		'--------------

		Do Until True

		Loop
		'--------------
	End Sub

	Public Sub OutputToScreen(message As String)
		OutputList.Items.Insert(0, message)
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.Items.Clear()

	End Sub

End Class