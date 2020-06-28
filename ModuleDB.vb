Imports System.Data
Imports System.Data.OleDb
Module ModuleDB

    Public Function GetConnectionAccess() As OleDbConnection
        Dim sql As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\workspace-vstudio\PetPack\banco\petPack_2002.mdb"
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
                End Try
            End Using
        End Sub
End Module
