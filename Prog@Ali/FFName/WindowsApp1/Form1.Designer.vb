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
        Me.txtfolder = New System.Windows.Forms.TextBox()
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.txtextension = New System.Windows.Forms.TextBox()
        Me.txtdrive = New System.Windows.Forms.TextBox()
        Me.txtffname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGo
        '
        Me.cmdGo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(229, 314)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(117, 48)
        Me.cmdGo.TabIndex = 0
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'txtfolder
        '
        Me.txtfolder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolder.Location = New System.Drawing.Point(229, 138)
        Me.txtfolder.Name = "txtfolder"
        Me.txtfolder.Size = New System.Drawing.Size(277, 35)
        Me.txtfolder.TabIndex = 1
        '
        'txtfile
        '
        Me.txtfile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfile.Location = New System.Drawing.Point(229, 191)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.Size = New System.Drawing.Size(277, 35)
        Me.txtfile.TabIndex = 2
        '
        'txtextension
        '
        Me.txtextension.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextension.Location = New System.Drawing.Point(229, 248)
        Me.txtextension.Name = "txtextension"
        Me.txtextension.Size = New System.Drawing.Size(277, 35)
        Me.txtextension.TabIndex = 3
        '
        'txtdrive
        '
        Me.txtdrive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrive.Location = New System.Drawing.Point(229, 83)
        Me.txtdrive.Name = "txtdrive"
        Me.txtdrive.Size = New System.Drawing.Size(277, 35)
        Me.txtdrive.TabIndex = 4
        '
        'txtffname
        '
        Me.txtffname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtffname.Location = New System.Drawing.Point(229, 26)
        Me.txtffname.Name = "txtffname"
        Me.txtffname.Size = New System.Drawing.Size(429, 35)
        Me.txtffname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Full File Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Drive"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Folders"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Extension"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 411)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtffname)
        Me.Controls.Add(Me.txtdrive)
        Me.Controls.Add(Me.txtextension)
        Me.Controls.Add(Me.txtfile)
        Me.Controls.Add(Me.txtfolder)
        Me.Controls.Add(Me.cmdGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGo As Button
    Friend WithEvents txtfolder As TextBox
    Friend WithEvents txtfile As TextBox
    Friend WithEvents txtextension As TextBox
    Friend WithEvents txtdrive As TextBox
    Friend WithEvents txtffname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
