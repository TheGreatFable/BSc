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
        Me.cmdSortPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(546, 214)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(115, 54)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdSortPrint
        '
        Me.cmdSortPrint.Location = New System.Drawing.Point(363, 213)
        Me.cmdSortPrint.Name = "cmdSortPrint"
        Me.cmdSortPrint.Size = New System.Drawing.Size(157, 55)
        Me.cmdSortPrint.TabIndex = 1
        Me.cmdSortPrint.Text = "Sort and Print"
        Me.cmdSortPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdSortPrint)
        Me.Controls.Add(Me.cmdLoad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdSortPrint As Button
End Class
