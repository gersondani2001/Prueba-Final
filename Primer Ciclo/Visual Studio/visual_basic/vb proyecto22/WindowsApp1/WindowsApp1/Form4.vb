Public Class Form4
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CompraYVentaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompraYVentaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompraYVentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.CompraYVenta' Puede moverla o quitarla según sea necesario.
        Me.CompraYVentaTableAdapter.Fill(Me.DatabaseDataSet.CompraYVenta)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Button1 As New Form1
        Button1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Button2 As New Form5
        Button2.Show()

        a = CodigoTextBox.Text
        b = NombreTextBox.Text
        c = ApellidoTextBox.Text
        d = DPITextBox.Text
        f = FechaCompraDateTimePicker.Text
        h = BonosTextBox.Text
        i = ComprasTextBox.Text
        j = TotalTextBox.Text

        cont = cont + 1







    End Sub
End Class