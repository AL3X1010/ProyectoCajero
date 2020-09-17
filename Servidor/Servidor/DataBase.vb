Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class DataBase
    Private conex As SqlClient.SqlConnection
    Private comando As SqlClient.SqlCommand, lector As SqlClient.SqlDataReader
    Private adaptador As SqlClient.SqlDataAdapter, constructor As SqlClient.SqlCommandBuilder
    Private sett As DataSet

    Public Function Conexion() As SqlClient.SqlConnection
        conex = New SqlClient.SqlConnection
        conex.ConnectionString = ("server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true")
        Return conex
    End Function

    Public Function Login(ByVal ds As clsProduct) As String
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("select * from tarjeta where numero_tarjeta=@ntarjeta and pin_tarjeta=@pin", conn)
            Dim datar As SqlDataReader

            comm.Parameters.AddWithValue("@ntarjeta", ds.ntarjeta)
            comm.Parameters.AddWithValue("@pin", ds.npin)

            conn.Open()
            datar = comm.ExecuteReader()

            If datar.Read() Then
                Return datar(0).ToString
            Else
                Return "Incorrecto"
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return "Incorrecto"
        End Try
    End Function
    'retirar
    Public Function Retirar(ByVal ds As clsProduct) As String
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("update tarjeta  set saldo = saldo - @retiro where numero_tarjeta = @ntarjeta", conn)
            Dim datar As SqlDataReader

            comm.Parameters.AddWithValue("@ntarjeta", ds.ntarjeta)
            comm.Parameters.AddWithValue("@retiro", ds.nRetiro)

            conn.Open()
            'datar = comm.ExecuteReader()


            If comm.ExecuteNonQuery Then
                Return "Correcto"
            Else
                Return "Denegar"
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return "Incorrecto"
        End Try
    End Function
    ''cambiar pin
    Public Function CambiarPin(ByVal ds As clsProduct) As String
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("update tarjeta  set pin_tarjeta = " & ds.npin & " where numero_tarjeta = " & ds.ntarjeta & "", conn)

            conn.Open()
            'datar = comm.ExecuteReader()
            If comm.ExecuteNonQuery Then
                Return True
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return "Incorrecto"
        End Try
    End Function
    'consulta saldo
    Public Function SaldoActual(ByVal ds As clsProduct) As SqlDataReader
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("SELECT dbo.cliente.numero_cuenta, dbo.tarjeta.saldo, dbo.cliente.nombre FROM dbo.tarjeta INNER JOIN dbo.cliente ON dbo.tarjeta.numero_cuenta = dbo.cliente.numero_cuenta WHERE (dbo.tarjeta.numero_tarjeta = @ntarjeta)", conn)
            Dim datar As SqlDataReader

            comm.Parameters.AddWithValue("@ntarjeta", ds.ntarjeta)
            conn.Open()
            datar = comm.ExecuteReader()
            'If comm.ExecuteNonQuery Then
            If datar.Read Then
                'ds.ncuenta = datar(0).ToString
                Return datar
                'Return datar(1).ToString
                'Return ds.ncuenta & ds.nsaldo
            Else

            End If
            Return Nothing
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return Nothing
        End Try
    End Function
    'transferencias entre cuentas
    Public Function TransferenciaD(ByVal ds As clsProduct) As String
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("update tarjeta  set saldo = saldo - @retiro where numero_tarjeta = @ntarjeta ;update tarjeta  set saldo = saldo + @retiro  where numero_cuenta = @cuenta ", conn)


            comm.Parameters.AddWithValue("@ntarjeta", ds.ntarjeta)
            comm.Parameters.AddWithValue("@retiro", ds.nRetiro)
            comm.Parameters.AddWithValue("@cuenta", ds.ncuenta)


            conn.Open()
            'datar = comm.ExecuteReader()


            If comm.ExecuteNonQuery Then
                Return "Correcto"
            Else
                Return "Denegar"
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return "Incorrecto"
        End Try
    End Function

    'Bitacoras
    Public Sub BitacoraServer(ByVal ds As clsProduct)
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("insert into bitacora values (@fecha,@hora,@usuario,@Operacion,@monto,@saldob )", conn)
            Dim fecha As Date = Date.Now.ToShortDateString

            comm.Parameters.AddWithValue("@fecha", fecha)
            comm.Parameters.AddWithValue("@hora", Date.Now.ToShortTimeString.ToString)
            comm.Parameters.AddWithValue("@usuario", ds.ntarjeta)
            comm.Parameters.AddWithValue("@Operacion", ds.nproceso)
            comm.Parameters.AddWithValue("@monto", ds.nRetiro)
            comm.Parameters.AddWithValue("@saldob", ds.nsaldo)

            conn.Open()
            comm.ExecuteNonQuery()
            'datar = comm.ExecuteReader()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion De Bitacoras")

        End Try
    End Sub
    Public Function Cuenta(ByVal ds As clsProduct) As String
        Try
            Dim cadena As String = "server=Kratos\ SQLEXPRESS;database=cajero;Integrated Security=true"
            Dim conn As New SqlConnection(cadena)
            Dim comm As New SqlCommand("select c.numero_cuenta from tarjeta t, cliente c where t.numero_tarjeta = @ntarjeta  ", conn)
            Dim datar As SqlDataReader

            comm.Parameters.AddWithValue("@ntarjeta", ds.ntarjeta)
            conn.Open()
            datar = comm.ExecuteReader()
            'If comm.ExecuteNonQuery Then
            If datar.Read Then
                ds.ncuenta = datar(0).ToString
                'ds.nsaldo = datar(1).ToString
                Return datar(0).ToString
                'Return datar(1).ToString
                'Return ds.ncuenta & ds.nsaldo
            Else
                Return "Incorrecto"
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error De Conexion")
            Return "Incorrecto"
        End Try
    End Function
End Class
