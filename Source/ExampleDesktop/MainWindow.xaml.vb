Option Strict Off
Imports System.Globalization

Class MainWindow


	Private Async Sub AndSlow(sender As Object, e As RoutedEventArgs) Handles ButtonH.Click
		SlowMessageTextBlock.Text = "processing..."
		If IsNetWorkAvailable() And Await IsDatabaseOnline() Then
			SlowMessageTextBlock.Text = "And: The Network and DB are available."
		Else
			SlowMessageTextBlock.Text = "And: Network off-line."
		End If
	End Sub

	Private Async Sub AndAlsoSlow(sender As Object, e As RoutedEventArgs) Handles ButtonJ.Click
		SlowMessageTextBlock.Text = "processing..."
		If IsNetWorkAvailable() AndAlso Await IsDatabaseOnline() Then
			SlowMessageTextBlock.Text = "AndAlso: The Network and DB are available."
		Else
			SlowMessageTextBlock.Text = "AndAlso: Network off-line."
		End If
	End Sub

End Class