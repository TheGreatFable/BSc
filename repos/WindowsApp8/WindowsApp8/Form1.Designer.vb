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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.TextBox()
        Me.Bx = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(349, 143)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(130, 26)
        Me.Input.TabIndex = 0
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(349, 214)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(280, 26)
        Me.output.TabIndex = 1
        '
        'Bx
        '
        Me.Bx.Location = New System.Drawing.Point(562, 143)
        Me.Bx.Name = "Bx"
        Me.Bx.Size = New System.Drawing.Size(93, 37)
        Me.Bx.TabIndex = 2
        Me.Bx.Text = "Button1"
        Me.Bx.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bx)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As TextBox
    Friend WithEvents output As TextBox
    Friend WithEvents Bx As Button
End Class
