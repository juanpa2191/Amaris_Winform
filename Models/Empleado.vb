Public Class Empleado
    Public Property ID As Integer
    Public Property NombreCompleto As String
    Public Property FechaContratacion As Date
    Public Property Cargo As String
    Public Property Salario As Decimal
    Public Property Departamento As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, fecha As Date, cargo As String, salario As Decimal, departamento As String)
        Me.ID = id
        Me.NombreCompleto = nombre
        Me.FechaContratacion = fecha
        Me.Cargo = cargo
        Me.Salario = salario
        Me.Departamento = departamento
    End Sub
End Class