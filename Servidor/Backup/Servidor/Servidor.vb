
Public Class Servidor
    Dim WithEvents WinSockServer1 As New WinSockServer()
    Private demo As Threading.Thread = Nothing
    Private demo1 As Threading.Thread = Nothing
    Dim IP1 As String
    Dim port1 As String
    Dim texto As String
    Delegate Sub SetTextCallback(ByVal [text1] As String)


    Private Sub ThreadProcSafe()
        Me.SetText(IP1)
    End Sub
    Private Sub SetText(ByVal [text1] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Lista.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Lista.Items.Add(IP1)
        End If
    End Sub
    Private Sub ThreadProcSafe1()
        Me.SetText1(texto)
    End Sub
    Private Sub SetText1(ByVal [text1] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.TxtMensaje.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText1)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Me.TxtMensaje.Text = TxtMensaje.Text & vbCrLf & texto
            Me.TxtServ.Text = " "
        End If
    End Sub

    Private Sub Servidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With WinSockServer1
            'Establezco el puerto donde escuchar 
            .PuertoDeEscucha = 8050
            'Comienzo la escucha 
            .Escuchar()
        End With
    End Sub
    Private Sub WinSockServer_NuevaConexion(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer1.NuevaConexion
        'Muestro quien se conecto 
       
        'WinSockServer1 = New Threading.Thread(New Threading.ThreadStart(WinSockSe ))
        IP1 = IDTerminal.Address.ToString & ":" & IDTerminal.Port.ToString
        Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
        Me.demo.Start()

        MsgBox("Se ha conectado un nuevo cliente desde la IP= " & IDTerminal.Address.ToString & _
                                                        ",Puerto = " & IDTerminal.Port)
    End Sub
    Private Sub WinSockServer_ConexionTerminada(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer1.ConexionTerminada
        'Muestro con quien se termino la conexion 
        MsgBox("Se ha desconectado el cliente desde la IP= " & IDTerminal.Address.ToString & _
                                                             ",Puerto = " & IDTerminal.Port)
    End Sub
    Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint, ByVal Datos As String) Handles WinSockServer1.DatosRecibidos
        'Muestro quien envio el mensaje 
        'TxtMensaje.Text = TxtMensaje.Text & vbCrLf & "IP(" & IDTerminal.Address.ToString & ":" & IDTerminal.Port & ")" & WinSockServer1.ObtenerDatos(IDTerminal)
        texto = IDTerminal.Address.ToString & ":" & IDTerminal.Port.ToString & ":" & Datos
        Me.demo1 = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe1))
        Me.demo1.Start()
        'Muestro el mensaje recibido 
        ' Call MsgBox(WinSockServer1.ObtenerDatos(IDTerminal))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Envio el texto escrito en el textbox txtMensaje a todos los clientes 
        WinSockServer1.EnviarDatos(TxtServ.Text)
        'Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
        'Me.demo.Start()
        TxtMensaje.Text = TxtMensaje.Text & vbCrLf & TxtServ.Text
        TxtServ.Text = " "
    End Sub
End Class
