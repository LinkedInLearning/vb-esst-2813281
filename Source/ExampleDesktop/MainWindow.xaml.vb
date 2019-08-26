Option Strict Off

Class MainWindow




	Private Sub EnumerableDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		' LINQ provides tools for querying lists of data 
		' The Enumerable class is key to query actions.


		' get a range of integers

		Dim numbers = Enumerable.Range(100, 300).ToList()

		' use Enumerable extension methods to query the numbers list

		Dim total = numbers.Sum
		OriginalList.Items.Add(total)

	End Sub


	Private Sub WhereDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		' where
		Dim integerList = Enumerable.Range(1, 300).ToList()

		Dim listOf25s = integerList.Where(Function(x) x Mod 25 = 0 Or x < 10)

		OriginalList.ItemsSource = integerList
		ModifiedList.ItemsSource = listOf25s


	End Sub

	Private Sub OrderByDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click


		Dim words = New List(Of String)({"aa-5-aa", "bb-1-bb", "rr-6-rr", "zz-3-zz"})
		Dim orderedWords = words.OrderBy(Of String)(Function(x) x.Chars(3))


		OriginalList.ItemsSource = words
		ModifiedList.ItemsSource = orderedWords

	End Sub

	Private Sub FindDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim doubleList = New List(Of Double)({3.3, 4.4, 1.1, 2.2, 5.5, 8.8, 9.9, 6.6, 7.7})
		Dim lastNumber = doubleList.Last()

		Dim maxValue = doubleList.Max

		OriginalList.ItemsSource = doubleList
		ModifiedList.Items.Add($"last number in list: {lastNumber}")
		ModifiedList.Items.Add($"Highest number in list: {maxValue}")

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