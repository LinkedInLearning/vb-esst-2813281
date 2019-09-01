Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		AnswerTextBox.Text = ""
		Dim searchWords = SearchWordTextBox.Text.ToLower

		Dim results As String = ""
		Dim found1, found2, foundAll As Boolean
		found1 = String1Textbox.Text.ToLower.Contains(searchWords)
		found2 = String2Textbox.Text.ToLower.Contains(searchWords)
		foundAll = found1 And found2
		If found1 Then
			results &= $"(+)  '{searchWords}' found in first string {vbCrLf}"
		Else
			results &= $"(-)  '{searchWords}' not found in first string {vbCrLf}"
		End If

		If found2 Then
			results &= $"(+)  '{searchWords}' found in second string {vbCrLf}"
			Else
			results &= $"(-)  '{searchWords}' not found in second string {vbCrLf}"
		End If

		If foundAll Then
			results &= $"(++)'{searchWords}' found in both strings {vbCrLf}"
		End If


		AnswerTextBox.Text = results


	End Sub













End Class