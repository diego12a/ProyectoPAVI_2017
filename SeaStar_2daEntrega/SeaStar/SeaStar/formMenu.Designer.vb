<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabAbm = New System.Windows.Forms.TabPage()
        Me.btnPuertos = New System.Windows.Forms.Button()
        Me.btnAbmCubiertas = New System.Windows.Forms.Button()
        Me.btnAbmNavios = New System.Windows.Forms.Button()
        Me.btnAbmItinerarios = New System.Windows.Forms.Button()
        Me.tabProcesos = New System.Windows.Forms.TabPage()
        Me.tabListadosYreportes = New System.Windows.Forms.TabPage()
        Me.tabEstadisticas = New System.Windows.Forms.TabPage()
        Me.tabMenu.SuspendLayout()
        Me.tabAbm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMenu
        '
        Me.tabMenu.Controls.Add(Me.tabAbm)
        Me.tabMenu.Controls.Add(Me.tabProcesos)
        Me.tabMenu.Controls.Add(Me.tabListadosYreportes)
        Me.tabMenu.Controls.Add(Me.tabEstadisticas)
        Me.tabMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabMenu.Location = New System.Drawing.Point(-4, 1)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(697, 498)
        Me.tabMenu.TabIndex = 1
        '
        'tabAbm
        '
        Me.tabAbm.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg2
        Me.tabAbm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabAbm.Controls.Add(Me.btnPuertos)
        Me.tabAbm.Controls.Add(Me.btnAbmCubiertas)
        Me.tabAbm.Controls.Add(Me.btnAbmNavios)
        Me.tabAbm.Controls.Add(Me.btnAbmItinerarios)
        Me.tabAbm.ImageKey = "(none)"
        Me.tabAbm.Location = New System.Drawing.Point(4, 22)
        Me.tabAbm.Name = "tabAbm"
        Me.tabAbm.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbm.Size = New System.Drawing.Size(689, 472)
        Me.tabAbm.TabIndex = 0
        Me.tabAbm.Text = "ABM'S"
        Me.tabAbm.UseVisualStyleBackColor = True
        '
        'btnPuertos
        '
        Me.btnPuertos.BackColor = System.Drawing.Color.Transparent
        Me.btnPuertos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPuertos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPuertos.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuertos.ForeColor = System.Drawing.Color.Transparent
        Me.btnPuertos.Location = New System.Drawing.Point(364, 266)
        Me.btnPuertos.Name = "btnPuertos"
        Me.btnPuertos.Size = New System.Drawing.Size(136, 110)
        Me.btnPuertos.TabIndex = 0
        Me.btnPuertos.Text = "Puertos"
        Me.btnPuertos.UseVisualStyleBackColor = False
        '
        'btnAbmCubiertas
        '
        Me.btnAbmCubiertas.BackColor = System.Drawing.Color.Transparent
        Me.btnAbmCubiertas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbmCubiertas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbmCubiertas.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbmCubiertas.ForeColor = System.Drawing.Color.Transparent
        Me.btnAbmCubiertas.Location = New System.Drawing.Point(364, 77)
        Me.btnAbmCubiertas.Name = "btnAbmCubiertas"
        Me.btnAbmCubiertas.Size = New System.Drawing.Size(136, 110)
        Me.btnAbmCubiertas.TabIndex = 0
        Me.btnAbmCubiertas.Text = "Cubiertas"
        Me.btnAbmCubiertas.UseVisualStyleBackColor = False
        '
        'btnAbmNavios
        '
        Me.btnAbmNavios.BackColor = System.Drawing.Color.Transparent
        Me.btnAbmNavios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbmNavios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbmNavios.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbmNavios.ForeColor = System.Drawing.Color.Transparent
        Me.btnAbmNavios.Location = New System.Drawing.Point(97, 266)
        Me.btnAbmNavios.Name = "btnAbmNavios"
        Me.btnAbmNavios.Size = New System.Drawing.Size(136, 110)
        Me.btnAbmNavios.TabIndex = 0
        Me.btnAbmNavios.Text = "Navios"
        Me.btnAbmNavios.UseVisualStyleBackColor = False
        '
        'btnAbmItinerarios
        '
        Me.btnAbmItinerarios.BackColor = System.Drawing.Color.Transparent
        Me.btnAbmItinerarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbmItinerarios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbmItinerarios.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbmItinerarios.ForeColor = System.Drawing.Color.Transparent
        Me.btnAbmItinerarios.Location = New System.Drawing.Point(97, 77)
        Me.btnAbmItinerarios.Name = "btnAbmItinerarios"
        Me.btnAbmItinerarios.Size = New System.Drawing.Size(136, 110)
        Me.btnAbmItinerarios.TabIndex = 0
        Me.btnAbmItinerarios.Text = "Itinerarios"
        Me.btnAbmItinerarios.UseVisualStyleBackColor = False
        '
        'tabProcesos
        '
        Me.tabProcesos.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg3
        Me.tabProcesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabProcesos.Location = New System.Drawing.Point(4, 22)
        Me.tabProcesos.Name = "tabProcesos"
        Me.tabProcesos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProcesos.Size = New System.Drawing.Size(689, 472)
        Me.tabProcesos.TabIndex = 1
        Me.tabProcesos.Text = "Procesos"
        Me.tabProcesos.UseVisualStyleBackColor = True
        '
        'tabListadosYreportes
        '
        Me.tabListadosYreportes.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg
        Me.tabListadosYreportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabListadosYreportes.Location = New System.Drawing.Point(4, 22)
        Me.tabListadosYreportes.Name = "tabListadosYreportes"
        Me.tabListadosYreportes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabListadosYreportes.Size = New System.Drawing.Size(689, 472)
        Me.tabListadosYreportes.TabIndex = 2
        Me.tabListadosYreportes.Text = "listados y reportes"
        Me.tabListadosYreportes.UseVisualStyleBackColor = True
        '
        'tabEstadisticas
        '
        Me.tabEstadisticas.BackgroundImage = Global.SeaStar.My.Resources.Resources.bg4
        Me.tabEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabEstadisticas.Location = New System.Drawing.Point(4, 22)
        Me.tabEstadisticas.Name = "tabEstadisticas"
        Me.tabEstadisticas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEstadisticas.Size = New System.Drawing.Size(689, 472)
        Me.tabEstadisticas.TabIndex = 3
        Me.tabEstadisticas.Text = "Estadisticas"
        Me.tabEstadisticas.UseVisualStyleBackColor = True
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 465)
        Me.Controls.Add(Me.tabMenu)
        Me.Name = "formMenu"
        Me.Text = "Form1"
        Me.tabMenu.ResumeLayout(False)
        Me.tabAbm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabAbm As System.Windows.Forms.TabPage
    Friend WithEvents btnPuertos As System.Windows.Forms.Button
    Friend WithEvents btnAbmCubiertas As System.Windows.Forms.Button
    Friend WithEvents btnAbmNavios As System.Windows.Forms.Button
    Friend WithEvents btnAbmItinerarios As System.Windows.Forms.Button
    Friend WithEvents tabProcesos As System.Windows.Forms.TabPage
    Friend WithEvents tabListadosYreportes As System.Windows.Forms.TabPage
    Friend WithEvents tabEstadisticas As System.Windows.Forms.TabPage

End Class
