<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApproveRequisitionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApproveRequisitionDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequistionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityApprovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RejectedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PartialDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequisitionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RequisitionsTableAdapter = New inventoryControl.iGontrolTableAdapters.RequisitionsTableAdapter()
        Me.ApprovedRequisitionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprovedRequisitionsTableAdapter = New inventoryControl.iGontrolTableAdapters.ApprovedRequisitionsTableAdapter()
        Me.RequisitionSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionSummaryTableAdapter = New inventoryControl.iGontrolTableAdapters.RequisitionSummaryTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ApprvForIssueUpdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprvForIssueUpdateTableAdapter = New inventoryControl.iGontrolTableAdapters.ApprvForIssueUpdateTableAdapter()
        Me.CheckApprovedQtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckApprovedQtyTableAdapter = New inventoryControl.iGontrolTableAdapters.checkApprovedQtyTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ApprovedRequisitionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprvForIssueUpdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckApprovedQtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Requisition Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Approval Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(479, 9)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(246, 20)
        Me.TextBox2.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(132, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdenDataGridViewTextBoxColumn, Me.RequistionNumberDataGridViewTextBoxColumn, Me.ClassificationDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.ItemNumberDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.PartNumberDataGridViewTextBoxColumn, Me.DORDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.OriginatorDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.QuantityApprovedDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.ExpDateDataGridViewTextBoxColumn, Me.ApprovedDataGridViewCheckBoxColumn, Me.RejectedDataGridViewCheckBoxColumn, Me.PartialDataGridViewCheckBoxColumn, Me.location})
        Me.DataGridView1.DataSource = Me.RequisitionsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1143, 333)
        Me.DataGridView1.TabIndex = 6
        '
        'IdenDataGridViewTextBoxColumn
        '
        Me.IdenDataGridViewTextBoxColumn.DataPropertyName = "iden"
        Me.IdenDataGridViewTextBoxColumn.HeaderText = "iden"
        Me.IdenDataGridViewTextBoxColumn.Name = "IdenDataGridViewTextBoxColumn"
        Me.IdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdenDataGridViewTextBoxColumn.Visible = False
        '
        'RequistionNumberDataGridViewTextBoxColumn
        '
        Me.RequistionNumberDataGridViewTextBoxColumn.DataPropertyName = "RequistionNumber"
        Me.RequistionNumberDataGridViewTextBoxColumn.HeaderText = "REQ. NUM."
        Me.RequistionNumberDataGridViewTextBoxColumn.Name = "RequistionNumberDataGridViewTextBoxColumn"
        Me.RequistionNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassificationDataGridViewTextBoxColumn
        '
        Me.ClassificationDataGridViewTextBoxColumn.DataPropertyName = "Classification"
        Me.ClassificationDataGridViewTextBoxColumn.HeaderText = "CLASSIFICATN"
        Me.ClassificationDataGridViewTextBoxColumn.Name = "ClassificationDataGridViewTextBoxColumn"
        Me.ClassificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClassificationDataGridViewTextBoxColumn.Width = 150
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "BRAND"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandDataGridViewTextBoxColumn.Width = 150
        '
        'ItemNumberDataGridViewTextBoxColumn
        '
        Me.ItemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber"
        Me.ItemNumberDataGridViewTextBoxColumn.HeaderText = "ITEM NUM"
        Me.ItemNumberDataGridViewTextBoxColumn.Name = "ItemNumberDataGridViewTextBoxColumn"
        Me.ItemNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ITEM NAME"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemNameDataGridViewTextBoxColumn.Width = 150
        '
        'PartNumberDataGridViewTextBoxColumn
        '
        Me.PartNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber"
        Me.PartNumberDataGridViewTextBoxColumn.HeaderText = "PartNumber"
        Me.PartNumberDataGridViewTextBoxColumn.Name = "PartNumberDataGridViewTextBoxColumn"
        Me.PartNumberDataGridViewTextBoxColumn.Visible = False
        '
        'DORDataGridViewTextBoxColumn
        '
        Me.DORDataGridViewTextBoxColumn.DataPropertyName = "DOR"
        Me.DORDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DORDataGridViewTextBoxColumn.Name = "DORDataGridViewTextBoxColumn"
        Me.DORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentDataGridViewTextBoxColumn.Width = 150
        '
        'OriginatorDataGridViewTextBoxColumn
        '
        Me.OriginatorDataGridViewTextBoxColumn.DataPropertyName = "Originator"
        Me.OriginatorDataGridViewTextBoxColumn.HeaderText = "Originator"
        Me.OriginatorDataGridViewTextBoxColumn.Name = "OriginatorDataGridViewTextBoxColumn"
        Me.OriginatorDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "QTY REQUESTED"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityApprovedDataGridViewTextBoxColumn
        '
        Me.QuantityApprovedDataGridViewTextBoxColumn.DataPropertyName = "QuantityApproved"
        Me.QuantityApprovedDataGridViewTextBoxColumn.HeaderText = "QTY APPROVED"
        Me.QuantityApprovedDataGridViewTextBoxColumn.Name = "QuantityApprovedDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.Visible = False
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Visible = False
        '
        'ExpDateDataGridViewTextBoxColumn
        '
        Me.ExpDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate"
        Me.ExpDateDataGridViewTextBoxColumn.HeaderText = "ExpDate"
        Me.ExpDateDataGridViewTextBoxColumn.Name = "ExpDateDataGridViewTextBoxColumn"
        Me.ExpDateDataGridViewTextBoxColumn.Visible = False
        '
        'ApprovedDataGridViewCheckBoxColumn
        '
        Me.ApprovedDataGridViewCheckBoxColumn.DataPropertyName = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.HeaderText = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.Name = "ApprovedDataGridViewCheckBoxColumn"
        Me.ApprovedDataGridViewCheckBoxColumn.Visible = False
        '
        'RejectedDataGridViewCheckBoxColumn
        '
        Me.RejectedDataGridViewCheckBoxColumn.DataPropertyName = "rejected"
        Me.RejectedDataGridViewCheckBoxColumn.HeaderText = "rejected"
        Me.RejectedDataGridViewCheckBoxColumn.Name = "RejectedDataGridViewCheckBoxColumn"
        Me.RejectedDataGridViewCheckBoxColumn.Visible = False
        '
        'PartialDataGridViewCheckBoxColumn
        '
        Me.PartialDataGridViewCheckBoxColumn.DataPropertyName = "Partial"
        Me.PartialDataGridViewCheckBoxColumn.HeaderText = "Partial"
        Me.PartialDataGridViewCheckBoxColumn.Name = "PartialDataGridViewCheckBoxColumn"
        Me.PartialDataGridViewCheckBoxColumn.Visible = False
        '
        'location
        '
        Me.location.DataPropertyName = "location"
        Me.location.HeaderText = "location"
        Me.location.Name = "location"
        '
        'RequisitionsBindingSource
        '
        Me.RequisitionsBindingSource.DataMember = "Requisitions"
        Me.RequisitionsBindingSource.DataSource = Me.IGontrol
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 428)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 78)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.inventoryControl.My.Resources.Resources.close
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(378, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.inventoryControl.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(81, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Treat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RequisitionsTableAdapter
        '
        Me.RequisitionsTableAdapter.ClearBeforeFill = True
        '
        'ApprovedRequisitionsBindingSource
        '
        Me.ApprovedRequisitionsBindingSource.DataMember = "ApprovedRequisitions"
        Me.ApprovedRequisitionsBindingSource.DataSource = Me.IGontrol
        '
        'ApprovedRequisitionsTableAdapter
        '
        Me.ApprovedRequisitionsTableAdapter.ClearBeforeFill = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Location"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(479, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(214, 20)
        Me.TextBox3.TabIndex = 9
        '
        'ApprvForIssueUpdateBindingSource
        '
        Me.ApprvForIssueUpdateBindingSource.DataMember = "ApprvForIssueUpdate"
        Me.ApprvForIssueUpdateBindingSource.DataSource = Me.IGontrol
        '
        'ApprvForIssueUpdateTableAdapter
        '
        Me.ApprvForIssueUpdateTableAdapter.ClearBeforeFill = True
        '
        'CheckApprovedQtyBindingSource
        '
        Me.CheckApprovedQtyBindingSource.DataMember = "checkApprovedQty"
        Me.CheckApprovedQtyBindingSource.DataSource = Me.IGontrol
        '
        'CheckApprovedQtyTableAdapter
        '
        Me.CheckApprovedQtyTableAdapter.ClearBeforeFill = True
        '
        'ApproveRequisitionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 518)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApproveRequisitionDetails"
        Me.Text = "Approve Requisition Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ApprovedRequisitionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprvForIssueUpdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckApprovedQtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents RequisitionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionsTableAdapter As inventoryControl.iGontrolTableAdapters.RequisitionsTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ApprovedRequisitionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApprovedRequisitionsTableAdapter As inventoryControl.iGontrolTableAdapters.ApprovedRequisitionsTableAdapter
    Friend WithEvents RequisitionSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionSummaryTableAdapter As inventoryControl.iGontrolTableAdapters.RequisitionSummaryTableAdapter
    Friend WithEvents IdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequistionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OriginatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityApprovedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RejectedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PartialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ApprvForIssueUpdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApprvForIssueUpdateTableAdapter As inventoryControl.iGontrolTableAdapters.ApprvForIssueUpdateTableAdapter
    Friend WithEvents CheckApprovedQtyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckApprovedQtyTableAdapter As inventoryControl.iGontrolTableAdapters.checkApprovedQtyTableAdapter
End Class
