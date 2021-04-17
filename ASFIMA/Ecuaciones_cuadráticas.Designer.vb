<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ecuaciones_cuadráticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ecuaciones_cuadráticas))
        Me.chbproce = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadráticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposPlanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposSólidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónCuadráticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónLinealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltextohab = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.txtA = New ASFIMA.NumericTextBox()
        Me.txtB = New ASFIMA.NumericTextBox()
        Me.txtC = New ASFIMA.NumericTextBox()
        Me.lblcalcular = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbproce
        '
        Me.chbproce.AutoSize = True
        Me.chbproce.BackColor = System.Drawing.Color.Transparent
        Me.chbproce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbproce.ForeColor = System.Drawing.Color.White
        Me.chbproce.Location = New System.Drawing.Point(12, 327)
        Me.chbproce.Name = "chbproce"
        Me.chbproce.Size = New System.Drawing.Size(174, 28)
        Me.chbproce.TabIndex = 66
        Me.chbproce.Text = "Mostrar procesos"
        Me.chbproce.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EcuacionesToolStripMenuItem, Me.GeometríaToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 65
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
        Me.GeometríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuerposPlanosToolStripMenuItem, Me.CuerposSólidosToolStripMenuItem})
        Me.GeometríaToolStripMenuItem.Name = "GeometríaToolStripMenuItem"
        Me.GeometríaToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.GeometríaToolStripMenuItem.Text = "Geometría"
        '
        'CuerposPlanosToolStripMenuItem
        '
        Me.CuerposPlanosToolStripMenuItem.Name = "CuerposPlanosToolStripMenuItem"
        Me.CuerposPlanosToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.CuerposPlanosToolStripMenuItem.Text = "Cuerpos planos"
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
        'lbltextohab
        '
        Me.lbltextohab.AutoSize = True
        Me.lbltextohab.BackColor = System.Drawing.Color.Transparent
        Me.lbltextohab.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lbltextohab.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltextohab.Location = New System.Drawing.Point(21, 65)
        Me.lbltextohab.Name = "lbltextohab"
        Me.lbltextohab.Size = New System.Drawing.Size(942, 116)
        Me.lbltextohab.TabIndex = 60
        Me.lbltextohab.Text = resources.GetString("lbltextohab.Text")
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.Transparent
        Me.lblC.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblC.Location = New System.Drawing.Point(362, 240)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(74, 25)
        Me.lblC.TabIndex = 64
        Me.lblC.Text = "Digite C"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.Color.Transparent
        Me.lblB.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblB.Location = New System.Drawing.Point(202, 240)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(73, 25)
        Me.lblB.TabIndex = 63
        Me.lblB.Text = "Digite B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.Transparent
        Me.lblA.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblA.Location = New System.Drawing.Point(39, 240)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(73, 25)
        Me.lblA.TabIndex = 62
        Me.lblA.Text = "Digite A"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltitulo.Location = New System.Drawing.Point(228, 29)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(453, 37)
        Me.lbltitulo.TabIndex = 61
        Me.lbltitulo.Text = "¿Qué es una ecuación cuadrática?"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(12, 268)
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(123, 31)
        Me.txtA.TabIndex = 67
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtB.Location = New System.Drawing.Point(175, 268)
        Me.txtB.Multiline = True
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(123, 31)
        Me.txtB.TabIndex = 68
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtC.Location = New System.Drawing.Point(336, 268)
        Me.txtC.Multiline = True
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(123, 31)
        Me.txtC.TabIndex = 69
        '
        'lblcalcular
        '
        Me.lblcalcular.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcalcular.Location = New System.Drawing.Point(707, 300)
        Me.lblcalcular.Name = "lblcalcular"
        Me.lblcalcular.Size = New System.Drawing.Size(218, 76)
        Me.lblcalcular.TabIndex = 70
        Me.lblcalcular.Text = "Calcular"
        Me.lblcalcular.UseVisualStyleBackColor = True
        '
        'Ecuaciones_cuadráticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.lblcalcular)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.chbproce)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbltextohab)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lbltitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ecuaciones_cuadráticas"
        Me.Text = "Ecuaciones_cuadráticas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chbproce As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposPlanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónLinealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltextohab As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lbltitulo As Label
    Friend WithEvents txtA As NumericTextBox
    Friend WithEvents txtB As NumericTextBox
    Friend WithEvents txtC As NumericTextBox
    Friend WithEvents lblcalcular As Button
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
End Class
