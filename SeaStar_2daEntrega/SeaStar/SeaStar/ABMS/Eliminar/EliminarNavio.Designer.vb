<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarNavio
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
        Me.txtAutonomia = New System.Windows.Forms.TextBox()
        Me.txtCantMotores = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantTripulantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantPasajeros = New System.Windows.Forms.MaskedTextBox()
        Me.txtManga = New System.Windows.Forms.MaskedTextBox()
        Me.txtEslora = New System.Windows.Forms.MaskedTextBox()
        Me.txtAltura = New System.Windows.Forms.MaskedTextBox()
        Me.txtDesplazamiento = New System.Windows.Forms.TextBox()
        Me.txtCodNavio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Navio = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
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
        CType(Me.gridNavio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAutonomia
        '
        Me.txtAutonomia.Enabled = False
        Me.txtAutonomia.Location = New System.Drawing.Point(146, 247)
        Me.txtAutonomia.Name = "txtAutonomia"
        Me.txtAutonomia.Size = New System.Drawing.Size(187, 20)
        Me.txtAutonomia.TabIndex = 22
        '
        'txtCantMotores
        '
        Me.txtCantMotores.Enabled = False
        Me.txtCantMotores.Location = New System.Drawing.Point(146, 355)
        Me.txtCantMotores.Mask = "9999999999"
        Me.txtCantMotores.Name = "txtCantMotores"
        Me.txtCantMotores.Size = New System.Drawing.Size(187, 20)
        Me.txtCantMotores.TabIndex = 27
        '
        'txtCantTripulantes
        '
        Me.txtCantTripulantes.Enabled = False
        Me.txtCantTripulantes.Location = New System.Drawing.Point(146, 318)
        Me.txtCantTripulantes.Mask = "9999999999"
        Me.txtCantTripulantes.Name = "txtCantTripulantes"
        Me.txtCantTripulantes.Size = New System.Drawing.Size(187, 20)
        Me.txtCantTripulantes.TabIndex = 25
        '
        'txtCantPasajeros
        '
        Me.txtCantPasajeros.Enabled = False
        Me.txtCantPasajeros.Location = New System.Drawing.Point(146, 283)
        Me.txtCantPasajeros.Mask = "9999999999"
        Me.txtCantPasajeros.Name = "txtCantPasajeros"
        Me.txtCantPasajeros.Size = New System.Drawing.Size(187, 20)
        Me.txtCantPasajeros.TabIndex = 23
        '
        'txtManga
        '
        Me.txtManga.Enabled = False
        Me.txtManga.Location = New System.Drawing.Point(146, 210)
        Me.txtManga.Mask = "9999999999"
        Me.txtManga.Name = "txtManga"
        Me.txtManga.Size = New System.Drawing.Size(187, 20)
        Me.txtManga.TabIndex = 21
        '
        'txtEslora
        '
        Me.txtEslora.Enabled = False
        Me.txtEslora.Location = New System.Drawing.Point(146, 179)
        Me.txtEslora.Mask = "9999999999"
        Me.txtEslora.Name = "txtEslora"
        Me.txtEslora.Size = New System.Drawing.Size(187, 20)
        Me.txtEslora.TabIndex = 20
        '
        'txtAltura
        '
        Me.txtAltura.Enabled = False
        Me.txtAltura.Location = New System.Drawing.Point(146, 110)
        Me.txtAltura.Mask = "99999999"
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(187, 20)
        Me.txtAltura.TabIndex = 18
        '
        'txtDesplazamiento
        '
        Me.txtDesplazamiento.Enabled = False
        Me.txtDesplazamiento.Location = New System.Drawing.Point(146, 142)
        Me.txtDesplazamiento.Name = "txtDesplazamiento"
        Me.txtDesplazamiento.Size = New System.Drawing.Size(187, 20)
        Me.txtDesplazamiento.TabIndex = 19
        '
        'txtCodNavio
        '
        Me.txtCodNavio.Enabled = False
        Me.txtCodNavio.Location = New System.Drawing.Point(146, 42)
        Me.txtCodNavio.Name = "txtCodNavio"
        Me.txtCodNavio.Size = New System.Drawing.Size(187, 20)
        Me.txtCodNavio.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(146, 75)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 20)
        Me.txtNombre.TabIndex = 17
        '
        'cmbTipo
        '
        Me.cmbTipo.Enabled = False
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(146, 387)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(187, 21)
        Me.cmbTipo.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(5, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Cantidad Motores"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(5, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Cantidad Tripulantes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(5, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = " Cantidad Pasajeros"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(5, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Autonomia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(5, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Manga"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(5, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Eslora"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(5, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Tipo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(5, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Desplazamiento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(5, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Altura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Navio
        '
        Me.Navio.BackColor = System.Drawing.Color.Transparent
        Me.Navio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Navio.Location = New System.Drawing.Point(5, 75)
        Me.Navio.Name = "Navio"
        Me.Navio.Size = New System.Drawing.Size(122, 23)
        Me.Navio.TabIndex = 24
        Me.Navio.Text = "Nombre"
        Me.Navio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(5, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 23)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Codigo Navio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Location = New System.Drawing.Point(28, 439)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 53)
        Me.btnConfirmar.TabIndex = 39
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(1196, 439)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 53)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperar.Location = New System.Drawing.Point(145, 439)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(75, 53)
        Me.btnRecuperar.TabIndex = 39
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'gridNavio
        '
        Me.gridNavio.AllowUserToAddRows = False
        Me.gridNavio.AllowUserToDeleteRows = False
        Me.gridNavio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNavio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodNavio, Me.colNombre, Me.colAltura, Me.colAutonomia, Me.colDesplazamiento, Me.colEslora, Me.colManga, Me.colCantMaxPasaj, Me.colCantTripulantes, Me.colCantMotores, Me.colTipoClasif})
        Me.gridNavio.Location = New System.Drawing.Point(351, 26)
        Me.gridNavio.Name = "gridNavio"
        Me.gridNavio.ReadOnly = True
        Me.gridNavio.Size = New System.Drawing.Size(920, 384)
        Me.gridNavio.TabIndex = 40
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
        'EliminarNavio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1287, 500)
        Me.Controls.Add(Me.gridNavio)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAutonomia)
        Me.Controls.Add(Me.txtCantMotores)
        Me.Controls.Add(Me.txtCantTripulantes)
        Me.Controls.Add(Me.txtCantPasajeros)
        Me.Controls.Add(Me.txtManga)
        Me.Controls.Add(Me.txtEslora)
        Me.Controls.Add(Me.txtAltura)
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
        Me.Controls.Add(Me.Navio)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Name = "EliminarNavio"
        Me.Text = "EliminarNavio"
        CType(Me.gridNavio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAutonomia As System.Windows.Forms.TextBox
    Friend WithEvents txtCantMotores As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCantTripulantes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCantPasajeros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtManga As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEslora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAltura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDesplazamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCodNavio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Navio As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents gridNavio As System.Windows.Forms.DataGridView
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
