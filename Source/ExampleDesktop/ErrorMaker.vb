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

	Public Function WorkWithNumbers (value As integer) As Integer
		

		return  value / 0
	End Function
End Module
