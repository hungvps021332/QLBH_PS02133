Public Class frmMain

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogin.txtDangNhap.Text = "administrator" Then
            btnQLNV.Enabled = True
        Else
            btnQLNV.Enabled = False
        End If
        lblTenDangnhap.Text = frmLogin.txtDangNhap.Text
    End Sub

    Private Sub btnQLSP_Click(sender As Object, e As EventArgs) Handles btnQLSP.Click
        frmQLSP.Show()
        Me.Hide()

    End Sub

    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangXuat.Click
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
    End Sub

    Private Sub btnQLNV_Click(sender As Object, e As EventArgs) Handles btnQLNV.Click
        Me.Hide()
        frmQLNV.Show()

    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()

    End Sub
End Class