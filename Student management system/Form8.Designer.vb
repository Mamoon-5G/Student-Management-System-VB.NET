<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AttendenceTableAdapter3 = New WindowsApplication1.loginDataSet6TableAdapters.AttendenceTableAdapter()
        Me.AttendenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarksDataSet2 = New WindowsApplication1.marksDataSet2()
        Me.AttendenceTableAdapter = New WindowsApplication1.marksDataSet2TableAdapters.AttendenceTableAdapter()
        Me.AverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttSENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttJPRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttGADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AverageDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttSENDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttJPRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttGADDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.AverageDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttSENDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttJPRDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttGADDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollnoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(348, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AttendenceTableAdapter3
        '
        Me.AttendenceTableAdapter3.ClearBeforeFill = True
        '
        'AttendenceBindingSource
        '
        Me.AttendenceBindingSource.DataMember = "Attendence"
        Me.AttendenceBindingSource.DataSource = Me.MarksDataSet2
        '
        'MarksDataSet2
        '
        Me.MarksDataSet2.DataSetName = "marksDataSet2"
        Me.MarksDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendenceTableAdapter
        '
        Me.AttendenceTableAdapter.ClearBeforeFill = True
        '
        'AverageDataGridViewTextBoxColumn
        '
        Me.AverageDataGridViewTextBoxColumn.DataPropertyName = "Average"
        Me.AverageDataGridViewTextBoxColumn.HeaderText = "Average"
        Me.AverageDataGridViewTextBoxColumn.Name = "AverageDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'AttSENDataGridViewTextBoxColumn
        '
        Me.AttSENDataGridViewTextBoxColumn.DataPropertyName = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn.HeaderText = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn.Name = "AttSENDataGridViewTextBoxColumn"
        '
        'AttJPRDataGridViewTextBoxColumn
        '
        Me.AttJPRDataGridViewTextBoxColumn.DataPropertyName = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn.HeaderText = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn.Name = "AttJPRDataGridViewTextBoxColumn"
        '
        'AttGADDataGridViewTextBoxColumn
        '
        Me.AttGADDataGridViewTextBoxColumn.DataPropertyName = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn.HeaderText = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn.Name = "AttGADDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.TextBox8)
        Me.TabPage4.Controls.Add(Me.TextBox7)
        Me.TabPage4.Controls.Add(Me.TextBox6)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(782, 486)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add_Att"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(140, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Enter Roll No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(140, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Enter Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label8.Location = New System.Drawing.Point(140, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Enter GAD Attendence"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label9.Location = New System.Drawing.Point(140, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Enter JPR Attendence"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label10.Location = New System.Drawing.Point(140, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Enter SEN Attendence"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(356, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(264, 22)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(356, 119)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(264, 22)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(356, 161)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(264, 22)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 212)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(264, 22)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(356, 260)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(264, 22)
        Me.TextBox8.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(450, 305)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 24)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(782, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit_Att"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(119, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Roll No"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(268, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(368, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(89, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter GAD Attendance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(89, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter JPR Attendance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(89, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Enter SEN Attendance"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(316, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(316, 238)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(316, 291)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(246, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(377, 331)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 515)
        Me.TabControl1.TabIndex = 1
        '
        'AverageDataGridViewTextBoxColumn1
        '
        Me.AverageDataGridViewTextBoxColumn1.DataPropertyName = "Average"
        Me.AverageDataGridViewTextBoxColumn1.HeaderText = "Average"
        Me.AverageDataGridViewTextBoxColumn1.Name = "AverageDataGridViewTextBoxColumn1"
        '
        'TotalDataGridViewTextBoxColumn1
        '
        Me.TotalDataGridViewTextBoxColumn1.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn1.Name = "TotalDataGridViewTextBoxColumn1"
        '
        'AttSENDataGridViewTextBoxColumn1
        '
        Me.AttSENDataGridViewTextBoxColumn1.DataPropertyName = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn1.HeaderText = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn1.Name = "AttSENDataGridViewTextBoxColumn1"
        '
        'AttJPRDataGridViewTextBoxColumn1
        '
        Me.AttJPRDataGridViewTextBoxColumn1.DataPropertyName = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn1.HeaderText = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn1.Name = "AttJPRDataGridViewTextBoxColumn1"
        '
        'AttGADDataGridViewTextBoxColumn1
        '
        Me.AttGADDataGridViewTextBoxColumn1.DataPropertyName = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn1.HeaderText = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn1.Name = "AttGADDataGridViewTextBoxColumn1"
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'RollnoDataGridViewTextBoxColumn1
        '
        Me.RollnoDataGridViewTextBoxColumn1.DataPropertyName = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn1.HeaderText = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn1.Name = "RollnoDataGridViewTextBoxColumn1"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(782, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Display_Att"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(468, 359)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 34)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Add"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'AverageDataGridViewTextBoxColumn2
        '
        Me.AverageDataGridViewTextBoxColumn2.DataPropertyName = "Average"
        Me.AverageDataGridViewTextBoxColumn2.HeaderText = "Average"
        Me.AverageDataGridViewTextBoxColumn2.Name = "AverageDataGridViewTextBoxColumn2"
        '
        'TotalDataGridViewTextBoxColumn2
        '
        Me.TotalDataGridViewTextBoxColumn2.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn2.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn2.Name = "TotalDataGridViewTextBoxColumn2"
        '
        'AttSENDataGridViewTextBoxColumn2
        '
        Me.AttSENDataGridViewTextBoxColumn2.DataPropertyName = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn2.HeaderText = "Att_SEN"
        Me.AttSENDataGridViewTextBoxColumn2.Name = "AttSENDataGridViewTextBoxColumn2"
        '
        'AttJPRDataGridViewTextBoxColumn2
        '
        Me.AttJPRDataGridViewTextBoxColumn2.DataPropertyName = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn2.HeaderText = "Att_JPR"
        Me.AttJPRDataGridViewTextBoxColumn2.Name = "AttJPRDataGridViewTextBoxColumn2"
        '
        'AttGADDataGridViewTextBoxColumn2
        '
        Me.AttGADDataGridViewTextBoxColumn2.DataPropertyName = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn2.HeaderText = "Att_GAD"
        Me.AttGADDataGridViewTextBoxColumn2.Name = "AttGADDataGridViewTextBoxColumn2"
        '
        'NameDataGridViewTextBoxColumn2
        '
        Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
        '
        'RollnoDataGridViewTextBoxColumn2
        '
        Me.RollnoDataGridViewTextBoxColumn2.DataPropertyName = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn2.HeaderText = "Roll_no"
        Me.RollnoDataGridViewTextBoxColumn2.Name = "RollnoDataGridViewTextBoxColumn2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn2, Me.NameDataGridViewTextBoxColumn2, Me.AttGADDataGridViewTextBoxColumn2, Me.AttJPRDataGridViewTextBoxColumn2, Me.AttSENDataGridViewTextBoxColumn2, Me.TotalDataGridViewTextBoxColumn2, Me.AverageDataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.AttendenceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(742, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_28_at_9_09_24_AM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "Attendence"
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AttendenceTableAdapter3 As WindowsApplication1.loginDataSet6TableAdapters.AttendenceTableAdapter
    Friend WithEvents MarksDataSet2 As WindowsApplication1.marksDataSet2
    Friend WithEvents AttendenceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttendenceTableAdapter As WindowsApplication1.marksDataSet2TableAdapters.AttendenceTableAdapter
    Friend WithEvents AverageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttSENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttJPRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttGADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents AverageDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttSENDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttJPRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttGADDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollnoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RollnoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttGADDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttJPRDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttSENDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
