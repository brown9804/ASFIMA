<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Densidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Densidad))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmasa = New ASFIMA.NumericTextBox()
        Me.txtvolumen = New ASFIMA.NumericTextBox()
        Me.txtdensidad = New ASFIMA.NumericTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.lbltextoar = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(325, 523)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 24)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "m^3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(323, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 24)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "kg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(325, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "kg/m^3"
        '
        'txtmasa
        '
        Me.txtmasa.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtmasa.Location = New System.Drawing.Point(193, 558)
        Me.txtmasa.Name = "txtmasa"
        Me.txtmasa.Size = New System.Drawing.Size(100, 35)
        Me.txtmasa.TabIndex = 117
        '
        'txtvolumen
        '
        Me.txtvolumen.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtvolumen.Location = New System.Drawing.Point(193, 512)
        Me.txtvolumen.Name = "txtvolumen"
        Me.txtvolumen.Size = New System.Drawing.Size(100, 35)
        Me.txtvolumen.TabIndex = 116
        '
        'txtdensidad
        '
        Me.txtdensidad.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtdensidad.Location = New System.Drawing.Point(193, 464)
        Me.txtdensidad.Name = "txtdensidad"
        Me.txtdensidad.Size = New System.Drawing.Size(100, 35)
        Me.txtdensidad.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(30, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Volumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 29)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Masa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(30, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 29)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Densidad"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(778, 419)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(218, 76)
        Me.btnlimpiar.TabIndex = 122
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(529, 419)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(218, 76)
        Me.btncalcular.TabIndex = 121
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'lbltextoar
        '
        Me.lbltextoar.AutoSize = True
        Me.lbltextoar.BackColor = System.Drawing.Color.Transparent
        Me.lbltextoar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lbltextoar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltextoar.Location = New System.Drawing.Point(46, 80)
        Me.lbltextoar.Name = "lbltextoar"
        Me.lbltextoar.Size = New System.Drawing.Size(950, 58)
        Me.lbltextoar.TabIndex = 124
        Me.lbltextoar.Text = "El flujo de la corriente que circula por un circuito eléctrico cerrado, es direct" &
    "amente proporcional a la tensión " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o voltaje aplicado, e inversamente proporcion" &
    "al a la resistencia."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(361, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 37)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Densidad"
        '
        'Densidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.lbltextoar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmasa)
        Me.Controls.Add(Me.txtvolumen)
        Me.Controls.Add(Me.txtdensidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Densidad"
        Me.Text = "Densidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmasa As NumericTextBox
    Friend WithEvents txtvolumen As NumericTextBox
    Friend WithEvents txtdensidad As NumericTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents lbltextoar As Label
    Friend WithEvents Label4 As Label
End Class
