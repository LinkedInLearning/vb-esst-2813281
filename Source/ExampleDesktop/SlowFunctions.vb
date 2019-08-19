Module SlowFunctions

	Public  Function IsNetWorkAvailable () As  Boolean
		Return True
	End Function

	Public async Function IsDatabaseOnline () As Task (Of Boolean)
	await	Task.Delay(3000)

		Return True
	End Function
End Module
