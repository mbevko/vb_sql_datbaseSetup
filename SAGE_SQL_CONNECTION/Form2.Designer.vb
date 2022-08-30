<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Server_NameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SAMINCDataSet = New SAGE_SQL_CONNECTION.SAMINCDataSet()
        Me.SAMINCDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MFGCOMDataSet = New SAGE_SQL_CONNECTION.MFGCOMDataSet()
        Me.SERVER_NAMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERVER_NAMETableAdapter = New SAGE_SQL_CONNECTION.MFGCOMDataSetTableAdapters.SERVER_NAMETableAdapter()
        Me.TableAdapterManager = New SAGE_SQL_CONNECTION.MFGCOMDataSetTableAdapters.TableAdapterManager()
        Me.Server_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.MFGCOMDataSet1 = New SAGE_SQL_CONNECTION.MFGCOMDataSet1()
        Me.DATABASE_NAMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATABASE_NAMESTableAdapter = New SAGE_SQL_CONNECTION.MFGCOMDataSet1TableAdapters.DATABASE_NAMESTableAdapter()
        Me.TableAdapterManager1 = New SAGE_SQL_CONNECTION.MFGCOMDataSet1TableAdapters.TableAdapterManager()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Server_NameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.SAMINCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAMINCDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVER_NAMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATABASE_NAMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Server_NameLabel
        '
        Server_NameLabel.AutoSize = True
        Server_NameLabel.Location = New System.Drawing.Point(12, 47)
        Server_NameLabel.Name = "Server_NameLabel"
        Server_NameLabel.Size = New System.Drawing.Size(72, 13)
        Server_NameLabel.TabIndex = 4
        Server_NameLabel.Text = "Server Name:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 85)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(56, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Database:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Load Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SAMINCDataSet
        '
        Me.SAMINCDataSet.DataSetName = "SAMINCDataSet"
        Me.SAMINCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SAMINCDataSetBindingSource
        '
        Me.SAMINCDataSetBindingSource.DataSource = Me.SAMINCDataSet
        Me.SAMINCDataSetBindingSource.Position = 0
        '
        'MFGCOMDataSet
        '
        Me.MFGCOMDataSet.DataSetName = "MFGCOMDataSet"
        Me.MFGCOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SERVER_NAMEBindingSource
        '
        Me.SERVER_NAMEBindingSource.DataMember = "SERVER_NAME"
        Me.SERVER_NAMEBindingSource.DataSource = Me.MFGCOMDataSet
        '
        'SERVER_NAMETableAdapter
        '
        Me.SERVER_NAMETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SAGE_SQL_CONNECTION.MFGCOMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Server_NameComboBox
        '
        Me.Server_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SERVER_NAMEBindingSource, "Server Name", True))
        Me.Server_NameComboBox.FormattingEnabled = True
        Me.Server_NameComboBox.Location = New System.Drawing.Point(107, 44)
        Me.Server_NameComboBox.Name = "Server_NameComboBox"
        Me.Server_NameComboBox.Size = New System.Drawing.Size(222, 21)
        Me.Server_NameComboBox.TabIndex = 5
        '
        'MFGCOMDataSet1
        '
        Me.MFGCOMDataSet1.DataSetName = "MFGCOMDataSet1"
        Me.MFGCOMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATABASE_NAMESBindingSource
        '
        Me.DATABASE_NAMESBindingSource.DataMember = "DATABASE_NAMES"
        Me.DATABASE_NAMESBindingSource.DataSource = Me.MFGCOMDataSet1
        '
        'DATABASE_NAMESTableAdapter
        '
        Me.DATABASE_NAMESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = SAGE_SQL_CONNECTION.MFGCOMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATABASE_NAMESBindingSource, "name", True))
        Me.NameComboBox.DataSource = Me.DATABASE_NAMESBindingSource
        Me.NameComboBox.DisplayMember = "name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(107, 85)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(222, 21)
        Me.NameComboBox.TabIndex = 6
        Me.NameComboBox.ValueMember = "name"
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(374, 174)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Server_NameLabel)
        Me.Controls.Add(Me.Server_NameComboBox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setup"
        CType(Me.SAMINCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAMINCDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVER_NAMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATABASE_NAMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents SAMINCDataSetBindingSource As BindingSource
    Friend WithEvents SAMINCDataSet As SAMINCDataSet
    Friend WithEvents MFGCOMDataSet As MFGCOMDataSet
    Friend WithEvents SERVER_NAMEBindingSource As BindingSource
    Friend WithEvents SERVER_NAMETableAdapter As MFGCOMDataSetTableAdapters.SERVER_NAMETableAdapter
    Friend WithEvents TableAdapterManager As MFGCOMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Server_NameComboBox As ComboBox
    Friend WithEvents MFGCOMDataSet1 As MFGCOMDataSet1
    Friend WithEvents DATABASE_NAMESBindingSource As BindingSource
    Friend WithEvents DATABASE_NAMESTableAdapter As MFGCOMDataSet1TableAdapters.DATABASE_NAMESTableAdapter
    Friend WithEvents TableAdapterManager1 As MFGCOMDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents NameComboBox As ComboBox
End Class
