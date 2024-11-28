Imports System.IO

Module ConnectDBfromTXT

    Public Function ConnectDB()
        Try
            Dim filename As String = Path.Combine(Directory.GetCurrentDirectory(), "config", "databaseConnector.txt")

            If Not File.Exists(filename) Then
                Throw New FileNotFoundException($"The file '{filename}' does not exist.")
            End If

            Dim content As String = ""

            ' Read the file content
            Using TextReader As New StreamReader(filename)
                content = TextReader.ReadToEnd()
            End Using

            ' Process the content as needed
            MsgBox("File read successfully. Content: " & vbCrLf & content, MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

End Module
