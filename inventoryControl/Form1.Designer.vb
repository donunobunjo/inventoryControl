<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.RequisitionSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionSummaryTableAdapter = New inventoryControl.iGontrolTableAdapters.RequisitionSummaryTableAdapter()
        Me.RequisitionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RejectedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PartialDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequisitionNumberDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DORDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ApprovedDataGridViewCheckBoxColumn, Me.RejectedDataGridViewCheckBoxColumn, Me.PartialDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.RequisitionSummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionSummaryBindingSource
        '
        Me.RequisitionSummaryBindingSource.DataMember = "RequisitionSummary"
        Me.RequisitionSummaryBindingSource.DataSource = Me.IGontrol
        '
        'RequisitionSummaryTableAdapter
        '
        Me.RequisitionSummaryTableAdapter.ClearBeforeFill = True
        '
        'RequisitionNumberDataGridViewTextBoxColumn
        '
        Me.RequisitionNumberDataGridViewTextBoxColumn.DataPropertyName = "RequisitionNumber"
        Me.RequisitionNumberDataGridViewTextBoxColumn.HeaderText = "RequisitionNumber"
        Me.RequisitionNumberDataGridViewTextBoxColumn.Name = "RequisitionNumberDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DORDataGridViewTextBoxColumn
        '
        Me.DORDataGridViewTextBoxColumn.DataPropertyName = "DOR"
        Me.DORDataGridViewTextBoxColumn.HeaderText = "DOR"
        Me.DORDataGridViewTextBoxColumn.Name = "DORDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ApprovedDataGridViewCheckBoxColumn
        '
        Me.ApprovedDataGridViewCheckBoxColumn.DataPropertyName = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.HeaderText = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.Name = "ApprovedDataGridViewCheckBoxColumn"
        '
        'RejectedDataGridViewCheckBoxColumn
        '
        Me.RejectedDataGridViewCheckBoxColumn.DataPropertyName = "Rejected"
        Me.RejectedDataGridViewCheckBoxColumn.HeaderText = "Rejected"
        Me.RejectedDataGridViewCheckBoxColumn.Name = "RejectedDataGridViewCheckBoxColumn"
        '
        'PartialDataGridViewCheckBoxColumn
        '
        Me.PartialDataGridViewCheckBoxColumn.DataPropertyName = "Partial"
        Me.PartialDataGridViewCheckBoxColumn.HeaderText = "Partial"
        Me.PartialDataGridViewCheckBoxColumn.Name = "PartialDataGridViewCheckBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents RequisitionSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionSummaryTableAdapter As inventoryControl.iGontrolTableAdapters.RequisitionSummaryTableAdapter
    Friend WithEvents RequisitionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RejectedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PartialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
