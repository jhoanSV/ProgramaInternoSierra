Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Listadeprecios
    'lo que va al cargar la lista de precios%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub listadeprecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexiondb.conexion.Close()
        Label23.Text = ""
        LlenarComboBoxSubCategoria(CBSubCategoria)
        llenarComboBoxProovedores(CBProovedor)
        llenarComboBoxUbicacion(CBUbicacion)
        llenarComboBoxCategoria(CBCategoria)
        cargar_CocProveedor(DGVOtrosProovedores) 'llena el campo de prodcutos del datagridview ventas.
        DGVOtrosProovedores.Columns(0).Width = 100
        DGVOtrosProovedores.Columns(1).Width = 600 'Poner el tamaño de la descripcion de los productos mas grande
        'para obtener el inventario en el datagridview sin la ultima fila que es siempre vacia
        llenar_los_productos()
        RadioButton2.Checked = True
        ComboBox2.Text = "Cod"
        Label29.Visible = False
        'fin para obtener el inventario en el datagridview sin la ultima fila que es siempre vacia
    End Sub

    Private Sub RBNuevoProducto_CheckedChanged(sender As Object, e As EventArgs) Handles RBNuevoProducto.CheckedChanged
        TabControlListaDePrecios.SelectedIndex = 0
    End Sub

    Private Sub RBModificarProducto_CheckedChanged(sender As Object, e As EventArgs) Handles RBModificarProducto.CheckedChanged
        TabControlListaDePrecios.SelectedIndex = 1
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControlListaDePrecios.SelectedIndex = 2
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TabControlListaDePrecios.SelectedIndex = 3
    End Sub

    'Fin de lo que va al cargar la lista de precios%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'TODO LO QUE VA EN EL TABPAGE 1 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'LO QUE MANEJA LOS COMBOBOX Y LISTBOX%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub CBProovedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProovedor.SelectedIndexChanged
        If CBProovedor.Text = "" Then
            MsgBox("Inserte un proveedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Proovedor ='" & CBProovedor.Text & "'")
            If result.Length > 0 Then
                TBCodigoProovedor.Text = CStr(result(0).Item(0))
            Else
                MsgBox("El proovedor no existe")
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUniPaquete.TextChanged
        'no permite que pongan un valor distinto a 1 cuando el producto se da por Unidad.
        If CBUniPaquete.Text = "Unidad" Then
            TextBoxUniPaquete.Text = 1
        End If
    End Sub

    Private Sub CBUniPaquete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUniPaquete.SelectedIndexChanged
        'Pone de forma inmediata el 1 cuando se pone que el producto viene por unidad.
        If CBUniPaquete.Text = "Unidad" Then
            TextBoxUniPaquete.Text = "1"
        End If
    End Sub

    Private Sub TBPventa_TextChanged(sender As Object, e As EventArgs) Handles TBPventa.TextChanged
        'calcula el porcentaje segun el costo y el precio de venta que pongan
        Dim pcosto As Double
        Dim pventa As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa.Text = "" Then
        ElseIf TBPcostoLprecios.Text = "" Or TBPcostoLprecios.Text = "0" Then
            MsgBox("Ingrese un costo mayor a cero")
        ElseIf TBPventa.Text = "" Then

            TBPventa.Text = "0"
        Else
            pcosto = Convert.ToDouble(TBPcostoLprecios.Text)
            pventa = Convert.ToDouble(TBPventa.Text)
            If TBPcostoLprecios.Text <> "" And TBPventa.Text <> "" Then
                d = ((pventa - pcosto) / pcosto) * 100
                mi = Math.Round(d, 2)
                TBGananciaLprecios.Text = mi
            End If
        End If
    End Sub

    Private Sub TBPcostoLprecios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPcostoLprecios.KeyPress
        'para darle formato de numero a lo que escriben en TBPcostoLprecios
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBPventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPventa.KeyPress
        'para darle formato de numero a lo que escriben en TBPventa
        Form1.Solo_numeros(e)

    End Sub

    Private Sub TBGananciaLprecios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGananciaLprecios.KeyPress
        'para darle formato de numero a lo que escriben en TBGananciaLprecios
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBPcostoLprecios_Leave(sender As Object, e As EventArgs) Handles TBPcostoLprecios.Leave
        'le da formato de moneda a TBPcostoLprecios
        If TBPcostoLprecios.Text = "" Then
            TBPcostoLprecios.Text = ""
        Else
            TBPcostoLprecios.Text = Format(Val(CDec(TBPcostoLprecios.Text)), "##,##0.00")
        End If
    End Sub

    Private Sub TBPventa_Leave(sender As Object, e As EventArgs) Handles TBPventa.Leave
        'para darle formato de moneda al TBventa
        If TBPventa.Text = "" Then
            TBPventa.Text = ""
        Else
            TBPventa.Text = Format(Val(CDec(TBPventa.Text)), "##,##0.00")
        End If
    End Sub

    Private Sub TBGananciaLprecios_Leave(sender As Object, e As EventArgs) Handles TBGananciaLprecios.Leave
        'calcula el porcentage de ganancia en TBGananciaLprecios
        Dim pcostos As Double
        Dim pventas As Double
        Dim porcenganancias As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa.Text = "" Then
            TBGananciaLprecios.Text = ""
        ElseIf TBPcostoLprecios.Text = "" Then
            MsgBox("Ingrese un costo al producto")
        ElseIf TBPcostoLprecios.Text = "0" Or TBGananciaLprecios.Text = "-" Then
            TBGananciaLprecios.Text = ""
        ElseIf TBGananciaLprecios.Text = "" Then
            TBGananciaLprecios.Text = "0"
        ElseIf TBGananciaLprecios.Text <> "" And TBPventa.Text = "" Then
            TBPventa.Text = "0"
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa.Text
            porcenganancias = TBGananciaLprecios.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)
            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa.Text = pventas
            End If
        Else
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa.Text
            porcenganancias = TBGananciaLprecios.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)

            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa.Text = pventas
            End If
        End If
    End Sub

    Private Sub TBCodigoProovedor_Leave(sender As Object, e As EventArgs) Handles TBCodigoProovedor.Leave
        If TBCodigoProovedor.Text = "" Then
            MsgBox("Inserte un proveedor") 'verifica si la casilla codigo esta vacia y en caso de que lo este manda un mensaje
        Else
            Dim result As DataRow() = Form1.TablaProveedores.Select("Cod ='" & TBCodigoProovedor.Text & "'")
            If result.Length > 0 Then
                CBProovedor.Text = CStr(result(0).Item(2))
            Else
                MsgBox("El proovedor no existe")
            End If
        End If
    End Sub

    Private Sub TBPventa1_Leave(sender As Object, e As EventArgs) Handles TBPventa1.Leave
        'para darle formato de moneda al TBventa1
        If TBPventa1.Text = "" Then
            TBPventa1.Text = ""
        Else
            TBPventa1.Text = Format(Val(CDec(TBPventa1.Text)), "##,##0.00")
        End If
    End Sub

    Private Sub TBPventa2_Leave(sender As Object, e As EventArgs) Handles TBPventa2.Leave
        'para darle formato de moneda al TBventa2
        If TBPventa2.Text = "" Then
            TBPventa2.Text = ""
        Else
            TBPventa2.Text = Format(Val(CDec(TBPventa2.Text)), "##,##0.00")
        End If
    End Sub

    Private Sub TBPventa1_TextChanged(sender As Object, e As EventArgs) Handles TBPventa1.TextChanged
        'le da el formato y calcula la ganancia con respecto al TBPventa1
        Dim pcosto As Double
        Dim pventa As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa1.Text = "" Then
        ElseIf TBPcostoLprecios.Text = "" Or TBPcostoLprecios.Text = "0" Then
            MsgBox("Ingrese un costo mayor a cero")
        ElseIf TBPventa1.Text = "" Then
            TBPventa1.Text = "0"
        Else
            pcosto = TBPcostoLprecios.Text
            pventa = TBPventa1.Text
            If TBPcostoLprecios.Text <> "" And TBPventa1.Text <> "" Then
                d = ((pventa - pcosto) / pcosto) * 100
                mi = Math.Round(d, 2)
                TBGananciaLprecios1.Text = mi
            End If
        End If
    End Sub

    Private Sub TBPventa1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPventa1.KeyPress
        'le da formato de numero al TBPventa1
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBPventa2_TextChanged(sender As Object, e As EventArgs) Handles TBPventa2.TextChanged
        'le da el formato y calcula la ganancia con respecto al TBPventa2
        Dim pcosto As Double
        Dim pventa As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa2.Text = "" Then
        ElseIf TBPcostoLprecios.Text = "" Or TBPcostoLprecios.Text = "0" Then
            MsgBox("Ingrese un costo mayor a cero")
        ElseIf TBPventa2.Text = "" Then
            TBPventa2.Text = "0"
        Else
            pcosto = TBPcostoLprecios.Text
            pventa = TBPventa2.Text
            If TBPcostoLprecios.Text <> "" And TBPventa2.Text <> "" Then
                d = ((pventa - pcosto) / pcosto) * 100
                mi = Math.Round(d, 2)
                TBGananciaLprecios2.Text = mi
            End If
        End If
    End Sub

    Private Sub TBPventa2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPventa2.KeyPress
        'le da formato de numero al TBPventa2
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBGananciaLprecios1_Leave(sender As Object, e As EventArgs) Handles TBGananciaLprecios1.Leave
        'calcula la ganancia y le da formato de moneda al TBGananciaLprecios2
        Dim pcostos As Double
        Dim pventas As Double
        Dim porcenganancias As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa1.Text = "" Then
            TBGananciaLprecios1.Text = ""
        ElseIf TBPcostoLprecios.Text = "" Then
            MsgBox("Ingrese un costo al producto")
        ElseIf TBPcostoLprecios.Text = "0" Or TBGananciaLprecios1.Text = "-" Then
            TBGananciaLprecios1.Text = ""
        ElseIf TBGananciaLprecios1.Text = "" Then
            TBGananciaLprecios1.Text = "0"
        ElseIf TBGananciaLprecios1.Text <> "" And TBPventa1.Text = "" Then
            TBPventa1.Text = "0"
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa1.Text
            porcenganancias = TBGananciaLprecios1.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)
            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa1.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa1.Text = pventas
            End If
        Else
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa1.Text
            porcenganancias = TBGananciaLprecios1.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)

            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa1.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa1.Text = pventas
            End If
        End If
    End Sub

    Private Sub TBGananciaLprecios1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGananciaLprecios1.KeyPress
        'para darle formato de numero a lo que escriben en TBGananciaLprecios1
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBGananciaLprecios2_Leave(sender As Object, e As EventArgs) Handles TBGananciaLprecios2.Leave
        'calcula la ganancia y le da formato de moneda al TBGananciaLprecios2
        Dim pcostos As Double
        Dim pventas As Double
        Dim porcenganancias As Double
        Dim d As Double
        Dim mi As Double

        If TBPcostoLprecios.Text = "" And TBPventa2.Text = "" Then
            TBGananciaLprecios2.Text = ""
        ElseIf TBPcostoLprecios.Text = "" Then
            MsgBox("Ingrese un costo al producto")
        ElseIf TBPcostoLprecios.Text = "0" Or TBGananciaLprecios2.Text = "-" Then
            TBGananciaLprecios2.Text = ""
        ElseIf TBGananciaLprecios2.Text = "" Then
            TBGananciaLprecios2.Text = "0"
        ElseIf TBGananciaLprecios2.Text <> "" And TBPventa2.Text = "" Then
            TBPventa2.Text = "0"
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa2.Text
            porcenganancias = TBGananciaLprecios2.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)
            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa2.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa2.Text = pventas
            End If
        Else
            pcostos = TBPcostoLprecios.Text
            pventas = TBPventa2.Text
            porcenganancias = TBGananciaLprecios2.Text
            d = ((pventas - pcostos) / pcostos) * 100
            mi = Math.Round(d, 2)

            If porcenganancias <> mi Then '((pventas - pcostos) / pcostos) * 100 Then
                TBPventa2.Text = Math.Round(pcostos + ((porcenganancias / 100) * pcostos), 2)
            Else
                TBPventa2.Text = pventas
            End If
        End If
    End Sub

    Private Sub TBGananciaLprecios2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGananciaLprecios2.KeyPress
        'para darle formato de numero a lo que escriben en TBGananciaLprecios2
        Form1.Solo_numeros(e)
    End Sub
    'Fin de LO QUE MANEJA LOS COMBOBOX Y LISTBOX%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'Botones %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonCancelarNProovedor_Click(sender As Object, e As EventArgs) Handles ButtonCancelarNProovedor.Click
        Limpiar_lista_de_precios()
    End Sub

    Private Sub NuevoProducto_Click(sender As Object, e As EventArgs) Handles NuevoProducto.Click
        'Este boton es para agregar los nuevos productos tanto a la lista de productos, a la lista de entradas y a la lista de otros proveedores
        If TBCodigoProductos.Text = "" Or TBDescripcion.Text = "" Then
            MsgBox("Falta insertar un codigo o la descripción") 'Pregunta se la casilla Codigo o Proovedor esta vacia y en casi de que sea asi manda un mensage
        Else
            Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & TextBoxCodigoEProducto.Text & "'")
            If result.Length > 0 Then
                MsgBox("El producto ya existe, intente con otro codigo")
            Else
                'Ingresa los datos en la tabla de productos
                Form1.Consultar("insert into productos values ('" & TBCodigoProductos.Text & "', '" & TBDescripcion.Text & "', '" & CBUniPaquete.Text & "','" & TextBoxUniPaquete.Text & "','" & CBCategoria.Text & "', '" & CBSubCategoria.Text & "', '" & TBCodigoProovedor.Text & "', '" & CBProovedor.Text & "','" & TBPcostoLprecios.Text & "', '" & TBPventa.Text & "','" & TBGananciaLprecios.Text & "', '" & TBPventa1.Text & "','" & TBGananciaLprecios1.Text & "', '" & TBPventa2.Text & "','" & TBGananciaLprecios2.Text & "' , '" & CBUbicacion.Text & "', '" & NumericUpDownCantidad.Text & "', '" & NumericUpDownMinimo.Value & "', '" & NumericUpDownMaximo.Value & "', '" & TBNotaProductos.Text & "')")
                Dim Cod As String
                Dim CodP As String
                Dim Proveedor As String
                Dim PCosto As String
                Dim Cantidad As String
                Dim Ganancia As String
                Dim cadena_de_insercion As String
                For i As Integer = 0 To DGVOtrosProovedores.Rows.Count - 2
                    Cod = TBCodigoProductos.Text
                    CodP = Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Cod").Value)
                    Proveedor = Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Proovedor").Value)
                    PCosto = Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("PCosto").Value)
                    Cantidad = Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Cantidad").Value)
                    Ganancia = Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Ganancia").Value)

                    cadena_de_insercion = "('" & Cod & "',
                                            '" & CodP & "',
                                            '" & Proveedor & "',
                                            '" & PCosto & "',
                                            '" & Cantidad & "',
                                            '" & Ganancia & "')"
                    Form1.A_tablas("otrosproveedores", cadena_de_insercion)
                Next
                'Ingresa los datos en la tabla de entradas
                Dim cadena_de_insercion1 As String = "('" & "000" & "',
                                        '" & "" & "',
                                        '" & "000" & "',
                                        '" & "Nuevo Producto al inventario" & "',
                                        '" & NumericUpDownCantidad.Text & "',
                                        '" & TBCodigoProductos.Text & "',
                                        '" & TBDescripcion.Text & "',
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
                'ingresa datos en la tabla salidas
                Dim cadena_de_insercion2 As String = "('" & "000" & "',
                                        '" & "" & "',
                                        '" & 0 & "',
                                        '" & TBCodigoProductos.Text & "',
                                        '" & TBDescripcion.Text & "',
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
                                        '" & "Nuevo producto al inventario" & "',
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
                'Limpia todas las casillas de la lista de precios
                'Ingresa la tabla de otros proveedores
                IngresarEnOtrosProeedores()
                Form1.Actualizar_productos()
                Form1.ActualizarTabla_otros_proveedores()
                llenar_los_productos()
                MsgBox("Se registro correctamente")
                Limpiar_lista_de_precios()
            End If

        End If
    End Sub
    Private Sub IngresarEnOtrosProeedores()
        'Para actualizar la tabla de otros proveedores%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'primero se eliminan todos los datos antiuos de los otro proveedores
        Form1.Consultar("delete from otrosproveedores Where Cod = '" & TBCodigoProductos.Text & "'")
        'luego se agregan todos los nuevos datos
        For i As Integer = 0 To DGVOtrosProovedores.Rows.Count - 2
            Dim cadena_de_insercion As String = "('" & TBCodigoProductos.Text & "',
                                               '" & Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Cod").Value) & "',
                                               '" & Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Proovedor").Value) & "',
                                               '" & Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("PCosto").Value) & "',
                                               '" & Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Cantidad").Value) & "',
                                               '" & Convert.ToString(DGVOtrosProovedores.Rows.Item(i).Cells("Ganancia").Value) & "')"
            Form1.A_tablas("otrosproveedores", cadena_de_insercion)
        Next

    End Sub
    Private Sub Limpiar_lista_de_precios()
        TBCodigoProductos.Clear()
        TBDescripcion.Clear()
        CBUniPaquete.Text = ""
        TextBoxUniPaquete.Clear()
        CBCategoria.Text = ""
        CBSubCategoria.Text = ""
        TBPcostoLprecios.Clear()
        TBPventa.Clear()
        TBGananciaLprecios.Clear()
        TBPventa1.Clear()
        TBGananciaLprecios1.Clear()
        TBPventa2.Clear()
        TBGananciaLprecios2.Clear()
        CBProovedor.Text = ""
        TBCodigoProovedor.Text = ""
        CBUbicacion.Text = ""
        NumericUpDownCantidad.Text = 0
        NumericUpDownMinimo.Value = 0
        NumericUpDownMaximo.Value = 0
        TBNotaProductos.Clear()
        DGVOtrosProovedores.Rows.Clear() 'para limpiar el datagridview de otros proveedores
        llenar_los_productos()
        cargar_DataCombo(Form1.Facturasdeventa.DGVVentasDistri)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProducto.Click
        'muestra la ventana de busqueda de productos
        Dim frm As New BusquedaProLDePrecios()
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        'Modifica las especificaciones del producto
        If TBCodigoProductos.Text = "" Then
            MsgBox("Inserte un codigo")
        ElseIf NumericUpDownCantidad.Text = "" Then
            MsgBox("Inserte una cantidad")
        Else
            Dim Diferencia As Double
            Dim Inventario As Double = Form1.Cantidad_del_producto(Trim(TBCodigoProductos.Text)) 'Convert.ToDouble(dt.Rows(0).Item(0).ToString)
            Dim Nuevo As Double = Convert.ToDouble(NumericUpDownCantidad.Text)
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
                                        '" & TBCodigoProductos.Text & "',
                                        '" & TBDescripcion.Text & "',
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
                                        '" & TBCodigoProductos.Text & "',
                                        '" & TBDescripcion.Text & "',
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

            'fin de Parte del cogigo para cuadrar el inventario
            Form1.Consultar("update productos set Descripcion = '" & TBDescripcion.Text & "', UnidadOpaquete = '" & CBUniPaquete.Text & "', EsUnidadOpaquete = '" & TextBoxUniPaquete.Text & "', Categoria = '" & CBCategoria.Text & "', SubCategoria = '" & CBSubCategoria.Text & "', CodProovedor = '" & TBCodigoProovedor.Text & "', Proovedor = '" & CBProovedor.Text & "', PCosto =  '" & TBPcostoLprecios.Text & "' , PVenta =  '" & TBPventa.Text & "' , Ganancia = '" & TBGananciaLprecios.Text & "', PVenta1 =  '" & TBPventa1.Text & "' , Ganancia1 = '" & TBGananciaLprecios1.Text & "', PVenta2 =  '" & TBPventa2.Text & "' , Ganancia2 = '" & TBGananciaLprecios2.Text & "', Ubicación = '" & CBUbicacion.Text & "', Cantidad = '" & NumericUpDownCantidad.Text & "', Minimo = '" & NumericUpDownMinimo.Value & "', Maximo = '" & NumericUpDownMaximo.Value & "', Nota = '" & TBNotaProductos.Text & "' Where Cod = '" & TBCodigoProductos.Text & "'")
            Form1.Actualizar_productos()
            'Actualiza los datos en otros proveedores
            IngresarEnOtrosProeedores()
            Form1.ActualizarTabla_otros_proveedores()
            'Fin para actualizar la tabla de otros proveedores%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'Cuando todo sale bien
            MsgBox("Los datos se actualizaron correctamente.") 'modifica los datos que se encuentren asociados al valor de la casilla codigo.
            Form1.Actualizar_productos()
            llenar_los_productos()
            Limpiar_lista_de_precios()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'muestra la ventana de buscar el lista de precios
        Dim frm As New BuscarEnListaDePrecios()
        frm.Show()
    End Sub


    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'LO que va adentro del DGV otros proveedores %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'intento para que solo lea numeros en los campos deseados

    'fin de intento para que solo lea numeros en los campos deseados

    Private Sub DGVOtrosProovedores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOtrosProovedores.CellEndEdit
        'le da los formatos al DGV otros proveedores
        If e.ColumnIndex = 1 Then

            If DGVOtrosProovedores.Rows(e.RowIndex).Cells("Proovedor").Value IsNot Nothing Then
                Dim NomProducto As String
                NomProducto = DGVOtrosProovedores.Rows(e.RowIndex).Cells("Proovedor").Value 'Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaProveedores.Select("Proovedor ='" & NomProducto & "'")
                If result.Length > 0 Then
                    'algo nuevo que intento hacer para que cuando cambie el combobox tambien cambie la parte del codigo
                    Dim dgvc As DataGridViewTextBoxCell
                    dgvc = DGVOtrosProovedores.Rows(e.RowIndex).Cells(0)
                    dgvc.Value = CStr(result(0).Item(0)) 'Me trae el codigo del proveedor segun el que se selecciono
                End If
            End If
        End If

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim validar As Boolean = False

        If DGVOtrosProovedores.Columns(e.ColumnIndex).Name = "PCosto" Or DGVOtrosProovedores.Columns(e.ColumnIndex).Name = "Cantidad" Then
            If TBPventa.Text = "" Then
                MsgBox("Ingrese un valor de venta")
            Else

                If DGVOtrosProovedores.Rows(e.RowIndex).Cells("PCosto").Value = "" Then
                    DGVOtrosProovedores.Rows(e.RowIndex).Cells("PCosto").Value = "0"
                End If


                For Each caracter In DGVOtrosProovedores.CurrentCell.Value
                    If InStr(1, "0123456789,.", caracter) > 0 Then
                        Continue For
                    Else
                        MsgBox("ingrese un valor valido")
                        DGVOtrosProovedores.CurrentCell.Value = "0"
                        DGVOtrosProovedores.CurrentCell.Value = Format(a, "##,##0.00")
                        validar = True
                    End If
                Next

                If validar = False Then
                    a = Convert.ToDouble(DGVOtrosProovedores.Rows(e.RowIndex).Cells("PCosto").Value)
                    b = Convert.ToDouble(DGVOtrosProovedores.Rows(e.RowIndex).Cells("Cantidad").Value)
                    c = Convert.ToDouble(TBPventa.Text)

                    d = ((c - a) / a) * 100

                    DGVOtrosProovedores.Rows(e.RowIndex).Cells("PCosto").Value = Format(a, "##,##0.00")
                    DGVOtrosProovedores.Rows(e.RowIndex).Cells("Cantidad").Value = Format(b, "##,##0.00")
                    DGVOtrosProovedores.Rows(e.RowIndex).Cells("Ganancia").Value = Format(d, "##,##0.00")

                End If

            End If
        End If
    End Sub

    Private Sub DGVOtrosProovedores_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVOtrosProovedores.CellFormatting
        ' le da formato al DGV de otros proveedores segun el cogigo que introduzcan

        If e.ColumnIndex = 0 Then
            If e.Value IsNot Nothing Then
                Dim codProducto As String
                codProducto = Convert.ToString(e.Value) 'para encontrar el valor de lo que ponga en el producto
                Dim result As DataRow() = Form1.TablaProveedores.Select("Cod ='" & codProducto & "'")

                If result.Length > 0 Then
                    Dim dgvcc As DataGridViewComboBoxCell
                    dgvcc = DGVOtrosProovedores.Rows(e.RowIndex).Cells(1)
                    Dim Ccol As DataGridViewComboBoxColumn = CType(DGVOtrosProovedores.Columns(1), DataGridViewComboBoxColumn)

                    dgvcc.Value = CStr(result(0).Item(2)) 'Me trae el codigo del producto segun el que se selecciono
                End If
            End If
        End If

    End Sub

    'FIN DE TODO LO QUE VA EN EL TABPAGE 1 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'TODO LO QUE VA EN EL TABPAGE 2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonCancelarEProdutos_Click(sender As Object, e As EventArgs) Handles ButtonCancelarEProdutos.Click
        'boton que borra los CB para eliminar productos
        TextBoxCodigoEProducto.Text = ""
        TextBoxEproducto.Text = ""
        TextBoxUbicaciónEProducto.Text = ""
    End Sub

    Private Sub ButtonBuscarEliminarProducto_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEliminarProducto.Click
        'busca y llena los datos del producto que se busca eliminar
        Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & TextBoxCodigoEProducto.Text & "'")
        If TextBoxCodigoEProducto.Text = "" Then
            MsgBox("Inserte un codigo")
        Else
            If result.Length > 0 Then
                TextBoxEproducto.Text = CStr(result(0).Item(1))
                TextBoxUbicaciónEProducto.Text = CStr(result(0).Item(17))
            Else
                MsgBox("El producto no existe")
            End If
        End If

    End Sub

    Private Sub ButtonEliminarProducto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProducto.Click
        'elimina el producto segun el codigo que elcuentre 
        If TextBoxCodigoEProducto.Text = "" Then
            MsgBox("Inserte un codigo")
        Else
            Form1.Consultar("delete from productos Where Cod = '" & TextBoxCodigoEProducto.Text & "'")
            MsgBox("Se elimino el producto correctamente")

            TextBoxCodigoEProducto.Text = ""
            TextBoxEproducto.Text = ""
            TextBoxUbicaciónEProducto.Text = ""
            Form1.Actualizar_productos()
            llenar_los_productos()
            DGVLDePrecios.AllowUserToAddRows = False
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TODO LO QUE VA EN EL TABPAGE 2 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'TODO LO QUE VA EN EL TABPAGE 3 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    'funciones %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonExportarAExcelColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        llenarExcel(DGVLDePrecios)
    End Sub

    Private Sub NumericUpDownCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDownCantidad.KeyPress
        'para darle formato de numero a lo que escriben en TBPcostoLprecios
        Form1.Solo_numeros(e)
    End Sub

    Private Sub TBCodigoProductos_TextChanged(sender As Object, e As EventArgs) Handles TBCodigoProductos.TextChanged
        Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & TBCodigoProductos.Text & "'")
        If result.Length > 0 Then
            Label23.Text = "El codigo ya existe"
        Else
            Label23.Text = ""
        End If
    End Sub

    Public Function llenar_los_productos()
        'prueba de mostrar la tabla
        Form1.LisDePrecios.DGVLDePrecios.Rows.Clear()
        If Form1.TablaDeProductos.Rows.Count > 0 Then
            Form1.LisDePrecios.DGVLDePrecios.Rows.Add(Form1.TablaDeProductos.Rows.Count)
            For i As Double = 0 To Form1.TablaDeProductos.Rows.Count - 1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(0).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(0).ToString) 'Cod
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(1).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(1).ToString) 'descripción
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(2).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(2).ToString) 'UnidadOpaquete
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(3).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(3).ToString) 'Unidad/paquete
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(4).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(4).ToString) 'Categoria
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(5).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(5).ToString) 'Sub categoria
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(6).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(6).ToString) 'Cod proveedor
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(7).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(7).ToString) 'Proveedor
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(8).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(8).ToString) 'P costo
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(9).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(9).ToString) 'P venta
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(10).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(10).ToString) 'Ganancia
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(11).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(11).ToString) 'P venta1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(12).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(12).ToString) 'Ganancia1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(13).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(13).ToString) 'P venta 2
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(14).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(14).ToString) 'Ganancia2
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(15).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(15).ToString) 'Ubicación
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(16).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(16).ToString)
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(17).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(17).ToString) 'Minimo
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(18).Value = Trim(Form1.TablaDeProductos.Rows(i).Item(18).ToString) 'Ubicación
            Next
        End If
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        llenar_los_productos()
        filtrar_los_productos()
        If ComboBox1.Text = "Bajo de inventario" Then
            TextBox1.Visible = False
            llenar_los_productos()
            If DGVLDePrecios.Rows.Count - 1 <> 0 Then
                For i As Integer = DGVLDePrecios.Rows.Count - 2 To 0 Step -1
                    Dim cantidad As Double = Convert.ToDouble(Convert.ToInt32(DGVLDePrecios.Rows(i).Cells(16).Value)) 'Convert.ToDouble(CStr(result(0).Item(16))) 'Convert.ToDouble(Convert.ToInt32(DGVLDePrecios.Rows(i).Cells(16).Value))
                    Dim minimo As Double = Convert.ToDouble(Convert.ToInt32(DGVLDePrecios.Rows(i).Cells(17).Value))
                    If cantidad >= minimo Then
                        DGVLDePrecios.Rows.Remove(DGVLDePrecios.Rows(i))
                    End If
                Next
            End If
        Else
            TextBox1.Visible = True
            llenar_los_productos()
            filtrar_los_productos()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        filtrar_los_productos()
    End Sub
    Private Function Filtrar(fila As DataRow())
        Dim ds As New DataTable
        For i As Integer = 0 To 18
            ds.Columns.Add()
            ds.Columns(i).ColumnName = Form1.TablaDeProductos.Columns(i).ColumnName
        Next
        For i As Integer = 0 To fila.Count - 1
            ds.Rows.Add()
            For j As Integer = 0 To 18
                Dim celda As String
                If IsDBNull(fila(i).Item(j)) Then
                    celda = ""
                Else
                    celda = CStr(fila(i).Item(j))
                End If
                ds.Rows(ds.Rows.Count - 1).Item(j) = celda 'CStr(fila(i).Item(j))
            Next
        Next
        Return ds
    End Function
    Public Function filtrar_los_productos()

        Dim Cadena_de_filtro As String = "Cod like'" & "%" + "" + "%" & "'"

        If ComboBox1.Text = "" Then
            Cadena_de_filtro = "Cod like'" & "%" + "" + "%" & "'"
        ElseIf ComboBox1.Text = "Cod" Then
            Cadena_de_filtro = "Cod like'" & "%" + TextBox1.Text + "%" & "'"
        ElseIf ComboBox1.Text = "Descripción" Then
            Cadena_de_filtro = "descripcion like'" & "%" + TextBox1.Text + "%" & "'"
        ElseIf ComboBox1.Text = "Sub categoria" Then
            Cadena_de_filtro = "SubCategoria like'" & "%" + TextBox1.Text + "%" & "'"
        ElseIf ComboBox1.Text = "Proveedor" Then
            Cadena_de_filtro = "Proovedor like'" & "%" + TextBox1.Text + "%" & "'" 
        ElseIf ComboBox1.Text = "P.venta" Then
            Cadena_de_filtro = "PVenta like'" & "%" + TextBox1.Text + "%" & "'"
        End If

        Dim FoundRows() As DataRow
        FoundRows = Form1.TablaDeProductos.Select(Cadena_de_filtro)
        Dim dt As DataTable
        dt = Filtrar(FoundRows)

        Form1.LisDePrecios.DGVLDePrecios.Rows.Clear()
        If dt.Rows.Count > 0 Then
            Form1.LisDePrecios.DGVLDePrecios.Rows.Add(dt.Rows.Count)
            For i As Double = 0 To dt.Rows.Count - 1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(0).ToString) 'Cod
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(1).ToString) 'descripción
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(2).ToString) 'UnidadOpaquete
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(3).ToString) 'Unidad/paquete
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(4).Value = Trim(dt.Rows(i).Item(4).ToString) 'Categoria
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(5).Value = Trim(dt.Rows(i).Item(5).ToString) 'Sub categoria
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(6).Value = Trim(dt.Rows(i).Item(6).ToString) 'Cod proveedor
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(7).Value = Trim(dt.Rows(i).Item(7).ToString) 'Proveedor
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(8).Value = Trim(dt.Rows(i).Item(8).ToString) 'P costo
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(9).Value = Trim(dt.Rows(i).Item(9).ToString) 'P venta
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(10).Value = Trim(dt.Rows(i).Item(10).ToString) 'Ganancia
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(11).Value = Trim(dt.Rows(i).Item(11).ToString) 'P venta1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(12).Value = Trim(dt.Rows(i).Item(12).ToString) 'Ganancia1
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(13).Value = Trim(dt.Rows(i).Item(13).ToString) 'P venta 2
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(14).Value = Trim(dt.Rows(i).Item(14).ToString) 'Ganancia2
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(15).Value = Trim(dt.Rows(i).Item(15).ToString) 'Ubicación
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(16).Value = Trim(dt.Rows(i).Item(16).ToString) 'Minimo
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(17).Value = Trim(dt.Rows(i).Item(17).ToString) 'Minimo
                Form1.LisDePrecios.DGVLDePrecios.Rows(i).Cells(18).Value = Trim(dt.Rows(i).Item(18).ToString) 'Ubicación

            Next

        End If
    End Function

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If
        valor_del_verificado()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            RadioButton2.Checked = False
            RadioButton4.Checked = False
        End If
        Valor_del_verificado()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        End If
        Valor_del_verificado()
    End Sub

    Public Function Verificar_precios(busqueda As String)
        Dim result As DataRow() = Form1.TablaDeProductos.Select("Cod ='" & busqueda & "'")
        Dim valor As String
        If ComboBox2.Text = "Cod" Then
            result = Form1.TablaDeProductos.Select("Cod ='" & busqueda & "'")
        ElseIf ComboBox2.Text = "Descripción" Then
            result = Form1.TablaDeProductos.Select("Descripcion ='" & busqueda & "'")
        End If

        If result.Length > 0 Then
            valor = CStr(result(0).Item(9))
            If RadioButton2.Checked = True Then
                valor = CStr(result(0).Item(9))
            ElseIf RadioButton3.Checked = True Then
                valor = CStr(result(0).Item(11))
            ElseIf RadioButton4.Checked = True Then
                valor = CStr(result(0).Item(13))
            End If
        Else
            valor = ""
        End If

        Return valor

    End Function

    Public Sub Valor_del_verificado()
        If Verificar_precios(TextBox2.Text) <> "" Then
            Label28.Text = "$" & Format(Convert.ToDouble(Verificar_precios(TextBox2.Text)), "##,##0.00")
            Label29.Visible = False
        ElseIf Verificar_precios(TextBox2.Text) = "" Then
            Label28.Text = "$ Producto no encontrado"
            Label29.Visible = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Valor_del_verificado()
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Valor_del_verificado()
    End Sub

    Private Sub DGVLDePrecios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVLDePrecios.CellFormatting
        If e.ColumnIndex = 16 Then
            If DGVLDePrecios.Rows.Count > 0 Then
                Try
                    Dim cantidad As Double = Convert.ToDouble(DGVLDePrecios.Rows(e.RowIndex).Cells(16).Value)
                    Dim minimo As Double = Convert.ToDouble(DGVLDePrecios.Rows(e.RowIndex).Cells(17).Value)
                    If cantidad <= minimo Then
                        e.CellStyle.BackColor = Color.OrangeRed
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub DGVOtrosProovedores_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVOtrosProovedores.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            Dim cbo As ComboBox = DirectCast(e.Control, ComboBox)
            cbo.DropDownHeight = 75
        End If
    End Sub

    Private Sub TextBoxUniPaquete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUniPaquete.KeyPress
        Form1.Solo_numeros(e)
    End Sub
    Public Sub ConsultarProductos(dt As DataGridViewRow) 'i As Integer)
        TBCodigoProductos.Text = Trim(CStr(dt.Cells(0).Value))
        TBDescripcion.Text = Trim(CStr(dt.Cells(1).Value))
        CBUniPaquete.Text = Trim(CStr(dt.Cells(2).Value))
        TextBoxUniPaquete.Text = Trim(CStr(dt.Cells(3).Value))
        CBCategoria.Text = Trim(CStr(dt.Cells(4).Value))
        CBSubCategoria.Text = Trim(CStr(dt.Cells(5).Value))
        TBCodigoProovedor.Text = Trim(CStr(dt.Cells(6).Value))
        CBProovedor.Text = Trim(CStr(dt.Cells(7).Value))
        TBPcostoLprecios.Text = Trim(CStr(dt.Cells(8).Value))
        TBPventa.Text = Trim(CStr(dt.Cells(9).Value))
        TBGananciaLprecios.Text = Trim(CStr(dt.Cells(10).Value))
        TBPventa1.Text = Trim(CStr(dt.Cells(11).Value))
        TBGananciaLprecios1.Text = Trim(CStr(dt.Cells(12).Value))
        TBPventa2.Text = Trim(CStr(dt.Cells(13).Value))
        TBGananciaLprecios2.Text = Trim(CStr(dt.Cells(14).Value))
        CBUbicacion.Text = Trim(CStr(dt.Cells(15).Value))
        NumericUpDownCantidad.Text = Trim(CStr(dt.Cells(16).Value))
        NumericUpDownMinimo.Value = Trim(CStr(dt.Cells(17).Value))
        NumericUpDownMaximo.Value = Trim(CStr(dt.Cells(18).Value))
        TBNotaProductos.Text = Trim(CStr(dt.Cells(19).Value))
        'codigo para llenar el campo de en inventario
    End Sub

    Private Sub DGVLDePrecios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLDePrecios.CellContentClick
        Convert.ToDouble(DGVLDePrecios.Rows(e.RowIndex).Cells(16).Value)
    End Sub
    'Fin de funciones %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FIN DE TODO LO QUE VA EN EL TABPAGE 3 &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

End Class