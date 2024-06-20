Public Class Form1
    Private Sub OpenView()
        Dim viewForm As New view()
        viewForm.Show()
    End Sub

    Private Sub OpenCreate()
        Dim createForm As New create()
        createForm.Show()
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        OpenView()
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        OpenCreate()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            OpenView()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            OpenCreate()
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Me.KeyPreview = True
    End Sub
End Class
