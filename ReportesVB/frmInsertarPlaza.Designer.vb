<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertarPlaza
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInsertarNumeroInterno = New System.Windows.Forms.TextBox()
        Me.txtPPUInsert = New System.Windows.Forms.TextBox()
        Me.txtPlazaInsertar = New System.Windows.Forms.TextBox()
        Me.btnInsertarPlaza = New System.Windows.Forms.Button()
        Me.ErrorInsertarPlaza = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorInsertarPlaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Interno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plaza"
        '
        'txtInsertarNumeroInterno
        '
        Me.txtInsertarNumeroInterno.Location = New System.Drawing.Point(172, 43)
        Me.txtInsertarNumeroInterno.Name = "txtInsertarNumeroInterno"
        Me.txtInsertarNumeroInterno.Size = New System.Drawing.Size(100, 20)
        Me.txtInsertarNumeroInterno.TabIndex = 3
        '
        'txtPPUInsert
        '
        Me.txtPPUInsert.Location = New System.Drawing.Point(172, 120)
        Me.txtPPUInsert.Name = "txtPPUInsert"
        Me.txtPPUInsert.Size = New System.Drawing.Size(100, 20)
        Me.txtPPUInsert.TabIndex = 4
        '
        'txtPlazaInsertar
        '
        Me.txtPlazaInsertar.Location = New System.Drawing.Point(172, 196)
        Me.txtPlazaInsertar.Name = "txtPlazaInsertar"
        Me.txtPlazaInsertar.Size = New System.Drawing.Size(100, 20)
        Me.txtPlazaInsertar.TabIndex = 5
        '
        'btnInsertarPlaza
        '
        Me.btnInsertarPlaza.Location = New System.Drawing.Point(398, 273)
        Me.btnInsertarPlaza.Name = "btnInsertarPlaza"
        Me.btnInsertarPlaza.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarPlaza.TabIndex = 6
        Me.btnInsertarPlaza.Text = "Insertar"
        Me.btnInsertarPlaza.UseVisualStyleBackColor = True
        '
        'ErrorInsertarPlaza
        '
        Me.ErrorInsertarPlaza.ContainerControl = Me
        '
        'frmInsertarPlaza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 327)
        Me.Controls.Add(Me.btnInsertarPlaza)
        Me.Controls.Add(Me.txtPlazaInsertar)
        Me.Controls.Add(Me.txtPPUInsert)
        Me.Controls.Add(Me.txtInsertarNumeroInterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsertarPlaza"
        Me.Text = "frmInsertarPlaza"
        CType(Me.ErrorInsertarPlaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInsertarNumeroInterno As TextBox
    Friend WithEvents txtPPUInsert As TextBox
    Friend WithEvents txtPlazaInsertar As TextBox
    Friend WithEvents btnInsertarPlaza As Button
    Friend WithEvents ErrorInsertarPlaza As ErrorProvider
End Class
