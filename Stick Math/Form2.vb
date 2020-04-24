' Code game with math
' Author: Nguyen Trung Nhan
' Contact: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201
Public Class Form2
    Dim s1 As Integer
    Dim s2 As Integer
    Dim s3 As String

    Private Sub kq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kq.KeyPress
        Try
            If e.KeyChar = Chr(8) Then Exit Sub
            Dim s As String = e.KeyChar
            Dim f As Short = s / 1
        Catch ex As Exception
            e.KeyChar = ""
        End Try
    End Sub

    Private Sub kq_TextChanged(sender As Object, e As EventArgs) Handles kq.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        so1.Text = Int(Rnd() * 10000)
        so2.Text = Int(Rnd() * 10000)
        s1 = so1.Text
        s2 = so2.Text
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        s3 = s1 + s2
        If kq.Text = s3 Then
            MsgBox("Right!")
            so1.Text = Int(Rnd() * 10000)
            so2.Text = Int(Rnd() * 10000)
            s1 = so1.Text
            s2 = so2.Text
            ban.Image = My.Resources.ban
            PictureBox1.Visible = True
            Timer1.Enabled = True
            kq.Text = ""
        Else
            MsgBox("Wrong!")
            so1.Text = Int(Rnd() * 10000)
            so2.Text = Int(Rnd() * 10000)
            s1 = so1.Text
            s2 = so2.Text
            Timer6.Enabled = True
            quai1.Image = My.Resources.dichh
            quai2.Image = My.Resources.dichh
            quai3.Image = My.Resources.dichh
            kq.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Visible = True
        PictureBox1.Visible = False
        Timer2.Enabled = True
        Timer1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox3.Visible = True
        PictureBox2.Visible = False
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox4.Visible = True

        Timer4.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox5.Visible = True

        Timer5.Enabled = True
        Timer4.Enabled = False
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If Label4.Text <= 10 Then
            MsgBox("Win!")
            End
        Else


            Label4.Text = Label4.Text - 150
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            ban.Image = My.Resources._1
            Timer5.Enabled = False
            If Label4.Text <= 10 Then
                MsgBox("Win!")
                End
            Else
            End If
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        denn.Visible = True
        Timer7.Enabled = True
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        denn.Visible = False

        If Label3.Text <= 10 Then
            MsgBox("Lose!")
            End
        Else
            Label3.Text = Label3.Text - 200
            quai1.Image = My.Resources._11
            quai2.Image = My.Resources._11
            quai3.Image = My.Resources._11
            Timer7.Enabled = False
            If Label3.Text <= 10 Then
                MsgBox("Lose!")
                End
            Else
            End If
        End If
    End Sub
End Class