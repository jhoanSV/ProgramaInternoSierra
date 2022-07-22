<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proovedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proovedores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonNuevo = New System.Windows.Forms.RadioButton()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TabControlProovedores = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBFiltrarPorCodigo = New System.Windows.Forms.TextBox()
        Me.TBFiltrarPorFerreteria = New System.Windows.Forms.TextBox()
        Me.DGVProveedoresBuscar = New System.Windows.Forms.DataGridView()
        Me.TextBoxNotaNproovedor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonGuardarNProovedor = New System.Windows.Forms.Button()
        Me.ButtonCancelarNProovedor = New System.Windows.Forms.Button()
        Me.TextBoxRutaNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccionNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxWebNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxCelNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefonoNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxContactoNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxProovedorNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxNitNProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoNProovedores = New System.Windows.Forms.TextBox()
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
        Me.ButtonCancelarEProovedores = New System.Windows.Forms.Button()
        Me.ButtonEliminarProovedores = New System.Windows.Forms.Button()
        Me.ButtonBuscarEliminarProovedores = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxProovedorEProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxNitEProovedores = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoEProovedores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ButtonExportarAExcelProovedores = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DGVListaProovedores = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.TabControlProovedores.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVProveedoresBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGVListaProovedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.RadioButtonNuevo)
        Me.Panel1.Controls.Add(Me.LabelClientes)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 60)
        Me.Panel1.TabIndex = 3
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
        Me.RadioButtonNuevo.Text = "Nuevo"
        Me.RadioButtonNuevo.UseVisualStyleBackColor = True
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Magneto", 21.75!, System.Drawing.FontStyle.Bold)
        Me.LabelClientes.ForeColor = System.Drawing.Color.White
        Me.LabelClientes.Location = New System.Drawing.Point(3, 9)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(210, 35)
        Me.LabelClientes.TabIndex = 3
        Me.LabelClientes.Text = "Proovedores"
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
        Me.RadioButton3.Text = "Lista"
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
        'TabControlProovedores
        '
        Me.TabControlProovedores.Controls.Add(Me.TabPage1)
        Me.TabControlProovedores.Controls.Add(Me.TabPage3)
        Me.TabControlProovedores.Controls.Add(Me.TabPage4)
        Me.TabControlProovedores.ItemSize = New System.Drawing.Size(62, 20)
        Me.TabControlProovedores.Location = New System.Drawing.Point(0, 41)
        Me.TabControlProovedores.Name = "TabControlProovedores"
        Me.TabControlProovedores.SelectedIndex = 0
        Me.TabControlProovedores.Size = New System.Drawing.Size(747, 397)
        Me.TabControlProovedores.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonModificar)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorCodigo)
        Me.TabPage1.Controls.Add(Me.TBFiltrarPorFerreteria)
        Me.TabPage1.Controls.Add(Me.DGVProveedoresBuscar)
        Me.TabPage1.Controls.Add(Me.TextBoxNotaNproovedor)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.ButtonGuardarNProovedor)
        Me.TabPage1.Controls.Add(Me.ButtonCancelarNProovedor)
        Me.TabPage1.Controls.Add(Me.TextBoxRutaNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxDireccionNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxWebNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxEmailNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxCelNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxTelefonoNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxContactoNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxProovedorNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxNitNProovedores)
        Me.TabPage1.Controls.Add(Me.TextBoxCodigoNProovedores)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(739, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.Navy
        Me.ButtonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonModificar.Location = New System.Drawing.Point(417, 317)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(64, 20)
        Me.ButtonModificar.TabIndex = 55
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(415, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 17)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Filtrar busqueda por:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(415, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 17)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Proveedor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(276, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 17)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Codigo"
        '
        'TBFiltrarPorCodigo
        '
        Me.TBFiltrarPorCodigo.Location = New System.Drawing.Point(332, 42)
        Me.TBFiltrarPorCodigo.Name = "TBFiltrarPorCodigo"
        Me.TBFiltrarPorCodigo.Size = New System.Drawing.Size(79, 25)
        Me.TBFiltrarPorCodigo.TabIndex = 51
        '
        'TBFiltrarPorFerreteria
        '
        Me.TBFiltrarPorFerreteria.Location = New System.Drawing.Point(491, 42)
        Me.TBFiltrarPorFerreteria.Name = "TBFiltrarPorFerreteria"
        Me.TBFiltrarPorFerreteria.Size = New System.Drawing.Size(205, 25)
        Me.TBFiltrarPorFerreteria.TabIndex = 50
        '
        'DGVProveedoresBuscar
        '
        Me.DGVProveedoresBuscar.AllowUserToAddRows = False
        Me.DGVProveedoresBuscar.AllowUserToDeleteRows = False
        Me.DGVProveedoresBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProveedoresBuscar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVProveedoresBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedoresBuscar.Location = New System.Drawing.Point(276, 67)
        Me.DGVProveedoresBuscar.Name = "DGVProveedoresBuscar"
        Me.DGVProveedoresBuscar.ReadOnly = True
        Me.DGVProveedoresBuscar.RowTemplate.Height = 25
        Me.DGVProveedoresBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProveedoresBuscar.Size = New System.Drawing.Size(419, 238)
        Me.DGVProveedoresBuscar.TabIndex = 49
        '
        'TextBoxNotaNproovedor
        '
        Me.TextBoxNotaNproovedor.Location = New System.Drawing.Point(76, 267)
        Me.TextBoxNotaNproovedor.Multiline = True
        Me.TextBoxNotaNproovedor.Name = "TextBoxNotaNproovedor"
        Me.TextBoxNotaNproovedor.Size = New System.Drawing.Size(198, 71)
        Me.TextBoxNotaNproovedor.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(21, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Nota:"
        '
        'ButtonGuardarNProovedor
        '
        Me.ButtonGuardarNProovedor.BackColor = System.Drawing.Color.Navy
        Me.ButtonGuardarNProovedor.FlatAppearance.BorderSize = 0
        Me.ButtonGuardarNProovedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonGuardarNProovedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonGuardarNProovedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarNProovedor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonGuardarNProovedor.Location = New System.Drawing.Point(279, 317)
        Me.ButtonGuardarNProovedor.Name = "ButtonGuardarNProovedor"
        Me.ButtonGuardarNProovedor.Size = New System.Drawing.Size(64, 20)
        Me.ButtonGuardarNProovedor.TabIndex = 34
        Me.ButtonGuardarNProovedor.Text = "Nuevo"
        Me.ButtonGuardarNProovedor.UseVisualStyleBackColor = False
        '
        'ButtonCancelarNProovedor
        '
        Me.ButtonCancelarNProovedor.BackColor = System.Drawing.Color.Navy
        Me.ButtonCancelarNProovedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancelarNProovedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonCancelarNProovedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarNProovedor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancelarNProovedor.Location = New System.Drawing.Point(348, 317)
        Me.ButtonCancelarNProovedor.Name = "ButtonCancelarNProovedor"
        Me.ButtonCancelarNProovedor.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCancelarNProovedor.TabIndex = 33
        Me.ButtonCancelarNProovedor.Text = "Cancelar"
        Me.ButtonCancelarNProovedor.UseVisualStyleBackColor = False
        '
        'TextBoxRutaNProovedores
        '
        Me.TextBoxRutaNProovedores.Location = New System.Drawing.Point(76, 243)
        Me.TextBoxRutaNProovedores.Name = "TextBoxRutaNProovedores"
        Me.TextBoxRutaNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxRutaNProovedores.TabIndex = 31
        '
        'TextBoxDireccionNProovedores
        '
        Me.TextBoxDireccionNProovedores.Location = New System.Drawing.Point(76, 218)
        Me.TextBoxDireccionNProovedores.Name = "TextBoxDireccionNProovedores"
        Me.TextBoxDireccionNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxDireccionNProovedores.TabIndex = 30
        '
        'TextBoxWebNProovedores
        '
        Me.TextBoxWebNProovedores.Location = New System.Drawing.Point(76, 192)
        Me.TextBoxWebNProovedores.Name = "TextBoxWebNProovedores"
        Me.TextBoxWebNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxWebNProovedores.TabIndex = 29
        '
        'TextBoxEmailNProovedores
        '
        Me.TextBoxEmailNProovedores.Location = New System.Drawing.Point(76, 167)
        Me.TextBoxEmailNProovedores.Name = "TextBoxEmailNProovedores"
        Me.TextBoxEmailNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxEmailNProovedores.TabIndex = 28
        '
        'TextBoxCelNProovedores
        '
        Me.TextBoxCelNProovedores.Location = New System.Drawing.Point(76, 142)
        Me.TextBoxCelNProovedores.Name = "TextBoxCelNProovedores"
        Me.TextBoxCelNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCelNProovedores.TabIndex = 27
        '
        'TextBoxTelefonoNProovedores
        '
        Me.TextBoxTelefonoNProovedores.Location = New System.Drawing.Point(76, 117)
        Me.TextBoxTelefonoNProovedores.Name = "TextBoxTelefonoNProovedores"
        Me.TextBoxTelefonoNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxTelefonoNProovedores.TabIndex = 26
        '
        'TextBoxContactoNProovedores
        '
        Me.TextBoxContactoNProovedores.Location = New System.Drawing.Point(76, 92)
        Me.TextBoxContactoNProovedores.Name = "TextBoxContactoNProovedores"
        Me.TextBoxContactoNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxContactoNProovedores.TabIndex = 25
        '
        'TextBoxProovedorNProovedores
        '
        Me.TextBoxProovedorNProovedores.Location = New System.Drawing.Point(76, 67)
        Me.TextBoxProovedorNProovedores.Name = "TextBoxProovedorNProovedores"
        Me.TextBoxProovedorNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxProovedorNProovedores.TabIndex = 24
        '
        'TextBoxNitNProovedores
        '
        Me.TextBoxNitNProovedores.Location = New System.Drawing.Point(76, 42)
        Me.TextBoxNitNProovedores.Name = "TextBoxNitNProovedores"
        Me.TextBoxNitNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxNitNProovedores.TabIndex = 23
        '
        'TextBoxCodigoNProovedores
        '
        Me.TextBoxCodigoNProovedores.Location = New System.Drawing.Point(76, 16)
        Me.TextBoxCodigoNProovedores.Name = "TextBoxCodigoNProovedores"
        Me.TextBoxCodigoNProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoNProovedores.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(21, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ruta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(21, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(21, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Web"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(21, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(21, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(21, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(21, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(21, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nit"
        '
        'CodigoNCliente
        '
        Me.CodigoNCliente.AutoSize = True
        Me.CodigoNCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CodigoNCliente.Location = New System.Drawing.Point(21, 19)
        Me.CodigoNCliente.Name = "CodigoNCliente"
        Me.CodigoNCliente.Size = New System.Drawing.Size(59, 17)
        Me.CodigoNCliente.TabIndex = 3
        Me.CodigoNCliente.Text = "Codigo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonCancelarEProovedores)
        Me.TabPage3.Controls.Add(Me.ButtonEliminarProovedores)
        Me.TabPage3.Controls.Add(Me.ButtonBuscarEliminarProovedores)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TextBoxProovedorEProovedores)
        Me.TabPage3.Controls.Add(Me.TextBoxNitEProovedores)
        Me.TabPage3.Controls.Add(Me.TextBoxCodigoEProovedores)
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
        Me.ButtonBuscarEliminarProovedores.Location = New System.Drawing.Point(459, 63)
        Me.ButtonBuscarEliminarProovedores.Name = "ButtonBuscarEliminarProovedores"
        Me.ButtonBuscarEliminarProovedores.Size = New System.Drawing.Size(64, 20)
        Me.ButtonBuscarEliminarProovedores.TabIndex = 9
        Me.ButtonBuscarEliminarProovedores.Text = "Buscar"
        Me.ButtonBuscarEliminarProovedores.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(203, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Proovedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(203, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Nit"
        '
        'TextBoxProovedorEProovedores
        '
        Me.TextBoxProovedorEProovedores.Location = New System.Drawing.Point(257, 114)
        Me.TextBoxProovedorEProovedores.Name = "TextBoxProovedorEProovedores"
        Me.TextBoxProovedorEProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxProovedorEProovedores.TabIndex = 6
        '
        'TextBoxNitEProovedores
        '
        Me.TextBoxNitEProovedores.Location = New System.Drawing.Point(257, 88)
        Me.TextBoxNitEProovedores.Name = "TextBoxNitEProovedores"
        Me.TextBoxNitEProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxNitEProovedores.TabIndex = 5
        '
        'TextBoxCodigoEProovedores
        '
        Me.TextBoxCodigoEProovedores.Location = New System.Drawing.Point(257, 63)
        Me.TextBoxCodigoEProovedores.Name = "TextBoxCodigoEProovedores"
        Me.TextBoxCodigoEProovedores.Size = New System.Drawing.Size(198, 25)
        Me.TextBoxCodigoEProovedores.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ButtonExportarAExcelProovedores)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.DGVListaProovedores)
        Me.TabPage4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(739, 369)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ButtonExportarAExcelProovedores
        '
        Me.ButtonExportarAExcelProovedores.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonExportarAExcelProovedores.FlatAppearance.BorderSize = 0
        Me.ButtonExportarAExcelProovedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonExportarAExcelProovedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ButtonExportarAExcelProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportarAExcelProovedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonExportarAExcelProovedores.Image = CType(resources.GetObject("ButtonExportarAExcelProovedores.Image"), System.Drawing.Image)
        Me.ButtonExportarAExcelProovedores.Location = New System.Drawing.Point(569, 1)
        Me.ButtonExportarAExcelProovedores.Name = "ButtonExportarAExcelProovedores"
        Me.ButtonExportarAExcelProovedores.Size = New System.Drawing.Size(135, 35)
        Me.ButtonExportarAExcelProovedores.TabIndex = 4
        Me.ButtonExportarAExcelProovedores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelProovedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelProovedores.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 14)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Lista de Proovedores"
        '
        'DGVListaProovedores
        '
        Me.DGVListaProovedores.AllowUserToAddRows = False
        Me.DGVListaProovedores.AllowUserToDeleteRows = False
        Me.DGVListaProovedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVListaProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListaProovedores.Location = New System.Drawing.Point(7, 53)
        Me.DGVListaProovedores.Name = "DGVListaProovedores"
        Me.DGVListaProovedores.ReadOnly = True
        Me.DGVListaProovedores.RowTemplate.Height = 25
        Me.DGVListaProovedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVListaProovedores.Size = New System.Drawing.Size(697, 288)
        Me.DGVListaProovedores.TabIndex = 2
        '
        'Proovedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(741, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlProovedores)
        Me.Name = "Proovedores"
        Me.Text = "Proovedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlProovedores.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVProveedoresBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DGVListaProovedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelClientes As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TabControlProovedores As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtonGuardarNProovedor As Button
    Friend WithEvents ButtonCancelarNProovedor As Button
    Friend WithEvents TextBoxRutaNProovedores As TextBox
    Friend WithEvents TextBoxDireccionNProovedores As TextBox
    Friend WithEvents TextBoxWebNProovedores As TextBox
    Friend WithEvents TextBoxEmailNProovedores As TextBox
    Friend WithEvents TextBoxCelNProovedores As TextBox
    Friend WithEvents TextBoxTelefonoNProovedores As TextBox
    Friend WithEvents TextBoxContactoNProovedores As TextBox
    Friend WithEvents TextBoxProovedorNProovedores As TextBox
    Friend WithEvents TextBoxNitNProovedores As TextBox
    Friend WithEvents TextBoxCodigoNProovedores As TextBox
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ButtonCancelarEProovedores As Button
    Friend WithEvents ButtonEliminarProovedores As Button
    Friend WithEvents ButtonBuscarEliminarProovedores As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxProovedorEProovedores As TextBox
    Friend WithEvents TextBoxNitEProovedores As TextBox
    Friend WithEvents TextBoxCodigoEProovedores As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RadioButtonNuevo As RadioButton
    Friend WithEvents DGVListaProovedores As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonExportarAExcelProovedores As Button
    Friend WithEvents TextBoxNotaNproovedor As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBFiltrarPorCodigo As TextBox
    Friend WithEvents TBFiltrarPorFerreteria As TextBox
    Friend WithEvents DGVProveedoresBuscar As DataGridView
    Friend WithEvents ButtonModificar As Button
End Class
