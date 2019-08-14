Imports System.Runtime.CompilerServices

Class MainWindow
	' class level scope, variable is visible to all code in class
	' in OOP this is also considered a Field (a member of the class type)

	Private primaryBrush As New SolidColorBrush

	' underscore naming convention preferred by some OOP programmers
	Private _accentBrush As New SolidColorBrush



	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' variable have scope and lifetime

		' scope determines its visibility to other code
		' variables in the same scope cannot have the same name

		' lifetime is how long the memory location is kept available

		Dim counter As Integer = 15

		' counter is local variable, any code in this method can access 

		If counter > 10 Then
			counter += 1
			Dim message As String = "block scope"
			' message is block scope, only visible in this if block
			OutputToScreen(message)

		End If
		If counter > 20 Then
			Dim message As String = "block scope"
			' message is block scope, only visible in this if block
			OutputToScreen(message)
		End If
		' what about this variable?
		' message = "Cannot access this variable"

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		primaryBrush.Color = Colors.Orange
		MainPanel.Background = primaryBrush

	End Sub
	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click
		_accentBrush.Color = Colors.Purple
		MessageTextBox.Foreground = primaryBrush
		MessageTextBox.Background = _accentBrush
	End Sub

	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
