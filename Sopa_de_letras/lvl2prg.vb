Public Class lvl2prg
    Dim puntuación As Integer 'variable de tipo integer llamada úntuación
    Dim vidas As Integer 'variable de tipo integer llamada vidas

    'se declara una variable de tipo char y cada caracter se convierte en un elemento del array
    Dim letrasAbecedario As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
    'declara una variable
    Dim rnd As New Random()


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized 'Agranda el formulario al maximo de la pantalla
        Timer1.Interval = 500   'El intervalo del timer pasa a 0,5 segundos'
        vidas = 10 'la variable "vida" Almacena el valor 10'
        Randomize() 'Hace mas random lo random



    End Sub
  

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False ' oculta el btn2

        Timer2.Enabled = True ' inicia el el timer 2 con un intervalo de 1000

        'Muestra todas las labels
        Label123.Visible = True
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
        Label111.Visible = True
        Label112.Visible = True
        Label113.Visible = True
        Label114.Visible = True


        'genera un numero aleatorio entre  y ese numero se utiliza como indice para acceder a un elemento
        'aleatorio del array  y luego lo convierte en una cadena de textto
        Label1.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label8.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label9.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label10.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
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
        Label28.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label29.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label31.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label33.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label34.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label35.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label36.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label38.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label39.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label40.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label41.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label43.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label44.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label45.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label46.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label47.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label48.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label49.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label50.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label51.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label54.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label55.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label56.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label57.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label58.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label59.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label62.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label63.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label64.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label65.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label66.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label68.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label70.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label71.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label72.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label73.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label74.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label75.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label76.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label79.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label80.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label81.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label83.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label84.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label85.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label86.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label91.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label93.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label94.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label95.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label96.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label97.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label98.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label99.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label100.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label101.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        GroupBox2.Visible = True



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label102.Text = Label102.Text + 1
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        puntuación = puntuación + 1 '
        Label103.Text = puntuación 'Guarda el valor de la variable puntuación en la label103
        Label3.BackColor = Color.Gold 'cuando se hace click en la label esta cambia su backcolor a gold
        Label3.Enabled = False 'Cuando se hace click a la label esta se vuelve enable para que nose vuelva a tocar


        'cuando el backcolor de las labels 3, 4 y 5 sea gold estas cambiaran su backcolor a green
        If Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

        'cuando el backcolor de todas las labels correctas este en verde entonces se abrita el formulario "win" y se cerrara el formulario actual
        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        'Cuando el back color de las labels 3, 4 y 5 sea green entonces la label116 cambiara su backcolor a greeen
        If Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.BackColor = Color.Red 'Cambia el backcolor de la label1 a rojo'
        Timer1.Start() 'inicia el timer con un intervalo de 500

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

        'Cuando las vidas lleguen a 0 se abrira el formulario "lose"
        If vidas = 0 Then
            Lose.Show()
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Despues de ese 0,5 segundo label cambia a su backcolor al default
        Label1.BackColor = Color.MintCream
        Label8.BackColor = Color.MintCream
        Label9.BackColor = Color.MintCream
        Label10.BackColor = Color.MintCream
        Label11.BackColor = Color.MintCream
        Label13.BackColor = Color.MintCream
        Label14.BackColor = Color.MintCream
        Label15.BackColor = Color.MintCream
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
        Label28.BackColor = Color.MintCream
        Label29.BackColor = Color.MintCream
        Label31.BackColor = Color.MintCream
        Label33.BackColor = Color.MintCream
        Label34.BackColor = Color.MintCream
        Label35.BackColor = Color.MintCream
        Label36.BackColor = Color.MintCream
        Label38.BackColor = Color.MintCream
        Label39.BackColor = Color.MintCream
        Label40.BackColor = Color.MintCream
        Label41.BackColor = Color.MintCream
        Label43.BackColor = Color.MintCream
        Label44.BackColor = Color.MintCream
        Label45.BackColor = Color.MintCream
        Label46.BackColor = Color.MintCream
        Label47.BackColor = Color.MintCream
        Label48.BackColor = Color.MintCream
        Label49.BackColor = Color.MintCream
        Label50.BackColor = Color.MintCream
        Label51.BackColor = Color.MintCream
        Label54.BackColor = Color.MintCream
        Label55.BackColor = Color.MintCream
        Label56.BackColor = Color.MintCream
        Label57.BackColor = Color.MintCream
        Label58.BackColor = Color.MintCream
        Label59.BackColor = Color.MintCream
        Label62.BackColor = Color.MintCream
        Label63.BackColor = Color.MintCream
        Label64.BackColor = Color.MintCream
        Label65.BackColor = Color.MintCream
        Label66.BackColor = Color.MintCream
        Label68.BackColor = Color.MintCream
        Label70.BackColor = Color.MintCream
        Label71.BackColor = Color.MintCream
        Label72.BackColor = Color.MintCream
        Label73.BackColor = Color.MintCream
        Label74.BackColor = Color.MintCream
        Label75.BackColor = Color.MintCream
        Label76.BackColor = Color.MintCream
        Label79.BackColor = Color.MintCream
        Label80.BackColor = Color.MintCream
        Label81.BackColor = Color.MintCream
        Label83.BackColor = Color.MintCream
        Label84.BackColor = Color.MintCream
        Label85.BackColor = Color.MintCream
        Label86.BackColor = Color.MintCream
        Label91.BackColor = Color.MintCream
        Label93.BackColor = Color.MintCream
        Label94.BackColor = Color.MintCream
        Label95.BackColor = Color.MintCream
        Label96.BackColor = Color.MintCream
        Label97.BackColor = Color.MintCream
        Label98.BackColor = Color.MintCream
        Label99.BackColor = Color.MintCream
        Label100.BackColor = Color.MintCream
        Label101.BackColor = Color.MintCream

        Timer1.Stop()  'Detiene el timer

    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label4.BackColor = Color.Gold
        Label4.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If


    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label5.BackColor = Color.Gold
        Label5.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If


    End Sub

   
    
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Label8.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Label9.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Label10.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Label11.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Label13.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Label14.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Label15.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        Label16.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        Label18.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Label19.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        Label20.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        Label21.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        Label22.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        Label23.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        Label24.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        Label25.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
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
        End If

    End Sub
    Private Sub Label128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
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
        End If

    End Sub
    Private Sub Label129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
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
        End If

    End Sub
    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click
        Label33.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click
        Label34.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click
        Label35.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click
        Label43.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click
        Label44.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click
        Label45.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
        Label46.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click
        Label47.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click
        Label48.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click
        Label49.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click
        Label50.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        Label51.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click
        Label54.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub
    Private Sub Label153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click
        Label53.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        End If

    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click
        Label55.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click
        Label56.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click
        Label57.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click
        Label58.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click
        Label59.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click
        Label62.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click
        Label63.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click
        Label64.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label66.Click
        Label66.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label68.Click
        Label68.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click
        Label70.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click
        Label71.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label72.Click
        Label72.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label74.Click
        Label74.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label75.Click
        Label75.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click
        Label76.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label79.Click
        Label79.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click
        Label80.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        Label81.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label93.Click
        Label93.BackColor = Color.Red
        Timer1.Start()

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
        End If


    End Sub
    Private Sub Label94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label94.Click
        Label94.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label95.Click
        Label95.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label96.Click
        Label96.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click
        Label97.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click
        Label98.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click
        Label99.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click
        Label100.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click
        Label101.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.Click
        Label65.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label73.Click
        Label73.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click
        Label83.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click
        Label84.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label85.Click
        Label85.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click
        Label86.BackColor = Color.Red
        Timer1.Start()

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
        End If

    End Sub
    Private Sub Label91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label91.Click
        Label91.BackColor = Color.Red
        Timer1.Start()

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
        End If




    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        'PYTHON
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label6.BackColor = Color.Gold
        Label6.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label17.BackColor = Color.Gold
        Label17.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label37.BackColor = Color.Gold
        Label37.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label27.BackColor = Color.Gold
        Label27.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label77.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label77.BackColor = Color.Gold
        Label77.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label67.BackColor = Color.Gold
        Label67.Enabled = False

        If Label6.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold AndAlso Label37.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label77.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold Then
            Label6.BackColor = Color.Green
            Label17.BackColor = Color.Green
            Label37.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label77.BackColor = Color.Green
            Label67.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        'SQL
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label7.BackColor = Color.Gold
        Label7.Enabled = False

        If Label7.BackColor = Color.Gold AndAlso Label12.BackColor = Color.Gold AndAlso Label32.BackColor = Color.Gold Then
            Label7.BackColor = Color.Green
            Label12.BackColor = Color.Green
            Label32.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label12.BackColor = Color.Gold
        Label12.Enabled = False

        If Label7.BackColor = Color.Gold AndAlso Label12.BackColor = Color.Gold AndAlso Label32.BackColor = Color.Gold Then
            Label7.BackColor = Color.Green
            Label12.BackColor = Color.Green
            Label32.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label32.BackColor = Color.Gold
        Label32.Enabled = False

        If Label7.BackColor = Color.Gold AndAlso Label12.BackColor = Color.Gold AndAlso Label32.BackColor = Color.Gold Then
            Label7.BackColor = Color.Green
            Label12.BackColor = Color.Green
            Label32.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click
        'JAVA
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label52.BackColor = Color.Gold
        Label52.Enabled = False

        If Label52.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold AndAlso Label82.BackColor = Color.Gold Then
            Label52.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label92.BackColor = Color.Green
            Label82.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green Then
            Label120.BackColor = Color.Green

        End If

       

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label42.BackColor = Color.Gold
        Label42.Enabled = False

        If Label52.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold AndAlso Label82.BackColor = Color.Gold Then
            Label52.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label92.BackColor = Color.Green
            Label82.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green Then
            Label120.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label92.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label92.BackColor = Color.Gold
        Label92.Enabled = False

        If Label52.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold AndAlso Label82.BackColor = Color.Gold Then
            Label52.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label92.BackColor = Color.Green
            Label82.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green Then
            Label120.BackColor = Color.Green

        End If



    End Sub

    Private Sub Form3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each control As Control In Me.Controls
            'Calcula la nueva posición X y Y para centrar el control
            control.Left = (Me.ClientSize.Width - control.Width) / 2
            control.Top = (Me.ClientSize.Height - control.Height) / 2
        Next

    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label82.BackColor = Color.Gold
        Label82.Enabled = False

        If Label52.BackColor = Color.Gold AndAlso Label42.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold AndAlso Label82.BackColor = Color.Gold Then
            Label52.BackColor = Color.Green
            Label42.BackColor = Color.Green
            Label92.BackColor = Color.Green
            Label82.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green Then
            Label120.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label115_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label115.MouseEnter
        Label115.ForeColor = Color.White

    End Sub
    Private Sub Label115_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label115.MouseLeave
        Label115.ForeColor = Color.Black

    End Sub

    Private Sub Label115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label115.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Label90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label90.Click
        'HTML
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label90.BackColor = Color.Gold
        Label90.Enabled = False

        If Label90.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold Then
            Label90.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green
            Label87.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            Label122.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label88.BackColor = Color.Gold
        Label88.Enabled = False

        If Label90.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold Then
            Label90.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green
            Label87.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            Label122.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label89.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label89.BackColor = Color.Gold
        Label89.Enabled = False

        If Label90.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold Then
            Label90.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green
            Label87.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            Label122.BackColor = Color.Green

        End If

    End Sub




    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label87.BackColor = Color.Gold
        Label87.Enabled = False

        If Label90.BackColor = Color.Gold AndAlso Label88.BackColor = Color.Gold AndAlso Label89.BackColor = Color.Gold AndAlso Label87.BackColor = Color.Gold Then
            Label90.BackColor = Color.Green
            Label88.BackColor = Color.Green
            Label89.BackColor = Color.Green
            Label87.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            Label122.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label30.BackColor = Color.Gold
        Label30.Enabled = False

        If Label30.BackColor = Color.Gold AndAlso Label78.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label30.BackColor = Color.Green
            Label78.BackColor = Color.Green
            Label69.BackColor = Color.Green

        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green Then
            Label117.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label78.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label78.BackColor = Color.Gold
        Label78.Enabled = False

        If Label30.BackColor = Color.Gold AndAlso Label78.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label30.BackColor = Color.Green
            Label78.BackColor = Color.Green
            Label69.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green Then
            Label117.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label69.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label69.BackColor = Color.Gold
        Label69.Enabled = False

        If Label30.BackColor = Color.Gold AndAlso Label78.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label30.BackColor = Color.Green
            Label78.BackColor = Color.Green
            Label69.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green Then
            Label117.BackColor = Color.Green

        End If

    End Sub

    Private Sub Label61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label61.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label61.BackColor = Color.Gold
        Label61.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green Then
            Label118.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label60.BackColor = Color.Gold
        Label60.Enabled = False

        If Label60.BackColor = Color.Gold AndAlso Label61.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
        End If

        If Label60.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label78.BackColor = Color.Green AndAlso Label69.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label37.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label77.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label7.BackColor = Color.Green AndAlso Label12.BackColor = Color.Green AndAlso Label32.BackColor = Color.Green AndAlso Label52.BackColor = Color.Green AndAlso Label42.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label82.BackColor = Color.Green AndAlso Label90.BackColor = Color.Green AndAlso Label88.BackColor = Color.Green AndAlso Label89.BackColor = Color.Green AndAlso Label87.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green Then
            Label118.BackColor = Color.Green
        End If

    End Sub


    

End Class