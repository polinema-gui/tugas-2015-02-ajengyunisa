Public Class Form1

    Dim samadengan As String
    Dim input As Integer
    Dim d As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_Box.Text = "0"
    End Sub
    Private Sub btn_Satu_Click(sender As Object, e As EventArgs) Handles btn_Satu.Click
        If (d = "0") Then
            d = "1"
        Else
            d &= "1"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Dua_Click(sender As Object, e As EventArgs) Handles btn_Dua.Click
        If (d = "0") Then
            d = "2"
        Else
            d &= "2"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Tiga_Click(sender As Object, e As EventArgs) Handles btn_Tiga.Click
        If (d = "0") Then
            d = "3"
        Else
            d &= "3"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Empat_Click(sender As Object, e As EventArgs) Handles btn_Empat.Click
        If (d = "0") Then
            d = "4"
        Else
            d &= "4"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Lima_Click(sender As Object, e As EventArgs) Handles btn_Lima.Click
        If (d = "0") Then
            d = "5"
        Else
            d &= "5"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Enam_Click(sender As Object, e As EventArgs) Handles btn_Enam.Click
        If (d = "0") Then
            d = "6"
        Else
            d &= "6"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Tujuh_Click(sender As Object, e As EventArgs) Handles btn_Tujuh.Click
        If (d = "0") Then
            d = "7"
        Else
            d &= "7"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Delapan_Click(sender As Object, e As EventArgs) Handles btn_Delapan.Click
        If (d = "0") Then
            d = "8"
        Else
            d &= "8"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Sembilan_Click(sender As Object, e As EventArgs) Handles btn_Sembilan.Click
        If (d = "0") Then
            d = "9"
        Else
            d &= "9"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Nol_Click(sender As Object, e As EventArgs) Handles btn_Nol.Click
        If (d = "0") Then
            d = "0"
        Else
            d &= "0"
        End If
        text_Box.Text = d
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        text_Box.Text = "0"
        d = Nothing
    End Sub

    Private Sub btn_Samadengan_Click(sender As Object, e As EventArgs) Handles btn_Samadengan.Click
        Select Case Me.samadengan
            Case "hasilsatu"
                text_Box.Text = Convert.ToString(input + text_Box.Text)
            Case "hasildua"
                text_Box.Text = Convert.ToString(input - text_Box.Text)
        End Select
    End Sub

    Private Sub btn_Plus_Click(sender As Object, e As EventArgs) Handles btn_Plus.Click
        Me.samadengan = "hasilsatu"
        Me.input = text_Box.Text
        d = Nothing
    End Sub

    Private Sub btn_Min_Click(sender As Object, e As EventArgs) Handles btn_Min.Click
        Me.samadengan = "hasildua"
        Me.input = text_Box.Text
        d = Nothing
    End Sub
End Class
