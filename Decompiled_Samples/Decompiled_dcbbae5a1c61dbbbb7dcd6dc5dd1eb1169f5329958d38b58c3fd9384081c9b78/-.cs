using System;
using System.Windows.Forms;

public static class _0003
{
	private static _0003 MapItem;

	[STAThread]
	public static void _0002()
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_0061, IL_00d6
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				return;
			case 1:
			case 7:
				Manager.LogoutFacade();
				num2 = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_3c87806b12d7438cba956510142600ea == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
			{
				string executablePath = Application.ExecutablePath;
				if (-1 == 0)
				{
					num2 = 5;
					continue;
				}
				Console.WriteLine(executablePath);
				goto case 5;
			}
			case 5:
				if (true)
				{
					num2 = 1;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_d3e3b107f8904fb69ad941560b17473e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			string startupPath = Application.StartupPath;
			if (8 == 0)
			{
				break;
			}
			Console.WriteLine(startupPath);
			num2 = 2;
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_774b9210d98142ebb4413559daae5a44 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static bool CancelItem()
	{
		return MapItem == null;
	}

	internal static _0003 ConnectItem()
	{
		return MapItem;
	}
}
