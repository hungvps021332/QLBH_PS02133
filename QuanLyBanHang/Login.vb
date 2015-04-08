'Khai báo dữ liệu sql từ máy client
Imports System.Data.SqlClient
Public Class frmLogin
    'gán con cho quyền kết nối SQL
    Dim con As New SqlConnection
    'Sự kiện Button Đăng nhập
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim ConnectString As String = "workstation id=hungvps02133.mssql.somee.com;packet size=4096;user id=percywangyin_SQLLogin_1;pwd=ryolqj1mrm;data source=hungvps02133.mssql.somee.com;persist security info=False;initial catalog=hungvps02133"

        Dim Connect As SqlConnection = New SqlConnection(ConnectString)
        Dim SQLAdap As New SqlDataAdapter("select * from USER_PS02133 where ID ='" & txtDangNhap.Text & "' and Password = '" & txtMatKhau.Text & "' ", ConnectString)
        Dim KetQua As New DataTable

        Try
            Connect.Open()
            SQLAdap.Fill(KetQua)
            If KetQua.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu")
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Sự kiện button Hủy bỏ
    Private Sub btnHuyBo_Click(sender As Object, e As EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Dim ketqua As Integer
        If txtDKDangNhap.Text = "" Or txtDKMatKhau.Text = "" Then
            MsgBox("Vui lòng điền tên đăng nhập hoặc mật khẩu")
        Else
            con.ConnectionString = "workstation id=hungvps02133.mssql.somee.com;packet size=4096;user id=percywangyin_SQLLogin_1;pwd=ryolqj1mrm;data source=hungvps02133.mssql.somee.com;persist security info=False;initial catalog=hungvps02133"

            con.Open()
            Dim cmd As New SqlCommand(("INSERT INTO USER_PS02133 VALUES('" & txtDKDangNhap.Text & "', '" & txtDKMatKhau.Text & "')  "), con)
            ketqua = cmd.ExecuteNonQuery()
            If ketqua = 0 Then
                MsgBox("Đã có người đăng ký! Vui lòng nhập lại tên đăng nhập")
            Else
                MsgBox("Đăng ký thành công")
            End If
            con.Close()
            txtDKDangNhap.Clear()
            txtDKMatKhau.Clear()
            txtDangNhap.Focus()

        End If
    End Sub
    'Sự kiện button Login
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        con.ConnectionString = "workstation id=hungvps02133.mssql.somee.com;packet size=4096;user id=percywangyin_SQLLogin_1;pwd=ryolqj1mrm;data source=hungvps02133.mssql.somee.com;persist security info=False;initial catalog=hungvps02133"

    End Sub
    'Sự kiện button nhập lại
    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs) Handles btnNhapLai.Click
        txtDKDangNhap.Clear()
        txtDKMatKhau.Clear()
    End Sub
End Class
