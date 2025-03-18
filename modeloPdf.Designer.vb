<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modeloPdf
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBusqueda = New Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripSearch()
        Me.VisorPdf = New Patagames.Pdf.Net.Controls.WinForms.PdfViewer()
        Me.SuspendLayout()
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ActiveRecordColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.CurrentRecord = 0
        Me.txtBusqueda.Dock = System.Windows.Forms.DockStyle.None
        Me.txtBusqueda.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBusqueda.Location = New System.Drawing.Point(9, 9)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PdfViewer = Nothing
        Me.txtBusqueda.SearchFlags = Patagames.Pdf.Enums.FindFlags.None
        Me.txtBusqueda.SearchText = ""
        Me.txtBusqueda.Size = New System.Drawing.Size(232, 37)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.Text = "PdfToolStripSearch1"
        '
        'VisorPdf
        '
        Me.VisorPdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorPdf.BackColor = System.Drawing.SystemColors.ControlDark
        Me.VisorPdf.CurrentIndex = -1
        Me.VisorPdf.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.VisorPdf.Document = Nothing
        Me.VisorPdf.FormHighlightColor = System.Drawing.Color.Transparent
        Me.VisorPdf.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY
        Me.VisorPdf.LoadingIconText = "Loading..."
        Me.VisorPdf.Location = New System.Drawing.Point(331, 27)
        Me.VisorPdf.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.[Default]
        Me.VisorPdf.Name = "VisorPdf"
        Me.VisorPdf.OptimizedLoadThreshold = 1000
        Me.VisorPdf.Padding = New System.Windows.Forms.Padding(10)
        Me.VisorPdf.PageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VisorPdf.PageAutoDispose = True
        Me.VisorPdf.PageBackColor = System.Drawing.Color.White
        Me.VisorPdf.PageBorderColor = System.Drawing.Color.Black
        Me.VisorPdf.PageMargin = New System.Windows.Forms.Padding(10)
        Me.VisorPdf.PageSeparatorColor = System.Drawing.Color.Gray
        Me.VisorPdf.RenderFlags = CType((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT Or Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH), Patagames.Pdf.Enums.RenderFlags)
        Me.VisorPdf.ShowCurrentPageHighlight = True
        Me.VisorPdf.ShowLoadingIcon = True
        Me.VisorPdf.ShowPageSeparator = True
        Me.VisorPdf.Size = New System.Drawing.Size(481, 557)
        Me.VisorPdf.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth
        Me.VisorPdf.TabIndex = 1
        Me.VisorPdf.TextSelectColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.VisorPdf.TilesCount = 2
        Me.VisorPdf.UseProgressiveRender = True
        Me.VisorPdf.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical
        Me.VisorPdf.Zoom = 1.0!
        '
        'modeloPdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1125, 596)
        Me.Controls.Add(Me.VisorPdf)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Name = "modeloPdf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modeloPdf"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBusqueda As Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripSearch
    Friend WithEvents VisorPdf As Patagames.Pdf.Net.Controls.WinForms.PdfViewer
End Class
