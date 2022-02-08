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
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFull = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(137, 279)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(87, 36)
        Me.cmdGo.TabIndex = 0
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(137, 123)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(149, 26)
        Me.txtFirst.TabIndex = 1
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(137, 178)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(149, 26)
        Me.txtLast.TabIndex = 2
        '
        'txtFull
        '
        Me.txtFull.Location = New System.Drawing.Point(137, 57)
        Me.txtFull.Name = "txtFull"
        Me.txtFull.Size = New System.Drawing.Size(149, 26)
        Me.txtFull.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(51, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last"
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(137, 228)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(149, 26)
        Me.txtNew.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "New Full Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 372)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtFull)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.cmdGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGo As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFull As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNew As TextBox
    Friend WithEvents Label4 As Label
End Class
