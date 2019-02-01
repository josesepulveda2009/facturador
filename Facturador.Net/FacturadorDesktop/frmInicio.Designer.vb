<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.barra = New System.Windows.Forms.ProgressBar()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBarra = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barra
        '
        Me.barra.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.barra.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.barra.Location = New System.Drawing.Point(12, 484)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(760, 65)
        Me.barra.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(12, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(760, 17)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.SystemColors.Control
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.Location = New System.Drawing.Point(12, 38)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(760, 17)
        Me.txtNit.TabIndex = 2
        Me.txtNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BackColor = System.Drawing.SystemColors.Control
        Me.txtTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonos.Location = New System.Drawing.Point(12, 64)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(760, 17)
        Me.txtTelefonos.TabIndex = 3
        Me.txtTelefonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Control
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(12, 90)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(760, 17)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLogo
        '
        Me.txtLogo.Location = New System.Drawing.Point(12, 529)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.Size = New System.Drawing.Size(760, 20)
        Me.txtLogo.TabIndex = 5
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(169, 119)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(457, 339)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
        '
        'lblBarra
        '
        Me.lblBarra.AutoSize = True
        Me.lblBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarra.Location = New System.Drawing.Point(341, 465)
        Me.lblBarra.Name = "lblBarra"
        Me.lblBarra.Size = New System.Drawing.Size(86, 16)
        Me.lblBarra.TabIndex = 7
        Me.lblBarra.Text = "Cargando . . ."
        '
        'Timer1
        '
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 556)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.lblBarra)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtLogo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barra As ProgressBar
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents txtTelefonos As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBarra As Label
    Friend WithEvents Timer1 As Timer
End Class
