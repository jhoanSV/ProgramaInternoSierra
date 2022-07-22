<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturasdecompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturasdecompra))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TCFacturasCompra = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TBconsecutivoCompras = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextHoy = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.TBTotalVentas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonGuardarNuevo = New System.Windows.Forms.Button()
        Me.DGVVentas = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoLP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBRTF = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBIvaCompras = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBTelProovedorVentas = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBDireccionProovedorVentas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaDeCredito = New System.Windows.Forms.DateTimePicker()
        Me.TBDiasDeCredito = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBProovedorVentas = New System.Windows.Forms.ComboBox()
        Me.CBNombreColaboradorVentas = New System.Windows.Forms.ComboBox()
        Me.CBContadoOCredito = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBCodigoColaboradorVentas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBNFactuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBCodigoProovedorVentas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.DTPFiltrarHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DTPFiltrarDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.TBbuscarConsecutivo = New System.Windows.Forms.TextBox()
        Me.ButtonAbonar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGVCobros = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ButtonExportarAExcelColaboradores = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DGVProductos_ingresados = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.TCFacturasCompra.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVProductos_ingresados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 60)
        Me.Panel1.TabIndex = 3
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(21, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(153, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Compras"
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
        Me.RadioButton3.Text = "Ingresados"
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
        Me.RadioButton2.Text = "Lista de compras"
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
        Me.RadioButton1.Text = "Compras"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TCFacturasCompra
        '
        Me.TCFacturasCompra.Controls.Add(Me.TabPage1)
        Me.TCFacturasCompra.Controls.Add(Me.TabPage2)
        Me.TCFacturasCompra.Controls.Add(Me.TabPage3)
        Me.TCFacturasCompra.Location = New System.Drawing.Point(0, 41)
        Me.TCFacturasCompra.Name = "TCFacturasCompra"
        Me.TCFacturasCompra.SelectedIndex = 0
        Me.TCFacturasCompra.Size = New System.Drawing.Size(703, 418)
        Me.TCFacturasCompra.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TBconsecutivoCompras)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.ComboBox6)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.TextHoy)
        Me.TabPage1.Controls.Add(Me.ButtonCancelar)
        Me.TabPage1.Controls.Add(Me.TBTotalVentas)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.ButtonGuardarNuevo)
        Me.TabPage1.Controls.Add(Me.DGVVentas)
        Me.TabPage1.Controls.Add(Me.TBRTF)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TBIvaCompras)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TBTelProovedorVentas)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TBDireccionProovedorVentas)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DTPFechaFactura)
        Me.TabPage1.Controls.Add(Me.DTPFechaDeCredito)
        Me.TabPage1.Controls.Add(Me.TBDiasDeCredito)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.CBProovedorVentas)
        Me.TabPage1.Controls.Add(Me.CBNombreColaboradorVentas)
        Me.TabPage1.Controls.Add(Me.CBContadoOCredito)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TBCodigoColaboradorVentas)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TBNFactuta)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TBCodigoProovedorVentas)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(695, 392)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proovedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TBconsecutivoCompras
        '
        Me.TBconsecutivoCompras.AutoSize = True
        Me.TBconsecutivoCompras.Location = New System.Drawing.Point(613, 6)
        Me.TBconsecutivoCompras.Name = "TBconsecutivoCompras"
        Me.TBconsecutivoCompras.Size = New System.Drawing.Size(88, 15)
        Me.TBconsecutivoCompras.TabIndex = 46
        Me.TBconsecutivoCompras.Text = "Consecutivo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(573, 351)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 15)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Total IVA:"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox6.Location = New System.Drawing.Point(253, 69)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(31, 23)
        Me.ComboBox6.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(244, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 15)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(244, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 15)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "*"
        '
        'TextHoy
        '
        Me.TextHoy.AutoSize = True
        Me.TextHoy.Location = New System.Drawing.Point(92, 6)
        Me.TextHoy.Name = "TextHoy"
        Me.TextHoy.Size = New System.Drawing.Size(30, 15)
        Me.TextHoy.TabIndex = 40
        Me.TextHoy.Text = "hoy"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelar.FlatAppearance.BorderSize = 0
        Me.ButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelar.Location = New System.Drawing.Point(550, 73)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelar.TabIndex = 39
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'TBTotalVentas
        '
        Me.TBTotalVentas.Location = New System.Drawing.Point(616, 328)
        Me.TBTotalVentas.Name = "TBTotalVentas"
        Me.TBTotalVentas.Size = New System.Drawing.Size(68, 23)
        Me.TBTotalVentas.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(573, 330)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 15)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Total:"
        '
        'ButtonGuardarNuevo
        '
        Me.ButtonGuardarNuevo.Location = New System.Drawing.Point(620, 73)
        Me.ButtonGuardarNuevo.Name = "ButtonGuardarNuevo"
        Me.ButtonGuardarNuevo.Size = New System.Drawing.Size(64, 20)
        Me.ButtonGuardarNuevo.TabIndex = 35
        Me.ButtonGuardarNuevo.Text = "Guardar"
        Me.ButtonGuardarNuevo.UseVisualStyleBackColor = True
        '
        'DGVVentas
        '
        Me.DGVVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.Descripcion, Me.Costo, Me.Iva, Me.Total, Me.CostoLP})
        Me.DGVVentas.Location = New System.Drawing.Point(7, 98)
        Me.DGVVentas.Name = "DGVVentas"
        Me.DGVVentas.RowTemplate.Height = 25
        Me.DGVVentas.Size = New System.Drawing.Size(677, 230)
        Me.DGVVentas.TabIndex = 34
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Iva
        '
        Me.Iva.HeaderText = "IVA"
        Me.Iva.Name = "Iva"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'CostoLP
        '
        Me.CostoLP.HeaderText = "Costo L.P"
        Me.CostoLP.Name = "CostoLP"
        '
        'TBRTF
        '
        Me.TBRTF.Location = New System.Drawing.Point(322, 69)
        Me.TBRTF.Name = "TBRTF"
        Me.TBRTF.Size = New System.Drawing.Size(68, 23)
        Me.TBRTF.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(290, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "RTF"
        '
        'TBIvaCompras
        '
        Me.TBIvaCompras.Location = New System.Drawing.Point(616, 348)
        Me.TBIvaCompras.Name = "TBIvaCompras"
        Me.TBIvaCompras.Size = New System.Drawing.Size(68, 23)
        Me.TBIvaCompras.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(228, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 15)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "IVA"
        '
        'TBTelProovedorVentas
        '
        Me.TBTelProovedorVentas.Location = New System.Drawing.Point(327, 47)
        Me.TBTelProovedorVentas.Name = "TBTelProovedorVentas"
        Me.TBTelProovedorVentas.Size = New System.Drawing.Size(194, 23)
        Me.TBTelProovedorVentas.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(254, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 15)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Tel Proovedor"
        '
        'TBDireccionProovedorVentas
        '
        Me.TBDireccionProovedorVentas.Location = New System.Drawing.Point(91, 48)
        Me.TBDireccionProovedorVentas.Name = "TBDireccionProovedorVentas"
        Me.TBDireccionProovedorVentas.Size = New System.Drawing.Size(158, 23)
        Me.TBDireccionProovedorVentas.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 15)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Dirección Proovedor"
        '
        'DTPFechaFactura
        '
        Me.DTPFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFactura.Location = New System.Drawing.Point(92, 26)
        Me.DTPFechaFactura.Name = "DTPFechaFactura"
        Me.DTPFechaFactura.Size = New System.Drawing.Size(68, 23)
        Me.DTPFechaFactura.TabIndex = 23
        '
        'DTPFechaDeCredito
        '
        Me.DTPFechaDeCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDeCredito.Location = New System.Drawing.Point(91, 69)
        Me.DTPFechaDeCredito.Name = "DTPFechaDeCredito"
        Me.DTPFechaDeCredito.Size = New System.Drawing.Size(68, 23)
        Me.DTPFechaDeCredito.TabIndex = 22
        '
        'TBDiasDeCredito
        '
        Me.TBDiasDeCredito.Location = New System.Drawing.Point(194, 69)
        Me.TBDiasDeCredito.Name = "TBDiasDeCredito"
        Me.TBDiasDeCredito.Size = New System.Drawing.Size(32, 23)
        Me.TBDiasDeCredito.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Dias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha vencimiento"
        '
        'CBProovedorVentas
        '
        Me.CBProovedorVentas.DropDownHeight = 50
        Me.CBProovedorVentas.FormattingEnabled = True
        Me.CBProovedorVentas.IntegralHeight = False
        Me.CBProovedorVentas.Location = New System.Drawing.Point(394, 4)
        Me.CBProovedorVentas.Name = "CBProovedorVentas"
        Me.CBProovedorVentas.Size = New System.Drawing.Size(127, 23)
        Me.CBProovedorVentas.TabIndex = 18
        '
        'CBNombreColaboradorVentas
        '
        Me.CBNombreColaboradorVentas.DropDownHeight = 50
        Me.CBNombreColaboradorVentas.FormattingEnabled = True
        Me.CBNombreColaboradorVentas.IntegralHeight = False
        Me.CBNombreColaboradorVentas.Location = New System.Drawing.Point(394, 26)
        Me.CBNombreColaboradorVentas.Name = "CBNombreColaboradorVentas"
        Me.CBNombreColaboradorVentas.Size = New System.Drawing.Size(127, 23)
        Me.CBNombreColaboradorVentas.TabIndex = 17
        '
        'CBContadoOCredito
        '
        Me.CBContadoOCredito.FormattingEnabled = True
        Me.CBContadoOCredito.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.CBContadoOCredito.Location = New System.Drawing.Point(615, 48)
        Me.CBContadoOCredito.Name = "CBContadoOCredito"
        Me.CBContadoOCredito.Size = New System.Drawing.Size(69, 23)
        Me.CBContadoOCredito.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Responsable"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(525, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contado/Credito"
        '
        'TBCodigoColaboradorVentas
        '
        Me.TBCodigoColaboradorVentas.Location = New System.Drawing.Point(254, 26)
        Me.TBCodigoColaboradorVentas.Name = "TBCodigoColaboradorVentas"
        Me.TBCodigoColaboradorVentas.Size = New System.Drawing.Size(68, 23)
        Me.TBCodigoColaboradorVentas.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cod Responsable"
        '
        'TBNFactuta
        '
        Me.TBNFactuta.Location = New System.Drawing.Point(616, 25)
        Me.TBNFactuta.Name = "TBNFactuta"
        Me.TBNFactuta.Size = New System.Drawing.Size(68, 23)
        Me.TBNFactuta.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "N° Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Consecutivo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proovedor"
        '
        'TBCodigoProovedorVentas
        '
        Me.TBCodigoProovedorVentas.Location = New System.Drawing.Point(254, 5)
        Me.TBCodigoProovedorVentas.Name = "TBCodigoProovedorVentas"
        Me.TBCodigoProovedorVentas.Size = New System.Drawing.Size(68, 23)
        Me.TBCodigoProovedorVentas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cod Proovedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Me.DTPFiltrarHasta)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.DTPFiltrarDesde)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.CBFiltro)
        Me.TabPage2.Controls.Add(Me.TBbuscarConsecutivo)
        Me.TabPage2.Controls.Add(Me.ButtonAbonar)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.DGVCobros)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(695, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(611, 317)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 18)
        Me.Label27.TabIndex = 101
        Me.Label27.Text = "Filtrar por:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(537, 317)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 18)
        Me.Label26.TabIndex = 100
        Me.Label26.Text = "Saldo:"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Con saldo", "Sin saldo"})
        Me.ComboBox4.Location = New System.Drawing.Point(396, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox4.TabIndex = 51
        '
        'DTPFiltrarHasta
        '
        Me.DTPFiltrarHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFiltrarHasta.Location = New System.Drawing.Point(611, 16)
        Me.DTPFiltrarHasta.Name = "DTPFiltrarHasta"
        Me.DTPFiltrarHasta.Size = New System.Drawing.Size(68, 21)
        Me.DTPFiltrarHasta.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(556, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 14)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Hasta:"
        '
        'DTPFiltrarDesde
        '
        Me.DTPFiltrarDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFiltrarDesde.Location = New System.Drawing.Point(451, 16)
        Me.DTPFiltrarDesde.Name = "DTPFiltrarDesde"
        Me.DTPFiltrarDesde.Size = New System.Drawing.Size(68, 21)
        Me.DTPFiltrarDesde.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(396, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 14)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Desde:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.ComboBox2.Location = New System.Drawing.Point(396, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(224, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 14)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Filtrar por:"
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Items.AddRange(New Object() {"Consecutivo", "Fecha", "Cod proveedor", "Proveedor", "Contado o Credito", "Fecha factura", "Fecha vencimiento", "Saldo"})
        Me.CBFiltro.Location = New System.Drawing.Point(269, 16)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(121, 22)
        Me.CBFiltro.TabIndex = 44
        '
        'TBbuscarConsecutivo
        '
        Me.TBbuscarConsecutivo.Location = New System.Drawing.Point(396, 16)
        Me.TBbuscarConsecutivo.Name = "TBbuscarConsecutivo"
        Me.TBbuscarConsecutivo.Size = New System.Drawing.Size(283, 21)
        Me.TBbuscarConsecutivo.TabIndex = 43
        '
        'ButtonAbonar
        '
        Me.ButtonAbonar.BackColor = System.Drawing.Color.Navy
        Me.ButtonAbonar.FlatAppearance.BorderSize = 0
        Me.ButtonAbonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonAbonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbonar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAbonar.Location = New System.Drawing.Point(155, 16)
        Me.ButtonAbonar.Name = "ButtonAbonar"
        Me.ButtonAbonar.Size = New System.Drawing.Size(64, 20)
        Me.ButtonAbonar.TabIndex = 42
        Me.ButtonAbonar.Text = "Abonar a compra"
        Me.ButtonAbonar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(85, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 20)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Modificar compra"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DGVCobros
        '
        Me.DGVCobros.AllowUserToAddRows = False
        Me.DGVCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCobros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCobros.Location = New System.Drawing.Point(7, 41)
        Me.DGVCobros.Name = "DGVCobros"
        Me.DGVCobros.RowTemplate.Height = 25
        Me.DGVCobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCobros.Size = New System.Drawing.Size(672, 273)
        Me.DGVCobros.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DateTimePicker3)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.DateTimePicker2)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.ButtonExportarAExcelColaboradores)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.DGVProductos_ingresados)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.ComboBox5)
        Me.TabPage3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(695, 392)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(437, 27)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(68, 21)
        Me.DateTimePicker3.TabIndex = 97
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(382, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "Hasta:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(247, 27)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(68, 21)
        Me.DateTimePicker2.TabIndex = 95
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(192, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "Desde:"
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
        Me.ButtonExportarAExcelColaboradores.Location = New System.Drawing.Point(556, 19)
        Me.ButtonExportarAExcelColaboradores.Name = "ButtonExportarAExcelColaboradores"
        Me.ButtonExportarAExcelColaboradores.Size = New System.Drawing.Size(113, 35)
        Me.ButtonExportarAExcelColaboradores.TabIndex = 93
        Me.ButtonExportarAExcelColaboradores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelColaboradores.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(313, 21)
        Me.TextBox1.TabIndex = 49
        '
        'DGVProductos_ingresados
        '
        Me.DGVProductos_ingresados.AllowUserToAddRows = False
        Me.DGVProductos_ingresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProductos_ingresados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVProductos_ingresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos_ingresados.Location = New System.Drawing.Point(23, 64)
        Me.DGVProductos_ingresados.Name = "DGVProductos_ingresados"
        Me.DGVProductos_ingresados.Size = New System.Drawing.Size(646, 272)
        Me.DGVProductos_ingresados.TabIndex = 48
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 14)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Filtrar por:"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Consecutivo", "Cod producto", "Producto", "Cod proveedor", "Proveedor", "Fecha", "Fecha factura", "N° Factura"})
        Me.ComboBox5.Location = New System.Drawing.Point(65, 27)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox5.TabIndex = 46
        '
        'Facturasdecompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(711, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TCFacturasCompra)
        Me.Name = "Facturasdecompra"
        Me.Text = "Facturasdecompra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TCFacturasCompra.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVProductos_ingresados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelClientes As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TCFacturasCompra As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents TBCodigoProovedorVentas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaFactura As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBDiasDeCredito As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CBNombreColaboradorVentas As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBCodigoColaboradorVentas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBNFactuta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVVentas As DataGridView
    Friend WithEvents TBRTF As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBIvaCompras As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBTelProovedorVentas As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBDireccionProovedorVentas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CBProovedorVentas As ComboBox
    Friend WithEvents TBProovedorVentas As TextBox
    Friend WithEvents CBContadoOCredito As ComboBox
    Friend WithEvents DTPFechaDeCredito As DateTimePicker
    Friend WithEvents ButtonGuardarNuevo As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents TBTotalProductos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TBTotalVentas As TextBox
    Friend WithEvents DGVCobros As DataGridView
    Friend WithEvents ButtonAbonar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextHoy As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents TBbuscarConsecutivo As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPFiltrarHasta As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents DTPFiltrarDesde As DateTimePicker
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGVProductos_ingresados As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ButtonExportarAExcelColaboradores As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewComboBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents CostoLP As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TBconsecutivoCompras As Label
End Class
