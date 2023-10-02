Public Class Form1
    Dim bebs As Integer = 1

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click

        If IsNumeric(accN_txt.Text) AndAlso IsNumeric(aLoan_txt.Text) AndAlso IsNumeric(intRate_txt.Text) AndAlso IsNumeric(yrP_txt.Text) Then

            Dim Accountnum As Integer = accN_txt.Text
            Dim name As String = name_txt.Text
            Dim Address As String = add_txt.Text
            Dim AmountLoan As Integer = aLoan_txt.Text
            Dim Interest As Double = intRate_txt.Text
            Dim Years As Integer = yrP_txt.Text


            accN2_txt2.Text = Accountnum
            name2_txt2.Text = name
            add2_txt2.Text = Address
            aLoan2_txt2.Text = AmountLoan
            Irate2_txt2.Text = +Interest
            yrP2_txt2.Text = Years


            Dim rate = Interest / 100
            Dim time = Years * 12


            Dim TotalInterest = (AmountLoan * rate) * Years
            Dim TotalLoan = AmountLoan + TotalInterest
            Dim TotalAnnualPayment = TotalLoan / Years
            Dim MonthlyPayment = TotalAnnualPayment / 12


            mpay_txt2.Text = Format(MonthlyPayment, "₱#,###.00")
            totalInt_txt2.Text = Format(TotalInterest, "₱#,###.00")
            tAnnual_txt2.Text = Format(TotalAnnualPayment, "₱#,###.00")
            tLoanPay_txt2.Text = Format(TotalLoan, "₱#,###.00")

        Else
            MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        bebs += 1
        lrn_txtb.Text = bebs.ToString("0000")
        accN_txt.Text = " "
        name_txt.Text = " "
        accN_txt.Text = " "
        add_txt.Text = " "
        aLoan_txt.Text = " "
        intRate_txt.Text = " "
        yrP_txt.Text = " "


        lrn2_txt2.Text = bebs.ToString("  0000")
        accN2_txt2.Text = "  -----"
        name2_txt2.Text = "  -----"
        accN2_txt2.Text = "  -----"
        add2_txt2.Text = "  -----"
        aLoan2_txt2.Text = "-----"
        Irate2_txt2.Text = "-----"
        yrP2_txt2.Text = "-----"
        mpay_txt2.Text = " "
        totalInt_txt2.Text = "-----"
        tLoanPay_txt2.Text = "-----"
        tAnnual_txt2.Text = "-----"

    End Sub

End Class
