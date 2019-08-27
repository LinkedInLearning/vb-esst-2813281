Option Strict Off

Class MainWindow




	Private Sub EnumerableDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		' LINQ provides tools for querying lists of data 
		' The Enumerable class is the primary LINQ class for query actions.


		' get a range of integers

		Dim numbers = Enumerable.Range(start:=20, count:=300).ToList()



	End Sub


	Private Sub ExtensionMethodsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


		Dim compassPoints As New List(Of String)({"North", "East", "South", "West"})
		Dim doubleList = New List(Of Double)({3.3, 4.4, 1.1, 2.2, 5.5, 8.8, 9.9, 6.6, 7.7})

		' use the Enumerable extension methods with any class
		' that implements the IEnumerable or IEnumerable (Of T) interface
		doubleList.

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