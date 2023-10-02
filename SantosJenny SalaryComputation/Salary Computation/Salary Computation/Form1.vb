Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If IsNumeric(WorkH_txtb.Text) AndAlso IsNumeric(RegR_txtb.Text) AndAlso IsNumeric(Overt_txtbox.Text) AndAlso IsNumeric(OvertR_txtbox.Text) Then

            Dim Name = name_txtb.Text
            Dim Department = Dept_txtb.Text
            Dim WorkingHours = WorkH_txtb.Text
            Dim RegularRate = RegR_txtb.Text
            Dim OverTime = Overt_txtbox.Text
            Dim OverRate = OvertR_txtbox.Text



            Dim SSS As Double = 0.05
            Dim PhilHealth As Double = 150
            Dim PagIbig As Double = 0.03
            Dim incometaxrate As Double = 0.08


            Dim RegularPay As Double = WorkingHours * RegularRate
            Dim ototrPay As Double = OverTime * OverRate
            Dim GrossPay = RegularPay + ototrPay


            Dim SSSDeduction As Double = GrossPay * SSS
            Dim PhilHealthDeduction As Double = PhilHealth
            Dim PagIbigDeduction As Double = GrossPay * PagIbig
            Dim Taxx As Double = GrossPay - (SSSDeduction + PhilHealthDeduction + PagIbigDeduction)
            Dim TaxDeduction = Taxx * incometaxrate
            Dim TotalDeductions = SSSDeduction + PhilHealth + PagIbigDeduction + TaxDeduction
            Dim Netpayy As Double = GrossPay - TotalDeductions


            txtboxname2.Text = " " & Name
            txtboxDept2.Text = " " & Department
            txtboxWorkH2.Text = WorkingHours
            txtboxRegR2.Text = RegularRate
            txtboxOvert2.Text = OverTime
            txtboxOvertRate2.Text = OverRate


            txtboxGross2.Text = "₱" & GrossPay.ToString("0.00")
            txtboxSSS2.Text = SSSDeduction.ToString("0.00")
            txtboxPhilH2.Text = PhilHealthDeduction.ToString("0.00")
            txtboxPagIbig2.Text = PagIbigDeduction.ToString("0.00")
            txtboxIncmeT2.Text = TaxDeduction.ToString("0.00")
            txtboxTotalD2.Text = "₱" & TotalDeductions.ToString("0.00")
            txtboxNetPay2.Text = "₱" & Netpayy.ToString("0.00")

        Else
            MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        name_txtb.Text = ""
        Dept_txtb.Text = ""
        WorkH_txtb.Text = ""
        RegR_txtb.Text = ""
        Overt_txtbox.Text = ""
        OvertR_txtbox.Text = ""

        txtboxname2.Text = "  -----"
        txtboxDept2.Text = "  -----"
        txtboxWorkH2.Text = "-----"
        txtboxRegR2.Text = "-----"
        txtboxOvert2.Text = "-----"
        txtboxOvertRate2.Text = "-----"
        txtboxGross2.Text = "-----"
        txtboxSSS2.Text = "-----"
        txtboxPhilH2.Text = "-----"
        txtboxPagIbig2.Text = "-----"
        txtboxIncmeT2.Text = "-----"
        txtboxTotalD2.Text = "-----"
        txtboxNetPay2.Text = "-----"
    End Sub


End Class
