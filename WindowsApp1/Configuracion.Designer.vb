<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonExportarAExcelColaboradores = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVEntradas = New System.Windows.Forms.DataGridView()
        Me.Consecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NFacrura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoLP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RTF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContadoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVAlistados = New System.Windows.Forms.DataGridView()
        Me.NPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADescripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posición = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVVerificados = New System.Windows.Forms.DataGridView()
        Me.NDePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ODePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VDescripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrUnitarioIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrTotalIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConOSinIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGVSalidas = New System.Windows.Forms.DataGridView()
        Me.SNDePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EODePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDescripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVrUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVrTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVrUnitarioIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVrTotalIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGanancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCodColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFechaOPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STipoDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFechaDeIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STieneIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFechaVencimiemto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DGVAnulados = New System.Windows.Forms.DataGridView()
        Me.AnNDePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnODePedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnDescripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnVrUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnVrTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnVrUnitarioIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnVrTotalIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnGanancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnSubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnCodColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnFechaOPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnFechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnTipoDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnUbicación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnConOSinIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.NUDVenta = New System.Windows.Forms.NumericUpDown()
        Me.NUDCompra = New System.Windows.Forms.NumericUpDown()
        Me.NconsecutivoVenta = New System.Windows.Forms.Label()
        Me.NconsecutivoCompra = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButtonNuevo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEliminarColaboradores = New System.Windows.Forms.RadioButton()
        Me.RadioButtonListaColaboradores = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVAlistados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGVVerificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DGVAnulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.NUDVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButtonNuevo)
        Me.Panel1.Controls.Add(Me.RadioButtonEliminarColaboradores)
        Me.Panel1.Controls.Add(Me.RadioButtonListaColaboradores)
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 60)
        Me.Panel1.TabIndex = 5
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(21, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(236, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Configuración"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 600)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(695, 572)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(574, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 35)
        Me.Button6.TabIndex = 96
        Me.Button6.Text = "Cargar datos"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Importar datos de excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(684, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonExportarAExcelColaboradores)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.DGVEntradas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(695, 578)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.ButtonExportarAExcelColaboradores.Location = New System.Drawing.Point(574, 29)
        Me.ButtonExportarAExcelColaboradores.Name = "ButtonExportarAExcelColaboradores"
        Me.ButtonExportarAExcelColaboradores.Size = New System.Drawing.Size(113, 35)
        Me.ButtonExportarAExcelColaboradores.TabIndex = 93
        Me.ButtonExportarAExcelColaboradores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelColaboradores.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Entradas"
        '
        'DGVEntradas
        '
        Me.DGVEntradas.AllowUserToAddRows = False
        Me.DGVEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Consecutivo, Me.NFacrura, Me.CodProveedor, Me.Proveedor, Me.Cantidad, Me.Codigo, Me.Descripción, Me.Costo, Me.Total, Me.CostoLP, Me.Fecha, Me.FechaFactura, Me.FechaVencimiento, Me.Dias, Me.IVA, Me.RTF, Me.CodResponsable, Me.Responsable, Me.ContadoCredito, Me.Hora, Me.ConIva})
        Me.DGVEntradas.Location = New System.Drawing.Point(5, 70)
        Me.DGVEntradas.Name = "DGVEntradas"
        Me.DGVEntradas.Size = New System.Drawing.Size(679, 400)
        Me.DGVEntradas.TabIndex = 0
        '
        'Consecutivo
        '
        Me.Consecutivo.HeaderText = "Consecutivo"
        Me.Consecutivo.Name = "Consecutivo"
        '
        'NFacrura
        '
        Me.NFacrura.HeaderText = "NFacrura"
        Me.NFacrura.Name = "NFacrura"
        '
        'CodProveedor
        '
        Me.CodProveedor.HeaderText = "CodProveedor"
        Me.CodProveedor.Name = "CodProveedor"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
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
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'CostoLP
        '
        Me.CostoLP.HeaderText = "CostoLP"
        Me.CostoLP.Name = "CostoLP"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'FechaFactura
        '
        Me.FechaFactura.HeaderText = "FechaFactura"
        Me.FechaFactura.Name = "FechaFactura"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.HeaderText = "FechaVencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        '
        'Dias
        '
        Me.Dias.HeaderText = "Dias"
        Me.Dias.Name = "Dias"
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        '
        'RTF
        '
        Me.RTF.HeaderText = "RTF"
        Me.RTF.Name = "RTF"
        '
        'CodResponsable
        '
        Me.CodResponsable.HeaderText = "CodResponsable"
        Me.CodResponsable.Name = "CodResponsable"
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        '
        'ContadoCredito
        '
        Me.ContadoCredito.HeaderText = "ContadoCredito"
        Me.ContadoCredito.Name = "ContadoCredito"
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'ConIva
        '
        Me.ConIva.HeaderText = "ConIva"
        Me.ConIva.Name = "ConIva"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.DGVAlistados)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(695, 578)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(574, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 35)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Exportar a Excel"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alistados"
        '
        'DGVAlistados
        '
        Me.DGVAlistados.AllowUserToAddRows = False
        Me.DGVAlistados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAlistados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPedido, Me.Cliente, Me.ACantidad, Me.Cod, Me.ADescripción, Me.Inventario, Me.Posición})
        Me.DGVAlistados.Location = New System.Drawing.Point(5, 70)
        Me.DGVAlistados.Name = "DGVAlistados"
        Me.DGVAlistados.Size = New System.Drawing.Size(679, 400)
        Me.DGVAlistados.TabIndex = 0
        '
        'NPedido
        '
        Me.NPedido.HeaderText = "NPedido"
        Me.NPedido.Name = "NPedido"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'ACantidad
        '
        Me.ACantidad.HeaderText = "Cantidad"
        Me.ACantidad.Name = "ACantidad"
        '
        'Cod
        '
        Me.Cod.HeaderText = "Cod"
        Me.Cod.Name = "Cod"
        '
        'ADescripción
        '
        Me.ADescripción.HeaderText = "Descripción"
        Me.ADescripción.Name = "ADescripción"
        '
        'Inventario
        '
        Me.Inventario.HeaderText = "Inventario"
        Me.Inventario.Name = "Inventario"
        '
        'Posición
        '
        Me.Posición.HeaderText = "Posición"
        Me.Posición.Name = "Posición"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.DGVVerificados)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(695, 578)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(574, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 35)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "Exportar a Excel"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Verificados"
        '
        'DGVVerificados
        '
        Me.DGVVerificados.AllowUserToAddRows = False
        Me.DGVVerificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVerificados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDePedido, Me.ODePedido, Me.VCantidad, Me.vCodigo, Me.VDescripción, Me.VrUnitario, Me.VrTotal, Me.VrUnitarioIVA, Me.VIVA, Me.VrTotalIVA, Me.VCosto, Me.CostoTotal, Me.Ganancia, Me.Porcentaje, Me.Categoria, Me.SubCategoria, Me.VProveedor, Me.CodCliente, Me.VCliente, Me.CodColaborador, Me.Colaborador, Me.FechaOPedido, Me.FechaEntrega, Me.TipoDePago, Me.Ubicación, Me.VHora, Me.VEstado, Me.ConOSinIVA})
        Me.DGVVerificados.Location = New System.Drawing.Point(5, 70)
        Me.DGVVerificados.Name = "DGVVerificados"
        Me.DGVVerificados.Size = New System.Drawing.Size(679, 400)
        Me.DGVVerificados.TabIndex = 0
        '
        'NDePedido
        '
        Me.NDePedido.HeaderText = "NDePedido"
        Me.NDePedido.Name = "NDePedido"
        '
        'ODePedido
        '
        Me.ODePedido.HeaderText = "ODePedido"
        Me.ODePedido.Name = "ODePedido"
        '
        'VCantidad
        '
        Me.VCantidad.HeaderText = "Cantidad"
        Me.VCantidad.Name = "VCantidad"
        '
        'vCodigo
        '
        Me.vCodigo.HeaderText = "Codigo"
        Me.vCodigo.Name = "vCodigo"
        '
        'VDescripción
        '
        Me.VDescripción.HeaderText = "Descripción"
        Me.VDescripción.Name = "VDescripción"
        '
        'VrUnitario
        '
        Me.VrUnitario.HeaderText = "VrUnitario"
        Me.VrUnitario.Name = "VrUnitario"
        '
        'VrTotal
        '
        Me.VrTotal.HeaderText = "VrTotal"
        Me.VrTotal.Name = "VrTotal"
        '
        'VrUnitarioIVA
        '
        Me.VrUnitarioIVA.HeaderText = "VrUnitarioIVA"
        Me.VrUnitarioIVA.Name = "VrUnitarioIVA"
        '
        'VIVA
        '
        Me.VIVA.HeaderText = "IVA"
        Me.VIVA.Name = "VIVA"
        '
        'VrTotalIVA
        '
        Me.VrTotalIVA.HeaderText = "VrTotalIVA"
        Me.VrTotalIVA.Name = "VrTotalIVA"
        '
        'VCosto
        '
        Me.VCosto.HeaderText = "Costo"
        Me.VCosto.Name = "VCosto"
        '
        'CostoTotal
        '
        Me.CostoTotal.HeaderText = "CostoTotal"
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
        Me.SubCategoria.HeaderText = "SubCategoria"
        Me.SubCategoria.Name = "SubCategoria"
        '
        'VProveedor
        '
        Me.VProveedor.HeaderText = "Proveedor"
        Me.VProveedor.Name = "VProveedor"
        '
        'CodCliente
        '
        Me.CodCliente.HeaderText = "CodCliente"
        Me.CodCliente.Name = "CodCliente"
        '
        'VCliente
        '
        Me.VCliente.HeaderText = "Cliente"
        Me.VCliente.Name = "VCliente"
        '
        'CodColaborador
        '
        Me.CodColaborador.HeaderText = "CodColaborador"
        Me.CodColaborador.Name = "CodColaborador"
        '
        'Colaborador
        '
        Me.Colaborador.HeaderText = "Colaborador"
        Me.Colaborador.Name = "Colaborador"
        '
        'FechaOPedido
        '
        Me.FechaOPedido.HeaderText = "FechaOPedido"
        Me.FechaOPedido.Name = "FechaOPedido"
        '
        'FechaEntrega
        '
        Me.FechaEntrega.HeaderText = "FechaEntrega"
        Me.FechaEntrega.Name = "FechaEntrega"
        '
        'TipoDePago
        '
        Me.TipoDePago.HeaderText = "TipoDePago"
        Me.TipoDePago.Name = "TipoDePago"
        '
        'Ubicación
        '
        Me.Ubicación.HeaderText = "Ubicación"
        Me.Ubicación.Name = "Ubicación"
        '
        'VHora
        '
        Me.VHora.HeaderText = "Hora"
        Me.VHora.Name = "VHora"
        '
        'VEstado
        '
        Me.VEstado.HeaderText = "Estado"
        Me.VEstado.Name = "VEstado"
        '
        'ConOSinIVA
        '
        Me.ConOSinIVA.HeaderText = "ConOSinIVA"
        Me.ConOSinIVA.Name = "ConOSinIVA"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.DGVSalidas)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(695, 578)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.ForestGreen
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(574, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 35)
        Me.Button4.TabIndex = 93
        Me.Button4.Text = "Exportar a Excel"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DGVSalidas
        '
        Me.DGVSalidas.AllowUserToAddRows = False
        Me.DGVSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNDePedido, Me.EODePedido, Me.SCantidad, Me.SCodigo, Me.SDescripción, Me.SVrUnitario, Me.SVrTotal, Me.SVrUnitarioIVA, Me.SIVA, Me.SVrTotalIVA, Me.SCosto, Me.SCostoTotal, Me.SGanancia, Me.SPorcentaje, Me.SCategoria, Me.SSubCategoria, Me.SProveedor, Me.SCodCliente, Me.SCliente, Me.SCodColaborador, Me.SColaborador, Me.SFechaOPedido, Me.SFechaEntrega, Me.STipoDePago, Me.SFechaDeIngreso, Me.SHora, Me.STieneIVA, Me.SFechaVencimiemto})
        Me.DGVSalidas.Location = New System.Drawing.Point(5, 70)
        Me.DGVSalidas.Name = "DGVSalidas"
        Me.DGVSalidas.Size = New System.Drawing.Size(679, 400)
        Me.DGVSalidas.TabIndex = 3
        '
        'SNDePedido
        '
        Me.SNDePedido.HeaderText = "NDePedido"
        Me.SNDePedido.Name = "SNDePedido"
        '
        'EODePedido
        '
        Me.EODePedido.HeaderText = "ODePedido"
        Me.EODePedido.Name = "EODePedido"
        '
        'SCantidad
        '
        Me.SCantidad.HeaderText = "Cantidad"
        Me.SCantidad.Name = "SCantidad"
        '
        'SCodigo
        '
        Me.SCodigo.HeaderText = "Codigo"
        Me.SCodigo.Name = "SCodigo"
        '
        'SDescripción
        '
        Me.SDescripción.HeaderText = "Descripción"
        Me.SDescripción.Name = "SDescripción"
        '
        'SVrUnitario
        '
        Me.SVrUnitario.HeaderText = "VrUnitario"
        Me.SVrUnitario.Name = "SVrUnitario"
        '
        'SVrTotal
        '
        Me.SVrTotal.HeaderText = "VrTotal"
        Me.SVrTotal.Name = "SVrTotal"
        '
        'SVrUnitarioIVA
        '
        Me.SVrUnitarioIVA.HeaderText = "VrUnitarioIVA"
        Me.SVrUnitarioIVA.Name = "SVrUnitarioIVA"
        '
        'SIVA
        '
        Me.SIVA.HeaderText = "IVA"
        Me.SIVA.Name = "SIVA"
        '
        'SVrTotalIVA
        '
        Me.SVrTotalIVA.HeaderText = "VrTotalIVA"
        Me.SVrTotalIVA.Name = "SVrTotalIVA"
        '
        'SCosto
        '
        Me.SCosto.HeaderText = "Costo"
        Me.SCosto.Name = "SCosto"
        '
        'SCostoTotal
        '
        Me.SCostoTotal.HeaderText = "CostoTotal"
        Me.SCostoTotal.Name = "SCostoTotal"
        '
        'SGanancia
        '
        Me.SGanancia.HeaderText = "Ganancia"
        Me.SGanancia.Name = "SGanancia"
        '
        'SPorcentaje
        '
        Me.SPorcentaje.HeaderText = "Porcentaje"
        Me.SPorcentaje.Name = "SPorcentaje"
        '
        'SCategoria
        '
        Me.SCategoria.HeaderText = "Categoria"
        Me.SCategoria.Name = "SCategoria"
        '
        'SSubCategoria
        '
        Me.SSubCategoria.HeaderText = "SubCategoria"
        Me.SSubCategoria.Name = "SSubCategoria"
        '
        'SProveedor
        '
        Me.SProveedor.HeaderText = "Proveedor"
        Me.SProveedor.Name = "SProveedor"
        '
        'SCodCliente
        '
        Me.SCodCliente.HeaderText = "CodCliente"
        Me.SCodCliente.Name = "SCodCliente"
        '
        'SCliente
        '
        Me.SCliente.HeaderText = "Cliente"
        Me.SCliente.Name = "SCliente"
        '
        'SCodColaborador
        '
        Me.SCodColaborador.HeaderText = "CodColaborador"
        Me.SCodColaborador.Name = "SCodColaborador"
        '
        'SColaborador
        '
        Me.SColaborador.HeaderText = "Colaborador"
        Me.SColaborador.Name = "SColaborador"
        '
        'SFechaOPedido
        '
        Me.SFechaOPedido.HeaderText = "FechaOPedido"
        Me.SFechaOPedido.Name = "SFechaOPedido"
        '
        'SFechaEntrega
        '
        Me.SFechaEntrega.HeaderText = "FechaEntrega"
        Me.SFechaEntrega.Name = "SFechaEntrega"
        '
        'STipoDePago
        '
        Me.STipoDePago.HeaderText = "TipoDePago"
        Me.STipoDePago.Name = "STipoDePago"
        '
        'SFechaDeIngreso
        '
        Me.SFechaDeIngreso.HeaderText = "FechaDeIngreso"
        Me.SFechaDeIngreso.Name = "SFechaDeIngreso"
        '
        'SHora
        '
        Me.SHora.HeaderText = "Hora"
        Me.SHora.Name = "SHora"
        '
        'STieneIVA
        '
        Me.STieneIVA.HeaderText = "TieneIVA"
        Me.STieneIVA.Name = "STieneIVA"
        '
        'SFechaVencimiemto
        '
        Me.SFechaVencimiemto.HeaderText = "FechaVencimiemto"
        Me.SFechaVencimiemto.Name = "SFechaVencimiemto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Salidas"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DGVAnulados)
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(695, 578)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DGVAnulados
        '
        Me.DGVAnulados.AllowUserToAddRows = False
        Me.DGVAnulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnulados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnNDePedido, Me.AnODePedido, Me.AnCantidad, Me.AnCodigo, Me.AnDescripción, Me.AnVrUnitario, Me.AnVrTotal, Me.AnVrUnitarioIVA, Me.AnIVA, Me.AnVrTotalIVA, Me.AnCosto, Me.AnCostoTotal, Me.AnGanancia, Me.AnPorcentaje, Me.AnCategoria, Me.AnSubCategoria, Me.AnProveedor, Me.AnCodCliente, Me.AnCliente, Me.AnCodColaborador, Me.AnColaborador, Me.AnFechaOPedido, Me.AnFechaEntrega, Me.AnTipoDePago, Me.AnUbicación, Me.AnHora, Me.AnEstado, Me.AnConOSinIVA})
        Me.DGVAnulados.Location = New System.Drawing.Point(5, 70)
        Me.DGVAnulados.Name = "DGVAnulados"
        Me.DGVAnulados.Size = New System.Drawing.Size(679, 400)
        Me.DGVAnulados.TabIndex = 96
        '
        'AnNDePedido
        '
        Me.AnNDePedido.HeaderText = "NDePedido"
        Me.AnNDePedido.Name = "AnNDePedido"
        '
        'AnODePedido
        '
        Me.AnODePedido.HeaderText = "ODePedido"
        Me.AnODePedido.Name = "AnODePedido"
        '
        'AnCantidad
        '
        Me.AnCantidad.HeaderText = "Cantidad"
        Me.AnCantidad.Name = "AnCantidad"
        '
        'AnCodigo
        '
        Me.AnCodigo.HeaderText = "Codigo"
        Me.AnCodigo.Name = "AnCodigo"
        '
        'AnDescripción
        '
        Me.AnDescripción.HeaderText = "Descripción"
        Me.AnDescripción.Name = "AnDescripción"
        '
        'AnVrUnitario
        '
        Me.AnVrUnitario.HeaderText = "VrUnitario"
        Me.AnVrUnitario.Name = "AnVrUnitario"
        '
        'AnVrTotal
        '
        Me.AnVrTotal.HeaderText = "VrTotal"
        Me.AnVrTotal.Name = "AnVrTotal"
        '
        'AnVrUnitarioIVA
        '
        Me.AnVrUnitarioIVA.HeaderText = "VrUnitarioIVA"
        Me.AnVrUnitarioIVA.Name = "AnVrUnitarioIVA"
        '
        'AnIVA
        '
        Me.AnIVA.HeaderText = "IVA"
        Me.AnIVA.Name = "AnIVA"
        '
        'AnVrTotalIVA
        '
        Me.AnVrTotalIVA.HeaderText = "VrTotalIVA"
        Me.AnVrTotalIVA.Name = "AnVrTotalIVA"
        '
        'AnCosto
        '
        Me.AnCosto.HeaderText = "Costo"
        Me.AnCosto.Name = "AnCosto"
        '
        'AnCostoTotal
        '
        Me.AnCostoTotal.HeaderText = "CostoTotal"
        Me.AnCostoTotal.Name = "AnCostoTotal"
        '
        'AnGanancia
        '
        Me.AnGanancia.HeaderText = "Ganancia"
        Me.AnGanancia.Name = "AnGanancia"
        '
        'AnPorcentaje
        '
        Me.AnPorcentaje.HeaderText = "Porcentaje"
        Me.AnPorcentaje.Name = "AnPorcentaje"
        '
        'AnCategoria
        '
        Me.AnCategoria.HeaderText = "Categoria"
        Me.AnCategoria.Name = "AnCategoria"
        '
        'AnSubCategoria
        '
        Me.AnSubCategoria.HeaderText = "SubCategoria"
        Me.AnSubCategoria.Name = "AnSubCategoria"
        '
        'AnProveedor
        '
        Me.AnProveedor.HeaderText = "Proveedor"
        Me.AnProveedor.Name = "AnProveedor"
        '
        'AnCodCliente
        '
        Me.AnCodCliente.HeaderText = "CodCliente"
        Me.AnCodCliente.Name = "AnCodCliente"
        '
        'AnCliente
        '
        Me.AnCliente.HeaderText = "Cliente"
        Me.AnCliente.Name = "AnCliente"
        '
        'AnCodColaborador
        '
        Me.AnCodColaborador.HeaderText = "CodColaborador"
        Me.AnCodColaborador.Name = "AnCodColaborador"
        '
        'AnColaborador
        '
        Me.AnColaborador.HeaderText = "Colaborador"
        Me.AnColaborador.Name = "AnColaborador"
        '
        'AnFechaOPedido
        '
        Me.AnFechaOPedido.HeaderText = "FechaOPedido"
        Me.AnFechaOPedido.Name = "AnFechaOPedido"
        '
        'AnFechaEntrega
        '
        Me.AnFechaEntrega.HeaderText = "FechaEntrega"
        Me.AnFechaEntrega.Name = "AnFechaEntrega"
        '
        'AnTipoDePago
        '
        Me.AnTipoDePago.HeaderText = "TipoDePago"
        Me.AnTipoDePago.Name = "AnTipoDePago"
        '
        'AnUbicación
        '
        Me.AnUbicación.HeaderText = "Ubicación"
        Me.AnUbicación.Name = "AnUbicación"
        '
        'AnHora
        '
        Me.AnHora.HeaderText = "Hora"
        Me.AnHora.Name = "AnHora"
        '
        'AnEstado
        '
        Me.AnEstado.HeaderText = "Estado"
        Me.AnEstado.Name = "AnEstado"
        '
        'AnConOSinIVA
        '
        Me.AnConOSinIVA.HeaderText = "ConOSinIVA"
        Me.AnConOSinIVA.Name = "AnConOSinIVA"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.ForestGreen
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(574, 29)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 35)
        Me.Button5.TabIndex = 95
        Me.Button5.Text = "Exportar a Excel"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(331, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Anulados"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.NUDVenta)
        Me.TabPage7.Controls.Add(Me.NUDCompra)
        Me.TabPage7.Controls.Add(Me.NconsecutivoVenta)
        Me.TabPage7.Controls.Add(Me.NconsecutivoCompra)
        Me.TabPage7.Controls.Add(Me.Button8)
        Me.TabPage7.Controls.Add(Me.Button7)
        Me.TabPage7.Controls.Add(Me.Label7)
        Me.TabPage7.Controls.Add(Me.Label6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(695, 578)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'NUDVenta
        '
        Me.NUDVenta.Location = New System.Drawing.Point(111, 73)
        Me.NUDVenta.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUDVenta.Name = "NUDVenta"
        Me.NUDVenta.Size = New System.Drawing.Size(86, 21)
        Me.NUDVenta.TabIndex = 49
        '
        'NUDCompra
        '
        Me.NUDCompra.Location = New System.Drawing.Point(111, 34)
        Me.NUDCompra.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUDCompra.Name = "NUDCompra"
        Me.NUDCompra.Size = New System.Drawing.Size(86, 21)
        Me.NUDCompra.TabIndex = 48
        '
        'NconsecutivoVenta
        '
        Me.NconsecutivoVenta.AutoSize = True
        Me.NconsecutivoVenta.Location = New System.Drawing.Point(108, 57)
        Me.NconsecutivoVenta.Name = "NconsecutivoVenta"
        Me.NconsecutivoVenta.Size = New System.Drawing.Size(154, 15)
        Me.NconsecutivoVenta.TabIndex = 7
        Me.NconsecutivoVenta.Text = "N° Consecutivo de compra"
        '
        'NconsecutivoCompra
        '
        Me.NconsecutivoCompra.AutoSize = True
        Me.NconsecutivoCompra.Location = New System.Drawing.Point(108, 21)
        Me.NconsecutivoCompra.Name = "NconsecutivoCompra"
        Me.NconsecutivoCompra.Size = New System.Drawing.Size(151, 15)
        Me.NconsecutivoCompra.TabIndex = 6
        Me.NconsecutivoCompra.Text = "N°Consecutivo de compra"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(217, 71)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Guardar consecutivo venta"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(217, 32)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Guardar consecutivo compra"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Consecutivo de venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Consecutivo de compra"
        '
        'RadioButtonNuevo
        '
        Me.RadioButtonNuevo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonNuevo.Checked = True
        Me.RadioButtonNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonNuevo.FlatAppearance.BorderSize = 0
        Me.RadioButtonNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButtonNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonNuevo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButtonNuevo.Location = New System.Drawing.Point(0, 35)
        Me.RadioButtonNuevo.Name = "RadioButtonNuevo"
        Me.RadioButtonNuevo.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonNuevo.TabIndex = 7
        Me.RadioButtonNuevo.TabStop = True
        Me.RadioButtonNuevo.Text = "Importar"
        Me.RadioButtonNuevo.UseVisualStyleBackColor = True
        '
        'RadioButtonEliminarColaboradores
        '
        Me.RadioButtonEliminarColaboradores.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonEliminarColaboradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonEliminarColaboradores.FlatAppearance.BorderSize = 0
        Me.RadioButtonEliminarColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButtonEliminarColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButtonEliminarColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonEliminarColaboradores.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButtonEliminarColaboradores.Location = New System.Drawing.Point(194, 35)
        Me.RadioButtonEliminarColaboradores.Name = "RadioButtonEliminarColaboradores"
        Me.RadioButtonEliminarColaboradores.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonEliminarColaboradores.TabIndex = 6
        Me.RadioButtonEliminarColaboradores.Text = "Verificados"
        Me.RadioButtonEliminarColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButtonEliminarColaboradores.UseVisualStyleBackColor = True
        '
        'RadioButtonListaColaboradores
        '
        Me.RadioButtonListaColaboradores.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonListaColaboradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButtonListaColaboradores.FlatAppearance.BorderSize = 0
        Me.RadioButtonListaColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RadioButtonListaColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RadioButtonListaColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonListaColaboradores.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RadioButtonListaColaboradores.Location = New System.Drawing.Point(129, 35)
        Me.RadioButtonListaColaboradores.Name = "RadioButtonListaColaboradores"
        Me.RadioButtonListaColaboradores.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonListaColaboradores.TabIndex = 5
        Me.RadioButtonListaColaboradores.Text = "Alistados"
        Me.RadioButtonListaColaboradores.UseVisualStyleBackColor = True
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
        Me.RadioButton1.Location = New System.Drawing.Point(256, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "Salidas"
        Me.RadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        Me.RadioButton2.Location = New System.Drawing.Point(321, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Anulados"
        Me.RadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton2.UseVisualStyleBackColor = True
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
        Me.RadioButton3.Location = New System.Drawing.Point(403, 35)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "Consecutivos"
        Me.RadioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        Me.RadioButton4.Location = New System.Drawing.Point(387, 35)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.Text = "Consecutivos"
        Me.RadioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton4.UseVisualStyleBackColor = True
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
        Me.RadioButton5.Location = New System.Drawing.Point(63, 35)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(69, 25)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.Text = "Entradas"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(711, 634)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Configuracion"
        Me.Text = "Confguración"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVAlistados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DGVVerificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.DGVAnulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.NUDVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelClientes As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVEntradas As DataGridView
    Friend WithEvents Consecutivo As DataGridViewTextBoxColumn
    Friend WithEvents NFacrura As DataGridViewTextBoxColumn
    Friend WithEvents CodProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents CostoLP As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents FechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Dias As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents RTF As DataGridViewTextBoxColumn
    Friend WithEvents CodResponsable As DataGridViewTextBoxColumn
    Friend WithEvents Responsable As DataGridViewTextBoxColumn
    Friend WithEvents ContadoCredito As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents ConIva As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DGVAlistados As DataGridView
    Friend WithEvents NPedido As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents ACantidad As DataGridViewTextBoxColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents ADescripción As DataGridViewTextBoxColumn
    Friend WithEvents Inventario As DataGridViewTextBoxColumn
    Friend WithEvents Posición As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVVerificados As DataGridView
    Friend WithEvents NDePedido As DataGridViewTextBoxColumn
    Friend WithEvents ODePedido As DataGridViewTextBoxColumn
    Friend WithEvents VCantidad As DataGridViewTextBoxColumn
    Friend WithEvents vCodigo As DataGridViewTextBoxColumn
    Friend WithEvents VDescripción As DataGridViewTextBoxColumn
    Friend WithEvents VrUnitario As DataGridViewTextBoxColumn
    Friend WithEvents VrTotal As DataGridViewTextBoxColumn
    Friend WithEvents VrUnitarioIVA As DataGridViewTextBoxColumn
    Friend WithEvents VIVA As DataGridViewTextBoxColumn
    Friend WithEvents VrTotalIVA As DataGridViewTextBoxColumn
    Friend WithEvents VCosto As DataGridViewTextBoxColumn
    Friend WithEvents CostoTotal As DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents VProveedor As DataGridViewTextBoxColumn
    Friend WithEvents CodCliente As DataGridViewTextBoxColumn
    Friend WithEvents VCliente As DataGridViewTextBoxColumn
    Friend WithEvents CodColaborador As DataGridViewTextBoxColumn
    Friend WithEvents Colaborador As DataGridViewTextBoxColumn
    Friend WithEvents FechaOPedido As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents TipoDePago As DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As DataGridViewTextBoxColumn
    Friend WithEvents VHora As DataGridViewTextBoxColumn
    Friend WithEvents VEstado As DataGridViewTextBoxColumn
    Friend WithEvents ConOSinIVA As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DGVSalidas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents SNDePedido As DataGridViewTextBoxColumn
    Friend WithEvents EODePedido As DataGridViewTextBoxColumn
    Friend WithEvents SCantidad As DataGridViewTextBoxColumn
    Friend WithEvents SCodigo As DataGridViewTextBoxColumn
    Friend WithEvents SDescripción As DataGridViewTextBoxColumn
    Friend WithEvents SVrUnitario As DataGridViewTextBoxColumn
    Friend WithEvents SVrTotal As DataGridViewTextBoxColumn
    Friend WithEvents SVrUnitarioIVA As DataGridViewTextBoxColumn
    Friend WithEvents SIVA As DataGridViewTextBoxColumn
    Friend WithEvents SVrTotalIVA As DataGridViewTextBoxColumn
    Friend WithEvents SCosto As DataGridViewTextBoxColumn
    Friend WithEvents SCostoTotal As DataGridViewTextBoxColumn
    Friend WithEvents SGanancia As DataGridViewTextBoxColumn
    Friend WithEvents SPorcentaje As DataGridViewTextBoxColumn
    Friend WithEvents SCategoria As DataGridViewTextBoxColumn
    Friend WithEvents SSubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents SProveedor As DataGridViewTextBoxColumn
    Friend WithEvents SCodCliente As DataGridViewTextBoxColumn
    Friend WithEvents SCliente As DataGridViewTextBoxColumn
    Friend WithEvents SCodColaborador As DataGridViewTextBoxColumn
    Friend WithEvents SColaborador As DataGridViewTextBoxColumn
    Friend WithEvents SFechaOPedido As DataGridViewTextBoxColumn
    Friend WithEvents SFechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents STipoDePago As DataGridViewTextBoxColumn
    Friend WithEvents SFechaDeIngreso As DataGridViewTextBoxColumn
    Friend WithEvents SHora As DataGridViewTextBoxColumn
    Friend WithEvents STieneIVA As DataGridViewTextBoxColumn
    Friend WithEvents SFechaVencimiemto As DataGridViewTextBoxColumn
    Friend WithEvents ButtonExportarAExcelColaboradores As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DGVAnulados As DataGridView
    Friend WithEvents AnNDePedido As DataGridViewTextBoxColumn
    Friend WithEvents AnODePedido As DataGridViewTextBoxColumn
    Friend WithEvents AnCantidad As DataGridViewTextBoxColumn
    Friend WithEvents AnCodigo As DataGridViewTextBoxColumn
    Friend WithEvents AnDescripción As DataGridViewTextBoxColumn
    Friend WithEvents AnVrUnitario As DataGridViewTextBoxColumn
    Friend WithEvents AnVrTotal As DataGridViewTextBoxColumn
    Friend WithEvents AnVrUnitarioIVA As DataGridViewTextBoxColumn
    Friend WithEvents AnIVA As DataGridViewTextBoxColumn
    Friend WithEvents AnVrTotalIVA As DataGridViewTextBoxColumn
    Friend WithEvents AnCosto As DataGridViewTextBoxColumn
    Friend WithEvents AnCostoTotal As DataGridViewTextBoxColumn
    Friend WithEvents AnGanancia As DataGridViewTextBoxColumn
    Friend WithEvents AnPorcentaje As DataGridViewTextBoxColumn
    Friend WithEvents AnCategoria As DataGridViewTextBoxColumn
    Friend WithEvents AnSubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents AnProveedor As DataGridViewTextBoxColumn
    Friend WithEvents AnCodCliente As DataGridViewTextBoxColumn
    Friend WithEvents AnCliente As DataGridViewTextBoxColumn
    Friend WithEvents AnCodColaborador As DataGridViewTextBoxColumn
    Friend WithEvents AnColaborador As DataGridViewTextBoxColumn
    Friend WithEvents AnFechaOPedido As DataGridViewTextBoxColumn
    Friend WithEvents AnFechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents AnTipoDePago As DataGridViewTextBoxColumn
    Friend WithEvents AnUbicación As DataGridViewTextBoxColumn
    Friend WithEvents AnHora As DataGridViewTextBoxColumn
    Friend WithEvents AnEstado As DataGridViewTextBoxColumn
    Friend WithEvents AnConOSinIVA As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NconsecutivoVenta As Label
    Friend WithEvents NconsecutivoCompra As Label
    Friend WithEvents NUDVenta As NumericUpDown
    Friend WithEvents NUDCompra As NumericUpDown
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButtonNuevo As RadioButton
    Friend WithEvents RadioButtonEliminarColaboradores As RadioButton
    Friend WithEvents RadioButtonListaColaboradores As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
