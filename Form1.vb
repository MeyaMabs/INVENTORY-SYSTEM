Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If cmbUsername.Text = "Manager" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Manager" Then

            TabControl1.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False
        ElseIf cmbUsername.Text = "Cashier" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Cashier" Then
            TabControl2.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False

        ElseIf cmbUsername.Text = "Stock Controller" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Stock Controller" Then
            TabControl3.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False
        Else

            MsgBox("Please Enter Your Username And Password", MsgBoxStyle.Information, "Login")

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
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_CATALOG' table. You can move, or remove it, as needed.
        Me.PRODUCT_CATALOGTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_CATALOG)
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_ORDERS' table. You can move, or remove it, as needed.
        Me.PRODUCT_ORDERSTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_ORDERS)
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_DETAILS' table. You can move, or remove it, as needed.
        Me.PRODUCT_DETAILSTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_DETAILS)
        'TODO: This line of code loads data into the 'SHOPDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOPDataSet.CUSTOMER_DETAILS)


        cmbUsername.Items.Add("Manager")
        cmbUsername.Items.Add("Cashier")
        cmbUsername.Items.Add("Stock Controller")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CUSTOMER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
         CUSTOMER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.CUSTOMER_DETAILSTableAdapter.Update(Me.SHOPDataSet)
Feedback:
        MsgBox("Check your Record", vbInformation)
        Exit Sub
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub


End Class
