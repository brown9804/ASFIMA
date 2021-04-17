Public Class Ecuaciones_cuadráticas
    Public D, x1, x2, B2, H As Double, A, B, C, fraccion As String

    Private Sub lblcalcular_Click(sender As Object, e As EventArgs) Handles lblcalcular.Click
        A = txtA.Text
        B = txtB.Text
        C = txtC.Text

        If A.Contains("/") Then
            A.Split("/")
            Dim numeA As String = A(0)
            Dim denoA As String = A(2)
            numeA = CDbl(numeA)
            denoA = CDbl(denoA)
            A = numeA / denoA
        Else
            A = CDbl(A)
        End If

        If B.Contains("/") Then
            B.Split("/")
            Dim numeB As String = B(0)
            Dim denoB As String = B(2)
            numeB = CDbl(numeB)
            denoB = CDbl(denoB)
            B = numeB / denoB
        Else
            B = CDbl(B)
        End If

        If C.Contains("/") Then
            C.Split("/")
            Dim numeC As String = C(0)
            Dim denoC As String = C(2)
            numeC = CDbl(numeC)
            denoC = CDbl(denoC)
            C = numeC / denoC
        Else
            C = CDbl(C)
        End If
        B2 = B ^ 2
        D = B2 - 4 * A * C
        H = Math.Sqrt(D)

        Select Case D
            Case Is > 0
                x1 = (-B + H) / (2 * A)
                inco1 = x1
                x2 = (-B - H) / (2 * A)
                x2 = CStr(x2)
                x1 = CStr(x1)
                inco2 = x2
                Dim dec As String = x1
                Dim dec2 As String = x2
                If dec.Length > 999999999999999 Then
                    x1 = String.Format("{0}...", dec.Substring(0, 7))
                Else
                    x1 = dec
                End If
                If dec2.Length > 9999999999999999 Then
                    x2 = String.Format("{0}...", dec2.Substring(0, 7))
                Else
                    x2 = dec2
                End If
                If chbproce.Checked = True Then
                    Proceso_funciones_cuadráticas.lblproce.Text = "Ecuación a resolver:"
                    Proceso_funciones_cuadráticas.lblplant.Text = A & Chr(178) & " + " & B & "x + " & C
                    Proceso_funciones_cuadráticas.lbldiscsus.Text = "(" & B & ")" & Chr(178) & " - 4 * " & A & " * " & C
                    Proceso_funciones_cuadráticas.lbldiscrest.Text = B ^ 2 & " - " & 4 * A * C
                    Proceso_funciones_cuadráticas.lbldisc.Text = D
                    Proceso_funciones_cuadráticas.lblx1sust.Text = -B & " + √(" & D & ")"
                    Proceso_funciones_cuadráticas.lbl2a.Text = 2 & " * " & A
                    Proceso_funciones_cuadráticas.lblx1.Text = (-B + H) / (2 * A)
                    Proceso_funciones_cuadráticas.lblx2sust.Text = -B & " - √(" & D & ")"
                    Proceso_funciones_cuadráticas.lbl2ax2.Text = 2 & " * " & A
                    Proceso_funciones_cuadráticas.x2.Text = (-B - H) / (2 * A)
                    Proceso_funciones_cuadráticas.Width = (835)
                    Proceso_funciones_cuadráticas.Show()
                    If dec.Length > 7 Then
                        Proceso_funciones_cuadráticas.lblx1.Text = String.Format("{0}...", dec.Substring(0, 7))
                    Else
                        Proceso_funciones_cuadráticas.lblx1.Text = dec
                    End If
                    If dec2.Length > 7 Then
                        Proceso_funciones_cuadráticas.x2.Text = String.Format("{0}...", dec2.Substring(0, 7))
                    Else
                        Proceso_funciones_cuadráticas.x2.Text = dec2
                    End If
                End If
                MsgBox("El valor de x1 es: " & simplificar(fraccion) & " y el valor de x2 es de: " & x2, 64 + 48 + 256, "Asistente Matemático")
            Case Is < 0
                MsgBox("Esta ecuación no tiene soluciones reales", 5 + 48 + 256, "Asistente Matemático")
                If chbproce.Checked = True Then
                    Proceso_funciones_cuadráticas.Width = (325)
                    Proceso_funciones_cuadráticas.lblplant.Text = A & Chr(178) & "x + " & B & "x + " & C
                    Proceso_funciones_cuadráticas.lbldiscsus.Text = "(" & B & ")" & Chr(178) & " -4 * " & A & " * " & C
                    Proceso_funciones_cuadráticas.lbldiscrest.Text = B ^ 2 & " - " & 4 * A * C
                    Proceso_funciones_cuadráticas.lbldisc.Text = D
                    Proceso_funciones_cuadráticas.Show()
                End If
            Case Is = 0
                Dim dec As String = x1
                x1 = (-B + H) / (2 * A)
                inco1 = x1
                If dec.Length > 7 Then
                    x1 = String.Format("{0}...", dec.Substring(0, 7))
                Else
                    x1 = dec
                End If
                MsgBox("El valor de x es: " & simplificar(fraccion), 64 + 48 + 256, "Asistente Matemático")

        End Select
    End Sub

    Private Sub CuerposSólidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposSólidosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_sólidos.Show()
    End Sub

    Function cFraccion(inco1 As Double)
        Dim sRac As String
        Dim num As Long
        Dim den As Long
        Dim nDec As Double
        sRac = Str(inco1)
        nDec = 0
        If InStr(1, sRac, ".") <> 0 Then
            nDec = Len(Mid(sRac, InStr(1, sRac, ".") + 1))
        End If

        num = inco1 * potencia(10, nDec)
        den = potencia(10, nDec)
        cFraccion = num & "/" & den

    End Function
    Function simplificar(ByVal fraccion As String)
        Dim aux, a, b As Long
        Dim den, num As Long
        Dim mcd As Integer
        fraccion = cFraccion(x1)
        num = Val(Mid(fraccion, 1, InStr(1, fraccion, "/") - 1))
        den = Val(Mid(fraccion, InStr(1, fraccion, "/") + 1))
        a = num
        b = den
        If num = 0 Or den = 0 Then simplificar = "0" : Exit Function

        While (b <> 0)
            aux = a Mod b
            a = b
            b = aux
        End While
        mcd = a
        simplificar = num / mcd & "/" & den / mcd
    End Function
    Function potencia(ByVal n As Integer, ByVal num As Integer)
        potencia = n
        For i = 1 To num - 1
            potencia = potencia * n
        Next i
    End Function
    Private Sub Ecuaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim valor As Integer

        valor = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Asistente Matemático")

        If valor = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf valor = 1 Then
            e.Cancel = False
        End If
    End Sub

    Private Sub CuerposPlanosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposPlanosToolStripMenuItem.Click
        Me.Hide()
        Cuerpos_planos.Show()
    End Sub

    Private Sub FunciónCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónCuadráticaToolStripMenuItem.Click
        Me.Hide()
        Funciones_lineales.Show()
    End Sub

    Private Sub FunciónLinealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónLinealToolStripMenuItem.Click
        Funciones_cuadráticas.Show()
        Me.Hide()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub
End Class