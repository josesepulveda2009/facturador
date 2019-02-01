Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmEmpresa
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conexion = New SqlConnection(ConexionBase.Conectar())
            conexion.Open()
            Using comando = New SqlCommand("select [nombre o razon social] as nombre, nit, direccion, telefonos, representante, logo, id from empresa", conexion)
                comando.CommandType = CommandType.Text
                Using adaptador = New SqlDataAdapter(comando)
                    Using datos = New DataSet()
                        adaptador.Fill(datos, "empresa")
                        txtRazonSocial.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nombre"))
                        txtNit.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nit"))
                        txtTelefonos.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "telefonos"))
                        txtDireccion.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "direccion"))
                        txtLogo.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "logo"))
                        txtRepresentante.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "representante"))
                        txtId.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "id"))
                        picLogo.ImageLocation = txtLogo.Text
                        frmLogin.picLogo.ImageLocation = txtLogo.Text

                        Me.Text = datos.Tables("empresa").TableName.ToUpper() & " - " & txtRazonSocial.Text
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim open As New OpenFileDialog()
        open.ShowDialog()

        txtLogo.Text = open.FileName
        picLogo.ImageLocation = txtLogo.Text
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using conexion = New SqlConnection(ConexionBase.Conectar())
            Using comando = New SqlCommand("update empresa set [nombre o razon social]=@nombre, nit=@nit, telefonos=@telefonos, direccion=@direccion, logo=@logo, representante=@representante where id=@id", conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@nombre", txtRazonSocial.Text)
                comando.Parameters.AddWithValue("@nit", txtNit.Text)
                comando.Parameters.AddWithValue("@telefonos", txtTelefonos.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@logo", txtLogo.Text)
                comando.Parameters.AddWithValue("@representante", txtRepresentante.Text)
                comando.Parameters.AddWithValue("@id", txtId.Text)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()
            End Using

            MessageBox.Show("Datos de empresa actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub
End Class