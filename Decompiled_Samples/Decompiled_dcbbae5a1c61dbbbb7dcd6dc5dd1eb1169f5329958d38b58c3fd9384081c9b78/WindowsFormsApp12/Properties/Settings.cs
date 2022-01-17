using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp12.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings m__0002;

		private static Settings ExcludeItem;

		public Settings()
		{
			//Discarded unreachable code: IL_002d, IL_0032, IL_0050
			_ = 2;
			if (8u != 0)
			{
			}
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8cca8faf24b940e59b2f8f934cadddc3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Settings()
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					return;
				case 2:
				{
					Settings obj = (Settings)DeleteItem(new Settings());
					if (0 == 0)
					{
						Settings.m__0002 = obj;
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_0a1056fd41cc4999b752df31622971fe != 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}

		public static Settings _0002()
		{
			//Discarded unreachable code: IL_0005
			Settings settings = Settings.m__0002;
			Settings result;
			if (uint.MaxValue != 0)
			{
				result = settings;
				int num = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8cca8faf24b940e59b2f8f934cadddc3 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			return result;
		}

		internal static bool EnableItem()
		{
			return ExcludeItem == null;
		}

		internal static Settings VisitItem()
		{
			return ExcludeItem;
		}

		internal static object DeleteItem(object P_0)
		{
			return SettingsBase.Synchronized((SettingsBase)P_0);
		}
	}
}
