Imports System.Data.Odbc
Imports System.Data.SqlClient 'NECESARIO PARA PODE USAR LOS COMANDOS SQL
Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Public Class BusquedaProLDePrecios

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
    Private Sub BusquedaProLDePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTE CODIGO ES PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        DGVBuscarLDePrecios.DataSource = ObtenerProductosBuscar() 'ESTO LLENA EL DGV CON LOS PRODUCTOS
        DGVBuscarLDePrecios.Columns(2).Visible = False
        DGVBuscarLDePrecios.Columns(3).Visible = False
        DGVBuscarLDePrecios.Columns(4).Visible = False
        DGVBuscarLDePrecios.Columns(6).Visible = False
        DGVBuscarLDePrecios.Columns(7).Visible = False
        DGVBuscarLDePrecios.Columns(8).Visible = False
        DGVBuscarLDePrecios.Columns(9).Visible = False
        DGVBuscarLDePrecios.Columns(10).Visible = False
        DGVBuscarLDePrecios.Columns(11).Visible = False
        DGVBuscarLDePrecios.Columns(12).Visible = False
        DGVBuscarLDePrecios.Columns(13).Visible = False
        DGVBuscarLDePrecios.Columns(14).Visible = False
        DGVBuscarLDePrecios.Columns(15).Visible = False
        DGVBuscarLDePrecios.Columns(16).Visible = False
        DGVBuscarLDePrecios.Columns(17).Visible = False
        DGVBuscarLDePrecios.Columns(18).Visible = False
        'fIN DEL CODIGO PARA LLENAR EL DGV Y NO MOSTRAR LAS COLUMNAS QUE NO SE REQUIEREN
        TBFiltrarPorCodigo.Text = ""
        TBFiltrarPorDescripcion.Text = ""
        TBFiltrarPorSubCategoria.Text = ""
    End Sub

    Private Sub TBFiltrarPorCodigo_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorCodigo.TextChanged
        Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod like'" & "%" + TBFiltrarPorCodigo.Text + "%" & "'")
        Me.DGVBuscarLDePrecios.DataSource = Filtrar(result)
        Ocultar()
    End Sub

    Private Sub TBFiltrarPorDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorDescripcion.TextChanged
        Dim result As DataRow() = Form1.TablaDeProductos.Select("Descripcion like'" & "%" + TBFiltrarPorDescripcion.Text + "%" & "'")
        Me.DGVBuscarLDePrecios.DataSource = Filtrar(result)
        Ocultar()
    End Sub

    Private Sub TBFiltrarPorSubCategoria_TextChanged(sender As Object, e As EventArgs) Handles TBFiltrarPorSubCategoria.TextChanged
        'este codigo es para filtrar la lista segun la descripción que ingresen
        Dim result As DataRow() = Form1.TablaDeProductos.Select("SubCategoria like'" & "%" + TBFiltrarPorSubCategoria.Text + "%" & "'")
        Me.DGVBuscarLDePrecios.DataSource = Filtrar(result)
        Ocultar()
    End Sub
    'funciones%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Public Function ObtenerProductosBuscar() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Return Form1.TablaDeProductos
    End Function
    'FIN DE LAS FUNCIONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'Todo lo del DGV%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub DGVBuscarLDePrecios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBuscarLDePrecios.CellDoubleClick
        Dim FilaActual As DataGridViewRow 'As Integer
        'FilaActual = DGVBuscarLDePrecios.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
        FilaActual = DGVBuscarLDePrecios.CurrentRow
        Form1.LisDePrecios.ConsultarProductos(FilaActual)
        Try
            Form1.LisDePrecios.DGVOtrosProovedores.Rows.Clear()

            Dim COD As String = Convert.ToString(DGVBuscarLDePrecios.CurrentRow.Cells(0).Value)
            Dim FoundRows() As DataRow
            FoundRows = Form1.TablaDeProductos.Select("Cod ='" & COD & "'")
            Dim dt As New DataTable
            Dim ds() As DataRow
            'Dim dt As New DataTable

            ds = Form1.Tabla_otros_proveedores.Select("Cod ='" & COD & "'")
            dt = FiltrarOtrosProveedores(ds)

            If dt.Rows.Count > 0 Then
                Dim index As Integer = Form1.LisDePrecios.DGVOtrosProovedores.Rows.Add(dt.Rows.Count)
                Dim i As Integer
                i = 0
                For Each fila As DataRow In dt.Rows
                    Form1.LisDePrecios.DGVOtrosProovedores.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(1).ToString)
                    Form1.LisDePrecios.DGVOtrosProovedores.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(2).ToString)
                    Form1.LisDePrecios.DGVOtrosProovedores.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(3).ToString)
                    Form1.LisDePrecios.DGVOtrosProovedores.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(4).ToString)
                    Form1.LisDePrecios.DGVOtrosProovedores.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(5).ToString)
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
        'fin de la parte del codigo que es para poder llenar el DGV con la lista de otros proveedores
        Me.Close()
    End Sub
    'Find de lo del DGV%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'BOTON PARA MINIMIZAR LA VENTANA
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 19
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaDeProductos.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 19
                Dim celda As String
                If IsDBNull(fila(i).Item(j)) Then
                    celda = ""
                Else
                    celda = CStr(fila(i).Item(j))
                End If
                ds.Rows(ds.Rows.Count - 1).Item(j) = celda
            Next
        Next
        Return ds
    End Function

    Private Function FiltrarOtrosProveedores(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 5
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.Tabla_otros_proveedores.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 5
                Dim celda As String
                If IsDBNull(fila(i).Item(j)) Then
                    celda = ""
                Else
                    celda = CStr(fila(i).Item(j))
                End If
                ds.Rows(ds.Rows.Count - 1).Item(j) = celda
            Next
        Next
        Return ds
    End Function

    Private Sub Ocultar()
        DGVBuscarLDePrecios.Columns(2).Visible = False
        DGVBuscarLDePrecios.Columns(3).Visible = False
        DGVBuscarLDePrecios.Columns(4).Visible = False
        DGVBuscarLDePrecios.Columns(6).Visible = False
        DGVBuscarLDePrecios.Columns(7).Visible = False
        DGVBuscarLDePrecios.Columns(8).Visible = False
        DGVBuscarLDePrecios.Columns(9).Visible = False
        DGVBuscarLDePrecios.Columns(10).Visible = False
        DGVBuscarLDePrecios.Columns(11).Visible = False
        DGVBuscarLDePrecios.Columns(12).Visible = False
        DGVBuscarLDePrecios.Columns(13).Visible = False
        DGVBuscarLDePrecios.Columns(14).Visible = False
        DGVBuscarLDePrecios.Columns(15).Visible = False
        DGVBuscarLDePrecios.Columns(16).Visible = False
        DGVBuscarLDePrecios.Columns(17).Visible = False
        DGVBuscarLDePrecios.Columns(18).Visible = False
        DGVBuscarLDePrecios.Columns(19).Visible = False
    End Sub


    'FIN DE BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
End Class