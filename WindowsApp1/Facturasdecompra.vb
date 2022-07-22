Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Facturasdecompra
    Private Sub Facturasdecompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboBoxProovedores(CBProovedorVentas)
        Lista_de_entradas()
        llenarComboBoxVendedor(CBNombreColaboradorVentas)
        ObtenerTablaDePagos()
        cargar_DataCombo(DGVVentas) 'llena el campo de prodcutos del datagridview ventas.
        TextHoy.Text = Today
        DGVVentas.Columns(0).Width = 100
        DGVVentas.Columns(1).Width = 100
        DGVVentas.Columns(2).Width = 600 'Poner el tamaño de la descripcion de los productos mas grande
        CBContadoOCredito.Text = "Contado"
        ComboBox2.Visible = False
        Label18.Visible = False
        DTPFiltrarDesde.Visible = False
        Label19.Visible = False
        DTPFiltrarHasta.Visible = False
        ComboBox4.Visible = False
        Label21.Visible = False
        DateTimePicker2.Visible = False
        Label22.Visible = False
        DateTimePicker3.Visible = False
        ComboBox6.Text = "No"
        TBconsecutivoCompras.Text = Consecutivos()
    End Sub
    Private Function Consecutivos()
        Dim dt As New DataTable
        Dim Ncompra As Double
        dt = Form1.Tablas("SELECT * from consecutivos")
        Ncompra = dt.Rows(0).Item(2).ToString
        Return Ncompra
    End Function

    'TAB PAGE 1&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'Todo lo que va en los combobox, textbox y demas que no van en el DGV%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProovedorVentas.SelectedIndexChanged
        'llena los datos del proveedor que escojan en el CBProveedorVentas
        If CBProovedorVentas.Text = "" Then
            MsgBox("Inserte un proveedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Proovedor='" & CBProovedorVentas.Text & "'")
            If result.Length > 0 Then
                TBCodigoProovedorVentas.Text = CStr(result(0).Item(0))
                TBTelProovedorVentas.Text = CStr(result(0).Item(4))
                TBDireccionProovedorVentas.Text = CStr(result(0).Item(8)) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                    MsgBox("El proovedor no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
                End If
            End If
    End Sub

    Function datos_del_proveedor()

        Dim result As DataRow() = Form1.TablaProveedores.Select("Proovedor='" & CBProovedorVentas.Text & "'")
        If result.Length > 0 Then
            TBCodigoProovedorVentas.Text = CStr(result(0).Item(0))
            TBTelProovedorVentas.Text = CStr(result(0).Item(4))
            TBDireccionProovedorVentas.Text = CStr(result(0).Item(8)) 'selecciona los datos segun el criterio del codigo del cliente
        Else
            MsgBox("El proovedor no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
        End If
    End Function

    Private Sub TBCodigoProovedorVentas_Leave(sender As Object, e As EventArgs) Handles TBCodigoProovedorVentas.Leave
        'llena los datos del proveedor que escojan en el TBCodigoProovedorVentas
        If TBCodigoProovedorVentas.Text = "" Then
            Label23.Visible = True 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Cod ='" & TBCodigoProovedorVentas.Text & "'")
            If result.Length > 0 Then
                CBProovedorVentas.Text = CStr(result(0).Item(2))
                TBTelProovedorVentas.Text = CStr(result(0).Item(4))
                TBDireccionProovedorVentas.Text = CStr(result(0).Item(8)) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El proovedor no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub

    Private Sub CBColaboradorVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNombreColaboradorVentas.SelectedIndexChanged
        'llena los datos del colaborador que recibe la mercancia segun el CBNombreColaboradorVentas
        If CBNombreColaboradorVentas.Text = "" Then
            MsgBox("Inserte un colaborador") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Nombre='" & CBNombreColaboradorVentas.Text & "'")
            If result.Length > 0 Then
                TBCodigoColaboradorVentas.Text = CStr(result(0).Item(0)) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                    MsgBox("El colaborador no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
                End If
            End If
    End Sub

    Private Sub TBCodigoColaboradorVentas_Leave(sender As Object, e As EventArgs) Handles TBCodigoColaboradorVentas.Leave
        'llena los datos del colaborador que recibe la mercancia segun el TBCodigoColaboradorVentas
        If TBCodigoColaboradorVentas.Text = "" Then
            Label24.Visible = True 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Label24.Visible = False
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod='" & TBCodigoColaboradorVentas.Text & "'")
            If result.Length > 0 Then
                CBNombreColaboradorVentas.Text = CStr(result(0).Item(1)) 'Trim(dt.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                    MsgBox("El colaborador no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
                End If
            End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TBDiasDeCredito.TextChanged
        'Entrega la fecha de vencimiento de la factura segun el DTPFechaFactura
        Dim dias As Integer
        If CBContadoOCredito.Text = "" Or CBContadoOCredito.Text = "Contado" Then
            TBDiasDeCredito.Text = ""
        Else
            If TBDiasDeCredito.Text = "" Then
                dias = 0
                DTPFechaDeCredito.Value = Today.AddDays(dias)
            Else
                dias = Convert.ToDouble(TBDiasDeCredito.Text)
                DTPFechaDeCredito.Value = DTPFechaFactura.Value.Date.AddDays(dias)
            End If
        End If
    End Sub

    Private Sub DTPFechaDeCredito_Leave(sender As Object, e As EventArgs) Handles DTPFechaDeCredito.Leave
        'calcula la cantidad de dias que hay de credito desde la fecha de la factura hasta la fecha de vencimiento
        Dim Candias As Integer
        Dim FechaHoy As Date = DTPFechaFactura.Value
        Dim FechaCredito As Date = DTPFechaDeCredito.Value

        If CBContadoOCredito.Text = "" Or CBContadoOCredito.Text = "Contado" Then
            DTPFechaDeCredito.Value = Today
        Else
            Candias = DateDiff(DateInterval.Day, FechaHoy, FechaCredito)
            TBDiasDeCredito.Text = Candias
        End If
    End Sub

    Private Sub TBDiasDeCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDiasDeCredito.KeyPress
        'le deja solo ingresar numeros al TBDiasDeCredito
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        'NO deja que modifiquen nada del TBHoy
        e.Handled = True
    End Sub
    'Fin DE todo lo que va en los combobox, textbox y demas que no van en el DGV%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGuardarNuevo.Click
        'Guarda los datos de la compra en la tabla de entradas y en la de AbonosCompras
        'Dim dt As New DataTable
        'dt = Form1.Tablas("select*from entradas where Consecutivo='" & TBconsecutivoCompras.Text & "'")
        Dim result As DataRow() = Form1.TablaEntradas.Select("Consecutivo='" & TBconsecutivoCompras.Text & "'")
        If result.Length > 0 Then
            'If dt.Rows.Count = 1 Then
            If ComboBox6.Text = "" Then
                MsgBox("Falta dato del cobro del IVA")
            ElseIf CBProovedorVentas.Text = "" Then
                MsgBox("Falta dato del Proveedor")
            ElseIf CBNombreColaboradorVentas.Text = "" Then
                MsgBox("Falta dato del Colaborador")
            ElseIf CBContadoOCredito.Text = "" Then
                MsgBox("Seleccione si es a contado o a credito")
            Else
                Modificar_compra()
                TBconsecutivoCompras.Text = Consecutivos()
                MsgBox("Se actualizo la factura correctamente")
            End If
        Else
            If ComboBox6.Text = "" Then
                MsgBox("Falta dato del cobro del IVA")
            ElseIf CBProovedorVentas.Text = "" Then
                MsgBox("Falta dato del Proveedor")
            ElseIf CBNombreColaboradorVentas.Text = "" Then
                MsgBox("Falta dato del Colaborador")
            ElseIf CBContadoOCredito.Text = "" Then
                MsgBox("Seleccione si es a contado o a credito")
            Else
                A_tabla_ingresos()
                Dim NuevoConsecutivoCompra As Double = Consecutivos() + 1
                Form1.Consultar("update consecutivos set Ncompra = '" & NuevoConsecutivoCompra & "' where 1 = 1")
                TBconsecutivoCompras.Text = Consecutivos()

                MsgBox("Se ingreso la factura correctamente")

            End If

        End If
    End Sub

    Private Function A_tabla_ingresos()
        'Guarda los datos de la compra en la tabla de entradas y en la de AbonosCompras
        If TBconsecutivoCompras.Text = "" Then
            MsgBox("Falta insertar un codigo o la descripción") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaEntradas.Select("Consecutivo='" & TBconsecutivoCompras.Text & "'")
            If result.Length > 0 Then
                MsgBox("El consecutivo ya existe")
            Else
                ''fin del codigo nuevo este codigo evita que pongan el mismo codigo para dos Proovedores distinto
                'Conexiondb.conexion.Close()
                'Dim agregarEntradas As New OdbcCommand("Insert into entradas values (@Consecutivo,@NFacrura,@CodProveedor,@Proveedor,@Cantidad,@Codigo,@Descripción,@Costo,@Total,@CostoLP,@Fecha,@FechaFactura,@FechaVencimiento,@Dias,@IVA,@RTF,@CodResponsable,@Responsable,@ContadoCredito,@Hora,@ConIva)", Conexiondb.conexion)
                'Conexiondb.conexion.Open()
                Try
                    'For Each fila Is Not nothing  In DGVOtrosProovedores.Rows()
                    For i As Integer = 0 To DGVVentas.Rows.Count - 2
                        Dim cadena_de_insercion1 As String = "('" & TBconsecutivoCompras.Text & "',
                                                               '" & TBNFactuta.Text & "',
                                                               '" & TBCodigoProovedorVentas.Text & "',
                                                               '" & CBProovedorVentas.Text & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Cantidad").Value) & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Codigo").Value) & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Descripcion").Value) & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Costo").Value) & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Total").Value) & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("CostoLP").Value) & "',
                                                               '" & TextHoy.Text & "',
                                                               '" & DTPFechaFactura.Text & "',
                                                               '" & DTPFechaDeCredito.Text & "',
                                                               '" & TBDiasDeCredito.Text & "',
                                                               '" & Convert.ToString(DGVVentas.Rows.Item(i).Cells("Iva").Value) & "',
                                                               '" & TBRTF.Text & "',
                                                               '" & TBCodigoColaboradorVentas.Text & "',
                                                               '" & CBNombreColaboradorVentas.Text & "',
                                                               '" & CBContadoOCredito.Text & "',
                                                               '" & TimeString & "',
                                                               '" & ComboBox6.Text & "')"
                        Form1.A_tablas("entradas", cadena_de_insercion1)

                        ''cantidad = DGVVentas.Rows.Item(i).Cells("Cantidad").Value
                        'agregarEntradas.Parameters.Clear()
                        'agregarEntradas.Parameters.AddWithValue("@Consecutivo", TBconsecutivoCompras.Text)
                        'agregarEntradas.Parameters.AddWithValue("@NFacrura", TBNFactuta.Text)
                        'agregarEntradas.Parameters.AddWithValue("@CodProveedor", TBCodigoProovedorVentas.Text)
                        'agregarEntradas.Parameters.AddWithValue("@Proveedor", CBProovedorVentas.Text)
                        'agregarEntradas.Parameters.AddWithValue("@Cantidad", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Cantidad").Value))
                        'agregarEntradas.Parameters.AddWithValue("@Codigo", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Codigo").Value))
                        'agregarEntradas.Parameters.AddWithValue("@Descripción", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Descripcion").Value))
                        'agregarEntradas.Parameters.AddWithValue("@Costo", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Costo").Value))
                        'agregarEntradas.Parameters.AddWithValue("@Total", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Total").Value))
                        'agregarEntradas.Parameters.AddWithValue("@CostoLP", Convert.ToString(DGVVentas.Rows.Item(i).Cells("CostoLP").Value))
                        'agregarEntradas.Parameters.AddWithValue("@Fecha", TextHoy.Text)
                        'agregarEntradas.Parameters.AddWithValue("@FechaFactura", DTPFechaFactura.Text)
                        'agregarEntradas.Parameters.AddWithValue("@FechaVencimiento", DTPFechaDeCredito.Text)
                        'agregarEntradas.Parameters.AddWithValue("@Dias", TBDiasDeCredito.Text)
                        'agregarEntradas.Parameters.AddWithValue("@IVA", Convert.ToString(DGVVentas.Rows.Item(i).Cells("Iva").Value))
                        'agregarEntradas.Parameters.AddWithValue("@RTF", TBRTF.Text)
                        'agregarEntradas.Parameters.AddWithValue("@CodResponsable", TBCodigoColaboradorVentas.Text)
                        'agregarEntradas.Parameters.AddWithValue("@Responsable", CBNombreColaboradorVentas.Text)
                        'agregarEntradas.Parameters.AddWithValue("@ContadoCredito", CBContadoOCredito.Text)
                        'agregarEntradas.Parameters.AddWithValue("@Hora", TimeString)
                        'agregarEntradas.Parameters.AddWithValue("@ConIva", ComboBox6.Text)
                        'agregarEntradas.ExecuteNonQuery()
                        'Conexiondb.conexion.Close()
                    Next
                    'MsgBox("Se guardo Correctamente")
                Catch ex As Exception
                    MsgBox("Ocurrio un error" & ex.Message)
                End Try
                Limpiar()
            End If
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Limpiar()
    End Sub
    Private Function Limpiar()
        'cancela toda la compra
        ObtenerTablaDePagos()
        Lista_de_entradas()
        TBCodigoProovedorVentas.Text = ""
        CBProovedorVentas.Text = ""
        TBCodigoColaboradorVentas.Text = ""
        CBNombreColaboradorVentas.Text = ""
        TBNFactuta.Text = ""
        TBDireccionProovedorVentas.Text = ""
        TBTelProovedorVentas.Text = ""
        CBContadoOCredito.Text = ""
        TBDiasDeCredito.Text = ""
        TBIvaCompras.Text = ""
        TBRTF.Text = ""
        DTPFechaFactura.Value = Today
        DTPFechaDeCredito.Value = Today
        ComboBox6.Text = ""
        ComboBox6.Text = "No"
        DGVVentas.Rows.Clear()
    End Function
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'Lo que va adentro del DGVVentas %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub DGVVentas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVVentas.CellFormatting
        'para llenar los demas campos del DGV dependiendo del codigo que le pongan

        If e.ColumnIndex = 1 Then
            If e.Value IsNot Nothing Then
                Dim codProducto As String = Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod='" & codProducto & "'")
                If result.Length > 0 Then
                    Dim dgvcc As DataGridViewComboBoxCell
                    dgvcc = DGVVentas.Rows(e.RowIndex).Cells(2)
                    Dim Ccol As DataGridViewComboBoxColumn = CType(DGVVentas.Columns(2), DataGridViewComboBoxColumn)

                    dgvcc.Value = CStr(result(0).Item(1)) 'dt.Rows(0).Item(1).ToString 'Me trae el codigo del producto segun el que se selecciono
                    Me.DGVVentas.Rows(e.RowIndex).Cells(6).Value = CStr(result(0).Item(8)) 'Trim(dt.Rows(0).Item(8).ToString) 'Me trae el costo del producto segun el que se selecciono
                End If
            End If
            'parte que le pongo para que funcione cuando le cambie el codigo me traiga todas las operaciones que necesito
            Dim a As Double
            Dim b As Double
            Dim c As Double
            Dim iva As Double

            a = Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells("Costo").Value)

            If ComboBox6.Text = "SI" Then
                iva = b + (b * (19 / 100))
                c = a * iva
            ElseIf ComboBox6.Text = "NO" Then
                iva = 0
                c = a * b
            End If

            DGVVentas.Rows(e.RowIndex).Cells("Total").Value = Format(c, "##,##0.00")
            DGVVentas.Rows(e.RowIndex).Cells("Costo").Value = Format(b, "##,##0.00")
            DGVVentas.Rows(e.RowIndex).Cells("Iva").Value = Format(iva, "##,##0.00")
            'End If

        End If


        If ComboBox6.Text = "SI" Then
            If e.ColumnIndex = 4 Then
                If Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(4).Value) > Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(6).Value) Then
                    e.CellStyle.BackColor = Color.Red
                ElseIf Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(4).Value) < Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(6).Value) Then
                    e.CellStyle.BackColor = Color.Green
                End If
            End If

        Else
            If e.ColumnIndex = 3 Then
                If Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(3).Value) > Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(6).Value) Then
                    e.CellStyle.BackColor = Color.Red
                ElseIf Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(3).Value) < Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells(6).Value) Then
                    e.CellStyle.BackColor = Color.Green
                End If
            End If
        End If

        Dim total As Double
        Dim total_iva As Double
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVVentas.Rows
            total += Convert.ToDouble(fila.Cells("Total").Value)
            total_iva += Convert.ToDouble(fila.Cells("Iva").Value)
        Next

        TBTotalVentas.Text = Format(total, "##,##0.00")
        TBIvaCompras.Text = Format(total_iva, "##,##0.00")
    End Sub

    'esta parte de codigo es para permitir solo el uso de numeros en las columnas de Cantidad y costo
    Private DataGridView1NumberColumns As String() = {"Cantidad", "Costo"}
    Private Sub DGVVentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles DGVVentas.EditingControlShowing

        If DataGridView1NumberColumns.Contains(DGVVentas.Columns(DGVVentas.CurrentCell.ColumnIndex).Name) Then
            Dim txtEditForDataGridView As TextBox = e.Control
            RemoveHandler txtEditForDataGridView.KeyPress, AddressOf txtEditForDataGridView_Keypress
            AddHandler txtEditForDataGridView.KeyPress, AddressOf txtEditForDataGridView_Keypress
        End If
        If TypeOf e.Control Is ComboBox Then
            Dim cbo As ComboBox = DirectCast(e.Control, ComboBox)
            cbo.DropDownHeight = 75
        End If

    End Sub
    Private Sub txtEditForDataGridView_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If DGVVentas.CurrentCell.ColumnIndex = 0 Or DGVVentas.CurrentCell.ColumnIndex = 3 Then
            If IsNumeric(e.KeyChar.ToString()) _
            Or e.KeyChar = ChrW(Keys.Back) _
            Or e.KeyChar = "," Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    'Fin del codigo para permitir que solo ingresen numeros al DGV en las columnas de Cantidad y costo

    Private Sub DGVVentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVentas.CellEndEdit
        'este codigo es para calcular las columnas de cantidad y costo con en total

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim iva As Double

        If DGVVentas.Columns(e.ColumnIndex).Name = "Cantidad" Or DGVVentas.Columns(e.ColumnIndex).Name = "Costo" Or DGVVentas.Columns(e.ColumnIndex).Name = "Descripcion" Then
            a = Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVentas.Rows(e.RowIndex).Cells("Costo").Value)
            If ComboBox6.Text = "SI" Then
                iva = b + (b * (19 / 100))
                c = a * iva
            ElseIf ComboBox6.Text = "NO" Then
                iva = 0
                c = a * b
            End If
            DGVVentas.Rows(e.RowIndex).Cells("Total").Value = Format(c, "##,##0.00")
            DGVVentas.Rows(e.RowIndex).Cells("Costo").Value = Format(b, "##,##0.00")
            DGVVentas.Rows(e.RowIndex).Cells("Iva").Value = Format(iva, "##,##0.00")
        End If

        If e.ColumnIndex = 2 Then

            If DGVVentas.Rows(e.RowIndex).Cells("Descripcion").Value IsNot Nothing Then
                Dim NomProducto As String = DGVVentas.Rows(e.RowIndex).Cells("Descripcion").Value 'Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaDeProductos.Select("Descripcion ='" & NomProducto & "'")
                If result.Length > 0 Then
                    Me.DGVVentas.Rows(e.RowIndex).Cells(1).Value = ""
                    Dim dgvc As DataGridViewTextBoxCell
                        dgvc = DGVVentas.Rows(e.RowIndex).Cells(1)
                    dgvc.Value = CStr(result(0).Item(0)) 'Me trae el codigo del producto segun el que se selecciono
                    Me.DGVVentas.Rows(e.RowIndex).Cells(6).Value = CStr(result(0).Item(8)) 'Me trae el costo del producto segun el que se selecciono
                End If
                End If
            End If
    End Sub
    'Fin de lo que va adentro del DGVVentas %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TAB PAGE 1 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'TAB PAGE 2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'Lo que va adentro del DGV %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonAbonar_Click(sender As Object, e As EventArgs) Handles ButtonAbonar.Click
        'Este boton llama al form de abonar a las compras
        If Form1.FacCompras.DGVCobros.Rows.Count = 0 Then
            MessageBox.Show("No se han registrado compras para hacer un abono")
        Else
            Dim frm As New FormatoDeAbonosCompras()
            frm.Show()
        End If
    End Sub
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Public Function ObtenerTablaDePagos() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        'Form1.FacCompras.DGVCobros.DataSource = Form1.Tabla_de_pagos
        Form1.FacCompras.DGVCobros.DataSource = Form1.Tabla_de_pagos

        'Dim dt As New DataTable
        'dt = Form1.Tablas("select E.Consecutivo, E.Fecha, E.FechaFactura, E.CodProveedor, E.Proveedor, E.ContadoCredito, E.FechaVencimiento, E.Total from entradas as E where E.Proveedor<>'Nuevo Producto al inventario' and E.Proveedor<>'Arreglo de invenario' group by E.Consecutivo, E.Fecha , E.FechaFactura, E.CodProveedor, E.Proveedor, E.ContadoCredito, E.FechaVencimiento, E.Total order by E.Fecha desc")

        'Dim i As Integer
        'i = 0
        'Form1.FacCompras.DGVCobros.Rows.Clear()
        'If dt.Rows.Count > 0 Then
        '    Form1.FacCompras.DGVCobros.Rows.Add(dt.Rows.Count)
        '    For Each filas As DataRow In dt.Rows()

        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
        '        'Para poder ver el saldo
        '        Dim dt1 As New DataTable
        '        dt1 = Form1.Tablas("Select Abono from abonoscompras where Consecutivo = '" & Trim(dt.Rows(i).Item(0).ToString) & "'")

        '        Dim Suma_abonos As Double = 0

        '        If dt1.Rows.Count > 0 Then
        '            For j As Double = 0 To dt1.Rows().Count - 1
        '                Suma_abonos += Convert.ToDouble(Trim(dt1.Rows(j).Item(0).ToString))
        '            Next
        '        Else
        '            Suma_abonos = 0
        '        End If

        '        Dim Verdadero_Saldo As Double = 0
        '        Verdadero_Saldo = Convert.ToDouble(Trim(dt.Rows(i).Item(7).ToString)) - Suma_abonos
        '        Form1.FacCompras.DGVCobros.Rows(i).Cells(8).Value = Format(Verdadero_Saldo, "##,##0.00")
        '        i = i + 1
        '    Next
        'End If
    End Function

    Private Sub TBbuscarConsecutivo_TextChanged(sender As Object, e As EventArgs) Handles TBbuscarConsecutivo.TextChanged
        If CBFiltro.Text = "Consecutivo" Then
            Filtrar("Consecutivo like'" & "%" + TBbuscarConsecutivo.Text + "%" & "'") 'FiltrarConsecutivoTablaDePagos()
        ElseIf CBFiltro.Text = "Cod proveedor" Then
            Filtrar("CodProveedor like'" & "%" + TBbuscarConsecutivo.Text + "%" & "'") 'FiltrarCodProveedorTablaDePagos()
        ElseIf CBFiltro.Text = "Proveedor" Then
            Filtrar("Proveedor like'" & "%" + TBbuscarConsecutivo.Text + "%" & "'") 'FiltrarProveedorTablaDePagos()
        End If
    End Sub

    Private Sub Filtrar(cadena As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.Tabla_de_pagos.Select(cadena)
        For i As Integer = 0 To 8
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.Tabla_de_pagos.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 8
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Form1.FacCompras.DGVCobros.DataSource = ds
    End Sub

    Private Sub DGVCobros_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVCobros.CellFormatting
        'para ponerle los colores al DGV de los estados
        Dim Vencimiento As Date = Trim(Convert.ToDateTime(DGVCobros.Rows(e.RowIndex).Cells(6).Value))
        If e.ColumnIndex = 5 Then

            If Trim(Convert.ToDouble(DGVCobros.Rows(e.RowIndex).Cells(8).Value)) > 0 Then
                If Vencimiento > Today.Date.AddDays(-15) Then
                    e.CellStyle.BackColor = Color.OrangeRed
                ElseIf Vencimiento > Today Then
                    e.CellStyle.BackColor = Color.Red
                End If

            End If

        End If

        Dim total As Double = 0
        For Each fila In DGVCobros.Rows
            total += Convert.ToDouble(fila.Cells(8).value) '"Saldo").Value)
        Next
        Label27.Text = Format(total, "##,##0.00")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Filtrar("ContadoCredito = '" & ComboBox2.Text & "'")
    End Sub

    Private Sub CBFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        If CBFiltro.Text = "Consecutivo" Then
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = True
            Label18.Visible = False
            DTPFiltrarDesde.Visible = False
            Label19.Visible = False
            DTPFiltrarHasta.Visible = False
            ComboBox2.Text = ""
        ElseIf CBFiltro.Text = "Cod proveedor" Then
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = True
            Label18.Visible = False
            DTPFiltrarDesde.Visible = False
            Label19.Visible = False
            DTPFiltrarHasta.Visible = False
            ComboBox2.Text = ""
        ElseIf CBFiltro.Text = "Proveedor" Then
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = True
            Label18.Visible = False
            DTPFiltrarDesde.Visible = False
            Label19.Visible = False
            DTPFiltrarHasta.Visible = False
            ComboBox2.Text = ""
        ElseIf CBFiltro.Text = "Contado o Credito" Then
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = True
            TBbuscarConsecutivo.Visible = False
            Label18.Visible = False
            DTPFiltrarDesde.Visible = False
            Label19.Visible = False
            DTPFiltrarHasta.Visible = False
        ElseIf CBFiltro.Text = "Fecha" Then
            DTPFiltrarDesde.Value = Today
            DTPFiltrarHasta.Value = Today
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = False
            Label18.Visible = True
            DTPFiltrarDesde.Visible = True
            Label19.Visible = True
            DTPFiltrarHasta.Visible = True
        ElseIf CBFiltro.Text = "Fecha factura" Then
            DTPFiltrarDesde.Value = Today
            DTPFiltrarHasta.Value = Today
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = False
            Label18.Visible = True
            DTPFiltrarDesde.Visible = True
            Label19.Visible = True
            DTPFiltrarHasta.Visible = True
        ElseIf CBFiltro.Text = "Fecha vencimiento" Then
            DTPFiltrarDesde.Value = Today
            DTPFiltrarHasta.Value = Today
            ObtenerTablaDePagos()
            ComboBox4.Visible = False
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = False
            Label18.Visible = True
            DTPFiltrarDesde.Visible = True
            Label19.Visible = True
            DTPFiltrarHasta.Visible = True
        ElseIf CBFiltro.Text = "Saldo" Then
            ObtenerTablaDePagos()
            ComboBox4.Visible = True
            ComboBox2.Visible = False
            TBbuscarConsecutivo.Visible = False
            Label18.Visible = False
            DTPFiltrarDesde.Visible = False
            Label19.Visible = False
            DTPFiltrarHasta.Visible = False
        End If
    End Sub

    Private Function FiltrarFechaTablaDePagos()

        For i As Double = DGVCobros.Rows.Count - 1 To 0 Step -1
            If Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(1).Value).ToShortDateString()) <= DTPFiltrarDesde.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(1).Value).ToShortDateString()) >= DTPFiltrarHasta.Value.AddDays(1) Then
                DGVCobros.Rows.Remove(DGVCobros.Rows(i))
            End If
        Next

    End Function

    Private Function FiltrarFechaFacturaTablaDePagos()

        For i As Double = DGVCobros.Rows.Count - 1 To 0 Step -1
            If Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(2).Value).ToShortDateString()) <= DTPFiltrarDesde.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(2).Value).ToShortDateString()) >= DTPFiltrarHasta.Value.AddDays(1) Then
                DGVCobros.Rows.Remove(DGVCobros.Rows(i))
            End If
        Next

    End Function

    Private Function FiltrarFechaVencimientoTablaDePagos()

        For i As Double = DGVCobros.Rows.Count - 1 To 0 Step -1
            If Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(6).Value).ToShortDateString()) <= DTPFiltrarDesde.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVCobros.Rows(i).Cells(6).Value).ToShortDateString()) >= DTPFiltrarHasta.Value.AddDays(1) Then
                DGVCobros.Rows.Remove(DGVCobros.Rows(i))
            End If
        Next

    End Function

    Private Sub DTPFiltrarDesde_ValueChanged(sender As Object, e As EventArgs) Handles DTPFiltrarDesde.ValueChanged

        If CBFiltro.Text = "Fecha" Then
            If DTPFiltrarDesde.Value > Today Then
                DTPFiltrarDesde.Value = Today
            End If
            ObtenerTablaDePagos()
            FiltrarFechaTablaDePagos()
        ElseIf CBFiltro.Text = "Fecha factura" Then
            If DTPFiltrarDesde.Value > Today Then
                DTPFiltrarDesde.Value = Today
            End If
            ObtenerTablaDePagos()
            FiltrarFechaFacturaTablaDePagos()
        ElseIf CBFiltro.Text = "Fecha vencimiento" Then
            ObtenerTablaDePagos()
            FiltrarFechaVencimientoTablaDePagos()
        End If
    End Sub

    Private Sub DTPFiltrarHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTPFiltrarHasta.ValueChanged
        If CBFiltro.Text = "Fecha" Then
            If DTPFiltrarDesde.Value > Today Then
                DTPFiltrarDesde.Value = Today
            End If
            ObtenerTablaDePagos()
            FiltrarFechaTablaDePagos()
        ElseIf CBFiltro.Text = "Fecha factura" Then
            If DTPFiltrarDesde.Value > Today Then
                DTPFiltrarDesde.Value = Today
            End If
            ObtenerTablaDePagos()
            FiltrarFechaFacturaTablaDePagos()
        ElseIf CBFiltro.Text = "Fecha vencimiento" Then
            ObtenerTablaDePagos()
            FiltrarFechaVencimientoTablaDePagos()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If CBFiltro.Text = "Saldo" Then
            ObtenerTablaDePagos()
            If ComboBox4.Text = "Con saldo" Then
                For i As Double = DGVCobros.Rows.Count - 1 To 0 Step -1
                    If Trim(Convert.ToDouble(DGVCobros.Rows(i).Cells(8).Value)) = 0 Then
                        DGVCobros.Rows.Remove(DGVCobros.Rows(i))
                    End If
                Next
            ElseIf ComboBox4.Text = "Sin saldo" Then
                For i As Double = DGVCobros.Rows.Count - 1 To 0 Step -1
                    If Trim(Convert.ToDouble(DGVCobros.Rows(i).Cells(8).Value)) > 0 Then
                        DGVCobros.Rows.Remove(DGVCobros.Rows(i))
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub ButtonExportarAExcelColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        llenarExcel(DGVProductos_ingresados)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.Text = "Fecha" Or ComboBox5.Text = "Fecha factura" Then
            TextBox1.Visible = False
            Label21.Visible = True
            DateTimePicker2.Visible = True
            Label22.Visible = True
            DateTimePicker3.Visible = True
            TextBox1.Text = ""
            Lista_de_entradas()
        Else
            TextBox1.Visible = True
            Label21.Visible = False
            DateTimePicker2.Visible = False
            Label22.Visible = False
            DateTimePicker3.Visible = False
            Lista_de_entradas()
        End If

    End Sub
    Private Function TablaParaModificarCompra(busqueda As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaEntradas.Select(busqueda)
        For i As Integer = 0 To 20
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaEntradas.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 20
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds

    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Form1.FacCompras.DGVCobros.Rows.Count = 0 Then
            MessageBox.Show("No se han registrado compras para hacer una modificacion")
        Else
            TCFacturasCompra.SelectedIndex = 0
            Dim dt As New DataTable
            Dim result As DataRow() = Form1.TablaEntradas.Select("Consecutivo ='" & Form1.FacCompras.DGVCobros.CurrentRow.Cells(0).Value & "'")
            dt = TablaParaModificarCompra("Consecutivo ='" & Form1.FacCompras.DGVCobros.CurrentRow.Cells(0).Value & "'")
            Form1.FacCompras.DGVVentas.Rows.Clear()
            If result.Length > 0 Then
                Form1.FacCompras.DGVVentas.Rows.Add(dt.Rows.Count)
                TBconsecutivoCompras.Text = Trim(dt.Rows(0).Item(0).ToString) 'consecutivo
                TBNFactuta.Text = Trim(dt.Rows(0).Item(1).ToString) 'N factura
                TBCodigoProovedorVentas.Text = Trim(dt.Rows(0).Item(2).ToString) 'Cod proveedor
                CBProovedorVentas.Text = Trim(dt.Rows(0).Item(3).ToString) 'Proveedor
                TextHoy.Text = Trim(dt.Rows(0).Item(10).ToString) 'Fecha
                DTPFechaFactura.Text = Trim(dt.Rows(0).Item(11).ToString) 'Fecha factura
                DTPFechaDeCredito.Text = Trim(dt.Rows(0).Item(12).ToString) 'Fecha vencimiento
                TBDiasDeCredito.Text = Trim(dt.Rows(0).Item(13).ToString) 'Dias
                ComboBox6.Text = Trim(dt.Rows(0).Item(20).ToString) 'IVA
                TBRTF.Text = Trim(dt.Rows(0).Item(15).ToString) 'Retefuente
                TBCodigoColaboradorVentas.Text = Trim(dt.Rows(0).Item(16).ToString) 'Cod colaborador
                CBNombreColaboradorVentas.Text = Trim(dt.Rows(0).Item(17).ToString) 'Colaborador
                CBContadoOCredito.Text = Trim(dt.Rows(0).Item(18).ToString) 'Contado o credito
                datos_del_proveedor()
                For i As Double = 0 To dt.Rows.Count - 1
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(4).ToString) 'Cantidad
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(5).ToString) 'Codigo
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(6).ToString) 'Descripción
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(7).ToString) 'valor
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(14).ToString) 'Iva
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(8).ToString) 'Total
                    Form1.FacCompras.DGVVentas.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(9).ToString) 'Costo Lista de precios
                Next

            End If

        End If
    End Sub

    Private Sub Modificar_compra()

        Try
            Form1.Consultar("delete from entradas Where Consecutivo = '" & TBconsecutivoCompras.Text & "'")
            A_tabla_ingresos()
            Lista_de_entradas()
            ObtenerTablaDePagos()
        Catch ex As Exception
            MsgBox("Ocurrio un error" & ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TCFacturasCompra.SelectedIndex = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TCFacturasCompra.SelectedIndex = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TCFacturasCompra.SelectedIndex = 2
    End Sub

    Private Sub TBCodigoProovedorVentas_TextChanged(sender As Object, e As EventArgs) Handles TBCodigoProovedorVentas.TextChanged
        If TBCodigoProovedorVentas.Text = "" Then
            Label23.Visible = True
        Else
            Label23.Visible = False
        End If
    End Sub

    Private Sub TBCodigoColaboradorVentas_TextChanged(sender As Object, e As EventArgs) Handles TBCodigoColaboradorVentas.TextChanged
        If TBCodigoColaboradorVentas.Text = "" Then
            Label24.Visible = True
        Else
            Label24.Visible = False
        End If

    End Sub
    'FIN DE TAB PAGE 2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'TAB PAGE 3 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'Lo que va adentro del DGV %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Lista_de_entradas()
        Form1.FacCompras.DGVProductos_ingresados.DataSource = Form1.Lista_de_entradas
    End Sub
    'Lo que va adentro del texbox %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If ComboBox5.Text = "Consecutivo" Then
            Filtros("Consecutivo like'" & "%" + TextBox1.Text + "%" & "'")
        ElseIf ComboBox5.Text = "Cod producto" Then
            Filtros("Cod like'" & "%" + TextBox1.Text + "%" & "'") 'Filtros("select E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.Codigo like'" & "%" + TextBox1.Text + "%" & "' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
        ElseIf ComboBox5.Text = "Producto" Then
            Filtros("Descripcion like'" & "%" + TextBox1.Text + "%" & "'") 'Filtros("select E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.Descripción like'" & "%" + TextBox1.Text + "%" & "' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
        ElseIf ComboBox5.Text = "Cod proveedor" Then
            Filtros("CodProveedor like'" & "%" + TextBox1.Text + "%" & "'") 'Filtros("select E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.CodProveedor like'" & "%" + TextBox1.Text + "%" & "' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
        ElseIf ComboBox5.Text = "Proveedor" Then
            Filtros("Proveedor like'" & "%" + TextBox1.Text + "%" & "'") 'Filtros("select E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.Proveedor like'" & "%" + TextBox1.Text + "%" & "' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
        ElseIf ComboBox5.Text = "N° Factura" Then
            Filtros("NFacrura like'" & "%" + TextBox1.Text + "%" & "'") 'Filtros("select E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.NFacrura like'" & "%" + TextBox1.Text + "%" & "' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
        End If
    End Sub

    Private Sub Filtros(busqueda As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.Lista_de_entradas.Select(busqueda)
        For i As Integer = 0 To 10
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.Lista_de_entradas.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 10
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Form1.FacCompras.DGVProductos_ingresados.DataSource = ds

    End Sub
End Class