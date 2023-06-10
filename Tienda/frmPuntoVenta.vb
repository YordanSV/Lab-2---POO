Public Class frmPuntoVenta
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
            ' Aquí puedes agregar el código para manejar la selección del valor
        End Sub

    Private Sub frmPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listItem As New List(Of String)()
        listItem.Add("Camisa")
        listItem.Add("Enagua")
        listItem.Add("Jacket")
        listItem.Add("Pantalón")
        listItem.Add("Sudadera")

        ComboBox1.Items.AddRange(listItem.ToArray())
    End Sub

End Class