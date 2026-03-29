Public Class savingsAccounts
    Inherits bankAccountClass

    Public Property interestrate As Decimal


    'constructor 
    Public Sub New(ByVal OwnerName As String, ByVal rate As Decimal)
        MyBase.New(OwnerName & " " & rate & "(%)", 0)

        Me.interestrate = rate


    End Sub
    'chilld method
    Public Overrides Sub deposit(amount As Decimal)

        If amount <= 0 Then
            MsgBox(" you cannot deposite $" & amount)
        End If
        If amount > 20000 Then
            MsgBox(" AML deposit Limit Reached")

        ElseIf interestrate >= 0 Then

            Dim interestAmount = (interestrate / 100) * amount
            Balance += amount + interestAmount
            MsgBox(" deposit of " & amount & " successfully ")
        End If

    End Sub


End Class
