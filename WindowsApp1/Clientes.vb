Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class Clientes
    'LO QUE VA AL CARGAR EL FORM %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarComboBoxVendedor(CBVendedor)
        DGVClientesBUscar.DataSource = ObtenerlistaClientes() 'Llama a la funcion Obtener lista de clientes
        DGVClientesBUscar.Columns(1).Visible = False
        DGVClientesBUscar.Columns(6).Visible = False
        DGVClientesBUscar.Columns(7).Visible = False
        DGVClientesBUscar.Columns(8).Visible = False
        DGVClientesBUscar.Columns(9).Visible = False
        DGVClientesBUscar.Columns(10).Visible = False
        DGVClientesBUscar.Columns(11).Visible = False
        DGVClientesBUscar.Columns(12).Visible = False
    End Sub
    'BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControlClientes.SelectedTab = TabControlClientes.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControlClientes.SelectedTab = TabControlClientes.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControlClientes.SelectedTab = TabControlClientes.TabPages.Item(2)
    End Sub
    'FIN DE BOTONES DEL TAPAGE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'TAPAGE 1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Agrega los datos del nuevo cliente en la tabla Clientes

        If TextBoxCodigoNCliente.Text = "" Or TextBoxFerreteriaNCliente.Text = "" Then
            MsgBox("Falta insertar codigo o Ferreteria") 'esta parte verifica si hay campos vacios en codigo o ferreteria y manda un mensaje en caso que alguno este vacio
        Else
            Dim result As DataRow() = Form1.TablaClientes.Select("Cod ='" & TextBoxCodigoNCliente.Text & "'")
            If result.Length > 0 Then
                MsgBox("El cliente ya existe, intente con otro codigo")
            Else
                Form1.Consultar("insert into clientes values ('" & TextBoxCodigoNCliente.Text & "', '" & TextBoxNitNCliente.Text & "', '" & TextBoxFerreteriaNCliente.Text & "','" & TextBoxContactoNCliente.Text & "', '" & TextBoxTelefonoNCliente.Text & "', '" & TextBoxCelNCliente.Text & "','" & TextBoxEmailNCliente.Text & "', '" & TextBoxDireccionNCliente.Text & "', '" & TextBoxBarrioNCliente.Text & "','" & TextBoxRutaNCliente.Text & "','" & CBVendedor.Text & "', '" & TBCodVendedor.Text & "', '" & TBNotaClientes.Text & "')")
                MsgBox("Se registro correctamente") ' se encarga de insertar los datos a la tabla Clientes de la base de datos
                'Limpia todos los items
                Limpiaritems()
            End If

        End If
    End Sub

    Private Sub Limpiaritems()
        Form1.Actualizar_Cliente()
        DGVClientesBUscar.DataSource = ObtenerlistaClientes() 'Llama a la funcion Obtener lista de clientes
        TextBoxCodigoNCliente.Text = ""  'deja el campo vacio del codigo y en lo demas es lo mismo
        TextBoxNitNCliente.Text = ""
        TextBoxFerreteriaNCliente.Text = ""
        TextBoxContactoNCliente.Text = ""
        TextBoxTelefonoNCliente.Text = ""
        TextBoxCelNCliente.Text = ""
        TextBoxEmailNCliente.Text = ""
        TextBoxDireccionNCliente.Text = ""
        TextBoxBarrioNCliente.Text = ""
        TextBoxRutaNCliente.Text = ""
        CBVendedor.Text = ""
        TBCodVendedor.Text = ""
        TBNotaClientes.Text = ""
        llenarComboBoxClientes(Form1.Facturasdeventa.CBVentasClientes)
        DGVClientesBUscar.DataSource = ObtenerlistaClientes() 'Llama a la funcion Obtener lista de clientes
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BOTON CANCELAR NUEVO CLIENTE
        Limpiaritems()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles ButtonModificarCliente.Click
        If TextBoxCodigoNCliente.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Form1.Consultar("update clientes set Nit = '" & TextBoxNitNCliente.Text & "', Ferreteria = '" & TextBoxFerreteriaNCliente.Text & "',Contacto = '" & TextBoxContactoNCliente.Text & "', Telefono = '" & TextBoxTelefonoNCliente.Text & "', Cel = '" & TextBoxCelNCliente.Text & "',Email = '" & TextBoxEmailNCliente.Text & "',Direccion = '" & TextBoxDireccionNCliente.Text & "', Barrio = '" & TextBoxBarrioNCliente.Text & "', Ruta = '" & TextBoxRutaNCliente.Text & "', Vendedor='" & CBVendedor.Text & "', CodVendedor='" & TBCodVendedor.Text & "', Nota = '" & TBNotaClientes.Text & "' Where Cod = '" & TextBoxCodigoNCliente.Text & "'")
            MsgBox("Los datos se actualizaron correctamente.") 'modifica los datos que se encuentren asociados al valor de la casilla codigo.
            Limpiaritems()
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'DGV y textbox %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 12
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaClientes.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 12
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(fila(i).Item(j))
            Next
        Next
        Return ds
    End Function
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorCodigo.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaClientes.Select("Cod like'" & "%" + TBFiltrarPorCodigo.Text + "%" & "'")
        Me.DGVClientesBUscar.DataSource = Filtrar(FoundRows)
    End Sub

    Private Sub TBFiltrarPorFerreteria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorFerreteria.TextChanged
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaClientes.Select("Ferreteria like'" & "%" + TBFiltrarPorFerreteria.Text + "%" & "'")
        Me.DGVClientesBUscar.DataSource = Filtrar(FoundRows)
    End Sub

    Private Sub DGVClientesBUscar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientesBUscar.CellDoubleClick
        Dim FilaActual As Integer
        FilaActual = DGVClientesBUscar.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        TextBoxCodigoNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(0).Value))
        TextBoxNitNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(1).Value))
        TextBoxFerreteriaNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(2).Value))
        TextBoxContactoNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(3).Value))
        TextBoxTelefonoNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(4).Value))
        TextBoxCelNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(5).Value))
        TextBoxEmailNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(6).Value))
        TextBoxDireccionNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(7).Value))
        TextBoxBarrioNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(8).Value))
        TextBoxRutaNCliente.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(9).Value))
        CBVendedor.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(10).Value))
        TBCodVendedor.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(11).Value))
        TBNotaClientes.Text = Trim(Convert.ToString(DGVClientesBUscar.Rows(FilaActual).Cells(12).Value))
    End Sub

    Private Sub CBVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBVendedor.SelectedIndexChanged
        'Este codigo llena el texbox del codigo del cliene con el codigo correspondiente al que seleccionaron en el combobox
        If CBVendedor.Text = "" Then
            MsgBox("Inserte un vendedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Nombre ='" & CBVendedor.Text & "'")
            If result.Length > 0 Then
                TBCodVendedor.Text = CStr(result(0).Item(0))
            Else
                MsgBox("El colaborador no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub

    Private Sub TBCodVendedor_Leave(sender As Object, e As EventArgs) Handles TBCodVendedor.Leave
        If TBCodVendedor.Text = "" Then
            MsgBox("Inserte un colaborador") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod ='" & TBCodVendedor.Text & "'")
            If result.Length > 0 Then
                CBVendedor.Text = CStr(result(0).Item(1))
            Else
                MsgBox("El colaborador no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            End If
    End Sub
    'FIN DE DGV y textbox %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE1 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

    'TABPAGE3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonBuscarEliminarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEliminarCliente.Click
        'BOTON BUSCAR ELIMINAR CLIENTE (BUSCA EL CLIENTE A ELIMINAR SEGUN CODIGO)
        If TextBoxCodigoECliente.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaClientes.Select("Cod ='" & TextBoxCodigoECliente.Text & "'")
            If result.Length > 0 Then
                TextBoxNitECliente.Text = CStr(result(0).Item(1))
                TextBoxFerreteriaECliente.Text = CStr(result(0).Item(2)) 'llena las casillas con los datos asociados al codigo dado
            Else
                MsgBox("El cliente no existe")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCancelarECliente.Click
        'BOTON CANCELAR ELIMINAR CLIENTE (PONE EN BLANCO LOS TEXTBOX)
        TextBoxCodigoECliente.Text = ""
        TextBoxNitECliente.Text = ""
        TextBoxFerreteriaECliente.Text = ""
    End Sub

    Private Sub ButtonEliminarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEliminarCliente.Click
        'BOTON ELIMINAR CLIENE (ELIMINA AL CLIENTE EN LA BASE DE DATOS SEGUN CODIGO)
        If TextBoxCodigoECliente.Text = "" Then
            MsgBox("Inserte un codigo") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Try
                Form1.Consultar("delete from clientes Where Cod = '" & TextBoxCodigoECliente.Text & "'")
                Form1.Actualizar_Cliente()
                TextBoxCodigoECliente.Text = ""
                TextBoxNitECliente.Text = ""
                TextBoxFerreteriaECliente.Text = ""
                llenarComboBoxClientes(Form1.Facturasdeventa.CBVentasClientes)
                DGVClientesBUscar.DataSource = ObtenerlistaClientes() 'Llama a la funcion Obtener lista de clientes
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TABPAGE 3 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'TABPAGE 4 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        MosTablaClientes.DataSource = ObtenerlistaClientes() 'Llama a la funcion Obtener lista de clientes
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles ButtonExportarAExcelClientes.Click
        'DE DGV A EXCEL
        llenarExcel(MosTablaClientes)
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerlistaClientes() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Form1.Actualizar_Cliente()
        Return Form1.TablaClientes
    End Function

    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

End Class