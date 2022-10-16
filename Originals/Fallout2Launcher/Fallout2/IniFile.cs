using System.Runtime.InteropServices;
using System.Text;

namespace Fallout2;

public class IniFile
{
	public string Path { get; set; }

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, StringBuilder lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	public IniFile(string IniPath)
	{
		Path = IniPath;
	}

	public string ReadValue(string section, string key)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		string lpDefault = "";
		string lpFileName = Path;
		int privateProfileString = GetPrivateProfileString(ref section, ref key, ref lpDefault, stringBuilder, 255, ref lpFileName);
		Path = lpFileName;
		int num = privateProfileString;
		return stringBuilder.ToString();
	}

	public void WriteValue(string section, string key, string value)
	{
		string lpFileName = Path;
		WritePrivateProfileString(ref section, ref key, ref value, ref lpFileName);
		Path = lpFileName;
	}
}
