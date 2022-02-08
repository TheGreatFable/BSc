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
        Me.cmbCliCat = New System.Windows.Forms.ComboBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.txtCliID = New System.Windows.Forms.TextBox()
        Me.txtCliAdress = New System.Windows.Forms.TextBox()
        Me.txtCliPhone = New System.Windows.Forms.TextBox()
        Me.txtCliName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdReformat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbCliCat
        '
        Me.cmbCliCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCliCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliCat.FormattingEnabled = True
        Me.cmbCliCat.Location = New System.Drawing.Point(497, 80)
        Me.cmbCliCat.Name = "cmbCliCat"
        Me.cmbCliCat.Size = New System.Drawing.Size(235, 179)
        Me.cmbCliCat.TabIndex = 0
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(205, 303)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(136, 63)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'txtCliID
        '
        Me.txtCliID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliID.Location = New System.Drawing.Point(205, 56)
        Me.txtCliID.Name = "txtCliID"
        Me.txtCliID.Size = New System.Drawing.Size(248, 35)
        Me.txtCliID.TabIndex = 2
        '
        'txtCliAdress
        '
        Me.txtCliAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliAdress.Location = New System.Drawing.Point(205, 139)
        Me.txtCliAdress.Name = "txtCliAdress"
        Me.txtCliAdress.Size = New System.Drawing.Size(248, 35)
        Me.txtCliAdress.TabIndex = 3
        '
        'txtCliPhone
        '
        Me.txtCliPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliPhone.Location = New System.Drawing.Point(205, 180)
        Me.txtCliPhone.Name = "txtCliPhone"
        Me.txtCliPhone.Size = New System.Drawing.Size(248, 35)
        Me.txtCliPhone.TabIndex = 4
        '
        'txtCliName
        '
        Me.txtCliName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliName.Location = New System.Drawing.Point(205, 97)
        Me.txtCliName.Name = "txtCliName"
        Me.txtCliName.Size = New System.Drawing.Size(248, 35)
        Me.txtCliName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(492, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Category"
        '
        'cmdReformat
        '
        Me.cmdReformat.Location = New System.Drawing.Point(497, 315)
        Me.cmdReformat.Name = "cmdReformat"
        Me.cmdReformat.Size = New System.Drawing.Size(132, 51)
        Me.cmdReformat.TabIndex = 12
        Me.cmdReformat.Text = "Reformat"
        Me.cmdReformat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdReformat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCliName)
        Me.Controls.Add(Me.txtCliPhone)
        Me.Controls.Add(Me.txtCliAdress)
        Me.Controls.Add(Me.txtCliID)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmbCliCat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCliCat As ComboBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents txtCliID As TextBox
    Friend WithEvents txtCliAdress As TextBox
    Friend WithEvents txtCliPhone As TextBox
    Friend WithEvents txtCliName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdReformat As Button
End Class
