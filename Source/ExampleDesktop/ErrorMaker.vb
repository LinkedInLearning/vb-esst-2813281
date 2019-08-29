Module ErrorMaker

	Public Function OpenFile(fileName As String) As String


		' Open the text file and display its contents.
		Dim reader As System.IO.StreamReader
		reader = System.IO.File.OpenText(fileName)

		Dim content = reader.ReadToEnd()
		reader.Close()

		Return content

	End Function


	Public Sub OpenFileWithGuard(fileName As String)
		' Verify that the file exists.
		If System.IO.File.Exists(fileName) = False Then
			Console.Write("File Not Found: " & fileName)
		Else
			' Open the text file and display its contents.
			Dim reader As System.IO.StreamReader =
					System.IO.File.OpenText(fileName)

			Console.Write(reader.ReadToEnd)

			reader.Close()
		End If
	End Sub

	Public Function WorkWithNumbers(value As Integer) As Integer


		Return value / 0
	End Function
	Public Function GetDataFromList(index As Integer) As Integer
		Dim numbers As New List(Of Integer)({5, 10, 15, 20, 25, 30, 35, 40, 45, 50})
		Return numbers.Item(index)
	End Function
End Module
