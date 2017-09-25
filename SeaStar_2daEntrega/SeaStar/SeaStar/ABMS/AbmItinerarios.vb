Public Class AbmItinerarios
    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperItinerario

    Private Sub AbmItinerarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grid(bd.conocer_itinerarios())
        limpiar()
    End Sub
    Private Function validar_campos() As Boolean
        If txtDescripcion.Text = " " Then
            MessageBox.Show("No se ingreso Descripcion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Focus()
            Return False
        End If
        If txtCategoria.Text = " " Then
            MessageBox.Show("No se ingreso Categoria", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCategoria.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim itinerario As New Itinerario
        If validar_campos() = True Then
            itinerario.descripcion = txtDescripcion.Text
            itinerario.Categoria = txtCategoria.Text
            itinerario.borrado = 0
            bd.guardar_itinerario(itinerario)
            llenar_grid(bd.conocer_itinerarios())
            limpiar()
        End If
    End Sub
    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        limpiar()
        llenar_grid(bd.conocer_itinerarios())
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim itinerario As New Itinerario

        If validar_campos() = True Then

            itinerario.cod_itinerario = txtCodigo.Text
            itinerario.descripcion = txtDescripcion.Text
            itinerario.Categoria = txtCategoria.Text
            itinerario.borrado = 0

            bd.modificar_itinerario(itinerario)

            limpiar()
            llenar_grid(bd.conocer_itinerarios())

        End If
    End Sub

    Private Sub limpiar()
        txtDescripcion.Text = " "
        txtCategoria.Text = " "
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        txtDescripcion.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarItinerario.ShowDialog()
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
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        row_selected = gridItinerarios.CurrentRow
        txtCodigo.Text = gridItinerarios.CurrentRow.Cells.Item("colCodItinerario").Value
        txtDescripcion.Text = gridItinerarios.CurrentRow.Cells.Item("colDescripcion").Value
        txtCategoria.Text = gridItinerarios.CurrentRow.Cells.Item("colCategoria").Value
    End Sub


End Class