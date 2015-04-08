<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbDangNhap = New System.Windows.Forms.GroupBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtDangNhap = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.lblDangNhap = New System.Windows.Forms.Label()
        Me.btnHuyBo = New System.Windows.Forms.Button()
        Me.grbDangKy = New System.Windows.Forms.GroupBox()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.lblDKMatkhau = New System.Windows.Forms.Label()
        Me.txtDKMatKhau = New System.Windows.Forms.TextBox()
        Me.lblDKDangnhap = New System.Windows.Forms.Label()
        Me.txtDKDangNhap = New System.Windows.Forms.TextBox()
        Me.grbDangNhap.SuspendLayout()
        Me.grbDangKy.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDangNhap
        '
        Me.grbDangNhap.Controls.Add(Me.txtMatKhau)
        Me.grbDangNhap.Controls.Add(Me.txtDangNhap)
        Me.grbDangNhap.Controls.Add(Me.btnDangNhap)
        Me.grbDangNhap.Controls.Add(Me.lblMatKhau)
        Me.grbDangNhap.Controls.Add(Me.lblDangNhap)
        Me.grbDangNhap.Location = New System.Drawing.Point(12, 12)
        Me.grbDangNhap.Name = "grbDangNhap"
        Me.grbDangNhap.Size = New System.Drawing.Size(303, 155)
        Me.grbDangNhap.TabIndex = 0
        Me.grbDangNhap.TabStop = False
        Me.grbDangNhap.Text = "Mời điền tên đăng nhập và mật khẩu"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(75, 58)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(222, 20)
        Me.txtMatKhau.TabIndex = 3
        '
        'txtDangNhap
        '
        Me.txtDangNhap.Location = New System.Drawing.Point(75, 26)
        Me.txtDangNhap.Name = "txtDangNhap"
        Me.txtDangNhap.Size = New System.Drawing.Size(222, 20)
        Me.txtDangNhap.TabIndex = 2
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(91, 84)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(117, 57)
        Me.btnDangNhap.TabIndex = 1
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Location = New System.Drawing.Point(14, 61)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(55, 13)
        Me.lblMatKhau.TabIndex = 1
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'lblDangNhap
        '
        Me.lblDangNhap.AutoSize = True
        Me.lblDangNhap.Location = New System.Drawing.Point(6, 29)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.Size = New System.Drawing.Size(63, 13)
        Me.lblDangNhap.TabIndex = 0
        Me.lblDangNhap.Text = "Đăng nhập:"
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(321, 12)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(117, 303)
        Me.btnHuyBo.TabIndex = 2
        Me.btnHuyBo.Text = "Thoát"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'grbDangKy
        '
        Me.grbDangKy.Controls.Add(Me.btnDangKy)
        Me.grbDangKy.Controls.Add(Me.btnNhapLai)
        Me.grbDangKy.Controls.Add(Me.lblDKMatkhau)
        Me.grbDangKy.Controls.Add(Me.txtDKMatKhau)
        Me.grbDangKy.Controls.Add(Me.lblDKDangnhap)
        Me.grbDangKy.Controls.Add(Me.txtDKDangNhap)
        Me.grbDangKy.Location = New System.Drawing.Point(11, 173)
        Me.grbDangKy.Name = "grbDangKy"
        Me.grbDangKy.Size = New System.Drawing.Size(304, 142)
        Me.grbDangKy.TabIndex = 3
        Me.grbDangKy.TabStop = False
        Me.grbDangKy.Text = "Đăng ký nhanh"
        '
        'btnDangKy
        '
        Me.btnDangKy.Location = New System.Drawing.Point(10, 77)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(117, 57)
        Me.btnDangKy.TabIndex = 6
        Me.btnDangKy.Text = "Đăng ký"
        Me.btnDangKy.UseVisualStyleBackColor = True
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Location = New System.Drawing.Point(181, 77)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(117, 57)
        Me.btnNhapLai.TabIndex = 4
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'lblDKMatkhau
        '
        Me.lblDKMatkhau.AutoSize = True
        Me.lblDKMatkhau.Location = New System.Drawing.Point(15, 54)
        Me.lblDKMatkhau.Name = "lblDKMatkhau"
        Me.lblDKMatkhau.Size = New System.Drawing.Size(55, 13)
        Me.lblDKMatkhau.TabIndex = 5
        Me.lblDKMatkhau.Text = "Mật khẩu:"
        '
        'txtDKMatKhau
        '
        Me.txtDKMatKhau.Location = New System.Drawing.Point(76, 51)
        Me.txtDKMatKhau.Name = "txtDKMatKhau"
        Me.txtDKMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDKMatKhau.Size = New System.Drawing.Size(222, 20)
        Me.txtDKMatKhau.TabIndex = 5
        '
        'lblDKDangnhap
        '
        Me.lblDKDangnhap.AutoSize = True
        Me.lblDKDangnhap.Location = New System.Drawing.Point(7, 22)
        Me.lblDKDangnhap.Name = "lblDKDangnhap"
        Me.lblDKDangnhap.Size = New System.Drawing.Size(63, 13)
        Me.lblDKDangnhap.TabIndex = 4
        Me.lblDKDangnhap.Text = "Đăng nhập:"
        '
        'txtDKDangNhap
        '
        Me.txtDKDangNhap.Location = New System.Drawing.Point(76, 19)
        Me.txtDKDangNhap.Name = "txtDKDangNhap"
        Me.txtDKDangNhap.Size = New System.Drawing.Size(222, 20)
        Me.txtDKDangNhap.TabIndex = 4
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 333)
        Me.Controls.Add(Me.grbDangKy)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.grbDangNhap)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.grbDangNhap.ResumeLayout(False)
        Me.grbDangNhap.PerformLayout()
        Me.grbDangKy.ResumeLayout(False)
        Me.grbDangKy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDangNhap As System.Windows.Forms.GroupBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents lblDangNhap As System.Windows.Forms.Label
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents grbDangKy As System.Windows.Forms.GroupBox
    Friend WithEvents btnDangKy As System.Windows.Forms.Button
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
    Friend WithEvents lblDKMatkhau As System.Windows.Forms.Label
    Friend WithEvents txtDKMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents lblDKDangnhap As System.Windows.Forms.Label
    Friend WithEvents txtDKDangNhap As System.Windows.Forms.TextBox

End Class
