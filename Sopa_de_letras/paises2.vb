Public Class paises2
    Dim vidas As Integer
    Dim puntuación As Integer

    Private letrasAbecedario As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
    Private rnd As New Random()

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label3.BackColor = Color.Gold
        Label3.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If


    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label18.BackColor = Color.Gold
        Label18.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label39.BackColor = Color.Gold
        Label39.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label27.BackColor = Color.Gold
        Label27.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label76.BackColor = Color.Gold
        Label76.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label65.BackColor = Color.Gold
        Label65.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label53.BackColor = Color.Gold
        Label53.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label44.BackColor = Color.Gold
        Label44.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label92.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label92.BackColor = Color.Gold
        Label92.Enabled = False

        If Label3.BackColor = Color.Gold AndAlso Label18.BackColor = Color.Gold AndAlso Label39.BackColor = Color.Gold AndAlso Label27.BackColor = Color.Gold AndAlso Label76.BackColor = Color.Gold AndAlso Label65.BackColor = Color.Gold AndAlso Label53.BackColor = Color.Gold AndAlso Label44.BackColor = Color.Gold AndAlso Label92.BackColor = Color.Gold Then
            Label3.BackColor = Color.Green
            Label18.BackColor = Color.Green
            Label39.BackColor = Color.Green
            Label27.BackColor = Color.Green
            Label76.BackColor = Color.Green
            Label65.BackColor = Color.Green
            Label53.BackColor = Color.Green
            Label44.BackColor = Color.Green
            Label92.BackColor = Color.Green

        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green Then
            Label116.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False

        Timer2.Start()

        GroupBox2.Visible = True
        Label115.Visible = True
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



        Label4.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

       
        Label9.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        
        Label12.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label13.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label14.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label15.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label17.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label16.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label19.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label20.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label22.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label23.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label24.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label25.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label26.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()


        Label29.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label31.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label32.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label33.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label34.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label35.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label36.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label37.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()




        Label52.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label54.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()


        Label62.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label63.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label64.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label66.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label68.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label69.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label71.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label72.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label73.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label74.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label75.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label77.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label78.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label80.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label82.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label83.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label84.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label90.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label91.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()

        Label93.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
        Label94.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()
     
       

        Label101.Text = letrasAbecedario(rnd.Next(0, letrasAbecedario.Length)).ToString()


        
     
    
       

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label8.BackColor = Color.Gold
        Label8.Enabled = False

        If Label8.BackColor = Color.Gold AndAlso Label10.BackColor = Color.Gold AndAlso Label11.BackColor = Color.Gold AndAlso Label6.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label8.BackColor = Color.Green
            Label10.BackColor = Color.Green
            Label11.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

        
        If Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label120.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label10.BackColor = Color.Gold
        Label10.Enabled = False

        If Label8.BackColor = Color.Gold AndAlso Label10.BackColor = Color.Gold AndAlso Label11.BackColor = Color.Gold AndAlso Label6.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label8.BackColor = Color.Green
            Label10.BackColor = Color.Green
            Label11.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If


        If Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label120.BackColor = Color.Green
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label11.BackColor = Color.Gold
        Label11.Enabled = False

        If Label8.BackColor = Color.Gold AndAlso Label10.BackColor = Color.Gold AndAlso Label11.BackColor = Color.Gold AndAlso Label6.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label8.BackColor = Color.Green
            Label10.BackColor = Color.Green
            Label11.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If


        If Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label120.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label6.BackColor = Color.Gold
        Label6.Enabled = False

        If Label8.BackColor = Color.Gold AndAlso Label10.BackColor = Color.Gold AndAlso Label11.BackColor = Color.Gold AndAlso Label6.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label8.BackColor = Color.Green
            Label10.BackColor = Color.Green
            Label11.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If

        If Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label120.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label5.BackColor = Color.Gold
        Label5.Enabled = False

        If Label8.BackColor = Color.Gold AndAlso Label10.BackColor = Color.Gold AndAlso Label11.BackColor = Color.Gold AndAlso Label6.BackColor = Color.Gold AndAlso Label5.BackColor = Color.Gold Then
            Label8.BackColor = Color.Green
            Label10.BackColor = Color.Green
            Label11.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label5.BackColor = Color.Green
        End If


        If Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green Then
            Label120.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label100.BackColor = Color.Gold
        Label100.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label98.BackColor = Color.Gold
        Label98.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label99.BackColor = Color.Gold
        Label99.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label97.BackColor = Color.Gold
        Label97.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label96.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label96.BackColor = Color.Gold
        Label96.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label95.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label95.BackColor = Color.Gold
        Label95.Enabled = False

        If Label100.BackColor = Color.Gold AndAlso Label99.BackColor = Color.Gold AndAlso Label98.BackColor = Color.Gold AndAlso Label97.BackColor = Color.Gold AndAlso Label96.BackColor = Color.Gold AndAlso Label95.BackColor = Color.Gold Then
            Label100.BackColor = Color.Green
            Label98.BackColor = Color.Green
            Label99.BackColor = Color.Green
            Label97.BackColor = Color.Green
            Label96.BackColor = Color.Green
            Label95.BackColor = Color.Green
        End If


        If Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green Then
            Label117.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label67.BackColor = Color.Gold
        Label67.Enabled = False

        If Label67.BackColor = Color.Gold AndAlso Label79.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label21.BackColor = Color.Gold Then
            Label67.BackColor = Color.Green
            Label79.BackColor = Color.Green
            Label28.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label21.BackColor = Color.Green

        End If


        If Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label79.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label79.BackColor = Color.Gold
        Label79.Enabled = False

        If Label67.BackColor = Color.Gold AndAlso Label79.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label21.BackColor = Color.Gold Then
            Label67.BackColor = Color.Green
            Label79.BackColor = Color.Green
            Label28.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label21.BackColor = Color.Green

        End If


        If Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label28.BackColor = Color.Gold
        Label28.Enabled = False

        If Label67.BackColor = Color.Gold AndAlso Label79.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label21.BackColor = Color.Gold Then
            Label67.BackColor = Color.Green
            Label79.BackColor = Color.Green
            Label28.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label21.BackColor = Color.Green

        End If


        If Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label40.BackColor = Color.Gold
        Label40.Enabled = False

        If Label67.BackColor = Color.Gold AndAlso Label79.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label21.BackColor = Color.Gold Then
            Label67.BackColor = Color.Green
            Label79.BackColor = Color.Green
            Label28.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label21.BackColor = Color.Green

        End If


        If Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label21.BackColor = Color.Gold
        Label21.Enabled = False

        If Label67.BackColor = Color.Gold AndAlso Label79.BackColor = Color.Gold AndAlso Label28.BackColor = Color.Gold AndAlso Label40.BackColor = Color.Gold AndAlso Label21.BackColor = Color.Gold Then
            Label67.BackColor = Color.Green
            Label79.BackColor = Color.Green
            Label28.BackColor = Color.Green
            Label40.BackColor = Color.Green
            Label21.BackColor = Color.Green

        End If


        If Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green Then
            Label119.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label61.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label61.BackColor = Color.Gold
        Label61.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label60.BackColor = Color.Gold
        Label60.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label58.BackColor = Color.Gold
        Label58.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label59.BackColor = Color.Gold
        Label59.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label57.BackColor = Color.Gold
        Label57.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label56.BackColor = Color.Gold
        Label56.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click
        puntuación = puntuación + 1
        Label103.Text = puntuación
        Label55.BackColor = Color.Gold
        Label55.Enabled = False

        If Label61.BackColor = Color.Gold AndAlso Label60.BackColor = Color.Gold AndAlso Label59.BackColor = Color.Gold AndAlso Label58.BackColor = Color.Gold AndAlso Label57.BackColor = Color.Gold AndAlso Label56.BackColor = Color.Gold AndAlso Label55.BackColor = Color.Gold Then
            Label61.BackColor = Color.Green
            Label60.BackColor = Color.Green
            Label59.BackColor = Color.Green
            Label58.BackColor = Color.Green
            Label57.BackColor = Color.Green
            Label56.BackColor = Color.Green
            Label55.BackColor = Color.Green

        End If


        If Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            Label121.BackColor = Color.Green
        End If

        If Label3.BackColor = Color.Green AndAlso Label18.BackColor = Color.Green AndAlso Label39.BackColor = Color.Green AndAlso Label27.BackColor = Color.Green AndAlso Label76.BackColor = Color.Green AndAlso Label65.BackColor = Color.Green AndAlso Label53.BackColor = Color.Green AndAlso Label44.BackColor = Color.Green AndAlso Label92.BackColor = Color.Green AndAlso Label8.BackColor = Color.Green AndAlso Label10.BackColor = Color.Green AndAlso Label11.BackColor = Color.Green AndAlso Label6.BackColor = Color.Green AndAlso Label5.BackColor = Color.Green AndAlso Label100.BackColor = Color.Green AndAlso Label99.BackColor = Color.Green AndAlso Label98.BackColor = Color.Green AndAlso Label97.BackColor = Color.Green AndAlso Label96.BackColor = Color.Green AndAlso Label95.BackColor = Color.Green AndAlso Label67.BackColor = Color.Green AndAlso Label79.BackColor = Color.Green AndAlso Label28.BackColor = Color.Green AndAlso Label40.BackColor = Color.Green AndAlso Label21.BackColor = Color.Green AndAlso Label61.BackColor = Color.Green AndAlso Label60.BackColor = Color.Green AndAlso Label59.BackColor = Color.Green AndAlso Label58.BackColor = Color.Green AndAlso Label57.BackColor = Color.Green AndAlso Label56.BackColor = Color.Green AndAlso Label55.BackColor = Color.Green Then
            win.Show()
            Me.Close()
        End If

    End Sub

    
    Private Sub paises2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Interval = 500   'El intervalo del timer pasa a 0,5 segundos'
        vidas = 10 'la variable "vida" Almacena el valor 10'
        Randomize()
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.White

    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label102.Text = Label102.Text + 1
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Label9.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label7.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        Label20.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Label19.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Label15.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Label13.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Label14.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Label12.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
            Me.Close()
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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        Label32.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
            Me.Close()
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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        Label22.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label75.Click
        Label75.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label73.Click
        Label73.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label74.Click
        Label74.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label72.Click
        Label72.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click
        Label63.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click
        Label64.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click
        Label62.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click
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
            Me.Close()
        End If
    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click
        Label52.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        Label63.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click
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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
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
            Me.Close()
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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click
        Label42.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click
        Label101.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label93.Click
        Label93.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label94.Click
        Label94.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label91.Click
        Label91.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label90.Click
        Label90.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click
        Label88.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

    Private Sub Label89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label89.Click
        Label89.BackColor = Color.Red   'Cambia el color de fondo de la label1 a rojo'
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

End Class