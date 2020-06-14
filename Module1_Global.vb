Imports MySql.Data.MySqlClient
Module Module1_Global

    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Public Sub ConnectToMySql()
        '  Try
        ' Dim connection As New MySqlConnection("server=localhost;port=3306;username=root;password=password1234;database=petPack")
        ' MsgBox("connection was successfully established", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

        ' Catch ex As Exception
        'MsgBox("Could not open a connection to MySQL", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")

        ' End Try

        Dim conn As MySqlConnection

        conn = New MySqlConnection


        conn.ConnectionString = "server=localhost;user id=admin;password=password1234;database=petPack"


        SQL = "SELECT * FROM animais"


        Try

            conn.Open()

            Try

                myCommand.Connection = conn

                myCommand.CommandText = SQL

                myAdapter.SelectCommand = myCommand

                myAdapter.Fill(myData)

                'DataGrid1.DataSource = myData

            Catch myerro As MySqlException

                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)

            End Try

            MessageBox.Show("Conexão aberta com sucesso")

            conn.Close()

        Catch myerro As MySqlException

            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)

        Finally

            conn.Dispose()

        End Try

    End Sub
End Module
