Public Class Form1
    Dim time As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Lancer" Then

            Timer1.Start()
            Button1.Text = "Arrêter"
        Else
            Timer1.Stop()
            Button1.Text = "Lancer"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "00 : 00 : 00"
        time = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        time = time + 1

        Dim heures As Integer = time \ 3600
        Dim Minutes As Integer = (time Mod 3600) \ 60
        Dim Secondes As Integer = (time Mod 3600) Mod 60

        Label1.Text = heures.ToString("00") & " : " & Minutes.ToString("00") & " : " & Secondes.ToString("00")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
