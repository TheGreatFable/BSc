<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdSelection = New System.Windows.Forms.Button()
        Me.cmdBubble = New System.Windows.Forms.Button()
        Me.cmdVB = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtElapse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdBinary = New System.Windows.Forms.Button()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdSelection
        '
        Me.cmdSelection.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdSelection.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelection.Location = New System.Drawing.Point(379, 74)
        Me.cmdSelection.Name = "cmdSelection"
        Me.cmdSelection.Size = New System.Drawing.Size(200, 70)
        Me.cmdSelection.TabIndex = 0
        Me.cmdSelection.Text = "Selection Sort"
        Me.cmdSelection.UseVisualStyleBackColor = False
        Me.cmdSelection.Visible = False
        '
        'cmdBubble
        '
        Me.cmdBubble.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdBubble.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBubble.Location = New System.Drawing.Point(379, 150)
        Me.cmdBubble.Name = "cmdBubble"
        Me.cmdBubble.Size = New System.Drawing.Size(200, 70)
        Me.cmdBubble.TabIndex = 1
        Me.cmdBubble.Text = "Bubble Sort"
        Me.cmdBubble.UseVisualStyleBackColor = False
        Me.cmdBubble.Visible = False
        '
        'cmdVB
        '
        Me.cmdVB.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdVB.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVB.Location = New System.Drawing.Point(379, 226)
        Me.cmdVB.Name = "cmdVB"
        Me.cmdVB.Size = New System.Drawing.Size(200, 70)
        Me.cmdVB.TabIndex = 2
        Me.cmdVB.Text = "VB Sort"
        Me.cmdVB.UseVisualStyleBackColor = False
        Me.cmdVB.Visible = False
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdLoad.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(175, 147)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(150, 70)
        Me.cmdLoad.TabIndex = 3
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'txtLimit
        '
        Me.txtLimit.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimit.Location = New System.Drawing.Point(182, 77)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(143, 40)
        Me.txtLimit.TabIndex = 4
        Me.txtLimit.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Limit"
        '
        'txtElapse
        '
        Me.txtElapse.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapse.Location = New System.Drawing.Point(517, 319)
        Me.txtElapse.Name = "txtElapse"
        Me.txtElapse.Size = New System.Drawing.Size(62, 40)
        Me.txtElapse.TabIndex = 6
        Me.txtElapse.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Elapse Time"
        Me.Label2.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(685, 77)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(150, 70)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        Me.cmdPrint.Visible = False
        '
        'cmdBinary
        '
        Me.cmdBinary.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmdBinary.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBinary.Location = New System.Drawing.Point(848, 333)
        Me.cmdBinary.Name = "cmdBinary"
        Me.cmdBinary.Size = New System.Drawing.Size(200, 70)
        Me.cmdBinary.TabIndex = 9
        Me.cmdBinary.Text = "Binary Search"
        Me.cmdBinary.UseVisualStyleBackColor = False
        Me.cmdBinary.Visible = False
        '
        'txtVal
        '
        Me.txtVal.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.Location = New System.Drawing.Point(853, 260)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(195, 40)
        Me.txtVal.TabIndex = 10
        Me.txtVal.Visible = False
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(909, 419)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(139, 40)
        Me.txtResult.TabIndex = 11
        Me.txtResult.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(683, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 33)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Input a Value"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(818, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 33)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Result"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "(Choose only one)"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "(Seconds)"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(698, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "(From the list)"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(642, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "(See the result in the consoleapp)"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Done."
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(348, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "If you want to Restart this App, please click here"
        '
        'cmdRestart
        '
        Me.cmdRestart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestart.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdRestart.Location = New System.Drawing.Point(409, 553)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(85, 35)
        Me.cmdRestart.TabIndex = 20
        Me.cmdRestart.Text = "Restart"
        Me.cmdRestart.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1144, 613)
        Me.Controls.Add(Me.cmdRestart)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.cmdBinary)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtElapse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdVB)
        Me.Controls.Add(Me.cmdBubble)
        Me.Controls.Add(Me.cmdSelection)
        Me.Name = "Form1"
        Me.Text = "Ali's Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSelection As Button
    Friend WithEvents cmdBubble As Button
    Friend WithEvents cmdVB As Button
    Friend WithEvents cmdLoad As Button
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtElapse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdBinary As Button
    Friend WithEvents txtVal As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdRestart As Button
End Class
