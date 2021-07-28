Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtUsername.Text = "Admin" And btnPassword.Text = "Password" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("Invaild Login Details", "Closing System", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        Dim result = MessageBox.Show("Are you sure you want to exit", "Closing the system",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHOPDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOPDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOPDataSet.CUSTOMER_DETAILS)

    End Sub
End Class
