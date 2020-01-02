Imports System
Imports System.Net

Public Class Main
    Private Sub DownloadFile_Click(sender As Object, e As EventArgs) Handles DownloadFile.Click
        Dim client As New WebClient()
        Dim link As String = MyLink.Text
        Dim filename As String = MyFileName.Text
        Dim extension As String = MyExtension.Text

        client.DownloadFile(link, filename + extension)
    End Sub
End Class
