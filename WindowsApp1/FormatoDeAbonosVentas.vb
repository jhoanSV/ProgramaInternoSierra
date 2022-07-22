Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO

Public Class FormatoDeAbonosVentas
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
        If Form1.Facturasdeventa.DGVCobrosVentas.Rows.Count() = 0 Then
            'Sierra la ventana
            Me.Close()
        Else
            Label2.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(0).Value) 'Trae el consecutivo de la factura
            Label3.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(2).Value) 'Trae la fecha de la factura
            Label5.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(3).Value) 'Trae el codigo del proveedor
            Label7.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(4).Value) 'Trae el nombre del proveedor
            Label9.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(6).Value) 'Trae el fecha de vencimiento
            Label15.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(7).Value) 'Trae el total de la factura
            Label19.Text = Convert.ToString(Form1.Facturasdeventa.DGVCobrosVentas.CurrentRow.Cells(5).Value) 'Trae el total de la factura
            Label18.Text = ""
            'TBSaldo.Text = "0"
            ObtenerTablaDeAbonosVentas()
        End If
    End Sub
    'Fin del al cargar el formulario.
    'Botones de minimizar y cerrar el formulario
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'minimiza la ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

        If TBValorAbono.Text = "" Or TBValorAbono.Text = "0" Or CBRC.Text = "" Then
            If TBValorAbono.Text = "" Or TBValorAbono.Text = "0" Then
                MsgBox("ingrese un valor al abono")
            ElseIf CBRC.Text = "" Then
                MsgBox("ingrese un radicado")
            End If
        Else
            Try
                Form1.Consultar("insert into abonosventas values ('" & Label2.Text & "', '" & CBRC.Text & "', '" & Convert.ToString(Format(Date.Now, "Short Date")) & "', '" & Label3.Text & "', '" & Label5.Text & "', '" & Label7.Text & "', '" & Label19.Text & "', '" & Label9.Text & "', '" & TBValorAbono.Text & "', '" & TBSaldo.Text & "')")
                MsgBox("Se registro correctamente") 'modifica los datos que se encuentren asociados al valor de la casilla codigo.
                CBRC.Text = ""  'deja el campo vacio del codigo y en lo demas es lo mismo
                TBValorAbono.Text = ""
                Form1.Actualizar_de_abonos_ventas()
                ObtenerTablaDeAbonosVentas()
                Form1.Facturasdeventa.ObtenerTablaDePagosVentas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    'FUNCIONES%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function ObtenerTablaDeAbonosVentas() As DataTable 'es una funcion encargada de llamar la lista de la base de datos y mostrara en pantalla
        Try
            Dim dt As New DataTable
            dt = Form1.Tablas("select A.Consecutivo, A.Fecha, A.RC, A.Abono, A.Saldo from abonosventas as A where A.Consecutivo= '" & Label2.Text & "' order by A.Fecha desc")
            Dim i As Integer
            i = 0
            Me.DGVAbonoVentas.Rows.Clear()
            If dt.Rows.Count > 0 Then
                Me.DGVAbonoVentas.Rows.Add(dt.Rows.Count)
                For Each filas As DataRow In dt.Rows
                    Me.DGVAbonoVentas.Rows(i).Cells(0).Value = Trim(dt.Rows(i).Item(1).ToString) 'fecha
                    Me.DGVAbonoVentas.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item(2).ToString) 'RC
                    Me.DGVAbonoVentas.Rows(i).Cells(2).Value = Trim(dt.Rows(i).Item(3).ToString) 'Abono
                    Me.DGVAbonoVentas.Rows(i).Cells(3).Value = Trim(dt.Rows(i).Item(4).ToString) 'Saldo
                    i = i + 1
                Next
                Dim total As Double
                'Dim fila As DataGridViewRow = New DataGridViewRow()
                Dim saldo As Double

                For Each fila In Me.DGVAbonoVentas.Rows
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
                dt = Form1.Tablas("select A.Consecutivo, A.RC from abonosventas as A where A.Consecutivo= '" & Label2.Text & "' and A.RC = '" & CBRC.Text & "'")
                If dt.Rows.Count > 0 Then
                    Label18.Text = "El RC ya existe"
                Else
                    Label18.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Algo salio mal " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TBValorAbono_TextChanged(sender As Object, e As EventArgs) Handles TBValorAbono.TextChanged
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim saldo As Double = 0
        Dim abono As Double = 0

        If TBValorAbono.Text = "" Then
            abono = 0
        Else
            abono = Convert.ToDouble(TBValorAbono.Text)
        End If
        For Each fila In Me.DGVAbonoVentas.Rows
            total += Convert.ToDouble(fila.Cells(2).Value)
        Next
        saldo = Convert.ToDouble(Label15.Text) - (total + abono)
        TBSaldo.Text = Format(saldo, "##,##0.00")

    End Sub

    'Fin de lo que va en los texbox, combobox y demas %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

End Class