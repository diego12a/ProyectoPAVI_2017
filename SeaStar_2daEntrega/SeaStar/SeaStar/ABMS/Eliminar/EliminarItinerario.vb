Public Class EliminarItinerario
    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperItinerario

    Private Sub EliminarItinerario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grid(bd.conocer_todos_itinerarios())
        limpiar()
    End Sub

    Private Function validar_campos() As Boolean
        If txtCodigo.Text = " " Then
            Return false
        End If
        If txtDescripcion.Text = " " Then
            Return False
        End If
        If txtCategoria.Text = " " Then
            Return False
        End If
        Return True
    End Function

    Private Sub limpiar()
        txtCodigo.Text = " "
        txtDescripcion.Text = " "
        txtCategoria.Text = " "
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)

        gridItinerarios.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To source.Rows.Count - 1

            gridItinerarios.Rows.Add(source.Rows(c)("cod_itinerario"), _
                               source.Rows(c)("descripcion"), _
                               source.Rows(c)("categoria"))
        Next
    End Sub

    Private Sub gridItinerarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItinerarios.CellContentClick
        row_selected = gridItinerarios.CurrentRow
        txtCodigo.Text = gridItinerarios.CurrentRow.Cells.Item("colCodigo").Value
        txtDescripcion.Text = gridItinerarios.CurrentRow.Cells.Item("colDescripcion").Value
        txtCategoria.Text = gridItinerarios.CurrentRow.Cells.Item("colCategoria").Value
    End Sub

   
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim itinerario As New Itinerario

        If validar_campos() = True Then
            itinerario.cod_itinerario = txtCodigo.Text
            itinerario.descripcion = txtDescripcion.Text
            itinerario.Categoria = txtCategoria.Text
            itinerario.borrado = 1
            bd.eliminar_itinerario(itinerario)
            MessageBox.Show("El itinerario se borro con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_itinerarios())
        Else
            MessageBox.Show("¡Se debe seleccionar un itinerario!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim itinerario As New Itinerario

        If validar_campos() = True Then
            itinerario.cod_itinerario = txtCodigo.Text
            itinerario.descripcion = txtDescripcion.Text
            itinerario.Categoria = txtCategoria.Text
            itinerario.borrado = 0
            bd.eliminar_itinerario(itinerario)
            MessageBox.Show("El itinerario se recupero con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_itinerarios())
        Else
            MessageBox.Show("¡Se debe seleccionar un itinerario!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class