Public Class Form1
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Try
            Dim price As Decimal = CDec(TextBoxPrice.Text)
            Dim downPayment As Decimal = CDec(TextBoxDownPayment.Text)
            Dim loanAmount As Decimal = price - downPayment
            Dim annualRate As Decimal = CDec(TextBoxAnnualRate.Text)
            Dim rate As Decimal = annualRate / 1200
            Dim years As Integer = CInt(TextBoxYears.Text)
            Dim month As Integer = years * 12
            Dim payment As Decimal = loanAmount * (rate * (1 + rate) ^ month) / ((1 + rate) ^ month - 1)
            Dim totalPayment As Decimal = payment * years * 12
            Dim totalInterest As Decimal = totalPayment - loanAmount
            LabelMonthlyPaymentResult.Text = CStr(Format(payment, "0.00"))
            LabelTotalPaymentResult.Text = CStr(Format(totalPayment, "0.00"))
            LabelTotalInterestResult.Text = CStr(Format(totalInterest, "0.00"))
        Catch Ex As System.InvalidCastException
            MessageBox.Show("Please enter valid numbers")

        Catch Ex As Exception
            MessageBox.Show("An unknown error has occurd", "Error")

        End Try
    End Sub
End Class
