﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administratorUserMenu
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
        Me.Logins = New TImeClock2.Logins()
        Me.TimesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimesTableAdapter = New TImeClock2.LoginsTableAdapters.TimesTableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClockedINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClockedOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ClockedINDataGridViewTextBoxColumn, Me.ClockedOutDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TimesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'Logins
        '
        Me.Logins.DataSetName = "Logins"
        Me.Logins.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimesBindingSource
        '
        Me.TimesBindingSource.DataMember = "Times"
        Me.TimesBindingSource.DataSource = Me.Logins
        '
        'TimesTableAdapter
        '
        Me.TimesTableAdapter.ClearBeforeFill = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClockedINDataGridViewTextBoxColumn
        '
        Me.ClockedINDataGridViewTextBoxColumn.DataPropertyName = "Clocked IN"
        Me.ClockedINDataGridViewTextBoxColumn.HeaderText = "Clocked IN"
        Me.ClockedINDataGridViewTextBoxColumn.Name = "ClockedINDataGridViewTextBoxColumn"
        Me.ClockedINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClockedOutDataGridViewTextBoxColumn
        '
        Me.ClockedOutDataGridViewTextBoxColumn.DataPropertyName = "Clocked Out"
        Me.ClockedOutDataGridViewTextBoxColumn.HeaderText = "Clocked Out"
        Me.ClockedOutDataGridViewTextBoxColumn.Name = "ClockedOutDataGridViewTextBoxColumn"
        Me.ClockedOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'administratorUserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 277)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "administratorUserMenu"
        Me.Text = "administratorUserMenu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Logins As Logins
    Friend WithEvents TimesBindingSource As BindingSource
    Friend WithEvents TimesTableAdapter As LoginsTableAdapters.TimesTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClockedINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClockedOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
