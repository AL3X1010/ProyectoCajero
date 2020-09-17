Imports System.Security.Cryptography
Imports System.Text
'Imports ClienteSeguridad.Form1
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class Form1


    Dim WithEvents WinSockCliente As New Cliente
    Private demo As Threading.Thread = Nothing
    Dim IP1 As String
    Dim port1 As String
    Dim Texto As String
    Delegate Sub SetTextCallback(ByVal [text1] As String)

    Private Sub ThreadProcSafe()
        Me.SetText(Texto)
    End Sub

    'Private Function deserializar(ByVal men As String) As guardartodo

    '    ''Deserialize XML file to a new chat object.
    '    My.Computer.FileSystem.WriteAllText("D:\Apoyo seguridad\Respaldo Seguridad\Servidor\archivo.xml", men, False)
    '    Dim objStreamReader As New StreamReader("D:\Apoyo seguridad\Respaldo Seguridad\Servidor\archivo.xml") 'Read File
    '    Dim msj As New guardartodo() 'Instantiate new chat Object
    '    Dim xsDeserialize As New XmlSerializer(msj.GetType) 'Get Info present
    '    msj = xsDeserialize.Deserialize(objStreamReader) 'Deserialize / Open
    '    objStreamReader.Close() 'Close Reader
    '    ''Display values of the new chat object
    '    Return msj
    '    'TxtCliente.Text = msj.Mensaje
    'End Function

    Private Sub SetText(ByVal [text1] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        ' If these threads are different, it returns true.
        If Me.txtEncriptado.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text1]})
        Else

            Me.txtEncriptado.Text = txtEncriptado.Text & vbCrLf & "Servidor: " & text1

         
        End If

    End Sub

    Private Sub ToolStripSplitButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.Click
        transaction.MdiParent = Me
        transaction.Show()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        ShowRecordsvb.MdiParent = Me
        ShowRecordsvb.Show()
    End Sub


    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        With WinSockCliente
            'Determino a donde se quiere conectar el usuario 
            .IPDelHost = txtIP.Text
            .PuertoDelHost = txtPuerto.Text
            'Me conecto 

            'Deshabilito la posibilidad de conexion 
            txtIP.Enabled = False
            txtPuerto.Enabled = False
            If btnConectar.Text = "desconectar" Then
                btnConectar.Text = "conectar"
            Else
                .Conectar()
                btnConectar.Text = "desconectar"
            End If
            'Habilito la posibilidad de enviar mensajes 

        End With
    End Sub

    Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos
        'txtMensaje.Text = txtMensaje.Text + datos
        Texto = datos
        Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
        Me.demo.Start()

        'MsgBox("El servidor envio el siguiente mensaje: " & datos)
    End Sub

    Private Sub WinSockCliente_ConexionTerminada() Handles WinSockCliente.ConexionTerminada
        MsgBox("Finalizo la conexion")
        'Habilito la posibilidad de una reconexion 
        txtIP.Enabled = True
        txtPuerto.Enabled = True
        btnConectar.Enabled = True

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As New Login
        a.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'serializar
    End Sub
    'Public Sub serializar()
    '    Dim p As New clsProduct()
    '    p.Name = "Allan1010"
    '    p.Description = "Gran Jeropa"
    '    p.Qty = 5
    '    Dim objStreamWriter As New StreamWriter("D:\Apoyo seguridad\ejemplo2.xml")
    '    Dim x As New XmlSerializer(p.GetType)
    '    x.Serialize(objStreamWriter, p)
    '    objStreamWriter.Close()
    'End Sub
    'Public Sub deserializar()
    '    Dim p As New clsProduct()
    '    'Deserialize text file to a new object.
    '    Dim objStreamReader As New StreamReader("D:\Apoyo seguridad\ejemplo2.xml")
    '    Dim x As New XmlSerializer(p.GetType)
    '    Dim p2 As New clsProduct()
    '    p2 = x.Deserialize(objStreamReader)
    '    objStreamReader.Close()
    'End Sub

    Private Sub txtDesencriptado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesencriptado.TextChanged

    End Sub
End Class
