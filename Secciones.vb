Imports System.Linq
Imports System.Windows.Interop
Imports ClosedXML.Excel
Imports Controladores
Public Class Secciones
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim manualMenu As ManualMenu = New ManualMenu()
        manualMenu.Show()
        Me.Close()
    End Sub

    Dim tablaDedatos As DataTable = New DataTable()

    Private ruta As String = AppDomain.CurrentDomain.BaseDirectory & "Documentos\"
    Private rutaArchivo As String = IO.Path.Combine(ruta, "SIGEM_manual.xlsx")


    Private Sub Secciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'grillaDatos.Rows.Add("1", "", "1")
        'grillaDatos.Columns.Add("Secciones", "Secciones")

        'Dim ruta As String = AppDomain.CurrentDomain.BaseDirectory & "Documentos\SIGEM_manual.xlsx"
        'Dim rutaDocumento As String = IO.Path.Combine(ruta, "SIGEM_manual.xlsx")

        'tablaDedatos.Columns.Add("Secciones")
        'tablaDedatos.Rows.Add("1") '

        'Dim tablaDedatos As DataTable = New DataTable()

        'grillaDatos.DataSource = tablaDedatos
        tablaDedatos = extraerDatos()
        grillaDatos.DataSource = tablaDedatos

    End Sub

    Private Sub btnBuscarSeccion_Click(sender As Object, e As EventArgs) Handles btnBuscarSeccion.Click

        Dim valorBusqueda As String = txtSeccion.Text.Replace("'", "''")

        Dim criterio As String = $"descripcion LIKE '%{valorBusqueda}%'"
        Dim filasEncontradas() As DataRow = tablaDedatos.Select(criterio)

        'Creo DataTable para almacenar los resultados
        Dim dtResultados As New DataTable()
        dtResultados = tablaDedatos.Clone() 'Clono la estructura del original

        'Agrego filas
        For Each fila As DataRow In filasEncontradas
            dtResultados.ImportRow(fila)
        Next

        grillaDatos.DataSource = dtResultados
    End Sub

    Private Sub btnTodaSecciones_Click(sender As Object, e As EventArgs) Handles btnTodaSecciones.Click
        grillaDatos.DataSource = tablaDedatos
    End Sub

    Private Sub grillaDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaDatos.CellDoubleClick
        Dim formulario As String = ""
        Try
            formulario = grillaDatos.CurrentRow.Cells(1).Value.ToString() 'selecciono de la selda en la que me posicione el valor de la 2da celda
            Dim modelo As modeloPdf = New modeloPdf()
            modelo.pasarTexto(formulario)
            modelo.Show()
            Me.Hide()

        Catch ex As Exception
            Return
        End Try
    End Sub

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