Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmLogin
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexion = New SqlConnection(ConexionBase.Conectar())
        conexion.Open()

        comando = New SqlCommand("select count(*) from usuario where usuario=@usuario and contraseña=@contraseña", conexion)
        comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text)

        res = comando.ExecuteScalar()
        conexion.Close()

        If res >= 1 Then
            frmMenu.Show()
            frmMenu.lblUsuario.Text = txtUsuario.Text
        Else
            MessageBox.Show("Usuario o contraseña errados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Focus()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de salir", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class