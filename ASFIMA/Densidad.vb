Public Class Densidad
    Public den, masa, vol As String
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtdensidad.Clear()
        txtmasa.Clear()
        txtvolumen.Clear()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Text = "m" & Chr(179)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = "kg/" & "m" & Chr(179)
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtmasa.Text = masa
        txtvolumen.Text = vol
        txtdensidad.Text = den
        If masa = "" Then
            masa = den * vol
            txtmasa.Text = masa
        ElseIf vol = "" Then
            vol = masa / den
            txtvolumen.Text = vol
        ElseIf den = "" Then
            den = masa / vol
            txtdensidad.Text = den
        End If

    End Sub
End Class