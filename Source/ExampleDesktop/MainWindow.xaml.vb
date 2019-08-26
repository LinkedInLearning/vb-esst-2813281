Option Strict Off

Class MainWindow


	Private Sub InitializeList(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

		Dim colorNames As New List(Of String)
		Dim colorNames2 = New List(Of String)

	End Sub

	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim colorNames As New List(Of String)




	End Sub
	Private Sub ListOfIntegersDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim oddNumbers = New List(Of Integer)
		For index = 1 To 30
			oddNumbers.Add(GetRandomOddNumber(201))

		Next

	End Sub

#Region "Output"
	Public Sub OutputToScreen(message As String)
		OutputList.Items.Insert(0, message)
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.Items.Clear()

	End Sub
#End Region
End Class