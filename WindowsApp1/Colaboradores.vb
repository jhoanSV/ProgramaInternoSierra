Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class Colaboradores

    Dim strcon As String = System.Configuration.ConfigurationSettings.AppSettings(Form1.conexion) '"Data Source=DESKTOP-9B9H7OE;Initial Catalog=programaembd;Integrated Security=True")
    'LO QUE VA AL CARGAR EL FORM %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Colaboradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        DGVColaboradoresBuscar.DataSource = ObtenerlistaColaboradores()
        DGVColaboradoresBuscar.Columns(4).Visible = False
        DGVColaboradoresBuscar.Columns(6).Visible = False
        DGVColaboradoresBuscar.Columns(7).Visible = False
        DGVColaboradoresBuscar.Columns(8).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
    End Sub
    'BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub RadioButtonNuevo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNuevo.CheckedChanged
        TabControlColaboradores.SelectedIndex = 0  ' me manda al primer tabpage de la sección de Colaboradores
    End Sub

    Private Sub RadioButtonListaColaboradores_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonListaColaboradores.CheckedChanged
        TabControlColaboradores.SelectedIndex = 1  ' me manda al primer tabpage de la sección de Colaboradores
    End Sub

    Private Sub RadioButtonEliminarColaboradores_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEliminarColaboradores.CheckedChanged
        TabControlColaboradores.SelectedIndex = 2  ' me manda al Tercer tabpage de la sección de Colaboradores
    End Sub

    Private Sub TabControlColaboradores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlColaboradores.SelectedIndexChanged
        DGVListaColaboradores.DataSource = ObtenerlistaColaboradores() 'Llama a la funcion Obtener lista de colaboradores
    End Sub
    Private Sub arreglarDGVColaoradores()

        DGVColaboradoresBuscar.Columns(4).Visible = False
        DGVColaboradoresBuscar.Columns(6).Visible = False
        DGVColaboradoresBuscar.Columns(7).Visible = False
        DGVColaboradoresBuscar.Columns(8).Visible = False
    End Sub
    'FIN DE BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'TAPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonCancelarNProovedor_Click(sender As Object, e As EventArgs) Handles ButtonCancelarColaboradores.Click
        'BOTON DE CANCELAR COLABORADORES (BORRA TODOS LOS DATOS QUE SE ESTEN LLENANDO)
        TextBoxCodigoColaboradores.Text = ""
        TextBoxNombreColaboradores.Text = ""
        TextBoxApellidoColaboradores.Text = ""
        TextBoxCargoColaboradores.Text = ""
        TextBoxTelefonoColaboradores.Text = ""
        TextBoxCelColaboradores.Text = ""
        TextBoxEmailColaboradores.Text = ""
        TextBoxDireccionColaboradores.Text = ""
        TextBoxNotaColaboradores.Text = "" 'Deja en blanco las casillas correspondientes
    End Sub

    Private Sub ButonBuscarColaborador_Click(sender As Object, e As EventArgs) Handles ButonBuscarColaborador.Click
        'BOTON BUSCAR COLABORADORES (BUSCA EL COLABORADOR SEFUN EL CODIGO QUE PONGAN)
        If TextBoxCodigoColaboradores.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Try
                Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod ='" & TextBoxCodigoColaboradores.Text & "'")
                If result.Length > 0 Then
                    TextBoxNombreColaboradores.Text = CStr(result(0).Item(1))
                    TextBoxApellidoColaboradores.Text = CStr(result(0).Item(2))
                    TextBoxCargoColaboradores.Text = CStr(result(0).Item(3))
                    TextBoxTelefonoColaboradores.Text = CStr(result(0).Item(4))
                    TextBoxCelColaboradores.Text = CStr(result(0).Item(5))
                    TextBoxEmailColaboradores.Text = CStr(result(0).Item(6))
                    TextBoxDireccionColaboradores.Text = CStr(result(0).Item(7))
                    TextBoxNotaColaboradores.Text = CStr(result(0).Item(8)) 'Trim(dt.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Else
                    MsgBox("El colaborador no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCrearColaboradores.Click
        'BOTON CREAR COLABORADORES (INSERTA DENTRO DE LAS TABLAS LOS DATOS CORRESPONDIENTES
        If TextBoxCodigoColaboradores.Text = "" Or TextBoxNombreColaboradores.Text = "" Then
            MsgBox("Falta insertar codigo o nombre") 'esta parte verifica si hay campos vacios en codigo o ferreteria y manda un mensaje en caso que alguno este vacio
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod ='" & TextBoxCodigoColaboradores.Text & "'")
            If result.Length > 0 Then
                MsgBox("El colaborador ya existe, intente con otro codigo")
            Else
                Form1.Consultar("insert into colaboradores values ('" & TextBoxCodigoColaboradores.Text & "', '" & TextBoxNombreColaboradores.Text & "', '" & TextBoxApellidoColaboradores.Text & "','" & TextBoxCargoColaboradores.Text & "', '" & TextBoxTelefonoColaboradores.Text & "', '" & TextBoxCelColaboradores.Text & "','" & TextBoxEmailColaboradores.Text & "', '" & TextBoxDireccionColaboradores.Text & "', '" & TextBoxNotaColaboradores.Text & "')")

                MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                Limpiar()
            End If
        End If
    End Sub

    Private Sub ButtonModificarColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonModificarColaboradores.Click
        'BOTON DE MODIFICAR COLABORADORES (MODIFICA LOS DATOS DEL COLABORADOR SEGUN CODIGO)
        If TextBoxCodigoColaboradores.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod ='" & TextBoxCodigoColaboradores.Text & "'")
            If result.Length = 0 Then
                MsgBox("El colaborador no esta creado")
            Else
                Form1.Consultar("update colaboradores set Nombre = '" & TextBoxNombreColaboradores.Text & "', Apellido = '" & TextBoxApellidoColaboradores.Text & "',Cargo = '" & TextBoxCargoColaboradores.Text & "', Telefono = '" & TextBoxTelefonoColaboradores.Text & "', Cel = '" & TextBoxCelColaboradores.Text & "',Email = '" & TextBoxEmailColaboradores.Text & "',Direccion = '" & TextBoxDireccionColaboradores.Text & "', Nota = '" & TextBoxNotaColaboradores.Text & "' Where Cod = '" & TextBoxCodigoColaboradores.Text & "'")

                MsgBox("Los datos se actualizaron correctamente.") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                Limpiar()
            End If
        End If
    End Sub

    Private Function Limpiar()
        Form1.Actualizar_Colaboradores()
        Form1.ActualizarTablaVendedores()
        TextBoxCodigoColaboradores.Text = ""
        TextBoxNombreColaboradores.Text = ""
        TextBoxApellidoColaboradores.Text = ""
        TextBoxCargoColaboradores.Text = ""
        TextBoxTelefonoColaboradores.Text = ""
        TextBoxCelColaboradores.Text = ""
        TextBoxEmailColaboradores.Text = ""
        TextBoxDireccionColaboradores.Text = ""
        TextBoxNotaColaboradores.Text = "" 'Deja en blanco las casillas correspondientes
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        DGVColaboradoresBuscar.DataSource = ObtenerlistaColaboradores()
        DGVColaboradoresBuscar.Columns(4).Visible = False
        DGVColaboradoresBuscar.Columns(6).Visible = False
        DGVColaboradoresBuscar.Columns(7).Visible = False
        DGVColaboradoresBuscar.Columns(8).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        TBFiltrarPorFerreteria.Text = ""
        llenarComboBoxVendedor(Form1.Facturasdeventa.CBVendedor)
        llenarComboBoxVendedor(Form1.Cliente.CBVendedor)
        llenarComboBoxVendedor(Form1.estudio.CBProovedorVentas)
    End Function
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV y textbox %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 8
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaColaboradores.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 8
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(fila(i).Item(j))
            Next
        Next
        Return ds
    End Function
    Private Sub TBFiltrarPorCodigo_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorCodigo.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaColaboradores.Select("Cod like'" & "%" + TBFiltrarPorCodigo.Text + "%" & "'")
        Me.DGVColaboradoresBuscar.DataSource = Filtrar(FoundRows)
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        'DGVColaboradoresBuscar.DataSource = ObtenerlistaColaboradores()
        DGVColaboradoresBuscar.Columns(4).Visible = False
        DGVColaboradoresBuscar.Columns(6).Visible = False
        DGVColaboradoresBuscar.Columns(7).Visible = False
        'DGVColaboradoresBuscar.Columns(8).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
    End Sub

    Private Sub TBFiltrarPorFerreteria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorFerreteria.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaColaboradores.Select("Nombre like'" & "%" + TBFiltrarPorFerreteria.Text + "%" & "'")
        Me.DGVColaboradoresBuscar.DataSource = Filtrar(FoundRows)
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        'DGVColaboradoresBuscar.DataSource = ObtenerlistaColaboradores()
        DGVColaboradoresBuscar.Columns(4).Visible = False
        DGVColaboradoresBuscar.Columns(6).Visible = False
        DGVColaboradoresBuscar.Columns(7).Visible = False
        DGVColaboradoresBuscar.Columns(8).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
    End Sub

    Private Sub DGVColaboradoresBuscar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVColaboradoresBuscar.CellMouseDoubleClick
        Dim FilaActual As Integer
        FilaActual = DGVColaboradoresBuscar.CurrentRow.Index 'Captura la celda en donde se dio el doble Clik
        'TBCategoria.Text = DGVCategoriaBuscar.Rows(FilaActual).Cells(0).Value
        TextBoxCodigoColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(0).Value))
        TextBoxNombreColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(1).Value))
        TextBoxApellidoColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(2).Value))
        TextBoxCargoColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(3).Value))
        TextBoxTelefonoColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(4).Value))
        TextBoxCelColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(5).Value))
        TextBoxEmailColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(6).Value))
        TextBoxDireccionColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(7).Value))
        TextBoxNotaColaboradores.Text = Trim(Convert.ToString(DGVColaboradoresBuscar.Rows(FilaActual).Cells(8).Value))
    End Sub
    'FIN DE DGV y textbox %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

    'TABPAGE2 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    Private Sub ButtonExportarAExcelProovedores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        llenarExcel(DGVListaColaboradores)
    End Sub

    'FIN DE TABPAGE2 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TABPAGE3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonBuscarEliminarProovedores_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEliminarProovedores.Click
        'BOTON DE BUSCAR PARA ELIMINAR COLABORADORES
        If TextBoxCodigoEColaboradores.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod ='" & TextBoxCodigoEColaboradores.Text & "'")

            If result.Length > 0 Then
                TextBoxColaboradorEColaboradores.Text = CStr(result(0).Item(1))
                TextBoxCargoEColaboradores.Text = CStr(result(0).Item(3))
            Else
                MsgBox("El colaborador no existe")
            End If

        End If
    End Sub

    Private Sub ButtonCancelarEProovedores_Click(sender As Object, e As EventArgs) Handles ButtonCancelarEProovedores.Click
        'BOTON DE CANCELAR ELIMINAR COLABORADORES (BORRA LOS DATOS Y LA BUSQUEDA PARA ELIMINAR A LOS COLABORADORES)
        TextBoxCodigoEColaboradores.Text = ""
        TextBoxColaboradorEColaboradores.Text = ""
        TextBoxCargoEColaboradores.Text = ""
    End Sub

    Private Sub ButtonEliminarProovedores_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProovedores.Click
        'BOTON ELIMINAR COLABORADORES (ELIMINA DE LA BASE DE DATOS AL COLABORADOR SEGUN CODIGO)
        If TextBoxCodigoEColaboradores.Text = "" Then
            MsgBox("Inserte un codigo")
        Else
            Try
                Form1.Consultar("delete from colaboradores Where Cod = '" & TextBoxCodigoEColaboradores.Text & "'")
                MsgBox("Se elimino al colaborador correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                Limpiar()

                TextBoxCodigoEColaboradores.Text = ""
                TextBoxColaboradorEColaboradores.Text = ""
                TextBoxCargoEColaboradores.Text = ""
                llenarComboBoxVendedor(Form1.Facturasdeventa.CBVendedor)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaColaboradores() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Form1.Actualizar_Colaboradores()
        Return Form1.TablaColaboradores
    End Function

    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

End Class