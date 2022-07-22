<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEnListaDePrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarEnListaDePrecios))
        Me.TCBuscarEnListaDePrecios = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVCategoriaBuscar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBFiltrarCategoria = New System.Windows.Forms.TextBox()
        Me.ButtonEliminarCategoria = New System.Windows.Forms.Button()
        Me.CancelarCategoria = New System.Windows.Forms.Button()
        Me.TBCategoria = New System.Windows.Forms.TextBox()
        Me.ButtonNuevaCategoria = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGVSubCategoriaBuscar = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBFiltrarSubCategoria = New System.Windows.Forms.TextBox()
        Me.ButtonEliminarSubCategoria = New System.Windows.Forms.Button()
        Me.CancelarSubCategoria = New System.Windows.Forms.Button()
        Me.TBSubCategoria = New System.Windows.Forms.TextBox()
        Me.ButtonNuevaSubCategoria = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGVUbicacionBuscar = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBFiltrarUbicacion = New System.Windows.Forms.TextBox()
        Me.ButtonEliminarUbicacion = New System.Windows.Forms.Button()
        Me.CancelarUbicacion = New System.Windows.Forms.Button()
        Me.TBUbicacion = New System.Windows.Forms.TextBox()
        Me.ButtonNuevaUbicacion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.Maximizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.RBUbicacion = New System.Windows.Forms.RadioButton()
        Me.RBSubCategoria = New System.Windows.Forms.RadioButton()
        Me.RBNuevoProducto = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TCBuscarEnListaDePrecios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVCategoriaBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVSubCategoriaBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVUbicacionBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TCBuscarEnListaDePrecios
        '
        Me.TCBuscarEnListaDePrecios.Controls.Add(Me.TabPage1)
        Me.TCBuscarEnListaDePrecios.Controls.Add(Me.TabPage2)
        Me.TCBuscarEnListaDePrecios.Controls.Add(Me.TabPage3)
        Me.TCBuscarEnListaDePrecios.Location = New System.Drawing.Point(0, 36)
        Me.TCBuscarEnListaDePrecios.Name = "TCBuscarEnListaDePrecios"
        Me.TCBuscarEnListaDePrecios.SelectedIndex = 0
        Me.TCBuscarEnListaDePrecios.Size = New System.Drawing.Size(379, 343)
        Me.TCBuscarEnListaDePrecios.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVCategoriaBuscar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TBFiltrarCategoria)
        Me.TabPage1.Controls.Add(Me.ButtonEliminarCategoria)
        Me.TabPage1.Controls.Add(Me.CancelarCategoria)
        Me.TabPage1.Controls.Add(Me.TBCategoria)
        Me.TabPage1.Controls.Add(Me.ButtonNuevaCategoria)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(371, 317)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVCategoriaBuscar
        '
        Me.DGVCategoriaBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCategoriaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCategoriaBuscar.Location = New System.Drawing.Point(6, 76)
        Me.DGVCategoriaBuscar.Name = "DGVCategoriaBuscar"
        Me.DGVCategoriaBuscar.RowTemplate.Height = 25
        Me.DGVCategoriaBuscar.Size = New System.Drawing.Size(358, 229)
        Me.DGVCategoriaBuscar.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Buscar"
        '
        'TBFiltrarCategoria
        '
        Me.TBFiltrarCategoria.Location = New System.Drawing.Point(97, 51)
        Me.TBFiltrarCategoria.Name = "TBFiltrarCategoria"
        Me.TBFiltrarCategoria.Size = New System.Drawing.Size(268, 20)
        Me.TBFiltrarCategoria.TabIndex = 62
        '
        'ButtonEliminarCategoria
        '
        Me.ButtonEliminarCategoria.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarCategoria.Location = New System.Drawing.Point(279, 26)
        Me.ButtonEliminarCategoria.Name = "ButtonEliminarCategoria"
        Me.ButtonEliminarCategoria.Size = New System.Drawing.Size(86, 20)
        Me.ButtonEliminarCategoria.TabIndex = 61
        Me.ButtonEliminarCategoria.Text = "Eliminar"
        Me.ButtonEliminarCategoria.UseVisualStyleBackColor = False
        '
        'CancelarCategoria
        '
        Me.CancelarCategoria.BackColor = System.Drawing.Color.Navy
        Me.CancelarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.CancelarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.CancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarCategoria.Location = New System.Drawing.Point(188, 26)
        Me.CancelarCategoria.Name = "CancelarCategoria"
        Me.CancelarCategoria.Size = New System.Drawing.Size(86, 20)
        Me.CancelarCategoria.TabIndex = 60
        Me.CancelarCategoria.Text = "Cancelar"
        Me.CancelarCategoria.UseVisualStyleBackColor = False
        '
        'TBCategoria
        '
        Me.TBCategoria.Location = New System.Drawing.Point(6, 26)
        Me.TBCategoria.Name = "TBCategoria"
        Me.TBCategoria.Size = New System.Drawing.Size(86, 20)
        Me.TBCategoria.TabIndex = 58
        '
        'ButtonNuevaCategoria
        '
        Me.ButtonNuevaCategoria.BackColor = System.Drawing.Color.Navy
        Me.ButtonNuevaCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonNuevaCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevaCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonNuevaCategoria.Location = New System.Drawing.Point(97, 26)
        Me.ButtonNuevaCategoria.Name = "ButtonNuevaCategoria"
        Me.ButtonNuevaCategoria.Size = New System.Drawing.Size(86, 20)
        Me.ButtonNuevaCategoria.TabIndex = 59
        Me.ButtonNuevaCategoria.Text = "Nuevo"
        Me.ButtonNuevaCategoria.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(-3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 71)
        Me.Panel3.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(143, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Categoria"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGVSubCategoriaBuscar)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TBFiltrarSubCategoria)
        Me.TabPage2.Controls.Add(Me.ButtonEliminarSubCategoria)
        Me.TabPage2.Controls.Add(Me.CancelarSubCategoria)
        Me.TabPage2.Controls.Add(Me.TBSubCategoria)
        Me.TabPage2.Controls.Add(Me.ButtonNuevaSubCategoria)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(371, 317)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGVSubCategoriaBuscar
        '
        Me.DGVSubCategoriaBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSubCategoriaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSubCategoriaBuscar.Location = New System.Drawing.Point(6, 76)
        Me.DGVSubCategoriaBuscar.Name = "DGVSubCategoriaBuscar"
        Me.DGVSubCategoriaBuscar.RowTemplate.Height = 25
        Me.DGVSubCategoriaBuscar.Size = New System.Drawing.Size(358, 229)
        Me.DGVSubCategoriaBuscar.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Buscar"
        '
        'TBFiltrarSubCategoria
        '
        Me.TBFiltrarSubCategoria.Location = New System.Drawing.Point(97, 51)
        Me.TBFiltrarSubCategoria.Name = "TBFiltrarSubCategoria"
        Me.TBFiltrarSubCategoria.Size = New System.Drawing.Size(268, 20)
        Me.TBFiltrarSubCategoria.TabIndex = 70
        '
        'ButtonEliminarSubCategoria
        '
        Me.ButtonEliminarSubCategoria.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarSubCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarSubCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarSubCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarSubCategoria.Location = New System.Drawing.Point(279, 26)
        Me.ButtonEliminarSubCategoria.Name = "ButtonEliminarSubCategoria"
        Me.ButtonEliminarSubCategoria.Size = New System.Drawing.Size(86, 20)
        Me.ButtonEliminarSubCategoria.TabIndex = 69
        Me.ButtonEliminarSubCategoria.Text = "Eliminar"
        Me.ButtonEliminarSubCategoria.UseVisualStyleBackColor = False
        '
        'CancelarSubCategoria
        '
        Me.CancelarSubCategoria.BackColor = System.Drawing.Color.Navy
        Me.CancelarSubCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.CancelarSubCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.CancelarSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarSubCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarSubCategoria.Location = New System.Drawing.Point(188, 26)
        Me.CancelarSubCategoria.Name = "CancelarSubCategoria"
        Me.CancelarSubCategoria.Size = New System.Drawing.Size(86, 20)
        Me.CancelarSubCategoria.TabIndex = 68
        Me.CancelarSubCategoria.Text = "Cancelar"
        Me.CancelarSubCategoria.UseVisualStyleBackColor = False
        '
        'TBSubCategoria
        '
        Me.TBSubCategoria.Location = New System.Drawing.Point(6, 26)
        Me.TBSubCategoria.Name = "TBSubCategoria"
        Me.TBSubCategoria.Size = New System.Drawing.Size(86, 20)
        Me.TBSubCategoria.TabIndex = 66
        '
        'ButtonNuevaSubCategoria
        '
        Me.ButtonNuevaSubCategoria.BackColor = System.Drawing.Color.Navy
        Me.ButtonNuevaSubCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonNuevaSubCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonNuevaSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevaSubCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonNuevaSubCategoria.Location = New System.Drawing.Point(97, 26)
        Me.ButtonNuevaSubCategoria.Name = "ButtonNuevaSubCategoria"
        Me.ButtonNuevaSubCategoria.Size = New System.Drawing.Size(86, 20)
        Me.ButtonNuevaSubCategoria.TabIndex = 67
        Me.ButtonNuevaSubCategoria.Text = "Nuevo"
        Me.ButtonNuevaSubCategoria.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 71)
        Me.Panel2.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(125, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Sub Categoria"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGVUbicacionBuscar)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.TBFiltrarUbicacion)
        Me.TabPage3.Controls.Add(Me.ButtonEliminarUbicacion)
        Me.TabPage3.Controls.Add(Me.CancelarUbicacion)
        Me.TabPage3.Controls.Add(Me.TBUbicacion)
        Me.TabPage3.Controls.Add(Me.ButtonNuevaUbicacion)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(371, 317)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGVUbicacionBuscar
        '
        Me.DGVUbicacionBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUbicacionBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUbicacionBuscar.Location = New System.Drawing.Point(6, 76)
        Me.DGVUbicacionBuscar.Name = "DGVUbicacionBuscar"
        Me.DGVUbicacionBuscar.RowTemplate.Height = 25
        Me.DGVUbicacionBuscar.Size = New System.Drawing.Size(358, 229)
        Me.DGVUbicacionBuscar.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Buscar"
        '
        'TBFiltrarUbicacion
        '
        Me.TBFiltrarUbicacion.Location = New System.Drawing.Point(97, 51)
        Me.TBFiltrarUbicacion.Name = "TBFiltrarUbicacion"
        Me.TBFiltrarUbicacion.Size = New System.Drawing.Size(268, 20)
        Me.TBFiltrarUbicacion.TabIndex = 78
        '
        'ButtonEliminarUbicacion
        '
        Me.ButtonEliminarUbicacion.BackColor = System.Drawing.Color.Navy
        Me.ButtonEliminarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonEliminarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonEliminarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminarUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEliminarUbicacion.Location = New System.Drawing.Point(279, 26)
        Me.ButtonEliminarUbicacion.Name = "ButtonEliminarUbicacion"
        Me.ButtonEliminarUbicacion.Size = New System.Drawing.Size(86, 20)
        Me.ButtonEliminarUbicacion.TabIndex = 77
        Me.ButtonEliminarUbicacion.Text = "Eliminar"
        Me.ButtonEliminarUbicacion.UseVisualStyleBackColor = False
        '
        'CancelarUbicacion
        '
        Me.CancelarUbicacion.BackColor = System.Drawing.Color.Navy
        Me.CancelarUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.CancelarUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.CancelarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarUbicacion.Location = New System.Drawing.Point(188, 26)
        Me.CancelarUbicacion.Name = "CancelarUbicacion"
        Me.CancelarUbicacion.Size = New System.Drawing.Size(86, 20)
        Me.CancelarUbicacion.TabIndex = 76
        Me.CancelarUbicacion.Text = "Cancelar"
        Me.CancelarUbicacion.UseVisualStyleBackColor = False
        '
        'TBUbicacion
        '
        Me.TBUbicacion.Location = New System.Drawing.Point(6, 26)
        Me.TBUbicacion.Name = "TBUbicacion"
        Me.TBUbicacion.Size = New System.Drawing.Size(86, 20)
        Me.TBUbicacion.TabIndex = 74
        '
        'ButtonNuevaUbicacion
        '
        Me.ButtonNuevaUbicacion.BackColor = System.Drawing.Color.Navy
        Me.ButtonNuevaUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.ButtonNuevaUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.ButtonNuevaUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevaUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonNuevaUbicacion.Location = New System.Drawing.Point(97, 26)
        Me.ButtonNuevaUbicacion.Name = "ButtonNuevaUbicacion"
        Me.ButtonNuevaUbicacion.Size = New System.Drawing.Size(86, 20)
        Me.ButtonNuevaUbicacion.TabIndex = 75
        Me.ButtonNuevaUbicacion.Text = "Nuevo"
        Me.ButtonNuevaUbicacion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 71)
        Me.Panel1.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(151, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Ubicación"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.RBUbicacion)
        Me.Panel4.Controls.Add(Me.RBSubCategoria)
        Me.Panel4.Controls.Add(Me.RBNuevoProducto)
        Me.Panel4.Location = New System.Drawing.Point(2, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(375, 23)
        Me.Panel4.TabIndex = 84
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
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
        Me.Panel5.Size = New System.Drawing.Size(375, 23)
        Me.Panel5.TabIndex = 88
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
        Me.Button2.Location = New System.Drawing.Point(347, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
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
        Me.Button1.Location = New System.Drawing.Point(326, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(517, 0)
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
        Me.Restaurar.Location = New System.Drawing.Point(1063, 0)
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
        Me.minimizar.Location = New System.Drawing.Point(1023, 0)
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
        Me.Maximizar.Location = New System.Drawing.Point(1063, 0)
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
        Me.cerrar.Location = New System.Drawing.Point(1102, 0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(34, 35)
        Me.cerrar.TabIndex = 0
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'RBUbicacion
        '
        Me.RBUbicacion.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBUbicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBUbicacion.FlatAppearance.BorderSize = 0
        Me.RBUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RBUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RBUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBUbicacion.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RBUbicacion.Location = New System.Drawing.Point(185, 34)
        Me.RBUbicacion.Name = "RBUbicacion"
        Me.RBUbicacion.Size = New System.Drawing.Size(86, 20)
        Me.RBUbicacion.TabIndex = 87
        Me.RBUbicacion.Text = "Ubicación"
        Me.RBUbicacion.UseVisualStyleBackColor = True
        '
        'RBSubCategoria
        '
        Me.RBSubCategoria.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBSubCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBSubCategoria.FlatAppearance.BorderSize = 0
        Me.RBSubCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.RBSubCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.RBSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBSubCategoria.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!)
        Me.RBSubCategoria.Location = New System.Drawing.Point(94, 34)
        Me.RBSubCategoria.Name = "RBSubCategoria"
        Me.RBSubCategoria.Size = New System.Drawing.Size(86, 20)
        Me.RBSubCategoria.TabIndex = 86
        Me.RBSubCategoria.Text = "Sub Categoria"
        Me.RBSubCategoria.UseVisualStyleBackColor = True
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
        Me.RBNuevoProducto.Location = New System.Drawing.Point(3, 34)
        Me.RBNuevoProducto.Name = "RBNuevoProducto"
        Me.RBNuevoProducto.Size = New System.Drawing.Size(86, 20)
        Me.RBNuevoProducto.TabIndex = 85
        Me.RBNuevoProducto.TabStop = True
        Me.RBNuevoProducto.Text = "Categoria"
        Me.RBNuevoProducto.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel6.Controls.Add(Me.RadioButton3)
        Me.Panel6.Controls.Add(Me.RadioButton1)
        Me.Panel6.Controls.Add(Me.RadioButton2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(379, 58)
        Me.Panel6.TabIndex = 85
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
        Me.RadioButton3.Location = New System.Drawing.Point(207, 36)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 25)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Ubicación"
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        Me.RadioButton1.Size = New System.Drawing.Size(83, 25)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Categoria"
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
        Me.RadioButton2.Location = New System.Drawing.Point(99, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "sub categoria"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'BuscarEnListaDePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 383)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.TCBuscarEnListaDePrecios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarEnListaDePrecios"
        Me.Text = "Añadir a desplegables"
        Me.TCBuscarEnListaDePrecios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVCategoriaBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVSubCategoriaBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVUbicacionBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCBuscarEnListaDePrecios As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TBFiltrarCategoria As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonEliminarCategoria As Button
    Friend WithEvents CancelarCategoria As Button
    Friend WithEvents TBCategoria As TextBox
    Friend WithEvents ButtonNuevaCategoria As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGVSubCategoriaBuscar As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TBFiltrarSubCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEliminarSubCategoria As Button
    Friend WithEvents CancelarSubCategoria As Button
    Friend WithEvents TBSubCategoria As TextBox
    Friend WithEvents ButtonNuevaSubCategoria As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DGVUbicacionBuscar As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TBFiltrarUbicacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonEliminarUbicacion As Button
    Friend WithEvents CancelarUbicacion As Button
    Friend WithEvents TBUbicacion As TextBox
    Friend WithEvents ButtonNuevaUbicacion As Button
    Friend WithEvents DGVCategoriaBuscar As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RBNuevoProducto As RadioButton
    Friend WithEvents RBUbicacion As RadioButton
    Friend WithEvents RBSubCategoria As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Restaurar As Button
    Friend WithEvents minimizar As Button
    Friend WithEvents Maximizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
