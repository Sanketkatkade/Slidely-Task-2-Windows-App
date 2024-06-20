<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        toggle = New Button()
        timer = New TextBox()
        name1 = New TextBox()
        email = New TextBox()
        phone = New TextBox()
        github = New TextBox()
        submit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(41, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(501, 30)
        Label1.TabIndex = 0
        Label1.Text = "Sanket Katkade, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(41, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 30)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(41, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 30)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(12, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 30)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(18, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 30)
        Label5.TabIndex = 4
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(18, 309)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 30)
        Label6.TabIndex = 5
        Label6.Text = "For Task 2"
        ' 
        ' toggle
        ' 
        toggle.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        toggle.Location = New Point(18, 363)
        toggle.Name = "toggle"
        toggle.Size = New Size(363, 34)
        toggle.TabIndex = 6
        toggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
        toggle.UseVisualStyleBackColor = False
        ' 
        ' timer
        ' 
        timer.Location = New Point(387, 365)
        timer.Name = "timer"
        timer.ReadOnly = True
        timer.Size = New Size(178, 31)
        timer.TabIndex = 7
        timer.Text = "00:00:00"
        ' 
        ' name1
        ' 
        name1.Location = New Point(162, 109)
        name1.Name = "name1"
        name1.Size = New Size(403, 31)
        name1.TabIndex = 8
        ' 
        ' email
        ' 
        email.Location = New Point(162, 168)
        email.Name = "email"
        email.Size = New Size(403, 31)
        email.TabIndex = 9
        ' 
        ' phone
        ' 
        phone.Location = New Point(162, 224)
        phone.Name = "phone"
        phone.Size = New Size(403, 31)
        phone.TabIndex = 10
        ' 
        ' github
        ' 
        github.Location = New Point(162, 308)
        github.Name = "github"
        github.Size = New Size(403, 31)
        github.TabIndex = 11
        ' 
        ' submit
        ' 
        submit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        submit.Location = New Point(41, 460)
        submit.Name = "submit"
        submit.Size = New Size(506, 52)
        submit.TabIndex = 12
        submit.Text = "SUBMIT (CTRL + S)"
        submit.UseVisualStyleBackColor = False
        ' 
        ' create
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 570)
        Controls.Add(submit)
        Controls.Add(github)
        Controls.Add(phone)
        Controls.Add(email)
        Controls.Add(name1)
        Controls.Add(timer)
        Controls.Add(toggle)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "create"
        Text = "create"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents toggle As Button
    Friend WithEvents timer As TextBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents github As TextBox
    Friend WithEvents submit As Button
End Class
