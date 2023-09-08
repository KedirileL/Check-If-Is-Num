Public Class Form1
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim iNumber As Integer



        If IsNumeric(txtNum.Text) = True Then

            iNumber = txtNum.Text
            MsgBox(" You Entered Number is " & txtNum.Text)


        Else
            MsgBox("Try again, You didnt enter a number!")

            Exit Sub
        End If

    End Sub
End Class
