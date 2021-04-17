Public Class Ley_Coulomb
    Public r, f, q1, q2 As Double

    Private Sub MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Click
        Me.Hide()
        MRUA.Show()
    End Sub

    Private Sub MovimientoCircularUniformaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoCircularUniformaToolStripMenuItem.Click
        Me.Hide()
        MCU.Show()
    End Sub

    Private Sub mostre_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

    End Sub

    Private Sub ConversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionesToolStripMenuItem.Click
        Conversiones.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub LeyDeOhmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeOhmToolStripMenuItem.Click
        Me.Hide()
        Ley_de_ohm.Show()

    End Sub

    Private Sub MovimientoRectilíneoUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformeToolStripMenuItem.Click
        Me.Hide()
        MRU.Show()
    End Sub

    Public k As Double

    Private Sub btnmru_Click(sender As Object, e As EventArgs) Handles btnmru.Click
        On Error GoTo control
        If txtf.Text = "" Then
            k = 9 * (10 ^ 9)
            q1 = txtq1.Text
            q2 = txtq2.Text
            r = txtr.Text
            f = ((k * q1 * q2) / (r ^ 2))
            txtf.Text = f
            Exit Sub
        ElseIf txtq1.Text = "" And txtq2.Text = ""
            k = 9 * (10 ^ 9)
            r = txtr.Text
            f = txtf.Text
            q1 = Math.Sqrt((f * (r ^ 2)) / k)
            txtq1.Text = q1
            txtq2.Text = q1
            Exit Sub
        ElseIf txtq1.Text = "" Then
            k = 9 * (10 ^ 9)
            q2 = txtq2.Text
            r = txtr.Text
            f = txtf.Text
            q1 = ((f * (r ^ 2) / k * q2))
            txtq1.Text = q1
            Exit Sub
        ElseIf txtq2.Text = "" Then
            k = 9 * (10 ^ 9)
            q1 = txtq1.Text
            r = txtr.Text
            f = txtf.Text
            q2 = ((f * (r ^ 2) / k * q1))
            txtq2.Text = q2
            Exit Sub
        ElseIf txtr.Text = "" Then
            k = 9 * (10 ^ 9)
            q1 = txtq1.Text
            q2 = txtq2.Text
            f = txtf.Text
            r = Math.Sqrt((q1 * q2 * k) / f)
            txtr.Text = r
            Exit Sub
        End If
control:
        MsgBox("Por favor revise que haya digitado las variables correctamente.", 64 + 48 + 256, "Asistente Físico")
    End Sub
End Class