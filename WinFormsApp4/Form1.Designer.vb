<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        view = New Button()
        create = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(67, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(664, 41)
        Label1.TabIndex = 0
        Label1.Text = "Sanket Katkade, Slidely Task 2 - Slidely Form App"
        ' 
        ' view
        ' 
        view.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        view.Location = New Point(67, 98)
        view.Name = "view"
        view.Size = New Size(676, 61)
        view.TabIndex = 1
        view.Text = "VIEW SUBMISSIONS (CTRL + V)"
        view.UseVisualStyleBackColor = False
        ' 
        ' create
        ' 
        create.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        create.Location = New Point(67, 174)
        create.Name = "create"
        create.Size = New Size(676, 61)
        create.TabIndex = 2
        create.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        create.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(805, 283)
        Controls.Add(create)
        Controls.Add(view)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents view As Button
    Friend WithEvents create As Button

End Class
