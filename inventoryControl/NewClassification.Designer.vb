<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClassification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewClassification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IGontrol = New inventoryControl.iGontrol()
        Me.ClassificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassificationTableAdapter = New inventoryControl.iGontrolTableAdapters.ClassificationTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Classification"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(112, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(383, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 93)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Image = Global.inventoryControl.My.Resources.Resources.close
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(351, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.inventoryControl.My.Resources.Resources.SaveandAdd
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(22, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save && Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.inventoryControl.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(187, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save && Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IGontrol
        '
        Me.IGontrol.DataSetName = "iGontrol"
        Me.IGontrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassificationBindingSource
        '
        Me.ClassificationBindingSource.DataMember = "Classification"
        Me.ClassificationBindingSource.DataSource = Me.IGontrol
        '
        'ClassificationTableAdapter
        '
        Me.ClassificationTableAdapter.ClearBeforeFill = True
        '
        'NewClassification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewClassification"
        Me.Text = "New Classification"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.IGontrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IGontrol As inventoryControl.iGontrol
    Friend WithEvents ClassificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassificationTableAdapter As inventoryControl.iGontrolTableAdapters.ClassificationTableAdapter
End Class
