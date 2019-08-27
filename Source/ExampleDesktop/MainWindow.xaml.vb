Option Strict Off

Class MainWindow




	Private Sub ReverseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		' create a function that returns 
		' a List( Of Integer)
		Dim oddNumbers = GetOddNumbersList(15)


		For Each number In oddNumbers
			OriginalList.Items.Add(number)

		Next
		oddNumbers.Reverse()

		For Each number In oddNumbers
			ModifiedList.Items.Add(number)

		Next



	End Sub


	Private Sub SortDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim oddNumbers = GetOddNumbersList(15)


		For Each number In oddNumbers
			OriginalList.Items.Add(number)

		Next
		oddNumbers.Sort()

		For Each number In oddNumbers
			ModifiedList.Items.Add(number)

		Next



	End Sub



	Private Sub FindDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim oddNumbers = GetOddNumbersList(100)
		Dim foundNumbers = oddNumbers.FindAll(Function(x) x > 50 And x < 100)
		oddNumbers.Sort()
		foundNumbers.Sort()

		For Each number In oddNumbers
			OriginalList.Items.Add(number)

		Next

		For Each number In foundNumbers
			ModifiedList.Items.Add(number)

		Next
	End Sub

#Region "Output"
	Public Sub OutputToScreen(message As String)

	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		ModifiedList.ItemsSource = Nothing
		ModifiedList.Items.Clear()

		OriginalList.ItemsSource = Nothing
		OriginalList.Items.Clear()

	End Sub

#End Region
End Class