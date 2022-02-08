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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCur = New System.Windows.Forms.TextBox()
        Me.lblResultE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResultR = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConvert2 = New System.Windows.Forms.Button()
        Me.btnConvert3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(127, 125)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(231, 61)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert to English"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1107, 42)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 51)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtCur
        '
        Me.txtCur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCur.Location = New System.Drawing.Point(231, 42)
        Me.txtCur.Name = "txtCur"
        Me.txtCur.Size = New System.Drawing.Size(461, 44)
        Me.txtCur.TabIndex = 2
        '
        'lblResultE
        '
        Me.lblResultE.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResultE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultE.Location = New System.Drawing.Point(96, 223)
        Me.lblResultE.Name = "lblResultE"
        Me.lblResultE.Size = New System.Drawing.Size(1316, 52)
        Me.lblResultE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input Amount"
        '
        'lblResultR
        '
        Me.lblResultR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResultR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultR.Location = New System.Drawing.Point(94, 289)
        Me.lblResultR.Name = "lblResultR"
        Me.lblResultR.Size = New System.Drawing.Size(1318, 52)
        Me.lblResultR.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "English"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Русский"
        '
        'btnConvert2
        '
        Me.btnConvert2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert2.Location = New System.Drawing.Point(376, 125)
        Me.btnConvert2.Name = "btnConvert2"
        Me.btnConvert2.Size = New System.Drawing.Size(244, 61)
        Me.btnConvert2.TabIndex = 8
        Me.btnConvert2.Text = "Convert to Russian"
        Me.btnConvert2.UseVisualStyleBackColor = True
        '
        'btnConvert3
        '
        Me.btnConvert3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert3.Location = New System.Drawing.Point(637, 125)
        Me.btnConvert3.Name = "btnConvert3"
        Me.btnConvert3.Size = New System.Drawing.Size(231, 61)
        Me.btnConvert3.TabIndex = 9
        Me.btnConvert3.Text = "Convert to Arabic"
        Me.btnConvert3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "عربى"
        '
        'lblResultA
        '
        Me.lblResultA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultA.Location = New System.Drawing.Point(96, 357)
        Me.lblResultA.Name = "lblResultA"
        Me.lblResultA.Size = New System.Drawing.Size(1316, 52)
        Me.lblResultA.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblResultA)
        Me.Controls.Add(Me.btnConvert3)
        Me.Controls.Add(Me.btnConvert2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblResultR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultE)
        Me.Controls.Add(Me.txtCur)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Ali's Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtCur As TextBox
    Friend WithEvents lblResultE As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultR As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConvert2 As Button
    Friend WithEvents btnConvert3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultA As Label
End Class
