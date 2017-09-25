<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmNavios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gridNavio = New System.Windows.Forms.DataGridView()
        Me.colCodNavio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAltura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAutonomia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesplazamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEslora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colManga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantMaxPasaj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantTripulantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantMotores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoClasif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDesplazamiento = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Navio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodNavio = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.MaskedTextBox()
        Me.txtEslora = New System.Windows.Forms.MaskedTextBox()
        Me.txtManga = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantPasajeros = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantTripulantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantMotores = New System.Windows.Forms.MaskedTextBox()
        Me.txtAutonomia = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.gridNavio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResetear
        '
        Me.btnResetear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetear.Location = New System.Drawing.Point(1219, 425)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(74, 46)
        Me.btnResetear.TabIndex = 14
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(262, 426)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(74, 46)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Location = New System.Drawing.Point(39, 426)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 46)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gridNavio
        '
        Me.gridNavio.AllowUserToAddRows = False
        Me.gridNavio.AllowUserToDeleteRows = False
        Me.gridNavio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNavio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodNavio, Me.colNombre, Me.colAltura, Me.colAutonomia, Me.colDesplazamiento, Me.colEslora, Me.colManga, Me.colCantMaxPasaj, Me.colCantTripulantes, Me.colCantMotores, Me.colTipoClasif})
        Me.gridNavio.Location = New System.Drawing.Point(360, 22)
        Me.gridNavio.Name = "gridNavio"
        Me.gridNavio.ReadOnly = True
        Me.gridNavio.Size = New System.Drawing.Size(933, 384)
        Me.gridNavio.TabIndex = 15
        '
        'colCodNavio
        '
        Me.colCodNavio.HeaderText = "Codigo"
        Me.colCodNavio.Name = "colCodNavio"
        Me.colCodNavio.ReadOnly = True
        Me.colCodNavio.Visible = False
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colAltura
        '
        Me.colAltura.HeaderText = "Altura"
        Me.colAltura.Name = "colAltura"
        Me.colAltura.ReadOnly = True
        '
        'colAutonomia
        '
        Me.colAutonomia.HeaderText = "Autonomia"
        Me.colAutonomia.Name = "colAutonomia"
        Me.colAutonomia.ReadOnly = True
        '
        'colDesplazamiento
        '
        Me.colDesplazamiento.HeaderText = "Desplazamiento"
        Me.colDesplazamiento.Name = "colDesplazamiento"
        Me.colDesplazamiento.ReadOnly = True
        '
        'colEslora
        '
        Me.colEslora.HeaderText = "Eslora"
        Me.colEslora.Name = "colEslora"
        Me.colEslora.ReadOnly = True
        '
        'colManga
        '
        Me.colManga.HeaderText = "Manga"
        Me.colManga.Name = "colManga"
        Me.colManga.ReadOnly = True
        '
        'colCantMaxPasaj
        '
        Me.colCantMaxPasaj.HeaderText = "Pasajeros"
        Me.colCantMaxPasaj.Name = "colCantMaxPasaj"
        Me.colCantMaxPasaj.ReadOnly = True
        '
        'colCantTripulantes
        '
        Me.colCantTripulantes.HeaderText = "Tripulantes"
        Me.colCantTripulantes.Name = "colCantTripulantes"
        Me.colCantTripulantes.ReadOnly = True
        '
        'colCantMotores
        '
        Me.colCantMotores.HeaderText = "Motores"
        Me.colCantMotores.Name = "colCantMotores"
        Me.colCantMotores.ReadOnly = True
        '
        'colTipoClasif
        '
        Me.colTipoClasif.HeaderText = "Tipo"
        Me.colTipoClasif.Name = "colTipoClasif"
        Me.colTipoClasif.ReadOnly = True
        '
        'txtDesplazamiento
        '
        Me.txtDesplazamiento.Location = New System.Drawing.Point(153, 122)
        Me.txtDesplazamiento.Name = "txtDesplazamiento"
        Me.txtDesplazamiento.Size = New System.Drawing.Size(187, 20)
        Me.txtDesplazamiento.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(153, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Manga"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Eslora"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Desplazamiento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Altura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Navio
        '
        Me.Navio.BackColor = System.Drawing.Color.Transparent
        Me.Navio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Navio.Location = New System.Drawing.Point(12, 58)
        Me.Navio.Name = "Navio"
        Me.Navio.Size = New System.Drawing.Size(122, 23)
        Me.Navio.TabIndex = 7
        Me.Navio.Text = "Nombre"
        Me.Navio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Autonomia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(12, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(153, 367)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(187, 21)
        Me.cmbTipo.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = " Cantidad Pasajeros"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(12, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Cantidad Tripulantes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cantidad Motores"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(12, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Codigo Navio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodNavio
        '
        Me.txtCodNavio.Enabled = False
        Me.txtCodNavio.Location = New System.Drawing.Point(153, 22)
        Me.txtCodNavio.Name = "txtCodNavio"
        Me.txtCodNavio.Size = New System.Drawing.Size(187, 20)
        Me.txtCodNavio.TabIndex = 0
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(153, 90)
        Me.txtAltura.Mask = "99999999"
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(187, 20)
        Me.txtAltura.TabIndex = 2
        '
        'txtEslora
        '
        Me.txtEslora.Location = New System.Drawing.Point(153, 159)
        Me.txtEslora.Mask = "9999999999"
        Me.txtEslora.Name = "txtEslora"
        Me.txtEslora.Size = New System.Drawing.Size(187, 20)
        Me.txtEslora.TabIndex = 4
        '
        'txtManga
        '
        Me.txtManga.Location = New System.Drawing.Point(153, 193)
        Me.txtManga.Mask = "9999999999"
        Me.txtManga.Name = "txtManga"
        Me.txtManga.Size = New System.Drawing.Size(187, 20)
        Me.txtManga.TabIndex = 5
        '
        'txtCantPasajeros
        '
        Me.txtCantPasajeros.Location = New System.Drawing.Point(153, 263)
        Me.txtCantPasajeros.Mask = "9999999999"
        Me.txtCantPasajeros.Name = "txtCantPasajeros"
        Me.txtCantPasajeros.Size = New System.Drawing.Size(187, 20)
        Me.txtCantPasajeros.TabIndex = 7
        '
        'txtCantTripulantes
        '
        Me.txtCantTripulantes.Location = New System.Drawing.Point(153, 298)
        Me.txtCantTripulantes.Mask = "9999999999"
        Me.txtCantTripulantes.Name = "txtCantTripulantes"
        Me.txtCantTripulantes.Size = New System.Drawing.Size(187, 20)
        Me.txtCantTripulantes.TabIndex = 8
        '
        'txtCantMotores
        '
        Me.txtCantMotores.Location = New System.Drawing.Point(153, 335)
        Me.txtCantMotores.Mask = "9999999999"
        Me.txtCantMotores.Name = "txtCantMotores"
        Me.txtCantMotores.Size = New System.Drawing.Size(187, 20)
        Me.txtCantMotores.TabIndex = 9
        '
        'txtAutonomia
        '
        Me.txtAutonomia.Location = New System.Drawing.Point(153, 227)
        Me.txtAutonomia.Name = "txtAutonomia"
        Me.txtAutonomia.Size = New System.Drawing.Size(187, 20)
        Me.txtAutonomia.TabIndex = 6
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(153, 426)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 46)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'AbmNavios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1312, 483)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtAutonomia)
        Me.Controls.Add(Me.txtCantMotores)
        Me.Controls.Add(Me.txtCantTripulantes)
        Me.Controls.Add(Me.txtCantPasajeros)
        Me.Controls.Add(Me.txtManga)
        Me.Controls.Add(Me.txtEslora)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gridNavio)
        Me.Controls.Add(Me.txtDesplazamiento)
        Me.Controls.Add(Me.txtCodNavio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Navio)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Name = "AbmNavios"
        Me.Text = "AbmNavio"
        CType(Me.gridNavio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnResetear As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gridNavio As System.Windows.Forms.DataGridView
    Friend WithEvents txtDesplazamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Navio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCodNavio As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEslora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtManga As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCantPasajeros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCantTripulantes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCantMotores As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAutonomia As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents colCodNavio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAltura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAutonomia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesplazamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEslora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colManga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantMaxPasaj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantTripulantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantMotores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoClasif As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
