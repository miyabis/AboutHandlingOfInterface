
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _compute(New ComputeAddition())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _compute(New ComputeSubtraction())
    End Sub

    Private Sub _compute(ByVal obj As ICompute)
        Try
            txtAns.Text = obj.Execute(CLng(txtValue1.Text), CLng(txtValue2.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
