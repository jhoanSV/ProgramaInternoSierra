Imports System.Data.Odbc
Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Imports System.Data.SqlClient ' ES NECESARIO PARA TODO LO QUE TIENE QUE VER CON SQL SERVER
Public Class ListaDeAlistarPelidos

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
    Private Sub ListaDeAlistarPelidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVListaDeAlistarPedidos.Columns(6).Visible = False 'esconde la columna de consecutivo
    End Sub
    'Botones de minimizar y cerrar el formulario
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'minimiza la ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Sierra la ventana
        Form1.AlistarPedidos_activo = False
        Me.Hide()
        Me.DGVListaDeAlistarPedidos.Rows.Clear() 'Limpia el DGVListaDeAlistarPedidos
    End Sub
    'Fin de botones de minimizar y cerrar el formulario
    'BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonExportarAExcelColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        Try

            For i As Double = 0 To DGVListaDeAlistarPedidos.Rows.Count - 1
                Dim c As Color

                c = DGVListaDeAlistarPedidos.Rows(i).DefaultCellStyle.BackColor
                If c.IsEmpty = False Then
                    i = i + 1
                Else
                    Dim cadena_de_insercion As String = "('" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Consecutivo").Value) & "',
                                                          '" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Ferreteria").Value) & "',
                                                          '" & Convert.ToDouble(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Cantidad").Value) & "',
                                                          '" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Codigo").Value) & "',
                                                          '" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Descipcion").Value) & "',
                                                          '" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Inventario").Value) & "',
                                                          '" & Convert.ToString(DGVListaDeAlistarPedidos.Rows.Item(i).Cells("Posicion").Value) & "')"
                    Form1.A_tablas("alistados", cadena_de_insercion)
                End If

            Next
            llenarExcelAlstarPedidos(DGVListaDeAlistarPedidos)
        Catch ex As Exception
            MsgBox("Ocurrio un error " & ex.Message)
        End Try
        Dim Ndepedido As String ' me da el numero del pedido que quiero alistar
        For Each fila In Form1.Facturasdeventa.DGVVentasAlistar.Rows ' esto hace que se ejecute el codigo pedido por pedido según el orden en el que esta en el DGVVentasAlistar
            Ndepedido = Convert.ToString(fila.Cells(0).Value)
            Try
                Form1.Consultar("delete from ingresados Where NDePedido = '" & Ndepedido & "'")
                Dim Alistado As String = "Alistado"
                Form1.Consultar("update tabladeestados set Estado = '" & Alistado & "', FechaDeEstado ='" & Convert.ToString(Format(Date.Now, "Short Date")) & "' Where NDePedido = '" & Ndepedido & "'")
                'esta parte del codigo se encarga de cambiar el estado de cada pedido al de alistado
            Catch ex As Exception
                MsgBox("algo salio mal" & ex.Message)
            End Try
        Next
        Form1.Facturasdeventa.DGVVentasIngresados.DataSource = Form1.Facturasdeventa.ObtenerIngresados()
        Form1.Facturasdeventa.DGVVentasAlistar.Rows.Clear()
        Form1.ActualizarTablaDeEstadosVentas()
        Form1.Facturasdeventa.DGVEstados.DataSource = Form1.Facturasdeventa.ObtenerTablaDeEstados()
        Actualizar_todo()
    End Sub

    'FIN DE BOTONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
End Class