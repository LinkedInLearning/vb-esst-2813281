Option Strict Off

Class MainWindow
	Dim _counter As Integer = 0
	Private Sub Catch1Demo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Try
			_counter += 1
			FileATextBox.Text = _counter
			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")

		Catch

		End Try





	End Sub

	Private Sub Catch2Demo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Try
			_counter += 1
			FileATextBox.Text = _counter

			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
		Catch ex As Exception
			MessageBox.Show($"Something went wrong { ex.Message}")
		End Try


	End Sub

	Private Sub Catch3Demo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Try
			_counter += 1
			Dim result As Integer = GetDataFromList (20)
			FileATextBox.Text = _counter
			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
			 result = ErrorMaker.WorkWithNumbers(7)

		Catch ex As System.IO.FileNotFoundException
			MessageBox.Show($"Cannot access the file  { ex.FileName}")
		Catch ex As OverflowException
			MessageBox.Show($"This looks like a division error")
		Catch ex As Exception
			
			' this block if for unforeseen exceptions
			' log the exception
		'	My.Log.WriteException (ex)
			My.Log.WriteException (ex,TraceEventType.Critical, "Add a custom log message/")
				MessageBox.Show($"Something went wrong { ex.Message}")
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