Imports System.Runtime.CompilerServices

Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' Declare with identifier, type and initializer 
		Dim counter As Integer = 22
		Dim taxRate As Double = 9.75

		' Declare with identifier and initializer
		Dim counter2 = 33.9
		Dim isFileReadOnly = "hello"

		'  Declare with identifier
		Dim counter3
		' assign a value before using
		counter3 = 44

		Dim backBrush = New SolidColorBrush()
		backBrush.Color = Colors.Red

		Dim a As Integer = 8
		Dim b As Integer = 10
		Dim c As Integer = 5 * 1000 * 1000

		If (a = 120) Xor (b = 2) And Not IsBigNumber(c) Then
		End If

		Dim width As Integer = 20
		Const DEFAULT_FILE_LOCATION As String = "C:\"

		' pass literal, constant or variable into a function
		CalculateArea(12, width)
		SaveToFile("demo.txt", DEFAULT_FILE_LOCATION)
#Region "ShowResults"
		OutputToScreen(counter)
		OutputToScreen(taxRate)
		OutputToScreen(counter2)
		OutputToScreen(isFileReadOnly)
		OutputToScreen(counter3)
#End Region
	End Sub
	Public Function IsBigNumber(candidate As Integer) As Boolean
		Return candidate < 1000
	End Function
	Sub CalculateArea(height As Integer, width As Integer)

	End Sub

	Sub SaveToFile(filename As String, dirName As String)

	End Sub
	Private Sub LiteralSuffixButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim anything = 5

		' use appended character to change literal type
		' Decimal: D or @
		' Double: R or #
		' Integer: I or %
		' Long: L or &
		' Short: S
		' Single: F or !
		' Char: C

		' use enclosing character
		' String: ""
		' Date: ##

		' read more about data types here
		' https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/data-types/index


#Region "ShowResults"

#End Region


	End Sub



	Sub OutputToScreen(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
