<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDeAlistarPelidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaDeAlistarPelidos))
        Me.DGVListaDeAlistarPedidos = New System.Windows.Forms.DataGridView()
        Me.Ferreteria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descipcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.Maximizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.ButtonExportarAExcelColaboradores = New System.Windows.Forms.Button()
        CType(Me.DGVListaDeAlistarPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVListaDeAlistarPedidos
        '
        Me.DGVListaDeAlistarPedidos.AllowUserToAddRows = False
        Me.DGVListaDeAlistarPedidos.AllowUserToDeleteRows = False
        Me.DGVListaDeAlistarPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVListaDeAlistarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListaDeAlistarPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ferreteria, Me.Cantidad, Me.Codigo, Me.Descipcion, Me.Inventario, Me.Posicion, Me.Consecutivo})
        Me.DGVListaDeAlistarPedidos.Location = New System.Drawing.Point(10, 80)
        Me.DGVListaDeAlistarPedidos.Name = "DGVListaDeAlistarPedidos"
        Me.DGVListaDeAlistarPedidos.ReadOnly = True
        Me.DGVListaDeAlistarPedidos.RowTemplate.Height = 25
        Me.DGVListaDeAlistarPedidos.Size = New System.Drawing.Size(569, 300)
        Me.DGVListaDeAlistarPedidos.TabIndex = 0
        '
        'Ferreteria
        '
        Me.Ferreteria.HeaderText = "Ferreteria"
        Me.Ferreteria.Name = "Ferreteria"
        Me.Ferreteria.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cod"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descipcion
        '
        Me.Descipcion.HeaderText = "Descripción"
        Me.Descipcion.Name = "Descipcion"
        Me.Descipcion.ReadOnly = True
        '
        'Inventario
        '
        Me.Inventario.HeaderText = "Inventario"
        Me.Inventario.Name = "Inventario"
        Me.Inventario.ReadOnly = True
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posición"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        '
        'Consecutivo
        '
        Me.Consecutivo.HeaderText = "N° de pedido"
        Me.Consecutivo.Name = "Consecutivo"
        Me.Consecutivo.ReadOnly = True
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
        Me.Button2.Location = New System.Drawing.Point(765, 0)
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
        Me.Button1.Location = New System.Drawing.Point(733, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Button3)
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
        Me.Panel5.Size = New System.Drawing.Size(594, 35)
        Me.Panel5.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(241, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Alistar Pedidos"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(559, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 35)
        Me.Button4.TabIndex = 8
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(519, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 35)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(728, 0)
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
        Me.Restaurar.Location = New System.Drawing.Point(1485, 0)
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
        Me.minimizar.Location = New System.Drawing.Point(1446, 0)
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
        Me.Maximizar.Location = New System.Drawing.Point(1485, 0)
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
        Me.cerrar.Location = New System.Drawing.Point(1525, 0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(34, 35)
        Me.cerrar.TabIndex = 0
        Me.cerrar.UseVisualStyleBackColor = True
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
        Me.ButtonExportarAExcelColaboradores.Location = New System.Drawing.Point(445, 40)
        Me.ButtonExportarAExcelColaboradores.Name = "ButtonExportarAExcelColaboradores"
        Me.ButtonExportarAExcelColaboradores.Size = New System.Drawing.Size(135, 35)
        Me.ButtonExportarAExcelColaboradores.TabIndex = 90
        Me.ButtonExportarAExcelColaboradores.Text = "Exportar a Excel"
        Me.ButtonExportarAExcelColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarAExcelColaboradores.UseVisualStyleBackColor = False
        '
        'ListaDeAlistarPelidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 390)
        Me.Controls.Add(Me.ButtonExportarAExcelColaboradores)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DGVListaDeAlistarPedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaDeAlistarPelidos"
        Me.Text = "ListaDeAlistarPelidos"
        CType(Me.DGVListaDeAlistarPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVListaDeAlistarPedidos As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Restaurar As Button
    Friend WithEvents minimizar As Button
    Friend WithEvents Maximizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonExportarAExcelColaboradores As Button
    Friend WithEvents Ferreteria As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descipcion As DataGridViewTextBoxColumn
    Friend WithEvents Inventario As DataGridViewTextBoxColumn
    Friend WithEvents Posicion As DataGridViewTextBoxColumn
    Friend WithEvents Consecutivo As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
