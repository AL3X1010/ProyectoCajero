Imports System.Security.Cryptography
Imports System.Text
'Imports ClienteSeguridad.Form1
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data.SqlClient
Public Class Retirar
    Dim WithEvents WinSockCliente As New Cliente
    Private demo As Threading.Thread = Nothing
    Dim IP1 As String
    Dim port1 As String
    Dim Texto As String
    Delegate Sub SetTextCallback(ByVal [text1] As String)
    Public Function serializar(ByVal p As clsProduct) As String
        Dim objStreamWriter As New StreamWriter("D:\Apoyo seguridad\ejemplo2.xml")
        Dim x As New XmlSerializer(p.GetType)
        Dim xml As String
        x.Serialize(objStreamWriter, p)
        objStreamWriter.Close()
        xml = My.Computer.FileSystem.ReadAllText("D:\Apoyo seguridad\ejemplo2.xml")
        Return xml
    End Function
    Public Function deserializar() As clsProduct
        Dim p As New clsProduct()
        'Deserialize text file to a new object.
        Dim objStreamReader As New StreamReader("D:\Apoyo seguridad\ejemplo2.xml")
        Dim x As New XmlSerializer(p.GetType)
        Dim p2 As New clsProduct()
        p2 = x.Deserialize(objStreamReader)
        objStreamReader.Close()
        Return p2
    End Function

    Private Sub Retirar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fun As New EncriptacionClass
        Dim mensaje As String
        Dim cls As New clsProduct
        cls.nRetiro = CInt(TextRetiro.Text)
        cls.ntarjeta = usuario
        cls.nproceso = "Retiro Monto"
        cls.ndmensaje = "Retirar"
        serializar(cls)
        mensaje = fun.encryptString(serializar(cls))
        WinSockCliente.EnviarDatos(mensaje)
        Transaccion.Show()
        Me.Hide()
    End Sub

    Private Sub TextRetiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextRetiro.KeyPress
        'Validacion solo numeros 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRetiro.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Transaccion.Show()
        Me.Hide()
    End Sub
End Class