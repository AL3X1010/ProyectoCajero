Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
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
        'InvokeRequired required compares the thread ID of the
        'calling thread to the thread ID of the creating thread.
        'If these threads are different, it returns true.
        If Me.TxtEncriptado_Entrada.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText1)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Me.TxtEncriptado_Entrada.Text = (texto)

            Dim E As New EncriptacionClass
            Me.TxtDesencriptado_Entrada.Text = E.decryptString(TxtEncriptado_Entrada.Text)
            Dim responde As String = E.encryptString("ok")
            Dim ds As New clsProduct
            ds = deserializar(TxtDesencriptado_Entrada.Text)
            If ds.ndmensaje = "Login" Then
                Dim db As New DataBase
                Dim db2 As New clsProduct
                If db.Login(ds) = "Incorrecto" Then
                    db2.ndmensaje = "Denegar"
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                Else
                    db2.ndmensaje = "Entrar"
                    db2.ntarjeta = db.Login(ds)
                    db.BitacoraServer(ds)
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                End If
            End If
            'retiro
            If ds.ndmensaje = "Retirar" Then
                Dim db As New DataBase
                Dim db2 As New clsProduct
                Dim datos As SqlClient.SqlDataReader
                Dim Bit As String
                datos = db.SaldoActual(ds)

                If ds.nRetiro <= datos(1) Then
                    If db.Retirar(ds) = "Correcto" Then
                        db2.ndmensaje = "Retiro"
                        db2.nnombre = datos(2)
                        db2.nsaldo = db.SaldoActual(ds)(1)
                        db2.ncuenta = datos(0)
                        ds.nsaldo = db.SaldoActual(ds)(1)
                        db.BitacoraServer(ds)
                        Dim msj As String = E.encryptString(serializar(db2))
                        TxtEncriptado_Salida.Text = msj
                        TxtDesencriptado_Salida.Text = E.decryptString(msj)
                        WinSockServer1.EnviarDatos(msj)
                        Bit = "Se Retiro La Cantidad: " & ds.nRetiro & "De La Cuenta: " & datos(0) & "  Fecha: " & Date.Now.ToShortDateString.ToString & " Hora: " & TimeOfDay.ToShortTimeString.ToString & vbCrLf
                        'db.Bitacora(Convert.ToString(Bit))

                    Else
                        db2.ndmensaje = "Denegar"
                        Dim msj As String = E.encryptString(serializar(db2))
                        TxtEncriptado_Salida.Text = msj
                        TxtDesencriptado_Salida.Text = E.decryptString(msj)
                        WinSockServer1.EnviarDatos(msj)
                    End If
                Else
                    db2.ndmensaje = "Saldo Insuficiente"
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                End If
                
            End If
            'cambiar pin
            If ds.ndmensaje = "CambioPin" Then
                Dim db As New DataBase
                Dim db2 As New clsProduct
                If db.CambiarPin(ds) = True Then
                    db2.ndmensaje = "Pin"
                    db.BitacoraServer(ds)
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                Else
                    db2.ndmensaje = "Denegar"
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                End If
            End If
            ''transferir
            If ds.ndmensaje = "Transferencia" Then
                Dim db As New DataBase
                Dim db2 As New clsProduct
                Dim datos As SqlClient.SqlDataReader
                'Dim Bit As String
                datos = db.SaldoActual(ds)

                If ds.nRetiro <= datos(1) Then
                    If db.TransferenciaD(ds) = "Correcto" Then
                        db2.ndmensaje = "Transferencia"
                        db2.nsaldo = db.SaldoActual(ds)(1)
                        ds.nsaldo = db2.nsaldo

                        db.BitacoraServer(ds)
                        Dim msj As String = E.encryptString(serializar(db2))
                        TxtEncriptado_Salida.Text = msj
                        TxtDesencriptado_Salida.Text = E.decryptString(msj)
                        WinSockServer1.EnviarDatos(msj)
                        'Bit = "Se Retiro La Cantidad: " & ds.nRetiro & "De La Cuenta: " & datos(0) & "  Fecha: " & Date.Now.ToShortDateString.ToString & " Hora: " & TimeOfDay.ToShortTimeString.ToString & vbCrLf
                        'db.Bitacora(Convert.ToString(Bit))
                        'RichTextBox1.Text = Bit
                    Else
                        db2.ndmensaje = "Denegar"
                        Dim msj As String = E.encryptString(serializar(db2))
                        TxtEncriptado_Salida.Text = msj
                        TxtDesencriptado_Salida.Text = E.decryptString(msj)
                        WinSockServer1.EnviarDatos(msj)
                    End If
                Else
                    db2.ndmensaje = "Saldo Insuficiente"
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                End If

            End If
            'consultar saldo actual
            If ds.ndmensaje = "ConsutarSaldo" Then
                Dim db As New DataBase
                Dim db2 As New clsProduct
                Dim db3 As New clsProduct
                If db.SaldoActual(ds) Is Nothing Then
                    db2.ndmensaje = "Error de saldo"
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                Else
                    Dim datos As SqlClient.SqlDataReader
                    datos = db.SaldoActual(ds)
                    db2.nsaldo = datos(1)
                    db2.ncuenta = datos(0)
                    db2.nnombre = datos(2)
                    db2.ndmensaje = "Saldo Actual"
                    ds.nsaldo = db2.nsaldo
                    db.BitacoraServer(ds)
                    Dim msj As String = E.encryptString(serializar(db2))
                    TxtEncriptado_Salida.Text = msj
                    TxtDesencriptado_Salida.Text = E.decryptString(msj)
                    WinSockServer1.EnviarDatos(msj)
                End If
            End If
        End If
    End Sub

    Private Sub Servidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CajeroDataSet.bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.Fill(Me.CajeroDataSet.bitacora)
        'TODO: esta línea de código carga datos en la tabla 'CajeroDataSet1.bitacora' Puede moverla o quitarla según sea necesario.

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

        'MsgBox("Se ha conectado un nuevo cliente desde la IP= " & IDTerminal.Address.ToString & _
        '                                                ",Puerto = " & IDTerminal.Port)
    End Sub
    Private Sub WinSockServer_ConexionTerminada(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer1.ConexionTerminada
        'Muestro con quien se termino la conexion 
        MsgBox("Se ha desconectado el cliente desde la IP= " & IDTerminal.Address.ToString & _
                                                             ",Puerto = " & IDTerminal.Port)
    End Sub
    Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint, ByVal Datos As String) Handles WinSockServer1.DatosRecibidos
        'Muestro quien envio el mensaje 
        'TxtMensaje.Text = TxtMensaje.Text & vbCrLf & "IP(" & IDTerminal.Address.ToString & ":" & IDTerminal.Port & ")" & WinSockServer1.ObtenerDatos(IDTerminal)
        texto = Datos
        Me.demo1 = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe1))
        Me.demo1.Start()
        'Muestro el mensaje recibido 
        ' Call MsgBox(WinSockServer1.ObtenerDatos(IDTerminal))
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Envio el texto escrito en el textbox txtMensaje a todos los clientes 
    '    WinSockServer1.EnviarDatos(TxtServ.Text)
    'Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
    'Me.demo.Start()
    '    TxtMensaje.Text = TxtMensaje.Text & vbCrLf & TxtServ.Text
    '    TxtServ.Text = " "
    'End Sub

    Private Sub txtsalidaen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesencriptado_Entrada.TextChanged

    End Sub
    Public Function serializar(ByVal p As clsProduct) As String
        Dim objStreamWriter As New StreamWriter("D:\Apoyo seguridad\ejemplo2.xml")
        Dim x As New XmlSerializer(p.GetType)
        Dim xml As String
        x.Serialize(objStreamWriter, p)
        objStreamWriter.Close()
        xml = My.Computer.FileSystem.ReadAllText("D:\Apoyo seguridad\ejemplo2.xml")
        Return xml
    End Function
    Public Function deserializar(ByVal a As String) As clsProduct
        Dim p As New clsProduct()
        'Deserialize text file to a new object.
        Dim objStreamReader As New StreamReader("D:\Apoyo seguridad\ejemplo2.xml")
        Dim x As New XmlSerializer(p.GetType)
        Dim p2 As New clsProduct()
        p2 = x.Deserialize(objStreamReader)
        objStreamReader.Close()
        Return p2
    End Function

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
