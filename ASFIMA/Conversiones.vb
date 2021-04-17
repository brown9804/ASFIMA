Public Class Conversiones
    Public u1, cadena, m, m1, unidad As String
    Public u2, cadena2, n, n1, unidad2 As String
    Public valor As Double
    Public v As String
    Public p As Double

    Private Sub btnconversion_Click(sender As Object, e As EventArgs) Handles btnconversion.Click

        p = 10
        u1 = txtunidad1.Text
        u2 = txtunidad2.Text
        v = txtvalor.Text
        Dim r As String
        Dim potencia As Double
        Dim cadenas As String()


        If v.Contains("^") Then
            cadenas = v.Split("^")
            potencia = cadenas(1)
            If v.Contains("*") Then
                cadenas = v.Split("*")
            Else
                cadenas = v.Split("x")
            End If
            v = cadenas(0)
            r = v * (10 ^ potencia)
            v = CDec(r)
        End If
        If u1.Contains("/") Then

        Else
            If u1.Contains("k") Then
                cadena = u1
                m = 3
                unidad = cadena(1)
                m1 = "k"
            ElseIf u1.Contains("E") Then
                cadena = u1
                m = 8
                unidad = cadena(1)
                m1 = "E"
            ElseIf u1.Contains("P") Then
                cadena = u1
                m = 7
                unidad = cadena(1)
                m1 = "P"
            ElseIf u1.Contains("T") Then
                cadena = u1
                m = 6
                unidad = cadena(1)
                m1 = "h"
            ElseIf u1.Contains("G") Then
                cadena = u1
                m = 5
                unidad = cadena(1)
                m1 = "G"
            ElseIf u1.Contains("M") Then
                cadena = u1
                m = 4
                unidad = cadena(1)
                m1 = "M"
            ElseIf u1.Contains("h") Then
                If u1.Length >= 2 Then
                    cadena = u1
                    m = 2
                    unidad = cadena(1)
                    m1 = "h"
                Else
                    cadena = u1
                    unidad = "h"
                    m1 = "h"
                    m = 12
                End If
            ElseIf u1(0) = "d" Then
                If u1.Contains("da") Then
                    cadena = u1
                    m = 1
                    unidad = cadena(2)
                    m1 = "da"
                Else
                    cadena = u1
                    m = -1
                    unidad = cadena(1)
                    m1 = "d"
                End If
            ElseIf u1(0) = "c" Then
                cadena = u1
                m = -2
                unidad = cadena(1)
                m1 = "c"
            ElseIf u1(0) = "m" Then
                If u1.Length >= 2 Then
                    If u1.Contains("min") Then
                        cadena = u1
                        m1 = "min"
                        unidad = "min"
                        m = 11
                    Else
                        cadena = u1
                        m = -3
                        unidad = cadena(1)
                        m1 = "m"
                    End If
                Else
                    cadena = u1
                    m = 0
                    unidad = "m"
                End If
            ElseIf u1(0) = "u" Then
                cadena = u1
                m = -4
                unidad = cadena(1)
                m1 = "u"
            ElseIf u1(0) = "n" Then
                cadena = u1
                m = -5
                unidad = cadena(1)
                m1 = "n"
            ElseIf u1(0) = "p" Then
                cadena = u1
                m = -6
                unidad = cadena(1)
                m1 = "p"
            ElseIf u1(0) = "f" Then
                cadena = u1
                m = -7
                unidad = cadena(1)
                m1 = "f"
            ElseIf u1(0) = "a" Then
                cadena = u1
                m = -8
                unidad = cadena(1)
                m1 = "a"
            ElseIf u1.Contains("s") Then
                cadena = u1
                m1 = "s"
                unidad = "s"
                m = 10
            Else
                m = 0
                unidad = u1
            End If
        End If


        If u2.Contains("k") Then
            cadena2 = u2
            n = 3
            unidad2 = cadena2(1)
            n1 = "k"
        ElseIf u2.Contains("h") Then
            If u2.Length >= 2 Then
                cadena2 = u2
                n = 2
                unidad2 = cadena2(1)
                n1 = "h"
            Else
                cadena2 = u2
                unidad2 = "h"
                n1 = "h"
                n = 12
            End If
        ElseIf u2(0) = "d" Then
            If u2.Contains("da") Then
                cadena2 = u2
                n = 1
                unidad2 = cadena2(2)
                n1 = "da"
            Else
                cadena2 = u2
                n = -1
                unidad2 = cadena2(1)
                n1 = "d"
            End If
        ElseIf u2(0) = "c" Then
            cadena2 = u2
            n = -2
            unidad2 = cadena2(1)
            n1 = "c"
        ElseIf u2(0) = "m" Then
            If u2.Length >= 2 Then
                If u2.Contains("min") Then
                    cadena2 = u2
                    n1 = "min"
                    unidad2 = "min"
                    n = 11
                Else
                    cadena2 = u2
                    n = -3
                    unidad2 = cadena2(1)
                    n1 = "m"
                End If
            Else
                cadena2 = u2
                n = 0
                unidad2 = "m"
            End If
        ElseIf u2.Contains("E") Then
            cadena2 = u2
            n = 8
            unidad2 = cadena2(1)
            n1 = "E"
        ElseIf u2.Contains("P") Then
            cadena2 = u2
            n = 7
            unidad2 = cadena2(1)
            n1 = "P"
        ElseIf u2.Contains("T") Then
            cadena2 = u2
            n = 6
            unidad2 = cadena2(1)
            n1 = "h"
        ElseIf u2.Contains("G") Then
            cadena2 = u2
            n = 5
            unidad2 = cadena2(1)
            n1 = "G"
        ElseIf u2.Contains("M") Then
            cadena2 = u2
            n = 4
            unidad2 = cadena2(1)
            n1 = "M"
        ElseIf u2(0) = "u" Then
            cadena2 = u2
            n = -4
            unidad2 = cadena2(1)
            n1 = "u"
        ElseIf u2(0) = "n" Then
            cadena2 = u2
            n = -5
            unidad2 = cadena2(1)
            n1 = "n"
        ElseIf u2(0) = "p" Then
            cadena = u2
            n = -6
            unidad2 = cadena2(1)
            n1 = "p"
        ElseIf u2(0) = "f" Then
            cadena2 = u2
            n = -7
            unidad2 = cadena2(1)
            n1 = "f"
        ElseIf u2(0) = "a" Then
            cadena2 = u2
            n = -8
            unidad2 = cadena2(1)
            n1 = "a"
        ElseIf u2.Contains("s") Then
            cadena2 = u2
            n1 = "s"
            unidad2 = "s"
            n = 10
        Else
            n = 0
            unidad2 = u2
        End If

        If unidad = unidad2 Then


            If m = 0 Then
                If n = 0 Then
                    valor = v
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = 1 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 1)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 19)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = 2 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 2)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 20)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If

            ElseIf m = 3 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 3)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If



            ElseIf m = 4 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 6)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2

                End If



            ElseIf m = 5 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 9)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                    valor = v * Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If



            ElseIf m = 6 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 12)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = 7 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 15)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 33)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If



            ElseIf m = 8 Then
                If n = 0 Then
                    valor = v * Math.Pow(p, 18)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v * Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v * Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v * Math.Pow(p, 19)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 20)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 33)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 36)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If

            ElseIf m = -1 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 1)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 19)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If



            ElseIf m = -2 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 2)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 20)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v * Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If





            ElseIf m = -3 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 3)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 2)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 1)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If



            ElseIf m = -4 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 6)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 5)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 4)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                    valor = v * Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If

            ElseIf m = -5 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 9)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 8)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 7)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = -6 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 12)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 11)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 10)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = -7 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 15)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 18)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 33)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 14)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 13)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v * Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If


            ElseIf m = -8 Then
                If n = 0 Then
                    valor = v / Math.Pow(p, 18)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 1 Then
                    valor = v / Math.Pow(p, 19)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 2 Then
                    valor = v / Math.Pow(p, 20)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 3 Then
                    valor = v / Math.Pow(p, 21)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 4 Then
                    valor = v / Math.Pow(p, 24)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 5 Then
                    valor = v / Math.Pow(p, 27)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 6 Then
                    valor = v / Math.Pow(p, 30)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 7 Then
                    valor = v / Math.Pow(p, 33)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = 8 Then
                    valor = v / Math.Pow(p, 36)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -1 Then
                    valor = v / Math.Pow(p, 17)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -2 Then
                    valor = v / Math.Pow(p, 16)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -3 Then
                    valor = v / Math.Pow(p, 15)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -4 Then
                    valor = v / Math.Pow(p, 12)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -5 Then
                    valor = v / Math.Pow(p, 9)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -6 Then
                    valor = v / Math.Pow(p, 6)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -7 Then
                    valor = v / Math.Pow(p, 3)
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                ElseIf n = -8 Then
                    valor = v
                    valor = CDec(valor)
                    lblresultado.Text = valor
                    lblunidad.Text = u2
                End If
            ElseIf m = 10 Then
                valor = v
                lblresultado.Text = valor
                lblunidad.Text = u1
            ElseIf m = 11 Then
                valor = v
                lblresultado.Text = valor
                lblunidad.Text = u1
            ElseIf m = 12 Then
                valor = v
                lblresultado.Text = valor
                lblunidad.Text = u1
            End If
        ElseIf unidad = "s" Then
            If n = 11 Then
                valor = v / 60
                lblresultado.Text = valor
                lblunidad.Text = u2
            ElseIf n = 12 Then
                valor = v / 3600
                lblresultado.Text = valor
                lblunidad.Text = u2
            End If
        ElseIf unidad = "min" Then
            If n = 10 Then
                valor = v * 60
                lblresultado.Text = valor
                lblunidad.Text = u2
            ElseIf n = 12 Then
                valor = v / 60
                lblresultado.Text = valor
                lblunidad.Text = u2
            End If
        ElseIf unidad = "h" Then
            If n = 10 Then
                valor = v * 3600
                lblresultado.Text = valor
                lblunidad.Text = u2
            ElseIf n = 11 Then
                valor = v * 60
                lblresultado.Text = valor
                lblunidad.Text = u2
            End If
        Else
            MsgBox("Las unidades son diferentes, digite las mismas unidades")
            txtvalor.Clear()
            txtunidad1.Clear()
            txtunidad2.Clear()
            txtvalor.Focus()
        End If
    End Sub

    Private Sub btnx10_Click(sender As Object, e As EventArgs) Handles btnx10.Click
        Dim x, c As String
        x = "*10^"
        c = txtvalor.Text
        If c.Contains("*10^") Then
            txtvalor.Text = txtvalor.Text
        Else
            txtvalor.Text = txtvalor.Text & x
        End If
    End Sub

    Private Sub btndecimal_Click(sender As Object, e As EventArgs) Handles btndecimal.Click
        Dim x, r As String
        Dim potencia As Double
        Dim cadenas As String()

        x = lblresultado.Text
        If x.Contains("^") Then
            cadenas = x.Split("^")
            potencia = cadenas(1)
            If x.Contains("*") Then
                cadenas = x.Split("*")
            Else
                cadenas = x.Split("x")
            End If
            x = cadenas(0)
            r = x * (10 ^ potencia)
            lblresultado.Text = CDec(r)
        End If

    End Sub

    Private Sub btncientifico_Click(sender As Object, e As EventArgs) Handles btncientifico.Click
        Dim i, x, n1, n2, n3, n4, n5 As String
        x = lblresultado.Text
        i = 0
        If x < 1 Then
            x = CDec(x)
            Do Until x >= 1
                x = x * 10
                i = i + 1

            Loop

            x = CDec(x)
            If x.Length > 4 Then
                n1 = x(0)
                n2 = x(1)
                n3 = x(2)
                n4 = x(3)
                n5 = x(4)
                If n5 >= 5 Then
                    n4 = n4 + 1
                End If
                If n4 >= 5 Then

                    If n4 = 10 Then
                        n4 = 0
                    End If
                    n3 = n3 + 1
                End If
                If n3 = 10 Then
                    n1 = n1 + 1
                    If n1 = 10 Then
                        n1 = 1
                        i = i - 1
                    End If

                End If
                lblresultado.Text = n1 & n2 & n3 & n4 & " *10^-" & i
            Else
                lblresultado.Text = x & " *10^-" & i
            End If




        ElseIf x > 10 Then
            Do Until x < 10
                x = x / 10
                i = i + 1
            Loop
            x = CDec(x)
            If x.Length > 4 Then
                n1 = x(0)
                n2 = x(1)
                n3 = x(2)
                n4 = x(3)
                n5 = x(4)
                If n5 >= 5 Then
                    n4 = n4 + 1
                End If
                If n4 >= 5 Then

                    If n4 = 10 Then
                        n4 = 0
                    End If
                    n3 = n3 + 1
                End If
                If n3 = 10 Then
                    n1 = n1 + 1
                    If n1 = 10 Then
                        n1 = 1
                        i = i + 1
                    End If

                End If
                lblresultado.Text = n1 & n2 & n3 & n4 & " *10^" & i
            Else
                lblresultado.Text = x & " *10^" & i
            End If


        End If
    End Sub
End Class