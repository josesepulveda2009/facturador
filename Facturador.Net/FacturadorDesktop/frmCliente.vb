Imports System.Data
Imports System.Data.SqlClient

Public Class frmCliente
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select * from cliente order by id desc", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "cliente")
        conexion.Close()

        txtNombres.DataBindings.Add(New Binding("Text", datos.Tables("cliente"), "nombres"))
        txtCedula.DataBindings.Add(New Binding("Text", datos.Tables("cliente"), "cedula"))
        txtDireccion.DataBindings.Add(New Binding("Text", datos.Tables("cliente"), "direccion"))
        txtTelefonos.DataBindings.Add(New Binding("Text", datos.Tables("cliente"), "telefonos"))
        chkEstado.DataBindings.Add(New Binding("Checked", datos.Tables("cliente"), "estado"))

        dgvCliente.DataSource = datos.Tables("CLIENTE")
        dgvBuscar.DataSource = datos.Tables("CLIENTE")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

        txtNombres.Focus()
        btnInsertar.Enabled = True
        btnNuevo.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtNombres.Text = String.Empty Or txtCedula.Text = String.Empty Or txtTelefonos.Text = String.Empty Or txtDireccion.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("insert into cliente(nombres, cedula, direccion, telefonos, estado) values(@nombres, @cedula, @direccion, @telefonos, @estado)", conexion)

                comando.Parameters.AddWithValue("@nombres", txtNombres.Text)
                comando.Parameters.AddWithValue("@cedula", txtCedula.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@telefonos", txtTelefonos.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "cliente")
                dgvCliente.Refresh()

                btnNuevo.Enabled = True
                btnInsertar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Es posible que este cliente ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombres.Text = String.Empty Or txtCedula.Text = String.Empty Or txtTelefonos.Text = String.Empty Or txtDireccion.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("update cliente set nombres=@nombres, cedula=@cedula, direccion=@direccion, telefonos=@telefonos, estado=@estado where id=@id", conexion)

                comando.Parameters.AddWithValue("@nombres", txtNombres.Text)
                comando.Parameters.AddWithValue("@cedula", txtCedula.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@telefonos", txtTelefonos.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)
                comando.Parameters.AddWithValue("@id", dgvCliente.CurrentRow.Cells("id").Value)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "cliente")
                dgvCliente.Refresh()
            Catch ex As Exception
                MessageBox.Show("Es posible que este cliente ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim sql As String
        Dim tabla As DataTable

        If cboBuscar.Text = "Nombres" Then
            sql = "select * from cliente where nombres like '%" + txtBuscar.Text + "%'"
            adaptador = New SqlDataAdapter(sql, conexion)

            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvBuscar.DataSource = tabla

        ElseIf cboBuscar.Text = "Cedula" Then
            sql = "select * from cliente where cedula like '%" + txtBuscar.Text + "%'"
            adaptador = New SqlDataAdapter(sql, conexion)

            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvBuscar.DataSource = tabla
        End If
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        frmFactura.Show()
        frmFactura.cboNombresCliente.Text = txtNombres.Text

        Me.Close()
    End Sub
End Class