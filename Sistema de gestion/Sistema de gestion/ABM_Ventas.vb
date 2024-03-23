Public Class ABM_Ventas
    Private Sub ABM_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSistema.conexionSql.Open()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ModuloPrincipal.AbrirFormEnPanel(Ventas)
        ModuloSistema.conexionSql.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class