Public Class Cuerpos_sólidos
    Public AT, Abase, AL, AB, l, a, Pb, h, app, n, apb, g, radio As Decimal

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub EcuacionesCuadráticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesCuadráticasToolStripMenuItem.Click
        Me.Hide()
        Funciones_cuadráticas.Show()
    End Sub

    Private Sub CuerposSólidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposSólidosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_planos.Show()
    End Sub

    Private Sub FunciónLinealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónLinealToolStripMenuItem.Click
        Me.Hide()
        Funciones_cuadráticas.Show()
    End Sub

    Private Sub FunciónCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónCuadráticaToolStripMenuItem.Click
        Me.Hide()
        Funciones_lineales.Show()
    End Sub

    Public base, cuerpo As String

    Private Sub rbAL_CheckedChanged(sender As Object, e As EventArgs) Handles rbAL.CheckedChanged
        cuerpo = cbcuerpos.Text
        base = cbbase.Text
        If cuerpo = "Prisma" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtbancho.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtradio.Enabled = False
                txtradio.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
            End If
        ElseIf cuerpo = "Piramide" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtbancho.Text = ""
                txtapp.Enabled = True
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            End If
        ElseIf cuerpo = "Cilindro"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = True
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cono"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = True
            txtradio.Enabled = True
        ElseIf cuerpo = "Cubo"
            txtblargo.Enabled = True
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = False
            txtradio.Text = ""
        ElseIf cuerpo = "Esfera"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        End If
    End Sub

    Private Sub rbPb_CheckedChanged(sender As Object, e As EventArgs) Handles rbPb.CheckedChanged
        cuerpo = cbcuerpos.Text
        base = cbbase.Text
        If cuerpo = "Prisma" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtradio.Enabled = False
                txtradio.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
            End If
        ElseIf cuerpo = "Piramide" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            End If
        ElseIf cuerpo = "Cilindro"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cono"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cubo"
            txtblargo.Enabled = True
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = False
            txtradio.Text = ""
        End If
    End Sub

    Private Sub rbabase_CheckedChanged(sender As Object, e As EventArgs) Handles rbabase.CheckedChanged
        cuerpo = cbcuerpos.Text
        base = cbbase.Text
        If cuerpo = "Prisma" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtradio.Enabled = False
                txtradio.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
            End If
        ElseIf cuerpo = "Piramide" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            End If
        ElseIf cuerpo = "Cilindro"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cono"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cubo"
            txtblargo.Enabled = True
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = False
            txtradio.Text = ""
        End If
    End Sub

    Private Sub rbAB_CheckedChanged(sender As Object, e As EventArgs) Handles rbAB.CheckedChanged
        cuerpo = cbcuerpos.Text
        base = cbbase.Text
        If cuerpo = "Prisma" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtradio.Enabled = False
                txtradio.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
            End If
        ElseIf cuerpo = "Piramide" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            End If
        ElseIf cuerpo = "Cilindro"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cono"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cubo"
            txtblargo.Enabled = True
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = False
            txtradio.Text = ""
        End If
    End Sub

    Private Sub rbAT_CheckedChanged(sender As Object, e As EventArgs) Handles rbAT.CheckedChanged
        cuerpo = cbcuerpos.Text
        base = cbbase.Text
        If cuerpo = "Prisma" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtbancho.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtapp.Enabled = False
                txtapp.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = True
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtradio.Enabled = False
                txtradio.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtapp.Enabled = False
                txtapp.Text = ""
            End If
        ElseIf cuerpo = "Piramide" Then
            If base = "Cuadrada" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtbapotema.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Rectangular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbancho.Enabled = True
                txtbancho.Text = ""
                txtapp.Enabled = True
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Trigulo equilatero" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtbapotema.Enabled = False
                txtg.Enabled = False
                txtg.Text = ""
                txtnlados.Enabled = False
                txtnlados.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            ElseIf base = "Otro poligono regular" Then
                txtblargo.Enabled = True
                txth.Enabled = False
                txth.Text = ""
                txtbapotema.Enabled = True
                txtnlados.Enabled = True
                txtapp.Enabled = True
                txtbancho.Enabled = False
                txtbancho.Text = ""
                txtg.Enabled = False
                txtg.Text = ""
                txtradio.Enabled = False
                txtradio.Text = ""
            End If
        ElseIf cuerpo = "Cilindro"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = True
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        ElseIf cuerpo = "Cono"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = True
            txtradio.Enabled = True
        ElseIf cuerpo = "Cubo"
            txtblargo.Enabled = True
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = False
            txtradio.Text = ""
        ElseIf cuerpo = "Esfera"
            txtblargo.Enabled = False
            txtblargo.Text = ""
            txth.Enabled = False
            txth.Text = ""
            txtbapotema.Enabled = False
            txtbapotema.Text = ""
            txtnlados.Enabled = False
            txtnlados.Text = ""
            txtapp.Enabled = False
            txtapp.Text = ""
            txtbancho.Enabled = False
            txtbancho.Text = ""
            txtg.Enabled = False
            txtg.Text = ""
            txtradio.Enabled = True
        End If
    End Sub

    Private Sub cbcuerpos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcuerpos.SelectedIndexChanged
        If cbcuerpos.Text = "Prisma" Then
            cbbase.Enabled = True

            rbAB.Enabled = True
            rbabase.Enabled = True
            rbAT.Enabled = True
            rbAL.Enabled = True
            rbPb.Enabled = True
        ElseIf cbcuerpos.Text = "Piramide" Then
            cbbase.Enabled = True

            rbAB.Enabled = True
            rbabase.Enabled = True
            rbAT.Enabled = True
            rbAL.Enabled = True
            rbPb.Enabled = True
        ElseIf cbcuerpos.Text = "Cubo" Then
            cbbase.Text = ""
            cbbase.Enabled = False
            rbAB.Enabled = True
            rbabase.Enabled = True
            rbAT.Enabled = True
            rbAL.Enabled = True
            rbPb.Enabled = True
        ElseIf cbcuerpos.Text = "Cilindro" Then
            cbbase.Text = ""
            cbbase.Enabled = False
            rbAB.Enabled = True
            rbabase.Enabled = True
            rbAT.Enabled = True
            rbAL.Enabled = True
            rbPb.Enabled = True
        ElseIf cbcuerpos.Text = "Esfera" Then
            cbbase.Text = ""
            cbbase.Enabled = False
            rbAB.Enabled = False
            rbabase.Enabled = False
            rbAT.Enabled = True
            rbAL.Enabled = False
            rbPb.Enabled = False
        ElseIf cbcuerpos.Text = "Cono" Then
            cbbase.Text = ""
            cbbase.Enabled = False
            rbAB.Enabled = True
            rbabase.Enabled = True
            rbAT.Enabled = True
            rbAL.Enabled = True
            rbPb.Enabled = True
        End If
    End Sub
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        cuerpo = cbcuerpos.Text
        base = cbbase.SelectedItem

        If cuerpo = "" Then
            MsgBox("Seleccione el cuerpo solido con el que desea trabajar")
            Exit Sub
        ElseIf cbbase.Enabled = True Then
            If base = "" Then
                MsgBox("Porfavor seleccione la forma de la base")
                Exit Sub
            End If
        End If

        If rbAB.Checked = True Then
            If cuerpo = "Prisma" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = l * l
                    AB = Abase * 2
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    Abase = l * a
                    AB = Abase * 2
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4
                    AB = Abase * 2
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    AB = Abase * 2
                    txtresultado.Text = AB
                    Exit Sub
                End If

            ElseIf cuerpo = "Piramide" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = l * l
                    AB = Abase
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    Abase = l * a
                    AB = Abase
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4
                    AB = Abase
                    txtresultado.Text = AB
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    AB = Abase
                    txtresultado.Text = AB
                    Exit Sub
                End If
            ElseIf cuerpo = "Cubo" Then
                If txtblargo.Text = "" Then
                    MsgBox("Porfavor digite el lado de la base")
                    Exit Sub
                End If
                l = txtblargo.Text
                Pb = l * 4
                Abase = Math.Pow(l, 2)
                AB = Abase * 2
                txtresultado.Text = AB
                Exit Sub
            ElseIf cuerpo = "Cono" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Abase = Math.Pow(radio, 2) * 3.14
                AB = Abase
                txtresultado.Text = AB
                Exit Sub
            ElseIf cuerpo = "Cilindro" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Abase = Math.Pow(radio, 2) * 3.14
                AB = Abase * 2
                txtresultado.Text = AB
                Exit Sub
            End If

        ElseIf rbabase.Checked = True Then
            If cuerpo = "Prisma" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = l * l
                    txtresultado.Text = Abase
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    Abase = l * a
                    txtresultado.Text = Abase
                    Exit Sub

                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4
                    txtresultado.Text = Abase
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    txtresultado.Text = Abase
                    Exit Sub
                End If

            ElseIf cuerpo = "Piramide" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = l * l
                    txtresultado.Text = Abase
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    Abase = l * a
                    txtresultado.Text = Abase
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4

                    txtresultado.Text = Abase
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    txtresultado.Text = Abase
                    Exit Sub
                End If
            ElseIf cuerpo = "Cubo" Then
                If txtblargo.Text = "" Then
                    MsgBox("Porfavor digite el lado de la base")
                    Exit Sub
                End If
                l = txtblargo.Text
                Abase = l * l
                txtresultado.Text = Abase
                Exit Sub
            ElseIf cuerpo = "Cono" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Abase = Math.Pow(radio, 2) * 3.14
            ElseIf cuerpo = "Cilindro" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Abase = Math.Pow(radio, 2) * 3.14
                txtresultado.Text = Abase
                Exit Sub
            End If
        ElseIf rbAT.Checked = True Then
            If cuerpo = "Prisma" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l * 4
                    Abase = l * l
                    AB = Abase * 2
                    AL = Pb * h
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l + l + a + a
                    Abase = l * a
                    AB = Abase * 2
                    AL = Pb * h
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l * 3
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4
                    AB = Abase * 2
                    AL = Pb * h
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    h = txth.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    AB = Abase * 2
                    AL = Pb * h
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                End If

            ElseIf cuerpo = "Piramide" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    End If
                    Pb = l * 4
                    l = txtblargo.Text
                    app = txtapp.Text
                    Abase = l * l
                    AB = Abase
                    AL = (Pb * app) / 2
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    Pb = l * a
                    a = txtbancho.Text
                    l = txtblargo.Text
                    app = txtapp.Text
                    Abase = l * a
                    AB = Abase
                    AL = (Pb * app) / 2
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    End If
                    Pb = l * 3
                    l = txtblargo.Text
                    app = txtapp.Text
                    Abase = Math.Pow(l, 2) * Math.Sqrt(3) / 4
                    AB = Abase
                    AL = (Pb * app) / 2
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    app = txtapp.Text
                    apb = txtbapotema.Text
                    Pb = l * n
                    Abase = Pb * apb / 2
                    AB = Abase
                    AL = (Pb * app)
                    AT = AL + AB
                    txtresultado.Text = AT
                    Exit Sub
                End If
            ElseIf cuerpo = "Cubo" Then
                If txtblargo.Text = "" Then
                    MsgBox("Porfavor digite el lado de la base")
                    Exit Sub
                End If
                l = txtblargo.Text
                Pb = l * 4
                Abase = Math.Pow(l, 2)
                AB = Math.Pow(l, 2) * 2
                AL = Math.Pow(l, 2) * 4
                AT = Math.Pow(l, 2) * 6
                txtresultado.Text = AT
                Exit Sub
            ElseIf cuerpo = "Cono"
                If txtg.Text = "" Then
                    MsgBox("Porfavor digite la generatriz")
                    Exit Sub
                ElseIf txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                g = txtg.Text
                radio = txtradio.Text
                Pb = 2 * radio * 3.14
                Abase = Math.Pow(radio, 2) * 3.14
                AB = Abase
                AL = radio * g * 3.14
                AT = AB + AL
                txtresultado.Text = AT
                Exit Sub
            ElseIf cuerpo = "Cilindro" Then
                If txth.Text = "" Then
                    MsgBox("Porfavor digite la altura del cilindro")
                    Exit Sub
                ElseIf txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                h = txth.Text
                radio = txtradio.Text
                Pb = radio * 3.14 * 2
                Abase = Math.Pow(radio, 2) * 3.14
                AB = Abase * 2
                AL = radio * h * 3.14 * 2
                AT = AL + AB
                txtresultado.Text = AT
                Exit Sub
            ElseIf cuerpo = "Esfera" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la esfera")
                    Exit Sub
                End If
                radio = txtradio.Text
                AT = 4 * 3.14 * Math.Pow(radio, 2)
                txtresultado.Text = AT
                Exit Sub
            End If
        ElseIf rbPb.Checked = True Then
            If cuerpo = "Prisma" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Pb = l * 4
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    Pb = l + l + a + a
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    Pb = l * 3
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    Pb = l * n
                    txtresultado.Text = Pb
                    Exit Sub
                End If

            ElseIf cuerpo = "Piramide" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    End If
                    Pb = l * 4
                    l = txtblargo.Text
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    Pb = l * a
                    a = txtbancho.Text
                    l = txtblargo.Text
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    End If
                    Pb = l * 3
                    l = txtblargo.Text
                    txtresultado.Text = Pb
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    Pb = l * n
                    txtresultado.Text = Pb
                    Exit Sub
                End If
            ElseIf cuerpo = "Cubo" Then
                If txtblargo.Text = "" Then
                    MsgBox("Porfavor digite el lado de la base")
                    Exit Sub
                End If
                l = txtblargo.Text
                Pb = l * 4
                txtresultado.Text = Pb
                Exit Sub
            ElseIf cuerpo = "Cono"
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Pb = 2 * radio * 3.14
                txtresultado.Text = Pb
                Exit Sub
            ElseIf cuerpo = "Cilindro" Then
                If txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                radio = txtradio.Text
                Pb = radio * 3.14 * 2
                txtresultado.Text = Pb
                Exit Sub
            End If
        ElseIf rbAL.Checked = True Then
            If cuerpo = "Prisma" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l * 4
                    AL = Pb * h
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    a = txtbancho.Text
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l + l + a + a
                    AL = Pb * h
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    End If
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l * 3
                    AL = Pb * h
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txth.Text = "" Then
                        MsgBox("Porfavor digite la altura del prisma")
                        Exit Sub
                    ElseIf txtbapotema.Text = "" Then
                        MsgBox("Porfavor digite la apotema de la base")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    h = txth.Text
                    Pb = l * n
                    AL = Pb * h
                    txtresultado.Text = AL
                    Exit Sub
                End If

            ElseIf cuerpo = "Piramide" Then
                If base = "Cuadrada" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el lado de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    End If
                    Pb = l * 4
                    l = txtblargo.Text
                    app = txtapp.Text
                    AL = (Pb * app) / 2
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Rectangular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    ElseIf txtbancho.Text = "" Then
                        MsgBox("Porfavor digite el ancho de la base")
                        Exit Sub
                    End If
                    Pb = l * a
                    a = txtbancho.Text
                    l = txtblargo.Text
                    app = txtapp.Text
                    AL = (Pb * app) / 2
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Trigulo equilatero" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    End If
                    Pb = l * 3
                    l = txtblargo.Text
                    app = txtapp.Text
                    AL = (Pb * app) / 2
                    txtresultado.Text = AL
                    Exit Sub
                ElseIf base = "Otro poligono regular" Then
                    If txtblargo.Text = "" Then
                        MsgBox("Porfavor digite el largo de la base")
                        Exit Sub
                    ElseIf txtapp.Text = "" Then
                        MsgBox("Porfavor digite el apotema de la piramide")
                        Exit Sub
                    ElseIf txtnlados.Text = "" Then
                        MsgBox("Porfavor digite el numero de lados de la base")
                        Exit Sub
                    End If
                    n = txtnlados.Text
                    l = txtblargo.Text
                    app = txtapp.Text
                    Pb = l * n
                    AL = (Pb * app)
                    txtresultado.Text = AL
                    Exit Sub
                End If
            ElseIf cuerpo = "Cubo" Then
                If txtblargo.Text = "" Then
                    MsgBox("Porfavor digite el lado de la base")
                    Exit Sub
                End If
                l = txtblargo.Text
                Pb = l * 4
                AL = Math.Pow(l, 2) * 4
                txtresultado.Text = AL
                Exit Sub
            ElseIf cuerpo = "Cono"
                If txtg.Text = "" Then
                    MsgBox("Porfavor digite la generatriz")
                    Exit Sub
                ElseIf txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                g = txtg.Text
                radio = txtradio.Text
                AL = radio * g * 3.14
                txtresultado.Text = AL
                Exit Sub
            ElseIf cuerpo = "Cilindro" Then
                If txth.Text = "" Then
                    MsgBox("Porfavor digite la altura del cilindro")
                    Exit Sub
                ElseIf txtradio.Text = "" Then
                    MsgBox("Porfavor digite el radio de la base")
                    Exit Sub
                End If
                h = txth.Text
                radio = txtradio.Text
                AL = radio * h * 3.14 * 2
                txtresultado.Text = AL
                Exit Sub
            End If

        Else
            MsgBox("Porfavor seleccione que va a calcular")
        End If

    End Sub
End Class