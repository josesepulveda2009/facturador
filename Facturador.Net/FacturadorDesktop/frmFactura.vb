Imports System.Data
Imports System.Data.SqlClient

Public Class frmFactura
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim adaptadorCliente As SqlDataAdapter
    Dim datos As DataSet
    Dim comando As SqlCommand
    Dim transaccion As SqlTransaction

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select [nombre o razon social] as nombre, nit, direccion, telefonos, logo from empresa", conexion)
        adaptadorCliente = New SqlDataAdapter("select nombres, cedula, telefonos, direccion, id from cliente where estado = 1", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "empresa")
        adaptadorCliente.Fill(datos, "cliente")
        conexion.Close()

        txtNombre.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nombre"))
        txtNit.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "nit"))
        txtDireccionEmpresa.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "direccion"))
        txtTelefonosEmpresa.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "telefonos"))
        txtLogo.DataBindings.Add(New Binding("Text", datos.Tables("empresa"), "logo"))

        picLogo.ImageLocation = txtLogo.Text

        cboNombresCliente.DataSource = datos.Tables("cliente")
        cboNombresCliente.DisplayMember = "nombres"
        cboNombresCliente.ValueMember = "id"
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmArticuloBuscar.Show()
    End Sub

    Private Sub cboNombresCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombresCliente.SelectedIndexChanged
        txtCedulaCliente.Text = cboNombresCliente.SelectedItem("cedula").ToString
        txtDireccionCliente.Text = cboNombresCliente.SelectedItem("direccion").ToString()
        txtTelefonosCliente.Text = cboNombresCliente.SelectedItem("telefonos").ToString()
    End Sub

    Private Sub txtLogo_TextChanged(sender As Object, e As EventArgs) Handles txtLogo.TextChanged

    End Sub

    Private Sub btnGuardarFactura_Click(sender As Object, e As EventArgs) Handles btnGuardarFactura.Click
        If dgvFactura.Rows.Count <= 0 Or txtFactura.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            conexion = New SqlConnection(ConexionBase.Conectar())
            conexion.Open()

            transaccion = conexion.BeginTransaction()

            Try
                comando = New SqlCommand("insert into factura(factura, fecha, subtotal, estado, cliente) values(@factura, @fecha, @subtotal, @estado, @cliente)", conexion)
                comando.Parameters.AddWithValue("@factura", txtFactura.Text)
                comando.Parameters.AddWithValue("@fecha", DateTimePicker1.Text)
                comando.Parameters.AddWithValue("@subtotal", txtSubtotal.Text)
                comando.Parameters.AddWithValue("@estado", True)
                comando.Parameters.AddWithValue("@cliente", cboNombresCliente.SelectedValue)
                comando.Transaction = transaccion
                comando.ExecuteNonQuery()

                comando = New SqlCommand("select @@IDENTITY", conexion)
                comando.Transaction = transaccion
                Dim idFactura As Integer = comando.ExecuteScalar()

                comando = New SqlCommand("insert into detalle(factura, articulo, cantidad, precio) values(@factura, @articulo, @cantidad, @precio)", conexion)
                comando.Transaction = transaccion

                For Each row As DataGridViewRow In dgvFactura.Rows
                    comando.Parameters.Clear()

                    comando.Parameters.AddWithValue("@factura", idFactura)
                    comando.Parameters.AddWithValue("@articulo", row.Cells("articulo").Value)
                    comando.Parameters.AddWithValue("@cantidad", row.Cells("cantidad").Value)
                    comando.Parameters.AddWithValue("@precio", row.Cells("precio").Value)

                    comando.ExecuteNonQuery()
                Next

                transaccion.Commit()
                MessageBox.Show("Factura " & txtFactura.Text & " guardada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                transaccion.Rollback()
                MessageBox.Show("Es posible que esta factura ya este registrada, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            conexion.Close()

            For i As Integer = dgvFactura.Rows.Count - 1 To 0 Step -1
                dgvFactura.Rows.RemoveAt(i)
            Next

            txtFactura.Text = String.Empty
            txtSubtotal.Text = "0"
            txtFactura.Focus()
        End If
    End Sub
End Class