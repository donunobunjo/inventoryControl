<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAcctCodes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAcctCodes))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.AcctCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcctCodesTableAdapter = New inventoryControl.iGontrolTableAdapters.AcctCodesTableAdapter()
        Me.IdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcctCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdenDataGridViewTextBoxColumn, Me.AcctCodeDataGridViewTextBoxColumn, Me.AcctNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AcctCodesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(566, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcctCodesBindingSource
        '
        Me.AcctCodesBindingSource.DataMember = "AcctCodes"
        Me.AcctCodesBindingSource.DataSource = Me.IGontrol
        '
        'AcctCodesTableAdapter
        '
        Me.AcctCodesTableAdapter.ClearBeforeFill = True
        '
        'IdenDataGridViewTextBoxColumn
        '
        Me.IdenDataGridViewTextBoxColumn.DataPropertyName = "iden"
        Me.IdenDataGridViewTextBoxColumn.HeaderText = "iden"
        Me.IdenDataGridViewTextBoxColumn.Name = "IdenDataGridViewTextBoxColumn"
        Me.IdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdenDataGridViewTextBoxColumn.Visible = False
        '
        'AcctCodeDataGridViewTextBoxColumn
        '
        Me.AcctCodeDataGridViewTextBoxColumn.DataPropertyName = "AcctCode"
        Me.AcctCodeDataGridViewTextBoxColumn.HeaderText = "ACCOUNT CODE"
        Me.AcctCodeDataGridViewTextBoxColumn.Name = "AcctCodeDataGridViewTextBoxColumn"
        Me.AcctCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AcctCodeDataGridViewTextBoxColumn.Width = 200
        '
        'AcctNameDataGridViewTextBoxColumn
        '
        Me.AcctNameDataGridViewTextBoxColumn.DataPropertyName = "AcctName"
        Me.AcctNameDataGridViewTextBoxColumn.HeaderText = "ACCOUNT NAME"
        Me.AcctNameDataGridViewTextBoxColumn.Name = "AcctNameDataGridViewTextBoxColumn"
        Me.AcctNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.AcctNameDataGridViewTextBoxColumn.Width = 300
        '
        'ViewAcctCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 414)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewAcctCodes"
        Me.Text = "Account Code List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcctCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents AcctCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcctCodesTableAdapter As inventoryControl.iGontrolTableAdapters.AcctCodesTableAdapter
    Friend WithEvents IdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcctCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcctNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
