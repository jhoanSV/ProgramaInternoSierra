Module FiltrosDeTablas
    Public Function Filtrar_tabla_de_ingresados(cadena As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.Tabla_de_ingresados.Select(cadena)
        For i As Integer = 0 To 27
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.Tabla_de_ingresados.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 27
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function

    Public Function FiltrarCliente(cadena As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaClientes.Select(cadena)
        For i As Integer = 0 To 12
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaClientes.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 12
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function

    Public Function ObtenerTablaDeFiltroEstados(buscar As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeEstadosVentas.Select(buscar)
        For i As Integer = 0 To 10
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaDeEstadosVentas.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 10
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function

    Public Function ObtenerTablaDeAlistados(buscar As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaAlistados.Select(buscar)
        For i As Integer = 0 To 27
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaAlistados.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 27
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function

    Public Function ObtenerTablaDeVerificados(buscar As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaVerificados.Select(buscar)
        For i As Integer = 0 To 27
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaVerificados.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 27
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function
End Module
