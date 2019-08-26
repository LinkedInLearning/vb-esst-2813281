Option Strict Off

Class MainWindow




	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim colorNames As New List(Of String)

		colorNames.Add("Scarlet")
		colorNames.Add("Magenta")
		colorNames.Insert(0, "Blue")
		colorNames.AddRange({"Green", "Lavender"})

		' Use For Each to loop through a collection



	End Sub


	Private Sub ListOfIntegersDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim oddNumbers = New List(Of Integer)
		For index = 1 To 30
			oddNumbers.Add(GetRandomOddNumber(201))

		Next

		For Each number In oddNumbers
			OutputList.Items.Add($"{number.ToString("D3")} * 4 = {(number * 4).ToString("D3")}")
		Next

	End Sub

	Private Sub BindingDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Dim compassPoints As New List(Of String)({"North", "East", "South", "West"})
		OutputList.ItemsSource = compassPoints
	End Sub

	Public Sub OutputToScreen(message As String)
		OutputList.Items.Insert(0, message)
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.ItemsSource = Nothing
		OutputList.Items.Clear()

	End Sub


End Class