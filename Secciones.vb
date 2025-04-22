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


    Private Sub Secciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablaDedatos = New ExtraerDatosExel().extraerDatos()
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




End Class