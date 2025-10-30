<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpleadoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelCargo = New System.Windows.Forms.Label()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.LabelSalario = New System.Windows.Forms.Label()
        Me.TextBoxSalario = New System.Windows.Forms.TextBox()
        Me.LabelDepartamento = New System.Windows.Forms.Label()
        Me.TextBoxDepartamento = New System.Windows.Forms.TextBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(12, 15)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(120, 15)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre Completo:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(138, 12)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxNombre.TabIndex = 1
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(12, 45)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(120, 15)
        Me.LabelFecha.TabIndex = 2
        Me.LabelFecha.Text = "Fecha de Contratación:"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(138, 42)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerFecha.TabIndex = 3
        '
        'LabelCargo
        '
        Me.LabelCargo.AutoSize = True
        Me.LabelCargo.Location = New System.Drawing.Point(12, 75)
        Me.LabelCargo.Name = "LabelCargo"
        Me.LabelCargo.Size = New System.Drawing.Size(40, 15)
        Me.LabelCargo.TabIndex = 4
        Me.LabelCargo.Text = "Cargo:"
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(138, 72)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxCargo.TabIndex = 5
        '
        'LabelSalario
        '
        Me.LabelSalario.AutoSize = True
        Me.LabelSalario.Location = New System.Drawing.Point(12, 105)
        Me.LabelSalario.Name = "LabelSalario"
        Me.LabelSalario.Size = New System.Drawing.Size(50, 15)
        Me.LabelSalario.TabIndex = 6
        Me.LabelSalario.Text = "Salario:"
        '
        'TextBoxSalario
        '
        Me.TextBoxSalario.Location = New System.Drawing.Point(138, 102)
        Me.TextBoxSalario.Name = "TextBoxSalario"
        Me.TextBoxSalario.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxSalario.TabIndex = 7
        '
        'LabelDepartamento
        '
        Me.LabelDepartamento.AutoSize = True
        Me.LabelDepartamento.Location = New System.Drawing.Point(12, 135)
        Me.LabelDepartamento.Name = "LabelDepartamento"
        Me.LabelDepartamento.Size = New System.Drawing.Size(85, 15)
        Me.LabelDepartamento.TabIndex = 8
        Me.LabelDepartamento.Text = "Departamento:"
        '
        'TextBoxDepartamento
        '
        Me.TextBoxDepartamento.Location = New System.Drawing.Point(138, 132)
        Me.TextBoxDepartamento.Name = "TextBoxDepartamento"
        Me.TextBoxDepartamento.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxDepartamento.TabIndex = 9
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(138, 165)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardar.TabIndex = 10
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(219, 165)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 11
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'EmpleadoForm
        '
        Me.AcceptButton = Me.ButtonGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(350, 200)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.TextBoxDepartamento)
        Me.Controls.Add(Me.LabelDepartamento)
        Me.Controls.Add(Me.TextBoxSalario)
        Me.Controls.Add(Me.LabelSalario)
        Me.Controls.Add(Me.TextBoxCargo)
        Me.Controls.Add(Me.LabelCargo)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmpleadoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelFecha As Label
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents LabelCargo As Label
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents LabelSalario As Label
    Friend WithEvents TextBoxSalario As TextBox
    Friend WithEvents LabelDepartamento As Label
    Friend WithEvents TextBoxDepartamento As TextBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonCancelar As Button
End Class