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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class
