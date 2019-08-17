Module NumberGenerator

	Public Function GetRandomOddNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)
		Return GetOddOrEven(candidate, True)

	End Function
	Public Function GetRandomEvenNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)
		Return GetOddOrEven(candidate, False)
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
		Dim ran = New Random
		Dim candidate As Integer = ran.Next(maxValue:=maxValue)
		Return candidate
	End Function
End Module
