Imports System.Data.Odbc
Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Imports System.Data.SqlClient ' ES NECESARIO PARA TODO LO QUE TIENE QUE VER CON SQL SERVER
Imports System.Drawing.Printing 'Es para poder imprimir
Public Class VerificarAlistamiento
    Dim printLine As Integer = 0
    Dim Contador As Integer = 0
    Dim terminarimpresion As Boolean = True

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
    'LO QUE VA AL CARGAR EL fORMULARIO%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub VerificarAlistamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_DataCombo(DGVVerificarVenta) 'llena el campo de prodcutos del datagridview ventas.
        'Form1.verificacion_activo = True
        DGVVerificarVenta.Columns(8).Visible = False
        DGVVerificarVenta.Columns(9).Visible = False
        DGVVerificarVenta.Columns(10).Visible = False
        DGVVerificarVenta.Columns(11).Visible = False
        DGVVerificarVenta.Columns(12).Visible = False
        DGVVerificarVenta.Columns(13).Visible = False
        DGVVerificarVenta.Columns(14).Visible = False
        DGVVerificarVenta.Columns(15).Visible = False
        DGVVerificarVenta.Columns(16).Visible = True

    End Sub
    'boton de minimizar y de cerrar la ventana
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'minimiza la ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Sierra la ventana
        Form1.verificacion_activo = False
        Me.Hide()
    End Sub

    'fin de boton de minimizar y cerrar la ventana
    'FIN DE LO QUE VA AL CARGAR EL fORMULARIO%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'LO QUE VA EN LOS LISBOX, COMBOBOX, CHECKBOX Y MAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub CHBIVA_CheckedChanged(sender As Object, e As EventArgs) Handles CHBIVA.CheckedChanged
        If CHBIVA.Checked = False Then
            DGVVerificarVenta.Columns(3).Visible = True
            DGVVerificarVenta.Columns(4).Visible = True
            DGVVerificarVenta.Columns(5).Visible = False
            DGVVerificarVenta.Columns(6).Visible = False
            DGVVerificarVenta.Columns(7).Visible = False
        Else
            DGVVerificarVenta.Columns(3).Visible = False
            DGVVerificarVenta.Columns(4).Visible = False
            DGVVerificarVenta.Columns(5).Visible = True
            DGVVerificarVenta.Columns(6).Visible = True
            DGVVerificarVenta.Columns(7).Visible = True
        End If
    End Sub
    'FIN DE LO QUE VA EN LOS LISBOX, COMBOBOX, CHECKBOX Y MAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonCerrarFactura.Click
        ''Esta parte se encarga de agregar los productos dentro de la tabla de salidas
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'Fin de esta parte se encarga de agregar los productos dentro de la tabla de salidas
        Dim permitir As Boolean
        permitir = False
        For i As Integer = 0 To DGVVerificarVenta.Rows.Count - 2
            If DGVVerificarVenta.Rows.Item(i).Cells("Estado").Value = True Then
                permitir = True
            End If
        Next
        If permitir = False Then

            Try
                Try
                    For i As Integer = 0 To DGVVerificarVenta.Rows.Count - 2
                        Dim TieneIva As String
                        If CHBIVA.Checked = True Then
                            TieneIva = "T"
                        ElseIf CHBIVA.Checked = False Then
                            TieneIva = "F"
                        End If
                        Dim cadena_de_insercion As String
                        cadena_de_insercion = "('" & LNdepedidoText.Text & "',
                                                '" & LOdepedidoText.Text & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cantidad").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cod").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Descripcion").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitario").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotal").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitarioIVA").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("IVA").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotalIVA").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Costo").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("CostoTotal").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Ganancia").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Porcentaje").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Categoria").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("SubCategoria").Value) & "',
                                                '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Proveedor").Value) & "',
                                                '" & LCodCLiente.Text & "',
                                                '" & LClienteText.Text & "',
                                                '" & LCodVText.Text & "',
                                                '" & LVendedorText.Text & "',
                                                '" & LFechaOdepedidoText.Text & "',
                                                '" & LFechaEntregaText.Text & "',
                                                '" & LTipoDePagoText.Text & "',
                                                '" & Convert.ToString(Format(Date.Now, "Short Date")) & "',
                                                '" & TimeString & "',
                                                '" & TieneIva & "',
                                                '" & TimeString & "')"
                        Form1.A_tablas("salidas", cadena_de_insercion)
                    Next
                Catch ex As Exception
                    MsgBox("Ocurrio un error" & ex.Message)
                End Try
                'ESTO ES PARA AGREGAR A LA LISTA DE ABONOS Y PAGOS
                Dim saldo As String = "0"
                If LTipoDePagoText.Text = "Contado" Then
                    saldo = "0"
                ElseIf LTipoDePagoText.Text = "Credito" Then
                    saldo = TBTotalVentas.Text
                End If
                Dim cadena_de_insercion1 As String
                cadena_de_insercion1 = "('" & LNdepedidoText.Text & "',
                                         '" & Convert.ToString(Format(Date.Now, "Short Date")) & "',
                                         '" & DateTimePicker1.Text & "',
                                         '" & LCodCLiente.Text & "',
                                         '" & LClienteText.Text & "',
                                         '" & LTipoDePagoText.Text & "',
                                         '" & DateTimePicker1.Text & "',
                                         '" & TBTotalVentas.Text & "',
                                         '" & saldo & "')"
                Form1.A_tablas("abonodeventas", cadena_de_insercion1)
                Form1.Facturasdeventa.ObtenerTablaDePagosVentas()
                'esto es para cambiar el estado a CERRADO
                Dim CERRADO As String = "Cerrado"
                Form1.Consultar("update tabladeestados set Estado = '" & CERRADO & "', FechaDeEstado = '" & Convert.ToString(Format(Date.Now, "Short Date")) & "', ValorFinal = '" & TBTotalVentas.Text & "' Where NDePedido = '" & LNdepedidoText.Text & "'")
                Form1.Actualizar_de_abonos_ventas()
                Form1.Facturasdeventa.DGVEstados.DataSource = Form1.Facturasdeventa.ObtenerTablaDeEstados()

                'elimina de la lista de verificados
                Form1.Consultar("delete from verificados Where NDePedido = '" & LNdepedidoText.Text & "'")
                MsgBox("Se registro correctamente")
            Catch ex As Exception
                MsgBox("Ocurrio un error" & ex.Message)

            End Try
        Else
            MsgBox("falta por confirmar uno o mas productos")
        End If
        Actualizar_Ventas()
    End Sub

    Private Sub ButtonDeGuardarVentas_Click(sender As Object, e As EventArgs) Handles ButtonDeGuardarVentas.Click
        'Este codigo es para ingresar los pedidos en las listas de ingresados y la ListaDeIngresados
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        If LNdepedidoText.Text = "" Then
            MsgBox("Inserte un N° de pedido")
        Else
            Try
                For i As Integer = 0 To DGVVerificarVenta.Rows.Count - 2
                    Dim estado As String
                    If Convert.ToBoolean(DGVVerificarVenta.Rows.Item(i).Cells("Estado").Value) = True Then
                        estado = "T"
                    Else
                        estado = "F"
                    End If
                    Dim ConOsinIva As String
                    If CHBIVA.Checked = True Then
                        ConOsinIva = "T"
                    Else
                        ConOsinIva = "F"
                    End If
                    Dim cadena_de_insercion As String
                    cadena_de_insercion = "('" & LNdepedidoText.Text & "',
                                            '" & LOdepedidoText.Text & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cantidad").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cod").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Descripcion").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitario").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotal").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitarioIVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("IVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotalIVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Costo").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("CostoTotal").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Ganancia").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Porcentaje").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Categoria").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("SubCategoria").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Proveedor").Value) & "',
                                            '" & LCodCLiente.Text & "',
                                            '" & LClienteText.Text & "',
                                            '" & LCodVText.Text & "',
                                            '" & LVendedorText.Text & "',
                                            '" & LFechaOdepedidoText.Text & "',
                                            '" & LFechaEntregaText.Text & "',
                                            '" & LTipoDePagoText.Text & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Ubicacion").Value) & "',
                                            '" & TimeString & "',
                                            '" & estado & "',
                                            '" & ConOsinIva & "')"
                    Form1.A_tablas("verificados", cadena_de_insercion)
                Next
                Form1.Consultar("delete from Verificados Where NDePedido = '" & LNdepedidoText.Text & "'")
                'esto es para cambiar el estado a verificado
                Form1.Consultar("update TablaDeEstados set Estado = ' Verificado ', FechaDeEstado = '" & Convert.ToString(Format(Date.Now, "Short Date")) & "' Where NDePedido = '" & LNdepedidoText.Text & "'")
                Form1.Actualizar_de_abonos_ventas()
                Actualizar_Ventas()
                Form1.Facturasdeventa.DGVEstados.DataSource = Form1.Facturasdeventa.ObtenerTablaDeEstados()
                MsgBox("Se registro correctamente")
            Catch ex As Exception
                MsgBox("Ocurrio un error" & ex.Message)

            End Try

        End If
        Actualizar_Ventas()
    End Sub

    Private Sub CancelarVenta_Click(sender As Object, e As EventArgs) Handles CancelarVenta.Click
        ''este boton se encarga de mostrar el ultimo cambio que se hiso antes de guardar
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'este boton se encarga de mostrar el ultimo cambio que se hiso antes de guardar
        Dim dt As New DataTable
        dt = ObtenerTablaDeFiltroEstados("NDePedido ='" & LNdepedidoText.Text & "'")
        If Trim(dt.Rows(0).Item(6).ToString) = "Alistado" Then
            Dim dt1 As New DataTable
            dt1 = Filtrar_tabla_de_ingresados("NDePedido= '" & LNdepedidoText.Text & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(dt1.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(dt1.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(dt1.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(dt1.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(dt1.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(dt1.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(dt1.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(dt1.Rows(0).Item(17).ToString) 'Codigo del cliente
            Dim ferreteria As String
            ferreteria = Trim(Convert.ToString(dt1.Rows(0).Item(17).ToString))
            Dim dt2 As New DataTable
            dt2 = FiltrarCliente("Cod='" & ferreteria & "'")
            If dt2.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(dt2.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(dt2.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(dt2.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(dt2.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(dt2.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(dt2.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(dt2.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(dt2.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()

            If dt1.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt1.Rows.Count)
                Dim i As Integer
                i = 0
                For Each fila As DataRow In dt1.Rows()
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt1.Rows(i).Item(2).ToString) 'Cantidad
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt1.Rows(i).Item(3).ToString) 'Codigo
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt1.Rows(i).Item(4).ToString) 'Descripción
                    i = i + 1
                Next
            End If

        ElseIf Trim(dt.Rows(0).Item(6).ToString) = "Verificado" Then
            Dim dt3 As New DataTable
            dt3 = ObtenerTablaDeVerificados("NDePedido= '" & LNdepedidoText.Text & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(dt3.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(dt3.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(dt3.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(dt3.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(dt3.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(dt3.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(dt3.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(dt3.Rows(0).Item(17).ToString) 'Codigo del cliente
            'esta parte del codigo se encarga de llenar los datos según el cliente
            If Trim(dt3.Rows(0).Item(27).ToString) = "T" Then
                Form1.verificacion.CHBIVA.Checked = True
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = True
            Else
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = False
            End If
            Dim ferreteria As String
            ferreteria = Trim(Convert.ToString(dt.Rows(0).Item(17).ToString))
            Dim dt4 As New DataTable
            dt4 = FiltrarCliente("Cod='" & ferreteria & "'")
            If dt4.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(dt4.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(dt4.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(dt4.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(dt4.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(dt4.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(dt4.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(dt4.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(dt4.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()

            If dt3.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt3.Rows.Count)
                Dim i As Integer
                i = 0
                Try
                    For Each fila As DataRow In dt3.Rows()
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt3.Rows(i).Item(2).ToString) 'Cantidad
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt3.Rows(i).Item(3).ToString) 'Codigo
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt3.Rows(i).Item(4).ToString) 'Descripción
                        If Trim(dt3.Rows(i).Item(26).ToString) = "T" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = True
                        ElseIf Trim(dt3.Rows(i).Item(16).ToString) = "F" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = False
                        End If
                        i = i + 1
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
        Actualizar_Ventas()
    End Sub

    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    'LO QUE VA ADENTRO DEL DGV VERIFICAR VENTA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub DGVVerificarVenta_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVerificarVenta.CellEndEdit
        ''este codigo es para calcular las columnas de valor total, costo total, ganancia total, porcentaje, categoria y proveedor
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'este codigo es para calcular las columnas de valor total, costo total, ganancia total, porcentaje, categoria y proveedor

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim f As Double
        Dim g As Double
        Dim h As Double
        Dim i As Double
        Dim j As Double
        Dim k As Double
        Dim l As Double

        If DGVVerificarVenta.Columns(e.ColumnIndex).Name = "Cantidad" Or DGVVerificarVenta.Columns(e.ColumnIndex).Name = "Descripcion" Then
            a = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitario").Value)
            c = a * b
            d = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("Costo").Value)
            f = a * d
            g = c - f
            h = b / (1.19)
            i = h * 0.19
            j = a * h
            k = c - f
            l = (k * 100) / f

            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrTotal").Value = Format(c, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitario").Value = Format(b, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Costo").Value = Format(d, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("CostoTotal").Value = Format(f, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Ganancia").Value = Format(g, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitarioIVA").Value = Format(h, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("IVA").Value = Format(i, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrTotalIVA").Value = Format(j, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Ganancia").Value = Format(k, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Porcentaje").Value = Format(l, "##,##0.00")
        End If
        'hasta el momento lo unico que hace es calcular el valor total del unitario 

        If e.ColumnIndex = 2 Then

            If DGVVerificarVenta.Rows(e.RowIndex).Cells("Descripcion").Value IsNot Nothing Then
                Dim NomProducto As String

                NomProducto = DGVVerificarVenta.Rows(e.RowIndex).Cells("Descripcion").Value 'para encontrar el valor de lo que ponga en la descripción del producto

                Dim ds As OdbcDataReader
                Dim dt As New DataTable
                'codigo nuevo
                Dim adaptador As New OdbcCommand("select*from productos where Descripcion ='" & NomProducto & "'", Conexiondb.conexion)
                Conexiondb.conexion.Open()
                ds = adaptador.ExecuteReader
                dt.Load(ds)

                If dt.Rows.Count > 0 Then
                    'algo nuevo que intento hacer para que cuando cambie el combobox tambien cambie la parte del codigo
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(1).Value = ""
                    Dim dgvc As DataGridViewTextBoxCell
                    dgvc = DGVVerificarVenta.Rows(e.RowIndex).Cells(1)

                    dgvc.Value = Trim(dt.Rows(0).Item(0).ToString) 'Me trae el codigo del producto segun la descripción que se selecciono

                    'fin de esa cosa nueva que intento hacer

                    'este if es un intento por cambiar los precios de venta en cuanto se cambie el tipo de pago
                    If LTipoDePagoText.Text = "Distribuidor" Then
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = Trim(dt.Rows(0).Item(13).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    ElseIf LTipoDePagoText.Text = "Credito" Then
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = Trim(dt.Rows(0).Item(11).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    Else
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = Trim(dt.Rows(0).Item(9).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    End If
                    'fin del if nuevo que trato de poner

                    'Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = ds.Tables("datos").Rows(0).Item(9).ToString 'Me trae el Precio de venta del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Value = Trim(dt.Rows(0).Item(8).ToString) 'Me trae el costo del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Value = Trim(dt.Rows(0).Item(4).ToString) 'Me trae la categoria del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Value = Trim(dt.Rows(0).Item(5).ToString) 'Me trae la Sub categoria del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Value = Trim(dt.Rows(0).Item(7).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Value = Trim(dt.Rows(0).Item(15).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                End If
            End If
        End If

        'Esta parte del codigo es para que se pomga en amarillo cuando se active el checkbox
        If Convert.ToBoolean(DGVVerificarVenta.Rows(e.RowIndex).Cells("Estado").Value) = True Then
            DGVVerificarVenta.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(9).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(10).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(11).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.Yellow

        ElseIf Convert.ToBoolean(DGVVerificarVenta.Rows(e.RowIndex).Cells("Estado").Value) = False Then
            DGVVerificarVenta.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(9).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(10).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(11).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.White
        End If
        'Fin de Esta parte del codigo es para que se pomga en amarillo cuando se active el checkbox
    End Sub

    Private Sub DGVVerificarVenta_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVVerificarVenta.CellFormatting
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'para llenar los demas campos del DGV dependiendo del codigo quue le pongan
        If e.ColumnIndex = 1 Then
            If e.Value IsNot Nothing Then
                Dim codProducto As String
                codProducto = Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod='" & codProducto & "'")
                'Dim ds As OdbcDataReader
                'Dim dt As New DataTable
                ''codigo nuevo
                'Conexiondb.conexion.Close()
                'Dim adaptador As New OdbcCommand("select*from productos where Cod ='" & codProducto & "'", Conexiondb.conexion)
                'Conexiondb.conexion.Open()
                'ds = adaptador.ExecuteReader
                'dt.Load(ds)

                If result.Length > 0 Then 'dt.Rows.Count > 0 Then
                    Dim dgvcc As DataGridViewComboBoxCell
                    dgvcc = DGVVerificarVenta.Rows(e.RowIndex).Cells(2)
                    Dim Ccol As DataGridViewComboBoxColumn = CType(DGVVerificarVenta.Columns(2), DataGridViewComboBoxColumn)

                    dgvcc.Value = CStr(result(0).Item(1)) 'Trim(dt.Rows(0).Item(1).ToString) 'Me trae la descripcion del prodcto segun el codigo del producto segun el que se selecciono
                    'este if es un intento por cambiar los precios de venta en cuanto se cambie el tipo de pago
                    If LTipoDePagoText.Text = "Distribuidor" Then
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(13)) 'Trim(dt.Rows(0).Item(13).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    ElseIf LTipoDePagoText.Text = "Credito" Then
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(11)) 'Trim(dt.Rows(0).Item(11).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    Else
                        Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(9)) 'Trim(dt.Rows(0).Item(9).ToString) 'Me trae el Precio de venta del producto segun el que se selecciono
                    End If
                    'fin del if nuevo que trato de poner
                    'Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = ds.Tables("datos").Rows(0).Item(9).ToString 'Me trae el Precio de venta del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Value = CStr(result(0).Item(8)) 'Trim(dt.Rows(0).Item(8).ToString) 'Me trae el costo del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Value = CStr(result(0).Item(4)) 'Trim(dt.Rows(0).Item(4).ToString) 'Me trae la categoria del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Value = CStr(result(0).Item(5)) 'Trim(dt.Rows(0).Item(5).ToString) 'Me trae la Sub categoria del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Value = CStr(result(0).Item(7)) 'Trim(dt.Rows(0).Item(7).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Value = CStr(result(0).Item(15)) 'Trim(dt.Rows(0).Item(15).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                End If
            End If
            'esta parte del codigo trae los precios y costos, y calcula los totales de ambos  
            Dim a As Double
            Dim b As Double
            Dim c As Double
            Dim d As Double
            Dim f As Double
            Dim g As Double
            Dim h As Double
            Dim i As Double
            Dim j As Double
            Dim k As Double
            Dim l As Double

            'If DGVVentasDistri.Columns(e.ColumnIndex).Name = "Cantidad" Or DGVVentasDistri.Columns(e.ColumnIndex).Name = "Descripcion" Then
            a = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitario").Value)
            c = a * b
            d = Convert.ToDouble(DGVVerificarVenta.Rows(e.RowIndex).Cells("Costo").Value)
            f = a * d
            g = c - f
            h = b / (1.19)
            i = h * 0.19
            j = a * (h + i)
            k = c - f
            l = (k * 100) / f

            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrTotal").Value = Format(c, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitario").Value = Format(b, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Costo").Value = Format(d, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("CostoTotal").Value = Format(f, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Ganancia").Value = Format(g, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrUnitarioIVA").Value = Format(h, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("IVA").Value = Format(i, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("VrTotalIVA").Value = Format(j, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Ganancia").Value = Format(k, "##,##0.00")
            DGVVerificarVenta.Rows(e.RowIndex).Cells("Porcentaje").Value = Format(j, "##,##0.00")
            'End If
            'hasta el momento lo unico que hace es calcular el valor total del unitario
        End If

        Dim total As Double
        'Dim subtotal As Double
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVVerificarVenta.Rows
            total += Convert.ToDouble(fila.Cells("VrTotal").Value)
        Next

        TBTotalVentas.Text = Format(total, "##,##0.00")
        'total del iva
        Dim total_IVA As Double
        Dim fila_iva As DataGridViewRow = New DataGridViewRow()

        For Each fila_iva In DGVVerificarVenta.Rows
            total_IVA += Convert.ToDouble(fila_iva.Cells("Cantidad").Value) * Convert.ToDouble(fila_iva.Cells("IVA").Value)
        Next

        TBTotalIVA.Text = Format(total_IVA, "##,##0.00")

        Dim Subtotal As Double
        Dim fila_subtotal As DataGridViewRow = New DataGridViewRow()

        For Each fila_subtotal In DGVVerificarVenta.Rows
            Subtotal += Convert.ToDouble(fila_subtotal.Cells("Cantidad").Value) * Convert.ToDouble(fila_subtotal.Cells("VrUnitarioIVA").Value)
        Next

        TBTotalBruto.Text = Format(Subtotal, "##,##0.00")

        If Convert.ToBoolean(DGVVerificarVenta.Rows(e.RowIndex).Cells("Estado").Value) = True Then
            DGVVerificarVenta.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(9).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(10).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(11).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Style.BackColor = Color.Yellow
            DGVVerificarVenta.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.Yellow

        ElseIf Convert.ToBoolean(DGVVerificarVenta.Rows(e.RowIndex).Cells("Estado").Value) = False Then
            DGVVerificarVenta.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(9).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(10).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(11).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(12).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(13).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(14).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(15).Style.BackColor = Color.White
            DGVVerificarVenta.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.White
        End If
    End Sub

    'esta parte de codigo es para permitir solo el uso de numeros en las columnas de Cantidad y costo
    Private DataGridView1NumberColumns As String() = {"Cantidad", "VrUnitario", "VrTotal", "Costo", "CostoTotal", "Ganancia", "Porcentaje", "Categoria", "Proveedor"}
    Private Sub DGVVerificarVenta_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles DGVVerificarVenta.EditingControlShowing

        If DataGridView1NumberColumns.Contains(DGVVerificarVenta.Columns(DGVVerificarVenta.CurrentCell.ColumnIndex).Name) Then
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
        factura.lbNumeroPagina.Text = "0"
        If DGVVerificarVenta.CurrentCell.ColumnIndex = 0 Then
            If IsNumeric(e.KeyChar.ToString()) _
            Or e.KeyChar = ChrW(Keys.Back) _
            Or e.KeyChar = "," Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

        If DGVVerificarVenta.CurrentCell.ColumnIndex = 3 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 4 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 5 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 6 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 7 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 9 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 10 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 11 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 12 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 13 Or DGVVerificarVenta.CurrentCell.ColumnIndex = 14 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        terminarimpresion = True
        printLine = 0
        Contador = 0
        factura.lbNumeroPagina.Text = "0"
        LlenarConsulta()
        PrintDialog1.Document = PrintDocument1

        'Te deja elegir la impresora
        '----------------------------------------------------------------------
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If

        'Te deja ver un preview del reporte antes de imprimir
        '-----------------------------------------------------------------------
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        'PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Cualquier variable que desees que conserve su valor debes declararla fuera del Printdocument
        'Todas las variable declaradas dentro de printdocument pierden su valor al cambiar de pagina

        'Definimos los tipos de letras a utilizar en el reporte
        '--------------------------------------------------------------------------------------------------------------------
        Dim FuenteTitulo As New Font("Microsoft Arial Rounded MT Bold", 22, FontStyle.Italic)
        Dim FuenteTitulo2 As New Font("Microsoft Arial Rounded MT Bold", 22, FontStyle.Bold)
        Dim FuenteSubtitulo As New Font("Microsoft Sans Serif", 16)
        Dim FuenteNegrita As New Font("Microsoft Calibri", 10, FontStyle.Bold)
        Dim FuenteDetalles As New Font("Microsoft Calibri", 10)
        Dim Fuenteaviso As New Font("Microsoft Calibri", 8, FontStyle.Bold)
        Dim FechadeHoy As String = Format(DateTime.Now, “dd/MM/yyyy”)
        'Dim EstaAnulado As Boolean
        'Imprimimos el encabezado junto con el logo y los datos de la factura antes del datagridview
        '----------------------------------------------------------------------------------------------------------------------
        e.Graphics.DrawString(factura.Enviar_a.Text, FuenteNegrita, Brushes.DarkBlue, factura.Enviar_a.Left, factura.Enviar_a.Top)
        e.Graphics.DrawString(factura.Correo.Text, FuenteNegrita, Brushes.DarkBlue, factura.Correo.Left, factura.Correo.Top)
        e.Graphics.DrawString(factura.Vendedor.Text, FuenteNegrita, Brushes.DarkBlue, factura.Vendedor.Left, factura.Vendedor.Top)
        e.Graphics.DrawString(factura.N_Pedido.Text, FuenteNegrita, Brushes.DarkBlue, factura.N_Pedido.Left, factura.N_Pedido.Top)
        e.Graphics.DrawString(factura.Fecha_remision.Text, FuenteNegrita, Brushes.DarkBlue, factura.Fecha_remision.Left, factura.Fecha_remision.Top)
        e.Graphics.DrawString(factura.Tipo_de_pago.Text, FuenteNegrita, Brushes.DarkBlue, factura.Tipo_de_pago.Left, factura.Tipo_de_pago.Top)
        e.Graphics.DrawString(factura.Facturar_a.Text, FuenteNegrita, Brushes.DarkBlue, factura.Facturar_a.Left, factura.Facturar_a.Top)
        e.Graphics.DrawString(factura.Direccion.Text, FuenteNegrita, Brushes.DarkBlue, factura.Direccion.Left, factura.Direccion.Top)
        e.Graphics.DrawString(factura.Telefono.Text, FuenteNegrita, Brushes.DarkBlue, factura.Telefono.Left, factura.Telefono.Top)
        e.Graphics.DrawString(factura.Barrio.Text, FuenteNegrita, Brushes.DarkBlue, factura.Barrio.Left, factura.Barrio.Top)
        e.Graphics.DrawString(factura.Nit_Cliente.Text, FuenteNegrita, Brushes.DarkBlue, factura.Nit_Cliente.Left, factura.Nit_Cliente.Top)
        Dim newImage As Image = factura.PictureBox1.Image : e.Graphics.DrawImage(newImage, factura.PictureBox1.Left, factura.PictureBox1.Top, factura.PictureBox1.Width, factura.PictureBox1.Height)
        Dim newImages As Image = factura.PictureBox2.Image : e.Graphics.DrawImage(newImages, factura.PictureBox2.Left, factura.PictureBox2.Top, factura.PictureBox2.Width, factura.PictureBox2.Height)
        Dim newImageQR As Image = factura.PictureBox4.Image : e.Graphics.DrawImage(newImageQR, factura.PictureBox4.Left, factura.punto1.Top + 614 + 4 * factura.punto1.Height, factura.PictureBox4.Width, factura.PictureBox4.Height)
        If FacturasDeVentas.EstaAnulado = True Then
            Dim newImageAnulado As Image = factura.PictureBox5.Image : e.Graphics.DrawImage(newImageAnulado, factura.PictureBox5.Left, factura.PictureBox5.Top, factura.PictureBox5.Width, factura.PictureBox5.Height)
        End If
        e.Graphics.DrawString(factura.Titulo_remision.Text, FuenteTitulo, Brushes.DarkBlue, factura.Titulo_remision.Left, factura.Titulo_remision.Top)
        e.Graphics.DrawString(LNdepedidoText.Text, FuenteTitulo2, Brushes.Black, factura.Titulo_remision_text.Left, factura.Titulo_remision_text.Top)

        e.Graphics.DrawString(LEnviarAText.Text, FuenteDetalles, Brushes.Black, factura.Enviar_a_text.Left, factura.Enviar_a_text.Top)
        e.Graphics.DrawString(LEmailText.Text, FuenteDetalles, Brushes.Black, factura.Correo_text.Left, factura.Correo_text.Top)
        e.Graphics.DrawString(LVendedorText.Text, FuenteDetalles, Brushes.Black, factura.Vendedor_text.Left, factura.Vendedor_text.Top)
        e.Graphics.DrawString(LOdepedidoText.Text, FuenteDetalles, Brushes.Black, factura.N_pedido_text.Left, factura.N_pedido_text.Top)
        e.Graphics.DrawString(FechadeHoy.ToString, FuenteDetalles, Brushes.Black, factura.fecha_remision_text.Left, factura.fecha_remision_text.Top)
        e.Graphics.DrawString(LTipoDePagoText.Text, FuenteDetalles, Brushes.Black, factura.Tipo_de_pago_text.Left, factura.Tipo_de_pago_text.Top)
        e.Graphics.DrawString(LClienteText.Text, FuenteDetalles, Brushes.Black, factura.Facturar_a_text.Left, factura.Facturar_a_text.Top)
        e.Graphics.DrawString(LDireccionText.Text, FuenteDetalles, Brushes.Black, factura.Direccion_text.Left, factura.Direccion_text.Top)
        e.Graphics.DrawString(LTelefonoText.Text, FuenteDetalles, Brushes.Black, factura.telefono_text.Left, factura.telefono_text.Top)
        e.Graphics.DrawString(LBarrioText.Text, FuenteDetalles, Brushes.Black, factura.barrio_text.Left, factura.barrio_text.Top)
        e.Graphics.DrawString(LNitText.Text, FuenteDetalles, Brushes.Black, factura.nit_cliente_text.Left, factura.nit_cliente_text.Top)

        'cuadro de fondo azul para los titulos del encavezado de la tabla
        Dim AnchoCuadrado As Integer = factura.punto6.Left - factura.punto1.Left
        Dim LargoDelCuadrado As Integer = factura.punto1.Height + 4
        Dim coordenadaCuadrado As Integer = factura.punto1.Top + factura.punto1.Height

        Dim blueBrush As New SolidBrush(Color.DarkBlue)
        Dim rect As New Rectangle(factura.punto1.Left, factura.punto1.Top, AnchoCuadrado, LargoDelCuadrado)
        e.Graphics.FillRectangle(blueBrush, rect)
        'texto de encavezado de la tabla
        '--------------------------------------------------------------------------------------------------
        If CHBIVA.Checked = True Then
            e.Graphics.DrawString("Cantidad", FuenteNegrita, Brushes.White, factura.punto1.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Codigo", FuenteNegrita, Brushes.White, factura.punto9.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Descripción", FuenteNegrita, Brushes.White, factura.punto10.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Vr.Unitario", FuenteNegrita, Brushes.White, factura.punto11.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("IVA", FuenteNegrita, Brushes.White, factura.punto12.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Vr.Total", FuenteNegrita, Brushes.White, factura.punto13.Left, factura.punto1.Top + 1)
        Else
            e.Graphics.DrawString("Cantidad", FuenteNegrita, Brushes.White, factura.punto1.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Codigo", FuenteNegrita, Brushes.White, factura.punto2.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Descripción", FuenteNegrita, Brushes.White, factura.punto3.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Vr.Unitario", FuenteNegrita, Brushes.White, factura.punto4.Left, factura.punto1.Top + 1)
            e.Graphics.DrawString("Vr.Total", FuenteNegrita, Brushes.White, factura.punto5.Left, factura.punto1.Top + 1)
        End If

        Contador += 1
        'Esta parte siempre va a salir en todas las paginas
        '---------------------------------------------------------------------------------------------
        'factura.lbNumeroPagina.Text = CInt(factura.lbNumeroPagina.Text) + 1
        e.Graphics.DrawString(factura.Pagina.Text, FuenteDetalles, Brushes.DarkBlue, factura.Pagina.Left, e.MarginBounds.Bottom)
        e.Graphics.DrawString(Contador, FuenteNegrita, Brushes.DarkBlue, factura.lbNumeroPagina.Left, e.MarginBounds.Bottom)
        'cuadro que hace el contorno a las especificaciones de la factura
        '__________________________________________________________________________________________________
        Dim rectF1 As New RectangleF(factura.punto1.Left, factura.punto1.Top, AnchoCuadrado, 610)
        e.Graphics.DrawRectangle(Pens.DarkBlue, Rectangle.Round(rectF1))
        'cuadro que hace el contorno del subtotal
        '__________________________________________________________________________________________________
        Dim SubtotalPosicion As Integer = factura.punto1.Top + 610
        Dim IVAPosicion As Integer = factura.punto1.Top + 610 + LargoDelCuadrado
        Dim TotalPosicion As Integer = factura.punto1.Top + 610 + 2 * LargoDelCuadrado
        Dim AnchoCuadrado2 As Integer = factura.punto6.Left - factura.punto4.Left

        Dim rect2 As New Rectangle(factura.punto4.Left, SubtotalPosicion, AnchoCuadrado2, LargoDelCuadrado)
        e.Graphics.FillRectangle(blueBrush, rect2)
        e.Graphics.DrawString("Total bruto:", FuenteNegrita, Brushes.White, factura.punto4.Left, SubtotalPosicion)
        e.Graphics.DrawString("$ " & TBTotalBruto.Text, FuenteNegrita, Brushes.White, factura.punto5.Left, SubtotalPosicion)
        'cuadro que hace el contorno del IVA
        '__________________________________________________________________________________________________
        If CHBIVA.Checked = True Then
            Dim rect3 As New Rectangle(factura.punto4.Left, IVAPosicion, AnchoCuadrado2, LargoDelCuadrado)
            e.Graphics.FillRectangle(blueBrush, rect3)
            e.Graphics.DrawString("IVA:", FuenteNegrita, Brushes.White, factura.punto4.Left, IVAPosicion)
            e.Graphics.DrawString("$ " & TBTotalIVA.Text, FuenteNegrita, Brushes.White, factura.punto5.Left, IVAPosicion)
            e.Graphics.DrawString("*Factura electronica se enviara por correo electronico", Fuenteaviso, Brushes.Black, factura.punto4.Left - 88, TotalPosicion + 3 * LargoDelCuadrado)
        End If
        'cuadro que hace el contorno del total
        '__________________________________________________________________________________________________
        Dim rect4 As New Rectangle(factura.punto4.Left, TotalPosicion, AnchoCuadrado2, LargoDelCuadrado)
        e.Graphics.FillRectangle(blueBrush, rect4)
        e.Graphics.DrawString("Total neto:", FuenteNegrita, Brushes.White, factura.punto4.Left, TotalPosicion)
        e.Graphics.DrawString("$ " & TBTotalVentas.Text, FuenteNegrita, Brushes.White, factura.punto5.Left, TotalPosicion)
        e.Graphics.DrawString("*No es una factura de venta, documento para confirmación de despacho", Fuenteaviso, Brushes.Black, factura.punto4.Left - 185, TotalPosicion + 2 * LargoDelCuadrado)
        'Aceptado firma y sello
        '__________________________________________________________________________________________________
        e.Graphics.DrawString("Aceptado:", FuenteNegrita, Brushes.Black, factura.punto1.Left, IVAPosicion)
        e.Graphics.DrawString("___________________________________", FuenteNegrita, Brushes.Black, factura.punto2.Left, IVAPosicion)
        e.Graphics.DrawString("Firma y sello", FuenteNegrita, Brushes.Black, factura.punto2.Left, TotalPosicion)

        'imagen de fondo
        '__________________________________________________________________________________________________

        'Imprimimos los detalles del reporte, es decir el listado de materias
        '-----------------------------------------------------------------------------------------------------------------------------
        Dim startX As Integer = factura.punto1.Left 'Tomamos la posicion horinzontal de la letra 'Punto1'
        Dim startY As Integer = factura.punto7.Top 'Tomamos la posicion vertical de la letra 'Punto1'
        Dim subtotal As Double = 0
        Dim itemDeFactura As Double = 0

        Do While startY + factura.punto1.Height < SubtotalPosicion
            'printLine < factura.DataGridView1.Rows.Count() - 2
            'startY +factura.punto1.Height >= SubtotalPosicion
            If printLine > factura.DataGridView1.Rows.Count() - 1 Then 'e.MarginBounds.Bottom Then
                'Esta parte se activa solo si 'startY' que es la posicion vertical almacenada supera el borde inferior de la pagina
                'Este se reinicia con cada pagina necesitada
                'MsgBox("la posicion es " & startY + factura.punto1.Height & "la posicion es " & SubtotalPosicion)

                subtotal = 0
                'e.HasMorePages = True

                'Exit Do
                Exit Sub
            ElseIf startY + factura.punto1.Height <= SubtotalPosicion Then
                'e.HasMorePages = False
                'MsgBox("la lenea es " & printLine)
            End If

            If CHBIVA.Checked = True Then
                'MsgBox(printLine)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Cantidad").Value), FuenteDetalles, Brushes.Black, factura.punto1.Left + 8, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Cod").Value), FuenteDetalles, Brushes.Black, factura.punto9.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Descripcion").Value), FuenteDetalles, Brushes.Black, factura.punto10.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("VrUnitarioIVA").Value), FuenteDetalles, Brushes.Black, factura.punto11.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("IVA").Value), FuenteDetalles, Brushes.Black, factura.punto12.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("VrTotal").Value), FuenteDetalles, Brushes.Black, factura.punto13.Left, startY)
            Else
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Cantidad").Value), FuenteDetalles, Brushes.Black, factura.punto1.Left + 8, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Cod").Value), FuenteDetalles, Brushes.Black, factura.punto2.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("Descripcion").Value), FuenteDetalles, Brushes.Black, factura.punto3.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("VrUnitario").Value), FuenteDetalles, Brushes.Black, factura.punto4.Left, startY)
                e.Graphics.DrawString(Convert.ToString(Me.DGVVerificarVenta.Rows(printLine).Cells("VrTotal").Value), FuenteDetalles, Brushes.Black, factura.punto5.Left, startY)
            End If

            subtotal += Convert.ToDouble(Me.DGVVerificarVenta.Rows(printLine).Cells("VrTotal").Value)

            'Aqui estoy usando un tipo de letras mas grande 'LabelCodigo' mas grande que 'Punto1' para crear mas espacio entre filas
            '----------------------------------------------------------------------------------
            startY += factura.punto1.Height

            'Contador += 1
            itemDeFactura += 1
            printLine += 1
        Loop



        If printLine <= factura.DataGridView1.Rows.Count() - 1 Then
            e.HasMorePages = True
            startY = factura.punto7.Top
        Else
            e.HasMorePages = False
            printLine = 0
        End If

        'Dim subtotalText As String
        'subtotalText = Format(subtotal, "##,##0.00")
        'e.Graphics.DrawString("$ " & subtotalText, FuenteNegrita, Brushes.White, factura.punto5.Left, SubtotalPosicion)
        'Si deseamos poner un contador de páginas

    End Sub

    Private Sub LlenarConsulta()
        Dim i As Integer
        i = 1
        Do While i < Me.DGVVerificarVenta.Rows.Count - 1
            factura.DataGridView1.Rows.Add()
            i += 1
        Loop

    End Sub

    Private Sub ButtonAnular_Click(sender As Object, e As EventArgs) Handles ButtonAnular.Click
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'Este codigo es para ingresar los pedidos en las listas de ingresados y la ListaDeIngresados
        If LNdepedidoText.Text = "" Then
            MsgBox("Incerte un N° de pedido")
        Else
            'fin del codigo nuevo este codigo evita que pongan el mismo codigo para dos Proovedores distintos
            Dim fila As DataGridViewRow = New DataGridViewRow()
            'esta parte elimina lo que se registro en la tabla de verificados con el numero de pedido anterior
            Form1.Consultar("delete from verificados Where NDePedido = '" & LNdepedidoText.Text & "'")
            'esta parte elimina lo que se registro en la tabla de alistados con el numero de pedido anterior
            Form1.Consultar("delete from alistados Where NPedido = '" & LNdepedidoText.Text & "'")

            Try

                For i As Integer = 0 To DGVVerificarVenta.Rows.Count - 2
                    Dim cadena_de_insercion As String
                    Dim estado As String
                    Dim conIva As String
                    If CHBIVA.Checked = True Then
                        conIva = "T" 'agregarAnulados.Parameters.AddWithValue("@ConOSinIVA", "T")
                    Else
                        conIva = "F" 'agregarAnulados.Parameters.AddWithValue("@ConOSinIVA", "F")
                    End If
                    If Convert.ToBoolean(DGVVerificarVenta.Rows.Item(i).Cells("Estado").Value) = True Then
                        estado = "T"
                    Else
                        estado = "F"
                    End If
                    cadena_de_insercion = "('" & LNdepedidoText.Text & "',
                                            '" & LOdepedidoText.Text & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cantidad").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Cod").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Descripcion").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitario").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotal").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrUnitarioIVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("IVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("VrTotalIVA").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Costo").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("CostoTotal").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Ganancia").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Porcentaje").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Categoria").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("SubCategoria").Value) & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Proveedor").Value) & "',
                                            '" & LCodCLiente.Text & "',
                                            '" & LClienteText.Text & "',
                                            '" & LCodVText.Text & "',
                                            '" & LVendedorText.Text & "',
                                            '" & LFechaOdepedidoText.Text & "',
                                            '" & LFechaEntregaText.Text & "',
                                            '" & LTipoDePagoText.Text & "',
                                            '" & Convert.ToString(DGVVerificarVenta.Rows.Item(i).Cells("Ubicacion").Value) & "',
                                            '" & TimeString & "',
                                            '" & estado & "',
                                            '" & conIva & "')"
                    Form1.A_tablas("anulados", cadena_de_insercion)
                Next

                'esto es para cambiar el estado a verificado
                Form1.Consultar("update tabladeestados set Estado = '" & "Anulado" & "', FechaDeEstado = '" & Convert.ToString(Format(Date.Now, "Short Date")) & "' Where NDePedido = '" & LNdepedidoText.Text & "'")
                Form1.Actualizar_Tabla_ingresados()
                Form1.Facturasdeventa.DGVEstados.DataSource = Form1.Facturasdeventa.ObtenerTablaDeEstados()
                'fin de para cambiar el estado a verificado
                Actualizar_Ventas()
                MsgBox("Se registro correctamente")
            Catch ex As Exception
                MsgBox("Ocurrio un error" & ex.Message)

            End Try

        End If
    End Sub

    'Fin del codigo para permitir que solo ingresen numeros al DGV en las columnas de Cantidad y costo
    'Private Sub dataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)

    '    ComboBox box = e.Control as ComboBox;
    '  If IsDBNull(box) Then
    '        box.DropDownStyle = ComboBoxStyle.DropDown;
    '        box.AutoCompleteSource = AutoCompleteSource.ListItems;
    '        box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
    '  End If

    'End Sub

    'FIN DE LO QUE VA ADENTRO DEL DGV VERIFICAR VENTA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

End Class