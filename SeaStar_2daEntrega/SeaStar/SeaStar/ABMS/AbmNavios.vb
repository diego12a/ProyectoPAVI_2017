Public Class AbmNavios

    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperNavio

 
    Private Function validar_campos() As Boolean
        If txtNombre.Text = " " Then
            MessageBox.Show("No se ingreso nombre", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
            Return False
        End If
        If Len(txtAltura.Text) = 0 Then
            MessageBox.Show("No se ingreso altura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAltura.Focus()
            Return False
        End If
        If txtDesplazamiento.Text = " " Then
            MessageBox.Show("No se ingreso desplazamiento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDesplazamiento.Focus()
            Return False
        End If
        If Len(txtEslora.Text) = 0 Then
            MessageBox.Show("No se ingreso eslora", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEslora.Focus()
            Return False
        End If
        If Len(txtManga.Text) = 0 Then
            MessageBox.Show("No se ingreso manga", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtManga.Focus()
            Return False
        End If
        If Len(txtCantPasajeros.Text) = 0 Then
            MessageBox.Show("No se ingreso cantidad maxima pasajeros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantPasajeros.Focus()
            Return False
        End If
        If Len(txtCantTripulantes.Text) = 0 Then
            MessageBox.Show("No se ingreso cantidad de tripulantes", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantTripulantes.Focus()
            Return False
        End If
        If Len(txtCantMotores.Text) = 0 Then
            MessageBox.Show("No se ingreso cantidad de motores", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantMotores.Focus()
            Return False
        End If
        If cmbTipo.SelectedIndex = -1 Then
            MessageBox.Show("No se ingreso clasificacion navio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbTipo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub limpiar()
        txtCodNavio.Text = " "
        txtNombre.Text = " "
        txtAltura.Text = " "
        txtDesplazamiento.Text = " "
        txtEslora.Text = " "
        txtManga.Text = " "
        txtCantPasajeros.Text = " "
        txtCantTripulantes.Text = " "
        txtCantMotores.Text = " "
        txtAutonomia.Text = " "
        cmbTipo.SelectedValue = 1
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        gridNavio.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To source.Rows.Count - 1
            gridNavio.Rows.Add(source.Rows(c)("cod_navio"), _
                               source.Rows(c)("nombre_navio"), _
                               source.Rows(c)("altura"), _
                               source.Rows(c)("autonomia"), _
                               source.Rows(c)("desplazamiento"), _
                               source.Rows(c)("eslora"), _
                               source.Rows(c)("manga"), _
                               source.Rows(c)("cant_max_pasaj"), _
                               source.Rows(c)("cant_tripulantes"), _
                               source.Rows(c)("cant_motores"), _
                               source.Rows(c)("tipo_clasif"))
        Next
    End Sub
    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable)
        combo.DataSource = tabla
        combo.ValueMember = tabla.Columns(0).ColumnName
        combo.DisplayMember = tabla.Columns(1).ColumnName
    End Sub
    Private Sub gridNavio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridNavio.CellContentClick
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        row_selected = gridNavio.CurrentRow
        txtCodNavio.Text = gridNavio.CurrentRow.Cells.Item("colCodNavio").Value
        txtNombre.Text = gridNavio.CurrentRow.Cells.Item("colNombre").Value
        txtAltura.Text = gridNavio.CurrentRow.Cells.Item("colAltura").Value
        txtAutonomia.Text = gridNavio.CurrentRow.Cells.Item("colAutonomia").Value
        txtDesplazamiento.Text = gridNavio.CurrentRow.Cells.Item("colDesplazamiento").Value
        txtEslora.Text = gridNavio.CurrentRow.Cells.Item("colEslora").Value
        txtManga.Text = gridNavio.CurrentRow.Cells.Item("colManga").Value
        txtCantPasajeros.Text = gridNavio.CurrentRow.Cells.Item("colCantMaxPasaj").Value
        txtCantTripulantes.Text = gridNavio.CurrentRow.Cells.Item("colCantTripulantes").Value
        txtCantMotores.Text = gridNavio.CurrentRow.Cells.Item("colCantMotores").Value
        cmbTipo.SelectedValue = gridNavio.CurrentRow.Cells.Item("colTipoClasif").Value
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarNavio.ShowDialog()
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        limpiar()
        llenar_grid(bd.conocer_navio())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim navio As New Navio

        If validar_campos() = True Then
            navio.nombre_navio = txtNombre.Text
            navio.altura = txtAltura.Text
            navio.autonomia = txtAutonomia.Text
            navio.desplazamiento = txtDesplazamiento.Text
            navio.eslora = txtEslora.Text
            navio.manga = txtManga.Text
            navio.cant_max_pasaj = txtCantPasajeros.Text
            navio.cant_tripulantes = txtCantTripulantes.Text
            navio.cant_motores = txtCantMotores.Text
            navio.tipo_clasif = cmbTipo.SelectedValue
            navio.borrado = 0
            bd.guardar_navio(navio)
            llenar_grid(bd.conocer_navio())
            limpiar()
        End If
    End Sub

    Private Sub txtEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim navio As New Navio
        If validar_campos() = True Then
            navio.cod_navio = txtCodNavio.Text
            navio.nombre_navio = txtNombre.Text
            navio.altura = txtAltura.Text
            navio.autonomia = txtAutonomia.Text
            navio.desplazamiento = txtDesplazamiento.Text
            navio.eslora = txtEslora.Text
            navio.manga = txtManga.Text
            navio.cant_max_pasaj = txtCantPasajeros.Text
            navio.cant_tripulantes = txtCantTripulantes.Text
            navio.cant_motores = txtCantMotores.Text
            navio.tipo_clasif = cmbTipo.SelectedValue
            navio.borrado = 0

            bd.modificar_navio(navio)
            limpiar()
            llenar_grid(bd.conocer_navio())
        End If
    End Sub

    Private Sub AbmNavios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipo, bd.conocer_clasificacion_navios())
        llenar_grid(bd.conocer_navio())
        limpiar()
    End Sub
End Class