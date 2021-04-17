<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRU))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmru = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoCircularUniformaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimintoParabolicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DinámicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msestati = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeyDeCoulombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmagneti = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeyDeOhmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbproce = New System.Windows.Forms.CheckBox()
        Me.txttiempo = New ASFIMA.NumericTextBox()
        Me.txtvelocidad = New ASFIMA.NumericTextBox()
        Me.txtdistancia = New ASFIMA.NumericTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnmru = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.msmru, Me.DinámicaToolStripMenuItem, Me.msestati, Me.msmagneti, Me.ConversionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'msmru
        '
        Me.msmru.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientoRectilíneoUniformeToolStripMenuItem, Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem, Me.MovimientoCircularUniformaToolStripMenuItem, Me.MovimintoParabolicoToolStripMenuItem})
        Me.msmru.Name = "msmru"
        Me.msmru.Size = New System.Drawing.Size(79, 20)
        Me.msmru.Text = "Cinemática"
        '
        'MovimientoRectilíneoUniformeToolStripMenuItem
        '
        Me.MovimientoRectilíneoUniformeToolStripMenuItem.Name = "MovimientoRectilíneoUniformeToolStripMenuItem"
        Me.MovimientoRectilíneoUniformeToolStripMenuItem.Size = New System.Drawing.Size(337, 22)
        Me.MovimientoRectilíneoUniformeToolStripMenuItem.Text = "Movimiento Rectilíneo Uniforme"
        '
        'MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem
        '
        Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Name = "MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem"
        Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Size = New System.Drawing.Size(337, 22)
        Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Text = "Movimiento Rectilíneo Uniformemente Acelerado"
        '
        'MovimientoCircularUniformaToolStripMenuItem
        '
        Me.MovimientoCircularUniformaToolStripMenuItem.Name = "MovimientoCircularUniformaToolStripMenuItem"
        Me.MovimientoCircularUniformaToolStripMenuItem.Size = New System.Drawing.Size(337, 22)
        Me.MovimientoCircularUniformaToolStripMenuItem.Text = "Movimiento Circular Uniforme"
        '
        'MovimintoParabolicoToolStripMenuItem
        '
        Me.MovimintoParabolicoToolStripMenuItem.Name = "MovimintoParabolicoToolStripMenuItem"
        Me.MovimintoParabolicoToolStripMenuItem.Size = New System.Drawing.Size(337, 22)
        Me.MovimintoParabolicoToolStripMenuItem.Text = "Moviminto Parabólico"
        '
        'DinámicaToolStripMenuItem
        '
        Me.DinámicaToolStripMenuItem.Name = "DinámicaToolStripMenuItem"
        Me.DinámicaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.DinámicaToolStripMenuItem.Text = "Dinámica"
        '
        'msestati
        '
        Me.msestati.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeyDeCoulombToolStripMenuItem})
        Me.msestati.Name = "msestati"
        Me.msestati.Size = New System.Drawing.Size(89, 20)
        Me.msestati.Text = "Electrostática"
        '
        'LeyDeCoulombToolStripMenuItem
        '
        Me.LeyDeCoulombToolStripMenuItem.Name = "LeyDeCoulombToolStripMenuItem"
        Me.LeyDeCoulombToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LeyDeCoulombToolStripMenuItem.Text = "Ley de Coulomb"
        '
        'msmagneti
        '
        Me.msmagneti.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeyDeOhmToolStripMenuItem})
        Me.msmagneti.Name = "msmagneti"
        Me.msmagneti.Size = New System.Drawing.Size(122, 20)
        Me.msmagneti.Text = "Electromagnetismo"
        '
        'LeyDeOhmToolStripMenuItem
        '
        Me.LeyDeOhmToolStripMenuItem.Name = "LeyDeOhmToolStripMenuItem"
        Me.LeyDeOhmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LeyDeOhmToolStripMenuItem.Text = "Ley de Ohm"
        '
        'ConversionesToolStripMenuItem
        '
        Me.ConversionesToolStripMenuItem.Name = "ConversionesToolStripMenuItem"
        Me.ConversionesToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ConversionesToolStripMenuItem.Text = "Conversiones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(994, 261)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(244, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 37)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Movimiento rectilíneo uniforme (MRU o MRC)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(22, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Tiempo (t)="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(22, 487)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Distancia (d)="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(22, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Velocidad (v)="
        '
        'chbproce
        '
        Me.chbproce.AutoSize = True
        Me.chbproce.BackColor = System.Drawing.Color.Transparent
        Me.chbproce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbproce.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chbproce.Location = New System.Drawing.Point(26, 593)
        Me.chbproce.Name = "chbproce"
        Me.chbproce.Size = New System.Drawing.Size(174, 28)
        Me.chbproce.TabIndex = 60
        Me.chbproce.Text = "Mostrar procesos"
        Me.chbproce.UseVisualStyleBackColor = False
        '
        'txttiempo
        '
        Me.txttiempo.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txttiempo.Location = New System.Drawing.Point(174, 434)
        Me.txttiempo.Multiline = True
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(133, 30)
        Me.txttiempo.TabIndex = 61
        '
        'txtvelocidad
        '
        Me.txtvelocidad.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtvelocidad.Location = New System.Drawing.Point(174, 532)
        Me.txtvelocidad.Multiline = True
        Me.txtvelocidad.Name = "txtvelocidad"
        Me.txtvelocidad.Size = New System.Drawing.Size(133, 30)
        Me.txtvelocidad.TabIndex = 62
        '
        'txtdistancia
        '
        Me.txtdistancia.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtdistancia.Location = New System.Drawing.Point(174, 481)
        Me.txtdistancia.Multiline = True
        Me.txtdistancia.Name = "txtdistancia"
        Me.txtdistancia.Size = New System.Drawing.Size(133, 30)
        Me.txtdistancia.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(313, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "s"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(313, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(313, 538)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 24)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "m/s"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(534, 416)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(123, 62)
        Me.btnlimpiar.TabIndex = 68
        Me.btnlimpiar.Text = "Limpiar cuadros"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnmru
        '
        Me.btnmru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmru.Location = New System.Drawing.Point(381, 416)
        Me.btnmru.Name = "btnmru"
        Me.btnmru.Size = New System.Drawing.Size(123, 62)
        Me.btnmru.TabIndex = 67
        Me.btnmru.Text = "Calcular"
        Me.btnmru.UseVisualStyleBackColor = True
        '
        'MRU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnmru)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdistancia)
        Me.Controls.Add(Me.txtvelocidad)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.chbproce)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MRU"
        Me.Text = "MRU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msmru As ToolStripMenuItem
    Friend WithEvents MovimientoRectilíneoUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoCircularUniformaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimintoParabolicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DinámicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msestati As ToolStripMenuItem
    Friend WithEvents LeyDeCoulombToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msmagneti As ToolStripMenuItem
    Friend WithEvents LeyDeOhmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chbproce As CheckBox
    Friend WithEvents txttiempo As NumericTextBox
    Friend WithEvents txtvelocidad As NumericTextBox
    Friend WithEvents txtdistancia As NumericTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnmru As Button
End Class
