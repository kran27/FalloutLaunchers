Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1
    Private ReadOnly args As String() = Environment.GetCommandLineArgs()

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    <DllImport("user32.dll")>
    Public Shared Sub ReleaseCapture()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If args.Contains("-classic") Then
            Process.Start("BOS.exe")
        ElseIf args.Contains("-win8") Then
            Process.Start("BOS_HR.exe", "-g")
        Else
            Process.Start("BOS_HR.exe")
        End If
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try : Process.Start("readme.rtf") : Catch : End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("http://support.bethsoft.com/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox2_MouseDown() Handles PictureBox2.MouseDown
        PictureBox2.Image = My.Resources.Play_Pressed
    End Sub
    Private Sub PictureBox2_MouseUp() Handles PictureBox2.MouseUp
        PictureBox2.Image = My.Resources.Play
    End Sub
    Private Sub Picturebox3_MouseDown() Handles PictureBox3.MouseDown
        PictureBox3.Image = My.Resources.ReadMe_Pressed
    End Sub
    Private Sub PictureBox3_MouseUp() Handles PictureBox3.MouseUp
        PictureBox3.Image = My.Resources.ReadMe
    End Sub
    Private Sub Picturebox4_MouseDown() Handles PictureBox4.MouseDown
        PictureBox4.Image = My.Resources.TS_Pressed
    End Sub
    Private Sub PictureBox4_MouseUp() Handles PictureBox4.MouseUp
        PictureBox4.Image = My.Resources.TS
    End Sub
    Private Sub Picturebox5_MouseDown() Handles PictureBox5.MouseDown
        PictureBox5.Image = My.Resources.Exit_Pressed
    End Sub
    Private Sub PictureBox5_MouseUp() Handles PictureBox5.MouseUp
        PictureBox5.Image = My.Resources._Exit
    End Sub

End Class
