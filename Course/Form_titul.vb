Public Class frm_titul

    'Выход
    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        If MsgBox("Вы уверены?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Выход") = vbYes Then End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Me.Hide() 'переход к главной форме
        frm_main.Show()
    End Sub
    'Инициализациия label
    Private Sub frm_titul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_mainTittle.Text = "СПбГУПТД Высшая Школа Технологии и Энергетики" & vbCrLf & vbCrLf &
            "Кафедра Информационно-измерительных технологий и систем управления" & vbCrLf &
        "Курсовая работа по дисциплине 'Программирование и основы алгоритмизации в АСУТП'" & vbCrLf &
        "На тему:'Разработка автоматизированного рабочего места технолога'"
    End Sub
End Class
