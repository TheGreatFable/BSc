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
        Me.cmdTranslate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtRussian = New System.Windows.Forms.TextBox()
        Me.txtArabic = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdTranslate
        '
        Me.cmdTranslate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTranslate.Location = New System.Drawing.Point(563, 104)
        Me.cmdTranslate.Name = "cmdTranslate"
        Me.cmdTranslate.Size = New System.Drawing.Size(177, 46)
        Me.cmdTranslate.TabIndex = 0
        Me.cmdTranslate.Text = "Translate"
        Me.cmdTranslate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(134, 104)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(248, 35)
        Me.txtNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "English"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Russian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Arabic"
        '
        'txtEnglish
        '
        Me.txtEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(134, 188)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(606, 35)
        Me.txtEnglish.TabIndex = 6
        '
        'txtRussian
        '
        Me.txtRussian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRussian.Location = New System.Drawing.Point(134, 229)
        Me.txtRussian.Name = "txtRussian"
        Me.txtRussian.Size = New System.Drawing.Size(606, 35)
        Me.txtRussian.TabIndex = 7
        '
        'txtArabic
        '
        Me.txtArabic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArabic.Location = New System.Drawing.Point(134, 267)
        Me.txtArabic.Name = "txtArabic"
        Me.txtArabic.Size = New System.Drawing.Size(606, 35)
        Me.txtArabic.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtArabic)
        Me.Controls.Add(Me.txtRussian)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTranslate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdTranslate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtRussian As TextBox
    Friend WithEvents txtArabic As TextBox
End Class
