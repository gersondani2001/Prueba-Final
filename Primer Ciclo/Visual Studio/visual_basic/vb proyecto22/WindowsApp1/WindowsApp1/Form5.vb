Public Class Form5
    'Estos son las variables que se determinan en la factura cada fact# tiene su variable y su union de datos'
    Dim fact, fact1, fact2, fact3, fact4, fact6 As String
    Dim facti, fact7, fact8, fact5 As Double

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact6 = h
        Label10.Text = "No." & fact6
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Button1.Click

        fact8 = j
        Label12.Text = "Total de pago por el prod: Q." & fact8
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label14.Text = cont
    End Sub

    Private Sub FechaCompraLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form5_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact3 = d
        Label7.Text = "No." & fact3
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact2 = c
        Label6.Text = fact2
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact1 = b
        Label5.Text = fact1
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs)
        fact1 = b
        Label5.Text = fact1
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact = a
        Label4.Text = "No." & fact
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact4 = f
        Label8.Text = fact4
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fact7 = i
        Label11.Text = "Q." & fact7
    End Sub
End Class