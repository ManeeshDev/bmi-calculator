Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim bmi As Double
        Dim weight As String
        Dim height As String
        weight = txtWeight.Text
        height = txtHeight.Text

        If height <> "" And weight <> "" Then
            bmi = weight / ((height / 100) * (height / 100))
            lblBmiAnswr.Text = bmi
        Else
            MsgBox("Please Fill Details", MsgBoxStyle.Exclamation, "Calculate")
            txtHeight.Focus()

        End If
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        If txtHeight.Text <> "" Or txtWeight.Text <> "" Then
            Dim ans As String
            ans = MsgBox("Do You want Reset..!!", vbYesNo + vbQuestion, "Reset")
            If ans = vbYes Then
                txtWeight.Text = ""
                txtHeight.Text = ""
                lblBmiAnswr.Text = ""
            End If
        End If
    End Sub

End Class
