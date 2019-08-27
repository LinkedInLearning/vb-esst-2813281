Option Strict Off

Class MainWindow

	Private Sub EnumerableDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim numbers = New List(Of Integer)({2, 4, 5, 6, 8, 20, 35, 50, 65, 89})

		' use Enumerable extension methods to query the numbers list

		Dim total As Integer
		Dim average As Double
		Dim subsetAverage As Double

		OriginalList.Items.Add("Integers : 2, 4, 5, 6, 8, 20, 35, 50, 65, 89")
		OriginalList.Items.Add($"Total: {total}")
		OriginalList.Items.Add($"Average: {average}")
		OriginalList.Items.Add($"Average of four values: {subsetAverage}")

	End Sub


	Private Sub WhereDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		' where
		Dim integerList = Enumerable.Range(1, 300).ToList()



		OriginalList.ItemsSource = integerList
		' ModifiedList.ItemsSource = listOf25s


	End Sub

	Private Sub OrderByDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click


		Dim words = New List(Of String)({"aa-5-aa", "bb-1-bb", "rr-6-rr", "zz-3-zz"})



		OriginalList.ItemsSource = words
		'	ModifiedList.ItemsSource = orderedWords

	End Sub

	Private Sub FindDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim doubleList = New List(Of Double)({3.3, 4.4, 1.1, 2.2, 5.5, 8.8, 9.9, 6.6, 7.7})


		OriginalList.ItemsSource = doubleList
		'ModifiedList.Items.Add($"Last number in list: {lastNumber}")
		'ModifiedList.Items.Add($"Highest number in list: {maxValue}")

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