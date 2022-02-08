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
        Me.cmdgcd = New System.Windows.Forms.Button()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtGcd1 = New System.Windows.Forms.TextBox()
        Me.txtGcd2 = New System.Windows.Forms.TextBox()
        Me.cmdprime = New System.Windows.Forms.Button()
        Me.cmdphi = New System.Windows.Forms.Button()
        Me.txtGcdR = New System.Windows.Forms.TextBox()
        Me.txtPrimeR = New System.Windows.Forms.TextBox()
        Me.txtPhiR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdgcd
        '
        Me.cmdgcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgcd.Location = New System.Drawing.Point(121, 150)
        Me.cmdgcd.Name = "cmdgcd"
        Me.cmdgcd.Size = New System.Drawing.Size(202, 47)
        Me.cmdgcd.TabIndex = 0
        Me.cmdgcd.Text = "GCD"
        Me.cmdgcd.UseVisualStyleBackColor = True
        '
        'txtPin
        '
        Me.txtPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPin.Location = New System.Drawing.Point(121, 300)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(202, 39)
        Me.txtPin.TabIndex = 1
        '
        'txtGcd1
        '
        Me.txtGcd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGcd1.Location = New System.Drawing.Point(121, 45)
        Me.txtGcd1.Name = "txtGcd1"
        Me.txtGcd1.Size = New System.Drawing.Size(202, 39)
        Me.txtGcd1.TabIndex = 2
        '
        'txtGcd2
        '
        Me.txtGcd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGcd2.Location = New System.Drawing.Point(121, 90)
        Me.txtGcd2.Name = "txtGcd2"
        Me.txtGcd2.Size = New System.Drawing.Size(202, 39)
        Me.txtGcd2.TabIndex = 3
        '
        'cmdprime
        '
        Me.cmdprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprime.Location = New System.Drawing.Point(121, 374)
        Me.cmdprime.Name = "cmdprime"
        Me.cmdprime.Size = New System.Drawing.Size(202, 47)
        Me.cmdprime.TabIndex = 5
        Me.cmdprime.Text = "Prime or Not"
        Me.cmdprime.UseVisualStyleBackColor = True
        '
        'cmdphi
        '
        Me.cmdphi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdphi.Location = New System.Drawing.Point(121, 487)
        Me.cmdphi.Name = "cmdphi"
        Me.cmdphi.Size = New System.Drawing.Size(202, 47)
        Me.cmdphi.TabIndex = 6
        Me.cmdphi.Text = "Phi"
        Me.cmdphi.UseVisualStyleBackColor = True
        '
        'txtGcdR
        '
        Me.txtGcdR.Enabled = False
        Me.txtGcdR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGcdR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGcdR.Location = New System.Drawing.Point(121, 203)
        Me.txtGcdR.Name = "txtGcdR"
        Me.txtGcdR.Size = New System.Drawing.Size(202, 39)
        Me.txtGcdR.TabIndex = 12
        '
        'txtPrimeR
        '
        Me.txtPrimeR.Enabled = False
        Me.txtPrimeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimeR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPrimeR.Location = New System.Drawing.Point(121, 427)
        Me.txtPrimeR.Name = "txtPrimeR"
        Me.txtPrimeR.Size = New System.Drawing.Size(202, 39)
        Me.txtPrimeR.TabIndex = 13
        '
        'txtPhiR
        '
        Me.txtPhiR.Enabled = False
        Me.txtPhiR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhiR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPhiR.Location = New System.Drawing.Point(121, 540)
        Me.txtPhiR.Name = "txtPhiR"
        Me.txtPhiR.Size = New System.Drawing.Size(202, 39)
        Me.txtPhiR.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Input 2 Numbers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Result"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Input a Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 29)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Result"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 546)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Result"
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(294, 602)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(108, 46)
        Me.Reset.TabIndex = 21
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 660)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhiR)
        Me.Controls.Add(Me.txtPrimeR)
        Me.Controls.Add(Me.txtGcdR)
        Me.Controls.Add(Me.cmdphi)
        Me.Controls.Add(Me.cmdprime)
        Me.Controls.Add(Me.txtGcd2)
        Me.Controls.Add(Me.txtGcd1)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.cmdgcd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdgcd As Button
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtGcd1 As TextBox
    Friend WithEvents txtGcd2 As TextBox
    Friend WithEvents cmdprime As Button
    Friend WithEvents cmdphi As Button
    Friend WithEvents txtGcdR As TextBox
    Friend WithEvents txtPrimeR As TextBox
    Friend WithEvents txtPhiR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Reset As Button
End Class
