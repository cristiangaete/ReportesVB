<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnBuscarDocumento = New System.Windows.Forms.Button()
        Me.ofdAbrirDocumento = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabReportes = New System.Windows.Forms.TabControl()
        Me.tabR196 = New System.Windows.Forms.TabPage()
        Me.btnAbrirICT = New System.Windows.Forms.Button()
        Me.dtpDesdeIct = New System.Windows.Forms.DateTimePicker()
        Me.dtgMostrar196 = New System.Windows.Forms.DataGridView()
        Me.btnGuardar1_96 = New System.Windows.Forms.Button()
        Me.dgvReporte196 = New System.Windows.Forms.DataGridView()
        Me.tabR22 = New System.Windows.Forms.TabPage()
        Me.btnVerRepo22 = New System.Windows.Forms.Button()
        Me.cboR2_2 = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvReporte22 = New System.Windows.Forms.DataGridView()
        Me.carga_indice = New System.Windows.Forms.TabPage()
        Me.btnVerICT = New System.Windows.Forms.Button()
        Me.cboTeoricoICT = New System.Windows.Forms.ComboBox()
        Me.btnTeoricoICT = New System.Windows.Forms.Button()
        Me.btnCargarIndice = New System.Windows.Forms.Button()
        Me.dgvIndice = New System.Windows.Forms.DataGridView()
        Me.cargar_plaza = New System.Windows.Forms.TabPage()
        Me.btnEliminarPlaza = New System.Windows.Forms.Button()
        Me.btnInsertarPlaza = New System.Windows.Forms.Button()
        Me.btnActualizaDatos = New System.Windows.Forms.Button()
        Me.btnMostrarPlaza = New System.Windows.Forms.Button()
        Me.btnCargarPlaza = New System.Windows.Forms.Button()
        Me.dgvPlaza = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEliminarFeriado = New System.Windows.Forms.Button()
        Me.btnVerFechas = New System.Windows.Forms.Button()
        Me.btnferiados = New System.Windows.Forms.Button()
        Me.cboFeriado = New System.Windows.Forms.ComboBox()
        Me.txtFeriado = New System.Windows.Forms.TextBox()
        Me.dtpferiado = New System.Windows.Forms.DateTimePicker()
        Me.dgvferiados = New System.Windows.Forms.DataGridView()
        Me.ofdExcel = New System.Windows.Forms.OpenFileDialog()
        Me.tabReportes.SuspendLayout()
        Me.tabR196.SuspendLayout()
        CType(Me.dtgMostrar196, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReporte196, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabR22.SuspendLayout()
        CType(Me.dgvReporte22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.carga_indice.SuspendLayout()
        CType(Me.dgvIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cargar_plaza.SuspendLayout()
        CType(Me.dgvPlaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvferiados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarDocumento
        '
        Me.btnBuscarDocumento.Location = New System.Drawing.Point(45, 26)
        Me.btnBuscarDocumento.Name = "btnBuscarDocumento"
        Me.btnBuscarDocumento.Size = New System.Drawing.Size(154, 42)
        Me.btnBuscarDocumento.TabIndex = 0
        Me.btnBuscarDocumento.Text = "Buscar"
        Me.btnBuscarDocumento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archivo"
        '
        'tabReportes
        '
        Me.tabReportes.Controls.Add(Me.tabR196)
        Me.tabReportes.Controls.Add(Me.tabR22)
        Me.tabReportes.Controls.Add(Me.carga_indice)
        Me.tabReportes.Controls.Add(Me.cargar_plaza)
        Me.tabReportes.Controls.Add(Me.TabPage1)
        Me.tabReportes.Location = New System.Drawing.Point(0, 89)
        Me.tabReportes.Name = "tabReportes"
        Me.tabReportes.SelectedIndex = 0
        Me.tabReportes.Size = New System.Drawing.Size(1124, 469)
        Me.tabReportes.TabIndex = 2
        '
        'tabR196
        '
        Me.tabR196.Controls.Add(Me.btnAbrirICT)
        Me.tabR196.Controls.Add(Me.dtpDesdeIct)
        Me.tabR196.Controls.Add(Me.dtgMostrar196)
        Me.tabR196.Controls.Add(Me.btnGuardar1_96)
        Me.tabR196.Controls.Add(Me.dgvReporte196)
        Me.tabR196.Location = New System.Drawing.Point(4, 22)
        Me.tabR196.Name = "tabR196"
        Me.tabR196.Padding = New System.Windows.Forms.Padding(3)
        Me.tabR196.Size = New System.Drawing.Size(1116, 443)
        Me.tabR196.TabIndex = 0
        Me.tabR196.Text = "Reporte 1.96"
        Me.tabR196.UseVisualStyleBackColor = True
        '
        'btnAbrirICT
        '
        Me.btnAbrirICT.Location = New System.Drawing.Point(970, 189)
        Me.btnAbrirICT.Name = "btnAbrirICT"
        Me.btnAbrirICT.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirICT.TabIndex = 4
        Me.btnAbrirICT.Text = "Generar ICT"
        Me.btnAbrirICT.UseVisualStyleBackColor = True
        '
        'dtpDesdeIct
        '
        Me.dtpDesdeIct.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeIct.Location = New System.Drawing.Point(842, 192)
        Me.dtpDesdeIct.Name = "dtpDesdeIct"
        Me.dtpDesdeIct.Size = New System.Drawing.Size(97, 20)
        Me.dtpDesdeIct.TabIndex = 3
        '
        'dtgMostrar196
        '
        Me.dtgMostrar196.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMostrar196.Location = New System.Drawing.Point(805, 20)
        Me.dtgMostrar196.Name = "dtgMostrar196"
        Me.dtgMostrar196.Size = New System.Drawing.Size(240, 150)
        Me.dtgMostrar196.TabIndex = 2
        '
        'btnGuardar1_96
        '
        Me.btnGuardar1_96.Location = New System.Drawing.Point(733, 402)
        Me.btnGuardar1_96.Name = "btnGuardar1_96"
        Me.btnGuardar1_96.Size = New System.Drawing.Size(101, 34)
        Me.btnGuardar1_96.TabIndex = 1
        Me.btnGuardar1_96.Text = "Guardar1.96"
        Me.btnGuardar1_96.UseVisualStyleBackColor = True
        '
        'dgvReporte196
        '
        Me.dgvReporte196.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte196.Location = New System.Drawing.Point(0, 0)
        Me.dgvReporte196.Name = "dgvReporte196"
        Me.dgvReporte196.Size = New System.Drawing.Size(726, 443)
        Me.dgvReporte196.TabIndex = 0
        '
        'tabR22
        '
        Me.tabR22.Controls.Add(Me.btnVerRepo22)
        Me.tabR22.Controls.Add(Me.cboR2_2)
        Me.tabR22.Controls.Add(Me.btnGuardar)
        Me.tabR22.Controls.Add(Me.dgvReporte22)
        Me.tabR22.Location = New System.Drawing.Point(4, 22)
        Me.tabR22.Name = "tabR22"
        Me.tabR22.Padding = New System.Windows.Forms.Padding(3)
        Me.tabR22.Size = New System.Drawing.Size(1116, 443)
        Me.tabR22.TabIndex = 1
        Me.tabR22.Text = "Reporte 2.2"
        Me.tabR22.UseVisualStyleBackColor = True
        '
        'btnVerRepo22
        '
        Me.btnVerRepo22.Location = New System.Drawing.Point(1036, 33)
        Me.btnVerRepo22.Name = "btnVerRepo22"
        Me.btnVerRepo22.Size = New System.Drawing.Size(75, 23)
        Me.btnVerRepo22.TabIndex = 3
        Me.btnVerRepo22.Text = "Ver"
        Me.btnVerRepo22.UseVisualStyleBackColor = True
        '
        'cboR2_2
        '
        Me.cboR2_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboR2_2.FormattingEnabled = True
        Me.cboR2_2.Location = New System.Drawing.Point(864, 36)
        Me.cboR2_2.Name = "cboR2_2"
        Me.cboR2_2.Size = New System.Drawing.Size(145, 21)
        Me.cboR2_2.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(826, 413)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar2.2"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgvReporte22
        '
        Me.dgvReporte22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte22.Location = New System.Drawing.Point(0, 0)
        Me.dgvReporte22.Name = "dgvReporte22"
        Me.dgvReporte22.Size = New System.Drawing.Size(807, 447)
        Me.dgvReporte22.TabIndex = 0
        '
        'carga_indice
        '
        Me.carga_indice.Controls.Add(Me.btnVerICT)
        Me.carga_indice.Controls.Add(Me.cboTeoricoICT)
        Me.carga_indice.Controls.Add(Me.btnTeoricoICT)
        Me.carga_indice.Controls.Add(Me.btnCargarIndice)
        Me.carga_indice.Controls.Add(Me.dgvIndice)
        Me.carga_indice.Location = New System.Drawing.Point(4, 22)
        Me.carga_indice.Name = "carga_indice"
        Me.carga_indice.Size = New System.Drawing.Size(1116, 443)
        Me.carga_indice.TabIndex = 2
        Me.carga_indice.Text = "Carga Indices Teoricos"
        Me.carga_indice.UseVisualStyleBackColor = True
        '
        'btnVerICT
        '
        Me.btnVerICT.Location = New System.Drawing.Point(908, 98)
        Me.btnVerICT.Name = "btnVerICT"
        Me.btnVerICT.Size = New System.Drawing.Size(75, 23)
        Me.btnVerICT.TabIndex = 4
        Me.btnVerICT.Text = "Ver"
        Me.btnVerICT.UseVisualStyleBackColor = True
        '
        'cboTeoricoICT
        '
        Me.cboTeoricoICT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeoricoICT.FormattingEnabled = True
        Me.cboTeoricoICT.Location = New System.Drawing.Point(635, 101)
        Me.cboTeoricoICT.Name = "cboTeoricoICT"
        Me.cboTeoricoICT.Size = New System.Drawing.Size(183, 21)
        Me.cboTeoricoICT.TabIndex = 3
        '
        'btnTeoricoICT
        '
        Me.btnTeoricoICT.Location = New System.Drawing.Point(908, 4)
        Me.btnTeoricoICT.Name = "btnTeoricoICT"
        Me.btnTeoricoICT.Size = New System.Drawing.Size(100, 42)
        Me.btnTeoricoICT.TabIndex = 2
        Me.btnTeoricoICT.Text = "Guardar TeoricoICT"
        Me.btnTeoricoICT.UseVisualStyleBackColor = True
        '
        'btnCargarIndice
        '
        Me.btnCargarIndice.Location = New System.Drawing.Point(634, 4)
        Me.btnCargarIndice.Name = "btnCargarIndice"
        Me.btnCargarIndice.Size = New System.Drawing.Size(112, 42)
        Me.btnCargarIndice.TabIndex = 1
        Me.btnCargarIndice.Text = "Cargar Teorico"
        Me.btnCargarIndice.UseVisualStyleBackColor = True
        '
        'dgvIndice
        '
        Me.dgvIndice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIndice.Location = New System.Drawing.Point(4, 4)
        Me.dgvIndice.Name = "dgvIndice"
        Me.dgvIndice.Size = New System.Drawing.Size(624, 439)
        Me.dgvIndice.TabIndex = 0
        '
        'cargar_plaza
        '
        Me.cargar_plaza.Controls.Add(Me.btnEliminarPlaza)
        Me.cargar_plaza.Controls.Add(Me.btnInsertarPlaza)
        Me.cargar_plaza.Controls.Add(Me.btnActualizaDatos)
        Me.cargar_plaza.Controls.Add(Me.btnMostrarPlaza)
        Me.cargar_plaza.Controls.Add(Me.btnCargarPlaza)
        Me.cargar_plaza.Controls.Add(Me.dgvPlaza)
        Me.cargar_plaza.Location = New System.Drawing.Point(4, 22)
        Me.cargar_plaza.Name = "cargar_plaza"
        Me.cargar_plaza.Size = New System.Drawing.Size(1116, 443)
        Me.cargar_plaza.TabIndex = 3
        Me.cargar_plaza.Text = " Plaza"
        Me.cargar_plaza.UseVisualStyleBackColor = True
        '
        'btnEliminarPlaza
        '
        Me.btnEliminarPlaza.Location = New System.Drawing.Point(738, 135)
        Me.btnEliminarPlaza.Name = "btnEliminarPlaza"
        Me.btnEliminarPlaza.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarPlaza.TabIndex = 5
        Me.btnEliminarPlaza.Text = "Eliminar"
        Me.btnEliminarPlaza.UseVisualStyleBackColor = True
        '
        'btnInsertarPlaza
        '
        Me.btnInsertarPlaza.Location = New System.Drawing.Point(622, 135)
        Me.btnInsertarPlaza.Name = "btnInsertarPlaza"
        Me.btnInsertarPlaza.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarPlaza.TabIndex = 4
        Me.btnInsertarPlaza.Text = "Insertar"
        Me.btnInsertarPlaza.UseVisualStyleBackColor = True
        '
        'btnActualizaDatos
        '
        Me.btnActualizaDatos.Location = New System.Drawing.Point(486, 135)
        Me.btnActualizaDatos.Name = "btnActualizaDatos"
        Me.btnActualizaDatos.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizaDatos.TabIndex = 3
        Me.btnActualizaDatos.Text = "Actualizar"
        Me.btnActualizaDatos.UseVisualStyleBackColor = True
        '
        'btnMostrarPlaza
        '
        Me.btnMostrarPlaza.Location = New System.Drawing.Point(730, 4)
        Me.btnMostrarPlaza.Name = "btnMostrarPlaza"
        Me.btnMostrarPlaza.Size = New System.Drawing.Size(84, 35)
        Me.btnMostrarPlaza.TabIndex = 2
        Me.btnMostrarPlaza.Text = "Ver datos"
        Me.btnMostrarPlaza.UseVisualStyleBackColor = True
        '
        'btnCargarPlaza
        '
        Me.btnCargarPlaza.Location = New System.Drawing.Point(486, 4)
        Me.btnCargarPlaza.Name = "btnCargarPlaza"
        Me.btnCargarPlaza.Size = New System.Drawing.Size(118, 35)
        Me.btnCargarPlaza.TabIndex = 1
        Me.btnCargarPlaza.Text = "Cargar Plaza"
        Me.btnCargarPlaza.UseVisualStyleBackColor = True
        '
        'dgvPlaza
        '
        Me.dgvPlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlaza.Location = New System.Drawing.Point(4, 4)
        Me.dgvPlaza.Name = "dgvPlaza"
        Me.dgvPlaza.Size = New System.Drawing.Size(475, 439)
        Me.dgvPlaza.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnEliminarFeriado)
        Me.TabPage1.Controls.Add(Me.btnVerFechas)
        Me.TabPage1.Controls.Add(Me.btnferiados)
        Me.TabPage1.Controls.Add(Me.cboFeriado)
        Me.TabPage1.Controls.Add(Me.txtFeriado)
        Me.TabPage1.Controls.Add(Me.dtpferiado)
        Me.TabPage1.Controls.Add(Me.dgvferiados)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1116, 443)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Feriados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnEliminarFeriado
        '
        Me.btnEliminarFeriado.Location = New System.Drawing.Point(517, 233)
        Me.btnEliminarFeriado.Name = "btnEliminarFeriado"
        Me.btnEliminarFeriado.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarFeriado.TabIndex = 6
        Me.btnEliminarFeriado.Text = "Eliminar"
        Me.btnEliminarFeriado.UseVisualStyleBackColor = True
        '
        'btnVerFechas
        '
        Me.btnVerFechas.Location = New System.Drawing.Point(791, 141)
        Me.btnVerFechas.Name = "btnVerFechas"
        Me.btnVerFechas.Size = New System.Drawing.Size(75, 23)
        Me.btnVerFechas.TabIndex = 5
        Me.btnVerFechas.Text = "Ver Fechas"
        Me.btnVerFechas.UseVisualStyleBackColor = True
        '
        'btnferiados
        '
        Me.btnferiados.Location = New System.Drawing.Point(517, 141)
        Me.btnferiados.Name = "btnferiados"
        Me.btnferiados.Size = New System.Drawing.Size(75, 23)
        Me.btnferiados.TabIndex = 4
        Me.btnferiados.Text = "Guardar"
        Me.btnferiados.UseVisualStyleBackColor = True
        '
        'cboFeriado
        '
        Me.cboFeriado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFeriado.FormattingEnabled = True
        Me.cboFeriado.Location = New System.Drawing.Point(791, 42)
        Me.cboFeriado.Name = "cboFeriado"
        Me.cboFeriado.Size = New System.Drawing.Size(121, 21)
        Me.cboFeriado.TabIndex = 3
        '
        'txtFeriado
        '
        Me.txtFeriado.Location = New System.Drawing.Point(638, 42)
        Me.txtFeriado.Name = "txtFeriado"
        Me.txtFeriado.ReadOnly = True
        Me.txtFeriado.Size = New System.Drawing.Size(100, 20)
        Me.txtFeriado.TabIndex = 2
        '
        'dtpferiado
        '
        Me.dtpferiado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpferiado.Location = New System.Drawing.Point(506, 42)
        Me.dtpferiado.Name = "dtpferiado"
        Me.dtpferiado.Size = New System.Drawing.Size(98, 20)
        Me.dtpferiado.TabIndex = 1
        '
        'dgvferiados
        '
        Me.dgvferiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvferiados.Location = New System.Drawing.Point(4, 4)
        Me.dgvferiados.Name = "dgvferiados"
        Me.dgvferiados.Size = New System.Drawing.Size(495, 439)
        Me.dgvferiados.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 559)
        Me.Controls.Add(Me.tabReportes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscarDocumento)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabReportes.ResumeLayout(False)
        Me.tabR196.ResumeLayout(False)
        CType(Me.dtgMostrar196, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReporte196, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabR22.ResumeLayout(False)
        CType(Me.dgvReporte22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.carga_indice.ResumeLayout(False)
        CType(Me.dgvIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cargar_plaza.ResumeLayout(False)
        CType(Me.dgvPlaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvferiados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarDocumento As Button
    Friend WithEvents ofdAbrirDocumento As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents tabReportes As TabControl
    Friend WithEvents tabR196 As TabPage
    Friend WithEvents tabR22 As TabPage
    Friend WithEvents carga_indice As TabPage
    Friend WithEvents cargar_plaza As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAbrirICT As Button
    Friend WithEvents dtpDesdeIct As DateTimePicker
    Friend WithEvents dtgMostrar196 As DataGridView
    Friend WithEvents btnGuardar1_96 As Button
    Friend WithEvents dgvReporte196 As DataGridView
    Friend WithEvents cboR2_2 As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvReporte22 As DataGridView
    Friend WithEvents btnVerRepo22 As Button
    Friend WithEvents btnVerICT As Button
    Friend WithEvents cboTeoricoICT As ComboBox
    Friend WithEvents btnTeoricoICT As Button
    Friend WithEvents btnCargarIndice As Button
    Friend WithEvents dgvIndice As DataGridView
    Friend WithEvents btnEliminarPlaza As Button
    Friend WithEvents btnInsertarPlaza As Button
    Friend WithEvents btnActualizaDatos As Button
    Friend WithEvents btnMostrarPlaza As Button
    Friend WithEvents btnCargarPlaza As Button
    Friend WithEvents dgvPlaza As DataGridView
    Friend WithEvents cboFeriado As ComboBox
    Friend WithEvents txtFeriado As TextBox
    Friend WithEvents dtpferiado As DateTimePicker
    Friend WithEvents dgvferiados As DataGridView
    Friend WithEvents btnEliminarFeriado As Button
    Friend WithEvents btnVerFechas As Button
    Friend WithEvents btnferiados As Button
    Friend WithEvents ofdExcel As OpenFileDialog
End Class
