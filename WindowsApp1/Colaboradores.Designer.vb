<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colaboradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Colaboradores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonNuevo = New System.Windows.Forms.RadioButton()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RadioButtonEliminarColaboradores = New System.Windows.Forms.RadioButton()
        Me.RadioButtonListaColaboradores = New System.Windows.Forms.RadioButton()
        Me.TabControlColaboradores = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBFiltrarPorCodigo = New System.Windows.Forms.TextBox()
        Me.TBFiltrarPorFerreteria = New System.Windows.Forms.TextBox()
        Me.DGVColaboradoresBuscar = New System.Windows.Forms.DataGridView()
        Me.ButtonModificarColaboradores = New System.Windows.Forms.Button()
        Me.ButtonCrearColaboradores = New System.Windows.Forms.Button()
        Me.ButonBuscarColaborador = New System.Windows.Forms.Button()
        Me.ButtonCancelarColaboradores = New System.Windows.Forms.Button()
        Me.TextBoxNotaColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccionColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxCelColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefonoColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxCargoColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxApellidoColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoColaboradores = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodigoNCliente = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonExportarAExcelColaboradores = New System.Windows.Forms.Button()
        Me.DGVListaColaboradores = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonCancelarEProovedores = New System.Windows.Forms.Button()
        Me.ButtonEliminarProovedores = New System.Windows.Forms.Button()
        Me.ButtonBuscarEliminarProovedores = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxCargoEColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxColaboradorEColaboradores = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoEColaboradores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControlColaboradores.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVColaboradoresBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVListaColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.RadioButtonNuevo)
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Controls.Add(Me.RadioButtonEliminarColaboradores)
        Me.Panel1.Controls.Add(Me.RadioButtonListaColaboradores)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 60)
        Me.Panel1.TabIndex = 4
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
        Me.RadioButtonNuevo.Location = New System.Drawing.Point(10, 36)
        Me.RadioButtonNuevo.Name = "RadioButtonNuevo"
        Me.RadioButtonNuevo.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonNuevo.TabIndex = 4
        Me.RadioButtonNuevo.TabStop = True
        Me.RadioButtonNuevo.Text = "Datos"
        Me.RadioButtonNuevo.UseVisualStyleBackColor = True
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(21, 8)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(240, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Colaboradores"
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
        Me.RadioButtonEliminarColaboradores.Location = New System.Drawing.Point(158, 36)
        Me.RadioButtonEliminarColaboradores.Name = "RadioButtonEliminarColaboradores"
        Me.RadioButtonEliminarColaboradores.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonEliminarColaboradores.TabIndex = 2
        Me.RadioButtonEliminarColaboradores.Text = "Eliminar"
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
        Me.RadioButtonListaColaboradores.Location = New System.Drawing.Point(84, 36)
        Me.RadioButtonListaColaboradores.Name = "RadioButtonListaColaboradores"
        Me.RadioButtonListaColaboradores.Size = New System.Drawing.Size(69, 25)
        Me.RadioButtonListaColaboradores.TabIndex = 1
        Me.RadioButtonListaColaboradores.Text = "Lista"
        Me.RadioButtonListaColaboradores.UseVisualStyleBackColor = True
        '
        'TabControlColaboradores
        '
        Me.TabControlColaboradores.Controls.Add(Me.TabPage1)
        Me.TabControlColaboradores.Controls.Add(Me.TabPage2)
        Me.TabControlColaboradores.Controls.Add(Me.TabPage3)
        Me.TabControlColaboradores.ItemSize = New System.Drawing.Size(62, 20)
        Me.TabControlColaboradores.Location = New System.Drawing.Point(0, 41)
        Me.TabControlColaboradores.Name = "TabControlColaboradores"
        Me.TabControlColaboradores.SelectedIndex = 0
        Me.TabControlColaboradores.Size = New System.Drawing.Size(747, 397)
        Me.TabControlColaboradores.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorCodigo)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorFerreteria)
        Me.TabPage1.Controls.Add(Me.DGVColaboradoresBuscar)
        Me.TabPage1.Controls.Add(Me.ButtonModificarColaboradores)
        Me.TabPage1.Controls.Add(Me.ButtonCrearColaboradores)
        Me.TabPage1.Controls.Add(Me.ButonBuscarColaborador)
        Me.TabPage1.Controls.Add(Me.ButtonCancelarColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxNotaColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxDireccionColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxEmailColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxCelColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxTelefonoColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxCargoColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxApellidoColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxNombreColaboradores)
        Me.TabPage1.Controls.Add(Me.TextBoxCodigoColaboradores)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(739, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(423, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 17)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Filtrar busqueda por:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(423, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 17)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Colaborador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(284, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 17)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Codigo"
        '
        'TBFiltrarPorCodigo
        '
        Me.TBFiltrarPorCodigo.Location = New System.Drawing.Point(339, 42)
        Me.TBFiltrarPorCodigo.Name = "TBFiltrarPorCodigo"
        Me.TBFiltrarPorCodigo.Size = New System.Drawing.Size(79, 25)
        Me.TBFiltrarPorCodigo.TabIndex = 57
        '
        'TBFiltrarPorFerreteria
        '
        Me.TBFiltrarPorFerreteria.Location = New System.Drawing.Point(499, 42)
        Me.TBFiltrarPorFerreteria.Name = "TBFiltrarPorFerreteria"
        Me.TBFiltrarPorFerreteria.Size = New System.Drawing.Size(205, 25)
        Me.TBFiltrarPorFerreteria.TabIndex = 56
        '
        'DGVColaboradoresBuscar
        '
        Me.DGVColaboradoresBuscar.AllowUserToAddRows = False
        Me.DGVColaboradoresBuscar.AllowUserToDeleteRows = False
        Me.DGVColaboradoresBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVColaboradoresBuscar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVColaboradoresBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVColaboradoresBuscar.Location = New System.Drawing.Point(284, 67)
        Me.DGVColaboradoresBuscar.Name = "DGVColaboradoresBuscar"
        Me.DGVColaboradoresBuscar.ReadOnly = True
        Me.DGVColaboradoresBuscar.RowTemplate.Height = 25
        Me.DGVColaboradoresBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVColaboradoresBuscar.Size = New System.Drawing.Size(419, 189)
        Me.DGVColaboradoresBuscar.TabIndex = 55
        '
        'ButtonModificarColaboradores
        '
        Me.ButtonModificarColaboradores.BackColor = System.Drawing.Color.Navy
        Me.ButtonModificarColaboradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonModificarColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonModificarColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonModificarColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarColaboradores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonModificarColaboradores.Location = New System.Drawing.Point(423, 261)
        Me.ButtonModificarColaboradores.Name = "ButtonModificarColaboradores"
        Me.ButtonModificarColaboradores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonModificarColaboradores.TabIndex = 37
        Me.ButtonModificarColaboradores.Text = "Modificar"
        Me.ButtonModificarColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonModificarColaboradores.UseVisualStyleBackColor = False
        '
        'ButtonCrearColaboradores
        '
        Me.ButtonCrearColaboradores.BackColor = System.Drawing.Color.Navy
        Me.ButtonCrearColaboradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCrearColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCrearColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCrearColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCrearColaboradores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCrearColaboradores.Location = New System.Drawing.Point(353, 261)
        Me.ButtonCrearColaboradores.Name = "ButtonCrearColaboradores"
        Me.ButtonCrearColaboradores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCrearColaboradores.TabIndex = 36
        Me.ButtonCrearColaboradores.Text = "Crear"
        Me.ButtonCrearColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCrearColaboradores.UseVisualStyleBackColor = False
        '
        'ButonBuscarColaborador
        '
        Me.ButonBuscarColaborador.BackColor = System.Drawing.Color.Navy
        Me.ButonBuscarColaborador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButonBuscarColaborador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButonBuscarColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButonBuscarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButonBuscarColaborador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButonBuscarColaborador.Location = New System.Drawing.Point(283, 261)
        Me.ButonBuscarColaborador.Name = "ButonBuscarColaborador"
        Me.ButonBuscarColaborador.Size = New System.Drawing.Size(64, 20)
        Me.ButonBuscarColaborador.TabIndex = 35
        Me.ButonBuscarColaborador.Text = "Buscar"
        Me.ButonBuscarColaborador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButonBuscarColaborador.UseVisualStyleBackColor = False
        '
        'ButtonCancelarColaboradores
        '
        Me.ButtonCancelarColaboradores.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarColaboradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelarColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarColaboradores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarColaboradores.Location = New System.Drawing.Point(492, 261)
        Me.ButtonCancelarColaboradores.Name = "ButtonCancelarColaboradores"
        Me.ButtonCancelarColaboradores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelarColaboradores.TabIndex = 33
        Me.ButtonCancelarColaboradores.Text = "Cancelar"
        Me.ButtonCancelarColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelarColaboradores.UseVisualStyleBackColor = False
        '
        'TextBoxNotaColaboradores
        '
        Me.TextBoxNotaColaboradores.Location = New System.Drawing.Point(81, 218)
        Me.TextBoxNotaColaboradores.Multiline = True
        Me.TextBoxNotaColaboradores.Name = "TextBoxNotaColaboradores"
        Me.TextBoxNotaColaboradores.Size = New System.Drawing.Size(198, 64)
        Me.TextBoxNotaColaboradores.TabIndex = 30
        '
        'TextBoxDireccionColaboradores
        '
        Me.TextBoxDireccionColaboradores.Location = New System.Drawing.Point(81, 192)
        Me.TextBoxDireccionColaboradores.Name = "TextBoxDireccionColaboradores"
        Me.TextBoxDireccionColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxDireccionColaboradores.TabIndex = 29
        '
        'TextBoxEmailColaboradores
        '
        Me.TextBoxEmailColaboradores.Location = New System.Drawing.Point(81, 167)
        Me.TextBoxEmailColaboradores.Name = "TextBoxEmailColaboradores"
        Me.TextBoxEmailColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxEmailColaboradores.TabIndex = 28
        '
        'TextBoxCelColaboradores
        '
        Me.TextBoxCelColaboradores.Location = New System.Drawing.Point(81, 142)
        Me.TextBoxCelColaboradores.Name = "TextBoxCelColaboradores"
        Me.TextBoxCelColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCelColaboradores.TabIndex = 27
        '
        'TextBoxTelefonoColaboradores
        '
        Me.TextBoxTelefonoColaboradores.Location = New System.Drawing.Point(81, 117)
        Me.TextBoxTelefonoColaboradores.Name = "TextBoxTelefonoColaboradores"
        Me.TextBoxTelefonoColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxTelefonoColaboradores.TabIndex = 26
        '
        'TextBoxCargoColaboradores
        '
        Me.TextBoxCargoColaboradores.Location = New System.Drawing.Point(81, 92)
        Me.TextBoxCargoColaboradores.Name = "TextBoxCargoColaboradores"
        Me.TextBoxCargoColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCargoColaboradores.TabIndex = 25
        '
        'TextBoxApellidoColaboradores
        '
        Me.TextBoxApellidoColaboradores.Location = New System.Drawing.Point(81, 67)
        Me.TextBoxApellidoColaboradores.Name = "TextBoxApellidoColaboradores"
        Me.TextBoxApellidoColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxApellidoColaboradores.TabIndex = 24
        '
        'TextBoxNombreColaboradores
        '
        Me.TextBoxNombreColaboradores.Location = New System.Drawing.Point(81, 42)
        Me.TextBoxNombreColaboradores.Name = "TextBoxNombreColaboradores"
        Me.TextBoxNombreColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxNombreColaboradores.TabIndex = 23
        '
        'TextBoxCodigoColaboradores
        '
        Me.TextBoxCodigoColaboradores.Location = New System.Drawing.Point(81, 16)
        Me.TextBoxCodigoColaboradores.Name = "TextBoxCodigoColaboradores"
        Me.TextBoxCodigoColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoColaboradores.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(23, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Nota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(23, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(23, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(23, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(23, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(23, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(23, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(23, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'CodigoNCliente
        '
        Me.CodigoNCliente.AutoSize = True
        Me.CodigoNCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CodigoNCliente.Location = New System.Drawing.Point(23, 19)
        Me.CodigoNCliente.Name = "CodigoNCliente"
        Me.CodigoNCliente.Size = New System.Drawing.Size(59, 17)
        Me.CodigoNCliente.TabIndex = 3
        Me.CodigoNCliente.Text = "Codigo"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonExportarAExcelColaboradores)
        Me.TabPage2.Controls.Add(Me.DGVListaColaboradores)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(739, 369)
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
        Me.ButtonExportarAExcelColaboradores.Location = New System.Drawing.Point(569, 1)
        Me.ButtonExportarAExcelColaboradores.Name = "ButtonExportarAExcelColaboradores"
        Me.ButtonExportarAExcelColaboradores.Size = New System.Drawing.Size(135, 35)
        Me.ButtonExportarAExcelColaboradores.TabIndex = 5
        Me.ButtonExportarAExcelColaboradores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelColaboradores.UseVisualStyleBackColor = False
        '
        'DGVListaColaboradores
        '
        Me.DGVListaColaboradores.AllowUserToAddRows = False
        Me.DGVListaColaboradores.AllowUserToDeleteRows = False
        Me.DGVListaColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVListaColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListaColaboradores.Location = New System.Drawing.Point(7, 53)
        Me.DGVListaColaboradores.Name = "DGVListaColaboradores"
        Me.DGVListaColaboradores.ReadOnly = True
        Me.DGVListaColaboradores.RowTemplate.Height = 25
        Me.DGVListaColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVListaColaboradores.Size = New System.Drawing.Size(697, 288)
        Me.DGVListaColaboradores.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(306, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Lista de Colaboradores"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonCancelarEProovedores)
        Me.TabPage3.Controls.Add(Me.ButtonEliminarProovedores)
        Me.TabPage3.Controls.Add(Me.ButtonBuscarEliminarProovedores)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TextBoxCargoEColaboradores)
        Me.TabPage3.Controls.Add(Me.TextBoxColaboradorEColaboradores)
        Me.TabPage3.Controls.Add(Me.TextBoxCodigoEColaboradores)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(739, 369)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonCancelarEProovedores
        '
        Me.ButtonCancelarEProovedores.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarEProovedores.FlatAppearance.BorderSize = 0
        Me.ButtonCancelarEProovedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarEProovedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarEProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarEProovedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarEProovedores.Location = New System.Drawing.Point(257, 166)
        Me.ButtonCancelarEProovedores.Name = "ButtonCancelarEProovedores"
        Me.ButtonCancelarEProovedores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelarEProovedores.TabIndex = 11
        Me.ButtonCancelarEProovedores.Text = "Cancelar"
        Me.ButtonCancelarEProovedores.UseVisualStyleBackColor = False
        '
        'ButtonEliminarProovedores
        '
        Me.ButtonEliminarProovedores.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarProovedores.FlatAppearance.BorderSize = 0
        Me.ButtonEliminarProovedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarProovedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarProovedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarProovedores.Location = New System.Drawing.Point(390, 166)
        Me.ButtonEliminarProovedores.Name = "ButtonEliminarProovedores"
        Me.ButtonEliminarProovedores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonEliminarProovedores.TabIndex = 10
        Me.ButtonEliminarProovedores.Text = "Eliminar"
        Me.ButtonEliminarProovedores.UseVisualStyleBackColor = False
        '
        'ButtonBuscarEliminarProovedores
        '
        Me.ButtonBuscarEliminarProovedores.BackColor = System.Drawing.Color.Navy
        Me.ButtonBuscarEliminarProovedores.FlatAppearance.BorderSize = 0
        Me.ButtonBuscarEliminarProovedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonBuscarEliminarProovedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonBuscarEliminarProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarEliminarProovedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonBuscarEliminarProovedores.Location = New System.Drawing.Point(459, 62)
        Me.ButtonBuscarEliminarProovedores.Name = "ButtonBuscarEliminarProovedores"
        Me.ButtonBuscarEliminarProovedores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonBuscarEliminarProovedores.TabIndex = 9
        Me.ButtonBuscarEliminarProovedores.Text = "Buscar"
        Me.ButtonBuscarEliminarProovedores.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(183, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Cargo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(183, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Colaborador"
        '
        'TextBoxCargoEColaboradores
        '
        Me.TextBoxCargoEColaboradores.Location = New System.Drawing.Point(257, 114)
        Me.TextBoxCargoEColaboradores.Name = "TextBoxCargoEColaboradores"
        Me.TextBoxCargoEColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCargoEColaboradores.TabIndex = 6
        '
        'TextBoxColaboradorEColaboradores
        '
        Me.TextBoxColaboradorEColaboradores.Location = New System.Drawing.Point(257, 88)
        Me.TextBoxColaboradorEColaboradores.Name = "TextBoxColaboradorEColaboradores"
        Me.TextBoxColaboradorEColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxColaboradorEColaboradores.TabIndex = 5
        '
        'TextBoxCodigoEColaboradores
        '
        Me.TextBoxCodigoEColaboradores.Location = New System.Drawing.Point(257, 63)
        Me.TextBoxCodigoEColaboradores.Name = "TextBoxCodigoEColaboradores"
        Me.TextBoxCodigoEColaboradores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoEColaboradores.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'Colaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(741, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlColaboradores)
        Me.Name = "Colaboradores"
        Me.Text = "Colaboradores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlColaboradores.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVColaboradoresBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVListaColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonNuevo As RadioButton
    Friend WithEvents LabelClientes As Label
    Friend WithEvents RadioButtonEliminarColaboradores As RadioButton
    Friend WithEvents RadioButtonListaColaboradores As RadioButton
    Friend WithEvents TabControlColaboradores As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtonCancelarColaboradores As Button
    Friend WithEvents TextBoxNotaColaboradores As TextBox
    Friend WithEvents TextBoxDireccionColaboradores As TextBox
    Friend WithEvents TextBoxEmailColaboradores As TextBox
    Friend WithEvents TextBoxCelColaboradores As TextBox
    Friend WithEvents TextBoxTelefonoColaboradores As TextBox
    Friend WithEvents TextBoxCargoColaboradores As TextBox
    Friend WithEvents TextBoxApellidoColaboradores As TextBox
    Friend WithEvents TextBoxNombreColaboradores As TextBox
    Friend WithEvents TextBoxCodigoColaboradores As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CodigoNCliente As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ButtonCancelarEProovedores As Button
    Friend WithEvents ButtonEliminarProovedores As Button
    Friend WithEvents ButtonBuscarEliminarProovedores As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxCargoEColaboradores As TextBox
    Friend WithEvents TextBoxColaboradorEColaboradores As TextBox
    Friend WithEvents TextBoxCodigoEColaboradores As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonModificarColaboradores As Button
    Friend WithEvents ButtonCrearColaboradores As Button
    Friend WithEvents ButonBuscarColaborador As Button
    Friend WithEvents DGVListaColaboradores As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonExportarAExcelProovedores As Button
    Friend WithEvents ButtonExportarAExcelColaboradores As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBFiltrarPorCodigo As TextBox
    Friend WithEvents TBFiltrarPorFerreteria As TextBox
    Friend WithEvents DGVColaboradoresBuscar As DataGridView
End Class
