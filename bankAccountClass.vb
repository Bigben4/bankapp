Public Class bankAccountClass

    'class to hold all bank details

    Public Property Owner As String

    Public Property AccountNumber As Guid

    Protected Balance As Decimal
    Public Property _Balance As Decimal
        'getters
        Get
            Return Balance
        End Get
        'setters 
        Set(value As Decimal)
            Balance = value
        End Set
    End Property

    'constructor
    Public Sub New(ByVal owner As String, ByVal balance As Decimal)
        Me.Owner = owner
        AccountNumber = Guid.NewGuid()
        Me.Balance = balance

    End Sub

    'method
    Public Overridable Sub deposit(amount As Decimal)

        If amount <= 0 Then
            MsgBox(" you cannot deposite $" & amount)
        End If
        If amount > 20000 Then
            MsgBox(" AML deposit Limit Reached")
        Else
            Me.Balance += amount
            MsgBox(" deposit of " & amount & " successfully ")
        End If

    End Sub

    'method 
    Public Sub withdraw(amount As Decimal)
        If amount <= 0 Then
            MsgBox(" you cannot withdraw $" & amount)
        End If
        If amount > Balance Then
            MsgBox(" you don't have enough money ")
        Else

            Me.Balance -= amount
            MsgBox(" withdraw of " & amount & " successfully ")
        End If
    End Sub


End Class
