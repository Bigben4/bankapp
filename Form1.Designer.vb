<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Ownertxt = New TextBox()
        AmountTxt = New NumericUpDown()
        BankAccountGrid = New DataGridView()
        CreateAccountBtn = New Button()
        DepositBtn = New Button()
        WidthdrawBtn = New Button()
        interestratetxt = New NumericUpDown()
        Label3 = New Label()
        CType(AmountTxt, ComponentModel.ISupportInitialize).BeginInit()
        CType(BankAccountGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(interestratetxt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 5
        Label1.Text = "Owner :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 6
        Label2.Text = " Amount :"
        ' 
        ' Ownertxt
        ' 
        Ownertxt.Location = New Point(129, 53)
        Ownertxt.Name = "Ownertxt"
        Ownertxt.Size = New Size(154, 23)
        Ownertxt.TabIndex = 7
        ' 
        ' AmountTxt
        ' 
        AmountTxt.Location = New Point(141, 318)
        AmountTxt.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        AmountTxt.Name = "AmountTxt"
        AmountTxt.Size = New Size(154, 23)
        AmountTxt.TabIndex = 8
        ' 
        ' BankAccountGrid
        ' 
        BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BankAccountGrid.Location = New Point(395, 53)
        BankAccountGrid.Name = "BankAccountGrid"
        BankAccountGrid.Size = New Size(372, 260)
        BankAccountGrid.TabIndex = 9
        ' 
        ' CreateAccountBtn
        ' 
        CreateAccountBtn.Location = New Point(129, 145)
        CreateAccountBtn.Name = "CreateAccountBtn"
        CreateAccountBtn.Size = New Size(154, 23)
        CreateAccountBtn.TabIndex = 10
        CreateAccountBtn.Text = "Create Account"
        CreateAccountBtn.UseVisualStyleBackColor = True
        ' 
        ' DepositBtn
        ' 
        DepositBtn.Location = New Point(395, 326)
        DepositBtn.Name = "DepositBtn"
        DepositBtn.Size = New Size(187, 23)
        DepositBtn.TabIndex = 11
        DepositBtn.Text = "Deposit"
        DepositBtn.UseVisualStyleBackColor = True
        ' 
        ' WidthdrawBtn
        ' 
        WidthdrawBtn.Location = New Point(588, 326)
        WidthdrawBtn.Name = "WidthdrawBtn"
        WidthdrawBtn.Size = New Size(179, 23)
        WidthdrawBtn.TabIndex = 12
        WidthdrawBtn.Text = "Withdraw"
        WidthdrawBtn.UseVisualStyleBackColor = True
        ' 
        ' interestratetxt
        ' 
        interestratetxt.Location = New Point(171, 93)
        interestratetxt.Name = "interestratetxt"
        interestratetxt.Size = New Size(112, 23)
        interestratetxt.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 14
        Label3.Text = "interest rate (%)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(interestratetxt)
        Controls.Add(WidthdrawBtn)
        Controls.Add(DepositBtn)
        Controls.Add(CreateAccountBtn)
        Controls.Add(BankAccountGrid)
        Controls.Add(AmountTxt)
        Controls.Add(Ownertxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        CType(AmountTxt, ComponentModel.ISupportInitialize).EndInit()
        CType(BankAccountGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(interestratetxt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ownertxt As TextBox
    Friend WithEvents AmountTxt As NumericUpDown
    Friend WithEvents BankAccountGrid As DataGridView
    Friend WithEvents CreateAccountBtn As Button
    Friend WithEvents DepositBtn As Button
    Friend WithEvents WidthdrawBtn As Button
    Friend WithEvents interestratetxt As NumericUpDown
    Friend WithEvents Label3 As Label

End Class
