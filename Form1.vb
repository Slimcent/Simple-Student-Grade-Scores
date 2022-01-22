Public Class Form1

    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click

        'to close the app

        Dim returndialogresult As System.Windows.Forms.DialogResult
        Dim title As String = "Sure to exit"
        Dim message As String = "Do you want to exit?"

        returndialogresult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If returndialogresult = Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtscores.Text = ""
        lblresult.Text = ""


    End Sub

    Private Sub txtscores_TextChanged(sender As Object, e As EventArgs) Handles txtscores.TextChanged

    End Sub

    Private Sub txtscores_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtscores.Validating

        Dim score As Integer

        Try
            score = Integer.Parse(txtscores.Text)

            If txtscores.Text = String.Empty Then

                'Cancel the event
                e.Cancel = True
                txtscores.SelectAll()
                txtscores.Focus()

                ErrorProvider.SetError(txtscores, "Score must not be blank")

            End If

        Catch ex As Exception
            e.Cancel = True
            txtscores.SelectAll()
            txtscores.Focus()
            ErrorProvider.SetError(txtscores, "Year must be numeric")
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = False

    End Sub

   
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click

        Dim scores As Integer

        scores = Val(txtscores.Text)

        If scores >= 70 Then
            lblresult.Text = "A"
        ElseIf scores >= 60 Then
            lblresult.Text = "B"
        ElseIf scores >= 50 Then
            lblresult.Text = "C"
        ElseIf scores >= 40 Then
            lblresult.Text = "D"
        Else
            lblresult.Text = "F"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
