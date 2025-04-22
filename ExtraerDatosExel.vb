Imports ClosedXML.Excel
Imports System.Linq

Public Class ExtraerDatosExel


    Private ruta As String = AppDomain.CurrentDomain.BaseDirectory & "Documentos\"
    Private rutaArchivo As String = IO.Path.Combine(ruta, "SIGEM_manual.xlsx")

    'extraer datos de exel
    Public Function extraerDatos() As DataTable

        Dim tablaDatos As DataTable = New DataTable()
        'Genero espacio de trabajo de xlsx
        Using archivo As New XLWorkbook(rutaArchivo)

            Dim hoja = archivo.Worksheet(1)

            ' Encuentro columnas "descripcion" y "Fomulario "
            Dim colDescripcion As Integer = -1
            Dim colFomulario As Integer = -1
            Dim colHoja As Integer = -1


            ' Recorro la primera fila para encontrar las columnas
            For Each celda In hoja.Row(1).Cells()
                If celda.Value.ToString().Trim() = "descripcion" Then
                    colDescripcion = celda.WorksheetColumn().ColumnNumber()  '- 1 Índice base 0
                ElseIf celda.Value.ToString().Trim() = "Formulario" Then
                    colFomulario = celda.WorksheetColumn().ColumnNumber() '- 1  Índice base 0
                    'ElseIf celda.Value.ToString().Trim() = "hoja" Then
                    '    colHoja = celda.WorksheetColumn().ColumnNumber() '- 1  Índice base 0
                End If
            Next

            ' Agrego las columnas a la tabla
            tablaDatos.Columns.Add("descripcion")
            tablaDatos.Columns.Add("Formulario")

            ' Recorro las filas restantes para agregar los datos
            For Each fila In hoja.RowsUsed().Skip(1) ' Saltamos la primera fila (encabezados)
                Dim newRow As DataRow = tablaDatos.NewRow()
                For Each celda In fila.Cells()
                    Dim columnaActual As Integer = celda.WorksheetColumn().ColumnNumber()

                    If columnaActual = colDescripcion Then
                        newRow("descripcion") = celda.Value.ToString() ' Índice base 1
                    ElseIf columnaActual = colFomulario Then
                        newRow("Formulario") = celda.Value.ToString()
                        'ElseIf columnaActual = colHoja Then
                        '    newRow("Hoja") = celda.Value.ToString()
                    End If

                Next

                tablaDatos.Rows.Add(newRow)
            Next
        End Using

        Return tablaDatos
    End Function
End Class
