Option Strict Off

Class MainWindow




	Private Sub EnumerableDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		FileATextBox.Text = ErrorMaker.OpenFile(System.AppDomain.CurrentDomain.BaseDirectory & "\example.txt")
		FileATextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")

	End Sub


	Private Sub HandledDemo1(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


		Try

		Catch ex As Exception
			MessageBox.Show("Cannot find the file requested,  select another file and try again.")
		End Try

	End Sub

	Private Sub OrderByDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
	
		Dim result = ErrorMaker.WorkWithNumbers (7)

	End Sub

	Private Sub FindDemo(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click

		Try
			Dim result = ErrorMaker.WorkWithNumbers (7)
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


		FileATextBox.Text = ""
		FileBTextBox.Text = ""

	End Sub

#End Region
End Class