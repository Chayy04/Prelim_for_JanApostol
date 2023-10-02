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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoundButton1 = New BMICalculator.RoundButton()
        Me.txt_w = New System.Windows.Forms.TextBox()
        Me.txt_h = New System.Windows.Forms.TextBox()
        Me.txt_bmi = New System.Windows.Forms.TextBox()
        Me.categ = New System.Windows.Forms.TextBox()
        Me.RoundButton2 = New BMICalculator.RoundButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BMI Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Height :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BMI :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "BMI Category"
        '
        'RoundButton1
        '
        Me.RoundButton1.BackColor = System.Drawing.Color.LightCoral
        Me.RoundButton1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.RoundButton1.FlatAppearance.BorderSize = 0
        Me.RoundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.RoundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Font = New System.Drawing.Font("Constantia", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundButton1.Location = New System.Drawing.Point(57, 366)
        Me.RoundButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(152, 58)
        Me.RoundButton1.TabIndex = 5
        Me.RoundButton1.Text = "CLEAR"
        Me.RoundButton1.UseVisualStyleBackColor = False
        '
        'txt_w
        '
        Me.txt_w.BackColor = System.Drawing.Color.Thistle
        Me.txt_w.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_w.Location = New System.Drawing.Point(197, 102)
        Me.txt_w.Name = "txt_w"
        Me.txt_w.Size = New System.Drawing.Size(179, 36)
        Me.txt_w.TabIndex = 6
        '
        'txt_h
        '
        Me.txt_h.BackColor = System.Drawing.Color.Thistle
        Me.txt_h.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_h.Location = New System.Drawing.Point(197, 152)
        Me.txt_h.Name = "txt_h"
        Me.txt_h.Size = New System.Drawing.Size(179, 36)
        Me.txt_h.TabIndex = 7
        '
        'txt_bmi
        '
        Me.txt_bmi.BackColor = System.Drawing.Color.Thistle
        Me.txt_bmi.Enabled = False
        Me.txt_bmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bmi.ForeColor = System.Drawing.Color.Black
        Me.txt_bmi.Location = New System.Drawing.Point(197, 204)
        Me.txt_bmi.Name = "txt_bmi"
        Me.txt_bmi.Size = New System.Drawing.Size(179, 36)
        Me.txt_bmi.TabIndex = 8
        Me.txt_bmi.Text = "---"
        Me.txt_bmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'categ
        '
        Me.categ.BackColor = System.Drawing.Color.Thistle
        Me.categ.Enabled = False
        Me.categ.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.categ.Location = New System.Drawing.Point(59, 293)
        Me.categ.Name = "categ"
        Me.categ.Size = New System.Drawing.Size(336, 38)
        Me.categ.TabIndex = 9
        Me.categ.Text = "---"
        Me.categ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RoundButton2
        '
        Me.RoundButton2.BackColor = System.Drawing.Color.MediumPurple
        Me.RoundButton2.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.RoundButton2.FlatAppearance.BorderSize = 0
        Me.RoundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.RoundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid
        Me.RoundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton2.Font = New System.Drawing.Font("Constantia", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundButton2.Location = New System.Drawing.Point(243, 366)
        Me.RoundButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RoundButton2.Name = "RoundButton2"
        Me.RoundButton2.Size = New System.Drawing.Size(152, 58)
        Me.RoundButton2.TabIndex = 10
        Me.RoundButton2.Text = "COMPUTE"
        Me.RoundButton2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMICalculator.My.Resources.Resources.bgbmi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(459, 474)
        Me.Controls.Add(Me.RoundButton2)
        Me.Controls.Add(Me.categ)
        Me.Controls.Add(Me.txt_bmi)
        Me.Controls.Add(Me.txt_h)
        Me.Controls.Add(Me.txt_w)
        Me.Controls.Add(Me.RoundButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents txt_w As TextBox
    Friend WithEvents txt_h As TextBox
    Friend WithEvents txt_bmi As TextBox
    Friend WithEvents categ As TextBox
    Friend WithEvents RoundButton2 As RoundButton
End Class
