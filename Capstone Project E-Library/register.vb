Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient


Public Class register
    Dim cmd As MySqlCommand
    Dim conn As MySqlConnection
    Dim cnstr As String = "data source =  localhost; user id = root; database = capstoneprojectbank;"
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "INSERT INTO users (rfid,password,firstname,lastname,middlename) VALUES (@rfid,@password,@firstname,@lastname,@middlename)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rfid", rfid.Text)
            cmd.Parameters.AddWithValue("@password", password.Text)
            cmd.Parameters.AddWithValue("@firstname", firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", lastname.Text)
            cmd.Parameters.AddWithValue("@middlename", middlename.Text)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("USER REGISTERED", vbInformation, "Query")
                rfid.Clear()
                password.Clear()
                firstname.Clear()
                lastname.Clear()
                middlename.Clear()
            Else
                MsgBox("USER NOT REGISTERED", vbInformation, "Query")

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab Is TabPage1 Then
            rfid1.Clear()
            password1.Clear()
            firstname1.Clear()
            lastname1.Clear()
            middlename1.Clear()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            rfid.Clear()
            password.Clear()
            firstname.Clear()
            lastname.Clear()
            middlename.Clear()
            adminverification.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "INSERT INTO admins (rfid,password,firstname,lastname,middlename) VALUES (@rfid,@password,@firstname,@lastname,@middlename)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rfid", rfid1.Text)
            cmd.Parameters.AddWithValue("@password", password1.Text)
            cmd.Parameters.AddWithValue("@firstname", firstname1.Text)
            cmd.Parameters.AddWithValue("@lastname", lastname1.Text)
            cmd.Parameters.AddWithValue("@middlename", middlename1.Text)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("ADMIN REGISTERED", vbInformation, "Query")
                rfid1.Clear()
                password1.Clear()
                firstname1.Clear()
                lastname1.Clear()
                middlename1.Clear()
            Else
                MsgBox("ADMIN NOT REGISTERED", vbInformation, "Query")

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub selectabas1()
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class