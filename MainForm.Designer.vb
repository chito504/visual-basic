'
' Creado por SharpDevelop.
' Usuario: lexblas
' Fecha: 07/12/2011
' Hora: 10:13
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Me.lblcodigoBarra = New System.Windows.Forms.Label()
        Me.txtcodigoProducto = New System.Windows.Forms.TextBox()
        Me.TXTPRODUCTO = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.btnGenerarCodigoBarra = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblcodigoBarra
        '
        Me.lblcodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigoBarra.Location = New System.Drawing.Point(18, 11)
        Me.lblcodigoBarra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigoBarra.Name = "lblcodigoBarra"
        Me.lblcodigoBarra.Size = New System.Drawing.Size(705, 77)
        Me.lblcodigoBarra.TabIndex = 1
        Me.lblcodigoBarra.Text = "label1"
        '
        'txtcodigoProducto
        '
        Me.txtcodigoProducto.Location = New System.Drawing.Point(240, 150)
        Me.txtcodigoProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodigoProducto.Name = "txtcodigoProducto"
        Me.txtcodigoProducto.Size = New System.Drawing.Size(241, 26)
        Me.txtcodigoProducto.TabIndex = 2
        '
        'TXTPRODUCTO
        '
        Me.TXTPRODUCTO.Location = New System.Drawing.Point(240, 121)
        Me.TXTPRODUCTO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPRODUCTO.Name = "TXTPRODUCTO"
        Me.TXTPRODUCTO.Size = New System.Drawing.Size(241, 26)
        Me.TXTPRODUCTO.TabIndex = 4
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(464, 197)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(83, 29)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'btnGenerarCodigoBarra
        '
        Me.btnGenerarCodigoBarra.Location = New System.Drawing.Point(230, 197)
        Me.btnGenerarCodigoBarra.Name = "btnGenerarCodigoBarra"
        Me.btnGenerarCodigoBarra.Size = New System.Drawing.Size(219, 29)
        Me.btnGenerarCodigoBarra.TabIndex = 6
        Me.btnGenerarCodigoBarra.Text = "Generar Codigo de Barras"
        Me.btnGenerarCodigoBarra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Codigo Producto"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 308)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarCodigoBarra)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.TXTPRODUCTO)
        Me.Controls.Add(Me.txtcodigoProducto)
        Me.Controls.Add(Me.lblcodigoBarra)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lblcodigoBarra As System.Windows.Forms.Label
    Private txtcodigoProducto As System.Windows.Forms.TextBox
    Private WithEvents TXTPRODUCTO As System.Windows.Forms.TextBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGenerarCodigoBarra As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
