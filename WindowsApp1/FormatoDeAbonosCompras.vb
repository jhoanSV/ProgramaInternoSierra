Imports System.Data.Odbc
Imports System.Data.SqlClient ' IMPORTANTE PARA QUE FUNCIONE TODO LO DEL SQL SERVER
Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Public Class FormatoDeAbonosCompras
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
    'Al cargar el formulario
    Private Sub FormatoDeAbonosCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.FacCompras.DGVCobros.Rows.Count = 0 Then
            MsgBox("No se han registrado compras para hacer un abono")
        Else
            Try
                Label2.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(0).Value) 'Trae el consecutivo de la factura
                Label3.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(2).Value) 'Trae la fecha de la factura
                Label5.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(3).Value) 'Trae el codigo del proveedor
                Label7.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(4).Value) 'Trae el nombre del proveedor
                Label9.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(6).Value) 'Trae el fecha de vencimiento
                Label15.Text = Convert.ToString(Form1.FacCompras.DGVCobros.CurrentRow.Cells(7).Value) 'Trae el total de la factura
                Label18.Text = ""
                ObtenerTablaDeAbonosCompras()
                'Cargar el saldo
                Dim total As Double
                Dim fila As DataGridViewRow = New DataGridViewRow()
                Dim saldo As Double

                For Each fila In Me.DGVAbono.Rows
                    total += Convert.ToDouble(fila.Cells(2).Value)
                Next
                saldo = Convert.ToDouble(Label15.Text) - total

                TBSaldo.Text = Format(saldo, "##,##0.00")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    'Fin del al cargar el formulario.
    'Botones de minimizar y cerrar el formulario
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'minimiza la ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Sierra la ventana
        Me.Close()
    End Sub
    'Fin de botones de minimizar y cerrar el formulario
    'BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        'sierra la ventana
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        'Guarda los datos dentro de la lista AbonosCompras
        Dim credito As String = "credito"
        If TBValorAbono.Text = "" Then
            MsgBox("Ingrese un valor al abono")
        ElseIf Convert.ToDouble(TBValorAbono.Text) = 0 Then
            MsgBox("Ingrese un valor al abono")
        ElseIf CBRC.Text = "" Then
            MsgBox("ingrese un radicado")
        ElseIf Label18.Text <> "" Then
            MsgBox("Este número de radicado ya existe")
        Else
            Try
                Form1.Consultar("insert into abonoscompras values ('" & Label2.Text & "', '" & CBRC.Text & "', '" & Convert.ToString(Format(Date.Now, "Short Date")) & "', '" & Label3.Text & "', '" & Label5.Text & "', '" & Label7.Text & "', '" & credito & "', '" & Label9.Text & "', '" & TBValorAbono.Text & "', '" & TBSaldo.Text & "')")
                MsgBox("Se registro correctamente") 'modifica los datos que se encuentren asociados al valor de la casilla codigo.
                Form1.Actualizar_abonos_compras()
                CBRC.Text = ""  'deja el campo vacio del codigo y en lo demas es lo mismo
                TBValorAbono.Text = ""
                ObtenerTablaDeAbonosCompras()
                Form1.FacCompras.ObtenerTablaDePagos()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    'FIN DE BOTONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'FUNCIONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerTablaDeAbonosCompras() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("select A.Consecutivo, A.Fecha, A.RC, A.Abono, A.Saldo from abonoscompras as A where A.Consecutivo= '" & Label2.Text & "' order by A.Fecha desc")
            Dim i As Integer
            i = 0
            Me.DGVAbono.Rows.Clear()
            If dt.Rows.Count > 0 Then
                Me.DGVAbono.Rows.Add(dt.Rows.Count)
                For Each filas As DataRow In dt.Rows
                    Me.DGVAbono.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(1).ToString) 'fecha
                    Me.DGVAbono.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(2).ToString) 'RC
                    Me.DGVAbono.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(3).ToString) 'Abono
                    Me.DGVAbono.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(4).ToString) 'Saldo
                    i = i + 1
                Next
                Dim total As Double
                Dim fila As DataGridViewRow = New DataGridViewRow()
                Dim saldo As Double

                For Each fila In Me.DGVAbono.Rows
                    total += Convert.ToDouble(fila.Cells(2).Value)
                Next
                saldo = Convert.ToDouble(Label15.Text) - total

                TBSaldo.Text = Format(saldo, "##,##0.00")
            End If
        Catch ex As Exception
            MsgBox("algo salio mal " & ex.Message)
        End Try
    End Function
    'FIN DE FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'Lo que va en los texbox, combobox y demas %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub TBValorAbono_Leave(sender As Object, e As EventArgs) Handles TBValorAbono.Leave
        TBValorAbono.Text = Format(Convert.ToDouble(TBValorAbono.Text), "##,##0.00")
    End Sub

    Private Sub TBSaldo_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TBValorAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBValorAbono.KeyPress
        'para darle formato de numero a lo que escriben en TBPcostoLprecios
        Form1.Solo_numeros(e)
    End Sub

    Private Sub CBRC_TextChanged(sender As Object, e As EventArgs) Handles CBRC.TextChanged
        If CBRC.Text = "" Then
            Label18.Text = ""
        Else
            Try
                Dim dt As DataTable
                dt = Form1.Tablas("select A.Consecutivo, A.RC from abonoscompras as A where A.Consecutivo= '" & Label2.Text & "' and A.RC = '" & CBRC.Text & "'")
                If dt.Rows.Count > 0 Then
                    Label18.Text = "El RC ya existe"
                Else
                    Label18.Text = ""
                End If
            Catch ex As Exception
                MsgBox("algo salio mal " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGVAbono_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAbono.CellContentDoubleClick
        If MsgBox("¿Desea eliminar este abono?", vbYesNo, "Eliminar abono") = vbYes Then
            Try
                Dim FilaActual As Integer = DGVAbono.CurrentRow.Index 'Captura la celda en conde se dio el doble Clik
                Form1.Consultar("delete from abonoscompras Where RC = '" & Trim(Convert.ToString(DGVAbono.Rows(FilaActual).Cells(1).Value)) & "' and Consecutivo = '" & Label2.Text & "'")
                MsgBox("Se elimino el abono correctamente")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ObtenerTablaDeAbonosCompras()
            Form1.FacCompras.ObtenerTablaDePagos()
        Else

        End If
    End Sub

    Private Sub TBValorAbono_TextChanged(sender As Object, e As EventArgs) Handles TBValorAbono.TextChanged
        Dim total As Double
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim saldo As Double
        Dim abono As Double = 0

        For Each fila In Me.DGVAbono.Rows
            total += Convert.ToDouble(fila.Cells(2).Value)
        Next
        If TBValorAbono.Text = "" Then
            abono = 0
        Else
            abono = Convert.ToDouble(TBValorAbono.Text)
        End If
        saldo = Convert.ToDouble(Label15.Text) - (total + abono)
        TBSaldo.Text = Format(saldo, "##,##0.00")
    End Sub
    'Fin de lo que va en los texbox, combobox y demas %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
End Class