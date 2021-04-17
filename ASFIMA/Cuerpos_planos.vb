Public Class Cuerpos_planos

    Private Sub Btnresolver_Click(sender As Object, e As EventArgs) Handles Btnresolver.Click
        Dim area, PI As Double
        PI = 3.1416
        Select Case Cbfiguras.Text
            Case "Triángulo"
                Dim b As Double = InputBox("Digite la medida base del triangulo", "Asistente Matemático")
                Dim h As Double = InputBox("Digite la medida de la altura del triangulo", "Asistente Matemático")
                area = ((b * h) / 2)
                area = Format(area, "#.##")
                lblformula.Text = "Área del triangulo: ( b * h ) / 2"
                lblresolucion.Text = "Área del triangulo: ( " & b & " * " & h & " ) / 2"
                lblresultado.Text = "Área del triangulo: " & area
                MsgBox(" El area del triángulo es de :" & area, 64 + 48 + 256, "Asistente Matemático")
            Case "Círculo"
                Dim r As Double = InputBox("Digite la medida del radio del círculo", "Asistente Matemático")
                area = ((r ^ 2) * PI)
                area = Format(area, "#.##")
                lblformula.Text = "Área del circulo: ( r ^ 2 ) * PI"
                lblresolucion.Text = "Área del circulo: ( " & r & " ^ 2 ) * " & PI & ""
                lblresultado.Text = "Área del circulo: " & area
                MsgBox(" El area del círculo es de :" & area, 64 + 48 + 256, "Asistente Matemático")
            Case "Rombo"
                Dim d As Double = InputBox("Digite la medida de la diagonal mayor", "Asistente Matemático")
                Dim dm As Double = InputBox("Digite la medida de la diagonal menor", "Asistente Matemático")
                area = (d * dm) / 2
                area = Format(area, "#.##")
                lblformula.Text = "Área del rombo: ( D * d ) / 2"
                lblresolucion.Text = "Área del rombo: ( " & d & " * " & dm & ") / 2"
                lblresultado.Text = "Área del rombo: " & area
                MsgBox("El area del rombo es:" & area, 64 + 48 + 256, "Asistente Matemático")
            Case "Rectangulo"
                Dim b As Double = InputBox("Digite la medida de la base del rectangulo", "Asistente Matemático")
                Dim h As Double = InputBox("Digite la medida de la base del rectangulo", "Asistente Matemático")
                area = (b * h)
                area = Format(area, "#.##")
                lblformula.Text = "Área del rectangulo: ( b * h )"
                lblresolucion.Text = "Área del rectangulo: ( " & b & " * " & h & " )"
                lblresultado.Text = "Área del rectangulo: " & area
                MsgBox("El area del rectangulo es:" & area, 64 + 48 + 256, "Asistente Matemático")
            Case "Trapecio"
                Dim B As Double = InputBox("Digite la medida de la base mayor del trapecio", "Asistente Matemático")
                Dim bm As Double = InputBox("Digite la medida de la base menor del trapecio", "Asistente Matemático")
                Dim h As Double = InputBox("Digite la medida de la altura del trapecio", "Asistente Matemático")
                area = (((B + bm) * h) / 2)
                area = Format(area, "#.##")
                lblformula.Text = "Área del trapecio: ( B + b ) * h / 2"
                lblresolucion.Text = "Área del trapecio:  ( ( " & B & " + " & bm & " ) * " & h & " ) / 2"
                lblresultado.Text = "Área del trapecio: " & area
                MsgBox("El area del trapecio es:" & area, 64 + 46 + 256, "Asistente Matemático")
        End Select

    End Sub

    Private Sub Areas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim valor As Integer

        valor = MsgBox("Esta seguro que desea salir", MsgBoxStyle.OkCancel, "Asistente Matemático")

        If valor = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf valor = 1 Then
            e.Cancel = False
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        lblformula.Text = ""
        lblresultado.Text = ""
        lblresolucion.Text = ""
        Cbfiguras.Text = ""
    End Sub
    Private Sub EcuacionesCuadráticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesCuadráticasToolStripMenuItem.Click
        Me.Hide()
        Ecuaciones_cuadráticas.Show()
    End Sub

    Private Sub FunciónCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónCuadráticaToolStripMenuItem.Click
        Me.Hide()
        Funciones_lineales.Show()
    End Sub

    Private Sub FunciónLinealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunciónLinealToolStripMenuItem.Click
        Me.Hide()
        Funciones_cuadráticas.Show()
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