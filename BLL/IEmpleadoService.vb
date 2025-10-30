Imports System.Collections.Generic

Public Interface IEmpleadoService
    Function ObtenerTodosLosEmpleados() As List(Of Empleado)
    Function ObtenerEmpleadoPorId(id As Integer) As Empleado
    Function AgregarEmpleado(empleado As Empleado) As Integer
    Sub ActualizarEmpleado(empleado As Empleado)
    Sub EliminarEmpleado(id As Integer)
    Function BuscarEmpleados(terminoBusqueda As String) As List(Of Empleado)
    Function ValidarEmpleado(empleado As Empleado) As List(Of String)
End Interface