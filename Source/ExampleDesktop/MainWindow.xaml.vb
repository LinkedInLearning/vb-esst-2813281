Option Strict Off

Class MainWindow

	Private _ran As Random = New Random
	Private _sortedSet As SortedSet(Of Double) = New SortedSet(Of Double)
	Private _queueOfInts As Queue(Of Integer) = New Queue(Of Integer)
	Private Sub SortedSetDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		_sortedSet = New Collections.Generic.SortedSet(Of Double)({3.3, 1.1, 4.4, 2.2, 5.5, 9.9, 8.8, 7.7, 6.6})
		OriginalList.ItemsSource = _sortedSet

	End Sub

	Private Sub AddDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Clear()
		Dim newDouble = _ran.NextDouble() * 10
		newDouble = Math.Round(newDouble, 2)
		_sortedSet.Add(newDouble)

		OriginalList.ItemsSource = _sortedSet

	End Sub

	Private Sub AddFiveDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		ClearOriginal()

		For counter = 1 To 5

			_queueOfInts.Enqueue(_ran.Next(1, 20))
		Next

		OriginalList.ItemsSource = _queueOfInts
	End Sub

	Private Sub DequeueDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		ClearOriginal()
		ModifiedList.Items.Add(_queueOfInts.Dequeue)
		OriginalList.ItemsSource = _queueOfInts

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
	Private Sub ClearOriginal()


		OriginalList.ItemsSource = Nothing
		OriginalList.Items.Clear()

	End Sub

#End Region
End Class