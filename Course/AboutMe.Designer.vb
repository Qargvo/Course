<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_aboutMe
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.pct_me = New System.Windows.Forms.PictureBox()
        CType(Me.pct_me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(167, 349)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(69, 28)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "Ок"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'pct_me
        '
        Me.pct_me.Image = Global.Course.My.Resources.Resources._me
        Me.pct_me.Location = New System.Drawing.Point(12, 12)
        Me.pct_me.Name = "pct_me"
        Me.pct_me.Size = New System.Drawing.Size(224, 331)
        Me.pct_me.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_me.TabIndex = 1
        Me.pct_me.TabStop = False
        '
        'frm_aboutMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 389)
        Me.Controls.Add(Me.pct_me)
        Me.Controls.Add(Me.btn_exit)
        Me.Name = "frm_aboutMe"
        Me.Text = "Обо мне"
        CType(Me.pct_me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents pct_me As System.Windows.Forms.PictureBox
End Class
