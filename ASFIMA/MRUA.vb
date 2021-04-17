Public Class MRUA
    Private Sub MRUA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = "m/s" & Chr(178)
    End Sub

    Private Sub btnmru_Click(sender As Object, e As EventArgs) Handles btnmru.Click
        Dim vi, vf, t, d, a As Double
        Dim acele, vefi, veini, tiemp, dist As String
        If rbformu1.Checked = True Then
            If (txtacele.Text = "" And txtvf.Text = "") Or (txtacele.Text = "" And txtvi.Text = "") Or (txtacele.Text = "" And txttiem.Text = "") Or (txtvf.Text = "" And txtvi.Text = "") Or (txtvf.Text = "" And txttiem.Text = "") Or (txttiem.Text = "" And txtvi.Text = "") Then
                MsgBox("Por favor digite los datos necesarios para continuar con la operación.", 64 + 48 + 256, "Asistente Físico")
            Else
                If txtacele.Text = "" Then
                    If txtvf.Text = txtvi.Text Then
                        If chbproce.Checked = True Then
                            Tres_variables_proceso.lblformutili.Text = "a = (vf - vi)"
                            Tres_variables_proceso.lbllidi0.Text = "_____"
                            Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                            Tres_variables_proceso.lbldiv0.Text = "t"
                            Tres_variables_proceso.lbldiv0.Location = New Point(66, 77)

                            Tres_variables_proceso.lblformdespe.Text = "a = " & vf & " - " & vi
                            Tres_variables_proceso.lbldivisora1.Text = "______"
                            Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                            Tres_variables_proceso.lbldivisorsutit.Text = t
                            Tres_variables_proceso.lbldivisorsutit.Location = New Point(66, 156)

                            Tres_variables_proceso.lblresusti.Text = "a = " & vf - vi
                            Tres_variables_proceso.lbllidi2.Text = "___"
                            Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                            Tres_variables_proceso.lbldiv2.Text = t
                            Tres_variables_proceso.lbldiv2.Location = New Point(46, 233)

                            Tres_variables_proceso.lblresultado.Text = "a = 0"
                            Tres_variables_proceso.Height = (344)
                            Tres_variables_proceso.Width = (261)
                            Tres_variables_proceso.Show()
                        End If
                        txtacele.Text = 0
                    Else
                        vi = txtvi.Text
                        vf = txtvf.Text
                        t = txttiem.Text
                        a = (vf - vi) / t
                        acele = a
                        If acele.Length > 5 Then
                            acele = String.Format("{0}", acele.Substring(0, 5))
                        Else
                            acele = acele
                        End If
                        If chbproce.Checked = True Then
                            Tres_variables_proceso.lblformutili.Text = "a = (vf - vi)"
                            Tres_variables_proceso.lbllidi0.Text = "_____"
                            Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                            Tres_variables_proceso.lbldiv0.Text = "t"
                            Tres_variables_proceso.lbldiv0.Location = New Point(66, 77)

                            Tres_variables_proceso.lblformdespe.Text = "a = " & vf & " - " & vi
                            Tres_variables_proceso.lbldivisora1.Text = "______"
                            Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                            Tres_variables_proceso.lbldivisorsutit.Text = t
                            Tres_variables_proceso.lbldivisorsutit.Location = New Point(66, 156)

                            Tres_variables_proceso.lblresusti.Text = "a = " & vf - vi
                            Tres_variables_proceso.lbllidi2.Text = "___"
                            Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                            Tres_variables_proceso.lbldiv2.Text = t
                            Tres_variables_proceso.lbldiv2.Location = New Point(46, 233)


                            Tres_variables_proceso.lblresultado.Text = "a = " & acele
                            Tres_variables_proceso.Height = (344)
                            Tres_variables_proceso.Width = (261)
                            Tres_variables_proceso.Show()
                        End If
                        txtacele.Text = acele
                    End If
                ElseIf txtvf.Text = "" Then
                    vi = txtvi.Text
                    a = txtacele.Text
                    t = txttiem.Text
                    vf = (a * t) + vi
                    vefi = vf
                    If vefi.Length > 5 Then
                        vefi = String.Format("{0}", vefi.Substring(0, 5))
                    Else
                        vefi = vefi
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "a = (vf - vi)"
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "t"
                        Tres_variables_proceso.lbldiv0.Location = New Point(66, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vf = a * t + vi "
                        Tres_variables_proceso.lbldivisora1.Text = ""
                        Tres_variables_proceso.lbldivisorsutit.Text = ""

                        Tres_variables_proceso.lblresusti.Text = "vf = " & a & " * " & t & " + " & vi
                        Tres_variables_proceso.lbllidi2.Text = ""
                        Tres_variables_proceso.lbldiv2.Text = ""

                        Tres_variables_proceso.lblresultado.Text = "vf = " & vefi
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvf.Text = vefi
                ElseIf txtvi.Text = "" Then
                    a = txtacele.Text
                    t = txttiem.Text
                    vf = txtvf.Text
                    vi = (a * t) - vf
                    veini = vi
                    If veini.Length > 5 Then
                        veini = String.Format("{0}", veini.Substring(0, 5))
                    Else
                        veini = veini
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "a = (vf - vi)"
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "t"
                        Tres_variables_proceso.lbldiv0.Location = New Point(66, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vi = a * t - vf "
                        Tres_variables_proceso.lbldivisora1.Text = ""
                        Tres_variables_proceso.lbldivisorsutit.Text = ""

                        Tres_variables_proceso.lblresusti.Text = "vi = " & a & " * " & t & " - " & vf
                        Tres_variables_proceso.lbllidi2.Text = ""
                        Tres_variables_proceso.lbldiv2.Text = ""

                        Tres_variables_proceso.lblresultado.Text = "vi = " & veini
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvi.Text = veini
                ElseIf txttiem.Text = "" Then
                    vi = txtvi.Text
                    vf = txtvf.Text
                    a = txtacele.Text
                    t = (vf - vi) / a
                    If t < 0 Then
                        t = t * -1
                    End If
                    tiemp = t
                    If tiemp.Length > 5 Then
                        tiemp = String.Format("{0}", tiemp.Substring(0, 5))
                    Else
                        tiemp = tiemp
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "a = (vf - vi)"
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "t"
                        Tres_variables_proceso.lbldiv0.Location = New Point(66, 77)

                        Tres_variables_proceso.lblformdespe.Text = "t = (vf - vi)"
                        Tres_variables_proceso.lbldivisora1.Text = "_____"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "a"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(66, 156)

                        Tres_variables_proceso.lblresusti.Text = "t = " & vf & " - " & vi
                        Tres_variables_proceso.lbllidi2.Text = "______"
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Text = a
                        Tres_variables_proceso.lbldiv2.Location = New Point(57, 233)

                        Tres_variables_proceso.lblresultado.Text = "t = " & tiemp
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txttiem.Text = tiemp
                End If
            End If
        ElseIf rbformu2.Checked = True Then
            If (txtacele.Text = "" And txtdist.Text = "") Or (txtacele.Text = "" And txtvi.Text = "") Or (txtacele.Text = "" And txttiem.Text = "") Or (txtdist.Text = "" And txtvi.Text = "") Or (txtdist.Text = "" And txttiem.Text = "") Or (txttiem.Text = "" And txtvi.Text = "") Then
                MsgBox("Por favor digite los datos necesarios para continuar con la operación.", 64 + 48 + 256, "Asistente Físico")
            Else
                If txtacele.Text = "" Then
                    vi = txtvi.Text
                    d = txtdist.Text
                    t = txttiem.Text
                    a = (2 * (d - vi * t)) / t ^ 2
                    acele = a
                    If acele.Length > 5 Then
                        acele = String.Format("{0}", acele.Substring(0, 5))
                    Else
                        acele = acele
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vi * t + a(t)" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "___"
                        Tres_variables_proceso.lbllidi0.Location = New Point(98, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(108, 77)

                        Tres_variables_proceso.lblformdespe.Text = "a = 2 * (d - vi * t)"
                        Tres_variables_proceso.lbllidi0.Text = "___________"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldiv0.Text = "t" & Chr(178)
                        Tres_variables_proceso.lbldiv0.Location = New Point(96, 156)

                        Tres_variables_proceso.lblresusti.Text = "a =  2 * (" & d & " - " & vi & " * " & t & ")"
                        Tres_variables_proceso.lbllidi2.Text = "_____________"
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Text = t & Chr(178)
                        Tres_variables_proceso.lbldiv2.Location = New Point(98, 233)

                        Tres_variables_proceso.lblresultado.Text = "a = " & acele
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtacele.Text = acele
                ElseIf txtdist.Text = "" Then
                    vi = txtvi.Text
                    a = txtacele.Text
                    t = txttiem.Text
                    d = vi * t + (1 / 2) * a * (t ^ 2)
                    dist = d
                    If dist.Length > 5 Then
                        dist = String.Format("{0}", dist.Substring(0, 5))
                    Else
                        dist = dist
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vi * t + a(t)" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "___"
                        Tres_variables_proceso.lbllidi0.Location = New Point(98, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(108, 77)

                        Tres_variables_proceso.lblformdespe.Text = "d = " & vi & " * " & t & " + " & a & " * " & t & Chr(178)
                        Tres_variables_proceso.lbldivisora1.Text = "______"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(98, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "2"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(118, 156)

                        Tres_variables_proceso.lblresusti.Text = "d = " & vi * t & " + " & (a * (t ^ 2)) / 2
                        Tres_variables_proceso.lbllidi2.Text = ""
                        Tres_variables_proceso.lbldiv2.Text = ""

                        Tres_variables_proceso.lblresultado.Text = "d = " & dist
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtdist.Text = dist
                ElseIf txtvi.Text = "0" And txttiem.Text = "" Then
                    a = txtacele.Text
                    d = txtdist.Text
                    t = 2 * d / a

                    If t < 0 Then
                        t = t * -1
                    End If
                    t = Math.Sqrt(t)
                    tiemp = t
                    If tiemp.Length > 5 Then
                        tiemp = String.Format("{0}", tiemp.Substring(0, 5))
                    Else
                        tiemp = tiemp
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vi * t + a(t)" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "___"
                        Tres_variables_proceso.lbllidi0.Location = New Point(98, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(108, 77)

                        Tres_variables_proceso.lblformdespe.Text = "t = -vi + √(vi + 2 * a * d)"
                        Tres_variables_proceso.lbldivisora1.Text = "________________"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "a"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(130, 156)

                        Tres_variables_proceso.lblresusti.Text = "t = -" & vi & " + √(" & vi & " + 2 * " & a & " * " & d & ")"
                        Tres_variables_proceso.lbllidi2.Text = "_________________"
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Text = a
                        Tres_variables_proceso.lbldiv2.Location = New Point(108, 233)

                        Tres_variables_proceso.lblresultado.Text = "t = " & tiemp
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (299)
                        Tres_variables_proceso.Show()
                    End If
                    txttiem.Text = tiemp
                ElseIf txtvi.Text <> "0" And txttiem.Text = "" Then
                    vi = txtvi.Text
                    a = txtacele.Text
                    d = txtdist.Text
                    t = (vi ^ 2) + 2 * a * d
                    If t < 0 Then
                        t = t * -1
                    End If
                    t = (-vi + Math.Sqrt(t)) / a
                    tiemp = t
                    If tiemp.Length > 5 Then
                        tiemp = String.Format("{0}", tiemp.Substring(0, 5))
                    Else
                        tiemp = tiemp
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vi * t + a(t)" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "___"
                        Tres_variables_proceso.lbllidi0.Location = New Point(98, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(108, 77)

                        Tres_variables_proceso.lblformdespe.Text = "t = -vi + √(vi + 2 * a * d)"
                        Tres_variables_proceso.lbldivisora1.Text = "________________"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(52, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "a"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(121, 156)


                        Tres_variables_proceso.lblresusti.Text = "t = -" & vi & " + √(" & vi & " + 2 * " & a & " * " & d & ")"
                        Tres_variables_proceso.lbllidi2.Text = "_____________________"
                        Tres_variables_proceso.lbldiv2.Text = a
                        Tres_variables_proceso.lblresultado.Text = "t = " & tiemp
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (299)
                        Tres_variables_proceso.Show()
                    End If
                    txttiem.Text = t
                ElseIf txtvi.Text = "" Then
                    a = txtacele.Text
                    d = txtdist.Text
                    t = txttiem.Text
                    vi = (d - ((a * (t ^ 2)) / 2)) / t
                    veini = vi
                    If veini.Length > 5 Then
                        veini = String.Format("{0}", veini.Substring(0, 5))
                    Else
                        veini = veini
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vi * t + a(t)" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "___"
                        Tres_variables_proceso.lbllidi0.Location = New Point(98, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(108, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vi = d - (a * t" & Chr(178) & ") / 2 "
                        Tres_variables_proceso.lbldivisora1.Text = "_____________"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(59, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "t"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(121, 156)

                        Tres_variables_proceso.lblresusti.Text = "vi = " & d & " - (" & a & " * " & t & Chr(178) & ") / 2 "
                        Tres_variables_proceso.lbllidi2.Location = New Point(59, 210)
                        Tres_variables_proceso.lbllidi2.Text = "________________"
                        Tres_variables_proceso.lbldiv2.Text = t
                        Tres_variables_proceso.lbldiv2.Location = New Point(144, 234)

                        Tres_variables_proceso.lblresultado.Text = "vi = " & veini
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvi.Text = vi
                End If
            End If
        ElseIf rbformu3.Checked = True Then
            If (txtacele.Text = "" And txtdist.Text = "") Or (txtacele.Text = "" And txtvi.Text = "") Or (txtacele.Text = "" And txtvf.Text = "") Or (txtdist.Text = "" And txtvi.Text = "") Or (txtdist.Text = "" And txtvf.Text = "") Or (txtvf.Text = "" And txtvi.Text = "") Then
                MsgBox("Por favor digite los datos necesarios para continuar con la operación.", 64 + 48 + 256, "Asistente Físico")
            Else
                If txtacele.Text = "" Then
                    vi = txtvi.Text
                    d = txtdist.Text
                    vf = txtvf.Text
                    a = ((vf ^ 2) - (vi ^ 2)) / (2 * d)
                    acele = a
                    If acele.Length > 5 Then
                        acele = String.Format("{0}", acele.Substring(0, 5))
                    Else
                        acele = acele
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vf" & Chr(178) & " - vi" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbldiv0.Text = "2 * a"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Location = New Point(52, 77)

                        Tres_variables_proceso.lblformdespe.Text = "a = " & vf & Chr(178) & " - " & vi & Chr(178)
                        Tres_variables_proceso.lbldivisora1.Text = "______"
                        Tres_variables_proceso.lbldivisorsutit.Text = "2 * " & d
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(49, 156)
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)

                        Tres_variables_proceso.lblresusti.Text = "a =  " & (vf ^ 2) - (vi ^ 2)
                        Tres_variables_proceso.lbllidi2.Text = "____"
                        Tres_variables_proceso.lbldiv2.Text = 2 * d
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Location = New Point(49, 233)

                        Tres_variables_proceso.lblresultado.Text = "a = " & acele
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtacele.Text = a
                ElseIf txtdist.Text = "" Then
                    vf = txtvf.Text
                    vi = txtvi.Text
                    a = txtacele.Text
                    d = ((vf ^ 2) - (vi ^ 2)) / (2 * a)
                    dist = d
                    If dist.Length > 5 Then
                        dist = String.Format("{0}", dist.Substring(0, 5))
                    Else
                        dist = dist
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vf" & Chr(178) & " - vi" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbldiv0.Text = "2 * a"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Location = New Point(52, 77)

                        Tres_variables_proceso.lblformdespe.Text = "d = " & vf & Chr(178) & " - " & vi & Chr(178)
                        Tres_variables_proceso.lbldivisora1.Text = "_______"
                        Tres_variables_proceso.lbldivisorsutit.Text = "2 * " & a
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(49, 156)
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)

                        Tres_variables_proceso.lblresusti.Text = "d = " & (vf ^ 2) - (vi ^ 2)
                        Tres_variables_proceso.lbllidi2.Text = "____"
                        Tres_variables_proceso.lbldiv2.Text = 2 * a
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Location = New Point(49, 233)

                        Tres_variables_proceso.lblresultado.Text = "d = " & dist
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtdist.Text = dist
                ElseIf txtvf.Text = "" Then
                    vi = txtvi.Text
                    a = txtacele.Text
                    d = txtdist.Text
                    vf = (2 * a * d) + vi ^ 2
                    If vf < 0 Then
                        vf = vf * -1
                    End If
                    vf = Math.Sqrt(vf)
                    vefi = vf
                    If vefi.Length > 5 Then
                        vefi = String.Format("{0}", vefi.Substring(0, 5))
                    Else
                        vefi = vefi
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vf" & Chr(178) & " - vi" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbldiv0.Text = "2 * a"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Location = New Point(52, 77)


                        Tres_variables_proceso.lblformdespe.Text = "vf = √(2 * a * d + vi" & Chr(178) & ")"
                        Tres_variables_proceso.lbldivisora1.Text = ""
                        Tres_variables_proceso.lbldivisorsutit.Text = ""

                        Tres_variables_proceso.lblresusti.Text = "vf = √(2 * " & a & " * " & d & " + " & vi & Chr(178) & ")"
                        Tres_variables_proceso.lbllidi2.Text = ""
                        Tres_variables_proceso.lbldiv2.Text = ""

                        Tres_variables_proceso.lblresultado.Text = "vf = " & vefi
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvf.Text = vefi
                ElseIf txtvi.Text = "" Then
                    vf = txtvf.Text
                    a = txtacele.Text
                    d = txtdist.Text
                    vi = (2 * a * d) - vf ^ 2
                    If vi < 0 Then
                        vi = vi * -1
                    End If
                    vi = Math.Sqrt(vi)
                    veini = vi
                    If veini.Length > 5 Then
                        veini = String.Format("{0}", veini.Substring(0, 5))
                    Else
                        veini = veini
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = vf" & Chr(178) & " - vi" & Chr(178)
                        Tres_variables_proceso.lbllidi0.Text = "_____"
                        Tres_variables_proceso.lbldiv0.Text = "2 * a"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Location = New Point(52, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vi = √(2 * a * d - vf" & Chr(178) & ")"
                        Tres_variables_proceso.lbldivisora1.Text = ""
                        Tres_variables_proceso.lbldivisorsutit.Text = ""


                        Tres_variables_proceso.lblresusti.Text = "vi = √(2 * " & a & " * " & d & " - " & vf & Chr(178) & ")"
                        Tres_variables_proceso.lbllidi2.Text = ""
                        Tres_variables_proceso.lbldiv2.Text = ""

                        Tres_variables_proceso.lblresultado.Text = "vi = " & veini
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvi.Text = veini
                End If
            End If
        ElseIf rbformu4.Checked = True Then
            If (txttiem.Text = "" And txtdist.Text = "") Or (txttiem.Text = "" And txtvi.Text = "") Or (txttiem.Text = "" And txtvf.Text = "") Or (txtdist.Text = "" And txtvi.Text = "") Or (txtdist.Text = "" And txtvf.Text = "") Or (txtvf.Text = "" And txtvi.Text = "") Then
                MsgBox("Por favor digite los datos necesarios para continuar con la operación.", 64 + 48 + 256, "Asistente Físico")
            Else
                If txtdist.Text = "" Then
                    vf = txtvf.Text
                    vi = txtvi.Text
                    t = txttiem.Text
                    d = ((vi + vf) * t) / 2
                    dist = d
                    If dist.Length > 5 Then
                        dist = String.Format("{0}", dist.Substring(0, 5))
                    Else
                        dist = dist
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = (vi + vf) * t "
                        Tres_variables_proceso.lbllidi0.Text = "_________"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(76, 77)


                        Tres_variables_proceso.lblformdespe.Text = "d = (" & vi & " + " & vf & ") * " & t
                        Tres_variables_proceso.lbldivisora1.Text = "____________"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "2"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(76, 156)

                        Tres_variables_proceso.lblresusti.Text = "d = " & (vi + vf) * t
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbllidi2.Text = "____"
                        Tres_variables_proceso.lbldiv2.Text = "2"
                        Tres_variables_proceso.lbldiv2.Location = New Point(54, 233)

                        Tres_variables_proceso.lblresultado.Text = "d = " & dist
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtdist.Text = dist
                ElseIf txtvf.Text = "" Then
                    vi = txtvi.Text
                    t = txttiem.Text
                    d = txtdist.Text
                    vf = ((2 * d) / t) - vi
                    vefi = vf
                    If vefi.Length > 5 Then
                        vefi = String.Format("{0}", vefi.Substring(0, 5))
                    Else
                        vefi = vefi
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = (vi + vf) * t "
                        Tres_variables_proceso.lbllidi0.Text = "_________"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(76, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vf = 2 * d - vi"
                        Tres_variables_proceso.lbldivisora1.Text = "____"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = "t"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(57, 156)

                        Tres_variables_proceso.lblresusti.Text = "vf = 2 * " & d & " - " & vi
                        Tres_variables_proceso.lbllidi2.Text = "_____"
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Text = t
                        Tres_variables_proceso.lbldiv2.Location = New Point(57, 233)

                        Tres_variables_proceso.lblresultado.Text = "vf = " & vefi
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvf.Text = vefi
                ElseIf txtvi.Text = "" Then
                    t = txttiem.Text
                    d = txtdist.Text
                    vf = txtvf.Text
                    vi = ((2 * d) / t) - vf
                    veini = vi
                    If veini.Length > 5 Then
                        veini = String.Format("{0}", veini.Substring(0, 5))
                    Else
                        veini = veini
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = (vi + vf) * t "
                        Tres_variables_proceso.lbllidi0.Text = "_________"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(76, 77)

                        Tres_variables_proceso.lblformdespe.Text = "vi = 2 * d - vf"
                        Tres_variables_proceso.lbldivisora1.Text = "_____"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(46, 132)
                        Tres_variables_proceso.lbldivisorsutit.Text = t
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(57, 156)

                        Tres_variables_proceso.lblresusti.Text = "vi = 2 * " & d & " - " & vf
                        Tres_variables_proceso.lbllidi2.Text = "_____"
                        Tres_variables_proceso.lbllidi2.Location = New Point(46, 209)
                        Tres_variables_proceso.lbldiv2.Text = t
                        Tres_variables_proceso.lbldiv2.Location = New Point(57, 233)

                        Tres_variables_proceso.lblresultado.Text = "vi = " & veini
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txtvi.Text = veini
                ElseIf txttiem.Text = "" Then
                    d = txtdist.Text
                    vf = txtvf.Text
                    vi = txtvi.Text
                    t = (2 * d) / (vi + vf)
                    tiemp = t
                    If tiemp.Length > 5 Then
                        tiemp = String.Format("{0}", tiemp.Substring(0, 5))
                    Else
                        tiemp = tiemp
                    End If
                    If chbproce.Checked = True Then
                        Tres_variables_proceso.lblformutili.Text = "d = (vi + vf) * t "
                        Tres_variables_proceso.lbllidi0.Text = "_________"
                        Tres_variables_proceso.lbllidi0.Location = New Point(46, 53)
                        Tres_variables_proceso.lbldiv0.Text = "2"
                        Tres_variables_proceso.lbldiv0.Location = New Point(76, 77)

                        Tres_variables_proceso.lblformdespe.Text = "t = 2 * d "
                        Tres_variables_proceso.lbldivisora1.Text = "_____"
                        Tres_variables_proceso.lbldivisora1.Location = New Point(36, 133)
                        Tres_variables_proceso.lbldivisorsutit.Text = "vi + vf"
                        Tres_variables_proceso.lbldivisorsutit.Location = New Point(39, 157)

                        Tres_variables_proceso.lblresusti.Text = "t = 2 * " & d
                        Tres_variables_proceso.lbllidi2.Text = "_______"
                        Tres_variables_proceso.lbllidi2.Location = New Point(36, 209)
                        Tres_variables_proceso.lbldiv2.Text = vi & " + " & vf
                        Tres_variables_proceso.lbldiv2.Location = New Point(39, 233)

                        Tres_variables_proceso.lblresultado.Text = "t = " & tiemp
                        Tres_variables_proceso.Height = (344)
                        Tres_variables_proceso.Width = (261)
                        Tres_variables_proceso.Show()
                    End If
                    txttiem.Text = tiemp
                End If
            End If
        Else
            MsgBox("Por favor seleccione la formula que desea utilizar para continuar el proceso.", 64 + 48 + 256, "Asistente Físico")
        End If


    End Sub
    Private Sub MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Ya se encuentra en el formulario seleccionado.", 64 + 48 + 256, "Asistente Físico")
    End Sub

    Private Sub MovimientoRectilíneoUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MRU.Show()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtacele.Text = ""
        txtdist.Text = ""
        txttiem.Text = ""
        txtvf.Text = ""
        txtvi.Text = ""
        rbformu1.Checked = False
        rbformu2.Checked = False
        rbformu3.Checked = False
        rbformu4.Checked = False
        txtacele.Enabled = True
        txtvf.Enabled = True
        txtvi.Enabled = True
        txttiem.Enabled = True
        txtdist.Enabled = True
    End Sub

    Private Sub rbformu1_CheckedChanged(sender As Object, e As EventArgs) Handles rbformu1.CheckedChanged
        txtacele.Enabled = True
        txtvf.Enabled = True
        txtvi.Enabled = True
        txttiem.Enabled = True
        txtdist.Enabled = False
        txtacele.Text = ""
        txtdist.Text = ""
        txttiem.Text = ""
        txtvf.Text = ""
        txtvi.Text = ""
    End Sub

    Private Sub rbformu2_CheckedChanged(sender As Object, e As EventArgs) Handles rbformu2.CheckedChanged
        txtacele.Enabled = True
        txtvf.Enabled = False
        txtvi.Enabled = True
        txttiem.Enabled = True
        txtdist.Enabled = True
        txtacele.Text = ""
        txtdist.Text = ""
        txttiem.Text = ""
        txtvf.Text = ""
        txtvi.Text = ""
    End Sub

    Private Sub rbformu3_CheckedChanged(sender As Object, e As EventArgs) Handles rbformu3.CheckedChanged
        txtacele.Enabled = True
        txtvf.Enabled = True
        txtvi.Enabled = True
        txttiem.Enabled = False
        txtdist.Enabled = True
        txtacele.Text = ""
        txtdist.Text = ""
        txttiem.Text = ""
        txtvf.Text = ""
        txtvi.Text = ""
    End Sub

    Private Sub rbformu4_CheckedChanged(sender As Object, e As EventArgs) Handles rbformu4.CheckedChanged
        txtacele.Enabled = False
        txtvf.Enabled = True
        txtvi.Enabled = True
        txttiem.Enabled = True
        txtdist.Enabled = True
        txtacele.Text = ""
        txtdist.Text = ""
        txttiem.Text = ""
        txtvf.Text = ""
        txtvi.Text = ""
    End Sub

    Private Sub MovimientoCircularUniformaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoCircularUniformaToolStripMenuItem.Click
        Me.Hide()
        MCU.Show()
    End Sub

    Private Sub MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformementeAceleradoToolStripMenuItem.Click
        MsgBox("Ya se encuentra en el formulario selccionado.", 64 + 48 + 256, "Asistente Físico")
    End Sub

    Private Sub MovimientoRectilíneoUniformeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MovimientoRectilíneoUniformeToolStripMenuItem.Click
        Me.Hide()
        MRU.Show()
    End Sub

    Private Sub ConversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionesToolStripMenuItem.Click
        Conversiones.Show()
    End Sub

    Private Sub LeyDeCoulombToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeCoulombToolStripMenuItem.Click
        Me.Hide()
        Ley_Coulomb.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub LeyDeOhmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeyDeOhmToolStripMenuItem.Click
        Me.Hide()
        Ley_de_ohm.Show()

    End Sub
End Class