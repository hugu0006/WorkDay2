Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        ' read the input from the user
        fullname = txtFullName.Text
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)
        txtFirstName.Text = firstName



    End Sub

    Private Sub txtFullName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
