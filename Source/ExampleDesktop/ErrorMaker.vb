Module ErrorMaker

	Public Sub OpenFile(fileName As String)


		' Open the text file and display its contents.
		Dim sr As System.IO.StreamReader =
					System.IO.File.OpenText(fileName)

		Dim content = sr.ReadToEnd()


	End Sub


	Public Sub OpenFileWithGuard(fileName As String)
		' Verify that the file exists.
		If System.IO.File.Exists(fileName) = False Then
			Console.Write("File Not Found: " & fileName)
		Else
			' Open the text file and display its contents.
			Dim sr As System.IO.StreamReader =
					System.IO.File.OpenText(fileName)

			Console.Write(sr.ReadToEnd)

			sr.Close()
		End If
	End Sub
End Module
