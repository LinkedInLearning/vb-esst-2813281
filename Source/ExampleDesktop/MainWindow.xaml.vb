Imports System.Runtime.CompilerServices

Class MainWindow
	' class level scope, variable is visible to all code in class
	' in OOP this is also considered a Field (a member of the class type)

	Private primaryBrush As New SolidColorBrush

	' underscore naming convention preferred by some OOP programmers
	Private _accentBrush As New SolidColorBrush



	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click



	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click


	End Sub
	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click

	End Sub

	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
