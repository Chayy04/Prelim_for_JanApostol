Public Class Form1

    Dim operand As String
    Dim num As Double = 0

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "1"
        Else
            txtbox.Text = txtbox.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "2"
        Else
            txtbox.Text = txtbox.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "3"
        Else
            txtbox.Text = txtbox.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "4"
        Else
            txtbox.Text = txtbox.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "5"
        Else
            txtbox.Text = txtbox.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "6"
        Else
            txtbox.Text = txtbox.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "7"
        Else
            txtbox.Text = txtbox.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "8"
        Else
            txtbox.Text = txtbox.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "9"
        Else
            txtbox.Text = txtbox.Text + "9"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If Val(txtbox.Text) = 0 Then
            txtbox.Text = "0"
        Else
            txtbox.Text = txtbox.Text + "0"
        End If
    End Sub

    Private Sub btndebayd_Click(sender As Object, e As EventArgs) Handles btndebayd.Click
        btnIkwals.PerformClick()
        operand = "div"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num / Val(txtbox.Text)
        End If
        txtbox.Text = "/"
        btnDot.Enabled = True
    End Sub

    Private Sub btntayms_Click(sender As Object, e As EventArgs) Handles btntayms.Click
        btnIkwals.PerformClick()
        operand = "mul"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num * Val(txtbox.Text)
        End If
        txtbox.Text = "×"
        btnDot.Enabled = True
    End Sub

    Private Sub btnmaynus_Click(sender As Object, e As EventArgs) Handles btnmaynus.Click
        btnIkwals.PerformClick()
        operand = "sub"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num - Val(txtbox.Text)
        End If
        txtbox.Text = "-"
        btnDot.Enabled = True
    End Sub

    Private Sub btnplas_Click(sender As Object, e As EventArgs) Handles btnplas.Click
        btnIkwals.PerformClick()
        operand = "add"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num - Val(txtbox.Text)
        End If
        txtbox.Text = "+"
        btnDot.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If txtbox.Text.Length > 0 Then
            txtbox.Text = txtbox.Text.Remove(txtbox.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        btnIkwals.PerformClick()
        operand = "mod"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num Mod Val(txtbox.Text)
        End If
        txtbox.Text = "Mod"
        btnDot.Enabled = True
    End Sub

    Private Sub btnExpo_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        btnIkwals.PerformClick()
        operand = "exp"
        If num = 0 Then
            num = Val(txtbox.Text)
        Else
            num = num ^ Val(txtbox.Text)
        End If
        txtbox.Text = "^"
        btnDot.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbox.Text = "0"
        num = "0"
        operand = ""
        btnDot.Enabled = True
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If btnDot.Enabled = True Then
            txtbox.Text = txtbox.Text + "."
            btnDot.Enabled = False
        End If
    End Sub

    Private Sub btnIkwals_Click(sender As Object, e As EventArgs) Handles btnIkwals.Click
        If operand = "add" Then
            txtbox.Text = num + Val(txtbox.Text)

        ElseIf operand = "sub" Then
            txtbox.Text = num - Val(txtbox.Text)

        ElseIf operand = "mul" Then
            txtbox.Text = num * Val(txtbox.Text)

        ElseIf operand = "div" Then
            txtbox.Text = num / Val(txtbox.Text)

        ElseIf operand = "div2" Then
            txtbox.Text = num \ Val(txtbox.Text)

        ElseIf operand = "mod" Then
            txtbox.Text = num Mod Val(txtbox.Text)

        ElseIf operand = "exp" Then
            txtbox.Text = num ^ Val(txtbox.Text)
        End If
        operand = ""
        num = 0
    End Sub

    Private Sub btnZero_KeyDown(sender As Object, e As KeyEventArgs) Handles btnZero.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad0
                txtbox.Text &= 0

            Case Keys.NumPad1
                txtbox.Text &= 1

            Case Keys.NumPad2
                txtbox.Text &= 2

            Case Keys.NumPad3
                txtbox.Text &= 3

            Case Keys.NumPad4
                txtbox.Text &= 4

            Case Keys.NumPad5
                txtbox.Text &= 5

            Case Keys.NumPad6
                txtbox.Text &= 6

            Case Keys.NumPad7
                txtbox.Text &= 7

            Case Keys.NumPad8
                txtbox.Text &= 8

            Case Keys.NumPad9
                txtbox.Text &= 9
        End Select
    End Sub

End Class
