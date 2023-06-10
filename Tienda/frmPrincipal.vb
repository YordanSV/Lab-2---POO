Public Class frmPrincipal
    Private Sub RegistrarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentaToolStripMenuItem.Click
        Dim frmPuntoVenta As New frmPuntoVenta()
        frmPuntoVenta.Show() ' Mostrar el formulario
    End Sub
End Class
