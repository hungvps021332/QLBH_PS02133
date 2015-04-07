<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKH
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
        Me.lblQLKH = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtDT = New System.Windows.Forms.TextBox()
        Me.grbNhaplieu = New System.Windows.Forms.GroupBox()
        Me.btnXoaTrang = New System.Windows.Forms.Button()
        Me.btnQuayve = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.grbThongtin = New System.Windows.Forms.GroupBox()
        Me.dgvTTKH = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New QuanLyBanHang.DataSet1()
        Me.KHACH_HANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KHACH_HANGTableAdapter = New QuanLyBanHang.DataSet1TableAdapters.KHACH_HANGTableAdapter()
        Me.TableAdapterManager = New QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager()
        Me.grbNhaplieu.SuspendLayout()
        Me.grbThongtin.SuspendLayout()
        CType(Me.dgvTTKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHACH_HANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQLKH
        '
        Me.lblQLKH.AutoSize = True
        Me.lblQLKH.Font = New System.Drawing.Font("Cambria", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLKH.Location = New System.Drawing.Point(89, 9)
        Me.lblQLKH.Name = "lblQLKH"
        Me.lblQLKH.Size = New System.Drawing.Size(504, 57)
        Me.lblQLKH.TabIndex = 0
        Me.lblQLKH.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(7, 16)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(88, 13)
        Me.lblMaKH.TabIndex = 1
        Me.lblMaKH.Text = "Mã khách hàng: "
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(6, 45)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(89, 13)
        Me.lblTenKH.TabIndex = 2
        Me.lblTenKH.Text = "Tên khách hàng:"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Location = New System.Drawing.Point(52, 74)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(43, 13)
        Me.lblDiachi.TabIndex = 3
        Me.lblDiachi.Text = "Địa chỉ:"
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(19, 168)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(76, 13)
        Me.lblSDT.TabIndex = 4
        Me.lblSDT.Text = "Số điện thoại: "
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(101, 13)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(159, 20)
        Me.txtMaKH.TabIndex = 5
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(101, 42)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(158, 20)
        Me.txtTenKH.TabIndex = 6
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(101, 71)
        Me.txtDC.Multiline = True
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(158, 88)
        Me.txtDC.TabIndex = 7
        '
        'txtDT
        '
        Me.txtDT.Location = New System.Drawing.Point(101, 165)
        Me.txtDT.Name = "txtDT"
        Me.txtDT.Size = New System.Drawing.Size(158, 20)
        Me.txtDT.TabIndex = 8
        '
        'grbNhaplieu
        '
        Me.grbNhaplieu.Controls.Add(Me.btnXoaTrang)
        Me.grbNhaplieu.Controls.Add(Me.btnQuayve)
        Me.grbNhaplieu.Controls.Add(Me.btnXoa)
        Me.grbNhaplieu.Controls.Add(Me.btnSua)
        Me.grbNhaplieu.Controls.Add(Me.btnThem)
        Me.grbNhaplieu.Controls.Add(Me.lblMaKH)
        Me.grbNhaplieu.Controls.Add(Me.txtDT)
        Me.grbNhaplieu.Controls.Add(Me.lblTenKH)
        Me.grbNhaplieu.Controls.Add(Me.txtDC)
        Me.grbNhaplieu.Controls.Add(Me.lblDiachi)
        Me.grbNhaplieu.Controls.Add(Me.txtTenKH)
        Me.grbNhaplieu.Controls.Add(Me.lblSDT)
        Me.grbNhaplieu.Controls.Add(Me.txtMaKH)
        Me.grbNhaplieu.Location = New System.Drawing.Point(12, 74)
        Me.grbNhaplieu.Name = "grbNhaplieu"
        Me.grbNhaplieu.Size = New System.Drawing.Size(273, 332)
        Me.grbNhaplieu.TabIndex = 9
        Me.grbNhaplieu.TabStop = False
        Me.grbNhaplieu.Text = "Nhập liệu"
        '
        'btnXoaTrang
        '
        Me.btnXoaTrang.Location = New System.Drawing.Point(135, 268)
        Me.btnXoaTrang.Name = "btnXoaTrang"
        Me.btnXoaTrang.Size = New System.Drawing.Size(124, 58)
        Me.btnXoaTrang.TabIndex = 13
        Me.btnXoaTrang.Text = "Xóa trắng"
        Me.btnXoaTrang.UseVisualStyleBackColor = True
        '
        'btnQuayve
        '
        Me.btnQuayve.Location = New System.Drawing.Point(10, 268)
        Me.btnQuayve.Name = "btnQuayve"
        Me.btnQuayve.Size = New System.Drawing.Size(124, 58)
        Me.btnQuayve.TabIndex = 12
        Me.btnQuayve.Text = "Quay về bàn làm việc"
        Me.btnQuayve.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(184, 204)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 58)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(97, 204)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 58)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(10, 204)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 58)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'grbThongtin
        '
        Me.grbThongtin.Controls.Add(Me.dgvTTKH)
        Me.grbThongtin.Location = New System.Drawing.Point(291, 74)
        Me.grbThongtin.Name = "grbThongtin"
        Me.grbThongtin.Size = New System.Drawing.Size(384, 332)
        Me.grbThongtin.TabIndex = 10
        Me.grbThongtin.TabStop = False
        Me.grbThongtin.Text = "Thông tin khách hàng"
        '
        'dgvTTKH
        '
        Me.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTTKH.Location = New System.Drawing.Point(6, 19)
        Me.dgvTTKH.Name = "dgvTTKH"
        Me.dgvTTKH.Size = New System.Drawing.Size(371, 307)
        Me.dgvTTKH.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KHACH_HANGBindingSource
        '
        Me.KHACH_HANGBindingSource.DataMember = "KHACH_HANG"
        Me.KHACH_HANGBindingSource.DataSource = Me.DataSet1
        '
        'KHACH_HANGTableAdapter
        '
        Me.KHACH_HANGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHI_TIET_HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.KHACH_HANGTableAdapter = Me.KHACH_HANGTableAdapter
        Me.TableAdapterManager.LOAI_SAN_PHAMTableAdapter = Nothing
        Me.TableAdapterManager.SAN_PHAMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USER_PS02133TableAdapter = Nothing
        '
        'frmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 418)
        Me.Controls.Add(Me.grbThongtin)
        Me.Controls.Add(Me.grbNhaplieu)
        Me.Controls.Add(Me.lblQLKH)
        Me.Name = "frmQLKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý khách hàng"
        Me.grbNhaplieu.ResumeLayout(False)
        Me.grbNhaplieu.PerformLayout()
        Me.grbThongtin.ResumeLayout(False)
        CType(Me.dgvTTKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHACH_HANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQLKH As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblSDT As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents txtDT As System.Windows.Forms.TextBox
    Friend WithEvents grbNhaplieu As System.Windows.Forms.GroupBox
    Friend WithEvents grbThongtin As System.Windows.Forms.GroupBox
    Friend WithEvents btnXoaTrang As System.Windows.Forms.Button
    Friend WithEvents btnQuayve As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As QuanLyBanHang.DataSet1
    Friend WithEvents KHACH_HANGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KHACH_HANGTableAdapter As QuanLyBanHang.DataSet1TableAdapters.KHACH_HANGTableAdapter
    Friend WithEvents TableAdapterManager As QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents dgvTTKH As System.Windows.Forms.DataGridView
End Class
