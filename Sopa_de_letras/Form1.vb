Public Class Form1
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        Me.StartPosition = FormStartPosition.Manual
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        Me.Left = (screenWidth - formWidth) \ 2
        Me.Top = (screenHeight - formHeight) \ 2

    End Sub
    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            ' Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form2.Show() 'Abre el Form2
        Me.Hide() 'Se oculta el formulario actual

    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.White 'Cambia el color de la fuente de la label1

    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black 'Cambia el color de la fuente de la label

    End Sub
    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        End 'Termina con la dupuración'
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Lose.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Opciones.Show()
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub
End Class
