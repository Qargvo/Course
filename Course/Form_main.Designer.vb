<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pnl_input = New System.Windows.Forms.Panel()
        Me.lbl_x3 = New System.Windows.Forms.Label()
        Me.lbl_x2 = New System.Windows.Forms.Label()
        Me.lbl_x1 = New System.Windows.Forms.Label()
        Me.txt_x3 = New System.Windows.Forms.TextBox()
        Me.txt_x2 = New System.Windows.Forms.TextBox()
        Me.txt_x1 = New System.Windows.Forms.TextBox()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Error_input = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.menustr = New System.Windows.Forms.MenuStrip()
        Me.pnl_input.SuspendLayout()
        CType(Me.Error_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menustr.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_input
        '
        Me.pnl_input.Controls.Add(Me.txt_x3)
        Me.pnl_input.Controls.Add(Me.txt_x2)
        Me.pnl_input.Controls.Add(Me.txt_x1)
        Me.pnl_input.Location = New System.Drawing.Point(82, 104)
        Me.pnl_input.Name = "pnl_input"
        Me.pnl_input.Size = New System.Drawing.Size(98, 113)
        Me.pnl_input.TabIndex = 8
        '
        'lbl_x3
        '
        Me.lbl_x3.AutoSize = True
        Me.lbl_x3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_x3.Location = New System.Drawing.Point(42, 184)
        Me.lbl_x3.Name = "lbl_x3"
        Me.lbl_x3.Size = New System.Drawing.Size(34, 24)
        Me.lbl_x3.TabIndex = 5
        Me.lbl_x3.Text = "X3"
        '
        'lbl_x2
        '
        Me.lbl_x2.AutoSize = True
        Me.lbl_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_x2.Location = New System.Drawing.Point(42, 149)
        Me.lbl_x2.Name = "lbl_x2"
        Me.lbl_x2.Size = New System.Drawing.Size(34, 24)
        Me.lbl_x2.TabIndex = 4
        Me.lbl_x2.Text = "X2"
        '
        'lbl_x1
        '
        Me.lbl_x1.AutoSize = True
        Me.lbl_x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_x1.Location = New System.Drawing.Point(42, 114)
        Me.lbl_x1.Name = "lbl_x1"
        Me.lbl_x1.Size = New System.Drawing.Size(34, 24)
        Me.lbl_x1.TabIndex = 3
        Me.lbl_x1.Text = "X1"
        '
        'txt_x3
        '
        Me.txt_x3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_x3.Location = New System.Drawing.Point(3, 77)
        Me.txt_x3.Name = "txt_x3"
        Me.txt_x3.Size = New System.Drawing.Size(90, 29)
        Me.txt_x3.TabIndex = 2
        '
        'txt_x2
        '
        Me.txt_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_x2.Location = New System.Drawing.Point(3, 42)
        Me.txt_x2.Name = "txt_x2"
        Me.txt_x2.Size = New System.Drawing.Size(90, 29)
        Me.txt_x2.TabIndex = 1
        '
        'txt_x1
        '
        Me.txt_x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_x1.Location = New System.Drawing.Point(3, 7)
        Me.txt_x1.Name = "txt_x1"
        Me.txt_x1.Size = New System.Drawing.Size(90, 29)
        Me.txt_x1.TabIndex = 0
        '
        'txt_output
        '
        Me.txt_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_output.Location = New System.Drawing.Point(352, 143)
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(118, 29)
        Me.txt_output.TabIndex = 9
        '
        'btn_calc
        '
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_calc.Location = New System.Drawing.Point(352, 183)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(118, 34)
        Me.btn_calc.TabIndex = 10
        Me.btn_calc.Text = "Расчет"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 50)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Расчет  производительности вакуум-фильтра по сухому веществу"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Error_input
        '
        Me.Error_input.ContainerControl = Me
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
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.СохранитьToolStripMenuItem.Text = "&Сохранить"
        '
        'СохранитькакToolStripMenuItem
        '
        Me.СохранитькакToolStripMenuItem.Name = "СохранитькакToolStripMenuItem"
        Me.СохранитькакToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.СохранитькакToolStripMenuItem.Text = "Сохранить &как"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
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
        'menustr
        '
        Me.menustr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.CalcToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustr.Location = New System.Drawing.Point(0, 0)
        Me.menustr.Name = "menustr"
        Me.menustr.Size = New System.Drawing.Size(631, 24)
        Me.menustr.TabIndex = 7
        Me.menustr.Text = "MenuStrip2"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 388)
        Me.Controls.Add(Me.lbl_x3)
        Me.Controls.Add(Me.lbl_x2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_x1)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.pnl_input)
        Me.Controls.Add(Me.menustr)
        Me.Name = "frm_main"
        Me.Text = "Курсовая"
        Me.pnl_input.ResumeLayout(False)
        Me.pnl_input.PerformLayout()
        CType(Me.Error_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menustr.ResumeLayout(False)
        Me.menustr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_input As Panel
    Friend WithEvents txt_x1 As TextBox
    Friend WithEvents txt_x3 As TextBox
    Friend WithEvents txt_x2 As TextBox
    Friend WithEvents lbl_x3 As Label
    Friend WithEvents lbl_x2 As Label
    Friend WithEvents lbl_x1 As Label
    Friend WithEvents txt_output As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Error_input As ErrorProvider
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
