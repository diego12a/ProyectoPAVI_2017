Public Class EliminarNavio
    Friend row_selected As DataGridViewRow
    Dim bd As New BDHelperNavio

    Private Sub EliminarNavio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipo, bd.conocer_clasificacion_navios())
        llenar_grid(bd.conocer_todos_navios())
        limpiar()
    End Sub


    Private Function validar_campos() As Boolean
        If txtNombre.Text = " " Then
            Return False
        End If
        If Len(txtAltura.Text) = 0 Then
            Return False
        End If
        If txtDesplazamiento.Text = " " Then
            Return False
        End If
        If Len(txtEslora.Text) = 0 Then
            Return False
        End If
        If Len(txtManga.Text) = 0 Then
            Return False
        End If
        If Len(txtCantPasajeros.Text) = 0 Then
            Return False
        End If
        If Len(txtCantTripulantes.Text) = 0 Then
            Return False
        End If
        If Len(txtCantMotores.Text) = 0 Then
            Return False
        End If
        If cmbTipo.SelectedValue = -1 Then
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

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
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
            navio.borrado = 1
            bd.eliminar_navio(navio)
            MessageBox.Show("El puerto se borro con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_navios())
        Else
            MessageBox.Show("¡Se debe seleccionar un navio!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
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
            bd.eliminar_navio(navio)
            MessageBox.Show("El puerto se recupero con exito!", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            llenar_grid(bd.conocer_todos_navios())
        Else
            MessageBox.Show("¡Se debe seleccionar un puerto!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub gridNavio_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gridNavio.CellContentClick
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
End Class