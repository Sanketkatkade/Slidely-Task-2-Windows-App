Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class create
    Private timer1 As Timer
    Private stopwatch As New Stopwatch
    Private isRunning As Boolean = False

    Private Sub create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1 = New System.Windows.Forms.Timer()
        timer1.Interval = 1000
        AddHandler timer1.Tick, AddressOf UpdateTimerDisplay
    End Sub

    Private Sub toggleTimer()
        If isRunning Then
            timer1.Stop()
            stopwatch.Stop()
            isRunning = False
        Else
            If Not stopwatch.IsRunning Then
                stopwatch.Start()
                timer1.Start()
            End If
            isRunning = True
            UpdateTimerDisplay(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub UpdateTimerDisplay(sender As Object, e As EventArgs)
        timer.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub submitForm()
        Dim formData As New Dictionary(Of String, String) From {
            {"name", name1.Text},
            {"email", email.Text},
            {"phone", phone.Text},
            {"github_link", github.Text},
            {"stopwatch_time", timer.Text}
        }
        Dim json As String = JsonConvert.SerializeObject(formData)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Form submitted successfully!")
                    name1.Text = ""
                    email.Text = ""
                    phone.Text = ""
                    github.Text = ""
                    timer.Text = "00:00:00"
                Else
                    MessageBox.Show("Error submitting form: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub toggle_Click(sender As Object, e As EventArgs) Handles toggle.Click
        toggleTimer()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        submitForm()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            toggleTimer()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            submitForm()
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Me.KeyPreview = True
    End Sub

End Class