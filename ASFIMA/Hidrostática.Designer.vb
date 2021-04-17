<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hidrostática
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hidrostática))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtare = New ASFIMA.NumericTextBox()
        Me.txtFue = New ASFIMA.NumericTextBox()
        Me.txtpre = New ASFIMA.NumericTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltextoar = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(406, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 29)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Presión"
        '
        'txtare
        '
        Me.txtare.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtare.Location = New System.Drawing.Point(175, 477)
        Me.txtare.Name = "txtare"
        Me.txtare.Size = New System.Drawing.Size(100, 35)
        Me.txtare.TabIndex = 107
        '
        'txtFue
        '
        Me.txtFue.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtFue.Location = New System.Drawing.Point(175, 431)
        Me.txtFue.Name = "txtFue"
        Me.txtFue.Size = New System.Drawing.Size(100, 35)
        Me.txtFue.TabIndex = 106
        '
        'txtpre
        '
        Me.txtpre.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtpre.Location = New System.Drawing.Point(175, 383)
        Me.txtpre.Name = "txtpre"
        Me.txtpre.Size = New System.Drawing.Size(100, 35)
        Me.txtpre.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Fuerza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 29)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Área "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Presión "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(296, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "N/m"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(296, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 24)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "N"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(296, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 24)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "m"
        '
        'lbltextoar
        '
        Me.lbltextoar.AutoSize = True
        Me.lbltextoar.BackColor = System.Drawing.Color.Transparent
        Me.lbltextoar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Italic)
        Me.lbltextoar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltextoar.Location = New System.Drawing.Point(84, 66)
        Me.lbltextoar.Name = "lbltextoar"
        Me.lbltextoar.Size = New System.Drawing.Size(690, 87)
        Me.lbltextoar.TabIndex = 113
        Me.lbltextoar.Text = "La presión corresponde al cociente que resulta al dividir el valor de la fuerza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "que cae perpendicular sobre una superficie, entre el área sobre la cual ejerce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "su acción."
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(772, 363)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(218, 76)
        Me.btnlimpiar.TabIndex = 115
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(523, 363)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(218, 76)
        Me.btncalcular.TabIndex = 114
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Hidrostática
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.lbltextoar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtare)
        Me.Controls.Add(Me.txtFue)
        Me.Controls.Add(Me.txtpre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Hidrostática"
        Me.Text = "Hidrostática"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtare As NumericTextBox
    Friend WithEvents txtFue As NumericTextBox
    Friend WithEvents txtpre As NumericTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltextoar As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btncalcular As Button
End Class
