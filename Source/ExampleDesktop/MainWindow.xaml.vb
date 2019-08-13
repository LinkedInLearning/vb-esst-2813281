Imports System.Runtime.CompilerServices

Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles GoButton.Click
		' Declare with identifier, type and initializer 
		Dim counter As Integer = 22
		Dim taxRate As Double = 9.75

		' Declare with identifier and initializer
		Dim counter2 = 33
		Dim isFileReadOnly = False

		'  Declare with identifier
		Dim counter3
		' assign a value before using
		counter3 = 44

#Region "ShowResults"
		ShowResults(counter, NameOf(counter), counter.GetType().Name)
		ShowResults(taxRate, NameOf(taxRate), taxRate.GetType().Name)
		ShowResults(counter2, NameOf(counter2), counter2.GetType().Name)
		ShowResults(isFileReadOnly, NameOf(isFileReadOnly), isFileReadOnly.GetType().Name)
		ShowResults(counter3, NameOf(counter3), counter3.GetType().Name)
#End Region
	End Sub

	Private Sub ValidIdButton_Click(sender As Object, e As RoutedEventArgs) Handles ValidIdButton.Click
		' Variable name rules
		' It must begin with an alphabetic character or an underscore (_).
		' It must only contain alphabetic characters, decimal digits, and underscores.
		' It must contain at least one alphabetic character Or decimal digit if it begins with an underscore.
		'	It must not be more than 1023 characters long.

		Dim _counter As Integer
		Dim counter As Long
		Dim base3Counter As Long
		' Dim 5counter As Short ' not a valid name


		' suggested naming convention for "local variable" is camel case 
		' (lower case first letter, capitalize rest of words)

		Dim thisIsAGoodName As String
		Dim lowercasename As String
		Dim UPPERCASENAME As String

		' VB compiler doesn't care a about case.
		' VB editor matches the initial identifier

		thisIsAGoodName = "hello"


#Region "ShowResults"
		ShowResults(_counter)
		ShowResults(counter)
		ShowResults(base3Counter)
		ShowResults(thisIsAGoodName)
		ShowResults(lowercasename)
		ShowResults(UPPERCASENAME)
#End Region


	End Sub

	Private Sub ConstantsButton_Click(sender As Object, e As RoutedEventArgs) Handles ConstantsButton.Click
		' usually a constant is declared at the class or module level
		' for this example it's in
	End Sub
	Sub ShowResults(message As String, variableName As String, typeName As String)
		Dim paddedMessage = $"variable name: {variableName} is of type {typeName}.  Value = {message}"
		MessageTextBox.Text += paddedMessage + vbCrLf
	End Sub
	Sub ShowResults(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
