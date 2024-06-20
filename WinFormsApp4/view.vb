Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class view
    Dim ind As Integer = 0

    Private Async Sub FetchData(index As Integer)
        Using client As New HttpClient()
            Try
                Dim url As String = $"http://localhost:3000/read?index={index}"
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim result As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonResponse)

                    name1.Text = result("name")
                    email.Text = result("email")
                    phone.Text = result("phone")
                    github.Text = result("github_link")
                    time.Text = result("stopwatch_time")
                Else
                    MessageBox.Show("You have reached the end of the submissions")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData(0)
    End Sub

    Private Sub nextRes()
        ind += 1
        FetchData(ind)
    End Sub
    Private Sub prevRes()
        If ind > 0 Then
            ind -= 1
            FetchData(ind)
        End If
    End Sub

    Private Sub nex_Click(sender As Object, e As EventArgs) Handles nex.Click
        nextRes()
    End Sub

    Private Sub prev_Click(sender As Object, e As EventArgs) Handles prev.Click
        prevRes()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            prevRes()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            nextRes()
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Me.KeyPreview = True
    End Sub
End Class