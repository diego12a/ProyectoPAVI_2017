<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarPuerto
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
        Me.txtCodPuerto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridPuertos = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        CType(Me.gridPuertos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodPuerto
        '
        Me.txtCodPuerto.Enabled = False
        Me.txtCodPuerto.Location = New System.Drawing.Point(114, 49)
        Me.txtCodPuerto.Name = "txtCodPuerto"
        Me.txtCodPuerto.Size = New System.Drawing.Size(76, 20)
        Me.txtCodPuerto.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo Puerto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridPuertos
        '
        Me.gridPuertos.AllowUserToAddRows = False
        Me.gridPuertos.AllowUserToDeleteRows = False
        Me.gridPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPuertos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNombre})
        Me.gridPuertos.Location = New System.Drawing.Point(250, 12)
        Me.gridPuertos.Name = "gridPuertos"
        Me.gridPuertos.ReadOnly = True
        Me.gridPuertos.Size = New System.Drawing.Size(222, 231)
        Me.gridPuertos.TabIndex = 11
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colID.HeaderText = "ID Puerto"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 77
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(114, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(114, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Nombre
        '
        Me.Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Nombre.Location = New System.Drawing.Point(8, 93)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(100, 23)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Location = New System.Drawing.Point(27, 249)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 37)
        Me.btnConfirmar.TabIndex = 12
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(391, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 37)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperar.Location = New System.Drawing.Point(143, 249)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(75, 37)
        Me.btnRecuperar.TabIndex = 13
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'EliminarPuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 303)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtCodPuerto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridPuertos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Nombre)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "EliminarPuerto"
        Me.Text = "EliminarPuerto"
        CType(Me.gridPuertos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodPuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridPuertos As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
End Class
