Public Class frm_titul
    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_main.Show()
    End Sub
End Class
