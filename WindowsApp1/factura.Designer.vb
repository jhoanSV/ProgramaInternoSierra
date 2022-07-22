<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class factura
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enviar_a = New System.Windows.Forms.Label()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.N_Pedido = New System.Windows.Forms.Label()
        Me.Fecha_remision = New System.Windows.Forms.Label()
        Me.Tipo_de_pago = New System.Windows.Forms.Label()
        Me.Enviar_a_text = New System.Windows.Forms.Label()
        Me.Vendedor_text = New System.Windows.Forms.Label()
        Me.N_pedido_text = New System.Windows.Forms.Label()
        Me.fecha_remision_text = New System.Windows.Forms.Label()
        Me.Tipo_de_pago_text = New System.Windows.Forms.Label()
        Me.nit_cliente_text = New System.Windows.Forms.Label()
        Me.barrio_text = New System.Windows.Forms.Label()
        Me.telefono_text = New System.Windows.Forms.Label()
        Me.Direccion_text = New System.Windows.Forms.Label()
        Me.Facturar_a_text = New System.Windows.Forms.Label()
        Me.Nit_Cliente = New System.Windows.Forms.Label()
        Me.Barrio = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.Label()
        Me.Facturar_a = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Pagina = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Titulo_remision_text = New System.Windows.Forms.Label()
        Me.Titulo_remision = New System.Windows.Forms.Label()
        Me.lbNumeroPagina = New System.Windows.Forms.Label()
        Me.punto1 = New System.Windows.Forms.Label()
        Me.punto2 = New System.Windows.Forms.Label()
        Me.punto3 = New System.Windows.Forms.Label()
        Me.punto4 = New System.Windows.Forms.Label()
        Me.punto5 = New System.Windows.Forms.Label()
        Me.punto6 = New System.Windows.Forms.Label()
        Me.punto7 = New System.Windows.Forms.Label()
        Me.punto8 = New System.Windows.Forms.Label()
        Me.punto9 = New System.Windows.Forms.Label()
        Me.punto10 = New System.Windows.Forms.Label()
        Me.punto13 = New System.Windows.Forms.Label()
        Me.punto12 = New System.Windows.Forms.Label()
        Me.punto11 = New System.Windows.Forms.Label()
        Me.Correo_text = New System.Windows.Forms.Label()
        Me.Correo = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Cod, Me.Descripcion, Me.VrUnitario, Me.VrTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(56, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(729, 79)
        Me.DataGridView1.TabIndex = 0
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.FillWeight = 203.0457!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'Cod
        '
        Me.Cod.FillWeight = 181.0697!
        Me.Cod.HeaderText = "Cod"
        Me.Cod.Name = "Cod"
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 38.6282!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'VrUnitario
        '
        Me.VrUnitario.FillWeight = 38.6282!
        Me.VrUnitario.HeaderText = "VrUnitario"
        Me.VrUnitario.Name = "VrUnitario"
        '
        'VrTotal
        '
        Me.VrTotal.FillWeight = 38.6282!
        Me.VrTotal.HeaderText = "VrTotal"
        Me.VrTotal.Name = "VrTotal"
        '
        'Enviar_a
        '
        Me.Enviar_a.AutoSize = True
        Me.Enviar_a.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enviar_a.Location = New System.Drawing.Point(56, 158)
        Me.Enviar_a.Name = "Enviar_a"
        Me.Enviar_a.Size = New System.Drawing.Size(57, 16)
        Me.Enviar_a.TabIndex = 1
        Me.Enviar_a.Text = "Cliente:"
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor.Location = New System.Drawing.Point(56, 190)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(73, 16)
        Me.Vendedor.TabIndex = 3
        Me.Vendedor.Text = "Vendedor:"
        '
        'N_Pedido
        '
        Me.N_Pedido.AutoSize = True
        Me.N_Pedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_Pedido.Location = New System.Drawing.Point(56, 206)
        Me.N_Pedido.Name = "N_Pedido"
        Me.N_Pedido.Size = New System.Drawing.Size(75, 16)
        Me.N_Pedido.TabIndex = 4
        Me.N_Pedido.Text = "O° pedido:"
        '
        'Fecha_remision
        '
        Me.Fecha_remision.AutoSize = True
        Me.Fecha_remision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_remision.Location = New System.Drawing.Point(56, 222)
        Me.Fecha_remision.Name = "Fecha_remision"
        Me.Fecha_remision.Size = New System.Drawing.Size(110, 16)
        Me.Fecha_remision.TabIndex = 5
        Me.Fecha_remision.Text = "Fecha remisión:"
        '
        'Tipo_de_pago
        '
        Me.Tipo_de_pago.AutoSize = True
        Me.Tipo_de_pago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_pago.Location = New System.Drawing.Point(56, 238)
        Me.Tipo_de_pago.Name = "Tipo_de_pago"
        Me.Tipo_de_pago.Size = New System.Drawing.Size(96, 16)
        Me.Tipo_de_pago.TabIndex = 6
        Me.Tipo_de_pago.Text = "Tipo de pago:"
        '
        'Enviar_a_text
        '
        Me.Enviar_a_text.AutoSize = True
        Me.Enviar_a_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enviar_a_text.Location = New System.Drawing.Point(176, 158)
        Me.Enviar_a_text.Name = "Enviar_a_text"
        Me.Enviar_a_text.Size = New System.Drawing.Size(84, 16)
        Me.Enviar_a_text.TabIndex = 7
        Me.Enviar_a_text.Text = "Enviar a text:"
        '
        'Vendedor_text
        '
        Me.Vendedor_text.AutoSize = True
        Me.Vendedor_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor_text.Location = New System.Drawing.Point(176, 190)
        Me.Vendedor_text.Name = "Vendedor_text"
        Me.Vendedor_text.Size = New System.Drawing.Size(92, 16)
        Me.Vendedor_text.TabIndex = 9
        Me.Vendedor_text.Text = "Vendedor text:"
        '
        'N_pedido_text
        '
        Me.N_pedido_text.AutoSize = True
        Me.N_pedido_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_pedido_text.Location = New System.Drawing.Point(176, 206)
        Me.N_pedido_text.Name = "N_pedido_text"
        Me.N_pedido_text.Size = New System.Drawing.Size(89, 16)
        Me.N_pedido_text.TabIndex = 10
        Me.N_pedido_text.Text = "N pedido text:"
        '
        'fecha_remision_text
        '
        Me.fecha_remision_text.AutoSize = True
        Me.fecha_remision_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_remision_text.Location = New System.Drawing.Point(176, 222)
        Me.fecha_remision_text.Name = "fecha_remision_text"
        Me.fecha_remision_text.Size = New System.Drawing.Size(122, 16)
        Me.fecha_remision_text.TabIndex = 11
        Me.fecha_remision_text.Text = "fecha remision text:"
        '
        'Tipo_de_pago_text
        '
        Me.Tipo_de_pago_text.AutoSize = True
        Me.Tipo_de_pago_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_pago_text.Location = New System.Drawing.Point(176, 238)
        Me.Tipo_de_pago_text.Name = "Tipo_de_pago_text"
        Me.Tipo_de_pago_text.Size = New System.Drawing.Size(109, 16)
        Me.Tipo_de_pago_text.TabIndex = 12
        Me.Tipo_de_pago_text.Text = "tipo de pago text:"
        '
        'nit_cliente_text
        '
        Me.nit_cliente_text.AutoSize = True
        Me.nit_cliente_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nit_cliente_text.Location = New System.Drawing.Point(590, 222)
        Me.nit_cliente_text.Name = "nit_cliente_text"
        Me.nit_cliente_text.Size = New System.Drawing.Size(94, 16)
        Me.nit_cliente_text.TabIndex = 23
        Me.nit_cliente_text.Text = "nit cliente text:"
        '
        'barrio_text
        '
        Me.barrio_text.AutoSize = True
        Me.barrio_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barrio_text.Location = New System.Drawing.Point(590, 206)
        Me.barrio_text.Name = "barrio_text"
        Me.barrio_text.Size = New System.Drawing.Size(70, 16)
        Me.barrio_text.TabIndex = 22
        Me.barrio_text.Text = "barrio text:"
        '
        'telefono_text
        '
        Me.telefono_text.AutoSize = True
        Me.telefono_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_text.Location = New System.Drawing.Point(590, 190)
        Me.telefono_text.Name = "telefono_text"
        Me.telefono_text.Size = New System.Drawing.Size(83, 16)
        Me.telefono_text.TabIndex = 21
        Me.telefono_text.Text = "telefono text:"
        '
        'Direccion_text
        '
        Me.Direccion_text.AutoSize = True
        Me.Direccion_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion_text.Location = New System.Drawing.Point(590, 174)
        Me.Direccion_text.Name = "Direccion_text"
        Me.Direccion_text.Size = New System.Drawing.Size(94, 16)
        Me.Direccion_text.TabIndex = 20
        Me.Direccion_text.Text = "Dirección Text:"
        '
        'Facturar_a_text
        '
        Me.Facturar_a_text.AutoSize = True
        Me.Facturar_a_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Facturar_a_text.Location = New System.Drawing.Point(590, 158)
        Me.Facturar_a_text.Name = "Facturar_a_text"
        Me.Facturar_a_text.Size = New System.Drawing.Size(97, 16)
        Me.Facturar_a_text.TabIndex = 19
        Me.Facturar_a_text.Text = "Facturar a text:"
        '
        'Nit_Cliente
        '
        Me.Nit_Cliente.AutoSize = True
        Me.Nit_Cliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nit_Cliente.Location = New System.Drawing.Point(470, 222)
        Me.Nit_Cliente.Name = "Nit_Cliente"
        Me.Nit_Cliente.Size = New System.Drawing.Size(76, 16)
        Me.Nit_Cliente.TabIndex = 17
        Me.Nit_Cliente.Text = "Nit cliente:"
        '
        'Barrio
        '
        Me.Barrio.AutoSize = True
        Me.Barrio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barrio.Location = New System.Drawing.Point(470, 206)
        Me.Barrio.Name = "Barrio"
        Me.Barrio.Size = New System.Drawing.Size(51, 16)
        Me.Barrio.TabIndex = 16
        Me.Barrio.Text = "Barrio:"
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.Location = New System.Drawing.Point(470, 190)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(67, 16)
        Me.Telefono.TabIndex = 15
        Me.Telefono.Text = "Telefono:"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(470, 174)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(72, 16)
        Me.Direccion.TabIndex = 14
        Me.Direccion.Text = "Dirección:"
        '
        'Facturar_a
        '
        Me.Facturar_a.AutoSize = True
        Me.Facturar_a.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Facturar_a.Location = New System.Drawing.Point(470, 158)
        Me.Facturar_a.Name = "Facturar_a"
        Me.Facturar_a.Size = New System.Drawing.Size(113, 16)
        Me.Facturar_a.TabIndex = 13
        Me.Facturar_a.Text = "Establecimiento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(568, 647)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "IVA text:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(565, 601)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 16)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Sub total text:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(448, 647)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 16)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "IVA:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(445, 601)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Subtotal:"
        '
        'Pagina
        '
        Me.Pagina.AutoSize = True
        Me.Pagina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pagina.Location = New System.Drawing.Point(378, 691)
        Me.Pagina.Name = "Pagina"
        Me.Pagina.Size = New System.Drawing.Size(52, 16)
        Me.Pagina.TabIndex = 28
        Me.Pagina.Text = "Pagina "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(568, 663)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 16)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Total text:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(448, 663)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(43, 16)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Total:"
        '
        'Titulo_remision_text
        '
        Me.Titulo_remision_text.AutoSize = True
        Me.Titulo_remision_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo_remision_text.Location = New System.Drawing.Point(612, 68)
        Me.Titulo_remision_text.Name = "Titulo_remision_text"
        Me.Titulo_remision_text.Size = New System.Drawing.Size(94, 16)
        Me.Titulo_remision_text.TabIndex = 32
        Me.Titulo_remision_text.Text = "Remisión Text:"
        '
        'Titulo_remision
        '
        Me.Titulo_remision.AutoSize = True
        Me.Titulo_remision.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo_remision.Location = New System.Drawing.Point(588, 34)
        Me.Titulo_remision.Name = "Titulo_remision"
        Me.Titulo_remision.Size = New System.Drawing.Size(137, 24)
        Me.Titulo_remision.TabIndex = 31
        Me.Titulo_remision.Text = "Pre-Factura:"
        '
        'lbNumeroPagina
        '
        Me.lbNumeroPagina.AutoSize = True
        Me.lbNumeroPagina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroPagina.Location = New System.Drawing.Point(429, 692)
        Me.lbNumeroPagina.Name = "lbNumeroPagina"
        Me.lbNumeroPagina.Size = New System.Drawing.Size(15, 16)
        Me.lbNumeroPagina.TabIndex = 33
        Me.lbNumeroPagina.Text = "0"
        '
        'punto1
        '
        Me.punto1.AutoSize = True
        Me.punto1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto1.Location = New System.Drawing.Point(56, 265)
        Me.punto1.Name = "punto1"
        Me.punto1.Size = New System.Drawing.Size(15, 16)
        Me.punto1.TabIndex = 34
        Me.punto1.Text = "1"
        '
        'punto2
        '
        Me.punto2.AutoSize = True
        Me.punto2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto2.Location = New System.Drawing.Point(154, 265)
        Me.punto2.Name = "punto2"
        Me.punto2.Size = New System.Drawing.Size(15, 16)
        Me.punto2.TabIndex = 35
        Me.punto2.Text = "2"
        '
        'punto3
        '
        Me.punto3.AutoSize = True
        Me.punto3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto3.Location = New System.Drawing.Point(252, 265)
        Me.punto3.Name = "punto3"
        Me.punto3.Size = New System.Drawing.Size(15, 16)
        Me.punto3.TabIndex = 36
        Me.punto3.Text = "3"
        '
        'punto4
        '
        Me.punto4.AutoSize = True
        Me.punto4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto4.Location = New System.Drawing.Point(586, 265)
        Me.punto4.Name = "punto4"
        Me.punto4.Size = New System.Drawing.Size(15, 16)
        Me.punto4.TabIndex = 37
        Me.punto4.Text = "4"
        '
        'punto5
        '
        Me.punto5.AutoSize = True
        Me.punto5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto5.Location = New System.Drawing.Point(684, 265)
        Me.punto5.Name = "punto5"
        Me.punto5.Size = New System.Drawing.Size(15, 16)
        Me.punto5.TabIndex = 38
        Me.punto5.Text = "5"
        '
        'punto6
        '
        Me.punto6.AutoSize = True
        Me.punto6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto6.Location = New System.Drawing.Point(782, 265)
        Me.punto6.Name = "punto6"
        Me.punto6.Size = New System.Drawing.Size(15, 16)
        Me.punto6.TabIndex = 39
        Me.punto6.Text = "6"
        '
        'punto7
        '
        Me.punto7.AutoSize = True
        Me.punto7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto7.Location = New System.Drawing.Point(56, 284)
        Me.punto7.Name = "punto7"
        Me.punto7.Size = New System.Drawing.Size(15, 16)
        Me.punto7.TabIndex = 40
        Me.punto7.Text = "7"
        '
        'punto8
        '
        Me.punto8.AutoSize = True
        Me.punto8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto8.Location = New System.Drawing.Point(56, 315)
        Me.punto8.Name = "punto8"
        Me.punto8.Size = New System.Drawing.Size(15, 16)
        Me.punto8.TabIndex = 43
        Me.punto8.Text = "8"
        '
        'punto9
        '
        Me.punto9.AutoSize = True
        Me.punto9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto9.Location = New System.Drawing.Point(135, 315)
        Me.punto9.Name = "punto9"
        Me.punto9.Size = New System.Drawing.Size(15, 16)
        Me.punto9.TabIndex = 44
        Me.punto9.Text = "9"
        '
        'punto10
        '
        Me.punto10.AutoSize = True
        Me.punto10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto10.Location = New System.Drawing.Point(214, 315)
        Me.punto10.Name = "punto10"
        Me.punto10.Size = New System.Drawing.Size(22, 16)
        Me.punto10.TabIndex = 45
        Me.punto10.Text = "10"
        '
        'punto13
        '
        Me.punto13.AutoSize = True
        Me.punto13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto13.Location = New System.Drawing.Point(703, 315)
        Me.punto13.Name = "punto13"
        Me.punto13.Size = New System.Drawing.Size(22, 16)
        Me.punto13.TabIndex = 46
        Me.punto13.Text = "13"
        '
        'punto12
        '
        Me.punto12.AutoSize = True
        Me.punto12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto12.Location = New System.Drawing.Point(624, 315)
        Me.punto12.Name = "punto12"
        Me.punto12.Size = New System.Drawing.Size(22, 16)
        Me.punto12.TabIndex = 47
        Me.punto12.Text = "12"
        '
        'punto11
        '
        Me.punto11.AutoSize = True
        Me.punto11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto11.Location = New System.Drawing.Point(545, 315)
        Me.punto11.Name = "punto11"
        Me.punto11.Size = New System.Drawing.Size(21, 16)
        Me.punto11.TabIndex = 48
        Me.punto11.Text = "11"
        '
        'Correo_text
        '
        Me.Correo_text.AutoSize = True
        Me.Correo_text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo_text.Location = New System.Drawing.Point(176, 174)
        Me.Correo_text.Name = "Correo_text"
        Me.Correo_text.Size = New System.Drawing.Size(74, 16)
        Me.Correo_text.TabIndex = 50
        Me.Correo_text.Text = "correo text:"
        '
        'Correo
        '
        Me.Correo.AutoSize = True
        Me.Correo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo.Location = New System.Drawing.Point(56, 174)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(55, 16)
        Me.Correo.TabIndex = 49
        Me.Correo.Text = "Correo:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApp1.My.Resources.Resources.anulado
        Me.PictureBox5.Location = New System.Drawing.Point(113, 432)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(612, 391)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 53
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp1.My.Resources.Resources.escaneo
        Me.PictureBox4.Location = New System.Drawing.Point(56, 495)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(210, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 52
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.fondo3
        Me.PictureBox2.Location = New System.Drawing.Point(56, 432)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(729, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.facturas_5
        Me.PictureBox1.Location = New System.Drawing.Point(59, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 749)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Correo_text)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.punto11)
        Me.Controls.Add(Me.punto12)
        Me.Controls.Add(Me.punto13)
        Me.Controls.Add(Me.punto10)
        Me.Controls.Add(Me.punto9)
        Me.Controls.Add(Me.punto8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.punto7)
        Me.Controls.Add(Me.punto6)
        Me.Controls.Add(Me.punto5)
        Me.Controls.Add(Me.punto4)
        Me.Controls.Add(Me.punto3)
        Me.Controls.Add(Me.punto2)
        Me.Controls.Add(Me.punto1)
        Me.Controls.Add(Me.lbNumeroPagina)
        Me.Controls.Add(Me.Titulo_remision_text)
        Me.Controls.Add(Me.Titulo_remision)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Pagina)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.nit_cliente_text)
        Me.Controls.Add(Me.barrio_text)
        Me.Controls.Add(Me.telefono_text)
        Me.Controls.Add(Me.Direccion_text)
        Me.Controls.Add(Me.Facturar_a_text)
        Me.Controls.Add(Me.Nit_Cliente)
        Me.Controls.Add(Me.Barrio)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Facturar_a)
        Me.Controls.Add(Me.Tipo_de_pago_text)
        Me.Controls.Add(Me.fecha_remision_text)
        Me.Controls.Add(Me.N_pedido_text)
        Me.Controls.Add(Me.Vendedor_text)
        Me.Controls.Add(Me.Enviar_a_text)
        Me.Controls.Add(Me.Tipo_de_pago)
        Me.Controls.Add(Me.Fecha_remision)
        Me.Controls.Add(Me.N_Pedido)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.Enviar_a)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "factura"
        Me.Text = "factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Enviar_a As Label
    Friend WithEvents Vendedor As Label
    Friend WithEvents N_Pedido As Label
    Friend WithEvents Fecha_remision As Label
    Friend WithEvents Tipo_de_pago As Label
    Friend WithEvents Enviar_a_text As Label
    Friend WithEvents Vendedor_text As Label
    Friend WithEvents N_pedido_text As Label
    Friend WithEvents fecha_remision_text As Label
    Friend WithEvents Tipo_de_pago_text As Label
    Friend WithEvents nit_cliente_text As Label
    Friend WithEvents barrio_text As Label
    Friend WithEvents telefono_text As Label
    Friend WithEvents Direccion_text As Label
    Friend WithEvents Facturar_a_text As Label
    Friend WithEvents Nit_Cliente As Label
    Friend WithEvents Barrio As Label
    Friend WithEvents Telefono As Label
    Friend WithEvents Direccion As Label
    Friend WithEvents Facturar_a As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Pagina As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Titulo_remision_text As Label
    Friend WithEvents Titulo_remision As Label
    Friend WithEvents lbNumeroPagina As Label
    Friend WithEvents punto1 As Label
    Friend WithEvents punto2 As Label
    Friend WithEvents punto3 As Label
    Friend WithEvents punto4 As Label
    Friend WithEvents punto5 As Label
    Friend WithEvents punto6 As Label
    Friend WithEvents punto7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents VrUnitario As DataGridViewTextBoxColumn
    Friend WithEvents VrTotal As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents punto8 As Label
    Friend WithEvents punto9 As Label
    Friend WithEvents punto10 As Label
    Friend WithEvents punto13 As Label
    Friend WithEvents punto12 As Label
    Friend WithEvents punto11 As Label
    Friend WithEvents Correo_text As Label
    Friend WithEvents Correo As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
