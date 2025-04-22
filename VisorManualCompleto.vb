Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text.pdf

Public Class VisorManualCompleto

    Dim ruta As String = AppDomain.CurrentDomain.BaseDirectory & "Documentos\"
    Dim rutaDocumento As String = Path.Combine(ruta, "Manual_de_usuario.pdf")
    Private Sub VisorManualCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VisorManual.LoadDocument(rutaDocumento)
        PdfToolzoom.PdfViewer = VisorManual

    End Sub

    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click
        Dim pdfReader As New PdfReader(rutaDocumento)
        Dim printPdf As New PrintDocument()
        Dim printDialog As New PrintDialog()
        printDialog.Document = printPdf
        printPdf.Print()

    End Sub

    Private Sub VisorManualCompleto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim manualMenu As ManualMenu = New ManualMenu()
        manualMenu.Show()
    End Sub
End Class

'Dim proceso As New Process()
'proceso.StartInfo.FileName = rutaDocumento
'proceso.StartInfo.Verb = "print"
'proceso.Start()


'Dim impresora As New PrintDocument()
'impresora.PrinterSettings.PrinterName = "Microsoft Print to PDF"
'impresora.PrinterSettings.PrintFileName = rutaDocumento
'impresora.Print()