<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarPlaza
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
        Me.txtNumeroInterno = New System.Windows.Forms.TextBox()
        Me.txtPPU = New System.Windows.Forms.TextBox()
        Me.txtPlaza = New System.Windows.Forms.TextBox()
        Me.btnActualizarPlaza = New System.Windows.Forms.Button()
        Me.ErrorActualizarPlaza = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorActualizarPlaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'txtNumeroInterno
        '
        Me.txtNumeroInterno.Location = New System.Drawing.Point(158, 39)
        Me.txtNumeroInterno.Name = "txtNumeroInterno"
        Me.txtNumeroInterno.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroInterno.TabIndex = 3
        '
        'txtPPU
        '
        Me.txtPPU.Location = New System.Drawing.Point(158, 115)
        Me.txtPPU.Name = "txtPPU"
        Me.txtPPU.Size = New System.Drawing.Size(100, 20)
        Me.txtPPU.TabIndex = 4
        '
        'txtPlaza
        '
        Me.txtPlaza.Location = New System.Drawing.Point(158, 178)
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.Size = New System.Drawing.Size(100, 20)
        Me.txtPlaza.TabIndex = 5
        '
        'btnActualizarPlaza
        '
        Me.btnActualizarPlaza.Location = New System.Drawing.Point(574, 241)
        Me.btnActualizarPlaza.Name = "btnActualizarPlaza"
        Me.btnActualizarPlaza.Size = New System.Drawing.Size(86, 39)
        Me.btnActualizarPlaza.TabIndex = 6
        Me.btnActualizarPlaza.Text = "Actualizar"
        Me.btnActualizarPlaza.UseVisualStyleBackColor = True
        '
        'ErrorActualizarPlaza
        '
        Me.ErrorActualizarPlaza.ContainerControl = Me
        '
        'frmActualizarPlaza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 342)
        Me.Controls.Add(Me.btnActualizarPlaza)
        Me.Controls.Add(Me.txtPlaza)
        Me.Controls.Add(Me.txtPPU)
        Me.Controls.Add(Me.txtNumeroInterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmActualizarPlaza"
        Me.Text = "Actualizar Datos"
        CType(Me.ErrorActualizarPlaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumeroInterno As TextBox
    Friend WithEvents txtPPU As TextBox
    Friend WithEvents txtPlaza As TextBox
    Friend WithEvents btnActualizarPlaza As Button
    Friend WithEvents ErrorActualizarPlaza As ErrorProvider
End Class
