<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Input_Box = New TextBox()
        Encrypt_Button = New Button()
        Decrypt_Button = New Button()
        Save_Button = New Button()
        Open_Button = New Button()
        Password_Box = New TextBox()
        Password_Label = New Label()
        Result_Label = New Label()
        SuspendLayout()
        ' 
        ' Input_Box
        ' 
        Input_Box.Location = New Point(112, 43)
        Input_Box.Name = "Input_Box"
        Input_Box.Size = New Size(219, 23)
        Input_Box.TabIndex = 0
        ' 
        ' Encrypt_Button
        ' 
        Encrypt_Button.Location = New Point(13, 72)
        Encrypt_Button.Name = "Encrypt_Button"
        Encrypt_Button.Size = New Size(75, 23)
        Encrypt_Button.TabIndex = 1
        Encrypt_Button.Text = "Encrypt"
        Encrypt_Button.UseVisualStyleBackColor = True
        ' 
        ' Decrypt_Button
        ' 
        Decrypt_Button.Location = New Point(94, 72)
        Decrypt_Button.Name = "Decrypt_Button"
        Decrypt_Button.Size = New Size(75, 23)
        Decrypt_Button.TabIndex = 2
        Decrypt_Button.Text = "Decrypt"
        Decrypt_Button.UseVisualStyleBackColor = True
        ' 
        ' Save_Button
        ' 
        Save_Button.Location = New Point(175, 72)
        Save_Button.Name = "Save_Button"
        Save_Button.Size = New Size(75, 23)
        Save_Button.TabIndex = 3
        Save_Button.Text = "Save as file"
        Save_Button.UseVisualStyleBackColor = True
        ' 
        ' Open_Button
        ' 
        Open_Button.Location = New Point(256, 72)
        Open_Button.Name = "Open_Button"
        Open_Button.Size = New Size(75, 23)
        Open_Button.TabIndex = 4
        Open_Button.Text = "Open file"
        Open_Button.UseVisualStyleBackColor = True
        ' 
        ' Password_Box
        ' 
        Password_Box.Location = New Point(112, 13)
        Password_Box.Name = "Password_Box"
        Password_Box.Size = New Size(219, 23)
        Password_Box.TabIndex = 5
        ' 
        ' Password_Label
        ' 
        Password_Label.AutoSize = True
        Password_Label.Location = New Point(19, 16)
        Password_Label.Name = "Password_Label"
        Password_Label.Size = New Size(57, 15)
        Password_Label.TabIndex = 6
        Password_Label.Text = "Password"
        ' 
        ' Result_Label
        ' 
        Result_Label.AutoSize = True
        Result_Label.Location = New Point(19, 46)
        Result_Label.Name = "Result_Label"
        Result_Label.Size = New Size(78, 15)
        Result_Label.TabIndex = 7
        Result_Label.Text = "Input/Output"
        ' 
        ' TestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 108)
        Controls.Add(Result_Label)
        Controls.Add(Password_Label)
        Controls.Add(Password_Box)
        Controls.Add(Open_Button)
        Controls.Add(Save_Button)
        Controls.Add(Decrypt_Button)
        Controls.Add(Encrypt_Button)
        Controls.Add(Input_Box)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "TestForm"
        Text = "Demo - Crypt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Input_Box As TextBox
    Friend WithEvents Encrypt_Button As Button
    Friend WithEvents Decrypt_Button As Button
    Friend WithEvents Save_Button As Button
    Friend WithEvents Open_Button As Button
    Friend WithEvents Password_Box As TextBox
    Friend WithEvents Password_Label As Label
    Friend WithEvents Result_Label As Label

End Class
