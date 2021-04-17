<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funciones_cuadráticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funciones_cuadráticas))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lbltextohab = New System.Windows.Forms.Label()
        Me.chbproce = New System.Windows.Forms.CheckBox()
        Me.lblcrec = New System.Windows.Forms.Label()
        Me.lbldecre = New System.Windows.Forms.Label()
        Me.lblamb = New System.Windows.Forms.Label()
        Me.lblejey = New System.Windows.Forms.Label()
        Me.lblejex = New System.Windows.Forms.Label()
        Me.lbltiprec = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcrifun = New System.Windows.Forms.Label()
        Me.txtx2 = New ASFIMA.NumericTextBox()
        Me.txtc = New ASFIMA.NumericTextBox()
        Me.txtx = New ASFIMA.NumericTextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncalcfuncua = New System.Windows.Forms.Button()
        Me.lblejesim = New System.Windows.Forms.Label()
        Me.lblvert = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadráticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposPlanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposSólidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónCuadráticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltitulo.Location = New System.Drawing.Point(12, 35)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(433, 37)
        Me.lbltitulo.TabIndex = 38
        Me.lbltitulo.Text = "¿Qué es una función cuadrática?"
        '
        'lbltextohab
        '
        Me.lbltextohab.AutoSize = True
        Me.lbltextohab.BackColor = System.Drawing.Color.Transparent
        Me.lbltextohab.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextohab.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltextohab.Location = New System.Drawing.Point(14, 82)
        Me.lbltextohab.Name = "lbltextohab"
        Me.lbltextohab.Size = New System.Drawing.Size(884, 87)
        Me.lbltextohab.TabIndex = 37
        Me.lbltextohab.Text = resources.GetString("lbltextohab.Text")
        '
        'chbproce
        '
        Me.chbproce.AutoSize = True
        Me.chbproce.BackColor = System.Drawing.Color.Transparent
        Me.chbproce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbproce.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chbproce.Location = New System.Drawing.Point(48, 255)
        Me.chbproce.Name = "chbproce"
        Me.chbproce.Size = New System.Drawing.Size(174, 28)
        Me.chbproce.TabIndex = 73
        Me.chbproce.Text = "Mostrar procesos"
        Me.chbproce.UseVisualStyleBackColor = False
        '
        'lblcrec
        '
        Me.lblcrec.AutoSize = True
        Me.lblcrec.BackColor = System.Drawing.Color.Transparent
        Me.lblcrec.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrec.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblcrec.Location = New System.Drawing.Point(123, 505)
        Me.lblcrec.Name = "lblcrec"
        Me.lblcrec.Size = New System.Drawing.Size(0, 25)
        Me.lblcrec.TabIndex = 72
        '
        'lbldecre
        '
        Me.lbldecre.AutoSize = True
        Me.lbldecre.BackColor = System.Drawing.Color.Transparent
        Me.lbldecre.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldecre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldecre.Location = New System.Drawing.Point(146, 459)
        Me.lbldecre.Name = "lbldecre"
        Me.lbldecre.Size = New System.Drawing.Size(0, 25)
        Me.lbldecre.TabIndex = 71
        '
        'lblamb
        '
        Me.lblamb.AutoSize = True
        Me.lblamb.BackColor = System.Drawing.Color.Transparent
        Me.lblamb.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblamb.Location = New System.Drawing.Point(133, 418)
        Me.lblamb.Name = "lblamb"
        Me.lblamb.Size = New System.Drawing.Size(0, 25)
        Me.lblamb.TabIndex = 70
        '
        'lblejey
        '
        Me.lblejey.AutoSize = True
        Me.lblejey.BackColor = System.Drawing.Color.Transparent
        Me.lblejey.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblejey.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblejey.Location = New System.Drawing.Point(270, 374)
        Me.lblejey.Name = "lblejey"
        Me.lblejey.Size = New System.Drawing.Size(0, 25)
        Me.lblejey.TabIndex = 69
        '
        'lblejex
        '
        Me.lblejex.AutoSize = True
        Me.lblejex.BackColor = System.Drawing.Color.Transparent
        Me.lblejex.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblejex.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblejex.Location = New System.Drawing.Point(287, 327)
        Me.lblejex.Name = "lblejex"
        Me.lblejex.Size = New System.Drawing.Size(0, 25)
        Me.lblejex.TabIndex = 68
        '
        'lbltiprec
        '
        Me.lbltiprec.AutoSize = True
        Me.lbltiprec.BackColor = System.Drawing.Color.Transparent
        Me.lbltiprec.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltiprec.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltiprec.Location = New System.Drawing.Point(193, 291)
        Me.lbltiprec.Name = "lbltiprec"
        Me.lbltiprec.Size = New System.Drawing.Size(0, 25)
        Me.lbltiprec.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(42, 505)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 25)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Crece:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(42, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Decrece:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(43, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Ámbito:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(43, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 25)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Intersección con el eje ""y"":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(42, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Intersecciones con el eje ""x"":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(43, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Tipo de gráfica:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(333, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "F(x)=         x²+       x+"
        '
        'lblcrifun
        '
        Me.lblcrifun.AutoSize = True
        Me.lblcrifun.BackColor = System.Drawing.Color.Transparent
        Me.lblcrifun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrifun.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblcrifun.Location = New System.Drawing.Point(42, 212)
        Me.lblcrifun.Name = "lblcrifun"
        Me.lblcrifun.Size = New System.Drawing.Size(215, 31)
        Me.lblcrifun.TabIndex = 59
        Me.lblcrifun.Text = "Digite la función:"
        '
        'txtx2
        '
        Me.txtx2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtx2.Location = New System.Drawing.Point(416, 212)
        Me.txtx2.Multiline = True
        Me.txtx2.Name = "txtx2"
        Me.txtx2.Size = New System.Drawing.Size(46, 31)
        Me.txtx2.TabIndex = 74
        '
        'txtc
        '
        Me.txtc.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtc.Location = New System.Drawing.Point(586, 212)
        Me.txtc.Multiline = True
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(46, 31)
        Me.txtc.TabIndex = 75
        '
        'txtx
        '
        Me.txtx.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtx.Location = New System.Drawing.Point(504, 212)
        Me.txtx.Multiline = True
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(46, 31)
        Me.txtx.TabIndex = 76
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(836, 260)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(160, 60)
        Me.btnlimpiar.TabIndex = 78
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncalcfuncua
        '
        Me.btncalcfuncua.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcfuncua.Location = New System.Drawing.Point(836, 339)
        Me.btncalcfuncua.Name = "btncalcfuncua"
        Me.btncalcfuncua.Size = New System.Drawing.Size(160, 60)
        Me.btncalcfuncua.TabIndex = 77
        Me.btncalcfuncua.Text = "Calcular"
        Me.btncalcfuncua.UseVisualStyleBackColor = True
        '
        'lblejesim
        '
        Me.lblejesim.AutoSize = True
        Me.lblejesim.BackColor = System.Drawing.Color.Transparent
        Me.lblejesim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblejesim.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblejesim.Location = New System.Drawing.Point(179, 585)
        Me.lblejesim.Name = "lblejesim"
        Me.lblejesim.Size = New System.Drawing.Size(0, 25)
        Me.lblejesim.TabIndex = 82
        '
        'lblvert
        '
        Me.lblvert.AutoSize = True
        Me.lblvert.BackColor = System.Drawing.Color.Transparent
        Me.lblvert.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvert.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblvert.Location = New System.Drawing.Point(133, 545)
        Me.lblvert.Name = "lblvert"
        Me.lblvert.Size = New System.Drawing.Size(0, 25)
        Me.lblvert.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(42, 585)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Eje de simetría:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(42, 545)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Vértice:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EcuacionesToolStripMenuItem, Me.GeometríaToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 83
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
        Me.CuerposPlanosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
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
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunciónCuadráticaToolStripMenuItem, Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem})
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
        'FuncionesTrigonométricasPróximamenteToolStripMenuItem
        '
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Name = "FuncionesTrigonométricasPróximamenteToolStripMenuItem"
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem.Text = "Funciones trigonométricas (Próximamente)"
        '
        'Funciones_cuadráticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblejesim)
        Me.Controls.Add(Me.lblvert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcfuncua)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.txtx2)
        Me.Controls.Add(Me.chbproce)
        Me.Controls.Add(Me.lblcrec)
        Me.Controls.Add(Me.lbldecre)
        Me.Controls.Add(Me.lblamb)
        Me.Controls.Add(Me.lblejey)
        Me.Controls.Add(Me.lblejex)
        Me.Controls.Add(Me.lbltiprec)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcrifun)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.lbltextohab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Funciones_cuadráticas"
        Me.Text = "Funciones cuadráticas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitulo As Label
    Friend WithEvents lbltextohab As Label
    Friend WithEvents chbproce As CheckBox
    Friend WithEvents lblcrec As Label
    Friend WithEvents lbldecre As Label
    Friend WithEvents lblamb As Label
    Friend WithEvents lblejey As Label
    Friend WithEvents lblejex As Label
    Friend WithEvents lbltiprec As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcrifun As Label
    Friend WithEvents txtx2 As NumericTextBox
    Friend WithEvents txtc As NumericTextBox
    Friend WithEvents txtx As NumericTextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btncalcfuncua As Button
    Friend WithEvents lblejesim As Label
    Friend WithEvents lblvert As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposPlanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
End Class
