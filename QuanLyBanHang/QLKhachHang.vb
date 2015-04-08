'Khai báo dữ liệu từ SQL
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQLKH
    'Gán quyền cho bảng ở phía database
    Dim ketqua As New DataTable
    'Gán chuỗi kết nối
    Dim constr As String = "workstation id=hungvps02133.mssql.somee.com;packet size=4096;user id=percywangyin_SQLLogin_1;pwd=ryolqj1mrm;data source=hungvps02133.mssql.somee.com;persist security info=False;initial catalog=hungvps02133"
    'Tạo một public sub tải dữ liệu từ database
    Public Sub Ldata()
        Dim con As New SqlConnection(constr)
        Dim sqlAdap As New SqlDataAdapter("select * from KHACH_HANG", con)
        Try
            sqlAdap.Fill(ketqua)
        Catch ex As Exception

        End Try
        dgvTTKH.DataSource = ketqua
        con.Close()
    End Sub
    'Sự kiện form LOAD'
    Private Sub frmQLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(constr)
        Dim sqlAdap As New SqlDataAdapter("Select * from KHACH_HANG", con)
        Try
            con.Open()
            sqlAdap.Fill(ketqua)

        Catch ex As Exception

        End Try
        dgvTTKH.DataSource = ketqua
        con.Close()
    End Sub
    'Sự kiện nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "INSERT INTO KHACH_HANG (MA_KH, HO_TEN, DIA_CHI, SO_DIEN_THOAI) VALUES (@MA_KH, @HO_TEN, @DIA_CHI, @SO_DIEN_THOAI)"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_KH", Me.txtMaKH.Text)
            concommand.Parameters.AddWithValue("@HO_TEN", Me.txtTenKH.Text)
            concommand.Parameters.AddWithValue("@DIA_CHI", Me.txtDC.Text)
            concommand.Parameters.AddWithValue("@SO_DIEN_THOAI", Me.txtDT.Text)
            concommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception

            If MessageBox.Show("Vui lòng xem lại dữ liệu!") Then
                txtMaKH.Focus()
            End If

        End Try
        ketqua.Clear()
        dgvTTKH.DataSource = ketqua
        dgvTTKH.DataSource = Nothing
        Ldata()
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDC.Clear()
        txtDT.Clear()
    End Sub
    'Sự kiện nút sửa
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "update KHACH_HANG set MA_KH = @MA_KH, HO_TEN = @HO_TEN, DIA_CHI = @DIA_CHI, SO_DIEN_THOAI = @SO_DIEN_THOAI where MA_KH = @MA_KH"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_KH", Me.txtMaKH.Text)
            concommand.Parameters.AddWithValue("@HO_TEN", Me.txtTenKH.Text)
            concommand.Parameters.AddWithValue("@DIA_CHI", Me.txtDC.Text)
            concommand.Parameters.AddWithValue("@SO_DIEN_THOAI", Me.txtDT.Text)
            concommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Dữ liệu có sai sót!")

        End Try
        ketqua.Clear()
        dgvTTKH.DataSource = ketqua
        dgvTTKH.DataSource = Nothing
        Ldata()
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDC.Clear()
        txtDT.Clear()
    End Sub
    'Sự kiện Cellclick trong bảng databgribview
    Private Sub dgvTTKH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTTKH.CellClick
        Dim cell As Integer = dgvTTKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvTTKH.Item(0, cell).Value
        txtTenKH.Text = dgvTTKH.Item(1, cell).Value
        txtDC.Text = dgvTTKH.Item(2, cell).Value
        txtDT.Text = dgvTTKH.Item(3, cell).Value
    End Sub
    'Sự kiện nút xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "delete from KHACH_HANG where MA_KH = @MA_KH"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_KH", txtMaKH.Text)
            concommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa không thành công!")

        End Try
        ketqua.Clear()
        dgvTTKH.DataSource = ketqua
        dgvTTKH.DataSource = Nothing
        Ldata()
    End Sub
    'sự kiện xóa trắng trên textbox
    Private Sub btnXoaTrang_Click(sender As Object, e As EventArgs) Handles btnXoaTrang.Click
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDC.Clear()
        txtDT.Clear()
    End Sub
    'Sự kiện nút quay về form main
    Private Sub btnQuayve_Click(sender As Object, e As EventArgs) Handles btnQuayve.Click
        Me.Hide()
        frmMain.Show()

    End Sub
End Class