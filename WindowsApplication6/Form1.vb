Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Imports System.Text
Imports System.Data.OleDb

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

	Dim ls As New List(Of String)
	Private ReadOnly txtpathfile As Object

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: Ten wiersz kodu wczytuje dane do tabeli 'DataSet2.FORMULA' . Możesz go przenieść lub usunąć.
		'Me.FORMULATableAdapter.Fill(Me.DataSet1_energy15_miernik.ENERGY15_MIERNIK)



		Dim header1 As ColumnHeader = New ColumnHeader()

		header1.Text = "Logi"
		header1.TextAlign = HorizontalAlignment.Left
		header1.Width = 500 'ListView1.Width - 5
		ListView1.Columns.Add(header1)

		ListView1.View = 3
		NumericUpDown1.Value = 1



		If My.Computer.Network.IsAvailable() Then
			Console.WriteLine("Network Connected")
			ListView1.Items.Add("Network Connected" & Chr(13))
		Else
			Console.WriteLine("No Network")
			ListView1.Items.Add("No Network" & Chr(13))
		End If


		Timer1.Interval = 1000
		Timer1.Start() 'Timer starts functioning
		ListView1.Items.Add("Czas start" & Chr(13))

		'Call Wykresy()
		ListView1.Items.Add("Uruchom wykresy" & Chr(13))

		SplitContainer1.Dock = DockStyle.Fill
		SplitContainer2.Dock = DockStyle.Fill

		Label1.Dock = DockStyle.Top
		DataGridView1.Dock = DockStyle.Fill


		SplitContainer2.Panel2.Visible = False

		SplitContainer2.SplitterDistance = SplitContainer2.Height



		'SplitContainer2.Panel1.Height = SplitContainer2.Height
		'SplitContainer2.Panel2.Height = 0

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


		Dim Serwer_FTP, Serwer_FTP_1 As String
		Dim Login_FTP As String
		Dim Haslo_FTP As String
		Dim Folder_FTP As String
		Dim Folder_Loc As String

		Serwer_FTP_1 = "energaobrot.home.pl"
		Serwer_FTP = "212.85.101.65"
		Login_FTP = "oht_miernik_mocy@energaobrot.pl"
		Haslo_FTP = "M13rN!k3n#rG@"
		Folder_FTP = "/"
		Folder_Loc = "c:\aaa\"

		'wgrywanie plikow na FTP
		'UploadFile(Serwer_FTP, Login_FTP, Haslo_FTP, Folder_FTP)


		Dim ex As Exception
		Dim ls As New List(Of String)

		'pobranie listy plikow
		ls = ListRemoteFiles("FTP://" & Serwer_FTP, Login_FTP, Haslo_FTP, ex)

		ListView1.Items.Add("Pobrano listę plików z FTP" & Chr(13))
		Dim iq As Integer


		If Not ls.Count = 0 Then
			For iq = 0 To ls.Count - 1
				ListView1.Items.Add(ls(iq) & Chr(13))
			Next iq
			ls.Sort()


			Dim temp_plik2 As String
			temp_plik2 = ls(ls.Count - 1)

			temp_plik2 = "esmart_ee_auto15min_2018_10_20_22_50_04.csv"


			ListView1.Items.Add("Ostatni plik na FTP: " & temp_plik2 & Chr(13))

			Dim temp_data2 As DateTime
			temp_data2 = GetFtpServerDateTime(Serwer_FTP, Login_FTP, Haslo_FTP, Folder_FTP, temp_plik2)

			Label1.Text = temp_plik2 & "      data    " & temp_data2
			ListView1.Items.Add("Data pliku: " & temp_data2 & Chr(13))

			'pobranie pliku
			DownloadSingleFile("FTP://" & Serwer_FTP_1, Login_FTP, Haslo_FTP, temp_plik2, Folder_Loc, False, ex)

			'wklejenie danych do viewdatagrid1

			Dim SR As StreamReader = New StreamReader(Folder_Loc & temp_plik2)
			Dim i As Long = 0
			Dim line As String '= SR.ReadLine()
			Dim strArray As String()
			Dim dt As DataTable = New DataTable()
			Dim row As DataRow


			line = SR.ReadLine()
			line = line.Replace(Chr(34), String.Empty)
			strArray = line.Split(";"c)

			For Each s As String In strArray
				'test_str = Mid(s, 2, Len(s) - 2)
				dt.Columns.Add(New DataColumn(s, GetType(String)))
			Next

			line = SR.ReadLine


			Dim znak_cudzyslow = Chr(34)
			Dim znak_srednik As Char = Chr(59)

			Do While Not line = String.Empty
				row = dt.NewRow()

				line = line.Replace(Chr(34), String.Empty)
				row.ItemArray = line.Split(";"c)
				dt.Rows.Add(row)

				line = SR.ReadLine

			Loop 'While Not line = String.Empty

			SR.Close()

			SR.Dispose()

			DataGridView2.DataSource = dt

			With DataGridView2
				'.AutoGenerateColumns = True
				.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
				.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
				.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
			End With

			DataGridView1.DataSource = dt


			'Dim data_pliku As Date
			'Dim data_string As String

			'data_string = Mid(temp_plik2, 21, 4) & "-" & Mid(temp_plik2, 26, 2) & "-" & Mid(temp_plik2, 29, 2) & " "
			'data_string = data_string & Mid(temp_plik2, 32, 2) & ":" & Mid(temp_plik2, 35, 2) & ":"
			'data_string = data_string & Mid(temp_plik2, 38, 2)



			row = dt.Rows(1)

			Dim x0 As Long

			x0 = DateDiff(DateInterval.Minute, row(1), row(3))
			x0 = (x0 / 15) + 6

			'x0 = 85


			Dim status As Boolean = True
			Dim form_ID As Long


			For Each row1 As DataRow In dt.Rows

				form_ID = pobierz_ID_formuly(row1(0))

				For i22 As Integer = 6 To x0
					'wyszukaj ID
					Console.WriteLine(form_ID)
					Console.WriteLine(row1(i22))
					Console.WriteLine(dt.Columns(i22))

				Next
			Next






		Else
			MsgBox("Niestety nie zostały znalezione pliki na serwerze", MsgBoxStyle.Critical, "Błąd...")
		End If





	End Sub


	Function pobierz_ID_formuly(nazwa As String)
		Select Case nazwa
			Case "MORPOL_I"
				pobierz_ID_formuly = 10
			Case "MORPOL_III"
				pobierz_ID_formuly = 11
			Case "MORPOL_IV"
				pobierz_ID_formuly = 12
			Case "MORPOL_STRZELINO"
				pobierz_ID_formuly = 13
			Case "MORPOL_LEBORK_BIS"
				pobierz_ID_formuly = 14
			Case "LUBIANA"
				pobierz_ID_formuly = 15
			Case "DRUMET_TR1"
				pobierz_ID_formuly = 16
			Case "DRUMET_TR2"
				pobierz_ID_formuly = 17
			Case "HYDRO - VACUUM"
				pobierz_ID_formuly = 18
			Case "GOLPASZ"
				pobierz_ID_formuly = 19
			Case "MARINA_CLUB"
				pobierz_ID_formuly = 20

		End Select
	End Function


	Public Function ListRemoteFiles(ftpAddress As String,
				ftpUser As String,
					 ftpPassword As String,
					 ByRef ExceptionInfo As Exception) As List(Of String)

		Dim ListOfFilesOnFTPSite As New List(Of String)

		Dim ftpRequest As FtpWebRequest = Nothing
		Dim ftpResponse As FtpWebResponse = Nothing

		Dim strReader As StreamReader = Nothing
		Dim sline As String = ""

		Try
			ftpRequest = CType(WebRequest.Create(ftpAddress), FtpWebRequest)

			With ftpRequest
				.Credentials = New NetworkCredential(ftpUser, ftpPassword)
				.Method = WebRequestMethods.Ftp.ListDirectory
			End With

			ftpResponse = CType(ftpRequest.GetResponse, FtpWebResponse)

			strReader = New StreamReader(ftpResponse.GetResponseStream)

			If strReader IsNot Nothing Then sline = strReader.ReadLine

			While sline IsNot Nothing
				ListOfFilesOnFTPSite.Add(sline)
				sline = strReader.ReadLine
			End While

		Catch ex As Exception
			ExceptionInfo = ex

		Finally
			If ftpResponse IsNot Nothing Then
				ftpResponse.Close()
				ftpResponse = Nothing
			End If

			If strReader IsNot Nothing Then
				strReader.Close()
				strReader = Nothing
			End If
		End Try

		ListRemoteFiles = ListOfFilesOnFTPSite

		ListOfFilesOnFTPSite = Nothing
	End Function


	Private Function GetFtpServerDateTime(ByVal ftpServer As String, ByVal username As String,
									  ByVal password As String, ByVal folder As String, ByVal ftpFile As String) As Date

		If Not LCase(Mid(ftpServer, 1, 3)) = "ftp" Then
			ftpServer = "ftp://" & ftpServer
		End If

		If Not ftpServer.EndsWith("/") Then
			ftpServer &= "/"
		End If

		If folder.Length > 1 Then
			If Not folder.EndsWith("/") Then
				folder &= "/"
			End If
		Else
			folder = ""
		End If
		'MsgBox(ftpFile)

		ftpFile = String.Concat(ftpServer, folder, ftpFile)


		Dim request As System.Net.FtpWebRequest = System.Net.FtpWebRequest.Create(ftpFile)
		Dim creds As New System.Net.NetworkCredential(username, password)
		request.Credentials = creds
		'request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
		request.Method = System.Net.WebRequestMethods.Ftp.GetDateTimestamp

		Dim response As System.Net.FtpWebResponse = request.GetResponse

		request = System.Net.FtpWebRequest.Create(ftpFile)
		request.Credentials = creds
		request.Method = System.Net.WebRequestMethods.Ftp.GetDateTimestamp
		response = request.GetResponse

		Return response.LastModified

		response.Close()

	End Function







	Function DownloadSingleFile(ftpAddress As String,
										  ftpUser As String,
										  ftpPassword As String,
										  fileToDownload As String,
										  downloadTargetFolder As String,
										  deleteAfterDownload As Boolean,
										  ExceptionInfo As Exception) As Boolean

		Dim FileDownloaded As Boolean = False

		Try

			Dim sFtpFile As String = ftpAddress & "/" & fileToDownload

			Dim sTargetFileName = System.IO.Path.GetFileName(sFtpFile)
			sTargetFileName = sTargetFileName.Replace("/", "\")
			sTargetFileName = downloadTargetFolder & sTargetFileName

			My.Computer.Network.DownloadFile(sFtpFile, sTargetFileName, ftpUser, ftpPassword)

			If deleteAfterDownload Then
				Dim ftpRequest As FtpWebRequest = Nothing

				ftpRequest = CType(WebRequest.Create(sFtpFile), FtpWebRequest)

				With ftpRequest
					.Credentials = New NetworkCredential(ftpUser, ftpPassword)
					.Method = WebRequestMethods.Ftp.DeleteFile
				End With

				Dim response As FtpWebResponse = CType(ftpRequest.GetResponse(), FtpWebResponse)
				response.Close()

				ftpRequest = Nothing

				FileDownloaded = True

			End If

		Catch ex As Exception
			ExceptionInfo = ex
		End Try

		Return FileDownloaded
	End Function




	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		Label3.Text = DateTime.Now.ToString

		second = second + 1
		If second >= 10 Then
			Timer1.Stop() 'Timer stops functioning
			ListView1.Items.Add("Czas stop ...")
		End If

	End Sub


	Sub Wykresy()



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

		If conn.State Then


			Label2.Text = "Connection is Open"

		Else

			Label2.Text = "Connection is close"

		End If





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

			'SplitContainer2.Panel1.Height = SplitContainer2.Height
			'SplitContainer2.Panel2.Height = 0

			SplitContainer2.Panel2Collapsed = True

		Else
			SplitContainer2.Panel2.Visible = True
			SplitContainer2.SplitterDistance = SplitContainer2.Height / 2
			CheckBox1.Text = "Ukryj dane"
			'SplitContainer2.Panel1.Height = SplitContainer2.Height / 2
			'SplitContainer2.Panel2.Height = SplitContainer2.Height / 2

			SplitContainer2.Panel2Collapsed = False

		End If
	End Sub


	Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
		ListView1.View = NumericUpDown1.Value
		Label4.Text = ListView1.View.ToString
	End Sub

	Private Sub ListView1_TextChanged(sender As Object, e As EventArgs) Handles ListView1.TextChanged
		ListView1.Items.Add(Chr(13))
		Label4.Text = ListView1.View.ToString
	End Sub

	Private Sub FORMULABindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles FORMULABindingSource.CurrentChanged

	End Sub
End Class

