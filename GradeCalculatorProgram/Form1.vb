Public Class frmCheck
    Private Sub btnGradeCheck_Click(sender As Object, e As EventArgs) Handles btnGradeCheck.Click
        Dim score As Integer = txtScore.Text
        If score >= 70 Then
            MessageBox.Show("That test score is an A grade") 'This Check If It Is Apart of The A Grade'

        ElseIf score >= 60 Then
            MessageBox.Show("That test score is an B grade") 'This Check If It Is Apart of The B Grade'

        ElseIf score >= 50 Then
            MessageBox.Show("That test score is a C grade") 'This Check If It Is Apart of The C Grade'

        ElseIf score >= 40 Then
            MessageBox.Show("That test score is a D grade") 'This Check If It Is Apart of The D Grade'


        Else
            MessageBox.Show("That test score is a U grade") 'This Check If It Is Apart of The U Grade'


        End If
    End Sub
End Class
