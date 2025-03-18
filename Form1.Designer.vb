<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btnIniciarManual = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkSigem = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cerrar.BackColor = System.Drawing.Color.Brown
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_cerrar.Location = New System.Drawing.Point(135, 233)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(98, 26)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.Text = "Salir"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btnIniciarManual
        '
        Me.btnIniciarManual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIniciarManual.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnIniciarManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarManual.ForeColor = System.Drawing.SystemColors.Control
        Me.btnIniciarManual.Location = New System.Drawing.Point(135, 199)
        Me.btnIniciarManual.Name = "btnIniciarManual"
        Me.btnIniciarManual.Size = New System.Drawing.Size(98, 28)
        Me.btnIniciarManual.TabIndex = 6
        Me.btnIniciarManual.Text = "Manual"
        Me.btnIniciarManual.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Manual de usuario del Sistema Gestor de Empresas y Municipios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(134, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SIGEM"
        '
        'LinkSigem
        '
        Me.LinkSigem.AutoSize = True
        Me.LinkSigem.Location = New System.Drawing.Point(137, 144)
        Me.LinkSigem.Name = "LinkSigem"
        Me.LinkSigem.Size = New System.Drawing.Size(96, 13)
        Me.LinkSigem.TabIndex = 8
        Me.LinkSigem.TabStop = True
        Me.LinkSigem.Text = "www.sigem.com.ar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 314)
        Me.Controls.Add(Me.LinkSigem)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btnIniciarManual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btnIniciarManual As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkSigem As LinkLabel
End Class
