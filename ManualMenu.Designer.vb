<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManualMenu
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
        Me.Panelicon = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnManualCompleto = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visorPdf = New System.Windows.Forms.FolderBrowserDialog()
        Me.visor = New System.Windows.Forms.PictureBox()
        Me.irAsecciones = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panelicon.SuspendLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelicon
        '
        Me.Panelicon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelicon.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panelicon.Controls.Add(Me.Label1)
        Me.Panelicon.Location = New System.Drawing.Point(2, -2)
        Me.Panelicon.Name = "Panelicon"
        Me.Panelicon.Size = New System.Drawing.Size(179, 438)
        Me.Panelicon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SIGEM"
        '
        'btnManualCompleto
        '
        Me.btnManualCompleto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManualCompleto.Location = New System.Drawing.Point(421, 101)
        Me.btnManualCompleto.Name = "btnManualCompleto"
        Me.btnManualCompleto.Size = New System.Drawing.Size(126, 23)
        Me.btnManualCompleto.TabIndex = 1
        Me.btnManualCompleto.Text = "Ver manual completo"
        Me.btnManualCompleto.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsulta.Location = New System.Drawing.Point(508, 201)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(126, 23)
        Me.btnConsulta.TabIndex = 2
        Me.btnConsulta.Text = "Buscar"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'txtConsulta
        '
        Me.txtConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConsulta.Location = New System.Drawing.Point(344, 201)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(140, 20)
        Me.txtConsulta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese acccion o seccion que quiera buscar"
        '
        'visor
        '
        Me.visor.Location = New System.Drawing.Point(297, 304)
        Me.visor.Name = "visor"
        Me.visor.Size = New System.Drawing.Size(386, 110)
        Me.visor.TabIndex = 5
        Me.visor.TabStop = False
        '
        'irAsecciones
        '
        Me.irAsecciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.irAsecciones.Location = New System.Drawing.Point(344, 244)
        Me.irAsecciones.Name = "irAsecciones"
        Me.irAsecciones.Size = New System.Drawing.Size(290, 23)
        Me.irAsecciones.TabIndex = 6
        Me.irAsecciones.Text = "Ir a secciones"
        Me.irAsecciones.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lista de acciones frecuentes"
        '
        'ManualMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 436)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.irAsecciones)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConsulta)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnManualCompleto)
        Me.Controls.Add(Me.Panelicon)
        Me.Name = "ManualMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panelicon.ResumeLayout(False)
        Me.Panelicon.PerformLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panelicon As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnManualCompleto As Button
    Friend WithEvents btnConsulta As Button
    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents visorPdf As FolderBrowserDialog
    Friend WithEvents visor As PictureBox
    Friend WithEvents irAsecciones As Button
    Friend WithEvents Label4 As Label
End Class
