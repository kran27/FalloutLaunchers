using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fallout.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Fallout;

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

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

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

	[AccessedThroughProperty("Play_IT")]
	private PictureBox _Play_IT;

	[AccessedThroughProperty("Readme_IT")]
	private PictureBox _Readme_IT;

	[AccessedThroughProperty("TS_IT")]
	private PictureBox _TS_IT;

	[AccessedThroughProperty("Exit_IT")]
	private PictureBox _Exit_IT;

	[AccessedThroughProperty("Play_DE")]
	private PictureBox _Play_DE;

	[AccessedThroughProperty("RM_DE")]
	private PictureBox _RM_DE;

	[AccessedThroughProperty("TS_De")]
	private PictureBox _TS_De;

	[AccessedThroughProperty("Exit_DE")]
	private PictureBox _Exit_DE;

	[AccessedThroughProperty("Play_ES")]
	private PictureBox _Play_ES;

	[AccessedThroughProperty("readme_es")]
	private PictureBox _readme_es;

	[AccessedThroughProperty("TS_ES")]
	private PictureBox _TS_ES;

	[AccessedThroughProperty("exit_es")]
	private PictureBox _exit_es;

	private string url;

	private object exe;

	private static IniFile ini = new IniFile(".\\fallout.cfg");

	private static object lang = ini.ReadValue("system", "language");

	internal virtual PictureBox LaunchBox
	{
		get
		{
			return _LaunchBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_LaunchBox != null)
			{
				_LaunchBox.Click -= value2;
				_LaunchBox.MouseEnter -= value3;
				_LaunchBox.MouseLeave -= value4;
			}
			_LaunchBox = value;
			if (_LaunchBox != null)
			{
				_LaunchBox.Click += value2;
				_LaunchBox.MouseEnter += value3;
				_LaunchBox.MouseLeave += value4;
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
			EventHandler value3 = Exit_Mouseleave;
			EventHandler value4 = Exit_Click;
			if (_QuitBox != null)
			{
				_QuitBox.MouseEnter -= value2;
				_QuitBox.MouseLeave -= value3;
				_QuitBox.Click -= value4;
			}
			_QuitBox = value;
			if (_QuitBox != null)
			{
				_QuitBox.MouseEnter += value2;
				_QuitBox.MouseLeave += value3;
				_QuitBox.Click += value4;
			}
		}
	}

	internal virtual PictureBox PictureBox4
	{
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox4 = value;
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
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			EventHandler value4 = TS_MouseHover;
			if (_TS != null)
			{
				_TS.Click -= value2;
				_TS.MouseLeave -= value3;
				_TS.MouseEnter -= value4;
			}
			_TS = value;
			if (_TS != null)
			{
				_TS.Click += value2;
				_TS.MouseLeave += value3;
				_TS.MouseEnter += value4;
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
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_Play_FR != null)
			{
				_Play_FR.Click -= value2;
				_Play_FR.MouseEnter -= value3;
				_Play_FR.MouseLeave -= value4;
			}
			_Play_FR = value;
			if (_Play_FR != null)
			{
				_Play_FR.Click += value2;
				_Play_FR.MouseEnter += value3;
				_Play_FR.MouseLeave += value4;
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
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			EventHandler value4 = TS_MouseHover;
			if (_TS_FR != null)
			{
				_TS_FR.Click -= value2;
				_TS_FR.MouseLeave -= value3;
				_TS_FR.MouseEnter -= value4;
			}
			_TS_FR = value;
			if (_TS_FR != null)
			{
				_TS_FR.Click += value2;
				_TS_FR.MouseLeave += value3;
				_TS_FR.MouseEnter += value4;
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
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_Play_Button_Pressed != null)
			{
				_Play_Button_Pressed.Click -= value2;
				_Play_Button_Pressed.MouseEnter -= value3;
				_Play_Button_Pressed.MouseLeave -= value4;
			}
			_Play_Button_Pressed = value;
			if (_Play_Button_Pressed != null)
			{
				_Play_Button_Pressed.Click += value2;
				_Play_Button_Pressed.MouseEnter += value3;
				_Play_Button_Pressed.MouseLeave += value4;
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
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			if (_TS_Button_Pressed != null)
			{
				_TS_Button_Pressed.Click -= value2;
				_TS_Button_Pressed.MouseLeave -= value3;
			}
			_TS_Button_Pressed = value;
			if (_TS_Button_Pressed != null)
			{
				_TS_Button_Pressed.Click += value2;
				_TS_Button_Pressed.MouseLeave += value3;
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
			EventHandler value2 = Exit_Mouseleave;
			EventHandler value3 = Exit_Click;
			if (_Exit_Button_Pressed != null)
			{
				_Exit_Button_Pressed.MouseLeave -= value2;
				_Exit_Button_Pressed.Click -= value3;
			}
			_Exit_Button_Pressed = value;
			if (_Exit_Button_Pressed != null)
			{
				_Exit_Button_Pressed.MouseLeave += value2;
				_Exit_Button_Pressed.Click += value3;
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
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_MouseHover;
			if (_TS_button != null)
			{
				_TS_button.Click -= value2;
				_TS_button.MouseEnter -= value3;
			}
			_TS_button = value;
			if (_TS_button != null)
			{
				_TS_button.Click += value2;
				_TS_button.MouseEnter += value3;
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
			EventHandler value3 = Exit_Mouseleave;
			EventHandler value4 = Exit_Click;
			if (_Exit_FR != null)
			{
				_Exit_FR.MouseHover -= value2;
				_Exit_FR.MouseLeave -= value3;
				_Exit_FR.Click -= value4;
			}
			_Exit_FR = value;
			if (_Exit_FR != null)
			{
				_Exit_FR.MouseHover += value2;
				_Exit_FR.MouseLeave += value3;
				_Exit_FR.Click += value4;
			}
		}
	}

	internal virtual PictureBox Play_IT
	{
		get
		{
			return _Play_IT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_Play_IT != null)
			{
				_Play_IT.Click -= value2;
				_Play_IT.MouseEnter -= value3;
				_Play_IT.MouseLeave -= value4;
			}
			_Play_IT = value;
			if (_Play_IT != null)
			{
				_Play_IT.Click += value2;
				_Play_IT.MouseEnter += value3;
				_Play_IT.MouseLeave += value4;
			}
		}
	}

	internal virtual PictureBox Readme_IT
	{
		get
		{
			return _Readme_IT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = ReadMe_MouseHover;
			EventHandler value4 = Readme_Click;
			if (_Readme_IT != null)
			{
				_Readme_IT.MouseLeave -= value2;
				_Readme_IT.MouseEnter -= value3;
				_Readme_IT.Click -= value4;
			}
			_Readme_IT = value;
			if (_Readme_IT != null)
			{
				_Readme_IT.MouseLeave += value2;
				_Readme_IT.MouseEnter += value3;
				_Readme_IT.Click += value4;
			}
		}
	}

	internal virtual PictureBox TS_IT
	{
		get
		{
			return _TS_IT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			EventHandler value4 = TS_MouseHover;
			if (_TS_IT != null)
			{
				_TS_IT.Click -= value2;
				_TS_IT.MouseLeave -= value3;
				_TS_IT.MouseEnter -= value4;
			}
			_TS_IT = value;
			if (_TS_IT != null)
			{
				_TS_IT.Click += value2;
				_TS_IT.MouseLeave += value3;
				_TS_IT.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox Exit_IT
	{
		get
		{
			return _Exit_IT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Mouseleave;
			EventHandler value4 = Exit_Click;
			if (_Exit_IT != null)
			{
				_Exit_IT.MouseEnter -= value2;
				_Exit_IT.MouseLeave -= value3;
				_Exit_IT.Click -= value4;
			}
			_Exit_IT = value;
			if (_Exit_IT != null)
			{
				_Exit_IT.MouseEnter += value2;
				_Exit_IT.MouseLeave += value3;
				_Exit_IT.Click += value4;
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
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_Play_DE != null)
			{
				_Play_DE.Click -= value2;
				_Play_DE.MouseEnter -= value3;
				_Play_DE.MouseLeave -= value4;
			}
			_Play_DE = value;
			if (_Play_DE != null)
			{
				_Play_DE.Click += value2;
				_Play_DE.MouseEnter += value3;
				_Play_DE.MouseLeave += value4;
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
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			EventHandler value4 = TS_MouseHover;
			if (_TS_De != null)
			{
				_TS_De.Click -= value2;
				_TS_De.MouseLeave -= value3;
				_TS_De.MouseEnter -= value4;
			}
			_TS_De = value;
			if (_TS_De != null)
			{
				_TS_De.Click += value2;
				_TS_De.MouseLeave += value3;
				_TS_De.MouseEnter += value4;
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
			EventHandler value3 = Exit_Mouseleave;
			EventHandler value4 = Exit_Click;
			if (_Exit_DE != null)
			{
				_Exit_DE.MouseHover -= value2;
				_Exit_DE.MouseLeave -= value3;
				_Exit_DE.Click -= value4;
			}
			_Exit_DE = value;
			if (_Exit_DE != null)
			{
				_Exit_DE.MouseHover += value2;
				_Exit_DE.MouseLeave += value3;
				_Exit_DE.Click += value4;
			}
		}
	}

	internal virtual PictureBox Play_ES
	{
		get
		{
			return _Play_ES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = Play_Click;
			EventHandler value3 = LaunchBox_MouseHover;
			EventHandler value4 = LaunchPressed_MouseLeave;
			if (_Play_ES != null)
			{
				_Play_ES.Click -= value2;
				_Play_ES.MouseEnter -= value3;
				_Play_ES.MouseLeave -= value4;
			}
			_Play_ES = value;
			if (_Play_ES != null)
			{
				_Play_ES.Click += value2;
				_Play_ES.MouseEnter += value3;
				_Play_ES.MouseLeave += value4;
			}
		}
	}

	internal virtual PictureBox readme_es
	{
		get
		{
			return _readme_es;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = ReadMeBox_MouseLeave;
			EventHandler value3 = ReadMe_MouseHover;
			EventHandler value4 = Readme_Click;
			if (_readme_es != null)
			{
				_readme_es.MouseLeave -= value2;
				_readme_es.MouseEnter -= value3;
				_readme_es.Click -= value4;
			}
			_readme_es = value;
			if (_readme_es != null)
			{
				_readme_es.MouseLeave += value2;
				_readme_es.MouseEnter += value3;
				_readme_es.Click += value4;
			}
		}
	}

	internal virtual PictureBox TS_ES
	{
		get
		{
			return _TS_ES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = TS_Pressed_Click;
			EventHandler value3 = TS_mouseleave;
			EventHandler value4 = TS_MouseHover;
			if (_TS_ES != null)
			{
				_TS_ES.Click -= value2;
				_TS_ES.MouseLeave -= value3;
				_TS_ES.MouseEnter -= value4;
			}
			_TS_ES = value;
			if (_TS_ES != null)
			{
				_TS_ES.Click += value2;
				_TS_ES.MouseLeave += value3;
				_TS_ES.MouseEnter += value4;
			}
		}
	}

	internal virtual PictureBox exit_es
	{
		get
		{
			return _exit_es;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = QuitBox_MouseHover;
			EventHandler value3 = Exit_Mouseleave;
			EventHandler value4 = Exit_Click;
			if (_exit_es != null)
			{
				_exit_es.MouseEnter -= value2;
				_exit_es.MouseLeave -= value3;
				_exit_es.Click -= value4;
			}
			_exit_es = value;
			if (_exit_es != null)
			{
				_exit_es.MouseEnter += value2;
				_exit_es.MouseLeave += value3;
				_exit_es.Click += value4;
			}
		}
	}

	public English()
	{
		base.Load += Cline_Load;
		base.Load += Splashscreen1_Load;
		url = "http://support.bethsoft.com/";
		exe = "falloutwHR.exe";
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fallout.English));
		this.LaunchBox = new System.Windows.Forms.PictureBox();
		this.ReadMeBox = new System.Windows.Forms.PictureBox();
		this.QuitBox = new System.Windows.Forms.PictureBox();
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
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
		this.Play_IT = new System.Windows.Forms.PictureBox();
		this.Readme_IT = new System.Windows.Forms.PictureBox();
		this.TS_IT = new System.Windows.Forms.PictureBox();
		this.Exit_IT = new System.Windows.Forms.PictureBox();
		this.Play_DE = new System.Windows.Forms.PictureBox();
		this.RM_DE = new System.Windows.Forms.PictureBox();
		this.TS_De = new System.Windows.Forms.PictureBox();
		this.Exit_DE = new System.Windows.Forms.PictureBox();
		this.Play_ES = new System.Windows.Forms.PictureBox();
		this.readme_es = new System.Windows.Forms.PictureBox();
		this.TS_ES = new System.Windows.Forms.PictureBox();
		this.exit_es = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.LaunchBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ReadMeBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.QuitBox).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
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
		((System.ComponentModel.ISupportInitialize)this.Play_IT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Readme_IT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_IT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_IT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_DE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RM_DE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_De).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_DE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Play_ES).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.readme_es).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TS_ES).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.exit_es).BeginInit();
		this.SuspendLayout();
		this.LaunchBox.Image = (System.Drawing.Image)resources.GetObject("LaunchBox.Image");
		System.Drawing.Point point2 = (this.LaunchBox.Location = new System.Drawing.Point(410, 37));
		this.LaunchBox.Name = "LaunchBox";
		System.Drawing.Size size2 = (this.LaunchBox.Size = new System.Drawing.Size(193, 50));
		this.LaunchBox.TabIndex = 2;
		this.LaunchBox.TabStop = false;
		this.ReadMeBox.Image = (System.Drawing.Image)resources.GetObject("ReadMeBox.Image");
		point2 = (this.ReadMeBox.Location = new System.Drawing.Point(411, 91));
		this.ReadMeBox.Name = "ReadMeBox";
		size2 = (this.ReadMeBox.Size = new System.Drawing.Size(188, 47));
		this.ReadMeBox.TabIndex = 3;
		this.ReadMeBox.TabStop = false;
		this.QuitBox.Image = (System.Drawing.Image)resources.GetObject("QuitBox.Image");
		point2 = (this.QuitBox.Location = new System.Drawing.Point(412, 192));
		this.QuitBox.Name = "QuitBox";
		size2 = (this.QuitBox.Size = new System.Drawing.Size(192, 48));
		this.QuitBox.TabIndex = 4;
		this.QuitBox.TabStop = false;
		this.PictureBox4.Image = (System.Drawing.Image)resources.GetObject("PictureBox4.Image");
		point2 = (this.PictureBox4.Location = new System.Drawing.Point(399, 388));
		this.PictureBox4.Name = "PictureBox4";
		size2 = (this.PictureBox4.Size = new System.Drawing.Size(248, 90));
		this.PictureBox4.TabIndex = 5;
		this.PictureBox4.TabStop = false;
		this.TS.Image = (System.Drawing.Image)resources.GetObject("TS.Image");
		point2 = (this.TS.Location = new System.Drawing.Point(410, 144));
		this.TS.Name = "TS";
		size2 = (this.TS.Size = new System.Drawing.Size(193, 46));
		this.TS.TabIndex = 9;
		this.TS.TabStop = false;
		this.Play_FR.Image = (System.Drawing.Image)resources.GetObject("Play_FR.Image");
		point2 = (this.Play_FR.Location = new System.Drawing.Point(410, 37));
		this.Play_FR.Name = "Play_FR";
		size2 = (this.Play_FR.Size = new System.Drawing.Size(193, 50));
		this.Play_FR.TabIndex = 11;
		this.Play_FR.TabStop = false;
		this.Play_FR.Visible = false;
		this.RM_FR.Image = (System.Drawing.Image)resources.GetObject("RM_FR.Image");
		point2 = (this.RM_FR.Location = new System.Drawing.Point(411, 91));
		this.RM_FR.Name = "RM_FR";
		size2 = (this.RM_FR.Size = new System.Drawing.Size(188, 47));
		this.RM_FR.TabIndex = 13;
		this.RM_FR.TabStop = false;
		this.RM_FR.Visible = false;
		this.TS_FR.Image = (System.Drawing.Image)resources.GetObject("TS_FR.Image");
		point2 = (this.TS_FR.Location = new System.Drawing.Point(411, 144));
		this.TS_FR.Name = "TS_FR";
		size2 = (this.TS_FR.Size = new System.Drawing.Size(193, 46));
		this.TS_FR.TabIndex = 15;
		this.TS_FR.TabStop = false;
		this.TS_FR.Visible = false;
		this.Play_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("Play_Button_Pressed.Image");
		point2 = (this.Play_Button_Pressed.Location = new System.Drawing.Point(410, 39));
		this.Play_Button_Pressed.Name = "Play_Button_Pressed";
		size2 = (this.Play_Button_Pressed.Size = new System.Drawing.Size(44, 46));
		this.Play_Button_Pressed.TabIndex = 16;
		this.Play_Button_Pressed.TabStop = false;
		this.Play_Button_Pressed.Visible = false;
		this.RM_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("RM_Button_Pressed.Image");
		point2 = (this.RM_Button_Pressed.Location = new System.Drawing.Point(410, 92));
		this.RM_Button_Pressed.Name = "RM_Button_Pressed";
		size2 = (this.RM_Button_Pressed.Size = new System.Drawing.Size(44, 46));
		this.RM_Button_Pressed.TabIndex = 17;
		this.RM_Button_Pressed.TabStop = false;
		this.RM_Button_Pressed.Visible = false;
		this.TS_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("TS_Button_Pressed.Image");
		point2 = (this.TS_Button_Pressed.Location = new System.Drawing.Point(409, 143));
		this.TS_Button_Pressed.Name = "TS_Button_Pressed";
		size2 = (this.TS_Button_Pressed.Size = new System.Drawing.Size(44, 46));
		this.TS_Button_Pressed.TabIndex = 18;
		this.TS_Button_Pressed.TabStop = false;
		this.TS_Button_Pressed.Visible = false;
		this.Exit_Button_Pressed.Image = (System.Drawing.Image)resources.GetObject("Exit_Button_Pressed.Image");
		point2 = (this.Exit_Button_Pressed.Location = new System.Drawing.Point(410, 192));
		this.Exit_Button_Pressed.Name = "Exit_Button_Pressed";
		size2 = (this.Exit_Button_Pressed.Size = new System.Drawing.Size(44, 46));
		this.Exit_Button_Pressed.TabIndex = 19;
		this.Exit_Button_Pressed.TabStop = false;
		this.Exit_Button_Pressed.Visible = false;
		this.Exit_Button.Image = (System.Drawing.Image)resources.GetObject("Exit_Button.Image");
		point2 = (this.Exit_Button.Location = new System.Drawing.Point(410, 192));
		this.Exit_Button.Name = "Exit_Button";
		size2 = (this.Exit_Button.Size = new System.Drawing.Size(44, 46));
		this.Exit_Button.TabIndex = 20;
		this.Exit_Button.TabStop = false;
		this.TS_button.Image = (System.Drawing.Image)resources.GetObject("TS_button.Image");
		point2 = (this.TS_button.Location = new System.Drawing.Point(409, 142));
		this.TS_button.Name = "TS_button";
		size2 = (this.TS_button.Size = new System.Drawing.Size(44, 46));
		this.TS_button.TabIndex = 21;
		this.TS_button.TabStop = false;
		this.RM_Button.Image = (System.Drawing.Image)resources.GetObject("RM_Button.Image");
		point2 = (this.RM_Button.Location = new System.Drawing.Point(410, 91));
		this.RM_Button.Name = "RM_Button";
		size2 = (this.RM_Button.Size = new System.Drawing.Size(44, 46));
		this.RM_Button.TabIndex = 22;
		this.RM_Button.TabStop = false;
		this.RM_Button.Visible = false;
		this.Play_Button.Image = (System.Drawing.Image)resources.GetObject("Play_Button.Image");
		point2 = (this.Play_Button.Location = new System.Drawing.Point(410, 37));
		this.Play_Button.Name = "Play_Button";
		size2 = (this.Play_Button.Size = new System.Drawing.Size(44, 46));
		this.Play_Button.TabIndex = 23;
		this.Play_Button.TabStop = false;
		this.Play_Button.Visible = false;
		this.Exit_FR.Image = (System.Drawing.Image)resources.GetObject("Exit_FR.Image");
		point2 = (this.Exit_FR.Location = new System.Drawing.Point(411, 193));
		this.Exit_FR.Name = "Exit_FR";
		size2 = (this.Exit_FR.Size = new System.Drawing.Size(192, 48));
		this.Exit_FR.TabIndex = 24;
		this.Exit_FR.TabStop = false;
		this.Exit_FR.Visible = false;
		this.Play_IT.Image = (System.Drawing.Image)resources.GetObject("Play_IT.Image");
		point2 = (this.Play_IT.Location = new System.Drawing.Point(409, 37));
		this.Play_IT.Name = "Play_IT";
		size2 = (this.Play_IT.Size = new System.Drawing.Size(193, 50));
		this.Play_IT.TabIndex = 25;
		this.Play_IT.TabStop = false;
		this.Play_IT.Visible = false;
		this.Readme_IT.Image = (System.Drawing.Image)resources.GetObject("Readme_IT.Image");
		point2 = (this.Readme_IT.Location = new System.Drawing.Point(410, 90));
		this.Readme_IT.Name = "Readme_IT";
		size2 = (this.Readme_IT.Size = new System.Drawing.Size(188, 47));
		this.Readme_IT.TabIndex = 26;
		this.Readme_IT.TabStop = false;
		this.Readme_IT.Visible = false;
		this.TS_IT.Image = (System.Drawing.Image)resources.GetObject("TS_IT.Image");
		point2 = (this.TS_IT.Location = new System.Drawing.Point(409, 144));
		this.TS_IT.Name = "TS_IT";
		size2 = (this.TS_IT.Size = new System.Drawing.Size(193, 46));
		this.TS_IT.TabIndex = 27;
		this.TS_IT.TabStop = false;
		this.TS_IT.Visible = false;
		this.Exit_IT.Image = (System.Drawing.Image)resources.GetObject("Exit_IT.Image");
		point2 = (this.Exit_IT.Location = new System.Drawing.Point(411, 193));
		this.Exit_IT.Name = "Exit_IT";
		size2 = (this.Exit_IT.Size = new System.Drawing.Size(192, 48));
		this.Exit_IT.TabIndex = 28;
		this.Exit_IT.TabStop = false;
		this.Exit_IT.Visible = false;
		this.Play_DE.Image = (System.Drawing.Image)resources.GetObject("Play_DE.Image");
		point2 = (this.Play_DE.Location = new System.Drawing.Point(411, 37));
		this.Play_DE.Name = "Play_DE";
		size2 = (this.Play_DE.Size = new System.Drawing.Size(193, 50));
		this.Play_DE.TabIndex = 29;
		this.Play_DE.TabStop = false;
		this.Play_DE.Visible = false;
		this.RM_DE.Image = (System.Drawing.Image)resources.GetObject("RM_DE.Image");
		point2 = (this.RM_DE.Location = new System.Drawing.Point(411, 91));
		this.RM_DE.Name = "RM_DE";
		size2 = (this.RM_DE.Size = new System.Drawing.Size(188, 47));
		this.RM_DE.TabIndex = 30;
		this.RM_DE.TabStop = false;
		this.RM_DE.Visible = false;
		this.TS_De.Image = (System.Drawing.Image)resources.GetObject("TS_De.Image");
		point2 = (this.TS_De.Location = new System.Drawing.Point(410, 144));
		this.TS_De.Name = "TS_De";
		size2 = (this.TS_De.Size = new System.Drawing.Size(193, 46));
		this.TS_De.TabIndex = 31;
		this.TS_De.TabStop = false;
		this.TS_De.Visible = false;
		this.Exit_DE.Image = (System.Drawing.Image)resources.GetObject("Exit_DE.Image");
		point2 = (this.Exit_DE.Location = new System.Drawing.Point(411, 193));
		this.Exit_DE.Name = "Exit_DE";
		size2 = (this.Exit_DE.Size = new System.Drawing.Size(192, 48));
		this.Exit_DE.TabIndex = 32;
		this.Exit_DE.TabStop = false;
		this.Exit_DE.Visible = false;
		this.Play_ES.Image = (System.Drawing.Image)resources.GetObject("Play_ES.Image");
		point2 = (this.Play_ES.Location = new System.Drawing.Point(410, 37));
		this.Play_ES.Name = "Play_ES";
		size2 = (this.Play_ES.Size = new System.Drawing.Size(193, 50));
		this.Play_ES.TabIndex = 33;
		this.Play_ES.TabStop = false;
		this.Play_ES.Visible = false;
		this.readme_es.Image = (System.Drawing.Image)resources.GetObject("readme_es.Image");
		point2 = (this.readme_es.Location = new System.Drawing.Point(410, 91));
		this.readme_es.Name = "readme_es";
		size2 = (this.readme_es.Size = new System.Drawing.Size(188, 47));
		this.readme_es.TabIndex = 34;
		this.readme_es.TabStop = false;
		this.readme_es.Visible = false;
		this.TS_ES.Image = (System.Drawing.Image)resources.GetObject("TS_ES.Image");
		point2 = (this.TS_ES.Location = new System.Drawing.Point(411, 144));
		this.TS_ES.Name = "TS_ES";
		size2 = (this.TS_ES.Size = new System.Drawing.Size(193, 46));
		this.TS_ES.TabIndex = 35;
		this.TS_ES.TabStop = false;
		this.TS_ES.Visible = false;
		this.exit_es.Image = (System.Drawing.Image)resources.GetObject("exit_es.Image");
		point2 = (this.exit_es.Location = new System.Drawing.Point(412, 192));
		this.exit_es.Name = "exit_es";
		size2 = (this.exit_es.Size = new System.Drawing.Size(192, 48));
		this.exit_es.TabIndex = 36;
		this.exit_es.TabStop = false;
		this.exit_es.Visible = false;
		System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		size2 = (this.ClientSize = new System.Drawing.Size(637, 481));
		this.Controls.Add(this.Play_Button);
		this.Controls.Add(this.RM_Button);
		this.Controls.Add(this.TS_button);
		this.Controls.Add(this.Exit_Button);
		this.Controls.Add(this.TS_Button_Pressed);
		this.Controls.Add(this.RM_Button_Pressed);
		this.Controls.Add(this.Play_Button_Pressed);
		this.Controls.Add(this.PictureBox4);
		this.Controls.Add(this.Exit_Button_Pressed);
		this.Controls.Add(this.LaunchBox);
		this.Controls.Add(this.Play_IT);
		this.Controls.Add(this.Play_DE);
		this.Controls.Add(this.Play_ES);
		this.Controls.Add(this.Play_FR);
		this.Controls.Add(this.ReadMeBox);
		this.Controls.Add(this.Readme_IT);
		this.Controls.Add(this.RM_DE);
		this.Controls.Add(this.readme_es);
		this.Controls.Add(this.RM_FR);
		this.Controls.Add(this.TS);
		this.Controls.Add(this.TS_FR);
		this.Controls.Add(this.TS_IT);
		this.Controls.Add(this.TS_De);
		this.Controls.Add(this.TS_ES);
		this.Controls.Add(this.QuitBox);
		this.Controls.Add(this.Exit_IT);
		this.Controls.Add(this.exit_es);
		this.Controls.Add(this.Exit_DE);
		this.Controls.Add(this.Exit_FR);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MaximizeBox = false;
		this.Name = "English";
		this.ShowIcon = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Fallout: A Post Nuclear Role Playing Game";
		((System.ComponentModel.ISupportInitialize)this.LaunchBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ReadMeBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.QuitBox).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
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
		((System.ComponentModel.ISupportInitialize)this.Play_IT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Readme_IT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_IT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_IT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_DE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RM_DE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_De).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Exit_DE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Play_ES).EndInit();
		((System.ComponentModel.ISupportInitialize)this.readme_es).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TS_ES).EndInit();
		((System.ComponentModel.ISupportInitialize)this.exit_es).EndInit();
		this.ResumeLayout(false);
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
					exe = "falloutw.exe";
				}
			}
		}
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
		if (Operators.ConditionalCompareObjectEqual(lang, "italian", TextCompare: false))
		{
			Play_IT.Visible = true;
			LaunchBox.Visible = false;
			Readme_IT.Visible = true;
			ReadMeBox.Visible = false;
			TS_IT.Visible = true;
			TS.Visible = false;
			Exit_IT.Visible = true;
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
		if (Operators.ConditionalCompareObjectEqual(lang, "spanish", TextCompare: false))
		{
			Play_ES.Visible = true;
			LaunchBox.Visible = false;
			readme_es.Visible = true;
			ReadMeBox.Visible = false;
			TS_ES.Visible = true;
			TS.Visible = false;
			exit_es.Visible = true;
			QuitBox.Visible = false;
		}
	}

	private void Play_Click(object sender, EventArgs e)
	{
		Type typeFromHandle = typeof(Process);
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(exe) };
		bool[] array2 = new bool[1] { true };
		NewLateBinding.LateCall(null, typeFromHandle, "Start", array, null, null, array2, IgnoreReturn: true);
		if (array2[0])
		{
			exe = RuntimeHelpers.GetObjectValue(array[0]);
		}
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
}
