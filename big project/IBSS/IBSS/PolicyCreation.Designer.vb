<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PolicyCreation
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDet = New System.Windows.Forms.TextBox()
        Me.btnCreateCo = New System.Windows.Forms.Button()
        Me.txtECli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbIns = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtPolN = New System.Windows.Forms.TextBox()
        Me.txtEd = New System.Windows.Forms.TextBox()
        Me.txtTd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCom = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(680, 342)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(202, 37)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Policy details"
        '
        'txtDet
        '
        Me.txtDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDet.Location = New System.Drawing.Point(903, 339)
        Me.txtDet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDet.Multiline = True
        Me.txtDet.Name = "txtDet"
        Me.txtDet.Size = New System.Drawing.Size(278, 89)
        Me.txtDet.TabIndex = 43
        '
        'btnCreateCo
        '
        Me.btnCreateCo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCo.Location = New System.Drawing.Point(334, 415)
        Me.btnCreateCo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreateCo.Name = "btnCreateCo"
        Me.btnCreateCo.Size = New System.Drawing.Size(278, 63)
        Me.btnCreateCo.TabIndex = 42
        Me.btnCreateCo.Text = "Create Contract"
        Me.btnCreateCo.UseVisualStyleBackColor = True
        '
        'txtECli
        '
        Me.txtECli.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECli.Location = New System.Drawing.Point(334, 35)
        Me.txtECli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtECli.Name = "txtECli"
        Me.txtECli.Size = New System.Drawing.Size(278, 44)
        Me.txtECli.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(285, 37)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Enter the Client ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 37)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Company name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 37)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Insurance type:"
        '
        'cmbIns
        '
        Me.cmbIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIns.FormattingEnabled = True
        Me.cmbIns.Items.AddRange(New Object() {"Car ins.", "Medical ins.", "Property ins."})
        Me.cmbIns.Location = New System.Drawing.Point(334, 176)
        Me.cmbIns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbIns.Name = "cmbIns"
        Me.cmbIns.Size = New System.Drawing.Size(278, 45)
        Me.cmbIns.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(680, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 37)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Total cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(680, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 37)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Policy name"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(903, 285)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(278, 44)
        Me.txtCost.TabIndex = 32
        '
        'txtPolN
        '
        Me.txtPolN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolN.Location = New System.Drawing.Point(903, 69)
        Me.txtPolN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPolN.Name = "txtPolN"
        Me.txtPolN.Size = New System.Drawing.Size(278, 44)
        Me.txtPolN.TabIndex = 31
        '
        'txtEd
        '
        Me.txtEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEd.Location = New System.Drawing.Point(903, 177)
        Me.txtEd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEd.Name = "txtEd"
        Me.txtEd.Size = New System.Drawing.Size(278, 44)
        Me.txtEd.TabIndex = 30
        '
        'txtTd
        '
        Me.txtTd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTd.Location = New System.Drawing.Point(903, 231)
        Me.txtTd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTd.Name = "txtTd"
        Me.txtTd.Size = New System.Drawing.Size(278, 44)
        Me.txtTd.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(680, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 37)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Ending date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 236)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 37)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total duration"
        '
        'txtSd
        '
        Me.txtSd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSd.Location = New System.Drawing.Point(903, 123)
        Me.txtSd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSd.Name = "txtSd"
        Me.txtSd.Size = New System.Drawing.Size(278, 44)
        Me.txtSd.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(680, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 37)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Starting date"
        '
        'cmbCom
        '
        Me.cmbCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCom.FormattingEnabled = True
        Me.cmbCom.Items.AddRange(New Object() {"Libano suisse", "Fidelity", "LCI", "Bankers", "Allianz SNA", "Metlife"})
        Me.cmbCom.Location = New System.Drawing.Point(334, 121)
        Me.cmbCom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCom.Name = "cmbCom"
        Me.cmbCom.Size = New System.Drawing.Size(278, 45)
        Me.cmbCom.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(680, 441)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 37)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Risks covered"
        '
        'txtRisk
        '
        Me.txtRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRisk.Location = New System.Drawing.Point(903, 441)
        Me.txtRisk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRisk.Multiline = True
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(278, 93)
        Me.txtRisk.TabIndex = 45
        '
        'PolicyCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1265, 586)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDet)
        Me.Controls.Add(Me.btnCreateCo)
        Me.Controls.Add(Me.txtECli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbIns)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtPolN)
        Me.Controls.Add(Me.txtEd)
        Me.Controls.Add(Me.txtTd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCom)
        Me.Name = "PolicyCreation"
        Me.Text = "Policy Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents txtDet As TextBox
    Friend WithEvents btnCreateCo As Button
    Friend WithEvents txtECli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbIns As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtPolN As TextBox
    Friend WithEvents txtEd As TextBox
    Friend WithEvents txtTd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCom As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRisk As TextBox
End Class
