<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view
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
        Label7 = New Label()
        Label8 = New Label()
        name1 = New TextBox()
        email = New TextBox()
        phone = New TextBox()
        github = New TextBox()
        time = New TextBox()
        prev = New Button()
        nex = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11F)
        Label1.Location = New Point(31, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(511, 26)
        Label1.TabIndex = 0
        Label1.Text = "Sanket Katkade, Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(57, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 30)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(39, 363)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 30)
        Label3.TabIndex = 2
        Label3.Text = "Stopwatch"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(31, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 30)
        Label4.TabIndex = 3
        Label4.Text = "Github Link"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(57, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 30)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(31, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 30)
        Label6.TabIndex = 5
        Label6.Text = "Phone Num"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F)
        Label7.Location = New Point(43, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 30)
        Label7.TabIndex = 6
        Label7.Text = "For Task 2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F)
        Label8.Location = New Point(64, 393)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 30)
        Label8.TabIndex = 7
        Label8.Text = "time"
        ' 
        ' name1
        ' 
        name1.Location = New Point(202, 113)
        name1.Name = "name1"
        name1.ReadOnly = True
        name1.Size = New Size(340, 31)
        name1.TabIndex = 8
        ' 
        ' email
        ' 
        email.Location = New Point(202, 174)
        email.Name = "email"
        email.ReadOnly = True
        email.Size = New Size(340, 31)
        email.TabIndex = 9
        ' 
        ' phone
        ' 
        phone.Location = New Point(203, 234)
        phone.Name = "phone"
        phone.ReadOnly = True
        phone.Size = New Size(339, 31)
        phone.TabIndex = 10
        ' 
        ' github
        ' 
        github.Location = New Point(202, 294)
        github.Name = "github"
        github.ReadOnly = True
        github.Size = New Size(336, 31)
        github.TabIndex = 11
        ' 
        ' time
        ' 
        time.Location = New Point(202, 375)
        time.Name = "time"
        time.ReadOnly = True
        time.Size = New Size(336, 31)
        time.TabIndex = 12
        ' 
        ' prev
        ' 
        prev.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        prev.Location = New Point(31, 477)
        prev.Name = "prev"
        prev.Size = New Size(257, 40)
        prev.TabIndex = 13
        prev.Text = "PREVIOUS (CTRL + P)"
        prev.UseVisualStyleBackColor = False
        ' 
        ' nex
        ' 
        nex.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        nex.Location = New Point(294, 477)
        nex.Name = "nex"
        nex.Size = New Size(248, 40)
        nex.TabIndex = 14
        nex.Text = "NEXT (CTRL + N)"
        nex.UseVisualStyleBackColor = False
        ' 
        ' view
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 570)
        Controls.Add(nex)
        Controls.Add(prev)
        Controls.Add(time)
        Controls.Add(github)
        Controls.Add(phone)
        Controls.Add(email)
        Controls.Add(name1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "view"
        Text = "view"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents name1 As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents github As TextBox
    Friend WithEvents time As TextBox
    Friend WithEvents prev As Button
    Friend WithEvents nex As Button
End Class
