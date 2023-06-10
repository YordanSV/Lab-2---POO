Public Class frmPuntoVenta

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim listItem As New List(Of String)()
        listItem.Add("Camisa")
        listItem.Add("Enagua")
        listItem.Add("Jacket")
        listItem.Add("Pantalón")
        listItem.Add("Sudadera")

        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(listItem.ToArray())

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigoPrueba As String = "Código de prueba"

        MessageBox.Show(codigoPrueba, "Código de prueba", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class