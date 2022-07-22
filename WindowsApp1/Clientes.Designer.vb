<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.TabControlClientes = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonModificarCliente = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBFiltrarPorCodigo = New System.Windows.Forms.TextBox()
        Me.TBFiltrarPorFerreteria = New System.Windows.Forms.TextBox()
        Me.DGVClientesBUscar = New System.Windows.Forms.DataGridView()
        Me.TBNotaClientes = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBCodVendedor = New System.Windows.Forms.TextBox()
        Me.CBVendedor = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxRutaNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxBarrioNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccionNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCelNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefonoNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxContactoNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxFerreteriaNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNitNCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoNCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodigoNCliente = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonCancelarECliente = New System.Windows.Forms.Button()
        Me.ButtonEliminarCliente = New System.Windows.Forms.Button()
        Me.ButtonBuscarEliminarCliente = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxFerreteriaECliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNitECliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoECliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ButtonExportarAExcelClientes = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MosTablaClientes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControlClientes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVClientesBUscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.MosTablaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlClientes
        '
        Me.TabControlClientes.Controls.Add(Me.TabPage1)
        Me.TabControlClientes.Controls.Add(Me.TabPage3)
        Me.TabControlClientes.Controls.Add(Me.TabPage4)
        Me.TabControlClientes.Location = New System.Drawing.Point(0, 41)
        Me.TabControlClientes.Name = "TabControlClientes"
        Me.TabControlClientes.SelectedIndex = 0
        Me.TabControlClientes.Size = New System.Drawing.Size(871, 458)
        Me.TabControlClientes.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonModificarCliente)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorCodigo)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorFerreteria)
        Me.TabPage1.Controls.Add(Me.DGVClientesBUscar)
        Me.TabPage1.Controls.Add(Me.TBNotaClientes)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TBCodVendedor)
        Me.TabPage1.Controls.Add(Me.CBVendedor)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBoxRutaNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxBarrioNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxDireccionNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxEmailNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxCelNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxTelefonoNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxContactoNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxFerreteriaNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxNitNCliente)
        Me.TabPage1.Controls.Add(Me.TextBoxCodigoNCliente)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CodigoNCliente)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(863, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonModificarCliente
        '
        Me.ButtonModificarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonModificarCliente.BackColor = System.Drawing.Color.Navy
        Me.ButtonModificarCliente.FlatAppearance.BorderSize = 0
        Me.ButtonModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonModificarCliente.Location = New System.Drawing.Point(415, 328)
        Me.ButtonModificarCliente.Name = "ButtonModificarCliente"
        Me.ButtonModificarCliente.Size = New System.Drawing.Size(64, 20)
        Me.ButtonModificarCliente.TabIndex = 49
        Me.ButtonModificarCliente.Text = "Modificar"
        Me.ButtonModificarCliente.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(415, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 17)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Filtrar busqueda por:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(415, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 17)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Ferreteria"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(276, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 17)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Codigo"
        '
        'TBFiltrarPorCodigo
        '
        Me.TBFiltrarPorCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBFiltrarPorCodigo.Location = New System.Drawing.Point(332, 42)
        Me.TBFiltrarPorCodigo.Name = "TBFiltrarPorCodigo"
        Me.TBFiltrarPorCodigo.Size = New System.Drawing.Size(79, 25)
        Me.TBFiltrarPorCodigo.TabIndex = 45
        '
        'TBFiltrarPorFerreteria
        '
        Me.TBFiltrarPorFerreteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBFiltrarPorFerreteria.Location = New System.Drawing.Point(491, 42)
        Me.TBFiltrarPorFerreteria.Name = "TBFiltrarPorFerreteria"
        Me.TBFiltrarPorFerreteria.Size = New System.Drawing.Size(205, 25)
        Me.TBFiltrarPorFerreteria.TabIndex = 44
        '
        'DGVClientesBUscar
        '
        Me.DGVClientesBUscar.AllowUserToAddRows = False
        Me.DGVClientesBUscar.AllowUserToDeleteRows = False
        Me.DGVClientesBUscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVClientesBUscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientesBUscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientesBUscar.Location = New System.Drawing.Point(276, 67)
        Me.DGVClientesBUscar.Name = "DGVClientesBUscar"
        Me.DGVClientesBUscar.ReadOnly = True
        Me.DGVClientesBUscar.RowTemplate.Height = 25
        Me.DGVClientesBUscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClientesBUscar.Size = New System.Drawing.Size(419, 238)
        Me.DGVClientesBUscar.TabIndex = 43
        '
        'TBNotaClientes
        '
        Me.TBNotaClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBNotaClientes.Location = New System.Drawing.Point(74, 293)
        Me.TBNotaClientes.Multiline = True
        Me.TBNotaClientes.Name = "TBNotaClientes"
        Me.TBNotaClientes.Size = New System.Drawing.Size(198, 55)
        Me.TBNotaClientes.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(18, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 17)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Nota"
        '
        'TBCodVendedor
        '
        Me.TBCodVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCodVendedor.Location = New System.Drawing.Point(196, 268)
        Me.TBCodVendedor.Name = "TBCodVendedor"
        Me.TBCodVendedor.Size = New System.Drawing.Size(75, 25)
        Me.TBCodVendedor.TabIndex = 40
        '
        'CBVendedor
        '
        Me.CBVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBVendedor.DropDownHeight = 50
        Me.CBVendedor.FormattingEnabled = True
        Me.CBVendedor.IntegralHeight = False
        Me.CBVendedor.Location = New System.Drawing.Point(74, 268)
        Me.CBVendedor.Name = "CBVendedor"
        Me.CBVendedor.Size = New System.Drawing.Size(118, 25)
        Me.CBVendedor.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(18, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Vendedor"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(276, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 20)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(345, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 20)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxRutaNCliente
        '
        Me.TextBoxRutaNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRutaNCliente.Location = New System.Drawing.Point(74, 243)
        Me.TextBoxRutaNCliente.Name = "TextBoxRutaNCliente"
        Me.TextBoxRutaNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxRutaNCliente.TabIndex = 31
        '
        'TextBoxBarrioNCliente
        '
        Me.TextBoxBarrioNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBarrioNCliente.Location = New System.Drawing.Point(74, 218)
        Me.TextBoxBarrioNCliente.Name = "TextBoxBarrioNCliente"
        Me.TextBoxBarrioNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxBarrioNCliente.TabIndex = 30
        '
        'TextBoxDireccionNCliente
        '
        Me.TextBoxDireccionNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDireccionNCliente.Location = New System.Drawing.Point(74, 192)
        Me.TextBoxDireccionNCliente.Name = "TextBoxDireccionNCliente"
        Me.TextBoxDireccionNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxDireccionNCliente.TabIndex = 29
        '
        'TextBoxEmailNCliente
        '
        Me.TextBoxEmailNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEmailNCliente.Location = New System.Drawing.Point(74, 167)
        Me.TextBoxEmailNCliente.Name = "TextBoxEmailNCliente"
        Me.TextBoxEmailNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxEmailNCliente.TabIndex = 28
        '
        'TextBoxCelNCliente
        '
        Me.TextBoxCelNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCelNCliente.Location = New System.Drawing.Point(74, 142)
        Me.TextBoxCelNCliente.Name = "TextBoxCelNCliente"
        Me.TextBoxCelNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCelNCliente.TabIndex = 27
        '
        'TextBoxTelefonoNCliente
        '
        Me.TextBoxTelefonoNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTelefonoNCliente.Location = New System.Drawing.Point(74, 117)
        Me.TextBoxTelefonoNCliente.Name = "TextBoxTelefonoNCliente"
        Me.TextBoxTelefonoNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxTelefonoNCliente.TabIndex = 26
        '
        'TextBoxContactoNCliente
        '
        Me.TextBoxContactoNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxContactoNCliente.Location = New System.Drawing.Point(74, 92)
        Me.TextBoxContactoNCliente.Name = "TextBoxContactoNCliente"
        Me.TextBoxContactoNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxContactoNCliente.TabIndex = 25
        '
        'TextBoxFerreteriaNCliente
        '
        Me.TextBoxFerreteriaNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFerreteriaNCliente.Location = New System.Drawing.Point(74, 67)
        Me.TextBoxFerreteriaNCliente.Name = "TextBoxFerreteriaNCliente"
        Me.TextBoxFerreteriaNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxFerreteriaNCliente.TabIndex = 24
        '
        'TextBoxNitNCliente
        '
        Me.TextBoxNitNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNitNCliente.Location = New System.Drawing.Point(74, 42)
        Me.TextBoxNitNCliente.Name = "TextBoxNitNCliente"
        Me.TextBoxNitNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxNitNCliente.TabIndex = 23
        '
        'TextBoxCodigoNCliente
        '
        Me.TextBoxCodigoNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCodigoNCliente.Location = New System.Drawing.Point(74, 16)
        Me.TextBoxCodigoNCliente.Name = "TextBoxCodigoNCliente"
        Me.TextBoxCodigoNCliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoNCliente.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(18, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ruta"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(18, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Barrio"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(18, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(18, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cel"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(18, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(18, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(18, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ferreteria"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nit"
        '
        'CodigoNCliente
        '
        Me.CodigoNCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodigoNCliente.AutoSize = True
        Me.CodigoNCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CodigoNCliente.Location = New System.Drawing.Point(18, 19)
        Me.CodigoNCliente.Name = "CodigoNCliente"
        Me.CodigoNCliente.Size = New System.Drawing.Size(59, 17)
        Me.CodigoNCliente.TabIndex = 3
        Me.CodigoNCliente.Text = "Codigo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonCancelarECliente)
        Me.TabPage3.Controls.Add(Me.ButtonEliminarCliente)
        Me.TabPage3.Controls.Add(Me.ButtonBuscarEliminarCliente)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TextBoxFerreteriaECliente)
        Me.TabPage3.Controls.Add(Me.TextBoxNitECliente)
        Me.TabPage3.Controls.Add(Me.TextBoxCodigoECliente)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonCancelarECliente
        '
        Me.ButtonCancelarECliente.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarECliente.FlatAppearance.BorderSize = 0
        Me.ButtonCancelarECliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarECliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarECliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarECliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarECliente.Location = New System.Drawing.Point(257, 166)
        Me.ButtonCancelarECliente.Name = "ButtonCancelarECliente"
        Me.ButtonCancelarECliente.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelarECliente.TabIndex = 11
        Me.ButtonCancelarECliente.Text = "Cancelar"
        Me.ButtonCancelarECliente.UseVisualStyleBackColor = False
        '
        'ButtonEliminarCliente
        '
        Me.ButtonEliminarCliente.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarCliente.FlatAppearance.BorderSize = 0
        Me.ButtonEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarCliente.Location = New System.Drawing.Point(390, 166)
        Me.ButtonEliminarCliente.Name = "ButtonEliminarCliente"
        Me.ButtonEliminarCliente.Size = New System.Drawing.Size(64, 20)
        Me.ButtonEliminarCliente.TabIndex = 10
        Me.ButtonEliminarCliente.Text = "Eliminar"
        Me.ButtonEliminarCliente.UseVisualStyleBackColor = False
        '
        'ButtonBuscarEliminarCliente
        '
        Me.ButtonBuscarEliminarCliente.BackColor = System.Drawing.Color.Navy
        Me.ButtonBuscarEliminarCliente.FlatAppearance.BorderSize = 0
        Me.ButtonBuscarEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonBuscarEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonBuscarEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonBuscarEliminarCliente.Location = New System.Drawing.Point(459, 62)
        Me.ButtonBuscarEliminarCliente.Name = "ButtonBuscarEliminarCliente"
        Me.ButtonBuscarEliminarCliente.Size = New System.Drawing.Size(64, 20)
        Me.ButtonBuscarEliminarCliente.TabIndex = 9
        Me.ButtonBuscarEliminarCliente.Text = "Buscar"
        Me.ButtonBuscarEliminarCliente.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(201, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Ferreteria"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(201, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Nit"
        '
        'TextBoxFerreteriaECliente
        '
        Me.TextBoxFerreteriaECliente.Location = New System.Drawing.Point(257, 114)
        Me.TextBoxFerreteriaECliente.Name = "TextBoxFerreteriaECliente"
        Me.TextBoxFerreteriaECliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxFerreteriaECliente.TabIndex = 6
        '
        'TextBoxNitECliente
        '
        Me.TextBoxNitECliente.Location = New System.Drawing.Point(257, 88)
        Me.TextBoxNitECliente.Name = "TextBoxNitECliente"
        Me.TextBoxNitECliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxNitECliente.TabIndex = 5
        '
        'TextBoxCodigoECliente
        '
        Me.TextBoxCodigoECliente.Location = New System.Drawing.Point(257, 63)
        Me.TextBoxCodigoECliente.Name = "TextBoxCodigoECliente"
        Me.TextBoxCodigoECliente.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoECliente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ButtonExportarAExcelClientes)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.MosTablaClientes)
        Me.TabPage4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(863, 432)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ButtonExportarAExcelClientes
        '
        Me.ButtonExportarAExcelClientes.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonExportarAExcelClientes.FlatAppearance.BorderSize = 0
        Me.ButtonExportarAExcelClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonExportarAExcelClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ButtonExportarAExcelClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportarAExcelClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonExportarAExcelClientes.Image = CType(resources.GetObject("ButtonExportarAExcelClientes.Image"), System.Drawing.Image)
        Me.ButtonExportarAExcelClientes.Location = New System.Drawing.Point(589, 2)
        Me.ButtonExportarAExcelClientes.Name = "ButtonExportarAExcelClientes"
        Me.ButtonExportarAExcelClientes.Size = New System.Drawing.Size(115, 35)
        Me.ButtonExportarAExcelClientes.TabIndex = 5
        Me.ButtonExportarAExcelClientes.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelClientes.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 14)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Lista de Clientes"
        '
        'MosTablaClientes
        '
        Me.MosTablaClientes.AllowUserToAddRows = False
        Me.MosTablaClientes.AllowUserToDeleteRows = False
        Me.MosTablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MosTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MosTablaClientes.Location = New System.Drawing.Point(7, 53)
        Me.MosTablaClientes.Name = "MosTablaClientes"
        Me.MosTablaClientes.ReadOnly = True
        Me.MosTablaClientes.RowTemplate.Height = 25
        Me.MosTablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MosTablaClientes.Size = New System.Drawing.Size(697, 288)
        Me.MosTablaClientes.TabIndex = 0
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
        Me.Panel1.Size = New System.Drawing.Size(871, 60)
        Me.Panel1.TabIndex = 2
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(21, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(144, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Clientes"
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
        Me.RadioButton3.Text = "Clientes"
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
        Me.RadioButton2.Text = "Eliminar"
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(864, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlClientes)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.TabControlClientes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVClientesBUscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.MosTablaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlClientes As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LabelClientes As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxRutaNCliente As TextBox
    Friend WithEvents TextBoxBarrioNCliente As TextBox
    Friend WithEvents TextBoxDireccionNCliente As TextBox
    Friend WithEvents TextBoxEmailNCliente As TextBox
    Friend WithEvents TextBoxCelNCliente As TextBox
    Friend WithEvents TextBoxTelefonoNCliente As TextBox
    Friend WithEvents TextBoxContactoNCliente As TextBox
    Friend WithEvents TextBoxFerreteriaNCliente As TextBox
    Friend WithEvents TextBoxNitNCliente As TextBox
    Friend WithEvents TextBoxCodigoNCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CodigoNCliente As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ButtonEliminarCliente As Button
    Friend WithEvents ButtonBuscarEliminarCliente As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxFerreteriaECliente As TextBox
    Friend WithEvents TextBoxNitECliente As TextBox
    Friend WithEvents TextBoxCodigoECliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCancelarECliente As Button
    Friend WithEvents MosTablaClientes As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CBVendedor As ComboBox
    Friend WithEvents TBCodVendedor As TextBox
    Friend WithEvents TBNotaClientes As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonExportarAExcelClientes As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBFiltrarPorCodigo As TextBox
    Friend WithEvents TBFiltrarPorFerreteria As TextBox
    Friend WithEvents DGVClientesBUscar As DataGridView
    Friend WithEvents ButtonModificarCliente As Button
End Class
