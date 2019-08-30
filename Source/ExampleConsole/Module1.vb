Module Module1

	Sub Main()
		Do
			Console.ResetColor()
			Dim ringCount = Console.ReadLine()

			Dim totalDots = PentagonalDotCounter(rings:=ringCount)
			'	Dim totalDots = GeneralizedDotCounter(rings:=ringCount,dimensions:=4)
			Console.ForegroundColor = ConsoleColor.Yellow
			Console.WriteLine($"Ring Count: {ringCount}, Total Dots: {totalDots}")
		Loop While True

	End Sub

	Private Function PentagonalDotCounter(rings As Integer)
		' 1 + 5 + 10 + 15 + 15
		' 1 + (5 * 1) + (5 * 2) ... + (5 * n) 
		Dim total = 1
		For counter = rings - 1 To 1 Step -1
			total += counter * 5
		Next
		Return total

	End Function
	Private Function GeneralizedDotCounter(rings As Integer, Optional dimensions As Integer = 5) As Integer
		Dim total = 1
		For counter = rings - 1 To 1 Step -1
			total += counter * dimensions
		Next
		Return total

	End Function
End Module
