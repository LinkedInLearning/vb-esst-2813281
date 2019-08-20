Option Strict Off

Class MainWindow

	Private Async Sub ForDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim engineStatus As Integer
		Do

			engineStatus = Await GetEngineStatus()
			OutputToScreen(engineStatus)
		Loop While engineStatus >= 0

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