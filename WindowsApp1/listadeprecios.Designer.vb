<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listadeprecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listadeprecios))
        Me.TabControlListaDePrecios = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NumericUpDownCantidad = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBGananciaLprecios2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TBPventa2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBGananciaLprecios1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBPventa1 = New System.Windows.Forms.TextBox()
        Me.TBCodigoProovedor = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBNotaProductos = New System.Windows.Forms.TextBox()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.ButtonBuscarProducto = New System.Windows.Forms.Button()
        Me.DGVOtrosProovedores = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proovedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBSubCategoria = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDownMaximo = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMinimo = New System.Windows.Forms.NumericUpDown()
        Me.NuevoProducto = New System.Windows.Forms.Button()
        Me.ButtonCancelarNProovedor = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBUbicacion = New System.Windows.Forms.ComboBox()
        Me.CBProovedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBGananciaLprecios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPventa = New System.Windows.Forms.TextBox()
        Me.TBPcostoLprecios = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.CBUniPaquete = New System.Windows.Forms.ComboBox()
        Me.TextBoxUniPaquete = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoNCliente = New System.Windows.Forms.Label()
        Me.TBCodigoProductos = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonCancelarEProdutos = New System.Windows.Forms.Button()
        Me.ButtonEliminarProducto = New System.Windows.Forms.Button()
        Me.ButtonBuscarEliminarProducto = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxUbicaciónEProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxEproducto = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoEProducto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ButtonExportarAExcelColaboradores = New System.Windows.Forms.Button()
        Me.DGVLDePrecios = New System.Windows.Forms.DataGridView()
        Me.LCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDescripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUnidadOpaquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUnidadPaquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LSubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCodProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPCostoContado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPVentaContado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGananciaContado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPVentaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGananciaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPVentaDistribuidor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGananciaDistribuidor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUbicación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMaximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RBNuevoProducto = New System.Windows.Forms.RadioButton()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RBModificarProducto = New System.Windows.Forms.RadioButton()
        Me.TabControlListaDePrecios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVOtrosProovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVLDePrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlListaDePrecios
        '
        Me.TabControlListaDePrecios.Controls.Add(Me.TabPage1)
        Me.TabControlListaDePrecios.Controls.Add(Me.TabPage2)
        Me.TabControlListaDePrecios.Controls.Add(Me.TabPage3)
        Me.TabControlListaDePrecios.Controls.Add(Me.TabPage4)
        Me.TabControlListaDePrecios.Location = New System.Drawing.Point(0, 41)
        Me.TabControlListaDePrecios.Name = "TabControlListaDePrecios"
        Me.TabControlListaDePrecios.SelectedIndex = 0
        Me.TabControlListaDePrecios.Size = New System.Drawing.Size(741, 423)
        Me.TabControlListaDePrecios.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.NumericUpDownCantidad)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TBGananciaLprecios2)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.TBPventa2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TBGananciaLprecios1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TBPventa1)
        Me.TabPage1.Controls.Add(Me.TBCodigoProovedor)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TBNotaProductos)
        Me.TabPage1.Controls.Add(Me.ButtonModificarProducto)
        Me.TabPage1.Controls.Add(Me.ButtonBuscarProducto)
        Me.TabPage1.Controls.Add(Me.DGVOtrosProovedores)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CBSubCategoria)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.NumericUpDownMaximo)
        Me.TabPage1.Controls.Add(Me.NumericUpDownMinimo)
        Me.TabPage1.Controls.Add(Me.NuevoProducto)
        Me.TabPage1.Controls.Add(Me.ButtonCancelarNProovedor)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.CBUbicacion)
        Me.TabPage1.Controls.Add(Me.CBProovedor)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TBGananciaLprecios)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TBPventa)
        Me.TabPage1.Controls.Add(Me.TBPcostoLprecios)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CBCategoria)
        Me.TabPage1.Controls.Add(Me.CBUniPaquete)
        Me.TabPage1.Controls.Add(Me.TextBoxUniPaquete)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TBDescripcion)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CodigoNCliente)
        Me.TabPage1.Controls.Add(Me.TBCodigoProductos)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(68, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 12)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Codigo"
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(412, 54)
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(85, 21)
        Me.NumericUpDownCantidad.TabIndex = 89
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(9, 193)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(164, 14)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Lista de otros proveedores"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(317, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 14)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "%"
        '
        'TBGananciaLprecios2
        '
        Me.TBGananciaLprecios2.Location = New System.Drawing.Point(330, 127)
        Me.TBGananciaLprecios2.Name = "TBGananciaLprecios2"
        Me.TBGananciaLprecios2.Size = New System.Drawing.Size(38, 21)
        Me.TBGananciaLprecios2.TabIndex = 87
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(183, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 14)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "P. Venta Distribuidor"
        '
        'TBPventa2
        '
        Me.TBPventa2.Location = New System.Drawing.Point(258, 127)
        Me.TBPventa2.Name = "TBPventa2"
        Me.TBPventa2.Size = New System.Drawing.Size(59, 21)
        Me.TBPventa2.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(317, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 14)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "%"
        '
        'TBGananciaLprecios1
        '
        Me.TBGananciaLprecios1.Location = New System.Drawing.Point(330, 102)
        Me.TBGananciaLprecios1.Name = "TBGananciaLprecios1"
        Me.TBGananciaLprecios1.Size = New System.Drawing.Size(38, 21)
        Me.TBGananciaLprecios1.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(183, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 14)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "P. Venta Credito"
        '
        'TBPventa1
        '
        Me.TBPventa1.Location = New System.Drawing.Point(258, 102)
        Me.TBPventa1.Name = "TBPventa1"
        Me.TBPventa1.Size = New System.Drawing.Size(59, 21)
        Me.TBPventa1.TabIndex = 81
        '
        'TBCodigoProovedor
        '
        Me.TBCodigoProovedor.Location = New System.Drawing.Point(70, 127)
        Me.TBCodigoProovedor.Name = "TBCodigoProovedor"
        Me.TBCodigoProovedor.Size = New System.Drawing.Size(109, 21)
        Me.TBCodigoProovedor.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(7, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 14)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Cod Proovedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(503, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 14)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Nota:"
        '
        'TBNotaProductos
        '
        Me.TBNotaProductos.Location = New System.Drawing.Point(503, 77)
        Me.TBNotaProductos.Multiline = True
        Me.TBNotaProductos.Name = "TBNotaProductos"
        Me.TBNotaProductos.Size = New System.Drawing.Size(205, 93)
        Me.TBNotaProductos.TabIndex = 76
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.BackColor = System.Drawing.Color.Navy
        Me.ButtonModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(618, 246)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(86, 22)
        Me.ButtonModificarProducto.TabIndex = 75
        Me.ButtonModificarProducto.Text = "Modificar"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = False
        '
        'ButtonBuscarProducto
        '
        Me.ButtonBuscarProducto.BackColor = System.Drawing.Color.Navy
        Me.ButtonBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonBuscarProducto.Location = New System.Drawing.Point(622, 26)
        Me.ButtonBuscarProducto.Name = "ButtonBuscarProducto"
        Me.ButtonBuscarProducto.Size = New System.Drawing.Size(86, 22)
        Me.ButtonBuscarProducto.TabIndex = 74
        Me.ButtonBuscarProducto.Text = "Buscar"
        Me.ButtonBuscarProducto.UseVisualStyleBackColor = False
        '
        'DGVOtrosProovedores
        '
        Me.DGVOtrosProovedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOtrosProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOtrosProovedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Proovedor, Me.PCosto, Me.Cantidad, Me.Ganancia})
        Me.DGVOtrosProovedores.Location = New System.Drawing.Point(7, 219)
        Me.DGVOtrosProovedores.Name = "DGVOtrosProovedores"
        Me.DGVOtrosProovedores.RowTemplate.Height = 25
        Me.DGVOtrosProovedores.Size = New System.Drawing.Size(606, 148)
        Me.DGVOtrosProovedores.TabIndex = 73
        '
        'Cod
        '
        Me.Cod.HeaderText = "Cod P"
        Me.Cod.Name = "Cod"
        '
        'Proovedor
        '
        Me.Proovedor.HeaderText = "Proveedor"
        Me.Proovedor.Name = "Proovedor"
        '
        'PCosto
        '
        Me.PCosto.HeaderText = "P. Costo"
        Me.PCosto.Name = "PCosto"
        Me.PCosto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PCosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Ganancia
        '
        Me.Ganancia.HeaderText = "% Ganancia"
        Me.Ganancia.Name = "Ganancia"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(7, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 14)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Sub-Categoria"
        '
        'CBSubCategoria
        '
        Me.CBSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBSubCategoria.DropDownHeight = 50
        Me.CBSubCategoria.FormattingEnabled = True
        Me.CBSubCategoria.IntegralHeight = False
        Me.CBSubCategoria.Location = New System.Drawing.Point(70, 103)
        Me.CBSubCategoria.Name = "CBSubCategoria"
        Me.CBSubCategoria.Size = New System.Drawing.Size(109, 22)
        Me.CBSubCategoria.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(374, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 14)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Maximo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(374, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 14)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Minimo"
        '
        'NumericUpDownMaximo
        '
        Me.NumericUpDownMaximo.Location = New System.Drawing.Point(412, 104)
        Me.NumericUpDownMaximo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownMaximo.Name = "NumericUpDownMaximo"
        Me.NumericUpDownMaximo.Size = New System.Drawing.Size(86, 21)
        Me.NumericUpDownMaximo.TabIndex = 49
        '
        'NumericUpDownMinimo
        '
        Me.NumericUpDownMinimo.Location = New System.Drawing.Point(412, 79)
        Me.NumericUpDownMinimo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownMinimo.Name = "NumericUpDownMinimo"
        Me.NumericUpDownMinimo.Size = New System.Drawing.Size(86, 21)
        Me.NumericUpDownMinimo.TabIndex = 47
        '
        'NuevoProducto
        '
        Me.NuevoProducto.BackColor = System.Drawing.Color.Navy
        Me.NuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.NuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.NuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NuevoProducto.Location = New System.Drawing.Point(618, 219)
        Me.NuevoProducto.Name = "NuevoProducto"
        Me.NuevoProducto.Size = New System.Drawing.Size(86, 22)
        Me.NuevoProducto.TabIndex = 51
        Me.NuevoProducto.Text = "Guardar Nuevo"
        Me.NuevoProducto.UseVisualStyleBackColor = False
        '
        'ButtonCancelarNProovedor
        '
        Me.ButtonCancelarNProovedor.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarNProovedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarNProovedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarNProovedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarNProovedor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarNProovedor.Location = New System.Drawing.Point(622, 49)
        Me.ButtonCancelarNProovedor.Name = "ButtonCancelarNProovedor"
        Me.ButtonCancelarNProovedor.Size = New System.Drawing.Size(86, 22)
        Me.ButtonCancelarNProovedor.TabIndex = 50
        Me.ButtonCancelarNProovedor.Text = "Cancelar"
        Me.ButtonCancelarNProovedor.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(374, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(183, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 14)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Ubicación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(7, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Proovedor"
        '
        'CBUbicacion
        '
        Me.CBUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBUbicacion.DropDownHeight = 50
        Me.CBUbicacion.FormattingEnabled = True
        Me.CBUbicacion.IntegralHeight = False
        Me.CBUbicacion.Location = New System.Drawing.Point(258, 151)
        Me.CBUbicacion.Name = "CBUbicacion"
        Me.CBUbicacion.Size = New System.Drawing.Size(59, 22)
        Me.CBUbicacion.TabIndex = 43
        '
        'CBProovedor
        '
        Me.CBProovedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBProovedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBProovedor.DropDownHeight = 50
        Me.CBProovedor.FormattingEnabled = True
        Me.CBProovedor.IntegralHeight = False
        Me.CBProovedor.Location = New System.Drawing.Point(70, 151)
        Me.CBProovedor.Name = "CBProovedor"
        Me.CBProovedor.Size = New System.Drawing.Size(109, 22)
        Me.CBProovedor.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(317, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 14)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "%"
        '
        'TBGananciaLprecios
        '
        Me.TBGananciaLprecios.Location = New System.Drawing.Point(330, 78)
        Me.TBGananciaLprecios.Name = "TBGananciaLprecios"
        Me.TBGananciaLprecios.Size = New System.Drawing.Size(38, 21)
        Me.TBGananciaLprecios.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(183, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "P. Venta Contado"
        '
        'TBPventa
        '
        Me.TBPventa.Location = New System.Drawing.Point(258, 78)
        Me.TBPventa.Name = "TBPventa"
        Me.TBPventa.Size = New System.Drawing.Size(59, 21)
        Me.TBPventa.TabIndex = 37
        '
        'TBPcostoLprecios
        '
        Me.TBPcostoLprecios.Location = New System.Drawing.Point(258, 53)
        Me.TBPcostoLprecios.Name = "TBPcostoLprecios"
        Me.TBPcostoLprecios.Size = New System.Drawing.Size(59, 21)
        Me.TBPcostoLprecios.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(183, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "P. Costo"
        '
        'CBCategoria
        '
        Me.CBCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCategoria.DropDownHeight = 50
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.IntegralHeight = False
        Me.CBCategoria.Location = New System.Drawing.Point(70, 78)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(109, 22)
        Me.CBCategoria.TabIndex = 31
        '
        'CBUniPaquete
        '
        Me.CBUniPaquete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBUniPaquete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBUniPaquete.FormattingEnabled = True
        Me.CBUniPaquete.Items.AddRange(New Object() {"Unidad", "Paquete"})
        Me.CBUniPaquete.Location = New System.Drawing.Point(70, 53)
        Me.CBUniPaquete.Name = "CBUniPaquete"
        Me.CBUniPaquete.Size = New System.Drawing.Size(52, 22)
        Me.CBUniPaquete.TabIndex = 28
        '
        'TextBoxUniPaquete
        '
        Me.TextBoxUniPaquete.Location = New System.Drawing.Point(127, 53)
        Me.TextBoxUniPaquete.Name = "TextBoxUniPaquete"
        Me.TextBoxUniPaquete.Size = New System.Drawing.Size(52, 21)
        Me.TextBoxUniPaquete.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Uni/Paquete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Categoria"
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(258, 28)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(349, 21)
        Me.TBDescripcion.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(183, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Descripción"
        '
        'CodigoNCliente
        '
        Me.CodigoNCliente.AutoSize = True
        Me.CodigoNCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CodigoNCliente.Location = New System.Drawing.Point(7, 30)
        Me.CodigoNCliente.Name = "CodigoNCliente"
        Me.CodigoNCliente.Size = New System.Drawing.Size(49, 14)
        Me.CodigoNCliente.TabIndex = 23
        Me.CodigoNCliente.Text = "Codigo"
        '
        'TBCodigoProductos
        '
        Me.TBCodigoProductos.Location = New System.Drawing.Point(70, 28)
        Me.TBCodigoProductos.Name = "TBCodigoProductos"
        Me.TBCodigoProductos.Size = New System.Drawing.Size(109, 21)
        Me.TBCodigoProductos.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 25)
        Me.Panel2.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(6, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Añadir a desplegables"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonCancelarEProdutos)
        Me.TabPage2.Controls.Add(Me.ButtonEliminarProducto)
        Me.TabPage2.Controls.Add(Me.ButtonBuscarEliminarProducto)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.TextBoxUbicaciónEProducto)
        Me.TabPage2.Controls.Add(Me.TextBoxEproducto)
        Me.TabPage2.Controls.Add(Me.TextBoxCodigoEProducto)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonCancelarEProdutos
        '
        Me.ButtonCancelarEProdutos.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarEProdutos.FlatAppearance.BorderSize = 0
        Me.ButtonCancelarEProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarEProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarEProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarEProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarEProdutos.Location = New System.Drawing.Point(261, 231)
        Me.ButtonCancelarEProdutos.Name = "ButtonCancelarEProdutos"
        Me.ButtonCancelarEProdutos.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelarEProdutos.TabIndex = 20
        Me.ButtonCancelarEProdutos.Text = "Cancelar"
        Me.ButtonCancelarEProdutos.UseVisualStyleBackColor = False
        '
        'ButtonEliminarProducto
        '
        Me.ButtonEliminarProducto.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarProducto.FlatAppearance.BorderSize = 0
        Me.ButtonEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarProducto.Location = New System.Drawing.Point(393, 231)
        Me.ButtonEliminarProducto.Name = "ButtonEliminarProducto"
        Me.ButtonEliminarProducto.Size = New System.Drawing.Size(64, 20)
        Me.ButtonEliminarProducto.TabIndex = 19
        Me.ButtonEliminarProducto.Text = "Eliminar"
        Me.ButtonEliminarProducto.UseVisualStyleBackColor = False
        '
        'ButtonBuscarEliminarProducto
        '
        Me.ButtonBuscarEliminarProducto.BackColor = System.Drawing.Color.Navy
        Me.ButtonBuscarEliminarProducto.FlatAppearance.BorderSize = 0
        Me.ButtonBuscarEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonBuscarEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonBuscarEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonBuscarEliminarProducto.Location = New System.Drawing.Point(463, 129)
        Me.ButtonBuscarEliminarProducto.Name = "ButtonBuscarEliminarProducto"
        Me.ButtonBuscarEliminarProducto.Size = New System.Drawing.Size(64, 20)
        Me.ButtonBuscarEliminarProducto.TabIndex = 18
        Me.ButtonBuscarEliminarProducto.Text = "Buscar"
        Me.ButtonBuscarEliminarProducto.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(207, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 17)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Ubicación"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 17)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Producto"
        '
        'TextBoxUbicaciónEProducto
        '
        Me.TextBoxUbicaciónEProducto.Location = New System.Drawing.Point(261, 179)
        Me.TextBoxUbicaciónEProducto.Name = "TextBoxUbicaciónEProducto"
        Me.TextBoxUbicaciónEProducto.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxUbicaciónEProducto.TabIndex = 15
        '
        'TextBoxEproducto
        '
        Me.TextBoxEproducto.Location = New System.Drawing.Point(261, 154)
        Me.TextBoxEproducto.Name = "TextBoxEproducto"
        Me.TextBoxEproducto.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxEproducto.TabIndex = 14
        '
        'TextBoxCodigoEProducto
        '
        Me.TextBoxCodigoEProducto.Location = New System.Drawing.Point(261, 129)
        Me.TextBoxCodigoEProducto.Name = "TextBoxCodigoEProducto"
        Me.TextBoxCodigoEProducto.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoEProducto.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(207, 132)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Codigo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.ButtonExportarAExcelColaboradores)
        Me.TabPage3.Controls.Add(Me.DGVLDePrecios)
        Me.TabPage3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(733, 397)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 22)
        Me.TextBox1.TabIndex = 95
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cod", "Descripción", "Sub categoria", "Proveedor", "P.venta", "Bajo de inventario"})
        Me.ComboBox1.Location = New System.Drawing.Point(72, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(109, 24)
        Me.ComboBox1.TabIndex = 94
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(9, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 16)
        Me.Label24.TabIndex = 93
        Me.Label24.Text = "Filtrar por:"
        '
        'ButtonExportarAExcelColaboradores
        '
        Me.ButtonExportarAExcelColaboradores.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonExportarAExcelColaboradores.FlatAppearance.BorderSize = 0
        Me.ButtonExportarAExcelColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonExportarAExcelColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ButtonExportarAExcelColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportarAExcelColaboradores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonExportarAExcelColaboradores.Image = CType(resources.GetObject("ButtonExportarAExcelColaboradores.Image"), System.Drawing.Image)
        Me.ButtonExportarAExcelColaboradores.Location = New System.Drawing.Point(587, 7)
        Me.ButtonExportarAExcelColaboradores.Name = "ButtonExportarAExcelColaboradores"
        Me.ButtonExportarAExcelColaboradores.Size = New System.Drawing.Size(113, 35)
        Me.ButtonExportarAExcelColaboradores.TabIndex = 92
        Me.ButtonExportarAExcelColaboradores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelColaboradores.UseVisualStyleBackColor = False
        '
        'DGVLDePrecios
        '
        Me.DGVLDePrecios.AllowUserToAddRows = False
        Me.DGVLDePrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVLDePrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLDePrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LCod, Me.LDescripción, Me.LUnidadOpaquete, Me.LUnidadPaquete, Me.LCategoria, Me.LSubCategoria, Me.LCodProveedor, Me.LProveedor, Me.LPCostoContado, Me.LPVentaContado, Me.LGananciaContado, Me.LPVentaCredito, Me.LGananciaCredito, Me.LPVentaDistribuidor, Me.LGananciaDistribuidor, Me.LUbicación, Me.LCantidad, Me.LMinimo, Me.LMaximo})
        Me.DGVLDePrecios.Location = New System.Drawing.Point(7, 48)
        Me.DGVLDePrecios.Name = "DGVLDePrecios"
        Me.DGVLDePrecios.RowTemplate.Height = 25
        Me.DGVLDePrecios.Size = New System.Drawing.Size(693, 286)
        Me.DGVLDePrecios.TabIndex = 0
        '
        'LCod
        '
        Me.LCod.HeaderText = "Cod"
        Me.LCod.Name = "LCod"
        '
        'LDescripción
        '
        Me.LDescripción.HeaderText = "descripción"
        Me.LDescripción.Name = "LDescripción"
        '
        'LUnidadOpaquete
        '
        Me.LUnidadOpaquete.HeaderText = "UnidadOpaquete"
        Me.LUnidadOpaquete.Name = "LUnidadOpaquete"
        '
        'LUnidadPaquete
        '
        Me.LUnidadPaquete.HeaderText = "Unidad/paquete"
        Me.LUnidadPaquete.Name = "LUnidadPaquete"
        '
        'LCategoria
        '
        Me.LCategoria.HeaderText = "Categoria"
        Me.LCategoria.Name = "LCategoria"
        '
        'LSubCategoria
        '
        Me.LSubCategoria.HeaderText = "Sub categoria"
        Me.LSubCategoria.Name = "LSubCategoria"
        '
        'LCodProveedor
        '
        Me.LCodProveedor.HeaderText = "Cod proveedor"
        Me.LCodProveedor.Name = "LCodProveedor"
        '
        'LProveedor
        '
        Me.LProveedor.HeaderText = "Proveedor"
        Me.LProveedor.Name = "LProveedor"
        '
        'LPCostoContado
        '
        Me.LPCostoContado.HeaderText = "P Costo"
        Me.LPCostoContado.Name = "LPCostoContado"
        '
        'LPVentaContado
        '
        Me.LPVentaContado.HeaderText = "P venta"
        Me.LPVentaContado.Name = "LPVentaContado"
        '
        'LGananciaContado
        '
        Me.LGananciaContado.HeaderText = "Ganancia"
        Me.LGananciaContado.Name = "LGananciaContado"
        '
        'LPVentaCredito
        '
        Me.LPVentaCredito.HeaderText = "P venta1"
        Me.LPVentaCredito.Name = "LPVentaCredito"
        '
        'LGananciaCredito
        '
        Me.LGananciaCredito.HeaderText = "Ganancia1"
        Me.LGananciaCredito.Name = "LGananciaCredito"
        '
        'LPVentaDistribuidor
        '
        Me.LPVentaDistribuidor.HeaderText = "P venta 2"
        Me.LPVentaDistribuidor.Name = "LPVentaDistribuidor"
        '
        'LGananciaDistribuidor
        '
        Me.LGananciaDistribuidor.HeaderText = "Ganancia2"
        Me.LGananciaDistribuidor.Name = "LGananciaDistribuidor"
        '
        'LUbicación
        '
        Me.LUbicación.HeaderText = "Ubicación"
        Me.LUbicación.Name = "LUbicación"
        '
        'LCantidad
        '
        Me.LCantidad.HeaderText = "Cantidad"
        Me.LCantidad.Name = "LCantidad"
        '
        'LMinimo
        '
        Me.LMinimo.HeaderText = "Minimo"
        Me.LMinimo.Name = "LMinimo"
        '
        'LMaximo
        '
        Me.LMaximo.HeaderText = "Maximo"
        Me.LMaximo.Name = "LMaximo"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.RadioButton4)
        Me.TabPage4.Controls.Add(Me.RadioButton3)
        Me.TabPage4.Controls.Add(Me.RadioButton2)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Controls.Add(Me.ComboBox2)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(733, 397)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(274, 82)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(160, 20)
        Me.Label29.TabIndex = 104
        Me.Label29.Text = "Producto no encontrado"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(203, 102)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(101, 24)
        Me.RadioButton4.TabIndex = 103
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Distribuidor"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(139, 102)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton3.TabIndex = 102
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Credito"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(68, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 24)
        Me.RadioButton2.TabIndex = 101
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Contado"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(271, 181)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(319, 42)
        Me.Label28.TabIndex = 100
        Me.Label28.Text = "verificador de precios"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(252, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(304, 32)
        Me.Label27.TabIndex = 99
        Me.Label27.Text = "verificador de precios"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(274, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 20)
        Me.Label26.TabIndex = 98
        Me.Label26.Text = "Buscar:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(323, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(349, 26)
        Me.TextBox2.TabIndex = 97
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cod", "Descripción"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(109, 28)
        Me.ComboBox2.TabIndex = 96
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(65, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 20)
        Me.Label25.TabIndex = 95
        Me.Label25.Text = "Buscar por:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RBNuevoProducto)
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Controls.Add(Me.RBModificarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 60)
        Me.Panel1.TabIndex = 5
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton5.FlatAppearance.BorderSize = 0
        Me.RadioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton5.Location = New System.Drawing.Point(262, 36)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(93, 25)
        Me.RadioButton5.TabIndex = 6
        Me.RadioButton5.Text = "Verificador de precios"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton1.Location = New System.Drawing.Point(171, 36)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 25)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "Lista de precios"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RBNuevoProducto
        '
        Me.RBNuevoProducto.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBNuevoProducto.Checked = True
        Me.RBNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBNuevoProducto.FlatAppearance.BorderSize = 0
        Me.RBNuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RBNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RBNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBNuevoProducto.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RBNuevoProducto.Location = New System.Drawing.Point(10, 36)
        Me.RBNuevoProducto.Name = "RBNuevoProducto"
        Me.RBNuevoProducto.Size = New System.Drawing.Size(83, 25)
        Me.RBNuevoProducto.TabIndex = 4
        Me.RBNuevoProducto.TabStop = True
        Me.RBNuevoProducto.Text = "Producto"
        Me.RBNuevoProducto.UseVisualStyleBackColor = True
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(10, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(280, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Lista de precios"
        '
        'RBModificarProducto
        '
        Me.RBModificarProducto.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBModificarProducto.FlatAppearance.BorderSize = 0
        Me.RBModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RBModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RBModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBModificarProducto.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RBModificarProducto.Location = New System.Drawing.Point(92, 36)
        Me.RBModificarProducto.Name = "RBModificarProducto"
        Me.RBModificarProducto.Size = New System.Drawing.Size(83, 25)
        Me.RBModificarProducto.TabIndex = 1
        Me.RBModificarProducto.Text = "Eliminar"
        Me.RBModificarProducto.UseVisualStyleBackColor = True
        '
        'Listadeprecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(740, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlListaDePrecios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Listadeprecios"
        Me.Text = "listadeprecios"
        Me.TabControlListaDePrecios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVOtrosProovedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVLDePrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlListaDePrecios As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TBCodigoProductos As TextBox
    Friend WithEvents CodigoNCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents CBUniPaquete As ComboBox
    Friend WithEvents TextBoxUniPaquete As TextBox
    Friend WithEvents TBPcostoLprecios As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPventa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBUbicacion As ComboBox
    Friend WithEvents CBProovedor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBGananciaLprecios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NuevoProducto As Button
    Friend WithEvents ButtonCancelarNProovedor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBNuevoProducto As RadioButton
    Friend WithEvents LabelClientes As Label
    Friend WithEvents RBModificarProducto As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDownMaximo As NumericUpDown
    Friend WithEvents NumericUpDownMinimo As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents CBSubCategoria As ComboBox
    Friend WithEvents DGVOtrosProovedores As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents ButtonBuscarProducto As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TBNotaProductos As TextBox
    Friend WithEvents TBCodigoProovedor As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ButtonCancelarEProdutos As Button
    Friend WithEvents ButtonEliminarProducto As Button
    Friend WithEvents ButtonBuscarEliminarProducto As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxUbicaciónEProducto As TextBox
    Friend WithEvents TextBoxEproducto As TextBox
    Friend WithEvents TextBoxCodigoEProducto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Proovedor As DataGridViewComboBoxColumn
    Friend WithEvents PCosto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TBGananciaLprecios2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TBPventa2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBGananciaLprecios1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBPventa1 As TextBox
    Friend WithEvents DGVLDePrecios As DataGridView
    Friend WithEvents ButtonExportarAExcelColaboradores As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents NumericUpDownCantidad As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents LCod As DataGridViewTextBoxColumn
    Friend WithEvents LDescripción As DataGridViewTextBoxColumn
    Friend WithEvents LUnidadOpaquete As DataGridViewTextBoxColumn
    Friend WithEvents LUnidadPaquete As DataGridViewTextBoxColumn
    Friend WithEvents LCategoria As DataGridViewTextBoxColumn
    Friend WithEvents LSubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents LCodProveedor As DataGridViewTextBoxColumn
    Friend WithEvents LProveedor As DataGridViewTextBoxColumn
    Friend WithEvents LPCostoContado As DataGridViewTextBoxColumn
    Friend WithEvents LPVentaContado As DataGridViewTextBoxColumn
    Friend WithEvents LGananciaContado As DataGridViewTextBoxColumn
    Friend WithEvents LPVentaCredito As DataGridViewTextBoxColumn
    Friend WithEvents LGananciaCredito As DataGridViewTextBoxColumn
    Friend WithEvents LPVentaDistribuidor As DataGridViewTextBoxColumn
    Friend WithEvents LGananciaDistribuidor As DataGridViewTextBoxColumn
    Friend WithEvents LUbicación As DataGridViewTextBoxColumn
    Friend WithEvents LCantidad As DataGridViewTextBoxColumn
    Friend WithEvents LMinimo As DataGridViewTextBoxColumn
    Friend WithEvents LMaximo As DataGridViewTextBoxColumn
End Class
