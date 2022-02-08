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
        Me.txtNScore = New System.Windows.Forms.TextBox()
        Me.txtQPoint = New System.Windows.Forms.TextBox()
        Me.txtLGrade = New System.Windows.Forms.TextBox()
        Me.txtQuali = New System.Windows.Forms.TextBox()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNScore
        '
        Me.txtNScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNScore.Location = New System.Drawing.Point(289, 68)
        Me.txtNScore.Name = "txtNScore"
        Me.txtNScore.Size = New System.Drawing.Size(178, 35)
        Me.txtNScore.TabIndex = 0
        '
        'txtQPoint
        '
        Me.txtQPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQPoint.Location = New System.Drawing.Point(289, 185)
        Me.txtQPoint.Name = "txtQPoint"
        Me.txtQPoint.Size = New System.Drawing.Size(101, 35)
        Me.txtQPoint.TabIndex = 1
        '
        'txtLGrade
        '
        Me.txtLGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLGrade.Location = New System.Drawing.Point(289, 141)
        Me.txtLGrade.Name = "txtLGrade"
        Me.txtLGrade.Size = New System.Drawing.Size(101, 35)
        Me.txtLGrade.TabIndex = 2
        '
        'txtQuali
        '
        Me.txtQuali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuali.Location = New System.Drawing.Point(289, 230)
        Me.txtQuali.Name = "txtQuali"
        Me.txtQuali.Size = New System.Drawing.Size(255, 35)
        Me.txtQuali.TabIndex = 3
        '
        'cmdGo
        '
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(289, 306)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(157, 69)
        Me.cmdGo.TabIndex = 4
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numeric Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Letter Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quality Points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Qualification"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.txtQuali)
        Me.Controls.Add(Me.txtLGrade)
        Me.Controls.Add(Me.txtQPoint)
        Me.Controls.Add(Me.txtNScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNScore As TextBox
    Friend WithEvents txtQPoint As TextBox
    Friend WithEvents txtLGrade As TextBox
    Friend WithEvents txtQuali As TextBox
    Friend WithEvents cmdGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
