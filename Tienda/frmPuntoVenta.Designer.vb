<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPuntoVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(89, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.amount, Me.price, Me.subtotal, Me.salesTax, Me.total})
        Me.DataGridView1.Location = New System.Drawing.Point(89, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(641, 147)
        Me.DataGridView1.TabIndex = 2
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        '
        'salesTax
        '
        Me.salesTax.HeaderText = "Sales tax"
        Me.salesTax.Name = "salesTax"
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(89, 60)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sales tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(486, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "0"
        '
        'frmPuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmPuntoVenta"
        Me.Text = "frmPuntoVenta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents salesTax As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
