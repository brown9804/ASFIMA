Public Class Ley_de_ohm
    Public inten, vol, resis, total As String

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtintensidad.Clear()
        txtresistencia.Clear()
        txtvoltaje.Clear()



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        MRU.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.Hide()
        MRUA.Show()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Me.Hide()
        MCU.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Me.Hide()
        Conversiones.Show()

    End Sub

    Private Sub lblcalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        inten = txtintensidad.Text
        vol = txtvoltaje.Text
        resis = txtresistencia.Text


        If inten = "" Then
            inten = vol / resis
            txtintensidad.Text = inten

        ElseIf resis = "" Then
            resis = vol / inten
            txtresistencia.Text = resis
        ElseIf vol = "" Then
            vol = inten * resis
            txtvoltaje.Text = vol
        End If

    End Sub

    Private Sub Ley_de_ohm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class