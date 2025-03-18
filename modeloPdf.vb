Imports System.Drawing
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports Patagames.Pdf.Net.PdfSearch
Public Class modeloPdf
    Dim textoAbuscar As String


    Sub pasarTexto(text As String)
        textoAbuscar = text
    End Sub

    Private Sub modeloPdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargo PDF en el visor
        Dim ruta As String = AppDomain.CurrentDomain.BaseDirectory & "Documentos\"
        Dim rutaDocumento As String = IO.Path.Combine(ruta, "Manual_de_usuario.pdf")
        VisorPdf.LoadDocument(rutaDocumento)

        'Agregar motor de busqueda a PDF
        txtBusqueda.PdfViewer = VisorPdf

        'Buscar texto en PDF
        txtBusqueda.Text = textoAbuscar
        txtBusqueda.SearchText = textoAbuscar

        'Agregar impresora

        'Dim texto As String = txtBusqueda.Text
        'MessageBox.Show("Texto: " & texto, "Texto", MessageBoxButtons.OK, MessageBoxIcon.Information)




        'Dim paginaEncontrada As Integer = BuscarTextoEnPDF(rutaDocumento, textoAbuscar)
        'If paginaEncontrada > 0 Then
        '    VisorPdf.CurrentIndex = paginaEncontrada - 1
        'End If




    End Sub



End Class

