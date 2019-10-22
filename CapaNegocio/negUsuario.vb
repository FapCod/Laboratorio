Imports CapaDatos
Imports CapaEntidad
Public Class negUsuario
    Public Function nuevo(objUsuario As entUsuario) As Boolean
        Dim objdat As New datUsuario
        If objUsuario.clave.Length < 8 Then
            Return False
        End If
        Return objdat.nuevo(objUsuario)
    End Function
    Public Function editar(objUsuario As entUsuario, id As Integer) As Boolean
        Dim objdat As New datUsuario
        If objUsuario.clave.Length < 8 Then
            Return False
        End If
        Return objdat.editar(objUsuario, id)
    End Function
    Public Function eliminar(id As String) As Boolean
        Dim objdat As New datUsuario
        Return objdat.eliminar(id)
    End Function
    Public Function buscar(id As String) As DataTable
        Dim objdat As New datUsuario
        Return objdat.buscar(id)
    End Function
    'creacion de datatable
    Public Function obtenerTabla(cadena As String) As DataTable
        Dim dat As New datUsuario
        Return dat.obtenerTabla(cadena)
    End Function
End Class
