Imports System
Imports System.Text
Imports System.Security.Cryptography

Public Class EncriptacionClass
    Private Key As String
    Private _cadenaMD5 As String
    Private _cadena3DES As String
    Private IVector() As Byte = {27, 9, 45, 27, 0, 72, 171, 54}

    Public Property cadenaMD5 As String
        Get
            Return _cadenaMD5
        End Get
        Set(ByVal value As String)
            _cadenaMD5 = value.Clone
        End Set
    End Property
    Public Property cadena3DES As String
        Get
            Return _cadena3DES
        End Get
        Set(ByVal value As String)
            _cadena3DES = value.Clone
        End Set
    End Property

    Public Function encryptString(ByVal str As String) As String
        Dim respuesta As String = ""
        Try
            '//Create a new RSA key. This key will encrypt a symmetric key,
            '//which will then be imbedded in the XML document. 

            '//Get a byte array of the str as encryption works on byte blocks
            Dim enc As New ASCIIEncoding
            Dim byteData() As Byte = enc.GetBytes(str)

            '//Create encryption object
            Dim tDes As New TripleDESCryptoServiceProvider()
            Dim md5 As New MD5CryptoServiceProvider()
            tDes.Key = md5.ComputeHash(enc.GetBytes("UNIVERAL_KEY_192"))
            '//Specify Initialisation Vector as encryption key to use
            tDes.IV = IVector
            '//Adds key and IVector to Encrypt object
            Dim ITransform As CryptoAPITransform
            ITransform = tDes.CreateEncryptor()
            cadenaMD5 = Convert.ToBase64String(md5.TransformFinalBlock(enc.GetBytes("UNIVERAL_KEY_192"), 0, enc.GetBytes("UNIVERAL_KEY_192").Length))
            cadena3DES = Convert.ToBase64String(ITransform.TransformFinalBlock(byteData, 0, byteData.Length))
            respuesta = Convert.ToBase64String(ITransform.TransformFinalBlock(byteData, 0, byteData.Length))
        Catch ex As Exception
            respuesta = "ERROR<#:#>" & ex.InnerException.ToString
        End Try
        Return respuesta
    End Function
    Public Function decryptString(ByVal base64_str As String) As String
        Dim respuesta
        Try
            Dim enc As New ASCIIEncoding
            Dim md5 As New MD5CryptoServiceProvider()
            Dim byteData() As Byte = enc.GetBytes(base64_str)
            Dim encData() As Byte = Convert.FromBase64String(base64_str)

            '//Create encryption object
            Dim tDes As New TripleDESCryptoServiceProvider()
            tDes.Key = md5.ComputeHash(enc.GetBytes("UNIVERAL_KEY_192"))
            '//Specify Initialisation Vector as encryption key to use
            tDes.IV = IVector
            'tDes.Key = UNIVERAL_KEY_192
            '//Adds key and IVector to decrypt object
            Dim ITransform As CryptoAPITransform
            ITransform = tDes.CreateDecryptor()
            cadenaMD5 = base64_str
            cadena3DES = Convert.ToBase64String(ITransform.TransformFinalBlock(encData, 0, encData.Length()))
            respuesta = Encoding.ASCII.GetString(ITransform.TransformFinalBlock(encData, 0, encData.Length()))
        Catch ex As Exception
            respuesta = "ERROR<#:#>" & ex.Message
        End Try
        '//Perform as decrypt of encytpted data with above method

        '//Get byte array from string

        Return respuesta
    End Function
End Class
