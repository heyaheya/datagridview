Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types



Public Class Form1

    Public ds As DataSet
    Public dr As OracleDataReader
	Public Property AxisX As Object

	'zmienna do Timer1
	Dim second As Integer

	Dim x0 As DateTime
	Dim mouseIsDown As Boolean
	Dim p0 As Point
	Dim p As Point



	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



		Timer1.Interval = 1000
		Timer1.Start() 'Timer starts functioning

		Call Proc_22()



		'SplitContainer1.Dock = DockStyle.Fill
		'SplitContainer2.Dock = DockStyle.Fill

		'Label1.Dock = DockStyle.Top
		'DataGridView1.Dock = DockStyle.Fill







		SplitContainer2.Panel2.Visible = False
		SplitContainer2.SplitterDistance = SplitContainer2.Height
		CheckBox1.Text = "Wyświetl dane"

		'Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
		Me.Chart1.Series(0).XValueType = ChartValueType.DateTime

		Me.Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "yyyy-MM-dd"

		'obrot etykiety o wartość stopni do -90 do +90
		'Me.Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 0

		Me.Chart1.ChartAreas(0).AxisX.Interval = 1
		Me.Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Days
		Me.Chart1.ChartAreas(0).AxisX.IntervalOffset = 1

		'wyłączenie znaczników osi X
		'Me.Chart2.ChartAreas(0).AxisX.MajorGrid.Enabled = False


		Me.Chart1.ChartAreas(0).AxisX.LabelAutoFitStyle = True




		Dim ex As Exception
		Dim ls As New List(Of String)

		Dim Serwer_FTP As String
		Dim Login_FTP As String
		Dim Haslo_FTP As String

		Serwer_FTP = "ftp://energaobrot.home.pl"
		Login_FTP = "oht_miernik_mocy@energaobrot.pl"
		Haslo_FTP = "M13rN!k3n#rG@"

		ls = ListRemoteFiles(Serwer_FTP, Login_FTP, Haslo_FTP, ex)



		'MsgBox(ex)

	End Sub

	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		LabelTimer.Text = DateTime.Now.ToString

		second = second + 1
		If second >= 10 Then
			Timer1.Stop() 'Timer stops functioning
			MsgBox("Timer Stopped....")
		End If

	End Sub


	Sub Proc_22()



		Dim i_seria As Integer = 0

		Dim o_chart As Chart

		Dim data_od As Date
		Dim data_do As Date
		Dim l_ID_Prognoza As Long
		Dim l_ID_Wykonanie As Long
		Dim l_ID_CRE As Long
		Dim s_Agregat As String



		data_od = Now().AddDays(-10)
		data_do = data_od.AddDays(+8)

		l_ID_Prognoza = 3014
		l_ID_CRE = 3006
		l_ID_Wykonanie = 3010
		s_Agregat = "hh"

		o_chart = Me.Chart1

		data_od = Now().AddDays(-10)
		data_do = data_od.AddDays(+8)

		ustaw_parametry_wykresu(o_chart, 500, 600)
		dodaj_serie(o_chart, 0, "prognoza", Color.Blue, False)
		pobierz_dane_do_serii(o_chart, 0, 3, 0, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)

		dodaj_serie(o_chart, 1, "wykonanie", Color.Green, False)
		pobierz_dane_do_serii(o_chart, 1, 3, 1, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)

		dodaj_serie(o_chart, 2, "odchylenie", Color.Red, False)
		pobierz_dane_do_serii(o_chart, 2, 3, 2, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)


		o_chart = Me.Chart2
		ustaw_parametry_wykresu(o_chart, 500, 600)
		dodaj_serie(o_chart, 0, "prognoza", Color.Blue, False)
		pobierz_dane_do_serii(o_chart, 0, 3, 0, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)

		dodaj_serie(o_chart, 1, "wykonanie", Color.Green, False)
		pobierz_dane_do_serii(o_chart, 1, 3, 1, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)

		dodaj_serie(o_chart, 2, "odchylenie", Color.Red, False)
		pobierz_dane_do_serii(o_chart, 2, 3, 2, data_od, data_do, l_ID_CRE, l_ID_Prognoza, l_ID_Wykonanie, s_Agregat)


		'dodanie lini poziomej na lini 333 o grubosci 8
		'Chart1.ChartAreas(0).AxisY.StripLines.Add(New StripLine())
		'Chart1.ChartAreas(0).AxisY.StripLines(0).BackColor = Color.FromArgb(80, 252, 180, 65)
		'Chart1.ChartAreas(0).AxisY.StripLines(0).StripWidth = 8
		'Chart1.ChartAreas(0).AxisY.StripLines(0).Interval = 1000
		'Chart1.ChartAreas(0).AxisY.StripLines(0).IntervalOffset = 333

		'dodanie lini pionowej na lini 97 o grubosci 1
		Chart1.ChartAreas(0).AxisX.StripLines.Add(New StripLine())
		Chart1.ChartAreas(0).AxisX.StripLines(0).BackColor = Color.FromArgb(80, 252, 180, 65)
		Chart1.ChartAreas(0).AxisX.StripLines(0).StripWidth = 10
		Chart1.ChartAreas(0).AxisX.StripLines(0).Interval = 100

		Dim data2 As Date = "2018-08-27 00:00"
		'Dim laba As Double


		'
		'laba = data2.ToOADate

		'Chart1.ChartAreas(0).AxisX.StripLines(0).IntervalOffset = laba





	End Sub

	Sub ustaw_parametry_wykresu(o_chart As Chart, i_wysokosc As Integer, i_szeroksc As Integer)

		'rozmiar i wlasciwosci
		'legenda
		'etykieta
		'typ
		'etykiety osi 



		With o_chart.ChartAreas(0)
			.AxisX.MajorGrid.LineColor = Color.LightBlue
			.AxisY.MajorGrid.LineColor = Color.LightGray

			'.AxisX.Minimum = 1
			'.AxisX.Maximum = 24 * 7
			'.AxisX.Interval = 1

			'.AxisY.Minimum = 0
			'.AxisY.Maximum = 100
			'.AxisY.Interval = 20

		End With

		'o_chart.Width = i_szeroksc
		' o_chart.Height = i_wysokosc

		o_chart.Dock = DockStyle.Fill


	End Sub

	Sub dodaj_serie(o_chart As Chart, i_seria As Integer, s_nazwa As String, o_kolor As Color, os_pomocnicza As Boolean)


		If o_chart.Legends.Count >= i_seria + 1 Then

			'istniejąca seria
			o_chart.Series(i_seria).Points.Clear()
			o_chart.Series(i_seria).Name = s_nazwa
		Else
			'nowa seria
			o_chart.Series.Add(s_nazwa)

		End If

		o_chart.Series(i_seria).Color = o_kolor

		o_chart.Series(i_seria).BorderWidth = 3

		If os_pomocnicza = True Then
			o_chart.Series(i_seria).YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
		End If

		o_chart.Series(i_seria).ChartType = SeriesChartType.Line

	End Sub


	Sub pobierz_dane_do_serii(o_chart As Chart, i_seria As Integer, i_kolumna_x As Integer, i_kolumna_y As Integer,
							  data_od As Date, data_do As Date, l_ID_CRE As Long, l_ID_Prognoza As Long,
							  l_ID_Wykonanie As Long, s_Agregat As String)


		Dim da As OracleDataAdapter
		'Dim cb As OracleCommandBuilder

		Dim sql As String

		'ERGH
		Dim oradb As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
					+ "(ADDRESS=(PROTOCOL=TCP)(HOST = ENCELADUS.energa.loc)(PORT = 1521)))" _
					+ "(CONNECT_DATA=(SERVICE_NAME=SRV_ERGH)));" _
					+ "User Id=skome;Password=szafran1;"

		Dim conn As New OracleConnection(oradb) ' Visual Basic

		Try
			conn.Open()

		Catch ex As OracleException ' catches only Oracle errors
			Select Case ex.Number
				Case 1
					MessageBox.Show("Error attempting to insert duplicate data.")
				Case 12560
					MessageBox.Show("Baza danych jest niedostępna !")
				Case Else
					MessageBox.Show("Database error: " + ex.Message.ToString())
			End Select


		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString())
		Finally
			'conn.Dispose()
		End Try


		Dim cmd As New OracleCommand
		cmd.Connection = conn



		sql = ""
		sql = sql & "  SELECT SUM (Prognoza)           AS " & Chr(34) & "Prognoza" & Chr(34) & ","
		sql = sql & "         SUM (Wykonanie)          AS " & Chr(34) & "Wykonanie" & Chr(34) & ","
		sql = sql & "         SUM (Prognoza - Wykonanie) As " & Chr(34) & "Odchylenie" & Chr(34) & ","
		sql = sql & "         TRUNC (K.GODZINA, '" & s_Agregat & "')  AS " & Chr(34) & "data" & Chr(34)
		sql = sql & "    FROM (  Select SUM (VALUE) As CRE, TRUNC (DateTime, 'hh') AS GODZINA"
		sql = sql & "              FROM energy15"
		sql = sql & "             WHERE     FORMULAID = '" & l_ID_CRE & "'"
		sql = sql & "                   AND DateTime >="
		sql = sql & "                           TO_DATE ('" & data_od.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "                   AND DateTime <"
		sql = sql & "                           TO_DATE ('" & data_do.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "          GROUP BY TRUNC (DATETIME, 'hh')) K"
		sql = sql & "         INNER JOIN"
		sql = sql & "         (  SELECT SUM (VALUE) / 1000 AS Prognoza,"
		sql = sql & "                   TRUNC (DateTime, 'hh') AS GODZINA"
		sql = sql & "              FROM energy15"
		sql = sql & "             WHERE     FORMULAID = '" & l_ID_Prognoza & "'"
		sql = sql & "                   AND DateTime >="
		sql = sql & "                           TO_DATE ('" & data_od.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "                   AND DateTime <"
		sql = sql & "                           TO_DATE ('" & data_do.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "          GROUP BY TRUNC (DATETIME, 'hh')) D"
		sql = sql & "             ON (K.GODZINA = D.GODZINA)"
		sql = sql & "         INNER JOIN"
		sql = sql & "         (  SELECT SUM (VALUE)/1000 AS Wykonanie, TRUNC (DATETIME, 'hh') AS GODZINA"
		sql = sql & "              FROM energy15"
		sql = sql & "             WHERE     FORMULAID = '" & l_ID_Wykonanie & "'"
		sql = sql & "                   AND datetime >="
		sql = sql & "                           TO_DATE ('" & data_od.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "                   AND DateTime <"
		sql = sql & "                           TO_DATE ('" & data_do.ToString("yyyy-MM-dd") & " 00:00', 'YYYY-MM-DD HH24:MI')"
		sql = sql & "          GROUP BY TRUNC (DATETIME, 'hh')) RB"
		sql = sql & "             ON K.GODZINA = RB.GODZINA "
		sql = sql & "GROUP BY TRUNC (K.GODZINA, '" & s_Agregat & "') "
		sql = sql & "ORDER BY TRUNC (K.GODZINA, '" & s_Agregat & "')"


		cmd.CommandText = sql

		cmd.CommandType = CommandType.Text

		da = New OracleDataAdapter(cmd)
		'cb = New OracleCommandBuilder(da)
		ds = New DataSet()

		da.Fill(ds)

		dr = cmd.ExecuteReader()

		Dim i As Int32
		i = 0


		Dim data1 As Date
		Dim aaa As Integer

		aaa = dr.FieldCount - 1

		Dim matrix(aaa, 0) As String

		While dr.Read()

			data1 = dr.Item(i_kolumna_x)
			matrix(0, i) = data1.ToString

			matrix(i_kolumna_y, 0) = dr.Item(i_kolumna_y).ToString

			i = i + 1

			'o_chart.Series(i_seria).Points.AddXY(i, dr.Item(i_kolumna_x))
			'o_chart.Series(i_seria).Points.AddXY(data1, dr.Item(i_kolumna_y))
			o_chart.Series(i_seria).Points.AddXY(dr.Item(i_kolumna_x), dr.Item(i_kolumna_y))

			ReDim Preserve matrix(aaa, i)

		End While

		'DataGridView1.DataSource = matrix

		cmd.Dispose()
		conn.Dispose()

	End Sub


	Protected Overrides Sub Finalize()
		MyBase.Finalize()
		dr.Dispose()

	End Sub



	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked = False Then
			SplitContainer2.Panel2.Visible = False
			SplitContainer2.SplitterDistance = SplitContainer2.Height
			CheckBox1.Text = "Wyświetl dane"
		Else
			SplitContainer2.Panel2.Visible = True
			SplitContainer2.SplitterDistance = SplitContainer2.Height / 2
			CheckBox1.Text = "Ukryj dane"
		End If
	End Sub


	Private Sub Chart1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseDown
		p0 = e.Location
		x0 = Date.FromOADate(Chart1.ChartAreas(0).AxisX.PixelPositionToValue(e.X))
		mouseIsDown = True
	End Sub
	Private Sub Chart1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseUp
		Dim x As DateTime = Date.FromOADate(Chart1.ChartAreas(0).AxisX.PixelPositionToValue(e.X))
		'make sure x0 < x
		If x0 > x Then
			Dim xtemp As DateTime = x
			x = x0
			x0 = xtemp
		End If

		'do your maths by iterating the points collection

		'rescale the chart...
		With Me.Chart1.ChartAreas(0).AxisX
			.Minimum = x0.ToOADate()
			.Maximum = x.ToOADate()
		End With

		mouseIsDown = False
		Chart1.Invalidate()

	End Sub


	Private Sub Chart1_MouseMove(sender As Object, e As MouseEventArgs) Handles Chart1.MouseMove
		If mouseIsDown Then
			p = e.Location
			Chart1.Invalidate()
		End If
	End Sub




	Private Sub Chart1_Paint(sender As Object, e As PaintEventArgs) Handles Chart1.Paint
		If mouseIsDown Then
			Dim sze As New Size(p.X - p0.X, p.Y - p0.Y)
			e.Graphics.DrawRectangle(Pens.Black, New Rectangle(p0, sze))
		End If
	End Sub











End Class

