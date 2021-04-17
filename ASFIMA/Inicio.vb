Public Class Inicio
    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim valor As Integer

        valor = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Asistente Matemático")

        If valor = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf valor = 1 Then
            e.Cancel = False
        End If
    End Sub
    Private Sub EcuacionesCuadráticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesCuadráticasToolStripMenuItem.Click
        Me.Hide()
        Ecuaciones_cuadráticas.Show()
    End Sub

    Private Sub CuerposPlanosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposPlanosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_planos.Show()
    End Sub


    Private Sub MovimientoRectilíneoUniformeMRUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformeMRUToolStripMenuItem.Click
        Me.Hide()
        MRU.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformementeAceleradoMRUAToolStripMenuItem.Click
        Me.Hide()
        MRUA.Show()
    End Sub

    Private Sub MovimientoCircularUniformeMCUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoCircularUniformeMCUToolStripMenuItem.Click
        Me.Hide()
        MCU.Show()
    End Sub

    Private Sub FuncióLinealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncióLinealToolStripMenuItem.Click
        Me.Hide()
        Funciones_lineales.Show()
    End Sub

    Private Sub FunciónCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónCuadráticaToolStripMenuItem.Click
        Me.Hide()
        Funciones_cuadráticas.Show()
    End Sub

    Private Sub CuerposSólidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposSólidosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_sólidos.Show()
    End Sub

    Private Sub ConversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionesToolStripMenuItem.Click
        Conversiones.Show()
    End Sub

    Private Sub LeyDeOhmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeOhmToolStripMenuItem.Click
        Me.Hide()
        Ley_de_ohm.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub HToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Me.Hide()
        Hidrostática.Show()

    End Sub

    Private Sub DensidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DensidadToolStripMenuItem.Click
        Me.Hide()
        Densidad.Show()

    End Sub
End Class