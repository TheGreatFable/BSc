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
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdSelection = New System.Windows.Forms.Button()
        Me.cmdBubble = New System.Windows.Forms.Button()
        Me.cmdVB = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdBinary = New System.Windows.Forms.Button()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(148, 104)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(100, 41)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdSelection
        '
        Me.cmdSelection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelection.Location = New System.Drawing.Point(85, 151)
        Me.cmdSelection.Name = "cmdSelection"
        Me.cmdSelection.Size = New System.Drawing.Size(188, 36)
        Me.cmdSelection.TabIndex = 1
        Me.cmdSelection.Text = "Selection Sort"
        Me.cmdSelection.UseVisualStyleBackColor = True
        '
        'cmdBubble
        '
        Me.cmdBubble.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBubble.Location = New System.Drawing.Point(85, 193)
        Me.cmdBubble.Name = "cmdBubble"
        Me.cmdBubble.Size = New System.Drawing.Size(188, 37)
        Me.cmdBubble.TabIndex = 2
        Me.cmdBubble.Text = "Bubble Sort"
        Me.cmdBubble.UseVisualStyleBackColor = True
        '
        'cmdVB
        '
        Me.cmdVB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVB.Location = New System.Drawing.Point(85, 236)
        Me.cmdVB.Name = "cmdVB"
        Me.cmdVB.Size = New System.Drawing.Size(188, 36)
        Me.cmdVB.TabIndex = 3
        Me.cmdVB.Text = "VB Sort"
        Me.cmdVB.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(85, 278)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 41)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdBinary
        '
        Me.cmdBinary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBinary.Location = New System.Drawing.Point(85, 366)
        Me.cmdBinary.Name = "cmdBinary"
        Me.cmdBinary.Size = New System.Drawing.Size(188, 37)
        Me.cmdBinary.TabIndex = 5
        Me.cmdBinary.Text = "Binary Search"
        Me.cmdBinary.UseVisualStyleBackColor = True
        '
        'txtLimit
        '
        Me.txtLimit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimit.Location = New System.Drawing.Point(148, 63)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(100, 35)
        Me.txtLimit.TabIndex = 6
        Me.txtLimit.Text = "10"
        '
        'txtVal
        '
        Me.txtVal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.Location = New System.Drawing.Point(85, 325)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(100, 35)
        Me.txtVal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Limit"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(85, 409)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 35)
        Me.txtResult.TabIndex = 9
        Me.txtResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 504)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.cmdBinary)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdVB)
        Me.Controls.Add(Me.cmdBubble)
        Me.Controls.Add(Me.cmdSelection)
        Me.Controls.Add(Me.cmdLoad)
        Me.Name = "Form1"
        Me.Text = "Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdSelection As Button
    Friend WithEvents cmdBubble As Button
    Friend WithEvents cmdVB As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdBinary As Button
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResult As TextBox
End Class
