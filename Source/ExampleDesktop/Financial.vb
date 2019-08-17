Module Financial

	Public Function CalculateMonthlyPayment(ByVal numberOfMonths As Integer, ByVal loanRate As Decimal, ByVal loanAmount As Decimal) As Decimal

		Dim perMonth As Decimal = 0
		Dim perMonthWithLoanRate As Decimal = 0
		perMonth = loanAmount / numberOfMonths
		perMonthWithLoanRate = perMonth * loanRate
		Return perMonthWithLoanRate
	End Function
End Module
