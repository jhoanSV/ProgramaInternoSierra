Imports System.Data.Odbc
Imports System.Data.SqlClient
Module LlenarConProductos
    Sub llenarComboBoxCategoria(ByVal cb As ComboBox)
        'para llenar los combobox de categorias
        For i As Double = 0 To Form1.TablaDeCategorias.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeCategorias.Rows(i).Item(0))
        Next
    End Sub
    Public Sub LlenarComboBoxProovedores(ByVal cb As ComboBox)
        'para llenar los combobox de Proveedores
        For i As Double = 0 To Form1.TablaDeProveedores.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeProveedores.Rows(i).Item(0))
        Next
    End Sub
    Sub llenarComboBoxClientes(ByVal cb As ComboBox)
        'para llenar los combobox de Proveedores
        For i As Double = 0 To Form1.TablaDeClientes.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeClientes.Rows(i).Item(0))
        Next
    End Sub
    Public Sub LlenarComboBoxSubCategoria(ByVal cb As ComboBox)
        'para llenar los combobox de Subcategorias
        For i As Double = 0 To Form1.TablaDeSubCategoria.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeSubCategoria.Rows(i).Item(0))
        Next
    End Sub
    Public Sub LlenarComboBoxUbicacion(ByVal cb As ComboBox)
        'para llenar los combobox de Ubicaciones
        For i As Double = 0 To Form1.TablaDeUbicaciones.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeUbicaciones.Rows(i).Item(0))
        Next
    End Sub
    Sub llenarComboBoxVendedor(ByVal cb As ComboBox)
        'para llenar los combobox de Ubicaciones
        cb.Items.Clear()
        For i As Double = 0 To Form1.TablaDeVendedores.Rows.Count - 1
            cb.Items.Add(Form1.TablaDeVendedores.Rows(i).Item(0))
        Next
    End Sub
    Public Sub cargar_DataCombo(ByVal dv As DataGridView)
        'Indico la columna combo
        Dim column As DataGridViewComboBoxColumn = DirectCast(dv.Columns(2), DataGridViewComboBoxColumn)
        'Configuro la columna.
        With column
            'Origen de datos
            .DataSource = Form1.TablaDeProductos
            'Nombre del campo cuyos datos se mostraran en la columna
            .DisplayMember = "Descripcion"
            'Nombre del campo cuyo valor se devolverá cuando se seleccione un elemento.
            .ValueMember = "Descripcion"
        End With

    End Sub

    Public Sub cargar_CocProducto(ByVal dv As DataGridView)
        'Indico la columna combo
        Dim column As DataGridViewComboBoxColumn = DirectCast(dv.Columns(2), DataGridViewComboBoxColumn)

        'Configuro la columna.
        With column
            'Origen de datos
            .DataSource = Form1.TablaDeProductos
            'Nombre del campo cuyos datos se mostraran en la columna
            .DisplayMember = "Descripcion"
            'Nombre del campo cuyo valor se devolverá cuando se seleccione un elemento.
            .ValueMember = "Descripcion"
        End With

    End Sub

    Public Sub cargar_CocProveedor(ByVal dv As DataGridView)
        'Indico la columna combo
        Dim column As DataGridViewComboBoxColumn = DirectCast(dv.Columns(1), DataGridViewComboBoxColumn)

        'Configuro la columna.
        With column
            'Origen de datos
            .DataSource = Form1.TablaDeProveedores
            'Nombre del campo cuyos datos se mostraran en la columna
            .DisplayMember = "Proovedor"
            'Nombre del campo cuyo valor se devolverá cuando se seleccione un elemento.
            .ValueMember = "Proovedor"
        End With

    End Sub

    Public Sub ObtenerProductosBuscar(ByVal dv As DataGridView)
        'Esta función se encarga de llenar el DGV con los productos
        Dim dtUbicacion As New DataTable
        dtUbicacion = Form1.Tablas("select*from Productos")
    End Sub

End Module
