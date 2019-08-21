Module NumberGenerator

	Public Function GetRandomOddNumber(maxValue As Integer) As Integer

		Return GetOddOrEven(GetRandomNumber(maxValue), True)

	End Function
	Public Function GetRandomEvenNumber(maxValue As Integer) As Integer
		'Dim candidate As Integer = GetRandomNumber(maxValue)
		Return GetOddOrEven(GetRandomNumber(maxValue), False)
	End Function

	Public Function GetRandomSquaredNumber(maxValue As Integer) As Integer
		Dim candidate As Integer = GetRandomNumber(maxValue)
		Return candidate * candidate
	End Function

	Private Function GetOddOrEven(candidate As Integer, wantOdd As Boolean) As Integer
		Dim remainder As Integer = 0
		If wantOdd Then
			remainder = 1
		End If
		If candidate Mod 2 = remainder Then
			Return candidate
		Else
			Return candidate + 1
		End If
	End Function

	Private Function GetRandomNumber(maxValue As Integer) As Integer

		Dim candidate As Integer = _ran.Next(maxValue:=maxValue)
		Return candidate
	End Function

	Dim _ran = New Random

	Public Async Function GetEngineStatus() As Task(Of Integer)
		Await Task.Delay(1)
		Dim candidate As Integer = _ran.Next(minValue:=-1, maxValue:=200)
		Return candidate
	End Function

	Public Function GetOddNumbersList(listCount As Integer) As List(Of Integer)
		Dim temp = New List(Of Integer)
		For index = 1 To listCount
			temp.Add(GetRandomOddNumber(201))

		Next
		Return temp
	End Function

End Module