Public Class EliminarPuerto

    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperPuerto
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim puerto As New Puerto

        If validar_campos() = True Then
            puerto.cod_puerto = txtCodPuerto.Text
            puerto.nombre = txtNombre.Text
            puerto.borrado = 1
            bd.eliminar_puerto(puerto)
            MessageBox.Show("El puerto se borro con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_puertos())
        Else
            MessageBox.Show("¡Se debe seleccionar un puerto!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        End If
    End Sub
    Private Sub llenar_grid(ByVal source As DataTable)
        gridPuertos.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To source.Rows.Count - 1
            gridPuertos.Rows.Add(source.Rows(c)("cod_puerto"), _
                               source.Rows(c)("nombre"))
        Next
    End Sub
    Private Sub gridPuertos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridPuertos.CellContentClick
        row_selected = gridPuertos.CurrentRow
        txtCodPuerto.Text = gridPuertos.CurrentRow.Cells.Item("colID").Value
        txtNombre.Text = gridPuertos.CurrentRow.Cells.Item("colNombre").Value
    End Sub

    Private Function validar_campos() As Boolean
        If txtNombre.Text = " " Then
            Return False
        Else
            Return True
        End If
        If txtCodPuerto.Text = " " Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub limpiar()
        txtNombre.Text = " "
        txtCodPuerto.Text = " "
        txtNombre.Focus()
    End Sub

    Private Sub EliminarPuerto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bd As New BDHelperPuerto
        llenar_grid(bd.conocer_todos_puertos())
        limpiar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim puerto As New Puerto
        If validar_campos() = True Then
            puerto.cod_puerto = txtCodPuerto.Text
            puerto.nombre = txtNombre.Text
            puerto.borrado = 0
            bd.eliminar_puerto(puerto)
            MessageBox.Show("El puerto se recupero con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_puertos())
        Else
            MessageBox.Show("¡Se debe seleccionar un puerto!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        End If
    End Sub
End Class