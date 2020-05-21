<AttributeUsage(AttributeTargets.Class, Inherited:=False, AllowMultiple:=True)>
Public Class AttributTable
    Inherits Attribute

    Public Property Name As String

    Public Sub New(name As String)
        Me.Name = name
    End Sub

End Class
