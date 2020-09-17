Imports System.Xml.Serialization
Public Class clsProduct

    Private pin As Integer
    Private tarjeta As Integer
    Private mensaje As String
    Private Retiro As Integer
    Private Saldo As Integer
    Private Nombre As String
    Private Cuenta As Integer
    Private Datos As String
    Private Proceso As String

    Public Property nproceso As String
        Get
            Return Proceso
        End Get
        Set(ByVal value As String)
            Proceso = value
        End Set
    End Property

    Public Property ndatos As String
        Get
            Return Datos
        End Get
        Set(ByVal value As String)
            Datos = value
        End Set
    End Property

    Public Property ncuenta As Integer
        Get
            Return Cuenta
        End Get
        Set(ByVal value As Integer)
            Cuenta = value
        End Set
    End Property


    Public Property nnombre As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property
    Public Property nsaldo As Integer
        Get
            Return Saldo
        End Get
        Set(ByVal value As Integer)
            Saldo = value
        End Set
    End Property

    Public Property npin() As Integer
        Get
            Return pin
        End Get
        Set(ByVal Value As Integer)
            pin = Value
        End Set
    End Property

    Public Property ntarjeta As Integer
        Get
            Return tarjeta
        End Get
        Set(ByVal Value As Integer)
            tarjeta = Value
        End Set
    End Property

    Public Property ndmensaje() As String
        Get
            Return mensaje
        End Get
        Set(ByVal Value As String)
            mensaje = Value
        End Set
    End Property

    Public Property nRetiro() As Integer
        Get
            Return Retiro
        End Get
        Set(ByVal Value As Integer)
            Retiro = Value
        End Set
    End Property


End Class

