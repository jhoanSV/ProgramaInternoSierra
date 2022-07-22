Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Estudios

    Private Sub CBProovedorVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProovedorVentas.SelectedIndexChanged
        Dim result As DataRow() = Form1.TablaColaboradores.Select("Nombre='" & CBProovedorVentas.Text & "'")
        If result.Length > 0 Then
            Label16.Visible = False
            TBCodColaborador.Text = CStr(result(0).Item(0))
        Else
            Label16.Visible = True
            TBCodColaborador.Text = ""
        End If
    End Sub

    Private Sub Estudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        RadioButton7.Checked = True
        llenarComboBoxVendedor(CBProovedorVentas)
        Dim Tabla_Salidas As DataTable = Form1.TablaDeSalidas
        DGVparaLosgraficos.DataSource = Tabla_Salidas
        LimpiarLista()
        Iva_recaudado()
    End Sub

    Public Function Filtros_por_periodos()
        Dim Comando_de_filtro As Double = 0
        If RadioButton4.Checked = True Then 'para la semana actual
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
        ElseIf RadioButton5.Checked = True Then 'para el mes actual
            RadioButton4.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            Comando_de_filtro = 2
        ElseIf RadioButton6.Checked = True Then 'para los datos del año actual
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton7.Checked = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            Comando_de_filtro = 3
        ElseIf RadioButton7.Checked = True Then 'para todos los registros
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            DateTimePicker1.Value = Today
            DateTimePicker2.Value = Today
            Comando_de_filtro = 4
        End If
        Return Comando_de_filtro
    End Function

    Public Sub Grafica_por_proveedor(Cadena_de_la_grafica As String) 'Cadena_de_la_grafica)
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        Dim fecha As ArrayList = New ArrayList
        Dim Ventas As ArrayList = New ArrayList
        Dim Ganancias As ArrayList = New ArrayList
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim Connstring As String = Form1.conexion

        Dim conn As New SqlConnection(Connstring)
        conn.Open()
        Try
            cmd = New SqlCommand(Cadena_de_la_grafica, conn)
            dr = cmd.ExecuteReader

            While (dr.Read())
                fecha.Add(dr.GetString(0))
                Ventas.Add(dr.GetString(1))
                Ganancias.Add(dr.GetString(2))
            End While
            Chart1.Series(0).Points.DataBindXY(fecha, Ventas)
            Chart1.Series(1).Points.DataBindXY(fecha, Ganancias)
            For i As Integer = 0 To Ventas.Count - 1
                Chart1.Series(0).Label = Ventas(i).ToString
            Next

            For Each DataPoint In Chart1.Series(0).Points
                DataPoint.CustomProperties = "LabelStyle=Top"
                DataPoint.Label = "#VALY{$##,##0.00}"
                DataPoint.LabelFormat = "##,##0.00"
            Next

            For Each DataPoint In Chart1.Series(1).Points
                DataPoint.CustomProperties = "LabelStyle=Top"
                DataPoint.Label = "#VALY{$##,##0.00}"
                DataPoint.LabelFormat = "##,##0.00"
            Next

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function grafica_por_Categoria(Cadena As String)
        Dim categoria As ArrayList = New ArrayList
        Dim cantidad As ArrayList = New ArrayList

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim Connstring As String = Form1.conexion

        Dim conn As New SqlConnection(Connstring)
        conn.Open()
        Try
            cmd = New SqlCommand(Cadena, conn)
            dr = cmd.ExecuteReader

            While (dr.Read())
                categoria.Add(dr.GetString(0))
                cantidad.Add(dr.GetString(1))
            End While
            Chart2.Series(0).Points.DataBindXY(categoria, cantidad)

            For Each DataPoint In Chart2.Series(0).Points
                DataPoint.CustomProperties = "LabelStyle=Top"
            Next
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Grafias_y_demas()
        'para el Iva recaudado
        For i As Integer = 0 To DGVparaLosgraficos.Rows.Count - 1

        Next
    End Sub
    Private Sub Iva_recaudado()
        Dim suma_iva_recaudado As Double = 0
        For i As Integer = DGVparaLosgraficos.Rows.Count - 1 To 0 Step -1
            suma_iva_recaudado += Convert.ToDouble(DGVparaLosgraficos.Rows(i).Cells(2).Value.ToString) * Convert.ToDouble(DGVparaLosgraficos.Rows(i).Cells(8).Value.ToString)
        Next
        Label12.Text = Format(suma_iva_recaudado, "##,##0.00")

        Dim suma_ventas_totales As Double = 0
        For i As Integer = DGVparaLosgraficos.Rows.Count - 1 To 0 Step -1
            suma_ventas_totales += Convert.ToDouble(DGVparaLosgraficos.Rows(i).Cells(5).Value.ToString)
        Next
        Label9.Text = Format(suma_ventas_totales, "##,##0.00")

        Dim suma_ganancias As Double = 0
        For i As Integer = DGVparaLosgraficos.Rows.Count - 1 To 0 Step -1
            suma_ganancias += Convert.ToDouble(DGVparaLosgraficos.Rows(i).Cells(12).Value.ToString)
        Next
        Label17.Text = Format(suma_ganancias, "##,##0.00")
    End Sub
    Private Sub LimpiarLista()
        For i As Double = DGVparaLosgraficos.Rows.Count - 1 To 0 Step -1
            If Trim(DGVparaLosgraficos.Rows(i).Cells(0).Value.ToString) = "" Or Trim(DGVparaLosgraficos.Rows(i).Cells(0).Value.ToString) = "0" Then
                DGVparaLosgraficos.Rows.Remove(DGVparaLosgraficos.Rows(i))
            End If
        Next
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class