Public Class Form1
    Private Sub TablaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TablaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TablaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OlaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OlaDataSet.tabla' Puede moverla o quitarla según sea necesario.
        Me.TablaTableAdapter.Fill(Me.OlaDataSet.tabla)

    End Sub
End Class
