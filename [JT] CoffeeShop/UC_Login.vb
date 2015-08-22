Public Class UC_Login

    Private Sub UC_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(50, 50)
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Left
    End Sub

    Private Sub LogIn()
        Dim DB = New Class_DB()

        If TextBox_Username.Text = DB.DbUsername And TextBox_Password.Text = DB.DbPassword Then
            Me.Visible = False
            Form_Main.LoggedIn = True
            Form_Main.tmp_UCMain = New UC_Main
            Form_Main.Controls.Add(Form_Main.tmp_UCMain)
            Me.Dispose()
        Else
            MsgBox("Đăng nhập thất bại", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ButtonButton_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Call LogIn()
    End Sub

    Private Sub TextBox_Username_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Username.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Call LogIn()
        End If
    End Sub

    Private Sub TextBox_Password_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Password.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Call LogIn()
        End If
    End Sub
End Class
