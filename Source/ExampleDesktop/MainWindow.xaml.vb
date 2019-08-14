Imports System.Runtime.CompilerServices

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' constants are usually declared at the module or class level

		Const Pi As Decimal = 3.1415926535897931
		Const HALF_BYTE As Byte = 127

		Dim circumference As Double
		Dim diameter As Double = 4
		circumference = Pi * diameter
		OutputToScreen(circumference)
		OutputToScreen(HALF_BYTE)
	End Sub

	Private Sub BuiltInButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		' Constants are members of some .NET classes.

		Dim circumference As Double
		Dim diameter As Double = 4
		circumference = Math.PI * diameter


		' VB language has some constants that start with vb_

		Dim message1, message2 As String
		message1 = "Hello" + vbCrLf + "again."
		OutputToScreen(message1)
		message2 = "indicate what conversion option to use with StrConv function."

		message2 = StrConv(message2, VbStrConv.Uppercase)
		OutputToScreen(message2)
	End Sub


	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
