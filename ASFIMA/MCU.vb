Public Class MCU

    Private Sub btnmru_Click(sender As Object, e As EventArgs) Handles btnmru.Click
        Dim ac, vt, m, r, fc, t, f As Double
        On Error GoTo Control
        If rbf1.Checked = True Then
            If txtvt.Text = "" Then
                r = txtr.Text
                f = txtf.Text
                vt = 2 * 3.14 * r * f
                txtvt.Text = vt
            ElseIf txtr.Text = "" Then
                f = txtf.Text
                vt = txtvt.Text
                r = vt / (2 * 3.14 * f)
                txtr.Text = r
            ElseIf txtf.Text = "" Then
                r = txtr.Text
                vt = txtvt.Text
                f = vt / (2 * 3.14 * r)
                txtf.Text = f
            End If
        ElseIf rbf2.Checked = True Then
            If txtvt.Text = "" Then
                t = txtt.Text
                r = txtr.Text
                vt = (2 * 3.14 * r) / t
                txtvt.Text = vt
            ElseIf txtt.Text = "" Then
                vt = txtvt.Text
                r = txtr.Text
                t = (2 * 3.14 * r) / vt
                txtt.Text = t
            ElseIf txtr.Text = "" Then
                vt = txtvt.Text
                t = txtt.Text
                r = (vt * t) / (2 * 3.14)
                txtr.Text = r
            End If
        ElseIf rbf3.Checked = True Then
            If txtt.Text = "" Then
                f = txtf.Text
                t = 1 / f
                txtt.Text = t
            ElseIf txtf.Text = "" Then
                t = txtt.Text
                f = 1 / t
                txtf.Text = f
            End If
        ElseIf rbf4.Checked = True Then
            If txtac.Text = "" Then
                vt = txtvt.Text
                r = txtr.Text
                ac = (vt ^ 2) / r
                txtac.Text = ac
            ElseIf txtr.Text = "" Then
                vt = txtvt.Text
                ac = txtac.Text
                r = (vt ^ 2) / ac
                txtr.Text = r
            ElseIf txtvt.Text = "" Then
                ac = txtac.Text
                r = txtr.Text
                vt = Math.Sqrt(ac * r)
                txtvt.Text = vt
            End If
        ElseIf rbf5.Checked = True
            If txtfc.Text = "" Then
                ac = txtac.Text
                m = txtmasa.Text
                fc = m * ac
                txtfc.Text = fc
            ElseIf txtmasa.Text = "" Then
                fc = txtfc.Text
                ac = txtac.Text
                m = fc / ac
                txtmasa.Text = m
            ElseIf txtac.Text = "" Then
                fc = txtfc.Text
                m = txtmasa.Text
                ac = fc / m
                txtac.Text = ac
            End If
        End If
Control:
        MsgBox("Por favor asegúrese de que insertó las variables correctamente y que seleccionó correctamente la fórmula. " & Err.Description, 64 + 48 + 256, "Asistente Físico")
    End Sub
    Private Sub rbf1_CheckedChanged(sender As Object, e As EventArgs) Handles rbf1.CheckedChanged

        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
        txtac.Enabled = False
        txtmasa.Enabled = False
        txtfc.Enabled = False
        txtt.Enabled = False
        txtvt.Enabled = True
        txtr.Enabled = True
        txtf.Enabled = True
    End Sub

    Private Sub rbf2_CheckedChanged(sender As Object, e As EventArgs) Handles rbf2.CheckedChanged

        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
        txtac.Enabled = False
        txtmasa.Enabled = False
        txtfc.Enabled = False
        txtt.Enabled = True
        txtvt.Enabled = True
        txtr.Enabled = True
        txtf.Enabled = False
    End Sub

    Private Sub rbf3_CheckedChanged(sender As Object, e As EventArgs) Handles rbf3.CheckedChanged

        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
        txtac.Enabled = False
        txtmasa.Enabled = False
        txtfc.Enabled = False
        txtt.Enabled = True
        txtvt.Enabled = False
        txtr.Enabled = False
        txtf.Enabled = True
    End Sub
    Private Sub rbf5_CheckedChanged(sender As Object, e As EventArgs) Handles rbf5.CheckedChanged
        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
        txtac.Enabled = True
        txtmasa.Enabled = True
        txtfc.Enabled = True
        txtt.Enabled = False
        txtvt.Enabled = False
        txtr.Enabled = False
        txtf.Enabled = False
    End Sub

    Private Sub rbf4_CheckedChanged(sender As Object, e As EventArgs) Handles rbf4.CheckedChanged

        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
        txtac.Enabled = True
        txtmasa.Enabled = False
        txtfc.Enabled = False
        txtt.Enabled = False
        txtvt.Enabled = True
        txtr.Enabled = True
        txtf.Enabled = False
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        rbf1.Checked = False
        rbf2.Checked = False
        rbf3.Checked = False
        rbf4.Checked = False
        rbf5.Checked = False
        txtac.Clear()
        txtmasa.Clear()
        txtfc.Clear()
        txtt.Clear()
        txtvt.Clear()
        txtr.Clear()
        txtf.Clear()
    End Sub

    Private Sub txtac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtac.KeyPress
        If e.KeyChar = ","c Or e.KeyChar = "."c Then
            If txtac.Text.Contains(",") Or txtac.Text.Contains(".") Then e.Handled = True
        ElseIf e.KeyChar = "-"c Then
            If txtac.Text.Contains("-") Then e.Handled = True
        ElseIf e.KeyChar = "^"c Then
            If txtac.Text.Contains("^") Then e.Handled = True
        ElseIf e.KeyChar = "*"c Then
            If txtac.Text.Contains("*") Then e.Handled = True
        ElseIf e.KeyChar = "x"c Then
            If txtac.Text.Contains("x") Then e.Handled = True Exit Sub
        ElseIf Not Char.IsDigit(e.KeyChar) And Not Asc(e.KeyChar) = Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformeToolStripMenuItem.Click
        Me.Hide()
        MRU.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Click
        Me.Hide()
        MRUA.Show()
    End Sub

    Private Sub LeyDeCoulombToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeCoulombToolStripMenuItem.Click
        Me.Hide()
        Ley_Coulomb.Show()
    End Sub

    Private Sub ConversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionesToolStripMenuItem.Click
        Conversiones.Show()
    End Sub

    Private Sub LeyDeOhmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeOhmToolStripMenuItem.Click
        Me.Hide()
        Ley_de_ohm.Show()

    End Sub
End Class