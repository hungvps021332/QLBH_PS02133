<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSP
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
        Me.components = New System.ComponentModel.Container()
        Me.lblQLSP = New System.Windows.Forms.Label()
        Me.grbNhaplieu = New System.Windows.Forms.GroupBox()
        Me.cboDonvi = New System.Windows.Forms.ComboBox()
        Me.lblDonvi = New System.Windows.Forms.Label()
        Me.nudSoluong = New System.Windows.Forms.NumericUpDown()
        Me.lblSoluong = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMLSP = New System.Windows.Forms.TextBox()
        Me.txtGiatien = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSp = New System.Windows.Forms.TextBox()
        Me.lblMLSP = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblGiatien = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.grbTTSP = New System.Windows.Forms.GroupBox()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.SAN_PHAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New QuanLyBanHang.DataSet1()
        Me.SAN_PHAMTableAdapter = New QuanLyBanHang.DataSet1TableAdapters.SAN_PHAMTableAdapter()
        Me.TableAdapterManager = New QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager()
        Me.grbNhaplieu.SuspendLayout()
        CType(Me.nudSoluong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTTSP.SuspendLayout()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAN_PHAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQLSP
        '
        Me.lblQLSP.AutoSize = True
        Me.lblQLSP.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblQLSP.Location = New System.Drawing.Point(295, 9)
        Me.lblQLSP.Name = "lblQLSP"
        Me.lblQLSP.Size = New System.Drawing.Size(253, 32)
        Me.lblQLSP.TabIndex = 0
        Me.lblQLSP.Text = "QUẢN LÝ SẢN PHẨM"
        '
        'grbNhaplieu
        '
        Me.grbNhaplieu.Controls.Add(Me.cboDonvi)
        Me.grbNhaplieu.Controls.Add(Me.lblDonvi)
        Me.grbNhaplieu.Controls.Add(Me.nudSoluong)
        Me.grbNhaplieu.Controls.Add(Me.lblSoluong)
        Me.grbNhaplieu.Controls.Add(Me.btnThoat)
        Me.grbNhaplieu.Controls.Add(Me.btnXoa)
        Me.grbNhaplieu.Controls.Add(Me.btnSua)
        Me.grbNhaplieu.Controls.Add(Me.btnThem)
        Me.grbNhaplieu.Controls.Add(Me.txtMLSP)
        Me.grbNhaplieu.Controls.Add(Me.txtGiatien)
        Me.grbNhaplieu.Controls.Add(Me.txtTenSP)
        Me.grbNhaplieu.Controls.Add(Me.txtMaSp)
        Me.grbNhaplieu.Controls.Add(Me.lblMLSP)
        Me.grbNhaplieu.Controls.Add(Me.lblTenSP)
        Me.grbNhaplieu.Controls.Add(Me.lblGiatien)
        Me.grbNhaplieu.Controls.Add(Me.lblMaSP)
        Me.grbNhaplieu.Location = New System.Drawing.Point(12, 44)
        Me.grbNhaplieu.Name = "grbNhaplieu"
        Me.grbNhaplieu.Size = New System.Drawing.Size(311, 365)
        Me.grbNhaplieu.TabIndex = 8
        Me.grbNhaplieu.TabStop = False
        Me.grbNhaplieu.Text = "Nhập liệu"
        '
        'cboDonvi
        '
        Me.cboDonvi.FormattingEnabled = True
        Me.cboDonvi.Items.AddRange(New Object() {"Thùng", "Lon", "Chai", "Hộp"})
        Me.cboDonvi.Location = New System.Drawing.Point(115, 193)
        Me.cboDonvi.Name = "cboDonvi"
        Me.cboDonvi.Size = New System.Drawing.Size(185, 21)
        Me.cboDonvi.TabIndex = 23
        '
        'lblDonvi
        '
        Me.lblDonvi.AutoSize = True
        Me.lblDonvi.Location = New System.Drawing.Point(68, 193)
        Me.lblDonvi.Name = "lblDonvi"
        Me.lblDonvi.Size = New System.Drawing.Size(41, 13)
        Me.lblDonvi.TabIndex = 22
        Me.lblDonvi.Text = "Đơn vị:"
        '
        'nudSoluong
        '
        Me.nudSoluong.Location = New System.Drawing.Point(115, 149)
        Me.nudSoluong.Name = "nudSoluong"
        Me.nudSoluong.Size = New System.Drawing.Size(185, 20)
        Me.nudSoluong.TabIndex = 21
        '
        'lblSoluong
        '
        Me.lblSoluong.AutoSize = True
        Me.lblSoluong.Location = New System.Drawing.Point(57, 156)
        Me.lblSoluong.Name = "lblSoluong"
        Me.lblSoluong.Size = New System.Drawing.Size(52, 13)
        Me.lblSoluong.TabIndex = 20
        Me.lblSoluong.Text = "Số lượng:"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(31, 286)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(240, 62)
        Me.btnThoat.TabIndex = 19
        Me.btnThoat.Text = "Trở về bàn làm việc"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(196, 227)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 53)
        Me.btnXoa.TabIndex = 18
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(115, 227)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 53)
        Me.btnSua.TabIndex = 17
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(34, 227)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 53)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMLSP
        '
        Me.txtMLSP.Location = New System.Drawing.Point(115, 118)
        Me.txtMLSP.Name = "txtMLSP"
        Me.txtMLSP.Size = New System.Drawing.Size(185, 20)
        Me.txtMLSP.TabIndex = 15
        '
        'txtGiatien
        '
        Me.txtGiatien.Location = New System.Drawing.Point(115, 83)
        Me.txtGiatien.Name = "txtGiatien"
        Me.txtGiatien.Size = New System.Drawing.Size(185, 20)
        Me.txtGiatien.TabIndex = 14
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(115, 52)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(185, 20)
        Me.txtTenSP.TabIndex = 13
        '
        'txtMaSp
        '
        Me.txtMaSp.Location = New System.Drawing.Point(115, 18)
        Me.txtMaSp.Name = "txtMaSp"
        Me.txtMaSp.Size = New System.Drawing.Size(185, 20)
        Me.txtMaSp.TabIndex = 12
        '
        'lblMLSP
        '
        Me.lblMLSP.AutoSize = True
        Me.lblMLSP.Location = New System.Drawing.Point(16, 121)
        Me.lblMLSP.Name = "lblMLSP"
        Me.lblMLSP.Size = New System.Drawing.Size(93, 13)
        Me.lblMLSP.TabIndex = 11
        Me.lblMLSP.Text = "Mã loại sản phẩm:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Location = New System.Drawing.Point(31, 59)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(78, 13)
        Me.lblTenSP.TabIndex = 9
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'lblGiatien
        '
        Me.lblGiatien.AutoSize = True
        Me.lblGiatien.Location = New System.Drawing.Point(63, 90)
        Me.lblGiatien.Name = "lblGiatien"
        Me.lblGiatien.Size = New System.Drawing.Size(46, 13)
        Me.lblGiatien.TabIndex = 10
        Me.lblGiatien.Text = "Giá tiền:"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Location = New System.Drawing.Point(35, 25)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(74, 13)
        Me.lblMaSP.TabIndex = 8
        Me.lblMaSP.Text = "Mã sản phẩm:"
        '
        'grbTTSP
        '
        Me.grbTTSP.Controls.Add(Me.dgvSP)
        Me.grbTTSP.Location = New System.Drawing.Point(329, 44)
        Me.grbTTSP.Name = "grbTTSP"
        Me.grbTTSP.Size = New System.Drawing.Size(508, 365)
        Me.grbTTSP.TabIndex = 9
        Me.grbTTSP.TabStop = False
        Me.grbTTSP.Text = "Thông tin sản phẩm"
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(6, 19)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.ReadOnly = True
        Me.dgvSP.Size = New System.Drawing.Size(492, 340)
        Me.dgvSP.TabIndex = 0
        '
        'SAN_PHAMBindingSource
        '
        Me.SAN_PHAMBindingSource.DataMember = "SAN_PHAM"
        Me.SAN_PHAMBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SAN_PHAMTableAdapter
        '
        Me.SAN_PHAMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHI_TIET_HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.KHACH_HANGTableAdapter = Nothing
        Me.TableAdapterManager.LOAI_SAN_PHAMTableAdapter = Nothing
        Me.TableAdapterManager.SAN_PHAMTableAdapter = Me.SAN_PHAMTableAdapter
        Me.TableAdapterManager.UpdateOrder = QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USER_PS02133TableAdapter = Nothing
        '
        'frmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 419)
        Me.Controls.Add(Me.grbTTSP)
        Me.Controls.Add(Me.grbNhaplieu)
        Me.Controls.Add(Me.lblQLSP)
        Me.Name = "frmQLSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sản phẩm"
        Me.grbNhaplieu.ResumeLayout(False)
        Me.grbNhaplieu.PerformLayout()
        CType(Me.nudSoluong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTTSP.ResumeLayout(False)
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAN_PHAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQLSP As System.Windows.Forms.Label
    Friend WithEvents grbNhaplieu As System.Windows.Forms.GroupBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtMLSP As System.Windows.Forms.TextBox
    Friend WithEvents txtGiatien As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSp As System.Windows.Forms.TextBox
    Friend WithEvents lblMLSP As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblGiatien As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents grbTTSP As System.Windows.Forms.GroupBox
    Friend WithEvents DataSet1 As QuanLyBanHang.DataSet1
    Friend WithEvents SAN_PHAMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAN_PHAMTableAdapter As QuanLyBanHang.DataSet1TableAdapters.SAN_PHAMTableAdapter
    Friend WithEvents TableAdapterManager As QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents dgvSP As System.Windows.Forms.DataGridView
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents nudSoluong As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSoluong As System.Windows.Forms.Label
    Friend WithEvents cboDonvi As System.Windows.Forms.ComboBox
    Friend WithEvents lblDonvi As System.Windows.Forms.Label
End Class
