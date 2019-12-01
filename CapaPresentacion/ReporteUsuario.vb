Public Class ReporteUsuario

    Private Sub ReporteUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsuariosDataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.UsuariosDataSet.Usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class