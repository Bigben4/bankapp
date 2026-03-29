Imports System.Drawing.Text

Public Class Form1

    ' creating a list to contain bankaccount
    Dim Accountlist As New List(Of bankAccountClass)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub RefreshGrid()
        BankAccountGrid.DataSource = vbNull
        BankAccountGrid.DataSource = Accountlist
    End Sub

    Private Sub CreateAccountBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountBtn.Click

        If Ownertxt.Text = Nothing Then
            Return
        End If
        'checking for interest rate value 
        If interestratetxt.Text > 0 Then
            Dim savingsAccount As New savingsAccounts(Ownertxt.Text, interestratetxt.Text)
            Accountlist.Add(savingsAccount)
        Else
            'adding new bank account 
            Dim bankAccount As New bankAccountClass(Ownertxt.Text, AmountTxt.Text)
            Accountlist.Add(bankAccount)
        End If
        'adding the list to the grid 
        RefreshGrid()

        'clears  text once user create an account 
        Ownertxt.Text = Nothing

        'clear text of user interest rate 
        interestratetxt.Text = Nothing


    End Sub


    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click

        If BankAccountGrid.SelectedRows.Count = 1 Then
            Dim SelectedBankAccount = BankAccountGrid.SelectedRows(0).DataBoundItem
            SelectedBankAccount.deposit(AmountTxt.Text)

            'adding the list to the grid 
            RefreshGrid()

            'clear text once user adds balance 
            AmountTxt.Text = 0

        End If


    End Sub


    Private Sub WidthdrawBtn_Click(sender As Object, e As EventArgs) Handles WidthdrawBtn.Click
        If BankAccountGrid.SelectedRows.Count = 1 Then

            Dim SelectedBankAccount = BankAccountGrid.SelectedRows(0).DataBoundItem
            SelectedBankAccount.withdraw(AmountTxt.Text)
            'adding the list to the grid 
            RefreshGrid()

            'clear text once user adds balance 
            AmountTxt.Text = 0


        End If
    End Sub

    Private Sub AmountTxt_ValueChanged(sender As Object, e As EventArgs) Handles AmountTxt.ValueChanged

    End Sub
End Class
