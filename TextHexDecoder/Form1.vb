Imports System.IO

Public Class Form1
    Public dict As New Dictionary(Of String, String)

    Private Sub OpenValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenValuesToolStripMenuItem.Click
        txtBrowser.ShowDialog()
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(txtBrowser.FileName, System.Text.Encoding.Default)

                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("=")
                Dim Row As String()
                While Not MyReader.EndOfData
                    Try
                        Row = MyReader.ReadFields()
                        dict.Add(Row(0), Row(1))
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using
        Catch ex As Exception

        End Try
        

        Try
            Dim myReader As New StreamReader(txtBrowser.FileName)
            btnCAll.Enabled = True
            txt1.Enabled = True
            txt2.Enabled = True
            GroupBox1.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            GroupBox5.Enabled = True
            EditINIToolStripMenuItem.Enabled = True
        Catch ex As Exception
            MsgBox("No ini Opened!", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBrowser.FileName = "Hex Values.ini"
        txtBrowser.Filter = ".ini File (*.ini)|*.ini"
        btnCAll.Enabled = False
        txt1.Enabled = False
        txt2.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
    End Sub

    Private Sub rbHex1_CheckedChanged(sender As Object, e As EventArgs) Handles rbHex1.CheckedChanged
        If rbHex1.Checked = True Then
            cbTo.Text = "Text"
        End If
    End Sub

    Private Sub rbText1_CheckedChanged(sender As Object, e As EventArgs) Handles rbText1.CheckedChanged
        If rbText1.Checked = True Then
            cbTo.Text = "Hex"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCField1_Click(sender As Object, e As EventArgs) Handles btnCField1.Click
        txt1.Text = Nothing
    End Sub

    Private Sub btnCAll_Click(sender As Object, e As EventArgs) Handles btnCAll.Click
        txt1.Text = Nothing
        txt2.Text = Nothing
    End Sub

    Private Sub btnCField2_Click(sender As Object, e As EventArgs) Handles btnCField2.Click
        txt2.Text = Nothing
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetDataObject(txt2.Text)
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim str As String = txt2.Text
        If (rbText1.Checked = True) And cbTo.Text = "Hex" Then
            Dim count As Integer = txt1.Text.Count
            For x As Integer = 0 To count - 1
                If txt1.Text.Chars(x) = " " Then
                    txt2.AppendText(" 00")
                End If
                For Each pair As KeyValuePair(Of String, String) In dict
                    If txt1.Text.Chars(x) = pair.Value Then
                        txt2.Text = (txt2.Text & " " & pair.Key).TrimStart
                    End If
                Next
            Next

        ElseIf (rbHex1.Checked = True) And cbTo.Text = "Text" Then
            Dim countHex As Integer = txt1.Text.Count
            For x As Integer = 0 To countHex - 1
                Try
                    If txt1.Text.Chars(x) & txt1.Text.Chars(x + 1) = "00" Then
                        txt2.AppendText(" ")
                    End If
                    For Each pair As KeyValuePair(Of String, String) In dict
                        If txt1.Text.Chars(x) & txt1.Text.Chars(x + 1) = pair.Key Then
                            txt2.Text = (txt2.Text & pair.Value).TrimStart

                        End If
                    Next
                Catch ex As Exception

                End Try
            Next

        ElseIf (rbText1.Checked = True) And cbTo.Text = "Text" Then
            txt2.Text = txt1.Text

        Else
            txt2.Text = txt1.Text
        End If

    End Sub
    Private Sub FbToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FbToolStripMenuItem1.Click
        Process.Start("www.facebook.com/mindfreak369")
    End Sub

    Private Sub TwittToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwittToolStripMenuItem.Click
        Process.Start("www.twitter.com/kingofhearts120")
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        About.Show()
    End Sub

    Private Sub GuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuideToolStripMenuItem.Click
        Guide.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub GmailToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GmailToolStripMenuItem1.Click
        MessageBox.Show("Send me an email at kinggarrettgoting@gmail.com", "Contact - GMAIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub YahooToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YahooToolStripMenuItem1.Click
        MessageBox.Show("Send me an email at skyrhettz@yahoo.com", "Contact - Yahoo Mail", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub EditINIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditINIToolStripMenuItem.Click
        MessageBox.Show("When editing the ini, always remember to separate the key to the value with an equal sign '='.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start(txtBrowser.FileName)
    End Sub

    Private Sub PcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PcToolStripMenuItem1.Click
        Process.Start("http://www.pokecommunity.com/member.php?u=433319")
    End Sub

    Private Sub SfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SfToolStripMenuItem.Click
        Process.Start("https://sourceforge.net/u/kakarot1212/profile/")
    End Sub

    Private Sub GitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GitToolStripMenuItem1.Click
        Process.Start("https://github.com/KakarotPH")
    End Sub
End Class
