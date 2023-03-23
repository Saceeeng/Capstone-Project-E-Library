Public Class adminverification
    Dim retries As Integer = 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If password.Text <> "ADMINISTRATOR12345" Then
            retries = retries - 1
            If retries = 0 Then
                MsgBox("ACCESS DENIED!!! CHANCES LEFT: " + retries.ToString)
                Me.Close()
                register.Show()
                register.selectabas1()
            Else
                MsgBox("WRONG PASSWORD!!! CHANCES LEFT: " + retries.ToString)
            End If
        ElseIf password.Text = "ADMINISTRATOR12345" Then
            MsgBox("ACCESS GRANTED")
            register.Show()
            Me.Close()
        End If
    End Sub

    Private Sub adminverification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class