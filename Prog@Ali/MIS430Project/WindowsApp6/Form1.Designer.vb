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
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.labClient = New System.Windows.Forms.Label()
        Me.labAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.labAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.labDiscount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.labNettopay = New System.Windows.Forms.Label()
        Me.txtNettopay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.Color.Gold
        Me.cmdAccept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.ForeColor = System.Drawing.Color.Black
        Me.cmdAccept.Location = New System.Drawing.Point(184, 287)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(148, 54)
        Me.cmdAccept.TabIndex = 0
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'txtClient
        '
        Me.txtClient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.Location = New System.Drawing.Point(193, 45)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(332, 35)
        Me.txtClient.TabIndex = 1
        '
        'labClient
        '
        Me.labClient.AutoSize = True
        Me.labClient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClient.Location = New System.Drawing.Point(117, 48)
        Me.labClient.Name = "labClient"
        Me.labClient.Size = New System.Drawing.Size(70, 27)
        Me.labClient.TabIndex = 2
        Me.labClient.Text = "Client"
        '
        'labAge
        '
        Me.labAge.AutoSize = True
        Me.labAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAge.Location = New System.Drawing.Point(136, 89)
        Me.labAge.Name = "labAge"
        Me.labAge.Size = New System.Drawing.Size(51, 27)
        Me.labAge.TabIndex = 4
        Me.labAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(193, 86)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(157, 35)
        Me.txtAge.TabIndex = 3
        '
        'labAmount
        '
        Me.labAmount.AutoSize = True
        Me.labAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAmount.Location = New System.Drawing.Point(97, 130)
        Me.labAmount.Name = "labAmount"
        Me.labAmount.Size = New System.Drawing.Size(90, 27)
        Me.labAmount.TabIndex = 6
        Me.labAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(193, 127)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(185, 35)
        Me.txtAmount.TabIndex = 5
        '
        'labDiscount
        '
        Me.labDiscount.AutoSize = True
        Me.labDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDiscount.Location = New System.Drawing.Point(89, 171)
        Me.labDiscount.Name = "labDiscount"
        Me.labDiscount.Size = New System.Drawing.Size(98, 27)
        Me.labDiscount.TabIndex = 8
        Me.labDiscount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(193, 168)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(96, 35)
        Me.txtDiscount.TabIndex = 7
        '
        'labNettopay
        '
        Me.labNettopay.AutoSize = True
        Me.labNettopay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNettopay.Location = New System.Drawing.Point(74, 212)
        Me.labNettopay.Name = "labNettopay"
        Me.labNettopay.Size = New System.Drawing.Size(113, 27)
        Me.labNettopay.TabIndex = 10
        Me.labNettopay.Text = "Net to pay"
        '
        'txtNettopay
        '
        Me.txtNettopay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNettopay.Location = New System.Drawing.Point(193, 209)
        Me.txtNettopay.Name = "txtNettopay"
        Me.txtNettopay.Size = New System.Drawing.Size(96, 35)
        Me.txtNettopay.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(646, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labNettopay)
        Me.Controls.Add(Me.txtNettopay)
        Me.Controls.Add(Me.labDiscount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.labAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.labAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.labClient)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.cmdAccept)
        Me.Name = "Form1"
        Me.Text = "MIS430 Ali's Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAccept As Button
    Friend WithEvents txtClient As TextBox
    Friend WithEvents labClient As Label
    Friend WithEvents labAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents labAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents labDiscount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents labNettopay As Label
    Friend WithEvents txtNettopay As TextBox
    Friend WithEvents Button1 As Button
End Class
