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
        Me.components = New System.ComponentModel.Container()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.TbCntrlServidor = New System.Windows.Forms.TabControl()
        Me.TbPgEntrada = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDesencriptado_Entrada = New System.Windows.Forms.TextBox()
        Me.TxtEncriptado_Entrada = New System.Windows.Forms.TextBox()
        Me.TbPgSalida = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDesencriptado_Salida = New System.Windows.Forms.TextBox()
        Me.TxtEncriptado_Salida = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroDataSet = New Global.Servidor.cajeroDataSet()
        Me.BitacoraTableAdapter = New cajeroDataSetTableAdapters.bitacoraTableAdapter()
        Me.TbCntrlServidor.SuspendLayout()
        Me.TbPgEntrada.SuspendLayout()
        Me.TbPgSalida.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(12, 22)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(112, 277)
        Me.Lista.TabIndex = 3
        '
        'TbCntrlServidor
        '
        Me.TbCntrlServidor.Controls.Add(Me.TbPgEntrada)
        Me.TbCntrlServidor.Controls.Add(Me.TbPgSalida)
        Me.TbCntrlServidor.Controls.Add(Me.TabPage1)
        Me.TbCntrlServidor.Location = New System.Drawing.Point(153, 22)
        Me.TbCntrlServidor.Multiline = True
        Me.TbCntrlServidor.Name = "TbCntrlServidor"
        Me.TbCntrlServidor.SelectedIndex = 0
        Me.TbCntrlServidor.Size = New System.Drawing.Size(723, 277)
        Me.TbCntrlServidor.TabIndex = 10
        '
        'TbPgEntrada
        '
        Me.TbPgEntrada.Controls.Add(Me.Label4)
        Me.TbPgEntrada.Controls.Add(Me.Label3)
        Me.TbPgEntrada.Controls.Add(Me.TxtDesencriptado_Entrada)
        Me.TbPgEntrada.Controls.Add(Me.TxtEncriptado_Entrada)
        Me.TbPgEntrada.Location = New System.Drawing.Point(4, 22)
        Me.TbPgEntrada.Name = "TbPgEntrada"
        Me.TbPgEntrada.Padding = New System.Windows.Forms.Padding(3)
        Me.TbPgEntrada.Size = New System.Drawing.Size(715, 251)
        Me.TbPgEntrada.TabIndex = 0
        Me.TbPgEntrada.Text = "Entrada"
        Me.TbPgEntrada.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "XML"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "3DS"
        '
        'TxtDesencriptado_Entrada
        '
        Me.TxtDesencriptado_Entrada.Location = New System.Drawing.Point(388, 45)
        Me.TxtDesencriptado_Entrada.Multiline = True
        Me.TxtDesencriptado_Entrada.Name = "TxtDesencriptado_Entrada"
        Me.TxtDesencriptado_Entrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesencriptado_Entrada.Size = New System.Drawing.Size(292, 177)
        Me.TxtDesencriptado_Entrada.TabIndex = 17
        '
        'TxtEncriptado_Entrada
        '
        Me.TxtEncriptado_Entrada.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEncriptado_Entrada.Location = New System.Drawing.Point(28, 45)
        Me.TxtEncriptado_Entrada.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TxtEncriptado_Entrada.Multiline = True
        Me.TxtEncriptado_Entrada.Name = "TxtEncriptado_Entrada"
        Me.TxtEncriptado_Entrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtEncriptado_Entrada.Size = New System.Drawing.Size(312, 177)
        Me.TxtEncriptado_Entrada.TabIndex = 14
        '
        'TbPgSalida
        '
        Me.TbPgSalida.Controls.Add(Me.Label5)
        Me.TbPgSalida.Controls.Add(Me.Label6)
        Me.TbPgSalida.Controls.Add(Me.TxtDesencriptado_Salida)
        Me.TbPgSalida.Controls.Add(Me.TxtEncriptado_Salida)
        Me.TbPgSalida.Location = New System.Drawing.Point(4, 22)
        Me.TbPgSalida.Name = "TbPgSalida"
        Me.TbPgSalida.Padding = New System.Windows.Forms.Padding(3)
        Me.TbPgSalida.Size = New System.Drawing.Size(715, 251)
        Me.TbPgSalida.TabIndex = 1
        Me.TbPgSalida.Text = "Salida"
        Me.TbPgSalida.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "XML"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "3DS"
        '
        'TxtDesencriptado_Salida
        '
        Me.TxtDesencriptado_Salida.Location = New System.Drawing.Point(375, 45)
        Me.TxtDesencriptado_Salida.Multiline = True
        Me.TxtDesencriptado_Salida.Name = "TxtDesencriptado_Salida"
        Me.TxtDesencriptado_Salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesencriptado_Salida.Size = New System.Drawing.Size(292, 175)
        Me.TxtDesencriptado_Salida.TabIndex = 17
        '
        'TxtEncriptado_Salida
        '
        Me.TxtEncriptado_Salida.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEncriptado_Salida.Location = New System.Drawing.Point(28, 45)
        Me.TxtEncriptado_Salida.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TxtEncriptado_Salida.Multiline = True
        Me.TxtEncriptado_Salida.Name = "TxtEncriptado_Salida"
        Me.TxtEncriptado_Salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtEncriptado_Salida.Size = New System.Drawing.Size(312, 175)
        Me.TxtEncriptado_Salida.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 251)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Bitacora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.OperacionDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.SaldobDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BitacoraBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(703, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'SaldobDataGridViewTextBoxColumn
        '
        Me.SaldobDataGridViewTextBoxColumn.DataPropertyName = "saldob"
        Me.SaldobDataGridViewTextBoxColumn.HeaderText = "saldob"
        Me.SaldobDataGridViewTextBoxColumn.Name = "SaldobDataGridViewTextBoxColumn"
        '
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataMember = "bitacora"
        Me.BitacoraBindingSource.DataSource = Me.CajeroDataSet
        '
        'CajeroDataSet
        '
        Me.CajeroDataSet.DataSetName = "cajeroDataSet"
        Me.CajeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BitacoraTableAdapter
        '
        Me.BitacoraTableAdapter.ClearBeforeFill = True
        '
        'Servidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(910, 326)
        Me.Controls.Add(Me.TbCntrlServidor)
        Me.Controls.Add(Me.Lista)
        Me.Name = "Servidor"
        Me.Text = "Servidor"
        Me.TbCntrlServidor.ResumeLayout(False)
        Me.TbPgEntrada.ResumeLayout(False)
        Me.TbPgEntrada.PerformLayout()
        Me.TbPgSalida.ResumeLayout(False)
        Me.TbPgSalida.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lista As System.Windows.Forms.ListBox
    Friend WithEvents TbCntrlServidor As System.Windows.Forms.TabControl
    Friend WithEvents TbPgEntrada As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDesencriptado_Entrada As System.Windows.Forms.TextBox
    Friend WithEvents TxtEncriptado_Entrada As System.Windows.Forms.TextBox
    Friend WithEvents TbPgSalida As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDesencriptado_Salida As System.Windows.Forms.TextBox
    Friend WithEvents TxtEncriptado_Salida As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CajeroDataSet As Global.Servidor.cajeroDataSet
    Friend WithEvents BitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BitacoraTableAdapter As cajeroDataSetTableAdapters.bitacoraTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
