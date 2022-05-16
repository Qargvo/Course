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
        Me.Error_input = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитькакToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItemF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BirthdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustr = New System.Windows.Forms.MenuStrip()
        Me.lbl_out = New System.Windows.Forms.Label()
        Me.ContextMenuStripMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Error_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menustr.SuspendLayout()
        Me.ContextMenuStripMain.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CalcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.CalcToolStripMenuItemF})
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CalcToolStripMenuItem.Text = "Расчет"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InputToolStripMenuItem.Text = "Ввод данных"
        '
        'CalcToolStripMenuItemF
        '
        Me.CalcToolStripMenuItemF.Name = "CalcToolStripMenuItemF"
        Me.CalcToolStripMenuItemF.Size = New System.Drawing.Size(180, 22)
        Me.CalcToolStripMenuItemF.Text = "Расчет"
        Me.CalcToolStripMenuItemF.Visible = False
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
        Me.menustr.Size = New System.Drawing.Size(476, 24)
        Me.menustr.TabIndex = 7
        Me.menustr.Text = "MenuStrip2"
        '
        'lbl_out
        '
        Me.lbl_out.AutoSize = True
        Me.lbl_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_out.Location = New System.Drawing.Point(22, 41)
        Me.lbl_out.Name = "lbl_out"
        Me.lbl_out.Size = New System.Drawing.Size(0, 24)
        Me.lbl_out.TabIndex = 8
        '
        'ContextMenuStripMain
        '
        Me.ContextMenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStripMain.Name = "ContextMenuStrip1"
        Me.ContextMenuStripMain.Size = New System.Drawing.Size(132, 48)
        '
        'OutToolStripMenuItem
        '
        Me.OutToolStripMenuItem.Name = "OutToolStripMenuItem"
        Me.OutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OutToolStripMenuItem.Text = "Вывести"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ClearToolStripMenuItem.Text = "Отчистить"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 273)
        Me.Controls.Add(Me.lbl_out)
        Me.Controls.Add(Me.menustr)
        Me.Name = "frm_main"
        Me.Text = "Курсовая"
        CType(Me.Error_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menustr.ResumeLayout(False)
        Me.menustr.PerformLayout()
        Me.ContextMenuStripMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Error_input As ErrorProvider
    Friend WithEvents menustr As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитькакToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItemF As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BirthdayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutProgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_out As Label
    Friend WithEvents ContextMenuStripMain As ContextMenuStrip
    Friend WithEvents OutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
