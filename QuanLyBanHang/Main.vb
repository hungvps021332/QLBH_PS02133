Public Class frmMain
    'Sự kiện form_load:
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogin.txtDangNhap.Text = "administrator" Then
            btnQLNV.Enabled = True
        Else
            btnQLNV.Enabled = False
        End If
        lblTenDangnhap.Text = frmLogin.txtDangNhap.Text
    End Sub
    'Sự kiện Button Quản lý sản phẩm
    Private Sub btnQLSP_Click(sender As Object, e As EventArgs) Handles btnQLSP.Click
        frmQLSP.Show()
        Me.Hide()

    End Sub
    'Sự kiện Button Quản lý nhân viên
    Private Sub btnQLNV_Click(sender As Object, e As EventArgs) Handles btnQLNV.Click
        Me.Hide()
        frmQLNV.Show()

    End Sub
    'Sự kiện Button đăng xuất
    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
    'Sự kiện Button Thoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()

    End Sub
    'Sự kiện quản lý khách hàng
    Private Sub btnQLKH_Click(sender As Object, e As EventArgs) Handles btnQLKH.Click
        Me.Hide()
        frmQLKH.Show()
    End Sub
End Class