<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuerpos_planos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuerpos_planos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadráticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposSólidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónCuadráticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónLinealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnresolver = New System.Windows.Forms.Button()
        Me.lbltextoar = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lblfigur = New System.Windows.Forms.Label()
        Me.Cbfiguras = New System.Windows.Forms.ComboBox()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.lblresolucion = New System.Windows.Forms.Label()
        Me.lblformula = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EcuacionesToolStripMenuItem, Me.GeometríaToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 84
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'EcuacionesToolStripMenuItem
        '
        Me.EcuacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EcuacionesCuadráticasToolStripMenuItem})
        Me.EcuacionesToolStripMenuItem.Name = "EcuacionesToolStripMenuItem"
        Me.EcuacionesToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EcuacionesToolStripMenuItem.Text = "Ecuaciones"
        '
        'EcuacionesCuadráticasToolStripMenuItem
        '
        Me.EcuacionesCuadráticasToolStripMenuItem.Name = "EcuacionesCuadráticasToolStripMenuItem"
        Me.EcuacionesCuadráticasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.EcuacionesCuadráticasToolStripMenuItem.Text = "Ecuaciones cuadráticas"
        '
        'GeometríaToolStripMenuItem
        '
        Me.GeometríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuerposSólidosToolStripMenuItem})
        Me.GeometríaToolStripMenuItem.Name = "GeometríaToolStripMenuItem"
        Me.GeometríaToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.GeometríaToolStripMenuItem.Text = "Geometría"
        '
        'CuerposSólidosToolStripMenuItem
        '
        Me.CuerposSólidosToolStripMenuItem.Name = "CuerposSólidosToolStripMenuItem"
        Me.CuerposSólidosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CuerposSólidosToolStripMenuItem.Text = "Cuerpos sólidos"
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunciónCuadráticaToolStripMenuItem, Me.FunciónLinealToolStripMenuItem, Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem})
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FuncionesToolStripMenuItem.Text = "Funciones"
        '
        'FunciónCuadráticaToolStripMenuItem
        '
        Me.FunciónCuadráticaToolStripMenuItem.Name = "FunciónCuadráticaToolStripMenuItem"
        Me.FunciónCuadráticaToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FunciónCuadráticaToolStripMenuItem.Text = "Función lineal"
        '
        'FunciónLinealToolStripMenuItem
        '
        Me.FunciónLinealToolStripMenuItem.Name = "FunciónLinealToolStripMenuItem"
        Me.FunciónLinealToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FunciónLinealToolStripMenuItem.Text = "Función cuadrática"
        '
        'FuncionesTrigonométricasPróximamenteToolStripMenuItem
        '
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Name = "FuncionesTrigonométricasPróximamenteToolStripMenuItem"
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Text = "Funciones trigonométricas (Próximamente)"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.btnlimpiar.Location = New System.Drawing.Point(739, 361)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(160, 60)
        Me.btnlimpiar.TabIndex = 90
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnresolver
        '
        Me.Btnresolver.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnresolver.Location = New System.Drawing.Point(564, 361)
        Me.Btnresolver.Name = "Btnresolver"
        Me.Btnresolver.Size = New System.Drawing.Size(160, 60)
        Me.Btnresolver.TabIndex = 89
        Me.Btnresolver.Text = "Resolver"
        Me.Btnresolver.UseVisualStyleBackColor = True
        '
        'lbltextoar
        '
        Me.lbltextoar.AutoSize = True
        Me.lbltextoar.BackColor = System.Drawing.Color.Transparent
        Me.lbltextoar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lbltextoar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltextoar.Location = New System.Drawing.Point(12, 84)
        Me.lbltextoar.Name = "lbltextoar"
        Me.lbltextoar.Size = New System.Drawing.Size(964, 87)
        Me.lbltextoar.TabIndex = 88
        Me.lbltextoar.Text = "Es una medida de extensión de una superficie expresada en unidades de  medida den" &
    "ominadas unidades de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "superficie " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.BackColor = System.Drawing.Color.Transparent
        Me.lblarea.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblarea.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblarea.Location = New System.Drawing.Point(418, 39)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(91, 37)
        Me.lblarea.TabIndex = 87
        Me.lblarea.Text = "Áreas"
        '
        'lblfigur
        '
        Me.lblfigur.AutoSize = True
        Me.lblfigur.BackColor = System.Drawing.Color.Transparent
        Me.lblfigur.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblfigur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblfigur.Location = New System.Drawing.Point(27, 275)
        Me.lblfigur.Name = "lblfigur"
        Me.lblfigur.Size = New System.Drawing.Size(444, 29)
        Me.lblfigur.TabIndex = 86
        Me.lblfigur.Text = "Seleccione a qué figura desea averiguarle el área"
        '
        'Cbfiguras
        '
        Me.Cbfiguras.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbfiguras.FormattingEnabled = True
        Me.Cbfiguras.Items.AddRange(New Object() {"Círculo", "Triángulo", "Rectangulo", "Trapecio", "Rombo"})
        Me.Cbfiguras.Location = New System.Drawing.Point(564, 275)
        Me.Cbfiguras.Name = "Cbfiguras"
        Me.Cbfiguras.Size = New System.Drawing.Size(326, 33)
        Me.Cbfiguras.TabIndex = 85
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.BackColor = System.Drawing.Color.Transparent
        Me.lblresultado.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblresultado.Location = New System.Drawing.Point(56, 467)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(0, 29)
        Me.lblresultado.TabIndex = 93
        '
        'lblresolucion
        '
        Me.lblresolucion.AutoSize = True
        Me.lblresolucion.BackColor = System.Drawing.Color.Transparent
        Me.lblresolucion.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresolucion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblresolucion.Location = New System.Drawing.Point(56, 416)
        Me.lblresolucion.Name = "lblresolucion"
        Me.lblresolucion.Size = New System.Drawing.Size(0, 29)
        Me.lblresolucion.TabIndex = 92
        '
        'lblformula
        '
        Me.lblformula.AutoSize = True
        Me.lblformula.BackColor = System.Drawing.Color.Transparent
        Me.lblformula.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblformula.Location = New System.Drawing.Point(56, 361)
        Me.lblformula.Name = "lblformula"
        Me.lblformula.Size = New System.Drawing.Size(0, 29)
        Me.lblformula.TabIndex = 91
        '
        'Cuerpos_planos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.lblresolucion)
        Me.Controls.Add(Me.lblformula)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Btnresolver)
        Me.Controls.Add(Me.lbltextoar)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblfigur)
        Me.Controls.Add(Me.Cbfiguras)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cuerpos_planos"
        Me.Text = "Cuerpos planos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónLinealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Btnresolver As Button
    Friend WithEvents lbltextoar As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents lblfigur As Label
    Friend WithEvents Cbfiguras As ComboBox
    Friend WithEvents lblresultado As Label
    Friend WithEvents lblresolucion As Label
    Friend WithEvents lblformula As Label
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
End Class
