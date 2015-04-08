<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTenDangnhap = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnQLNV = New System.Windows.Forms.Button()
        Me.btnQLSP = New System.Windows.Forms.Button()
        Me.btnDangXuat = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnQLKH = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl1, Me.lblTenDangnhap, Me.lbl2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 255)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(353, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl1
        '
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(113, 17)
        Me.lbl1.Text = "Chào mừng tài khoản:"
        '
        'lblTenDangnhap
        '
        Me.lblTenDangnhap.Name = "lblTenDangnhap"
        Me.lblTenDangnhap.Size = New System.Drawing.Size(0, 17)
        '
        'lbl2
        '
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(118, 17)
        Me.lbl2.Text = " đăng nhập thành công"
        '
        'btnQLNV
        '
        Me.btnQLNV.Location = New System.Drawing.Point(65, 19)
        Me.btnQLNV.Name = "btnQLNV"
        Me.btnQLNV.Size = New System.Drawing.Size(96, 79)
        Me.btnQLNV.TabIndex = 2
        Me.btnQLNV.Text = "Quản lý nhân viên"
        Me.btnQLNV.UseVisualStyleBackColor = True
        '
        'btnQLSP
        '
        Me.btnQLSP.Location = New System.Drawing.Point(6, 19)
        Me.btnQLSP.Name = "btnQLSP"
        Me.btnQLSP.Size = New System.Drawing.Size(96, 79)
        Me.btnQLSP.TabIndex = 3
        Me.btnQLSP.Text = "Quản lý sản phẩm"
        Me.btnQLSP.UseVisualStyleBackColor = True
        '
        'btnDangXuat
        '
        Me.btnDangXuat.Location = New System.Drawing.Point(248, 12)
        Me.btnDangXuat.Name = "btnDangXuat"
        Me.btnDangXuat.Size = New System.Drawing.Size(96, 120)
        Me.btnDangXuat.TabIndex = 4
        Me.btnDangXuat.Text = "Đăng xuất"
        Me.btnDangXuat.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(248, 138)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(96, 110)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnQLKH
        '
        Me.btnQLKH.Location = New System.Drawing.Point(121, 19)
        Me.btnQLKH.Name = "btnQLKH"
        Me.btnQLKH.Size = New System.Drawing.Size(96, 79)
        Me.btnQLKH.TabIndex = 6
        Me.btnQLKH.Text = "Quản lý khách hàng"
        Me.btnQLKH.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnQLSP)
        Me.GroupBox1.Controls.Add(Me.btnQLKH)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 110)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dành cho TK thường và Administrator"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnQLNV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 120)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dành cho Administrator"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 277)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangXuat)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bàn làm việc"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnQLNV As System.Windows.Forms.Button
    Friend WithEvents btnQLSP As System.Windows.Forms.Button
    Friend WithEvents lblTenDangnhap As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnDangXuat As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnQLKH As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
