Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class adminpannel
    Dim cmd As MySqlCommand
    Dim conn As MySqlConnection
    Dim cnstr As String = "data source =  localhost; user id = root; database = capstoneprojectbank;"
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim itemcol(99) As String
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage5 Then
            quee()
        End If
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
            firstname.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            lastname.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
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
End Class