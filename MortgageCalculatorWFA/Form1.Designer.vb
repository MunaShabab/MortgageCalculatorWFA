<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelInstruction = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.LabelDownPayment = New System.Windows.Forms.Label()
        Me.TextBoxDownPayment = New System.Windows.Forms.TextBox()
        Me.LabelAnnualInterestRate = New System.Windows.Forms.Label()
        Me.TextBoxAnnualRate = New System.Windows.Forms.TextBox()
        Me.LabelYears = New System.Windows.Forms.Label()
        Me.TextBoxYears = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.LabelMonthlyPaymentResult = New System.Windows.Forms.Label()
        Me.LabelTotalPaymentResult = New System.Windows.Forms.Label()
        Me.LabelMonthlPayment = New System.Windows.Forms.Label()
        Me.LabelTotalPayment = New System.Windows.Forms.Label()
        Me.LabelTotalInterest = New System.Windows.Forms.Label()
        Me.LabelTotalInterestResult = New System.Windows.Forms.Label()
        Me.LabelPercentSign = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelInstruction
        '
        Me.LabelInstruction.AutoSize = True
        Me.LabelInstruction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInstruction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelInstruction.Location = New System.Drawing.Point(30, 13)
        Me.LabelInstruction.Name = "LabelInstruction"
        Me.LabelInstruction.Size = New System.Drawing.Size(893, 45)
        Me.LabelInstruction.TabIndex = 0
        Me.LabelInstruction.Text = "Enter the following data to calculate your mortgage payment:"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPrice.Location = New System.Drawing.Point(30, 65)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(238, 45)
        Me.LabelPrice.TabIndex = 1
        Me.LabelPrice.Text = "Price of house: "
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPrice.Location = New System.Drawing.Point(340, 60)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(200, 50)
        Me.TextBoxPrice.TabIndex = 2
        '
        'LabelDownPayment
        '
        Me.LabelDownPayment.AutoSize = True
        Me.LabelDownPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDownPayment.Location = New System.Drawing.Point(30, 124)
        Me.LabelDownPayment.Name = "LabelDownPayment"
        Me.LabelDownPayment.Size = New System.Drawing.Size(251, 45)
        Me.LabelDownPayment.TabIndex = 3
        Me.LabelDownPayment.Text = "Down payment: "
        '
        'TextBoxDownPayment
        '
        Me.TextBoxDownPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxDownPayment.Location = New System.Drawing.Point(340, 124)
        Me.TextBoxDownPayment.Name = "TextBoxDownPayment"
        Me.TextBoxDownPayment.Size = New System.Drawing.Size(200, 50)
        Me.TextBoxDownPayment.TabIndex = 4
        '
        'LabelAnnualInterestRate
        '
        Me.LabelAnnualInterestRate.AutoSize = True
        Me.LabelAnnualInterestRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelAnnualInterestRate.Location = New System.Drawing.Point(30, 188)
        Me.LabelAnnualInterestRate.Name = "LabelAnnualInterestRate"
        Me.LabelAnnualInterestRate.Size = New System.Drawing.Size(315, 45)
        Me.LabelAnnualInterestRate.TabIndex = 5
        Me.LabelAnnualInterestRate.Text = "Annual interest rate: "
        '
        'TextBoxAnnualRate
        '
        Me.TextBoxAnnualRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxAnnualRate.Location = New System.Drawing.Point(340, 188)
        Me.TextBoxAnnualRate.Name = "TextBoxAnnualRate"
        Me.TextBoxAnnualRate.Size = New System.Drawing.Size(200, 50)
        Me.TextBoxAnnualRate.TabIndex = 6
        '
        'LabelYears
        '
        Me.LabelYears.AutoSize = True
        Me.LabelYears.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelYears.Location = New System.Drawing.Point(30, 256)
        Me.LabelYears.Name = "LabelYears"
        Me.LabelYears.Size = New System.Drawing.Size(273, 45)
        Me.LabelYears.TabIndex = 7
        Me.LabelYears.Text = "Number of years: "
        '
        'TextBoxYears
        '
        Me.TextBoxYears.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxYears.Location = New System.Drawing.Point(340, 253)
        Me.TextBoxYears.Name = "TextBoxYears"
        Me.TextBoxYears.Size = New System.Drawing.Size(200, 50)
        Me.TextBoxYears.TabIndex = 8
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCalculate.FlatAppearance.BorderSize = 2
        Me.ButtonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCalculate.Location = New System.Drawing.Point(279, 333)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(327, 70)
        Me.ButtonCalculate.TabIndex = 9
        Me.ButtonCalculate.Text = "Calculate Payment"
        Me.ButtonCalculate.UseVisualStyleBackColor = False
        '
        'LabelMonthlyPaymentResult
        '
        Me.LabelMonthlyPaymentResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMonthlyPaymentResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMonthlyPaymentResult.Location = New System.Drawing.Point(340, 427)
        Me.LabelMonthlyPaymentResult.Name = "LabelMonthlyPaymentResult"
        Me.LabelMonthlyPaymentResult.Size = New System.Drawing.Size(200, 64)
        Me.LabelMonthlyPaymentResult.TabIndex = 10
        '
        'LabelTotalPaymentResult
        '
        Me.LabelTotalPaymentResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotalPaymentResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalPaymentResult.Location = New System.Drawing.Point(340, 500)
        Me.LabelTotalPaymentResult.Name = "LabelTotalPaymentResult"
        Me.LabelTotalPaymentResult.Size = New System.Drawing.Size(200, 64)
        Me.LabelTotalPaymentResult.TabIndex = 11
        '
        'LabelMonthlPayment
        '
        Me.LabelMonthlPayment.AutoSize = True
        Me.LabelMonthlPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMonthlPayment.Location = New System.Drawing.Point(30, 446)
        Me.LabelMonthlPayment.Name = "LabelMonthlPayment"
        Me.LabelMonthlPayment.Size = New System.Drawing.Size(271, 45)
        Me.LabelMonthlPayment.TabIndex = 12
        Me.LabelMonthlPayment.Text = "Monthly payment"
        '
        'LabelTotalPayment
        '
        Me.LabelTotalPayment.AutoSize = True
        Me.LabelTotalPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalPayment.Location = New System.Drawing.Point(30, 519)
        Me.LabelTotalPayment.Name = "LabelTotalPayment"
        Me.LabelTotalPayment.Size = New System.Drawing.Size(219, 45)
        Me.LabelTotalPayment.TabIndex = 13
        Me.LabelTotalPayment.Text = "Total Payment"
        '
        'LabelTotalInterest
        '
        Me.LabelTotalInterest.AutoSize = True
        Me.LabelTotalInterest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalInterest.Location = New System.Drawing.Point(30, 595)
        Me.LabelTotalInterest.Name = "LabelTotalInterest"
        Me.LabelTotalInterest.Size = New System.Drawing.Size(205, 45)
        Me.LabelTotalInterest.TabIndex = 14
        Me.LabelTotalInterest.Text = "Total Interest"
        '
        'LabelTotalInterestResult
        '
        Me.LabelTotalInterestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotalInterestResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalInterestResult.Location = New System.Drawing.Point(340, 576)
        Me.LabelTotalInterestResult.Name = "LabelTotalInterestResult"
        Me.LabelTotalInterestResult.Size = New System.Drawing.Size(200, 64)
        Me.LabelTotalInterestResult.TabIndex = 15
        '
        'LabelPercentSign
        '
        Me.LabelPercentSign.AutoSize = True
        Me.LabelPercentSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPercentSign.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPercentSign.Location = New System.Drawing.Point(546, 188)
        Me.LabelPercentSign.Name = "LabelPercentSign"
        Me.LabelPercentSign.Size = New System.Drawing.Size(46, 45)
        Me.LabelPercentSign.TabIndex = 16
        Me.LabelPercentSign.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 693)
        Me.Controls.Add(Me.LabelPercentSign)
        Me.Controls.Add(Me.LabelTotalInterestResult)
        Me.Controls.Add(Me.LabelTotalInterest)
        Me.Controls.Add(Me.LabelTotalPayment)
        Me.Controls.Add(Me.LabelMonthlPayment)
        Me.Controls.Add(Me.LabelTotalPaymentResult)
        Me.Controls.Add(Me.LabelMonthlyPaymentResult)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxYears)
        Me.Controls.Add(Me.LabelYears)
        Me.Controls.Add(Me.TextBoxAnnualRate)
        Me.Controls.Add(Me.LabelAnnualInterestRate)
        Me.Controls.Add(Me.TextBoxDownPayment)
        Me.Controls.Add(Me.LabelDownPayment)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelInstruction)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Mortgage Calcualtor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInstruction As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents LabelDownPayment As Label
    Friend WithEvents TextBoxDownPayment As TextBox
    Friend WithEvents LabelAnnualInterestRate As Label
    Friend WithEvents TextBoxAnnualRate As TextBox
    Friend WithEvents LabelYears As Label
    Friend WithEvents TextBoxYears As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents LabelMonthlyPaymentResult As Label
    Friend WithEvents LabelTotalPaymentResult As Label
    Friend WithEvents LabelMonthlPayment As Label
    Friend WithEvents LabelTotalPayment As Label
    Friend WithEvents LabelTotalInterest As Label
    Friend WithEvents LabelTotalInterestResult As Label
    Friend WithEvents LabelPercentSign As Label
End Class
