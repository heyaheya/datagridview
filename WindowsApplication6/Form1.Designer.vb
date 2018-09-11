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
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.LabelTimer = New System.Windows.Forms.Label()
		Me.ListView2 = New System.Windows.Forms.ListView()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Chart1
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Alignment = System.Drawing.StringAlignment.Center
		Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
		Legend1.MaximumAutoSize = 10.0!
		Legend1.Name = "Legend1"
		Legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(597, 45)
		Me.Chart1.Name = "Chart1"
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(419, 90)
		Me.Chart1.TabIndex = 11
		Me.Chart1.Text = "Chart1"
		'
		'Chart2
		'
		ChartArea2.Name = "ChartArea1"
		Me.Chart2.ChartAreas.Add(ChartArea2)
		Legend2.Name = "Legend1"
		Me.Chart2.Legends.Add(Legend2)
		Me.Chart2.Location = New System.Drawing.Point(116, 108)
		Me.Chart2.Name = "Chart2"
		Series2.ChartArea = "ChartArea1"
		Series2.Legend = "Legend1"
		Series2.Name = "Series1"
		Me.Chart2.Series.Add(Series2)
		Me.Chart2.Size = New System.Drawing.Size(643, 100)
		Me.Chart2.TabIndex = 12
		Me.Chart2.Text = "Chart2"
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
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
		Me.SplitContainer1.Size = New System.Drawing.Size(1149, 603)
		Me.SplitContainer1.SplitterDistance = 278
		Me.SplitContainer1.TabIndex = 13
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.LinkLabel1)
		Me.SplitContainer2.Panel1.Controls.Add(Me.LabelTimer)
		Me.SplitContainer2.Panel1.Controls.Add(Me.ListView2)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Chart1)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
		Me.SplitContainer2.Panel1.Controls.Add(Me.ProgressBar1)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
		Me.SplitContainer2.Panel2.Enabled = False
		Me.SplitContainer2.Panel2MinSize = 0
		Me.SplitContainer2.Size = New System.Drawing.Size(1105, 250)
		Me.SplitContainer2.SplitterDistance = 150
		Me.SplitContainer2.TabIndex = 0
		'
		'LabelTimer
		'
		Me.LabelTimer.AutoSize = True
		Me.LabelTimer.Location = New System.Drawing.Point(4, 111)
		Me.LabelTimer.Name = "LabelTimer"
		Me.LabelTimer.Size = New System.Drawing.Size(39, 13)
		Me.LabelTimer.TabIndex = 19
		Me.LabelTimer.Text = "Label2"
		'
		'ListView2
		'
		Me.ListView2.Location = New System.Drawing.Point(151, 16)
		Me.ListView2.Name = "ListView2"
		Me.ListView2.Size = New System.Drawing.Size(395, 119)
		Me.ListView2.TabIndex = 18
		Me.ListView2.UseCompatibleStateImageBehavior = False
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(3, 84)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 17
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(680, 16)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(276, 23)
		Me.ProgressBar1.TabIndex = 14
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(3, 55)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 15
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(3, 16)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(3, 85)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
		Me.CheckBox1.TabIndex = 13
		Me.CheckBox1.Text = "Wyswietl dane"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Label1"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(21, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1071, 77)
		Me.DataGridView1.TabIndex = 0
		'
		'ListView1
		'
		Me.ListView1.Location = New System.Drawing.Point(116, 3)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(535, 99)
		Me.ListView1.TabIndex = 13
		Me.ListView1.UseCompatibleStateImageBehavior = False
		'
		'Timer1
		'
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(38, 111)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
		Me.LinkLabel1.TabIndex = 20
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "LinkLabel1"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666!))
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.ListView1, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Chart2, 1, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 19)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(855, 211)
		Me.TableLayoutPanel1.TabIndex = 14
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1181, 618)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.PerformLayout()
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Chart2 As DataVisualization.Charting.Chart
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Label1 As Label
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents ListView1 As ListView
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Button3 As Button
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents ListView2 As ListView
	Friend WithEvents LabelTimer As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
