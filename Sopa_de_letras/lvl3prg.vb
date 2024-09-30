Public Class lvl3prg
    Dim puntuación As Integer
    Dim vidas As Integer

    Private letrasAbecedario As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
    Private rnd As New Random()
    Private Sub lvl3prg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Interval = 500   'El intervalo del timer pasa a 0,5 segundos'
        vidas = 5    'la variable "vida" Almacena el valor 10'
        Randomize()
    End Sub

    Private Sub lvl3prg_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            ' Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next

    End Sub



    
    Private Sub Label139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label139.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label139.BackColor = Color.Gold
        Label139.Enabled = False

        If Label139.BackColor = Color.Gold AndAlso Label140.BackColor = Color.Gold AndAlso Label138.BackColor = Color.Gold AndAlso Label137.BackColor = Color.Gold Then
            Label140.BackColor = Color.Green
            Label139.BackColor = Color.Green
            Label138.BackColor = Color.Green
            Label137.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            Label255.BackColor = Color.Green
        End If


        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label140.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label140.BackColor = Color.Gold
        Label140.Enabled = False

        If Label139.BackColor = Color.Gold AndAlso Label140.BackColor = Color.Gold AndAlso Label138.BackColor = Color.Gold AndAlso Label137.BackColor = Color.Gold Then
            Label140.BackColor = Color.Green
            Label139.BackColor = Color.Green
            Label138.BackColor = Color.Green
            Label137.BackColor = Color.Green
        End If

        If Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            Label255.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label138.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label138.BackColor = Color.Gold
        Label138.Enabled = False

        If Label139.BackColor = Color.Gold AndAlso Label140.BackColor = Color.Gold AndAlso Label138.BackColor = Color.Gold AndAlso Label137.BackColor = Color.Gold Then
            Label140.BackColor = Color.Green
            Label139.BackColor = Color.Green
            Label138.BackColor = Color.Green
            Label137.BackColor = Color.Green
        End If

        If Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            Label255.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label137.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label137.BackColor = Color.Gold
        Label137.Enabled = False

        If Label139.BackColor = Color.Gold AndAlso Label140.BackColor = Color.Gold AndAlso Label138.BackColor = Color.Gold AndAlso Label137.BackColor = Color.Gold Then
            Label140.BackColor = Color.Green
            Label139.BackColor = Color.Green
            Label138.BackColor = Color.Green
            Label137.BackColor = Color.Green
        End If

        If Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            Label255.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label222.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label222.BackColor = Color.Gold
        Label222.Enabled = False

        If Label222.BackColor = Color.Gold AndAlso Label220.BackColor = Color.Gold AndAlso Label218.BackColor = Color.Gold Then
            Label222.BackColor = Color.Green
            Label220.BackColor = Color.Green
            Label218.BackColor = Color.Green

        End If

        If Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green Then
            Label256.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label220.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label220.BackColor = Color.Gold
        Label220.Enabled = False

        If Label222.BackColor = Color.Gold AndAlso Label220.BackColor = Color.Gold AndAlso Label218.BackColor = Color.Gold Then
            Label222.BackColor = Color.Green
            Label220.BackColor = Color.Green
            Label218.BackColor = Color.Green

        End If

        If Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green Then
            Label256.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label218.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label218.BackColor = Color.Gold
        Label218.Enabled = False

        If Label222.BackColor = Color.Gold AndAlso Label220.BackColor = Color.Gold AndAlso Label218.BackColor = Color.Gold Then
            Label222.BackColor = Color.Green
            Label220.BackColor = Color.Green
            Label218.BackColor = Color.Green

        End If

        If Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green Then
            Label256.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label155.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label155.BackColor = Color.Gold
        Label155.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label51.BackColor = Color.Gold
        Label51.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label50.BackColor = Color.Gold
        Label50.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label48.BackColor = Color.Gold
        Label48.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label49.BackColor = Color.Gold
        Label49.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label47.BackColor = Color.Gold
        Label47.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label46.BackColor = Color.Gold
        Label46.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label45.BackColor = Color.Gold
        Label45.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label43.BackColor = Color.Gold
        Label43.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label44.BackColor = Color.Gold
        Label44.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label42.BackColor = Color.Gold
        Label42.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label144.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label144.BackColor = Color.Gold
        Label144.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label143.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label143.BackColor = Color.Gold
        Label143.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label186.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label186.BackColor = Color.Gold
        Label186.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label185.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label185.BackColor = Color.Gold
        Label185.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label240.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label240.BackColor = Color.Gold
        Label240.Enabled = False

        If Label155.BackColor = Color.Gold AndAlso Label51.BackColor = Color.Gold AndAlso Label50.BackColor = Color.Gold AndAlso Label48.BackColor = Color.Gold AndAlso Label49.BackColor = Color.Gold AndAlso Label47.BackColor = Color.Gold AndAlso Label46.BackColor = Color.Gold AndAlso Label45.BackColor = Color.Gold AndAlso Label43.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label144.BackColor = Color.Gold AndAlso Label143.BackColor = Color.Gold AndAlso Label185.BackColor = Color.Gold AndAlso Label186.BackColor = Color.Gold AndAlso Label240.BackColor = Color.Gold Then
            Label155.BackColor = Color.Green
            Label51.BackColor = Color.Green
            Label50.BackColor = Color.Green
            Label48.BackColor = Color.Green
            Label49.BackColor = Color.Green
            Label47.BackColor = Color.Green
            Label46.BackColor = Color.Green
            Label45.BackColor = Color.Green
            Label43.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label144.BackColor = Color.Green
            Label143.BackColor = Color.Green
            Label185.BackColor = Color.Green
            Label186.BackColor = Color.Green
            Label240.BackColor = Color.Green

        End If

        If Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green Then
            Label258.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.White

    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black

    End Sub

    Private Sub Label85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label85.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label85.BackColor = Color.Gold
        Label85.Enabled = False

        If Label85.BackColor = Color.Gold AndAlso Label86.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold Then
            Label85.BackColor = Color.Green
            Label86.BackColor = Color.Green
            Label87.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green

        End If

        If Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green Then
            Label259.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label86.BackColor = Color.Gold
        Label86.Enabled = False

        If Label85.BackColor = Color.Gold AndAlso Label86.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold Then
            Label85.BackColor = Color.Green
            Label86.BackColor = Color.Green
            Label87.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green

        End If

        If Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green Then
            Label259.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label87.BackColor = Color.Gold
        Label87.Enabled = False

        If Label85.BackColor = Color.Gold AndAlso Label86.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold Then
            Label85.BackColor = Color.Green
            Label86.BackColor = Color.Green
            Label87.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green

        End If

        If Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green Then
            Label259.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label89.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label89.BackColor = Color.Gold
        Label89.Enabled = False

        If Label85.BackColor = Color.Gold AndAlso Label86.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold Then
            Label85.BackColor = Color.Green
            Label86.BackColor = Color.Green
            Label87.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green

        End If

        If Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green Then
            Label259.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label88.BackColor = Color.Gold
        Label88.Enabled = False

        If Label85.BackColor = Color.Gold AndAlso Label86.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold Then
            Label85.BackColor = Color.Green
            Label86.BackColor = Color.Green
            Label87.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green

        End If

        If Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green Then
            Label259.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label168.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label168.BackColor = Color.Gold
        Label168.Enabled = False

        If Label168.BackColor = Color.Gold AndAlso Label167.BackColor = Color.Gold AndAlso Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label168.BackColor = Color.Green
            Label167.BackColor = Color.Green
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label38.BackColor = Color.Green

        End If

        If Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label257.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label167.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label167.BackColor = Color.Gold
        Label167.Enabled = False

        If Label168.BackColor = Color.Gold AndAlso Label167.BackColor = Color.Gold AndAlso Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label168.BackColor = Color.Green
            Label167.BackColor = Color.Green
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label38.BackColor = Color.Green

        End If

        If Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label257.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label41.BackColor = Color.Gold
        Label41.Enabled = False

        If Label168.BackColor = Color.Gold AndAlso Label167.BackColor = Color.Gold AndAlso Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label168.BackColor = Color.Green
            Label167.BackColor = Color.Green
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label38.BackColor = Color.Green

        End If

        If Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label257.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label40.BackColor = Color.Gold
        Label40.Enabled = False

        If Label168.BackColor = Color.Gold AndAlso Label167.BackColor = Color.Gold AndAlso Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label168.BackColor = Color.Green
            Label167.BackColor = Color.Green
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label38.BackColor = Color.Green

        End If

        If Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label257.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label38.BackColor = Color.Gold
        Label38.Enabled = False

        If Label168.BackColor = Color.Gold AndAlso Label167.BackColor = Color.Gold AndAlso Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label168.BackColor = Color.Green
            Label167.BackColor = Color.Green
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label38.BackColor = Color.Green

        End If

        If Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label257.BackColor = Color.Green
        End If


        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label209.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label209.BackColor = Color.Gold
        Label209.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    
    Private Sub Label212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label212.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label212.BackColor = Color.Gold
        Label212.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label239.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label239.BackColor = Color.Gold
        Label239.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label242_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label242.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label242.BackColor = Color.Gold
        Label242.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label189.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label189.BackColor = Color.Gold
        Label189.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label192.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label192.BackColor = Color.Gold
        Label192.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label183.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label183.BackColor = Color.Gold
        Label183.Enabled = False

        If Label209.BackColor = Color.Gold AndAlso Label212.BackColor = Color.Gold AndAlso Label239.BackColor = Color.Gold AndAlso Label242.BackColor = Color.Gold AndAlso Label189.BackColor = Color.Gold AndAlso Label192.BackColor = Color.Gold AndAlso Label183.BackColor = Color.Gold Then
            Label209.BackColor = Color.Green
            Label212.BackColor = Color.Green
            Label239.BackColor = Color.Green
            Label242.BackColor = Color.Green
            Label189.BackColor = Color.Green
            Label192.BackColor = Color.Green
            Label183.BackColor = Color.Green

        End If

        If Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green Then
            Label260.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label124.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label124.BackColor = Color.Gold
        Label124.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label123.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label123.BackColor = Color.Gold
        Label123.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label180.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label180.BackColor = Color.Gold
        Label180.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label179.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label179.BackColor = Color.Gold
        Label179.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label236.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label236.BackColor = Color.Gold
        Label236.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label235.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label235.BackColor = Color.Gold
        Label235.Enabled = False

        If Label124.BackColor = Color.Gold AndAlso Label123.BackColor = Color.Gold AndAlso Label180.BackColor = Color.Gold AndAlso Label179.BackColor = Color.Gold AndAlso Label236.BackColor = Color.Gold AndAlso Label235.BackColor = Color.Gold Then
            Label124.BackColor = Color.Green
            Label123.BackColor = Color.Green
            Label180.BackColor = Color.Green
            Label179.BackColor = Color.Green
            Label236.BackColor = Color.Green
            Label235.BackColor = Color.Green


        End If

        If Label124.BackColor = Color.Green AndAlso Label123.BackColor = Color.Green AndAlso Label180.BackColor = Color.Green AndAlso Label179.BackColor = Color.Green AndAlso Label236.BackColor = Color.Green AndAlso Label235.BackColor = Color.Green Then
            Label261.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label201.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label201.BackColor = Color.Gold
        Label201.Enabled = False

        If Label201.BackColor = Color.Gold AndAlso Label202.BackColor = Color.Gold AndAlso Label213.BackColor = Color.Gold AndAlso Label214.BackColor = Color.Gold AndAlso Label7.BackColor = Color.Gold Then
            Label201.BackColor = Color.Green
            Label202.BackColor = Color.Green
            Label213.BackColor = Color.Green
            Label214.BackColor = Color.Green
            Label7.BackColor = Color.Green


        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green Then
            Label262.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label202.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label202.BackColor = Color.Gold
        Label202.Enabled = False

        If Label201.BackColor = Color.Gold AndAlso Label202.BackColor = Color.Gold AndAlso Label213.BackColor = Color.Gold AndAlso Label214.BackColor = Color.Gold AndAlso Label7.BackColor = Color.Gold Then
            Label201.BackColor = Color.Green
            Label202.BackColor = Color.Green
            Label213.BackColor = Color.Green
            Label214.BackColor = Color.Green
            Label7.BackColor = Color.Green


        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green Then
            Label262.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label213.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label213.BackColor = Color.Gold
        Label213.Enabled = False

        If Label201.BackColor = Color.Gold AndAlso Label202.BackColor = Color.Gold AndAlso Label213.BackColor = Color.Gold AndAlso Label214.BackColor = Color.Gold AndAlso Label7.BackColor = Color.Gold Then
            Label201.BackColor = Color.Green
            Label202.BackColor = Color.Green
            Label213.BackColor = Color.Green
            Label214.BackColor = Color.Green
            Label7.BackColor = Color.Green


        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green Then
            Label262.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label214.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label214.BackColor = Color.Gold
        Label214.Enabled = False

        If Label201.BackColor = Color.Gold AndAlso Label202.BackColor = Color.Gold AndAlso Label213.BackColor = Color.Gold AndAlso Label214.BackColor = Color.Gold AndAlso Label7.BackColor = Color.Gold Then
            Label201.BackColor = Color.Green
            Label202.BackColor = Color.Green
            Label213.BackColor = Color.Green
            Label214.BackColor = Color.Green
            Label7.BackColor = Color.Green


        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green Then
            Label262.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label7.BackColor = Color.Gold
        Label7.Enabled = False

        If Label201.BackColor = Color.Gold AndAlso Label202.BackColor = Color.Gold AndAlso Label213.BackColor = Color.Gold AndAlso Label214.BackColor = Color.Gold AndAlso Label7.BackColor = Color.Gold Then
            Label201.BackColor = Color.Green
            Label202.BackColor = Color.Green
            Label213.BackColor = Color.Green
            Label214.BackColor = Color.Green
            Label7.BackColor = Color.Green


        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green Then
            Label262.BackColor = Color.Green
        End If

        If Label201.BackColor = Color.Green AndAlso Label202.BackColor = Color.Green AndAlso Label213.BackColor = Color.Green AndAlso Label214.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label58.BackColor = Color.Gold
        Label58.Enabled = False

        If Label58.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold AndAlso Label81.BackColor = Color.Gold AndAlso Label165.BackColor = Color.Gold Then
            Label58.BackColor = Color.Green
            Label70.BackColor = Color.Green
            Label81.BackColor = Color.Green
            Label165.BackColor = Color.Green

        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green Then
            Label110.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label70.BackColor = Color.Gold
        Label70.Enabled = False

        If Label58.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold AndAlso Label81.BackColor = Color.Gold AndAlso Label165.BackColor = Color.Gold Then
            Label58.BackColor = Color.Green
            Label70.BackColor = Color.Green
            Label81.BackColor = Color.Green
            Label165.BackColor = Color.Green

        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green Then
            Label110.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label81.BackColor = Color.Gold
        Label81.Enabled = False

        If Label58.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold AndAlso Label81.BackColor = Color.Gold AndAlso Label165.BackColor = Color.Gold Then
            Label58.BackColor = Color.Green
            Label70.BackColor = Color.Green
            Label81.BackColor = Color.Green
            Label165.BackColor = Color.Green

        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green Then
            Label110.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label165.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label165.BackColor = Color.Gold
        Label165.Enabled = False

        If Label58.BackColor = Color.Gold AndAlso Label70.BackColor = Color.Gold AndAlso Label81.BackColor = Color.Gold AndAlso Label165.BackColor = Color.Gold Then
            Label58.BackColor = Color.Green
            Label70.BackColor = Color.Green
            Label81.BackColor = Color.Green
            Label165.BackColor = Color.Green

        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green Then
            Label110.BackColor = Color.Green
        End If

        If Label58.BackColor = Color.Green AndAlso Label70.BackColor = Color.Green AndAlso Label81.BackColor = Color.Green AndAlso Label165.BackColor = Color.Green AndAlso Label209.BackColor = Color.Green AndAlso Label212.BackColor = Color.Green AndAlso Label239.BackColor = Color.Green AndAlso Label242.BackColor = Color.Green AndAlso Label189.BackColor = Color.Green AndAlso Label192.BackColor = Color.Green AndAlso Label183.BackColor = Color.Green AndAlso Label168.BackColor = Color.Green AndAlso Label167.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label85.BackColor = Color.Green AndAlso Label86.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label155.BackColor = Color.Green AndAlso Label51.BackColor = Color.Green AndAlso Label50.BackColor = Color.Green AndAlso Label48.BackColor = Color.Green AndAlso Label49.BackColor = Color.Green AndAlso Label47.BackColor = Color.Green AndAlso Label46.BackColor = Color.Green AndAlso Label45.BackColor = Color.Green AndAlso Label43.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label144.BackColor = Color.Green AndAlso Label143.BackColor = Color.Green AndAlso Label185.BackColor = Color.Green AndAlso Label186.BackColor = Color.Green AndAlso Label240.BackColor = Color.Green AndAlso Label222.BackColor = Color.Green AndAlso Label220.BackColor = Color.Green AndAlso Label218.BackColor = Color.Green AndAlso Label139.BackColor = Color.Green AndAlso Label140.BackColor = Color.Green AndAlso Label138.BackColor = Color.Green AndAlso Label137.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label148.Click
        Label148.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If
       
        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label147.Click
        Label147.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label142.Click
        Label142.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label141.Click
        Label141.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label136.Click
        Label136.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label132.Click
        Label132.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label135.Click
        Label135.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label131.Click
        Label131.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label118.Click
        Label118.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label117.Click
        Label117.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label178.Click
        Label178.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label177.Click
        Label177.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label234.Click
        Label234.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label233_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label233.Click
        Label233.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label208.Click
        Label208.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label207.Click
        Label207.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label146.Click
        Label146.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label145.Click
        Label145.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label130.Click
        Label130.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label129.Click
        Label129.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label127.Click
        Label127.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label128.Click
        Label128.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label126.Click
        Label126.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label125.Click
        Label125.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label122.Click
        Label122.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label120.Click
        Label120.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label121.Click
        Label121.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label119.Click
        Label119.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label116.Click
        Label116.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label115.Click
        Label115.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label176.Click
        Label176.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label175.Click
        Label175.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label232.Click
        Label232.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label231.Click
        Label231.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label206.Click
        Label206.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label205.Click
        Label205.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label172.Click
        Label172.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label171.Click
        Label171.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Label3.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Label5.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Label6.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Label11.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Label10.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Label8.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Label9.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label254_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label254.Click
        Label254.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label253_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label253.Click
        Label253.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label230.Click
        Label230.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label229_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label229.Click
        Label229.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label170.Click
        Label170.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label169.Click
        Label169.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        Label21.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        Label20.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        Label18.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Label19.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        Label17.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        Label16.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Label15.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Label13.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Label14.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Label12.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label204.Click
        Label204.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label203.Click
        Label203.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label200.Click
        Label200.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label199.Click
        Label199.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label252_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label252.Click
        Label252.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label251_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label251.Click
        Label251.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label228.Click
        Label228.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label227.Click
        Label227.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        Label39.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click
        Label37.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click
        Label36.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click
        Label35.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click
        Label33.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click
        Label34.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        Label32.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label194.Click
        Label194.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label193.Click
        Label193.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label198.Click
        Label198.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label197.Click
        Label197.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label250.Click
        Label250.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label249.Click
        Label249.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label226.Click
        Label226.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label225.Click
        Label225.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label166.Click
        Label166.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click
        Label131.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        Label130.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        Label28.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Label29.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        Label27.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        Label26.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        Label25.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        Label23.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        Label24.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        Label22.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label184.Click
        Label184.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label196.Click
        Label196.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label195_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label195.Click
        Label195.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label248_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label248.Click
        Label248.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label247_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label247.Click
        Label247.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label224.Click
        Label224.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label223.Click
        Label223.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label162.Click
        Label162.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label161.Click
        Label161.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click
        Label80.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label78.Click
        Label78.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label79.Click
        Label79.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label77.Click
        Label77.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click
        Label76.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label75.Click
        Label75.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label73.Click
        Label73.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label74.Click
        Label74.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label72.Click
        Label72.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label174.Click
        Label174.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label173.Click
        Label173.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label191.Click
        Label191.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label246_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label246.Click
        Label246.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label245.Click
        Label245.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label221.Click
        Label221.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label158.Click
        Label158.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label157.Click
        Label157.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label160.Click
        Label160.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label159.Click
        Label159.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click
        Label71.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label68.Click
        Label68.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label69.Click
        Label69.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click
        Label67.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label66.Click
        Label66.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.Click
        Label65.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click
        Label63.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click
        Label64.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click
        Label62.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label164.Click
        Label164.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label163.Click
        Label163.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label190.Click
        Label190.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label244_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label244.Click
        Label244.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label243_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label243.Click
        Label243.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label219.Click
        Label219.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label61.Click
        Label61.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click
        Label60.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click
        Label59.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click
        Label57.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click
        Label56.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click
        Label55.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click
        Label53.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click
        Label54.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click
        Label52.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label154.Click
        Label154.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label153.Click
        Label153.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label188.Click
        Label188.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label187.Click
        Label187.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label241_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label241.Click
        Label241.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label217.Click
        Label217.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label156.Click
        Label156.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label216.Click
        Label216.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label215.Click
        Label215.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label152.Click
        Label152.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label151.Click
        Label151.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click
        Label101.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click
        Label100.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click
        Label98.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click
        Label99.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click
        Label97.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label96.Click
        Label96.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label95.Click
        Label95.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label93.Click
        Label93.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label94.Click
        Label94.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label92.Click
        Label92.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label134.Click
        Label134.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label133.Click
        Label133.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label182.Click
        Label182.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label181.Click
        Label181.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label238_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label238.Click
        Label238.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label237.Click
        Label237.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label211.Click
        Label211.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label150.Click
        Label150.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label149.Click
        Label149.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label91.Click
        Label91.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label90.Click
        Label90.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click
        Label83.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click
        Label84.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click
        Label82.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label210.Click
        Label210.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

        vidas = vidas - 1

        If vidas = 4 Then
            Label105.Visible = False
        End If
        If vidas = 3 Then
            Label106.Visible = False
        End If
        If vidas = 2 Then
            Label107.Visible = False
        End If
        If vidas = 1 Then
            Label108.Visible = False
        End If
        If vidas = 0 Then
            Label109.Visible = False
        End If

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.BackColor = Color.MintCream
        Label4.BackColor = Color.MintCream
        Label5.BackColor = Color.MintCream
        Label6.BackColor = Color.MintCream
        Label8.BackColor = Color.MintCream
        Label9.BackColor = Color.MintCream
        Label10.BackColor = Color.MintCream
        Label11.BackColor = Color.MintCream
        Label12.BackColor = Color.MintCream
        Label13.BackColor = Color.MintCream
        Label14.BackColor = Color.MintCream
        Label15.BackColor = Color.MintCream
        Label17.BackColor = Color.MintCream
        Label16.BackColor = Color.MintCream
        Label18.BackColor = Color.MintCream
        Label19.BackColor = Color.MintCream
        Label20.BackColor = Color.MintCream
        Label21.BackColor = Color.MintCream
        Label22.BackColor = Color.MintCream
        Label23.BackColor = Color.MintCream
        Label24.BackColor = Color.MintCream
        Label25.BackColor = Color.MintCream
        Label26.BackColor = Color.MintCream
        Label27.BackColor = Color.MintCream
        Label28.BackColor = Color.MintCream
        Label29.BackColor = Color.MintCream
        Label31.BackColor = Color.MintCream
        Label32.BackColor = Color.MintCream
        Label33.BackColor = Color.MintCream
        Label34.BackColor = Color.MintCream
        Label35.BackColor = Color.MintCream
        Label36.BackColor = Color.MintCream
        Label37.BackColor = Color.MintCream

        Label39.BackColor = Color.MintCream
       
       
        Label52.BackColor = Color.MintCream
        Label53.BackColor = Color.MintCream
        Label54.BackColor = Color.MintCream
        Label55.BackColor = Color.MintCream
        Label56.BackColor = Color.MintCream
        Label57.BackColor = Color.MintCream

        Label59.BackColor = Color.MintCream
        Label60.BackColor = Color.MintCream
        Label61.BackColor = Color.MintCream
        Label62.BackColor = Color.MintCream
        Label63.BackColor = Color.MintCream
        Label64.BackColor = Color.MintCream
        Label65.BackColor = Color.MintCream
        Label66.BackColor = Color.MintCream
        Label67.BackColor = Color.MintCream
        Label68.BackColor = Color.MintCream
        Label69.BackColor = Color.MintCream

        Label71.BackColor = Color.MintCream
        Label72.BackColor = Color.MintCream
        Label73.BackColor = Color.MintCream
        Label74.BackColor = Color.MintCream
        Label75.BackColor = Color.MintCream
        Label76.BackColor = Color.MintCream
        Label77.BackColor = Color.MintCream
        Label78.BackColor = Color.MintCream
        Label79.BackColor = Color.MintCream
        Label80.BackColor = Color.MintCream

        Label82.BackColor = Color.MintCream
        Label83.BackColor = Color.MintCream
        Label84.BackColor = Color.MintCream
        Label90.BackColor = Color.MintCream
        Label91.BackColor = Color.MintCream
        Label92.BackColor = Color.MintCream
        Label93.BackColor = Color.MintCream
        Label94.BackColor = Color.MintCream
        Label95.BackColor = Color.MintCream
        Label96.BackColor = Color.MintCream
        Label97.BackColor = Color.MintCream
        Label98.BackColor = Color.MintCream
        Label99.BackColor = Color.MintCream
        Label100.BackColor = Color.MintCream
        Label101.BackColor = Color.MintCream
        Label115.BackColor = Color.MintCream
        Label116.BackColor = Color.MintCream
        Label117.BackColor = Color.MintCream
        Label118.BackColor = Color.MintCream
        Label119.BackColor = Color.MintCream
        Label120.BackColor = Color.MintCream
        Label121.BackColor = Color.MintCream
        Label122.BackColor = Color.MintCream
      
        Label125.BackColor = Color.MintCream
        Label126.BackColor = Color.MintCream
        Label127.BackColor = Color.MintCream
        Label128.BackColor = Color.MintCream
        Label129.BackColor = Color.MintCream
        Label130.BackColor = Color.MintCream
        Label131.BackColor = Color.MintCream
        Label132.BackColor = Color.MintCream
        Label133.BackColor = Color.MintCream
        Label134.BackColor = Color.MintCream
        Label135.BackColor = Color.MintCream
        Label136.BackColor = Color.MintCream
        
        Label141.BackColor = Color.MintCream
        Label142.BackColor = Color.MintCream
      
        Label145.BackColor = Color.MintCream
        Label146.BackColor = Color.MintCream
        Label147.BackColor = Color.MintCream
        Label148.BackColor = Color.MintCream
        Label149.BackColor = Color.MintCream
        Label150.BackColor = Color.MintCream
        Label151.BackColor = Color.MintCream
        Label152.BackColor = Color.MintCream
        Label156.BackColor = Color.MintCream
        Label157.BackColor = Color.MintCream
        Label158.BackColor = Color.MintCream
        Label159.BackColor = Color.MintCream
        Label160.BackColor = Color.MintCream
        Label161.BackColor = Color.MintCream
        Label162.BackColor = Color.MintCream
        Label163.BackColor = Color.MintCream
        Label164.BackColor = Color.MintCream
        Label171.BackColor = Color.MintCream
        Label172.BackColor = Color.MintCream
        Label173.BackColor = Color.MintCream
        Label174.BackColor = Color.MintCream
        Label175.BackColor = Color.MintCream
        Label176.BackColor = Color.MintCream
        Label177.BackColor = Color.MintCream
        Label181.BackColor = Color.MintCream
        Label182.BackColor = Color.MintCream
        Label184.BackColor = Color.MintCream
        Label190.BackColor = Color.MintCream
        Label193.BackColor = Color.MintCream
        Label194.BackColor = Color.MintCream
        Label197.BackColor = Color.MintCream
        Label198.BackColor = Color.MintCream
        Label234.BackColor = Color.MintCream
        Label199.BackColor = Color.MintCream
        Label200.BackColor = Color.MintCream
        Label203.BackColor = Color.MintCream
        Label204.BackColor = Color.MintCream

        Label205.BackColor = Color.MintCream
        Label206.BackColor = Color.MintCream
        Label207.BackColor = Color.MintCream
        Label208.BackColor = Color.MintCream
        Label210.BackColor = Color.MintCream
        Label211.BackColor = Color.MintCream
      
        Label215.BackColor = Color.MintCream
        Label216.BackColor = Color.MintCream

        Label219.BackColor = Color.MintCream

        Label221.BackColor = Color.MintCream

        Label223.BackColor = Color.MintCream
        Label224.BackColor = Color.MintCream
        Label225.BackColor = Color.MintCream
        Label226.BackColor = Color.MintCream
        Label228.BackColor = Color.MintCream
        Label229.BackColor = Color.MintCream
        Label230.BackColor = Color.MintCream
        Label231.BackColor = Color.MintCream
        Label232.BackColor = Color.MintCream
        Label233.BackColor = Color.MintCream
        Label234.BackColor = Color.MintCream
        Label237.BackColor = Color.MintCream
        Label238.BackColor = Color.MintCream


        Label241.BackColor = Color.MintCream
        Label243.BackColor = Color.MintCream
        Label244.BackColor = Color.MintCream
        Label245.BackColor = Color.MintCream
        Label246.BackColor = Color.MintCream
        Label247.BackColor = Color.MintCream
        Label248.BackColor = Color.MintCream
        Label249.BackColor = Color.MintCream
        Label251.BackColor = Color.MintCream
        Label252.BackColor = Color.MintCream
        Label253.BackColor = Color.MintCream
        Label254.BackColor = Color.MintCream

      

     

        

        Timer1.Stop()  'Detiene el timer
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible= False

        Timer2.Start()

        Label1.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True
        Label30.Visible = True
        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True
        Label35.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True
        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True
        Label43.Visible = True
        Label44.Visible = True
        Label45.Visible = True
        Label46.Visible = True
        Label47.Visible = True
        Label48.Visible = True
        Label49.Visible = True
        Label50.Visible = True
        Label51.Visible = True
        Label52.Visible = True
        Label53.Visible = True
        Label54.Visible = True
        Label55.Visible = True
        Label56.Visible = True
        Label57.Visible = True
        Label58.Visible = True
        Label59.Visible = True
        Label60.Visible = True
        Label61.Visible = True
        Label62.Visible = True
        Label63.Visible = True
        Label64.Visible = True
        Label65.Visible = True
        Label66.Visible = True
        Label67.Visible = True
        Label68.Visible = True
        Label69.Visible = True
        Label70.Visible = True
        Label71.Visible = True
        Label72.Visible = True
        Label73.Visible = True
        Label74.Visible = True
        Label75.Visible = True
        Label76.Visible = True
        Label77.Visible = True
        Label78.Visible = True
        Label79.Visible = True
        Label80.Visible = True
        Label81.Visible = True
        Label82.Visible = True
        Label83.Visible = True
        Label84.Visible = True
        Label85.Visible = True
        Label86.Visible = True
        Label87.Visible = True
        Label88.Visible = True
        Label89.Visible = True
        Label90.Visible = True
        Label91.Visible = True
        Label92.Visible = True
        Label93.Visible = True
        Label94.Visible = True
        Label95.Visible = True
        Label96.Visible = True
        Label97.Visible = True
        Label98.Visible = True
        Label99.Visible = True
        Label100.Visible = True
        Label101.Visible = True
        Label102.Visible = True
        Label103.Visible = True
        Label104.Visible = True
        Label105.Visible = True
        Label106.Visible = True
        Label107.Visible = True
        Label108.Visible = True
        Label109.Visible = True
        Label110.Visible = True
        Label115.Visible = True
        Label116.Visible = True
        Label117.Visible = True
        Label118.Visible = True
        Label119.Visible = True
        Label120.Visible = True
        Label121.Visible = True
        Label122.Visible = True
        Label123.Visible = True
        Label124.Visible = True
        Label125.Visible = True
        Label126.Visible = True
        Label127.Visible = True
        Label128.Visible = True
        Label129.Visible = True
        Label130.Visible = True
        Label131.Visible = True
        Label132.Visible = True
        Label133.Visible = True
        Label134.Visible = True
        Label135.Visible = True
        Label136.Visible = True
        Label137.Visible = True
        Label138.Visible = True
        Label139.Visible = True
        Label140.Visible = True
        Label141.Visible = True
        Label142.Visible = True
        Label143.Visible = True
        Label144.Visible = True
        Label145.Visible = True
        Label146.Visible = True
        Label147.Visible = True
        Label148.Visible = True
        Label149.Visible = True
        Label150.Visible = True
        Label151.Visible = True
        Label152.Visible = True
        Label153.Visible = True
        Label154.Visible = True
        Label155.Visible = True
        Label156.Visible = True
        Label157.Visible = True
        Label158.Visible = True
        Label159.Visible = True
        Label160.Visible = True
        Label161.Visible = True
        Label162.Visible = True
        Label163.Visible = True
        Label164.Visible = True
        Label165.Visible = True
        Label166.Visible = True
        Label167.Visible = True
        Label168.Visible = True
        Label169.Visible = True
        Label170.Visible = True
        Label171.Visible = True
        Label172.Visible = True
        Label173.Visible = True
        Label174.Visible = True
        Label175.Visible = True
        Label176.Visible = True
        Label177.Visible = True
        Label178.Visible = True
        Label179.Visible = True
        Label180.Visible = True
        Label181.Visible = True
        Label182.Visible = True
        Label183.Visible = True
        Label184.Visible = True
        Label185.Visible = True
        Label186.Visible = True
        Label187.Visible = True
        Label188.Visible = True
        Label189.Visible = True
        Label190.Visible = True
        Label191.Visible = True
        Label192.Visible = True
        Label193.Visible = True
        Label194.Visible = True
        Label195.Visible = True
        Label196.Visible = True
        Label197.Visible = True
        Label198.Visible = True
        Label199.Visible = True
        Label200.Visible = True
        Label201.Visible = True
        Label202.Visible = True
        Label203.Visible = True
        Label204.Visible = True
        Label205.Visible = True
        Label206.Visible = True
        Label207.Visible = True
        Label208.Visible = True
        Label209.Visible = True
        Label210.Visible = True
        Label211.Visible = True
        Label212.Visible = True
        Label213.Visible = True
        Label214.Visible = True
        Label215.Visible = True
        Label216.Visible = True
        Label217.Visible = True
        Label218.Visible = True
        Label219.Visible = True
        Label220.Visible = True
        Label221.Visible = True
        Label222.Visible = True
        Label223.Visible = True
        Label224.Visible = True
        Label225.Visible = True
        Label226.Visible = True
        Label227.Visible = True
        Label228.Visible = True
        Label229.Visible = True
        Label230.Visible = True
        Label231.Visible = True
        Label232.Visible = True
        Label233.Visible = True
        Label234.Visible = True
        Label235.Visible = True
        Label236.Visible = True
        Label237.Visible = True
        Label238.Visible = True
        Label239.Visible = True
        Label240.Visible = True
        Label241.Visible = True
        Label242.Visible = True
        Label243.Visible = True
        Label244.Visible = True
        Label245.Visible = True
        Label246.Visible = True
        Label247.Visible = True
        Label248.Visible = True
        Label249.Visible = True
        Label250.Visible = True
        Label251.Visible = True
        Label252.Visible = True
        Label253.Visible = True
        Label254.Visible = True
        Label255.Visible = True
        Label256.Visible = True
        Label257.Visible = True
        Label258.Visible = True
        Label259.Visible = True
        Label260.Visible = True
        Label261.Visible = True
        Label266.Visible = True

        GroupBox2.Visible = True

        Label3.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label4.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label5.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label6.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label8.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label9.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label10.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label11.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label12.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label13.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label14.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label15.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label17.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label16.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label18.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label19.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label20.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label21.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label22.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label23.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label24.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label25.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label26.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label27.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label28.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label29.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label31.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label32.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label33.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label34.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label35.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label36.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label37.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label39.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()


        Label52.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label53.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label54.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label55.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label56.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label57.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label59.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label60.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label61.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label62.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label63.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label64.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label65.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label66.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label67.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label68.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label69.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label71.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label72.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label73.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label74.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label75.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label76.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label77.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label78.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label79.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label80.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label82.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label83.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label84.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label90.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label91.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label92.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label93.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label94.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label95.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label96.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label97.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label98.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label99.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label100.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label101.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label115.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label116.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label117.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label118.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label119.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label120.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label121.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label122.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label125.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label126.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label127.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label128.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label129.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label130.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label131.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label132.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label133.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label134.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label135.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label136.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label141.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label142.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label145.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label146.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label147.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label148.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label149.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label150.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label151.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label152.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label156.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label157.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label158.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label159.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label160.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label161.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label162.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label163.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label164.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label171.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label172.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label173.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label174.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label175.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label176.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label177.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label181.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label182.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label184.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label190.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label193.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label194.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label197.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label198.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label234.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label199.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label200.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label203.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label204.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label205.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label206.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label207.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label208.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label210.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label211.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label215.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label216.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label219.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label221.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label223.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label224.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label225.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label226.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label228.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label229.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label230.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label231.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label232.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label233.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label234.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label237.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label238.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()


        Label241.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label243.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label244.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label245.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label246.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label247.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label248.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label249.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label251.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label252.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label253.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

     

    End Sub

    
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label102.Text = Label102.Text + 1
    End Sub
End Class