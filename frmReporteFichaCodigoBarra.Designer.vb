<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFichaCodigoBarra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvFichaGeneraCodigoBarra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvFichaGeneraCodigoBarra
        '
        Me.crvFichaGeneraCodigoBarra.ActiveViewIndex = -1
        Me.crvFichaGeneraCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvFichaGeneraCodigoBarra.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvFichaGeneraCodigoBarra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvFichaGeneraCodigoBarra.Location = New System.Drawing.Point(0, 0)
        Me.crvFichaGeneraCodigoBarra.Name = "crvFichaGeneraCodigoBarra"
        Me.crvFichaGeneraCodigoBarra.Size = New System.Drawing.Size(522, 398)
        Me.crvFichaGeneraCodigoBarra.TabIndex = 0
        '
        'frmReporteFichaCodigoBarra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 398)
        Me.Controls.Add(Me.crvFichaGeneraCodigoBarra)
        Me.Name = "frmReporteFichaCodigoBarra"
        Me.Text = "frmReporteFichaCodigoBarra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvFichaGeneraCodigoBarra As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
