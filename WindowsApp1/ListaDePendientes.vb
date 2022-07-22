Imports System.Runtime.InteropServices 'NECESARIO PARA PODER MOVER LA VENTANA DEL FORMULARIO
Public Class ListaDePendientes
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
    'Botones de minimizar y cerrar el formulario
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.ListaDePendientes_activo = False
        Me.Hide()
        Me.DGVListaDePendientes.Rows.Clear()
    End Sub

    Private Sub ButtonExportarAExcelColaboradores_Click(sender As Object, e As EventArgs) Handles ButtonExportarAExcelColaboradores.Click
        llenarExcel(DGVListaDePendientes) 'descarga la lista en un EXcel
    End Sub

    'Fin de botones de minimizar y cerrar el formulario
End Class