<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuMatem = New System.Windows.Forms.MenuStrip()
        Me.MatemáticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadráticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposPlanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposSólidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncióLinealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónCuadráticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoCircularUniformeMCUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeyDeCoulombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectromagnetismoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeyDeOhmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMatem.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMatem
        '
        Me.MenuMatem.BackColor = System.Drawing.Color.Transparent
        Me.MenuMatem.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuMatem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMatem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatemáticasToolStripMenuItem, Me.EcuacionesToolStripMenuItem, Me.GeometríaToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuMatem.Location = New System.Drawing.Point(0, 0)
        Me.MenuMatem.Name = "MenuMatem"
        Me.MenuMatem.Size = New System.Drawing.Size(141, 601)
        Me.MenuMatem.TabIndex = 10
        Me.MenuMatem.Text = "MenuStrip1"
        '
        'MatemáticasToolStripMenuItem
        '
        Me.MatemáticasToolStripMenuItem.Enabled = False
        Me.MatemáticasToolStripMenuItem.ForeColor = System.Drawing.Color.Linen
        Me.MatemáticasToolStripMenuItem.Name = "MatemáticasToolStripMenuItem"
        Me.MatemáticasToolStripMenuItem.Size = New System.Drawing.Size(128, 29)
        Me.MatemáticasToolStripMenuItem.Text = "Matemáticas:"
        '
        'EcuacionesToolStripMenuItem
        '
        Me.EcuacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EcuacionesCuadráticasToolStripMenuItem})
        Me.EcuacionesToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.EcuacionesToolStripMenuItem.Name = "EcuacionesToolStripMenuItem"
        Me.EcuacionesToolStripMenuItem.Size = New System.Drawing.Size(128, 29)
        Me.EcuacionesToolStripMenuItem.Text = "Ecuaciones"
        '
        'EcuacionesCuadráticasToolStripMenuItem
        '
        Me.EcuacionesCuadráticasToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.EcuacionesCuadráticasToolStripMenuItem.Name = "EcuacionesCuadráticasToolStripMenuItem"
        Me.EcuacionesCuadráticasToolStripMenuItem.Size = New System.Drawing.Size(279, 30)
        Me.EcuacionesCuadráticasToolStripMenuItem.Text = "Ecuaciones cuadráticas"
        '
        'GeometríaToolStripMenuItem
        '
        Me.GeometríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuerposPlanosToolStripMenuItem, Me.CuerposSólidosToolStripMenuItem})
        Me.GeometríaToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.GeometríaToolStripMenuItem.Name = "GeometríaToolStripMenuItem"
        Me.GeometríaToolStripMenuItem.Size = New System.Drawing.Size(128, 29)
        Me.GeometríaToolStripMenuItem.Text = "Geometría"
        '
        'CuerposPlanosToolStripMenuItem
        '
        Me.CuerposPlanosToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.CuerposPlanosToolStripMenuItem.Name = "CuerposPlanosToolStripMenuItem"
        Me.CuerposPlanosToolStripMenuItem.Size = New System.Drawing.Size(223, 30)
        Me.CuerposPlanosToolStripMenuItem.Text = "Cuerpos planos"
        '
        'CuerposSólidosToolStripMenuItem
        '
        Me.CuerposSólidosToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.CuerposSólidosToolStripMenuItem.Name = "CuerposSólidosToolStripMenuItem"
        Me.CuerposSólidosToolStripMenuItem.Size = New System.Drawing.Size(223, 30)
        Me.CuerposSólidosToolStripMenuItem.Text = "Cuerpos sólidos "
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncióLinealToolStripMenuItem, Me.FunciónCuadráticaToolStripMenuItem, Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem})
        Me.FuncionesToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(128, 29)
        Me.FuncionesToolStripMenuItem.Text = "Funciones"
        '
        'FuncióLinealToolStripMenuItem
        '
        Me.FuncióLinealToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FuncióLinealToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.FuncióLinealToolStripMenuItem.Name = "FuncióLinealToolStripMenuItem"
        Me.FuncióLinealToolStripMenuItem.Size = New System.Drawing.Size(446, 30)
        Me.FuncióLinealToolStripMenuItem.Text = "Función lineal"
        '
        'FunciónCuadráticaToolStripMenuItem
        '
        Me.FunciónCuadráticaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FunciónCuadráticaToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.FunciónCuadráticaToolStripMenuItem.Name = "FunciónCuadráticaToolStripMenuItem"
        Me.FunciónCuadráticaToolStripMenuItem.Size = New System.Drawing.Size(446, 30)
        Me.FunciónCuadráticaToolStripMenuItem.Text = "Función cuadrática"
        '
        'FuncionesTrigonométricasPróximamenteToolStripMenuItem
        '
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Name = "FuncionesTrigonométricasPróximamenteToolStripMenuItem"
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Size = New System.Drawing.Size(446, 30)
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Text = "Funciones trigonométricas (Próximamente)"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem4, Me.ToolStripMenuItem7, Me.ElectromagnetismoToolStripMenuItem, Me.ConversionesToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(816, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(192, 601)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Linen
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(179, 29)
        Me.ToolStripMenuItem1.Text = "Física:"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem, Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem, Me.MovimientoCircularUniformeMCUToolStripMenuItem})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Chocolate
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(179, 29)
        Me.ToolStripMenuItem2.Text = "Cinemática"
        '
        'MovimientoRectilíneoUniformeMRUToolStripMenuItem
        '
        Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem.Name = "MovimientoRectilíneoUniformeMRUToolStripMenuItem"
        Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem.Size = New System.Drawing.Size(562, 30)
        Me.MovimientoRectilíneoUniformeMRUToolStripMenuItem.Text = "Movimiento rectilíneo uniforme (MRU)"
        '
        'MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem
        '
        Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem.Name = "MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem"
        Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem.Size = New System.Drawing.Size(562, 30)
        Me.MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem.Text = "Movimiento rectilíneo uniformemente acelerado (MRUA)"
        '
        'MovimientoCircularUniformeMCUToolStripMenuItem
        '
        Me.MovimientoCircularUniformeMCUToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.MovimientoCircularUniformeMCUToolStripMenuItem.Name = "MovimientoCircularUniformeMCUToolStripMenuItem"
        Me.MovimientoCircularUniformeMCUToolStripMenuItem.Size = New System.Drawing.Size(562, 30)
        Me.MovimientoCircularUniformeMCUToolStripMenuItem.Text = "Movimiento circular uniforme (MCU)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.Chocolate
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(179, 29)
        Me.ToolStripMenuItem4.Text = "Dinámica"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeyDeCoulombToolStripMenuItem})
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.Chocolate
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(179, 29)
        Me.ToolStripMenuItem7.Text = "Electrostática"
        '
        'LeyDeCoulombToolStripMenuItem
        '
        Me.LeyDeCoulombToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.LeyDeCoulombToolStripMenuItem.Name = "LeyDeCoulombToolStripMenuItem"
        Me.LeyDeCoulombToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.LeyDeCoulombToolStripMenuItem.Text = "Ley de coulomb"
        '
        'ElectromagnetismoToolStripMenuItem
        '
        Me.ElectromagnetismoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeyDeOhmToolStripMenuItem})
        Me.ElectromagnetismoToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.ElectromagnetismoToolStripMenuItem.Name = "ElectromagnetismoToolStripMenuItem"
        Me.ElectromagnetismoToolStripMenuItem.Size = New System.Drawing.Size(179, 29)
        Me.ElectromagnetismoToolStripMenuItem.Text = "Electromagnetismo"
        '
        'LeyDeOhmToolStripMenuItem
        '
        Me.LeyDeOhmToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.LeyDeOhmToolStripMenuItem.Name = "LeyDeOhmToolStripMenuItem"
        Me.LeyDeOhmToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.LeyDeOhmToolStripMenuItem.Text = "Ley de Ohm"
        '
        'ConversionesToolStripMenuItem
        '
        Me.ConversionesToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.ConversionesToolStripMenuItem.Name = "ConversionesToolStripMenuItem"
        Me.ConversionesToolStripMenuItem.Size = New System.Drawing.Size(179, 29)
        Me.ConversionesToolStripMenuItem.Text = "Conversiones"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.DensidadToolStripMenuItem})
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Chocolate
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(179, 29)
        Me.ToolStripMenuItem3.Text = "Hidrostática"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Chocolate
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(163, 30)
        Me.ToolStripMenuItem5.Text = "Presión"
        '
        'DensidadToolStripMenuItem
        '
        Me.DensidadToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate
        Me.DensidadToolStripMenuItem.Name = "DensidadToolStripMenuItem"
        Me.DensidadToolStripMenuItem.Size = New System.Drawing.Size(163, 30)
        Me.DensidadToolStripMenuItem.Text = "Densidad"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuMatem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.MenuMatem.ResumeLayout(False)
        Me.MenuMatem.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuMatem As MenuStrip
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposPlanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncióLinealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatemáticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ElectromagnetismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoRectilíneoUniformeMRUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoCircularUniformeMCUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeyDeCoulombToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeyDeOhmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents DensidadToolStripMenuItem As ToolStripMenuItem
End Class
