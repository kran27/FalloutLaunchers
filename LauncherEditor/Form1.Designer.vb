<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits AltUI.Forms.DarkForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SelectLauncher = New AltUI.Controls.DarkButton()
        Me.ComboBox1 = New AltUI.Controls.DarkComboBox()
        Me.Label1 = New AltUI.Controls.DarkLabel()
        Me.GroupBox1 = New AltUI.Controls.DarkGroupBox()
        Me.Button4 = New AltUI.Controls.DarkButton()
        Me.Button3 = New AltUI.Controls.DarkButton()
        Me.Button2 = New AltUI.Controls.DarkButton()
        Me.Button1 = New AltUI.Controls.DarkButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectLauncher
        '
        Me.SelectLauncher.FlatBottom = False
        Me.SelectLauncher.FlatTop = False
        Me.SelectLauncher.HoldColour = False
        Me.SelectLauncher.Location = New System.Drawing.Point(14, 14)
        Me.SelectLauncher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SelectLauncher.Name = "SelectLauncher"
        Me.SelectLauncher.Padding = New System.Windows.Forms.Padding(6)
        Me.SelectLauncher.Size = New System.Drawing.Size(212, 27)
        Me.SelectLauncher.TabIndex = 0
        Me.SelectLauncher.Text = "Select Launcher"
        '
        'ComboBox1
        '
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fallout 3", "Fallout: New Vegas", "Fallout 4"})
        Me.ComboBox1.Location = New System.Drawing.Point(85, 47)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Launcher:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(14, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(212, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image Modification"
        '
        'Button4
        '
        Me.Button4.FlatBottom = False
        Me.Button4.FlatTop = False
        Me.Button4.HoldColour = False
        Me.Button4.Location = New System.Drawing.Point(7, 122)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(6)
        Me.Button4.Size = New System.Drawing.Size(198, 27)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Create Theme"
        '
        'Button3
        '
        Me.Button3.FlatBottom = False
        Me.Button3.FlatTop = False
        Me.Button3.HoldColour = False
        Me.Button3.Location = New System.Drawing.Point(7, 89)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(6)
        Me.Button3.Size = New System.Drawing.Size(198, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Restore Images"
        Me.ToolTip1.SetToolTip(Me.Button3, "Extracts images from the backup file")
        '
        'Button2
        '
        Me.Button2.FlatBottom = False
        Me.Button2.FlatTop = False
        Me.Button2.HoldColour = False
        Me.Button2.Location = New System.Drawing.Point(7, 55)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(6)
        Me.Button2.Size = New System.Drawing.Size(198, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Replace Images"
        Me.ToolTip1.SetToolTip(Me.Button2, "Replaces images in the launcher")
        '
        'Button1
        '
        Me.Button1.FlatBottom = False
        Me.Button1.FlatTop = False
        Me.Button1.HoldColour = False
        Me.Button1.Location = New System.Drawing.Point(7, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(6)
        Me.Button1.Size = New System.Drawing.Size(198, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Extract Images"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(240, 248)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SelectLauncher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Launcher Editor"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectLauncher As AltUI.Controls.DarkButton
    Friend WithEvents ComboBox1 As AltUI.Controls.DarkComboBox
    Friend WithEvents Label1 As AltUI.Controls.DarkLabel
    Friend WithEvents GroupBox1 As AltUI.Controls.DarkGroupBox
    Friend WithEvents Button1 As AltUI.Controls.DarkButton
    Friend WithEvents Button2 As AltUI.Controls.DarkButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button3 As AltUI.Controls.DarkButton
    Friend WithEvents Button4 As AltUI.Controls.DarkButton
End Class
