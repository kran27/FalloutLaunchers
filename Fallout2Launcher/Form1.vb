Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1
    Private ReadOnly args As String() = Environment.GetCommandLineArgs()
    Private PBI As Bitmap() = {My.Resources.Play, My.Resources.Play_Pressed}
    Private RBI As Bitmap() = {My.Resources.ReadMe, My.Resources.ReadMe_Pressed}
    Private TBI As Bitmap() = {My.Resources.TS, My.Resources.TS_Pressed}
    Private EBI As Bitmap() = {My.Resources._Exit, My.Resources.Exit_Pressed}

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

    Private Sub Form1_Load() Handles MyBase.Load
        Dim ini As String()
        Try : ini = IO.File.ReadAllLines(".\\fallout2.cfg") : Catch : End Try
        If ini IsNot Nothing Then
            Dim lang As String = ini.Ini("system", "language")
            Select Case lang
                Case "french"
                    PBI(0) = My.Resources.Play_FR : PBI(1) = My.Resources.Play_FR_Pressed
                    RBI(0) = My.Resources.ReadMe_FR : RBI(1) = My.Resources.ReadMe_FR_Pressed
                    TBI(0) = My.Resources.TS_FR : RBI(1) = My.Resources.TS_FR_Pressed
                    EBI(0) = My.Resources.Exit_FR : RBI(1) = My.Resources.ReadMe_FR_Pressed
                Case "german"
                    PBI(0) = My.Resources.Play_DE : PBI(1) = My.Resources.Play_DE_Pressed
                    RBI(0) = My.Resources.ReadMe_DE : RBI(1) = My.Resources.ReadMe_DE_Pressed
                    TBI(0) = My.Resources.TS_DE : RBI(1) = My.Resources.TS_DE_Pressed
                    EBI(0) = My.Resources.Exit_DE : RBI(1) = My.Resources.ReadMe_DE_Pressed
            End Select
        End If
        PictureBox2.Image = PBI(0)
        PictureBox3.Image = RBI(0)
        PictureBox4.Image = TBI(0)
        PictureBox5.Image = EBI(0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If args.Contains("-classic") Then
            Process.Start("fallout2.exe")
        Else
            Process.Start("fallout2hr.exe")
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
        PictureBox2.Image = PBI(1)
    End Sub
    Private Sub PictureBox2_MouseUp() Handles PictureBox2.MouseUp
        PictureBox2.Image = PBI(0)
    End Sub
    Private Sub Picturebox3_MouseDown() Handles PictureBox3.MouseDown
        PictureBox3.Image = RBI(1)
    End Sub
    Private Sub PictureBox3_MouseUp() Handles PictureBox3.MouseUp
        PictureBox3.Image = RBI(0)
    End Sub
    Private Sub Picturebox4_MouseDown() Handles PictureBox4.MouseDown
        PictureBox4.Image = TBI(1)
    End Sub
    Private Sub PictureBox4_MouseUp() Handles PictureBox4.MouseUp
        PictureBox4.Image = TBI(0)
    End Sub
    Private Sub Picturebox5_MouseDown() Handles PictureBox5.MouseDown
        PictureBox5.Image = EBI(1)
    End Sub
    Private Sub PictureBox5_MouseUp() Handles PictureBox5.MouseUp
        PictureBox5.Image = EBI(0)
    End Sub

End Class

Public Module IniManager

    <Extension()>
    Public Function Ini(ByRef IniArray As String(), IniSection As String, IniKey As String, Optional Value As String = Nothing)
        ' Find bounds of section
        Dim SectionStart = Array.FindIndex(IniArray, Function(x) x.StartsWith($"[{IniSection}]"))
        Dim SectionEnd = Array.FindIndex(IniArray, SectionStart + 1, Function(x) x.StartsWith("[")) - 1
        If SectionEnd < 0 Then SectionEnd = IniArray.Length - 1
        ' Find key location and value
        Dim KeyIndex = Array.FindIndex(IniArray, SectionStart + 1, Function(x) x.StartsWith(IniKey))
        If KeyIndex > SectionEnd Then Return Nothing
        Dim KeyLine = IniArray(KeyIndex)
        Dim KeyValue = KeyLine.Substring(KeyLine.IndexOf("=") + 1).Trim
        ' Find comment, if any
        Dim Comment = Nothing
        Try : Comment = KeyValue.Substring(KeyValue.IndexOf(";")) : Catch : End Try
        If Comment IsNot Nothing Then KeyValue = KeyValue.Substring(0, KeyValue.LastIndexOf(";")).Trim
        ' Either set or return value
        If Value IsNot Nothing Then
            IniArray(KeyIndex) = Trim($"{IniKey} = {Value} {Comment}")
            Return Nothing
        Else
            Return KeyValue
        End If
    End Function

    <Extension()>
    Public Function GetSection(IniArray As String(), IniSection As String) As String()
        ' Find bounds of section
        Dim SectionStart = Array.FindIndex(IniArray, Function(x) x.StartsWith($"[{IniSection}]"))
        Dim SectionEnd = Array.FindIndex(IniArray, SectionStart + 1, Function(x) x.StartsWith("[")) - 1
        If SectionEnd < 0 Then SectionEnd = IniArray.Length - 1
        ' Return section
        Return IniArray.Skip(SectionStart + 1).Take(SectionEnd - SectionStart).ToArray
    End Function

End Module
