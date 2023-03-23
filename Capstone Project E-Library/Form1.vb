Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient


Public Class Form1
    Dim cmd As MySqlCommand
    Dim conn As MySqlConnection
    Dim cnstr As String = "data source =  localhost; user id = root; database = capstoneprojectbank;"
    Dim READER As MySqlDataReader
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rfid.TextChanged, password.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        register.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * from users WHERE rfid = '" & rfid.Text & "' and password = '" & password.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Reader = cmd.ExecuteReader
            Dim count As Integer = 0
            While Reader.Read
                count += 1
            End While
            If count = 1 Then
                MessageBox.Show("LOGIN SUCCESSFUL")


            ElseIf count > 1 Then
                MessageBox.Show("LOGIN DETAILS DUPLICATED")
            Else
                MessageBox.Show("WRONG PASSWORD OR EMAIL")
            End If
            rfid.Clear()
            password.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * from admins WHERE rfid = '" & rfid.Text & "' and password = '" & password.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            Dim count As Integer = 0
            While READER.Read
                count += 1
            End While
            If count = 1 Then
                MessageBox.Show("LOGIN SUCCESSFUL")
                adminpannel.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("LOGIN DETAILS DUPLICATED")
            Else
                MessageBox.Show("WRONG PASSWORD OR EMAIL")
            End If
            rfid.Clear()
            password.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Dim retype As Integer = 0
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If retype = 0 Then
            password.UseSystemPasswordChar = False
            retype = 1
        ElseIf retype = 1 Then
            password.UseSystemPasswordChar = True
            retype = 0
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        register.Show()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.DarkGreen
        Button2.ForeColor = Color.White

    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Button3.BackColor
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.DarkGreen
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Button2.BackColor
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.DarkGreen
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Button2.BackColor
        Button4.ForeColor = Color.Black
    End Sub
End Class
