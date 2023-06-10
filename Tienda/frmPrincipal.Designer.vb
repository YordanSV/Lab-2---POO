<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiendaToolStripMenuItem
        '
        Me.TiendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.RegistrarVentaToolStripMenuItem})
        Me.TiendaToolStripMenuItem.Name = "TiendaToolStripMenuItem"
        Me.TiendaToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.TiendaToolStripMenuItem.Text = "Tienda"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'RegistrarVentaToolStripMenuItem
        '
        Me.RegistrarVentaToolStripMenuItem.Name = "RegistrarVentaToolStripMenuItem"
        Me.RegistrarVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarVentaToolStripMenuItem.Text = "Registrar Venta"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TiendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVentaToolStripMenuItem As ToolStripMenuItem
End Class
