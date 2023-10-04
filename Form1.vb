Imports System.Transactions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyText As String
        MyText = "VISUAL BASIC"
        MsgBox(Microsoft.VisualBasic.Right(MyText, 3))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyPhrase As String
        Dim Position, number As Integer
        MyPhrase = InputBox("Enter your phrase")
        Position = TextBox2.Text 'enter the number 
        number = TextBox3.Text 'Eenter the numer of letter to be extracted





    End Sub
End Class
