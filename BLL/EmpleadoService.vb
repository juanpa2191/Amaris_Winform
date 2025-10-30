Imports System.Collections.Generic

Public Class EmpleadoService
    Implements IEmpleadoService

    Private ReadOnly _repository As IEmpleadoRepository

    Public Sub New(repository As IEmpleadoRepository)
        _repository = repository
    End Sub

    Public Function ObtenerTodosLosEmpleados() As List(Of Empleado) Implements IEmpleadoService.ObtenerTodosLosEmpleados
        Return _repository.GetAll()
    End Function

    Public Function ObtenerEmpleadoPorId(id As Integer) As Empleado Implements IEmpleadoService.ObtenerEmpleadoPorId
        If id <= 0 Then Throw New ArgumentException("El ID debe ser mayor que cero.")
        Return _repository.GetById(id)
    End Function

    Public Function AgregarEmpleado(empleado As Empleado) As Integer Implements IEmpleadoService.AgregarEmpleado
        Dim errores As List(Of String) = ValidarEmpleado(empleado)
        If errores.Count > 0 Then Throw New ArgumentException(String.Join(Environment.NewLine, errores))
        Return _repository.Add(empleado)
    End Function

    Public Sub ActualizarEmpleado(empleado As Empleado) Implements IEmpleadoService.ActualizarEmpleado
        If empleado.ID <= 0 Then Throw New ArgumentException("El ID debe ser mayor que cero.")
        Dim errores As List(Of String) = ValidarEmpleado(empleado)
        If errores.Count > 0 Then Throw New ArgumentException(String.Join(Environment.NewLine, errores))
        _repository.Update(empleado)
    End Sub

    Public Sub EliminarEmpleado(id As Integer) Implements IEmpleadoService.EliminarEmpleado
        If id <= 0 Then Throw New ArgumentException("El ID debe ser mayor que cero.")
        _repository.Delete(id)
    End Sub

    Public Function BuscarEmpleados(terminoBusqueda As String) As List(Of Empleado) Implements IEmpleadoService.BuscarEmpleados
        If String.IsNullOrWhiteSpace(terminoBusqueda) Then Return _repository.GetAll()
        Return _repository.SearchByNameOrId(terminoBusqueda)
    End Function

    Public Function ValidarEmpleado(empleado As Empleado) As List(Of String) Implements IEmpleadoService.ValidarEmpleado
        Dim errores As New List(Of String)()

        If String.IsNullOrWhiteSpace(empleado.NombreCompleto) Then errores.Add("El nombre completo es obligatorio.")
        If empleado.NombreCompleto IsNot Nothing AndAlso empleado.NombreCompleto.Length > 100 Then errores.Add("El nombre completo no puede exceder 100 caracteres.")

        If empleado.FechaContratacion = Date.MinValue Then errores.Add("La fecha de contratación es obligatoria.")
        If empleado.FechaContratacion > Date.Today Then errores.Add("La fecha de contratación no puede ser futura.")

        If String.IsNullOrWhiteSpace(empleado.Cargo) Then errores.Add("El cargo es obligatorio.")
        If empleado.Cargo IsNot Nothing AndAlso empleado.Cargo.Length > 50 Then errores.Add("El cargo no puede exceder 50 caracteres.")

        If empleado.Salario <= 0 Then errores.Add("El salario debe ser mayor que cero.")
        If empleado.Salario > 999999.99D Then errores.Add("El salario no puede exceder 999,999.99.")

        If String.IsNullOrWhiteSpace(empleado.Departamento) Then errores.Add("El departamento es obligatorio.")
        If empleado.Departamento IsNot Nothing AndAlso empleado.Departamento.Length > 50 Then errores.Add("El departamento no puede exceder 50 caracteres.")

        Return errores
    End Function
End Class