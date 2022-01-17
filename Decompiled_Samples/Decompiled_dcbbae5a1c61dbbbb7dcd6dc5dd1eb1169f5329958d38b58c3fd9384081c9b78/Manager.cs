using System;
using System.Reflection;

internal static class Manager
{
	internal static Manager AddItem;

	public static void LogoutFacade()
	{
		//Discarded unreachable code: IL_0059, IL_0068
		object obj = PushItem(ListItem());
		Type[] array;
		if (6u != 0)
		{
			array = (Type[])obj;
		}
		Type[] array2 = array;
		int num;
		Type[] array3 = default(Type[]);
		if (8 == 0)
		{
			num = 4;
		}
		else
		{
			array3 = array2;
			num = 7;
		}
		int num2 = default(int);
		Type type = default(Type);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				num2++;
				int num3 = 6;
				num = num3;
				break;
			}
			case 4:
			case 7:
				if (5 == 0)
				{
					goto case 2;
				}
				num2 = 0;
				num = 2;
				break;
			case 1:
				type = array3[num2];
				num = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_1a02f8da48ac406c98d9cad8ca377c5b == 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			default:
				PublishItem(type.GetMethods());
				num = 3;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_694a2ce709a24606ad521698223e16f1 != 0)
				{
					num = 3;
				}
				break;
			case 2:
			case 6:
				if (num2 >= array3.Length)
				{
					num = 5;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_3c87806b12d7438cba956510142600ea != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private static void FillFacade(MethodInfo[] spec)
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_00c5, IL_015a
		int num = 10;
		MethodInfo[] array = default(MethodInfo[]);
		int num3 = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					MethodInfo obj = array[num3];
					if (1 == 0)
					{
						num2 = 3;
						continue;
					}
					methodInfo = obj;
					break;
				}
				case 5:
				case 9:
					if (6 == 0)
					{
						num2 = 4;
						continue;
					}
					num3 = 0;
					num2 = 6;
					continue;
				case 3:
					break;
				case 10:
					if (false)
					{
						num2 = 9;
						continue;
					}
					array = spec;
					num2 = 5;
					continue;
				case 8:
					return;
				case 11:
					if (!flag)
					{
						num2 = 0;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_998eb8dec19c46dbadb23b38e4845884 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					methodInfo.Invoke(null, null);
					num2 = 2;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_a1c1ff6dd32b4941b387e9a3f27456af != 0)
					{
						num2 = 7;
					}
					continue;
				default:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_dd2f1ebca64349f79180980532b8e09c == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
				case 4:
				case 6:
					if (num3 >= array.Length)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_2c14d7a09b2547d0bb8f361f957318cd == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			flag = ReflectItem(methodInfo.Name, "Ylfwdwgmpilzyaph");
			num = 11;
		}
	}

	internal static object ListItem()
	{
		return Facade.PrintFacade();
	}

	internal static object PushItem(object P_0)
	{
		return ((Assembly)P_0).GetExportedTypes();
	}

	internal static void PublishItem(object P_0)
	{
		FillFacade((MethodInfo[])P_0);
	}

	internal static bool WriteItem()
	{
		return AddItem == null;
	}

	internal static Manager StartItem()
	{
		return AddItem;
	}

	internal static bool ReflectItem(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
