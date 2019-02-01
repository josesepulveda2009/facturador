Imports System.Data
Imports System.Data.SqlClient

Public Class frmArticulo

    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select * from articulo order by id desc", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "articulo")
        conexion.Close()

        txtImg.DataBindings.Add(New Binding("Text", datos.Tables("articulo"), "img"))
        txtCodigo.DataBindings.Add(New Binding("Text", datos.Tables("articulo"), "codigo"))
        txtDescripcion.DataBindings.Add(New Binding("Text", datos.Tables("articulo"), "descripcion"))
        txtPrecio.DataBindings.Add(New Binding("Text", datos.Tables("articulo"), "precio"))
        chkEstado.DataBindings.Add(New Binding("Checked", datos.Tables("articulo"), "estado"))

        dgvArticulo.DataSource = datos.Tables("articulo")
        dgvBuscar.DataSource = datos.Tables("articulo")
    End Sub

    Private Sub txtImg_TextChanged(sender As Object, e As EventArgs) Handles txtImg.TextChanged
        Call cargarImg(txtImg.Text)
    End Sub

    Private Sub cargarImg(url As String)
        picImg.ImageLocation = url
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim open As New OpenFileDialog()
        open.ShowDialog()

        txtImg.Text = open.FileName

        Call cargarImg(txtImg.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

        txtCodigo.Focus()
        btnInsertar.Enabled = True
        btnNuevo.Enabled = False
        chkEstado.Checked = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtCodigo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtPrecio.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("insert into articulo(img, codigo, descripcion, precio, estado) values(@img, @codigo, @descripcion, @precio, @estado)", conexion)

                comando.Parameters.AddWithValue("@img", txtImg.Text)
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text)
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
                comando.Parameters.AddWithValue("@precio", txtPrecio.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "articulo")
                dgvArticulo.Refresh()

                btnNuevo.Enabled = True
                btnInsertar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Es posible que este articulo ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtPrecio.Text = String.Empty Then
            MessageBox.Show("Debe diligenciar todos los datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conexion = New SqlConnection(ConexionBase.Conectar())
                comando = New SqlCommand("update articulo set img=@img, codigo=codigo, descripcion=@descripcion, precio=@precio, estado=@estado where id=@id", conexion)

                comando.Parameters.AddWithValue("@img", txtImg.Text)
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text)
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
                comando.Parameters.AddWithValue("@precio", txtPrecio.Text)
                comando.Parameters.AddWithValue("@estado", chkEstado.Checked)
                comando.Parameters.AddWithValue("@id", dgvArticulo.CurrentRow.Cells("id").Value)

                conexion.Open()
                res = comando.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(res & " Datos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "articulo")
                dgvArticulo.Refresh()
            Catch ex As Exception
                MessageBox.Show("Es posible que este articulo ya este registrado, verifique nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim sql As String
        Dim tabla As DataTable

        If cboBuscar.Text = "Codigo" Then
            sql = "select * from articulo where codigo like '%" + txtBuscar.Text + "%'"
            adaptador = New SqlDataAdapter(sql, conexion)

            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvBuscar.DataSource = tabla

        ElseIf cboBuscar.Text = "Descripcion" Then
            sql = "select * from articulo where descripcion like '%" + txtBuscar.Text + "%'"
            adaptador = New SqlDataAdapter(sql, conexion)

            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvBuscar.DataSource = tabla
        End If
    End Sub
End Class