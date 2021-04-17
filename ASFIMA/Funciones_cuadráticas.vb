Public Class Funciones_cuadráticas

    Private Sub btncalcfuncua_Click(sender As Object, e As EventArgs) Handles btncalcfuncua.Click
        Dim dis, x2, B2, x, c, raiz As String
        x = txtx.Text
        x2 = txtx2.Text
        c = txtc.Text
        If x2.Contains("/") Then
            x2.Split("/")
            Dim numa As String = x2(0)
            Dim dena As String = x2(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            x2 = numa / dena
        Else
            x2 = CDbl(x2)
        End If

        If x.Contains("/") Then
            x.Split("/")
            Dim numa As String = x(0)
            Dim dena As String = x(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            x = numa / dena
        Else
            x = CDbl(x)
        End If
        B2 = x ^ 2
        If c.Contains("/") Then
            c.Split("/")
            Dim numa As String = c(0)
            Dim dena As String = c(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            c = numa / dena
        Else
            c = CDbl(c)
        End If
        dis = B2 - 4 * x2 * c
        If dis = 0 Then
            raiz = 0
        ElseIf dis < 0
            raiz = Math.Sqrt(dis * -1)
        Else
            raiz = Math.Sqrt(dis)
        End If
        If dis.Contains("/") Then
            dis.Split("/")
            Dim numa As String = dis(0)
            Dim dena As String = dis(2)
            numa = CDbl(numa)
            dena = CDbl(dena)
            dis = numa / dena
        Else
            dis = CDbl(dis)
        End If
        Dim redu, redu2 As String
        Dim proc1, proc2 As Decimal
        proc1 = (-x + raiz)
        proc2 = (-x - raiz)
        redu = CStr(proc1)
        redu2 = CStr(proc2)
        If redu.Length > 5 Then
            redu = String.Format("{0}", redu.Substring(0, 5))
        Else
            redu = redu
        End If
        If redu2.Length > 5 Then
            redu2 = String.Format("{0}", redu2.Substring(0, 5))
        Else
            redu2 = redu2
        End If
        Select Case dis
            Case Is > 0
                lblejex.Text = "(" & redu & "/" & (2 * x2) & ",0) y (" & redu2 & "/" & (2 * x2) & ",0)"
                lblejey.Text = "(0," & c & ")"
                lblejesim.Text = -x & "/" & (2 * x2)
                lblvert.Text = "(" & -x & "/" & (2 * x2) & "," & -dis & "/" & (4 * x2) & ")"
                If chbproce.Checked = True Then
                    Proceso_funciones_cuadráticas.lblplant.Text = x2 & "x" & Chr(178) & " + " & x & "x + " & c
                    Proceso_funciones_cuadráticas.lbldiscsus.Text = "(" & x & ")" & Chr(178) & " -4 * " & x2 & " * " & c
                    Proceso_funciones_cuadráticas.lbldiscrest.Text = B2 & " - " & 4 * x2 * c
                    Proceso_funciones_cuadráticas.lbldisc.Text = dis
                    Proceso_funciones_cuadráticas.lblx1sust.Text = -x & " + √(" & dis & ")"
                    Proceso_funciones_cuadráticas.lbl2a.Text = 2 & " * " & x2
                    Proceso_funciones_cuadráticas.lblx1.Text = (-x + raiz) / (2 * x2)
                    Proceso_funciones_cuadráticas.lblx2sust.Text = -x & " - √(" & dis & ")"
                    Proceso_funciones_cuadráticas.lbl2ax2.Text = 2 & " * " & x2
                    Proceso_funciones_cuadráticas.x2.Text = (-x - raiz) / (2 * x2)
                    Proceso_funciones_cuadráticas.Width = (835)
                    Proceso_funciones_cuadráticas.Show()
                    Dim dec As String = Proceso_funciones_cuadráticas.lblx1.Text
                    Dim dec2 As String = Proceso_funciones_cuadráticas.x2.Text
                    If dec.Length > 5 Then
                        Proceso_funciones_cuadráticas.lblx1.Text = String.Format("{0}...", dec.Substring(0, 5))
                    Else
                        Proceso_funciones_cuadráticas.lblx1.Text = dec
                    End If
                    If dec2.Length > 5 Then
                        Proceso_funciones_cuadráticas.x2.Text = String.Format("{0}...", dec2.Substring(0, 5))
                    Else
                        Proceso_funciones_cuadráticas.x2.Text = dec2
                    End If
                End If
                If x2 > 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia arriba"
                    lblamb.Text = "[" & -x & "/" & (2 * x2) & ",+∞["
                    lblcrec.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                    lbldecre.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                ElseIf x2 < 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia abajo"
                    lblamb.Text = "[-∞," & -x & "/" & (2 * x2) & "["
                    lblcrec.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                    lbldecre.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                End If
            Case Is = 0
                If chbproce.Checked = True Then
                    Proceso_funciones_cuadráticas.lblplant.Text = x2 & "x" & Chr(178) & "+ " & x & "x + " & c
                    Proceso_funciones_cuadráticas.lbldiscsus.Text = "(" & x & ")" & Chr(178) & " -4 * " & x2 & " * " & c
                    Proceso_funciones_cuadráticas.lbldiscrest.Text = B2 & " - " & 4 * x2 * c
                    Proceso_funciones_cuadráticas.lbldisc.Text = dis
                    Proceso_funciones_cuadráticas.lblx1sust.Text = -x & " + √(" & dis & ")"
                    Proceso_funciones_cuadráticas.lbl2a.Text = 2 & " * " & x2
                    Proceso_funciones_cuadráticas.lblx1.Text = (-x + raiz) / (2 * x2)
                    Proceso_funciones_cuadráticas.lblx2sust.Text = -x & " - √(" & dis & ")"
                    Proceso_funciones_cuadráticas.lbl2ax2.Text = 2 & " * " & x2
                    Proceso_funciones_cuadráticas.x2.Text = (-x - raiz) / (2 * x2)
                    Proceso_funciones_cuadráticas.Width = (835)
                    Proceso_funciones_cuadráticas.Show()
                    Dim dec As String = Proceso_funciones_cuadráticas.lblx1.Text
                    Dim dec2 As String = Proceso_funciones_cuadráticas.x2.Text
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
                lblejex.Text = "(" & redu & "/" & (2 * x2) & ",0)"
                lblejey.Text = "(0," & c & ")"
                lblejesim.Text = -x & "/" & (2 * x2)
                lblvert.Text = "(" & -x & "/" & (2 * x2) & "," & -dis & "/" & (4 * x2) & ")"
                If x2 > 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia arriba"
                    lblamb.Text = "[" & -x & "/" & (2 * x2) & ",+∞["
                    lblcrec.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                    lbldecre.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                ElseIf x2 < 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia abajo"
                    lblamb.Text = "[-∞," & -x & "/" & (2 * x2) & "["
                    lblcrec.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                    lbldecre.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                End If
            Case Is < 0
                lblejex.Text = "La gráfica no interseca el eje x"
                lblejey.Text = "(0," & c & ")"
                lblejesim.Text = -x & "/" & (2 * x2)
                lblvert.Text = "(" & -x & "/" & (2 * x2) & "," & -dis & "/" & (4 * x2) & ")"
                If chbproce.Checked = True Then
                    Proceso_funciones_cuadráticas.Show()
                    Proceso_funciones_cuadráticas.Width = (325)
                    Proceso_funciones_cuadráticas.lblplant.Text = x2 & "x" & Chr(178) & " x + " & x & "x + " & c
                    Proceso_funciones_cuadráticas.lbldiscsus.Text = "(" & x & ")    -4 * " & x2 & " * " & c
                    Proceso_funciones_cuadráticas.lbldiscrest.Text = B2 & " - " & 4 * x2 * c
                    Proceso_funciones_cuadráticas.lbldisc.Text = dis
                End If
                If x2 > 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia arriba"
                    lblamb.Text = "[" & -x & "/" & (2 * x2) & ",+∞["
                    lblcrec.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                    lbldecre.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                ElseIf x2 < 0 Then
                    lbltiprec.Text = "La gráfica es cóncava hacia abajo"
                    lblamb.Text = "[-∞," & -x & "/" & (2 * x2) & "["
                    lblcrec.Text = "]-∞," & -x & "/" & (2 * x2) & "["
                    lbldecre.Text = "]" & -x & "/" & (2 * x2) & ",+∞["
                End If
        End Select
    End Sub
    Private Sub funciones_cuadráticas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub FunciónCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónCuadráticaToolStripMenuItem.Click
        Me.Hide()
        Funciones_lineales.Show()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtc.Clear()
        txtx.Clear()
        txtx2.Clear()
        lblamb.Text = "   "
        lblcrec.Text = "   "
        lbldecre.Text = "   "
        lblejesim.Text = "   "
        lblejex.Text = "   "
        lblejey.Text = "   "
        lbltiprec.Text = "   "
        lblvert.Text = "   "
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