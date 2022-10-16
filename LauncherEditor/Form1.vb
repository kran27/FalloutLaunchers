Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class Form1
    Private FilePath As String
    Public dir As String
    Private Sub SelectLauncherC(sender As Object, e As EventArgs) Handles SelectLauncher.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Bethesda Launcher|*.exe",
            .Multiselect = False
        }
        If ofd.ShowDialog() = DialogResult.OK Then
            FilePath = ofd.FileName
            Dim filename = ofd.FileName.Split("\").Last
            Select Case filename
                Case "FalloutLauncher.exe", "FalloutLauncherSteam.exe" : ComboBox1.SelectedIndex = 0
                Case "FalloutNVLauncher.exe" : ComboBox1.SelectedIndex = 1
                Case "Fallout4Launcher.exe" : ComboBox1.SelectedIndex = 2
                Case "SkyrimLauncher.exe" : ComboBox1.SelectedIndex = 3
                Case "SkyrimSELauncher.exe" : ComboBox1.SelectedIndex = 4
                Case Else : MsgBox("Couldn't identify launcher, please select manually")
                    ComboBox1.Enabled = True
            End Select
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Enabled = False
        dir = $"{Application.StartupPath}{ComboBox1.SelectedItem.Replace(":", "")}"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("ResourceHacker.exe") Then
            If MsgBox("Resource Hacker not found, would you like to open the download page?", MsgBoxStyle.YesNo, "Dependency Missing") = DialogResult.Yes Then
                MsgBox("Download the ZIP version and extract the .exe to this folder")
                Process.Start("explorer", "http://www.angusj.com/resourcehacker/#download")
                Process.Start("explorer", Application.StartupPath)
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub ExtractImages(silent As Boolean, openFolder As Boolean)
        IO.Directory.CreateDirectory(dir)
        Dim rh As New Process With {.StartInfo = New ProcessStartInfo With {.FileName = "ResourceHacker.exe", .Arguments = "-script scr.txt", .WorkingDirectory = dir}}
        Dim scrb As New Text.StringBuilder
        scrb.Append("[FILENAMES]")
        scrb.Append(vbCrLf)
        scrb.Append($"Open=""{FilePath}""")
        scrb.Append(vbCrLf)
        Select Case ComboBox1.SelectedIndex
            Case 0, 1, 3 : scrb.Append(My.Resources.FExtract)
            Case 2, 4 : scrb.Append(My.Resources.F4Extract)
        End Select
        IO.File.WriteAllText($"{dir}\scr.txt", scrb.ToString)
        rh.Start()
        rh.WaitForExit()
        IO.File.Delete($"{dir}\scr.txt")
        If Not silent Then MsgBox("Images Extracted")
        If openFolder Then Process.Start("explorer", dir)
    End Sub

    Public Sub ApplyChanges() Handles Button2.Click
        If IO.Directory.Exists(dir) Then
            For Each file As String In IO.Directory.GetFiles(dir)
                Dim f As New IO.FileInfo(file)
                If f.Extension = ".bmp" Then
                    Dim bmp = LoadBmp(file)
                    bmp.Save(file, ImageFormat.Bmp)
                End If
            Next
            Dim rh As New Process With {.StartInfo = New ProcessStartInfo With {.FileName = $"ResourceHacker.exe", .Arguments = "-script scr.txt", .WorkingDirectory = dir}}
            Dim scrb As New Text.StringBuilder
            scrb.Append("[FILENAMES]")
            scrb.Append(vbCrLf)
            scrb.Append($"Open=""{FilePath}""")
            scrb.Append(vbCrLf)
            scrb.Append($"Save=""{FilePath}""")
            scrb.Append(vbCrLf)
            Select Case ComboBox1.SelectedIndex
                Case 0, 1, 3 : scrb.Append(My.Resources.FReplace)
                Case 2, 4 : scrb.Append(My.Resources.F4Replace)
            End Select
            IO.File.WriteAllText($"{dir}\scr.txt", scrb.ToString)
            If Not IO.File.Exists(FilePath & ".bak") Then IO.File.Copy(FilePath, FilePath & ".bak")
            rh.Start()
            rh.WaitForExit()
            IO.File.Delete($"{dir}\scr.txt")
            If MsgBox("File Patched, start launcher?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Process.Start(FilePath)
        Else
            MsgBox("No images to load")
        End If
    End Sub

    Public Shared Function LoadBmp(file As String) As Bitmap
        Dim tmp = New Bitmap(file)
        Dim bmp As New Bitmap(tmp.Width, tmp.Height, PixelFormat.Format24bppRgb)
        Dim g = Graphics.FromImage(bmp)
        g.DrawImage(tmp, 0, 0, tmp.Width, tmp.Height)
        g.Dispose()
        tmp.Dispose()
        Return bmp
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FilePath &= ".bak"
        If IO.File.Exists(FilePath) Then
            ExtractImages(False, True)
        Else
            MsgBox("Backup .exe not found")
        End If
        FilePath = FilePath.Substring(0, FilePath.LastIndexOf("."))
    End Sub

    Private Sub Button4_Click() Handles Button4.Click
        If Not IO.Directory.Exists(dir) Then ExtractImages(True, False)
        Using f As New Form2 With {.game = ComboBox1.SelectedIndex}
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExtractImages(False, True)
    End Sub
End Class
