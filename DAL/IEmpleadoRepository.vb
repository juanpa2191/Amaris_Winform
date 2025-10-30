Imports System.Collections.Generic

Public Interface IEmpleadoRepository
    Function GetAll() As List(Of Empleado)
    Function GetById(id As Integer) As Empleado
    Function Add(empleado As Empleado) As Integer
    Sub Update(empleado As Empleado)
    Sub Delete(id As Integer)
    Function SearchByNameOrId(searchTerm As String) As List(Of Empleado)
End Interface