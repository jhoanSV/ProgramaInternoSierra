Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Proovedores
    'LO QUE VA AL CARGAR EL FORM %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Proovedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        DGVProveedoresBuscar.DataSource = ObtenerlistaProovedores()
        DGVProveedoresBuscar.Columns(1).Visible = False
        DGVProveedoresBuscar.Columns(4).Visible = False
        DGVProveedoresBuscar.Columns(6).Visible = False
        DGVProveedoresBuscar.Columns(7).Visible = False
        DGVProveedoresBuscar.Columns(8).Visible = False
        DGVProveedoresBuscar.Columns(9).Visible = False
        DGVProveedoresBuscar.Columns(10).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
    End Sub
    'BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButtonNuevo.CheckedChanged
        TabControlProovedores.SelectedIndex = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControlProovedores.SelectedTab = TabControlProovedores.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControlProovedores.SelectedTab = TabControlProovedores.TabPages.Item(2)
    End Sub
    'FIN DE BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'TAPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonGuardarNProovedor_Click(sender As Object, e As EventArgs) Handles ButtonGuardarNProovedor.Click
        'BOTON DE GUARDAR NUEVO PROVEEDOR
        If TextBoxCodigoNProovedores.Text = "" Or TextBoxProovedorNProovedores.Text = "" Then
            MsgBox("Inserte un codigo") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Cod ='" & TextBoxCodigoNProovedores.Text & "'")
            If result.Length > 0 Then
                MsgBox("El proovedor ya existe, intente con otro codigo")
            Else
                Form1.Consultar("insert into proovedores values ('" & TextBoxCodigoNProovedores.Text & "', '" & TextBoxNitNProovedores.Text & "', '" & TextBoxProovedorNProovedores.Text & "','" & TextBoxContactoNProovedores.Text & "', '" & TextBoxTelefonoNProovedores.Text & "', '" & TextBoxCelNProovedores.Text & "','" & TextBoxEmailNProovedores.Text & "', '" & TextBoxWebNProovedores.Text & "', '" & TextBoxDireccionNProovedores.Text & "','" & TextBoxRutaNProovedores.Text & "', '" & TextBoxNotaNproovedor.Text & "')")
                MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                'Limpia todos los items
                Limpiaritems()
            End If

        End If
    End Sub

    Private Function Limpiaritems()
        Form1.Actualizar_Proveedores()
        TextBoxCodigoNProovedores.Text = ""
        TextBoxNitNProovedores.Text = ""
        TextBoxProovedorNProovedores.Text = ""
        TextBoxContactoNProovedores.Text = ""
        TextBoxTelefonoNProovedores.Text = ""
        TextBoxCelNProovedores.Text = ""
        TextBoxEmailNProovedores.Text = ""
        TextBoxWebNProovedores.Text = ""
        TextBoxDireccionNProovedores.Text = ""
        TextBoxRutaNProovedores.Text = ""
        TextBoxNotaNproovedor.Text = ""
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        DGVProveedoresBuscar.DataSource = ObtenerlistaProovedores()
        DGVProveedoresBuscar.Columns(1).Visible = False
        DGVProveedoresBuscar.Columns(4).Visible = False
        DGVProveedoresBuscar.Columns(6).Visible = False
        DGVProveedoresBuscar.Columns(7).Visible = False
        DGVProveedoresBuscar.Columns(8).Visible = False
        DGVProveedoresBuscar.Columns(9).Visible = False
        DGVProveedoresBuscar.Columns(10).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        TBFiltrarPorCodigo.Text = ""
        TBFiltrarPorFerreteria.Text = ""
        llenarComboBoxProovedores(Form1.FacCompras.CBProovedorVentas)
        llenarComboBoxVendedor(Form1.FacCompras.CBNombreColaboradorVentas)

    End Function
    Private Sub ButtonCancelarNProovedor_Click(sender As Object, e As EventArgs) Handles ButtonCancelarNProovedor.Click
        Limpiaritems()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        'BOTON DE MODIFICAR PROVEEDOR
        If TextBoxCodigoNProovedores.Text = "" Then
            MsgBox("Inserte un codigo")
        Else
            Try
                Form1.Consultar("update proovedores set Nit = '" & TextBoxNitNProovedores.Text & "', Proovedor = '" & TextBoxProovedorNProovedores.Text & "',Contacto = '" & TextBoxContactoNProovedores.Text & "', Telefono = '" & TextBoxTelefonoNProovedores.Text & "', Cel = '" & TextBoxCelNProovedores.Text & "',Email = '" & TextBoxEmailNProovedores.Text & "', Web = '" & TextBoxWebNProovedores.Text & "', Direccion = '" & TextBoxDireccionNProovedores.Text & "', Ruta = '" & TextBoxRutaNProovedores.Text & "', Nota = '" & TextBoxNotaNproovedor.Text & "' Where Cod = '" & TextBoxCodigoNProovedores.Text & "'")
                MsgBox("Los datos se actualizaron correctamente.")
                Limpiaritems()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TBFiltrarPorCodigo_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorCodigo.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaProveedores.Select("Cod like'" & "%" + TBFiltrarPorCodigo.Text + "%" & "'")
        Me.DGVProveedoresBuscar.DataSource = Filtrar(FoundRows)
    End Sub

    Private Sub TBFiltrarPorFerreteria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorFerreteria.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaProveedores.Select("Proovedor like'" & "%" + TBFiltrarPorFerreteria.Text + "%" & "'")
        Dim dt As New DataTable
        Me.DGVProveedoresBuscar.DataSource = Filtrar(FoundRows)
    End Sub

    Private Sub DGVProveedoresBuscar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedoresBuscar.CellDoubleClick
        Dim FilaActual As Integer
        FilaActual = DGVProveedoresBuscar.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        'TBCategoria.Text = DGVCategoriaBuscar.Rows(FilaActual).Cells(0).Value
        TextBoxCodigoNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(0).Value))
        TextBoxNitNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(1).Value))
        TextBoxProovedorNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(2).Value))
        TextBoxContactoNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(3).Value))
        TextBoxTelefonoNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(4).Value))
        TextBoxCelNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(5).Value))
        TextBoxEmailNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(6).Value))
        TextBoxWebNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(7).Value))
        TextBoxDireccionNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(8).Value))
        TextBoxRutaNProovedores.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(9).Value))
        TextBoxNotaNproovedor.Text = Trim(Convert.ToString(DGVProveedoresBuscar.Rows(FilaActual).Cells(10).Value))
    End Sub
    'FIN DE DGV Y TEXTBOX %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TAPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TAPAGE 3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonBuscarEliminarProovedores_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEliminarProovedores.Click
        'BOTON BUSCAR PROVEEDOR PARA ELIMINAR
        If TextBoxCodigoEProovedores.Text = "" Then
            MsgBox("Inserte un codigo")
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Cod ='" & TextBoxCodigoEProovedores.Text & "'")
            If result.Length > 0 Then
                TextBoxNitEProovedores.Text = CStr(result(0).Item(1)) 'Trim(dt.Rows(0).Item(0).ToString)
                TextBoxProovedorEProovedores.Text = CStr(result(0).Item(2)) 'Trim(dt.Rows(0).Item(1).ToString)
            Else
                    MsgBox("El proovedor no existe")
                End If

            End If
    End Sub

    Private Sub ButtonCancelarEProovedores_Click(sender As Object, e As EventArgs) Handles ButtonCancelarEProovedores.Click
        'BOTON CANCELAR PROVEEDOR PARA ELIMINAR (BORRA LOS DATOS DE LOS TEXTBOX DEL PROVEEDOR QUE SE BUSCA ELIMINAR)
        TextBoxCodigoEProovedores.Text = ""
        TextBoxNitEProovedores.Text = ""
        TextBoxProovedorEProovedores.Text = ""
    End Sub

    Private Sub ButtonEliminarProovedores_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProovedores.Click
        'BOTON DE ELIMINAR PROVEEDRO (ELIMINA EL PROVEEDOR DE LA BASE DE DATOS)
        If TextBoxCodigoEProovedores.Text = "" Then
            MsgBox("Inserte un codigo")
        Else

            Try
                Form1.Consultar("delete from proovedores Where Cod = '" & TextBoxCodigoEProovedores.Text & "'")
                MsgBox("Se elimino al proovedor correctamente")

                TextBoxCodigoEProovedores.Text = ""
                TextBoxNitEProovedores.Text = ""
                TextBoxProovedorEProovedores.Text = ""
                Limpiaritems()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    'FIN DE TAPAGE 3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TAPAGE 4 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelProovedores.Click
        'PASA DEL DGV A UN EXCEL
        llenarExcel(DGVListaProovedores)
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaProovedores() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Return Form1.TablaProveedores
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        DGVListaProovedores.DataSource = ObtenerlistaProovedores() 'Llama a la funcion Obtener lista de proveedores
    End Sub
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 10
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaProveedores.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 10
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(fila(i).Item(j))
            Next
        Next
        Return ds
    End Function
    'FIN DE TAPAGE 4 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
End Class