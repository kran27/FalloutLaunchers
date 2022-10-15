Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports ImageTools.Tools
Imports LauncherEditor.Form1
Public Class Form2
    Private l As Boolean
    Public sizes As Integer() = {11, 4, 29}
    Public game As Integer
    Private PFont As Font() = {DefaultFont, DefaultFont}
    Private OFont As Font() = {DefaultFont, DefaultFont}
    Private DFont As Font() = {DefaultFont, DefaultFont}
    Private SFont As Font() = {DefaultFont, DefaultFont}
    Private CFont As Font() = {DefaultFont, DefaultFont}
    Private PCol As Color() = {Color.White, Color.White}
    Private OCol As Color() = {Color.White, Color.White}
    Private DCol As Color() = {Color.White, Color.White}
    Private SCol As Color() = {Color.White, Color.White}
    Private CCol As Color() = {Color.White, Color.White}
    Private PECol As Color() = {Color.Black, Color.Black}
    Private OECol As Color() = {Color.Black, Color.Black}
    Private DECol As Color() = {Color.Black, Color.Black}
    Private SECol As Color() = {Color.Black, Color.Black}
    Private CECol As Color() = {Color.Black, Color.Black}
    Private PEff As Integer() = {0, 0}
    Private OEff As Integer() = {0, 0}
    Private DEff As Integer() = {0, 0}
    Private SEff As Integer() = {0, 0}
    Private CEff As Integer() = {0, 0}
    Private PBlank As Bitmap
    Private OBlank As Bitmap
    Private DBlank As Bitmap
    Private SBlank As Bitmap
    Private CBlank As Bitmap
    Private PImg As Bitmap() = {New Bitmap(1, 1), New Bitmap(1, 1)}
    Private OImg As Bitmap() = {New Bitmap(1, 1), New Bitmap(1, 1)}
    Private DImg As Bitmap() = {New Bitmap(1, 1), New Bitmap(1, 1)}
    Private SImg As Bitmap() = {New Bitmap(1, 1), New Bitmap(1, 1)}
    Private CImg As Bitmap() = {New Bitmap(1, 1), New Bitmap(1, 1)}
    Private test As String() = {"string index 0", "string index 1"}
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Background.SendToBack()
        Select Case game
            Case 0
                Background.Size = New Size(794, 390)
                Background.Location = New Size(GroupBox1.Width / 2 - Background.Width / 2, GroupBox1.Height / 2 - Background.Height / 2)
                Background.Image = LoadBmp(Form1.dir & "\Background.bmp")
                Play.Size = New Size(108, 44)
                Play.Location = New Point(648 + Background.Location.X, 87 + Background.Location.Y)
                Play.Image = LoadBmp(Form1.dir & "\Play.bmp")
                Options.Size = New Size(99, 39)
                Options.Location = New Point(657 + Background.Location.X, 144 + Background.Location.Y)
                Options.Image = LoadBmp(Form1.dir & "\Options.bmp")
                DataFiles.Size = New Size(115, 39)
                DataFiles.Location = New Point(641 + Background.Location.X, 184 + Background.Location.Y)
                DataFiles.Image = LoadBmp(Form1.dir & "\DataFiles.bmp")
                Support.Size = New Size(152, 39)
                Support.Location = New Point(604 + Background.Location.X, 224 + Background.Location.Y)
                Support.Image = LoadBmp(Form1.dir & "\Support.bmp")
                Close.Size = New Size(58, 39)
                Close.Location = New Point(698 + Background.Location.X, 263 + Background.Location.Y)
                Close.Image = LoadBmp(Form1.dir & "\Exit.bmp")
            Case 1
                Background.Size = New Size(794, 390)
                Background.Location = New Size(GroupBox1.Width / 2 - Background.Width / 2, GroupBox1.Height / 2 - Background.Height / 2)
                Background.Image = LoadBmp(Form1.dir & "\Background.bmp")
                Play.Size = New Size(221, 53)
                Play.Location = New Point(552 + Background.Location.X, 81 + Background.Location.Y)
                Play.Image = LoadBmp(Form1.dir & "\Play.bmp")
                Options.Size = New Size(221, 50)
                Options.Location = New Point(552 + Background.Location.X, 134 + Background.Location.Y)
                Options.Image = LoadBmp(Form1.dir & "\Options.bmp")
                DataFiles.Size = New Size(221, 47)
                DataFiles.Location = New Point(552 + Background.Location.X, 184 + Background.Location.Y)
                DataFiles.Image = LoadBmp(Form1.dir & "\DataFiles.bmp")
                Support.Size = New Size(221, 44)
                Support.Location = New Point(552 + Background.Location.X, 231 + Background.Location.Y)
                Support.Image = LoadBmp(Form1.dir & "\Support.bmp")
                Close.Size = New Size(221, 45)
                Close.Location = New Point(552 + Background.Location.X, 275 + Background.Location.Y)
                Close.Image = LoadBmp(Form1.dir & "\Exit.bmp")
            Case 2
                Background.Size = New Size(835, 400)
                Background.Location = New Size(GroupBox1.Width / 2 - Background.Width / 2, GroupBox1.Height / 2 - Background.Height / 2)
                DarkGroupBox4.Enabled = False
                Background.Image = LoadBmp(Form1.dir & "\Background.bmp")
                Play.Size = New Size(275, 50)
                Play.Location = New Point(560 + Background.Location.X, 25 + Background.Location.Y)
                Play.Image = LoadBmp(Form1.dir & "\Play.bmp")
                Options.Size = New Size(275, 50)
                Options.Location = New Point(560 + Background.Location.X, 75 + Background.Location.Y)
                Options.Image = LoadBmp(Form1.dir & "\Options.bmp")
                DataFiles.Hide()
                Support.Size = New Size(275, 50)
                Support.Location = New Point(560 + Background.Location.X, 125 + Background.Location.Y)
                Support.Image = LoadBmp(Form1.dir & "\Support.bmp")
                Close.Size = New Size(275, 50)
                Close.Location = New Point(560 + Background.Location.X, 175 + Background.Location.Y)
                Close.Image = LoadBmp(Form1.dir & "\Exit.bmp")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, DarkButton22.Click
        Dim bmp = New Bitmap(1, 1)
        If sender.Equals(DarkButton22) Then GoTo LoadCurrent
        Dim ofd As New OpenFileDialog With {
        .Filter = $"Image ({Background.Size.Width}x{Background.Size.Height})|*.png;*.jpg;*.jpeg;*.bmp", .Multiselect = False
        }
        If ofd.ShowDialog = DialogResult.OK Then
            bmp = LoadBmp(ofd.FileName)
            GoTo Loaded
LoadCurrent:
            bmp = LoadBmp(Form1.dir & "\Background.bmp")
Loaded:
            Dim g = Graphics.FromImage(Background.Image)
            g.DrawImage(bmp, 0, 0, Background.Size.Width, Background.Size.Height)
            Dim tmp = New Bitmap(Background.Image).ToDirectBitmap
            PBlank = tmp.Crop(Play.Location.X - Background.Location.X, Play.Location.Y - Background.Location.Y, Play.Size).Bitmap
            Play.Image.CopyFrom(PBlank) : PImg(0).CopyFrom(PBlank) : PImg(1).CopyFrom(PBlank)
            OBlank = tmp.Crop(Options.Location.X - Background.Location.X, Options.Location.Y - Background.Location.Y, Options.Size).Bitmap
            Options.Image.CopyFrom(OBlank) : OImg(0).CopyFrom(OBlank) : OImg(1).CopyFrom(OBlank)
            If DataFiles.Visible Then
                DBlank = tmp.Crop(DataFiles.Location.X - Background.Location.X, DataFiles.Location.Y - Background.Location.Y, DataFiles.Size).Bitmap
                DataFiles.Image.CopyFrom(DBlank) : DImg(0).CopyFrom(DBlank) : DImg(1).CopyFrom(DBlank)
            End If
            SBlank = tmp.Crop(Support.Location.X - Background.Location.X, Support.Location.Y - Background.Location.Y, Support.Size).Bitmap
            Support.Image.CopyFrom(SBlank) : SImg(0).CopyFrom(SBlank) : SImg(1).CopyFrom(SBlank)
            CBlank = tmp.Crop(Close.Location.X - Background.Location.X, Close.Location.Y - Background.Location.Y, Close.Size).Bitmap
            Close.Image.CopyFrom(CBlank) : SImg(0).CopyFrom(CBlank) : SImg(1).CopyFrom(CBlank)
            Background.Refresh()
            DarkComboBox1.SelectedIndex = 0 : DarkComboBox2.SelectedIndex = 0 : DarkComboBox3.SelectedIndex = 0 : DarkComboBox4.SelectedIndex = 0 : DarkComboBox5.SelectedIndex = 0
            DarkGroupBox1.Enabled = True
            DrawAll()
        End If
    End Sub

    Private Sub SetFont(sender As Object, e As EventArgs) Handles DarkButton1.Click, DarkButton2.Click, DarkButton3.Click, DarkButton4.Click, DarkButton5.Click
        Dim fd As New FontDialog
        If fd.ShowDialog() = DialogResult.OK Then
            If sender.Equals(DarkButton1) Then
                PFont(l.i) = fd.Font
            ElseIf sender.Equals(DarkButton2) Then
                OFont(l.i) = fd.Font
            ElseIf sender.Equals(DarkButton3) Then
                DFont(l.i) = fd.Font
            ElseIf sender.Equals(DarkButton4) Then
                SFont(l.i) = fd.Font
            Else
                CFont(l.i) = fd.Font
            End If
            DrawAll()
        End If
    End Sub
    Private Sub SetColour(sender As Object, e As EventArgs) Handles DarkButton7.Click, DarkButton8.Click, DarkButton9.Click, DarkButton10.Click, DarkButton11.Click
        Dim cp = New ColorDialog
        If cp.ShowDialog = DialogResult.OK Then

            If sender.Equals(DarkButton7) Then
                PCol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton8) Then
                OCol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton9) Then
                DCol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton10) Then
                SCol(l.i) = cp.Color
            Else
                CCol(l.i) = cp.Color
            End If
            DrawAll()
        End If
    End Sub
    Private Sub SetEffCol(sender As Object, e As EventArgs) Handles DarkButton17.Click, DarkButton18.Click, DarkButton19.Click, DarkButton20.Click, DarkButton21.Click
        Dim cp = New ColorDialog
        If cp.ShowDialog = DialogResult.OK Then
            If sender.Equals(DarkButton17) Then
                PECol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton18) Then
                OECol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton19) Then
                DECol(l.i) = cp.Color
            ElseIf sender.Equals(DarkButton20) Then
                SECol(l.i) = cp.Color
            Else
                CECol(l.i) = cp.Color
            End If
            DrawAll()
        End If
    End Sub

    Private Sub DrawButton(t As String, f As Font, c As Color, ec As Color, ByVal blank As Bitmap, ByRef hold As Bitmap, ByRef pb As PictureBox, ei As Integer, Optional savePath As String = "")
        Dim tmp As New Bitmap(blank.Width, blank.Height)
        Dim g = Graphics.FromImage(tmp)
        g.DrawImage(blank, 0, 0, blank.Width, blank.Height)
        pb.Image = tmp
        g = Graphics.FromImage(pb.Image)
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim s As SizeF = g.MeasureString(t, f)
        Dim p = New GraphicsPath
        p.AddString(t, f.FontFamily, f.Style, g.DpiY * f.SizeInPoints / 72, New Point(pb.Size.Width - s.Width - sizes(game), pb.Size.Height / 2 - s.Height / 2), StringFormat.GenericDefault)
        Select Case ei
            Case 1
                g.DrawPath(New Pen(ec, 3), p)
            Case 2
                Dim blur As New Bitmap(blank.Width, blank.Height)
                Using g2 = Graphics.FromImage(blur)
                    g2.FillPath(New SolidBrush(ec), p)
                End Using
                blur = ApplyBlur(blur, 10, 10, ec, True)
                blur.Save("test.png")
                g.DrawImage(blur, 0, 0, blank.Width, blank.Height)
        End Select
        g.FillPath(New SolidBrush(c), p)
        hold.CopyFrom(pb.Image)
        If Not savePath = "" Then hold.Save(savePath)
        pb.Refresh()
        g.Dispose()
    End Sub

    Private Sub MatchFont() Handles DarkButton6.Click
        OFont(l.i) = PFont(l.i)
        DFont(l.i) = PFont(l.i)
        SFont(l.i) = PFont(l.i)
        CFont(l.i) = PFont(l.i)
        DrawAll()
    End Sub
    Private Sub MatchCol(sender As Object, e As EventArgs) Handles DarkButton12.Click
        OCol(l.i) = PCol(l.i)
        DCol(l.i) = PCol(l.i)
        SCol(l.i) = PCol(l.i)
        CCol(l.i) = PCol(l.i)
        DrawAll()
    End Sub
    Private Sub MatchEff(sender As Object, e As EventArgs) Handles DarkButton15.Click
        OEff(l.i) = PEff(l.i)
        DEff(l.i) = PEff(l.i)
        SEff(l.i) = PEff(l.i)
        CEff(l.i) = PEff(l.i)
        DarkComboBox2.SelectedIndex = OEff(l.i)
        DarkComboBox3.SelectedIndex = DEff(l.i)
        DarkComboBox4.SelectedIndex = SEff(l.i)
        DarkComboBox5.SelectedIndex = CEff(l.i)
        DrawAll()
    End Sub
    Private Sub MatchEffCol(sender As Object, e As EventArgs) Handles DarkButton16.Click
        OECol(l.i) = PECol(l.i)
        DECol(l.i) = PECol(l.i)
        SECol(l.i) = PECol(l.i)
        CECol(l.i) = PECol(l.i)
        DrawAll()
    End Sub

    Private Sub DrawAll(Optional Save As Boolean = False)
        If DarkGroupBox1.Enabled Then
            DrawButton(TextBox1.Text, PFont(l.i), PCol(l.i), PECol(l.i), PBlank, PImg(l.i), Play, PEff(l.i), If(Save, If(l, Form1.dir & "\PlayLit.bmp", Form1.dir & "\Play.bmp"), ""))
            DrawButton(DarkTextBox1.Text, OFont(l.i), OCol(l.i), OECol(l.i), OBlank, OImg(l.i), Options, OEff(l.i), If(Save, If(l, Form1.dir & "\OptionsLit.bmp", Form1.dir & "\Options.bmp"), ""))
            If DarkGroupBox4.Enabled Then DrawButton(DarkTextBox2.Text, DFont(l.i), DCol(l.i), DECol(l.i), DBlank, DImg(l.i), DataFiles, DEff(l.i), If(Save, If(l, Form1.dir & "\DataFilesLit.bmp", Form1.dir & "\DataFiles.bmp"), ""))
            DrawButton(DarkTextBox3.Text, SFont(l.i), SCol(l.i), SECol(l.i), SBlank, SImg(l.i), Support, SEff(l.i), If(Save, If(l, Form1.dir & "\SupportLit.bmp", Form1.dir & "\Support.bmp"), ""))
            DrawButton(DarkTextBox4.Text, CFont(l.i), CCol(l.i), CECol(l.i), CBlank, CImg(l.i), Close, CEff(l.i), If(Save, If(l, Form1.dir & "\ExitLit.bmp", Form1.dir & "\Exit.bmp"), ""))
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, DarkTextBox1.TextChanged, DarkTextBox2.TextChanged, DarkTextBox3.TextChanged, DarkTextBox4.TextChanged
        DrawAll()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        l = CheckBox1.Checked
        DarkComboBox1.SelectedIndex = PEff(l.i)
        DarkComboBox2.SelectedIndex = OEff(l.i)
        DarkComboBox3.SelectedIndex = DEff(l.i)
        DarkComboBox4.SelectedIndex = SEff(l.i)
        DarkComboBox5.SelectedIndex = CEff(l.i)
        DrawAll()
    End Sub

    Private Sub DarkButton13_Click(sender As Object, e As EventArgs) Handles DarkButton13.Click
        Background.Image.Save(Form1.dir & "\Background.bmp")
        DrawAll(True)
        l = Not l
        DrawAll(True)
        l = Not l
        If MsgBox("Theme Exported, Apply Changes to Launcher?", MsgBoxStyle.YesNo, "Apply Changes?") = MsgBoxResult.Yes Then
            Form1.ApplyChanges()
        End If
        Hide()
    End Sub

    Private Sub DarkButton14_Click(sender As Object, e As EventArgs) Handles DarkButton14.Click
        PCol(l.i) = PCol((Not l).i)
        OCol(l.i) = OCol((Not l).i)
        DCol(l.i) = DCol((Not l).i)
        SCol(l.i) = SCol((Not l).i)
        CCol(l.i) = CCol((Not l).i)
        PFont(l.i) = PFont((Not l).i)
        OFont(l.i) = OFont((Not l).i)
        DFont(l.i) = DFont((Not l).i)
        SFont(l.i) = SFont((Not l).i)
        CFont(l.i) = CFont((Not l).i)
        PEff(l.i) = PEff((Not l).i)
        OEff(l.i) = OEff((Not l).i)
        DEff(l.i) = DEff((Not l).i)
        SEff(l.i) = SEff((Not l).i)
        CEff(l.i) = CEff((Not l).i)
        DarkComboBox1.SelectedIndex = PEff(l.i)
        DarkComboBox2.SelectedIndex = OEff(l.i)
        DarkComboBox3.SelectedIndex = DEff(l.i)
        DarkComboBox4.SelectedIndex = SEff(l.i)
        DarkComboBox5.SelectedIndex = CEff(l.i)
        PECol(l.i) = PECol((Not l).i)
        OECol(l.i) = OECol((Not l).i)
        DECol(l.i) = DECol((Not l).i)
        SECol(l.i) = SECol((Not l).i)
        CECol(l.i) = CECol((Not l).i)
        DrawAll()
    End Sub

    Private Sub DarkComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DarkComboBox1.SelectedIndexChanged, DarkComboBox2.SelectedIndexChanged, DarkComboBox3.SelectedIndexChanged, DarkComboBox4.SelectedIndexChanged, DarkComboBox5.SelectedIndexChanged
        If sender.Equals(DarkComboBox1) Then
            PEff(l.i) = sender.SelectedIndex
        ElseIf sender.Equals(DarkComboBox2) Then
            OEff(l.i) = sender.SelectedIndex
        ElseIf sender.Equals(DarkComboBox3) Then
            DEff(l.i) = sender.SelectedIndex
        ElseIf sender.Equals(DarkComboBox4) Then
            SEff(l.i) = sender.SelectedIndex
        Else
            CEff(l.i) = sender.SelectedIndex
        End If
        DrawAll()
    End Sub
End Class
Public Module BitmapCopy
    <Extension()>
    Public Sub CopyFrom(ByRef img As Image, bmp As Bitmap)
        Dim tmp As New Bitmap(bmp.Width, bmp.Height)
        Using g = Graphics.FromImage(tmp)
            g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height)
        End Using
        img = tmp
    End Sub
    <Extension()>
    Public Function i(b As Boolean) As Integer
        Return Convert.ToInt32(b)
    End Function
End Module