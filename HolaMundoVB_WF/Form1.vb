Imports Biblioteca

Public Class Form1

    Dim persona As New Biblioteca.ClsPersona

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        persona.Nombre = txtNombre.Text

        MessageBox.Show($"hola {persona.Nombre}")
    End Sub

End Class
