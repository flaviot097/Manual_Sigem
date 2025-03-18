Imports iTextSharp.text.pdf
Imports System.Drawing


Public Class ManualMenu

    Private Sub ManualMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim buscarModelo As modeloPdf = New modeloPdf()
        buscarModelo.pasarTexto(txtConsulta.Text)
        buscarModelo.Show()
        Me.Hide()
        '' Cargar el PDF usando PdfiumViewer
        'Dim pdfDocument As PdfDocument = pdfDocument.Load(rutaDocumento)

        '' Verificar si el PDF se cargó correctamente
        'If pdfDocument IsNot Nothing Then
        '    ' Obtener la primera página del PDF como imagen
        '    Dim imagenPagina As Image = pdfDocument.Render(0, 150, 150, True)

        '    ' Mostrar la imagen en el PictureBox
        '    If visor.Image IsNot Nothing Then
        '        visor.Image.Dispose() ' Liberar la imagen anterior
        '    End If
        '    visor.Image = imagenPagina
        'Else
        '    MessageBox.Show("No se pudo cargar el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub btnManualCompleto_Click(sender As Object, e As EventArgs) Handles btnManualCompleto.Click
        Dim manualCompleto = New VisorManualCompleto()
        manualCompleto.Show()
        Me.Hide()
    End Sub

    Private Sub irAsecciones_Click(sender As Object, e As EventArgs) Handles irAsecciones.Click
        Dim secciones As Secciones = New Secciones()
        secciones.Show()
        Me.Hide()
    End Sub


End Class