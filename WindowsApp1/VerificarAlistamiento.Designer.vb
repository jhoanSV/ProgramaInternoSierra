<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificarAlistamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerificarAlistamiento))
        Me.DGVVerificarVenta = New System.Windows.Forms.DataGridView()
        Me.TBTotalVentas = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonDeGuardarVentas = New System.Windows.Forms.Button()
        Me.CancelarVenta = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.LClienteText = New System.Windows.Forms.Label()
        Me.LEnviarAText = New System.Windows.Forms.Label()
        Me.LNitText = New System.Windows.Forms.Label()
        Me.LCiudadText = New System.Windows.Forms.Label()
        Me.LDireccionText = New System.Windows.Forms.Label()
        Me.LTelefonoText = New System.Windows.Forms.Label()
        Me.LCelText = New System.Windows.Forms.Label()
        Me.LEmailText = New System.Windows.Forms.Label()
        Me.LBarrioText = New System.Windows.Forms.Label()
        Me.LVendedorText = New System.Windows.Forms.Label()
        Me.LCodVText = New System.Windows.Forms.Label()
        Me.LNdepedidoText = New System.Windows.Forms.Label()
        Me.LOdepedidoText = New System.Windows.Forms.Label()
        Me.LFechaOdepedidoText = New System.Windows.Forms.Label()
        Me.LFechaEntregaText = New System.Windows.Forms.Label()
        Me.LTipoDePagoText = New System.Windows.Forms.Label()
        Me.LCodCLiente = New System.Windows.Forms.Label()
        Me.CHBIVA = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.Maximizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ButtonCerrarFactura = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBTotalIVA = New System.Windows.Forms.TextBox()
        Me.ButtonAnular = New System.Windows.Forms.Button()
        Me.TBTotalBruto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
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
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DGVVerificarVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVVerificarVenta
        '
        Me.DGVVerificarVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVerificarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVerificarVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Cod, Me.Descripcion, Me.VrUnitario, Me.VrTotal, Me.VrUnitarioIVA, Me.IVA, Me.VrTotalIVA, Me.Costo, Me.CostoTotal, Me.Ganancia, Me.Porcentaje, Me.Categoria, Me.SubCategoria, Me.Proveedor, Me.Ubicacion, Me.Estado})
        Me.DGVVerificarVenta.Location = New System.Drawing.Point(10, 159)
        Me.DGVVerificarVenta.Name = "DGVVerificarVenta"
        Me.DGVVerificarVenta.RowTemplate.Height = 25
        Me.DGVVerificarVenta.Size = New System.Drawing.Size(742, 240)
        Me.DGVVerificarVenta.TabIndex = 74
        '
        'TBTotalVentas
        '
        Me.TBTotalVentas.Location = New System.Drawing.Point(625, 405)
        Me.TBTotalVentas.Name = "TBTotalVentas"
        Me.TBTotalVentas.Size = New System.Drawing.Size(85, 20)
        Me.TBTotalVentas.TabIndex = 82
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(574, 407)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "Total neto:"
        '
        'ButtonDeGuardarVentas
        '
        Me.ButtonDeGuardarVentas.Location = New System.Drawing.Point(96, 40)
        Me.ButtonDeGuardarVentas.Name = "ButtonDeGuardarVentas"
        Me.ButtonDeGuardarVentas.Size = New System.Drawing.Size(64, 20)
        Me.ButtonDeGuardarVentas.TabIndex = 83
        Me.ButtonDeGuardarVentas.Text = "Guardar"
        Me.ButtonDeGuardarVentas.UseVisualStyleBackColor = True
        '
        'CancelarVenta
        '
        Me.CancelarVenta.Location = New System.Drawing.Point(165, 40)
        Me.CancelarVenta.Name = "CancelarVenta"
        Me.CancelarVenta.Size = New System.Drawing.Size(64, 20)
        Me.CancelarVenta.TabIndex = 84
        Me.CancelarVenta.Text = "Cancelar"
        Me.CancelarVenta.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(8, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 14)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Enviar a:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(466, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 14)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Fecha entrega:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(8, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 14)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Ciudad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(235, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 14)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Vendedor:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(466, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "N° pedido:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(638, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 14)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Cod Cliente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(235, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Barrio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(235, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(235, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 14)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Cel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(235, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(466, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 14)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Tipo de pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(466, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 14)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha O pedido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(466, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "O de Pedido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 14)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Nit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Cliente:"
        '
        'LClienteText
        '
        Me.LClienteText.Location = New System.Drawing.Point(63, 66)
        Me.LClienteText.Name = "LClienteText"
        Me.LClienteText.Size = New System.Drawing.Size(171, 13)
        Me.LClienteText.TabIndex = 118
        Me.LClienteText.Text = "Clientetext"
        '
        'LEnviarAText
        '
        Me.LEnviarAText.Location = New System.Drawing.Point(63, 83)
        Me.LEnviarAText.Name = "LEnviarAText"
        Me.LEnviarAText.Size = New System.Drawing.Size(171, 13)
        Me.LEnviarAText.TabIndex = 119
        Me.LEnviarAText.Text = "EnviarAText"
        '
        'LNitText
        '
        Me.LNitText.Location = New System.Drawing.Point(63, 101)
        Me.LNitText.Name = "LNitText"
        Me.LNitText.Size = New System.Drawing.Size(171, 13)
        Me.LNitText.TabIndex = 120
        Me.LNitText.Text = "NitText"
        '
        'LCiudadText
        '
        Me.LCiudadText.Location = New System.Drawing.Point(63, 118)
        Me.LCiudadText.Name = "LCiudadText"
        Me.LCiudadText.Size = New System.Drawing.Size(171, 13)
        Me.LCiudadText.TabIndex = 121
        Me.LCiudadText.Text = "CiudadText"
        '
        'LDireccionText
        '
        Me.LDireccionText.Location = New System.Drawing.Point(63, 135)
        Me.LDireccionText.Name = "LDireccionText"
        Me.LDireccionText.Size = New System.Drawing.Size(171, 13)
        Me.LDireccionText.TabIndex = 122
        Me.LDireccionText.Text = "DireccionText"
        '
        'LTelefonoText
        '
        Me.LTelefonoText.Location = New System.Drawing.Point(293, 66)
        Me.LTelefonoText.Name = "LTelefonoText"
        Me.LTelefonoText.Size = New System.Drawing.Size(171, 13)
        Me.LTelefonoText.TabIndex = 123
        Me.LTelefonoText.Text = "TelefonoText"
        '
        'LCelText
        '
        Me.LCelText.Location = New System.Drawing.Point(293, 83)
        Me.LCelText.Name = "LCelText"
        Me.LCelText.Size = New System.Drawing.Size(171, 13)
        Me.LCelText.TabIndex = 124
        Me.LCelText.Text = "CelText"
        '
        'LEmailText
        '
        Me.LEmailText.Location = New System.Drawing.Point(293, 101)
        Me.LEmailText.Name = "LEmailText"
        Me.LEmailText.Size = New System.Drawing.Size(171, 13)
        Me.LEmailText.TabIndex = 125
        Me.LEmailText.Text = "EmailText"
        '
        'LBarrioText
        '
        Me.LBarrioText.Location = New System.Drawing.Point(293, 118)
        Me.LBarrioText.Name = "LBarrioText"
        Me.LBarrioText.Size = New System.Drawing.Size(171, 13)
        Me.LBarrioText.TabIndex = 126
        Me.LBarrioText.Text = "BarrioText"
        '
        'LVendedorText
        '
        Me.LVendedorText.Location = New System.Drawing.Point(293, 135)
        Me.LVendedorText.Name = "LVendedorText"
        Me.LVendedorText.Size = New System.Drawing.Size(107, 13)
        Me.LVendedorText.TabIndex = 127
        Me.LVendedorText.Text = "VendedorText"
        '
        'LCodVText
        '
        Me.LCodVText.Location = New System.Drawing.Point(405, 135)
        Me.LCodVText.Name = "LCodVText"
        Me.LCodVText.Size = New System.Drawing.Size(58, 13)
        Me.LCodVText.TabIndex = 128
        Me.LCodVText.Text = "CodVText"
        '
        'LNdepedidoText
        '
        Me.LNdepedidoText.Location = New System.Drawing.Point(562, 65)
        Me.LNdepedidoText.Name = "LNdepedidoText"
        Me.LNdepedidoText.Size = New System.Drawing.Size(70, 12)
        Me.LNdepedidoText.TabIndex = 129
        Me.LNdepedidoText.Text = "NdepedidoText"
        '
        'LOdepedidoText
        '
        Me.LOdepedidoText.Location = New System.Drawing.Point(562, 82)
        Me.LOdepedidoText.Name = "LOdepedidoText"
        Me.LOdepedidoText.Size = New System.Drawing.Size(70, 12)
        Me.LOdepedidoText.TabIndex = 130
        Me.LOdepedidoText.Text = "OdepedidoText"
        '
        'LFechaOdepedidoText
        '
        Me.LFechaOdepedidoText.Location = New System.Drawing.Point(562, 100)
        Me.LFechaOdepedidoText.Name = "LFechaOdepedidoText"
        Me.LFechaOdepedidoText.Size = New System.Drawing.Size(70, 12)
        Me.LFechaOdepedidoText.TabIndex = 131
        Me.LFechaOdepedidoText.Text = "FechaOdepedidoText"
        '
        'LFechaEntregaText
        '
        Me.LFechaEntregaText.Location = New System.Drawing.Point(562, 117)
        Me.LFechaEntregaText.Name = "LFechaEntregaText"
        Me.LFechaEntregaText.Size = New System.Drawing.Size(70, 12)
        Me.LFechaEntregaText.TabIndex = 132
        Me.LFechaEntregaText.Text = "FechaEntregaText"
        '
        'LTipoDePagoText
        '
        Me.LTipoDePagoText.Location = New System.Drawing.Point(562, 134)
        Me.LTipoDePagoText.Name = "LTipoDePagoText"
        Me.LTipoDePagoText.Size = New System.Drawing.Size(70, 12)
        Me.LTipoDePagoText.TabIndex = 133
        Me.LTipoDePagoText.Text = "TipoDePagoText"
        '
        'LCodCLiente
        '
        Me.LCodCLiente.Location = New System.Drawing.Point(681, 65)
        Me.LCodCLiente.Name = "LCodCLiente"
        Me.LCodCLiente.Size = New System.Drawing.Size(64, 12)
        Me.LCodCLiente.TabIndex = 134
        Me.LCodCLiente.Text = "CodCLiente"
        '
        'CHBIVA
        '
        Me.CHBIVA.AutoSize = True
        Me.CHBIVA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.CHBIVA.Location = New System.Drawing.Point(638, 81)
        Me.CHBIVA.Name = "CHBIVA"
        Me.CHBIVA.Size = New System.Drawing.Size(47, 18)
        Me.CHBIVA.TabIndex = 136
        Me.CHBIVA.Text = "IVA"
        Me.CHBIVA.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Restaurar)
        Me.Panel5.Controls.Add(Me.minimizar)
        Me.Panel5.Controls.Add(Me.Maximizar)
        Me.Panel5.Controls.Add(Me.cerrar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(767, 35)
        Me.Panel5.TabIndex = 137
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(276, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 17)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "Tabla de verificación de facturas"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(732, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 35)
        Me.Button5.TabIndex = 10
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(700, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 35)
        Me.Button6.TabIndex = 9
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1062, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1030, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 35)
        Me.Button4.TabIndex = 7
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1268, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1237, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(979, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restaurar.FlatAppearance.BorderSize = 0
        Me.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Restaurar.Image = CType(resources.GetObject("Restaurar.Image"), System.Drawing.Image)
        Me.Restaurar.Location = New System.Drawing.Point(1988, 0)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(34, 35)
        Me.Restaurar.TabIndex = 3
        Me.Restaurar.UseVisualStyleBackColor = True
        Me.Restaurar.Visible = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderSize = 0
        Me.minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(1949, 0)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(34, 35)
        Me.minimizar.TabIndex = 2
        Me.minimizar.UseVisualStyleBackColor = True
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maximizar.FlatAppearance.BorderSize = 0
        Me.Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximizar.Image = CType(resources.GetObject("Maximizar.Image"), System.Drawing.Image)
        Me.Maximizar.Location = New System.Drawing.Point(1988, 0)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(34, 35)
        Me.Maximizar.TabIndex = 1
        Me.Maximizar.UseVisualStyleBackColor = True
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderSize = 0
        Me.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(2028, 0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(34, 35)
        Me.cerrar.TabIndex = 0
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(235, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 20)
        Me.Button7.TabIndex = 138
        Me.Button7.Text = "Imprimir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ButtonCerrarFactura
        '
        Me.ButtonCerrarFactura.Location = New System.Drawing.Point(8, 40)
        Me.ButtonCerrarFactura.Name = "ButtonCerrarFactura"
        Me.ButtonCerrarFactura.Size = New System.Drawing.Size(83, 20)
        Me.ButtonCerrarFactura.TabIndex = 139
        Me.ButtonCerrarFactura.Text = "Cerrar factura"
        Me.ButtonCerrarFactura.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(639, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(71, 20)
        Me.DateTimePicker1.TabIndex = 140
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(639, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 141
        Me.Label18.Text = "Fecha recibido"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(430, 408)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 13)
        Me.Label20.TabIndex = 142
        Me.Label20.Text = "IVA:"
        '
        'TBTotalIVA
        '
        Me.TBTotalIVA.Location = New System.Drawing.Point(464, 405)
        Me.TBTotalIVA.Name = "TBTotalIVA"
        Me.TBTotalIVA.Size = New System.Drawing.Size(85, 20)
        Me.TBTotalIVA.TabIndex = 143
        '
        'ButtonAnular
        '
        Me.ButtonAnular.Location = New System.Drawing.Point(12, 404)
        Me.ButtonAnular.Name = "ButtonAnular"
        Me.ButtonAnular.Size = New System.Drawing.Size(64, 20)
        Me.ButtonAnular.TabIndex = 144
        Me.ButtonAnular.Text = "Anular pedido"
        Me.ButtonAnular.UseVisualStyleBackColor = True
        '
        'TBTotalBruto
        '
        Me.TBTotalBruto.Location = New System.Drawing.Point(310, 404)
        Me.TBTotalBruto.Name = "TBTotalBruto"
        Me.TBTotalBruto.Size = New System.Drawing.Size(85, 20)
        Me.TBTotalBruto.TabIndex = 146
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(254, 408)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 145
        Me.Label21.Text = "Total bruto:"
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
        Me.Descripcion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Descripcion.HeaderText = "Descripción"
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
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'VerificarAlistamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 439)
        Me.Controls.Add(Me.TBTotalBruto)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ButtonAnular)
        Me.Controls.Add(Me.TBTotalIVA)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ButtonCerrarFactura)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.CHBIVA)
        Me.Controls.Add(Me.LCodCLiente)
        Me.Controls.Add(Me.LTipoDePagoText)
        Me.Controls.Add(Me.LFechaEntregaText)
        Me.Controls.Add(Me.LFechaOdepedidoText)
        Me.Controls.Add(Me.LOdepedidoText)
        Me.Controls.Add(Me.LNdepedidoText)
        Me.Controls.Add(Me.LCodVText)
        Me.Controls.Add(Me.LVendedorText)
        Me.Controls.Add(Me.LBarrioText)
        Me.Controls.Add(Me.LEmailText)
        Me.Controls.Add(Me.LCelText)
        Me.Controls.Add(Me.LTelefonoText)
        Me.Controls.Add(Me.LDireccionText)
        Me.Controls.Add(Me.LCiudadText)
        Me.Controls.Add(Me.LNitText)
        Me.Controls.Add(Me.LEnviarAText)
        Me.Controls.Add(Me.LClienteText)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelarVenta)
        Me.Controls.Add(Me.ButtonDeGuardarVentas)
        Me.Controls.Add(Me.TBTotalVentas)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DGVVerificarVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerificarAlistamiento"
        Me.Text = "VerificarAlistamiento"
        CType(Me.DGVVerificarVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVVerificarVenta As DataGridView
    Friend WithEvents TBTotalVentas As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonDeGuardarVentas As Button
    Friend WithEvents CancelarVenta As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents LClienteText As Label
    Friend WithEvents LEnviarAText As Label
    Friend WithEvents LNitText As Label
    Friend WithEvents LCiudadText As Label
    Friend WithEvents LDireccionText As Label
    Friend WithEvents LTelefonoText As Label
    Friend WithEvents LCelText As Label
    Friend WithEvents LEmailText As Label
    Friend WithEvents LBarrioText As Label
    Friend WithEvents LVendedorText As Label
    Friend WithEvents LCodVText As Label
    Friend WithEvents LNdepedidoText As Label
    Friend WithEvents LOdepedidoText As Label
    Friend WithEvents LFechaOdepedidoText As Label
    Friend WithEvents LFechaEntregaText As Label
    Friend WithEvents LTipoDePagoText As Label
    Friend WithEvents LCodCLiente As Label
    Friend WithEvents CHBIVA As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Restaurar As Button
    Friend WithEvents minimizar As Button
    Friend WithEvents Maximizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents ButtonCerrarFactura As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label20 As Label
    Friend WithEvents TBTotalIVA As TextBox
    Friend WithEvents ButtonAnular As Button
    Friend WithEvents TBTotalBruto As TextBox
    Friend WithEvents Label21 As Label
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
    Friend WithEvents Estado As DataGridViewCheckBoxColumn
End Class
