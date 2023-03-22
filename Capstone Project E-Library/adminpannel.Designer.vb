<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminpannel
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.middlename = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(792, 424)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.id)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.middlename)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.lastname)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.firstname)
        Me.TabPage5.Controls.Add(Me.ListView1)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(792, 424)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "EDIT CREDENTIALS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(607, 41)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(26, 20)
        Me.id.TabIndex = 51
        Me.id.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "ID"
        '
        'middlename
        '
        Me.middlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.Location = New System.Drawing.Point(611, 237)
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(117, 26)
        Me.middlename.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(587, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "MIDDLE NAME"
        '
        'lastname
        '
        Me.lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(611, 173)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(117, 26)
        Me.lastname.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(580, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "FIRST NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(583, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "LAST NAME"
        '
        'firstname
        '
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(608, 100)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(120, 26)
        Me.firstname.TabIndex = 50
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(76, 77)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(467, 220)
        Me.ListView1.TabIndex = 40
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LAST NAME"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FIRST NAME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 118
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MIDDLE NAME"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 127
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "logout admin"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'adminpannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "adminpannel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminpannel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents TabPage5 As TabPage
    Friend WithEvents id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents middlename As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
