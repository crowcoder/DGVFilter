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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colName, Me.colValue})
        Me.DataGridView1.Location = New System.Drawing.Point(33, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(198, 203)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(183, 20)
        Me.txtFilter.TabIndex = 1
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(398, 201)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "Button1"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'colCheck
        '
        Me.colCheck.DataPropertyName = "Selected"
        Me.colCheck.HeaderText = "Selected"
        Me.colCheck.Name = "colCheck"
        '
        'colName
        '
        Me.colName.DataPropertyName = "Name"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colValue
        '
        Me.colValue.DataPropertyName = "Value"
        Me.colValue.HeaderText = "Value"
        Me.colValue.Name = "colValue"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 261)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents colCheck As DataGridViewCheckBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colValue As DataGridViewTextBoxColumn
End Class
