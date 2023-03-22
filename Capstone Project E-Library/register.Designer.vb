<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rfid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.middlename = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rfid1 = New System.Windows.Forms.TextBox()
        Me.middlename1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.lastname1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.firstname1 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RFID"
        '
        'rfid
        '
        Me.rfid.Location = New System.Drawing.Point(66, 18)
        Me.rfid.Name = "rfid"
        Me.rfid.Size = New System.Drawing.Size(100, 20)
        Me.rfid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PASSWORD"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(66, 66)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "FIRST NAME"
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(66, 116)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(100, 20)
        Me.firstname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LAST NAME"
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(66, 166)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(100, 20)
        Me.lastname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "MIDDLE NAME"
        '
        'middlename
        '
        Me.middlename.Location = New System.Drawing.Point(66, 232)
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(100, 20)
        Me.middlename.TabIndex = 1
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(66, 278)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 2
        Me.submit.Text = "register"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(704, 407)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.submit)
        Me.TabPage1.Controls.Add(Me.rfid)
        Me.TabPage1.Controls.Add(Me.middlename)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.password)
        Me.TabPage1.Controls.Add(Me.lastname)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.firstname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(696, 381)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "USER REGISTER"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.rfid1)
        Me.TabPage2.Controls.Add(Me.middlename1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.password1)
        Me.TabPage2.Controls.Add(Me.lastname1)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.firstname1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(696, 381)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADMIN REGISTER"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(357, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RFID"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(258, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 34)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "register"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rfid1
        '
        Me.rfid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfid1.Location = New System.Drawing.Point(275, 60)
        Me.rfid1.Name = "rfid1"
        Me.rfid1.Size = New System.Drawing.Size(131, 26)
        Me.rfid1.TabIndex = 9
        '
        'middlename1
        '
        Me.middlename1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename1.Location = New System.Drawing.Point(275, 278)
        Me.middlename1.Name = "middlename1"
        Me.middlename1.Size = New System.Drawing.Size(131, 26)
        Me.middlename1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "PASSWORD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(235, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "MIDDLE NAME"
        '
        'password1
        '
        Me.password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password1.Location = New System.Drawing.Point(275, 110)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(131, 26)
        Me.password1.TabIndex = 11
        '
        'lastname1
        '
        Me.lastname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname1.Location = New System.Drawing.Point(275, 212)
        Me.lastname1.Name = "lastname1"
        Me.lastname1.Size = New System.Drawing.Size(131, 26)
        Me.lastname1.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(235, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "FIRST NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "LAST NAME"
        '
        'firstname1
        '
        Me.firstname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname1.Location = New System.Drawing.Point(275, 162)
        Me.firstname1.Name = "firstname1"
        Me.firstname1.Size = New System.Drawing.Size(131, 26)
        Me.firstname1.TabIndex = 13
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rfid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents middlename As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents rfid1 As TextBox
    Friend WithEvents middlename1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents password1 As TextBox
    Friend WithEvents lastname1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents firstname1 As TextBox
End Class
