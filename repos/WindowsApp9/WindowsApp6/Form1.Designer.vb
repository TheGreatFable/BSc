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
        Me.cmdSelection = New System.Windows.Forms.Button()
        Me.cmdBubble = New System.Windows.Forms.Button()
        Me.cmdVB = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtElapse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdSelection
        '
        Me.cmdSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelection.Location = New System.Drawing.Point(118, 122)
        Me.cmdSelection.Name = "cmdSelection"
        Me.cmdSelection.Size = New System.Drawing.Size(130, 35)
        Me.cmdSelection.TabIndex = 0
        Me.cmdSelection.Text = "Selection"
        Me.cmdSelection.UseVisualStyleBackColor = True
        '
        'cmdBubble
        '
        Me.cmdBubble.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBubble.Location = New System.Drawing.Point(118, 174)
        Me.cmdBubble.Name = "cmdBubble"
        Me.cmdBubble.Size = New System.Drawing.Size(130, 38)
        Me.cmdBubble.TabIndex = 1
        Me.cmdBubble.Text = "Bubble"
        Me.cmdBubble.UseVisualStyleBackColor = True
        '
        'cmdVB
        '
        Me.cmdVB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVB.Location = New System.Drawing.Point(118, 228)
        Me.cmdVB.Name = "cmdVB"
        Me.cmdVB.Size = New System.Drawing.Size(130, 45)
        Me.cmdVB.TabIndex = 2
        Me.cmdVB.Text = "VB"
        Me.cmdVB.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(329, 85)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(117, 39)
        Me.cmdLoad.TabIndex = 3
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'txtLimit
        '
        Me.txtLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimit.Location = New System.Drawing.Point(630, 92)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(100, 35)
        Me.txtLimit.TabIndex = 4
        Me.txtLimit.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(560, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Limit"
        '
        'txtElapse
        '
        Me.txtElapse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElapse.Location = New System.Drawing.Point(630, 159)
        Me.txtElapse.Name = "txtElapse"
        Me.txtElapse.Size = New System.Drawing.Size(100, 35)
        Me.txtElapse.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Elapse Time"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(329, 156)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(117, 38)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Text = "Form1"
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
End Class
