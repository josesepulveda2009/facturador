﻿Public Class frmRpFactura
    Private Sub frmRpFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataJsvDataSet.SQLFACTURAS' Puede moverla o quitarla según sea necesario.
        Me.SQLFACTURASTableAdapter.Fill(Me.DataJsvDataSet.SQLFACTURAS)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class