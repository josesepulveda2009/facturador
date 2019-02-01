<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNombresCliente = New System.Windows.Forms.ComboBox()
        Me.txtTelefonosCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedulaCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.txtTelefonosEmpresa = New System.Windows.Forms.TextBox()
        Me.txtDireccionEmpresa = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarFactura = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboNombresCliente)
        Me.GroupBox1.Controls.Add(Me.txtTelefonosCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDireccionCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCedulaCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE"
        '
        'cboNombresCliente
        '
        Me.cboNombresCliente.FormattingEnabled = True
        Me.cboNombresCliente.Location = New System.Drawing.Point(16, 28)
        Me.cboNombresCliente.Name = "cboNombresCliente"
        Me.cboNombresCliente.Size = New System.Drawing.Size(259, 21)
        Me.cboNombresCliente.TabIndex = 16
        '
        'txtTelefonosCliente
        '
        Me.txtTelefonosCliente.Location = New System.Drawing.Point(292, 69)
        Me.txtTelefonosCliente.Name = "txtTelefonosCliente"
        Me.txtTelefonosCliente.Size = New System.Drawing.Size(259, 20)
        Me.txtTelefonosCliente.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefonos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombres"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(16, 69)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(259, 59)
        Me.txtDireccionCliente.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Direccion"
        '
        'txtCedulaCliente
        '
        Me.txtCedulaCliente.Location = New System.Drawing.Point(292, 29)
        Me.txtCedulaCliente.Name = "txtCedulaCliente"
        Me.txtCedulaCliente.Size = New System.Drawing.Size(259, 20)
        Me.txtCedulaCliente.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cedula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picLogo)
        Me.GroupBox2.Controls.Add(Me.txtLogo)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFactura)
        Me.GroupBox2.Controls.Add(Me.txtTelefonosEmpresa)
        Me.GroupBox2.Controls.Add(Me.txtDireccionEmpresa)
        Me.GroupBox2.Controls.Add(Me.txtNit)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 163)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPRESA"
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(12, 45)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(126, 105)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'txtLogo
        '
        Me.txtLogo.Location = New System.Drawing.Point(12, 130)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.Size = New System.Drawing.Size(100, 20)
        Me.txtLogo.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(441, 119)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Factura No"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(441, 80)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 9
        '
        'txtTelefonosEmpresa
        '
        Me.txtTelefonosEmpresa.Location = New System.Drawing.Point(163, 119)
        Me.txtTelefonosEmpresa.Name = "txtTelefonosEmpresa"
        Me.txtTelefonosEmpresa.Size = New System.Drawing.Size(259, 20)
        Me.txtTelefonosEmpresa.TabIndex = 8
        Me.txtTelefonosEmpresa.Text = "TELEFONOS EMPRESA"
        Me.txtTelefonosEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccionEmpresa
        '
        Me.txtDireccionEmpresa.Location = New System.Drawing.Point(163, 71)
        Me.txtDireccionEmpresa.Multiline = True
        Me.txtDireccionEmpresa.Name = "txtDireccionEmpresa"
        Me.txtDireccionEmpresa.Size = New System.Drawing.Size(259, 42)
        Me.txtDireccionEmpresa.TabIndex = 7
        Me.txtDireccionEmpresa.Text = "DIRECCION EMPRESA"
        Me.txtDireccionEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(144, 45)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(292, 20)
        Me.txtNit.TabIndex = 6
        Me.txtNit.Text = "NIT"
        Me.txtNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(422, 20)
        Me.txtNombre.TabIndex = 5
        Me.txtNombre.Text = "NOMBRE EMPRESA"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.btnProducto)
        Me.GroupBox3.Controls.Add(Me.dgvFactura)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 204)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ARTICULOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(399, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(451, 168)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 3
        Me.txtSubtotal.Text = "0"
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(12, 166)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(120, 23)
        Me.btnProducto.TabIndex = 5
        Me.btnProducto.Text = "Nuevo producto"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'dgvFactura
        '
        Me.dgvFactura.AllowUserToAddRows = False
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descripcion, Me.Cantidad, Me.precio, Me.Total, Me.articulo})
        Me.dgvFactura.Location = New System.Drawing.Point(12, 19)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFactura.Size = New System.Drawing.Size(545, 141)
        Me.dgvFactura.TabIndex = 3
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'articulo
        '
        Me.articulo.HeaderText = "articulo"
        Me.articulo.Name = "articulo"
        '
        'btnGuardarFactura
        '
        Me.btnGuardarFactura.Location = New System.Drawing.Point(235, 538)
        Me.btnGuardarFactura.Name = "btnGuardarFactura"
        Me.btnGuardarFactura.Size = New System.Drawing.Size(120, 23)
        Me.btnGuardarFactura.TabIndex = 3
        Me.btnGuardarFactura.Text = "Guardar factura"
        Me.btnGuardarFactura.UseVisualStyleBackColor = True
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 569)
        Me.Controls.Add(Me.btnGuardarFactura)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboNombresCliente As ComboBox
    Friend WithEvents txtTelefonosCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCedulaCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnProducto As Button
    Friend WithEvents dgvFactura As DataGridView
    Friend WithEvents txtTelefonosEmpresa As TextBox
    Friend WithEvents txtDireccionEmpresa As TextBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents btnGuardarFactura As Button
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents articulo As DataGridViewTextBoxColumn
End Class
