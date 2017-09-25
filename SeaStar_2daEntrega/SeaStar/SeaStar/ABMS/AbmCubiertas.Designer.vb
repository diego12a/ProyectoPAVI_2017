<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmCubiertas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLegEncargado = New System.Windows.Forms.ComboBox()
        Me.cmbNavios = New System.Windows.Forms.ComboBox()
        Me.txtNumCubierta = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.gridCubiertas = New System.Windows.Forms.DataGridView()
        Me.colCodNavio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumCubierta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLegEncargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnResetear = New System.Windows.Forms.Button()
        CType(Me.gridCubiertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Cubierta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Navio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripcion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Encargado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbLegEncargado
        '
        Me.cmbLegEncargado.FormattingEnabled = True
        Me.cmbLegEncargado.Location = New System.Drawing.Point(131, 180)
        Me.cmbLegEncargado.Name = "cmbLegEncargado"
        Me.cmbLegEncargado.Size = New System.Drawing.Size(184, 21)
        Me.cmbLegEncargado.TabIndex = 1
        '
        'cmbNavios
        '
        Me.cmbNavios.FormattingEnabled = True
        Me.cmbNavios.Location = New System.Drawing.Point(131, 90)
        Me.cmbNavios.Name = "cmbNavios"
        Me.cmbNavios.Size = New System.Drawing.Size(184, 21)
        Me.cmbNavios.TabIndex = 1
        '
        'txtNumCubierta
        '
        Me.txtNumCubierta.Enabled = False
        Me.txtNumCubierta.Location = New System.Drawing.Point(131, 43)
        Me.txtNumCubierta.Name = "txtNumCubierta"
        Me.txtNumCubierta.Size = New System.Drawing.Size(184, 20)
        Me.txtNumCubierta.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 137)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(184, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'gridCubiertas
        '
        Me.gridCubiertas.AllowUserToAddRows = False
        Me.gridCubiertas.AllowUserToDeleteRows = False
        Me.gridCubiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCubiertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodNavio, Me.colNumCubierta, Me.colDescripcion, Me.colLegEncargado})
        Me.gridCubiertas.Location = New System.Drawing.Point(377, 18)
        Me.gridCubiertas.Name = "gridCubiertas"
        Me.gridCubiertas.ReadOnly = True
        Me.gridCubiertas.Size = New System.Drawing.Size(445, 316)
        Me.gridCubiertas.TabIndex = 3
        '
        'colCodNavio
        '
        Me.colCodNavio.HeaderText = "Navio"
        Me.colCodNavio.Name = "colCodNavio"
        Me.colCodNavio.ReadOnly = True
        '
        'colNumCubierta
        '
        Me.colNumCubierta.HeaderText = "Numero Cubierta"
        Me.colNumCubierta.Name = "colNumCubierta"
        Me.colNumCubierta.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'colLegEncargado
        '
        Me.colLegEncargado.HeaderText = "Encargado"
        Me.colLegEncargado.Name = "colLegEncargado"
        Me.colLegEncargado.ReadOnly = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(28, 340)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 52)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(131, 340)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(67, 52)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(248, 340)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(67, 52)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnResetear
        '
        Me.btnResetear.Location = New System.Drawing.Point(755, 340)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(67, 52)
        Me.btnResetear.TabIndex = 4
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'AbmCubiertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 404)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gridCubiertas)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNumCubierta)
        Me.Controls.Add(Me.cmbNavios)
        Me.Controls.Add(Me.cmbLegEncargado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Name = "AbmCubiertas"
        Me.Text = "AbmCubiertas"
        CType(Me.gridCubiertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLegEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNavios As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumCubierta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents gridCubiertas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnResetear As System.Windows.Forms.Button
    Friend WithEvents colCodNavio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumCubierta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLegEncargado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
