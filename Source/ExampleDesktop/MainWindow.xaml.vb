Option Strict Off
Imports System.Globalization

Class MainWindow

	Private Sub CreateString_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim direction = "East"
		Dim otherDirection As String = "West"
		' use the constructor to build a string
		Dim line = New String("»"c, 63)
		OutputToScreen(direction)
		OutputToScreen(line)

	End Sub

	Private Sub Concatenate_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim teamA = TeamATextBox.Text
		Dim teamB = TeamBTextBox.Text
		Dim message = "Don't miss this match between top-ranked (" + teamA + ") and long-time rivals (" & teamB & ")."
		OutputToScreen(message)

		' string.format
		message = String.Format("Meet the teams: ({0}) and long-time rivals ({1}).", teamA, teamB)
		OutputToScreen(message)
		' Interpolated strings 
		message = $"Autographs and Selfies with: ({teamA}) and long-time rivals ({teamB})."
		OutputToScreen(message)

	End Sub

	Private Sub Search_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim message = "Personalize your LinkedIn Learning experience with skills you need."
		OutputToScreen(message)
		' verify if a sub string is available

		Dim periodExists = message.EndsWith(".")
		Dim wordExists = message.StartsWith("Hello")

		' finding by index
		' return -1 if not found, otherwise the index location
		Dim searchWord = SearchWordTextbox.Text
		OutputToScreen($"Use Contains(), '{searchWord}' Exists: {message.Contains(searchWord)}")
		Dim wordIndex As Integer = message.IndexOf(searchWord)
		OutputToScreen($"Use IndexOf,Word Index for '{searchWord}': {wordIndex}")


	End Sub
	Private Sub Modify_Click(sender As Object, e As RoutedEventArgs) Handles ButtonE.Click

		Dim lettersWithSpaces = "  AA  "
		Dim trimmed = lettersWithSpaces.Trim(" ")

		'  trim these chars
		Dim charsToTrim = New Char() {","c, "."c, " "c, "!"c}
		Dim message = "A synonym for cinnamon, is a cinnamon synonym. Say cinnamon swiftly and soundlessly!!!"

		trimmed = message.TrimEnd(charsToTrim)
		OutputToScreen(message)
		OutputToScreen(trimmed)
		OutputLine()

		Dim upper = message.ToUpper()
		Dim lower = message.ToLower()
		OutputToScreen(upper)
		OutputToScreen(lower)
		OutputLine()

		Dim replaced = message.Replace("cinnamon", "cardamom")
		OutputToScreen(message)
		OutputToScreen(replaced)

	End Sub

	Private Sub Split_click(sender As Object, e As RoutedEventArgs) Handles ButtonF.Click
		Dim message = "Personalize your LinkedIn Learning experience with skills you need."
		Dim words = message.Split(" "c)

		For Each word In words
			OutputToScreen(word)
		Next
		OutputLine()
		Dim newSentence = String.Join("~", words)
		OutputToScreen(newSentence)

	End Sub



	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub OutputBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub


	Sub OutputLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		MessageTextBox.Text = ""
	End Sub

	'Private Sub Chars_Click(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
	'	' use indexer to get a char from string
	'	Dim message = "Now is a good time to learn .NET."
	'	Dim ninthChar = message(9)
	'	OutputToScreen(message)
	'	OutputToScreen(ninthChar)
	'End Sub

	' use IndexOfAny to search for multiple candidates
	' search stops as soon as first match is found
	' Dim invalidCharsFound As Integer = message.IndexOfAny(New Char() {"!"c, "@"c, "#"c, "$"c})
End Class