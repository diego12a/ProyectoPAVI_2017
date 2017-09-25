Public Class AbmCubiertas

    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperCubierta
  
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarCubierta.ShowDialog()
    End Sub
    Private Sub AbmCubiertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbNavios, bd.conocer_navios())
        cargarCombo(cmbLegEncargado, bd.conocer_encargados)
        llenar_grid(bd.conocer_cubiertas())
        limpiar()
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable)
        combo.DataSource = tabla
        combo.ValueMember = tabla.Columns(0).ColumnName
        combo.DisplayMember = tabla.Columns(1).ColumnName
    End Sub
    Private Function validar_campos() As Boolean

        If txtDescripcion.Text = " " Then
            MessageBox.Show("No se ingreso descripcion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Focus()
            Return False
        End If
        If cmbNavios.SelectedIndex = -1 Then
            MessageBox.Show("No se ingreso navio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbNavios.Focus()
            Return False
        End If
        If cmbLegEncargado.SelectedIndex = -1 Then
            MessageBox.Show("No se ingreso Encargado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbLegEncargado.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub limpiar()
        txtNumCubierta.Text = " "
        txtDescripcion.Text = " "
        cmbNavios.SelectedValue = 1
        cmbLegEncargado.SelectedValue = 1
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        cmbNavios.Enabled = True
        cmbNavios.Focus()
    End Sub
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

    Private Sub gridCubiertas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCubiertas.CellContentClick
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        cmbNavios.Enabled = False
        row_selected = gridCubiertas.CurrentRow
        txtNumCubierta.Text = gridCubiertas.CurrentRow.Cells.Item("colNumCubierta").Value
        cmbNavios.SelectedValue = gridCubiertas.CurrentRow.Cells.Item("colCodNavio").Value
        txtDescripcion.Text = gridCubiertas.CurrentRow.Cells.Item("colDescripcion").Value
        cmbLegEncargado.SelectedValue = gridCubiertas.CurrentRow.Cells.Item("colLegEncargado").Value
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        cmbNavios.Enabled = True
        limpiar()
        llenar_grid(bd.conocer_cubiertas())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cubierta As New Cubierta

        If validar_campos() = True Then
            cubierta.cod_navio = cmbNavios.SelectedValue
            cubierta.descripcion = txtDescripcion.Text
            cubierta.leg_encargado = cmbLegEncargado.SelectedValue
            cubierta.borrado = 0
            bd.guardar_cubierta(cubierta)
            llenar_grid(bd.conocer_cubiertas())
            limpiar()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cubierta As New Cubierta
        If validar_campos() = True Then
            cubierta.num_cubierta = txtNumCubierta.Text
            cubierta.cod_navio = cmbNavios.SelectedValue
            cubierta.descripcion = txtDescripcion.Text
            cubierta.leg_encargado = cmbLegEncargado.SelectedValue
            cubierta.borrado = 0
            bd.modificar_cubierta(cubierta)
            limpiar()
            llenar_grid(bd.conocer_cubiertas())

        End If
    End Sub
End Class