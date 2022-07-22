Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FacturasDeVentas
    Public EstaAnulado As Boolean = False
    Private Sub FacturasDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_DataCombo(DGVVentasDistri) 'llena el campo de prodcutos del datagridview ventas.
        llenarComboBoxVendedor(CBVendedor)
        llenarComboBoxClientes(CBVentasClientes)
        ObtenerTablaDeEstados()
        ObtenerTablaDePagosVentas()
        ComboBox5.Text = "Contado"
        'para obrener la lista de ingresados en el datagridview sin la ultima fila que es siempre vacia
        DGVVentasIngresados.DataSource = ObtenerIngresados()
        DGVVentasIngresados.AllowUserToAddRows = False
        'fin
        DGVVentasAlistar.AllowUserToAddRows = False
        CBVentasTipodepago.Text = "Contado"
        DGVVentasDistri.Columns(5).Visible = False
        DGVVentasDistri.Columns(6).Visible = False
        DGVVentasDistri.Columns(7).Visible = False
        DGVVentasDistri.Columns(12).Visible = False
        DGVVentasDistri.Columns(13).Visible = False
        DGVVentasDistri.Columns(14).Visible = False
        DGVVentasDistri.Columns(15).Visible = False
        Completo()

        Label23.Visible = False
        DTP_Desde.Visible = False
        Label24.Visible = False
        DTP_Hasta.Visible = False
        Label25.Visible = False
        ComboBox2.Visible = False
        Label26.Visible = False
        ComboBox3.Visible = False
        Label27.Visible = False
        ComboBox4.Visible = False

        TextBox3.Visible = True
        Label33.Visible = False
        DTPdesdeAbono.Visible = False
        Label34.Visible = False
        DTPHastaAbono.Visible = False
        Label35.Visible = False
        ComboBox7.Visible = False
        Label36.Visible = False
        ComboBox8.Visible = False
        TBVentasNPedido.Text = Consecutivos()
    End Sub

    Private Function Consecutivos()
        Dim dt As New DataTable
        Dim Ncompra As Double
        dt = Form1.Tablas("SELECT * from consecutivos")
        Ncompra = dt.Rows(0).Item(1).ToString
        Return Ncompra
    End Function
    'LO QUE VA EN EL TABPAGE 1 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

    'Solo lo que va afuera del Data grid view de ventas%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub CBVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBVendedor.SelectedIndexChanged
        'Este codigo llena el texbox del codigo del cliene con el codigo correspondiente al que seleccionaron en el combobox
        If CBVendedor.Text = "" Then
            MsgBox("Inserte un vendedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Nombre='" & CBVendedor.Text & "'")
            If result.Length > 0 Then
                TBCodVendedor.Text = CStr(result(0).Item(0)) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El vendedor no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub
    Private Sub TBCodVendedor_Leave(sender As Object, e As EventArgs) Handles TBCodVendedor.Leave
        'Este codigo pone en el combo box el nombre del vendedor segun el codigo que coloquen
        If TBCodVendedor.Text = "" Then
            MsgBox("Inserte un vendedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaColaboradores.Select("Cod='" & TBCodVendedor.Text & "'")
            If result.Length > 0 Then
                CBVendedor.Text = CStr(result(0).Item(1)) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El vendedor no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub

    Private Sub TBVentasCodCLiente_Leave(sender As Object, e As EventArgs) Handles TBVentasCodCLiente.Leave
        'Este codigo pone en el combo box el nombre del cliente segun el codigo que coloquen y llena los demas con respecto a este
        If TBVentasCodCLiente.Text = "" Then
            MsgBox("Inserte un cliente") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaClientes.Select("Cod='" & TBVentasCodCLiente.Text & "'")
            If result.Length > 0 Then
                TBVentasNit.Text = CStr(result(0).Item(1)) 'selecciona el nit segun el criterio del codigo del cliente
                CBVentasClientes.Text = CStr(result(0).Item(2)) 'selecciona el cliente segun el criterio del codigo del cliente
                TBVentasEnviara.Text = CStr(result(0).Item(3)) 'selecciona el enviar a segun el criterio del codigo del cliente
                TBVentasTelefono.Text = CStr(result(0).Item(4)) 'selecciona el telefono segun el criterio del codigo del cliente
                TBVentasCel.Text = CStr(result(0).Item(5)) 'selecciona el celular segun el criterio del codigo del cliente
                TBVentasEmail.Text = CStr(result(0).Item(6)) 'selecciona el email segun el criterio del codigo del cliente
                TBVentasDireccion.Text = CStr(result(0).Item(7)) 'selecciona la direccion segun el criterio del codigo del cliente
                TBVentasBarrio.Text = CStr(result(0).Item(8)) 'selecciona el barrio segun el criterio del codigo del cliente
                CBVendedor.Text = CStr(result(0).Item(10)) 'selecciona el vendedor segun el criterio del codigo del cliente
                TBCodVendedor.Text = CStr(result(0).Item(11)) 'selecciona el codigo del vendedor segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub

    Private Sub CBVentasClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBVentasClientes.SelectedIndexChanged
        'Este codigo pone en el combo box el nombre del vendedor segun el codigo que coloquen y llena los demas campos segun la informacion de ese cliente
        If CBVentasClientes.Text = "" Then
            MsgBox("Inserte un cliente") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaClientes.Select("Ferreteria='" & CBVentasClientes.Text & "'")
            If result.Length > 0 Then
                TBVentasNit.Text = CStr(result(0).Item(1)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasCodCLiente.Text = CStr(result(0).Item(0)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasEnviara.Text = CStr(result(0).Item(3)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasTelefono.Text = CStr(result(0).Item(4)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasCel.Text = CStr(result(0).Item(5)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasEmail.Text = CStr(result(0).Item(6)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasDireccion.Text = CStr(result(0).Item(7)) 'selecciona los datos segun el criterio del codigo del cliente
                TBVentasBarrio.Text = CStr(result(0).Item(8)) 'selecciona los datos segun el criterio del codigo del cliente
                CBVendedor.Text = CStr(result(0).Item(10)) 'selecciona el vendedor segun el criterio del codigo del cliente
                TBCodVendedor.Text = CStr(result(0).Item(11)) 'selecciona el codigo del vendedor segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
        End If
    End Sub

    'Fin de solo lo que va afuera del Data grid view de ventas%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'Lo que va adentro del DGV de ventas.%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub DGVVentasDistri_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVentasDistri.CellEndEdit
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

        If DGVVentasDistri.Columns(e.ColumnIndex).Name = "Cantidad" Or DGVVentasDistri.Columns(e.ColumnIndex).Name = "Descripcion" Then
            a = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitario").Value)
            c = a * b
            d = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("Costo").Value)
            f = a * d
            g = c - f
            h = b / (1.19)
            i = h * 0.19
            j = a * h
            k = c - f
            l = (k * 100) / f

            DGVVentasDistri.Rows(e.RowIndex).Cells("VrTotal").Value = Format(c, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitario").Value = Format(b, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Costo").Value = Format(d, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("CostoTotal").Value = Format(f, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Ganancia").Value = Format(g, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitarioIVA").Value = Format(h, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("IVA").Value = Format(i, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrTotalIVA").Value = Format(j, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Ganancia").Value = Format(k, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Porcentaje").Value = Math.Round(l, 2)
        End If
        'hasta el momento lo unico que hace es calcular el valor total del unitario 

        If e.ColumnIndex = 2 Then

            If DGVVentasDistri.Rows(e.RowIndex).Cells("Descripcion").Value IsNot Nothing Then
                Dim NomProducto As String = DGVVentasDistri.Rows(e.RowIndex).Cells("Descripcion").Value 'para encontrar el valor de lo que ponga en la descripción del producto
                Dim result As DataRow() = Form1.TablaDeProductos.Select("Descripcion ='" & NomProducto & "'")
                If result.Length > 0 Then
                    'algo nuevo que intento hacer para que cuando cambie el combobox tambien cambie la parte del codigo
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(1).Value = ""
                    Dim dgvc As DataGridViewTextBoxCell
                    dgvc = DGVVentasDistri.Rows(e.RowIndex).Cells(1)
                    dgvc.Value = CStr(result(0).Item(0)) 'Me trae el codigo del producto segun la descripción que se selecciono
                    'este if es un intento por cambiar los precios de venta en cuanto se cambie el tipo de pago
                    If CBVentasTipodepago.Text = "Distribuidor" Then
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(13)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    ElseIf CBVentasTipodepago.Text = "Credito" Then
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(11)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    Else
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(result(0).Item(9)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    End If
                    'Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = ds.Tables("datos").Rows(0).Item(9).ToString 'Me trae el Precio de venta del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(8).Value = CStr(result(0).Item(8)) 'Me trae el costo del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(12).Value = CStr(result(0).Item(4)) 'Me trae la categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(13).Value = CStr(result(0).Item(5)) 'Me trae la Sub categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(14).Value = CStr(result(0).Item(7)) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(15).Value = CStr(result(0).Item(15)) 'Trim(dt.Rows(0).Item(15).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                End If
            End If
        End If

        If e.ColumnIndex = 1 Then

            If DGVVentasDistri.Rows(e.RowIndex).Cells("Cod").Value IsNot Nothing Then
                Dim NomProducto As String = DGVVentasDistri.Rows(e.RowIndex).Cells("Cod").Value 'para encontrar el valor de lo que ponga en la descripción del producto
                Dim Result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & NomProducto & "'")
                If Result.Length > 0 Then
                    'algo nuevo que intento hacer para que cuando cambie el combobox tambien cambie la parte del codigo
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(2).Value = ""
                    Dim dgvc As DataGridViewComboBoxCell
                    dgvc = DGVVentasDistri.Rows(e.RowIndex).Cells(2)
                    dgvc.Value = CStr(Result(0).Item(1)) 'Me trae la descripcion del producto segun la descripción que se selecciono
                    'este if es un intento por cambiar los precios de venta en cuanto se cambie el tipo de pago
                    If CBVentasTipodepago.Text = "Distribuidor" Then
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(Result(0).Item(13)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    ElseIf CBVentasTipodepago.Text = "Credito" Then
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(Result(0).Item(11)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    Else
                        Me.DGVVentasDistri.Rows(e.RowIndex).Cells(3).Value = CStr(Result(0).Item(9)) 'Me trae el Precio de venta del producto segun el que se selecciono
                    End If

                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(8).Value = CStr(Result(0).Item(8)) 'Me trae el costo del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(12).Value = CStr(Result(0).Item(4)) 'Me trae la categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(13).Value = CStr(Result(0).Item(5)) 'Me trae la Sub categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(14).Value = CStr(Result(0).Item(7)) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(15).Value = CStr(Result(0).Item(15)) 'Me trae el proveedor del producto segun el que se selecciono
                End If
            End If
        End If
    End Sub

    Private Sub DGVVentasDistri_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVVentasDistri.CellFormatting
        'para llenar los demas campos del DGV dependiendo del codigo quue le pongan
        If e.ColumnIndex = 1 Then
            If e.Value IsNot Nothing Then
                Dim codProducto As String = Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & codProducto & "'")
                If result.Length > 0 Then
                    Dim dgvcc As DataGridViewComboBoxCell
                    dgvcc = DGVVentasDistri.Rows(e.RowIndex).Cells(2)
                    Dim Ccol As DataGridViewComboBoxColumn = CType(DGVVentasDistri.Columns(2), DataGridViewComboBoxColumn)
                    dgvcc.Value = CStr(result(0).Item(1)) 'Trim(dt.Rows(0).Item(1).ToString) 'Me trae la descripcion del prodcto segun el codigo del producto segun el que se selecciono

                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(12).Value = CStr(result(0).Item(4)) 'Trim(dt.Rows(0).Item(4).ToString) 'Me trae la categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(13).Value = CStr(result(0).Item(5)) 'Trim(dt.Rows(0).Item(5).ToString) 'Me trae la Sub categoria del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(14).Value = CStr(result(0).Item(7)) 'Trim(dt.Rows(0).Item(7).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(15).Value = CStr(result(0).Item(15)) 'Trim(dt.Rows(0).Item(15).ToString) 'Me trae el proveedor del producto segun el que se selecciono
                    Me.DGVVentasDistri.Rows(e.RowIndex).Cells(16).Value = producto_disponible(codProducto)
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
            Dim porcentaje_ganancia As Double

            'If DGVVentasDistri.Columns(e.ColumnIndex).Name = "Cantidad" Or DGVVentasDistri.Columns(e.ColumnIndex).Name = "Descripcion" Then
            a = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("Cantidad").Value)
            b = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitario").Value)
            c = a * b
            d = Convert.ToDouble(DGVVentasDistri.Rows(e.RowIndex).Cells("Costo").Value)
            f = a * d
            g = c - f
            h = b / (1.19)
            i = h * 0.19
            j = a * (h + i)
            k = c - f
            l = (k * 100) / f
            porcentaje_ganancia = Math.Round(l, 2)

            DGVVentasDistri.Rows(e.RowIndex).Cells("VrTotal").Value = Format(c, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitario").Value = Format(b, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Costo").Value = Format(d, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("CostoTotal").Value = Format(f, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Ganancia").Value = Format(g, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrUnitarioIVA").Value = Format(h, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("IVA").Value = Format(i, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("VrTotalIVA").Value = Format(j, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Ganancia").Value = Format(k, "##,##0.00")
            DGVVentasDistri.Rows(e.RowIndex).Cells("Porcentaje").Value = porcentaje_ganancia
            'End If
            'hasta el momento lo unico que hace es calcular el valor total del unitario

        End If

        Dim total As Double
        Dim total_iva As Double
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVVentasDistri.Rows
            total += Convert.ToDouble(fila.Cells("VrTotal").Value)
            total_iva += Convert.ToDouble(fila.Cells("IVA").Value) * Convert.ToDouble(fila.Cells("Cantidad").Value)
        Next

        TBTotalVentas.Text = Format(total, "##,##0.00")
        TextBox1.Text = Format(total_iva, "##,##0.00")

        Dim pal_disponible As Double
        Dim lo_ordenado As Double
        If Trim(Convert.ToString(DGVVentasDistri.Rows(e.RowIndex).Cells(16).Value)) = "" Then
            pal_disponible = 0
        Else
            pal_disponible = Convert.ToDouble(Trim(DGVVentasDistri.Rows(e.RowIndex).Cells(16).Value))
        End If

        If Trim(Convert.ToString(DGVVentasDistri.Rows(e.RowIndex).Cells(0).Value)) = "" Then
            lo_ordenado = 0
        Else
            lo_ordenado = Convert.ToDouble(Trim(DGVVentasDistri.Rows(e.RowIndex).Cells(0).Value))
        End If


        If CheckBox1.Checked = False And pal_disponible - lo_ordenado < 0 Then
            DGVVentasDistri.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.Red
            'e.ColumnIndex(16).CellStyle.BackColor = Color.Red
        Else
            DGVVentasDistri.Rows(e.RowIndex).Cells(16).Style.BackColor = Color.White
        End If
    End Sub

    'esta parte de codigo es para permitir solo el uso de numeros en las columnas de Cantidad y costo
    Private DataGridView1NumberColumns As String() = {"Cantidad", "VrUnitario", "VrTotal", "Costo", "CostoTotal", "Ganancia", "Porcentaje", "Categoria", "Proveedor"}
    Private Sub DGVVentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles DGVVentasDistri.EditingControlShowing

        If DataGridView1NumberColumns.Contains(DGVVentasDistri.Columns(DGVVentasDistri.CurrentCell.ColumnIndex).Name) Then
            Dim txtEditForDataGridView As TextBox = e.Control
            RemoveHandler txtEditForDataGridView.KeyPress, AddressOf txtEditForDataGridView_Keypress
            AddHandler txtEditForDataGridView.KeyPress, AddressOf txtEditForDataGridView_Keypress
        End If
    End Sub
    Private Sub txtEditForDataGridView_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If DGVVentasDistri.CurrentCell.ColumnIndex = 0 Then
            If IsNumeric(e.KeyChar.ToString()) _
            Or e.KeyChar = ChrW(Keys.Back) _
            Or e.KeyChar = "," Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

        If DGVVentasDistri.CurrentCell.ColumnIndex = 4 Or DGVVentasDistri.CurrentCell.ColumnIndex = 5 Or DGVVentasDistri.CurrentCell.ColumnIndex = 6 Or DGVVentasDistri.CurrentCell.ColumnIndex = 7 Or DGVVentasDistri.CurrentCell.ColumnIndex = 9 Or DGVVentasDistri.CurrentCell.ColumnIndex = 10 Or DGVVentasDistri.CurrentCell.ColumnIndex = 11 Or DGVVentasDistri.CurrentCell.ColumnIndex = 12 Or DGVVentasDistri.CurrentCell.ColumnIndex = 13 Or DGVVentasDistri.CurrentCell.ColumnIndex = 14 Then
            e.Handled = True
        End If
    End Sub
    'Fin del codigo para permitir que solo ingresen numeros al DGV en las columnas de Cantidad y costo

    'BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelarVenta.Click
        Limpiar()
        TBVentasNPedido.Text = Consecutivos()
    End Sub
    Private Sub Limpiar()
        TBVentasNit.Text = ""
        TBVentasCiudad.Text = ""
        CBVentasClientes.Text = ""
        TBVentasEnviara.Text = ""
        TBVentasTelefono.Text = ""
        TBVentasCel.Text = ""
        TBVentasEmail.Text = ""
        TBVentasDireccion.Text = ""
        TBVentasBarrio.Text = ""
        CBVendedor.Text = ""
        TBCodVendedor.Text = ""
        TBVentasOdePedido.Text = ""
        TBVentasCodCLiente.Text = ""
        CBVentasTipodepago.Text = "Contado"
        TBDiasDeCredito.Text = ""
        CHBIVA.Checked = False
        DGVVentasDistri.Rows.Clear()
        Actualizar_Ventas()
        DGVVentasIngresados.DataSource = ObtenerIngresados() 'es para llenar y actualizar el DGV de ingresados
        DGVVentasAlistar.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonDeGuardarVentas.Click
        'Este codigo es para ingresar los pedidos en las listas de ingresados y la ListaDeIngresados
        If TBVentasNPedido.Text = "" Then
            MsgBox("Incerte un N° de pedido")
        ElseIf CheckBox1.Checked = False Then
            If estan_disponibles() = False Then
                MsgBox("algún producto no esta disponible")
            Else
                Dim result As DataRow() = Form1.TablaIngresados.Select("NDePedido='" & TBVentasNPedido.Text & "'")
                If result.Length > 0 Then
                    MsgBox("El N° de factura ya exise, intente con otro")
                Else
                    Form1.Consultar("insert into ingresados values ('" & TBVentasNPedido.Text & "', '" & CBVentasClientes.Text & "', '" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')")
                    For i As Integer = 0 To DGVVentasDistri.Rows.Count - 2
                        Dim TieneIva As String = ""
                        Dim cadena_de_insercion As String
                        If CHBIVA.Checked = True Then
                            TieneIva = "T"
                        Else
                            TieneIva = "F"
                        End If
                        cadena_de_insercion = "('" & TBVentasNPedido.Text & "',
                                                '" & TBVentasOdePedido.Text & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Cantidad").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Cod").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Descripcion").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrUnitario").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrTotal").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrUnitarioIVA").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("IVA").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrTotalIVA").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Costo").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("CostoTotal").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Ganancia").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Porcentaje").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Categoria").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("SubCategoria").Value) & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Proveedor").Value) & "',
                                                '" & TBVentasCodCLiente.Text & "',
                                                '" & CBVentasClientes.Text & "',
                                                '" & TBCodVendedor.Text & "',
                                                '" & CBVendedor.Text & "',
                                                '" & DateTimePicker1.Text & "',
                                                '" & DateTimePicker2.Text & "',
                                                '" & CBVentasTipodepago.Text & "',
                                                '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Ubicacion").Value) & "',
                                                '" & TimeString & "',
                                                '" & TieneIva & "',
                                                '" & DTPFechaDeCredito.Text & "')"
                        Form1.A_tablas("tabladeingresados", cadena_de_insercion)
                    Next
                    'esta parte del codigo agrega los datos a la tabla de Estados
                    Form1.Consultar("insert into tabladeestados values ('" & TBVentasNPedido.Text & "', '" & TBVentasCodCLiente.Text & "', '" & CBVentasClientes.Text & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "','" & TBTotalVentas.Text & "','" & CBVentasTipodepago.Text & "','" & "Ingresado" & "','" & "" & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "', '')")
                    MsgBox("Se registro correctamente")
                    Actualizar_Ventas()
                    Form1.Actualizar_Tabla_ingresados()
                    'para limpiar las casillas
                    Limpiar()
                End If
            End If
            'Me aumenta en el consecutivo de ventas
            Dim NuevoConsecutivoCompra As Double = Consecutivos() + 1
            Form1.Consultar("update consecutivos set NPreFactura = '" & NuevoConsecutivoCompra & "' where 1 = 1")
            TBVentasNPedido.Text = Consecutivos()

        ElseIf CheckBox1.Checked = True Then
            Dim result As DataRow() = Form1.TablaIngresados.Select("NDePedido='" & TBVentasNPedido.Text & "'")
            If result.Length > 0 Then
                MsgBox("El N° de factura ya exise, intente con otro")
            Else
                'fin del codigo nuevo este codigo evita que pongan el mismo codigo para dos Proovedores distintos
                Form1.Consultar("insert into ingresados values ('" & TBVentasNPedido.Text & "', '" & CBVentasClientes.Text & "', '" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')")
                For i As Integer = 0 To DGVVentasDistri.Rows.Count - 2
                    Dim TieneIva As String = ""
                    Dim cadena_de_insercion As String
                    If CHBIVA.Checked = True Then
                        TieneIva = "T"
                    Else
                        TieneIva = "F"
                    End If
                    cadena_de_insercion = "('" & TBVentasNPedido.Text & "',
                                            '" & TBVentasOdePedido.Text & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Cantidad").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Cod").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Descripcion").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrUnitario").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrTotal").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrUnitarioIVA").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("IVA").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("VrTotalIVA").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Costo").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("CostoTotal").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Ganancia").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Porcentaje").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Categoria").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("SubCategoria").Value) & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Proveedor").Value) & "',
                                            '" & TBVentasCodCLiente.Text & "',
                                            '" & CBVentasClientes.Text & "',
                                            '" & TBCodVendedor.Text & "',
                                            '" & CBVendedor.Text & "',
                                            '" & DateTimePicker1.Text & "',
                                            '" & DateTimePicker2.Text & "',
                                            '" & CBVentasTipodepago.Text & "',
                                            '" & Convert.ToString(DGVVentasDistri.Rows.Item(i).Cells("Ubicacion").Value) & "',
                                            '" & TimeString & "',
                                            '" & TieneIva & "',
                                            '" & DTPFechaDeCredito.Text & "')"
                    Form1.A_tablas("tabladeingresados", cadena_de_insercion)
                Next
                Form1.Consultar("insert into tabladeestados values ('" & TBVentasNPedido.Text & "', '" & TBVentasCodCLiente.Text & "', '" & CBVentasClientes.Text & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "','" & TBTotalVentas.Text & "','" & CBVentasTipodepago.Text & "','" & "Ingresado" & "','" & "" & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "','" & Convert.ToString(Format(Date.Now, "Short Date")) & "', '')")
                ObtenerTablaDeEstados()
                'fin de 
                MsgBox("Se registro correctamente")
                Form1.Actualizar_Tabla_ingresados()
                Actualizar_Ventas()
                Limpiar()
            End If
            'Me aumenta en el consecutivo de ventas
            Dim NuevoConsecutivoCompra As Double = Consecutivos() + 1
            Form1.Consultar("update consecutivos set NPreFactura = '" & NuevoConsecutivoCompra & "' where 1 = 1")
            TBVentasNPedido.Text = Consecutivos()
        End If

    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE LO QUE VA EN EL TABPAGE 1 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'LO QUE VA EN EL TABPAGE2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonParaAlistar.Click
        For Each row As DataGridViewRow In
             DGVVentasIngresados.SelectedRows.Cast(Of DataGridViewRow)().Reverse()

            Dim index As Integer = DGVVentasAlistar.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

            For Each cell As DataGridViewCell In row.Cells
                DGVVentasAlistar.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
            Next
            DGVVentasIngresados.Rows.Remove(DGVVentasIngresados.CurrentRow)
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonParaListaDeIngresados.Click
        'este boton es para llevar los que esten para alistaar de vuelta a la lista de ingresados
        Dim dt As DataTable = DirectCast(DGVVentasIngresados.DataSource, DataTable)
        ' Creamos una nueva fila
        Dim row As DataRow = dt.NewRow()
        ' Añadimos los valores a sus columnas
        row.Item(0) = Trim(Convert.ToString(DGVVentasAlistar.CurrentRow.Cells(0).Value))
        row.Item(1) = Trim(Convert.ToString(DGVVentasAlistar.CurrentRow.Cells(1).Value))
        row.Item(2) = Trim(Convert.ToString(DGVVentasAlistar.CurrentRow.Cells(2).Value))
        row.Item(3) = Trim(Convert.ToString(DGVVentasAlistar.CurrentRow.Cells(3).Value))
        ' Añadimos la fila a la colección de filas
        ' del objeto DataTable
        dt.Rows.Add(row)
        'eliminamos la fila del DGVVentasAlistar
        DGVVentasAlistar.Rows.Remove(DGVVentasAlistar.CurrentRow)
    End Sub

    Private Sub ButtonCancelarPedidosParaAlistar_Click(sender As Object, e As EventArgs) Handles ButtonCancelarPedidosParaAlistar.Click
        DGVVentasIngresados.DataSource = ObtenerIngresados()
        DGVVentasAlistar.Rows.Clear()
    End Sub

    Public Function la_lista_de_alistar_pedidos()
        'parte del cogigo que calcula si va o no a la lista de Alistar pedidos
        Dim total As Double
        'Dim filas As DataRow 'DataGridViewRow = New DataGridViewRow() 'filas de pedido que se esta alistando
        Dim fila As DataGridViewRow = New DataGridViewRow() 'filas de DGVVentasAlistar
        Dim j As Integer 'contador del DGV que es la lista para alistar los pedidos
        Dim Ndepedido As String ' me da el numero del pedido que quiero alistar

        If Form1.AlistarPedidos_activo = True Then
            Form1.AlistarPedidos.Activate()
        Else
            Form1.AlistarPedidos.Show()
            Form1.AlistarPedidos_activo = True
        End If

        If Form1.ListaDePendientes_activo = True Then
            Form1.ListaDePendientes.Activate()
        Else
            Form1.ListaDePendientes.Show()
            Form1.ListaDePendientes_activo = True
        End If

        For Each fila In DGVVentasAlistar.Rows ' esto hace que se ejecute el codigo pedido por pedido según el orden en el que esta en el DGVVentasAlistar
            Ndepedido = Convert.ToString(fila.Cells(0).Value)
            'parte del codigo que llena el DGVListaDeAlistarPedidos
            Dim en_alistamiento As Double = 0

            Dim dt As New DataTable
            dt = Form1.Tablas("select I.Cantidad ,I.Codigo, I.Descripción, (select SUM(E.Cantidad) From entradas as E where I.Codigo=E.Codigo)-((select SUM(S.Cantidad) From salidas as S where I.Codigo=S.Codigo)) AS Disponible, I.Cliente, I.Costo, I.Proveedor, I.Ubicación From tabladeingresados as I where I.NDePedido= '" & Ndepedido & "' group by I.Codigo, I.Descripción, I.Cantidad, I.Cliente, I.Costo, I.Proveedor, I.Ubicación")

            Dim i As Integer = 0

            If dt.Rows.Count > 0 Then
                For Each filas As DataRow In dt.Rows()
                    Dim codtabla As String = Trim(Convert.ToString(dt.Rows(i).Item(1).ToString))
                    For j = 0 To Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows.Count - 1

                        Dim codporalistar As String = Trim(Convert.ToString(Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(j).Cells(2).Value))
                        If codtabla = codporalistar Then
                            'calcula el total de lo que se ha alistado anteriormente 
                            total += Convert.ToDouble(Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(j).Cells(1).Value)
                        End If

                    Next j
                    Dim disponible As Double = producto_disponible(codtabla) - total
                    'este codigo ingresa los que estan disponibles en inventario a la lista de alistamiento
                    If disponible - Convert.ToDouble(dt.Rows(i).Item(0).ToString) >= 0 Then
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows.Add(1)
                        Dim k As Integer
                        k = Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows.Count - 1
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(0).Value = Trim(dt.Rows(i).Item(4).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(1).Value = Trim(dt.Rows(i).Item(0).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(2).Value = Trim(dt.Rows(i).Item(1).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(3).Value = Trim(dt.Rows(i).Item(2).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(4).Value = Trim(dt.Rows(i).Item(3).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(5).Value = Trim(dt.Rows(i).Item(7).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(6).Value = Ndepedido
                        'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                    ElseIf disponible - Convert.ToDouble(dt.Rows(i).Item(0).ToString) < 0 Then
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows.Add(1)
                        Dim c As Integer
                        c = Form1.ListaDePendientes.DGVListaDePendientes.Rows.Count - 1
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows(c).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows(c).Cells(1).Value = Trim(dt.Rows(i).Item(2).ToString)
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows(c).Cells(2).Value = Trim(dt.Rows(i).Item(5).ToString)
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows(c).Cells(3).Value = Trim(dt.Rows(i).Item(4).ToString)
                        Form1.ListaDePendientes.DGVListaDePendientes.Rows(c).Cells(4).Value = Trim(dt.Rows(i).Item(6).ToString)
                        'Pone en color los que estan pendientes en la lista de alistar pedidos
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows.Add(1)
                        Dim k As Integer
                        k = Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows.Count - 1
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(0).Value = Trim(dt.Rows(i).Item(4).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(1).Value = Trim(dt.Rows(i).Item(0).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(2).Value = Trim(dt.Rows(i).Item(1).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(3).Value = Trim(dt.Rows(i).Item(2).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(4).Value = Trim(dt.Rows(i).Item(3).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(5).Value = Trim(dt.Rows(i).Item(7).ToString)
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).Cells(6).Value = Ndepedido
                        Form1.AlistarPedidos.DGVListaDeAlistarPedidos.Rows(k).DefaultCellStyle.BackColor = Color.OrangeRed
                        'Fin de Pone en color los que estan pendientes en la lista de alistar pedidos
                    End If
                    i = i + 1
                Next
            End If
        Next
    End Function

    Private Sub ButtonAlistarPedidos_Click(sender As Object, e As EventArgs) Handles ButtonAlistarPedidos.Click
        la_lista_de_alistar_pedidos()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        la_lista_de_alistar_pedidos()
        Form1.AlistarPedidos.Hide()
        Form1.AlistarPedidos_activo = False
    End Sub

    'FIN DE BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Public Function ObtenerIngresados() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        'Dim dtIngresados As New DataTable
        'dtIngresados = Form1.Tablas("Select*from ingresados")
        Return Form1.TablaIngresados 'dtIngresados
    End Function
    'FIN DE FUNCIONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE LO QUE VA EN EL TABPAGE 2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'LO QUE VA EN EL TABPAGE 3 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Public Function ObtenerTablaDeEstados() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Dim dt As New DataTable
        dt = Form1.TablaDeEstadosVentas 'Tablas("Select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados As ES order by ES.FechaFactura desc")
        Dim i As Integer = 0

        DGVEstados.Rows.Clear()
        If dt.Rows.Count > 0 Then
            DGVEstados.Rows.Add(dt.Rows.Count)
            For Each filas As DataRow In dt.Rows()
                DGVEstados.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                DGVEstados.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                DGVEstados.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                DGVEstados.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                DGVEstados.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                DGVEstados.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                DGVEstados.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                DGVEstados.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                DGVEstados.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                DGVEstados.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                DGVEstados.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                i = i + 1
            Next
        End If

    End Function

    Public Function ObtenerTablaDePagosVentas() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        'esta funcion da la tabla de los pagos de las facturas de ventas
        Dim dt As New DataTable
        dt = Form1.TablaDeAbonoVentas 'Form1.Tablas("Select S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo from abonodeventas As S order by S.Fecha desc")
        Dim i As Integer = 0
        Form1.Facturasdeventa.DGVCobrosVentas.Rows.Clear()
        If dt.Rows.Count > 0 Then
            Form1.Facturasdeventa.DGVCobrosVentas.Rows.Add(dt.Rows.Count)
            For Each filas As DataRow In dt.Rows()
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(8).Value = Format(Convert.ToDouble(Trim(dt.Rows(i).Item(9).ToString)), "##,##0.00")
                i = i + 1
            Next
        Else

        End If
    End Function
    Public Function abilitar_alistamiento()
        If Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Cerrado" Or Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Anulado" Then
            Form1.verificacion.ButtonCerrarFactura.Visible = False
            Form1.verificacion.ButtonDeGuardarVentas.Visible = False
            Form1.verificacion.CancelarVenta.Visible = False
            Form1.verificacion.DGVVerificarVenta.ReadOnly = True
            Form1.verificacion.CHBIVA.Visible = False
            Form1.verificacion.ButtonAnular.Visible = False
        Else
            Form1.verificacion.ButtonCerrarFactura.Visible = True
            Form1.verificacion.ButtonDeGuardarVentas.Visible = True
            Form1.verificacion.CancelarVenta.Visible = True
            Form1.verificacion.DGVVerificarVenta.ReadOnly = False
            Form1.verificacion.CHBIVA.Visible = True
            Form1.verificacion.ButtonAnular.Visible = True
        End If
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'BOOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles ButtonVerificarPedido.Click
        'ESTE BOTON SE ENCARGA DE VERIFICAR LOS PEDIDOS
        Dim NPedido As String = Trim(Convert.ToString(DGVEstados.CurrentRow.Cells(0).Value))
        If Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Alistado" Then
            EstaAnulado = False
            If Form1.verificacion_activo = True Then
                Form1.verificacion.Activate()
            Else
                Form1.verificacion.Show()
                Form1.verificacion_activo = True
            End If

            'Dim dt As New DataTable
            'dt = Form1.Tablas("select*From tabladeingresados where NDePedido= '" & NPedido & "'") 'Selecciona toda la tabla de tabla de ingresados
            Dim result As DataRow() = Form1.Tabla_de_ingresados.Select("NDePedido= '" & NPedido & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(CStr(result(0).Item(0))) 'Trim(dt.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(CStr(result(0).Item(1))) 'Trim(dt.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(CStr(result(0).Item(19))) 'Trim(dt.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(CStr(result(0).Item(20))) 'Trim(dt.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(CStr(result(0).Item(21))) 'Trim(dt.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(CStr(result(0).Item(22))) 'Trim(dt.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(CStr(result(0).Item(23))) 'Trim(dt.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(CStr(result(0).Item(17))) 'Trim(dt.Rows(0).Item(17).ToString) 'Codigo del cliente
            If Trim(CStr(result(0).Item(26))) = "T" Then
                Form1.verificacion.CHBIVA.Checked = True
            Else
                Form1.verificacion.CHBIVA.Checked = False
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente

            Dim ferreteria As String = Trim(CStr(result(0).Item(17))) 'Trim(Convert.ToString(dt.Rows(0).Item(17).ToString))

            'Dim dt1 As New DataTable
            'dt1 = Form1.Tablas("select*from clientes where Cod='" & ferreteria & "'")
            Dim resultClientes As DataRow() = Form1.TablaClientes.Select("Cod='" & ferreteria & "'")
            If resultClientes.Length > 0 Then 'dt1.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(CStr(resultClientes(0).Item(1))) 'Trim(dt1.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(CStr(resultClientes(0).Item(2))) 'Trim(dt1.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(CStr(resultClientes(0).Item(3))) 'Trim(dt1.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(CStr(resultClientes(0).Item(4))) 'Trim(dt1.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(CStr(resultClientes(0).Item(5))) 'Trim(dt1.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(CStr(resultClientes(0).Item(6))) 'Trim(dt1.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(CStr(resultClientes(0).Item(7))) 'Trim(dt1.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(CStr(resultClientes(0).Item(1))) 'Trim(dt1.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()
            Dim dt As New DataTable
            dt = Filtrar_tabla_de_ingresados("NDePedido= '" & NPedido & "'")
            If dt.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt.Rows.Count)
                Dim i As Integer = 0
                For Each fila As DataRow In dt.Rows()
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(2).ToString) 'Cantidad
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(3).ToString) 'Codigo
                    Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(4).ToString) 'Descripción
                    i = i + 1
                Next
            End If

            abilitar_alistamiento()
        ElseIf Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Verificado" Then
            EstaAnulado = False
            If Form1.verificacion_activo = True Then
                Form1.verificacion.Activate()
            Else
                Form1.verificacion.Show()
                Form1.verificacion_activo = True
            End If
            'Dim dt As New DataTable
            'dt = Form1.Tablas("select*From verificados where NDePedido= '" & NPedido & "'") 'Selecciona toda la tabla de tabla de ingresados
            Dim result As DataRow() = Form1.TablaVerificados.Select("NDePedido= '" & NPedido & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(CStr(result(0).Item(0))) 'Trim(dt.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(CStr(result(0).Item(1))) 'Trim(dt.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(CStr(result(0).Item(19))) 'Trim(dt.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(CStr(result(0).Item(20))) 'Trim(dt.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(CStr(result(0).Item(21))) 'Trim(dt.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(CStr(result(0).Item(22))) 'Trim(dt.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(CStr(result(0).Item(23))) 'Trim(dt.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(CStr(result(0).Item(17))) 'Trim(dt.Rows(0).Item(17).ToString) 'Codigo del cliente
            'esta parte del codigo se encarga de llenar los datos según el cliente
            If Trim(CStr(result(0).Item(27))) = "T" Then
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
            Dim ferreteria As String = Trim(CStr(result(0).Item(17))) 'Trim(Convert.ToString(dt.Rows(0).Item(17).ToString))
            Dim dt As New DataTable
            dt = FiltrarCliente("where Cod='" & ferreteria & "'") 'Form1.Tablas("select*from clientes where Cod='" & ferreteria & "'")

            If dt.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(dt.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(dt.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(dt.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(dt.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(dt.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(dt.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(dt.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(dt.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()

            If dt.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt.Rows.Count)
                Dim i As Integer = 0
                Try
                    For Each fila As DataRow In dt.Rows()
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(2).ToString) 'Cantidad
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(3).ToString) 'Codigo
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(4).ToString) 'Descripción
                        If Trim(dt.Rows(i).Item(26).ToString) = "T" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = True
                        ElseIf Trim(dt.Rows(i).Item(16).ToString) = "F" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = False
                        End If
                        i = i + 1
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            abilitar_alistamiento()
        ElseIf Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Cerrado" Then
            EstaAnulado = False
            If Form1.verificacion_activo = True Then
                Form1.verificacion.Activate()
            Else
                Form1.verificacion.Show()
                Form1.verificacion_activo = True
            End If
            'Dim dt As New DataTable
            'dt = Form1.Tablas("select*From salidas where NDePedido= '" & NPedido & "'") 'Selecciona toda la tabla de tabla de salidas
            Dim result As DataRow() = Form1.TablaDeSalidas.Select("NDePedido= '" & NPedido & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(CStr(result(0).Item(0))) 'Trim(dt.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(CStr(result(0).Item(1))) 'Trim(dt.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(CStr(result(0).Item(19))) 'Trim(dt.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(CStr(result(0).Item(20))) 'Trim(dt.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(CStr(result(0).Item(21))) 'Trim(dt.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(CStr(result(0).Item(22))) 'Trim(dt.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(CStr(result(0).Item(23))) 'Trim(dt.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(CStr(result(0).Item(17))) 'Trim(dt.Rows(0).Item(17).ToString) 'Codigo del cliente
            'esta parte del codigo se encarga de llenar los datos según el cliente
            If Trim(CStr(result(0).Item(26))) = "T" Then
                Form1.verificacion.CHBIVA.Checked = True
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = True
            ElseIf Trim(CStr(result(0).Item(26))) = "F" Then
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = False
            End If
            Dim ferreteria As String = Trim(CStr(result(0).Item(17))) 'Trim(Convert.ToString(dt.Rows(0).Item(17).ToString))
            Dim dt As New DataTable
            dt = FiltrarCliente("where Cod='" & ferreteria & "'") 'Form1.Tablas("select*from clientes where Cod='" & ferreteria & "'")

            If dt.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(dt.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(dt.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(dt.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(dt.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(dt.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(dt.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(dt.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(dt.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()

            If dt.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt.Rows.Count)
                Dim i As Integer = 0
                Try
                    For Each fila As DataRow In dt.Rows()
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(2).ToString) 'Cantidad
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(3).ToString) 'Codigo
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(4).ToString) 'Descripción
                        If Trim(dt.Rows(i).Item(26).ToString) = "T" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = True
                        ElseIf Trim(dt.Rows(i).Item(16).ToString) = "F" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = False
                        End If
                        i = i + 1
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            abilitar_alistamiento()
        ElseIf Convert.ToString(DGVEstados.CurrentRow.Cells("Estado").Value) = "Anulado" Then
            EstaAnulado = True
            If Form1.verificacion_activo = True Then
                Form1.verificacion.Activate()
            Else
                Form1.verificacion.Show()
                Form1.verificacion_activo = True
            End If
            'Dim dt As New DataTable
            'dt = Form1.Tablas("select*From anulados where NDePedido= '" & NPedido & "'") 'Selecciona toda la tabla de tabla de salidas
            Dim result As DataRow() = Form1.Tabla_de_anulado.Select("NDePedido= '" & NPedido & "'")
            Form1.verificacion.LNdepedidoText.Text = Trim(CStr(result(0).Item(0))) 'Trim(dt.Rows(0).Item(0).ToString) 'N de pedido
            Form1.verificacion.LOdepedidoText.Text = Trim(CStr(result(0).Item(1))) 'Trim(dt.Rows(0).Item(1).ToString) 'Orden de pedido
            Form1.verificacion.LCodVText.Text = Trim(CStr(result(0).Item(19))) 'Trim(dt.Rows(0).Item(19).ToString) 'cod vendedor
            Form1.verificacion.LVendedorText.Text = Trim(CStr(result(0).Item(20))) 'Trim(dt.Rows(0).Item(20).ToString) 'vendedor
            Form1.verificacion.LFechaOdepedidoText.Text = Trim(CStr(result(0).Item(21))) 'Trim(dt.Rows(0).Item(21).ToString) 'Fecha de la orden de pedido
            Form1.verificacion.LFechaEntregaText.Text = Trim(CStr(result(0).Item(22))) 'Trim(dt.Rows(0).Item(22).ToString) 'Fecha de entrega
            Form1.verificacion.LTipoDePagoText.Text = Trim(CStr(result(0).Item(23))) 'Trim(dt.Rows(0).Item(23).ToString) 'Tipo de pago
            Form1.verificacion.LCodCLiente.Text = Trim(CStr(result(0).Item(17))) 'Trim(dt.Rows(0).Item(17).ToString) 'Codigo del cliente
            'esta parte del codigo se encarga de llenar los datos según el cliente
            If Trim(CStr(result(0).Item(26))) = "T" Then
                Form1.verificacion.CHBIVA.Checked = True
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = True
            ElseIf Trim(CStr(result(0).Item(26))) = "F" Then
                Form1.verificacion.DGVVerificarVenta.Columns(3).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(4).Visible = True
                Form1.verificacion.DGVVerificarVenta.Columns(5).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(6).Visible = False
                Form1.verificacion.DGVVerificarVenta.Columns(7).Visible = False
            End If
            Dim ferreteria As String = Trim(CStr(result(0).Item(17))) 'Trim(Convert.ToString(dt.Rows(0).Item(17).ToString))
            Dim dt As New DataTable
            dt = FiltrarCliente("where Cod='" & ferreteria & "'")
            'Dim dt1 As New DataTable
            'dt1 = Form1.Tablas("select*from clientes where Cod='" & ferreteria & "'")

            If dt.Rows.Count > 0 Then
                Form1.verificacion.LNitText.Text = Trim(dt.Rows(0).Item(1).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LClienteText.Text = Trim(dt.Rows(0).Item(2).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEnviarAText.Text = Trim(dt.Rows(0).Item(3).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LTelefonoText.Text = Trim(dt.Rows(0).Item(4).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LCelText.Text = Trim(dt.Rows(0).Item(5).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LEmailText.Text = Trim(dt.Rows(0).Item(6).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LDireccionText.Text = Trim(dt.Rows(0).Item(7).ToString) 'selecciona los datos segun el criterio del codigo del cliente
                Form1.verificacion.LBarrioText.Text = Trim(dt.Rows(0).Item(8).ToString) 'selecciona los datos segun el criterio del codigo del cliente
            Else
                MsgBox("El cliente no existe") 'Manda un mensaje en caso tal que el Codigo no exista.
            End If
            'esta parte del codigo se encarga de llenar los datos según el cliente
            Form1.verificacion.DGVVerificarVenta.Rows.Clear()

            If dt.Rows.Count > 0 Then
                Dim index As Integer = Form1.verificacion.DGVVerificarVenta.Rows.Add(dt.Rows.Count)
                Dim i As Integer = 0
                Try
                    For Each fila As DataRow In dt.Rows()
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(2).ToString) 'Cantidad
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(3).ToString) 'Codigo
                        Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(4).ToString) 'Descripción
                        If Trim(dt.Rows(i).Item(26).ToString) = "T" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = True
                        ElseIf Trim(dt.Rows(i).Item(16).ToString) = "F" Then
                            Form1.verificacion.DGVVerificarVenta.Rows(i).Cells(16).Value = False
                        End If
                        i = i + 1
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            abilitar_alistamiento()
        Else
            MsgBox("El pedido no esta listo para verificar")
        End If
    End Sub
    Private Sub ButtonAbonar_Click(sender As Object, e As EventArgs) Handles ButtonAbonar.Click
        'Este boton llama al form de abonar a las compras
        If Form1.Facturasdeventa.DGVCobrosVentas.Rows.Count = 0 Then
            MessageBox.Show("No se han registrado ventas para hacer un abono")
        Else
            Dim frm As New FormatoDeAbonosVentas()
            frm.Show()
        End If
    End Sub
    'FIN DE BOOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub DGVEstados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVEstados.CellFormatting
        'para ponerle los colores al DGV de los estados
        If e.ColumnIndex = 6 Then
            If Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(6).Value)) = "Ingresado" Then
                e.CellStyle.BackColor = Color.Yellow
            ElseIf Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(6).Value)) = "Alistado" Then
                e.CellStyle.BackColor = Color.Orange
            ElseIf Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(6).Value)) = "Verificado" Then
                e.CellStyle.BackColor = Color.OrangeRed
            ElseIf Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(6).Value)) = "Transporte" Then
                e.CellStyle.BackColor = Color.Red
            ElseIf Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(6).Value)) = "Cerrado" Then
                e.CellStyle.BackColor = Color.Green
                e.CellStyle.ForeColor = Color.White
            End If
        ElseIf e.ColumnIndex = 10 Then
            If Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(10).Value)) = "Incompleto" Then
                e.CellStyle.BackColor = Color.Orange
            ElseIf Trim(Convert.ToString(DGVEstados.Rows(e.RowIndex).Cells(10).Value)) = "Completo" Then
                e.CellStyle.BackColor = Color.White

            End If
        End If

    End Sub

    Private Sub CHBIVA_CheckedChanged(sender As Object, e As EventArgs) Handles CHBIVA.CheckedChanged
        If CHBIVA.Checked = True Then
            DGVVentasDistri.Columns(3).Visible = False
            DGVVentasDistri.Columns(4).Visible = False
            DGVVentasDistri.Columns(5).Visible = True
            DGVVentasDistri.Columns(6).Visible = True
            DGVVentasDistri.Columns(7).Visible = True
        Else
            DGVVentasDistri.Columns(3).Visible = True
            DGVVentasDistri.Columns(4).Visible = True
            DGVVentasDistri.Columns(5).Visible = False
            DGVVentasDistri.Columns(6).Visible = False
            DGVVentasDistri.Columns(7).Visible = False
        End If
    End Sub

    Private Sub DGVEstados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEstados.CellEndEdit

        If DGVEstados.Columns(e.ColumnIndex).Name = "ProcesoDelPedido" Then
            Form1.Consultar("update tabladeestados set ProcesoDelPedido = '" & DGVEstados.Rows(e.RowIndex).Cells("ProcesoDelPedido").Value & "' Where NDePedido = '" & DGVEstados.Rows(e.RowIndex).Cells("NPedido").Value & "'")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If ComboBox1.Text = "N° de pedido" Then
            Filtrar_estados("NDePedido like'" & "%" + TextBox2.Text + "%" & "'") 'Filtro = "select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados as ES where ES.NDePedido like'" & "%" + TextBox2.Text + "%" & "' order by ES.FechaFactura desc"
        ElseIf ComboBox1.Text = "Cod" Then
            Filtrar_estados("CodCliente like'" & "%" + TextBox2.Text + "%" & "'") 'Filtro = "select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados as ES where ES.CodCliente like'" & "%" + TextBox2.Text + "%" & "' order by ES.FechaFactura desc"
        ElseIf ComboBox1.Text = "Cliente" Then
            Filtrar_estados("Cliente like'" & "%" + TextBox2.Text + "%" & "'") 'Filtro = "select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from Tabladeestados as ES where ES.Cliente like'" & "%" + TextBox2.Text + "%" & "' order by ES.FechaFactura desc"
        ElseIf ComboBox1.Text = "Valor" Then
            Filtrar_estados("Valor like'" & "%" + TextBox2.Text + "%" & "'") 'Filtro = "select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados as ES where ES.Valor like'" & "%" + TextBox2.Text + "%" & "' order by ES.FechaFactura desc"
        ElseIf ComboBox1.Text = "Valor final" Then
            Filtrar_estados("ValorFinal like'" & "%" + TextBox2.Text + "%" & "'") 'Filtro = "select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados as ES where ES.ValorFinal like'" & "%" + TextBox2.Text + "%" & "' order by ES.FechaFactura desc"
        End If

    End Sub

    Public Sub Filtrar_estados(buscar As String)
        Dim dt As DataTable
        dt = ObtenerTablaDeFiltroEstados(buscar)

        Dim i As Integer = 0
        DGVEstados.Rows.Clear()
        If dt.Rows.Count > 0 Then
            DGVEstados.Rows.Add(dt.Rows.Count)
            For Each filas As DataRow In dt.Rows()
                DGVEstados.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                DGVEstados.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                DGVEstados.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                DGVEstados.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                DGVEstados.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                DGVEstados.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                DGVEstados.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                DGVEstados.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                DGVEstados.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString)
                DGVEstados.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString)
                DGVEstados.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString)
                'este codigo ingresa los que estan no estan disponibles en inventario a la lista de compras
                i = i + 1
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Fecha" Or ComboBox1.Text = "Fecha de estado" Or ComboBox1.Text = "Fecha de entrega" Then
            DTP_Desde.Value = Today
            DTP_Hasta.Value = Today
            ObtenerTablaDeEstados()
            Label27.Visible = False
            ComboBox4.Visible = False
            Label26.Visible = False
            ComboBox3.Visible = False
            Label25.Visible = False
            ComboBox2.Visible = False
            TextBox2.Visible = False
            Label22.Visible = False
            Label23.Visible = True
            DTP_Desde.Visible = True
            Label24.Visible = True
            DTP_Hasta.Visible = True
        ElseIf ComboBox1.Text = "Tipo de pago" Then
            ObtenerTablaDeEstados()
            Label27.Visible = False
            ComboBox4.Visible = False
            Label26.Visible = False
            ComboBox3.Visible = False
            Label25.Visible = True
            ComboBox2.Visible = True
            TextBox2.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            DTP_Desde.Visible = False
            Label24.Visible = False
            DTP_Hasta.Visible = False
        ElseIf ComboBox1.Text = "Estado" Then
            ObtenerTablaDeEstados()
            Label27.Visible = False
            ComboBox4.Visible = False
            Label26.Visible = True
            ComboBox3.Visible = True
            Label25.Visible = False
            ComboBox2.Visible = False
            TextBox2.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            DTP_Desde.Visible = False
            Label24.Visible = False
            DTP_Hasta.Visible = False
        ElseIf ComboBox1.Text = "Proceso del pedido" Then
            ObtenerTablaDeEstados()
            Label27.Visible = True
            ComboBox4.Visible = True
            Label26.Visible = False
            ComboBox3.Visible = False
            Label25.Visible = False
            ComboBox2.Visible = False
            TextBox2.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            DTP_Desde.Visible = False
            Label24.Visible = False
            DTP_Hasta.Visible = False
        Else
            ObtenerTablaDeEstados()
            Label27.Visible = False
            ComboBox4.Visible = False
            Label26.Visible = False
            ComboBox3.Visible = False
            Label25.Visible = False
            ComboBox2.Visible = False
            TextBox2.Visible = True
            Label22.Visible = True
            Label23.Visible = False
            DTP_Desde.Visible = False
            Label24.Visible = False
            DTP_Hasta.Visible = False
        End If
    End Sub

    Private Sub DTP_Desde_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Desde.ValueChanged
        Dim j As Integer
        ObtenerTablaDeEstados()

        If ComboBox1.Text = "Fecha" Then
            j = 3
        ElseIf ComboBox1.Text = "Fecha de estado" Then
            j = 8
        ElseIf ComboBox1.Text = "Fecha de entrega" Then
            j = 9
        End If
        For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

            If Trim(Convert.ToDateTime(Trim(DGVEstados.Rows(i).Cells(j).Value)).ToShortDateString()) <= DTP_Desde.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVEstados.Rows(i).Cells(j).Value).ToShortDateString()) >= DTP_Hasta.Value.AddDays(1) Then
                DGVEstados.Rows.Remove(DGVEstados.Rows(i))
            End If
        Next
    End Sub

    Private Sub DTP_Hasta_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Hasta.ValueChanged
        Dim j As Integer
        ObtenerTablaDeEstados()

        If ComboBox1.Text = "Fecha" Then
            j = 3
        ElseIf ComboBox1.Text = "Fecha de estado" Then
            j = 8
        ElseIf ComboBox1.Text = "Fecha de entrega" Then
            j = 9
        End If
        For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

            If Trim(Convert.ToDateTime(Trim(DGVEstados.Rows(i).Cells(j).Value)).ToShortDateString()) <= DTP_Desde.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVEstados.Rows(i).Cells(j).Value).ToShortDateString()) >= DTP_Hasta.Value.AddDays(1) Then
                DGVEstados.Rows.Remove(DGVEstados.Rows(i))
            End If
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Contado" Then
            ObtenerTablaDeEstados()
            For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

                If Trim(DGVEstados.Rows(i).Cells(5).Value) <> "Contado" Then
                    DGVEstados.Rows.Remove(DGVEstados.Rows(i))
                End If
            Next
        ElseIf ComboBox2.Text = "Credito" Then
            ObtenerTablaDeEstados()
            For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

                If Trim(DGVEstados.Rows(i).Cells(5).Value) <> "Credito" Then
                    DGVEstados.Rows.Remove(DGVEstados.Rows(i))
                End If
            Next
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ObtenerTablaDeEstados()
        Dim pal_filtro As String
        If ComboBox3.Text = "Alistado" Then
            pal_filtro = "Alistado"
        ElseIf ComboBox3.Text = "Verificado" Then
            pal_filtro = "Verificado"
        ElseIf ComboBox3.Text = "Cerrado" Then
            pal_filtro = "Cerrado"
        End If

        For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

            If Trim(DGVEstados.Rows(i).Cells(6).Value) <> pal_filtro Then
                DGVEstados.Rows.Remove(DGVEstados.Rows(i))
            End If
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ObtenerTablaDeEstados()
        Dim pal_filtro As String
        If ComboBox4.Text = "Incompleto" Then
            pal_filtro = "Incompleto"
        ElseIf ComboBox4.Text = "Completo" Then
            pal_filtro = "Completo"
        End If

        For i As Double = DGVEstados.Rows.Count - 1 To 0 Step -1

            If Trim(DGVEstados.Rows(i).Cells(10).Value) <> pal_filtro Then
                DGVEstados.Rows.Remove(DGVEstados.Rows(i))
            End If
        Next
    End Sub

    Private Sub TBDiasDeCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDiasDeCredito.KeyPress
        'le deja solo ingresar numeros al TBDiasDeCredito
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBDiasDeCredito_TextChanged(sender As Object, e As EventArgs) Handles TBDiasDeCredito.TextChanged
        Dim dias As Integer
        If ComboBox5.Text = "" Or ComboBox5.Text = "Contado" Then
            TBDiasDeCredito.Text = ""
        Else
            If TBDiasDeCredito.Text = "" Then
                dias = 0
                DTPFechaDeCredito.Value = Today.AddDays(dias)
            Else
                dias = Convert.ToDouble(TBDiasDeCredito.Text)
                DTPFechaDeCredito.Value = DateTimePicker2.Value.Date.AddDays(dias)
            End If
        End If
    End Sub

    Private Sub DTPFechaDeCredito_Leave(sender As Object, e As EventArgs) Handles DTPFechaDeCredito.Leave
        Dim Candias As Integer
        Dim FechaHoy As Date = DateTimePicker2.Value
        Dim FechaCredito As Date = DTPFechaDeCredito.Value

        If ComboBox5.Text = "" Or ComboBox5.Text = "Contado" Then
            DTPFechaDeCredito.Value = Today
        Else
            Candias = DateDiff(DateInterval.Day, FechaHoy, FechaCredito)
            TBDiasDeCredito.Text = Candias
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub DGVCobrosVentas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVCobrosVentas.CellFormatting
        'para ponerle los colores al DGV de los estados
        Dim Vencimiento As Date = Trim(Convert.ToDateTime(DGVCobrosVentas.Rows(e.RowIndex).Cells(6).Value))
        If e.ColumnIndex = 5 Then
            If Trim(Convert.ToString(DGVCobrosVentas.Rows(e.RowIndex).Cells(5).Value)) = "Credito" Then
                If Trim(Convert.ToDouble(DGVCobrosVentas.Rows(e.RowIndex).Cells(8).Value)) > 0 Then
                    If Vencimiento > Today.Date.AddDays(-15) Then
                        e.CellStyle.BackColor = Color.OrangeRed
                    ElseIf Vencimiento > Today Then
                        e.CellStyle.BackColor = Color.Red
                    End If

                End If
            End If
        End If
        Dim total As Double = 0
        For Each fila In DGVCobrosVentas.Rows
            total += Convert.ToDouble(fila.Cells("Saldo").Value)
        Next
        Label38.Text = Format(total, "##,##0.00")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ObtenerTablaDePagosVentas()
        If ComboBox6.Text = "N° factura" Then
            FiltrarAbonos("NFactura like'" & "%" + TextBox3.Text + "%" & "'") 'filtro = "select S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo from abonodeventas as S where S.NFactura like'" & "%" + TextBox3.Text + "%" & "' order by S.Fecha desc"
        ElseIf ComboBox6.Text = "Cod cliente" Then
            FiltrarAbonos("CodCliente like'" & "%" + TextBox3.Text + "%" & "'") '    filtro = "select S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo from abonodeventas as S where S.CodCliente like'" & "%" + TextBox3.Text + "%" & "' order by S.Fecha desc"
        ElseIf ComboBox6.Text = "Cliente" Then
            FiltrarAbonos("Cliente like'" & "%" + TextBox3.Text + "%" & "'") '    filtro = "select S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo from abonodeventas as S where S.Cliente like'" & "%" + TextBox3.Text + "%" & "' order by S.Fecha desc"
        ElseIf ComboBox6.Text = "Total" Then
            FiltrarAbonos("Total like'" & "%" + TextBox3.Text + "%" & "'") '    filtro = "select S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo from abonodeventas as S where S.Total like'" & "%" + TextBox3.Text + "%" & "' order by S.Fecha desc"
        End If
    End Sub
    Private Function ObtenerTablaDeFiltroAbnosDeVentas(busqueda As String)
        Dim ds As New DataTable
        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeAbonoVentas.Select(busqueda)
        For i As Integer = 0 To 9
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaDeAbonoVentas.Columns(i).ColumnName
        Next
        For i As Integer = 0 To FoundRows.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 9
                ds.Rows(ds.Rows.Count - 1).Item(j) = CStr(FoundRows(i).Item(j))
            Next
        Next
        Return ds
    End Function
    Public Function FiltrarAbonos(busqueda As String)
        'esta funcion da la tabla de los pagos de las facturas de ventas
        Dim dt As DataTable
        dt = ObtenerTablaDeFiltroAbnosDeVentas(busqueda)

        Dim i As Integer = 0
        Form1.Facturasdeventa.DGVCobrosVentas.Rows.Clear()
        If dt.Rows.Count > 0 Then
            Form1.Facturasdeventa.DGVCobrosVentas.Rows.Add(dt.Rows.Count)
            For Each filas As DataRow In dt.Rows()
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString)
                Form1.Facturasdeventa.DGVCobrosVentas.Rows(i).Cells(8).Value = Format(Convert.ToDouble(Trim(dt.Rows(i).Item(9).ToString)), "##,##0.00")
                i = i + 1
            Next
        Else

        End If
    End Function

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "N° factura" Or ComboBox6.Text = "Cod cliente" Or ComboBox6.Text = "Cliente" Or ComboBox6.Text = "Total" Then
            ObtenerTablaDePagosVentas()
            TextBox3.Visible = True
            Label31.Visible = True
            ComboBox7.Visible = False
            Label33.Visible = False
            Label35.Visible = False
            DTPdesdeAbono.Visible = False
            Label34.Visible = False
            DTPHastaAbono.Visible = False
            Label36.Visible = False
            ComboBox8.Visible = False
        ElseIf ComboBox6.Text = "Fecha" Or ComboBox6.Text = "Fecha factura" Or ComboBox6.Text = "Fecha vencimiento" Then
            ObtenerTablaDePagosVentas()
            TextBox3.Visible = False
            Label31.Visible = False
            Label35.Visible = False
            ComboBox7.Visible = False
            Label33.Visible = True
            DTPdesdeAbono.Visible = True
            Label34.Visible = True
            DTPHastaAbono.Visible = True
            Label36.Visible = False
            ComboBox8.Visible = False
        ElseIf ComboBox6.Text = "Tipo de pago" Then
            ObtenerTablaDePagosVentas()
            TextBox3.Visible = False
            Label31.Visible = False
            Label35.Visible = True
            ComboBox7.Visible = True
            Label33.Visible = False
            DTPdesdeAbono.Visible = False
            Label34.Visible = False
            DTPHastaAbono.Visible = False
            Label36.Visible = False
            ComboBox8.Visible = False
        ElseIf ComboBox6.Text = "Saldo" Then
            ObtenerTablaDePagosVentas()
            TextBox3.Visible = False
            Label31.Visible = False
            Label35.Visible = False
            ComboBox7.Visible = False
            Label33.Visible = False
            DTPdesdeAbono.Visible = False
            Label34.Visible = False
            DTPHastaAbono.Visible = False
            Label36.Visible = True
            ComboBox8.Visible = True
        End If
    End Sub

    Public Function filtrar_abono_por_fechas()
        Dim j As Integer
        ObtenerTablaDePagosVentas()

        If ComboBox6.Text = "Fecha" Then
            j = 1
        ElseIf ComboBox6.Text = "Fecha factura" Then
            j = 2
        ElseIf ComboBox6.Text = "Fecha vencimiento" Then
            j = 6
        End If
        For i As Double = DGVCobrosVentas.Rows.Count - 1 To 0 Step -1

            If Trim(Convert.ToDateTime(Trim(DGVCobrosVentas.Rows(i).Cells(j).Value)).ToShortDateString()) <= DTPdesdeAbono.Value.AddDays(-1) Or Trim(Convert.ToDateTime(DGVCobrosVentas.Rows(i).Cells(j).Value).ToShortDateString()) >= DTPHastaAbono.Value.AddDays(1) Then
                DGVCobrosVentas.Rows.Remove(DGVCobrosVentas.Rows(i))
            End If
        Next
    End Function

    Private Sub DTPdesdeAbono_ValueChanged(sender As Object, e As EventArgs) Handles DTPdesdeAbono.ValueChanged
        filtrar_abono_por_fechas()
    End Sub

    Private Sub DTPHastaAbono_ValueChanged(sender As Object, e As EventArgs) Handles DTPHastaAbono.ValueChanged
        filtrar_abono_por_fechas()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        ObtenerTablaDePagosVentas()
        If ComboBox7.Text = "Contado" Then
            For i As Double = DGVCobrosVentas.Rows.Count - 1 To 0 Step -1
                If Trim(DGVCobrosVentas.Rows(i).Cells(5).Value) <> "Contado" Then
                    DGVCobrosVentas.Rows.Remove(DGVCobrosVentas.Rows(i))
                End If
            Next
        ElseIf ComboBox7.Text = "Credito" Then
            For i As Double = DGVCobrosVentas.Rows.Count - 1 To 0 Step -1
                If Trim(DGVCobrosVentas.Rows(i).Cells(5).Value) <> "Credito" Then
                    DGVCobrosVentas.Rows.Remove(DGVCobrosVentas.Rows(i))
                End If
            Next
        End If


    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        ObtenerTablaDePagosVentas()
        If ComboBox8.Text = "Con saldo" Then
            For i As Double = DGVCobrosVentas.Rows.Count - 1 To 0 Step -1
                If Trim(DGVCobrosVentas.Rows(i).Cells(8).Value) = 0 Then
                    DGVCobrosVentas.Rows.Remove(DGVCobrosVentas.Rows(i))
                End If
            Next
        ElseIf ComboBox8.Text = "Sin saldo" Then
            For i As Double = DGVCobrosVentas.Rows.Count - 1 To 0 Step -1
                If Trim(DGVCobrosVentas.Rows(i).Cells(8).Value) <> 0 Then
                    DGVCobrosVentas.Rows.Remove(DGVCobrosVentas.Rows(i))
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Completo()
    End Sub

    Public Function Completo()
        If CheckBox1.Checked = False Then
            DGVVentasDistri.Columns(8).Visible = False
            DGVVentasDistri.Columns(9).Visible = False
            DGVVentasDistri.Columns(10).Visible = False
            DGVVentasDistri.Columns(11).Visible = False
            DGVVentasDistri.Columns(12).Visible = False
            DGVVentasDistri.Columns(13).Visible = False
            DGVVentasDistri.Columns(14).Visible = False
            DGVVentasDistri.Columns(15).Visible = False
            DGVVentasDistri.Columns(16).Visible = True
        ElseIf CheckBox1.Checked = True Then
            DGVVentasDistri.Columns(5).Visible = True
            DGVVentasDistri.Columns(6).Visible = True
            DGVVentasDistri.Columns(7).Visible = True
            DGVVentasDistri.Columns(12).Visible = True
            DGVVentasDistri.Columns(13).Visible = True
            DGVVentasDistri.Columns(14).Visible = True
            DGVVentasDistri.Columns(15).Visible = True
            DGVVentasDistri.Columns(16).Visible = True
        End If

        If CHBIVA.Checked = True Then
            DGVVentasDistri.Columns(3).Visible = False
            DGVVentasDistri.Columns(4).Visible = False
            DGVVentasDistri.Columns(5).Visible = True
            DGVVentasDistri.Columns(6).Visible = True
            DGVVentasDistri.Columns(7).Visible = True
        Else
            DGVVentasDistri.Columns(3).Visible = True
            DGVVentasDistri.Columns(4).Visible = True
            DGVVentasDistri.Columns(5).Visible = False
            DGVVentasDistri.Columns(6).Visible = False
            DGVVentasDistri.Columns(7).Visible = False
        End If
    End Function

    Public Function estan_disponibles()
        Dim disponibilidad As Boolean = True
        For i As Double = 0 To Form1.Facturasdeventa.DGVVentasDistri.Rows.Count() - 2
            If Form1.Facturasdeventa.DGVVentasDistri.Rows(i).Cells(16).Value - Form1.Facturasdeventa.DGVVentasDistri.Rows(i).Cells(0).Value < 0 Then
                disponibilidad = False
            End If

        Next i

        Return disponibilidad
    End Function

    Public Function producto_disponible(codigo As String)
        'para ver lo que ya esta verificado
        Dim en_verificacion As Double = 0
        Dim result As DataRow() = Form1.TablaVerificados.Select("Codigo ='" & codigo & "'")
        Dim SumaVerificados As Double = 0
        If result.Length > 0 Then
            For i = 0 To result.Length
                SumaVerificados += CStr(result(i).Item(2))
            Next
        End If
        en_verificacion = SumaVerificados

        'para ver lo que ya esta alistado
        Dim en_alistados As Double = 0
        Dim result1 As DataRow() = Form1.TablaAlistados.Select("Cod ='" & codigo & "'")
        Dim SumaAlistados As Double = 0
        If result.Length > 0 Then
            For i = 0 To result.Length
                sumaAlistados += CStr(result(i).Item(2))
            Next
        End If
        en_verificacion = SumaAlistados

        'para ver lo que esa en inventario
        Dim en_inventario As Double = 0
        Dim result2 As DataRow() = Form1.TablaDeProductos.Select("Cod= '" & codigo & "'")
        en_inventario = CStr(result2(0).Item(16))

        Dim Lo_disponible As Double = en_inventario - (en_verificacion + en_alistados)
            'fin para ver lo que ya esta alistado
            Return Lo_disponible

    End Function
    'para controlar el tamaño de despliegue de los combobox de los datagridview
    Private Sub DGVVentasDistri_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVVentasDistri.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            Dim cbo As ComboBox = DirectCast(e.Control, ComboBox)
            cbo.DropDownHeight = 75
        End If
    End Sub
End Class