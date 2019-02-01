Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmInicio
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(barra.Handle, 1040, 2, 0)

        Using conexion = New SqlConnection(ConexionBase.Conectar())
            conexion.Open()
            Using comando = New SqlCommand("select [nombre o razon social] as nombre, nit, direccion, telefonos, logo from empresa", conexion)
                comando.CommandType = CommandType.Text
                Using adaptador = New SqlDataAdapter(comando)
                    Using datos = New DataSet()
                        adaptador.Fill(datos, "empresa")
                        txtNombre.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nombre"))
                        txtNit.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nit"))
                        txtTelefonos.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "telefonos"))
                        txtDireccion.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "direccion"))
                        txtLogo.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "logo"))

                        picLogo.ImageLocation = txtLogo.Text
                        frmLogin.picLogo.ImageLocation = txtLogo.Text
                    End Using
                End Using
            End Using
        End Using

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        barra.Increment(2)
        lblBarra.Text = "Cargando . . . " & barra.Value & " %"

        If barra.Value = 100 Then
            Timer1.Enabled = False
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class
