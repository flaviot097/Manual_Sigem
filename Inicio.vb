Public Class Inicio
    Private Sub btnIniciarManual_Click(sender As Object, e As EventArgs) Handles btnIniciarManual.Click
        Dim manualMenus As New ManualMenu()
        manualMenus.Show()

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class