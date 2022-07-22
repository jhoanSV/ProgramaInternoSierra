Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Public Class Form1
    Public FacCompras As New Facturasdecompra()
    Public LisDePrecios As New Listadeprecios()
    Public Facturasdeventa As New FacturasDeVentas()
    Public AlistarPedidos As New ListaDeAlistarPelidos()
    Public ListaDePendientes As New ListaDePendientes()
    Public verificacion As New VerificarAlistamiento()
    Public Cliente As New Clientes()
    Public FacImprimir As New factura()
    Public provee As New Proovedores()
    Public estudio As New Estudios()
    Public Configuracion As New Configuracion()
    Public AlistarPedidos_activo As Boolean = False
    Public ListaDePendientes_activo As Boolean = False
    Public verificacion_activo As Boolean = False
    Public TablaDeProductos As DataTable = Tablas("SELECT p.Cod, p.descripcion, p.UnidadOpaquete, p.EsUnidadOpaquete, p.Categoria, p.SubCategoria, p.CodProovedor, p.Proovedor, p.PCosto, p.PVenta, p.Ganancia, p.Pventa1, p.Ganancia1, p.Pventa2, p.Ganancia2, p.Ubicación, (SELECT (SELECT SUM(Cantidad) FROM entradas WHERE Codigo= p.Cod)-(SELECT SUM(Cantidad) FROM salidas WHERE Codigo= p.Cod)) AS cantidad, p.Minimo, p.Maximo, p.Nota FROM productos AS p")
    Public TablaDeCategorias As DataTable = Tablas("select Categoria from categoria")
    Public TablaDeSubCategoria As DataTable = Tablas("select SubCategoria from subcategorias")
    Public TablaDeUbicaciones As DataTable = Tablas("select Ubicacion from ubicaciones")
    Public TablaDeProveedores As DataTable = Tablas("select Proovedor from proovedores")
    Public TablaProveedores As DataTable = Tablas("SELECT*fROM proovedores")
    Public TablaDeClientes As DataTable = Tablas("select Ferreteria from clientes")
    Public TablaDeVendedores As DataTable = Tablas("select Nombre from colaboradores")
    Public TablaClientes As DataTable = Tablas("SELECT*FROM clientes")
    Public TablaColaboradores As DataTable = Tablas("SELECT*FROM colaboradores")
    Public conexion As String = "Data Source=DESKTOP-0GMFESR\SQLEXPRESS;Initial Catalog=programaembd;Integrated Security=True"
    Public Tabla_abonos_compras As DataTable = Tablas("SELECT*FROM abonoscompras")
    Public TablaEntradas As DataTable = Tablas("SELECT*FROM entradas")
    Public Lista_de_entradas As DataTable = Tablas("select E.Consecutivo, E.Cantidad, E.Codigo AS Cod, E.Descripción AS Descripcion, E.costo AS VrUnitario, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura from entradas as E where E.Proveedor<>'Nuevo Producto al inventario' and E.Proveedor<>'Arreglo de invenario' group by E.Consecutivo, E.Cantidad, E.Codigo, E.Descripción, E.costo, E.Total, E.CodProveedor, E.Proveedor, E.Fecha, E.FechaFactura, E.NFacrura order by E.Fecha desc")
    Public Tabla_de_pagos As DataTable = Tablas("SELECT E.Consecutivo, E.Fecha, E.FechaFactura, E.CodProveedor, E.Proveedor, E.ContadoCredito, E.FechaVencimiento, E.Total, IFNULL(E.Total-(SELECT SUM(CONVERT(IFNULL(abono, 0),REAL)) FROM abonoscompras WHERE Consecutivo = E.Consecutivo),0) AS Saldo FROM entradas AS E GROUP BY E.Consecutivo, E.Fecha , E.FechaFactura, E.CodProveedor, E.Proveedor, E.ContadoCredito, E.FechaVencimiento, E.Total ORDER BY E.Fecha DESC")
    Public TablaIngresados As DataTable = Tablas("SELECT*FROM ingresados")
    Public TablaVerificados As DataTable = Tablas("SELECT*FROM verificados")
    Public TablaAlistados As DataTable = Tablas("SELECT*FROM alistados")
    Public TablaDeAbonoVentas As DataTable = Tablas("SELECT S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo, CONVERT(CONVERT(REPLACE(REPLACE(S.Total,'.',''),',','.'),REAL)-(SELECT IFNULL(SUM(CONVERT(Abono,REAL)),0) FROM abonosventas WHERE Consecutivo = S.NFactura),NCHAR) AS Verdadero_saldo FROM abonodeventas AS S ORDER BY S.Fecha DESC") '"SELECT S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo, CONVERT(REPLACE(REPLACE(S.Total,'.',''),',','.'),REAL)-(SELECT IFNULL(SUM(CONVERT(Abono,REAL)),0) FROM abonosventas WHERE Consecutivo = S.NFactura) AS Verdadero_saldo FROM abonodeventas AS S ORDER BY S.Fecha DESC")
    Public TablaDeEstadosVentas As DataTable = Tablas("Select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados As ES order by ES.FechaFactura desc")
    Public TablaDeSalidas As DataTable = Tablas("SELECT*FROM salidas")
    Public Tabla_otros_proveedores As DataTable = Tablas("select*from otrosproveedores")
    Public Tabla_de_ingresados As DataTable = Tablas("Select*from tabladeingresados")
    Public Tabla_de_anulado As DataTable = Tablas("select*from anulados")

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizando()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        'Me.Close()
        Application.Exit() 'Se suóne que este si sierra la aplicación es mas seguro y no daña el computador si uno lo usa mucho
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Private Sub Ampliaryminimizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        Maximizar.Visible = False
        Restaurar.Visible = True
        'Me.WindowState = FormWindowState.Maximized
        'Nuevo codigo para maximizar sin que ocupe la barra de tareas de windows
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        'Fin del nuevo codigo
    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Restaurar.Visible = False
        Maximizar.Visible = True
        'Me.WindowState = FormWindowState.Normal
        'Nuevo codigo para normalizar con los valores y las posiciones donde estaba antes de maximizar
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)


        'Fin del nuevo codigo
    End Sub

    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub OcultarMenu_Tick(sender As Object, e As EventArgs) Handles OcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.OcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub MostrarMenu_Tick(sender As Object, e As EventArgs) Handles MostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.MostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        If PanelMenu.Width = 220 Then
            OcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            MostrarMenu.Enabled = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirFormEnPanel(New Colaboradores)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        AbrirFormEnPanel(Cliente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(FacCompras)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Facturasdeventa)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel(estudio)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(Configuracion)
    End Sub

    Private Sub ButtonProveedores_Click(sender As Object, e As EventArgs) Handles ButtonProveedores.Click
        AbrirFormEnPanel(New Proovedores)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(LisDePrecios)
        'LisDePrecios.CBProovedor.Items.Clear()
        'cargar_CocProveedor(LisDePrecios.DGVOtrosProovedores)
        'LisDePrecios.llenar_los_productos()
        ''LisDePrecios.DGVLDePrecios.DataSource = BusquedaProLDePrecios.ObtenerProductosBuscar()
        ''LisDePrecios.DGVLDePrecios.AllowUserToAddRows = False
        'LlenarComboBoxProovedores(LisDePrecios.CBProovedor)
    End Sub
    'funcion para igresar datos a una tabla
    Public Sub A_tablas(tabla As String, cadena As String)
        Try
            Conexiondb.conexion.Close()
            Dim Consulta As New OdbcCommand("INSERT INTO " & tabla & " VALUES " & cadena, Conexiondb.conexion)
            Conexiondb.conexion.Open()
            Consulta.ExecuteNonQuery()
            Conexiondb.conexion.Close()
        Catch ex As Exception
            MsgBox("ocurrio un error en la funcion " & ex.Message)
        End Try
    End Sub
    Public Function Tablas(Cadena As String)
        'hace la coneccion y me trae de vuelta una tabla con la información
        Conexiondb.conexion.Close()
        Dim ds As OdbcDataReader
        Dim dt As New DataTable
        'codigo nuevo
        Dim consulta As New OdbcCommand(Cadena, Conexiondb.conexion)
        Conexiondb.conexion.Open()
        ds = consulta.ExecuteReader
        dt.Load(ds)
        Conexiondb.conexion.Close()
        Return dt
    End Function

    Public Sub Consultar(cadena As String)
        Conexiondb.conexion.Close()
        Dim Consulta As New OdbcCommand(cadena, Conexiondb.conexion)
        Conexiondb.conexion.Open()
        Consulta.ExecuteNonQuery()
        Conexiondb.conexion.Close()
    End Sub

    Public Sub Solo_numeros(e As KeyPressEventArgs)
        Dim filtro As String = "0123456789,"

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Next
    End Sub
    Public Function Fila_de_productos(i As Integer)
        Return TablaDeProductos.Rows(i)
    End Function
    Public Sub Actualizar_productos()
        TablaDeProductos = Tablas("SELECT p.Cod, p.descripcion, p.UnidadOpaquete, p.EsUnidadOpaquete, p.Categoria, p.SubCategoria, p.CodProovedor, p.Proovedor, p.PCosto, p.PVenta, p.Ganancia, p.Pventa1, p.Ganancia1, p.Pventa2, p.Ganancia2, p.Ubicación, (SELECT (SELECT SUM(Cantidad) FROM entradas WHERE Codigo= p.Cod)-(SELECT SUM(Cantidad) FROM salidas WHERE Codigo= p.Cod)) AS cantidad, p.Minimo, p.Maximo, p.Nota FROM productos AS p")
    End Sub
    Public Sub Actualizar_Categoria()
        TablaDeCategorias = Tablas("select Categoria from categoria")
    End Sub
    Public Sub Actualizar_SubCategoria()
        TablaDeSubCategoria = Tablas("select SubCategoria from subcategorias")
    End Sub
    Public Sub Actualizar_ubicacion()
        TablaDeUbicaciones = Tablas("select Ubicacion from ubicaciones")
    End Sub
    Public Sub Actualizar_Cliente()
        TablaClientes = Tablas("SELECT*FROM clientes")
    End Sub
    Public Sub Actualizar_Colaboradores()
        TablaColaboradores = Tablas("SELECT*FROM colaboradores")
    End Sub
    Public Sub Actualizar_Proveedores()
        TablaProveedores = Tablas("SELECT*fROM proovedores")
    End Sub
    Public Sub Actualizar_abonos_compras()
        Tabla_abonos_compras = Tablas("SELECT*FROM abonoscompras")
    End Sub
    Public Sub Actualizar_Tabla_entradas()
        TablaEntradas = Tablas("SELECT*FROM entradas")
    End Sub
    Public Sub Actualizar_Tabla_ingresados()
        TablaIngresados = Tablas("SELECT*FROM ingresados")
    End Sub
    Public Sub Actualizar_de_abonos_ventas()
        TablaDeAbonoVentas = Tablas("SELECT S.NFactura, S.Fecha, S.FechaFactura, S.CodCliente, S.Cliente, S.ContadoOCredito, S.Vencimiento, S.Total, S.Saldo, CONVERT(CONVERT(REPLACE(REPLACE(S.Total,'.',''),',','.'),REAL)-(SELECT IFNULL(SUM(CONVERT(Abono,REAL)),0) FROM abonosventas WHERE Consecutivo = S.NFactura),NCHAR) AS Verdadero_saldo FROM abonodeventas AS S ORDER BY S.Fecha DESC")
    End Sub
    Public Sub ActualizarTablaVendedores()
        TablaDeVendedores = Tablas("select Nombre from colaboradores")
    End Sub

    Public Sub ActualizarTablaDeEstadosVentas()
        TablaDeEstadosVentas = Tablas("Select ES.NDePedido, ES.CodCliente, ES.Cliente, ES.FechaFactura, ES.Valor, ES.TipoDePago, ES.Estado, ES.ValorFinal, ES.FechaDeEstado, ES.FechaDeEntrega, ES.ProcesoDelPedido from tabladeestados As ES order by ES.FechaFactura desc")
    End Sub

    Public Sub ActualizarTablaDeSalidas()
        TablaDeSalidas = Tablas("SELECT*FROM salidas")
    End Sub

    Public Sub ActualizarTabla_otros_proveedores()
        Tabla_otros_proveedores = Tablas("select*from otrosproveedores")
    End Sub

    Public Sub Actualizar_Tabla_de_ingresados()
        Tabla_de_ingresados = Tablas("Select*from tabladeingresados")
    End Sub

    Public Sub Actualizar_Tabla_de_anulado()
        Tabla_de_anulado = Tablas("select*from anulados")
    End Sub

    Public Function Cantidad_del_producto(codigo)
        Dim dt As New DataTable
        Dim numero As Double = 0
        dt = Tablas("select (select SUM(Cantidad) from entradas where Codigo= '" & codigo & "')-(select SUM(Cantidad) from salidas where Codigo= '" & codigo & "') ")
        Try
            If dt.Rows.Count > 0 Then
                numero = Convert.ToDouble(dt.Rows(0).Item(0).ToString)
            End If
        Catch ex As Exception

        End Try
        Return numero
    End Function
End Class
