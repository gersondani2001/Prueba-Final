<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ComprasLabel As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim FechaCompraLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        TotalLabel = New System.Windows.Forms.Label()
        ComprasLabel = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        FechaCompraLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(12, 282)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 43
        TotalLabel.Text = "Total:"
        '
        'ComprasLabel
        '
        ComprasLabel.AutoSize = True
        ComprasLabel.Location = New System.Drawing.Point(12, 256)
        ComprasLabel.Name = "ComprasLabel"
        ComprasLabel.Size = New System.Drawing.Size(46, 13)
        ComprasLabel.TabIndex = 42
        ComprasLabel.Text = "Compra:"
        '
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(12, 234)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(23, 13)
        BonosLabel.TabIndex = 41
        BonosLabel.Text = "Nit:"
        '
        'FechaCompraLabel
        '
        FechaCompraLabel.AutoSize = True
        FechaCompraLabel.Location = New System.Drawing.Point(12, 201)
        FechaCompraLabel.Name = "FechaCompraLabel"
        FechaCompraLabel.Size = New System.Drawing.Size(79, 13)
        FechaCompraLabel.TabIndex = 39
        FechaCompraLabel.Text = "Fecha Compra:"
        AddHandler FechaCompraLabel.Click, AddressOf Me.FechaCompraLabel_Click
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(12, 174)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 38
        DPILabel.Text = "DPI:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(12, 148)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 37
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 124)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 36
        NombreLabel.Text = "Nombre:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(12, 97)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 35
        CodigoLabel.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Free PSD Website Template"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 42)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "MAGIC"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 53)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "APP"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(125, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(125, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(125, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(125, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(125, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 13)
        Me.Label8.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(125, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(125, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(125, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 13)
        Me.Label12.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(105, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 33)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "NO."
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(181, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 33)
        Me.Label14.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 19)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(ComprasLabel)
        Me.Controls.Add(BonosLabel)
        Me.Controls.Add(FechaCompraLabel)
        Me.Controls.Add(DPILabel)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
End Class
