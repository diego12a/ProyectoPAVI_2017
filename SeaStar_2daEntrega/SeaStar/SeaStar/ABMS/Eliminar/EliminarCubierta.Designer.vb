<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarCubierta
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
        Me.gridCubiertas = New System.Windows.Forms.DataGridView()
        Me.colCodNavio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumCubierta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLegEncargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNumCubierta = New System.Windows.Forms.TextBox()
        Me.cmbNavios = New System.Windows.Forms.ComboBox()
        Me.cmbLegEncargado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.gridCubiertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCubiertas
        '
        Me.gridCubiertas.AllowUserToAddRows = False
        Me.gridCubiertas.AllowUserToDeleteRows = False
        Me.gridCubiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCubiertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodNavio, Me.colNumCubierta, Me.colDescripcion, Me.colLegEncargado})
        Me.gridCubiertas.Location = New System.Drawing.Point(373, 12)
        Me.gridCubiertas.Name = "gridCubiertas"
        Me.gridCubiertas.ReadOnly = True
        Me.gridCubiertas.Size = New System.Drawing.Size(445, 316)
        Me.gridCubiertas.TabIndex = 12
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
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 131)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(184, 20)
        Me.txtDescripcion.TabIndex = 10
        '
        'txtNumCubierta
        '
        Me.txtNumCubierta.Enabled = False
        Me.txtNumCubierta.Location = New System.Drawing.Point(127, 37)
        Me.txtNumCubierta.Name = "txtNumCubierta"
        Me.txtNumCubierta.Size = New System.Drawing.Size(184, 20)
        Me.txtNumCubierta.TabIndex = 11
        '
        'cmbNavios
        '
        Me.cmbNavios.Enabled = False
        Me.cmbNavios.FormattingEnabled = True
        Me.cmbNavios.Location = New System.Drawing.Point(127, 84)
        Me.cmbNavios.Name = "cmbNavios"
        Me.cmbNavios.Size = New System.Drawing.Size(184, 21)
        Me.cmbNavios.TabIndex = 8
        '
        'cmbLegEncargado
        '
        Me.cmbLegEncargado.Enabled = False
        Me.cmbLegEncargado.FormattingEnabled = True
        Me.cmbLegEncargado.Location = New System.Drawing.Point(127, 174)
        Me.cmbLegEncargado.Name = "cmbLegEncargado"
        Me.cmbLegEncargado.Size = New System.Drawing.Size(184, 21)
        Me.cmbLegEncargado.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(8, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Encargado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(8, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(8, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Navio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero Cubierta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperar.Location = New System.Drawing.Point(153, 341)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(75, 37)
        Me.btnRecuperar.TabIndex = 16
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(737, 341)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 37)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Location = New System.Drawing.Point(27, 341)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 37)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'EliminarCubierta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 390)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
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
        Me.Name = "EliminarCubierta"
        Me.Text = "EliminarCubierta"
        CType(Me.gridCubiertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridCubiertas As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCubierta As System.Windows.Forms.TextBox
    Friend WithEvents cmbNavios As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLegEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents colCodNavio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumCubierta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLegEncargado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
