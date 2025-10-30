Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private Shared ReadOnly connectionString As String = "Server=localhost;Database=SistemaGestionEmpleados;Trusted_Connection=True;"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Public Shared Sub CreateDatabaseAndTable()
        Using connection As SqlConnection = New SqlConnection("Server=localhost;Trusted_Connection=True;")
            connection.Open()
            Dim createDbQuery As String = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'SistemaGestionEmpleados') CREATE DATABASE SistemaGestionEmpleados"
            Using command As SqlCommand = New SqlCommand(createDbQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using

        Using connection As SqlConnection = GetConnection()
            connection.Open()
            Dim createTableQuery As String = "
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Empleados' AND xtype='U')
                CREATE TABLE Empleados (
                    ID INT IDENTITY(1,1) PRIMARY KEY,
                    NombreCompleto NVARCHAR(100) NOT NULL,
                    FechaContratacion DATE NOT NULL,
                    Cargo NVARCHAR(50) NOT NULL,
                    Salario DECIMAL(10,2) NOT NULL,
                    Departamento NVARCHAR(50) NOT NULL
                )"
            Using command As SqlCommand = New SqlCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class