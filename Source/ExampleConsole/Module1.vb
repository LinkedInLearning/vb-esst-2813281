Module Module1

	Sub Main()
		Dim counter = 2
		Dim outputString
		Dim currentChar = "-"c
		Do
			counter = counter + 1
			outputString = New String(currentChar, counter)
			Console.WriteLine(outputString)
			Threading.Thread.Sleep(120)
		Loop While True

	End Sub
End Module
