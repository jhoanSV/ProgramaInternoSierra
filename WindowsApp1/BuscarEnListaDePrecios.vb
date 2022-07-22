Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Public Class BuscarEnListaDePrecios

    'PARA PODER MOVER LA VENTANA DEL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'FIND EL CODIGO PARA PODER MOVER LA VENTANA DEL FORMULARIO

    'AL CARGAR EL FORM %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub BuscarEnListaDePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVCategoriaBuscar.DataSource = ObtenerlistaCategoriaBuscar() 'Llama a la funcion Obtener lista de Categoria
        DGVSubCategoriaBuscar.DataSource = ObtenerlistaSubCategoriaBuscar() 'Llama a la funcion Obtener lista de Categoria
        DGVUbicacionBuscar.DataSource = ObtenerlistaUbicacionBuscar() 'Llama a la funcion Obtener lista de Categoria
    End Sub
    'BOTONES DE CERRAR Y MINIMIZAR %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    'FIN DE BOTONES DE CERRAR Y MINIMIZAR %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOTONES DEL TABPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub RBNuevoProducto_CheckedChanged(sender As Object, e As EventArgs) Handles RBNuevoProducto.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedIndex = 0
    End Sub

    Private Sub RBSubCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles RBSubCategoria.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedIndex = 1
    End Sub

    Private Sub RBUbicacion_CheckedChanged(sender As Object, e As EventArgs) Handles RBUbicacion.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedIndex = 2
    End Sub
    'FIN DE BOTONES DEL TABPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'TABPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonNuevaCategoria_Click(sender As Object, e As EventArgs) Handles ButtonNuevaCategoria.Click
        'BOTON PARA AGREGAR NUEVA CATEGORIA
        If TBCategoria.Text = "" Then
            MsgBox("Inserte una categoria") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaDeCategorias.Select("Categoria ='" & TBCategoria.Text & "'")
            If result.Length > 0 Then
                MsgBox("La categoria ya existe")
            Else
                Form1.Consultar("insert into categoria values ('" & TBCategoria.Text & "')")
                MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                'Refrescar el DGVB
                Form1.Actualizar_Categoria()
                'llena el CBCategorias
                DGVCategoriaBuscar.DataSource = ObtenerlistaCategoriaBuscar() 'Llama a la funcion Obtener lista de Categoria
                'llenar el CBCategorias

                Form1.LisDePrecios.CBCategoria.Items.Clear()
                llenarComboBoxCategoria(Form1.LisDePrecios.CBCategoria)
                'fin de llena el CBSubCategorias
                TBCategoria.Text = "" 'deja en blanco la casilla de Categoria
            End If

        End If
    End Sub
    Public Sub CancelarCategoria_Click(sender As Object, e As EventArgs) Handles CancelarCategoria.Click
        'ELIMINA EL TB PARA CANCELAR LA ACCION CON LA CARTEGORIA
        TBCategoria.Text = ""
    End Sub
    Private Sub ButtonEliminarCategoria_Click(sender As Object, e As EventArgs) Handles ButtonEliminarCategoria.Click
        'ELIMINA LA CATEGORIA QUE SE HA SELECCIONADO
        If TBCategoria.Text = "" Then
            MsgBox("Inserte una categoria")
        Else
            Form1.Consultar("delete from categoria Where Categoria = '" & TBCategoria.Text & "'")
            MsgBox("Se elimino la categoria correctamente")
            Form1.Actualizar_Categoria()
            'REFESCAR EL DGV
            DGVCategoriaBuscar.DataSource = ObtenerlistaCategoriaBuscar()
            'fin de REFESCAR EL DGV
            'llena el CBCategorias
            Form1.LisDePrecios.CBCategoria.Items.Clear()
            llenarComboBoxCategoria(Form1.LisDePrecios.CBCategoria)
            'fin de llena el CBCategorias
            TBCategoria.Text = ""
            Form1.TablaDeCategorias = Form1.Tablas("select Categoria from categoria")
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TBFiltrarCategoria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarCategoria.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeCategorias.Select("Categoria like'" & "%" + TBFiltrarCategoria.Text + "%" & "'")
        Me.DGVCategoriaBuscar.DataSource = Filtrar(FoundRows)
    End Sub
    Private Sub DGVCategoriaBuscar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCategoriaBuscar.CellDoubleClick
        'CON UN DOBLE CLICK PONE LA CATEGORIA EN EL TB
        Dim FilaActual As Integer
        FilaActual = DGVCategoriaBuscar.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        TBCategoria.Text = DGVCategoriaBuscar.Rows(FilaActual).Cells(0).Value
    End Sub
    'FIN DE DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaCategoriaBuscar() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        'OPTIENE LA LISTA DE CATEGORIAS
        Dim dtCategoria As New DataTable
        dtCategoria = Form1.TablaDeCategorias
        Return dtCategoria
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TABPAGE 2 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonNuevaSubCategoria.Click
        'CREA UNA NUEVA SUB CATEGORIA
        If TBSubCategoria.Text = "" Then
            MsgBox("Inserte una Sub-Categoria") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaDeSubCategoria.Select("SubCategoria ='" & TBSubCategoria.Text & "'")
            If result.Length > 0 Then
                MsgBox("La categoria ya existe")
            Else
                Form1.Consultar("insert into subcategorias values ('" & TBSubCategoria.Text & "')")
                    MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                'refrescar el DGV
                Form1.Actualizar_SubCategoria()
                DGVSubCategoriaBuscar.DataSource = ObtenerlistaSubCategoriaBuscar()


                'fin de refrescar el DGV
                'llena el CBSubCategorias
                Form1.LisDePrecios.CBSubCategoria.Items.Clear()
                    LlenarComboBoxSubCategoria(Form1.LisDePrecios.CBSubCategoria)
                    'fin de llena el CBSubCategorias
                    TBSubCategoria.Text = ""  'deja en blanco la casilla de Categoria
                End If
                Conexiondb.conexion.Close()
            End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelarSubCategoria.Click
        'ELIMINA EL TB PARA CANCELAR LA ACCION CON LA SUBCARTEGORIA
        TBSubCategoria.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEliminarSubCategoria.Click
        'ELIMINA LA SUBCATEGORIA QUE SE HA SELECCIONADO
        If TBSubCategoria.Text = "" Then
            MsgBox("Inserte una sub-categoria")
        Else
            Form1.Consultar("delete from subcategorias Where  SubCategoria= '" & TBSubCategoria.Text & "'")
            MsgBox("Se elimino la sub-categoria correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
            'refrescar el DGV
            Form1.Actualizar_SubCategoria()
            DGVSubCategoriaBuscar.DataSource = ObtenerlistaSubCategoriaBuscar()
            'fin de refrescar el DGV
            TBSubCategoria.Text = ""
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TBFiltrarSubCategoria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarSubCategoria.TextChanged
        'FILTRA LA SUBCATEGOIA AUTOMATICAMENTE
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeSubCategoria.Select("SubCategoria like'" & "%" + TBFiltrarCategoria.Text + "%" & "'")
        Me.DGVSubCategoriaBuscar.DataSource = Filtrar(FoundRows) 'dt
    End Sub
    Private Sub DGVSubCategoriaBuscar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSubCategoriaBuscar.CellContentDoubleClick
        'CON UN DOBLE CLICK PONE LA SUBCATEGORIA EN EL TB
        Dim FilaActual As Integer
        FilaActual = DGVSubCategoriaBuscar.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        TBCategoria.Text = DGVSubCategoriaBuscar.Rows(FilaActual).Cells(0).Value
    End Sub
    'FIN DE DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaSubCategoriaBuscar() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Return Form1.TablaDeSubCategoria 'dtSubCategoria
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE 2 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TABPAGE 3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonNuevaUbicacion_Click(sender As Object, e As EventArgs) Handles ButtonNuevaUbicacion.Click
        'CREA UNA NUEVA UBICACION
        If TBUbicacion.Text = "" Then
            MsgBox("Inserte una ubicación") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaDeUbicaciones.Select("Ubicacion ='" & TBSubCategoria.Text & "'")
            If result.Length > 0 Then 'dt.Rows.Count > 0 Then
                MsgBox("La categoria ya existe")
            Else
                Form1.Consultar("insert into ubicaciones values ('" & TBUbicacion.Text & "')")
                MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                'REFESCAR EL DGV
                Form1.Actualizar_ubicacion()
                DGVUbicacionBuscar.DataSource = ObtenerlistaUbicacionBuscar()
                'fin de REFESCAR EL DGV
                'llena el CBCategorias
                Form1.LisDePrecios.CBUbicacion.Items.Clear()
                llenarComboBoxUbicacion(Form1.LisDePrecios.CBUbicacion)
                'fin de llena el CBCategorias
                TBUbicacion.Text = ""      'deja en blanco la casilla de Ubicación
            End If
            Conexiondb.conexion.Close()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles CancelarUbicacion.Click
        'ELIMINA EL TB PARA CANCELAR LA ACCION CON LA UBICACION
        TBUbicacion.Text = ""
    End Sub

    Private Sub ButtonEliminarUbicacion_Click(sender As Object, e As EventArgs) Handles ButtonEliminarUbicacion.Click
        'ELIMINA LA UBICACION QUE SE HA SELECCIONADO
        If TBUbicacion.Text = "" Then
            MsgBox("Inserte una Ubicación")
        Else
            Form1.Consultar("delete from ubicaciones Where  Ubicacion= '" & TBUbicacion.Text & "'")
            MsgBox("Se elimino la ubicación correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
            'REFESCAR EL DGV
            Form1.Actualizar_ubicacion()
            DGVUbicacionBuscar.DataSource = ObtenerlistaUbicacionBuscar()
            'fin de REFESCAR EL DGV
            'llena el CBCategorias
            Form1.LisDePrecios.CBUbicacion.Items.Clear()
            llenarComboBoxUbicacion(Form1.LisDePrecios.CBUbicacion)
            'fin de llena el CBCategorias
            TBUbicacion.Text = ""
            Conexiondb.conexion.Close()
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TBFiltrarUbicacion_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarUbicacion.TextChanged
        'FILTRA LA UBICACION AUTOMATICAMENTE
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeUbicaciones.Select("Ubicacion like'" & "%" + TBFiltrarUbicacion.Text + "%" & "'")
        Me.DGVUbicacionBuscar.DataSource = Filtrar(FoundRows) 'dt
    End Sub
    Private Sub DGVUbicacionBuscar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUbicacionBuscar.CellContentDoubleClick
        'CON UN DOBLE CLICK PONE LA UBICACION EN EL TB
        Dim FilaActual As Integer
        FilaActual = DGVUbicacionBuscar.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        TBCategoria.Text = DGVUbicacionBuscar.Rows(FilaActual).Cells(0).Value
    End Sub
    'FIN DE DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaUbicacionBuscar() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Return Form1.TablaDeUbicaciones 'dtUbicacion
    End Function

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedIndex = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedTab = TCBuscarEnListaDePrecios.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TCBuscarEnListaDePrecios.SelectedTab = TCBuscarEnListaDePrecios.TabPages.Item(2)
    End Sub
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        ds.Columns.Add()
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            ds.Rows(ds.Rows.Count - 1).Item(0) = CStr(fila(i).Item(0))
        Next
        Return ds
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE 3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
End Class