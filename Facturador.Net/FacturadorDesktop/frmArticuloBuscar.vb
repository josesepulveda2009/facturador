Imports System.Data
Imports System.Data.SqlClient

Public Class frmArticuloBuscar
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmArticuloBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select codigo, descripcion, precio, img, id from articulo where estado = 1", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "articulo")
        conexion.Close()

        cboDescripcion.DataSource = datos.Tables("articulo")
        cboDescripcion.DisplayMember = "descripcion"
        cboDescripcion.ValueMember = "id"
    End Sub

    Private Sub cboDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDescripcion.SelectedIndexChanged
        txtCodigo.Text = cboDescripcion.SelectedItem("codigo").ToString()
        txtPrecio.Text = cboDescripcion.SelectedItem("precio").ToString()
        txtImg.Text = cboDescripcion.SelectedItem("img").ToString()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim cantidad As Integer
        Dim precio As Integer
        Dim total As Integer
        Dim subtotal As Integer

        cantidad = Convert.ToInt16(cboCantidad.Text)
        precio = Convert.ToInt16(txtPrecio.Text)

        If cantidad <= 0 Or cboCantidad.Text = String.Empty Then
            MessageBox.Show("La cantidad no puede estar vacia, ser menor o igual que 0", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            total = cantidad * precio
            frmFactura.dgvFactura.Rows.Add(txtCodigo.Text, cboDescripcion.Text, cboCantidad.Text, txtPrecio.Text, total, cboDescripcion.SelectedValue)

            For Each row In frmFactura.dgvFactura.Rows
                subtotal = subtotal + row.cells("total").value
            Next

            frmFactura.txtSubtotal.Text = subtotal
        End If
    End Sub

    Private Sub txtImg_TextChanged(sender As Object, e As EventArgs) Handles txtImg.TextChanged
        picImg.ImageLocation = txtImg.Text
    End Sub
End Class