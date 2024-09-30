Public Class lvl1prg

    Dim puntuación As Integer
    Dim vidas As Integer

    Private letrasAbecedario As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
    Private rnd As New Random()


    Private Sub lvl1prg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Interval = 500   'El intervalo del timer pasa a 0,5 segundos'
        vidas = 10 'la variable "vida" Almacena el valor 10'
        Randomize()



    End Sub
    Private Sub lvl1prg_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            ' Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next

    End Sub
  
    Private Sub Label115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label115.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Label115_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label115.MouseEnter
        Label115.ForeColor = Color.White

    End Sub
    Private Sub Label115_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label115.MouseLeave
        Label115.ForeColor = Color.Black

    End Sub

    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label71.BackColor = Color.Gold
        Label71.Enabled = False

        If Label71.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold Then
            Label71.BackColor = Color.Green
            Label70.BackColor = Color.Green


        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green Then

            Label13.BackColor = Color.Green
        End If
      

    End Sub

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label70.BackColor = Color.Gold
        Label70.Enabled = False

        If Label71.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold Then
            Label71.BackColor = Color.Green
            Label70.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green Then

            Label13.BackColor = Color.Green
        End If


    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label81.BackColor = Color.Green
        Label81.Enabled = False

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If


        If Label81.BackColor = Color.Green Then
            Label12.BackColor = Color.Green

        End If


    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label21.BackColor = Color.Gold
        Label21.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label19.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green Then
            Label10.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label20.BackColor = Color.Gold
        Label20.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label19.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green Then
            Label10.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label18.BackColor = Color.Gold
        Label18.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label19.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green Then
            Label10.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label19.BackColor = Color.Gold
        Label19.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label19.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green Then
            Label10.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label1.BackColor = Color.Gold
        Label1.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label9.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label3.BackColor = Color.Gold
        Label3.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label9.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label4.BackColor = Color.Gold
        Label4.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label9.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        puntuación = puntuación + 1
        Label7.Text = puntuación
        Label5.BackColor = Color.Gold
        Label5.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green

        End If

        If Label71.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Me.Close()
            win.Show()
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label9.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Label6.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Label11.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        Label17.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        Label16.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        Label41.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        Label40.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        Label39.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click
        Label36.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click
        Label37.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        Label38.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click
        Label31.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        Label26.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Label29.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        Label28.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        Label27.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        Label30.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click
        Label80.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label79.Click
        Label79.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click
        Label76.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label77.Click
        Label77.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label78.Click
        Label78.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label69.Click
        Label69.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label66.Click
        Label66.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click
        Label67.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label68.Click
        Label68.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
        Timer1.Start() 'inicia el timer'

        vidas = vidas - 1

        If vidas = 9 Then
            Label105.Visible = False
        End If
        If vidas = 8 Then
            Label106.Visible = False
        End If
        If vidas = 7 Then
            Label107.Visible = False
        End If
        If vidas = 6 Then
            Label108.Visible = False
        End If
        If vidas = 5 Then
            Label109.Visible = False
        End If
        If vidas = 4 Then
            Label110.Visible = False
        End If
        If vidas = 3 Then
            Label111.Visible = False
        End If
        If vidas = 2 Then
            Label112.Visible = False
        End If
        If vidas = 1 Then
            Label113.Visible = False
        End If
        If vidas = 0 Then
            Label114.Visible = False
        End If

        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.BackColor = Color.MintCream 'Cambia el color de fondo de la label1 al default'
        Label11.BackColor = Color.MintCream
        Label17.BackColor = Color.MintCream
        Label16.BackColor = Color.MintCream
        Label41.BackColor = Color.MintCream
        Label40.BackColor = Color.MintCream
        Label37.BackColor = Color.MintCream
        Label38.BackColor = Color.MintCream
        Label39.BackColor = Color.MintCream
        Label36.BackColor = Color.MintCream
        Label31.BackColor = Color.MintCream
        Label30.BackColor = Color.MintCream
        Label28.BackColor = Color.MintCream
        Label29.BackColor = Color.MintCream
        Label27.BackColor = Color.MintCream
        Label26.BackColor = Color.MintCream
        Label80.BackColor = Color.MintCream
        Label78.BackColor = Color.MintCream
        Label79.BackColor = Color.MintCream
        Label77.BackColor = Color.MintCream
        Label76.BackColor = Color.MintCream
        Label68.BackColor = Color.MintCream
        Label69.BackColor = Color.MintCream
        Label66.BackColor = Color.MintCream
        Label67.BackColor = Color.MintCream

        Timer1.Stop()  'Detiene el timer'
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False

        Timer2.Enabled = True
        Label14.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label11.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True
        Label30.Visible = True
        Label31.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True
        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label66.Visible = True
        Label67.Visible = True
        Label68.Visible = True
        Label69.Visible = True
        Label70.Visible = True
        Label71.Visible = True
        Label76.Visible = True
        Label77.Visible = True
        Label78.Visible = True
        Label79.Visible = True
        Label80.Visible = True
        Label81.Visible = True
        Label102.Visible = True
        Label103.Visible = True
        Label104.Visible = True
        Label105.Visible = True
        Label106.Visible = True
        Label107.Visible = True
        Label108.Visible = True
        Label109.Visible = True
        Label110.Visible = True
        Label111.Visible = True
        Label112.Visible = True
        Label113.Visible = True
        Label114.Visible = True

        GroupBox2.Visible = True



        Label6.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label11.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label16.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label17.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label26.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label27.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label37.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label28.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label29.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label30.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label31.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()  
        Label36.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label38.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label39.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label40.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label41.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label77.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label67.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label66.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label68.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()  
        Label76.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label78.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label69.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label79.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label80.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

    



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label8.Text = Label8.Text + 1
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class