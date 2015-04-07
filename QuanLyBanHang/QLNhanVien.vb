Public Class frmQLNV

    Private Sub USER_PS02133BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles USER_PS02133BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.USER_PS02133BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub QLNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.USER_PS02133' table. You can move, or remove it, as needed.
        Me.USER_PS02133TableAdapter.Fill(Me.DataSet1.USER_PS02133)

    End Sub

    Private Sub USER_PS02133BindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles USER_PS02133BindingNavigator.RefreshItems

    End Sub

    Private Sub btnQuayve_Click(sender As Object, e As EventArgs) Handles btnQuayve.Click
        Me.Hide()
        frmMain.Show()

    End Sub
End Class