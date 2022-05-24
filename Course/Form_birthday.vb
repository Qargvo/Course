Public Class frm_birthday
    Dim now_date As Date = Now()
    Dim birthday As Date = #10/17/2001#
    Dim diff As New Dictionary(Of String, String)()


    'Инициализация
    Private Sub frm_birthday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_now.Text = Format(now_date, "dd/MM/yyyy")
        txt_birth.Text = Format(birthday, "dd/MM/yyyy")
        diff.Add("Лет", "yyyy")
        diff.Add("Кварталов", "q")
        diff.Add("Месяцев", "m")
        diff.Add("Недель", "ww")
        diff.Add("Дней", "d")
        For Each i In diff
            cmb_dif.Items.Add(i.Key)
        Next i
        cmb_dif.SelectedIndex = 0
        calc()
    End Sub
    'кнопка выхода
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Hide()
    End Sub
    'функция расчета и вывода
    Function calc() As Integer
        txt_output.Text = DateDiff(diff(cmb_dif.Text), birthday, now_date)
        Return 0
    End Function
    'вызов фунуии расчета и вывода при нажатии на кнопку
    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        calc()
    End Sub
End Class