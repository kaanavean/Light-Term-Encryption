Imports System.IO
Imports Light_Term_Encryption
Public Class TestForm

    Private ReadOnly engine As New LTE

    Private Sub Encypt_Button_Click(sender As Object, e As EventArgs) Handles Encrypt_Button.Click
        If String.IsNullOrWhiteSpace(Input_Box.Text) Then Return
        Try
            ' Protect(Text, UseHardwareBinding, Password)
            Dim encryptedData As Byte() = engine.Protect(Input_Box.Text, True, Password_Box.Text)

            ' Converting to Base64 for easy display/storage
            Input_Box.Text = Convert.ToBase64String(encryptedData)
            MessageBox.Show("Encrypted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while encrypting: " & ex.Message)
        End Try
    End Sub

    Private Sub Decrypt_Button_Click(sender As Object, e As EventArgs) Handles Decrypt_Button.Click
        If String.IsNullOrWhiteSpace(Input_Box.Text) Then Return
        Try
            ' Base64 back to Bytes
            Dim encryptedData As Byte() = Convert.FromBase64String(Input_Box.Text)
            ' Unprotect(Bytes, UseHardwareBinding, Password)
            Dim decryptedText As String = engine.Unprotect(encryptedData, True, Password_Box.Text)
            Input_Box.Text = decryptedText
        Catch ex As Exception
            MessageBox.Show("Decryption failed. Wrong hardware or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        If String.IsNullOrWhiteSpace(Input_Box.Text) Then Return
        Dim sfd As New SaveFileDialog With {
            .Filter = "Crypt Files (*.data)|*.data",
            .Title = "Save encrypted data"
        }
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' Convert Base64 string back to bytes and save to file
                Dim dataToSave As Byte() = Convert.FromBase64String(Input_Box.Text)
                File.WriteAllBytes(sfd.FileName, dataToSave)
                MessageBox.Show("File saved!")
            Catch
                MessageBox.Show("Please encrypt input manually first.")
            End Try
        End If
    End Sub

    Private Sub Open_Button_Click(sender As Object, e As EventArgs) Handles Open_Button.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Crypt Files (*.data)|*.data",
            .Title = "Open encrypted data"
        }
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim fileData As Byte() = File.ReadAllBytes(ofd.FileName)
                ' Show as Base64 string in TextBox
                Input_Box.Text = Convert.ToBase64String(fileData)
            Catch ex As Exception
                MessageBox.Show("Error occurred while loading: " & ex.Message)
            End Try
        End If
    End Sub
End Class