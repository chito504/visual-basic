'
' Creado por SharpDevelop.
' Usuario: lexblas
' Fecha: 07/12/2011
' Hora: 10:13
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False ' MySettings are not supported in SharpDevelop.
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub
	End Class
End Namespace
