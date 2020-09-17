Imports System
Imports System.Text
Imports System.Security.Cryptography

Public Class EncriptacionClass
    Private IVector() As Byte = {27, 9, 45, 27, 0, 72, 171, 54}

    Public Function encryptString(ByVal str As String) As String
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

        Return Convert.ToBase64String(ITransform.TransformFinalBlock(byteData, 0, byteData.Length))

    End Function
    Public Function decryptString(ByVal base64_str As String) As String
        '//Perform as decrypt of encytpted data with above method

        '//Get byte array from string
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

        Return Encoding.ASCII.GetString(ITransform.TransformFinalBlock(encData, 0, encData.Length()))
    End Function
End Class
