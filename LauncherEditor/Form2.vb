Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports ImageTools.Tools
Imports LauncherEditor.Form1
Public Class Form2
    Private l As Boolean
    Public sizes As Integer() = {11, 4, 29}
    Public game As Integer
    Private PFont As Font = DefaultFont
    Private OFont As Font = DefaultFont
    Private DFont As Font = DefaultFont
    Private SFont As Font = DefaultFont
    Private CFont As Font = DefaultFont
    Private PCol As Color = Color.White
    Private OCol As Color = Color.White
    Private DCol As Color = Color.White
    Private SCol As Color = Color.White
    Private CCol As Color = Color.White
    Private PFontL As Font = DefaultFont
    Private OFontL As Font = DefaultFont
    Private DFontL As Font = DefaultFont
    Private SFontL As Font = DefaultFont
    Private CFontL As Font = DefaultFont
    Private PColL As Color = Color.White
    Private OColL As Color = Color.White
    Private DColL As Color = Color.White
    Private SColL As Color = Color.White
    Private CColL As Color = Color.White
    Private PBlank As Bitmap
    Private OBlank As Bitmap
    Private DBlank As Bitmap
    Private SBlank As Bitmap
    Private CBlank As Bitmap
    Private PNorm As Bitmap
    Private ONorm As Bitmap
    Private DNorm As Bitmap
    Private SNorm As Bitmap
    Private CNorm As Bitmap
    Private PLit As Bitmap
    Private OLit As Bitmap
    Private DLit As Bitmap
    Private SLit As Bitmap
    Private CLit As Bitmap
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog With {
        .Filter = $"Image ({Background.Size.Width}x{Background.Size.Height})|*.png;*.jpg;*.jpeg;*.bmp", .Multiselect = False
        }
        If ofd.ShowDialog = DialogResult.OK Then
            Dim bmp = LoadBmp(ofd.FileName)
            Dim g = Graphics.FromImage(Background.Image)
            g.DrawImage(bmp, 0, 0, Background.Size.Width, Background.Size.Height)
            Dim tmp = New Bitmap(Background.Image).ToDirectBitmap
            PBlank = tmp.Crop(Play.Location.X - Background.Location.X, Play.Location.Y - Background.Location.Y, Play.Size).Bitmap
            Play.Image.CopyFrom(PBlank) : PNorm.CopyFrom(PBlank) : PLit.CopyFrom(PBlank)
            OBlank = tmp.Crop(Options.Location.X - Background.Location.X, Options.Location.Y - Background.Location.Y, Options.Size).Bitmap
            Options.Image.CopyFrom(OBlank) : ONorm.CopyFrom(OBlank) : OLit.CopyFrom(OBlank)
            If DataFiles.Visible Then
                DBlank = tmp.Crop(DataFiles.Location.X - Background.Location.X, DataFiles.Location.Y - Background.Location.Y, DataFiles.Size).Bitmap
                DataFiles.Image.CopyFrom(DBlank) : DNorm.CopyFrom(DBlank) : DLit.CopyFrom(DBlank)
            End If
            SBlank = tmp.Crop(Support.Location.X - Background.Location.X, Support.Location.Y - Background.Location.Y, Support.Size).Bitmap
            Support.Image.CopyFrom(SBlank) : SNorm.CopyFrom(SBlank) : SLit.CopyFrom(SBlank)
            CBlank = tmp.Crop(Close.Location.X - Background.Location.X, Close.Location.Y - Background.Location.Y, Close.Size).Bitmap
            Close.Image.CopyFrom(CBlank) : CNorm.CopyFrom(CBlank) : CLit.CopyFrom(CBlank)
            DrawAll()
            Background.Refresh()
            DarkGroupBox1.Enabled = True
        End If
    End Sub

    Private Sub SetFont(sender As Object, e As EventArgs) Handles DarkButton1.Click, DarkButton2.Click, DarkButton3.Click, DarkButton4.Click, DarkButton5.Click
        Dim fd As New FontDialog
        If fd.ShowDialog() = DialogResult.OK Then
            If l Then
                If sender.Equals(DarkButton1) Then
                    PFontL = fd.Font
                ElseIf sender.Equals(DarkButton2) Then
                    OFontL = fd.Font
                ElseIf sender.Equals(DarkButton3) Then
                    DFontL = fd.Font
                ElseIf sender.Equals(DarkButton4) Then
                    SFontL = fd.Font
                Else
                    CFontL = fd.Font
                End If
            Else
                If sender.Equals(DarkButton1) Then
                    PFont = fd.Font
                ElseIf sender.Equals(DarkButton2) Then
                    OFont = fd.Font
                ElseIf sender.Equals(DarkButton3) Then
                    DFont = fd.Font
                ElseIf sender.Equals(DarkButton4) Then
                    SFont = fd.Font
                Else
                    CFont = fd.Font
                End If
            End If

            DrawAll()
        End If
    End Sub
    Private Sub SetColour(sender As Object, e As EventArgs) Handles DarkButton7.Click, DarkButton8.Click, DarkButton9.Click, DarkButton10.Click, DarkButton11.Click
        Dim cp = New ColorDialog
        If cp.ShowDialog = DialogResult.OK Then
            If l Then
                If sender.Equals(DarkButton7) Then
                    PColL = cp.Color
                ElseIf sender.Equals(DarkButton8) Then
                    OColL = cp.Color
                ElseIf sender.Equals(DarkButton9) Then
                    DColL = cp.Color
                ElseIf sender.Equals(DarkButton10) Then
                    SColL = cp.Color
                Else
                    CColL = cp.Color
                End If
            Else
                If sender.Equals(DarkButton7) Then
                    PCol = cp.Color
                ElseIf sender.Equals(DarkButton8) Then
                    OCol = cp.Color
                ElseIf sender.Equals(DarkButton9) Then
                    DCol = cp.Color
                ElseIf sender.Equals(DarkButton10) Then
                    SCol = cp.Color
                Else
                    CCol = cp.Color
                End If
            End If
            DrawAll()
        End If
    End Sub

    Private Sub DrawButton(t As String, f As Font, c As Color, ByVal blank As Bitmap, ByRef hold As Bitmap, ByRef pb As PictureBox, Optional savePath As String = "")
        Dim tmp As New Bitmap(blank.Width, blank.Height)
        Dim g = Graphics.FromImage(tmp)
        g.DrawImage(blank, 0, 0, blank.Width, blank.Height)
        pb.Image = tmp
        g = Graphics.FromImage(pb.Image)
        Dim s As SizeF = g.MeasureString(t, f)
        g.DrawString(t, f, New SolidBrush(c), New PointF(pb.Size.Width - s.Width - sizes(game), pb.Size.Height / 2 - s.Height / 2))
        hold.CopyFrom(pb.Image)
        If Not savePath = "" Then hold.Save(savePath)
        pb.Refresh()
        g.Dispose()
    End Sub

    Private Sub DarkButton6_Click() Handles DarkButton6.Click
        If l Then
            OFontL = PFontL
            DFontL = PFontL
            SFontL = PFontL
            CFontL = PFontL
        Else
            OFont = PFont
            DFont = PFont
            SFont = PFont
            CFont = PFont
        End If
        DrawAll()
    End Sub
    Private Sub DarkButton12_Click(sender As Object, e As EventArgs) Handles DarkButton12.Click
        If l Then
            OColL = PColL
            DColL = PColL
            SColL = PColL
            CColL = PColL
        Else
            OCol = PCol
            DCol = PCol
            SCol = PCol
            CCol = PCol
        End If
        DrawAll()
    End Sub

    Private Sub DrawAll(Optional Save As Boolean = False)
        If DarkGroupBox1.Enabled Then
            DrawButton(TextBox1.Text, If(l, PFontL, PFont), If(l, PColL, PCol), PBlank, If(l, PLit, PNorm), Play, If(Save, If(l, Form1.dir & "\PlayLit.bmp", Form1.dir & "\Play.bmp"), ""))
            DrawButton(DarkTextBox1.Text, If(l, OFontL, OFont), If(l, OColL, OCol), OBlank, If(l, OLit, ONorm), Options, If(Save, If(l, Form1.dir & "\OptionsLit.bmp", Form1.dir & "\Options.bmp"), ""))
            If DarkGroupBox4.Enabled Then DrawButton(DarkTextBox2.Text, If(l, DFontL, DFont), If(l, DColL, DCol), DBlank, If(l, DLit, DNorm), DataFiles, If(Save, If(l, Form1.dir & "\DataFilesLit.bmp", Form1.dir & "\DataFiles.bmp"), ""))
            DrawButton(DarkTextBox3.Text, If(l, SFontL, SFont), If(l, SColL, SCol), SBlank, If(l, SLit, SNorm), Support, If(Save, If(l, Form1.dir & "\SupportLit.bmp", Form1.dir & "\Support.bmp"), ""))
            DrawButton(DarkTextBox4.Text, If(l, CFontL, CFont), If(l, CColL, CCol), CBlank, If(l, CLit, CNorm), Close, If(Save, If(l, Form1.dir & "\ExitLit.bmp", Form1.dir & "\Exit.bmp"), ""))
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, DarkTextBox1.TextChanged, DarkTextBox2.TextChanged, DarkTextBox3.TextChanged, DarkTextBox4.TextChanged
        DrawAll()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        l = CheckBox1.Checked
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
        If l Then
            PColL = PCol
            OColL = OCol
            DColL = DCol
            SColL = SCol
            CColL = CCol
            PFontL = PFont
            OFontL = OFont
            DFontL = DFont
            SFontL = SFont
            CFontL = CFont
        Else
            PCol = PColL
            OCol = OColL
            DCol = DColL
            SCol = SColL
            CCol = CColL
            PFont = PFontL
            OFont = OFontL
            DFont = DFontL
            SFont = SFontL
            CFont = CFontL
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
End Module