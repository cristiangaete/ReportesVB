<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmICT
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
        Me.dgvFrmICT = New System.Windows.Forms.DataGridView()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        CType(Me.dgvFrmICT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFrmICT
        '
        Me.dgvFrmICT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFrmICT.Location = New System.Drawing.Point(13, 70)
        Me.dgvFrmICT.Name = "dgvFrmICT"
        Me.dgvFrmICT.Size = New System.Drawing.Size(1115, 558)
        Me.dgvFrmICT.TabIndex = 0
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(13, 23)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(114, 41)
        Me.btnExportarExcel.TabIndex = 1
        Me.btnExportarExcel.Text = "Exportar a Excel"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'frmICT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 627)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.dgvFrmICT)
        Me.Name = "frmICT"
        Me.Text = "frmICT"
        CType(Me.dgvFrmICT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFrmICT As DataGridView
    Friend WithEvents btnExportarExcel As Button
End Class
