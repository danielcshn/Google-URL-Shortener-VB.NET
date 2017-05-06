Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1

    ' You can obtain a free key from the API Console which is recommended
    ' so that you can Do 1.000.000 queries a day!
    ' https://console.developers.google.com/apis/
    ' Search "URL Shortener API"
    ' Clic "Enable"
    ' Copy your Key: https://console.developers.google.com/apis/credentials
    '
    ' More Info: http://code.google.com/apis/urlshortener/

    Private Const key As String = "<API-GOOGLE>"

    Dim lastKey As String = ""

    Public Shared Function Shorten(url As String) As String
        Dim post As String = (Convert.ToString("{""longUrl"": """) & url) + """}"
        Dim shortUrl As String = url
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(Convert.ToString("https://www.googleapis.com/urlshortener/v1/url?key=") & key), HttpWebRequest)

        Try
            request.ServicePoint.Expect100Continue = False
            request.Method = "POST"
            request.ContentLength = post.Length
            request.ContentType = "application/json"
            request.Headers.Add("Cache-Control", "no-cache")

            Using requestStream As Stream = request.GetRequestStream()
                Dim postBuffer As Byte() = Encoding.ASCII.GetBytes(post)
                requestStream.Write(postBuffer, 0, postBuffer.Length)
            End Using

            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    Using responseReader As New StreamReader(responseStream)
                        Dim json As String = responseReader.ReadToEnd()
                        shortUrl = Regex.Match(json, """id"": ?""(?<id>.+)""").Groups("id").Value
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' if Google's URL Shortner is down...
            System.Diagnostics.Debug.WriteLine(ex.Message)
            System.Diagnostics.Debug.WriteLine(ex.StackTrace)
        End Try
        Form1.lastKey = shortUrl
        Return shortUrl
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Google URL Shortener v" + Application.ProductVersion
        CaptureLink.Enabled = True
    End Sub

    Private Sub btnShorten_Click(sender As Object, e As EventArgs) Handles btnShorten.Click
        If txtURL.Text.Contains("http") Then
            ' Shorten URL:
            txtShort.Text = Shorten(txtURL.Text)
        Else
            MessageBox.Show("You must enter a valid URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtURL.Text = "" ' Clean txtURL.
            txtURL.Focus() ' Another Focus Option: txtURL.Select()
        End If
    End Sub

    Private Sub btn_Paste_Click(sender As Object, e As EventArgs) Handles btn_Paste.Click
        ' Paste URL.-
        txtURL.Text = Clipboard.GetText()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If txtShort.Text Is Nothing Then
        Else
            ' Copy Short URL to Clipboard.-
            My.Computer.Clipboard.SetText(txtShort.Text)
        End If
    End Sub

    Public Sub autoClipBoardText()
        Dim Cliptxt As String = My.Computer.Clipboard.GetText()
        If (Cliptxt.Contains("http") And Me.lastKey IsNot Cliptxt) Then
            txtURL.Text = Clipboard.GetText()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles CaptureLink.Tick
        autoClipBoardText()
    End Sub
End Class