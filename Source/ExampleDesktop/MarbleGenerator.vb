Module MarbleGenerator



	Public Function GetMarbles(marbleCount As Integer, marbleName As String) As List(Of String)
		Dim temp = New List(Of String)
		For index = 1 To marbleCount
			temp.Add(marbleName)

		Next
		Return temp
	End Function

End Module