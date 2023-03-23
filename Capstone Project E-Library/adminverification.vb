Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class adminverification
    Dim retries As Integer = 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If password.Text <> "ADMINISTRATOR12345" Then
            retries = retries - 1
            If retries = 0 Then
                MsgBox("ACCESS DENIED!!! CHANCES LEFT: " + retries.ToString)
                register.Show()
                register.selectabas1()
                Me.Close()
            Else
                MsgBox("WRONG PASSWORD!!! CHANCES LEFT: " + retries.ToString)
            End If
        ElseIf password.Text = "ADMINISTRATOR12345" Then
            MsgBox("ACCESS GRANTED")
            register.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkGreen
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = register.Button2.BackColor
        Button1.ForeColor = Color.Black
    End Sub
    Private Sub adminverification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub adminverification_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        register.selectabas1()
        register.Show()

        Me.Close()
    End Sub
End Class