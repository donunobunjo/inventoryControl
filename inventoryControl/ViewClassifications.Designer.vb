<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewClassifications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewClassifications))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.ClassificationTableAdapter = New inventoryControl.iGontrolTableAdapters.ClassificationTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdenDataGridViewTextBoxColumn, Me.ClassificationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassificationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(446, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'IdenDataGridViewTextBoxColumn
        '
        Me.IdenDataGridViewTextBoxColumn.DataPropertyName = "iden"
        Me.IdenDataGridViewTextBoxColumn.HeaderText = "iden"
        Me.IdenDataGridViewTextBoxColumn.Name = "IdenDataGridViewTextBoxColumn"
        Me.IdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdenDataGridViewTextBoxColumn.Visible = False
        '
        'ClassificationDataGridViewTextBoxColumn
        '
        Me.ClassificationDataGridViewTextBoxColumn.DataPropertyName = "classification"
        Me.ClassificationDataGridViewTextBoxColumn.HeaderText = "CLASSIFICATIONS"
        Me.ClassificationDataGridViewTextBoxColumn.Name = "ClassificationDataGridViewTextBoxColumn"
        Me.ClassificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClassificationDataGridViewTextBoxColumn.Width = 300
        '
        'ClassificationBindingSource
        '
        Me.ClassificationBindingSource.DataMember = "Classification"
        Me.ClassificationBindingSource.DataSource = Me.IGontrol
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassificationTableAdapter
        '
        Me.ClassificationTableAdapter.ClearBeforeFill = True
        '
        'ViewClassifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 340)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewClassifications"
        Me.Text = "View Classifications"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents ClassificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassificationTableAdapter As inventoryControl.iGontrolTableAdapters.ClassificationTableAdapter
    Friend WithEvents IdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
