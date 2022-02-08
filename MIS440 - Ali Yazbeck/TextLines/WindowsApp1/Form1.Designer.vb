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
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtLines = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdNextLine = New System.Windows.Forms.Button()
        Me.cmdReadFields = New System.Windows.Forms.Button()
        Me.cmdOutput = New System.Windows.Forms.Button()
        Me.cmdWriteline = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(207, 95)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(406, 35)
        Me.txtFileName.TabIndex = 0
        '
        'txtLines
        '
        Me.txtLines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLines.Location = New System.Drawing.Point(207, 184)
        Me.txtLines.Multiline = True
        Me.txtLines.Name = "txtLines"
        Me.txtLines.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLines.Size = New System.Drawing.Size(773, 40)
        Me.txtLines.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lines"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(102, 225)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(26, 29)
        Me.lblNum.TabIndex = 4
        Me.lblNum.Text = "0"
        '
        'cmdOpen
        '
        Me.cmdOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.Location = New System.Drawing.Point(138, 312)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(132, 75)
        Me.cmdOpen.TabIndex = 5
        Me.cmdOpen.Text = "Open input"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(162, 429)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 45)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdNextLine
        '
        Me.cmdNextLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextLine.Location = New System.Drawing.Point(597, 262)
        Me.cmdNextLine.Name = "cmdNextLine"
        Me.cmdNextLine.Size = New System.Drawing.Size(131, 65)
        Me.cmdNextLine.TabIndex = 7
        Me.cmdNextLine.Text = "Next line"
        Me.cmdNextLine.UseVisualStyleBackColor = True
        '
        'cmdReadFields
        '
        Me.cmdReadFields.Location = New System.Drawing.Point(597, 354)
        Me.cmdReadFields.Name = "cmdReadFields"
        Me.cmdReadFields.Size = New System.Drawing.Size(135, 76)
        Me.cmdReadFields.TabIndex = 15
        Me.cmdReadFields.Text = "Read Fields"
        Me.cmdReadFields.UseVisualStyleBackColor = True
        '
        'cmdOutput
        '
        Me.cmdOutput.Location = New System.Drawing.Point(378, 295)
        Me.cmdOutput.Name = "cmdOutput"
        Me.cmdOutput.Size = New System.Drawing.Size(128, 49)
        Me.cmdOutput.TabIndex = 16
        Me.cmdOutput.Text = "Open output"
        Me.cmdOutput.UseVisualStyleBackColor = True
        '
        'cmdWriteline
        '
        Me.cmdWriteline.Location = New System.Drawing.Point(392, 366)
        Me.cmdWriteline.Name = "cmdWriteline"
        Me.cmdWriteline.Size = New System.Drawing.Size(114, 64)
        Me.cmdWriteline.TabIndex = 17
        Me.cmdWriteline.Text = "writeline"
        Me.cmdWriteline.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 555)
        Me.Controls.Add(Me.cmdWriteline)
        Me.Controls.Add(Me.cmdOutput)
        Me.Controls.Add(Me.cmdReadFields)
        Me.Controls.Add(Me.cmdNextLine)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLines)
        Me.Controls.Add(Me.txtFileName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFileName As TextBox
    Friend WithEvents txtLines As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdNextLine As Button
    Friend WithEvents cmdReadFields As Button
    Friend WithEvents cmdOutput As Button
    Friend WithEvents cmdWriteline As Button
End Class
