Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim population As Double = 7000
        Dim year As Integer = 2012

        Do While population > 6

            year = year - 50
            population = population / 2

        Loop

        MessageBox.Show("This year is" & year, "gehh")

    End Sub
End Class
