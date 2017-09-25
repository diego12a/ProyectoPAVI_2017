Public Class formMenu

    Private Sub btnAbmCubiertas_Click(sender As Object, e As EventArgs) Handles btnAbmCubiertas.Click
        AbmCubiertas.ShowDialog()
    End Sub

    Private Sub btnAbmNavios_Click(sender As Object, e As EventArgs) Handles btnAbmNavios.Click
        AbmNavios.ShowDialog()
    End Sub

    Private Sub btnPuertos_Click(sender As Object, e As EventArgs) Handles btnPuertos.Click
        AbmPuertos.ShowDialog()
    End Sub

    Private Sub btnAbmItinerarios_Click(sender As Object, e As EventArgs) Handles btnAbmItinerarios.Click
        AbmItinerarios.ShowDialog()
    End Sub
End Class
