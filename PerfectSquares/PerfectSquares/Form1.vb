Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim numb As Integer = 1
        Dim perfSquare As Integer
        lstResult.Items.Clear()

        Do Until numb > 10
            perfSquare = numb ^ 2


            lstResult.Items.Add(numb & "*" & numb & "=" & perfSquare)
            numb += 1
        Loop
    End Sub
End Class
