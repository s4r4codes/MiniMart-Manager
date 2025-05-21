Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prdct_btn.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles splr_btn.Click
    End Sub

    Private Sub odr_btn_Click(sender As Object, e As EventArgs) Handles odr_btn.Click
    End Sub

    Private Sub cstmr_btn_Click(sender As Object, e As EventArgs) Handles cstmr_btn.Click
    End Sub

    Private Sub dshbrd_btn_Click(sender As Object, e As EventArgs) Handles dshbrd_btn.Click
    End Sub

    Private Sub rpt_btn_Click(sender As Object, e As EventArgs) Handles rpt_btn.Click
    End Sub

    Private Sub lgot_btn_Click(sender As Object, e As EventArgs) Handles lgot_btn.Click
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set all buttons to match the panel's background color
        Dim panelColor As Color = header.BackColor

        prdct_btn.BackColor = panelColor
        splr_btn.BackColor = panelColor
        odr_btn.BackColor = panelColor
        cstmr_btn.BackColor = panelColor
        dshbrd_btn.BackColor = panelColor
        rpt_btn.BackColor = panelColor
        lgot_btn.BackColor = panelColor
    End Sub

End Class
