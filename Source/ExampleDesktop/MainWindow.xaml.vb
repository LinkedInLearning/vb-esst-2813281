Option Strict Off
Imports System.IO
Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click


		Dim odd As Integer
		odd = GetRandomOddNumber(201)
		ExamplesForWatchWindow()
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click


	End Sub
	Public Sub ExamplesForWatchWindow()
		Dim sentence As String = "One word after another."
		Dim taxRate As Double = 7.8
		Dim birthDate = Date.Parse("5/5/1992")
		' use a directory that is on you hard drive
		Dim sampleDir = New DirectoryInfo("c:\VBTemp")

	End Sub

#Region "Output Methods"

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
		MessageTextBox.Text = ""
	End Sub
#End Region
End Class