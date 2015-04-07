Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQLSP
    Dim ketqua As New DataTable
    Dim constr As String = "workstation id=hungvps02133.mssql.somee.com;packet size=4096;user id=percywangyin_SQLLogin_1;pwd=ryolqj1mrm;data source=hungvps02133.mssql.somee.com;persist security info=False;initial catalog=hungvps02133"
    Public Sub LData()
        Dim con As New SqlConnection(constr)
        Dim sqlAdap As New SqlDataAdapter("select * from SAN_PHAM", con)
        Try
            sqlAdap.Fill(ketqua)
        Catch ex As Exception

        End Try
        dgvSP.DataSource = ketqua
        con.Close()

    End Sub
    Private Sub frmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(constr)
        Dim sqlAdap As New SqlDataAdapter("Select * from SAN_PHAM", con)
        Try
            con.Open()
            sqlAdap.Fill(ketqua)

        Catch ex As Exception

        End Try
        dgvSP.DataSource = ketqua
        con.Close()

    End Sub

    Private Sub dgvSP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellClick
        Dim cell As Integer = dgvSP.CurrentCell.RowIndex
        txtMaSp.Text = dgvSP.Item(0, cell).Value
        txtTenSP.Text = dgvSP.Item(1, cell).Value
        txtGiatien.Text = dgvSP.Item(2, cell).Value
        txtMLSP.Text = dgvSP.Item(3, cell).Value
        nudSoluong.Value = dgvSP.Item(4, cell).Value
        cboDonvi.Text = dgvSP.Item(5, cell).Value
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "update SAN_PHAM set MA_SP = @MA_SP, TEN_SP = @TEN_SP, GIA_TIEN = @GIA_TIEN, MA_LOAI_SP = @MA_LOAI_SP, SO_LUONG = @SO_LUONG, DON_VI = @DON_VI where MA_SP = @MA_SP"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_SP", txtMaSp.Text)
            concommand.Parameters.AddWithValue("@TEN_SP", txtTenSP.Text)
            concommand.Parameters.AddWithValue("@GIA_TIEN", txtGiatien.Text)
            concommand.Parameters.AddWithValue("@MA_LOAI_SP", txtMLSP.Text)
            concommand.Parameters.AddWithValue("@SO_LUONG", nudSoluong.Text)
            concommand.Parameters.AddWithValue("@DON_VI", cboDonvi.Text)
            concommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Dữ liệu có sai sót!")

        End Try
        ketqua.Clear()
        dgvSP.DataSource = ketqua
        dgvSP.DataSource = Nothing
        LData()
        txtMaSp.Clear()
        txtTenSP.Clear()
        txtGiatien.Clear()
        txtMLSP.Clear()
        nudSoluong.Value = 0
        cboDonvi.Text = ""





    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "delete from SAN_PHAM where MA_SP = @MA_SP"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_SP", txtMaSp.Text)
            concommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa không thành công!")

        End Try
        ketqua.Clear()
        dgvSP.DataSource = ketqua
        dgvSP.DataSource = Nothing
        LData()

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim stringadd As String = "INSERT INTO SAN_PHAM (MA_SP, TEN_SP, GIA_TIEN, MA_LOAI_SP, SO_LUONG, DON_VI) VALUES (@MA_SP, @TEN_SP, @GIA_TIEN, @MA_LOAI_SP, @SO_LUONG, @DON_VI)"
        Dim concommand As New SqlCommand(stringadd, con)
        Try
            concommand.Parameters.AddWithValue("@MA_SP", Me.txtMaSp.Text)
            concommand.Parameters.AddWithValue("@TEN_SP", Me.txtTenSP.Text)
            concommand.Parameters.AddWithValue("@GIA_TIEN", Me.txtGiatien.Text)
            concommand.Parameters.AddWithValue("@MA_LOAI_SP", Me.txtMLSP.Text)
            concommand.Parameters.AddWithValue("@SO_LUONG", Me.nudSoluong.Text)
            concommand.Parameters.AddWithValue("@DON_VI", Me.cboDonvi.Text)
            concommand.ExecuteNonQuery()
            con.Close()
           
        Catch ex As Exception
            
            If MessageBox.Show("Vui lòng xem lại dữ liệu!") Then
                txtMaSp.Focus()
            End If

        End Try
        ketqua.Clear()
        dgvSP.DataSource = ketqua
        dgvSP.DataSource = Nothing
        LData()
        txtMaSp.Clear()
        txtTenSP.Clear()
        txtGiatien.Clear()
        txtMLSP.Clear()
        nudSoluong.Value = 0
        cboDonvi.Text = ""

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Hide()
        frmMain.Show()
    End Sub

End Class