using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class MockParamsStub
{
	private static ResourceManager m_Interceptor;

	private static CultureInfo _Model;

	private static MockParamsStub OrderItem;

	internal MockParamsStub()
	{
		//Discarded unreachable code: IL_002d, IL_0032, IL_0050
		_ = 0;
		if (uint.MaxValue != 0)
		{
		}
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_84ee2e5a475341d78a53f13f3f565463 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static ResourceManager CallFacade()
	{
		//Discarded unreachable code: IL_0084, IL_009a
		int num = 7;
		ResourceManager resourceManager2 = default(ResourceManager);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					ResourceManager interceptor = resourceManager2;
					if (8 == 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_d64a48182f63414bb3c83906ee506a78 == 0)
						{
							num2 = 0;
						}
						break;
					}
					m_Interceptor = interceptor;
					num2 = 0;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_b7c5cdade6ec4bd5997e2e75e0b0b073 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 7:
				{
					bool num3 = m_Interceptor == null;
					if (3u != 0)
					{
						flag = num3;
						num2 = 5;
						break;
					}
					goto end_IL_0012;
				}
				default:
					return m_Interceptor;
				case 5:
				case 6:
					if (flag)
					{
						num2 = 4;
						if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8f2a606f8bea4c7aa0d1133ce995fbaa == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				case 4:
				{
					ResourceManager resourceManager = new ResourceManager("WindowsFormsApp12.Properties.Resources", typeof(MockParamsStub).Assembly);
					if (8 == 0)
					{
						num2 = 2;
						break;
					}
					resourceManager2 = resourceManager;
					goto case 2;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	internal static CultureInfo IncludeFacade()
	{
		//Discarded unreachable code: IL_0005
		CultureInfo model = _Model;
		CultureInfo result;
		if (7u != 0)
		{
			result = model;
			int num = 0;
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_685efbeca26b40ca8ff28c5cd33cf6ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		return result;
	}

	internal static void AssetFacade(CultureInfo def)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 1:
				if (3u != 0)
				{
					_Model = def;
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_095ec761ca62495f96548cfebf3e7873 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool DefineItem()
	{
		return OrderItem == null;
	}

	internal static MockParamsStub CompareItem()
	{
		return OrderItem;
	}
}
