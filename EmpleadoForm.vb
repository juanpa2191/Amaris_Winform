Public Class EmpleadoForm
    Private ReadOnly _service As IEmpleadoService
    Private ReadOnly _empleado As Empleado

    Public Sub New(service As IEmpleadoService, Optional empleado As Empleado = Nothing)
        InitializeComponent()
        _service = service
        _empleado = empleado

        If _empleado IsNot Nothing Then
            CargarDatosEmpleado()
            Me.Text = "Editar Empleado"
        Else
            Me.Text = "Agregar Empleado"
        End If
    End Sub

    Private Sub CargarDatosEmpleado()
        TextBoxNombre.Text = _empleado.NombreCompleto
        DateTimePickerFecha.Value = _empleado.FechaContratacion
        TextBoxCargo.Text = _empleado.Cargo
        TextBoxSalario.Text = _empleado.Salario.ToString()
        TextBoxDepartamento.Text = _empleado.Departamento
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            Dim empleado As New Empleado()

            If _empleado IsNot Nothing Then
                empleado.ID = _empleado.ID
            End If

            empleado.NombreCompleto = TextBoxNombre.Text.Trim()
            empleado.FechaContratacion = DateTimePickerFecha.Value.Date
            empleado.Cargo = TextBoxCargo.Text.Trim()
            empleado.Departamento = TextBoxDepartamento.Text.Trim()

            If Not Decimal.TryParse(TextBoxSalario.Text.Trim(), empleado.Salario) Then
                MessageBox.Show("El salario debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If _empleado Is Nothing Then
                _service.AgregarEmpleado(empleado)
                MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _service.ActualizarEmpleado(empleado)
                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al guardar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class