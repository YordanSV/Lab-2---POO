Public Class Prenda
    Public Precio As Integer
    Public ImpuestoVentas As Double = 0.13
    Public MontoImpuestoVentas As Double
    Public Cantidad As Double
    Public Subtotal As Double
    Public Total As Double

    Public Sub New(_cantidad As Integer, _precio As Double)
        Precio = _precio
        Cantidad = _cantidad
    End Sub
    Public Sub New()
    End Sub

    Public Sub calcularVenta()
        Try
            Me.Subtotal = Me.Cantidad * Me.Precio
            Me.MontoImpuestoVentas = Math.Round(Me.Subtotal * Me.ImpuestoVentas)
            Me.Total = Me.Subtotal + Me.MontoImpuestoVentas

        Catch ex As Exception
            Throw New Exception("Se ha producido un error al calcular la venta del producto")
        End Try
    End Sub


End Class
