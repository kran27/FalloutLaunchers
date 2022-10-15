Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class Form1
    Private FilePath As String
    Private Sub SelectLauncherC(sender As Object, e As EventArgs) Handles SelectLauncher.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Fallout 3/NV/4 Launcher|*.exe",
            .Multiselect = False
        }
        If ofd.ShowDialog() = DialogResult.OK Then
            FilePath = ofd.FileName
            Dim filename = ofd.FileName.Split("\").Last
            Select Case filename
                Case "FalloutLauncher.exe", "FalloutLauncherSteam.exe" : ComboBox1.SelectedIndex = 0
                Case "FalloutNVLauncher.exe" : ComboBox1.SelectedIndex = 1
                Case "Fallout4Launcher.exe" : ComboBox1.SelectedIndex = 2
                Case Else : MsgBox("Couldn't identify launcher, please select manually")
                    ComboBox1.Enabled = True
            End Select
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("ResourceHacker.exe") Then
            If MsgBox("Resource Hacker not found, would you like to open the download page?", MsgBoxStyle.YesNo, "Dependency Missing") = DialogResult.Yes Then
                MsgBox("Download the ZIP version and extract the .exe to this folder")
                Process.Start("http://www.angusj.com/resourcehacker/#download")
                Process.Start(Application.StartupPath)
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Button1_Click() Handles Button1.Click
        Dim dir = $"{Application.StartupPath}\{ComboBox1.SelectedItem.Replace(":", "")}"
        IO.Directory.CreateDirectory(dir)
        IO.File.Move("ResourceHacker.exe", dir & "\ResourceHacker.exe")
        Dim rh As New Process With {.StartInfo = New ProcessStartInfo With {.FileName = $"ResourceHacker.exe", .Arguments = "-script scr.txt", .WorkingDirectory = dir}}
        Dim scrb As New Text.StringBuilder
        scrb.Append("[FILENAMES]")
        scrb.Append(vbNewLine)
        scrb.Append($"Open=""{FilePath}""")
        scrb.Append(vbNewLine)
        Select Case ComboBox1.SelectedIndex
            Case 0, 1 : scrb.Append(My.Resources.FExtract)
            Case 2 : scrb.Append(My.Resources.F4Extract)
        End Select
        IO.File.WriteAllText($"{dir}\scr.txt", scrb.ToString)
        rh.Start()
        rh.WaitForExit()
        IO.File.Move(dir & "\ResourceHacker.exe", "ResourceHacker.exe")
        IO.File.Delete($"{dir}\ResourceHacker.ini")
        IO.File.Delete($"{dir}\ResourceHacker.log")
        IO.File.Delete($"{dir}\scr.txt")
        MsgBox("Images Extracted")
        Process.Start(dir)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dir = $"{Application.StartupPath}\{ComboBox1.SelectedItem.Replace(":", "")}"
        For Each file As String In IO.Directory.GetFiles(dir)
            Dim f As New IO.FileInfo(file)
            If f.Extension = ".bmp" Then
                Dim bmp = LoadBmp(file)
                bmp.Save(file, ImageFormat.Bmp)
            End If
        Next
        IO.File.Move("ResourceHacker.exe", dir & "\ResourceHacker.exe")
        Dim rh As New Process With {.StartInfo = New ProcessStartInfo With {.FileName = $"ResourceHacker.exe", .Arguments = "-script scr.txt", .WorkingDirectory = dir}}
        Dim scrb As New Text.StringBuilder
        scrb.Append("[FILENAMES]")
        scrb.Append(vbNewLine)
        scrb.Append($"Open=""{FilePath}""")
        scrb.Append(vbNewLine)
        scrb.Append($"Save=""{FilePath}""")
        scrb.Append(vbNewLine)
        Select Case ComboBox1.SelectedIndex
            Case 0, 1 : scrb.Append(My.Resources.FReplace)
            Case 2 : scrb.Append(My.Resources.F4Replace)
        End Select
        IO.File.WriteAllText($"{dir}\scr.txt", scrb.ToString)
        If Not IO.File.Exists(FilePath & ".bak") Then IO.File.Copy(FilePath, FilePath & ".bak")
        rh.Start()
        rh.WaitForExit()
        IO.File.Move(dir & "\ResourceHacker.exe", "ResourceHacker.exe")
        IO.File.Delete($"{dir}\ResourceHacker.ini")
        IO.File.Delete($"{dir}\ResourceHacker.log")
        IO.File.Delete($"{dir}\scr.txt")
        MsgBox("File Patched")
    End Sub

    Private Function LoadBmp(file As String) As Bitmap
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
            Button1_Click()
        Else
            MsgBox("Backup .exe not found")
        End If
        FilePath = FilePath.Substring(0, FilePath.LastIndexOf("."))
    End Sub
End Class
