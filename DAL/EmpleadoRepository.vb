Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class EmpleadoRepository
    Implements IEmpleadoRepository

    Public Function GetAll() As List(Of Empleado) Implements IEmpleadoRepository.GetAll
        Dim empleados As New List(Of Empleado)()
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "SELECT ID, NombreCompleto, FechaContratacion, Cargo, Salario, Departamento FROM Empleados"
            Using command As SqlCommand = New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        empleados.Add(New Empleado(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetDecimal(4),
                            reader.GetString(5)
                        ))
                    End While
                End Using
            End Using
        End Using
        Return empleados
    End Function

    Public Function GetById(id As Integer) As Empleado Implements IEmpleadoRepository.GetById
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "SELECT ID, NombreCompleto, FechaContratacion, Cargo, Salario, Departamento FROM Empleados WHERE ID = @ID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return New Empleado(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetDecimal(4),
                            reader.GetString(5)
                        )
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function Add(empleado As Empleado) As Integer Implements IEmpleadoRepository.Add
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "INSERT INTO Empleados (NombreCompleto, FechaContratacion, Cargo, Salario, Departamento) VALUES (@Nombre, @Fecha, @Cargo, @Salario, @Departamento); SELECT SCOPE_IDENTITY();"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", empleado.NombreCompleto)
                command.Parameters.AddWithValue("@Fecha", empleado.FechaContratacion)
                command.Parameters.AddWithValue("@Cargo", empleado.Cargo)
                command.Parameters.AddWithValue("@Salario", empleado.Salario)
                command.Parameters.AddWithValue("@Departamento", empleado.Departamento)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Sub Update(empleado As Empleado) Implements IEmpleadoRepository.Update
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "UPDATE Empleados SET NombreCompleto = @Nombre, FechaContratacion = @Fecha, Cargo = @Cargo, Salario = @Salario, Departamento = @Departamento WHERE ID = @ID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", empleado.ID)
                command.Parameters.AddWithValue("@Nombre", empleado.NombreCompleto)
                command.Parameters.AddWithValue("@Fecha", empleado.FechaContratacion)
                command.Parameters.AddWithValue("@Cargo", empleado.Cargo)
                command.Parameters.AddWithValue("@Salario", empleado.Salario)
                command.Parameters.AddWithValue("@Departamento", empleado.Departamento)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(id As Integer) Implements IEmpleadoRepository.Delete
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "DELETE FROM Empleados WHERE ID = @ID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function SearchByNameOrId(searchTerm As String) As List(Of Empleado) Implements IEmpleadoRepository.SearchByNameOrId
        Dim empleados As New List(Of Empleado)()
        Using connection As SqlConnection = DatabaseHelper.GetConnection()
            connection.Open()
            Dim query As String = "SELECT ID, NombreCompleto, FechaContratacion, Cargo, Salario, Departamento FROM Empleados WHERE NombreCompleto LIKE @Search OR CAST(ID AS NVARCHAR) LIKE @Search"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Search", "%" & searchTerm & "%")
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        empleados.Add(New Empleado(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetDecimal(4),
                            reader.GetString(5)
                        ))
                    End While
                End Using
            End Using
        End Using
        Return empleados
    End Function
End Class