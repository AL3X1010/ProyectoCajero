<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newaccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpbPI = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtaddr1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdbF = New System.Windows.Forms.RadioButton()
        Me.rdbM = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFamN = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtinitialdep = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.grpbPI.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(757, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "_________________________________________________________________________________" & _
            "____________________________________________"
        '
        'grpbPI
        '
        Me.grpbPI.Controls.Add(Me.cmbStatus)
        Me.grpbPI.Controls.Add(Me.Label13)
        Me.grpbPI.Controls.Add(Me.txtaddr1)
        Me.grpbPI.Controls.Add(Me.Label12)
        Me.grpbPI.Controls.Add(Me.Label11)
        Me.grpbPI.Controls.Add(Me.rdbF)
        Me.grpbPI.Controls.Add(Me.rdbM)
        Me.grpbPI.Controls.Add(Me.Label10)
        Me.grpbPI.Controls.Add(Me.txtFamN)
        Me.grpbPI.Controls.Add(Me.txtage)
        Me.grpbPI.Controls.Add(Me.Label6)
        Me.grpbPI.Controls.Add(Me.txtFN)
        Me.grpbPI.Controls.Add(Me.Label5)
        Me.grpbPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbPI.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpbPI.Location = New System.Drawing.Point(15, 25)
        Me.grpbPI.Name = "grpbPI"
        Me.grpbPI.Size = New System.Drawing.Size(388, 269)
        Me.grpbPI.TabIndex = 4
        Me.grpbPI.TabStop = False
        Me.grpbPI.Text = "Informacion Personal"
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cmbStatus.Location = New System.Drawing.Point(256, 86)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(113, 21)
        Me.cmbStatus.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(211, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Estado"
        '
        'txtaddr1
        '
        Me.txtaddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddr1.Location = New System.Drawing.Point(83, 169)
        Me.txtaddr1.Name = "txtaddr1"
        Me.txtaddr1.Size = New System.Drawing.Size(268, 20)
        Me.txtaddr1.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(20, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(20, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 34
        '
        'rdbF
        '
        Me.rdbF.AutoSize = True
        Me.rdbF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbF.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbF.Location = New System.Drawing.Point(123, 134)
        Me.rdbF.Name = "rdbF"
        Me.rdbF.Size = New System.Drawing.Size(51, 17)
        Me.rdbF.TabIndex = 6
        Me.rdbF.TabStop = True
        Me.rdbF.Text = "Mujer"
        Me.rdbF.UseVisualStyleBackColor = True
        '
        'rdbM
        '
        Me.rdbM.AutoSize = True
        Me.rdbM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbM.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbM.Location = New System.Drawing.Point(55, 134)
        Me.rdbM.Name = "rdbM"
        Me.rdbM.Size = New System.Drawing.Size(62, 17)
        Me.rdbM.TabIndex = 5
        Me.rdbM.TabStop = True
        Me.rdbM.Text = "Hombre"
        Me.rdbM.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(20, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sexo:"
        '
        'txtFamN
        '
        Me.txtFamN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamN.Location = New System.Drawing.Point(270, 50)
        Me.txtFamN.Name = "txtFamN"
        Me.txtFamN.Size = New System.Drawing.Size(112, 20)
        Me.txtFamN.TabIndex = 2
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(83, 90)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(78, 20)
        Me.txtage.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(20, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Edad"
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(113, 50)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(112, 20)
        Me.txtFN.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nombre Completo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtCardNum)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtinitialdep)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.btncreate)
        Me.GroupBox1.Controls.Add(Me.txtPin)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtAccNum)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(412, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 269)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta De Banco"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(211, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "(4 Digit)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(270, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "(6 Digit)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(162, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "(11 Digit)"
        '
        'txtCardNum
        '
        Me.txtCardNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNum.Location = New System.Drawing.Point(116, 31)
        Me.txtCardNum.MaxLength = 11
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(170, 20)
        Me.txtCardNum.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(13, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Numero De Tarjeta"
        '
        'txtinitialdep
        '
        Me.txtinitialdep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinitialdep.Location = New System.Drawing.Point(116, 149)
        Me.txtinitialdep.Name = "txtinitialdep"
        Me.txtinitialdep.Size = New System.Drawing.Size(89, 20)
        Me.txtinitialdep.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(20, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Deposito:"
        '
        'btncreate
        '
        Me.btncreate.BackColor = System.Drawing.SystemColors.Desktop
        Me.btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.Location = New System.Drawing.Point(53, 195)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(255, 40)
        Me.btncreate.TabIndex = 5
        Me.btncreate.Text = "Crear"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'txtPin
        '
        Me.txtPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPin.Location = New System.Drawing.Point(116, 117)
        Me.txtPin.MaxLength = 4
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(89, 20)
        Me.txtPin.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(22, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Pin"
        '
        'txtAccNum
        '
        Me.txtAccNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNum.Location = New System.Drawing.Point(116, 74)
        Me.txtAccNum.MaxLength = 6
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.Size = New System.Drawing.Size(148, 20)
        Me.txtAccNum.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(20, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Numero De Cuenta"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(752, 1)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 18)
        Me.btnclose.TabIndex = 83
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'newaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 318)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbPI)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newaccount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "newaccount"
        Me.grpbPI.ResumeLayout(False)
        Me.grpbPI.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpbPI As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtaddr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rdbF As System.Windows.Forms.RadioButton
    Friend WithEvents rdbM As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFamN As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAccNum As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents txtinitialdep As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCardNum As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
