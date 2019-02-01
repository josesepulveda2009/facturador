Imports System.Data
Imports System.Data.SqlClient

Public Class frmUsuario
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select *  from usuario", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "usuario")
        conexion.Close()

        txtUsuario.DataBindings.Add(New Binding("Text", datos.Tables("usuario"), "usuario"))
        txtContraseña.DataBindings.Add(New Binding("Text", datos.Tables("usuario"), "contraseña"))
        cboNivel.DataBindings.Add(New Binding("Text", datos.Tables("usuario"), "nivel"))
        chkEstado.DataBindings.Add(New Binding("Checked", datos.Tables("usuario"), "estado"))

        dgvUsuario.DataSource = datos.Tables("usuario")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

        txtUsuario.Focus()
        btnInsertar.Enabled = True
        btnNuevo.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtUsuario.Text = String.Empty Or txtContraseña.Text = String.Empty Or cboNivel.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("insert into usuario(usuario, contraseña, nivel, estado) values(@usuario, @contraseña, @nivel, @estado)", conexion)

                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                comando.Parameters.AddWithValue("nivel", cboNivel.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "usuario")
                dgvUsuario.Refresh()
            Catch ex As Exception
                MessageBox.Show("Es posible que este usuario ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtUsuario.Text = String.Empty Or txtContraseña.Text = String.Empty Or cboNivel.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("update usuario set usuario=@usuario, contraseña=@contraseña, nivel=@nivel, estado=@estado where id=@id", conexion)

                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                comando.Parameters.AddWithValue("nivel", cboNivel.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)
                comando.Parameters.AddWithValue("@id", dgvUsuario.CurrentRow.Cells("id").Value)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "usuario")
                dgvUsuario.Refresh()
            Catch ex As Exception
                MessageBox.Show("Es posible que este usuario ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class