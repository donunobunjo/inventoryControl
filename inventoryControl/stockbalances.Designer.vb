<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockbalances
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockbalances))
        Me.ItemMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.iGontrol = New inventoryControl.iGontrol()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ItemMasterTableAdapter = New inventoryControl.iGontrolTableAdapters.ItemMasterTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.WareHouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseTableAdapter = New inventoryControl.iGontrolTableAdapters.WareHouseTableAdapter()
        Me.ItemMasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Check_BalanceTableAdapter = New inventoryControl.iGontrolTableAdapters.check_BalanceTableAdapter()
        CType(Me.ItemMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemMasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemMasterBindingSource
        '
        Me.ItemMasterBindingSource.DataMember = "ItemMaster"
        Me.ItemMasterBindingSource.DataSource = Me.iGontrol
        '
        'iGontrol
        '
        Me.iGontrol.DataSetName = "iGontrol"
        Me.iGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ItemMasterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "inventoryControl.StockBalances.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 403)
        Me.ReportViewer1.TabIndex = 0
        '
        'ItemMasterTableAdapter
        '
        Me.ItemMasterTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.WareHouseBindingSource
        Me.ComboBox1.DisplayMember = "WareHouse"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(487, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(231, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'WareHouseBindingSource
        '
        Me.WareHouseBindingSource.DataMember = "WareHouse"
        Me.WareHouseBindingSource.DataSource = Me.iGontrol
        '
        'WareHouseTableAdapter
        '
        Me.WareHouseTableAdapter.ClearBeforeFill = True
        '
        'ItemMasterBindingSource1
        '
        Me.ItemMasterBindingSource1.DataMember = "ItemMaster"
        Me.ItemMasterBindingSource1.DataSource = Me.iGontrol
        '
        'CheckBalanceBindingSource
        '
        Me.CheckBalanceBindingSource.DataMember = "check Balance"
        Me.CheckBalanceBindingSource.DataSource = Me.iGontrol
        '
        'Check_BalanceTableAdapter
        '
        Me.Check_BalanceTableAdapter.ClearBeforeFill = True
        '
        'stockbalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 480)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stockbalances"
        Me.Text = "Stock Balances"
        CType(Me.ItemMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemMasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ItemMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents iGontrol As inventoryControl.iGontrol
    Friend WithEvents ItemMasterTableAdapter As inventoryControl.iGontrolTableAdapters.ItemMasterTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents WareHouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseTableAdapter As inventoryControl.iGontrolTableAdapters.WareHouseTableAdapter
    Friend WithEvents ItemMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Check_BalanceTableAdapter As inventoryControl.iGontrolTableAdapters.check_BalanceTableAdapter
End Class
