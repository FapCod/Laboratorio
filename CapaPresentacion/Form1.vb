Imports CapaEntidad
Imports CapaNegocio
Imports System.Data.SqlClient

Public Class Form1

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'se crea el objeto y se le envia los datos
        Dim objent As New entUsuario
        objent.idusuario = txtid.Text
        objent.nombres = txtnombre.Text
        objent.apellidos = txtapellido.Text
        objent.tipousuarios = cbotipo.Text
        objent.clave = txtcontrasena.Text
        objent.estado = chkactivo.Checked
        Dim objneg As New negUsuario
        If objneg.nuevo(objent) Then
            MsgBox("REGISTRO EXITOSO")
            Ver()
        Else
            MsgBox("ERROR", vbCritical)
        End If

    End Sub
    Sub Ver()
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerTabla("select * from usuario")
    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtid.Text = DataGridView1.Item(0, i).Value()
        txtnombre.Text = DataGridView1.Item(1, i).Value()
        txtapellido.Text = DataGridView1.Item(2, i).Value()
        cbotipo.Text = DataGridView1.Item(3, i).Value()
        txtcontrasena.Text = DataGridView1.Item(4, i).Value()
        chkactivo.Checked = DataGridView1.Item(5, i).Value()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        'se crea el objeto y se le envia los datos
        Dim objent As New entUsuario
        objent.idusuario = txtid.Text
        objent.nombres = txtnombre.Text
        objent.apellidos = txtapellido.Text
        objent.tipousuarios = cbotipo.Text
        objent.clave = txtcontrasena.Text
        objent.estado = chkactivo.Checked
        Dim objneg As New negUsuario
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Try
            If objneg.editar(objent, id) Then
                MsgBox("ACTUALIZACION EXITOSO")
                Ver()
            Else
                MsgBox("ERROR", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

       
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim neguser As New negUsuario
        Dim id As String
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()

        Dim verificarRA = neguser.eliminar(id)
        If verificarRA = True Then
            MsgBox("Eliminacion Exitosa")
            Ver()
        Else
            MsgBox("Error de Eliminacion de Alumno")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim neguser As New negUsuario
        Dim id As String
        If txtBuscar.Text <> "" Then
            id = txtBuscar.Text
            DataGridView1.DataSource = neguser.buscar(id)
        Else
            Ver()
        End If
        

    End Sub

    
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        txtcontrasena.PasswordChar = ""
        btnVer.Visible = False
        btnOcultar.Visible = True
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        txtcontrasena.PasswordChar = "*"
        btnOcultar.Visible = False
        btnVer.Visible = True
    End Sub
End Class
