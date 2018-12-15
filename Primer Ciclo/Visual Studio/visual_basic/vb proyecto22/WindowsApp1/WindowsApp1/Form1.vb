Public Class Form1
    Dim var As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Button1 As New Form2
        Button1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Button2 As New Form3
        Button2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Button3 As New Form4
        Button3.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Timer1.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text += 1
        If Label7.Text = "60" Then
            Label6.Text += 1
            Label7.Text = 0

        End If
        If Label6.Text = 60 Then
            Label5.Text += 1
            Label6.Text = 0
        End If
        If Label5.Text = 1 Then
            Dim f As New Form6
            f.Show()
            Me.Hide()
            Timer1.Stop()
        End If

    End Sub
End Class
