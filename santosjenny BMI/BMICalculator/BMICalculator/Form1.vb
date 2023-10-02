Public Class Form1
    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        If IsNumeric(txt_h.Text) AndAlso IsNumeric(txt_w.Text) Then
            ' Calculate BMI
            Dim height As Double = CDbl(txt_h.Text)
            Dim weight As Double = CDbl(txt_w.Text)

            Dim Hheight As Double = height / 100
            Dim bmi As Double = weight / (Hheight * Hheight)

            ' Display the result
            txt_bmi.Text = bmi.ToString("0.00")

            ' Interpret the BMI
            If bmi < 15 Then
                categ.Text = "Very severely underweight"
            ElseIf (bmi < 16 And bmi <= 18) Then
                categ.Text = "Severely Underweight"
            ElseIf (bmi < 18 And bmi <= 25) Then
                categ.Text = "Underweight"
            ElseIf (bmi < 25 And bmi <= 30) Then
                categ.Text = "Normal"
            ElseIf (bmi < 30 And bmi <= 35) Then
                categ.Text = "Overweight"
            ElseIf (bmi < 35 And bmi <= 40) Then
                categ.Text = "Moderately Obese"
            ElseIf (bmi < 40) Then
                categ.Text = "Severely Obese"
            Else
                categ.Text = "Very Severely Obese"
            End If
        Else
            MessageBox.Show("Please enter valid numeric values for height and weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        txt_w.Text = ""
        txt_h.Text = ""
        txt_bmi.Text = "---"
        categ.Text = "---"
    End Sub
End Class
