Imports BLL

Public Class frmPuntoVenta

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub frmPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ComboBox1.Items
            .Add("Seleccione")
            .Add("Camiseta")
            .Add("Enagua")
            .Add("Jacket")
            .Add("Pantalon")
            .Add("Sudadera")
        End With
        Me.ComboBox1.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidad As Integer = 0
        Try
            cantidad = CInt(Me.txtCantidad.Text)

            If cantidad <= 0 Then Throw New Exception("Cantidad de productos menor o igual a cero")
        Catch ex As Exception
            MessageBox.Show("La cantidad de producto que desea adquirir no es valido. Favor indicar un valorr mayor a cero")
            Exit Sub
        End Try

        Dim listaProductos As New List(Of Dictionary(Of String, Object))()

        ' Agregar productos a la lista
        Dim camiseta As New Dictionary(Of String, Object)()
        camiseta.Add("Camiseta", "Producto 1")
        camiseta.Add("Precio", 173)
        listaProductos.Add(camiseta)

        Dim enagua As New Dictionary(Of String, Object)()
        enagua.Add("Nombre", "Enagua")
        enagua.Add("Precio", 165)
        listaProductos.Add(enagua)

        Dim jacket As New Dictionary(Of String, Object)()
        jacket.Add("Nombre", "Jacket")
        jacket.Add("Precio", 115)
        listaProductos.Add(jacket)

        Dim pantalon As New Dictionary(Of String, Object)()
        pantalon.Add("Nombre", "Pantalon")
        pantalon.Add("Precio", 260)
        listaProductos.Add(pantalon)

        Dim sudadera As New Dictionary(Of String, Object)()
        sudadera.Add("Nombre", "Sudadera")
        sudadera.Add("Precio", 245)
        listaProductos.Add(sudadera)

        Dim strProducto As String = Me.ComboBox1.Text
        Dim iPrenda As Prenda
        Dim productoElegido
        Select Case strProducto
            Case "Seleccione"
                MessageBox.Show("Seleccione un articulo", "Informacion al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Case "Pantalon"
                iPrenda = New Pantalon
                productoElegido = listaProductos(3)
            Case "Camiseta"
                iPrenda = New Camiseta
                productoElegido = listaProductos(0)
            Case "Enagua"
                iPrenda = New Enagua
                productoElegido = listaProductos(1)
            Case "Jacket"
                iPrenda = New Jacket
                productoElegido = listaProductos(2)
            Case "Sudadera"
                iPrenda = New Sudadera
                productoElegido = listaProductos(4)
        End Select

        iPrenda.Cantidad = CInt(txtCantidad.Text)
        iPrenda.Precio = CInt(productoElegido("Precio"))
        iPrenda.calcularVenta()
        DataGridView1.Rows.Add(strProducto, iPrenda.Cantidad, iPrenda.Precio, iPrenda.Subtotal, iPrenda.MontoImpuestoVentas, iPrenda.Total)
        Label4.Text = CStr(CDbl(Label4.Text) + iPrenda.Subtotal)
        Label5.Text = CStr(CDbl(Label5.Text) + iPrenda.MontoImpuestoVentas)
        Label6.Text = CStr(CDbl(Label6.Text) + iPrenda.Total)

    End Sub


End Class