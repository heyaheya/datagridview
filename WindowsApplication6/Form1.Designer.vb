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
		Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.DataGridView3 = New System.Windows.Forms.DataGridView()
		Me.DataSet1energy15miernikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataSet1_energy15_miernik = New Mapa1.DataSet1_energy15_miernik()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FORMULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.DataSet1 = New Mapa1.DataSet1()
		Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1energy15miernikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1_energy15_miernik, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FORMULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Chart1
		'
		ChartArea3.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea3)
		Legend3.Alignment = System.Drawing.StringAlignment.Center
		Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
		Legend3.MaximumAutoSize = 10.0!
		Legend3.Name = "Legend1"
		Legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
		Me.Chart1.Legends.Add(Legend3)
		Me.Chart1.Location = New System.Drawing.Point(117, 3)
		Me.Chart1.Name = "Chart1"
		Series3.ChartArea = "ChartArea1"
		Series3.Legend = "Legend1"
		Series3.Name = "Series1"
		Me.Chart1.Series.Add(Series3)
		Me.Chart1.Size = New System.Drawing.Size(1223, 70)
		Me.Chart1.TabIndex = 11
		Me.Chart1.Text = "Chart1"
		'
		'Chart2
		'
		ChartArea4.Name = "ChartArea1"
		Me.Chart2.ChartAreas.Add(ChartArea4)
		Legend4.Name = "Legend1"
		Me.Chart2.Legends.Add(Legend4)
		Me.Chart2.Location = New System.Drawing.Point(290, 3)
		Me.Chart2.Name = "Chart2"
		Series4.ChartArea = "ChartArea1"
		Series4.Legend = "Legend1"
		Series4.Name = "Series1"
		Me.Chart2.Series.Add(Series4)
		Me.Chart2.Size = New System.Drawing.Size(879, 240)
		Me.Chart2.TabIndex = 12
		Me.Chart2.Text = "Chart2"
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.SplitContainer1.Location = New System.Drawing.Point(-5, -6)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1515, 767)
		Me.SplitContainer1.SplitterDistance = 671
		Me.SplitContainer1.TabIndex = 13
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel2)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
		Me.SplitContainer2.Panel2.Enabled = False
		Me.SplitContainer2.Panel2MinSize = 0
		Me.SplitContainer2.Size = New System.Drawing.Size(1511, 667)
		Me.SplitContainer2.SplitterDistance = 436
		Me.SplitContainer2.SplitterWidth = 10
		Me.SplitContainer2.TabIndex = 0
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.580175!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.41982!))
		Me.TableLayoutPanel2.Controls.Add(Me.Chart1, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.DataGridView3, 1, 1)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.55224!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1511, 436)
		Me.TableLayoutPanel2.TabIndex = 18
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(108, 111)
		Me.FlowLayoutPanel1.TabIndex = 12
		'
		'CheckBox1
		'
		Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
		Me.CheckBox1.TabIndex = 13
		Me.CheckBox1.Text = "Wyswietl dane"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(3, 26)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(96, 23)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(3, 55)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(96, 23)
		Me.Button2.TabIndex = 15
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(3, 84)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(96, 23)
		Me.Button3.TabIndex = 17
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(3, 110)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 29)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Label2"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 139)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 13)
		Me.Label3.TabIndex = 19
		Me.Label3.Text = "Label3"
		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.Location = New System.Drawing.Point(3, 155)
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(75, 20)
		Me.NumericUpDown1.TabIndex = 20
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 178)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 13)
		Me.Label4.TabIndex = 21
		Me.Label4.Text = "Label4"
		'
		'DataGridView3
		'
		Me.DataGridView3.AllowUserToDeleteRows = False
		Me.DataGridView3.AutoGenerateColumns = False
		Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView3.DataSource = Me.DataSet1energy15miernikBindingSource
		Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView3.Location = New System.Drawing.Point(117, 120)
		Me.DataGridView3.Name = "DataGridView3"
		Me.DataGridView3.Size = New System.Drawing.Size(1391, 313)
		Me.DataGridView3.TabIndex = 21
		'
		'DataSet1energy15miernikBindingSource
		'
		Me.DataSet1energy15miernikBindingSource.DataSource = Me.DataSet1_energy15_miernik
		Me.DataSet1energy15miernikBindingSource.Position = 0
		'
		'DataSet1_energy15_miernik
		'
		Me.DataSet1_energy15_miernik.DataSetName = "DataSet1_energy15_miernik"
		Me.DataSet1_energy15_miernik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(27, 25)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1435, 98)
		Me.DataGridView1.TabIndex = 0
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33929!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1172.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.ListView1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.DataGridView2, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Chart2, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.04065!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95935!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1459, 393)
		Me.TableLayoutPanel1.TabIndex = 14
		'
		'ListView1
		'
		Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListView1.FullRowSelect = True
		Me.ListView1.Location = New System.Drawing.Point(3, 3)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.RightToLeftLayout = True
		Me.ListView1.Size = New System.Drawing.Size(281, 249)
		Me.ListView1.TabIndex = 13
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'DataGridView2
		'
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView2.Location = New System.Drawing.Point(290, 258)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(1166, 132)
		Me.DataGridView2.TabIndex = 20
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 255)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Label1"
		'
		'FORMULABindingSource
		'
		'
		'Timer1
		'
		'
		'DataSet1
		'
		Me.DataSet1.DataSetName = "DataSet1"
		Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataSet1BindingSource
		'
		Me.DataSet1BindingSource.DataSource = Me.DataSet1
		Me.DataSet1BindingSource.Position = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1515, 774)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1energy15miernikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1_energy15_miernik, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FORMULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Chart2 As DataVisualization.Charting.Chart
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Label1 As Label
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents ListView1 As ListView
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents Timer1 As Timer
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents DataGridView3 As DataGridView
	Friend WithEvents FORMULABindingSource As BindingSource
	Friend WithEvents DataSet1energy15miernikBindingSource As BindingSource
	Friend WithEvents DataSet1_energy15_miernik As DataSet1_energy15_miernik
	Friend WithEvents DataSet1 As Mapa1.DataSet1
	Friend WithEvents DataSet1BindingSource As BindingSource
	'Friend WithEvents FORMULATableAdapter As Mapa1.DataSet2TableAdapters.FORMULATableAdapter
End Class
