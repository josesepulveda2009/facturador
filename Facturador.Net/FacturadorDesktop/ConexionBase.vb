Imports System.Configuration

Public Class ConexionBase
    Shared cadena As String
    Public Shared Function Conectar() As String
        cadena = ConfigurationManager.ConnectionStrings("cnx").ConnectionString

        Return cadena
    End Function
End Class
