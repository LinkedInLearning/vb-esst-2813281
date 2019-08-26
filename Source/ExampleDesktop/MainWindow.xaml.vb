Option Strict Off

Class MainWindow




	Private Sub EnumerableDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		ErrorMaker.OpenFile("c:\nofile.txt")

	End Sub


	Private Sub WhereDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click




	End Sub

	Private Sub OrderByDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Dim number As Integer = 7

		Dim result As Integer

		result = number / 0


	End Sub

	Private Sub FindDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click

		Try
			Dim number As Integer = 7

			Dim result As Integer

			result = number / 0
		Catch ex As Exception
			MessageBox.Show("Cannot divide by zero,  select another number and try again.")
		End Try
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