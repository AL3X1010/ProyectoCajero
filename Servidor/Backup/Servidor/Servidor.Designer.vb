<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servidor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtMensaje = New System.Windows.Forms.TextBox
        Me.TxtServ = New System.Windows.Forms.TextBox
        Me.Lista = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 96)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enviar Mensaje"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(8, 12)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(228, 182)
        Me.TxtMensaje.TabIndex = 1
        '
        'TxtServ
        '
        Me.TxtServ.Location = New System.Drawing.Point(12, 211)
        Me.TxtServ.Multiline = True
        Me.TxtServ.Name = "TxtServ"
        Me.TxtServ.Size = New System.Drawing.Size(228, 96)
        Me.TxtServ.TabIndex = 2
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(243, 13)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(197, 186)
        Me.Lista.TabIndex = 3
        '
        'Servidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 319)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.TxtServ)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Servidor"
        Me.Text = "Servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents TxtServ As System.Windows.Forms.TextBox
    Friend WithEvents Lista As System.Windows.Forms.ListBox

End Class
