<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ley_Coulomb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ley_Coulomb))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmru = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoCircularUniformaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DinámicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msestati = New System.Windows.Forms.ToolStripMenuItem()
        Me.msmagneti = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeyDeOhmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtq1 = New ASFIMA.NumericTextBox()
        Me.txtq2 = New ASFIMA.NumericTextBox()
        Me.txtf = New ASFIMA.NumericTextBox()
        Me.txtr = New ASFIMA.NumericTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.TabIndex = 46
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
        Me.msmru.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientoRectilíneoUniformeToolStripMenuItem, Me.MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem, Me.MovimientoCircularUniformaToolStripMenuItem})
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
        'DinámicaToolStripMenuItem
        '
        Me.DinámicaToolStripMenuItem.Name = "DinámicaToolStripMenuItem"
        Me.DinámicaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.DinámicaToolStripMenuItem.Text = "Dinámica"
        '
        'msestati
        '
        Me.msestati.Name = "msestati"
        Me.msestati.Size = New System.Drawing.Size(89, 20)
        Me.msestati.Text = "Electrostática"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(356, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Ley de Coulomb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(977, 319)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(20, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 24)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Carga 2 (q2)="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(15, 550)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Distancia entre las cargas (r)="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(20, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Carga 1 (q1)="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(20, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Fuerza (F)="
        '
        'txtq1
        '
        Me.txtq1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtq1.Location = New System.Drawing.Point(163, 440)
        Me.txtq1.Multiline = True
        Me.txtq1.Name = "txtq1"
        Me.txtq1.Size = New System.Drawing.Size(113, 25)
        Me.txtq1.TabIndex = 58
        '
        'txtq2
        '
        Me.txtq2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtq2.Location = New System.Drawing.Point(163, 476)
        Me.txtq2.Multiline = True
        Me.txtq2.Name = "txtq2"
        Me.txtq2.Size = New System.Drawing.Size(113, 25)
        Me.txtq2.TabIndex = 59
        '
        'txtf
        '
        Me.txtf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtf.Location = New System.Drawing.Point(163, 513)
        Me.txtf.Multiline = True
        Me.txtf.Name = "txtf"
        Me.txtf.Size = New System.Drawing.Size(113, 25)
        Me.txtf.TabIndex = 60
        '
        'txtr
        '
        Me.txtr.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtr.Location = New System.Drawing.Point(308, 549)
        Me.txtr.Multiline = True
        Me.txtr.Name = "txtr"
        Me.txtr.Size = New System.Drawing.Size(113, 25)
        Me.txtr.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(278, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(278, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 24)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "C"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(277, 514)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 24)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "N"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(427, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "m"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(755, 482)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(79, 36)
        Me.btnlimpiar.TabIndex = 69
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnmru
        '
        Me.btnmru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmru.Location = New System.Drawing.Point(840, 483)
        Me.btnmru.Name = "btnmru"
        Me.btnmru.Size = New System.Drawing.Size(112, 35)
        Me.btnmru.TabIndex = 68
        Me.btnmru.Text = "Calcular"
        Me.btnmru.UseVisualStyleBackColor = True
        '
        'Ley_Coulomb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnmru)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtr)
        Me.Controls.Add(Me.txtf)
        Me.Controls.Add(Me.txtq2)
        Me.Controls.Add(Me.txtq1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ley_Coulomb"
        Me.Text = "Ley_Coulomb"
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
    Friend WithEvents DinámicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msestati As ToolStripMenuItem
    Friend WithEvents msmagneti As ToolStripMenuItem
    Friend WithEvents LeyDeOhmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtq1 As NumericTextBox
    Friend WithEvents txtq2 As NumericTextBox
    Friend WithEvents txtf As NumericTextBox
    Friend WithEvents txtr As NumericTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnmru As Button
End Class
