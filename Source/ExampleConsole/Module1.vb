Module Module1

	Sub Main()
		Dim counter = 2
		Dim outputString
		Dim currentChar = "-"c
		Do
			counter = counter + 1
			If counter > 30 Then
				counter = 2
			End If
			outputString = New String(currentChar, counter)
			Console.WriteLine(outputString)
			Threading.Thread.Sleep(120)
		Loop While True

	End Sub
End Module
