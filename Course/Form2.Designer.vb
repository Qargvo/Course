﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menustr = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитькакToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BirthdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustr.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(12, 398)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(79, 40)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = True
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.Text = "NotifyIcon3"
        Me.NotifyIcon3.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'menustr
        '
        Me.menustr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.CalcToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustr.Location = New System.Drawing.Point(0, 0)
        Me.menustr.Name = "menustr"
        Me.menustr.Size = New System.Drawing.Size(800, 24)
        Me.menustr.TabIndex = 7
        Me.menustr.Text = "MenuStrip2"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьToolStripMenuItem, Me.СохранитькакToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FIleToolStripMenuItem.Text = "Файл"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Image = CType(resources.GetObject("СохранитьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.СохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СохранитьToolStripMenuItem.Text = "&Сохранить"
        '
        'СохранитькакToolStripMenuItem
        '
        Me.СохранитькакToolStripMenuItem.Name = "СохранитькакToolStripMenuItem"
        Me.СохранитькакToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СохранитькакToolStripMenuItem.Text = "Сохранить &как"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Вы&ход"
        '
        'CalcToolStripMenuItem
        '
        Me.CalcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.CalcToolStripMenuItem1})
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CalcToolStripMenuItem.Text = "Расчет"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.InputToolStripMenuItem.Text = "Ввод данных"
        '
        'CalcToolStripMenuItem1
        '
        Me.CalcToolStripMenuItem1.Name = "CalcToolStripMenuItem1"
        Me.CalcToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.CalcToolStripMenuItem1.Text = "Расчет"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BirthdayToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ToolsToolStripMenuItem.Text = "Инструменты"
        '
        'BirthdayToolStripMenuItem
        '
        Me.BirthdayToolStripMenuItem.Name = "BirthdayToolStripMenuItem"
        Me.BirthdayToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BirthdayToolStripMenuItem.Text = "День рождения"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CalculatorToolStripMenuItem.Text = "Калькулятор"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMeToolStripMenuItem, Me.AboutProgToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.HelpToolStripMenuItem.Text = "Помощь"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AboutMeToolStripMenuItem.Text = "Про меня"
        '
        'AboutProgToolStripMenuItem
        '
        Me.AboutProgToolStripMenuItem.Name = "AboutProgToolStripMenuItem"
        Me.AboutProgToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AboutProgToolStripMenuItem.Text = "О программе"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menustr)
        Me.Controls.Add(Me.btn_exit)
        Me.Name = "frm_main"
        Me.Text = "Курсовая"
        Me.menustr.ResumeLayout(False)
        Me.menustr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents menustr As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитькакToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BirthdayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutProgToolStripMenuItem As ToolStripMenuItem
End Class