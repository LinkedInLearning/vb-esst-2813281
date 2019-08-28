Option Strict Off

Class MainWindow
#Region "Rules"
	'For this challenge you’ll code a classic probability problem.  It’s the draw a Marble contest.
	'	On the table are two empty buckets, one painted red And other painted blue.  In the center of the table Is a large Golden bucket that contains 50 red marbles, 50 blue marbles And one gold marble.  The contestant draws out one marble at a time And places it in its matching colored bucket.  The contest Is over when the gold marble Is drawn. The later the gold marble Is drawn, the better the prize.

	' Use at least one List (of T) or other collection class
	' consider using a For Each loop
#End Region

	Private _ran As Random = New Random
	Dim _stopPositions As New List(Of Integer)

	Private Sub CodeTips()
		' a quick way to randomize a list of items.
		Dim colorNames = New List(Of String)({"a", "b", "c", "d", "e", "f"})
		colorNames = colorNames.OrderBy(Function(x) _ran.Next).ToList

		' add an item to the top of a ListBox with .Insert ()
		BlueMarbleListBox.Items.Insert(0, "example")
	End Sub
	Private Sub DrawMarbles(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		DrawMarble()
		CodeTips()
	End Sub
	Private Sub Do1000(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		For index = 1 To 1000
			DrawMarble()
		Next

	End Sub
	Private Sub DrawMarble()
		Dim marbles = New List(Of String)
		marbles.AddRange(GetMarbles(50, "R"))
		marbles.AddRange(GetMarbles(50, "B"))
		marbles.AddRange(GetMarbles(1, "0"))

		Dim blueCount As Integer
		Dim redCount As Integer

		marbles = marbles.OrderBy(Function(x) _ran.Next).ToList
		For Each marble In marbles
			If marble = "R" Then
				redCount += 1
			ElseIf marble = "B" Then
				blueCount += 1

			Else
				Exit For
			End If
		Next
		BlueMarbleListBox.Items.Insert(0, blueCount)
		RedMarbleListBox.Items.Insert(0, redCount)
		_stopPositions.Insert(0, blueCount + redCount)
		FarthestPositionListBox.Items.Insert(0, blueCount + redCount)
		AverageTextBlock.Text = _stopPositions.Average
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