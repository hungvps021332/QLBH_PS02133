<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLNV))
        Me.DataSet1 = New QuanLyBanHang.DataSet1()
        Me.USER_PS02133BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USER_PS02133TableAdapter = New QuanLyBanHang.DataSet1TableAdapters.USER_PS02133TableAdapter()
        Me.TableAdapterManager = New QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager()
        Me.USER_PS02133BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.USER_PS02133BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.USER_PS02133DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuayve = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_PS02133BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_PS02133BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.USER_PS02133BindingNavigator.SuspendLayout()
        CType(Me.USER_PS02133DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USER_PS02133BindingSource
        '
        Me.USER_PS02133BindingSource.DataMember = "USER_PS02133"
        Me.USER_PS02133BindingSource.DataSource = Me.DataSet1
        '
        'USER_PS02133TableAdapter
        '
        Me.USER_PS02133TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHI_TIET_HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.HOA_DONTableAdapter = Nothing
        Me.TableAdapterManager.KHACH_HANGTableAdapter = Nothing
        Me.TableAdapterManager.LOAI_SAN_PHAMTableAdapter = Nothing
        Me.TableAdapterManager.SAN_PHAMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USER_PS02133TableAdapter = Me.USER_PS02133TableAdapter
        '
        'USER_PS02133BindingNavigator
        '
        Me.USER_PS02133BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.USER_PS02133BindingNavigator.BindingSource = Me.USER_PS02133BindingSource
        Me.USER_PS02133BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.USER_PS02133BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.USER_PS02133BindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.USER_PS02133BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.USER_PS02133BindingNavigatorSaveItem})
        Me.USER_PS02133BindingNavigator.Location = New System.Drawing.Point(9, 268)
        Me.USER_PS02133BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.USER_PS02133BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.USER_PS02133BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.USER_PS02133BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.USER_PS02133BindingNavigator.Name = "USER_PS02133BindingNavigator"
        Me.USER_PS02133BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.USER_PS02133BindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.USER_PS02133BindingNavigator.TabIndex = 0
        Me.USER_PS02133BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'USER_PS02133BindingNavigatorSaveItem
        '
        Me.USER_PS02133BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.USER_PS02133BindingNavigatorSaveItem.Image = CType(resources.GetObject("USER_PS02133BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.USER_PS02133BindingNavigatorSaveItem.Name = "USER_PS02133BindingNavigatorSaveItem"
        Me.USER_PS02133BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.USER_PS02133BindingNavigatorSaveItem.Text = "Save Data"
        '
        'USER_PS02133DataGridView
        '
        Me.USER_PS02133DataGridView.AutoGenerateColumns = False
        Me.USER_PS02133DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USER_PS02133DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.USER_PS02133DataGridView.DataSource = Me.USER_PS02133BindingSource
        Me.USER_PS02133DataGridView.Location = New System.Drawing.Point(12, 49)
        Me.USER_PS02133DataGridView.Name = "USER_PS02133DataGridView"
        Me.USER_PS02133DataGridView.Size = New System.Drawing.Size(293, 216)
        Me.USER_PS02133DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quản lý nhân viên"
        '
        'btnQuayve
        '
        Me.btnQuayve.Location = New System.Drawing.Point(111, 310)
        Me.btnQuayve.Name = "btnQuayve"
        Me.btnQuayve.Size = New System.Drawing.Size(95, 80)
        Me.btnQuayve.TabIndex = 3
        Me.btnQuayve.Text = "Quay về bàn làm việc"
        Me.btnQuayve.UseVisualStyleBackColor = True
        '
        'frmQLNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 420)
        Me.Controls.Add(Me.btnQuayve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USER_PS02133DataGridView)
        Me.Controls.Add(Me.USER_PS02133BindingNavigator)
        Me.Name = "frmQLNV"
        Me.Text = "QLNhanVien"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_PS02133BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_PS02133BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.USER_PS02133BindingNavigator.ResumeLayout(False)
        Me.USER_PS02133BindingNavigator.PerformLayout()
        CType(Me.USER_PS02133DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As QuanLyBanHang.DataSet1
    Friend WithEvents USER_PS02133BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USER_PS02133TableAdapter As QuanLyBanHang.DataSet1TableAdapters.USER_PS02133TableAdapter
    Friend WithEvents TableAdapterManager As QuanLyBanHang.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents USER_PS02133BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents USER_PS02133BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents USER_PS02133DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuayve As System.Windows.Forms.Button
End Class
