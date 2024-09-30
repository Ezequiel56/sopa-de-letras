Public Class comojugar

    Private Sub comojugar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Visible = False
        Button1.Visible = False

        Button2.Visible = True
        PictureBox2.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False
        PictureBox2.Visible = False
        Label2.Visible = False

        Button3.Visible = True
        PictureBox3.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False

        Button4.Visible = True
        PictureBox4.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        PictureBox4.Visible = False
        Label4.Visible = False

        Button5.Visible = True
        PictureBox5.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Visible = False
        PictureBox5.Visible = False
        Label5.Visible = False

        PictureBox6.Visible = True
        Label6.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.Red 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub
End Class