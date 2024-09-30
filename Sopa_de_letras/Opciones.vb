﻿Public Class Opciones

    Private Sub Opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        Me.Left = (screenWidth - formWidth) \ 2
        Me.Top = (screenHeight - formHeight) \ 2
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        soporte.Show()
    End Sub
    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        comojugar.Show()
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.White 'Cambia el color de la fuente de la label3

    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black 'Cambia el color de la fuente de la label3

    End Sub
End Class