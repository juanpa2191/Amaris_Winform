<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DataGridViewEmpleados = New System.Windows.Forms.DataGridView()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewEmpleados
        '
        Me.DataGridViewEmpleados.AllowUserToAddRows = False
        Me.DataGridViewEmpleados.AllowUserToDeleteRows = False
        Me.DataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpleados.Location = New System.Drawing.Point(12, 70)
        Me.DataGridViewEmpleados.Name = "DataGridViewEmpleados"
        Me.DataGridViewEmpleados.ReadOnly = True
        Me.DataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmpleados.Size = New System.Drawing.Size(776, 368)
        Me.DataGridViewEmpleados.TabIndex = 0
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(100, 12)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxBuscar.TabIndex = 1
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(306, 12)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(12, 41)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 3
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(93, 41)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 4
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(174, 41)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 5
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Location = New System.Drawing.Point(12, 15)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(82, 15)
        Me.LabelBuscar.TabIndex = 6
        Me.LabelBuscar.Text = "Buscar por ID o Nombre:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelBuscar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.DataGridViewEmpleados)
        Me.Name = "Form1"
        Me.Text = "Sistema de Gestión de Empleados"
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents DataGridViewEmpleados As DataGridView
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents LabelBuscar As Label

End Class
