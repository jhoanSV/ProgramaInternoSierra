Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Configuracion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim myFileDialog As New OpenFileDialog()
            Dim xSheet As String = ""

            With myFileDialog
                .Filter = "Excel Files |*.xlsx"
                .Title = "Open File"
                .ShowDialog()
            End With
            If myFileDialog.FileName.ToString <> "" Then
                Dim ExcelFile As String = myFileDialog.FileName.ToString
                'MsgBox(ExcelFile)
                xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
                Dim dt As DataTable = GetDataExcel(ExcelFile, xSheet)

                '"C:\Users\pc\Documents\prueba_de_subir_excel.xlsx", "Hoja1")

                'quitafilasvacias(dt)

                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        For i As Double = DataGridView1.Rows.Count - 1 To 0 Step -1
            If Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value) = "" Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(i))
            End If
        Next
    End Sub


    Private Function GetDataExcel(
    ByVal fileName As String, ByVal sheetName As String) As DataTable

        ' Comprobamos los parámetros.
        '
        If ((String.IsNullOrEmpty(fileName)) OrElse
          (String.IsNullOrEmpty(sheetName))) Then _
          Throw New ArgumentNullException()

        Try
            Dim extension As String = IO.Path.GetExtension(fileName)

            Dim connString As String = "Data Source=" & fileName

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0;" &
                       "Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"

            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0;" &
                       "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Throw New ArgumentException(
                  "La extensión " & extension & " del archivo no está permitida.")
            End If

            Using conexion As New OleDbConnection(connString)

                Dim sql As String = "SELECT * FROM [" & sheetName & "$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)

                Dim dt As New DataTable("Excel")

                adaptador.Fill(dt)

                Return dt

            End Using

        Catch ex As Exception
            Throw

        End Try

    End Function

    Public Function ObtenerTablaDeEntradas() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("Select * from entradas As ES order by ES.FechaFactura desc")
            Dim i As Integer = 0
            DGVEntradas.Rows.Clear()
            If dt.Rows.Count > 0 Then
                DGVEntradas.Rows.Add(dt.Rows.Count)
                For Each fila As DataRow In dt.Rows
                    DGVEntradas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                    DGVEntradas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                    DGVEntradas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                    DGVEntradas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                    DGVEntradas.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                    DGVEntradas.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                    DGVEntradas.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                    DGVEntradas.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                    DGVEntradas.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                    DGVEntradas.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                    DGVEntradas.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                    DGVEntradas.Rows(i).Cells(11).Value = Trim(dt.Rows(i).Item(11).ToString)
                    DGVEntradas.Rows(i).Cells(12).Value = Trim(dt.Rows(i).Item(12).ToString)
                    DGVEntradas.Rows(i).Cells(13).Value = Trim(dt.Rows(i).Item(13).ToString)
                    DGVEntradas.Rows(i).Cells(14).Value = Trim(dt.Rows(i).Item(14).ToString)
                    DGVEntradas.Rows(i).Cells(15).Value = Trim(dt.Rows(i).Item(15).ToString)
                    DGVEntradas.Rows(i).Cells(16).Value = Trim(dt.Rows(i).Item(16).ToString)
                    DGVEntradas.Rows(i).Cells(17).Value = Trim(dt.Rows(i).Item(17).ToString)
                    DGVEntradas.Rows(i).Cells(18).Value = Trim(dt.Rows(i).Item(18).ToString)
                    DGVEntradas.Rows(i).Cells(19).Value = Trim(dt.Rows(i).Item(19).ToString)
                    DGVEntradas.Rows(i).Cells(20).Value = Trim(dt.Rows(i).Item(20).ToString)
                    'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function

    Public Function ObtenerTablaDeAlistados() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("Select * from alistados As ES")
            Dim i As Integer = 0
            DGVAlistados.Rows.Clear()
            If dt.Rows.Count > 0 Then
                DGVAlistados.Rows.Add(dt.Rows.Count)
                For Each fila As DataRow In dt.Rows
                    DGVAlistados.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                    DGVAlistados.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                    DGVAlistados.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                    DGVAlistados.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                    DGVAlistados.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                    DGVAlistados.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                    DGVAlistados.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                    'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function

    Public Function ObtenerTablaDeVerificados() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("Select * from verificados As ES")
            Dim i As Integer = 0
            DGVVerificados.Rows.Clear()
            If dt.Rows.Count > 0 Then
                DGVVerificados.Rows.Add(dt.Rows.Count)
                For Each fila As DataRow In dt.Rows
                    DGVVerificados.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                    DGVVerificados.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                    DGVVerificados.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                    DGVVerificados.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                    DGVVerificados.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                    DGVVerificados.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                    DGVVerificados.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                    DGVVerificados.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                    DGVVerificados.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                    DGVVerificados.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                    DGVVerificados.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                    DGVVerificados.Rows(i).Cells(11).Value = Trim(dt.Rows(i).Item(11).ToString)
                    DGVVerificados.Rows(i).Cells(12).Value = Trim(dt.Rows(i).Item(12).ToString)
                    DGVVerificados.Rows(i).Cells(13).Value = Trim(dt.Rows(i).Item(13).ToString)
                    DGVVerificados.Rows(i).Cells(14).Value = Trim(dt.Rows(i).Item(14).ToString)
                    DGVVerificados.Rows(i).Cells(15).Value = Trim(dt.Rows(i).Item(15).ToString)
                    DGVVerificados.Rows(i).Cells(16).Value = Trim(dt.Rows(i).Item(16).ToString)
                    DGVVerificados.Rows(i).Cells(17).Value = Trim(dt.Rows(i).Item(17).ToString)
                    DGVVerificados.Rows(i).Cells(18).Value = Trim(dt.Rows(i).Item(18).ToString)
                    DGVVerificados.Rows(i).Cells(19).Value = Trim(dt.Rows(i).Item(19).ToString)
                    DGVVerificados.Rows(i).Cells(20).Value = Trim(dt.Rows(i).Item(20).ToString)
                    DGVVerificados.Rows(i).Cells(21).Value = Trim(dt.Rows(i).Item(21).ToString)
                    DGVVerificados.Rows(i).Cells(22).Value = Trim(dt.Rows(i).Item(22).ToString)
                    DGVVerificados.Rows(i).Cells(23).Value = Trim(dt.Rows(i).Item(23).ToString)
                    DGVVerificados.Rows(i).Cells(24).Value = Trim(dt.Rows(i).Item(24).ToString)
                    DGVVerificados.Rows(i).Cells(25).Value = Trim(dt.Rows(i).Item(25).ToString)
                    DGVVerificados.Rows(i).Cells(26).Value = Trim(dt.Rows(i).Item(26).ToString)
                    DGVVerificados.Rows(i).Cells(27).Value = Trim(dt.Rows(i).Item(27).ToString)
                    'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function

    Public Function ObtenerTablaDeSalidas() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("Select * from salidas As ES")
            Dim i As Integer = 0
            DGVSalidas.Rows.Clear()
            If dt.Rows.Count > 0 Then
                DGVSalidas.Rows.Add(dt.Rows.Count)
                For Each fila As DataRow In dt.Rows
                    DGVSalidas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                    DGVSalidas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                    DGVSalidas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                    DGVSalidas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                    DGVSalidas.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                    DGVSalidas.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                    DGVSalidas.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                    DGVSalidas.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                    DGVSalidas.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                    DGVSalidas.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                    DGVSalidas.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                    DGVSalidas.Rows(i).Cells(11).Value = Trim(dt.Rows(i).Item(11).ToString)
                    DGVSalidas.Rows(i).Cells(12).Value = Trim(dt.Rows(i).Item(12).ToString)
                    DGVSalidas.Rows(i).Cells(13).Value = Trim(dt.Rows(i).Item(13).ToString)
                    DGVSalidas.Rows(i).Cells(14).Value = Trim(dt.Rows(i).Item(14).ToString)
                    DGVSalidas.Rows(i).Cells(15).Value = Trim(dt.Rows(i).Item(15).ToString)
                    DGVSalidas.Rows(i).Cells(16).Value = Trim(dt.Rows(i).Item(16).ToString)
                    DGVSalidas.Rows(i).Cells(17).Value = Trim(dt.Rows(i).Item(17).ToString)
                    DGVSalidas.Rows(i).Cells(18).Value = Trim(dt.Rows(i).Item(18).ToString)
                    DGVSalidas.Rows(i).Cells(19).Value = Trim(dt.Rows(i).Item(19).ToString)
                    DGVSalidas.Rows(i).Cells(20).Value = Trim(dt.Rows(i).Item(20).ToString)
                    DGVSalidas.Rows(i).Cells(21).Value = Trim(dt.Rows(i).Item(21).ToString)
                    DGVSalidas.Rows(i).Cells(22).Value = Trim(dt.Rows(i).Item(22).ToString)
                    DGVSalidas.Rows(i).Cells(23).Value = Trim(dt.Rows(i).Item(23).ToString)
                    DGVSalidas.Rows(i).Cells(24).Value = Trim(dt.Rows(i).Item(24).ToString)
                    DGVSalidas.Rows(i).Cells(25).Value = Trim(dt.Rows(i).Item(25).ToString)
                    DGVSalidas.Rows(i).Cells(26).Value = Trim(dt.Rows(i).Item(26).ToString)
                    DGVSalidas.Rows(i).Cells(27).Value = Trim(dt.Rows(i).Item(27).ToString)
                    'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function

    Public Function ObtenerTablaDeAnulados() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("Select * from anulados As ES")
            Dim i As Integer = 0
            DGVAnulados.Rows.Clear()
            If dt.Rows.Count > 0 Then
                DGVAnulados.Rows.Add(dt.Rows.Count)
                For Each fila As DataRow In dt.Rows
                    DGVAnulados.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                    DGVAnulados.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                    DGVAnulados.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                    DGVAnulados.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                    DGVAnulados.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                    DGVAnulados.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                    DGVAnulados.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                    DGVAnulados.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                    DGVAnulados.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                    DGVAnulados.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                    DGVAnulados.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                    DGVAnulados.Rows(i).Cells(11).Value = Trim(dt.Rows(i).Item(11).ToString)
                    DGVAnulados.Rows(i).Cells(12).Value = Trim(dt.Rows(i).Item(12).ToString)
                    DGVAnulados.Rows(i).Cells(13).Value = Trim(dt.Rows(i).Item(13).ToString)
                    DGVAnulados.Rows(i).Cells(14).Value = Trim(dt.Rows(i).Item(14).ToString)
                    DGVAnulados.Rows(i).Cells(15).Value = Trim(dt.Rows(i).Item(15).ToString)
                    DGVAnulados.Rows(i).Cells(16).Value = Trim(dt.Rows(i).Item(16).ToString)
                    DGVAnulados.Rows(i).Cells(17).Value = Trim(dt.Rows(i).Item(17).ToString)
                    DGVAnulados.Rows(i).Cells(18).Value = Trim(dt.Rows(i).Item(18).ToString)
                    DGVAnulados.Rows(i).Cells(19).Value = Trim(dt.Rows(i).Item(19).ToString)
                    DGVAnulados.Rows(i).Cells(20).Value = Trim(dt.Rows(i).Item(20).ToString)
                    DGVAnulados.Rows(i).Cells(21).Value = Trim(dt.Rows(i).Item(21).ToString)
                    DGVAnulados.Rows(i).Cells(22).Value = Trim(dt.Rows(i).Item(22).ToString)
                    DGVAnulados.Rows(i).Cells(23).Value = Trim(dt.Rows(i).Item(23).ToString)
                    DGVAnulados.Rows(i).Cells(24).Value = Trim(dt.Rows(i).Item(24).ToString)
                    DGVAnulados.Rows(i).Cells(25).Value = Trim(dt.Rows(i).Item(25).ToString)
                    DGVAnulados.Rows(i).Cells(26).Value = Trim(dt.Rows(i).Item(26).ToString)
                    DGVAnulados.Rows(i).Cells(27).Value = Trim(dt.Rows(i).Item(27).ToString)
                    'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerTablaDeEntradas()
        ObtenerTablaDeAlistados()
        ObtenerTablaDeVerificados()
        ObtenerTablaDeSalidas()
        ObtenerTablaDeAnulados()
        Consecutivos()
    End Sub

    Private Sub ButtonExportarAExcelColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        llenarExcel(DGVEntradas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        llenarExcel(DGVAlistados)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        llenarExcel(DGVVerificados)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenarExcel(DGVSalidas)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        llenarExcel(DGVAnulados)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If verificar_existencias() = False Then
            MsgBox("no se pudo")
        ElseIf verificar_existencias() = True Then
            ingresar_a_las_tablas()
            Actualizar_todo()
        End If
    End Sub
    Private Sub ingresar_a_las_tablas()
        If verificar_existencias() = True Then
            If DataGridView1.Rows.Count = 0 Then
                MsgBox("La tabla no puede estar vacia para subir los datos")
            Else

                Try
                    'Verifica si ya exsiste la categoria y si no exise la agrega a la lista de categorias.
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        Dim dt As New DataTable
                        dt = Form1.Tablas("select*from categoria where Categoria='" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(4).Value) & "'")

                        If dt.Rows.Count = 1 Then
                            Continue For
                        Else
                            Form1.Consultar("insert into categoria values ('" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(4).Value) & "')")
                        End If
                    Next

                    'Verifica si ya exsiste la sub categoria y si no exise la agrega a la lista de sub categorias.
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        Dim dt As New DataTable
                        dt = Form1.Tablas("select*from subcategorias where SubCategoria='" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(5).Value) & "'")

                        If dt.Rows.Count = 1 Then
                            Continue For
                        Else
                            Form1.Consultar("insert into subcategorias values ('" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(5).Value) & "')")
                        End If

                    Next

                    'Verifica si ya exsiste la ubicacion y si no exise la agrega a la lista de ubicacion.
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        Dim dt As New DataTable
                        dt = Form1.Tablas("select*from ubicaciones where Ubicacion='" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(15).Value) & "'")

                        If dt.Rows.Count = 1 Then
                            Continue For
                        Else
                            Form1.Consultar("insert into ubicaciones values ('" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(15).Value) & "')")
                        End If

                    Next
                    'para verificar si exsiste, si existe cambia la cantidad, si no existe la crea
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        Dim dt1 As New DataTable
                        dt1 = Form1.Tablas("Select Cod, Descripcion, Cantidad from productos where Cod='" & Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value) & "'")
                        If dt1.Rows.Count Then
                            Actualizar_inventario(Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value), Convert.ToString(DataGridView1.Rows.Item(i).Cells(1).Value), Convert.ToDouble(DataGridView1.Rows(i).Cells(16).Value))
                        Else
                            Agregar_en_tablas(i)
                        End If
                    Next

                    ''Insertar datos a la tabla de producto &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                    'Try
                    '    Dim Cod As String
                    '    Dim Descripcion As String
                    '    Dim UnidadOpaquete As String
                    '    Dim EsUnidadOpaquete As String
                    '    Dim Categoria As String
                    '    Dim SubCategoria As String
                    '    Dim CodProovedor As String
                    '    Dim Proovedor As String
                    '    Dim PCosto As String
                    '    Dim PVenta As String
                    '    Dim Ganancia As String
                    '    Dim PVenta1 As String
                    '    Dim Ganancia1 As String
                    '    Dim Pventa2 As String
                    '    Dim Ganancia2 As String
                    '    Dim Ubicación As String
                    '    Dim Cantidad As String
                    '    Dim Minimo As String
                    '    Dim Maximo As String
                    '    Dim Nota As String
                    '    Dim cadena_de_insercion As String



                    '    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    '        Cod = Convert.ToString(DataGridView1.Rows(i).Cells(0).Value)
                    '        Descripcion = Convert.ToString(DataGridView1.Rows(i).Cells(1).Value)
                    '        UnidadOpaquete = Convert.ToString(DataGridView1.Rows(i).Cells(2).Value)
                    '        EsUnidadOpaquete = Convert.ToString(DataGridView1.Rows(i).Cells(3).Value)
                    '        Categoria = Convert.ToString(DataGridView1.Rows(i).Cells(4).Value)
                    '        SubCategoria = Convert.ToString(DataGridView1.Rows(i).Cells(5).Value)
                    '        CodProovedor = "000"
                    '        Proovedor = "Nuevo Producto al inventario"
                    '        PCosto = Convert.ToString(DataGridView1.Rows(i).Cells(8).Value)
                    '        PVenta = Convert.ToString(DataGridView1.Rows(i).Cells(9).Value)
                    '        Ganancia = Convert.ToString(DataGridView1.Rows(i).Cells(10).Value)
                    '        PVenta1 = Convert.ToString(DataGridView1.Rows(i).Cells(11).Value)
                    '        Ganancia1 = Convert.ToString(DataGridView1.Rows(i).Cells(12).Value)
                    '        Pventa2 = Convert.ToString(DataGridView1.Rows(i).Cells(13).Value)
                    '        Ganancia2 = Convert.ToString(DataGridView1.Rows(i).Cells(14).Value)
                    '        Ubicación = Convert.ToString(DataGridView1.Rows(i).Cells(15).Value)
                    '        Cantidad = Convert.ToString(DataGridView1.Rows(i).Cells(16).Value)
                    '        Minimo = Convert.ToString(DataGridView1.Rows(i).Cells(17).Value)
                    '        Maximo = Convert.ToString(DataGridView1.Rows(i).Cells(18).Value)
                    '        Nota = Convert.ToString(DataGridView1.Rows(i).Cells(19).Value)
                    '        cadena_de_insercion = "('" & Cod & "',
                    '                                '" & Descripcion & "',
                    '                                '" & UnidadOpaquete & "',
                    '                                '" & EsUnidadOpaquete & "',
                    '                                '" & Categoria & "',
                    '                                '" & SubCategoria & "',
                    '                                '" & CodProovedor & "',
                    '                                '" & Proovedor & "',
                    '                                '" & PCosto & "',
                    '                                '" & PVenta & "',
                    '                                '" & Ganancia & "',
                    '                                '" & PVenta1 & "', 
                    '                                '" & Ganancia1 & "',
                    '                                '" & Pventa2 & "',
                    '                                '" & Ganancia2 & "',
                    '                                '" & Ubicación & "',
                    '                                '" & Cantidad & "', 
                    '                                '" & Minimo & "',
                    '                                '" & Maximo & "',
                    '                                '" & Nota & "')"
                    '        Form1.A_tablas("productos", cadena_de_insercion)
                    '    Next
                    '    Conexiondb.conexion.Close()
                    'Catch ex As Exception
                    '    MsgBox("Ocurrio un Error en productos" & ex.Message)
                    'End Try


                    ''Insertar datos a la tabla de Entradas &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                    'Try
                    '    Dim Consecutivo As String
                    '    Dim NFacrura As String
                    '    Dim CodProveedor As String
                    '    Dim Proveedor As String
                    '    Dim Cantidad As String
                    '    Dim Codigo As String
                    '    Dim Descripción As String
                    '    Dim Costo As String
                    '    Dim Total As String
                    '    Dim CostoLP As String
                    '    Dim Fecha As String
                    '    Dim FechaFactura As String
                    '    Dim FechaVencimiento As String
                    '    Dim Dias As String
                    '    Dim IVA As String
                    '    Dim RTF As String
                    '    Dim CodResponsable As String
                    '    Dim Responsable As String
                    '    Dim ContadoCredito As String
                    '    Dim Hora As String
                    '    Dim ConIva As String
                    '    Dim cadena_de_insercion As String
                    '    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    '        Consecutivo = "000"
                    '        NFacrura = ""
                    '        CodProveedor = "000"
                    '        Proveedor = "Nuevo Producto al inventario"
                    '        Cantidad = Convert.ToString(DataGridView1.Rows(i).Cells(16).Value)
                    '        Codigo = Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value)
                    '        Descripción = Convert.ToString(DataGridView1.Rows.Item(i).Cells(1).Value)
                    '        Costo = "0"
                    '        Total = "0"
                    '        CostoLP = "0"
                    '        Fecha = Format(Date.Now, "Short Date")
                    '        FechaFactura = Format(Date.Now, "Short Date")
                    '        FechaVencimiento = Format(Date.Now, "Short Date")
                    '        Dias = "0"
                    '        IVA = "0"
                    '        RTF = "0"
                    '        CodResponsable = "bla"
                    '        Responsable = "bla"
                    '        ContadoCredito = ""
                    '        Hora = TimeString
                    '        ConIva = ""
                    '        cadena_de_insercion = "('" & Consecutivo & "',
                    '                                '" & NFacrura & "',
                    '                                '" & CodProveedor & "',
                    '                                '" & Proveedor & "',
                    '                                '" & Cantidad & "',
                    '                                '" & Codigo & "',
                    '                                '" & Descripción & "',
                    '                                '" & Costo & "',
                    '                                '" & Total & "',
                    '                                '" & CostoLP & "',
                    '                                '" & Fecha & "',
                    '                                '" & FechaFactura & "',
                    '                                '" & FechaVencimiento & "',
                    '                                '" & Dias & "',
                    '                                '" & IVA & "',
                    '                                '" & RTF & "',
                    '                                '" & CodResponsable & "',
                    '                                '" & Responsable & "',
                    '                                '" & ContadoCredito & "',
                    '                                '" & Hora & "',
                    '                                '" & ConIva & "')"
                    '        Form1.A_tablas("entradas", cadena_de_insercion)
                    '    Next
                    'Catch ex As Exception
                    '    MsgBox("Ocurrio un error en entradas " & ex.Message)
                    'End Try

                    ''Insertar datos a la tabla de Entradas &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

                    'Try
                    '    Dim NDePedido As String
                    '    Dim ODePedido As String
                    '    Dim Cantidad As Double
                    '    Dim Codigo As String
                    '    Dim Descipción As String
                    '    Dim VrUnitario As String
                    '    Dim VrTotal As String
                    '    Dim VrUnitarioIVA As String
                    '    Dim IVA As String
                    '    Dim VrTotalIVA As String
                    '    Dim Costo As String
                    '    Dim CostoTotal As String
                    '    Dim Ganancia As String
                    '    Dim Porcentaje As String
                    '    Dim Categoria As String
                    '    Dim SubCategoria As String
                    '    Dim Proveedor As String
                    '    Dim CodCliente As String
                    '    Dim Cliente As String
                    '    Dim CodColaborador As String
                    '    Dim Colaborador As String
                    '    Dim FechaOPedido As String
                    '    Dim FechaEntrega As String
                    '    Dim TipoDePago As String
                    '    Dim FechaDeIngreso As String
                    '    Dim Hora As String
                    '    Dim TieneIVA As String
                    '    Dim FechaVencimiemto As String
                    '    Dim cadena_de_insercion As String

                    '    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    '        NDePedido = "bla000"
                    '        ODePedido = "000"
                    '        Cantidad = 0
                    '        Codigo = Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value)
                    '        Descipción = Convert.ToString(DataGridView1.Rows.Item(i).Cells(1).Value)
                    '        VrUnitario = "0"
                    '        VrTotal = "0"
                    '        VrUnitarioIVA = "0"
                    '        IVA = "0"
                    '        VrTotalIVA = "0"
                    '        Costo = "0"
                    '        CostoTotal = "0"
                    '        Ganancia = "0"
                    '        Porcentaje = "0"
                    '        Categoria = "0"
                    '        SubCategoria = "0"
                    '        Proveedor = "Nuevo producto al inventario"
                    '        CodCliente = ""
                    '        Cliente = ""
                    '        CodColaborador = ""
                    '        Colaborador = ""
                    '        FechaOPedido = ""
                    '        FechaEntrega = ""
                    '        TipoDePago = ""
                    '        FechaDeIngreso = ""
                    '        Hora = ""
                    '        TieneIVA = ""
                    '        FechaVencimiemto = ""

                    '        cadena_de_insercion = "('" & NDePedido & "',
                    '                                '" & ODePedido & "',
                    '                                '" & Cantidad & "',
                    '                                '" & Codigo & "',
                    '                                '" & Descipción & "',
                    '                                '" & VrUnitario & "',
                    '                                '" & VrTotal & "',
                    '                                '" & VrUnitarioIVA & "',
                    '                                '" & IVA & "',
                    '                                '" & VrTotalIVA & "',
                    '                                '" & Costo & "',
                    '                                '" & CostoTotal & "',
                    '                                '" & Ganancia & "',
                    '                                '" & Porcentaje & "',
                    '                                '" & Categoria & "',
                    '                                '" & SubCategoria & "',
                    '                                '" & Proveedor & "',
                    '                                '" & CodCliente & "',
                    '                                '" & Cliente & "',
                    '                                '" & CodColaborador & "',
                    '                                '" & Colaborador & "',
                    '                                '" & FechaOPedido & "',
                    '                                '" & FechaEntrega & "',
                    '                                '" & TipoDePago & "',
                    '                                '" & FechaDeIngreso & "',
                    '                                '" & Hora & "',
                    '                                '" & TieneIVA & "',
                    '                                '" & FechaVencimiemto & "')"
                    '        Form1.A_tablas("salidas", cadena_de_insercion)
                    '    Next
                    '    Conexiondb.conexion.Close()
                    'Catch ex As Exception
                    '    MsgBox("Ocurrio un Error en salidas " & ex.Message)
                    'End Try
                    MsgBox("Los datos se subieron satisfactoriamente")
                    Conexiondb.conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Function Agregar_en_tablas(i As Double)
        'Insertar datos a la tabla de producto &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        Try
            Dim Cod As String
            Dim Descripcion As String
            Dim UnidadOpaquete As String
            Dim EsUnidadOpaquete As String
            Dim Categoria As String
            Dim SubCategoria As String
            Dim CodProovedor As String
            Dim Proovedor As String
            Dim PCosto As String
            Dim PVenta As String
            Dim Ganancia As String
            Dim PVenta1 As String
            Dim Ganancia1 As String
            Dim Pventa2 As String
            Dim Ganancia2 As String
            Dim Ubicación As String
            Dim Cantidad As String
            Dim Minimo As String
            Dim Maximo As String
            Dim Nota As String
            Dim cadena_de_insercion As String

            'For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Cod = Convert.ToString(DataGridView1.Rows(i).Cells(0).Value)
            Descripcion = Convert.ToString(DataGridView1.Rows(i).Cells(1).Value)
            UnidadOpaquete = Convert.ToString(DataGridView1.Rows(i).Cells(2).Value)
            EsUnidadOpaquete = Convert.ToString(DataGridView1.Rows(i).Cells(3).Value)
            Categoria = Convert.ToString(DataGridView1.Rows(i).Cells(4).Value)
            SubCategoria = Convert.ToString(DataGridView1.Rows(i).Cells(5).Value)
            CodProovedor = "000"
            Proovedor = "Nuevo Producto al inventario"
            PCosto = Convert.ToString(DataGridView1.Rows(i).Cells(8).Value)
            PVenta = Convert.ToString(DataGridView1.Rows(i).Cells(9).Value)
            Ganancia = Convert.ToString(DataGridView1.Rows(i).Cells(10).Value)
            PVenta1 = Convert.ToString(DataGridView1.Rows(i).Cells(11).Value)
            Ganancia1 = Convert.ToString(DataGridView1.Rows(i).Cells(12).Value)
            Pventa2 = Convert.ToString(DataGridView1.Rows(i).Cells(13).Value)
            Ganancia2 = Convert.ToString(DataGridView1.Rows(i).Cells(14).Value)
            Ubicación = Convert.ToString(DataGridView1.Rows(i).Cells(15).Value)
            Cantidad = Convert.ToString(DataGridView1.Rows(i).Cells(16).Value)
            Minimo = Convert.ToString(DataGridView1.Rows(i).Cells(17).Value)
            Maximo = Convert.ToString(DataGridView1.Rows(i).Cells(18).Value)
            Nota = Convert.ToString(DataGridView1.Rows(i).Cells(19).Value)
            cadena_de_insercion = "('" & Cod & "',
                                                    '" & Descripcion & "',
                                                    '" & UnidadOpaquete & "',
                                                    '" & EsUnidadOpaquete & "',
                                                    '" & Categoria & "',
                                                    '" & SubCategoria & "',
                                                    '" & CodProovedor & "',
                                                    '" & Proovedor & "',
                                                    '" & PCosto & "',
                                                    '" & PVenta & "',
                                                    '" & Ganancia & "',
                                                    '" & PVenta1 & "', 
                                                    '" & Ganancia1 & "',
                                                    '" & Pventa2 & "',
                                                    '" & Ganancia2 & "',
                                                    '" & Ubicación & "',
                                                    '" & Cantidad & "', 
                                                    '" & Minimo & "',
                                                    '" & Maximo & "',
                                                    '" & Nota & "')"
            Form1.A_tablas("productos", cadena_de_insercion)
            'Next
            Conexiondb.conexion.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un Error en productos" & ex.Message)
        End Try


        'Insertar datos a la tabla de Entradas &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        Try
            Dim Consecutivo As String
            Dim NFacrura As String
            Dim CodProveedor As String
            Dim Proveedor As String
            Dim Cantidad As String
            Dim Codigo As String
            Dim Descripción As String
            Dim Costo As String
            Dim Total As String
            Dim CostoLP As String
            Dim Fecha As String
            Dim FechaFactura As String
            Dim FechaVencimiento As String
            Dim Dias As String
            Dim IVA As String
            Dim RTF As String
            Dim CodResponsable As String
            Dim Responsable As String
            Dim ContadoCredito As String
            Dim Hora As String
            Dim ConIva As String
            Dim cadena_de_insercion As String
            'For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Consecutivo = "000"
            NFacrura = ""
            CodProveedor = "000"
            Proveedor = "Nuevo Producto al inventario"
            Cantidad = Convert.ToString(DataGridView1.Rows(i).Cells(16).Value)
            Codigo = Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value)
            Descripción = Convert.ToString(DataGridView1.Rows.Item(i).Cells(1).Value)
            Costo = "0"
            Total = "0"
            CostoLP = "0"
            Fecha = Format(Date.Now, "Short Date")
            FechaFactura = Format(Date.Now, "Short Date")
            FechaVencimiento = Format(Date.Now, "Short Date")
            Dias = "0"
            IVA = "0"
            RTF = "0"
            CodResponsable = "bla"
            Responsable = "bla"
            ContadoCredito = ""
            Hora = TimeString
            ConIva = ""
            cadena_de_insercion = "('" & Consecutivo & "',
                                                    '" & NFacrura & "',
                                                    '" & CodProveedor & "',
                                                    '" & Proveedor & "',
                                                    '" & Cantidad & "',
                                                    '" & Codigo & "',
                                                    '" & Descripción & "',
                                                    '" & Costo & "',
                                                    '" & Total & "',
                                                    '" & CostoLP & "',
                                                    '" & Fecha & "',
                                                    '" & FechaFactura & "',
                                                    '" & FechaVencimiento & "',
                                                    '" & Dias & "',
                                                    '" & IVA & "',
                                                    '" & RTF & "',
                                                    '" & CodResponsable & "',
                                                    '" & Responsable & "',
                                                    '" & ContadoCredito & "',
                                                    '" & Hora & "',
                                                    '" & ConIva & "')"
            Form1.A_tablas("entradas", cadena_de_insercion)
            'Next
        Catch ex As Exception
            MsgBox("Ocurrio un error en entradas " & ex.Message)
        End Try

        'Insertar datos a la tabla de Entradas &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        Try
            Dim NDePedido As String
            Dim ODePedido As String
            Dim Cantidad As Double
            Dim Codigo As String
            Dim Descipción As String
            Dim VrUnitario As String
            Dim VrTotal As String
            Dim VrUnitarioIVA As String
            Dim IVA As String
            Dim VrTotalIVA As String
            Dim Costo As String
            Dim CostoTotal As String
            Dim Ganancia As String
            Dim Porcentaje As String
            Dim Categoria As String
            Dim SubCategoria As String
            Dim Proveedor As String
            Dim CodCliente As String
            Dim Cliente As String
            Dim CodColaborador As String
            Dim Colaborador As String
            Dim FechaOPedido As String
            Dim FechaEntrega As String
            Dim TipoDePago As String
            Dim FechaDeIngreso As String
            Dim Hora As String
            Dim TieneIVA As String
            Dim FechaVencimiemto As String
            Dim cadena_de_insercion As String

            'For i As Integer = 0 To DataGridView1.Rows.Count - 1
            NDePedido = "bla000"
            ODePedido = "000"
            Cantidad = 0
            Codigo = Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value)
            Descipción = Convert.ToString(DataGridView1.Rows.Item(i).Cells(1).Value)
            VrUnitario = "0"
            VrTotal = "0"
            VrUnitarioIVA = "0"
            IVA = "0"
            VrTotalIVA = "0"
            Costo = "0"
            CostoTotal = "0"
            Ganancia = "0"
            Porcentaje = "0"
            Categoria = "0"
            SubCategoria = "0"
            Proveedor = "Nuevo producto al inventario"
            CodCliente = ""
            Cliente = ""
            CodColaborador = ""
            Colaborador = ""
            FechaOPedido = ""
            FechaEntrega = ""
            TipoDePago = ""
            FechaDeIngreso = ""
            Hora = ""
            TieneIVA = ""
            FechaVencimiemto = ""

            cadena_de_insercion = "('" & NDePedido & "',
                                                    '" & ODePedido & "',
                                                    '" & Cantidad & "',
                                                    '" & Codigo & "',
                                                    '" & Descipción & "',
                                                    '" & VrUnitario & "',
                                                    '" & VrTotal & "',
                                                    '" & VrUnitarioIVA & "',
                                                    '" & IVA & "',
                                                    '" & VrTotalIVA & "',
                                                    '" & Costo & "',
                                                    '" & CostoTotal & "',
                                                    '" & Ganancia & "',
                                                    '" & Porcentaje & "',
                                                    '" & Categoria & "',
                                                    '" & SubCategoria & "',
                                                    '" & Proveedor & "',
                                                    '" & CodCliente & "',
                                                    '" & Cliente & "',
                                                    '" & CodColaborador & "',
                                                    '" & Colaborador & "',
                                                    '" & FechaOPedido & "',
                                                    '" & FechaEntrega & "',
                                                    '" & TipoDePago & "',
                                                    '" & FechaDeIngreso & "',
                                                    '" & Hora & "',
                                                    '" & TieneIVA & "',
                                                    '" & FechaVencimiemto & "')"
            Form1.A_tablas("salidas", cadena_de_insercion)
            'Next
            Conexiondb.conexion.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un Error en salidas " & ex.Message)
        End Try
    End Function

    Private Function Actualizar_inventario(Codigo As String, Descripcion As String, Ncantidad As Double)
        Dim Diferencia As Double
        Dim Inventario As Double = Form1.Cantidad_del_producto(Codigo) 'Convert.ToDouble(dt.Rows(0).Item(0).ToString)
        Dim Nuevo As Double = Convert.ToDouble(Ncantidad)
        Diferencia = Nuevo - Inventario
        Dim valor_absoluto_de_diferencia As Double = 0
        valor_absoluto_de_diferencia = Math.Abs(Diferencia)

        If Diferencia >= 0 Then
            'se agrega la diferencia a la lista de Entradas
            Dim cadena_de_insercion1 As String = "('" & "000" & "',
                                                   '" & "" & "',
                                                   '" & "000" & "',
                                                   '" & "Arreglo de invenario" & "',
                                                   '" & valor_absoluto_de_diferencia & "',
                                                   '" & Codigo & "',
                                                   '" & Descripcion & "',
                                                   '" & "0" & "',
                                                   '" & "0" & "',
                                                   '" & "0" & "',
                                                   '" & Format(Date.Now, "Short Date") & "',
                                                   '" & Format(Date.Now, "Short Date") & "',
                                                   '" & Format(Date.Now, "Short Date") & "',
                                                   '" & "0" & "',
                                                   '" & "0" & "',
                                                   '" & "0" & "',
                                                   '" & "bla" & "',
                                                   '" & "bla" & "',
                                                   '" & "" & "',
                                                   '" & TimeString & "',
                                                   '" & "" & "')"
            Form1.A_tablas("entradas", cadena_de_insercion1)
            'para modificar productos
            'Form1.Consultar("update productos Set Cantidad = '" & NumericUpDownCantidad.Text & "' Where Cod = '" & TBCodigoProductos.Text & "'")

        ElseIf Diferencia < 0 Then
            Dim cadena_de_insercion2 As String = "('" & "000" & "',
                                        '" & "" & "',
                                        '" & valor_absoluto_de_diferencia & "',
                                        '" & Codigo & "',
                                        '" & Descripcion & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "0" & "',
                                        '" & "Arreglo de inventario" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & Format(Date.Now, "Short Date") & "',
                                        '" & "" & "',
                                        '" & "" & "',
                                        '" & "" & "')"
            Form1.A_tablas("salidas", cadena_de_insercion2)
        End If

    End Function

    Private Function verificar_existencias()
        Dim verificado As Boolean = True
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim dt As New DataTable
            dt = Form1.Tablas("Select Cod from productos")
            If dt.Rows.Count Then
                'For k As Integer = 0 To dt.Rows.Count
                '    If dt.Rows(k).Item(0).ToString = Convert.ToString(DataGridView1.Rows.Item(i).Cells(0).Value) Then
                '        MsgBox("El producto con codigo " + Convert.ToString(DataGridView1.Rows(i).Cells(0).Value) + "y descripción " + Convert.ToString(DataGridView1.Rows(i).Cells(1).Value) + " ya existe, intente con otro codigo")
                '        verificado = False
                '    Else
                '        Continue For
                '    End If
                'Next

            Else
                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    If j = i Then
                        Continue For
                    ElseIf Convert.ToString(DataGridView1.Rows(i).Cells(0).Value) = Convert.ToString(DataGridView1.Rows.Item(j).Cells(0).Value) Then
                        MsgBox("El producto con codigo " + Convert.ToString(DataGridView1.Rows(i).Cells(0).Value) + "y descripción " + Convert.ToString(DataGridView1.Rows(i).Cells(1).Value) + " Se encuentra repetido, intente con otro codigo")
                        verificado = False
                    End If
                Next
            End If

        Next
        Return verificado

    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim NuevoConsecutivoCompra As Double = NUDCompra.Text
        Form1.Consultar("update consecutivos set Ncompra = '" & NuevoConsecutivoCompra & "' where 1 = 1")
        Consecutivos()
    End Sub
    Private Sub Consecutivos()
        Dim dt As New DataTable
        dt = Form1.Tablas("SELECT * from consecutivos")
        NconsecutivoCompra.Text = dt.Rows(0).Item(2).ToString
        NconsecutivoVenta.Text = dt.Rows(0).Item(1).ToString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim NuevoConsecutivoVenta As Double = NUDVenta.Text
        Form1.Consultar("update consecutivos set NPreFactura = '" & NuevoConsecutivoVenta & "' where 1 = 1")
        Consecutivos()
    End Sub

    Private Sub RadioButtonNuevo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNuevo.CheckedChanged
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub RadioButtonListaColaboradores_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonListaColaboradores.CheckedChanged
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub RadioButtonEliminarColaboradores_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEliminarColaboradores.CheckedChanged
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        TabControl1.SelectedIndex = 6
    End Sub


End Class