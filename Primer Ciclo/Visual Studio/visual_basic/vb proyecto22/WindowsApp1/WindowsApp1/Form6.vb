Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text += 1
        If Label9.Text = "60" Then
            Label7.Text += 1
            Label9.Text = 0

        End If
        If Label7.Text = 60 Then
            Label5.Text += 1
            Label7.Text = 0
        End If
        If Label5.Text = 1 Then
            Dim f As New Form1
            f.Show()
            Me.Hide()
            Timer1.Stop()
        End If

    End Sub

    Private Sub Form6_Click(sender As Object, e As EventArgs) Handles Me.Click
        Timer1.Start()
    End Sub
End Class