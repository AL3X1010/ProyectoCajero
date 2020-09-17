<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaccion
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
        Me.RETIRO = New System.Windows.Forms.Button()
        Me.ConsultarSaldo = New System.Windows.Forms.Button()
        Me.CambioPin = New System.Windows.Forms.Button()
        Me.Transferencia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Recibo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RETIRO
        '
        Me.RETIRO.BackColor = System.Drawing.Color.DarkGray
        Me.RETIRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RETIRO.Location = New System.Drawing.Point(46, 50)
        Me.RETIRO.Name = "RETIRO"
        Me.RETIRO.Size = New System.Drawing.Size(113, 74)
        Me.RETIRO.TabIndex = 0
        Me.RETIRO.Text = ">>"
        Me.RETIRO.UseVisualStyleBackColor = False
        '
        'ConsultarSaldo
        '
        Me.ConsultarSaldo.BackColor = System.Drawing.Color.DarkGray
        Me.ConsultarSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarSaldo.Location = New System.Drawing.Point(47, 143)
        Me.ConsultarSaldo.Name = "ConsultarSaldo"
        Me.ConsultarSaldo.Size = New System.Drawing.Size(113, 74)
        Me.ConsultarSaldo.TabIndex = 1
        Me.ConsultarSaldo.Text = ">>"
        Me.ConsultarSaldo.UseVisualStyleBackColor = False
        '
        'CambioPin
        '
        Me.CambioPin.BackColor = System.Drawing.Color.DarkGray
        Me.CambioPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambioPin.Location = New System.Drawing.Point(488, 50)
        Me.CambioPin.Name = "CambioPin"
        Me.CambioPin.Size = New System.Drawing.Size(106, 74)
        Me.CambioPin.TabIndex = 2
        Me.CambioPin.Text = "<<"
        Me.CambioPin.UseVisualStyleBackColor = False
        '
        'Transferencia
        '
        Me.Transferencia.BackColor = System.Drawing.Color.DarkGray
        Me.Transferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transferencia.Location = New System.Drawing.Point(488, 143)
        Me.Transferencia.Name = "Transferencia"
        Me.Transferencia.Size = New System.Drawing.Size(106, 74)
        Me.Transferencia.TabIndex = 3
        Me.Transferencia.Text = "<<"
        Me.Transferencia.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cambiar Pin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Consutar Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Transferencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Retiro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Recibo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 267)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Recibo
        '
        Me.Recibo.BackColor = System.Drawing.Color.DarkGray
        Me.Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recibo.Location = New System.Drawing.Point(488, 243)
        Me.Recibo.Name = "Recibo"
        Me.Recibo.Size = New System.Drawing.Size(106, 74)
        Me.Recibo.TabIndex = 10
        Me.Recibo.Text = "<<"
        Me.Recibo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(46, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 74)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Transaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(630, 357)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Recibo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Transferencia)
        Me.Controls.Add(Me.CambioPin)
        Me.Controls.Add(Me.ConsultarSaldo)
        Me.Controls.Add(Me.RETIRO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transaccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RETIRO As System.Windows.Forms.Button
    Friend WithEvents ConsultarSaldo As System.Windows.Forms.Button
    Friend WithEvents CambioPin As System.Windows.Forms.Button
    Friend WithEvents Transferencia As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Recibo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
