Option Strict Off

Class MainWindow
#Region "Rules"
	'For this challenge you’ll code a classic probability problem.  It’s the draw a Marble contest.
	'	On the table are two empty buckets, one painted red And other painted blue.  In the center of the table Is a large Golden bucket that contains 50 red marbles, 50 blue marbles And one gold marble.  The contestant draws out one marble at a time And places it in its matching colored bucket.  The contest Is over when the gold marble Is drawn. The later the gold marble Is drawn, the better the prize.

	' Use at least one List (of T) or other collection class
	' consider using a For Each loop
#End Region

	Private _ran As Random = New Random


	Private Sub CodeTips()
		' a quick way to randomize a list of items.
		Dim colorNames = New List(Of String)({"a", "b", "c", "d", "e", "f"})
		colorNames = colorNames.OrderBy(Function(x) _ran.Next).ToList

		' add an item to the top of a ListBox with .Insert ()
		BlueMarbleListBox.Items.Insert(0, "example")
	End Sub
	Private Sub PlayARound(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

	End Sub
	Private Sub Do1000(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


	End Sub






#Region "Output"
	Public Sub OutputToScreen(message As String)

	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		BlueMarbleListBox.ItemsSource = Nothing
		BlueMarbleListBox.Items.Clear()

		RedMarbleListBox.ItemsSource = Nothing
		RedMarbleListBox.Items.Clear()
		FarthestPositionListBox.ItemsSource = Nothing
		FarthestPositionListBox.Items.Clear()

	End Sub

#End Region
End Class