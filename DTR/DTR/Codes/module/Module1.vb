Imports MySql.Data.MySqlClient
Module Module1
    Public query As String
    Public read As String
    Public ctrl As New Controller

    Public Function Con() As MySqlConnection

        Con = New MySqlConnection()
        Con.ConnectionString = "server=localhost;" _
            & "user id=root;" _
            & "password=;" _
            & "database="

        Con.Open()
        Return Con

    End Function
End Module
