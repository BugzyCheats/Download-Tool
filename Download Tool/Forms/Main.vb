Imports System.Net

Public Class Main
    Private Sub DownloadFile_Click(sender As Object, e As EventArgs) Handles DownloadFile.Click
        Dim client As New WebClient()
        Dim download As Boolean = True
        Dim link As String = MyLink.Text
        Dim filename As String = MyFileName.Text
        Dim extension As String = "." + MyExtension.Text
        Dim result As String = (filename + extension)

        client.DownloadFile(link, filename + extension)
        client.Dispose()

        MsgBox("Downloaded " + result + " Successfully", MsgBoxStyle.Information, "Download Tool")
    End Sub
End Class