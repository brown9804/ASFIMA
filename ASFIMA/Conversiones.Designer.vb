<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conversiones))
        Me.txtunidad2 = New System.Windows.Forms.TextBox()
        Me.txtunidad1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblunidad = New System.Windows.Forms.Label()
        Me.btnx10 = New System.Windows.Forms.Button()
        Me.btndecimal = New System.Windows.Forms.Button()
        Me.btncientifico = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.btnconversion = New System.Windows.Forms.Button()
        Me.txtvalor = New ASFIMA.NumericTextBox()
        Me.SuspendLayout()
        '
        'txtunidad2
        '
        Me.txtunidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtunidad2.Location = New System.Drawing.Point(197, 137)
        Me.txtunidad2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtunidad2.Name = "txtunidad2"
        Me.txtunidad2.Size = New System.Drawing.Size(83, 29)
        Me.txtunidad2.TabIndex = 28
        '
        'txtunidad1
        '
        Me.txtunidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtunidad1.Location = New System.Drawing.Point(197, 97)
        Me.txtunidad1.Margin = New System.Windows.Forms.Padding(6)
        Me.txtunidad1.Name = "txtunidad1"
        Me.txtunidad1.Size = New System.Drawing.Size(83, 29)
        Me.txtunidad1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(8, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Unidad actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(9, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Unidad a convertir:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Digite el valor a convertir:"
        '
        'lblunidad
        '
        Me.lblunidad.AutoSize = True
        Me.lblunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblunidad.Location = New System.Drawing.Point(254, 190)
        Me.lblunidad.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(0, 24)
        Me.lblunidad.TabIndex = 33
        '
        'btnx10
        '
        Me.btnx10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnx10.Location = New System.Drawing.Point(243, 291)
        Me.btnx10.Margin = New System.Windows.Forms.Padding(6)
        Me.btnx10.Name = "btnx10"
        Me.btnx10.Size = New System.Drawing.Size(111, 42)
        Me.btnx10.TabIndex = 32
        Me.btnx10.Text = "*10^"
        Me.btnx10.UseVisualStyleBackColor = True
        '
        'btndecimal
        '
        Me.btndecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btndecimal.Location = New System.Drawing.Point(9, 237)
        Me.btndecimal.Margin = New System.Windows.Forms.Padding(6)
        Me.btndecimal.Name = "btndecimal"
        Me.btndecimal.Size = New System.Drawing.Size(231, 42)
        Me.btndecimal.TabIndex = 31
        Me.btndecimal.Text = "Notacion Decimal"
        Me.btndecimal.UseVisualStyleBackColor = True
        '
        'btncientifico
        '
        Me.btncientifico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btncientifico.Location = New System.Drawing.Point(9, 291)
        Me.btncientifico.Margin = New System.Windows.Forms.Padding(6)
        Me.btncientifico.Name = "btncientifico"
        Me.btncientifico.Size = New System.Drawing.Size(231, 42)
        Me.btncientifico.TabIndex = 30
        Me.btncientifico.Text = "Notacion cientifica"
        Me.btncientifico.UseVisualStyleBackColor = True
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblresultado.Location = New System.Drawing.Point(104, 190)
        Me.lblresultado.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblresultado.Size = New System.Drawing.Size(0, 24)
        Me.lblresultado.TabIndex = 29
        '
        'btnconversion
        '
        Me.btnconversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnconversion.Location = New System.Drawing.Point(243, 237)
        Me.btnconversion.Margin = New System.Windows.Forms.Padding(6)
        Me.btnconversion.Name = "btnconversion"
        Me.btnconversion.Size = New System.Drawing.Size(111, 42)
        Me.btnconversion.TabIndex = 27
        Me.btnconversion.Text = "Convertir"
        Me.btnconversion.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(13, 37)
        Me.txtvalor.Multiline = True
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(289, 32)
        Me.txtvalor.TabIndex = 37
        '
        'Conversiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 342)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.txtunidad2)
        Me.Controls.Add(Me.txtunidad1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblunidad)
        Me.Controls.Add(Me.btnx10)
        Me.Controls.Add(Me.btndecimal)
        Me.Controls.Add(Me.btncientifico)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.btnconversion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Conversiones"
        Me.Text = "Conversiones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtunidad2 As TextBox
    Friend WithEvents txtunidad1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblunidad As Label
    Friend WithEvents btnx10 As Button
    Friend WithEvents btndecimal As Button
    Friend WithEvents btncientifico As Button
    Friend WithEvents lblresultado As Label
    Friend WithEvents btnconversion As Button
    Friend WithEvents txtvalor As NumericTextBox
End Class
