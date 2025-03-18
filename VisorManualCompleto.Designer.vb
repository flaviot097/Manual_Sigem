<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisorManualCompleto
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
        Me.VisorManual = New Patagames.Pdf.Net.Controls.WinForms.PdfViewer()
        Me.PdfToolzoom = New Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VisorManual
        '
        Me.VisorManual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorManual.BackColor = System.Drawing.SystemColors.ControlDark
        Me.VisorManual.CurrentIndex = -1
        Me.VisorManual.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.VisorManual.Document = Nothing
        Me.VisorManual.FormHighlightColor = System.Drawing.Color.Transparent
        Me.VisorManual.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY
        Me.VisorManual.LoadingIconText = "Loading..."
        Me.VisorManual.Location = New System.Drawing.Point(241, 12)
        Me.VisorManual.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.[Default]
        Me.VisorManual.Name = "VisorManual"
        Me.VisorManual.OptimizedLoadThreshold = 1000
        Me.VisorManual.Padding = New System.Windows.Forms.Padding(10)
        Me.VisorManual.PageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VisorManual.PageAutoDispose = True
        Me.VisorManual.PageBackColor = System.Drawing.Color.White
        Me.VisorManual.PageBorderColor = System.Drawing.Color.Black
        Me.VisorManual.PageMargin = New System.Windows.Forms.Padding(10)
        Me.VisorManual.PageSeparatorColor = System.Drawing.Color.Gray
        Me.VisorManual.RenderFlags = CType((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT Or Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH), Patagames.Pdf.Enums.RenderFlags)
        Me.VisorManual.ShowCurrentPageHighlight = True
        Me.VisorManual.ShowLoadingIcon = True
        Me.VisorManual.ShowPageSeparator = True
        Me.VisorManual.Size = New System.Drawing.Size(323, 426)
        Me.VisorManual.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth
        Me.VisorManual.TabIndex = 0
        Me.VisorManual.TextSelectColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.VisorManual.TilesCount = 2
        Me.VisorManual.UseProgressiveRender = True
        Me.VisorManual.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical
        Me.VisorManual.Zoom = 1.0!
        '
        'PdfToolzoom
        '
        Me.PdfToolzoom.Location = New System.Drawing.Point(0, 0)
        Me.PdfToolzoom.Name = "PdfToolzoom"
        Me.PdfToolzoom.PdfViewer = Nothing
        Me.PdfToolzoom.Size = New System.Drawing.Size(800, 25)
        Me.PdfToolzoom.TabIndex = 2
        Me.PdfToolzoom.Text = "PdfToolStripZoomEx1"
        Me.PdfToolzoom.ZoomLevel = New Single() {8.33!, 12.5!, 25.0!, 33.33!, 50.0!, 66.67!, 75.0!, 100.0!, 125.0!, 150.0!, 200.0!, 300.0!, 400.0!, 600.0!, 800.0!}
        '
        'imprimir
        '
        Me.imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imprimir.BackColor = System.Drawing.SystemColors.Highlight
        Me.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.imprimir.Location = New System.Drawing.Point(736, 415)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(52, 23)
        Me.imprimir.TabIndex = 3
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = False
        '
        'VisorManualCompleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.PdfToolzoom)
        Me.Controls.Add(Me.VisorManual)
        Me.Name = "VisorManualCompleto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisorManual As Patagames.Pdf.Net.Controls.WinForms.PdfViewer
    Friend WithEvents PdfToolzoom As Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx
    Friend WithEvents imprimir As Button
End Class
