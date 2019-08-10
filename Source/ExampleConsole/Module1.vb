Module Module1

	Sub Main()

		Dim counter As Integer = 2
		Dim outputString As String
		Dim currentChar As Char = "-"c
		Do
			counter = counter + 1
			If counter > 80 Then
				counter = 2
			End If
			If Console.KeyAvailable Then
				currentChar = Console.ReadKey.KeyChar
			End If


			outputString = New String(currentChar, counter)
			Console.WriteLine(outputString)

			Threading.Thread.Sleep(100)
		Loop While currentChar <> " "c
	End Sub

End Module
