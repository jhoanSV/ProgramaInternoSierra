Module Actualizar
    Sub Actualizando()
        Dim UltimaVez As Date = Now ' Utilizas dos variables tipo Date y le asignas el tiempo actual del sistema
        Dim HoraActual As Date = Now
        Const Minutos = 1 'Declaras el limite de tiempo

        If DateDiff(DateInterval.Minute, UltimaVez, HoraActual) > Minutos Then ' Minutos está definido igual a 9 entonces al hacer la comparación y esta sea mayor a Minutos ejecutara el método.
            Actualizar_todo()
            '-- Aqui va el método a ejecutar
            UltimaVez = Now 'Regresas UltimaVez al tiempo actual para reiniciar el proceso

        End If
    End Sub

    Sub Actualizar_todo()
        Form1.Actualizar_productos()
        Form1.Actualizar_Categoria()
        Form1.Actualizar_SubCategoria()
        Form1.Actualizar_ubicacion()
        Form1.Actualizar_Cliente()
        Form1.Actualizar_Colaboradores()
        Form1.Actualizar_Proveedores()
        Form1.Actualizar_abonos_compras()
        Form1.Actualizar_Tabla_entradas()
        Form1.Actualizar_Tabla_ingresados()
        Form1.Actualizar_de_abonos_ventas()
        Form1.ActualizarTablaVendedores()
        Form1.ActualizarTablaDeEstadosVentas()
        Form1.ActualizarTablaDeSalidas()
        Form1.ActualizarTabla_otros_proveedores()
        Form1.Actualizar_Tabla_de_ingresados()
        Form1.Actualizar_Tabla_de_anulado()


        LlenarComboBoxSubCategoria(Form1.LisDePrecios.CBSubCategoria)
        LlenarComboBoxProovedores(Form1.LisDePrecios.CBProovedor)
        LlenarComboBoxUbicacion(Form1.LisDePrecios.CBUbicacion)
        llenarComboBoxCategoria(Form1.LisDePrecios.CBCategoria)
        cargar_CocProveedor(Form1.LisDePrecios.DGVOtrosProovedores) 'llena el campo de prodcutos del datagridview ventas.
        Form1.LisDePrecios.DGVOtrosProovedores.Columns(0).Width = 100
        Form1.LisDePrecios.DGVOtrosProovedores.Columns(1).Width = 600 'Poner el tamaño de la descripcion de los productos mas grande
        'para obtener el inventario en el datagridview sin la ultima fila que es siempre vacia
        Form1.LisDePrecios.llenar_los_productos()
        Form1.LisDePrecios.llenar_los_productos()
        Form1.Facturasdeventa.ObtenerTablaDeEstados()
        Form1.Facturasdeventa.ObtenerTablaDePagosVentas()
    End Sub

    Sub Actualizar_Ventas()
        Form1.Actualizar_Tabla_ingresados()
        Form1.Actualizar_Tabla_de_ingresados()
        Form1.Actualizar_Tabla_de_anulado()
        Form1.Actualizar_Tabla_entradas()
        Form1.ActualizarTablaDeSalidas()
        Form1.Facturasdeventa.ObtenerTablaDeEstados()
        Form1.Facturasdeventa.ObtenerTablaDePagosVentas()
    End Sub
End Module
