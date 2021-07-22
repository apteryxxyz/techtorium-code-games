Public Class Lab01
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Student Name: " & TextBox1.Text & " " & TextBox2.Text)
        ListBox1.Items.Add("Student DOB: " & DateTimePicker1.Value.Date)
    End Sub
End Class
