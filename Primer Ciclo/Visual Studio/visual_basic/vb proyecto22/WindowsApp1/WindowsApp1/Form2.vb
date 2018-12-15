Public Class Form2
    Private Sub RegistroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RegistroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub RegistroBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles RegistroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.DatabaseDataSet.Registro)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Button1 As New Form1
        Button1.Show()
        Me.Hide()
    End Sub
End Class