Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Environment.UserName
        Dim plat As String = Environment.OSVersion.ToString
        Dim mName As String = Environment.MachineName
        TextBox2.Text = "User: " & username & vbNewLine & "Platform: " & plat & vbNewLine & "Machine Name: " & mName & vbNewLine & "Product Version: 2.0" & vbNewLine & "Product Type: Free"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class