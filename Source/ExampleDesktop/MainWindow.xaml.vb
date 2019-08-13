Imports System.Runtime.CompilerServices

Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' variable have scope and lifetime
		' scope determines its visibility to other code

		Dim counter As Integer = 1

		' counter is local variable, can access within this method

		If counter > 10 Then
			Dim message As String = "block scope"
			' message is block scope, only visible in this if block
			ShowResults(message)

		End If
		If counter > 20 Then
			Dim message As String = "block scope"
			' message is block scope, only visible in this if block
			ShowResults(message)
		End If
		' what about this variable?
		'	message = "Cannot access this variable"

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click


	End Sub


	Sub ShowResults(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
