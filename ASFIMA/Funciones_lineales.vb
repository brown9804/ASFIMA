Public Class Funciones_lineales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valx, crit1, crit2, tocrit As String
        valx = txtvalx.Text
        crit1 = txtcrit1.Text
        crit2 = txtcrit2.Text
        If valx.Contains("/") Then
            valx.Split("/")
            Dim numa As String = valx(0)
            Dim dena As String = valx(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            valx = numa / dena
        Else
            valx = CDbl(valx)
        End If

        If crit1.Contains("/") Then
            crit1.Split("/")
            Dim numa As String = crit1(0)
            Dim dena As String = crit1(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            crit1 = numa / dena
        Else
            crit1 = CDbl(crit1)
        End If
        If crit2.Contains("/") Then
            crit2.Split("/")
            Dim numa As String = crit2(0)
            Dim dena As String = crit2(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            crit2 = numa / dena
        Else
            crit2 = CDbl(crit2)
        End If
        tocrit = (crit1 * valx) + crit2
        MsgBox("El resultado de la función es: " & tocrit, 64 + 48 + 256, "Asistente Matemático")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim par11, par12, par21, par22, m1, m2, b As String
        par11 = txtpar11.Text
        par12 = txtpar12.Text
        par21 = txtpar21.Text
        par22 = txtpar22.Text
        If par11.Contains("/") Then
            par11.Split("/")
            Dim numa As String = par11(0)
            Dim dena As String = par11(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            par11 = numa / dena
        Else
            par11 = CDbl(par11)
        End If

        If par12.Contains("/") Then
            par12.Split("/")
            Dim numa As String = par12(0)
            Dim dena As String = par12(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            par12 = numa / dena
        Else
            par12 = CDbl(par12)
        End If
        If par21.Contains("/") Then
            par21.Split("/")
            Dim numa As String = par21(0)
            Dim dena As String = par21(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            par21 = numa / dena
        Else
            par21 = CDbl(par21)
        End If
        If par22.Contains("/") Then
            par22.Split("/")
            Dim numa As String = par22(0)
            Dim dena As String = par22(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            par22 = numa / dena
        Else
            par22 = CDbl(par22)
        End If
        m1 = (par22 - par12)
        m2 = (par21 - par11)
        b = par12 - ((m1 + m2) * par11)
        MsgBox("El valor de m es: " & m1 & "/" & m2 & " y el valor de b es: " & b, 64 + 48 + 256, "Asistente Matemático")

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim A, B, C As String
        Dim m, y As Double
        A = txtA.Text
        B = txtB.Text
        C = txtC.Text
        If A.Contains("/") Then
            A.Split("/")
            Dim numa As String = A(0)
            Dim dena As String = A(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            A = numa / dena
        Else
            A = CDbl(A)
        End If

        If B.Contains("/") Then
            B.Split("/")
            Dim numa As String = B(0)
            Dim dena As String = B(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            B = numa / dena
        Else
            B = CDbl(B)
        End If
        If C.Contains("/") Then
            C.Split("/")
            Dim numa As String = C(0)
            Dim dena As String = C(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            C = numa / dena
        Else
            C = CDbl(C)
        End If
        m = (-A / B)
        y = (-C / B)

        MsgBox("El valor de m es: " & -A & "/" & B & ", el valor de b es: " & -C & "/" & B & ". La intersección del eje X es: ((" & -A & "/" & B & ")/ (" & -C & "/" & B & "),0) y la intersección en eje Y es: (0, " & -C & "/" & B & ")", 64 + 48 + 256, "Asistente Matemático")
    End Sub

    Private Sub funciones_lineales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim valor As Integer

        valor = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Asistente Matemático")

        If valor = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf valor = 1 Then
            e.Cancel = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtcrit1.Clear()
        txtcrit2.Clear()
        txtpar11.Clear()
        txtpar12.Clear()
        txtpar21.Clear()
        txtpar22.Clear()
        txtvalx.Clear()
    End Sub
    Private Sub EcuacionesCuadráticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesCuadráticasToolStripMenuItem.Click
        Ecuaciones_cuadráticas.Show()
        Me.Hide()
    End Sub

    Private Sub CuerposPlanosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposPlanosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_planos.Show()
    End Sub

    Private Sub FunciónLinealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónLinealToolStripMenuItem.Click
        Funciones_cuadráticas.Show()
        Me.Hide()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub CuerposSólidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposSólidosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_sólidos.Show()
    End Sub
End Class