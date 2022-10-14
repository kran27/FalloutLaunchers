using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Tactics.My;

namespace Tactics;

[DesignerGenerated]
public class English : Form
{
	private IContainer components;

	[AccessedThroughProperty("LaunchBox")]
	private PictureBox _LaunchBox;

	[AccessedThroughProperty("ReadMeBox")]
	private PictureBox _ReadMeBox;

	[AccessedThroughProperty("QuitBox")]
	private PictureBox _QuitBox;

	[AccessedThroughProperty("TS")]
	private PictureBox _TS;

	[AccessedThroughProperty("Play_FR")]
	private PictureBox _Play_FR;

	[AccessedThroughProperty("RM_FR")]
	private PictureBox _RM_FR;

	[AccessedThroughProperty("TS_FR")]
	private PictureBox _TS_FR;

	[AccessedThroughProperty("Play_Button_Pressed")]
	private PictureBox _Play_Button_Pressed;

	[AccessedThroughProperty("RM_Button_Pressed")]
	private PictureBox _RM_Button_Pressed;

	[AccessedThroughProperty("TS_Button_Pressed")]
	private PictureBox _TS_Button_Pressed;

	[AccessedThroughProperty("Exit_Button_Pressed")]
	private PictureBox _Exit_Button_Pressed;

	[AccessedThroughProperty("Exit_Button")]
	private PictureBox _Exit_Button;

	[AccessedThroughProperty("TS_button")]
	private PictureBox _TS_button;

	[AccessedThroughProperty("RM_Button")]
	private PictureBox _RM_Button;

	[AccessedThroughProperty("Play_Button")]
	private PictureBox _Play_Button;

	[AccessedThroughProperty("Exit_FR")]
	private PictureBox _Exit_FR;

	[AccessedThroughProperty("Play_DE")]
	private PictureBox _Play_DE;

	[AccessedThroughProperty("RM_DE")]
	private PictureBox _RM_DE;

	[AccessedThroughProperty("TS_De")]
	private PictureBox _TS_De;

	[AccessedThroughProperty("Exit_DE")]
	private PictureBox _Exit_DE;

	private static IniFile ini = new IniFile(".\\tactics.cfg");

	private static object lang = ini.ReadValue("system", "language");

	private string url;

	private object exe;

	private object exe2;

	internal virtual PictureBox LaunchBox
	{
		get
		{
			return _LaunchBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = LaunchPressed_MouseLeave;
			EventHandler value3 = Play_Click;
			EventHandler value4 = LaunchBox_MouseHover;
			if (_LaunchBox != null)
			{
				_LaunchBox.MouseLeave -= value2;
				_LaunchBox.Click -= value3;
				_LaunchBox.MouseEnter -= value4;
			}
			_LaunchBox = value;
			if (_LaunchBox != null)
			{
				_LaunchBox.MouseLeave += value2;
				_LaunchBox.Click += value3;
				_LaunchBox.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox ReadMeBox
	{
		get
		{
			return _ReadMeBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = ReadMe_MouseHover;
			EventHandler value4 = Readme_Click;
			if (_ReadMeBox != null)
			{
				_ReadMeBox.MouseLeave -= value2;
				_ReadMeBox.MouseEnter -= value3;
				_ReadMeBox.Click -= value4;
			}
			_ReadMeBox = value;
			if (_ReadMeBox != null)
			{
				_ReadMeBox.MouseLeave += value2;
				_ReadMeBox.MouseEnter += value3;
				_ReadMeBox.Click += value4;
			}
		}
	}

	internal virtual PictureBox QuitBox
	{
		get
		{
			return _QuitBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Click;
			EventHandler value4 = Exit_Mouseleave;
			if (_QuitBox != null)
			{
				_QuitBox.MouseEnter -= value2;
				_QuitBox.Click -= value3;
				_QuitBox.MouseLeave -= value4;
			}
			_QuitBox = value;
			if (_QuitBox != null)
			{
				_QuitBox.MouseEnter += value2;
				_QuitBox.Click += value3;
				_QuitBox.MouseLeave += value4;
			}
		}
	}

	internal virtual PictureBox TS
	{
		get
		{
			return _TS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_mouseleave;
			EventHandler value3 = TS_MouseHover;
			EventHandler value4 = TS_Pressed_Click;
			if (_TS != null)
			{
				_TS.MouseLeave -= value2;
				_TS.MouseEnter -= value3;
				_TS.Click -= value4;
			}
			_TS = value;
			if (_TS != null)
			{
				_TS.MouseLeave += value2;
				_TS.MouseEnter += value3;
				_TS.Click += value4;
			}
		}
	}

	internal virtual PictureBox Play_FR
	{
		get
		{
			return _Play_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = LaunchPressed_MouseLeave;
			EventHandler value3 = Play_Click;
			EventHandler value4 = LaunchBox_MouseHover;
			if (_Play_FR != null)
			{
				_Play_FR.MouseLeave -= value2;
				_Play_FR.Click -= value3;
				_Play_FR.MouseEnter -= value4;
			}
			_Play_FR = value;
			if (_Play_FR != null)
			{
				_Play_FR.MouseLeave += value2;
				_Play_FR.Click += value3;
				_Play_FR.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox RM_FR
	{
		get
		{
			return _RM_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = ReadMe_MouseHover;
			EventHandler value4 = Readme_Click;
			if (_RM_FR != null)
			{
				_RM_FR.MouseLeave -= value2;
				_RM_FR.MouseEnter -= value3;
				_RM_FR.Click -= value4;
			}
			_RM_FR = value;
			if (_RM_FR != null)
			{
				_RM_FR.MouseLeave += value2;
				_RM_FR.MouseEnter += value3;
				_RM_FR.Click += value4;
			}
		}
	}

	internal virtual PictureBox TS_FR
	{
		get
		{
			return _TS_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_mouseleave;
			EventHandler value3 = TS_MouseHover;
			EventHandler value4 = TS_Pressed_Click;
			if (_TS_FR != null)
			{
				_TS_FR.MouseLeave -= value2;
				_TS_FR.MouseEnter -= value3;
				_TS_FR.Click -= value4;
			}
			_TS_FR = value;
			if (_TS_FR != null)
			{
				_TS_FR.MouseLeave += value2;
				_TS_FR.MouseEnter += value3;
				_TS_FR.Click += value4;
			}
		}
	}

	internal virtual PictureBox Play_Button_Pressed
	{
		get
		{
			return _Play_Button_Pressed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = LaunchPressed_MouseLeave;
			EventHandler value3 = Play_Click;
			EventHandler value4 = LaunchBox_MouseHover;
			if (_Play_Button_Pressed != null)
			{
				_Play_Button_Pressed.MouseLeave -= value2;
				_Play_Button_Pressed.Click -= value3;
				_Play_Button_Pressed.MouseEnter -= value4;
			}
			_Play_Button_Pressed = value;
			if (_Play_Button_Pressed != null)
			{
				_Play_Button_Pressed.MouseLeave += value2;
				_Play_Button_Pressed.Click += value3;
				_Play_Button_Pressed.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox RM_Button_Pressed
	{
		get
		{
			return _RM_Button_Pressed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = Readme_Click;
			if (_RM_Button_Pressed != null)
			{
				_RM_Button_Pressed.MouseLeave -= value2;
				_RM_Button_Pressed.Click -= value3;
			}
			_RM_Button_Pressed = value;
			if (_RM_Button_Pressed != null)
			{
				_RM_Button_Pressed.MouseLeave += value2;
				_RM_Button_Pressed.Click += value3;
			}
		}
	}

	internal virtual PictureBox TS_Button_Pressed
	{
		get
		{
			return _TS_Button_Pressed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_mouseleave;
			EventHandler value3 = TS_Pressed_Click;
			if (_TS_Button_Pressed != null)
			{
				_TS_Button_Pressed.MouseLeave -= value2;
				_TS_Button_Pressed.Click -= value3;
			}
			_TS_Button_Pressed = value;
			if (_TS_Button_Pressed != null)
			{
				_TS_Button_Pressed.MouseLeave += value2;
				_TS_Button_Pressed.Click += value3;
			}
		}
	}

	internal virtual PictureBox Exit_Button_Pressed
	{
		get
		{
			return _Exit_Button_Pressed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = Exit_Click;
			EventHandler value3 = Exit_Mouseleave;
			if (_Exit_Button_Pressed != null)
			{
				_Exit_Button_Pressed.Click -= value2;
				_Exit_Button_Pressed.MouseLeave -= value3;
			}
			_Exit_Button_Pressed = value;
			if (_Exit_Button_Pressed != null)
			{
				_Exit_Button_Pressed.Click += value2;
				_Exit_Button_Pressed.MouseLeave += value3;
			}
		}
	}

	internal virtual PictureBox Exit_Button
	{
		get
		{
			return _Exit_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Click;
			if (_Exit_Button != null)
			{
				_Exit_Button.MouseEnter -= value2;
				_Exit_Button.Click -= value3;
			}
			_Exit_Button = value;
			if (_Exit_Button != null)
			{
				_Exit_Button.MouseEnter += value2;
				_Exit_Button.Click += value3;
			}
		}
	}

	internal virtual PictureBox TS_button
	{
		get
		{
			return _TS_button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_MouseHover;
			EventHandler value3 = TS_Pressed_Click;
			if (_TS_button != null)
			{
				_TS_button.MouseEnter -= value2;
				_TS_button.Click -= value3;
			}
			_TS_button = value;
			if (_TS_button != null)
			{
				_TS_button.MouseEnter += value2;
				_TS_button.Click += value3;
			}
		}
	}

	internal virtual PictureBox RM_Button
	{
		get
		{
			return _RM_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMe_MouseHover;
			EventHandler value3 = Readme_Click;
			if (_RM_Button != null)
			{
				_RM_Button.MouseEnter -= value2;
				_RM_Button.Click -= value3;
			}
			_RM_Button = value;
			if (_RM_Button != null)
			{
				_RM_Button.MouseEnter += value2;
				_RM_Button.Click += value3;
			}
		}
	}

	internal virtual PictureBox Play_Button
	{
		get
		{
			return _Play_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			if (_Play_Button != null)
			{
				_Play_Button.Click -= value2;
				_Play_Button.MouseEnter -= value3;
			}
			_Play_Button = value;
			if (_Play_Button != null)
			{
				_Play_Button.Click += value2;
				_Play_Button.MouseEnter += value3;
			}
		}
	}

	internal virtual PictureBox Exit_FR
	{
		get
		{
			return _Exit_FR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Click;
			EventHandler value4 = Exit_Mouseleave;
			if (_Exit_FR != null)
			{
				_Exit_FR.MouseHover -= value2;
				_Exit_FR.Click -= value3;
				_Exit_FR.MouseLeave -= value4;
			}
			_Exit_FR = value;
			if (_Exit_FR != null)
			{
				_Exit_FR.MouseHover += value2;
				_Exit_FR.Click += value3;
				_Exit_FR.MouseLeave += value4;
			}
		}
	}

	internal virtual PictureBox Play_DE
	{
		get
		{
			return _Play_DE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = LaunchPressed_MouseLeave;
			EventHandler value3 = Play_Click;
			EventHandler value4 = LaunchBox_MouseHover;
			if (_Play_DE != null)
			{
				_Play_DE.MouseLeave -= value2;
				_Play_DE.Click -= value3;
				_Play_DE.MouseEnter -= value4;
			}
			_Play_DE = value;
			if (_Play_DE != null)
			{
				_Play_DE.MouseLeave += value2;
				_Play_DE.Click += value3;
				_Play_DE.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox RM_DE
	{
		get
		{
			return _RM_DE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = ReadMe_MouseHover;
			EventHandler value4 = Readme_Click;
			if (_RM_DE != null)
			{
				_RM_DE.MouseLeave -= value2;
				_RM_DE.MouseEnter -= value3;
				_RM_DE.Click -= value4;
			}
			_RM_DE = value;
			if (_RM_DE != null)
			{
				_RM_DE.MouseLeave += value2;
				_RM_DE.MouseEnter += value3;
				_RM_DE.Click += value4;
			}
		}
	}

	internal virtual PictureBox TS_De
	{
		get
		{
			return _TS_De;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_mouseleave;
			EventHandler value3 = TS_MouseHover;
			EventHandler value4 = TS_Pressed_Click;
			if (_TS_De != null)
			{
				_TS_De.MouseLeave -= value2;
				_TS_De.MouseEnter -= value3;
				_TS_De.Click -= value4;
			}
			_TS_De = value;
			if (_TS_De != null)
			{
				_TS_De.MouseLeave += value2;
				_TS_De.MouseEnter += value3;
				_TS_De.Click += value4;
			}
		}
	}

	internal virtual PictureBox Exit_DE
	{
		get
		{
			return _Exit_DE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Click;
			EventHandler value4 = Exit_Mouseleave;
			if (_Exit_DE != null)
			{
				_Exit_DE.MouseHover -= value2;
				_Exit_DE.Click -= value3;
				_Exit_DE.MouseLeave -= value4;
			}
			_Exit_DE = value;
			if (_Exit_DE != null)
			{
				_Exit_DE.MouseHover += value2;
				_Exit_DE.Click += value3;
				_Exit_DE.MouseLeave += value4;
			}
		}
	}

	public English()
	{
		base.Load += Splashscreen1_Load;
		base.Load += Cline_Load;
		url = "http://support.bethsoft.com/";
		exe = "BOS_HR.exe";
		exe2 = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tactics.English));
		this.LaunchBox = new System.Windows.Forms.PictureBox();
		this.ReadMeBox = new System.Windows.Forms.PictureBox();
		this.QuitBox = new System.Windows.Forms.PictureBox();
		this.TS = new System.Windows.Forms.PictureBox();
		this.Play_FR = new System.Windows.Forms.PictureBox();
		this.RM_FR = new System.Windows.Forms.PictureBox();
		this.TS_FR = new System.Windows.Forms.PictureBox();
		this.Play_Button_Pressed = new System.Windows.Forms.PictureBox();
		this.RM_Button_Pressed = new System.Windows.Forms.PictureBox();
		this.TS_Button_Pressed = new System.Windows.Forms.PictureBox();
		this.Exit_Button_Pressed = new System.Windows.Forms.PictureBox();
		this.Exit_Button = new System.Windows.Forms.PictureBox();
		this.TS_button = new System.Windows.Forms.PictureBox();
		this.RM_Button = new System.Windows.Forms.PictureBox();
		this.Play_Button = new System.Windows.Forms.PictureBox();
		this.Exit_FR = new System.Windows.Forms.PictureBox();
		this.Play_DE = new System.Windows.Forms.PictureBox();
		this.RM_DE = new System.Windows.Forms.PictureBox();
		this.TS_De = new System.Windows.Forms.PictureBox();
		this.Exit_DE = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.LaunchBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ReadMeBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.QuitBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_FR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RM_FR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_FR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_Button_Pressed).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RM_Button_Pressed).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_Button_Pressed).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_Button_Pressed).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_Button).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_button).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RM_Button).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_Button).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_FR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_DE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RM_DE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_De).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_DE).BeginInit();
		this.SuspendLayout();
		this.LaunchBox.BackColor = System.Drawing.Color.Transparent;
		this.LaunchBox.Image = (System.Drawing.Image)resources.GetObject("LaunchBox.Image");
		System.Drawing.Point point2 = (this.LaunchBox.Location = new System.Drawing.Point(399, 23));
		this.LaunchBox.Name = "LaunchBox";
		System.Drawing.Size size2 = (this.LaunchBox.Size = new System.Drawing.Size(215, 34));
		this.LaunchBox.TabIndex = 2;
		this.LaunchBox.TabStop = false;
		this.ReadMeBox.BackColor = System.Drawing.Color.Transparent;
		this.ReadMeBox.Image = (System.Drawing.Image)resources.GetObject("ReadMeBox.Image");
		point2 = (this.ReadMeBox.Location = new System.Drawing.Point(399, 65));
		this.ReadMeBox.Name = "ReadMeBox";
		size2 = (this.ReadMeBox.Size = new System.Drawing.Size(215, 36));
		this.ReadMeBox.TabIndex = 3;
		this.ReadMeBox.TabStop = false;
		this.QuitBox.BackColor = System.Drawing.Color.Transparent;
		this.QuitBox.Image = (System.Drawing.Image)resources.GetObject("QuitBox.Image");
		point2 = (this.QuitBox.Location = new System.Drawing.Point(399, 150));
		this.QuitBox.Name = "QuitBox";
		size2 = (this.QuitBox.Size = new System.Drawing.Size(224, 32));
		this.QuitBox.TabIndex = 4;
		this.QuitBox.TabStop = false;
		this.TS.BackColor = System.Drawing.Color.Transparent;
		this.TS.Image = (System.Drawing.Image)resources.GetObject("TS.Image");
		point2 = (this.TS.Location = new System.Drawing.Point(400, 107));
		this.TS.Name = "TS";
		size2 = (this.TS.Size = new System.Drawing.Size(214, 33));
		this.TS.TabIndex = 9;
		this.TS.TabStop = false;
		this.Play_FR.BackColor = System.Drawing.Color.Transparent;
		this.Play_FR.Image = (System.Drawing.Image)resources.GetObject("Play_FR.Image");
		point2 = (this.Play_FR.Location = new System.Drawing.Point(399, 23));
		this.Play_FR.Name = "Play_FR";
		size2 = (this.Play_FR.Size = new System.Drawing.Size(216, 40));
		this.Play_FR.TabIndex = 11;
		this.Play_FR.TabStop = false;
		this.Play_FR.Visible = false;
		this.RM_FR.BackColor = System.Drawing.Color.Transparent;
		this.RM_FR.Image = (System.Drawing.Image)resources.GetObject("RM_FR.Image");
		point2 = (this.RM_FR.Location = new System.Drawing.Point(399, 65));
		this.RM_FR.Name = "RM_FR";
		size2 = (this.RM_FR.Size = new System.Drawing.Size(216, 35));
		this.RM_FR.TabIndex = 13;
		this.RM_FR.TabStop = false;
		this.RM_FR.Visible = false;
		this.TS_FR.BackColor = System.Drawing.Color.Transparent;
		this.TS_FR.Image = (System.Drawing.Image)resources.GetObject("TS_FR.Image");
		point2 = (this.TS_FR.Location = new System.Drawing.Point(399, 107));
		this.TS_FR.Name = "TS_FR";
		size2 = (this.TS_FR.Size = new System.Drawing.Size(220, 35));
		this.TS_FR.TabIndex = 15;
		this.TS_FR.TabStop = false;
		this.TS_FR.Visible = false;
		this.Play_Button_Pressed.BackColor = System.Drawing.Color.Transparent;
		this.Play_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("Play_Button_Pressed.Image");
		point2 = (this.Play_Button_Pressed.Location = new System.Drawing.Point(413, 28));
		this.Play_Button_Pressed.Name = "Play_Button_Pressed";
		size2 = (this.Play_Button_Pressed.Size = new System.Drawing.Size(26, 29));
		this.Play_Button_Pressed.TabIndex = 16;
		this.Play_Button_Pressed.TabStop = false;
		this.Play_Button_Pressed.Visible = false;
		this.RM_Button_Pressed.BackColor = System.Drawing.Color.Transparent;
		this.RM_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("RM_Button_Pressed.Image");
		point2 = (this.RM_Button_Pressed.Location = new System.Drawing.Point(414, 69));
		this.RM_Button_Pressed.Name = "RM_Button_Pressed";
		size2 = (this.RM_Button_Pressed.Size = new System.Drawing.Size(26, 26));
		this.RM_Button_Pressed.TabIndex = 17;
		this.RM_Button_Pressed.TabStop = false;
		this.RM_Button_Pressed.Visible = false;
		this.TS_Button_Pressed.BackColor = System.Drawing.Color.Transparent;
		this.TS_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("TS_Button_Pressed.Image");
		point2 = (this.TS_Button_Pressed.Location = new System.Drawing.Point(413, 111));
		this.TS_Button_Pressed.Name = "TS_Button_Pressed";
		size2 = (this.TS_Button_Pressed.Size = new System.Drawing.Size(26, 29));
		this.TS_Button_Pressed.TabIndex = 18;
		this.TS_Button_Pressed.TabStop = false;
		this.TS_Button_Pressed.Visible = false;
		this.Exit_Button_Pressed.BackColor = System.Drawing.Color.Transparent;
		this.Exit_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("Exit_Button_Pressed.Image");
		point2 = (this.Exit_Button_Pressed.Location = new System.Drawing.Point(413, 153));
		this.Exit_Button_Pressed.Name = "Exit_Button_Pressed";
		size2 = (this.Exit_Button_Pressed.Size = new System.Drawing.Size(25, 26));
		this.Exit_Button_Pressed.TabIndex = 19;
		this.Exit_Button_Pressed.TabStop = false;
		this.Exit_Button_Pressed.Visible = false;
		this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
		this.Exit_Button.Image = (System.Drawing.Image)resources.GetObject("Exit_Button.Image");
		point2 = (this.Exit_Button.Location = new System.Drawing.Point(413, 153));
		this.Exit_Button.Name = "Exit_Button";
		size2 = (this.Exit_Button.Size = new System.Drawing.Size(27, 29));
		this.Exit_Button.TabIndex = 20;
		this.Exit_Button.TabStop = false;
		this.TS_button.BackColor = System.Drawing.Color.Transparent;
		this.TS_button.Image = (System.Drawing.Image)resources.GetObject("TS_button.Image");
		point2 = (this.TS_button.Location = new System.Drawing.Point(413, 111));
		this.TS_button.Name = "TS_button";
		size2 = (this.TS_button.Size = new System.Drawing.Size(26, 27));
		this.TS_button.TabIndex = 21;
		this.TS_button.TabStop = false;
		this.RM_Button.BackColor = System.Drawing.Color.Transparent;
		this.RM_Button.Image = (System.Drawing.Image)resources.GetObject("RM_Button.Image");
		point2 = (this.RM_Button.Location = new System.Drawing.Point(414, 69));
		this.RM_Button.Name = "RM_Button";
		size2 = (this.RM_Button.Size = new System.Drawing.Size(27, 28));
		this.RM_Button.TabIndex = 22;
		this.RM_Button.TabStop = false;
		this.Play_Button.BackColor = System.Drawing.Color.Transparent;
		this.Play_Button.Image = (System.Drawing.Image)resources.GetObject("Play_Button.Image");
		point2 = (this.Play_Button.Location = new System.Drawing.Point(413, 28));
		this.Play_Button.Name = "Play_Button";
		size2 = (this.Play_Button.Size = new System.Drawing.Size(33, 28));
		this.Play_Button.TabIndex = 23;
		this.Play_Button.TabStop = false;
		this.Exit_FR.BackColor = System.Drawing.Color.Transparent;
		this.Exit_FR.Image = (System.Drawing.Image)resources.GetObject("Exit_FR.Image");
		point2 = (this.Exit_FR.Location = new System.Drawing.Point(398, 149));
		this.Exit_FR.Name = "Exit_FR";
		size2 = (this.Exit_FR.Size = new System.Drawing.Size(218, 34));
		this.Exit_FR.TabIndex = 24;
		this.Exit_FR.TabStop = false;
		this.Exit_FR.Visible = false;
		this.Play_DE.BackColor = System.Drawing.Color.Transparent;
		this.Play_DE.Image = (System.Drawing.Image)resources.GetObject("Play_DE.Image");
		point2 = (this.Play_DE.Location = new System.Drawing.Point(399, 23));
		this.Play_DE.Name = "Play_DE";
		size2 = (this.Play_DE.Size = new System.Drawing.Size(218, 35));
		this.Play_DE.TabIndex = 29;
		this.Play_DE.TabStop = false;
		this.Play_DE.Visible = false;
		this.RM_DE.BackColor = System.Drawing.Color.Transparent;
		this.RM_DE.Image = (System.Drawing.Image)resources.GetObject("RM_DE.Image");
		point2 = (this.RM_DE.Location = new System.Drawing.Point(399, 65));
		this.RM_DE.Name = "RM_DE";
		size2 = (this.RM_DE.Size = new System.Drawing.Size(220, 36));
		this.RM_DE.TabIndex = 30;
		this.RM_DE.TabStop = false;
		this.RM_DE.Visible = false;
		this.TS_De.BackColor = System.Drawing.Color.Transparent;
		this.TS_De.Image = (System.Drawing.Image)resources.GetObject("TS_De.Image");
		point2 = (this.TS_De.Location = new System.Drawing.Point(400, 106));
		this.TS_De.Name = "TS_De";
		size2 = (this.TS_De.Size = new System.Drawing.Size(223, 36));
		this.TS_De.TabIndex = 31;
		this.TS_De.TabStop = false;
		this.TS_De.Visible = false;
		this.Exit_DE.BackColor = System.Drawing.Color.Transparent;
		this.Exit_DE.Image = (System.Drawing.Image)resources.GetObject("Exit_DE.Image");
		point2 = (this.Exit_DE.Location = new System.Drawing.Point(398, 150));
		this.Exit_DE.Name = "Exit_DE";
		size2 = (this.Exit_DE.Size = new System.Drawing.Size(223, 35));
		this.Exit_DE.TabIndex = 32;
		this.Exit_DE.TabStop = false;
		this.Exit_DE.Visible = false;
		System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		size2 = (this.ClientSize = new System.Drawing.Size(637, 481));
		this.Controls.Add(this.Play_Button_Pressed);
		this.Controls.Add(this.TS_button);
		this.Controls.Add(this.TS_Button_Pressed);
		this.Controls.Add(this.Exit_Button);
		this.Controls.Add(this.RM_Button);
		this.Controls.Add(this.RM_Button_Pressed);
		this.Controls.Add(this.Exit_Button_Pressed);
		this.Controls.Add(this.Play_Button);
		this.Controls.Add(this.LaunchBox);
		this.Controls.Add(this.Play_FR);
		this.Controls.Add(this.Play_DE);
		this.Controls.Add(this.RM_FR);
		this.Controls.Add(this.ReadMeBox);
		this.Controls.Add(this.RM_DE);
		this.Controls.Add(this.TS);
		this.Controls.Add(this.TS_FR);
		this.Controls.Add(this.TS_De);
		this.Controls.Add(this.QuitBox);
		this.Controls.Add(this.Exit_FR);
		this.Controls.Add(this.Exit_DE);
		this.ForeColor = System.Drawing.Color.Transparent;
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MaximizeBox = false;
		this.Name = "English";
		this.ShowIcon = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Fallout Tactics";
		((System.ComponentModel.ISupportInitialize)this.LaunchBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ReadMeBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.QuitBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_FR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RM_FR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_FR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_Button_Pressed).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RM_Button_Pressed).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_Button_Pressed).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_Button_Pressed).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_Button).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_button).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RM_Button).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_Button).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_FR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_DE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RM_DE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_De).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_DE).EndInit();
		this.ResumeLayout(false);
	}

	private void Splashscreen1_Load(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(lang, "french", TextCompare: false))
		{
			Play_FR.Visible = true;
			LaunchBox.Visible = false;
			RM_FR.Visible = true;
			ReadMeBox.Visible = false;
			TS_FR.Visible = true;
			TS.Visible = false;
			Exit_FR.Visible = true;
			QuitBox.Visible = false;
		}
		if (Operators.ConditionalCompareObjectEqual(lang, "german", TextCompare: false))
		{
			Play_DE.Visible = true;
			LaunchBox.Visible = false;
			RM_DE.Visible = true;
			ReadMeBox.Visible = false;
			TS_De.Visible = true;
			TS.Visible = false;
			Exit_DE.Visible = true;
			QuitBox.Visible = false;
		}
	}

	private void Cline_Load(object sender, EventArgs e)
	{
		ReadOnlyCollection<string> commandLineArgs = MyProject.Application.CommandLineArgs;
		checked
		{
			int num = commandLineArgs.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(commandLineArgs[i], "-classic", TextCompare: false) == 0)
				{
					exe = "BOS.exe";
				}
				if (Operators.CompareString(commandLineArgs[i], "-win8", TextCompare: false) == 0)
				{
					exe = "BOS_HR.exe";
					exe2 = "-g";
				}
			}
		}
	}

	private void Play_Click(object sender, EventArgs e)
	{
		Process.Start(Conversions.ToString(exe), Conversions.ToString(exe2));
		Application.Exit();
	}

	private void TS_Pressed_Click(object sender, EventArgs e)
	{
		Process.Start(url);
	}

	private void Exit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Readme_Click(object sender, EventArgs e)
	{
		Process.Start("readme.rtf");
	}

	private void LaunchBox_MouseHover(object sender, EventArgs e)
	{
		Play_Button_Pressed.Visible = true;
		Play_Button.Visible = false;
	}

	private void LaunchPressed_MouseLeave(object sender, EventArgs e)
	{
		Play_Button.Visible = true;
		Play_Button_Pressed.Visible = false;
	}

	private void TS_MouseHover(object sender, EventArgs e)
	{
		TS_Button_Pressed.Visible = true;
		TS_button.Visible = false;
	}

	private void TS_mouseleave(object sender, EventArgs e)
	{
		TS_button.Visible = true;
		TS_Button_Pressed.Visible = false;
	}

	private void ReadMe_MouseHover(object sender, EventArgs e)
	{
		RM_Button_Pressed.Visible = true;
		RM_Button.Visible = false;
	}

	private void ReadMeBox_MouseLeave(object sender, EventArgs e)
	{
		RM_Button.Visible = true;
		RM_Button_Pressed.Visible = false;
	}

	private void QuitBox_MouseHover(object sender, EventArgs e)
	{
		Exit_Button_Pressed.Visible = true;
		Exit_Button.Visible = false;
	}

	private void Exit_Mouseleave(object sender, EventArgs e)
	{
		Exit_Button.Visible = true;
		Exit_Button_Pressed.Visible = false;
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}
}
