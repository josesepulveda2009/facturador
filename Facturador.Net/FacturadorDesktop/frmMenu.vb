Public Class frmMenu
    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        frmEmpresa.MdiParent = Me
        frmEmpresa.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Esta seguro de salir", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        frmArticulo.MdiParent = Me
        frmArticulo.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCliente.MdiParent = Me
        frmCliente.Show()
    End Sub

    Private Sub GenerarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarFacturaToolStripMenuItem.Click
        frmFactura.MdiParent = Me
        frmFactura.Show()
    End Sub

    Private Sub FacturaXFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaXFechasToolStripMenuItem.Click
        frmInformeFacturaFechas.MdiParent = Me
        frmInformeFacturaFechas.Show()
    End Sub

    Private Sub FacturaXClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaXClientesToolStripMenuItem.Click
        frmInformeFacturaClientes.MdiParent = Me
        frmInformeFacturaClientes.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lblFecha.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class