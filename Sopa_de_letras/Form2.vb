Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub Form2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            ' Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dificultadprg.Show()
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.White 'Cambia el color de la fuente de la label1

    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black 'Cambia el color de la fuente de la label1

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form1.Show() 'Abre el form1
        Me.Close() 'Cierra el formulario actual
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dificultadani.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dificultadpais.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class