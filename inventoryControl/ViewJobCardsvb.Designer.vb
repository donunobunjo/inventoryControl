﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewJobCardsvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewJobCardsvb))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.JobCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobCardTableAdapter = New inventoryControl.iGontrolTableAdapters.JobCardTableAdapter()
        Me.IdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobCardNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobCardDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdenDataGridViewTextBoxColumn, Me.JobCardNumberDataGridViewTextBoxColumn, Me.JobCardDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JobCardBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(528, 405)
        Me.DataGridView1.TabIndex = 0
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobCardBindingSource
        '
        Me.JobCardBindingSource.DataMember = "JobCard"
        Me.JobCardBindingSource.DataSource = Me.IGontrol
        '
        'JobCardTableAdapter
        '
        Me.JobCardTableAdapter.ClearBeforeFill = True
        '
        'IdenDataGridViewTextBoxColumn
        '
        Me.IdenDataGridViewTextBoxColumn.DataPropertyName = "iden"
        Me.IdenDataGridViewTextBoxColumn.HeaderText = "iden"
        Me.IdenDataGridViewTextBoxColumn.Name = "IdenDataGridViewTextBoxColumn"
        Me.IdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdenDataGridViewTextBoxColumn.Visible = False
        '
        'JobCardNumberDataGridViewTextBoxColumn
        '
        Me.JobCardNumberDataGridViewTextBoxColumn.DataPropertyName = "JobCardNumber"
        Me.JobCardNumberDataGridViewTextBoxColumn.HeaderText = "JOB CARD NUMBER"
        Me.JobCardNumberDataGridViewTextBoxColumn.Name = "JobCardNumberDataGridViewTextBoxColumn"
        Me.JobCardNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.JobCardNumberDataGridViewTextBoxColumn.Width = 150
        '
        'JobCardDescriptionDataGridViewTextBoxColumn
        '
        Me.JobCardDescriptionDataGridViewTextBoxColumn.DataPropertyName = "JobCardDescription"
        Me.JobCardDescriptionDataGridViewTextBoxColumn.HeaderText = "JOB CARD DESCRIPTION"
        Me.JobCardDescriptionDataGridViewTextBoxColumn.Name = "JobCardDescriptionDataGridViewTextBoxColumn"
        Me.JobCardDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.JobCardDescriptionDataGridViewTextBoxColumn.Width = 300
        '
        'ViewJobCardsvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 405)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewJobCardsvb"
        Me.Text = "View Job Cards"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents JobCardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobCardTableAdapter As inventoryControl.iGontrolTableAdapters.JobCardTableAdapter
    Friend WithEvents IdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCardNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCardDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
