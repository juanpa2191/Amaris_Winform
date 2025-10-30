Imports System.Collections.Generic

Public Class Form1
    Private ReadOnly _service As IEmpleadoService

    Public Sub New()
        InitializeComponent()
        DatabaseHelper.CreateDatabaseAndTable()
        _service = New EmpleadoService(New EmpleadoRepository())
        CargarEmpleados()
    End Sub

    Private Sub CargarEmpleados()
        Try
            Dim empleados As List(Of Empleado) = _service.ObtenerTodosLosEmpleados()
            DataGridViewEmpleados.DataSource = empleados
            ConfigurarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarDataGridView()
        DataGridViewEmpleados.Columns("ID").HeaderText = "ID"
        DataGridViewEmpleados.Columns("NombreCompleto").HeaderText = "Nombre Completo"
        DataGridViewEmpleados.Columns("FechaContratacion").HeaderText = "Fecha de Contratación"
        DataGridViewEmpleados.Columns("Cargo").HeaderText = "Cargo"
        DataGridViewEmpleados.Columns("Salario").HeaderText = "Salario"
        DataGridViewEmpleados.Columns("Departamento").HeaderText = "Departamento"

        DataGridViewEmpleados.Columns("FechaContratacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        DataGridViewEmpleados.Columns("Salario").DefaultCellStyle.Format = "C2"
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            Dim termino As String = TextBoxBuscar.Text.Trim()
            Dim empleados As List(Of Empleado) = _service.BuscarEmpleados(termino)
            DataGridViewEmpleados.DataSource = empleados
        Catch ex As Exception
            MessageBox.Show("Error al buscar empleados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Using form As New EmpleadoForm(_service)
            If form.ShowDialog() = DialogResult.OK Then
                CargarEmpleados()
            End If
        End Using
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        If DataGridViewEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim empleado As Empleado = CType(DataGridViewEmpleados.SelectedRows(0).DataBoundItem, Empleado)
        Using form As New EmpleadoForm(_service, empleado)
            If form.ShowDialog() = DialogResult.OK Then
                CargarEmpleados()
            End If
        End Using
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim empleado As Empleado = CType(DataGridViewEmpleados.SelectedRows(0).DataBoundItem, Empleado)
        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar al empleado '{empleado.NombreCompleto}'?",
                                                     "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                _service.EliminarEmpleado(empleado.ID)
                CargarEmpleados()
                MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
