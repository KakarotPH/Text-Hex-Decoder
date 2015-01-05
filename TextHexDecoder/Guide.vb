Public Class Guide


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        
        If ComboBox1.Text = "Convert Button" Then
            Label1.Visible = False
            Label3.Visible = False
            Label2.Text = "Button used to convert the current text of the text field for 'From'"

        ElseIf ComboBox1.Text = "Clear Field Button" Then
            Label1.Visible = False
            Label3.Visible = False
            Label2.Text = "Used to clear the 'From' or 'To' Text Field"

        ElseIf ComboBox1.Text = "Clear All Button" Then
            Label1.Visible = False
            Label3.Visible = False
            Label2.Text = "Clear all fields."

        ElseIf ComboBox1.Text = "First time use" Then
            Label1.Visible = True
            Label3.Visible = True
            Label2.Text = "Then, you can now freely convert from 'Text - Hex' or 'Hex - Text'"

        ElseIf ComboBox1.Text = "Copy Button" Then
            Label1.Visible = False
            Label3.Visible = False
            Label2.Text = "Copy whatever the 'To' text field contains."
        End If
    End Sub

    Private Sub Guide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "First time use"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class