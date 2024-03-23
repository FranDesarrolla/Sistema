Public Class ABM_Productos
    Private Sub ABM_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSistema.conexionSql.Open()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ModuloPrincipal.AbrirFormEnPanel(Productos)
        ModuloSistema.conexionSql.Close()
    End Sub

End Class