Imports System.Data
Imports System.Data.OleDb
Module ModuleDB
    Public sql As String
    Public cm As OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public db As OleDbConnection
    Public adapt As OleDbDataAdapter
    Public tbl As DataTable
    Public ds As New DataSet

    Public Function GetConnectionAccess() As OleDbConnection
        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\willi\Desktop\raq\PetPack\PetPack\bin\Debug\banco\petPack_2002.mdb"
        Return New OleDbConnection(sql)
    End Function

    Public Sub carrega_banco()
            Using con As OleDbConnection = GetConnectionAccess()
            Try
                con.Open()
                Dim sql As String = "select * from cadastroClientes"
                MsgBox("Conexão bem sucedida!!!")
            Catch ex As Exception
                MsgBox("Falha ao conectar!!!")
            Finally
                con.Close()
            End Try
        End Using
        End Sub
End Module
