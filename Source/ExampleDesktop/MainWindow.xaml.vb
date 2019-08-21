Option Strict Off

Class MainWindow




	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim colorNames As New List(Of String)

		colorNames.Add("Scarlet")
		colorNames.Add("Magenta")
		colorNames.Insert(0, "Blue")
		colorNames.AddRange({"Green", "Lavender"})



	End Sub
	Private Sub ListOfIntegersDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim oddNumbers = New List(Of Integer)
		For index = 1 To 30
			oddNumbers.Add(GetRandomOddNumber(201))

		Next

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