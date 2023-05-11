<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MarksDataSet1 = New WindowsApplication1.marksDataSet1()
        Me.MarksDataSet = New WindowsApplication1.marksDataSet()
        Me.MarksTableAdapter = New WindowsApplication1.marksDataSetTableAdapters.marksTableAdapter()
        Me.MarksTableAdapter1 = New WindowsApplication1.marksDataSet1TableAdapters.marksTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GadmarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JprmarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenmarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarksDataSet4 = New WindowsApplication1.marksDataSet4()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MarksTableAdapter2 = New WindowsApplication1.marksDataSet3TableAdapters.marksTableAdapter()
        Me.MarksTableAdapter3 = New WindowsApplication1.marksDataSet4TableAdapters.marksTableAdapter()
        CType(Me.MarksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(377, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MarksDataSet1
        '
        Me.MarksDataSet1.DataSetName = "marksDataSet1"
        Me.MarksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarksDataSet
        '
        Me.MarksDataSet.DataSetName = "marksDataSet"
        Me.MarksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarksTableAdapter
        '
        Me.MarksTableAdapter.ClearBeforeFill = True
        '
        'MarksTableAdapter1
        '
        Me.MarksTableAdapter1.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(844, 380)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(836, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Disp_marks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(490, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(360, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.GadmarksDataGridViewTextBoxColumn, Me.JprmarksDataGridViewTextBoxColumn, Me.SenmarksDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PercentageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(70, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(699, 233)
        Me.DataGridView1.TabIndex = 2
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'GadmarksDataGridViewTextBoxColumn
        '
        Me.GadmarksDataGridViewTextBoxColumn.DataPropertyName = "gad_marks"
        Me.GadmarksDataGridViewTextBoxColumn.HeaderText = "gad_marks"
        Me.GadmarksDataGridViewTextBoxColumn.Name = "GadmarksDataGridViewTextBoxColumn"
        '
        'JprmarksDataGridViewTextBoxColumn
        '
        Me.JprmarksDataGridViewTextBoxColumn.DataPropertyName = "jpr_marks"
        Me.JprmarksDataGridViewTextBoxColumn.HeaderText = "jpr_marks"
        Me.JprmarksDataGridViewTextBoxColumn.Name = "JprmarksDataGridViewTextBoxColumn"
        '
        'SenmarksDataGridViewTextBoxColumn
        '
        Me.SenmarksDataGridViewTextBoxColumn.DataPropertyName = "sen_marks"
        Me.SenmarksDataGridViewTextBoxColumn.HeaderText = "sen_marks"
        Me.SenmarksDataGridViewTextBoxColumn.Name = "SenmarksDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'PercentageDataGridViewTextBoxColumn
        '
        Me.PercentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.HeaderText = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.Name = "PercentageDataGridViewTextBoxColumn"
        '
        'MarksBindingSource
        '
        Me.MarksBindingSource.DataMember = "marks"
        Me.MarksBindingSource.DataSource = Me.MarksDataSet4
        '
        'MarksDataSet4
        '
        Me.MarksDataSet4.DataSetName = "marksDataSet4"
        Me.MarksDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(836, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit_marks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(425, 295)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(352, 253)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(246, 22)
        Me.TextBox3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(143, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Enter SEN Marks"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(352, 199)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 22)
        Me.TextBox2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(143, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter JPR Marks"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(143, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter GAD Marks"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(396, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(304, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(142, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Roll No"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(836, 351)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add_marks"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(463, 245)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 33)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(360, 190)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(318, 22)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(360, 142)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(318, 22)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(360, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(318, 22)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(360, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(318, 22)
        Me.TextBox4.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label9.Location = New System.Drawing.Point(123, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Enter JPR marks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label8.Location = New System.Drawing.Point(123, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Enter SEN Marks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(123, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Enter Gad Marks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(123, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enter Roll No"
        '
        'MarksTableAdapter2
        '
        Me.MarksTableAdapter2.ClearBeforeFill = True
        '
        'MarksTableAdapter3
        '
        Me.MarksTableAdapter3.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.ClientSize = New System.Drawing.Size(869, 493)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form9"
        Me.Text = "Marks"
        CType(Me.MarksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MarksDataSet As WindowsApplication1.marksDataSet
    Friend WithEvents MarksTableAdapter As WindowsApplication1.marksDataSetTableAdapters.marksTableAdapter
    Friend WithEvents MarksDataSet1 As WindowsApplication1.marksDataSet1
    Friend WithEvents MarksTableAdapter1 As WindowsApplication1.marksDataSet1TableAdapters.marksTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MarksTableAdapter2 As WindowsApplication1.marksDataSet3TableAdapters.marksTableAdapter
    Friend WithEvents MarksDataSet4 As WindowsApplication1.marksDataSet4
    Friend WithEvents MarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarksTableAdapter3 As WindowsApplication1.marksDataSet4TableAdapters.marksTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GadmarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JprmarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenmarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
