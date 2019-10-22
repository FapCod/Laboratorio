Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datUsuario
    Public Function nuevo(objUsuario As entUsuario) As Boolean
        Try
            Dim objdao As New datConexion
            'Dim dt As DataTable
            'Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO usuario VALUES(@id,@nom,@ape,@tip,@cla,@es)"
            cmd.Parameters.AddWithValue("@id", objUsuario.idusuario)
            cmd.Parameters.AddWithValue("@nom", objUsuario.nombres)
            cmd.Parameters.AddWithValue("@ape", objUsuario.apellidos)
            cmd.Parameters.AddWithValue("@tip", objUsuario.tipousuarios)
            cmd.Parameters.AddWithValue("@cla", objUsuario.clave)
            cmd.Parameters.AddWithValue("@es", objUsuario.estado)
            objdao.BaseDatos = "Ejemplo"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex")
        End Try

        Return False
    End Function
    Public Function editar(objUsuario As entUsuario, id As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "ActualizarUser"
            cmd.Parameters.AddWithValue("@idUsario", id)
            cmd.Parameters.AddWithValue("@nombres", objUsuario.nombres)
            cmd.Parameters.AddWithValue("@apellidos", objUsuario.apellidos)
            cmd.Parameters.AddWithValue("@tipousuario", objUsuario.tipousuarios)
            cmd.Parameters.AddWithValue("@clave", objUsuario.clave)
            cmd.Parameters.AddWithValue("@estado", objUsuario.estado)
            objdao.BaseDatos = "Ejemplo"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex")
        End Try

        Return False
    End Function

    Public Function eliminar(id As String) As Boolean

        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "EliminarUser"
            cmd.Parameters.AddWithValue("@idusuario", id)
            objdao.BaseDatos = "Ejemplo"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False
    End Function
    Public Function buscar(id As String) As DataTable

        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "BuscarUser"
            cmd.Parameters.AddWithValue("@id", id)
            objdao.BaseDatos = "Ejemplo"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            Dim dt1 As New DataTable
            dt1.Load(cmd.ExecuteReader())
            If cmd.ExecuteNonQuery Then
                Return dt1
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function
    Public Function obtenerTabla(ByVal query As String) As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cadena = "Server=FAPCOD\SQLEXPRESS;DataBase=Ejemplo; integrated security=true"
        cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt1 As New DataTable
        dt1.Load(cmd.ExecuteReader())
        Return dt1
    End Function
End Class
