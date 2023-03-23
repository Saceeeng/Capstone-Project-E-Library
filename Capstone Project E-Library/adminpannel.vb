Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class adminpannel
    Dim cmd As MySqlCommand
    Dim conn As MySqlConnection
    Dim cnstr As String = "data source =  localhost; user id = root; database = capstoneprojectbank;"
    Dim reader As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim itemcol(99) As String
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage5 Then
            quee()
        ElseIf TabControl1.SelectedTab Is TabPage4 Then
            quee1()
        End If
    End Sub

    Public Sub quee1()
        Try
            ListView2.Items.Clear()
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT id, lastname, firstname, middlename from users "
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitems As New ListViewItem(itemcol)
                ListView2.Items.Add(lvitems)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Public Sub quee()
        Try
            ListView1.Items.Clear()
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT id, lastname, firstname, middlename from admins "
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitems As New ListViewItem(itemcol)
                ListView1.Items.Add(lvitems)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            id.Text = ListView1.Items(ListView1.SelectedIndices(0)).Text
            lastname.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            firstname.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
            middlename.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim Sql As String = "UPDATE admins set lastname = @lastname,firstname = @firstname ,middlename = @middlename WHERE id = '" & id.Text & "'"
            cmd = New MySqlCommand(Sql, conn)
            cmd.Parameters.AddWithValue("@lastname", lastname.Text)
            cmd.Parameters.AddWithValue("@firstname", firstname.Text)
            cmd.Parameters.AddWithValue("@middlename", middlename.Text)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                Call quee()
                MsgBox("ADMIN CREDENTIALS UPDATED", vbInformation, "Query")


            Else
                MsgBox("ADMIN CREDENTIALS CAN'T UPDATED", vbInformation, "Query")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call quee()
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Dim idtemp As String
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            idtemp = ListView2.Items(ListView2.SelectedIndices(0)).Text
        End If

        conn = New MySqlConnection(cnstr)
        conn.Open()
        Dim sql As String = "SELECT * from users WHERE id = '" & idtemp & "' "
        cmd = New MySqlCommand(sql, conn)
        reader = cmd.ExecuteReader
        Dim count As Integer = 0
        Dim names As String
        While reader.Read
            names = reader.GetString("lastname") + ", " + reader.GetString("firstname") + " " + reader.GetString("middlename")
        End While
        conn.Close()
        conn = New MySqlConnection(cnstr)
        conn.Open()
        Dim result As DialogResult = MessageBox.Show("Do you want to delete user: " + names.ToString + "?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim sql1 As String = "DELETE FROM users WHERE id=@id"
            Dim command As New MySqlCommand(sql1, conn)
            command.Parameters.AddWithValue("@id", idtemp) ' Set the value of the parameter

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            conn.Close()
            If rowsAffected > 0 Then
                MessageBox.Show("User deleted successfully.")
                quee1()
            Else
                MessageBox.Show("User not found.")
            End If
        Else
        End If
    End Sub
End Class