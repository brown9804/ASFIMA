Public Class Hidrostática
    Public pre, fue, are As String
    Private Sub Hidrostática_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = "m" & Chr(178)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = "N/" & "m" & Chr(178)
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtare.Clear()
        txtFue.Clear()
        txtpre.Clear()

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        pre = txtpre.Text
        are = txtare.Text
        fue = txtFue.Text
        If pre = "" Then
            pre = fue / are
            txtpre.Text = pre
        ElseIf fue = "" Then
            fue = pre * are
            txtFue.Text = fue
        ElseIf are = "" Then
            are = fue / pre
            txtare.Text = are


        End If
    End Sub
End Class