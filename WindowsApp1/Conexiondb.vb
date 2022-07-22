Imports System.Data.Odbc
Module Conexiondb
    Public conexion As New OdbcConnection("dsn=ProgramaSierraWeb")

    Sub conectardb()
        Try
            conexion.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
