Imports System.Reflection

Public MustInherit Class EntityDB

    Public ReadOnly Property TableName As String
        Get
            Return [GetType].GetCustomAttribute(Of AttributTable)().Name
        End Get
    End Property

    Public ReadOnly Property PropertyList As PropertyInfo()
        Get
            Return [GetType].GetProperties().Where(Function(t) Attribute.IsDefined(t, GetType(AttributProperty)))
        End Get
    End Property

End Class
