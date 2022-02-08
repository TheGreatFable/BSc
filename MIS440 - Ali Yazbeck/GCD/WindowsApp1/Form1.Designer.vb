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
        Me.txtgcd1 = New System.Windows.Forms.TextBox()
        Me.txtgcd2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgcdr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdgcd
        '
        Me.cmdgcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgcd.Location = New System.Drawing.Point(88, 227)
        Me.cmdgcd.Name = "cmdgcd"
        Me.cmdgcd.Size = New System.Drawing.Size(139, 47)
        Me.cmdgcd.TabIndex = 0
        Me.cmdgcd.Text = "GCD"
        Me.cmdgcd.UseVisualStyleBackColor = True
        '
        'txtgcd1
        '
        Me.txtgcd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgcd1.Location = New System.Drawing.Point(88, 109)
        Me.txtgcd1.Name = "txtgcd1"
        Me.txtgcd1.Size = New System.Drawing.Size(140, 35)
        Me.txtgcd1.TabIndex = 2
        '
        'txtgcd2
        '
        Me.txtgcd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgcd2.Location = New System.Drawing.Point(88, 157)
        Me.txtgcd2.Name = "txtgcd2"
        Me.txtgcd2.Size = New System.Drawing.Size(140, 35)
        Me.txtgcd2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Input"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Output"
        '
        'txtgcdr
        '
        Me.txtgcdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgcdr.Location = New System.Drawing.Point(73, 324)
        Me.txtgcdr.Name = "txtgcdr"
        Me.txtgcdr.Size = New System.Drawing.Size(177, 35)
        Me.txtgcdr.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 450)
        Me.Controls.Add(Me.txtgcdr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtgcd2)
        Me.Controls.Add(Me.txtgcd1)
        Me.Controls.Add(Me.cmdgcd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdgcd As Button
    Friend WithEvents txtgcd1 As TextBox
    Friend WithEvents txtgcd2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgcdr As TextBox
End Class
