Public Class BDHelperPuerto

    Private cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor2;Integrated Security=SSPI;Initial Catalog=Sea Star"
    'este metodo devuelve todos los puertos que esten en la base de datos
    Public Function conocer_todos_puertos() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM Puerto"
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



    Public Function conocer_puertos() As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM Puerto WHERE borrado = 0"
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
    'este metodo guarda un puerto en la base de datos, recibe como parametro un objeto puerto
    Public Sub guardar_puerto(ByRef puerto As Puerto)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion

            sql = "INSERT INTO puerto (nombre,borrado) VALUES ('" & puerto.nombre & "', " & puerto.borrado & ")"
            cmd.CommandText = sql
            If validar_existencia(puerto.cod_puerto) = False Then
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
    ' este metodo modifica un puerto, recibe como parametro un puerto
    Public Sub modificar_puerto(ByRef puerto As Puerto)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Puerto SET nombre = '" & puerto.nombre & "' WHERE cod_puerto = " & puerto.cod_puerto
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
    'este metodo elimina un puerto de la base de datos
    Public Sub eliminar_puerto(ByRef puerto As Puerto)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "UPDATE Puerto SET borrado = " & puerto.borrado & " WHERE cod_puerto = " & puerto.cod_puerto

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

    'este metodo devuelve true si existe en la base de datos un puerto con el id que se le pasa como parametro o false si no existe
    Public Function validar_existencia(ByVal id As Integer) As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        Dim sql As String
        Try
            conexion.ConnectionString = cadena_conexion
            cmd.CommandType = CommandType.Text
            conexion.Open()
            cmd.Connection = conexion
            sql = "SELECT * FROM Puerto WHERE cod_puerto= " & id
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
