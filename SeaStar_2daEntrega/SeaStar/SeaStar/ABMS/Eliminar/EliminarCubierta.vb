Public Class EliminarCubierta
    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperCubierta
    Private Sub EliminarCubierta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbNavios, bd.conocer_navios())
        cargarCombo(cmbLegEncargado, bd.conocer_encargados)
        llenar_grid(bd.conocer_todas_cubiertas())
        limpiar()
    End Sub
    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable)
        combo.DataSource = tabla
        combo.ValueMember = tabla.Columns(0).ColumnName
        combo.DisplayMember = tabla.Columns(1).ColumnName
    End Sub

    Private Sub gridCubiertas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCubiertas.CellContentClick
        row_selected = gridCubiertas.CurrentRow
        txtNumCubierta.Text = gridCubiertas.CurrentRow.Cells.Item("colNumCubierta").Value
        cmbNavios.SelectedValue = gridCubiertas.CurrentRow.Cells.Item("colCodNavio").Value
        txtDescripcion.Text = gridCubiertas.CurrentRow.Cells.Item("colDescripcion").Value
        cmbLegEncargado.SelectedValue = gridCubiertas.CurrentRow.Cells.Item("colLegEncargado").Value
    End Sub
    Private Sub limpiar()
        txtNumCubierta.Text = " "
        txtDescripcion.Text = " "
        cmbNavios.SelectedValue = 1
        cmbLegEncargado.SelectedValue = 1
    End Sub
    Private Function validar_campos() As Boolean
        If txtDescripcion.Text = " " Then
            Return False
        End If
        If cmbNavios.SelectedValue = -1 Then
            Return False
        End If
        If cmbLegEncargado.SelectedValue = -1 Then
            Return False
        End If
        Return True
    End Function
    Private Sub llenar_grid(ByVal source As DataTable)
        gridCubiertas.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To source.Rows.Count - 1
            gridCubiertas.Rows.Add(source.Rows(c)("cod_navio"), _
                               source.Rows(c)("num_cubierta"), _
                               source.Rows(c)("descripcion"), _
                               source.Rows(c)("leg_encargado"))
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim cubierta As New Cubierta
        If validar_campos() = True Then
            cubierta.num_cubierta = txtNumCubierta.Text
            Cubierta.cod_navio = cmbNavios.SelectedValue
            cubierta.descripcion = txtDescripcion.Text
            cubierta.leg_encargado = cmbLegEncargado.SelectedValue
            bd.eliminar_cubierta(cubierta)
            MessageBox.Show("La cubierta se borro con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todas_cubiertas())
        Else
            MessageBox.Show("¡Se debe seleccionar una cubierta!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim cubierta As New Cubierta
        If validar_campos() = True Then
            cubierta.num_cubierta = txtNumCubierta.Text
            cubierta.cod_navio = cmbNavios.SelectedValue
            cubierta.borrado = 0
            bd.modificar_cubierta(cubierta)
            MessageBox.Show("La cubierta se recupero con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todas_cubiertas())
        Else
            MessageBox.Show("¡Se debe seleccionar una cubierta!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class