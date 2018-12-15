<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim FechaCompraLabel As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim ComprasLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DatabaseDataSet = New WindowsApp1.DatabaseDataSet()
        Me.CompraYVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraYVentaTableAdapter = New WindowsApp1.DatabaseDataSetTableAdapters.CompraYVentaTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CompraYVentaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompraYVentaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.FechaCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BonosTextBox = New System.Windows.Forms.TextBox()
        Me.ComprasTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        CodigoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        FechaCompraLabel = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        ComprasLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraYVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraYVentaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompraYVentaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(16, 155)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 26
        CodigoLabel.Text = "Codigo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(16, 182)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 27
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(16, 206)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 28
        ApellidoLabel.Text = "Apellido:"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(16, 232)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 29
        DPILabel.Text = "DPI:"
        '
        'FechaCompraLabel
        '
        FechaCompraLabel.AutoSize = True
        FechaCompraLabel.Location = New System.Drawing.Point(16, 259)
        FechaCompraLabel.Name = "FechaCompraLabel"
        FechaCompraLabel.Size = New System.Drawing.Size(79, 13)
        FechaCompraLabel.TabIndex = 30
        FechaCompraLabel.Text = "Fecha Compra:"
        '
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(16, 289)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(23, 13)
        BonosLabel.TabIndex = 32
        BonosLabel.Text = "Nit:"
        '
        'ComprasLabel
        '
        ComprasLabel.AutoSize = True
        ComprasLabel.Location = New System.Drawing.Point(16, 316)
        ComprasLabel.Name = "ComprasLabel"
        ComprasLabel.Size = New System.Drawing.Size(51, 13)
        ComprasLabel.TabIndex = 33
        ComprasLabel.Text = "Compras:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(16, 342)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 34
        TotalLabel.Text = "Total:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(427, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 100)
        Me.Panel1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Compras y Ventas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Free PSD Website Template"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 42)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "MAGIC"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 49)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "APP"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(510, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 60)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(448, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 59)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(523, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 31)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraYVentaBindingSource
        '
        Me.CompraYVentaBindingSource.DataMember = "CompraYVenta"
        Me.CompraYVentaBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CompraYVentaTableAdapter
        '
        Me.CompraYVentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CompraYVentaTableAdapter = Me.CompraYVentaTableAdapter
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompraYVentaBindingNavigator
        '
        Me.CompraYVentaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompraYVentaBindingNavigator.BindingSource = Me.CompraYVentaBindingSource
        Me.CompraYVentaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CompraYVentaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CompraYVentaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CompraYVentaBindingNavigatorSaveItem})
        Me.CompraYVentaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompraYVentaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CompraYVentaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CompraYVentaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CompraYVentaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CompraYVentaBindingNavigator.Name = "CompraYVentaBindingNavigator"
        Me.CompraYVentaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CompraYVentaBindingNavigator.Size = New System.Drawing.Size(714, 25)
        Me.CompraYVentaBindingNavigator.TabIndex = 26
        Me.CompraYVentaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CompraYVentaBindingNavigatorSaveItem
        '
        Me.CompraYVentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CompraYVentaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompraYVentaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompraYVentaBindingNavigatorSaveItem.Name = "CompraYVentaBindingNavigatorSaveItem"
        Me.CompraYVentaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CompraYVentaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(65, 152)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 27
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(69, 179)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 28
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(69, 203)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 29
        '
        'DPITextBox
        '
        Me.DPITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "DPI", True))
        Me.DPITextBox.Location = New System.Drawing.Point(50, 229)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DPITextBox.TabIndex = 30
        '
        'FechaCompraDateTimePicker
        '
        Me.FechaCompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CompraYVentaBindingSource, "FechaCompra", True))
        Me.FechaCompraDateTimePicker.Location = New System.Drawing.Point(101, 255)
        Me.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker"
        Me.FechaCompraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaCompraDateTimePicker.TabIndex = 31
        '
        'BonosTextBox
        '
        Me.BonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Bonos", True))
        Me.BonosTextBox.Location = New System.Drawing.Point(62, 286)
        Me.BonosTextBox.Name = "BonosTextBox"
        Me.BonosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BonosTextBox.TabIndex = 33
        '
        'ComprasTextBox
        '
        Me.ComprasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Compras", True))
        Me.ComprasTextBox.Location = New System.Drawing.Point(73, 313)
        Me.ComprasTextBox.Name = "ComprasTextBox"
        Me.ComprasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ComprasTextBox.TabIndex = 34
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraYVentaBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(56, 339)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 35
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 432)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(ComprasLabel)
        Me.Controls.Add(Me.ComprasTextBox)
        Me.Controls.Add(BonosLabel)
        Me.Controls.Add(Me.BonosTextBox)
        Me.Controls.Add(FechaCompraLabel)
        Me.Controls.Add(Me.FechaCompraDateTimePicker)
        Me.Controls.Add(DPILabel)
        Me.Controls.Add(Me.DPITextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.CompraYVentaBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Compras y Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraYVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraYVentaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompraYVentaBindingNavigator.ResumeLayout(False)
        Me.CompraYVentaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CompraYVentaBindingSource As BindingSource
    Friend WithEvents CompraYVentaTableAdapter As DatabaseDataSetTableAdapters.CompraYVentaTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompraYVentaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CompraYVentaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents DPITextBox As TextBox
    Friend WithEvents FechaCompraDateTimePicker As DateTimePicker
    Friend WithEvents BonosTextBox As TextBox
    Friend WithEvents ComprasTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
End Class
