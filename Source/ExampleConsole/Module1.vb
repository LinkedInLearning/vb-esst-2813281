Imports System.IO

Module Module1

	Sub Main()

		Dim folderName As String = "C:\VbTemp"
		Dim files As String()
		files = Directory.GetFiles(folderName)

		For Each file In files
			Console.WriteLine(file)
		Next

		Console.ReadLine()
	End Sub

End Module
