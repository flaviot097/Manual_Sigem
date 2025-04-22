Imports iTextSharp.text.pdf
Imports System.Drawing


Public Class ManualMenu

    Private Sub ManualMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim buscarModelo As modeloPdf = New modeloPdf()
        buscarModelo.pasarTexto(txtConsulta.Text)
        Me.Hide()
        buscarModelo.Show()

    End Sub

    Private Sub btnManualCompleto_Click(sender As Object, e As EventArgs) Handles btnManualCompleto.Click
        Dim manualCompleto = New VisorManualCompleto()
        Me.Hide()
        manualCompleto.Show()
    End Sub

    Private Sub irAsecciones_Click(sender As Object, e As EventArgs) Handles irAsecciones.Click
        Dim secciones As Secciones = New Secciones()
        Me.Hide()
        secciones.Show()
    End Sub


End Class