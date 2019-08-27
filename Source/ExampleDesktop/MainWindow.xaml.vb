Option Strict Off

Class MainWindow


	Private _ran As Random = New Random
	Dim _stopPositions As New List(Of Integer)

	Private Sub DrawMarbles(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim marbles = New List(Of String)
		marbles.AddRange(GetMarbles(50, "R"))
		marbles.AddRange(GetMarbles(50, "B"))
		marbles.AddRange(GetMarbles(1, "0"))

		Dim bCount As Integer
		Dim rCount As Integer

		marbles = marbles.OrderBy(Function(x) _ran.Next).ToList
		For Each marble In marbles
			If marble = "R" Then
				rCount += 1
			ElseIf marble = "B" Then
				bCount += 1

			Else
				Exit For
			End If
		Next
		BlueMarbleListBox.Items.Add(bCount)
		RedMarbleListBox.Items.Add(rCount)
		_stopPositions.Add(bCount + rCount)
		FarthestPositionListBox.Items.Add(_stopPositions.Average())
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