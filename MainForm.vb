Imports System.Drawing.Text
Public Partial Class MainForm
	dim fuente as Font
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
    Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
	Public Sub cargarfuente()
		 
        Dim pfc As PrivateFontCollection = New PrivateFontCollection()
        Dim fontFamily As FontFamily
'Obtenemos la fuente que se encuentra en el directorio de la aplicacion
'y la cargamos 
        pfc.AddFontFile(my.Application.Info.DirectoryPath &"\BARCODE.TTF" )
        fontFamily = pfc.Families(0)
        fuente = New Font(fontFamily,50)
    


	End Sub
	
	Public Function FormatoCodigoBarras(ByVal code As String) As String
		
        Dim barcode As String = String.Empty
        barcode = String.Format("{0}", code)
        Return barcode
    End Function
	
   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click




        Dim DataSetMemoria As New Reportes
        Dim fila As Reportes.dtsFichaCodigoBarraRow = DataSetMemoria.dtsFichaCodigoBarra.NewdtsFichaCodigoBarraRow

        ''Pasamos los datos de los TextBox a los campos del dtsFicha que creamos en el DataSetReportes 

        If TXTPRODUCTO.Text = "" Then
            fila.NombreProducto = ""
        Else
            fila.NombreProducto = TXTPRODUCTO.Text
        End If


        If txtcodigoProducto.Text = "" Then
            fila.codigoProducto = ""
        Else
            fila.codigoProducto = txtcodigoProducto.Text
        End If


        If lblcodigoBarra.Text = "" Then
            fila.codigoBarra = ""
        Else
            fila.codigoBarra = lblcodigoBarra.Text
        End If




        '*****************************************

        DataSetMemoria.dtsFichaCodigoBarra.AdddtsFichaCodigoBarraRow(fila)

        'Mostrando Reporte
        Dim rpt As New FichaCodigoBarra 'Es el nombre del Reporte

        rpt.SetDataSource(DataSetMemoria)

        frmReporteFichaCodigoBarra.crvFichaGeneraCodigoBarra.ReportSource = rpt

        frmReporteFichaCodigoBarra.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCodigoBarra.Click
        cargarfuente()
        lblcodigoBarra.Font = fuente
        lblcodigoBarra.Text = FormatoCodigoBarras(txtcodigoProducto.Text)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub lblcodigoBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcodigoBarra.Click

    'End Sub
End Class
