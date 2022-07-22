<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasDeVentas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TBVentasNPedido = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DTPFechaDeCredito = New System.Windows.Forms.DateTimePicker()
        Me.TBDiasDeCredito = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CHBIVA = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBTotalVentas = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonDeGuardarVentas = New System.Windows.Forms.Button()
        Me.CancelarVenta = New System.Windows.Forms.Button()
        Me.TBVentasEnviara = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBVentasClientes = New System.Windows.Forms.ComboBox()
        Me.DGVVentasDistri = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VrUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrUnitarioIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrTotalIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBVentasDireccion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBVentasCiudad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBVentasTipodepago = New System.Windows.Forms.ComboBox()
        Me.TBCodVendedor = New System.Windows.Forms.TextBox()
        Me.CBVendedor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBVentasCodCLiente = New System.Windows.Forms.TextBox()
        Me.TBVentasBarrio = New System.Windows.Forms.TextBox()
        Me.TBVentasEmail = New System.Windows.Forms.TextBox()
        Me.TBVentasCel = New System.Windows.Forms.TextBox()
        Me.TBVentasTelefono = New System.Windows.Forms.TextBox()
        Me.TBVentasOdePedido = New System.Windows.Forms.TextBox()
        Me.TBVentasNit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAlistarPedidos = New System.Windows.Forms.Button()
        Me.ButtonCancelarPedidosParaAlistar = New System.Windows.Forms.Button()
        Me.ButtonParaListaDeIngresados = New System.Windows.Forms.Button()
        Me.ButtonParaAlistar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DGVVentasAlistar = New System.Windows.Forms.DataGridView()
        Me.NDePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaODePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVVentasIngresados = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DTP_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DTP_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DGVEstados = New System.Windows.Forms.DataGridView()
        Me.NPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoDelPedido = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButtonVerificarPedido = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.DTPHastaAbono = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DTPdesdeAbono = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ButtonAbonar = New System.Windows.Forms.Button()
        Me.DGVCobrosVentas = New System.Windows.Forms.DataGridView()
        Me.Consecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteCobrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteCobrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContadoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVVentasDistri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVVentasAlistar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVentasIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGVCobrosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(719, 454)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TBVentasNPedido)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.ComboBox5)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.DTPFechaDeCredito)
        Me.TabPage1.Controls.Add(Me.TBDiasDeCredito)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.CHBIVA)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.TBTotalVentas)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.ButtonDeGuardarVentas)
        Me.TabPage1.Controls.Add(Me.CancelarVenta)
        Me.TabPage1.Controls.Add(Me.TBVentasEnviara)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CBVentasClientes)
        Me.TabPage1.Controls.Add(Me.DGVVentasDistri)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TBVentasDireccion)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TBVentasCiudad)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CBVentasTipodepago)
        Me.TabPage1.Controls.Add(Me.TBCodVendedor)
        Me.TabPage1.Controls.Add(Me.CBVendedor)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TBVentasCodCLiente)
        Me.TabPage1.Controls.Add(Me.TBVentasBarrio)
        Me.TabPage1.Controls.Add(Me.TBVentasEmail)
        Me.TabPage1.Controls.Add(Me.TBVentasCel)
        Me.TabPage1.Controls.Add(Me.TBVentasTelefono)
        Me.TabPage1.Controls.Add(Me.TBVentasOdePedido)
        Me.TabPage1.Controls.Add(Me.TBVentasNit)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(711, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TBVentasNPedido
        '
        Me.TBVentasNPedido.AutoSize = True
        Me.TBVentasNPedido.Location = New System.Drawing.Point(522, 7)
        Me.TBVentasNPedido.Name = "TBVentasNPedido"
        Me.TBVentasNPedido.Size = New System.Drawing.Size(79, 14)
        Me.TBVentasNPedido.TabIndex = 145
        Me.TBVentasNPedido.Text = "Consecutivo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(597, 95)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 18)
        Me.CheckBox1.TabIndex = 144
        Me.CheckBox1.Text = "Completo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.ComboBox5.Location = New System.Drawing.Point(522, 94)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(71, 22)
        Me.ComboBox5.TabIndex = 143
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(461, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 14)
        Me.Label30.TabIndex = 142
        Me.Label30.Text = "Tipo de pago:"
        '
        'DTPFechaDeCredito
        '
        Me.DTPFechaDeCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDeCredito.Location = New System.Drawing.Point(92, 93)
        Me.DTPFechaDeCredito.Name = "DTPFechaDeCredito"
        Me.DTPFechaDeCredito.Size = New System.Drawing.Size(68, 21)
        Me.DTPFechaDeCredito.TabIndex = 141
        '
        'TBDiasDeCredito
        '
        Me.TBDiasDeCredito.Location = New System.Drawing.Point(195, 93)
        Me.TBDiasDeCredito.Name = "TBDiasDeCredito"
        Me.TBDiasDeCredito.Size = New System.Drawing.Size(33, 21)
        Me.TBDiasDeCredito.TabIndex = 140
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(159, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 14)
        Me.Label28.TabIndex = 139
        Me.Label28.Text = "Dias"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 96)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(115, 14)
        Me.Label29.TabIndex = 138
        Me.Label29.Text = "Fecha vencimiento"
        '
        'CHBIVA
        '
        Me.CHBIVA.AutoSize = True
        Me.CHBIVA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.CHBIVA.Location = New System.Drawing.Point(599, 7)
        Me.CHBIVA.Name = "CHBIVA"
        Me.CHBIVA.Size = New System.Drawing.Size(47, 18)
        Me.CHBIVA.TabIndex = 137
        Me.CHBIVA.Text = "IVA"
        Me.CHBIVA.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(621, 363)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 21)
        Me.TextBox1.TabIndex = 82
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(582, 366)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 14)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Total IVA:"
        '
        'TBTotalVentas
        '
        Me.TBTotalVentas.Location = New System.Drawing.Point(621, 343)
        Me.TBTotalVentas.Name = "TBTotalVentas"
        Me.TBTotalVentas.Size = New System.Drawing.Size(85, 21)
        Me.TBTotalVentas.TabIndex = 80
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(582, 346)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 14)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Total:"
        '
        'ButtonDeGuardarVentas
        '
        Me.ButtonDeGuardarVentas.Location = New System.Drawing.Point(641, 25)
        Me.ButtonDeGuardarVentas.Name = "ButtonDeGuardarVentas"
        Me.ButtonDeGuardarVentas.Size = New System.Drawing.Size(64, 20)
        Me.ButtonDeGuardarVentas.TabIndex = 78
        Me.ButtonDeGuardarVentas.Text = "Guardar"
        Me.ButtonDeGuardarVentas.UseVisualStyleBackColor = True
        '
        'CancelarVenta
        '
        Me.CancelarVenta.Location = New System.Drawing.Point(641, 50)
        Me.CancelarVenta.Name = "CancelarVenta"
        Me.CancelarVenta.Size = New System.Drawing.Size(64, 20)
        Me.CancelarVenta.TabIndex = 77
        Me.CancelarVenta.Text = "Cancelar"
        Me.CancelarVenta.UseVisualStyleBackColor = True
        '
        'TBVentasEnviara
        '
        Me.TBVentasEnviara.Location = New System.Drawing.Point(57, 23)
        Me.TBVentasEnviara.Name = "TBVentasEnviara"
        Me.TBVentasEnviara.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasEnviara.TabIndex = 76
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 14)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "Enviar a:"
        '
        'CBVentasClientes
        '
        Me.CBVentasClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBVentasClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBVentasClientes.DropDownHeight = 50
        Me.CBVentasClientes.FormattingEnabled = True
        Me.CBVentasClientes.IntegralHeight = False
        Me.CBVentasClientes.Location = New System.Drawing.Point(57, 5)
        Me.CBVentasClientes.Name = "CBVentasClientes"
        Me.CBVentasClientes.Size = New System.Drawing.Size(171, 22)
        Me.CBVentasClientes.TabIndex = 74
        '
        'DGVVentasDistri
        '
        Me.DGVVentasDistri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVentasDistri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVVentasDistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentasDistri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Cod, Me.Descripcion, Me.VrUnitario, Me.VrTotal, Me.VrUnitarioIVA, Me.IVA, Me.VrTotalIVA, Me.Costo, Me.CostoTotal, Me.Ganancia, Me.Porcentaje, Me.Categoria, Me.SubCategoria, Me.Proveedor, Me.Ubicacion, Me.Disponible})
        Me.DGVVentasDistri.Location = New System.Drawing.Point(7, 120)
        Me.DGVVentasDistri.Name = "DGVVentasDistri"
        Me.DGVVentasDistri.RowTemplate.Height = 25
        Me.DGVVentasDistri.Size = New System.Drawing.Size(699, 218)
        Me.DGVVentasDistri.TabIndex = 73
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.Name = "Cod"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MaxDropDownItems = 5
        Me.Descripcion.Name = "Descripcion"
        '
        'VrUnitario
        '
        Me.VrUnitario.HeaderText = "Vr.Unitario"
        Me.VrUnitario.Name = "VrUnitario"
        '
        'VrTotal
        '
        Me.VrTotal.HeaderText = "VrTotal"
        Me.VrTotal.Name = "VrTotal"
        '
        'VrUnitarioIVA
        '
        Me.VrUnitarioIVA.HeaderText = "Vr.Unitario"
        Me.VrUnitarioIVA.Name = "VrUnitarioIVA"
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        '
        'VrTotalIVA
        '
        Me.VrTotalIVA.HeaderText = "Vr.Total"
        Me.VrTotalIVA.Name = "VrTotalIVA"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'CostoTotal
        '
        Me.CostoTotal.HeaderText = "Costo Total"
        Me.CostoTotal.Name = "CostoTotal"
        '
        'Ganancia
        '
        Me.Ganancia.HeaderText = "Ganancia"
        Me.Ganancia.Name = "Ganancia"
        '
        'Porcentaje
        '
        Me.Porcentaje.HeaderText = "Porcentaje"
        Me.Porcentaje.Name = "Porcentaje"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'SubCategoria
        '
        Me.SubCategoria.HeaderText = "Sub Categoria"
        Me.SubCategoria.Name = "SubCategoria"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicación"
        Me.Ubicacion.Name = "Ubicacion"
        '
        'Disponible
        '
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(522, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(71, 21)
        Me.DateTimePicker1.TabIndex = 72
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(522, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(71, 21)
        Me.DateTimePicker2.TabIndex = 71
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(461, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 14)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Fecha entrega:"
        '
        'TBVentasDireccion
        '
        Me.TBVentasDireccion.Location = New System.Drawing.Point(57, 75)
        Me.TBVentasDireccion.Name = "TBVentasDireccion"
        Me.TBVentasDireccion.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasDireccion.TabIndex = 69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 14)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Dirección:"
        '
        'TBVentasCiudad
        '
        Me.TBVentasCiudad.Location = New System.Drawing.Point(57, 57)
        Me.TBVentasCiudad.Name = "TBVentasCiudad"
        Me.TBVentasCiudad.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasCiudad.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Ciudad:"
        '
        'CBVentasTipodepago
        '
        Me.CBVentasTipodepago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBVentasTipodepago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBVentasTipodepago.FormattingEnabled = True
        Me.CBVentasTipodepago.Items.AddRange(New Object() {"Contado", "Credito", "Distribuidor"})
        Me.CBVentasTipodepago.Location = New System.Drawing.Point(522, 75)
        Me.CBVentasTipodepago.Name = "CBVentasTipodepago"
        Me.CBVentasTipodepago.Size = New System.Drawing.Size(71, 22)
        Me.CBVentasTipodepago.TabIndex = 65
        '
        'TBCodVendedor
        '
        Me.TBCodVendedor.Location = New System.Drawing.Point(400, 75)
        Me.TBCodVendedor.Name = "TBCodVendedor"
        Me.TBCodVendedor.Size = New System.Drawing.Size(59, 21)
        Me.TBCodVendedor.TabIndex = 64
        '
        'CBVendedor
        '
        Me.CBVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBVendedor.DropDownHeight = 50
        Me.CBVendedor.FormattingEnabled = True
        Me.CBVendedor.IntegralHeight = False
        Me.CBVendedor.Location = New System.Drawing.Point(288, 75)
        Me.CBVendedor.Name = "CBVendedor"
        Me.CBVendedor.Size = New System.Drawing.Size(108, 22)
        Me.CBVendedor.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(230, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 14)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Vendedor:"
        '
        'TBVentasCodCLiente
        '
        Me.TBVentasCodCLiente.Location = New System.Drawing.Point(640, 75)
        Me.TBVentasCodCLiente.Name = "TBVentasCodCLiente"
        Me.TBVentasCodCLiente.Size = New System.Drawing.Size(67, 21)
        Me.TBVentasCodCLiente.TabIndex = 59
        '
        'TBVentasBarrio
        '
        Me.TBVentasBarrio.Location = New System.Drawing.Point(288, 57)
        Me.TBVentasBarrio.Name = "TBVentasBarrio"
        Me.TBVentasBarrio.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasBarrio.TabIndex = 58
        '
        'TBVentasEmail
        '
        Me.TBVentasEmail.Location = New System.Drawing.Point(288, 40)
        Me.TBVentasEmail.Name = "TBVentasEmail"
        Me.TBVentasEmail.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasEmail.TabIndex = 57
        '
        'TBVentasCel
        '
        Me.TBVentasCel.Location = New System.Drawing.Point(288, 23)
        Me.TBVentasCel.Name = "TBVentasCel"
        Me.TBVentasCel.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasCel.TabIndex = 56
        '
        'TBVentasTelefono
        '
        Me.TBVentasTelefono.Location = New System.Drawing.Point(288, 5)
        Me.TBVentasTelefono.Name = "TBVentasTelefono"
        Me.TBVentasTelefono.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasTelefono.TabIndex = 55
        '
        'TBVentasOdePedido
        '
        Me.TBVentasOdePedido.Location = New System.Drawing.Point(522, 23)
        Me.TBVentasOdePedido.Name = "TBVentasOdePedido"
        Me.TBVentasOdePedido.Size = New System.Drawing.Size(71, 21)
        Me.TBVentasOdePedido.TabIndex = 52
        '
        'TBVentasNit
        '
        Me.TBVentasNit.Location = New System.Drawing.Point(57, 40)
        Me.TBVentasNit.Name = "TBVentasNit"
        Me.TBVentasNit.Size = New System.Drawing.Size(171, 21)
        Me.TBVentasNit.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(461, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "N° pedido:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(594, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 14)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Cod Cliente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(230, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Barrio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(230, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 14)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Cel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 14)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Tabla de precios:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Fecha O pedido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "O de Pedido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 14)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Cliente:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ButtonAlistarPedidos)
        Me.TabPage2.Controls.Add(Me.ButtonCancelarPedidosParaAlistar)
        Me.TabPage2.Controls.Add(Me.ButtonParaListaDeIngresados)
        Me.TabPage2.Controls.Add(Me.ButtonParaAlistar)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.DGVVentasAlistar)
        Me.TabPage2.Controls.Add(Me.DGVVentasIngresados)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(711, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 20)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Pendientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonAlistarPedidos
        '
        Me.ButtonAlistarPedidos.Location = New System.Drawing.Point(386, 334)
        Me.ButtonAlistarPedidos.Name = "ButtonAlistarPedidos"
        Me.ButtonAlistarPedidos.Size = New System.Drawing.Size(69, 20)
        Me.ButtonAlistarPedidos.TabIndex = 43
        Me.ButtonAlistarPedidos.Text = "Alistar Pedidos"
        Me.ButtonAlistarPedidos.UseVisualStyleBackColor = True
        '
        'ButtonCancelarPedidosParaAlistar
        '
        Me.ButtonCancelarPedidosParaAlistar.Location = New System.Drawing.Point(6, 334)
        Me.ButtonCancelarPedidosParaAlistar.Name = "ButtonCancelarPedidosParaAlistar"
        Me.ButtonCancelarPedidosParaAlistar.Size = New System.Drawing.Size(69, 20)
        Me.ButtonCancelarPedidosParaAlistar.TabIndex = 42
        Me.ButtonCancelarPedidosParaAlistar.Text = "Cancelar"
        Me.ButtonCancelarPedidosParaAlistar.UseVisualStyleBackColor = True
        '
        'ButtonParaListaDeIngresados
        '
        Me.ButtonParaListaDeIngresados.Location = New System.Drawing.Point(339, 67)
        Me.ButtonParaListaDeIngresados.Name = "ButtonParaListaDeIngresados"
        Me.ButtonParaListaDeIngresados.Size = New System.Drawing.Size(41, 20)
        Me.ButtonParaListaDeIngresados.TabIndex = 41
        Me.ButtonParaListaDeIngresados.Text = "<-"
        Me.ButtonParaListaDeIngresados.UseVisualStyleBackColor = True
        '
        'ButtonParaAlistar
        '
        Me.ButtonParaAlistar.Location = New System.Drawing.Point(339, 42)
        Me.ButtonParaAlistar.Name = "ButtonParaAlistar"
        Me.ButtonParaAlistar.Size = New System.Drawing.Size(41, 20)
        Me.ButtonParaAlistar.TabIndex = 40
        Me.ButtonParaAlistar.Text = "->"
        Me.ButtonParaAlistar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(386, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 15)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Pedidos para alistar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 15)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Lista de ingresados"
        '
        'DGVVentasAlistar
        '
        Me.DGVVentasAlistar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVentasAlistar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVVentasAlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentasAlistar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDePedido, Me.Cliente, Me.FechaODePedido, Me.FechaDeEntrega})
        Me.DGVVentasAlistar.Location = New System.Drawing.Point(386, 42)
        Me.DGVVentasAlistar.Name = "DGVVentasAlistar"
        Me.DGVVentasAlistar.RowTemplate.Height = 25
        Me.DGVVentasAlistar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVentasAlistar.Size = New System.Drawing.Size(321, 287)
        Me.DGVVentasAlistar.TabIndex = 1
        '
        'NDePedido
        '
        Me.NDePedido.HeaderText = "N De Pedido"
        Me.NDePedido.Name = "NDePedido"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'FechaODePedido
        '
        Me.FechaODePedido.HeaderText = "Fecha O de Pedido"
        Me.FechaODePedido.Name = "FechaODePedido"
        '
        'FechaDeEntrega
        '
        Me.FechaDeEntrega.HeaderText = "Fecha de entrega"
        Me.FechaDeEntrega.Name = "FechaDeEntrega"
        '
        'DGVVentasIngresados
        '
        Me.DGVVentasIngresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVentasIngresados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVVentasIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentasIngresados.Location = New System.Drawing.Point(6, 42)
        Me.DGVVentasIngresados.MultiSelect = False
        Me.DGVVentasIngresados.Name = "DGVVentasIngresados"
        Me.DGVVentasIngresados.RowTemplate.Height = 25
        Me.DGVVentasIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVentasIngresados.Size = New System.Drawing.Size(327, 287)
        Me.DGVVentasIngresados.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ComboBox4)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.ComboBox3)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.DTP_Hasta)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.DTP_Desde)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.DGVEstados)
        Me.TabPage3.Controls.Add(Me.ButtonVerificarPedido)
        Me.TabPage3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(711, 428)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Incompleto", "Completo"})
        Me.ComboBox4.Location = New System.Drawing.Point(281, 13)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(88, 23)
        Me.ComboBox4.TabIndex = 86
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(234, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 15)
        Me.Label27.TabIndex = 85
        Me.Label27.Text = "Proceso:"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Alistado", "Verificado", "Cerrado"})
        Me.ComboBox3.Location = New System.Drawing.Point(281, 13)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(88, 23)
        Me.ComboBox3.TabIndex = 84
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(234, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 15)
        Me.Label26.TabIndex = 83
        Me.Label26.Text = "Estado:"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.ComboBox2.Location = New System.Drawing.Point(281, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 23)
        Me.ComboBox2.TabIndex = 82
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(234, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 15)
        Me.Label25.TabIndex = 81
        Me.Label25.Text = "Tipo de pago:"
        '
        'DTP_Hasta
        '
        Me.DTP_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Hasta.Location = New System.Drawing.Point(422, 13)
        Me.DTP_Hasta.Name = "DTP_Hasta"
        Me.DTP_Hasta.Size = New System.Drawing.Size(71, 21)
        Me.DTP_Hasta.TabIndex = 80
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(375, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 15)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "Hasta:"
        '
        'DTP_Desde
        '
        Me.DTP_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Desde.Location = New System.Drawing.Point(281, 13)
        Me.DTP_Desde.Name = "DTP_Desde"
        Me.DTP_Desde.Size = New System.Drawing.Size(71, 21)
        Me.DTP_Desde.TabIndex = 78
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(234, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 15)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "Desde:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(234, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 15)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Filtrar:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"N° de pedido", "Cod", "Cliente", "Fecha", "Valor", "Tipo de pago", "Estado", "Valor final", "Fecha de estado", "Fecha de entrega", "Proceso del pedido"})
        Me.ComboBox1.Location = New System.Drawing.Point(76, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 23)
        Me.ComboBox1.TabIndex = 75
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(281, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(303, 21)
        Me.TextBox2.TabIndex = 57
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Filtrar por:"
        '
        'DGVEstados
        '
        Me.DGVEstados.AllowUserToAddRows = False
        Me.DGVEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEstados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPedido, Me.CodCliente, Me.DataGridViewTextBoxColumn1, Me.Fecha, Me.Valor, Me.TipoDePago, Me.Estado, Me.ValorFinal, Me.FechaEstado, Me.Entrega, Me.ProcesoDelPedido})
        Me.DGVEstados.Location = New System.Drawing.Point(7, 46)
        Me.DGVEstados.MultiSelect = False
        Me.DGVEstados.Name = "DGVEstados"
        Me.DGVEstados.RowTemplate.Height = 25
        Me.DGVEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEstados.Size = New System.Drawing.Size(676, 319)
        Me.DGVEstados.TabIndex = 1
        '
        'NPedido
        '
        Me.NPedido.HeaderText = "NPedido"
        Me.NPedido.Name = "NPedido"
        '
        'CodCliente
        '
        Me.CodCliente.HeaderText = "Cod"
        Me.CodCliente.Name = "CodCliente"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'TipoDePago
        '
        Me.TipoDePago.HeaderText = "Tipo de pago"
        Me.TipoDePago.Name = "TipoDePago"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'ValorFinal
        '
        Me.ValorFinal.HeaderText = "Valor final"
        Me.ValorFinal.Name = "ValorFinal"
        '
        'FechaEstado
        '
        Me.FechaEstado.HeaderText = "Fecha de estado"
        Me.FechaEstado.Name = "FechaEstado"
        '
        'Entrega
        '
        Me.Entrega.HeaderText = "Fecha de entrega"
        Me.Entrega.Name = "Entrega"
        '
        'ProcesoDelPedido
        '
        Me.ProcesoDelPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProcesoDelPedido.HeaderText = "Proceso del pedido"
        Me.ProcesoDelPedido.Items.AddRange(New Object() {"Incompleto", "Completo"})
        Me.ProcesoDelPedido.Name = "ProcesoDelPedido"
        '
        'ButtonVerificarPedido
        '
        Me.ButtonVerificarPedido.Location = New System.Drawing.Point(590, 13)
        Me.ButtonVerificarPedido.Name = "ButtonVerificarPedido"
        Me.ButtonVerificarPedido.Size = New System.Drawing.Size(93, 20)
        Me.ButtonVerificarPedido.TabIndex = 0
        Me.ButtonVerificarPedido.Text = "Verificar pedido"
        Me.ButtonVerificarPedido.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.ComboBox8)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.ComboBox7)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.DTPHastaAbono)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.DTPdesdeAbono)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.ComboBox6)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.ButtonAbonar)
        Me.TabPage4.Controls.Add(Me.DGVCobrosVentas)
        Me.TabPage4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(711, 428)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(631, 343)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 19)
        Me.Label38.TabIndex = 99
        Me.Label38.Text = "Saldo:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(561, 343)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 19)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "Saldo:"
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"Con saldo", "Sin saldo"})
        Me.ComboBox8.Location = New System.Drawing.Point(348, 22)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(114, 23)
        Me.ComboBox8.TabIndex = 97
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(280, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 15)
        Me.Label36.TabIndex = 96
        Me.Label36.Text = "Saldo:"
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.ComboBox7.Location = New System.Drawing.Point(348, 22)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(114, 23)
        Me.ComboBox7.TabIndex = 95
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(280, 25)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 15)
        Me.Label35.TabIndex = 94
        Me.Label35.Text = "Tipo de pago:"
        '
        'DTPHastaAbono
        '
        Me.DTPHastaAbono.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHastaAbono.Location = New System.Drawing.Point(486, 22)
        Me.DTPHastaAbono.Name = "DTPHastaAbono"
        Me.DTPHastaAbono.Size = New System.Drawing.Size(71, 21)
        Me.DTPHastaAbono.TabIndex = 93
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(439, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 15)
        Me.Label34.TabIndex = 92
        Me.Label34.Text = "Hasta:"
        '
        'DTPdesdeAbono
        '
        Me.DTPdesdeAbono.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdesdeAbono.Location = New System.Drawing.Point(333, 22)
        Me.DTPdesdeAbono.Name = "DTPdesdeAbono"
        Me.DTPdesdeAbono.Size = New System.Drawing.Size(71, 21)
        Me.DTPdesdeAbono.TabIndex = 91
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(280, 25)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 15)
        Me.Label33.TabIndex = 90
        Me.Label33.Text = "Desde:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(299, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 15)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "Filtrar:"
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"N° factura", "Fecha", "Fecha factura", "Cod cliente", "Cliente", "Tipo de pago", "Fecha vencimiento", "Total", "Saldo"})
        Me.ComboBox6.Location = New System.Drawing.Point(156, 22)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(114, 23)
        Me.ComboBox6.TabIndex = 88
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(361, 22)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(270, 21)
        Me.TextBox3.TabIndex = 87
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(88, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 15)
        Me.Label32.TabIndex = 86
        Me.Label32.Text = "Filtrar por:"
        '
        'ButtonAbonar
        '
        Me.ButtonAbonar.BackColor = System.Drawing.Color.Navy
        Me.ButtonAbonar.FlatAppearance.BorderSize = 0
        Me.ButtonAbonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonAbonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbonar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAbonar.Location = New System.Drawing.Point(18, 22)
        Me.ButtonAbonar.Name = "ButtonAbonar"
        Me.ButtonAbonar.Size = New System.Drawing.Size(64, 20)
        Me.ButtonAbonar.TabIndex = 43
        Me.ButtonAbonar.Text = "Abonar a venta"
        Me.ButtonAbonar.UseVisualStyleBackColor = False
        '
        'DGVCobrosVentas
        '
        Me.DGVCobrosVentas.AllowUserToAddRows = False
        Me.DGVCobrosVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCobrosVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVCobrosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCobrosVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Consecutivo, Me.DataGridViewTextBoxColumn2, Me.FechaFactura, Me.CodClienteCobrar, Me.ClienteCobrar, Me.ContadoCredito, Me.FechaVencimiento, Me.TotalFac, Me.Saldo})
        Me.DGVCobrosVentas.Location = New System.Drawing.Point(18, 57)
        Me.DGVCobrosVentas.MultiSelect = False
        Me.DGVCobrosVentas.Name = "DGVCobrosVentas"
        Me.DGVCobrosVentas.RowTemplate.Height = 25
        Me.DGVCobrosVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCobrosVentas.Size = New System.Drawing.Size(672, 283)
        Me.DGVCobrosVentas.TabIndex = 1
        '
        'Consecutivo
        '
        Me.Consecutivo.HeaderText = "N° factura"
        Me.Consecutivo.Name = "Consecutivo"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FechaFactura
        '
        Me.FechaFactura.HeaderText = "Fecha Factura"
        Me.FechaFactura.Name = "FechaFactura"
        '
        'CodClienteCobrar
        '
        Me.CodClienteCobrar.HeaderText = "Cod Cliente"
        Me.CodClienteCobrar.Name = "CodClienteCobrar"
        '
        'ClienteCobrar
        '
        Me.ClienteCobrar.HeaderText = "Cliente"
        Me.ClienteCobrar.Name = "ClienteCobrar"
        '
        'ContadoCredito
        '
        Me.ContadoCredito.HeaderText = "Contado/Credito"
        Me.ContadoCredito.Name = "ContadoCredito"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.HeaderText = "Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        '
        'TotalFac
        '
        Me.TotalFac.HeaderText = "Total"
        Me.TotalFac.Name = "TotalFac"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 35)
        Me.Panel1.TabIndex = 4
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.FlatAppearance.BorderSize = 0
        Me.RadioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton4.Location = New System.Drawing.Point(231, 36)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "Abonos"
        Me.RadioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(21, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(120, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Ventas"
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton3.Location = New System.Drawing.Point(158, 36)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Estados"
        Me.RadioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton2.Location = New System.Drawing.Point(84, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Ingresados"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButton1.Location = New System.Drawing.Point(10, 36)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nuevo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FacturasDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(715, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FacturasDeVentas"
        Me.Text = "FacturasDeVentas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVVentasDistri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVVentasAlistar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVentasIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DGVCobrosVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents LabelClientes As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TBVentasCodCLiente As TextBox
    Friend WithEvents TBVentasBarrio As TextBox
    Friend WithEvents TBVentasEmail As TextBox
    Friend WithEvents TBVentasCel As TextBox
    Friend WithEvents TBVentasTelefono As TextBox
    Friend WithEvents TBVentasOdePedido As TextBox
    Friend WithEvents TBVentasNit As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBCodVendedor As TextBox
    Friend WithEvents CBVendedor As ComboBox
    Friend WithEvents CBVentasTipodepago As ComboBox
    Friend WithEvents TBVentasDireccion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBVentasCiudad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DGVVentasDistri As DataGridView
    Friend WithEvents CBVentasClientes As ComboBox
    Friend WithEvents TBVentasEnviara As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ButtonDeGuardarVentas As Button
    Friend WithEvents CancelarVenta As Button
    Friend WithEvents DGVVentasIngresados As DataGridView
    Friend WithEvents DGVVentasAlistar As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ButtonParaListaDeIngresados As Button
    Friend WithEvents ButtonParaAlistar As Button
    Friend WithEvents NDePedido As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents FechaODePedido As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeEntrega As DataGridViewTextBoxColumn
    Friend WithEvents ButtonCancelarPedidosParaAlistar As Button
    Friend WithEvents ButtonAlistarPedidos As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TBTotalVentas As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonVerificarPedido As Button
    Friend WithEvents DGVEstados As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DGVCobrosVentas As DataGridView
    Friend WithEvents ButtonAbonar As Button
    Friend WithEvents Consecutivo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteCobrar As DataGridViewTextBoxColumn
    Friend WithEvents ClienteCobrar As DataGridViewTextBoxColumn
    Friend WithEvents ContadoCredito As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents TotalFac As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Protected Friend WithEvents Label20 As Label
    Friend WithEvents CHBIVA As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents DTP_Hasta As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents DTP_Desde As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents NPedido As DataGridViewTextBoxColumn
    Friend WithEvents CodCliente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents TipoDePago As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents ValorFinal As DataGridViewTextBoxColumn
    Friend WithEvents FechaEstado As DataGridViewTextBoxColumn
    Friend WithEvents Entrega As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoDelPedido As DataGridViewComboBoxColumn
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents DTPFechaDeCredito As DateTimePicker
    Friend WithEvents TBDiasDeCredito As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents DTPHastaAbono As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents DTPdesdeAbono As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewComboBoxColumn
    Friend WithEvents VrUnitario As DataGridViewTextBoxColumn
    Friend WithEvents VrTotal As DataGridViewTextBoxColumn
    Friend WithEvents VrUnitarioIVA As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents VrTotalIVA As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents CostoTotal As DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
    Friend WithEvents TBVentasNPedido As Label
End Class
