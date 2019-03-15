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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.DataSet1energy15miernikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataSet1_energy15_miernik = New Mapa1.DataSet1_energy15_miernik()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FORMULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.FORMULATableAdapter = New Mapa1.DataSet2TableAdapters.FORMULATableAdapter()
		Me.DataSet1 = New Mapa1.DataSet1()
		Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridView3 = New System.Windows.Forms.DataGridView()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1energy15miernikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1_energy15_miernik, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FORMULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Chart2
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart2.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart2.Legends.Add(Legend1)
		Me.Chart2.Location = New System.Drawing.Point(59, 4)
		Me.Chart2.Margin = New System.Windows.Forms.Padding(4)
		Me.Chart2.Name = "Chart2"
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart2.Series.Add(Series1)
		Me.Chart2.Size = New System.Drawing.Size(300, 300)
		Me.Chart2.TabIndex = 12
		Me.Chart2.Text = "Chart2"
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
		Me.DataGridView1.Location = New System.Drawing.Point(4, 201)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(300, 300)
		Me.DataGridView1.TabIndex = 0

		'
		'DataGridView2
		'
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(4, 279)
		Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(300, 300)
		Me.DataGridView2.TabIndex = 20

		'	'
		'ListView1
		'
		Me.ListView1.FullRowSelect = True
		Me.ListView1.Location = New System.Drawing.Point(4, 599)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.RightToLeftLayout = True
		Me.ListView1.Size = New System.Drawing.Size(300, 300)
		Me.ListView1.TabIndex = 13
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		Me.FORMULATableAdapter.ClearBeforeFill = True
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
		'DataGridView3
		'
		Me.DataGridView3.AllowUserToDeleteRows = False
		Me.DataGridView3.AutoGenerateColumns = False
		Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView3.DataSource = Me.DataSet1energy15miernikBindingSource
		Me.DataGridView3.Location = New System.Drawing.Point(4, 449)
		Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView3.Name = "DataGridView3"
		Me.DataGridView3.Size = New System.Drawing.Size(300, 300)
		Me.DataGridView3.TabIndex = 21

		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.Location = New System.Drawing.Point(693, 599)
		Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(100, 22)
		Me.NumericUpDown1.TabIndex = 20


		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(636, 595)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 16)
		Me.Label4.TabIndex = 21
		Me.Label4.Text = "Label4"



		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(579, 595)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(49, 16)
		Me.Label3.TabIndex = 19
		Me.Label3.Text = "Label3"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(443, 595)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 36)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Label2"



		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(386, 595)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(49, 16)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Label1"

		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(1073, 599)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(128, 28)
		Me.Button3.TabIndex = 17
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(937, 599)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(128, 28)
		Me.Button2.TabIndex = 15
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(801, 599)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(128, 28)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(1209, 885)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(114, 20)
		Me.CheckBox1.TabIndex = 13
		Me.CheckBox1.Text = "Wyswietl dane"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Chart1
		'
		ChartArea2.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea2)
		Legend2.Alignment = System.Drawing.StringAlignment.Center
		Legend2.MaximumAutoSize = 10.0!
		Legend2.Name = "Legend1"
		Legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
		Me.Chart1.Legends.Add(Legend2)
		Me.Chart1.Location = New System.Drawing.Point(4, 192)
		Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
		Me.Chart1.Name = "Chart1"
		Series2.ChartArea = "ChartArea1"
		Series2.Legend = "Legend1"
		Series2.Name = "Series1"
		Me.Chart1.Series.Add(Series2)
		Me.Chart1.Size = New System.Drawing.Size(300, 300)
		Me.Chart1.TabIndex = 11
		Me.Chart1.Text = "Chart1"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
		Me.TableLayoutPanel2.TabIndex = 0
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Chart2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Chart1)
		Me.FlowLayoutPanel1.Controls.Add(Me.DataGridView1)
		Me.FlowLayoutPanel1.Controls.Add(Me.DataGridView2)
		Me.FlowLayoutPanel1.Controls.Add(Me.DataGridView3)
		Me.FlowLayoutPanel1.Controls.Add(Me.ListView1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		'Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1338, 953)
		Me.FlowLayoutPanel1.TabIndex = 0
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(49, 16)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Label5"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1338, 953)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1energy15miernikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1_energy15_miernik, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FORMULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Chart2 As DataVisualization.Charting.Chart
	'Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Label1 As Label
	'Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents ListView1 As ListView
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents Timer1 As Timer
	'Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents FORMULABindingSource As BindingSource
	Friend WithEvents DataSet1energy15miernikBindingSource As BindingSource
	Friend WithEvents DataSet1_energy15_miernik As DataSet1_energy15_miernik
	Friend WithEvents DataSet1 As Mapa1.DataSet1
	Friend WithEvents DataSet1BindingSource As BindingSource
	Friend WithEvents FORMULATableAdapter As Mapa1.DataSet2TableAdapters.FORMULATableAdapter
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	'Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents DataGridView3 As DataGridView
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label5 As Label
End Class
