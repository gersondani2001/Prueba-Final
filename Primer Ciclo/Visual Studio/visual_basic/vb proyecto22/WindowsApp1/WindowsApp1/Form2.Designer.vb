<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Dim Apellido_ClienteLabel As System.Windows.Forms.Label
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim CompraLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DatabaseDataSet = New WindowsApp1.DatabaseDataSet()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New WindowsApp1.DatabaseDataSetTableAdapters.RegistroTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.RegistroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.CompraTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Apellido_ClienteLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        CompraLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistroBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Free PSD Website Template"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MAGIC"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 49)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "APP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Registro"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(319, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 100)
        Me.Panel1.TabIndex = 7
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "Registro"
        Me.RegistroBindingSource.DataSource = Me.DatabaseDataSet
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CompraYVentaTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Me.RegistroTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistroBindingNavigator
        '
        Me.RegistroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistroBindingNavigator.BindingSource = Me.RegistroBindingSource
        Me.RegistroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistroBindingNavigatorSaveItem})
        Me.RegistroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistroBindingNavigator.Name = "RegistroBindingNavigator"
        Me.RegistroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistroBindingNavigator.Size = New System.Drawing.Size(606, 25)
        Me.RegistroBindingNavigator.TabIndex = 9
        Me.RegistroBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'RegistroBindingNavigatorSaveItem
        '
        Me.RegistroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistroBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistroBindingNavigatorSaveItem.Name = "RegistroBindingNavigatorSaveItem"
        Me.RegistroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RegistroBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.Location = New System.Drawing.Point(32, 153)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Nombre_ClienteLabel.TabIndex = 9
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(120, 150)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_ClienteTextBox.TabIndex = 10
        '
        'Apellido_ClienteLabel
        '
        Apellido_ClienteLabel.AutoSize = True
        Apellido_ClienteLabel.Location = New System.Drawing.Point(32, 180)
        Apellido_ClienteLabel.Name = "Apellido_ClienteLabel"
        Apellido_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Apellido_ClienteLabel.TabIndex = 10
        Apellido_ClienteLabel.Text = "Apellido Cliente:"
        '
        'Apellido_ClienteTextBox
        '
        Me.Apellido_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Apellido_Cliente", True))
        Me.Apellido_ClienteTextBox.Location = New System.Drawing.Point(120, 177)
        Me.Apellido_ClienteTextBox.Name = "Apellido_ClienteTextBox"
        Me.Apellido_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apellido_ClienteTextBox.TabIndex = 11
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.Location = New System.Drawing.Point(32, 208)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(59, 13)
        ProveedorLabel.TabIndex = 11
        ProveedorLabel.Text = "Proveedor:"
        '
        'ProveedorTextBox
        '
        Me.ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Proveedor", True))
        Me.ProveedorTextBox.Location = New System.Drawing.Point(97, 205)
        Me.ProveedorTextBox.Name = "ProveedorTextBox"
        Me.ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProveedorTextBox.TabIndex = 12
        '
        'CompraLabel
        '
        CompraLabel.AutoSize = True
        CompraLabel.Location = New System.Drawing.Point(32, 235)
        CompraLabel.Name = "CompraLabel"
        CompraLabel.Size = New System.Drawing.Size(46, 13)
        CompraLabel.TabIndex = 12
        CompraLabel.Text = "Compra:"
        '
        'CompraTextBox
        '
        Me.CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Compra", True))
        Me.CompraTextBox.Location = New System.Drawing.Point(84, 232)
        Me.CompraTextBox.Name = "CompraTextBox"
        Me.CompraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompraTextBox.TabIndex = 13
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(32, 267)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 14
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(104, 264)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 15
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(32, 295)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 16
        PaisLabel.Text = "Pais:"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(68, 292)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 17
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(32, 326)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(51, 13)
        EmpresaLabel.TabIndex = 18
        EmpresaLabel.Text = "Empresa:"
        '
        'EmpresaTextBox
        '
        Me.EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Empresa", True))
        Me.EmpresaTextBox.Location = New System.Drawing.Point(89, 323)
        Me.EmpresaTextBox.Name = "EmpresaTextBox"
        Me.EmpresaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmpresaTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(400, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 60)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(348, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 59)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NOTA: para aguardar los datos, se ubica uno en los iconos de la parte superior de" &
    "l formulario y darle click al caset azul. "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 389)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(Me.EmpresaTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(CompraLabel)
        Me.Controls.Add(Me.CompraTextBox)
        Me.Controls.Add(ProveedorLabel)
        Me.Controls.Add(Me.ProveedorTextBox)
        Me.Controls.Add(Apellido_ClienteLabel)
        Me.Controls.Add(Me.Apellido_ClienteTextBox)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Me.RegistroBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Registro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistroBindingNavigator.ResumeLayout(False)
        Me.RegistroBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As DatabaseDataSetTableAdapters.RegistroTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistroBindingNavigator As BindingNavigator
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
    Friend WithEvents RegistroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Nombre_ClienteTextBox As TextBox
    Friend WithEvents Apellido_ClienteTextBox As TextBox
    Friend WithEvents ProveedorTextBox As TextBox
    Friend WithEvents CompraTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents EmpresaTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
