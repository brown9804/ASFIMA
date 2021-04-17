<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funciones_lineales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funciones_lineales))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadráticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposPlanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuerposSólidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunciónLinealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbecudelarec = New System.Windows.Forms.GroupBox()
        Me.txtB = New ASFIMA.NumericTextBox()
        Me.txtC = New ASFIMA.NumericTextBox()
        Me.txtA = New ASFIMA.NumericTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblingra = New System.Windows.Forms.Label()
        Me.gbparor = New System.Windows.Forms.GroupBox()
        Me.txtpar21 = New ASFIMA.NumericTextBox()
        Me.txtpar22 = New ASFIMA.NumericTextBox()
        Me.txtpar12 = New ASFIMA.NumericTextBox()
        Me.txtpar11 = New ASFIMA.NumericTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpar2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblpar1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbFunciónSimple = New System.Windows.Forms.GroupBox()
        Me.txtvalx = New ASFIMA.NumericTextBox()
        Me.txtcrit2 = New ASFIMA.NumericTextBox()
        Me.txtcrit1 = New ASFIMA.NumericTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lblvalx = New System.Windows.Forms.Label()
        Me.lblcrifun = New System.Windows.Forms.Label()
        Me.lblfx = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbecudelarec.SuspendLayout()
        Me.gbparor.SuspendLayout()
        Me.gbFunciónSimple.SuspendLayout()
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
        Me.GeometríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuerposPlanosToolStripMenuItem, Me.CuerposSólidosToolStripMenuItem})
        Me.GeometríaToolStripMenuItem.Name = "GeometríaToolStripMenuItem"
        Me.GeometríaToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.GeometríaToolStripMenuItem.Text = "Geometría"
        '
        'CuerposPlanosToolStripMenuItem
        '
        Me.CuerposPlanosToolStripMenuItem.Name = "CuerposPlanosToolStripMenuItem"
        Me.CuerposPlanosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CuerposPlanosToolStripMenuItem.Text = "Cuerpos planos"
        '
        'CuerposSólidosToolStripMenuItem
        '
        Me.CuerposSólidosToolStripMenuItem.Name = "CuerposSólidosToolStripMenuItem"
        Me.CuerposSólidosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CuerposSólidosToolStripMenuItem.Text = "Cuerpos sólidos "
        '
        'FuncionesToolStripMenuItem
        '
        Me.FuncionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunciónLinealToolStripMenuItem, Me.FuncionesTrigonométricasPróximamenteToolStripMenuItem})
        Me.FuncionesToolStripMenuItem.Name = "FuncionesToolStripMenuItem"
        Me.FuncionesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FuncionesToolStripMenuItem.Text = "Funciones"
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
        'gbecudelarec
        '
        Me.gbecudelarec.BackColor = System.Drawing.Color.Transparent
        Me.gbecudelarec.Controls.Add(Me.txtB)
        Me.gbecudelarec.Controls.Add(Me.txtC)
        Me.gbecudelarec.Controls.Add(Me.txtA)
        Me.gbecudelarec.Controls.Add(Me.Label22)
        Me.gbecudelarec.Controls.Add(Me.Label21)
        Me.gbecudelarec.Controls.Add(Me.Label20)
        Me.gbecudelarec.Controls.Add(Me.Label23)
        Me.gbecudelarec.Controls.Add(Me.Button5)
        Me.gbecudelarec.Controls.Add(Me.lblingra)
        Me.gbecudelarec.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbecudelarec.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gbecudelarec.Location = New System.Drawing.Point(684, 27)
        Me.gbecudelarec.Name = "gbecudelarec"
        Me.gbecudelarec.Size = New System.Drawing.Size(298, 482)
        Me.gbecudelarec.TabIndex = 87
        Me.gbecudelarec.TabStop = False
        Me.gbecudelarec.Text = "Ecuación de la recta"
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtB.Location = New System.Drawing.Point(114, 157)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(52, 35)
        Me.txtB.TabIndex = 78
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtC.Location = New System.Drawing.Point(114, 238)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(52, 35)
        Me.txtC.TabIndex = 77
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtA.Location = New System.Drawing.Point(114, 81)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(52, 35)
        Me.txtA.TabIndex = 76
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label22.Location = New System.Drawing.Point(5, 241)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 29)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Ingrese C:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label21.Location = New System.Drawing.Point(6, 157)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 29)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Ingrese B:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.Label20.Location = New System.Drawing.Point(172, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 29)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "y"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.Label23.Location = New System.Drawing.Point(171, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 29)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "x"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 20.25!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(61, 395)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(193, 75)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Calcular "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblingra
        '
        Me.lblingra.AutoSize = True
        Me.lblingra.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblingra.Location = New System.Drawing.Point(5, 84)
        Me.lblingra.Name = "lblingra"
        Me.lblingra.Size = New System.Drawing.Size(102, 29)
        Me.lblingra.TabIndex = 1
        Me.lblingra.Text = "Ingrese A:"
        '
        'gbparor
        '
        Me.gbparor.BackColor = System.Drawing.Color.Transparent
        Me.gbparor.Controls.Add(Me.txtpar21)
        Me.gbparor.Controls.Add(Me.txtpar22)
        Me.gbparor.Controls.Add(Me.txtpar12)
        Me.gbparor.Controls.Add(Me.txtpar11)
        Me.gbparor.Controls.Add(Me.Label3)
        Me.gbparor.Controls.Add(Me.Label1)
        Me.gbparor.Controls.Add(Me.lblpar2)
        Me.gbparor.Controls.Add(Me.Button2)
        Me.gbparor.Controls.Add(Me.Label4)
        Me.gbparor.Controls.Add(Me.lblpar1)
        Me.gbparor.Controls.Add(Me.Label2)
        Me.gbparor.Controls.Add(Me.Label5)
        Me.gbparor.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbparor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gbparor.Location = New System.Drawing.Point(362, 27)
        Me.gbparor.Name = "gbparor"
        Me.gbparor.Size = New System.Drawing.Size(298, 482)
        Me.gbparor.TabIndex = 86
        Me.gbparor.TabStop = False
        Me.gbparor.Text = "Pares ordenados"
        '
        'txtpar21
        '
        Me.txtpar21.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtpar21.Location = New System.Drawing.Point(88, 302)
        Me.txtpar21.Name = "txtpar21"
        Me.txtpar21.Size = New System.Drawing.Size(70, 35)
        Me.txtpar21.TabIndex = 79
        '
        'txtpar22
        '
        Me.txtpar22.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtpar22.Location = New System.Drawing.Point(187, 302)
        Me.txtpar22.Name = "txtpar22"
        Me.txtpar22.Size = New System.Drawing.Size(70, 35)
        Me.txtpar22.TabIndex = 78
        '
        'txtpar12
        '
        Me.txtpar12.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtpar12.Location = New System.Drawing.Point(187, 211)
        Me.txtpar12.Name = "txtpar12"
        Me.txtpar12.Size = New System.Drawing.Size(70, 35)
        Me.txtpar12.TabIndex = 77
        '
        'txtpar11
        '
        Me.txtpar11.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtpar11.Location = New System.Drawing.Point(88, 211)
        Me.txtpar11.Name = "txtpar11"
        Me.txtpar11.Size = New System.Drawing.Size(70, 35)
        Me.txtpar11.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 57)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "("
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 57)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "("
        '
        'lblpar2
        '
        Me.lblpar2.AutoSize = True
        Me.lblpar2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblpar2.Location = New System.Drawing.Point(0, 304)
        Me.lblpar2.Name = "lblpar2"
        Me.lblpar2.Size = New System.Drawing.Size(187, 29)
        Me.lblpar2.TabIndex = 15
        Me.lblpar2.Text = "Par #2                     , "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 20.25!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(75, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 75)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Calcular "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 58)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ingrese los pares ordenados:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblpar1
        '
        Me.lblpar1.AutoSize = True
        Me.lblpar1.BackColor = System.Drawing.Color.Transparent
        Me.lblpar1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblpar1.Location = New System.Drawing.Point(0, 213)
        Me.lblpar1.Name = "lblpar1"
        Me.lblpar1.Size = New System.Drawing.Size(242, 29)
        Me.lblpar1.TabIndex = 10
        Me.lblpar1.Text = "Par #1                     ,            "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 57)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = ")"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(248, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 57)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = ")"
        '
        'gbFunciónSimple
        '
        Me.gbFunciónSimple.BackColor = System.Drawing.Color.Transparent
        Me.gbFunciónSimple.Controls.Add(Me.txtvalx)
        Me.gbFunciónSimple.Controls.Add(Me.txtcrit2)
        Me.gbFunciónSimple.Controls.Add(Me.txtcrit1)
        Me.gbFunciónSimple.Controls.Add(Me.Button1)
        Me.gbFunciónSimple.Controls.Add(Me.lblx)
        Me.gbFunciónSimple.Controls.Add(Me.lblvalx)
        Me.gbFunciónSimple.Controls.Add(Me.lblcrifun)
        Me.gbFunciónSimple.Controls.Add(Me.lblfx)
        Me.gbFunciónSimple.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbFunciónSimple.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gbFunciónSimple.Location = New System.Drawing.Point(32, 27)
        Me.gbFunciónSimple.Name = "gbFunciónSimple"
        Me.gbFunciónSimple.Size = New System.Drawing.Size(298, 482)
        Me.gbFunciónSimple.TabIndex = 85
        Me.gbFunciónSimple.TabStop = False
        Me.gbFunciónSimple.Text = "Criterio Lineal"
        '
        'txtvalx
        '
        Me.txtvalx.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtvalx.Location = New System.Drawing.Point(50, 324)
        Me.txtvalx.Name = "txtvalx"
        Me.txtvalx.Size = New System.Drawing.Size(70, 35)
        Me.txtvalx.TabIndex = 77
        '
        'txtcrit2
        '
        Me.txtcrit2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtcrit2.Location = New System.Drawing.Point(178, 173)
        Me.txtcrit2.Name = "txtcrit2"
        Me.txtcrit2.Size = New System.Drawing.Size(70, 35)
        Me.txtcrit2.TabIndex = 76
        '
        'txtcrit1
        '
        Me.txtcrit1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtcrit1.Location = New System.Drawing.Point(69, 171)
        Me.txtcrit1.Name = "txtcrit1"
        Me.txtcrit1.Size = New System.Drawing.Size(70, 35)
        Me.txtcrit1.TabIndex = 75
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(69, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 75)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calcular "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblx.Location = New System.Drawing.Point(6, 326)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(38, 29)
        Me.lblx.TabIndex = 8
        Me.lblx.Text = "X="
        '
        'lblvalx
        '
        Me.lblvalx.AutoSize = True
        Me.lblvalx.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblvalx.Location = New System.Drawing.Point(2, 268)
        Me.lblvalx.Name = "lblvalx"
        Me.lblvalx.Size = New System.Drawing.Size(197, 58)
        Me.lblvalx.TabIndex = 6
        Me.lblvalx.Text = "Ingrese el valor de X:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblcrifun
        '
        Me.lblcrifun.AutoSize = True
        Me.lblcrifun.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblcrifun.Location = New System.Drawing.Point(2, 93)
        Me.lblcrifun.Name = "lblcrifun"
        Me.lblcrifun.Size = New System.Drawing.Size(283, 29)
        Me.lblcrifun.TabIndex = 1
        Me.lblcrifun.Text = "Ingrese el criterio de la función:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblfx
        '
        Me.lblfx.AutoSize = True
        Me.lblfx.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lblfx.Location = New System.Drawing.Point(2, 173)
        Me.lblfx.Name = "lblfx"
        Me.lblfx.Size = New System.Drawing.Size(183, 29)
        Me.lblfx.TabIndex = 0
        Me.lblfx.Text = "F(x)=                   x +"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlimpiar.Location = New System.Drawing.Point(32, 569)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(181, 52)
        Me.btnlimpiar.TabIndex = 78
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Funciones_lineales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.gbecudelarec)
        Me.Controls.Add(Me.gbparor)
        Me.Controls.Add(Me.gbFunciónSimple)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Funciones_lineales"
        Me.Text = "Funciones lineales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbecudelarec.ResumeLayout(False)
        Me.gbecudelarec.PerformLayout()
        Me.gbparor.ResumeLayout(False)
        Me.gbparor.PerformLayout()
        Me.gbFunciónSimple.ResumeLayout(False)
        Me.gbFunciónSimple.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EcuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadráticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposPlanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerposSólidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunciónLinealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionesTrigonométricasPróximamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbecudelarec As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents lblingra As Label
    Friend WithEvents gbparor As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblpar2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblpar1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbFunciónSimple As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblx As Label
    Friend WithEvents lblvalx As Label
    Friend WithEvents lblcrifun As Label
    Friend WithEvents lblfx As Label
    Friend WithEvents txtB As NumericTextBox
    Friend WithEvents txtC As NumericTextBox
    Friend WithEvents txtA As NumericTextBox
    Friend WithEvents txtpar21 As NumericTextBox
    Friend WithEvents txtpar22 As NumericTextBox
    Friend WithEvents txtpar12 As NumericTextBox
    Friend WithEvents txtpar11 As NumericTextBox
    Friend WithEvents txtvalx As NumericTextBox
    Friend WithEvents txtcrit2 As NumericTextBox
    Friend WithEvents txtcrit1 As NumericTextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
End Class
