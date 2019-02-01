Imports System.Data
Imports System.Data.SqlClient

Public Class frmInformeFacturaFechas
    Dim conexion As SqlConnection
    Dim adaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim datos As DataSet
    Dim res As Integer

    Private Sub frmInformeFacturaFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConexionBase.Conectar())
        adaptador = New SqlDataAdapter("select nombres, factura, fecha, subtotal, factura.estado, factura.fechaHoraDig, factura.id from cliente inner join factura on cliente.id = factura.cliente order by fecha desc", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "factura")
        conexion.Close()

        dgvFactura.DataSource = datos.Tables("factura")
    End Sub

    Private Sub dgvFactura_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFactura.SelectionChanged
        adaptador = New SqlDataAdapter("select codigo, descripcion, cantidad, detalle.precio, total from articulo inner join detalle on articulo.id = detalle.articulo where factura = '" & dgvFactura.CurrentRow.Cells(6).Value.ToString + "' ", conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos, "detalle")
        conexion.Close()

        dgvDetalle.DataSource = datos.Tables("detalle")
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        conexion = New SqlConnection(ConexionBase.Conectar())
        comando = New SqlCommand("select nombres, factura, fecha, subtotal, factura.estado, factura.fechaHoraDig, factura.id from cliente inner join factura on cliente.id = factura.cliente where fecha between '" + dtpFechaIncial.Text + "' and '" + dtpFechaFinal.Text + "' order by fecha Desc", conexion)

        conexion.Open()

        comando.ExecuteNonQuery()
        datos = New DataSet()
        adaptador = New SqlDataAdapter(comando)
        adaptador.Fill(datos, "factura")

        conexion.Close()

        dgvFactura.DataSource = datos.Tables("factura")
    End Sub
End Class