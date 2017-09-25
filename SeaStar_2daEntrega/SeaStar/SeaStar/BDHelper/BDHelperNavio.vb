Public Class BDHelperNavio

    Private cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor2;Integrated Security=SSPI;Initial Catalog=Sea Star"
    Public Function conocer_todos_navios() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM Navios"
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡¡ERROR!!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function conocer_navio() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM  Navios WHERE borrado = 0 "
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡¡ERROR!!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Sub guardar_navio(ByRef navio As Navio)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion

            sql = "INSERT INTO Navios (nombre_navio,altura,autonomia,desplazamiento,eslora,manga,cant_max_pasaj,cant_tripulantes,cant_motores,tipo_clasif,borrado) VALUES ('" & navio.nombre_navio & "'"
            sql &= ", " & navio.altura
            sql &= ", '" & navio.autonomia & "'"
            sql &= ", '" & navio.desplazamiento & "'"
            sql &= ", " & navio.eslora
            sql &= ", " & navio.manga
            sql &= ", " & navio.cant_max_pasaj
            sql &= ", " & navio.cant_tripulantes
            sql &= ", " & navio.cant_motores
            sql &= ", " & navio.tipo_clasif
            sql &= ", " & navio.borrado & ")"
            cmd.CommandText = sql
            If validar_existencia(navio.cod_navio) = False Then
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡¡ERROR!!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

    End Sub
    'ejecuta una QUERY que se le pasa por parametro y devuelve un dataTable
    Public Function EjecutarSQL(ByVal strSql As String) As DataTable

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡ERROR!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            conexion.Close()
            conexion.Dispose()
        End Try
    End Function
    Public Function conocer_clasificacion_navios() As DataTable
        Dim sql As String
        sql = "SELECT cod_clasif, descrip FROM Clasificacion_Navio WHERE borrado = 0"
        Return EjecutarSQL(sql)
    End Function

    Public Sub modificar_navio(ByRef navio As Navio)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Navios SET nombre_navio = '" & navio.nombre_navio & "'"
            sql &= ", altura = " & navio.altura
            sql &= ", autonomia = '" & navio.autonomia & "'"
            sql &= ", desplazamiento = '" & navio.desplazamiento & "'"
            sql &= ", eslora = " & navio.eslora
            sql &= ", manga = " & navio.manga
            sql &= ", cant_max_pasaj = " & navio.cant_max_pasaj
            sql &= ", cant_tripulantes = " & navio.cant_tripulantes
            sql &= ", cant_motores = " & navio.cant_motores
            sql &= ", tipo_clasif = " & navio.tipo_clasif
            sql &= " WHERE cod_navio = " & navio.cod_navio
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡ERROR AL INTENTAR MODIFICAR!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub
    Public Sub eliminar_navio(ByRef navio As Navio)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Navios SET borrado = " & navio.borrado
            sql &= "WHERE cod_navio = " & navio.cod_navio
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡ERROR!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub
    Public Function validar_existencia(ByVal id_navio) As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "SELECT * FROM Navios WHERE cod_navio= " & id_navio
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
            'MessageBox.Show("¡¡ERROR!!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

    End Function
End Class
