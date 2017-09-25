Public Class BDHelperCubierta
    Private cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor2;Integrated Security=SSPI;Initial Catalog=Sea Star"

    Public Function conocer_todas_cubiertas() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM Cubiertas"
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

    Public Function conocer_cubiertas() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM Cubiertas WHERE borrado = 0"
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

    Public Sub guardar_cubierta(ByRef cubierta As Cubierta)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion

            sql = "INSERT INTO Cubiertas (cod_navio,descripcion,leg_encargado,borrado) VALUES(" & cubierta.cod_navio
            sql &= ", '" & cubierta.descripcion & "'"
            sql &= ", " & cubierta.leg_encargado
            sql &= ", " & cubierta.borrado & ")"
            cmd.CommandText = sql
            If validar_existencia(cubierta.cod_navio, cubierta.num_cubierta) = False Then
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
    Public Function conocer_encargados() As DataTable
        Dim sql As String
        sql = "SELECT legajo, nombre FROM Tripulaciones WHERE cod_puesto = 1 AND borrado = 0 "
        Return EjecutarSQL(sql)
    End Function
    Public Function conocer_navios() As DataTable
        Dim sql As String
        sql = "SELECT cod_navio, nombre_navio FROM Navios WHERE borrado = 0 "
        Return EjecutarSQL(sql)
    End Function

    Public Sub modificar_cubierta(ByRef cubierta As Cubierta)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Cubiertas SET descripcion = '" & cubierta.descripcion & "'"
            sql &= ", leg_encargado = " & cubierta.leg_encargado
            sql &= " WHERE cod_navio = " & cubierta.cod_navio
            sql &= "AND num_cubierta = " & cubierta.num_cubierta
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
    Public Sub eliminar_cubierta(ByRef cubierta As Cubierta)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Cubiertas SET borrado = 1"
            sql &= " WHERE cod_navio = " & cubierta.cod_navio
            sql &= "AND num_cubierta = " & cubierta.num_cubierta
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
    Public Function validar_existencia(ByVal id_navio As Integer, ByVal id_cubierta As Integer) As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "SELECT * FROM Cubiertas"
            sql &= " WHERE cod_navio = " & id_navio
            sql &= " AND num_cubierta = " & id_cubierta
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            If (reader.Read()) Then
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
