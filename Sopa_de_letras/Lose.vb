Public Class Lose

    Private Sub lose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lose_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            ' Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Blue 'Cambia el color de la fuente de la label3

    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave

        Label2.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub
End Class