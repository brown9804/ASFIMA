Public Class MRU
    Private Sub MRU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = "m/s" & Chr(178)
    End Sub

    Private Sub btnmru_Click(sender As Object, e As EventArgs) Handles btnmru.Click
        Dim v, t, d As Double
        Dim vel, dist, tiemp As String
        If txtvelocidad.Text = "" And txtdistancia.Text <> "" And txttiempo.Text <> "" Then
            t = txttiempo.Text
            d = txtdistancia.Text
            v = d / t
            vel = v
            If vel.Length > 5 Then
                vel = String.Format("{0}", vel.Substring(0, 5))
            Else
                vel = vel
            End If
            txtvelocidad.Text = vel
            If chbproce.Checked = True Then
                Tres_variables_proceso.lblformdespe.Text = "V = D / T"
                Tres_variables_proceso.lblformutili.Text = "D = V * T"
                Tres_variables_proceso.lblsust.Text = "V = " & d & " / " & t
                Tres_variables_proceso.lblresult.Text = vel
                Tres_variables_proceso.Height = (287)
                Tres_variables_proceso.Show()
            End If
        ElseIf txttiempo.Text = "" And txtvelocidad.Text <> "" And txtdistancia.Text <> "" Then
            v = txtvelocidad.Text
            d = txtdistancia.Text
            t = d / v
            tiemp = t
            If tiemp.Length > 5 Then
                tiemp = String.Format("{0}", tiemp.Substring(0, 5))
            Else
                tiemp = tiemp
            End If
            txttiempo.Text = tiemp
            If chbproce.Checked = True Then
                Tres_variables_proceso.lblformdespe.Text = "T = D / V"
                Tres_variables_proceso.lblformutili.Text = "D = V * T"
                Tres_variables_proceso.lblsust.Text = "T = " & d & " / " & v
                Tres_variables_proceso.lblresult.Text = tiemp
                Tres_variables_proceso.Height = (287)
                Tres_variables_proceso.Show()
            End If
        ElseIf txtdistancia.Text = "" And txtvelocidad.Text <> "" And txttiempo.Text <> "" Then
            v = txtvelocidad.Text
            t = txttiempo.Text
            d = v * t
            dist = d
            If dist.Length > 5 Then
                dist = String.Format("{0}", dist.Substring(0, 5))
            Else
                dist = dist
            End If
            txtdistancia.Text = dist
            If chbproce.Checked = True Then
                Tres_variables_proceso.lblformutili.Text = "D = V * T"
                Tres_variables_proceso.lblformdespe.Text = "D = " & v & " * " & t
                Tres_variables_proceso.lblsust.Text = dist
                Tres_variables_proceso.Height = (231)
                Tres_variables_proceso.Show()
            End If
        ElseIf (txtvelocidad.Text = "" And txttiempo.Text = "") Or (txttiempo.Text = "" And txtdistancia.Text = "") Or (txtdistancia.Text = "" And txtvelocidad.Text = "") Then
            MsgBox("Por favor ingrese los datos necesarios para terminar el proceso.", 64 + 48 + 256, "Asistente Físico")
        Else
            MsgBox("Todos los procesos ya fueron resueltos.", 64 + 48 + 256, "Asistente Físico")
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtdistancia.Text = ""
        txttiempo.Text = ""
        txtvelocidad.Text = ""
        Tres_variables_proceso.Hide()
    End Sub

    Private Sub MovimientoCircularUniformaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoCircularUniformaToolStripMenuItem.Click
        Me.Hide()
        MCU.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Click
        Me.Hide()
        MRUA.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformeToolStripMenuItem.Click
        MsgBox("Ya se encuentra en el formulario seleccionado.", 64 + 48 + 256, "Asistente Físico")
    End Sub

    Private Sub ConversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionesToolStripMenuItem.Click
        Conversiones.Show()
    End Sub

    Private Sub LeyDeCoulombToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeCoulombToolStripMenuItem.Click
        Me.Hide()
        Ley_Coulomb.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub LeyDeOhmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeOhmToolStripMenuItem.Click
        Me.Hide()
        Ley_de_ohm.Show()

    End Sub
End Class