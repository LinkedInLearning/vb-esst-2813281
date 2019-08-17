Module NumberGenerator

	Public Function GetRandomOddNumber() As Integer
		Dim ran = New Random
		Dim candidate As Integer = ran.Next(maxValue:=201)
		If candidate Mod 2 = 1 Then
			Return candidate
		Else
			Return candidate + 1
		End If

	End Function
	Public Function GetRandomEvenNumber() As Integer
		Dim ran = New Random
		Dim candidate As Integer = ran.Next(maxValue:=201)
		If candidate Mod 2 = 0 Then
			Return candidate
		Else
			Return candidate + 1
		End If
	End Function
End Module
