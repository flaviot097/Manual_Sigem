<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grillaDatos = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.btnBuscarSeccion = New System.Windows.Forms.Button()
        Me.btnTodaSecciones = New System.Windows.Forms.Button()
        CType(Me.grillaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaDatos
        '
        Me.grillaDatos.AllowUserToAddRows = False
        Me.grillaDatos.AllowUserToDeleteRows = False
        Me.grillaDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaDatos.Location = New System.Drawing.Point(98, 100)
        Me.grillaDatos.Name = "grillaDatos"
        Me.grillaDatos.ReadOnly = True
        Me.grillaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaDatos.Size = New System.Drawing.Size(622, 305)
        Me.grillaDatos.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(47, 22)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(352, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SIGEM"
        '
        'txtSeccion
        '
        Me.txtSeccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeccion.Location = New System.Drawing.Point(98, 60)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(451, 20)
        Me.txtSeccion.TabIndex = 7
        '
        'btnBuscarSeccion
        '
        Me.btnBuscarSeccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarSeccion.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBuscarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSeccion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarSeccion.Location = New System.Drawing.Point(555, 57)
        Me.btnBuscarSeccion.Name = "btnBuscarSeccion"
        Me.btnBuscarSeccion.Size = New System.Drawing.Size(165, 25)
        Me.btnBuscarSeccion.TabIndex = 8
        Me.btnBuscarSeccion.Text = "Buscar"
        Me.btnBuscarSeccion.UseVisualStyleBackColor = False
        '
        'btnTodaSecciones
        '
        Me.btnTodaSecciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTodaSecciones.Location = New System.Drawing.Point(294, 415)
        Me.btnTodaSecciones.Name = "btnTodaSecciones"
        Me.btnTodaSecciones.Size = New System.Drawing.Size(234, 23)
        Me.btnTodaSecciones.TabIndex = 9
        Me.btnTodaSecciones.Text = "Todas Las Secciones"
        Me.btnTodaSecciones.UseVisualStyleBackColor = True
        '
        'Secciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTodaSecciones)
        Me.Controls.Add(Me.btnBuscarSeccion)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.grillaDatos)
        Me.Name = "Secciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secciones"
        CType(Me.grillaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grillaDatos As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSeccion As TextBox
    Friend WithEvents btnBuscarSeccion As Button
    Friend WithEvents btnTodaSecciones As Button
End Class
