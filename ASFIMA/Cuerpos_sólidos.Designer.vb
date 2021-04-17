<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuerpos_sólidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuerpos_sólidos))
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
        Me.cbbase = New System.Windows.Forms.ComboBox()
        Me.rbAL = New System.Windows.Forms.RadioButton()
        Me.rbPb = New System.Windows.Forms.RadioButton()
        Me.rbabase = New System.Windows.Forms.RadioButton()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.rbAB = New System.Windows.Forms.RadioButton()
        Me.rbAT = New System.Windows.Forms.RadioButton()
        Me.cbcuerpos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtresultado = New System.Windows.Forms.Label()
        Me.txtradio = New ASFIMA.NumericTextBox()
        Me.txtg = New ASFIMA.NumericTextBox()
        Me.txtapp = New ASFIMA.NumericTextBox()
        Me.txth = New ASFIMA.NumericTextBox()
        Me.txtnlados = New ASFIMA.NumericTextBox()
        Me.txtbapotema = New ASFIMA.NumericTextBox()
        Me.txtbancho = New ASFIMA.NumericTextBox()
        Me.txtblargo = New ASFIMA.NumericTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EcuacionesToolStripMenuItem, Me.GeometríaToolStripMenuItem, Me.FuncionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 85
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
        Me.CuerposSólidosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CuerposSólidosToolStripMenuItem.Text = "Cuerpos planos"
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
        'cbbase
        '
        Me.cbbase.Enabled = False
        Me.cbbase.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbbase.FormattingEnabled = True
        Me.cbbase.Items.AddRange(New Object() {"Cuadrada", "Rectangular", "Trigulo equilatero", "Otro poligono regular"})
        Me.cbbase.Location = New System.Drawing.Point(460, 144)
        Me.cbbase.Name = "cbbase"
        Me.cbbase.Size = New System.Drawing.Size(187, 37)
        Me.cbbase.TabIndex = 88
        '
        'rbAL
        '
        Me.rbAL.AutoSize = True
        Me.rbAL.BackColor = System.Drawing.Color.Transparent
        Me.rbAL.Enabled = False
        Me.rbAL.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.rbAL.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAL.Location = New System.Drawing.Point(6, 129)
        Me.rbAL.Name = "rbAL"
        Me.rbAL.Size = New System.Drawing.Size(186, 33)
        Me.rbAL.TabIndex = 24
        Me.rbAL.TabStop = True
        Me.rbAL.Text = " Area Lateral (AL)"
        Me.rbAL.UseVisualStyleBackColor = False
        '
        'rbPb
        '
        Me.rbPb.AutoSize = True
        Me.rbPb.BackColor = System.Drawing.Color.Transparent
        Me.rbPb.Enabled = False
        Me.rbPb.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.rbPb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbPb.Location = New System.Drawing.Point(6, 207)
        Me.rbPb.Name = "rbPb"
        Me.rbPb.Size = New System.Drawing.Size(254, 33)
        Me.rbPb.TabIndex = 5
        Me.rbPb.TabStop = True
        Me.rbPb.Text = "Perimetro de la base (Pb)"
        Me.rbPb.UseVisualStyleBackColor = False
        '
        'rbabase
        '
        Me.rbabase.AutoSize = True
        Me.rbabase.BackColor = System.Drawing.Color.Transparent
        Me.rbabase.Enabled = False
        Me.rbabase.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.rbabase.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbabase.Location = New System.Drawing.Point(6, 168)
        Me.rbabase.Name = "rbabase"
        Me.rbabase.Size = New System.Drawing.Size(211, 33)
        Me.rbabase.TabIndex = 6
        Me.rbabase.TabStop = True
        Me.rbabase.Text = "Area de la base (Ab)"
        Me.rbabase.UseVisualStyleBackColor = False
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.Transparent
        Me.btncalcular.Font = New System.Drawing.Font("Arial Narrow", 20.25!)
        Me.btncalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncalcular.Location = New System.Drawing.Point(473, 254)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(151, 46)
        Me.btncalcular.TabIndex = 1
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'rbAB
        '
        Me.rbAB.AutoSize = True
        Me.rbAB.BackColor = System.Drawing.Color.Transparent
        Me.rbAB.Enabled = False
        Me.rbAB.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.rbAB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAB.Location = New System.Drawing.Point(6, 90)
        Me.rbAB.Name = "rbAB"
        Me.rbAB.Size = New System.Drawing.Size(177, 33)
        Me.rbAB.TabIndex = 3
        Me.rbAB.TabStop = True
        Me.rbAB.Text = " Area Basal (AB)"
        Me.rbAB.UseVisualStyleBackColor = False
        '
        'rbAT
        '
        Me.rbAT.AutoSize = True
        Me.rbAT.BackColor = System.Drawing.Color.Transparent
        Me.rbAT.Enabled = False
        Me.rbAT.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.rbAT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAT.Location = New System.Drawing.Point(6, 51)
        Me.rbAT.Name = "rbAT"
        Me.rbAT.Size = New System.Drawing.Size(165, 33)
        Me.rbAT.TabIndex = 4
        Me.rbAT.TabStop = True
        Me.rbAT.Text = "Area Total (AT)"
        Me.rbAT.UseVisualStyleBackColor = False
        '
        'cbcuerpos
        '
        Me.cbcuerpos.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbcuerpos.FormattingEnabled = True
        Me.cbcuerpos.Items.AddRange(New Object() {"Prisma", "Piramide", "Cubo", "Esfera", "Cono", "Cilindro"})
        Me.cbcuerpos.Location = New System.Drawing.Point(460, 67)
        Me.cbcuerpos.Name = "cbcuerpos"
        Me.cbcuerpos.Size = New System.Drawing.Size(187, 37)
        Me.cbcuerpos.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(6, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(270, 29)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Cantidad de lados de la base:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(468, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 29)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Apotema de la base:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(289, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 29)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Ancho de la base:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 29)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Largo de la base:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbPb)
        Me.GroupBox1.Controls.Add(Me.rbabase)
        Me.GroupBox1.Controls.Add(Me.rbAB)
        Me.GroupBox1.Controls.Add(Me.rbAT)
        Me.GroupBox1.Controls.Add(Me.rbAL)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(725, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 251)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a averiguar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtradio)
        Me.GroupBox2.Controls.Add(Me.txtg)
        Me.GroupBox2.Controls.Add(Me.txtapp)
        Me.GroupBox2.Controls.Add(Me.txth)
        Me.GroupBox2.Controls.Add(Me.txtnlados)
        Me.GroupBox2.Controls.Add(Me.txtbapotema)
        Me.GroupBox2.Controls.Add(Me.btncalcular)
        Me.GroupBox2.Controls.Add(Me.txtbancho)
        Me.GroupBox2.Controls.Add(Me.txtblargo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(11, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 309)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos necesarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label8.Location = New System.Drawing.Point(6, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 29)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Generatriz:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.Location = New System.Drawing.Point(289, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 29)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Radio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.Location = New System.Drawing.Point(468, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 29)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Apotema de la piramide:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.Location = New System.Drawing.Point(289, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 29)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Altura:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbcuerpos)
        Me.GroupBox3.Controls.Add(Me.cbbase)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(11, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(653, 228)
        Me.GroupBox3.TabIndex = 96
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de figura a estudiar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(1, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(456, 87)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "2) En caso de que la figura escogida anteriormente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tenga una base de una forma v" &
    "ariable, por favor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccione el polígono que conforma la o las bases"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(1, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 29)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "1) Por favor seleccione el tipo forma a utilizar"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtresultado)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(713, 312)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(284, 251)
        Me.GroupBox4.TabIndex = 97
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultado"
        '
        'txtresultado
        '
        Me.txtresultado.AutoSize = True
        Me.txtresultado.BackColor = System.Drawing.Color.Transparent
        Me.txtresultado.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtresultado.Location = New System.Drawing.Point(21, 109)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(0, 28)
        Me.txtresultado.TabIndex = 91
        '
        'txtradio
        '
        Me.txtradio.Enabled = False
        Me.txtradio.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtradio.Location = New System.Drawing.Point(294, 265)
        Me.txtradio.Name = "txtradio"
        Me.txtradio.Size = New System.Drawing.Size(100, 35)
        Me.txtradio.TabIndex = 105
        '
        'txtg
        '
        Me.txtg.Enabled = False
        Me.txtg.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtg.Location = New System.Drawing.Point(11, 265)
        Me.txtg.Name = "txtg"
        Me.txtg.Size = New System.Drawing.Size(100, 35)
        Me.txtg.TabIndex = 104
        '
        'txtapp
        '
        Me.txtapp.Enabled = False
        Me.txtapp.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtapp.Location = New System.Drawing.Point(473, 185)
        Me.txtapp.Name = "txtapp"
        Me.txtapp.Size = New System.Drawing.Size(100, 35)
        Me.txtapp.TabIndex = 103
        '
        'txth
        '
        Me.txth.Enabled = False
        Me.txth.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txth.Location = New System.Drawing.Point(294, 185)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(100, 35)
        Me.txth.TabIndex = 102
        '
        'txtnlados
        '
        Me.txtnlados.Enabled = False
        Me.txtnlados.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtnlados.Location = New System.Drawing.Point(11, 185)
        Me.txtnlados.Name = "txtnlados"
        Me.txtnlados.Size = New System.Drawing.Size(100, 35)
        Me.txtnlados.TabIndex = 101
        '
        'txtbapotema
        '
        Me.txtbapotema.Enabled = False
        Me.txtbapotema.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtbapotema.Location = New System.Drawing.Point(473, 88)
        Me.txtbapotema.Name = "txtbapotema"
        Me.txtbapotema.Size = New System.Drawing.Size(100, 35)
        Me.txtbapotema.TabIndex = 100
        '
        'txtbancho
        '
        Me.txtbancho.Enabled = False
        Me.txtbancho.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtbancho.Location = New System.Drawing.Point(294, 88)
        Me.txtbancho.Name = "txtbancho"
        Me.txtbancho.Size = New System.Drawing.Size(100, 35)
        Me.txtbancho.TabIndex = 99
        '
        'txtblargo
        '
        Me.txtblargo.Enabled = False
        Me.txtblargo.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtblargo.Location = New System.Drawing.Point(16, 88)
        Me.txtblargo.Name = "txtblargo"
        Me.txtblargo.Size = New System.Drawing.Size(100, 35)
        Me.txtblargo.TabIndex = 98
        '
        'Cuerpos_sólidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cuerpos_sólidos"
        Me.Text = "Cuerpos sólidos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónLinealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbbase As ComboBox
    Friend WithEvents rbAL As RadioButton
    Friend WithEvents rbPb As RadioButton
    Friend WithEvents rbabase As RadioButton
    Friend WithEvents btncalcular As Button
    Friend WithEvents rbAB As RadioButton
    Friend WithEvents rbAT As RadioButton
    Friend WithEvents cbcuerpos As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnlados As NumericTextBox
    Friend WithEvents txtbapotema As NumericTextBox
    Friend WithEvents txtbancho As NumericTextBox
    Friend WithEvents txtblargo As NumericTextBox
    Friend WithEvents txtradio As NumericTextBox
    Friend WithEvents txtg As NumericTextBox
    Friend WithEvents txtapp As NumericTextBox
    Friend WithEvents txth As NumericTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtresultado As Label
End Class
