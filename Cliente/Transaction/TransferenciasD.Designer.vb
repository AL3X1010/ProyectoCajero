<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferenciasD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNumeroCuentaTransferir = New System.Windows.Forms.TextBox()
        Me.TextBoxTransferencias = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTransferirNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTransferirCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Para Transferir:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero De Cuenta A Transferir: "
        '
        'TextBoxNumeroCuentaTransferir
        '
        Me.TextBoxNumeroCuentaTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumeroCuentaTransferir.Location = New System.Drawing.Point(307, 119)
        Me.TextBoxNumeroCuentaTransferir.Name = "TextBoxNumeroCuentaTransferir"
        Me.TextBoxNumeroCuentaTransferir.Size = New System.Drawing.Size(128, 26)
        Me.TextBoxNumeroCuentaTransferir.TabIndex = 2
        '
        'TextBoxTransferencias
        '
        Me.TextBoxTransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTransferencias.Location = New System.Drawing.Point(307, 163)
        Me.TextBoxTransferencias.Name = "TextBoxTransferencias"
        Me.TextBoxTransferencias.Size = New System.Drawing.Size(128, 26)
        Me.TextBoxTransferencias.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "TRANSFERIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxTransferirNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxTransferirCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxTransferencias)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumeroCuentaTransferir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 280)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(267, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 32)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre:"
        '
        'TextBoxTransferirNombre
        '
        Me.TextBoxTransferirNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTransferirNombre.Location = New System.Drawing.Point(307, 36)
        Me.TextBoxTransferirNombre.Name = "TextBoxTransferirNombre"
        Me.TextBoxTransferirNombre.ReadOnly = True
        Me.TextBoxTransferirNombre.Size = New System.Drawing.Size(128, 26)
        Me.TextBoxTransferirNombre.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Numero De Cuenta:"
        '
        'TextBoxTransferirCuenta
        '
        Me.TextBoxTransferirCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTransferirCuenta.Location = New System.Drawing.Point(307, 75)
        Me.TextBoxTransferirCuenta.Name = "TextBoxTransferirCuenta"
        Me.TextBoxTransferirCuenta.ReadOnly = True
        Me.TextBoxTransferirCuenta.Size = New System.Drawing.Size(128, 26)
        Me.TextBoxTransferirCuenta.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lps"
        '
        'TransferenciasD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(520, 312)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TransferenciasD"
        Me.Text = "Transferencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNumeroCuentaTransferir As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTransferencias As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTransferirNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTransferirCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
