Public Class animales1
    Dim vidas As Integer
    Dim puntuación As Integer

    Private letrasAbecedario As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
    Private rnd As New Random()

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label1.BackColor = Color.Gold
        Label1.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

      

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If


        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label3.BackColor = Color.Gold
        Label3.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

       

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label4.BackColor = Color.Gold
        Label4.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If


        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label5.BackColor = Color.Gold
        Label5.Enabled = False

        If Label1.BackColor = Color.Gold AndAlso Label3.BackColor = Color.Gold AndAlso Label4.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

       

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If


        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label21.BackColor = Color.Gold
        Label21.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label17.BackColor = Color.Green
        End If

       

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label20.BackColor = Color.Gold
        Label20.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label17.BackColor = Color.Green
        End If

        

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label18.BackColor = Color.Gold
        Label18.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label17.BackColor = Color.Green
        End If

       

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label19.BackColor = Color.Gold
        Label19.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label17.BackColor = Color.Green
        End If

      

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label17.BackColor = Color.Gold
        Label17.Enabled = False

        If Label21.BackColor = Color.Gold AndAlso Label20.BackColor = Color.Gold AndAlso Label19.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label17.BackColor = Color.Gold Then
            Label21.BackColor = Color.Green
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label17.BackColor = Color.Green
        End If

       

        If Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Timer2.Start()

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label41.Visible = True
        Label40.Visible = True
        Label38.Visible = True
        Label39.Visible = True
        Label31.Visible = True
        Label30.Visible = True
        Label29.Visible = True
        Label28.Visible = True
        Label68.Visible = True
        Label69.Visible = True
        Label66.Visible = True
        Label67.Visible = True
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
        Label115.Visible = True
        Label102.Visible = True
        Label103.Visible = True
        Label104.Visible = True
        Label105.Visible = True



        GroupBox2.Visible = True

        Label26.Visible = True
        Label28.Visible = True
        Label37.Visible = True
        Label36.Visible = True
        Label27.Visible = True
        Label26.Visible = True
        Label16.Visible = True
        Label11.Visible = True
        Label6.Visible = True
        Label76.Visible = True
        Label77.Visible = True
        Label78.Visible = True
        Label79.Visible = True
        Label80.Visible = True
        Label81.Visible = True
        Label70.Visible = True
        Label71.Visible = True

        Button2.Visible = False

        Label6.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label11.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label16.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label36.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label37.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label26.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label27.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label76.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label77.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label78.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label79.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label80.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label81.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label71.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label70.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label41.BackColor = Color.Gold
        Label41.Enabled = False

        If Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label38.BackColor = Color.Green
        End If

        If Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label118.BackColor = Color.Green

        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label40.BackColor = Color.Gold
        Label40.Enabled = False

        If Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label38.BackColor = Color.Green
        End If

        If Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label118.BackColor = Color.Green

        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label38.BackColor = Color.Gold
        Label38.Enabled = False

        If Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label38.BackColor = Color.Green
        End If

        If Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label118.BackColor = Color.Green

        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label39.BackColor = Color.Gold
        Label39.Enabled = False

        If Label41.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label38.BackColor = Color.Gold Then
            Label41.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label38.BackColor = Color.Green
        End If

        If Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green Then
            Label118.BackColor = Color.Green

        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label31.BackColor = Color.Gold
        Label31.Enabled = False

        If Label31.BackColor = Color.Gold AndAlso Label30.BackColor = Color.Gold AndAlso Label29.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold Then
            Label31.BackColor = Color.Green
            Label30.BackColor = Color.Green
            Label29.BackColor = Color.Green
            Label28.BackColor = Color.Green
        End If

        If Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            Label7.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label30.BackColor = Color.Gold
        Label30.Enabled = False

        If Label31.BackColor = Color.Gold AndAlso Label30.BackColor = Color.Gold AndAlso Label29.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold Then
            Label31.BackColor = Color.Green
            Label30.BackColor = Color.Green
            Label29.BackColor = Color.Green
            Label28.BackColor = Color.Green
        End If

        If Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            Label7.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label28.BackColor = Color.Gold
        Label28.Enabled = False

        If Label31.BackColor = Color.Gold AndAlso Label30.BackColor = Color.Gold AndAlso Label29.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold Then
            Label31.BackColor = Color.Green
            Label30.BackColor = Color.Green
            Label29.BackColor = Color.Green
            Label28.BackColor = Color.Green
        End If

        If Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            Label7.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label29.BackColor = Color.Gold
        Label29.Enabled = False

        If Label31.BackColor = Color.Gold AndAlso Label30.BackColor = Color.Gold AndAlso Label29.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold Then
            Label31.BackColor = Color.Green
            Label30.BackColor = Color.Green
            Label29.BackColor = Color.Green
            Label28.BackColor = Color.Green
        End If

        If Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            Label7.BackColor = Color.Green
        End If

        If Label1.BackColor = Color.Green AndAlso Label3.BackColor = Color.Green AndAlso Label4.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label20.BackColor = Color.Green AndAlso Label19.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label17.BackColor = Color.Green AndAlso Label41.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label38.BackColor = Color.Green AndAlso Label31.BackColor = Color.Green AndAlso Label30.BackColor = Color.Green AndAlso Label29.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        

        Label6.BackColor = Color.MintCream

      
        Label11.BackColor = Color.MintCream
      
        Label16.BackColor = Color.MintCream
      
       
        Label27.BackColor = Color.MintCream
      
        
        Label36.BackColor = Color.MintCream
        Label37.BackColor = Color.MintCream
       



        Label70.BackColor = Color.MintCream
        Label71.BackColor = Color.MintCream
       
        Label77.BackColor = Color.MintCream
        Label79.BackColor = Color.MintCream
        Label78.BackColor = Color.MintCream
        Label80.BackColor = Color.MintCream
        Label81.BackColor = Color.MintCream
      



        Timer1.Stop()  'Detiene el timer'
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

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        Label81.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click
        Label71.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click
        Label70.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label68.BackColor = Color.Gold
        Label68.Enabled = False

        If Label66.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold AndAlso Label68.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label66.BackColor = Color.LightSlateGray
            Label67.BackColor = Color.LightSlateGray
            Label68.BackColor = Color.LightSlateGray
            Label69.BackColor = Color.LightSlateGray
        End If

    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label69.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label69.BackColor = Color.Gold
        Label69.Enabled = False

        If Label66.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold AndAlso Label68.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label66.BackColor = Color.LightSlateGray
            Label67.BackColor = Color.LightSlateGray
            Label68.BackColor = Color.LightSlateGray
            Label69.BackColor = Color.LightSlateGray
        End If
    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label67.BackColor = Color.Gold
        Label67.Enabled = False

        If Label66.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold AndAlso Label68.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label66.BackColor = Color.LightSlateGray
            Label67.BackColor = Color.LightSlateGray
            Label68.BackColor = Color.LightSlateGray
            Label69.BackColor = Color.LightSlateGray
        End If
    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label66.BackColor = Color.Gold
        Label66.Enabled = False

        If Label66.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold AndAlso Label68.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label66.BackColor = Color.LightSlateGray
            Label67.BackColor = Color.LightSlateGray
            Label68.BackColor = Color.LightSlateGray
            Label69.BackColor = Color.LightSlateGray
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub animales1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Interval = 500   'El intervalo del timer pasa a 0,5 segundos'
        vidas = 10 'la variable "vida" Almacena el valor 10'
        Randomize()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label102.Text = Label102.Text + 1
    End Sub

    Private Sub Label66_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label66.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label66.BackColor = Color.Gold
        Label66.Enabled = False

        If Label66.BackColor = Color.Gold AndAlso Label67.BackColor = Color.Gold AndAlso Label68.BackColor = Color.Gold AndAlso Label69.BackColor = Color.Gold Then
            Label66.BackColor = Color.LightSlateGray
            Label67.BackColor = Color.LightSlateGray
            Label68.BackColor = Color.LightSlateGray
            Label69.BackColor = Color.LightSlateGray
        End If
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.White 'Cambia el color de la fuente de la label1

    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black 'Cambia el color de la fuente de la label1

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub

    
    
End Class