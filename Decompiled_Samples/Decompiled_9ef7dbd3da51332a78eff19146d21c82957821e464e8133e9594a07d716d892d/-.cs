using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32.SafeHandles;

internal abstract class _0002
{
	public abstract byte _0002_200A_2002_0002();
}
internal sealed class _0002_2000 : _0006, IDisposable
{
	private _0008_2000 m__0002;

	private byte[] m__0003;

	private readonly int _0005;

	private readonly int _0008;

	public _0002_2000(_0008_2000 _0002)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0002._0002())
		{
			throw new NotSupportedException();
		}
		this.m__0002 = _0002;
		this.m__0003 = new byte[_0002._0006_200A_2002_0003()];
		_0005 = this._0002();
		_0008 = _0003();
	}

	private int _0002()
	{
		return this.m__0002._0006_200A_2002_0002();
	}

	private int _0003()
	{
		return this.m__0002._0006_200A_2002_0003() - 10;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0002()
	{
		return _0005;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0003()
	{
		return _0008;
	}

	public int _0006_200A_2002_0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E)
	{
		return this._0002(_0002, _0003, _0005, _0008, _0006, _000E);
	}

	private int _0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E)
	{
		int num = this.m__0002._0006_200A_2002_0003();
		byte[] array = this.m__0003;
		this.m__0002._0006_200A_2002_0002(_0002, _0003, _0005, array, 0, _000E);
		byte num2 = array[0];
		bool flag = num2 != 2;
		int num3 = _0002_2000._0002(num2, array, 0, num);
		num3++;
		if (flag || num3 < 10)
		{
			throw new InvalidOperationException(_000F_2004_2000._0002(-1506765050));
		}
		int num4 = num - num3;
		Buffer.BlockCopy(array, num3, _0008, _0006, num4);
		return num4;
	}

	private static int _0002(byte _0002, byte[] _0003, int _0005, int _0008)
	{
		for (int i = _0005 + 1; i != _0005 + _0008; i++)
		{
			if (_0003[i] == 0)
			{
				return i;
			}
		}
		return -1;
	}

	public void Dispose()
	{
		if (this.m__0002 != null)
		{
			this.m__0002.Dispose();
			this.m__0002 = null;
		}
	}
}
[_0006_2009]
internal struct _0002_2000_2000
{
	public readonly int _0002;

	public _0002_2000_2000(int _0002)
	{
		this._0002 = _0002;
	}
}
internal sealed class _0002_2001 : DeriveBytes
{
	private static volatile bool _0002;

	private DeriveBytes _0003;

	private readonly byte[] _0005;

	private readonly byte[] _0008;

	private readonly int _0006;

	public _0002_2001(byte[] _0002, byte[] _0003, int _0005)
	{
		this._0005 = _0002;
		_0008 = _0003;
		_0006 = _0005;
		if (!_0002_2001._0002)
		{
			try
			{
				this._0003 = new Rfc2898DeriveBytes(_0002, _0003, _0005);
			}
			catch
			{
				_0002_2001._0002 = true;
			}
		}
		if (this._0003 == null)
		{
			this._0003 = new _0003_2000(_0002, _0003, _0005);
		}
	}

	public override byte[] GetBytes(int _0002)
	{
		byte[] array = null;
		if (!_0002_2001._0002)
		{
			try
			{
				array = _0003.GetBytes(_0002);
			}
			catch
			{
				_0002_2001._0002 = true;
			}
		}
		if (array == null)
		{
			_0003 = new _0003_2000(_0005, _0008, _0006);
			array = _0003.GetBytes(_0002);
		}
		return array;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
internal sealed class _0002_2002 : _000E_2001
{
	private new Array m__0002;

	public _0002_2002()
		: base(1)
	{
	}

	public new Array _0002()
	{
		return this.m__0002;
	}

	public void _0002(Array _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((Array)_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0002_2002 obj = new _0002_2002();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 1:
			this._0002(((_0002_2002)_0002)._0002());
			break;
		case 8:
			this._0002((Array)((_000F_2007)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal interface _0002_2002_2000<_0002> : _000E_2001_2000, _000F_2001_2000
{
	new _0002 _000E_2001_2000_200A_2002_0002();
}
internal sealed class _0002_2003
{
	private sealed class _0002
	{
		public byte[] _0002;

		public bool _0003;

		public _0002()
		{
		}

		public _0002(byte[] _0002, int _0003, int _0005, bool _0008)
		{
			this._0002(_0002, _0003, _0005, _0008);
		}

		public void _0002(byte[] _0002, int _0003, int _0005, bool _0008)
		{
			this._0002 = new byte[_0005];
			Buffer.BlockCopy(_0002, _0003, this._0002, 0, _0005);
			this._0003 = _0008;
		}
	}

	private readonly object m__0002 = new object();

	private _000F_2003[] m__0003;

	private Dictionary<int, _000F_2003> m__0005;

	private volatile bool _0008;

	private _0006_2003 _0006;

	private Dictionary<int, WeakReference> _000E;

	private object _000F;

	private int _0002_2000;

	private object[] _0003_2000;

	private int _0005_2000;

	public _0002_2003(_0006_2003 _0002)
	{
		_0006 = _0002;
	}

	private void _0002()
	{
		if (_0008)
		{
			return;
		}
		lock (this.m__0002)
		{
			if (!_0008)
			{
				this.m__0003 = new _000F_2003[_0006._0005()];
				for (int i = 0; i < _0006._0005(); i++)
				{
					this.m__0003[i] = new _000F_2003();
				}
				this.m__0005 = new Dictionary<int, _000F_2003>();
				_000E = new Dictionary<int, WeakReference>();
				_000F = new object();
				_0002_2000 = _0006._0008();
				_0003_2000 = new object[_0006._0006()];
				_0008 = true;
			}
		}
	}

	public void _0002(_000F_2003 _0002)
	{
		this._0002();
		lock (this.m__0002)
		{
			if (this.m__0005.TryGetValue(_0002._0003, out var value) && value != null)
			{
				value._0008 = _0002._0008;
				return;
			}
			int num = 0;
			DateTime dateTime = this.m__0003[0]._0008;
			for (int i = 1; i < _0006._0005(); i++)
			{
				if (this.m__0003[i]._0008 < dateTime)
				{
					num = i;
				}
			}
			value = this.m__0003[num];
			if (value._0002 == null)
			{
				value._0002 = new byte[_0006._0002()];
			}
			else
			{
				this.m__0005[value._0003] = null;
			}
			this._0002(_0002, value);
			this.m__0005[value._0003] = value;
			if (this.m__0005.Count > _0006._0005() * 2)
			{
				_0003();
			}
		}
	}

	private void _0003()
	{
		Dictionary<int, _000F_2003> dictionary = this.m__0005;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, _000F_2003> item in dictionary)
		{
			if (item.Value == null)
			{
				list.Add(item.Key);
			}
		}
		foreach (int item2 in list)
		{
			dictionary.Remove(item2);
		}
	}

	public bool _0002(int _0002, ref _000F_2003 _0003)
	{
		if (!_0008)
		{
			return false;
		}
		lock (this.m__0002)
		{
			if (this.m__0005.TryGetValue(_0002, out var value) && value != null)
			{
				this._0002(value, _0003);
				return true;
			}
		}
		return false;
	}

	private void _0002(_000F_2003 _0002, _000F_2003 _0003)
	{
		_0002._0008 = DateTime.UtcNow;
		_0003._0003 = _0002._0003;
		_0003._0005 = _0002._0005;
		_0003._0008 = _0002._0008;
		Buffer.BlockCopy(_0002._0002, 0, _0003._0002, 0, _0006._0002());
	}

	private void _0002(object _0002)
	{
		for (int i = 0; i < _0003_2000.Length; i++)
		{
			if (_0003_2000[i] == _0002)
			{
				return;
			}
		}
		_0003_2000[_0005_2000] = _0002;
		_0005_2000++;
		if (_0005_2000 == _0003_2000.Length)
		{
			_0005_2000 = 0;
		}
	}

	private void _0005()
	{
		if (_000E.Count < _0002_2000)
		{
			return;
		}
		Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
		foreach (KeyValuePair<int, WeakReference> item in _000E)
		{
			if (item.Value.IsAlive)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		_000E = dictionary;
		_0002_2000 = Math.Max(dictionary.Count * 2, 10);
	}

	public void _0002(int _0002, byte[] _0003, int _0005, int _0008, bool _0006)
	{
		this._0002();
		lock (_000F)
		{
			_0002 obj;
			if (_000E.TryGetValue(_0002, out var value))
			{
				obj = value.Target as _0002;
				if (obj != null)
				{
					if (obj._0002.Length < _0008)
					{
						obj._0002(_0003, _0005, _0008, _0006);
					}
					goto IL_0070;
				}
			}
			this._0005();
			obj = new _0002(_0003, _0005, _0008, _0006);
			_000E[_0002] = new WeakReference(obj);
			goto IL_0070;
			IL_0070:
			this._0002(obj);
		}
	}

	public bool _0002(int _0002, byte[] _0003, int _0005, int _0008, out int _0006)
	{
		_0006 = 0;
		if (!this._0008)
		{
			return false;
		}
		lock (_000F)
		{
			if (!_000E.TryGetValue(_0002, out var value))
			{
				return false;
			}
			_0002 obj = value.Target as _0002;
			if (obj == null)
			{
				return false;
			}
			int num = obj._0002.Length;
			_0006 = _0008;
			if (num < _0008)
			{
				if (!obj._0003)
				{
					return false;
				}
				_0006 = num;
			}
			Buffer.BlockCopy(obj._0002, 0, _0003, _0005, _0006);
			this._0002(obj);
			return true;
		}
	}
}
internal sealed class _0002_2003_2000
{
	internal static void _0002()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>l\"&f4#", (object[])null);
	}
}
internal sealed class _0002_2004 : _000E_2001
{
	private new short m__0002;

	public _0002_2004()
		: base(6)
	{
	}

	public new short _0002()
	{
		return this.m__0002;
	}

	public void _0002(short _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is int)
		{
			this._0002((short)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((short)(long)_0002);
		}
		else if (_0002 is ushort)
		{
			this._0002((short)(ushort)_0002);
		}
		else if (_0002 is uint)
		{
			this._0002((short)(uint)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((short)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((short)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((short)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToInt16(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0002_2004 obj = new _0002_2004();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 6:
			this._0002(((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((short)((_0006_2004)_0002)._0002());
			break;
		case 26:
			this._0002((short)((_000F_2004)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToInt16(((_000F_2002)_0002)._0002()));
			break;
		case 25:
			this._0002((short)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((short)((_000E_2005)_0002)._0002());
			break;
		case 23:
			this._0002((short)((_0002_2006)_0002)._0002());
			break;
		case 14:
			this._0002((short)((_0003_2003)_0002)._0002());
			break;
		case 0:
			this._0002((short)((_0008_2003)_0002)._0002());
			break;
		case 24:
			this._0002((short)(int)((_000E_2006)_0002)._0002());
			break;
		case 8:
			this._0002(Convert.ToInt16(((_000F_2007)_0002)._0002()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _0002_2004_2000
{
	internal static int _0002;

	internal static string _0003;

	internal static string _0005;

	internal static bool _0008;

	internal static string _0006;

	internal static bool _000E;

	internal static bool _000F;

	internal static string _0002_2000;

	internal static byte[] _0003_2000;

	internal static bool _0005_2000;

	internal static FileInfo _0008_2000;

	internal static FileInfo _0006_2000;

	internal static bool _000E_2000;

	internal static bool _000F_2000;

	internal static bool _0002_2001;

	internal static int _0003_2001;

	internal static string _0005_2001;

	internal static bool _0008_2001;

	internal static bool _0006_2001;

	internal static bool _000E_2001;

	internal static bool _000F_2001;

	static _0002_2004_2000()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@=\"*FVE", (object[])null);
	}
}
internal static class _0002_2005
{
	public static bool _0002(Type _0002, Type _0003, out int _0005)
	{
		_0005 = 0;
		if ((object)_0002 == _0003)
		{
			_0005 = 1;
			return true;
		}
		if ((object)_0002 == null || (object)_0003 == null)
		{
			return false;
		}
		if (_0002.IsByRef)
		{
			if (!_0003.IsByRef)
			{
				return false;
			}
			return _0002_2005._0002(_0002.GetElementType(), _0003.GetElementType(), out _0005);
		}
		if (_0003.IsByRef)
		{
			return false;
		}
		if (_0002.IsPointer)
		{
			if (!_0003.IsPointer)
			{
				return false;
			}
			return _0002_2005._0002(_0002.GetElementType(), _0003.GetElementType(), out _0005);
		}
		if (_0003.IsPointer)
		{
			return false;
		}
		if (_0002.IsArray)
		{
			if (!_0003.IsArray)
			{
				return false;
			}
			if (_0002.GetArrayRank() != _0003.GetArrayRank())
			{
				return false;
			}
			return _0002_2005._0002(_0002.GetElementType(), _0003.GetElementType(), out _0005);
		}
		if (_0003.IsArray)
		{
			return false;
		}
		if (_0002.IsGenericType != _0003.IsGenericType)
		{
			return false;
		}
		if (_0002.IsGenericType)
		{
			Type obj = (_0002.IsGenericTypeDefinition ? _0002 : _0002.GetGenericTypeDefinition());
			Type type = (_0003.IsGenericTypeDefinition ? _0003 : _0003.GetGenericTypeDefinition());
			if ((object)obj != type)
			{
				return false;
			}
			Type[] genericArguments = _0002.GetGenericArguments();
			Type[] genericArguments2 = _0003.GetGenericArguments();
			if (genericArguments.Length != genericArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (_0002_2005._0002(genericArguments[i], genericArguments2[i], out var num))
				{
					_0005 += num;
				}
			}
		}
		else if ((object)_0002 != _0003)
		{
			return false;
		}
		_0005++;
		return true;
	}
}
internal static class _0002_2005_2000
{
}
internal sealed class _0002_2006 : _000E_2001
{
	private new ulong m__0002;

	public _0002_2006()
		: base(23)
	{
	}

	public new ulong _0002()
	{
		return this.m__0002;
	}

	public void _0002(ulong _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is short)
		{
			this._0002((ulong)(short)_0002);
		}
		else if (_0002 is int)
		{
			this._0002((ulong)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((ulong)(long)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((ulong)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((ulong)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToUInt64(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0002_2006 obj = new _0002_2006();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((ulong)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((ulong)((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002((ulong)((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002(((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002(((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((ulong)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002(((_0002_2006)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToUInt64(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToUInt64(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((ulong)(long)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((ulong)((_0005_2007)_0002)._0002());
			break;
		case 0:
			this._0002((ulong)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((ulong)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _0002_2007 : _000F_2006
{
	private int m__0002;

	private byte[] m__0003;

	private long _0005;

	private int _0008;

	[CompilerGenerated]
	public int _000F_2006_200A_2002_0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	[CompilerGenerated]
	public byte[] _000F_2006_200A_2002_0002()
	{
		return this.m__0003;
	}

	public void _0002(byte[] _0002)
	{
		this.m__0003 = _0002;
	}

	[CompilerGenerated]
	public long _000F_2006_200A_2002_0002()
	{
		return _0005;
	}

	public void _0002(long _0002)
	{
		_0005 = _0002;
	}

	public int _0002()
	{
		return _0008;
	}

	public void _0003(int _0002)
	{
		_0008 = _0002;
	}
}
internal sealed class _0002_2008
{
	[Serializable]
	private sealed class _0002
	{
		public static readonly _0002 _0002 = new _0002();

		public static Comparison<_0008_200A> _0003;

		internal int _0002(_0008_200A _0002, _0008_200A _0003)
		{
			if (_0002._0002() == _0003._0002())
			{
				return _0003._0005().CompareTo(_0002._0005());
			}
			return _0002._0002().CompareTo(_0003._0002());
		}
	}

	private struct _0002_2000
	{
		public readonly byte _0002;

		public readonly _000F _0003;

		public _0002_2000(_0008_200B _0002, _000F _0003)
		{
			this._0002 = _0002._0002();
			this._0003 = _0003;
		}
	}

	private struct _0003
	{
		public bool _0002;
	}

	private static class _0003_2000
	{
		private delegate void _0002();

		private delegate void _0002_2000<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F);

		private delegate _0008 _0002_2001<in _0002, in _0003, in _0005, out _0008>(_0002 _0002, _0003 _0003, _0005 _0005);

		private delegate void _0003<in _0002>(_0002 _0002);

		private delegate void _0003_2000<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F, in _0002_2000>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F, _0002_2000 _0002_2000);

		private delegate _0006 _0003_2001<in _0002, in _0003, in _0005, in _0008, out _0006>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008);

		private delegate void _0005<in _0002, in _0003>(_0002 _0002, _0003 _0003);

		private delegate void _0005_2000<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F, in _0002_2000, in _0003_2000>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F, _0002_2000 _0002_2000, _0003_2000 _0003_2000);

		private delegate _000E _0005_2001<in _0002, in _0003, in _0005, in _0008, in _0006, out _000E>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006);

		private delegate void _0006<in _0002, in _0003, in _0005, in _0008>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008);

		private delegate _0005_2000 _0006_2000<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F, in _0002_2000, in _0003_2000, out _0005_2000>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F, _0002_2000 _0002_2000, _0003_2000 _0003_2000);

		private delegate _0002_2000 _0006_2001<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F, out _0002_2000>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F);

		private delegate void _0008<in _0002, in _0003, in _0005>(_0002 _0002, _0003 _0003, _0005 _0005);

		private delegate _0002 _0008_2000<out _0002>();

		private delegate _000F _0008_2001<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, out _000F>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E);

		private delegate void _000E<in _0002, in _0003, in _0005, in _0008, in _0006>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006);

		private delegate _0003 _000E_2000<in _0002, out _0003>(_0002 _0002);

		private delegate _0003_2000 _000E_2001<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E, in _000F, in _0002_2000, out _0003_2000>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E, _000F _000F, _0002_2000 _0002_2000);

		private delegate void _000F<in _0002, in _0003, in _0005, in _0008, in _0006, in _000E>(_0002 _0002, _0003 _0003, _0005 _0005, _0008 _0008, _0006 _0006, _000E _000E);

		private delegate _0005 _000F_2000<in _0002, in _0003, out _0005>(_0002 _0002, _0003 _0003);

		private static readonly Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> m__0002 = new Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>>();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object _0002(object _0002, MethodBase _0003, out MethodInfo _0005)
		{
			KeyValuePair<Type, MethodInfo> keyValuePair = global::_0002_2008._0003_2000._0002(_0003);
			Delegate result = (Delegate)Activator.CreateInstance(keyValuePair.Key, _0002, _0003.MethodHandle.GetFunctionPointer());
			_0005 = keyValuePair.Value;
			return result;
		}

		private static KeyValuePair<Type, MethodInfo> _0002(MethodBase _0002)
		{
			lock (global::_0002_2008._0003_2000.m__0002)
			{
				if (global::_0002_2008._0003_2000.m__0002.TryGetValue(_0002, out var value))
				{
					return value;
				}
				Type type = (_0002 as MethodInfo)?.ReturnType ?? global::_0002_2008.m__0002_2004;
				bool flag = (object)type != global::_0002_2008.m__0002_2004;
				ParameterInfo[] parameters = _0002.GetParameters();
				if (parameters.Length > 9)
				{
					throw new Exception(string.Format(global::_000F_2004_2000._0002(-1506765567), parameters.Length));
				}
				Type[] array = new Type[parameters.Length + (flag ? 1 : 0)];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type parameterType = parameters[i].ParameterType;
					if (parameterType.IsByRef || parameterType.IsPointer)
					{
						throw new Exception(global::_000F_2004_2000._0002(-1506765357));
					}
					array[i] = parameterType;
				}
				if (flag)
				{
					array[array.Length - 1] = type;
				}
				Type type2 = (flag ? global::_0002_2008._0003_2000._0002(array) : _0003(array));
				MethodInfo method = type2.GetMethod(global::_000F_2004_2000._0002(-1506765726));
				value = new KeyValuePair<Type, MethodInfo>(type2, method);
				global::_0002_2008._0003_2000.m__0002.Add(_0002, value);
				return value;
			}
		}

		private static Type _0002(Type[] _0002)
		{
			return _0002.Length switch
			{
				1 => typeof(_0008_2000<>).MakeGenericType(_0002), 
				2 => typeof(_000E_2000<, >).MakeGenericType(_0002), 
				3 => typeof(_000F_2000<, , >).MakeGenericType(_0002), 
				4 => typeof(_0002_2001<, , , >).MakeGenericType(_0002), 
				5 => typeof(_0003_2001<, , , , >).MakeGenericType(_0002), 
				6 => typeof(_0005_2001<, , , , , >).MakeGenericType(_0002), 
				7 => typeof(_0008_2001<, , , , , , >).MakeGenericType(_0002), 
				8 => typeof(_0006_2001<, , , , , , , >).MakeGenericType(_0002), 
				9 => typeof(_000E_2001<, , , , , , , , >).MakeGenericType(_0002), 
				10 => typeof(_0006_2000<, , , , , , , , , >).MakeGenericType(_0002), 
				_ => null, 
			};
		}

		private static Type _0003(Type[] _0002)
		{
			return _0002.Length switch
			{
				0 => typeof(_0002), 
				1 => typeof(_0003<>).MakeGenericType(_0002), 
				2 => typeof(_0005<, >).MakeGenericType(_0002), 
				3 => typeof(_0008<, , >).MakeGenericType(_0002), 
				4 => typeof(_0006<, , , >).MakeGenericType(_0002), 
				5 => typeof(_000E<, , , , >).MakeGenericType(_0002), 
				6 => typeof(_000F<, , , , , >).MakeGenericType(_0002), 
				7 => typeof(_0002_2000<, , , , , , >).MakeGenericType(_0002), 
				8 => typeof(_0003_2000<, , , , , , , >).MakeGenericType(_0002), 
				9 => typeof(_0005_2000<, , , , , , , , >).MakeGenericType(_0002), 
				_ => null, 
			};
		}
	}

	private static class _0005
	{
		public static readonly bool _0002;

		static _0005()
		{
			try
			{
				global::_0002_2008._0005._0002 = _0002();
			}
			catch
			{
				global::_0002_2008._0005._0002 = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _0002()
		{
			if (typeof(DynamicMethod).IsAbstract)
			{
				return false;
			}
			try
			{
				new DynamicMethod(string.Empty, typeof(void), Type.EmptyTypes);
			}
			catch (PlatformNotSupportedException)
			{
				return false;
			}
			return true;
		}
	}

	private static class _0005_2000
	{
		private static readonly Dictionary<MethodBase, MethodInfo> m__0002 = new Dictionary<MethodBase, MethodInfo>();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MethodBase _0002(_0002_2008 _0002, _0003_2001 _0003, MethodBase _0005, bool _0008)
		{
			lock (global::_0002_2008._0005_2000.m__0002)
			{
				if (global::_0002_2008._0005_2000.m__0002.TryGetValue(_0005, out var value))
				{
					return value;
				}
				MethodInfo methodInfo = _0005 as MethodInfo;
				Type returnType = (((object)methodInfo == null) ? global::_0002_2008.m__0002_2004 : methodInfo.ReturnType);
				ParameterInfo[] parameters = _0005.GetParameters();
				Type[] array;
				if (_0005.IsStatic)
				{
					array = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				else
				{
					array = new Type[parameters.Length + 1];
					Type type = _0005.DeclaringType;
					if (type.IsValueType)
					{
						type = type.MakeByRefType();
						_0008 = false;
					}
					array[0] = type;
					for (int j = 0; j < parameters.Length; j++)
					{
						array[j + 1] = parameters[j].ParameterType;
					}
				}
				string empty = string.Empty;
				if ((object)value == null)
				{
					value = new DynamicMethod(empty, returnType, array, _0002._0002(_0003._0002(), _0003: true), skipVisibility: true);
				}
				ILGenerator iLGenerator = ((DynamicMethod)value).GetILGenerator();
				for (int k = 0; k < array.Length; k++)
				{
					iLGenerator.Emit(OpCodes.Ldarg, k);
				}
				ConstructorInfo constructorInfo = _0005 as ConstructorInfo;
				if ((object)constructorInfo != null)
				{
					iLGenerator.Emit(_0008 ? OpCodes.Callvirt : OpCodes.Call, constructorInfo);
				}
				else
				{
					iLGenerator.Emit(_0008 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)_0005);
				}
				iLGenerator.Emit(OpCodes.Ret);
				global::_0002_2008._0005_2000.m__0002.Add(_0005, value);
				return value;
			}
		}
	}

	private delegate object _0006(object _0002, object[] _0003);

	private sealed class _0006_2000 : IDisposable
	{
		public _0002_2007 _0002;

		public _0008_2002 _0003;

		public _0005_2004 _0005;

		public long _0008;

		public void Dispose()
		{
			IDisposable disposable = _0003;
			if (disposable != null)
			{
				disposable.Dispose();
				disposable = null;
			}
			if (_0005 != null)
			{
				_0005.Dispose();
				_0005 = null;
			}
		}
	}

	private struct _0008
	{
		private readonly uint m__0002;

		private readonly object _0003;

		public _0008(uint _0002)
		{
			this.m__0002 = _0002;
			_0003 = null;
		}

		public _0008(uint _0002, object _0003)
		{
			this.m__0002 = _0002;
			this._0003 = _0003;
		}

		public uint _0002()
		{
			return this.m__0002;
		}

		public object _0002()
		{
			return _0003;
		}
	}

	private struct _0008_2000 : IEquatable<_0008_2000>
	{
		private readonly MethodBase m__0002;

		private readonly bool _0003;

		public _0008_2000(MethodBase _0002, bool _0003)
		{
			this.m__0002 = _0002;
			this._0003 = _0003;
		}

		public MethodBase _0002()
		{
			return this.m__0002;
		}

		public bool _0002()
		{
			return _0003;
		}

		public override int GetHashCode()
		{
			return this._0002().GetHashCode() ^ this._0002().GetHashCode();
		}

		public override bool Equals(object _0002)
		{
			if (_0002 is _0008_2000)
			{
				_0008_2000 obj = (_0008_2000)_0002;
				return Equals(obj);
			}
			return false;
		}

		public bool Equals(_0008_2000 _0002)
		{
			if ((object)this._0002() == _0002._0002())
			{
				return this._0002() == _0002._0002();
			}
			return false;
		}
	}

	private sealed class _000E
	{
		private string m__0002;

		private Type _0003;

		public string _0002()
		{
			return this.m__0002;
		}

		public void _0002(string _0002)
		{
			this.m__0002 = _0002;
		}

		public Type _0002()
		{
			return _0003;
		}

		public void _0002(Type _0002)
		{
			_0003 = _0002;
		}
	}

	private sealed class _000E_2000<_0002> : IComparer<KeyValuePair<int, _0002>>
	{
		private readonly Comparison<_0002> _0002;

		public _000E_2000(Comparison<_0002> _0002)
		{
			this._0002 = _0002;
		}

		public int Compare(KeyValuePair<int, _0002> _0002, KeyValuePair<int, _0002> _0003)
		{
			int num = this._0002(_0002.Value, _0003.Value);
			if (num == 0)
			{
				return _0003.Key.CompareTo(_0002.Key);
			}
			return num;
		}
	}

	private delegate void _000F(_0002_2008 _0002, _000E_2001 _0003);

	private Stream m__0005_2001;

	private _0008_2002 m__0006_2003;

	private uint? m__0008_2001;

	private long m__0002_2001;

	private readonly _0003_200B m__0008_2003;

	private static readonly Dictionary<_0008_2000, _0006> m__000F_2000 = new Dictionary<_0008_2000, _0006>(256);

	private Type[] m__0005_2004;

	private readonly Stack<_0008> m__0005_2000 = new Stack<_0008>();

	private Stack<_0006_2000> m__0003_2004;

	private static Type m__0005_2002 = typeof(MethodBase);

	private static Dictionary<int, _0002_2000> m__000F_2001;

	private _000E_2001 m__0008_2004;

	private Type m__0005_2003;

	private uint m__0006_2000;

	private uint m__0008_2002;

	private static readonly Dictionary<MethodBase, object> m__000E_2001 = new Dictionary<MethodBase, object>();

	private _0008_2002 m__0003_2000;

	private static readonly Dictionary<int, object> m__000F_2003 = new Dictionary<int, object>();

	private static Type m__0003 = typeof(Assembly);

	private readonly Module m__0002_2003;

	private byte[] m__0002;

	private static readonly Dictionary<MethodBase, int> m__0006 = new Dictionary<MethodBase, int>(256);

	private readonly Stack<_000E_2001> m__0003_2001 = new Stack<_000E_2001>(16);

	private uint m__0003_2002;

	private _000E_2001 m__000F;

	private static object m__0006_2002 = new object();

	private static Type m__0002_2000 = typeof(object[]);

	private object[] m__000E_2000;

	private bool m__0008;

	private _0008_200A[] m__0008_2000;

	private static Type m__0002_2002 = typeof(RuntimeHelpers);

	private static Type m__000E = typeof(IntPtr);

	private bool m__000E_2003;

	private static Type m__0002_2004 = typeof(void);

	private Type[] m__000F_2002;

	private _000E_2001[] m__000E_2002;

	private object m__0003_2003;

	private _0003_2001 m__0006_2001;

	private _000E_2001[] m__0005;

	public _0002_2008(_0003_200B _0002, Module _0003)
	{
		this.m__0008_2003 = _0002;
		this.m__0002_2003 = _0003;
		_000E();
	}

	public _0002_2008(_0003_200B _0002)
		: this(_0002, typeof(_0002_2008).Module)
	{
	}

	private static void _0002_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(1);
	}

	private static void _0003_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		uint num = ((_000E_2005)_0003)._0002();
		_0002._0002(null, num);
	}

	private static void _0006_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0002: true, _0003: true);
	}

	private void _0006(int _0002)
	{
		_0005(new _0006_2004(_0002));
	}

	private static void _0008_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		double num = obj._0002() switch
		{
			16 => (uint)((_0006_2004)obj)._0002(), 
			26 => (ulong)((_000F_2004)obj)._0002(), 
			15 => Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		};
		_0003_2003 obj2 = new _0003_2003();
		obj2._0002(num);
		_0002._0005(obj2);
	}

	public static object _0002(Type _0002)
	{
		if (_0002.IsValueType)
		{
			return Activator.CreateInstance(_0002);
		}
		return null;
	}

	private static void _0008_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0006_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		uint num = ((_000E_2005)_0003)._0002();
		_0002._0002(num);
	}

	private void _0002(long _0002)
	{
		this.m__0003_2000._0002()._0005_2004_200A_2002_0002(_0002 - this.m__0002_2001);
	}

	private int _0002()
	{
		return 958208842;
	}

	private static void _0005_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0002: false, _0003: false);
	}

	private static void _0008_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		uint num = obj._0002() switch
		{
			16 => (uint)((_0006_2004)obj)._0002(), 
			26 => (uint)((_000F_2004)obj)._0002(), 
			15 => (uint)Convert.ToInt64(obj._000E_2001_200A_2002_0002()), 
			_ => throw new InvalidOperationException(), 
		};
		_0006_2004[] array = (_0006_2004[])((_0002_2002)_0003)._0002();
		if (num < array.Length)
		{
			uint num2 = (uint)array[num]._0002();
			_0002._0002(num2);
		}
	}

	private static _0002_2007 _0002(_0002_2008 _0002)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_000E_2001 obj3 = _0002._0002();
		if (obj._0002() != 26)
		{
			throw new InvalidOperationException();
		}
		long num = ((_000F_2004)obj)._0002();
		int num2 = obj2._0002();
		if (num2 != 1 && num2 != 8)
		{
			throw new InvalidOperationException();
		}
		byte[] array = global::_0006_200B._0002(obj2._000E_2001_200A_2002_0002());
		if (obj3._0002() != 16)
		{
			throw new InvalidOperationException();
		}
		int num3 = ((_0006_2004)obj3)._0002();
		_0002_2007 obj4 = new _0002_2007();
		obj4._0002(num3);
		obj4._0002(array);
		obj4._0002(num);
		return obj4;
	}

	[Conditional("DEBUG")]
	private void _0002(object _0002)
	{
	}

	private bool _0003(MethodBase _0002, object _0003, ref object _0005, object[] _0008)
	{
		Type declaringType = _0002.DeclaringType;
		if ((object)declaringType == null)
		{
			return false;
		}
		if (global::_000F_200A._0002(declaringType))
		{
			if (string.Equals(_0002.Name, global::_000F_2004_2000._0002(-1506765950), StringComparison.Ordinal))
			{
				_0005 = _0003 != null;
			}
			else if (string.Equals(_0002.Name, global::_000F_2004_2000._0002(-1506765923), StringComparison.Ordinal))
			{
				if (_0003 == null)
				{
					return ((bool?)null).Value;
				}
				_0005 = _0003;
			}
			else if (_0002.Name.Equals(global::_000F_2004_2000._0002(-1506766227), StringComparison.Ordinal))
			{
				if (_0003 == null)
				{
					_0005 = Activator.CreateInstance(Nullable.GetUnderlyingType(_0002.DeclaringType));
				}
				_0005 = _0003;
			}
			else
			{
				if (_0003 != null || _0002.IsStatic)
				{
					return false;
				}
				_0005 = null;
			}
			return true;
		}
		if ((object)declaringType == global::_0002_2008.m__0003)
		{
			if (_0002.Name.Equals(global::_000F_2004_2000._0002(-1506766267), StringComparison.Ordinal))
			{
				_0005 = global::_000F_200A._000E;
				return true;
			}
			if (this.m__000E_2000 != null && _0002.Name == global::_000F_2004_2000._0002(-1506766248))
			{
				Assembly assembly = null;
				object[] array = this.m__000E_2000;
				for (int i = 0; i < array.Length; i++)
				{
					assembly = array[i] as Assembly;
					if ((object)assembly != null)
					{
						_0005 = assembly;
						return true;
					}
				}
			}
		}
		else if ((object)declaringType == global::_0002_2008.m__0005_2002)
		{
			if (_0002.Name == global::_000F_2004_2000._0002(-1506766287))
			{
				if (this.m__000E_2000 != null)
				{
					MethodBase methodBase = null;
					object[] array = this.m__000E_2000;
					for (int i = 0; i < array.Length; i++)
					{
						methodBase = array[i] as MethodBase;
						if ((object)methodBase != null)
						{
							_0005 = methodBase;
							return true;
						}
					}
				}
				_0005 = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return this._0002(_0002, _0003, ref _0005, _0008);
		}
		return false;
	}

	private static bool _0003(_000E_2001 _0002, _000E_2001 _0003)
	{
		bool result = false;
		switch (_0002._0002())
		{
		case 16:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0003(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(((_000F_2002)_0003)._0002())));
			}
			result = ((_0006_2004)_0002)._0002() < ((_0006_2004)_0003)._0002();
			break;
		case 26:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0003(_0002, (_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0003)._0002())));
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0003(_0002, (_000E_2001)new _000F_2004(((_0006_2004)_0003)._0002()));
			}
			result = ((_000F_2004)_0002)._0002() < ((_000F_2004)_0003)._0002();
			break;
		case 15:
			return global::_0002_2008._0003((_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0002)._0002())), _0003);
		case 14:
			result = ((_0003_2003)_0002)._0002() < ((_0003_2003)_0003)._0002();
			break;
		}
		return result;
	}

	private static void _0002_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(global::_0002_2008.m__000E);
	}

	private static void _0006_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003_2000(_0002: true);
	}

	private void _000F()
	{
		_0002(this.m__0008_2000, global::_0002_2008._0002._0002._0002);
	}

	private void _0002(bool _0002, bool _0003)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(_0008(obj2, obj, _0002, _0003));
	}

	private static Exception _0002(string _0002, string _0003)
	{
		return new FieldAccessException(global::_0002_2008._0002(global::_000F_2004_2000._0002(-1506765705) + _0002 + global::_000F_2004_2000._0002(-1506765741), global::_000F_2004_2000._0002(-1506765733) + _0003 + global::_000F_2004_2000._0002(-1506765741)));
	}

	private static _000E_2001 _0003(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (!_0008)
		{
			long num = ((_000F_2004)_0002)._0002();
			long num2 = ((_000F_2004)_0003)._0002();
			long num3 = ((!_0005) ? (num * num2) : checked(num * num2));
			return new _000F_2004(num3);
		}
		ulong num4 = (ulong)((_000F_2004)_0002)._0002();
		ulong num5 = (ulong)((_000F_2004)_0003)._0002();
		ulong num6 = ((!_0005) ? (num4 * num5) : checked(num4 * num5));
		return new _000F_2004((long)num6);
	}

	private static _0006 _0002(_0008_2000 _0002)
	{
		_0006 value;
		lock (global::_0002_2008.m__000F_2000)
		{
			global::_0002_2008.m__000F_2000.TryGetValue(_0002, out value);
		}
		if (value != null)
		{
			return value;
		}
		MethodBase methodBase = _0002._0002();
		lock (global::_0002_2008.m__000E_2001)
		{
			while (global::_0002_2008.m__000E_2001.ContainsKey(methodBase))
			{
				Monitor.Wait(global::_0002_2008.m__000E_2001);
			}
			global::_0002_2008.m__000E_2001[methodBase] = null;
		}
		try
		{
			lock (global::_0002_2008.m__000F_2000)
			{
				global::_0002_2008.m__000F_2000.TryGetValue(_0002, out value);
			}
			if (value == null)
			{
				value = global::_0002_2008._0002(methodBase, _0002._0002());
				lock (global::_0002_2008.m__000F_2000)
				{
					global::_0002_2008.m__000F_2000[_0002] = value;
				}
			}
			return value;
		}
		finally
		{
			lock (global::_0002_2008.m__000E_2001)
			{
				global::_0002_2008.m__000E_2001.Remove(methodBase);
				Monitor.PulseAll(global::_0002_2008.m__000E_2001);
			}
		}
	}

	private static void _0005_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0003(obj._000E_2001_200A_2002_0002());
	}

	private static void _0003_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		object obj = _0002._0002()._000E_2001_200A_2002_0002();
		long num = _0002._0002();
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(sbyte))
		{
			_000E_2001 obj2 = global::_000E_2001._0002(obj, typeof(sbyte));
			((sbyte[])array)[num] = (sbyte)obj2._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(byte))
		{
			_000E_2001 obj3 = global::_000E_2001._0002(obj, typeof(byte));
			((byte[])array)[num] = (byte)obj3._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(bool))
		{
			_000E_2001 obj4 = global::_000E_2001._0002(obj, typeof(bool));
			((bool[])array)[num] = (bool)obj4._000E_2001_200A_2002_0002();
		}
		else if (elementType.IsEnum)
		{
			_0002._0002(elementType, obj, num, array);
		}
		else
		{
			_0002._0002(typeof(sbyte), obj, num, array);
		}
	}

	private static Exception _0005(string _0002, string _0003)
	{
		return new MethodAccessException(global::_0002_2008._0002(global::_000F_2004_2000._0002(-1506765705) + _0002 + global::_000F_2004_2000._0002(-1506765741), global::_000F_2004_2000._0002(-1506766374) + _0003 + global::_000F_2004_2000._0002(-1506765741)));
	}

	private static void _000E_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0006_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0002: true, _0003: false);
	}

	private void _0005()
	{
		if (this.m__0005_2000.Count == 0)
		{
			if (this.m__0008)
			{
				_0003(this.m__0003_2003);
			}
			return;
		}
		_0008 obj = this.m__0005_2000.Pop();
		if (obj._0002() != null)
		{
			_000F_2007 obj2 = new _000F_2007();
			obj2._000E_2001_200A_2002_0002(obj._0002());
			_0005(obj2);
		}
		else
		{
			_0002_2000();
		}
		_0002(obj._0002());
	}

	private static void _0003_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(6);
	}

	private void _000F_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_0005(new _0006_2004(obj._0002() switch
		{
			16 => (!_0002) ? ((ushort)((_0006_2004)obj)._0002()) : checked((ushort)(uint)((_0006_2004)obj)._0002()), 
			26 => (!_0002) ? ((ushort)((_000F_2004)obj)._0002()) : checked((ushort)(ulong)((_000F_2004)obj)._0002()), 
			15 => (!_0002) ? ((ushort)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((ushort)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((ushort)((_0003_2003)obj)._0002()) : checked((ushort)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((!_0002) ? ((ushort)(long)((_000E_2006)obj)._0002()) : checked((ushort)(ulong)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((ushort)(int)((_000E_2006)obj)._0002()) : checked((ushort)(int)((_000E_2006)obj)._0002())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private bool _0002(MethodBase _0002)
	{
		if (!_0002.IsVirtual)
		{
			return false;
		}
		if (this._0002(this.m__0006_2001._0002(), _0003: true).IsSubclassOf(_0002.DeclaringType))
		{
			return true;
		}
		return false;
	}

	private long _0002()
	{
		_000E_2001 obj = this._0002();
		return obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002(), 
			24 => ((_000E_2006)obj)._0002().ToInt64(), 
			7 => (long)((_0005_2007)obj)._0002().ToUInt64(), 
			15 => Convert.ToInt64(((_000F_2002)obj)._0002()), 
			_ => throw new Exception(global::_000F_2004_2000._0002(-1506765915)), 
		};
	}

	private static string _0002(string _0002, string _0003)
	{
		string fullName = typeof(_0002_2008).Assembly.FullName;
		return global::_000F_2004_2000._0002(-1506762907) + _0002 + global::_000F_2004_2000._0002(-1506762889) + _0003 + global::_000F_2004_2000._0002(-1506762943) + Environment.NewLine + Environment.NewLine + global::_000F_2004_2000._0002(-1506762928) + fullName + global::_000F_2004_2000._0002(-1506762975);
	}

	private _000E_2000[] _0002(_0008_2002 _0002)
	{
		_000E_2000[] array = new _000E_2000[_0002._0002()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this._0002(_0002);
		}
		return array;
	}

	private static void _000E_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0002: true);
	}

	public object _0002(Stream _0002, string _0003, object[] _0005, Type[] _0008, Type[] _0006, object[] _000E)
	{
		this.m__0005_2001 = _0002;
		this._0002(_0002, _0003);
		return this._0002(_0005, _0008, _0006, _000E);
	}

	private _000E_2001 _0002(_000E_2001 _0002)
	{
		if (_0002._0002() == 16)
		{
			return new _0006_2004(-((_0006_2004)_0002)._0002());
		}
		if (_0002._0002() == 26)
		{
			return new _000F_2004(-((_000F_2004)_0002)._0002());
		}
		if (_0002._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(0.0 - ((_0003_2003)_0002)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
			{
				return this._0002((_000E_2001)new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())));
			}
			return this._0002((_000E_2001)new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())));
		}
		throw new InvalidOperationException();
	}

	private static void _000E_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002_2007 obj = global::_0002_2008._0002(_0002);
		_0005_2004 obj2 = _0002.m__0003_2000._0002();
		long num = _0002._0003();
		byte[] array = new _0006_2007(obj._000F_2006_200A_2002_0002(), obj._000F_2006_200A_2002_0002())._0002(obj2, obj);
		_0006_2000 obj3 = new _0006_2000
		{
			_0002 = obj,
			_0008 = num
		};
		obj._0003(global::_0008_2007._0003(array.Length) - array.Length);
		obj3._0003 = new _0008_2002(obj3._0005 = new _0008_2004(array, 0, array.Length, _0008: false));
		_0002._0002().Push(obj3);
		_0002._0002(obj3);
	}

	private static void _0006_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0002: true);
	}

	private void _0008(bool _0002)
	{
		_000E_2001 obj = this._0002();
		long num = obj._0002() switch
		{
			16 => (!_0002) ? ((_0006_2004)obj)._0002() : ((_0006_2004)obj)._0002(), 
			26 => (!_0002) ? ((_000F_2004)obj)._0002() : ((_000F_2004)obj)._0002(), 
			15 => (!_0002) ? ((long)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((long)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((long)((_0003_2003)obj)._0002()) : checked((long)((_0003_2003)obj)._0002()), 
			24 => (!_0002) ? ((long)((_000E_2006)obj)._0002()) : ((long)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		};
		_000F_2004 obj2 = new _000F_2004();
		obj2._0002(num);
		_0005(obj2);
	}

	private static void _000E_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(sbyte));
	}

	private static _0008_200A _0002(_0008_2002 _0002)
	{
		_0008_200A obj = new _0008_200A();
		obj._0002(_0002._0002());
		obj._0003(_0002._0006());
		obj._0008(_0002._0002());
		obj._0005(_0002._0002());
		obj._0003(_0002._0002());
		obj._0002(_0002._0002());
		return obj;
	}

	private static void _0003_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(3);
	}

	public void _0002(Stream _0002, string _0003, object[] _0005)
	{
		this._0002(_0002, _0003, _0005);
	}

	private static void _0003_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0002: false, _0003: false);
	}

	private static void _000F_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0003);
	}

	private static void _0002_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0006_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(8);
	}

	private void _0003(_000E_2001 _0002)
	{
		_0006_2004 obj = (_0006_2004)_0002;
		MethodBase methodBase = this._0002(obj._0002());
		if ((object)this.m__0005_2003 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.m__0005_2003.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if ((object)method != null)
			{
				methodBase = method;
			}
			this.m__0005_2003 = null;
		}
		this._0002(methodBase, _0003: true);
	}

	private void _0002(int _0002)
	{
		_000E_2009 obj = new _000E_2009();
		obj._0002(_0002);
		_0005(obj);
	}

	private static void _0006_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_000E_2001 obj = _0002._0002();
		_0005_2008 obj2 = obj as _0005_2008;
		if (obj2 != null)
		{
			obj = _0002._0002(obj2);
		}
		object obj3 = obj._000E_2001_200A_2002_0002();
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		_0002._0005(global::_000E_2001._0002(fieldInfo.GetValue(obj3), fieldInfo.FieldType));
	}

	private static void _0005_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(7);
	}

	private static void _0002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002_2000(_0002: false);
	}

	private static void _000E_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E_2000(_0002: true);
	}

	private static byte[] _0002(_0008_2002 _0002)
	{
		int num = _0002._0006();
		byte[] array = new byte[num];
		_0002._0002(array, 0, num);
		return array;
	}

	private _000E_2001 _0002(_000E_2001 _0002, _000E_2001 _0003, bool _0005)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0005)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					return new _0006_2004(num / num2);
				}
				int num3 = ((_0006_2004)_0002)._0002();
				uint num4 = (uint)((_0006_2004)_0003)._0002();
				return new _0006_2004((int)((uint)num3 / num4));
			}
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0003(new _000F_2004(((_0006_2004)_0002)._0002()), _0003, _0005);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					return global::_0002_2008._0003(new _000F_2004(((_0006_2004)_0002)._0002()), new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005);
				}
				return this._0002(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0003(_0002, _0003, _0005);
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0003(_0002, new _000F_2004(((_0006_2004)_0003)._0002()), _0005);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return global::_0002_2008._0003(_0002, new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005);
				}
				return global::_0002_2008._0003(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 14 && _0003._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(((_0003_2003)_0002)._0002() / ((_0003_2003)_0003)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong))
			{
				return this._0002((_000E_2001)new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
			}
			return this._0002((_000E_2001)new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
		}
		throw new InvalidOperationException();
	}

	private void _0006()
	{
	}

	public object _0002(Stream _0002, string _0003, object[] _0005)
	{
		return this._0002(_0002, _0003, _0005, null, null, null);
	}

	private static void _0002_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		UIntPtr uIntPtr = obj._0002() switch
		{
			16 => new UIntPtr((uint)((_0006_2004)obj)._0002()), 
			26 => new UIntPtr((ulong)((_000F_2004)obj)._0002()), 
			15 => new UIntPtr(Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => new UIntPtr((ulong)((_0003_2003)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		};
		_0005_2007 obj2 = new _0005_2007();
		obj2._0002(uIntPtr);
		_0002._0005(obj2);
	}

	private string _0002(int _0002)
	{
		lock (global::_0002_2008.m__000F_2003)
		{
			bool flag = true;
			if (flag && global::_0002_2008.m__000F_2003.TryGetValue(_0002, out var value))
			{
				return (string)value;
			}
			global::_0005_2000 obj = this._0002(_0002);
			if (obj._0002() == 1)
			{
				return this.m__0002_2003.ResolveString(obj._0002());
			}
			string text = ((global::_0003)obj._0002())._0002();
			if (flag)
			{
				global::_0002_2008.m__000F_2003.Add(_0002, text);
			}
			return text;
		}
	}

	private static void _0003_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0003_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(global::_000F_200A._0002);
	}

	private static _000E_2001 _0002(_000E_2001 _0002, _000E_2001 _0003, bool _0005)
	{
		if (!_0005)
		{
			long num = ((_000F_2004)_0002)._0002();
			long num2 = ((_000F_2004)_0003)._0002();
			return new _000F_2004(num % num2);
		}
		long num3 = ((_000F_2004)_0002)._0002();
		ulong num4 = (ulong)((_000F_2004)_0003)._0002();
		return new _000F_2004((long)((ulong)num3 % num4));
	}

	private static void _000E_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(_0002._0003(obj));
	}

	[DebuggerNonUserCode]
	private MethodBase _0002(int _0002, global::_0005_2000 _0003)
	{
		lock (global::_0002_2008.m__000F_2003)
		{
			bool flag = true;
			if (flag && global::_0002_2008.m__000F_2003.TryGetValue(_0002, out var value))
			{
				return (MethodBase)value;
			}
			if (_0003._0002() == 1)
			{
				MethodBase methodBase = this.m__0002_2003.ResolveMethod(_0003._0002());
				if (flag)
				{
					global::_0002_2008.m__000F_2003.Add(_0002, methodBase);
				}
				return methodBase;
			}
			_0006_2000_2000 obj = (_0006_2000_2000)_0003._0002();
			if (obj._0003())
			{
				return this._0002(obj);
			}
			Type type = this._0002(obj._0002()._0002(), _0003: false);
			Type type2 = this._0002(obj._0003()._0002(), _0003: true);
			Type[] array = new Type[obj._0002().Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this._0002(obj._0002()[i]._0002(), _0003: true);
			}
			if (type.IsGenericType)
			{
				flag = false;
			}
			if (obj._0002() == global::_000F_2004_2000._0002(-1506765876))
			{
				ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null);
				if ((object)constructor == null)
				{
					throw new Exception();
				}
				if (flag)
				{
					global::_0002_2008.m__000F_2003.Add(_0002, constructor);
				}
				return constructor;
			}
			BindingFlags bindingAttr = global::_0002_2008._0002(obj._0002());
			MethodBase methodBase2 = null;
			try
			{
				methodBase2 = type.GetMethod(obj._0002(), bindingAttr, null, CallingConventions.Any, array, null);
			}
			catch (AmbiguousMatchException)
			{
				MethodInfo[] methods = type.GetMethods(bindingAttr);
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name != obj._0002() || (object)methodInfo.ReturnType != type2)
					{
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != array.Length)
					{
						continue;
					}
					bool flag2 = false;
					for (int k = 0; k < array.Length; k++)
					{
						if ((object)parameters[k].ParameterType != array[k])
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						methodBase2 = methodInfo;
						break;
					}
				}
			}
			if ((object)methodBase2 == null)
			{
				throw new Exception(string.Format(global::_000F_2004_2000._0002(-1506766405), type.Name, obj._0002()));
			}
			if (flag)
			{
				global::_0002_2008.m__000F_2003.Add(_0002, methodBase2);
			}
			return methodBase2;
		}
	}

	private _000E_2001 _0002(_0005_2008 _0002)
	{
		switch (((_000E_2001)_0002)._0002())
		{
		case 13:
			return ((_0006_2008)_0002)._0002();
		case 17:
			return this.m__000E_2002[((_000E_2009)_0002)._0002()];
		case 3:
		{
			_0008_2009 obj2 = (_0008_2009)_0002;
			return global::_000E_2001._0002(obj2._0002().GetValue(obj2._0002()), null);
		}
		case 5:
		case 12:
		{
			_000F_2008 obj = (_000F_2008)_0002;
			return global::_000E_2001._0002(obj._000F_2008_200A_2002_0002(), obj._0002());
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private void _000E_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		int num = obj._0002() switch
		{
			16 => (!_0002) ? ((_0006_2004)obj)._0002() : ((_0006_2004)obj)._0002(), 
			26 => (int)((!_0002) ? ((_000F_2004)obj)._0002() : checked((int)((_000F_2004)obj)._0002())), 
			15 => (!_0002) ? ((int)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((int)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((int)((_0003_2003)obj)._0002()) : checked((int)((_0003_2003)obj)._0002()), 
			24 => (int)((IntPtr.Size != 4) ? ((!_0002) ? ((long)((_000E_2006)obj)._0002()) : checked((int)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((int)((_000E_2006)obj)._0002()) : ((int)((_000E_2006)obj)._0002()))), 
			_ => throw new InvalidOperationException(), 
		};
		_0006_2004 obj2 = new _0006_2004();
		obj2._0002(num);
		_0005(obj2);
	}

	private static void _000F_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(uint));
	}

	private static void _0003_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0002: true);
	}

	private static bool _0002(object _0002)
	{
		return RemotingServices.IsTransparentProxy(_0002);
	}

	private static void _0008_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (obj._0002() != 16)
		{
			throw new InvalidOperationException();
		}
		int num = ((_0006_2004)obj)._0002();
		Stack<_0006_2000> stack = _0002._0002();
		if (stack.Count < 2)
		{
			throw new InvalidOperationException();
		}
		using _0006_2000 obj2 = stack.Pop();
		if (obj2 == null || obj2._0002._000F_2006_200A_2002_0002() != num)
		{
			throw new InvalidOperationException();
		}
		_0006_2000 obj3 = stack.Peek();
		_0002._0002(obj3);
		_0002.m__0006_2000 += (uint)obj2._0002._0002();
		_0002._0002((long)_0002.m__0006_2000);
	}

	private static void _000F_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(3);
	}

	private static void _0006_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		long num2 = _0002._0002();
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		_0003_2009 obj = new _0003_2009();
		obj._0002(array);
		obj._0002(type);
		obj._0002(num2);
		_0002._0005(obj);
	}

	private static void _000F_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(1);
	}

	private void _0002(_0008_2000_2000 _0002)
	{
		global::_0005_2000 obj = this._0002(_0002._0003());
		_ = (_0006_2000_2000)obj._0002();
		MethodBase methodBase = this._0002(_0002._0003(), obj);
		methodBase.GetParameters();
		int num = _0002._0002();
		bool flag = (num & 0x40000000) != 0;
		num &= -1073741825;
		Type[] array = this.m__000F_2002;
		Type[] array2 = this.m__0005_2004;
		try
		{
			this.m__000F_2002 = ((methodBase is ConstructorInfo) ? null : methodBase.GetGenericArguments());
			this.m__0005_2004 = methodBase.DeclaringType.GetGenericArguments();
			this._0002(num, this.m__000F_2002, this.m__0005_2004, flag);
		}
		finally
		{
			this.m__000F_2002 = array;
			this.m__0005_2004 = array2;
		}
	}

	private Type _0002(int _0002, global::_0005_2000 _0003, ref bool _0005, bool _0008)
	{
		if (_0003._0002() == 1)
		{
			return this.m__0002_2003.ResolveType(_0003._0002());
		}
		global::_0008 obj = (global::_0008)_0003._0002();
		Type type;
		if (obj._0002())
		{
			if (obj._0003() != -1)
			{
				if (this.m__000F_2002 == null)
				{
					throw new InvalidOperationException(global::_000F_2004_2000._0002(-1506766129));
				}
				type = this.m__000F_2002[obj._0003()];
			}
			else
			{
				if (obj._0002() == -1)
				{
					throw new Exception();
				}
				if (this.m__0005_2004 == null)
				{
					throw new InvalidOperationException(global::_000F_2004_2000._0002(-1506766120));
				}
				type = this.m__0005_2004[obj._0002()];
			}
			Stack<_000E_200A> stack = global::_000F_200A._0002(obj._0002());
			type = global::_000F_200A._0002(type, stack);
			_0005 = false;
			return type;
		}
		string text = obj._0002();
		type = Type.GetType(text);
		if ((object)type == null)
		{
			int num = text.IndexOf(',');
			string text2 = text.Substring(0, num);
			string text3 = text.Substring(num + 1).Trim();
			Assembly assembly = global::_000F_200A._000E;
			if (text3.Equals(assembly.FullName, StringComparison.Ordinal))
			{
				type = assembly.GetType(text2);
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly2 in assemblies)
				{
					string value = null;
					try
					{
						value = assembly2.Location;
					}
					catch (NotSupportedException)
					{
					}
					if (string.IsNullOrEmpty(value) && assembly2.FullName.Equals(text3, StringComparison.Ordinal))
					{
						type = assembly2.GetType(text2);
						if ((object)type != null)
						{
							break;
						}
					}
				}
			}
			if ((object)type == null && text2.StartsWith(global::_000F_2004_2000._0002(-1506766167), StringComparison.Ordinal) && text2.Contains(global::_000F_2004_2000._0002(-1506765669)))
			{
				try
				{
					Type[] types = Assembly.Load(text3).GetTypes();
					foreach (Type type2 in types)
					{
						if (type2.FullName == text2)
						{
							type = type2;
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		if ((object)type == null)
		{
			throw new TypeLoadException(string.Format(global::_000F_2004_2000._0002(-1506766185), text));
		}
		if (obj._0003())
		{
			Type[] array = new Type[obj._0002().Length];
			for (int j = 0; j < obj._0002().Length; j++)
			{
				array[j] = this._0002(obj._0002()[j]._0002(), _0008);
			}
			if (array != null)
			{
				Type genericTypeDefinition = global::_000F_200A._0002(type).GetGenericTypeDefinition();
				Stack<_000E_200A> stack2 = global::_000F_200A._0002(type);
				type = genericTypeDefinition.MakeGenericType(array);
				type = global::_000F_200A._0002(type, stack2);
			}
			_0005 = false;
		}
		return type;
	}

	private static void _000F_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		Debugger.Break();
	}

	private static void _0006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _000F_2004(obj._0002() switch
		{
			16 => (uint)((_0006_2004)obj)._0002(), 
			26 => ((_000F_2004)obj)._0002(), 
			15 => (long)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (long)checked((ulong)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((long)((_000E_2006)obj)._0002()) : ((uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private _000E_2001 _0008(_000E_2001 _0002, _000E_2001 _0003)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				int num = ((_0006_2004)_0002)._0002();
				int num2 = ((_0006_2004)_0003)._0002();
				return new _0006_2004(num << num2);
			}
			if (_0003._0002() == 15)
			{
				return this._0008(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())));
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 16)
			{
				long num3 = ((_000F_2004)_0002)._0002();
				int num4 = ((_0006_2004)_0003)._0002();
				return new _000F_2004(num3 << num4);
			}
			if (_0003._0002() == 15)
			{
				return this._0008(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())));
			}
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
			{
				return this._0008((_000E_2001)new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003);
			}
			return this._0008((_000E_2001)new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003);
		}
		throw new InvalidOperationException();
	}

	private static void _0008_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_000E_2001 obj = global::_000E_2001._0002(_0002._0002()._000E_2001_200A_2002_0002(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, obj._000E_2001_200A_2002_0002());
	}

	private static _000E_2001 _0002(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (!_0008)
		{
			long num = ((_000F_2004)_0002)._0002();
			long num2 = ((_000F_2004)_0003)._0002();
			long num3 = ((!_0005) ? (num + num2) : checked(num + num2));
			return new _000F_2004(num3);
		}
		ulong num4 = (ulong)((_000F_2004)_0002)._0002();
		ulong num5 = (ulong)((_000F_2004)_0003)._0002();
		ulong num6 = ((!_0005) ? (num4 + num5) : checked(num4 + num5));
		return new _000F_2004((long)num6);
	}

	private static void _0008_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(int));
	}

	private void _0005(_000E_2001 _0002)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(global::_000F_2004_2000._0002(-1506766824));
		}
		_000E_2001 obj;
		if ((object)_0002._0002() != null)
		{
			obj = _0002;
		}
		else
		{
			switch (_0002._0002())
			{
			case 0:
			{
				_0003_2003 obj5 = new _0003_2003();
				obj5._0002(((_0008_2003)_0002)._0002());
				obj5._0002(_0002._0002());
				obj = obj5;
				break;
			}
			case 21:
			{
				_0006_2004 obj7 = new _0006_2004(((_000E_2003)_0002)._0002());
				obj7._0002(_0002._0002());
				obj = obj7;
				break;
			}
			case 6:
			{
				_0006_2004 obj6 = new _0006_2004(((_0002_2004)_0002)._0002());
				obj6._0002(_0002._0002());
				obj = obj6;
				break;
			}
			case 19:
			{
				_0006_2004 obj10 = new _0006_2004(((_0003_2005)_0002)._0002());
				obj10._0002(_0002._0002());
				obj = obj10;
				break;
			}
			case 25:
			{
				_0006_2004 obj9 = new _0006_2004(((_0008_2005)_0002)._0002());
				obj9._0002(_0002._0002());
				obj = obj9;
				break;
			}
			case 10:
			{
				_0006_2004 obj8 = new _0006_2004((int)((_000E_2005)_0002)._0002());
				obj8._0002(_0002._0002());
				obj = obj8;
				break;
			}
			case 23:
			{
				_000F_2004 obj11 = new _000F_2004((long)((_0002_2006)_0002)._0002());
				obj11._0002(_0002._0002());
				obj = obj11;
				break;
			}
			case 20:
			{
				_0006_2004 obj4 = new _0006_2004(((_0005_2002)_0002)._0002() ? 1 : 0);
				obj4._0002(_0002._0002());
				obj = obj4;
				break;
			}
			case 11:
			{
				_0006_2004 obj3 = new _0006_2004(((_0006_2002)_0002)._0002());
				obj3._0002(_0002._0002());
				obj = obj3;
				break;
			}
			case 8:
			{
				object obj2 = _0002._000E_2001_200A_2002_0002();
				if (obj2 == null)
				{
					obj = _0002;
					break;
				}
				Type type = obj2.GetType();
				if (type.HasElementType && !type.IsArray)
				{
					type = type.GetElementType();
				}
				obj = (((object)type == null || type.IsValueType || type.IsEnum) ? global::_000E_2001._0002(obj2, type) : _0002);
				break;
			}
			default:
				obj = _0002;
				break;
			}
		}
		if (this.m__0008_2004 != null)
		{
			if (this.m__000F != null)
			{
				this.m__0003_2001.Push(this.m__000F);
			}
			this.m__000F = this.m__0008_2004;
		}
		this.m__0008_2004 = obj;
	}

	private static void _000F_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (global::_0002_2008._0002(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private void _0002(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(_0008(obj2, obj, _0002));
	}

	private static void _0003_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_0002._0002(type);
	}

	private static void _000E_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0002: false);
	}

	private static void _0005_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(short));
	}

	private static void _0003_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_000E_2001 obj = _0002._0002();
		_0005_2008 obj2 = obj as _0005_2008;
		object obj3 = ((obj2 == null) ? obj._000E_2001_200A_2002_0002() : _0002._0002(obj2)._000E_2001_200A_2002_0002());
		_0002._0005(new _0008_2009(fieldInfo, obj3, obj2));
	}

	private static void _0005_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003_2000();
	}

	private static void _0006_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_0002._0005(new _0008_2009(fieldInfo, null));
	}

	private void _0005_2000()
	{
		_0006_2000(_0002: false);
	}

	private static void _0002(Exception _0002)
	{
		try
		{
			MethodInfo method = typeof(Exception).GetMethod(global::_000F_2004_2000._0002(-1506766328), BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if ((object)method != null)
			{
				method.Invoke(_0002, null);
				return;
			}
		}
		catch
		{
		}
		try
		{
			Type type = _0002.GetType();
			if (type.IsSerializable)
			{
				StreamingContext context = new StreamingContext(StreamingContextStates.CrossAppDomain);
				ObjectManager objectManager = new ObjectManager(null, context);
				SerializationInfo info = new SerializationInfo(type, new FormatterConverter());
				_0002.GetObjectData(info, context);
				objectManager.RegisterObject(_0002, 1L, info);
				objectManager.DoFixups();
			}
		}
		catch
		{
		}
	}

	private static void _0008_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766622));
	}

	private void _0003(int _0002)
	{
		_0005(this.m__0005[_0002]._000E_2001_200A_2002_0002());
	}

	private static bool _0005(_000E_2001 _0002, _000E_2001 _0003)
	{
		bool flag = false;
		switch (_0002._0002())
		{
		case 16:
			return (uint)((_0006_2004)_0002)._0002() > (uint)((_0006_2004)_0003)._0002();
		case 26:
			return (ulong)((_000F_2004)_0002)._0002() > (ulong)((_000F_2004)_0003)._0002();
		case 14:
		{
			double num3 = ((_0003_2003)_0002)._0002();
			double num4 = ((_0003_2003)_0003)._0002();
			return num3 > num4 || double.IsNaN(num3) || double.IsNaN(num4);
		}
		case 24:
			if (_0003._0002() == 8 && _0003._000E_2001_200A_2002_0002() == null)
			{
				return ((_000E_2006)_0002)._0002() != IntPtr.Zero;
			}
			return ((_000E_2006)_0002)._0002() != ((_000E_2006)_0003)._0002();
		case 7:
			if (_0003._0002() == 8 && _0003._000E_2001_200A_2002_0002() == null)
			{
				return ((_0005_2007)_0002)._0002() != UIntPtr.Zero;
			}
			return ((_0005_2007)_0002)._0002() != ((_0005_2007)_0003)._0002();
		case 8:
			return ((_000F_2007)_0002)._0002() != ((_000F_2007)_0003)._0002();
		case 4:
			if (_0003._0002() == 8 && _0003._000E_2001_200A_2002_0002() == null)
			{
				return true;
			}
			return ((_0006_200A)_0002)._0002() != ((_0006_200A)_0003)._0002();
		case 15:
		{
			long num = Convert.ToInt64(((_000F_2002)_0002)._0002());
			long num2 = ((_0003._0002() != 16) ? Convert.ToInt64(((_000F_2002)_0003)._0002()) : ((_0006_2004)_0003)._0002());
			return num > num2;
		}
		default:
			return _0002._000E_2001_200A_2002_0002() != _0003._000E_2001_200A_2002_0002();
		}
	}

	private bool _0002(Type _0002, global::_0005_2000 _0003, out int _0005)
	{
		_0005 = 0;
		global::_0008 obj = (global::_0008)_0003._0002();
		if (global::_000F_200A._0002(_0002).IsGenericParameter)
		{
			if (obj != null && !obj._0002())
			{
				return false;
			}
			return true;
		}
		Type type = this._0002(_0003._0002(), _0003: false);
		if (!global::_0002_2005._0002(_0002, type, out _0005))
		{
			return false;
		}
		return true;
	}

	[Conditional("DEBUG")]
	public static void _0002(string _0002)
	{
	}

	private static object _0002(MethodBase _0002, object _0003, object[] _0005, bool _0008)
	{
		if (!global::_0002_2008._0005._0002)
		{
			return global::_0002_2008._0002(_0002, _0003, _0005);
		}
		_0008_2000 obj = new _0008_2000(_0002, _0008);
		_0006 obj2 = global::_0002_2008._0003(obj);
		if (obj2 == null)
		{
			bool flag;
			lock (global::_0002_2008.m__0006)
			{
				global::_0002_2008.m__0006.TryGetValue(_0002, out var value);
				flag = value >= 50;
				if (!flag)
				{
					global::_0002_2008.m__0006[_0002] = value + 1;
				}
			}
			if (!flag && (_0008 || _0003 != null || _0002.IsStatic || _0002.IsConstructor) && !global::_0002_2008._0002(_0002) && (_0002.CallingConvention & CallingConventions.Any) != CallingConventions.VarArgs)
			{
				return global::_0002_2008._0002(_0002, _0003, _0005);
			}
			obj2 = global::_0002_2008._0002(obj);
			lock (global::_0002_2008.m__0006)
			{
				global::_0002_2008.m__0006.Remove(_0002);
			}
		}
		return obj2(_0003, _0005);
	}

	private static bool _0008(_000E_2001 _0002, _000E_2001 _0003)
	{
		bool result = false;
		switch (_0002._0002())
		{
		case 16:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0008(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(((_000F_2002)_0003)._0002())));
			}
			result = (uint)((_0006_2004)_0002)._0002() < (uint)((_0006_2004)_0003)._0002();
			break;
		case 26:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0008(_0002, (_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0003)._0002())));
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0008(_0002, (_000E_2001)new _000F_2004(((_0006_2004)_0003)._0002()));
			}
			result = (ulong)((_000F_2004)_0002)._0002() < (ulong)((_000F_2004)_0003)._0002();
			break;
		case 15:
			return global::_0002_2008._0008((_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0002)._0002())), _0003);
		case 14:
		{
			double num = ((_0003_2003)_0002)._0002();
			double num2 = ((_0003_2003)_0003)._0002();
			result = num < num2 || double.IsNaN(num) || double.IsNaN(num2);
			break;
		}
		}
		return result;
	}

	private static void _0002_2004_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0002: true, _0003: true);
	}

	private static void _0008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(new _0006_2004(global::_0002_2008._0003(obj2, obj) ? 1 : 0));
	}

	private static void _0002_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(((_000E_2003)_0003)._0002());
	}

	private void _0008()
	{
		_000E_2001 obj = this._0002();
		_0005_2008 obj2 = (_0005_2008)this._0002();
		_0002(obj2, obj);
	}

	private void _000E(int _0002)
	{
		_000E_2001 obj = this._0002();
		this.m__0005[_0002]._000E_2001_200A_2002_0002(obj);
	}

	private static void _000E_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0003);
	}

	private static void _0005_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
	}

	private static void _000E_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (global::_0002_2008._0003(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private Stack<_0006_2000> _0002()
	{
		Stack<_0006_2000> stack = this.m__0003_2004;
		if (stack == null)
		{
			stack = (this.m__0003_2004 = new Stack<_0006_2000>());
			stack.Push(new _0006_2000
			{
				_0003 = this.m__0003_2000,
				_0005 = this.m__0003_2000._0002(),
				_0008 = this.m__0002_2001
			});
		}
		return stack;
	}

	private static void _0008_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0008_2005 obj = (_0008_2005)_0003;
		_0002._0005(obj._0002());
	}

	private int _0003()
	{
		return -1090652793;
	}

	private static _0006 _0003(_0008_2000 _0002)
	{
		lock (global::_0002_2008.m__000F_2000)
		{
			global::_0002_2008.m__000F_2000.TryGetValue(_0002, out var value);
			return value;
		}
	}

	private static void _000F_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008_2000(_0002: true);
	}

	private static void _0008_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		if ((obj2._0002() != 14) ? (!global::_0002_2008._0002(obj2, obj)) : (!global::_0002_2008._0005(obj2, obj)))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private void _0008_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		bool flag = IntPtr.Size == 4;
		IntPtr intPtr;
		switch (obj._0002())
		{
		case 16:
		{
			int value = ((_0006_2004)obj)._0002();
			intPtr = ((!_0002) ? new IntPtr(value) : new IntPtr(value));
			break;
		}
		case 26:
		{
			long num = ((_000F_2004)obj)._0002();
			intPtr = ((!flag) ? ((!_0002) ? new IntPtr(num) : new IntPtr(num)) : ((!_0002) ? new IntPtr((int)num) : new IntPtr(checked((int)num))));
			break;
		}
		case 14:
		{
			double num2 = ((_0003_2003)obj)._0002();
			intPtr = ((!flag) ? ((!_0002) ? new IntPtr((long)num2) : new IntPtr(checked((long)num2))) : ((!_0002) ? new IntPtr((int)num2) : new IntPtr(checked((int)num2))));
			break;
		}
		case 15:
			intPtr = ((!_0002) ? new IntPtr((long)Convert.ToUInt64(((_000F_2002)obj)._0002())) : new IntPtr(checked((long)Convert.ToUInt64(((_000F_2002)obj)._0002()))));
			break;
		default:
			throw new InvalidOperationException();
		}
		_000E_2006 obj2 = new _000E_2006();
		obj2._0002(intPtr);
		_0005(obj2);
	}

	private static _000E_2001 _0008(_000E_2001 _0002, _000E_2001 _0003, bool _0005)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0005)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					return new _0006_2004(num >> num2);
				}
				int num3 = ((_0006_2004)_0002)._0002();
				int num4 = ((_0006_2004)_0003)._0002();
				return new _0006_2004((int)((uint)num3 >> num4));
			}
			if (_0003._0002() == 15)
			{
				return _0008(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 16)
			{
				if (!_0005)
				{
					long num5 = ((_000F_2004)_0002)._0002();
					int num6 = ((_0006_2004)_0003)._0002();
					return new _000F_2004(num5 >> num6);
				}
				long num7 = ((_000F_2004)_0002)._0002();
				int num8 = ((_0006_2004)_0003)._0002();
				return new _000F_2004((long)((ulong)num7 >> num8));
			}
			if (_0003._0002() == 15)
			{
				return _0008(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
			{
				return _0008(new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
			}
			return _0008(new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
		}
		throw new InvalidOperationException();
	}

	private void _0002(ref _0003 _0002, MethodBase _0003, bool _0005)
	{
		bool flag = false;
		if ((object)_0003.DeclaringType == typeof(Interlocked) && _0003.IsStatic)
		{
			string name = _0003.Name;
			if (name == global::_000F_2004_2000._0002(-1506766747) || name == global::_000F_2004_2000._0002(-1506766737) || name == global::_000F_2004_2000._0002(-1506766779) || name == global::_000F_2004_2000._0002(-1506766763) || name == global::_000F_2004_2000._0002(-1506766812) || name == global::_000F_2004_2000._0002(-1506766796))
			{
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
			}
			finally
			{
				Monitor.Enter(global::_0002_2008.m__0006_2002);
				_0002._0002 = true;
			}
		}
	}

	private static void _000E_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0003);
	}

	private static void _0006_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2003 obj = (_000E_2003)_0003;
		_0006_2008 obj2 = new _0006_2008();
		obj2._0002(_0002.m__0005[obj._0002()]);
		_0002._0005(obj2);
	}

	private void _0002(ref _0003 _0002)
	{
		if (_0002._0002)
		{
			Monitor.Exit(global::_0002_2008.m__0006_2002);
		}
	}

	private static void _000E_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(checked(obj._0002() switch
		{
			16 => (byte)(uint)((_0006_2004)obj)._0002(), 
			26 => (byte)(ulong)((_000F_2004)obj)._0002(), 
			15 => (byte)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (byte)((_0003_2003)obj)._0002(), 
			24 => (IntPtr.Size != 4) ? ((byte)(ulong)(long)((_000E_2006)obj)._0002()) : ((byte)(uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _0003_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		double num = obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002(), 
			26 => ((_000F_2004)obj)._0002(), 
			15 => Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => ((_0003_2003)obj)._0002(), 
			_ => throw new InvalidOperationException(), 
		};
		_0003_2003 obj2 = new _0003_2003();
		obj2._0002(num);
		_0002._0005(obj2);
	}

	private void _0002(uint _0002)
	{
		this.m__0008_2001 = _0002;
	}

	private void _0002(Stream _0002, long _0003, string _0005)
	{
		int num = this._0003();
		_0002_200B obj = new _0002_200B(_0002, num);
		this.m__0006_2003 = new _0008_2002(obj);
		if (_0005 != null)
		{
			_0003 = this._0002(_0005);
		}
		_0005_2004 obj2 = this.m__0006_2003._0002();
		lock (obj2)
		{
			obj2._0005_2004_200A_2002_0002(_0003, 0);
			this._0002(this.m__0006_2003);
			this.m__0006_2001 = this._0002(this.m__0006_2003);
			this.m__0008_2000 = global::_0002_2008._0002(this.m__0006_2003);
			this.m__0002 = global::_0002_2008._0002(this.m__0006_2003);
		}
		_000F();
	}

	private static void _0005_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		string text = _0002._0002(num);
		_0005_200A obj = new _0005_200A();
		obj._0002(text);
		_0002._0005(obj);
	}

	private static void _0003_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (!_0006(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private bool _0002(MethodBase _0002, object _0003, _000E_2001[] _0005, object[] _0008, bool _0006, ref object _000E)
	{
		Type declaringType = _0002.DeclaringType;
		if ((object)declaringType == null)
		{
			return false;
		}
		if ((object)declaringType == global::_0002_2008.m__0002_2002 && _0002.Name == global::_000F_2004_2000._0002(-1506766475) && _0008.Length == 2 && _0002.ToString() == global::_000F_2004_2000._0002(-1506766525))
		{
			global::_000E_2004._0002((Array)_0008[0], (RuntimeFieldHandle)_0008[1]);
			return true;
		}
		return false;
	}

	private static void _000F_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(_0002: true);
	}

	private static void _0005_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(2);
	}

	private static void _0005_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0006_2004 obj = (_0006_2004)_0003;
		MethodBase methodBase = _0002._0002(obj._0002());
		_0002._0002(methodBase, _0003: false);
	}

	private static void _0005_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_000E_2001 obj = _0002._0002();
		if (_0002._0002(obj, type))
		{
			_0002._0005(obj);
		}
		else
		{
			_0002._0005(new _000F_2007());
		}
	}

	private void _0002_2000()
	{
		this.m__0008_2004 = null;
		this.m__000F = null;
		this.m__0003_2001.Clear();
	}

	private void _000E()
	{
		if (!this.m__0008_2003._0002())
		{
			lock (this.m__0008_2003)
			{
				if (!this.m__0008_2003._0002())
				{
					global::_0002_2008.m__000F_2001 = _0002(this.m__0008_2003);
					_0006();
					this.m__0008_2003._0002(_0002: true);
				}
			}
		}
		if (global::_0002_2008.m__000F_2001 == null)
		{
			global::_0002_2008.m__000F_2001 = _0002(this.m__0008_2003);
		}
	}

	private static void _0002(ILGenerator _0002, int _0003)
	{
		switch (_0003)
		{
		case -1:
			_0002.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			_0002.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			_0002.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			_0002.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			_0002.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			_0002.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			_0002.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			_0002.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			_0002.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			_0002.Emit(OpCodes.Ldc_I4_8);
			return;
		}
		if (_0003 > -129 && _0003 < 128)
		{
			_0002.Emit(OpCodes.Ldc_I4_S, (sbyte)_0003);
		}
		else
		{
			_0002.Emit(OpCodes.Ldc_I4, _0003);
		}
	}

	private static void _000E_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(byte));
	}

	private static bool _0002(MethodBase _0002)
	{
		ParameterInfo[] parameters = _0002.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	private static void _0008_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		global::_0005_2000 obj = _0002._0002(num);
		object obj2 = ((obj._0002() == 1) ? _0002._0002(obj._0002()) : (obj._0002()._0002_200A_2002_0002() switch
		{
			1 => _0002._0002(num, _0003: true).TypeHandle, 
			0 => _0002._0002(num).MethodHandle, 
			4 => _0002._0002(num).FieldHandle, 
			_ => throw new InvalidOperationException(), 
		}));
		_000F_2007 obj3 = new _000F_2007();
		obj3._0002(obj2);
		_0002._0005(obj3);
	}

	private _000E_2001 _0003(_000E_2001 _0002)
	{
		if (_0002._0002() == 16)
		{
			int num = ((_0006_2004)_0002)._0002();
			_0006_2004 obj = new _0006_2004();
			obj._0002(~num);
			return obj;
		}
		if (_0002._0002() == 26)
		{
			long num2 = ((_000F_2004)_0002)._0002();
			_000F_2004 obj2 = new _000F_2004();
			obj2._0002(~num2);
			return obj2;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
			{
				return new _000F_2004(~Convert.ToInt64(_0002._000E_2001_200A_2002_0002()));
			}
			return new _0006_2004(~Convert.ToInt32(_0002._000E_2001_200A_2002_0002()));
		}
		throw new InvalidOperationException();
	}

	private static void _0002_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0003);
	}

	private static void _000E_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(_0002: true, _0003: true);
	}

	private static bool _0002()
	{
		return false;
	}

	private static void _0003_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (global::_0002_2008._0005(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private static void _000F_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(_0002: false);
	}

	private static _0008_200A[] _0002(_0008_2002 _0002)
	{
		int num = _0002._0002();
		_0008_200A[] array = new _0008_200A[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = global::_0002_2008._0002(_0002);
		}
		return array;
	}

	private static void _0002_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002(), 
			26 => (int)checked((uint)(ulong)((_000F_2004)obj)._0002()), 
			15 => (int)checked((uint)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (int)checked((uint)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((int)checked((uint)(ulong)(long)((_000E_2006)obj)._0002())) : ((int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void _0005_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		_0002.m__0005_2003 = _0002._0002(num, _0003: true);
	}

	private void _0002(_0006_2000 _0002)
	{
		this.m__0003_2000 = _0002._0003;
		this.m__0002_2001 = _0002._0008;
	}

	private static void _0002(object _0002)
	{
		throw _0002;
	}

	private static void _0003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(_0002._0008(obj2, obj));
	}

	private static void _0005(ILGenerator _0002, Type _0003)
	{
		if (_0003.IsValueType || global::_000F_200A._0002(_0003).IsGenericParameter)
		{
			_0002.Emit(OpCodes.Box, _0003);
		}
	}

	private static void _0002_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_0002._0005(global::_000E_2001._0002(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	private void _0005(Type _0002)
	{
		_0005_2008 obj = (_0005_2008)this._0002();
		_0005(global::_000E_2001._0002(this._0002(obj)._000E_2001_200A_2002_0002(), _0002));
	}

	private static void _0005_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(((_0008_2005)_0003)._0002());
	}

	private static void _0005_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(checked(obj._0002() switch
		{
			16 => (short)(uint)((_0006_2004)obj)._0002(), 
			26 => (short)(ulong)((_000F_2004)obj)._0002(), 
			15 => (short)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (short)((_0003_2003)obj)._0002(), 
			24 => (IntPtr.Size != 4) ? ((short)(ulong)(long)((_000E_2006)obj)._0002()) : ((short)(uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _000F_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0006_2004 obj = (_0006_2004)_0003;
		MethodBase methodBase = _0002._0002(obj._0002());
		_000E_2001[] array = _0002.m__0005;
		foreach (_000E_2001 obj2 in array)
		{
			_0002._0005(obj2);
		}
		_0002._0002(methodBase, _0003: false);
	}

	private static void _0002_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0005_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002_2000(_0002: true);
	}

	private static void _000F_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private _0003_2001 _0002(_0008_2002 _0002)
	{
		_0003_2001 obj = new _0003_2001();
		obj._0002(_0002._0002());
		obj._0002(this._0002(_0002));
		obj._0002(_0002._0006());
		obj._0003(_0002._0006());
		obj._0002(_0002._0002());
		obj._0002(this._0002(_0002));
		return obj;
	}

	private static void _0002_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(3);
	}

	private static void _000F_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		object obj = _0002._0002()._000E_2001_200A_2002_0002();
		long num = _0002._0002();
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(short))
		{
			_000E_2001 obj2 = global::_000E_2001._0002(obj, typeof(short));
			((short[])array)[num] = (short)obj2._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(ushort))
		{
			_000E_2001 obj3 = global::_000E_2001._0002(obj, typeof(ushort));
			((ushort[])array)[num] = (ushort)obj3._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(char))
		{
			_000E_2001 obj4 = global::_000E_2001._0002(obj, typeof(char));
			((char[])array)[num] = (char)obj4._000E_2001_200A_2002_0002();
		}
		else if (elementType.IsEnum)
		{
			_0002._0002(elementType, obj, num, array);
		}
		else
		{
			_0002._0002(typeof(short), obj, num, array);
		}
	}

	private static void _0006_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E(_0002: false);
	}

	private static void _0002_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		checked
		{
			_0002._0005(new _000F_2004(obj._0002() switch
			{
				16 => unchecked((uint)((_0006_2004)obj)._0002()), 
				26 => (long)(ulong)((_000F_2004)obj)._0002(), 
				15 => (long)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
				14 => (long)((_0003_2003)obj)._0002(), 
				24 => (IntPtr.Size != 4) ? ((long)(ulong)(long)((_000E_2006)obj)._0002()) : unchecked((uint)(int)((_000E_2006)obj)._0002()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private static void _0006_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0002: true, _0003: false);
	}

	private static void _0005_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0002: true, _0003: false);
	}

	private _000E_2001 _0002(_000E_2001 _0002, _000E_2001 _0003)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				int num = ((_0006_2004)_0002)._0002();
				int num2 = ((_0006_2004)_0003)._0002();
				_0006_2004 obj = new _0006_2004();
				obj._0002(num & num2);
				return obj;
			}
			if (_0003._0002() == 15)
			{
				int num3 = ((_0006_2004)_0002)._0002();
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num3 & num4);
				}
				int num5 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				_0006_2004 obj2 = new _0006_2004();
				obj2._0002(num3 & num5);
				return obj2;
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				long num6 = ((_000F_2004)_0002)._0002();
				long num7 = ((_000F_2004)_0003)._0002();
				_000F_2004 obj3 = new _000F_2004();
				obj3._0002(num6 & num7);
				return obj3;
			}
			if (_0003._0002() == 15)
			{
				int num8 = ((_0006_2004)_0002)._0002();
				long num9 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
				return new _000F_2004(num8 & num9);
			}
		}
		if (_0002._0002() == 15)
		{
			if (_0003._0002() == 16)
			{
				int num10 = ((_0006_2004)_0003)._0002();
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002()) & num10);
				}
				int num11 = Convert.ToInt32(_0002._000E_2001_200A_2002_0002());
				_0006_2004 obj4 = new _0006_2004();
				obj4._0002(num11 & num10);
				return obj4;
			}
			if (_0003._0002() == 26)
			{
				long num12 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
				long num13 = ((_000F_2004)_0003)._0002();
				_000F_2004 obj5 = new _000F_2004();
				obj5._0002(num12 & num13);
				return obj5;
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong) || (object)underlyingType4 == typeof(long) || (object)underlyingType4 == typeof(ulong))
				{
					long num14 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
					long num15 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num14 & num15);
				}
				int num16 = Convert.ToInt32(_0002._000E_2001_200A_2002_0002());
				int num17 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				return new _0006_2004(num16 & num17);
			}
		}
		throw new InvalidOperationException();
	}

	private global::_0002 _0002(_0008_2002 _0002)
	{
		switch (_0002._0002())
		{
		case 1:
		{
			global::_0008 obj7 = new global::_0008();
			obj7._0002(_0002._0002());
			obj7._0003(_0002._0002());
			obj7._0002(_0002._0002());
			obj7._0003(_0002._0006());
			obj7._0002(_0002._0006());
			int num5 = _0002._0008();
			global::_0005_2000[] array3 = new global::_0005_2000[num5];
			for (int k = 0; k < num5; k++)
			{
				int num6 = k;
				global::_0005_2000 obj8 = new global::_0005_2000();
				obj8._0002((byte)0);
				obj8._0002(_0002._0006());
				array3[num6] = obj8;
			}
			obj7._0002(array3);
			return obj7;
		}
		case 4:
		{
			_0005_2000_2000 obj10 = new _0005_2000_2000();
			global::_0005_2000 obj11 = new global::_0005_2000();
			obj11._0002((byte)0);
			obj11._0002(_0002._0006());
			obj10._0002(obj11);
			obj10._0002(_0002._0002());
			obj10._0002(_0002._0002());
			return obj10;
		}
		case 2:
		{
			_0008_2000_2000 obj9 = new _0008_2000_2000();
			obj9._0002(_0002._0006());
			obj9._0003(_0002._0006());
			return obj9;
		}
		case 0:
		{
			_0006_2000_2000 obj2 = new _0006_2000_2000();
			global::_0005_2000 obj3 = new global::_0005_2000();
			obj3._0002((byte)0);
			obj3._0002(_0002._0006());
			obj2._0002(obj3);
			obj2._0002(_0002._0002());
			obj2._0002(_0002._0002());
			global::_0005_2000 obj4 = new global::_0005_2000();
			obj4._0002((byte)0);
			obj4._0002(_0002._0006());
			obj2._0003(obj4);
			int num = _0002._0008();
			global::_0005_2000[] array = new global::_0005_2000[num];
			for (int i = 0; i < num; i++)
			{
				int num2 = i;
				global::_0005_2000 obj5 = new global::_0005_2000();
				obj5._0002((byte)0);
				obj5._0002(_0002._0006());
				array[num2] = obj5;
			}
			obj2._0002(array);
			int num3 = _0002._0008();
			global::_0005_2000[] array2 = new global::_0005_2000[num3];
			for (int j = 0; j < num3; j++)
			{
				int num4 = j;
				global::_0005_2000 obj6 = new global::_0005_2000();
				obj6._0002((byte)0);
				obj6._0002(_0002._0006());
				array2[num4] = obj6;
			}
			obj2._0003(array2);
			return obj2;
		}
		case 3:
		{
			global::_0003 obj = new global::_0003();
			obj._0002(_0002._0002());
			return obj;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private static void _0008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2003 obj = (_000E_2003)_0003;
		_0002._0005(obj._0002());
	}

	private _0008_2001 _0002(_0008_2002 _0002)
	{
		_0008_2001 obj = new _0008_2001();
		obj._0002(_0002._0006());
		obj._0002(_0002._0002());
		return obj;
	}

	private static void _000F_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000F(_0002: false);
	}

	private static _0006 _0002(MethodBase _0002, bool _0003)
	{
		DynamicMethod dynamicMethod = null;
		if ((object)dynamicMethod == null)
		{
			dynamicMethod = new DynamicMethod(string.Empty, global::_000F_200A._0002, new Type[2]
			{
				global::_000F_200A._0002,
				global::_0002_2008.m__0002_2000
			}, typeof(_0002_2008).Module, skipVisibility: true);
		}
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = _0002.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = iLGenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg_1);
			global::_0002_2008._0002(iLGenerator, k);
			iLGenerator.Emit(OpCodes.Ldelem_Ref);
			global::_0002_2008._0002(iLGenerator, array[k]);
			iLGenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			iLGenerator.BeginExceptionBlock();
		}
		if (!_0002.IsStatic && !_0002.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = _0002.DeclaringType;
			if (declaringType.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Unbox, declaringType);
				_0003 = false;
			}
			else
			{
				global::_0002_2008._0003(iLGenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (_0002.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Newobj, (ConstructorInfo)_0002);
			_0005(iLGenerator, _0002.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)_0002;
			if (!_0003 || _0002.IsStatic)
			{
				iLGenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			else
			{
				iLGenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			if ((object)methodInfo.ReturnType == global::_0002_2008.m__0002_2004)
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				_0005(iLGenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = iLGenerator.DeclareLocal(global::_000F_200A._0002);
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					global::_0002_2008._0002(iLGenerator, m);
					iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || global::_000F_200A._0002(array2[m].LocalType).IsGenericParameter)
					{
						iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			iLGenerator.EndExceptionBlock();
			iLGenerator.Emit(OpCodes.Ldloc, local);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return (_0006)dynamicMethod.CreateDelegate(typeof(_0006));
	}

	private void _0002(Type _0002)
	{
		object obj = this._0002()._000E_2001_200A_2002_0002();
		long num = this._0002();
		Array array = (Array)this._0002()._000E_2001_200A_2002_0002();
		this._0002(_0002, obj, num, array);
	}

	private void _0003(Type _0002)
	{
		long index = this._0002();
		Array array = (Array)this._0002()._000E_2001_200A_2002_0002();
		_0005(global::_000E_2001._0002(array.GetValue(index), _0002));
	}

	private static void _0002_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(((_000E_2003)_0003)._0002());
	}

	private _000E_2001 _0005(_000E_2001 _0002, _000E_2001 _0003)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				int num = ((_0006_2004)_0002)._0002();
				int num2 = ((_0006_2004)_0003)._0002();
				return new _0006_2004(num ^ num2);
			}
			if (_0003._0002() == 15)
			{
				int num3 = ((_0006_2004)_0002)._0002();
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num3 ^ num4);
				}
				int num5 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				return new _0006_2004(num3 ^ num5);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				long num6 = ((_000F_2004)_0002)._0002();
				long num7 = ((_000F_2004)_0003)._0002();
				return new _000F_2004(num6 ^ num7);
			}
			if (_0003._0002() == 15)
			{
				int num8 = ((_0006_2004)_0002)._0002();
				long num9 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
				return new _000F_2004(num8 ^ num9);
			}
		}
		if (_0002._0002() == 15)
		{
			if (_0003._0002() == 16)
			{
				int num10 = ((_0006_2004)_0003)._0002();
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002()) ^ num10);
				}
				return new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002()) ^ num10);
			}
			if (_0003._0002() == 26)
			{
				long num11 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
				long num12 = ((_000F_2004)_0003)._0002();
				return new _000F_2004(num11 ^ num12);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong) || (object)underlyingType4 == typeof(long) || (object)underlyingType4 == typeof(ulong))
				{
					long num13 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
					long num14 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num13 ^ num14);
				}
				int num15 = Convert.ToInt32(_0002._000E_2001_200A_2002_0002());
				int num16 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				return new _0006_2004(num15 ^ num16);
			}
		}
		throw new InvalidOperationException();
	}

	private static void _0002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		if (_0002.m__0003_2003 == null)
		{
			throw new InvalidOperationException();
		}
		_0002._0003(_0002.m__0003_2003);
	}

	private static void _0003_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		bool flag = false;
		if (obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002() == 0, 
			26 => ((_000F_2004)obj)._0002() == 0, 
			24 => ((_000E_2006)obj)._0002() == IntPtr.Zero, 
			7 => ((_0005_2007)obj)._0002() == UIntPtr.Zero, 
			8 => ((_000F_2007)obj)._0002() == null, 
			15 => !Convert.ToBoolean(((_000F_2002)obj)._0002()), 
			_ => obj._000E_2001_200A_2002_0002() == null, 
		})
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private static void _0008_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0008_2005 obj = (_0008_2005)_0003;
		_0006_2008 obj2 = new _0006_2008();
		obj2._0002(_0002.m__0005[obj._0002()]);
		_0002._0005(obj2);
	}

	private static void _000E_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002();
	}

	private void _0003(object _0002)
	{
		Exception ex = _0002 as Exception;
		if (ex != null)
		{
			global::_0002_2008._0002(ex);
		}
		global::_0002_2008._0002(_0002);
	}

	private static void _0006_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		object obj = _0002._0002()._000E_2001_200A_2002_0002();
		long num = _0002._0002();
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(long))
		{
			_000E_2001 obj2 = global::_000E_2001._0002(obj, typeof(long));
			((long[])array)[num] = (long)obj2._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(ulong))
		{
			_000E_2001 obj3 = global::_000E_2001._0002(obj, typeof(ulong));
			((ulong[])array)[num] = (ulong)obj3._000E_2001_200A_2002_0002();
		}
		else if (elementType.IsEnum)
		{
			_0002._0002(elementType, obj, num, array);
		}
		else
		{
			_0002._0002(typeof(long), obj, num, array);
		}
	}

	private static void _0005_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		bool flag = false;
		if (obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002() != 0, 
			26 => ((_000F_2004)obj)._0002() != 0, 
			24 => ((_000E_2006)obj)._0002() != IntPtr.Zero, 
			7 => ((_0005_2007)obj)._0002() != UIntPtr.Zero, 
			15 => Convert.ToBoolean(((_000F_2002)obj)._0002()), 
			8 => ((_000F_2007)obj)._0002() != null, 
			_ => obj._000E_2001_200A_2002_0002() != null, 
		})
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	public static void _0002<T>(T[] _0002, Comparison<T> _0003)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[_0002.Length];
		for (int i = 0; i < _0002.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, _0002[i]);
		}
		Array.Sort(array, _0002, new _000E_2000<T>(_0003));
	}

	private static void _0008_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0006_2004 obj3 = new _0006_2004();
		obj3._0002(_0006(obj2, obj) ? 1 : 0);
		_0002._0005(obj3);
	}

	private MethodBase _0002(_0006_2000_2000 _0002)
	{
		Type type = this._0002(_0002._0002()._0002(), _0003: false);
		BindingFlags bindingAttr = global::_0002_2008._0002(_0002._0002());
		Type[] array = null;
		global::_0005_2000[] array2 = _0002._0003();
		if (array2 != null)
		{
			array = new Type[array2.Length];
			for (int i = 0; i < array.Length; i++)
			{
				global::_0005_2000 obj = array2[i];
				if (obj != null)
				{
					array[i] = this._0002(obj._0002(), _0003: true);
				}
			}
		}
		MemberInfo[] member = type.GetMember(_0002._0002(), MemberTypes.Method, bindingAttr);
		MethodInfo methodInfo = null;
		int num = -1;
		MemberInfo[] array3 = member;
		for (int j = 0; j < array3.Length; j++)
		{
			MethodInfo methodInfo2 = (MethodInfo)array3[j];
			if (this._0002(methodInfo2, _0002, array, out var num2) && num2 > num)
			{
				methodInfo = methodInfo2;
				num = num2;
			}
		}
		if ((object)methodInfo == null)
		{
			throw new Exception(string.Format(global::_000F_2004_2000._0002(-1506766405), type.Name, _0002._0002()));
		}
		return methodInfo.MakeGenericMethod(array);
	}

	private static void _0008_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(global::_0002_2008.m__000E);
	}

	private static void _000E_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static void _0008_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(sbyte));
	}

	private void _0008(int _0002)
	{
		_0005(this.m__000E_2002[_0002]._000E_2001_200A_2002_0002());
	}

	private void _0005_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_0005(new _0006_2004(obj._0002() switch
		{
			16 => (int)((!_0002) ? ((ushort)((_0006_2004)obj)._0002()) : checked((uint)((_0006_2004)obj)._0002())), 
			26 => (int)((!_0002) ? ((_000F_2004)obj)._0002() : checked((uint)((_000F_2004)obj)._0002())), 
			15 => (int)((!_0002) ? Convert.ToUInt64(((_000F_2002)obj)._0002()) : checked((uint)Convert.ToUInt64(((_000F_2002)obj)._0002()))), 
			14 => (int)((!_0002) ? ((uint)((_0003_2003)obj)._0002()) : checked((uint)((_0003_2003)obj)._0002())), 
			24 => (int)((IntPtr.Size != 4) ? ((!_0002) ? ((long)((_000E_2006)obj)._0002()) : checked((uint)(ulong)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((int)((_000E_2006)obj)._0002()) : ((int)checked((uint)(int)((_000E_2006)obj)._0002())))), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void _000E_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(checked(obj._0002() switch
		{
			16 => (ushort)(uint)((_0006_2004)obj)._0002(), 
			26 => (ushort)(ulong)((_000F_2004)obj)._0002(), 
			15 => (ushort)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (ushort)((_0003_2003)obj)._0002(), 
			24 => (IntPtr.Size != 4) ? ((ushort)(ulong)(long)((_000E_2006)obj)._0002()) : ((ushort)(uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _0005_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		bool num2 = (num & int.MinValue) != 0;
		bool flag = (num & 0x40000000) != 0;
		num &= 0x3FFFFFFF;
		if (num2)
		{
			_0002._0002(num, null, null, flag);
			return;
		}
		_0008_2000_2000 obj = (_0008_2000_2000)_0002._0002(num)._0002();
		_0002._0002(obj);
	}

	private static void _0006_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(float));
	}

	private void _0003_2000()
	{
		this.m__000E_2003 = true;
	}

	private _000E_2001[] _0002()
	{
		_000E_2000[] array = this.m__0006_2001._0002();
		int num = array.Length;
		_000E_2001[] array2 = new _000E_2001[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = global::_000E_2001._0002(null, _0002(array[i]._0002(), _0003: false));
		}
		return array2;
	}

	private static void _000F_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_0005_2008 obj = (_0005_2008)_0002._0002();
		if (type.IsValueType)
		{
			object obj2 = _0002._0002(obj)._000E_2001_200A_2002_0002();
			if (global::_000F_200A._0002(type))
			{
				_000F_2007 obj3 = new _000F_2007();
				((_000E_2001)obj3)._0002(type);
				_0002._0002(obj, obj3);
				return;
			}
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				fieldInfo.SetValue(obj2, global::_0002_2008._0002(fieldInfo.FieldType));
			}
		}
		else
		{
			_0002._0002(obj, new _000F_2007());
		}
	}

	private FieldInfo _0002(int _0002)
	{
		lock (global::_0002_2008.m__000F_2003)
		{
			bool flag = true;
			FieldInfo fieldInfo;
			if (flag && global::_0002_2008.m__000F_2003.TryGetValue(_0002, out var value))
			{
				fieldInfo = (FieldInfo)value;
			}
			else
			{
				global::_0005_2000 obj = this._0002(_0002);
				fieldInfo = this._0002(_0002, obj, ref flag);
				if (flag)
				{
					global::_0002_2008.m__000F_2003.Add(_0002, fieldInfo);
				}
			}
			this._0002(fieldInfo);
			return fieldInfo;
		}
	}

	private static void _0005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		_0002._0005(new _0006_2004(array.Length));
	}

	private Type _0002(int _0002, bool _0003)
	{
		Type type;
		lock (global::_0002_2008.m__000F_2003)
		{
			bool flag = true;
			if (flag && global::_0002_2008.m__000F_2003.TryGetValue(_0002, out var value))
			{
				type = (Type)value;
			}
			else
			{
				global::_0005_2000 obj = this._0002(_0002);
				type = this._0002(_0002, obj, ref flag, _0003);
				if (flag)
				{
					global::_0002_2008.m__000F_2003.Add(_0002, type);
				}
			}
		}
		if (_0003)
		{
			this._0002((MemberInfo)type);
		}
		return type;
	}

	private static void _000F_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(0);
	}

	private static void _0003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(global::_000F_200A._0002);
	}

	private void _000F(bool _0002)
	{
		_000E_2001 obj = this._0002();
		sbyte b = obj._0002() switch
		{
			16 => (!_0002) ? ((sbyte)((_0006_2004)obj)._0002()) : checked((sbyte)((_0006_2004)obj)._0002()), 
			26 => (!_0002) ? ((sbyte)((_000F_2004)obj)._0002()) : checked((sbyte)((_000F_2004)obj)._0002()), 
			15 => (!_0002) ? ((sbyte)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((sbyte)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((sbyte)((_0003_2003)obj)._0002()) : checked((sbyte)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((!_0002) ? ((sbyte)(long)((_000E_2006)obj)._0002()) : checked((sbyte)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((sbyte)(int)((_000E_2006)obj)._0002()) : checked((sbyte)(int)((_000E_2006)obj)._0002())), 
			_ => throw new InvalidOperationException(), 
		};
		_0006_2004 obj2 = new _0006_2004();
		obj2._0002(b);
		_0005(obj2);
	}

	private static void _0002_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766656));
	}

	private static void _000F_2005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (global::_0002_2008._0008(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private global::_0005_2000 _0002(int _0002)
	{
		if (this.m__0006_2003 == null)
		{
			throw new InvalidOperationException();
		}
		lock (this.m__0006_2003._0002())
		{
			this.m__0006_2003._0002()._0005_2004_200A_2002_0002(_0002, 0);
			global::_0005_2000 obj = new global::_0005_2000();
			obj._0002(this.m__0006_2003._0002());
			if (obj._0002() == 1)
			{
				obj._0002(this.m__0006_2003._0006());
			}
			else
			{
				obj._0002(this._0002(this.m__0006_2003));
			}
			return obj;
		}
	}

	private static void _0002_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(float));
	}

	private static void _0006_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E(((_0008_2005)_0003)._0002());
	}

	private static Exception _0003(string _0002, string _0003)
	{
		return new TypeLoadException(global::_0002_2008._0002(global::_000F_2004_2000._0002(-1506765705) + _0002 + global::_000F_2004_2000._0002(-1506765741), global::_000F_2004_2000._0002(-1506765765) + _0003 + global::_000F_2004_2000._0002(-1506765741)));
	}

	private void _0002(MethodBase _0002, bool _0003)
	{
		bool flag = !_0003 && this._0002(_0002);
		if (flag && global::_0002_2008._0005._0002)
		{
			_0002 = global::_0002_2008._0005_2000._0002(this, this.m__0006_2001, _0002, _0003);
		}
		ParameterInfo[] parameters = _0002.GetParameters();
		int num = parameters.Length;
		_000E_2001[] array = new _000E_2001[num];
		object[] array2 = new object[num];
		_0003 obj = default(_0003);
		try
		{
			this._0002(ref obj, _0002, _0003);
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				_000E_2001 obj2 = (array[num2] = this._0002());
				_0005_2008 obj3 = obj2 as _0005_2008;
				if (obj3 != null)
				{
					obj2 = this._0002(obj3);
				}
				if ((object)obj2._0002() != null)
				{
					obj2 = global::_000E_2001._0002(null, obj2._0002())._000E_2001_200A_2002_0002(obj2);
				}
				_000E_2001 obj4 = global::_000E_2001._0002(null, parameters[num2].ParameterType)._000E_2001_200A_2002_0002(obj2);
				array2[num2] = obj4._000E_2001_200A_2002_0002();
			}
			_000E_2001 obj5 = null;
			if (!_0002.IsStatic)
			{
				obj5 = this._0002();
				if (obj5 != null && (object)obj5._0002() != null)
				{
					obj5 = global::_000E_2001._0002(null, obj5._0002())._000E_2001_200A_2002_0002(obj5);
				}
			}
			object obj6 = null;
			object obj7 = null;
			try
			{
				if (_0002.IsConstructor)
				{
					obj6 = Activator.CreateInstance(_0002.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					if (!(obj5 is _0005_2008))
					{
						throw new InvalidOperationException();
					}
					obj7 = obj6;
				}
				else
				{
					if (obj5 != null)
					{
						_000E_2001 obj8 = obj5;
						_0005_2008 obj9 = obj5 as _0005_2008;
						if (obj9 != null)
						{
							obj8 = this._0002(obj9);
						}
						obj7 = obj8._000E_2001_200A_2002_0002();
					}
					try
					{
						if (!this._0003(_0002, obj7, ref obj6, array2))
						{
							if (_0003 && !_0002.IsStatic && obj7 == null)
							{
								throw new NullReferenceException();
							}
							if (!this._0002(_0002, obj7, array, array2, _0003, ref obj6))
							{
								MethodBase methodBase = _0002;
								object obj10 = obj7;
								if (flag && !global::_0002_2008._0005._0002)
								{
									obj10 = global::_0002_2008._0003_2000._0002(obj7, _0002, out var methodInfo);
									methodBase = methodInfo;
								}
								obj6 = global::_0002_2008._0002(methodBase, obj10, array2, _0003);
							}
						}
					}
					catch (TargetInvocationException ex)
					{
						Exception ex2 = ex.InnerException ?? ex;
						this._0003(ex2);
					}
				}
			}
			finally
			{
				for (int i = 0; i < array.Length; i++)
				{
					_0005_2008 obj11 = array[i] as _0005_2008;
					if (obj11 != null)
					{
						object obj12 = array2[i];
						this._0002(obj11, global::_000E_2001._0002(obj12, null));
					}
				}
				if (obj7 != null)
				{
					_0005_2008 obj13 = obj5 as _0005_2008;
					if (obj13 != null)
					{
						bool flag2 = true;
						_0008_2009 obj14 = obj13 as _0008_2009;
						if (obj14 != null)
						{
							flag2 = this._0002(obj14);
						}
						if (flag2)
						{
							this._0002(obj13, global::_000E_2001._0002(obj7, _0002.DeclaringType));
						}
					}
				}
			}
			MethodInfo methodInfo2 = _0002 as MethodInfo;
			if ((object)methodInfo2 != null)
			{
				Type returnType = methodInfo2.ReturnType;
				if ((object)returnType != global::_0002_2008.m__0002_2004)
				{
					_0005(global::_000E_2001._0002(obj6, returnType));
				}
			}
		}
		finally
		{
			this._0002(ref obj);
		}
	}

	private static void _0006_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(0);
	}

	private static void _0008_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
	}

	private void _0005(bool _0002, bool _0003)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(_0005(obj2, obj, _0002, _0003));
	}

	private void _0002(object _0002, uint _0003)
	{
		bool flag = _0002 != null;
		this.m__0003_2003 = _0002;
		if (flag)
		{
			this.m__0005_2000.Clear();
		}
		this.m__0008 = flag;
		if (!flag)
		{
			this.m__0005_2000.Push(new _0008(_0003));
		}
		_0008_200A[] array = this.m__0008_2000;
		foreach (_0008_200A obj in array)
		{
			if (!global::_0002_2008._0002(this.m__0008_2002, obj._0002(), obj._0005()))
			{
				continue;
			}
			switch (obj._0002())
			{
			case 4:
				if (flag || !global::_0002_2008._0002(_0003, obj._0002(), obj._0005()))
				{
					this.m__0005_2000.Push(new _0008(obj._0003()));
				}
				break;
			case 1:
				if (flag)
				{
					this.m__0005_2000.Push(new _0008(obj._0003()));
				}
				break;
			case 2:
				if (flag)
				{
					this.m__0005_2000.Push(new _0008(obj._0008(), _0002));
				}
				break;
			case 0:
				if (flag)
				{
					Type type = _0002.GetType();
					Type type2 = this._0002(obj._0003(), _0003: true);
					if ((object)type == type2 || type.IsSubclassOf(type2))
					{
						this.m__0005_2000.Push(new _0008(obj._0003(), _0002));
						this.m__0008 = false;
					}
				}
				break;
			}
		}
		_0005();
	}

	private static void _000E_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(new _0006_2004(global::_0002_2008._0002(obj2, obj) ? 1 : 0));
	}

	private void _0006(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_0005(new _000F_2004(obj._0002() switch
		{
			16 => (!_0002) ? ((uint)((_0006_2004)obj)._0002()) : checked((uint)((_0006_2004)obj)._0002()), 
			26 => (!_0002) ? ((_000F_2004)obj)._0002() : ((long)checked((ulong)((_000F_2004)obj)._0002())), 
			15 => (long)((!_0002) ? Convert.ToUInt64(((_000F_2002)obj)._0002()) : Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (long)((!_0002) ? ((ulong)((_0003_2003)obj)._0002()) : checked((ulong)((_0003_2003)obj)._0002())), 
			24 => (IntPtr.Size != 4) ? ((!_0002) ? ((long)((_000E_2006)obj)._0002()) : ((long)checked((ulong)(long)((_000E_2006)obj)._0002()))) : ((!_0002) ? ((uint)(int)((_000E_2006)obj)._0002()) : checked((uint)(int)((_000E_2006)obj)._0002())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private long _0002(string _0002)
	{
		MemoryStream memoryStream = new MemoryStream(global::_0003_2002._0002(_0002));
		long result = new _0008_2002(new _0002_200B(memoryStream, this._0002()))._0002();
		memoryStream.Dispose();
		return result;
	}

	private static void _0006_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(1);
	}

	private static void _0003_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(5);
	}

	private static _000E_2001 _0008(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0008)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					int num3 = ((!_0005) ? (num - num2) : checked(num - num2));
					return new _0006_2004(num3);
				}
				uint num4 = (uint)((_0006_2004)_0002)._0002();
				uint num5 = (uint)((_0006_2004)_0003)._0002();
				uint num6 = ((!_0005) ? (num4 - num5) : checked(num4 - num5));
				return new _0006_2004((int)num6);
			}
			if (_0003._0002() == 26)
			{
				return _000E(new _000F_2004(((_0006_2004)_0002)._0002()), _0003, _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					return _000E(new _000F_2004(((_0006_2004)_0002)._0002()), new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return global::_0002_2008._0008(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				return _000E(_0002, _0003, _0005, _0008);
			}
			if (_0003._0002() == 16)
			{
				return _000E(_0002, new _000F_2004(((_0006_2004)_0003)._0002()), _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return _000E(_0002, new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return _000E(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 14 && _0003._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(((_0003_2003)_0002)._0002() - ((_0003_2003)_0003)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong))
			{
				return global::_0002_2008._0008(new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
			}
			return global::_0002_2008._0008(new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
		}
		throw new InvalidOperationException();
	}

	private static void _000E_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(double));
	}

	private static void _000E_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		MethodBase methodBase = ((_0005_2006)_0002._0002())._0002();
		_0002._0002(methodBase, _0003: false);
	}

	private static void _000F_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(_0002._0005(obj2, obj));
	}

	private _0008_2001[] _0002(_0008_2002 _0002)
	{
		_0008_2001[] array = new _0008_2001[_0002._0002()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this._0002(_0002);
		}
		return array;
	}

	private static void _000F_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0003);
	}

	private static void _0005(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0003();
		_0002._0005(obj._000E_2001_200A_2002_0002());
	}

	private void _0002(_0003_2001 _0002)
	{
		if (global::_0002_2008._0002() && !this.m__0006_2001._0003() && _0002._0003() && !_0002._0005())
		{
			string text = this._0002(_0002);
			throw _0005(this._0002(this.m__0006_2001), text);
		}
	}

	private _000E_2001 _0002()
	{
		_000E_2001 obj = this.m__0008_2004;
		if (obj != null)
		{
			this.m__0008_2004 = this.m__000F;
			this.m__000F = null;
			return obj;
		}
		return this.m__0003_2001.Pop();
	}

	private static _000E_2001 _0005(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0008)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					int num3 = ((!_0005) ? (num * num2) : checked(num * num2));
					return new _0006_2004(num3);
				}
				uint num4 = (uint)((_0006_2004)_0002)._0002();
				uint num5 = (uint)((_0006_2004)_0003)._0002();
				uint num6 = ((!_0005) ? (num4 * num5) : checked(num4 * num5));
				return new _0006_2004((int)num6);
			}
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0003(new _000F_2004(((_0006_2004)_0002)._0002()), _0003, _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					return global::_0002_2008._0003(new _000F_2004(((_0006_2004)_0002)._0002()), new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return global::_0002_2008._0005(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0003(_0002, _0003, _0005, _0008);
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0003(_0002, new _000F_2004(((_0006_2004)_0003)._0002()), _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return global::_0002_2008._0003(_0002, new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return global::_0002_2008._0003(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 14 && _0003._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(((_0003_2003)_0002)._0002() * ((_0003_2003)_0003)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong))
			{
				return global::_0002_2008._0005(new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
			}
			return global::_0002_2008._0005(new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
		}
		throw new InvalidOperationException();
	}

	private static void _000E_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002((int)((_000E_2003)_0003)._0002());
	}

	private static void _0003_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0006_2004 obj = (_0006_2004)_0003;
		MethodBase methodBase = _0002._0002(obj._0002());
		_0005_2006 obj2 = new _0005_2006();
		obj2._0002(methodBase);
		_0002._0005(obj2);
	}

	private static _000E_2001 _0006(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0008)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					int num3 = ((!_0005) ? (num + num2) : checked(num + num2));
					return new _0006_2004(num3);
				}
				uint num4 = (uint)((_0006_2004)_0002)._0002();
				uint num5 = (uint)((_0006_2004)_0003)._0002();
				uint num6 = ((!_0005) ? (num4 + num5) : checked(num4 + num5));
				return new _0006_2004((int)num6);
			}
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0002(new _000F_2004(((_0006_2004)_0002)._0002()), _0003, _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					return global::_0002_2008._0002(new _000F_2004(((_0006_2004)_0002)._0002()), new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return _0006(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0002(_0002, _0003, _0005, _0008);
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0002(_0002, new _000F_2004(((_0006_2004)_0003)._0002()), _0005, _0008);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return global::_0002_2008._0002(_0002, new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
				}
				return global::_0002_2008._0002(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005, _0008);
			}
		}
		if (_0002._0002() == 14 && _0003._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(((_0003_2003)_0002)._0002() + ((_0003_2003)_0003)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong))
			{
				return _0006(new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
			}
			return _0006(new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005, _0008);
		}
		throw new InvalidOperationException();
	}

	private static void _0008_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_000E_2001 obj = global::_000E_2001._0002(_0002._0002()._000E_2001_200A_2002_0002(), type);
		obj._0002(type);
		_0002._0005(obj);
	}

	private FieldInfo _0002(int _0002, global::_0005_2000 _0003, ref bool _0005)
	{
		if (_0003._0002() == 1)
		{
			_0005 = false;
			return this.m__0002_2003.ResolveField(_0003._0002());
		}
		_0005_2000_2000 obj = (_0005_2000_2000)_0003._0002();
		Type type = this._0002(obj._0002()._0002(), _0003: false);
		if (type.IsGenericType)
		{
			_0005 = false;
		}
		return type.GetField(bindingAttr: global::_0002_2008._0002(obj._0002()), name: obj._0002());
	}

	private static void _0006_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(checked(obj._0002() switch
		{
			16 => (sbyte)(uint)((_0006_2004)obj)._0002(), 
			26 => (sbyte)(ulong)((_000F_2004)obj)._0002(), 
			15 => (sbyte)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (sbyte)((_0003_2003)obj)._0002(), 
			24 => (IntPtr.Size != 4) ? ((sbyte)(ulong)(long)((_000E_2006)obj)._0002()) : ((sbyte)(uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _000F_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(2);
	}

	private void _0006_2000(bool _0002)
	{
		uint num = this.m__0003_2002;
		while (true)
		{
			try
			{
				while (!this.m__000E_2003)
				{
					if (this.m__0008_2001.HasValue)
					{
						this.m__0006_2000 = this.m__0008_2001.Value;
						this._0002((long)this.m__0006_2000);
						this.m__0008_2001 = null;
					}
					else if (this.m__0006_2000 >= num)
					{
						break;
					}
					this._0003();
				}
				return;
			}
			catch (object obj)
			{
				this._0002(obj, 0u);
				if (!_0002)
				{
					_0006_2000(_0002: true);
					return;
				}
			}
		}
	}

	private static void _0006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000F_2000(_0002: true);
	}

	private static void _0006_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private static BindingFlags _0002(bool _0002)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (_0002)
		{
			return bindingFlags | BindingFlags.Static;
		}
		return bindingFlags | BindingFlags.Instance;
	}

	private static void _0003_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		float num = obj._0002() switch
		{
			16 => ((_0006_2004)obj)._0002(), 
			26 => ((_000F_2004)obj)._0002(), 
			15 => Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (float)((_0003_2003)obj)._0002(), 
			_ => throw new InvalidOperationException(), 
		};
		_0003_2003 obj2 = new _0003_2003();
		obj2._0002(num);
		_0002._0005(obj2);
	}

	private static void _000F_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0003_2003 obj = (_0003_2003)_0002._0002();
		if (double.IsNaN(obj._0002()) || double.IsInfinity(obj._0002()))
		{
			throw new OverflowException(global::_000F_2004_2000._0002(-1506766069));
		}
		_0002._0005(obj);
	}

	private static void _000F(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(4);
	}

	private static bool _0006(_000E_2001 _0002, _000E_2001 _0003)
	{
		bool result = false;
		switch (_0002._0002())
		{
		case 16:
			result = ((_0003._0002() != 15) ? ((_0003._0002() != 8 || _0003._000E_2001_200A_2002_0002() != null) ? (((_0006_2004)_0002)._0002() == ((_0006_2004)_0003)._0002()) : (((_0006_2004)_0002)._0002() == 0)) : (((_0006_2004)_0002)._0002() == Convert.ToInt64(((_000F_2002)_0003)._0002())));
			break;
		case 26:
			result = ((_0003._0002() != 15) ? ((_0003._0002() != 8 || _0003._000E_2001_200A_2002_0002() != null) ? (((_000F_2004)_0002)._0002() == ((_000F_2004)_0003)._0002()) : (((_000F_2004)_0002)._0002() == 0)) : (((_000F_2004)_0002)._0002() == Convert.ToInt64(((_000F_2002)_0003)._0002())));
			break;
		case 24:
			result = ((_0003._0002() == 8 && _0003._000E_2001_200A_2002_0002() == null) ? (((_000E_2006)_0002)._0002() == IntPtr.Zero) : ((_0003._0002() != 16) ? ((_0003._0002() != 26) ? (((_000E_2006)_0002)._0002() == ((_000E_2006)_0003)._0002()) : (((_000E_2006)_0002)._0002() == new IntPtr(((_000F_2004)_0003)._0002()))) : (((_000E_2006)_0002)._0002() == new IntPtr(((_0006_2004)_0003)._0002()))));
			break;
		case 7:
			result = ((_0003._0002() == 8 && _0003._000E_2001_200A_2002_0002() == null) ? (((_0005_2007)_0002)._0002() == UIntPtr.Zero) : ((_0003._0002() != 16) ? ((_0003._0002() != 26) ? (((_0005_2007)_0002)._0002() == ((_0005_2007)_0003)._0002()) : (((_0005_2007)_0002)._0002() == new UIntPtr((ulong)((_000F_2004)_0003)._0002()))) : (((_0005_2007)_0002)._0002() == new UIntPtr((uint)((_0006_2004)_0003)._0002()))));
			break;
		case 8:
			result = _0002._000E_2001_200A_2002_0002() == _0003._000E_2001_200A_2002_0002();
			break;
		case 4:
			result = (_0003._0002() != 8 || _0003._000E_2001_200A_2002_0002() != null) && ((_0006_200A)_0002)._0002() == ((_0006_200A)_0003)._0002();
			break;
		case 15:
		{
			_000F_2002 obj9 = (_000F_2002)_0002;
			if (_0003._0002() == 15)
			{
				result = Convert.ToInt64(obj9._0002()) == Convert.ToInt64(((_000F_2002)_0003)._0002());
			}
			else if (obj9._0002() == null)
			{
				result = _0003._000E_2001_200A_2002_0002() == null;
			}
			else if (_0003._000E_2001_200A_2002_0002() != null)
			{
				result = Convert.ToInt64(obj9._0002()) == Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
			}
			break;
		}
		case 14:
		{
			double d = ((_0003_2003)_0002)._0002();
			double num = ((_0003_2003)_0003)._0002();
			result = !double.IsNaN(d) && !double.IsNaN(num) && d.Equals(num);
			break;
		}
		case 5:
		case 12:
		{
			_000F_2008 obj7 = (_000F_2008)_0002;
			_000F_2008 obj8 = (_000F_2008)_0003;
			result = obj7._000F_2008_200A_2002_0002(obj8);
			break;
		}
		case 3:
		{
			_0008_2009 obj5 = (_0008_2009)_0002;
			_0008_2009 obj6 = (_0008_2009)_0003;
			result = obj5._0002() == obj6._0002() && (object)obj5._0002() == obj6._0002();
			break;
		}
		case 17:
		{
			_000E_2009 obj3 = (_000E_2009)_0002;
			_000E_2009 obj4 = (_000E_2009)_0003;
			result = obj3._0002() == obj4._0002();
			break;
		}
		case 13:
		{
			_0006_2008 obj = (_0006_2008)_0002;
			result = _0006(_0003: ((_0006_2008)_0003)._0002(), _0002: obj._0002());
			break;
		}
		default:
			result = _0002._000E_2001_200A_2002_0002() == _0003._000E_2001_200A_2002_0002();
			break;
		}
		return result;
	}

	private static void _0008_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E_2000(_0002: false);
	}

	private static void _0003_2004_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506763231));
	}

	private static void _0003_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(typeof(float));
	}

	private object _0002(int _0002)
	{
		switch (global::_000F._0002(_0002))
		{
		case 16777216:
		case 33554432:
		case 452984832:
			return this.m__0002_2003.ModuleHandle.ResolveTypeHandle(_0002);
		case 67108864:
			return this.m__0002_2003.ModuleHandle.ResolveFieldHandle(_0002);
		case 100663296:
		case 721420288:
			return this.m__0002_2003.ModuleHandle.ResolveMethodHandle(_0002);
		case 167772160:
			try
			{
				return this.m__0002_2003.ModuleHandle.ResolveFieldHandle(_0002);
			}
			catch
			{
				try
				{
					return this.m__0002_2003.ModuleHandle.ResolveMethodHandle(_0002);
				}
				catch
				{
					throw new InvalidOperationException();
				}
			}
		default:
			throw new InvalidOperationException();
		}
	}

	private _000E_2000 _0002(_0008_2002 _0002)
	{
		_000E_2000 obj = new _000E_2000();
		obj._0002(_0002._0006());
		return obj;
	}

	private static _000E_2001 _0003(_000E_2001 _0002, _000E_2001 _0003, bool _0005)
	{
		if (!_0005)
		{
			long num = ((_000F_2004)_0002)._0002();
			long num2 = ((_000F_2004)_0003)._0002();
			return new _000F_2004(num / num2);
		}
		long num3 = ((_000F_2004)_0002)._0002();
		ulong num4 = (ulong)((_000F_2004)_0003)._0002();
		return new _000F_2004((long)((ulong)num3 / num4));
	}

	private static _000E_2001 _0005(_000E_2001 _0002, _000E_2001 _0003, bool _0005)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				if (!_0005)
				{
					int num = ((_0006_2004)_0002)._0002();
					int num2 = ((_0006_2004)_0003)._0002();
					return new _0006_2004(num % num2);
				}
				int num3 = ((_0006_2004)_0002)._0002();
				uint num4 = (uint)((_0006_2004)_0003)._0002();
				return new _0006_2004((int)((uint)num3 % num4));
			}
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0002((_000E_2001)new _000F_2004(((_0006_2004)_0002)._0002()), _0003, _0005);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					return global::_0002_2008._0002((_000E_2001)new _000F_2004(((_0006_2004)_0002)._0002()), (_000E_2001)new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005);
				}
				return global::_0002_2008._0005(_0002, new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				return global::_0002_2008._0002(_0002, _0003, _0005);
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0002(_0002, (_000E_2001)new _000F_2004(((_0006_2004)_0003)._0002()), _0005);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return global::_0002_2008._0002(_0002, (_000E_2001)new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002())), _0005);
				}
				return global::_0002_2008._0002(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(_0003._000E_2001_200A_2002_0002())), _0005);
			}
		}
		if (_0002._0002() == 14 && _0003._0002() == 14)
		{
			_0003_2003 obj = new _0003_2003();
			obj._0002(((_0003_2003)_0002)._0002() % ((_0003_2003)_0003)._0002());
			return obj;
		}
		if (_0002._0002() == 15)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
			if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong))
			{
				return global::_0002_2008._0005(new _000F_2004(Convert.ToInt64(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
			}
			return global::_0002_2008._0005(new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002())), _0003, _0005);
		}
		throw new InvalidOperationException();
	}

	private static bool _0002(_000E_2001 _0002, _000E_2001 _0003)
	{
		bool result = false;
		switch (_0002._0002())
		{
		case 16:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0002(_0002, (_000E_2001)new _0006_2004(Convert.ToInt32(((_000F_2002)_0003)._0002())));
			}
			result = ((_0006_2004)_0002)._0002() > ((_0006_2004)_0003)._0002();
			break;
		case 26:
			if (_0003._0002() == 15)
			{
				return global::_0002_2008._0002(_0002, (_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0003)._0002())));
			}
			if (_0003._0002() == 16)
			{
				return global::_0002_2008._0002(_0002, (_000E_2001)new _000F_2004(((_0006_2004)_0003)._0002()));
			}
			result = ((_000F_2004)_0002)._0002() > ((_000F_2004)_0003)._0002();
			break;
		case 15:
			return global::_0002_2008._0002((_000E_2001)new _000F_2004(Convert.ToInt64(((_000F_2002)_0002)._0002())), _0003);
		case 14:
		{
			double num = ((_0003_2003)_0002)._0002();
			double num2 = ((_0003_2003)_0003)._0002();
			result = !double.IsNaN(num) && !double.IsNaN(num2) && num > num2;
			break;
		}
		}
		return result;
	}

	private static void _0003_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_0002._0005(type);
	}

	private static void _0005_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(double));
	}

	private static void _0003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003_2000(_0002: false);
	}

	private static void _000F_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(new _000F_2007());
	}

	private static void _0005_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(1);
	}

	private static void _0003_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0002: false, _0003: false);
	}

	private static bool _0002(uint _0002, uint _0003, uint _0005)
	{
		if (_0002 >= _0003)
		{
			return _0002 <= _0003 + _0005;
		}
		return false;
	}

	private static void _0003_2002(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(_0002: false);
	}

	private static void _0002_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_0002._0003(type);
	}

	private static void _0008_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002((int)((_0008_2005)_0003)._0002());
	}

	private void _0002(Type _0002, object _0003, long _0005, Array _0008)
	{
		_000E_2001 obj = global::_000E_2001._0002(_0003, _0002);
		_0008.SetValue(obj._000E_2001_200A_2002_0002(), _0005);
	}

	private static void _0003_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(new _0006_2004(global::_0002_2008._0008(obj2, obj) ? 1 : 0));
	}

	private static void _000F_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005();
	}

	private static void _000F_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005_2000(_0002: false);
	}

	private static void _0008_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(byte));
	}

	private static void _000E(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0006_2004 obj = (_0006_2004)_0003;
		MethodBase methodBase = _0002._0002(obj._0002());
		Type declaringType = methodBase.DeclaringType;
		Type type = _0002._0002()._000E_2001_200A_2002_0002().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		Type type2 = type;
		while ((object)type2 != null && (object)type2 != declaringType)
		{
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if ((object)method != null && (object)method.GetBaseDefinition() == methodBase)
			{
				methodBase2 = method;
				break;
			}
			type2 = type2.BaseType;
		}
		if ((object)methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		_0005_2006 obj2 = new _0005_2006();
		obj2._0002(methodBase2);
		_0002._0005(obj2);
	}

	private static void _0005_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(uint));
	}

	private void _0005(int _0002)
	{
		_000E_2001 obj = this._0002();
		if (obj is _0005_2008)
		{
			this.m__000E_2002[_0002] = obj;
		}
		else
		{
			this.m__000E_2002[_0002]._000E_2001_200A_2002_0002(obj);
		}
	}

	private void _0003(bool _0002, bool _0003)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(_0006(obj2, obj, _0002, _0003));
	}

	private static void _0002_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		FieldInfo fieldInfo = _0002._0002(num);
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0005_2008 obj3 = obj2 as _0005_2008;
		object obj4 = ((obj3 == null) ? obj2._000E_2001_200A_2002_0002() : _0002._0002(obj3)._000E_2001_200A_2002_0002());
		if (obj4 == null)
		{
			throw new NullReferenceException();
		}
		_000E_2001 obj5 = global::_000E_2001._0002(obj._000E_2001_200A_2002_0002(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj4, obj5._000E_2001_200A_2002_0002());
		if (obj3 != null && obj4 != null && obj4.GetType().IsValueType)
		{
			_0002._0002(obj3, global::_000E_2001._0002(obj4, null));
		}
	}

	private static void _000E_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(0);
	}

	private static void _000E_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506765798));
	}

	private bool _0002()
	{
		if (this.m__0008_2004 == null)
		{
			return this.m__0003_2001.Count != 0;
		}
		return true;
	}

	private static void _000F_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E(_0002: true);
	}

	private static void _0006_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(3);
	}

	private void _000E(bool _0002)
	{
		_000E_2001 obj = this._0002();
		short num = obj._0002() switch
		{
			16 => (!_0002) ? ((short)((_0006_2004)obj)._0002()) : checked((short)((_0006_2004)obj)._0002()), 
			26 => (!_0002) ? ((short)((_000F_2004)obj)._0002()) : checked((short)((_000F_2004)obj)._0002()), 
			15 => (!_0002) ? ((short)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((short)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((short)((_0003_2003)obj)._0002()) : checked((short)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((!_0002) ? ((short)(long)((_000E_2006)obj)._0002()) : checked((short)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((short)(int)((_000E_2006)obj)._0002()) : checked((short)(int)((_000E_2006)obj)._0002())), 
			_ => throw new InvalidOperationException(), 
		};
		_0006_2004 obj2 = new _0006_2004();
		obj2._0002(num);
		_0005(obj2);
	}

	private static void _0006_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(ushort));
	}

	private static void _0002_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000F_2000(_0002: false);
	}

	private object _0002(object[] _0002, Type[] _0003, Type[] _0005, object[] _0008)
	{
		this._0002();
		if (_0002 == null)
		{
			_0002 = global::_0003_2007<object>._0002;
		}
		this.m__000E_2000 = _0008;
		this.m__000F_2002 = _0003;
		this.m__0005_2004 = _0005;
		this.m__0005 = this._0002(_0002);
		this.m__000E_2002 = this._0002();
		try
		{
			_0008_2004 obj = new _0008_2004(this.m__0002);
			try
			{
				using (this.m__0003_2000 = new _0008_2002(obj))
				{
					this.m__0003_2002 = (uint)((_0005_2004)obj)._0005_2004_200A_2002_0002();
					this.m__000E_2003 = false;
					this.m__0008_2001 = null;
					this.m__0008_2002 = 0u;
					this.m__0006_2000 = 0u;
					_0002_2000();
					_0005_2000();
				}
			}
			finally
			{
				((IDisposable)obj).Dispose();
			}
			Type type = this._0002(this.m__0006_2001._0003(), _0003: false);
			if ((object)type != global::_0002_2008.m__0002_2004 && this._0002())
			{
				return global::_000E_2001._0002(null, type)._000E_2001_200A_2002_0002(this._0002())._000E_2001_200A_2002_0002();
			}
			return null;
		}
		finally
		{
			for (int i = 0; i < this.m__0006_2001._0002().Length; i++)
			{
				_0008_2001 obj3 = this.m__0006_2001._0002()[i];
				if (obj3._0002())
				{
					_0006_2008 obj4 = (_0006_2008)this.m__0005[i];
					Type type2 = this._0002(obj3._0002(), _0003: false);
					_0002[i] = global::_000E_2001._0002(null, type2.GetElementType())._000E_2001_200A_2002_0002(obj4._0002())._000E_2001_200A_2002_0002();
				}
			}
			this.m__000E_2000 = null;
			this.m__0005 = null;
			this.m__000E_2002 = null;
		}
	}

	private static void _0002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(-1);
	}

	private static void _0003_2003(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(_0002._0002(obj));
	}

	private static void _0005_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(_0002._0003(obj2, obj));
	}

	private bool _0002(_000E_2001 _0002, Type _0003)
	{
		object obj = _0002._000E_2001_200A_2002_0002();
		if (obj == null)
		{
			return true;
		}
		Type type = _0002._0002() ?? obj.GetType();
		if ((object)type == _0003 || _0003.IsAssignableFrom(type))
		{
			return true;
		}
		if (!type.IsValueType && !_0003.IsValueType)
		{
			if (Marshal.IsComObject(obj))
			{
				IntPtr intPtr;
				try
				{
					intPtr = Marshal.GetComInterfaceForObject(obj, _0003);
				}
				catch (InvalidCastException)
				{
					intPtr = IntPtr.Zero;
				}
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						Marshal.Release(intPtr);
					}
					catch
					{
					}
					return true;
				}
			}
			else if (global::_0002_2008._0002(obj))
			{
				return true;
			}
		}
		return false;
	}

	private _000E_2001 _0002(_0008_2002 _0002, byte _0003)
	{
		switch (_0003)
		{
		case 12:
			return null;
		case 11:
		{
			this.m__0006_2000++;
			_0003_2005 obj2 = new _0003_2005();
			obj2._0002(_0002._0002());
			return obj2;
		}
		case 0:
		case 9:
			this.m__0006_2000 += 4u;
			return new _0006_2004(_0002._0006());
		case 2:
			this.m__0006_2000 += 8u;
			return new _000F_2004(_0002._0002());
		case 3:
		case 6:
		{
			this.m__0006_2000++;
			_000E_2003 obj7 = new _000E_2003();
			obj7._0002(_0002._0002());
			return obj7;
		}
		case 1:
		case 4:
		{
			this.m__0006_2000 += 2u;
			_0008_2005 obj6 = new _0008_2005();
			obj6._0002(_0002._0002());
			return obj6;
		}
		case 5:
		{
			this.m__0006_2000 += 4u;
			_0008_2003 obj5 = new _0008_2003();
			obj5._0002(_0002._0002());
			return obj5;
		}
		case 8:
		{
			this.m__0006_2000 += 8u;
			_0003_2003 obj4 = new _0003_2003();
			obj4._0002(_0002._0002());
			return obj4;
		}
		case 10:
		{
			this.m__0006_2000 += 4u;
			_000E_2005 obj3 = new _000E_2005();
			obj3._0002(_0002._0002());
			return obj3;
		}
		case 7:
		{
			int num = _0002._0006();
			_0006_2004[] array = new _0006_2004[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new _0006_2004(_0002._0006());
			}
			this.m__0006_2000 += (uint)((num + 1) * 4);
			_0002_2002 obj = new _0002_2002();
			obj._0002(array);
			return obj;
		}
		default:
			throw new Exception(global::_000F_2004_2000._0002(-1506766025));
		}
	}

	private static void _000F_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0002: false);
	}

	private static void _0002_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008();
	}

	private void _0003()
	{
		this.m__0008_2002 = this.m__0006_2000;
		int key = this.m__0003_2000._0006();
		this.m__0006_2000 += 4u;
		global::_0002_2008.m__000F_2001.TryGetValue(key, out var value);
		value._0003(this, _0002(this.m__0003_2000, value._0002));
	}

	private static void _0005_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000F(_0002: true);
	}

	private static void _0006_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(new _0006_2004(global::_0002_2008._0005(obj2, obj) ? 1 : 0));
	}

	private static void _0008_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766688));
	}

	private static void _000E_200A_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		IntPtr intPtr = checked(obj._0002() switch
		{
			16 => new IntPtr((uint)((_0006_2004)obj)._0002()), 
			26 => new IntPtr((long)(ulong)((_000F_2004)obj)._0002()), 
			15 => new IntPtr((long)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => new IntPtr((long)((_0003_2003)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		});
		_000E_2006 obj2 = new _000E_2006();
		obj2._0002(intPtr);
		_0002._0005(obj2);
	}

	private static void _0003_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		Thread.MemoryBarrier();
	}

	private void _0003(bool _0002)
	{
		_000E_2001 obj = this._0002();
		bool flag = IntPtr.Size == 4;
		checked
		{
			IntPtr intPtr;
			switch (obj._0002())
			{
			case 16:
			{
				int num = ((_0006_2004)obj)._0002();
				intPtr = ((!flag) ? ((!_0002) ? new IntPtr(unchecked((uint)num)) : new IntPtr((uint)num)) : ((!_0002) ? new IntPtr(num) : new IntPtr((int)(uint)num)));
				break;
			}
			case 26:
			{
				long num2 = ((_000F_2004)obj)._0002();
				intPtr = ((!flag) ? ((!_0002) ? new IntPtr(num2) : new IntPtr((long)(ulong)num2)) : ((!_0002) ? new IntPtr(unchecked((int)num2)) : new IntPtr((int)(ulong)num2)));
				break;
			}
			case 14:
			{
				double num3 = ((_0003_2003)obj)._0002();
				intPtr = ((!flag) ? ((!_0002) ? new IntPtr(unchecked((long)num3)) : new IntPtr((long)(ulong)num3)) : ((!_0002) ? new IntPtr(unchecked((int)(ulong)num3)) : new IntPtr((int)(ulong)num3)));
				break;
			}
			case 15:
				intPtr = ((!_0002) ? new IntPtr(Convert.ToInt64(((_000F_2002)obj)._0002())) : new IntPtr(Convert.ToInt64(((_000F_2002)obj)._0002())));
				break;
			default:
				throw new InvalidOperationException();
			}
			_000E_2006 obj2 = new _000E_2006();
			obj2._0002(intPtr);
			_0005(obj2);
		}
	}

	private void _0002(MemberInfo _0002)
	{
		if (!global::_0002_2008._0002() || this.m__0006_2001._0003())
		{
			return;
		}
		bool flag = false;
		Assembly assembly = typeof(SecurityCriticalAttribute).Assembly;
		MemberInfo memberInfo = _0002;
		while ((object)memberInfo != null)
		{
			object[] customAttributes = memberInfo.GetCustomAttributes(inherit: false);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				Type type = customAttributes[i].GetType();
				if ((object)type.Assembly == assembly)
				{
					string fullName = type.FullName;
					if (global::_000F_2004_2000._0002(-1506765569).Equals(fullName, StringComparison.Ordinal))
					{
						flag = true;
						goto end_IL_0098;
					}
					if (global::_000F_2004_2000._0002(-1506765649).Equals(fullName, StringComparison.Ordinal))
					{
						goto end_IL_0098;
					}
				}
			}
			memberInfo = memberInfo.DeclaringType;
			continue;
			end_IL_0098:
			break;
		}
		if (flag)
		{
			if (_0002 is MethodBase)
			{
				string text = global::_0002_2008._0002((MethodBase)_0002);
				throw _0005(this._0002(this.m__0006_2001), text);
			}
			if (_0002 is FieldInfo)
			{
				string text2 = _0002.DeclaringType.FullName + global::_000F_2004_2000._0002(-1506765669) + _0002.Name;
				throw global::_0002_2008._0002(this._0002(this.m__0006_2001), text2);
			}
			if (_0002 is Type)
			{
				string fullName2 = ((Type)_0002).FullName;
				throw _0003(this._0002(this.m__0006_2001), fullName2);
			}
			throw new SecurityException(global::_000F_2004_2000._0002(-1506765981));
		}
	}

	private void _0002(int _0002, Type[] _0003, Type[] _0005, bool _0008)
	{
		this.m__0006_2003._0002()._0005_2004_200A_2002_0002(_0002, 0);
		this._0002(this.m__0006_2003);
		_0003_2001 obj = this._0002(this.m__0006_2003);
		this._0002(obj);
		int num = obj._0002().Length;
		object[] array = new object[num];
		_000E_2001[] array2 = new _000E_2001[num];
		if ((object)this.m__0005_2003 != null && _0008)
		{
			int num2 = ((!obj._0002()) ? 1 : 0);
			Type[] array3 = new Type[num - num2];
			for (int num3 = num - 1; num3 >= num2; num3--)
			{
				array3[num3] = this._0002(obj._0002()[num3]._0002(), _0003: true);
			}
			MethodInfo method = this.m__0005_2003.GetMethod(obj._0002(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			this.m__0005_2003 = null;
			if ((object)method != null)
			{
				this._0002((MethodBase)method, _0003: true);
				return;
			}
		}
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			_000E_2001 obj2 = (array2[num4] = this._0002());
			_0005_2008 obj3 = obj2 as _0005_2008;
			if (obj3 != null)
			{
				obj2 = this._0002(obj3);
			}
			if ((object)obj2._0002() != null)
			{
				obj2 = global::_000E_2001._0002(null, obj2._0002())._000E_2001_200A_2002_0002(obj2);
			}
			_000E_2001 obj4 = global::_000E_2001._0002(null, this._0002(obj._0002()[num4]._0002(), _0003: true))._000E_2001_200A_2002_0002(obj2);
			array[num4] = obj4._000E_2001_200A_2002_0002();
			if (num4 == 0 && _0008 && !obj._0002() && array[num4] == null)
			{
				throw new NullReferenceException();
			}
		}
		_0002_2008 obj5 = new _0002_2008(this.m__0008_2003);
		object[] array4 = new object[1] { this.m__0002_2003.Assembly };
		object obj6;
		try
		{
			obj6 = obj5._0002(this.m__0005_2001, _0002, array, _0003, _0005, array4);
		}
		finally
		{
			bool flag = !obj._0002();
			for (int i = 0; i < num; i++)
			{
				int num5;
				if (flag)
				{
					num5 = i + 1;
					if (num5 == num)
					{
						num5 = 0;
					}
				}
				else
				{
					num5 = i;
				}
				_0005_2008 obj7 = array2[num5] as _0005_2008;
				if (obj7 != null)
				{
					this._0002(obj7, global::_000E_2001._0002(array[num5], null));
				}
			}
		}
		Type type = obj5._0002(obj5.m__0006_2001._0003(), _0003: true);
		if ((object)type != global::_0002_2008.m__0002_2004)
		{
			this._0005(global::_000E_2001._0002(obj6, type));
		}
	}

	private void _0002(Stream _0002, string _0003)
	{
		this._0002(_0002, 0L, _0003);
	}

	private static void _0008_2004(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_000E_2001 obj = global::_000E_2001._0002(_0002._0002()._000E_2001_200A_2002_0002(), type);
		_0002._0005(obj);
	}

	private object _0002(Stream _0002, int _0003, object[] _0005, Type[] _0008, Type[] _0006, object[] _000E)
	{
		this.m__0005_2001 = _0002;
		this._0002(_0002, _0003, null);
		return this._0002(_0005, _0008, _0006, _000E);
	}

	private static void _0006_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(_0002: true);
	}

	private static void _0008_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._000E(((_000E_2003)_0003)._0002());
	}

	private static object _0002(MethodBase _0002, object _0003, object[] _0005)
	{
		if (_0002.IsConstructor)
		{
			try
			{
				return Activator.CreateInstance(_0002.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, _0005, null);
			}
			catch (AmbiguousMatchException)
			{
				return ((ConstructorInfo)_0002).Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, _0005, null);
			}
		}
		return _0002.Invoke(_0003, _0005);
	}

	private static void _0006_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(int));
	}

	private static void _000F_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008_2000(_0002: false);
	}

	private static void _0002_2007(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(_0003);
	}

	private static void _0002_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(((_0008_2005)_0003)._0002());
	}

	private static void _0006_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(0);
	}

	private static Dictionary<int, _0002_2000> _0002(_0003_200B _0002)
	{
		return new Dictionary<int, _0002_2000>(256)
		{
			{
				_0002._0002_2004._0002(),
				new _0002_2000(_0002._0002_2004, _0005_2001_2000)
			},
			{
				_0002._000F_2007_2000._0002(),
				new _0002_2000(_0002._000F_2007_2000, _0006_2001_2001)
			},
			{
				_0002._0006_2004._0002(),
				new _0002_2000(_0002._0006_2004, _0003_2006)
			},
			{
				_0002._000E_2001._0002(),
				new _0002_2000(_0002._000E_2001, _0002_2002_2000)
			},
			{
				_0002._000F_2005_2000._0002(),
				new _0002_2000(_0002._000F_2005_2000, _0005_2000_2001)
			},
			{
				_0002._0008_2003_2000._0002(),
				new _0002_2000(_0002._0008_2003_2000, _0008_2008)
			},
			{
				_0002._000E_2003_2001._0002(),
				new _0002_2000(_0002._000E_2003_2001, _0003_2009_2000)
			},
			{
				_0002._0008_2007_2000._0002(),
				new _0002_2000(_0002._0008_2007_2000, _0002_200B)
			},
			{
				_0002._000F_2007._0002(),
				new _0002_2000(_0002._000F_2007, _000E_2009_2000)
			},
			{
				_0002._0002_2001_2000._0002(),
				new _0002_2000(_0002._0002_2001_2000, _0002_2000)
			},
			{
				_0002._000F_2009._0002(),
				new _0002_2000(_0002._000F_2009, _0008_2002_2000)
			},
			{
				_0002._000E_2007_2000._0002(),
				new _0002_2000(_0002._000E_2007_2000, _0008_2000)
			},
			{
				_0002._000E_2000_2000._0002(),
				new _0002_2000(_0002._000E_2000_2000, _000E_2006)
			},
			{
				_0002._0002_2004_2000._0002(),
				new _0002_2000(_0002._0002_2004_2000, _000E_2002)
			},
			{
				_0002._0002_2007._0002(),
				new _0002_2000(_0002._0002_2007, _000E_200A_2000)
			},
			{
				_0002._000E_2001_2001._0002(),
				new _0002_2000(_0002._000E_2001_2001, _000E_2002_2000)
			},
			{
				_0002._0005_2002._0002(),
				new _0002_2000(_0002._0005_2002, _000E_2000)
			},
			{
				_0002._0005_2004_2000._0002(),
				new _0002_2000(_0002._0005_2004_2000, _0003_200B_2000)
			},
			{
				_0002._0005_2001_2001._0002(),
				new _0002_2000(_0002._0005_2001_2001, _0003_2008_2000)
			},
			{
				_0002._000E_2005_2000._0002(),
				new _0002_2000(_0002._000E_2005_2000, _000F_2008_2000)
			},
			{
				_0002._0008_2005_2000._0002(),
				new _0002_2000(_0002._0008_2005_2000, _0005_2007)
			},
			{
				_0002._000E_200B._0002(),
				new _0002_2000(_0002._000E_200B, _0008_2001)
			},
			{
				_0002._0006_2000_2000._0002(),
				new _0002_2000(_0002._0006_2000_2000, _000F_2000_2000)
			},
			{
				_0002._000F_2006._0002(),
				new _0002_2000(_0002._000F_2006, _0002_2004_2001)
			},
			{
				_0002._0002_2000_2000._0002(),
				new _0002_2000(_0002._0002_2000_2000, _0003_2007_2000)
			},
			{
				_0002._000F_2000._0002(),
				new _0002_2000(_0002._000F_2000, _000F_2004)
			},
			{
				_0002._0006_200A_2000._0002(),
				new _0002_2000(_0002._0006_200A_2000, _000E_2000_2000)
			},
			{
				_0002._0008_2009._0002(),
				new _0002_2000(_0002._0008_2009, _0005_2000_2000)
			},
			{
				_0002._000F_2002_2000._0002(),
				new _0002_2000(_0002._000F_2002_2000, _0003_2005)
			},
			{
				_0002._000E._0002(),
				new _0002_2000(_0002._000E, _0006_2004_2000)
			},
			{
				_0002._0005_2007_2000._0002(),
				new _0002_2000(_0002._0005_2007_2000, _000F_2005_2000)
			},
			{
				_0002._0005_200A_2000._0002(),
				new _0002_2000(_0002._0005_200A_2000, _0002_2004)
			},
			{
				_0002._0008_200B_2000._0002(),
				new _0002_2000(_0002._0008_200B_2000, _000F_2001_2000)
			},
			{
				_0002._0003_2004._0002(),
				new _0002_2000(_0002._0003_2004, _0006_2003_2000)
			},
			{
				_0002._0003_2007_2000._0002(),
				new _0002_2000(_0002._0003_2007_2000, _0005_2002_2000)
			},
			{
				_0002._0003_2006._0002(),
				new _0002_2000(_0002._0003_2006, _000E_2006_2000)
			},
			{
				_0002._0003_200A._0002(),
				new _0002_2000(_0002._0003_200A, _0002_2001_2000)
			},
			{
				_0002._0002_2005_2000._0002(),
				new _0002_2000(_0002._0002_2005_2000, _0003_2002_2001)
			},
			{
				_0002._0006_2009._0002(),
				new _0002_2000(_0002._0006_2009, _0005_2004_2000)
			},
			{
				_0002._0002_200A_2000._0002(),
				new _0002_2000(_0002._0002_200A_2000, _000F_2009)
			},
			{
				_0002._0003_2001_2000._0002(),
				new _0002_2000(_0002._0003_2001_2000, _0008_200B)
			},
			{
				_0002._0005_2005._0002(),
				new _0002_2000(_0002._0005_2005, _000F_200B_2000)
			},
			{
				_0002._0008_2006_2000._0002(),
				new _0002_2000(_0002._0008_2006_2000, _0008_200A)
			},
			{
				_0002._0002_2008._0002(),
				new _0002_2000(_0002._0002_2008, _0008_2009_2000)
			},
			{
				_0002._0002_2002_2000._0002(),
				new _0002_2000(_0002._0002_2002_2000, _0002_2008)
			},
			{
				_0002._0008_200A._0002(),
				new _0002_2000(_0002._0008_200A, _0003_2000_2000)
			},
			{
				_0002._000F_2001_2000._0002(),
				new _0002_2000(_0002._000F_2001_2000, _0006_2002_2001)
			},
			{
				_0002._0005_2002_2000._0002(),
				new _0002_2000(_0002._0005_2002_2000, _000E_2002_2001)
			},
			{
				_0002._0005_200A._0002(),
				new _0002_2000(_0002._0003_2003, _0003_2001_2001)
			},
			{
				_0002._000F_2001_2001._0002(),
				new _0002_2000(_0002._000F_2001_2001, _0008_2000_2001)
			},
			{
				_0002._0003_2003._0002(),
				new _0002_2000(_0002._0003_2003, _0005_2007_2000)
			},
			{
				_0002._0006_200B_2000._0002(),
				new _0002_2000(_0002._0006_200B_2000, _0003_2003)
			},
			{
				_0002._0002_200B_2000._0002(),
				new _0002_2000(_0002._0002_200B_2000, _0006_2003)
			},
			{
				_0002._0008_2008_2000._0002(),
				new _0002_2000(_0002._0008_2008_2000, _0003_2001)
			},
			{
				_0002._0006_2002._0002(),
				new _0002_2000(_0002._0006_2002, _0006_2001_2000)
			},
			{
				_0002._0002_2002_2001._0002(),
				new _0002_2000(_0002._0002_2002_2001, _000E_2009)
			},
			{
				_0002._000F_2008_2000._0002(),
				new _0002_2000(_0002._000F_2008_2000, _000E_2008)
			},
			{
				_0002._0006_2008._0002(),
				new _0002_2000(_0002._0006_2008, _0002_2000_2001)
			},
			{
				_0002._0003_2005_2000._0002(),
				new _0002_2000(_0002._0003_2005_2000, _0006)
			},
			{
				_0002._0008_2004_2000._0002(),
				new _0002_2000(_0002._0008_2004_2000, _0002_2002)
			},
			{
				_0002._0005_2005_2001._0002(),
				new _0002_2000(_0002._0005_2005_2001, _0003_2004)
			},
			{
				_0002._0005._0002(),
				new _0002_2000(_0002._0005, _0008_2002)
			},
			{
				_0002._0003._0002(),
				new _0002_2000(_0002._0003, _000E_2001_2000)
			},
			{
				_0002._0008_200A_2000._0002(),
				new _0002_2000(_0002._0008_200A_2000, _0002_2008_2000)
			},
			{
				_0002._000E_2007._0002(),
				new _0002_2000(_0002._000E_2007, _0006_2009)
			},
			{
				_0002._0002_200B._0002(),
				new _0002_2000(_0002._0002_200B, _0006_2001)
			},
			{
				_0002._0005_200B_2000._0002(),
				new _0002_2000(_0002._0005_200B_2000, _0008_2007)
			},
			{
				_0002._0003_200B._0002(),
				new _0002_2000(_0002._0003_200B, _000F_2008)
			},
			{
				_0002._0006_2006._0002(),
				new _0002_2000(_0002._0006_2006, _0005_2009)
			},
			{
				_0002._000E_2005._0002(),
				new _0002_2000(_0002._000E_2005, _0002_2009_2000)
			},
			{
				_0002._0006_2005_2001._0002(),
				new _0002_2000(_0002._0006_2005_2001, _0006_2002_2000)
			},
			{
				_0002._000F_2006_2000._0002(),
				new _0002_2000(_0002._000F_2006_2000, _000F_2000)
			},
			{
				_0002._0002_2000._0002(),
				new _0002_2000(_0002._0002_2000, _0006_2000)
			},
			{
				_0002._0002_2003._0002(),
				new _0002_2000(_0002._0002_2003, _0006_2000_2000)
			},
			{
				_0002._000F_2002_2001._0002(),
				new _0002_2000(_0002._000F_2002_2001, _0008_2007_2000)
			},
			{
				_0002._0008_2000_2001._0002(),
				new _0002_2000(_0002._0008_2000_2001, _0002_200B_2000)
			},
			{
				_0002._0002_200A._0002(),
				new _0002_2000(_0002._0002_200A, _0006_2009_2000)
			},
			{
				_0002._000F_2003_2000._0002(),
				new _0002_2000(_0002._000F_2003_2000, _0005)
			},
			{
				_0002._0002_2004_2001._0002(),
				new _0002_2000(_0002._0002_2004_2001, _000F_2003_2000)
			},
			{
				_0002._0002._0002(),
				new _0002_2000(_0002._0002, _0003_2005_2000)
			},
			{
				_0002._0003_2004_2000._0002(),
				new _0002_2000(_0002._0003_2004_2000, _000F_2007_2000)
			},
			{
				_0002._000F_2004_2001._0002(),
				new _0002_2000(_0002._000F_2004_2001, _000E_2003)
			},
			{
				_0002._000E_2001_2000._0002(),
				new _0002_2000(_0002._000E_2001_2000, _0005_2008_2000)
			},
			{
				_0002._0003_2000_2001._0002(),
				new _0002_2000(_0002._0003_2000_2001, _0005_200B)
			},
			{
				_0002._0003_2000._0002(),
				new _0002_2000(_0002._0003_2000, _0005_2003_2001)
			},
			{
				_0002._0006_2002_2000._0002(),
				new _0002_2000(_0002._0006_2002_2000, _0005_2004)
			},
			{
				_0002._0008_2004_2001._0002(),
				new _0002_2000(_0002._0008_2004_2001, _0003_2003_2000)
			},
			{
				_0002._0003_2003_2000._0002(),
				new _0002_2000(_0002._0003_2003_2000, _0002_2009)
			},
			{
				_0002._0008_2005_2001._0002(),
				new _0002_2000(_0002._0008_2005_2001, _000F)
			},
			{
				_0002._0005_2009._0002(),
				new _0002_2000(_0002._0005_2009, _000F_2006_2000)
			},
			{
				_0002._000F_200B._0002(),
				new _0002_2000(_0002._000F_200B, _0002_200A)
			},
			{
				_0002._0002_2001._0002(),
				new _0002_2000(_0002._0002_2001, _0005_2006_2000)
			},
			{
				_0002._0008_2002_2001._0002(),
				new _0002_2000(_0002._0008_2002_2001, _000E_2003_2000)
			},
			{
				_0002._0005_2009_2000._0002(),
				new _0002_2000(_0002._0005_2009_2000, _000E_2001_2001)
			},
			{
				_0002._0003_2001._0002(),
				new _0002_2000(_0002._0003_2001, _000F_2001)
			},
			{
				_0002._000E_200A_2000._0002(),
				new _0002_2000(_0002._000E_200A_2000, _0002_2000_2000)
			},
			{
				_0002._000E_200B_2000._0002(),
				new _0002_2000(_0002._000E_200B_2000, _0005_2002_2001)
			},
			{
				_0002._0003_2003_2001._0002(),
				new _0002_2000(_0002._0003_2003_2001, _0008_2004_2000)
			},
			{
				_0002._0006_2003_2000._0002(),
				new _0002_2000(_0002._0006_2003_2000, _000E_2003_2001)
			},
			{
				_0002._000E_2003._0002(),
				new _0002_2000(_0002._000E_2003, _0008_2003)
			},
			{
				_0002._0005_2006_2000._0002(),
				new _0002_2000(_0002._0005_2006_2000, _0005_2001_2001)
			},
			{
				_0002._000E_2003_2000._0002(),
				new _0002_2000(_0002._000E_2003_2000, _0006_2007_2000)
			},
			{
				_0002._0008_2008._0002(),
				new _0002_2000(_0002._0008_2008, _0008_2003_2001)
			},
			{
				_0002._000F_2004._0002(),
				new _0002_2000(_0002._000F_2004, _0003_2004_2001)
			},
			{
				_0002._0008_2002_2000._0002(),
				new _0002_2000(_0002._0008_2002_2000, _0003_2008)
			},
			{
				_0002._0003_2009._0002(),
				new _0002_2000(_0002._0003_2009, _0002_2005_2000)
			},
			{
				_0002._0002_2002._0002(),
				new _0002_2000(_0002._0002_2002, _0003_2003_2001)
			},
			{
				_0002._0005_2003_2001._0002(),
				new _0002_2000(_0002._0005_2003_2001, _0006_2002)
			},
			{
				_0002._0006_2006_2000._0002(),
				new _0002_2000(_0002._0006_2006_2000, _0005_2002)
			},
			{
				_0002._0006_2007_2000._0002(),
				new _0002_2000(_0002._0006_2007_2000, _000E_200B)
			},
			{
				_0002._0005_2002_2001._0002(),
				new _0002_2000(_0002._0005_2002_2001, _000E_2000_2001)
			},
			{
				_0002._0008_2005._0002(),
				new _0002_2000(_0002._0008_2005, _0003_200A)
			},
			{
				_0002._0002_2003_2001._0002(),
				new _0002_2000(_0002._0002_2003_2001, _0005_2006)
			},
			{
				_0002._000E_200A._0002(),
				new _0002_2000(_0002._000E_200A, _0006_2007)
			},
			{
				_0002._000E_2006._0002(),
				new _0002_2000(_0002._000E_2006, _000F_2000_2001)
			},
			{
				_0002._0003_200B_2000._0002(),
				new _0002_2000(_0002._0003_200B_2000, global::_0002_2008._0002)
			},
			{
				_0002._000F_2001._0002(),
				new _0002_2000(_0002._000F_2001, _0002_2003_2000)
			},
			{
				_0002._000F_2002._0002(),
				new _0002_2000(_0002._000F_2002, _0008_2006)
			},
			{
				_0002._0008_2000_2000._0002(),
				new _0002_2000(_0002._0008_2000_2000, _0006_2003_2001)
			},
			{
				_0002._0006._0002(),
				new _0002_2000(_0002._0006, _0008_200B_2000)
			},
			{
				_0002._0008_2003_2001._0002(),
				new _0002_2000(_0002._0008_2003_2001, _0002_2006)
			},
			{
				_0002._000E_2004._0002(),
				new _0002_2000(_0002._000E_2004, _0003_2007)
			},
			{
				_0002._0002_2006._0002(),
				new _0002_2000(_0002._0002_2006, _0008_2002_2001)
			},
			{
				_0002._0006_200B._0002(),
				new _0002_2000(_0002._0006_200B, _0005_2000)
			},
			{
				_0002._000E_2002_2001._0002(),
				new _0002_2000(_0002._000E_2002_2001, _0008_200A_2000)
			},
			{
				_0002._0005_2000._0002(),
				new _0002_2000(_0002._0005_2000, _000F_2002_2001)
			},
			{
				_0002._0008_2006._0002(),
				new _0002_2000(_0002._0008_2006, _0006_2004)
			},
			{
				_0002._0008_2007._0002(),
				new _0002_2000(_0002._0008_2007, _000F_200A_2000)
			},
			{
				_0002._0003_2002._0002(),
				new _0002_2000(_0002._0003_2002, _0008_2008_2000)
			},
			{
				_0002._0002_2000_2001._0002(),
				new _0002_2000(_0002._0002_2000_2001, _0002_200A_2000)
			},
			{
				_0002._0005_2005_2000._0002(),
				new _0002_2000(_0002._0005_2005_2000, _0005_200B_2000)
			},
			{
				_0002._0008_2000._0002(),
				new _0002_2000(_0002._0008_2000, _0005_2008)
			},
			{
				_0002._0005_2008._0002(),
				new _0002_2000(_0002._0005_2008, _0005_2003_2000)
			},
			{
				_0002._0002_2009_2000._0002(),
				new _0002_2000(_0002._0002_2009_2000, _0006_2008_2000)
			},
			{
				_0002._0005_2003_2000._0002(),
				new _0002_2000(_0002._0005_2003_2000, _000E_2007_2000)
			},
			{
				_0002._0006_2001._0002(),
				new _0002_2000(_0002._0006_2001, _0006_200A_2000)
			},
			{
				_0002._0006_2007._0002(),
				new _0002_2000(_0002._0006_2007, _0006_2000_2001)
			},
			{
				_0002._000F_2003_2001._0002(),
				new _0002_2000(_0002._000F_2003_2001, _0002_2001_2001)
			},
			{
				_0002._0008_2004._0002(),
				new _0002_2000(_0002._0008_2004, _0003_200A_2000)
			},
			{
				_0002._000F_2003._0002(),
				new _0002_2000(_0002._000F_2003, _0008_2001_2000)
			},
			{
				_0002._000F._0002(),
				new _0002_2000(_0002._000F, _0008_2005)
			},
			{
				_0002._0005_2007._0002(),
				new _0002_2000(_0002._0005_2007, _0006_2006)
			},
			{
				_0002._000F_2000_2001._0002(),
				new _0002_2000(_0002._000F_2000_2001, _0008_2006_2000)
			},
			{
				_0002._0006_2005._0002(),
				new _0002_2000(_0002._0006_2005, _0003_2000_2001)
			},
			{
				_0002._0005_2000_2001._0002(),
				new _0002_2000(_0002._0005_2000_2001, _000F_2002_2000)
			},
			{
				_0002._000E_2008_2000._0002(),
				new _0002_2000(_0002._000E_2008_2000, _0008_2000_2000)
			},
			{
				_0002._0008_2001_2000._0002(),
				new _0002_2000(_0002._0008_2001_2000, _0006_2006_2000)
			},
			{
				_0002._0003_2005_2001._0002(),
				new _0002_2000(_0002._0003_2005_2001, _000F_2002)
			},
			{
				_0002._0003_2004_2001._0002(),
				new _0002_2000(_0002._0003_2004_2001, _0008_2004)
			},
			{
				_0002._0006_2003._0002(),
				new _0002_2000(_0002._0006_2003, _000F_200B)
			},
			{
				_0002._0006_2009_2000._0002(),
				new _0002_2000(_0002._0006_2009_2000, _000E_200B_2000)
			},
			{
				_0002._000E_2009_2000._0002(),
				new _0002_2000(_0002._000E_2009_2000, _0002_2002_2001)
			},
			{
				_0002._0003_2002_2000._0002(),
				new _0002_2000(_0002._0003_2002_2000, _0006_2008)
			},
			{
				_0002._0006_2001_2000._0002(),
				new _0002_2000(_0002._0006_2001_2000, _0003_2000)
			},
			{
				_0002._0008_2002._0002(),
				new _0002_2000(_0002._0008_2002, _0002_2007_2000)
			},
			{
				_0002._0005_2004_2001._0002(),
				new _0002_2000(_0002._0005_2004_2001, _0003_200B)
			},
			{
				_0002._0005_2003._0002(),
				new _0002_2000(_0002._0005_2003, _0002_2004_2000)
			},
			{
				_0002._000E_2004_2000._0002(),
				new _0002_2000(_0002._000E_2004_2000, _0002_2003)
			},
			{
				_0002._0002_2001_2001._0002(),
				new _0002_2000(_0002._0002_2001_2001, _0008_2005_2000)
			},
			{
				_0002._0003_2001_2001._0002(),
				new _0002_2000(_0002._0003_2001_2001, _000E_2005)
			},
			{
				_0002._000F_2004_2000._0002(),
				new _0002_2000(_0002._000F_2004_2000, _000F_2005)
			},
			{
				_0002._0006_2004_2001._0002(),
				new _0002_2000(_0002._0006_2004_2001, _0003_2002)
			},
			{
				_0002._000E_2004_2001._0002(),
				new _0002_2000(_0002._000E_2004_2001, _000E_2008_2000)
			},
			{
				_0002._0003_2008._0002(),
				new _0002_2000(_0002._0003_2008, _0008_2009)
			},
			{
				_0002._0006_2004_2000._0002(),
				new _0002_2000(_0002._0006_2004_2000, _000F_2009_2000)
			},
			{
				_0002._0002_2006_2000._0002(),
				new _0002_2000(_0002._0002_2006_2000, _0005_200A)
			},
			{
				_0002._0008._0002(),
				new _0002_2000(_0002._0008, _0003_2009)
			},
			{
				_0002._000E_2008._0002(),
				new _0002_2000(_0002._000E_2008, _0005_2003)
			},
			{
				_0002._0003_2006_2000._0002(),
				new _0002_2000(_0002._0003_2006_2000, _0003_2002_2000)
			},
			{
				_0002._0008_2003._0002(),
				new _0002_2000(_0002._0008_2003, _000F_2003)
			},
			{
				_0002._0003_200A_2000._0002(),
				new _0002_2000(_0002._0003_200A_2000, _0002_2005)
			},
			{
				_0002._0003_2002_2001._0002(),
				new _0002_2000(_0002._0003_2002_2001, _000F_200A)
			},
			{
				_0002._0008_2001_2001._0002(),
				new _0002_2000(_0002._0008_2001_2001, _000F_2006)
			},
			{
				_0002._000F_2005._0002(),
				new _0002_2000(_0002._000F_2005, _0005_2009_2000)
			},
			{
				_0002._000E_2002_2000._0002(),
				new _0002_2000(_0002._000E_2002_2000, _0003_2004_2000)
			},
			{
				_0002._0003_2007._0002(),
				new _0002_2000(_0002._0003_2007, _0006_200B)
			},
			{
				_0002._0005_200B._0002(),
				new _0002_2000(_0002._0005_200B, _0006_2005)
			},
			{
				_0002._000E_2002._0002(),
				new _0002_2000(_0002._000E_2002, _000E)
			},
			{
				_0002._0006_2001_2001._0002(),
				new _0002_2000(_0002._0006_2001_2001, _0003)
			},
			{
				_0002._0006_200A._0002(),
				new _0002_2000(_0002._0006_200A, _000F_2001_2001)
			},
			{
				_0002._0005_2006._0002(),
				new _0002_2000(_0002._0005_2006, _0002_2006_2000)
			},
			{
				_0002._0002_2007_2000._0002(),
				new _0002_2000(_0002._0002_2007_2000, _0006_200B_2000)
			},
			{
				_0002._0006_2000._0002(),
				new _0002_2000(_0002._0006_2000, _0002_2003_2001)
			},
			{
				_0002._000F_200A_2000._0002(),
				new _0002_2000(_0002._000F_200A_2000, _0005_2005)
			},
			{
				_0002._0005_2008_2000._0002(),
				new _0002_2000(_0002._0005_2008_2000, _0006_2005_2000)
			},
			{
				_0002._0006_2005_2000._0002(),
				new _0002_2000(_0002._0006_2005_2000, _000F_2003_2001)
			},
			{
				_0002._0008_2009_2000._0002(),
				new _0002_2000(_0002._0008_2009_2000, _0006_200A)
			},
			{
				_0002._0006_2008_2000._0002(),
				new _0002_2000(_0002._0006_2008_2000, _0008_2003_2000)
			},
			{
				_0002._0005_2001_2000._0002(),
				new _0002_2000(_0002._0005_2001_2000, _000E_200A)
			},
			{
				_0002._0006_2000_2001._0002(),
				new _0002_2000(_0002._0006_2000_2001, _000E_2001)
			},
			{
				_0002._0005_2001._0002(),
				new _0002_2000(_0002._0005_2001, _0008_2001_2001)
			},
			{
				_0002._0006_2002_2001._0002(),
				new _0002_2000(_0002._0006_2002_2001, _0005_2005_2000)
			},
			{
				_0002._0005_2004._0002(),
				new _0002_2000(_0002._0005_2004, _0005_200A_2000)
			},
			{
				_0002._0008_200B._0002(),
				new _0002_2000(_0002._0008_200B, _000E_2007)
			},
			{
				_0002._0003_2009_2000._0002(),
				new _0002_2000(_0002._0003_2009_2000, _0003_2001_2000)
			},
			{
				_0002._000E_2000_2001._0002(),
				new _0002_2000(_0002._000E_2000_2001, _000E_2005_2000)
			},
			{
				_0002._000E_2009._0002(),
				new _0002_2000(_0002._000E_2009, _0002_2001)
			},
			{
				_0002._000F_2009_2000._0002(),
				new _0002_2000(_0002._000F_2009_2000, _0003_2006_2000)
			},
			{
				_0002._0002_2008_2000._0002(),
				new _0002_2000(_0002._0002_2008_2000, _000E_2004_2000)
			},
			{
				_0002._0002_2005._0002(),
				new _0002_2000(_0002._0002_2005, _000F_2007)
			},
			{
				_0002._0002_2003_2000._0002(),
				new _0002_2000(_0002._0002_2003_2000, _000E_2004)
			},
			{
				_0002._000E_2006_2000._0002(),
				new _0002_2000(_0002._000E_2006_2000, _0002_2007)
			},
			{
				_0002._000F_200A._0002(),
				new _0002_2000(_0002._000F_200A, _000F_2004_2000)
			},
			{
				_0002._000E_2000._0002(),
				new _0002_2000(_0002._000E_2000, _0005_2001)
			},
			{
				_0002._0008_2001._0002(),
				new _0002_2000(_0002._0008_2001, _0008)
			}
		};
	}

	private static void _000F_200A(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type t = _0002._0002(num, _0003: true);
		_0002._0005(new _0006_2004(Marshal.SizeOf(t)));
	}

	private void _0003_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_0005(new _0006_2004(obj._0002() switch
		{
			16 => (!_0002) ? ((byte)((_0006_2004)obj)._0002()) : checked((byte)(uint)((_0006_2004)obj)._0002()), 
			26 => (!_0002) ? ((byte)((_000F_2004)obj)._0002()) : checked((byte)(ulong)((_000F_2004)obj)._0002()), 
			15 => (!_0002) ? ((byte)Convert.ToUInt64(((_000F_2002)obj)._0002())) : checked((byte)Convert.ToUInt64(((_000F_2002)obj)._0002())), 
			14 => (!_0002) ? ((byte)((_0003_2003)obj)._0002()) : checked((byte)((_0003_2003)obj)._0002()), 
			24 => (IntPtr.Size != 4) ? ((!_0002) ? ((byte)(long)((_000E_2006)obj)._0002()) : checked((byte)(ulong)(long)((_000E_2006)obj)._0002())) : ((!_0002) ? ((byte)(int)((_000E_2006)obj)._0002()) : checked((byte)(int)((_000E_2006)obj)._0002())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private void _0002(_0005_2008 _0002, _000E_2001 _0003)
	{
		switch (((_000E_2001)_0002)._0002())
		{
		case 13:
			((_0006_2008)_0002)._0002()._000E_2001_200A_2002_0002(_0003);
			break;
		case 17:
			this.m__000E_2002[((_000E_2009)_0002)._0002()]._000E_2001_200A_2002_0002(_0003);
			break;
		case 3:
		{
			_0008_2009 obj3 = (_0008_2009)_0002;
			FieldInfo fieldInfo = obj3._0002();
			_000E_2001 obj4 = global::_000E_2001._0002(_0003._000E_2001_200A_2002_0002(), fieldInfo.FieldType);
			fieldInfo.SetValue(obj3._0002(), obj4._000E_2001_200A_2002_0002());
			_0005_2008 obj5 = obj3._0002();
			if (obj5 != null && fieldInfo.DeclaringType.IsValueType)
			{
				this._0002(obj5, global::_000E_2001._0002(obj3._0002(), null));
			}
			break;
		}
		case 5:
		case 12:
		{
			_000F_2008 obj = (_000F_2008)_0002;
			_000E_2001 obj2 = global::_000E_2001._0002(_0003._000E_2001_200A_2002_0002(), obj._0002());
			obj._000F_2008_200A_2002_0002(obj2._000E_2001_200A_2002_0002());
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private static void _000E_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		if ((obj2._0002() != 14) ? (!global::_0002_2008._0005(obj2, obj)) : (!global::_0002_2008._0002(obj2, obj)))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private static void _0005_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766785));
	}

	private static void _0002_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0003);
	}

	private static bool _0003()
	{
		return false;
	}

	private static void _0002(ILGenerator _0002, Type _0003)
	{
		if (_0003.IsValueType || global::_000F_200A._0002(_0003).IsGenericParameter)
		{
			_0002.Emit(OpCodes.Unbox_Any, _0003);
		}
		else
		{
			global::_0002_2008._0003(_0002, _0003);
		}
	}

	private static void _0003_200B_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(ushort));
	}

	private static void _0005_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
	}

	private void _0002(_000E_2001 _0002)
	{
		if (((_0006_2004)this._0002())._0002() != 0)
		{
			this.m__0005_2000.Push(new _0008(this.m__0006_2000, this.m__0003_2003));
			this.m__0008 = false;
		}
		_0005();
	}

	private void _0002(_0008_2002 _0002)
	{
	}

	private static void _0002_2001_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0006(2);
	}

	private static void _0008_2008(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (!global::_0002_2008._0008(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private static void _0006_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_000E_2001 obj2 = _0002._0002();
		_0002._0005(_0002._0002(obj2, obj));
	}

	private _000E_2001[] _0002(object[] _0002)
	{
		_0008_2001[] array = this.m__0006_2001._0002();
		int num = array.Length;
		_000E_2001[] array2 = new _000E_2001[num];
		for (int i = 0; i < num; i++)
		{
			object obj = _0002[i];
			Type type = this._0002(array[i]._0002(), _0003: false);
			Type type2 = null;
			Type type3 = global::_000F_200A._0003(type);
			type2 = (((object)type3 != global::_000F_200A._0002 && !global::_000F_200A._0002(type3)) ? ((obj != null) ? obj.GetType() : type) : type);
			if (obj != null && !type.IsAssignableFrom(type2) && type.IsByRef && !type.GetElementType().IsAssignableFrom(type2))
			{
				throw new ArgumentException(string.Format(global::_000F_2004_2000._0002(-1506766577), type2, type));
			}
			array2[i] = global::_000E_2001._0002(obj, type2);
		}
		if (!this.m__0006_2001._0002() && this._0002(this.m__0006_2001._0002(), _0003: false).IsValueType)
		{
			_0006_2008 obj2 = new _0006_2008();
			obj2._0002(array2[0]);
			array2[0] = obj2;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j]._0002())
			{
				int num2 = j;
				_0006_2008 obj3 = new _0006_2008();
				obj3._0002(array2[j]);
				array2[num2] = obj3;
			}
		}
		return array2;
	}

	private bool _0002(MethodBase _0002, object _0003, ref object _0005, object[] _0008)
	{
		if (!_0002.IsStatic && _0002.Name == global::_000F_2004_2000._0002(-1506765826))
		{
			MethodInfo methodInfo = _0002 as MethodInfo;
			if ((object)methodInfo != null)
			{
				Type returnType = methodInfo.ReturnType;
				if (returnType.IsByRef)
				{
					returnType = returnType.GetElementType();
					int num = _0008.Length;
					if (num >= 1 && _0008[0] is int)
					{
						int[] array = new int[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = (int)_0008[i];
						}
						_0002_200A obj = new _0002_200A();
						obj._0002((Array)_0003);
						obj._0002(array);
						obj._0002(returnType);
						_0005 = obj;
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool _0002(MethodInfo _0002, _0006_2000_2000 _0003, Type[] _0005, out int _0008)
	{
		_0008 = 0;
		if (!_0002.IsGenericMethodDefinition)
		{
			return false;
		}
		ParameterInfo[] parameters = _0002.GetParameters();
		if (parameters.Length != _0003._0002().Length)
		{
			return false;
		}
		if (_0002.GetGenericArguments().Length != _0003._0003().Length)
		{
			return false;
		}
		for (int i = -1; i < parameters.Length; i++)
		{
			Type type = ((i == -1) ? _0002.ReturnType : parameters[i].ParameterType);
			if (_0005 != null && type.IsGenericParameter && (object)type.DeclaringMethod != null)
			{
				type = _0005[type.GenericParameterPosition] ?? type;
			}
			global::_0005_2000 obj = ((i == -1) ? _0003._0003() : _0003._0002()[i]);
			if (obj != null)
			{
				if (!this._0002(type, obj, out var num))
				{
					return false;
				}
				if (i >= 0)
				{
					_0008 += num;
				}
			}
		}
		return true;
	}

	private static void _0005_2006(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type elementType = _0002._0002(num, _0003: true);
		_000E_2001 obj = _0002._0002();
		_0006_2004 obj2 = obj as _0006_2004;
		int length;
		if (obj2 != null)
		{
			length = obj2._0002();
		}
		else
		{
			_000E_2006 obj3 = obj as _000E_2006;
			if (obj3 != null)
			{
				length = obj3._0002().ToInt32();
			}
			else
			{
				_0005_2007 obj4 = obj as _0005_2007;
				if (obj4 == null)
				{
					throw new Exception();
				}
				length = (int)obj4._0002().ToUInt32();
			}
		}
		Array array = Array.CreateInstance(elementType, length);
		_0002_2002 obj5 = new _0002_2002();
		obj5._0002(array);
		_0002._0005(obj5);
	}

	private static void _0008_2009(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(global::_000F_200A._0002);
	}

	private static void _0005_200B(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (!global::_0002_2008._0003(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private void _0002()
	{
		if (this.m__0006_2001._0002())
		{
			Type type;
			try
			{
				type = _0002(this.m__0006_2001._0002(), _0003: false);
			}
			catch (InvalidOperationException)
			{
				type = null;
			}
			if ((object)type != null)
			{
				RuntimeHelpers.RunClassConstructor(type.TypeHandle);
			}
		}
	}

	private void _0002_2000(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(this._0002(obj2, obj, _0002));
	}

	private static void _0008_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(long));
	}

	private static void _0008_2005_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0003(typeof(short));
	}

	private string _0002(_0003_2001 _0002)
	{
		Type type = this._0002(_0002._0002(), _0003: false);
		_0008_2001[] array = _0002._0002();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = this._0002(array[i]._0002(), _0003: false)?.FullName;
		}
		string text = string.Join(global::_000F_2004_2000._0002(-1506766399), array2);
		return type.FullName + global::_000F_2004_2000._0002(-1506765669) + _0002._0002() + global::_000F_2004_2000._0002(-1506766390) + text + global::_000F_2004_2000._0002(-1506766382);
	}

	private static void _0002_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(typeof(long));
	}

	private void _0008(_000E_2001 _0002)
	{
		int num = ((_0006_2004)_0002)._0002();
		MethodBase methodBase = this._0002(num);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num2 = parameters.Length;
		object[] array = new object[num2];
		Dictionary<int, _0005_2008> dictionary = new Dictionary<int, _0005_2008>();
		for (int num3 = num2 - 1; num3 >= 0; num3--)
		{
			_000E_2001 obj = this._0002();
			_0005_2008 obj2 = obj as _0005_2008;
			if (obj2 != null)
			{
				dictionary.Add(num3, obj2);
				obj = this._0002(obj2);
			}
			if ((object)obj._0002() != null)
			{
				obj = global::_000E_2001._0002(null, obj._0002())._000E_2001_200A_2002_0002(obj);
			}
			_000E_2001 obj3 = global::_000E_2001._0002(null, parameters[num3].ParameterType)._000E_2001_200A_2002_0002(obj);
			array[num3] = obj3._000E_2001_200A_2002_0002();
		}
		object obj4;
		try
		{
			obj4 = global::_0002_2008._0002(methodBase, null, array, _0008: false);
		}
		catch (TargetInvocationException ex)
		{
			Exception ex2 = ex.InnerException ?? ex;
			_0003(ex2);
			return;
		}
		foreach (KeyValuePair<int, _0005_2008> item in dictionary)
		{
			this._0002(item.Value, global::_000E_2001._0002(array[item.Key], null));
		}
		_0005(global::_000E_2001._0002(obj4, declaringType));
	}

	private static void _0003(ILGenerator _0002, Type _0003)
	{
		if ((object)_0003 != global::_000F_200A._0002)
		{
			_0002.Emit(OpCodes.Castclass, _0003);
		}
	}

	private void _0005(bool _0002)
	{
		_000E_2001 obj = this._0002();
		_000E_2001 obj2 = this._0002();
		_0005(_0005(obj2, obj, _0002));
	}

	private static void _0008_2006_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		_0002._0005(new _0006_2004(checked(obj._0002() switch
		{
			16 => (int)(uint)((_0006_2004)obj)._0002(), 
			26 => (int)(ulong)((_000F_2004)obj)._0002(), 
			15 => (int)Convert.ToUInt64(((_000F_2002)obj)._0002()), 
			14 => (int)((_0003_2003)obj)._0002(), 
			24 => (IntPtr.Size != 4) ? ((int)(ulong)(long)((_000E_2006)obj)._0002()) : ((int)(uint)(int)((_000E_2006)obj)._0002()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _000E_2004_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(2);
	}

	private static void _000F_2008_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(_0003);
	}

	private static void _0002_2002_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_000E_2001 obj = _0002._0002();
		if (_0006(_0002._0002(), obj))
		{
			uint num = ((_000E_2005)_0003)._0002();
			_0002._0002(num);
		}
	}

	private static void _000E_2001_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0008(_0002: false);
	}

	private static void _0005_2003_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766103));
	}

	private static void _000E_2002_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		throw new NotSupportedException(global::_000F_2004_2000._0002(-1506766661));
	}

	private static _000E_2001 _000E(_000E_2001 _0002, _000E_2001 _0003, bool _0005, bool _0008)
	{
		if (!_0008)
		{
			long num = ((_000F_2004)_0002)._0002();
			long num2 = ((_000F_2004)_0003)._0002();
			long num3 = ((!_0005) ? (num - num2) : checked(num - num2));
			return new _000F_2004(num3);
		}
		ulong num4 = (ulong)((_000F_2004)_0002)._0002();
		ulong num5 = (ulong)((_000F_2004)_0003)._0002();
		ulong num6 = ((!_0005) ? (num4 - num5) : checked(num4 - num5));
		return new _000F_2004((long)num6);
	}

	private static void _0002_2009_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005_2000(_0002: true);
	}

	private _000E_2001 _0003()
	{
		return this.m__0008_2004 ?? this.m__0003_2001.Peek();
	}

	private static void _000E_2000_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0005(global::_0002_2008.m__000E);
	}

	[DebuggerNonUserCode]
	private MethodBase _0002(int _0002)
	{
		global::_0005_2000 obj = this._0002(_0002);
		MethodBase methodBase = this._0002(_0002, obj);
		this._0002((MemberInfo)methodBase);
		return methodBase;
	}

	private long _0003()
	{
		return this.m__0003_2000._0002()._0005_2004_200A_2002_0003() + this.m__0002_2001;
	}

	private static void _0003_2000_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		object obj = _0002._0002()._000E_2001_200A_2002_0002();
		long num = _0002._0002();
		Array array = (Array)_0002._0002()._000E_2001_200A_2002_0002();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(int))
		{
			_000E_2001 obj2 = global::_000E_2001._0002(obj, typeof(int));
			((int[])array)[num] = (int)obj2._000E_2001_200A_2002_0002();
		}
		else if ((object)elementType == typeof(uint))
		{
			_000E_2001 obj3 = global::_000E_2001._0002(obj, typeof(uint));
			((uint[])array)[num] = (uint)obj3._000E_2001_200A_2002_0002();
		}
		else if (elementType.IsEnum)
		{
			_0002._0002(elementType, obj, num, array);
		}
		else
		{
			_0002._0002(typeof(int), obj, num, array);
		}
	}

	private bool _0002(_0008_2009 _0002)
	{
		if (!_0002._0002().IsInitOnly)
		{
			return true;
		}
		if (_0002._0002().IsStatic != this.m__0006_2001._0002())
		{
			return false;
		}
		if (this.m__0006_2001._0002() != global::_000F_2004_2000._0002(-1506765876) && this.m__0006_2001._0002() != global::_000F_2004_2000._0002(-1506765872))
		{
			return false;
		}
		return (object)this._0002(this.m__0006_2001._0002(), _0003: true) == _0002._0002().DeclaringType;
	}

	private _000E_2001 _0003(_000E_2001 _0002, _000E_2001 _0003)
	{
		if (_0002._0002() == 16)
		{
			if (_0003._0002() == 16)
			{
				int num = ((_0006_2004)_0002)._0002();
				int num2 = ((_0006_2004)_0003)._0002();
				return new _0006_2004(num | num2);
			}
			if (_0003._0002() == 15)
			{
				int num3 = ((_0006_2004)_0002)._0002();
				Type underlyingType = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType == typeof(long) || (object)underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num3 | num4);
				}
				int num5 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				return new _0006_2004(num3 | num5);
			}
		}
		if (_0002._0002() == 26)
		{
			if (_0003._0002() == 26)
			{
				long num6 = ((_000F_2004)_0002)._0002();
				long num7 = ((_000F_2004)_0003)._0002();
				return new _000F_2004(num6 | num7);
			}
			if (_0003._0002() == 15)
			{
				int num8 = ((_0006_2004)_0002)._0002();
				long num9 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
				return new _000F_2004(num8 | num9);
			}
		}
		if (_0002._0002() == 15)
		{
			if (_0003._0002() == 16)
			{
				int num10 = ((_0006_2004)_0003)._0002();
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType2 == typeof(long) || (object)underlyingType2 == typeof(ulong))
				{
					return new _000F_2004(Convert.ToInt64(_0003._000E_2001_200A_2002_0002()) | num10);
				}
				return new _0006_2004(Convert.ToInt32(_0002._000E_2001_200A_2002_0002()) | num10);
			}
			if (_0003._0002() == 26)
			{
				long num11 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
				long num12 = ((_000F_2004)_0003)._0002();
				return new _000F_2004(num11 | num12);
			}
			if (_0003._0002() == 15)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0002._000E_2001_200A_2002_0002().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0003._000E_2001_200A_2002_0002().GetType());
				if ((object)underlyingType3 == typeof(long) || (object)underlyingType3 == typeof(ulong) || (object)underlyingType4 == typeof(long) || (object)underlyingType4 == typeof(ulong))
				{
					long num13 = Convert.ToInt64(_0002._000E_2001_200A_2002_0002());
					long num14 = Convert.ToInt64(_0003._000E_2001_200A_2002_0002());
					return new _000F_2004(num13 | num14);
				}
				int num15 = Convert.ToInt32(_0002._000E_2001_200A_2002_0002());
				int num16 = Convert.ToInt32(_0003._000E_2001_200A_2002_0002());
				return new _0006_2004(num15 | num16);
			}
		}
		throw new InvalidOperationException();
	}

	private static string _0002(MethodBase _0002)
	{
		Type declaringType = _0002.DeclaringType;
		ParameterInfo[] parameters = _0002.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format(global::_000F_2004_2000._0002(-1506763181), parameterInfo.ParameterType, parameterInfo.Name);
		}
		string text = string.Join(global::_000F_2004_2000._0002(-1506766399), array);
		return declaringType.FullName + global::_000F_2004_2000._0002(-1506765669) + _0002.Name + global::_000F_2004_2000._0002(-1506766390) + text + global::_000F_2004_2000._0002(-1506766382);
	}

	private static void _0002_2003_2001(_0002_2008 _0002, _000E_2001 _0003)
	{
		int num = ((_0006_2004)_0003)._0002();
		Type type = _0002._0002(num, _0003: true);
		_000E_2001 obj = _0002._0002();
		if (_0002._0002(obj, type))
		{
			_0002._0005(obj);
			return;
		}
		throw new InvalidCastException();
	}

	private static void _0006_2007_2000(_0002_2008 _0002, _000E_2001 _0003)
	{
		_0002._0002(typeof(double));
	}
}
internal sealed class _0002_2009 : _000E_2007, IDisposable
{
	private SecureString m__0002 = new SecureString();

	public int _000E_2007_200A_2002_0002()
	{
		return this.m__0002.Length;
	}

	public _000E_2007 _000E_2007_200A_2002_0002()
	{
		return new _0002_2009();
	}

	public void _000E_2007_200A_2002_0002(int _0002, out byte _0003)
	{
		if (_0002 < 0 || _0002 >= this._000E_2007_200A_2002_0002())
		{
			throw new ArgumentOutOfRangeException();
		}
		IntPtr intPtr = IntPtr.Zero;
		char c = '\0';
		try
		{
			intPtr = Marshal.SecureStringToGlobalAllocUnicode(this.m__0002);
			c = (char)Marshal.ReadInt16(intPtr, _0002 * 2);
			_0003 = _0002_2009._0002(c, _0002);
		}
		finally
		{
			_000E_2008._0002(ref c);
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
		}
	}

	public void _000E_2007_200A_2002_0003(int _0002, ref byte _0003)
	{
		int num = this.m__0002.Length;
		while (true)
		{
			if (num > _0002)
			{
				this.m__0002.SetAt(_0002, _0002_2009._0002(_0003, _0002));
				return;
			}
			if (num == _0002)
			{
				break;
			}
			this.m__0002.AppendChar(_0002_2009._0002(0, num));
			num++;
		}
		this.m__0002.AppendChar(_0002_2009._0002(_0003, num));
	}

	private static char _0002(byte _0002, int _0003)
	{
		return (char)(_0002 + 1);
	}

	private static byte _0002(char _0002, int _0003)
	{
		return (byte)(_0002 - 1);
	}

	public void _000E_2007_200A_2002_0002()
	{
		this.m__0002.Clear();
	}

	public void Dispose()
	{
		this.m__0002.Dispose();
		this.m__0002 = null;
	}
}
internal sealed class _0002_200A : _000F_2008
{
	private new Array m__0002;

	private int[] _0003;

	public _0002_200A()
		: base(5)
	{
	}

	public new Array _0002()
	{
		return this.m__0002;
	}

	public void _0002(Array _0002)
	{
		this.m__0002 = _0002;
	}

	public new int[] _0002()
	{
		return _0003;
	}

	public void _0002(int[] _0002)
	{
		_0003 = _0002;
	}

	public override object _000F_2008_200A_2002_0002()
	{
		return this._0002().GetValue(this._0002());
	}

	public override void _000F_2008_200A_2002_0002(object _0002)
	{
		this._0002().SetValue(_0002, this._0002());
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0002_200A obj = new _0002_200A();
		obj._0002(this._0002());
		obj._0002(this._0002());
		obj._0002(base._0002());
		((_000E_2001)obj)._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 5)
		{
			_0002_200A obj = (_0002_200A)_0002;
			this._0002(obj._0002());
			this._0002(obj._0002());
			base._0002(((_000F_2008)obj)._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override bool _000F_2008_200A_2002_0002(_000F_2008 _0002)
	{
		_0002_200A obj = (_0002_200A)_0002;
		if (this._0002() == obj._0002())
		{
			return _0003_200A._0002(this._0002(), obj._0002());
		}
		return false;
	}
}
internal sealed class _0003 : _0002
{
	private string m__0002;

	public string _0002()
	{
		return this.m__0002;
	}

	public void _0002(string _0002)
	{
		this.m__0002 = _0002;
	}

	public override byte _0002_200A_2002_0002()
	{
		return 3;
	}
}
internal sealed class _0003_2000 : DeriveBytes
{
	private byte[] m__0002;

	private byte[] _0003;

	private int _0005;

	private readonly _0003_2000_2000 _0008 = new _0003_2000_2000();

	private readonly byte[] _0006;

	public _0003_2000(byte[] _0002, byte[] _0003, int _0005)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506765037));
		}
		if (_0003 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764826));
		}
		if (_0005 < 1)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506764823));
		}
		this.m__0002 = (byte[])_0002.Clone();
		this._0003 = (byte[])_0003.Clone();
		this._0005 = _0005;
		_0006 = new byte[_0008._0002()];
	}

	private void _0002(byte[] _0002, int _0003, byte[] _0005, byte[] _0008, int _0006)
	{
		if (_0002 != null)
		{
			this._0008._0002(_0002, 0, _0002.Length);
		}
		this._0008._0002(_0005, 0, _0005.Length);
		this._0008._0002(this._0006, 0);
		Buffer.BlockCopy(this._0006, 0, _0008, _0006, this._0006.Length);
		for (int i = 1; i < _0003; i++)
		{
			this._0008._0002(this._0006, 0, this._0006.Length);
			this._0008._0002(this._0006, 0);
			for (int j = 0; j < this._0006.Length; j++)
			{
				_0008[_0006 + j] ^= this._0006[j];
			}
		}
	}

	public override byte[] GetBytes(int _0002)
	{
		int num = _0008._0002();
		int num2 = (_0002 + num - 1) / num;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num2 * num];
		int num3 = 0;
		_0008._0002(this.m__0002);
		for (int i = 1; i <= num2; i++)
		{
			int num4 = 3;
			while (++array[num4] == 0)
			{
				num4--;
			}
			this._0002(_0003, _0005, array, array2, num3);
			num3 += num;
		}
		if (_0002 < array2.Length)
		{
			byte[] array3 = new byte[_0002];
			Buffer.BlockCopy(array2, 0, array3, 0, _0002);
			array2 = array3;
		}
		return array2;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
internal sealed class _0003_2000_2000
{
	private readonly _0005_2001 m__0002 = new _0005_2001();

	private readonly int _0003;

	private readonly int _0005;

	private _0005_2001 _0008;

	private _0005_2001 _0006;

	private readonly byte[] _000E;

	private readonly byte[] _000F;

	public _0003_2000_2000()
	{
		_0003 = this.m__0002._0003();
		_0005 = this.m__0002._0002();
		_000E = new byte[_0005];
		_000F = new byte[_0005 + _0003];
	}

	public void _0002(byte[] _0002)
	{
		this.m__0002._0003();
		int num = _0002.Length;
		if (num > _0005)
		{
			this.m__0002._0002(_0002, 0, num);
			this.m__0002._0002(_000E, 0);
			num = _0003;
		}
		else
		{
			Array.Copy(_0002, 0, _000E, 0, num);
		}
		Array.Clear(_000E, num, _0005 - num);
		Array.Copy(_000E, 0, _000F, 0, _0005);
		_0003_2000_2000._0002(_000E, _0005, (byte)54);
		_0003_2000_2000._0002(_000F, _0005, (byte)92);
		_0006 = this.m__0002._0002();
		_0006._0002(_000F, 0, _0005);
		this.m__0002._0002(_000E, 0, _000E.Length);
		_0008 = this.m__0002._0002();
	}

	public int _0002()
	{
		return _0003;
	}

	public void _0002(byte[] _0002, int _0003, int _0005)
	{
		this.m__0002._0002(_0002, _0003, _0005);
	}

	public int _0002(byte[] _0002, int _0003)
	{
		this.m__0002._0002(_000F, _0005);
		this.m__0002._0003(_0006);
		this.m__0002._0002(_000F, _0005, this.m__0002._0003());
		int result = this.m__0002._0002(_0002, _0003);
		Array.Clear(_000F, _0005, this._0003);
		this.m__0002._0003(_0008);
		return result;
	}

	private static void _0002(byte[] _0002, int _0003, byte _0005)
	{
		for (int i = 0; i < _0003; i++)
		{
			_0002[i] ^= _0005;
		}
	}
}
internal sealed class _0003_2001
{
	private int m__0002;

	private byte m__0003;

	private _000E_2000[] m__0005;

	private string _0008;

	private int _0006;

	private _0008_2001[] _000E;

	public _000E_2000[] _0002()
	{
		return this.m__0005;
	}

	public void _0002(_000E_2000[] _0002)
	{
		this.m__0005 = _0002;
	}

	public _0008_2001[] _0002()
	{
		return _000E;
	}

	public void _0002(_0008_2001[] _0002)
	{
		_000E = _0002;
	}

	public string _0002()
	{
		return _0008;
	}

	public void _0002(string _0002)
	{
		_0008 = _0002;
	}

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public int _0003()
	{
		return _0006;
	}

	public void _0003(int _0002)
	{
		_0006 = _0002;
	}

	public byte _0002()
	{
		return this.m__0003;
	}

	public void _0002(byte _0002)
	{
		this.m__0003 = _0002;
	}

	public bool _0002()
	{
		return (this._0002() & 1) != 0;
	}

	public bool _0003()
	{
		return (this._0002() & 0x10) != 0;
	}

	public bool _0005()
	{
		return (this._0002() & 2) != 0;
	}
}
internal static class _0003_2002
{
	private static readonly uint[] m__0002 = new uint[5] { 52200625u, 614125u, 7225u, 85u, 1u };

	public static byte[] _0002(string _0002)
	{
		if (_0002 == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(_0002.Length * 4 / 5);
		try
		{
			int num = 0;
			uint num2 = 0u;
			foreach (char c in _0002)
			{
				if (c == 'z' && num == 0)
				{
					_0003_2002._0002(memoryStream, num2, 0);
					continue;
				}
				if (c < '!' || c > 'u')
				{
					throw new Exception();
				}
				checked
				{
					num2 += (uint)(unchecked((long)_0003_2002.m__0002[num]) * unchecked((long)checked(unchecked((int)c) - 33)));
				}
				num++;
				if (num == 5)
				{
					_0003_2002._0002(memoryStream, num2, 0);
					num = 0;
					num2 = 0u;
				}
			}
			if (num == 1)
			{
				throw new Exception();
			}
			if (num > 1)
			{
				for (int j = num; j < 5; j++)
				{
					num2 = checked(num2 + 84u * _0003_2002.m__0002[j]);
				}
				_0003_2002._0002(memoryStream, num2, 5 - num);
			}
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private static void _0002(Stream _0002, uint _0003, int _0005)
	{
		_0002.WriteByte((byte)(_0003 >> 24));
		if (_0005 == 3)
		{
			return;
		}
		_0002.WriteByte((byte)(_0003 >> 16));
		if (_0005 != 2)
		{
			_0002.WriteByte((byte)(_0003 >> 8));
			if (_0005 != 1)
			{
				_0002.WriteByte((byte)_0003);
			}
		}
	}
}
internal static class _0003_2002_2000
{
}
internal sealed class _0003_2003 : _000E_2001
{
	private new double m__0002;

	public _0003_2003()
		: base(14)
	{
	}

	public new double _0002()
	{
		return this.m__0002;
	}

	public void _0002(double _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(Convert.ToDouble(_0002));
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0003_2003 obj = new _0003_2003();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 14:
			this._0002(((_0003_2003)_0002)._0002());
			break;
		case 0:
			this._0002(((_0008_2003)_0002)._0002());
			break;
		case 21:
			this._0002((int)((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002(((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002(((_0006_2004)_0002)._0002());
			break;
		case 26:
			this._0002(((_000F_2004)_0002)._0002());
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002((int)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002(((_000E_2005)_0002)._0002());
			break;
		case 23:
			this._0002(((_0002_2006)_0002)._0002());
			break;
		case 8:
			this._0002((double)((_000F_2007)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0003_2003_2000
{
	internal static void _0002()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6kA-!sAW)", (object[])null);
	}

	internal static void _0003()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>S!snu.", (object[])null);
	}

	internal static bool _0002()
	{
		return (bool)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>f!tYJ5", (object[])null);
	}

	internal static void _0005()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6kA2!tG>3", (object[])null);
	}

	internal static void _0008()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@%!t>82", (object[])null);
	}
}
internal sealed class _0003_2004_2000
{
	internal _0003_2004_2000()
	{
		_002Ector_2();
	}

	private void _002Ector_2()
	{
		object[] array = new object[1] { this };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>a\"+(%K", array);
	}
}
internal sealed class _0003_2005 : _000E_2001
{
	private new sbyte m__0002;

	public _0003_2005()
		: base(19)
	{
	}

	public new sbyte _0002()
	{
		return this.m__0002;
	}

	public void _0002(sbyte _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is byte)
		{
			this._0002((sbyte)(byte)_0002);
		}
		else if (_0002 is short)
		{
			this._0002((sbyte)(short)_0002);
		}
		else if (_0002 is int)
		{
			this._0002((sbyte)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((sbyte)(long)_0002);
		}
		else if (_0002 is ushort)
		{
			this._0002((sbyte)(ushort)_0002);
		}
		else if (_0002 is uint)
		{
			this._0002((sbyte)(uint)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((sbyte)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((sbyte)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((sbyte)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToSByte(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0003_2005 obj = new _0003_2005();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToSByte(((_0005_2002)_0002)._0002()));
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToSByte(((_000F_2002)_0002)._0002()));
			break;
		case 21:
			this._0002((sbyte)((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((sbyte)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((sbyte)((_0006_2004)_0002)._0002());
			break;
		case 25:
			this._0002((sbyte)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((sbyte)((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((sbyte)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((sbyte)((_0002_2006)_0002)._0002());
			break;
		case 8:
			this._0002(Convert.ToSByte(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((sbyte)(int)((_000E_2006)_0002)._0002());
			break;
		case 0:
			this._0002((sbyte)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((sbyte)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0003_2005_2000
{
	private sealed class _0002
	{
		private int m__0002;

		private int _0003;

		internal _0002()
		{
			_0002(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _0002()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_0002).Assembly)
			{
				return 2918384L;
			}
			if (!_0003_2005_2000._0002())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = ~(-(-(~(-(~(-(~(~(-(~-315906080))))))))));
			array[1] = -(~(~(-(-(~(-(~(~1312662025))))))));
			array[2] = -(~(~(-(-(~(~(-(~(-(~-2113208006))))))))));
			array[0] = -(~(~(-(~(-(~(-(~-1804222741))))))));
			int num = this.m__0002;
			int num2 = _0003;
			int num3 = ~(-(-(~(~(-(~(-(~1640531524))))))));
			int num4 = ~(-(-(~(~(-(~(-(~957401309))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0002(long _0002)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_0002).Assembly && _0003_2005_2000._0002())
			{
				int[] array = new int[4];
				array[1] = ~(-(-(~(~(-(~(-(~1312662021))))))));
				array[0] = ~(-(-(~(-(~(-(~(~(-(~-1804222738))))))))));
				array[2] = ~(-(~(-(-(~(-(~(~(-(~-2113208006))))))))));
				array[3] = -(~(-(~(-(~(~(-(~-315906079))))))));
				int num = -(~(~(-(-(~(-(~(~1640531528))))))));
				int num2 = (int)_0002;
				int num3 = (int)(_0002 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__0002 = num2;
				_0003 = num3;
			}
		}
	}

	private sealed class _0002_2000
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0002(_0003_2005_2000._0002(typeof(_0002_2000)), _0003_2005_2000._0003._0005(_0003_2005_2000._0003._0003(_0003_2005_2000._0002(typeof(_000F)), _0003_2005_2000._0002(typeof(_0005))), _0003_2005_2000._0003._0005(_0003_2005_2000._0002(typeof(_0008)) ^ -(~(~(-(-(~(-(~(~(-(~-304507016)))))))))), _000F._0002())));
		}
	}

	private static class _0003
	{
		internal static int _0002(int _0002, int _0003)
		{
			return _0002 ^ (_0003 - -(~(-(~(~(-(-(~(~278698983)))))))));
		}

		internal static int _0003(int _0002, int _0003)
		{
			return (_0002 - -(~(~(-(-(~(-(~(~(-(~-837012711))))))))))) ^ (_0003 + -(~(-(~(~(-(-(~(-(~(~-623636012)))))))))));
		}

		internal static int _0005(int _0002, int _0003)
		{
			return _0002 ^ ((_0003 - -(~(-(~(~(-(-(~(~588052349))))))))) ^ (_0002 - _0003));
		}
	}

	private sealed class _0005
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0005(_0003_2005_2000._0003._0003(_0003_2005_2000._0002(typeof(_0006)), _0003_2005_2000._0003._0005(_0003_2005_2000._0002(typeof(_0005)), _0003_2005_2000._0002(typeof(_000F)))), _0002_2000._0002());
		}
	}

	private sealed class _0006
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0002(_0003_2005_2000._0002(typeof(_0008)), _0003_2005_2000._0002(typeof(_000E)) ^ _0003_2005_2000._0003._0003(_0003_2005_2000._0002(typeof(_0006)), _0003_2005_2000._0003._0005(_0003_2005_2000._0002(typeof(_0002_2000)), _000E._0002())));
		}
	}

	private sealed class _0008
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0005(_0003_2005_2000._0003._0002(_0006._0002() ^ ~(-(-(~(~(-(~(-(~-527758449)))))))), _0003_2005_2000._0002(typeof(_000E))), _0003_2005_2000._0003._0003(_0003_2005_2000._0002(typeof(_0005)) ^ _0003_2005_2000._0002(typeof(_0002_2000)), ~(-(-(~(~(-(~(-(~-1469573945))))))))));
		}
	}

	private sealed class _000E
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0005(_0003_2005_2000._0002(typeof(_000E)), _0003_2005_2000._0003._0002(_0003_2005_2000._0002(typeof(_0005)), _0003_2005_2000._0003._0003(_0003_2005_2000._0002(typeof(_0006)), _0003_2005_2000._0003._0005(_0003_2005_2000._0002(typeof(_0008)), _0003_2005_2000._0003._0002(_0003_2005_2000._0002(typeof(_000F)), _0003_2005_2000._0002(typeof(_0002_2000)))))));
		}
	}

	private sealed class _000F
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2005_2000._0003._0003(_0003_2005_2000._0003._0003(_0008._0002(), _0003_2005_2000._0003._0002(_0003_2005_2000._0002(typeof(_000F)), _0006._0002())), _0003_2005_2000._0002(typeof(_0002_2000)));
		}
	}

	private static _0002 m__0002 = new _0002();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _0002()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0003_2005_2000).Assembly || !_0003_2005_2000._0002())
		{
			return 0L;
		}
		lock (_0003_2005_2000.m__0002)
		{
			long num = _0003_2005_2000.m__0002._0002();
			if (num == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = _0002(typeof(_0003_2005_2000));
				int num3 = _0005._0002();
				list.Add((byte)(num2 >> 8));
				list.Add((byte)(num3 >> 24));
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)num2);
				list.Add((byte)num3);
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= -4779091940427437442L;
				_0003_2005_2000.m__0002._0002(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _0002(byte[] _0002)
	{
		if ((object)Assembly.GetCallingAssembly() == typeof(_0003_2005_2000).Assembly && _0003_2005_2000._0002())
		{
			long num = _0003_2005_2000._0002();
			byte[] array = new byte[8]
			{
				(byte)num,
				(byte)(num >> 40),
				(byte)(num >> 56),
				(byte)(num >> 48),
				(byte)(num >> 32),
				(byte)(num >> 24),
				(byte)(num >> 16),
				(byte)(num >> 8)
			};
			int num2 = _0002.Length;
			for (int i = 0; i != num2; i++)
			{
				_0002[i] ^= (byte)(array[i & 7] + i);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0003_2005_2000).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _0002(Type _0002)
	{
		return _0002.MetadataToken;
	}
}
internal sealed class _0003_2006 : Stream
{
	private int m__0002;

	private int m__0003;

	private int m__0005;

	private Stream m__0008;

	private _0006 _0006;

	private int _000E;

	private bool _000F;

	private bool _0002_2000;

	private bool _0003_2000;

	private byte[] _0005_2000;

	private int _0008_2000;

	private byte[] _0006_2000;

	private int _000E_2000;

	private int _000F_2000;

	private int _0002_2001;

	private bool _0003_2001;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			_0008();
			return this.m__0002;
		}
	}

	public override long Position
	{
		get
		{
			return _000E * _0002_2001 + _000F_2000;
		}
		set
		{
			int num = (int)value / _0002_2001;
			_000F_2000 = (int)value % _0002_2001;
			if (_000E != num)
			{
				_000E = num;
				_0003_2000 = true;
				_000F = false;
			}
		}
	}

	public _0003_2006(Stream _0002, _0006 _0003)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764898));
		}
		if (_0003 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506765477));
		}
		this.m__0008 = _0002;
		_0006 = _0003;
		if (this.m__0008.Length < 4)
		{
			throw new InvalidOperationException();
		}
		this._0002();
	}

	private void _0002()
	{
		_0008_2000 = _0006._0006_200A_2002_0002();
		_0005_2000 = new byte[_0008_2000];
		_0002_2001 = _0006._0006_200A_2002_0003();
		_0006_2000 = new byte[_0002_2001];
	}

	public override long Seek(long _0002, SeekOrigin _0003)
	{
		switch (_0003)
		{
		case SeekOrigin.Begin:
			Position = _0002;
			break;
		case SeekOrigin.Current:
			Position += _0002;
			break;
		case SeekOrigin.End:
			Position = Length + _0002;
			break;
		}
		return Position;
	}

	public override void SetLength(long _0002)
	{
		throw new NotSupportedException();
	}

	public override int Read(byte[] _0002, int _0003, int _0005)
	{
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_2004_2000._0002(-1506765525));
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_2004_2000._0002(-1506765506));
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		if (_0005 == 0)
		{
			return 0;
		}
		int num = _0005;
		int num2 = _0003;
		if (_000F_2000 < _0002_2001)
		{
			this._0003();
			int num3 = _000E_2000 - _000F_2000;
			if (num3 > _0005)
			{
				Buffer.BlockCopy(_0006_2000, _000F_2000, _0002, _0003, _0005);
				_000F_2000 += _0005;
				return _0005;
			}
			Buffer.BlockCopy(_0006_2000, _000F_2000, _0002, _0003, num3);
			_000F_2000 = _000E_2000;
			if (_0002_2000)
			{
				return num3;
			}
			num -= num3;
			num2 += num3;
		}
		if (_0002_2000)
		{
			return _0005 - num;
		}
		while (num > 0)
		{
			this._0005();
			if (_0002_2000)
			{
				return _0005 - num;
			}
			int num4 = _000E_2000;
			if (num >= num4)
			{
				Buffer.BlockCopy(_0006_2000, 0, _0002, num2, num4);
				num2 += num4;
				num -= num4;
				_000F_2000 = num4;
				continue;
			}
			Buffer.BlockCopy(_0006_2000, 0, _0002, num2, num);
			_000F_2000 = num;
			return _0005;
		}
		return _0005;
	}

	private void _0003()
	{
		_0008();
		if (!_000F)
		{
			_000F = true;
			_0002_2000 = false;
			int num = _000E;
			if (_0003_2000)
			{
				this.m__0008.Position = 4 + num * _0008_2000;
				_0003_2000 = false;
			}
			_0002(num);
		}
	}

	private void _0005()
	{
		int num = _000E + 1;
		if (_0002(num))
		{
			_000E = num;
			_000F_2000 = 0;
		}
		_000F = true;
	}

	private bool _0002(int _0002)
	{
		int num;
		for (int i = 0; i < _0008_2000; i += num)
		{
			num = this.m__0008.Read(_0005_2000, i, _0008_2000 - i);
			if (num == 0)
			{
				if (i != 0)
				{
					throw new InvalidOperationException();
				}
				_0002_2000 = true;
				return false;
			}
		}
		_000E_2000 = _0006._0006_200A_2002_0002(_0005_2000, 0, _0008_2000, _0006_2000, 0, null);
		if (_0002 == this.m__0003)
		{
			_000E_2000 = this.m__0005;
		}
		return true;
	}

	private void _0008()
	{
		if (!_0003_2001)
		{
			if (this.m__0008.Position != 0L)
			{
				this.m__0008.Position = 0L;
				_0003_2000 = true;
			}
			this.m__0002 = _0002(this.m__0008)._0002;
			this.m__0003 = this.m__0002 / _0002_2001;
			this.m__0005 = this.m__0002 % _0002_2001;
			_0003_2001 = true;
		}
	}

	private static _0002_2000_2000 _0002(Stream _0002)
	{
		_0002_200B obj = new _0002_200B(_0002, 0);
		try
		{
			_0008_2002 obj2 = new _0008_2002(obj);
			try
			{
				return new _0002_2000_2000(obj2._0006());
			}
			finally
			{
				((IDisposable)obj2).Dispose();
			}
		}
		finally
		{
			((IDisposable)obj).Dispose();
		}
	}

	public override void Flush()
	{
	}

	public override void Write(byte[] _0002, int _0003, int _0005)
	{
		throw new NotSupportedException();
	}
}
internal static class _0003_2007<_0002>
{
	public static readonly _0002[] _0002 = new _0002[0];
}
internal sealed class _0003_2008 : _000E_2007, IDisposable
{
	private List<byte> m__0002 = new List<byte>();

	public int _000E_2007_200A_2002_0002()
	{
		return this.m__0002.Count;
	}

	public void _000E_2007_200A_2002_0002()
	{
		this.m__0002.Clear();
	}

	public _000E_2007 _000E_2007_200A_2002_0002()
	{
		return new _0003_2008();
	}

	public void Dispose()
	{
		this._000E_2007_200A_2002_0002();
		this.m__0002 = null;
	}

	public void _000E_2007_200A_2002_0002(int _0002, out byte _0003)
	{
		_0003 = this._0002(this.m__0002[_0002], _0002);
	}

	public void _000E_2007_200A_2002_0003(int _0002, ref byte _0003)
	{
		int num = this.m__0002.Count;
		while (true)
		{
			if (num > _0002)
			{
				this.m__0002[_0002] = this._0003(_0003, _0002);
				return;
			}
			if (num == _0002)
			{
				break;
			}
			this.m__0002.Add(this._0003(0, num));
			num++;
		}
		this.m__0002.Add(this._0003(_0003, num));
	}

	private byte _0002(byte _0002, int _0003)
	{
		throw new NotImplementedException();
	}

	private byte _0003(byte _0002, int _0003)
	{
		throw new NotImplementedException();
	}
}
internal sealed class _0003_2009 : _000F_2008
{
	private new Array m__0002;

	private long _0003;

	public _0003_2009()
		: base(12)
	{
	}

	public new Array _0002()
	{
		return this.m__0002;
	}

	public void _0002(Array _0002)
	{
		this.m__0002 = _0002;
	}

	public new long _0002()
	{
		return _0003;
	}

	public void _0002(long _0002)
	{
		_0003 = _0002;
	}

	public override object _000F_2008_200A_2002_0002()
	{
		return this.m__0002.GetValue(_0003);
	}

	public override void _000F_2008_200A_2002_0002(object _0002)
	{
		this.m__0002.SetValue(_0002, _0003);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 12)
		{
			_0003_2009 obj = (_0003_2009)_0002;
			this._0002(obj._0002());
			this._0002(obj._0002());
			base._0002(((_000F_2008)obj)._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0003_2009 obj = new _0003_2009();
		obj._0002(this.m__0002);
		obj._0002(_0003);
		obj._0002(base._0002());
		((_000E_2001)obj)._0002(base._0002());
		return obj;
	}

	public override bool _000F_2008_200A_2002_0002(_000F_2008 _0002)
	{
		_0003_2009 obj = (_0003_2009)_0002;
		if (this._0002() == obj._0002())
		{
			return this._0002() == obj._0002();
		}
		return false;
	}
}
internal static class _0003_200A
{
	public static bool _0002(int[] _0002, int[] _0003)
	{
		if (_0002 == _0003)
		{
			return true;
		}
		if (_0002 == null || _0003 == null)
		{
			return false;
		}
		if (_0002.Length != _0003.Length)
		{
			return false;
		}
		for (int i = 0; i < _0002.Length; i++)
		{
			if (_0002[i] != _0003[i])
			{
				return false;
			}
		}
		return true;
	}
}
internal static class _0005
{
	private static readonly bool m__0002;

	private static readonly bool m__0003;

	static _0005()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		_0005.m__0002 = oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version >= new Version(6, 0);
		if (_0002())
		{
			try
			{
				_0005.m__0003 = _0002(oSVersion);
			}
			catch
			{
				_0005.m__0003 = false;
			}
		}
	}

	public static bool _0002()
	{
		return _0005.m__0002;
	}

	public static bool _0003()
	{
		return _0005.m__0003;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002(OperatingSystem _0002)
	{
		if (_0002.Platform == PlatformID.Win32NT && _0002.Version < new Version(6, 2, 9200) && Process.GetCurrentProcess().SessionId == 0)
		{
			return false;
		}
		return true;
	}
}
internal sealed class _0005_2000
{
	private byte m__0002;

	private int _0003;

	private _0002 _0005;

	public byte _0002()
	{
		return this.m__0002;
	}

	public void _0002(byte _0002)
	{
		this.m__0002 = _0002;
	}

	public int _0002()
	{
		return _0003;
	}

	public void _0002(int _0002)
	{
		_0003 = _0002;
	}

	public _0002 _0002()
	{
		return _0005;
	}

	public void _0002(_0002 _0002)
	{
		_0005 = _0002;
	}
}
internal sealed class _0005_2000_2000 : _0002
{
	private _0005_2000 m__0002;

	private string _0003;

	private bool _0005;

	public _0005_2000 _0002()
	{
		return this.m__0002;
	}

	public void _0002(_0005_2000 _0002)
	{
		this.m__0002 = _0002;
	}

	public string _0002()
	{
		return _0003;
	}

	public void _0002(string _0002)
	{
		_0003 = _0002;
	}

	public bool _0002()
	{
		return _0005;
	}

	public void _0002(bool _0002)
	{
		_0005 = _0002;
	}

	public override byte _0002_200A_2002_0002()
	{
		return 4;
	}
}
internal sealed class _0005_2001
{
	private byte[] m__0002;

	private int m__0003;

	private long m__0005;

	private uint _0008;

	private uint _0006;

	private uint _000E;

	private uint _000F;

	private uint _0002_2000;

	private uint[] _0003_2000 = new uint[80];

	private int _0005_2000;

	public _0005_2001()
	{
		this.m__0002 = new byte[4];
		this._0003();
	}

	public _0005_2001(_0005_2001 _0002)
	{
		this._0002(_0002);
	}

	public void _0002(byte _0002)
	{
		this.m__0002[this.m__0003++] = _0002;
		if (this.m__0003 == this.m__0002.Length)
		{
			this._0002(this.m__0002, 0);
			this.m__0003 = 0;
		}
		this.m__0005++;
	}

	public void _0002(byte[] _0002, int _0003, int _0005)
	{
		_0005 = Math.Max(0, _0005);
		int i = 0;
		if (this.m__0003 != 0)
		{
			while (i < _0005)
			{
				this.m__0002[this.m__0003++] = _0002[_0003 + i++];
				if (this.m__0003 == 4)
				{
					this._0002(this.m__0002, 0);
					this.m__0003 = 0;
					break;
				}
			}
		}
		for (int num = ((_0005 - i) & -4) + i; i < num; i += 4)
		{
			this._0002(_0002, _0003 + i);
		}
		while (i < _0005)
		{
			this.m__0002[this.m__0003++] = _0002[_0003 + i++];
		}
		this.m__0005 += _0005;
	}

	public void _0002()
	{
		long num = this.m__0005 << 3;
		_0002(128);
		while (this.m__0003 != 0)
		{
			_0002(0);
		}
		_0002(num);
		_0005();
	}

	public int _0002()
	{
		return 64;
	}

	private void _0002(_0005_2001 _0002)
	{
		this.m__0002 = new byte[_0002.m__0002.Length];
		Buffer.BlockCopy(_0002.m__0002, 0, this.m__0002, 0, _0002.m__0002.Length);
		this.m__0003 = _0002.m__0003;
		this.m__0005 = _0002.m__0005;
		_0008 = _0002._0008;
		_0006 = _0002._0006;
		_000E = _0002._000E;
		_000F = _0002._000F;
		_0002_2000 = _0002._0002_2000;
		Array.Copy(_0002._0003_2000, 0, _0003_2000, 0, _0002._0003_2000.Length);
		_0005_2000 = _0002._0005_2000;
	}

	public int _0003()
	{
		return 20;
	}

	public void _0002(byte[] _0002, int _0003)
	{
		_0003_2000[_0005_2000] = _0005_2001._0002(_0002, _0003);
		if (++_0005_2000 == 16)
		{
			_0005();
		}
	}

	public void _0002(long _0002)
	{
		if (_0005_2000 > 14)
		{
			_0005();
		}
		_0003_2000[14] = (uint)((ulong)_0002 >> 32);
		_0003_2000[15] = (uint)_0002;
	}

	public int _0002(byte[] _0002, int _0003)
	{
		this._0002();
		_0005_2001._0002(_0008, _0002, _0003);
		_0005_2001._0002(_0006, _0002, _0003 + 4);
		_0005_2001._0002(_000E, _0002, _0003 + 8);
		_0005_2001._0002(_000F, _0002, _0003 + 12);
		_0005_2001._0002(_0002_2000, _0002, _0003 + 16);
		this._0003();
		return 20;
	}

	public void _0003()
	{
		this.m__0005 = 0L;
		this.m__0003 = 0;
		Array.Clear(this.m__0002, 0, this.m__0002.Length);
		_0008 = 1732584193u;
		_0006 = 4023233417u;
		_000E = 2562383102u;
		_000F = 271733878u;
		_0002_2000 = 3285377520u;
		_0005_2000 = 0;
		Array.Clear(_0003_2000, 0, _0003_2000.Length);
	}

	private static uint _0002(uint _0002, uint _0003, uint _0005)
	{
		return (_0002 & _0003) | (~_0002 & _0005);
	}

	private static uint _0003(uint _0002, uint _0003, uint _0005)
	{
		return _0002 ^ _0003 ^ _0005;
	}

	private static uint _0005(uint _0002, uint _0003, uint _0005)
	{
		return (_0002 & _0003) | (_0002 & _0005) | (_0003 & _0005);
	}

	private void _0005()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = _0003_2000[i - 3] ^ _0003_2000[i - 8] ^ _0003_2000[i - 14] ^ _0003_2000[i - 16];
			_0003_2000[i] = (num << 1) | (num >> 31);
		}
		uint num2 = _0008;
		uint num3 = _0006;
		uint num4 = _000E;
		uint num5 = _000F;
		uint num6 = _0002_2000;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + _0002(num3, num4, num5) + _0003_2000[num7++] + 1518500249;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + _0002(num2, num3, num4) + _0003_2000[num7++] + 1518500249;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + _0002(num6, num2, num3) + _0003_2000[num7++] + 1518500249;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + _0002(num5, num6, num2) + _0003_2000[num7++] + 1518500249;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + _0002(num4, num5, num6) + _0003_2000[num7++] + 1518500249;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + _0003(num3, num4, num5) + _0003_2000[num7++] + 1859775393;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + _0003(num2, num3, num4) + _0003_2000[num7++] + 1859775393;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + _0003(num6, num2, num3) + _0003_2000[num7++] + 1859775393;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + _0003(num5, num6, num2) + _0003_2000[num7++] + 1859775393;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + _0003(num4, num5, num6) + _0003_2000[num7++] + 1859775393;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + _0005(num3, num4, num5) + _0003_2000[num7++]) + -1894007588);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + _0005(num2, num3, num4) + _0003_2000[num7++]) + -1894007588);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + _0005(num6, num2, num3) + _0003_2000[num7++]) + -1894007588);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + _0005(num5, num6, num2) + _0003_2000[num7++]) + -1894007588);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + _0005(num4, num5, num6) + _0003_2000[num7++]) + -1894007588);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + _0003(num3, num4, num5) + _0003_2000[num7++]) + -899497514);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + _0003(num2, num3, num4) + _0003_2000[num7++]) + -899497514);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + _0003(num6, num2, num3) + _0003_2000[num7++]) + -899497514);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + _0003(num5, num6, num2) + _0003_2000[num7++]) + -899497514);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + _0003(num4, num5, num6) + _0003_2000[num7++]) + -899497514);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		_0008 += num2;
		_0006 += num3;
		_000E += num4;
		_000F += num5;
		_0002_2000 += num6;
		_0005_2000 = 0;
		Array.Clear(_0003_2000, 0, 16);
	}

	private static void _0002(uint _0002, byte[] _0003, int _0005)
	{
		_0003[_0005] = (byte)(_0002 >> 24);
		_0003[_0005 + 1] = (byte)(_0002 >> 16);
		_0003[_0005 + 2] = (byte)(_0002 >> 8);
		_0003[_0005 + 3] = (byte)_0002;
	}

	private static uint _0002(byte[] _0002, int _0003)
	{
		return (uint)((_0002[_0003] << 24) | (_0002[_0003 + 1] << 16) | (_0002[_0003 + 2] << 8) | _0002[_0003 + 3]);
	}

	public _0005_2001 _0002()
	{
		return new _0005_2001(this);
	}

	public void _0003(_0005_2001 _0002)
	{
		this._0002(_0002);
	}
}
internal static class _0005_2001_2000
{
	internal sealed class _0002 : global::_0006_2001_2000<int>, _0008_2001_2000, global::_0002_2002_2000<int>, _000F_2001_2000, _000E_2001_2000
	{
		private int m__0002;

		private int _0003;

		private int _0005;

		private int _0008;

		public int _0006;

		[DebuggerHidden]
		public _0002(int _0002)
		{
			this.m__0002 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0002_200A_2002_0002()
		{
		}

		void _000F_2001_2000._000F_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			this._0002_200A_2002_0002();
		}

		private bool _000E_2001_2000_200A_2002_0002()
		{
			switch (m__0002)
			{
			default:
				return false;
			case 0:
				m__0002 = -1;
				_0003 = -1497387237;
				m__0002 = 1;
				return true;
			case 1:
				m__0002 = -1;
				_0003 = _0008 ^ -189013616;
				m__0002 = 2;
				return true;
			case 2:
				m__0002 = -1;
				_0003 = -1788010553;
				m__0002 = 3;
				return true;
			case 3:
				m__0002 = -1;
				_0003 = _0008 ^ -189013616;
				m__0002 = 4;
				return true;
			case 4:
				m__0002 = -1;
				_0003 = 1600819614;
				m__0002 = 5;
				return true;
			case 5:
				m__0002 = -1;
				_0003 = _0008 ^ 0x69A4D3D6;
				m__0002 = 6;
				return true;
			case 6:
				m__0002 = -1;
				_0003 = 544574778;
				m__0002 = 7;
				return true;
			case 7:
				m__0002 = -1;
				_0003 = 662889479;
				m__0002 = 8;
				return true;
			case 8:
				m__0002 = -1;
				return false;
			}
		}

		bool _000E_2001_2000._000E_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in     
			return this._000E_2001_2000_200A_2002_0002();
		}

		[DebuggerHidden]
		private int _0002_200A_2002_0002()
		{
			return _0003;
		}

		int global::_0002_2002_2000<int>._000E_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_200A_2002_0002();
		}

		[DebuggerHidden]
		private void _0002_200A_2002_0003()
		{
			throw new NotSupportedException();
		}

		void _000E_2001_2000._000E_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			this._0002_200A_2002_0003();
		}

		[DebuggerHidden]
		private object _0002_200A_2002_0002()
		{
			return _0003;
		}

		object _000E_2001_2000._000E_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_200A_2002_0002();
		}

		[DebuggerHidden]
		private global::_0002_2002_2000<int> _0002_200A_2002_0002()
		{
			_0002 obj;
			if (m__0002 == -2 && _0005 == Thread.CurrentThread.ManagedThreadId)
			{
				m__0002 = 0;
				obj = this;
			}
			else
			{
				obj = new _0002(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		global::_0002_2002_2000<int> global::_0006_2001_2000<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_200A_2002_0002();
		}

		[DebuggerHidden]
		private _000E_2001_2000 _0002_200A_2002_0002()
		{
			return this._0002_200A_2002_0002();
		}

		_000E_2001_2000 _0008_2001_2000._0008_2001_2000_200A_2002_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in   
			return this._0002_200A_2002_0002();
		}
	}
}
internal sealed class _0005_2002 : _000E_2001
{
	private new bool m__0002;

	public _0005_2002()
		: base(20)
	{
	}

	public new bool _0002()
	{
		return this.m__0002;
	}

	public void _0002(bool _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(Convert.ToBoolean(_0002));
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(((_0005_2002)_0002)._0002());
			break;
		case 16:
			this._0002(Convert.ToBoolean(((_0006_2004)_0002)._0002()));
			break;
		case 26:
			this._0002(Convert.ToBoolean(((_000F_2004)_0002)._0002()));
			break;
		case 6:
			this._0002(Convert.ToBoolean(((_0002_2004)_0002)._0002()));
			break;
		case 10:
			this._0002(Convert.ToBoolean(((_000E_2005)_0002)._0002()));
			break;
		case 23:
			this._0002(Convert.ToBoolean(((_0002_2006)_0002)._0002()));
			break;
		case 25:
			this._0002(Convert.ToBoolean(((_0008_2005)_0002)._0002()));
			break;
		case 24:
			this._0002(Convert.ToBoolean(((_000E_2006)_0002)._0002()));
			break;
		case 7:
			this._0002(Convert.ToBoolean(((_0005_2007)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToBoolean(((_000F_2007)_0002)._0002()));
			break;
		case 19:
			this._0002(Convert.ToBoolean(((_0003_2005)_0002)._0002()));
			break;
		case 21:
			this._0002(Convert.ToBoolean(((_000E_2003)_0002)._0002()));
			break;
		case 15:
			this._0002(Convert.ToBoolean(((_000F_2002)_0002)._0002()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0005_2002 obj = new _0005_2002();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal sealed class _0005_2002_2000
{
	internal static byte[] _0002(byte[] _0002)
	{
		object[] array = new object[1] { _0002 };
		return (byte[])_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@N\"\"\"$K", array);
	}
}
internal sealed class _0005_2003
{
	private object m__0002 = new object();

	private Dictionary<_0006_2003, _0002_2003> _0003;

	internal _0002_2003 _0002(_0006_2003 _0002)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		lock (this.m__0002)
		{
			if (_0003 == null)
			{
				_0003 = new Dictionary<_0006_2003, _0002_2003>();
			}
			if (!_0003.TryGetValue(_0002, out var value))
			{
				value = new _0002_2003(_0002);
				_0003[_0002] = value;
			}
			return value;
		}
	}
}
internal static class _0005_2003_2000
{
	internal static bool _0002()
	{
		return (bool)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@m!tbP6", (object[])null);
	}
}
internal abstract class _0005_2004 : IDisposable
{
	public abstract bool _0005_2004_200A_2002_0002();

	public abstract bool _0005_2004_200A_2002_0003();

	public abstract bool _0005_2004_200A_2002_0005();

	public abstract long _0005_2004_200A_2002_0002();

	public abstract long _0005_2004_200A_2002_0003();

	public abstract void _0005_2004_200A_2002_0002(long _0002);

	public virtual void _0005_2004_200A_2002_0002()
	{
		_0005_2004_200A_2002_0002(_0002: true);
		GC.SuppressFinalize(this);
	}

	public void Dispose()
	{
		this._0005_2004_200A_2002_0002();
	}

	protected virtual void _0005_2004_200A_2002_0002(bool _0002)
	{
	}

	public abstract void _0005_2004_200A_2002_0003();

	public abstract long _0005_2004_200A_2002_0002(long _0002, int _0003);

	public abstract void _0005_2004_200A_2002_0003(long _0002);

	public abstract int _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005);

	public virtual int _0005_2004_200A_2002_0002()
	{
		byte[] array = new byte[1];
		if (this._0005_2004_200A_2002_0002(array, 0, 1) == 0)
		{
			return -1;
		}
		return array[0];
	}

	public abstract void _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005);

	public virtual void _0005_2004_200A_2002_0002(byte _0002)
	{
		this._0005_2004_200A_2002_0002(new byte[1] { _0002 }, 0, 1);
	}
}
internal sealed class _0005_2004_2000
{
	internal _0005_2004_2000()
	{
		_002Ector_2();
	}

	private void _002Ector_2()
	{
		object[] array = new object[1] { this };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k?T\"+L=O", array);
	}
}
internal static class _0005_2005
{
	private static readonly bool m__0002;

	static _0005_2005()
	{
		try
		{
			_0005_2005.m__0002 = (object)Type.GetType(_000F_2004_2000._0002(-1506765121)) != null;
		}
		catch
		{
			_0005_2005.m__0002 = false;
		}
	}

	public static bool _0002()
	{
		return _0005_2005.m__0002;
	}
}
internal static class _0005_2005_2000
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct a1
	{
	}

	private static _0003_200B _0008_2005_2000;

	[ThreadStatic]
	private static Stream _0006_2005_2000;

	internal static a1 a1/* Not supported: data(B4 A2 9D 8C 55 F1 B9 30 17 F0 C0 98 E2 F3 7C C8 09 30 8F 5D D5 3A 59 FC 3B F3 3E 29 4F 5E EC D9 E6 2F 0D C1 F5 16 0B E1 5F 2D 29 46 11 16 CD 88 FD 93 F7 C2 C9 1A E8 65 66 D9 93 FD AE 3F 1B 22 72 BA BA A5 77 D3 CE 49 C8 EC 7C 87 3E 0C AA 05 DF D5 68 24 4B 0E F6 42 A8 C8 1D D9 13 BB 2F B7 6F 84 34 B4 E0 11 1D 1B CD 57 5D F2 54 F6 CD AD 17 F6 16 63 9A 3E AF 66 44 C0 4A 9E E2 E1 3E C2) */;

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static _0002_2008 _000E_2005_2000()
	{
		if (_0008_2005_2000 == null)
		{
			_0008_2005_2000 = new _0003_200B();
		}
		return new _0002_2008(_0008_2005_2000);
	}

	public static string _0002()
	{
		return _000F_2004_2000._0002(-1506765236);
	}

	public static Stream _000F_2005_2000()
	{
		if (_0006_2005_2000 == null)
		{
			_0006_2005_2000 = _0008_2006._0002(typeof(_0005_2005_2000).Assembly.GetManifestResourceStream("7c8cb5598e724d34384cce7402b11f0e"), new byte[128]
			{
				180, 162, 157, 140, 85, 241, 185, 48, 23, 240,
				192, 152, 226, 243, 124, 200, 9, 48, 143, 93,
				213, 58, 89, 252, 59, 243, 62, 41, 79, 94,
				236, 217, 230, 47, 13, 193, 245, 22, 11, 225,
				95, 45, 41, 70, 17, 22, 205, 136, 253, 147,
				247, 194, 201, 26, 232, 101, 102, 217, 147, 253,
				174, 63, 27, 34, 114, 186, 186, 165, 119, 211,
				206, 73, 200, 236, 124, 135, 62, 12, 170, 5,
				223, 213, 104, 36, 75, 14, 246, 66, 168, 200,
				29, 217, 19, 187, 47, 183, 111, 132, 52, 180,
				224, 17, 29, 27, 205, 87, 93, 242, 84, 246,
				205, 173, 23, 246, 22, 99, 154, 62, 175, 102,
				68, 192, 74, 158, 226, 225, 62, 194
			}, _0002());
		}
		return _0006_2005_2000;
	}
}
internal sealed class _0005_2006 : _000E_2001
{
	private new MethodBase m__0002;

	public _0005_2006()
		: base(18)
	{
	}

	public new MethodBase _0002()
	{
		return this.m__0002;
	}

	public void _0002(MethodBase _0002)
	{
		this.m__0002 = _0002;
	}

	public new IntPtr _0002()
	{
		return this._0002().MethodHandle.GetFunctionPointer();
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return this._0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((MethodBase)_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 18)
		{
			this._0002(((_0005_2006)_0002)._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0005_2006 obj = new _0005_2006();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal sealed class _0005_2007 : _000E_2001
{
	private new UIntPtr m__0002;

	public _0005_2007()
		: base(7)
	{
	}

	public new UIntPtr _0002()
	{
		return this.m__0002;
	}

	public void _0002(UIntPtr _0002)
	{
		this.m__0002 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0005_2007 obj = new _0005_2007();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((UIntPtr)_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 7:
			this._0002(((_0005_2007)_0002)._0002());
			break;
		case 21:
			this._0002((UIntPtr)((_000E_2003)_0002)._0002());
			break;
		case 16:
			this._0002((UIntPtr)(ulong)((_0006_2004)_0002)._0002());
			break;
		case 25:
			this._0002((UIntPtr)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((UIntPtr)((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((UIntPtr)(ulong)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((UIntPtr)((_0002_2006)_0002)._0002());
			break;
		case 8:
			this._0002((UIntPtr)((_000F_2007)_0002)._0002());
			break;
		case 0:
			this._0002((UIntPtr)(ulong)((_0008_2003)_0002)._0002());
			break;
		case 15:
			this._0002(new UIntPtr(Convert.ToUInt64(((_000F_2002)_0002)._0002())));
			break;
		case 14:
			this._0002((UIntPtr)(ulong)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal abstract class _0005_2008 : _000E_2001
{
	public _0005_2008(int _0002)
		: base(_0002)
	{
	}

	public override object _000E_2001_200A_2002_0002()
	{
		throw new InvalidOperationException();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		throw new InvalidOperationException();
	}
}
[_0005_2009]
internal sealed class _0005_2009 : Attribute
{
}
internal sealed class _0005_200A : _000E_2001
{
	private new string m__0002;

	public _0005_200A()
		: base(22)
	{
	}

	public new string _0002()
	{
		return this.m__0002;
	}

	public void _0002(string _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((string)_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 22:
			this._0002(((_0005_200A)_0002)._0002());
			break;
		case 8:
			this._0002((string)((_000F_2007)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0005_200A obj = new _0005_200A();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal interface _0006
{
	int _0006_200A_2002_0002();

	int _0006_200A_2002_0003();

	int _0006_200A_2002_0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E);
}
internal sealed class _0006_2000
{
	private _000F_2000 m__0002;

	private int m__0003;

	private int _0005;

	private int _0008;

	public void _0002(bool _0002, _000F_2000 _0003)
	{
		this.m__0002 = _0003;
		this.m__0003 = this.m__0002._0002()._0002();
		this._0002(_0006_2000._0002(this.m__0003, _0002));
		this._0003(_0006_2000._0003(this.m__0003, _0002));
	}

	public int _0002()
	{
		return _0005;
	}

	private void _0002(int _0002)
	{
		_0005 = _0002;
	}

	public int _0003()
	{
		return _0008;
	}

	private void _0003(int _0002)
	{
		_0008 = _0002;
	}

	private static int _0002(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 + 7) / 8;
		}
		return (_0002 - 1) / 8;
	}

	private static int _0003(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 - 1) / 8;
		}
		return (_0002 + 7) / 8;
	}

	public _0005_200B _0002(byte[] _0002, int _0003, int _0005)
	{
		return new _0005_200B(1, _0002, _0003, _0005);
	}

	public int _0002(_0005_200B _0002, byte[] _0003, int _0005)
	{
		int num = this._0003() - _0002._0008();
		Array.Clear(_0003, _0005, num);
		_0005 += num;
		_0002._0002(_0003, _0005);
		return this._0003();
	}

	public _0005_200B _0002(_0005_200B _0002)
	{
		return _0002._0002(this.m__0002._0003(), this.m__0002._0002());
	}
}
internal sealed class _0006_2000_2000 : _0002
{
	private byte m__0002;

	private _0005_2000 m__0003;

	private string _0005;

	private _0005_2000[] _0008;

	private _0005_2000[] _0006;

	private _0005_2000 _000E;

	public byte _0002()
	{
		return this.m__0002;
	}

	public void _0002(byte _0002)
	{
		this.m__0002 = _0002;
	}

	public bool _0002()
	{
		return (this._0002() & 1) != 0;
	}

	public bool _0003()
	{
		return (this._0002() & 2) != 0;
	}

	public _0005_2000 _0002()
	{
		return this.m__0003;
	}

	public void _0002(_0005_2000 _0002)
	{
		this.m__0003 = _0002;
	}

	public string _0002()
	{
		return _0005;
	}

	public void _0002(string _0002)
	{
		_0005 = _0002;
	}

	public _0005_2000[] _0002()
	{
		return _0008;
	}

	public void _0002(_0005_2000[] _0002)
	{
		_0008 = _0002;
	}

	public _0005_2000[] _0003()
	{
		return _0006;
	}

	public void _0003(_0005_2000[] _0002)
	{
		_0006 = _0002;
	}

	public _0005_2000 _0003()
	{
		return _000E;
	}

	public void _0003(_0005_2000 _0002)
	{
		_000E = _0002;
	}

	public override byte _0002_200A_2002_0002()
	{
		return 0;
	}
}
internal sealed class _0006_2001 : SymmetricAlgorithm
{
	private sealed class _0002 : ICryptoTransform, IDisposable
	{
		private byte[] m__0002;

		private bool _0003;

		public int InputBlockSize => 4;

		public int OutputBlockSize => 4;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public _0002(byte[] _0002, bool _0003)
		{
			this.m__0002 = _0002;
			this._0003 = _0003;
		}

		public void Dispose()
		{
		}

		public int TransformBlock(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006)
		{
			if (_0005 % 4 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 0; i < _0005; i += 4)
			{
				_0006_2001._0002(this.m__0002, _0002, _0003 + i, _0008, _0006 + i, this._0003);
			}
			return _0005;
		}

		public byte[] TransformFinalBlock(byte[] _0002, int _0003, int _0005)
		{
			byte[] array = new byte[_0005];
			TransformBlock(_0002, _0003, _0005, array, 0);
			return array;
		}
	}

	private static byte[] m__0002 = new byte[256]
	{
		163, 215, 9, 131, 248, 72, 246, 244, 179, 33,
		21, 120, 153, 177, 175, 249, 231, 45, 77, 138,
		206, 76, 202, 46, 82, 149, 217, 30, 78, 56,
		68, 40, 10, 223, 2, 160, 23, 241, 96, 104,
		18, 183, 122, 195, 233, 250, 61, 83, 150, 132,
		107, 186, 242, 99, 154, 25, 124, 174, 229, 245,
		247, 22, 106, 162, 57, 182, 123, 15, 193, 147,
		129, 27, 238, 180, 26, 234, 208, 145, 47, 184,
		85, 185, 218, 133, 63, 65, 191, 224, 90, 88,
		128, 95, 102, 11, 216, 144, 53, 213, 192, 167,
		51, 6, 101, 105, 69, 0, 148, 86, 109, 152,
		155, 118, 151, 252, 178, 194, 176, 254, 219, 32,
		225, 235, 214, 228, 221, 71, 74, 29, 66, 237,
		158, 110, 73, 60, 205, 67, 39, 210, 7, 212,
		222, 199, 103, 24, 137, 203, 48, 31, 141, 198,
		143, 170, 200, 116, 220, 201, 93, 92, 49, 164,
		112, 136, 97, 44, 159, 13, 43, 135, 80, 130,
		84, 100, 38, 125, 3, 64, 52, 75, 28, 115,
		209, 196, 253, 59, 204, 251, 127, 171, 230, 62,
		91, 165, 173, 4, 35, 156, 20, 81, 34, 240,
		41, 121, 113, 126, 255, 140, 14, 226, 12, 239,
		188, 114, 117, 111, 55, 161, 236, 211, 142, 98,
		139, 134, 16, 232, 8, 119, 17, 190, 146, 79,
		36, 197, 50, 54, 157, 207, 243, 166, 187, 172,
		94, 108, 169, 19, 87, 37, 181, 227, 189, 168,
		58, 1, 5, 89, 42, 70
	};

	public _0006_2001()
	{
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(32, 32, 0)
		};
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(80, 80, 0)
		};
		BlockSizeValue = 32;
		KeySizeValue = 80;
		ModeValue = CipherMode.ECB;
		PaddingValue = PaddingMode.None;
	}

	public _0006_2001(byte[] _0002)
		: this()
	{
		Key = _0002 ?? throw new ArgumentNullException();
	}

	public override ICryptoTransform CreateDecryptor(byte[] _0002, byte[] _0003)
	{
		return new _0002(_0002, _0003: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] _0002, byte[] _0003)
	{
		return new _0002(_0002, _0003: true);
	}

	public override void GenerateIV()
	{
		throw new NotImplementedException();
	}

	public override void GenerateKey()
	{
		throw new NotImplementedException();
	}

	private static ushort _0002(byte[] _0002, int _0003, ushort _0005)
	{
		byte b = (byte)(_0005 >> 8);
		byte b2 = (byte)_0005;
		byte b3 = (byte)(_0006_2001.m__0002[b2 ^ _0002[4 * _0003 % 10]] ^ b);
		byte b4 = (byte)(_0006_2001.m__0002[b3 ^ _0002[(4 * _0003 + 1) % 10]] ^ b2);
		byte b5 = (byte)(_0006_2001.m__0002[b4 ^ _0002[(4 * _0003 + 2) % 10]] ^ b3);
		byte b6 = (byte)(_0006_2001.m__0002[b5 ^ _0002[(4 * _0003 + 3) % 10]] ^ b4);
		return (ushort)((b5 << 8) + b6);
	}

	private static void _0002(byte[] _0002, byte[] _0003, int _0005, byte[] _0008, int _0006, bool _000E)
	{
		int num;
		int num2;
		if (_000E)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)((_0003[_0005] << 8) + _0003[_0005 + 1]);
		ushort num4 = (ushort)((_0003[_0005 + 2] << 8) + _0003[_0005 + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 = (ushort)(num4 ^ (ushort)(_0006_2001._0002(_0002, num2, num3) ^ num2));
			num2 += num;
			num3 = (ushort)(num3 ^ (ushort)(_0006_2001._0002(_0002, num2, num4) ^ num2));
			num2 += num;
		}
		_0008[_0006] = (byte)(num4 >> 8);
		_0008[_0006 + 1] = (byte)num4;
		_0008[_0006 + 2] = (byte)(num3 >> 8);
		_0008[_0006 + 3] = (byte)num3;
	}
}
internal interface _0006_2001_2000<_0002> : _0008_2001_2000
{
	global::_0002_2002_2000<_0002> GetEnumerator();
}
internal sealed class _0006_2002 : _000E_2001
{
	private new char m__0002;

	public _0006_2002()
		: base(11)
	{
	}

	public new char _0002()
	{
		return this.m__0002;
	}

	public void _0002(char _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(Convert.ToChar(_0002));
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToChar(((_0005_2002)_0002)._0002()));
			break;
		case 16:
			this._0002((char)((_0006_2004)_0002)._0002());
			break;
		case 26:
			this._0002((char)((_000F_2004)_0002)._0002());
			break;
		case 6:
			this._0002((char)((_0002_2004)_0002)._0002());
			break;
		case 10:
			this._0002((char)((_000E_2005)_0002)._0002());
			break;
		case 23:
			this._0002((char)((_0002_2006)_0002)._0002());
			break;
		case 25:
			this._0002((char)((_0008_2005)_0002)._0002());
			break;
		case 24:
			this._0002((char)(int)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((char)(uint)((_0005_2007)_0002)._0002());
			break;
		case 8:
			this._0002(Convert.ToChar(((_000F_2007)_0002)._0002()));
			break;
		case 19:
			this._0002((char)((_0003_2005)_0002)._0002());
			break;
		case 21:
			this._0002((char)((_000E_2003)_0002)._0002());
			break;
		case 11:
			this._0002(((_0006_2002)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToChar(((_000F_2002)_0002)._0002()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0006_2002 obj = new _0006_2002();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal static class _0006_2002_2000
{
	internal static CreateApi _0002<CreateApi>(string _0002, string _0003)
	{
		object[] array = new object[2] { _0002, _0003 };
		Type[] array2 = new Type[1] { typeof(CreateApi) };
		return (CreateApi)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@^\"#'`U", array, array2, null, null);
	}
}
internal sealed class _0006_2003 : IEquatable<_0006_2003>
{
	private int m__0002 = 255;

	private int m__0003 = 12;

	private int m__0005 = 96;

	private int m__0008 = 10;

	private int m__0006 = 4;

	private static readonly _0006_2003 _000E = new _0006_2003();

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public int _0003()
	{
		return this.m__0003;
	}

	public void _0003(int _0002)
	{
		this.m__0003 = _0002;
	}

	public int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0002)
	{
		this.m__0005 = _0002;
	}

	public int _0008()
	{
		return this.m__0008;
	}

	public void _0008(int _0002)
	{
		this.m__0008 = _0002;
	}

	public int _0006()
	{
		return this.m__0006;
	}

	public void _0006(int _0002)
	{
		this.m__0006 = _0002;
	}

	public static _0006_2003 _0002()
	{
		return _000E;
	}

	public override bool Equals(object _0002)
	{
		return _0006_2003._0002(this, _0002 as _0006_2003);
	}

	public bool Equals(_0006_2003 _0002)
	{
		return _0006_2003._0002(this, _0002);
	}

	public static bool _0002(_0006_2003 _0002, _0006_2003 _0003)
	{
		if (_0002 == _0003)
		{
			return true;
		}
		if (_0002 == null || _0003 == null)
		{
			return false;
		}
		if (_0002._0002() == _0003._0002() && _0002._0003() == _0003._0003() && _0002._0005() == _0003._0005() && _0002._0008() == _0003._0008())
		{
			return _0002._0006() == _0003._0006();
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((((-8832819 + this._0002().GetHashCode()) * -1521134295 + _0003().GetHashCode()) * -1521134295 + _0005().GetHashCode()) * -1521134295 + _0008().GetHashCode()) * -1521134295 + _0006().GetHashCode();
	}
}
internal static class _0006_2003_2000
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _0002(IntPtr _0002);

	internal delegate bool _0003(int _0002, int _0003);

	public enum _0005 : uint
	{

	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct _0006
	{
		public uint _0002;

		public readonly string _0003;

		public readonly string _0005;

		public readonly string _0008;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public readonly byte[] _0006;

		public readonly IntPtr _000E;

		public readonly IntPtr _000F;

		public readonly IntPtr _0002_2000;

		public readonly IntPtr _0003_2000;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct _0008
	{
		public readonly IntPtr _0002;

		public readonly IntPtr _0003;

		public readonly uint _0005;

		public readonly uint _0008;
	}

	internal static _0002 _0002;

	[DllImport("kernel32", EntryPoint = "VirtualAlloc", SetLastError = true)]
	internal static extern IntPtr _0002(IntPtr _0002, int _0003, int _0005, int _0008);

	[DllImport("User32.Dll", EntryPoint = "GetClassName")]
	internal static extern void _0002(int _0002, StringBuilder _0003, int _0005);

	[DllImport("user32", EntryPoint = "GetWindowThreadProcessId")]
	internal static extern int _0002(int _0002, out int _0003);

	[DllImport("user32.Dll", EntryPoint = "EnumChildWindows")]
	internal static extern bool _0002(int _0002, _0003 _0003, int _0005);

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	internal static extern long _0002(int _0002, ref Rectangle _0003);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowText", SetLastError = true)]
	internal static extern int _0002(IntPtr _0002, StringBuilder _0003, int _0005);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	internal static extern IntPtr _0002(IntPtr _0002, uint _0003, IntPtr _0005, [Out] StringBuilder _0008);

	[DllImport("psapi", EntryPoint = "EnumProcesses")]
	internal static extern bool _0002([In][Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] IntPtr[] _0002, uint _0003, [MarshalAs(UnmanagedType.U4)] out uint _0005);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	internal static extern IntPtr _0002(_0005 _0002, [MarshalAs(UnmanagedType.Bool)] bool _0003, IntPtr _0005);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool _0002(IntPtr _0002);

	[DllImport("psapi.dll", EntryPoint = "GetModuleFileNameEx")]
	internal static extern uint _0002(IntPtr _0002, IntPtr _0003, [Out] StringBuilder _0005, [In][MarshalAs(UnmanagedType.U4)] int _0008);

	[DllImport("psapi.dll", EntryPoint = "EnumProcessModules", SetLastError = true)]
	internal static extern bool _0002(IntPtr _0002, [Out] IntPtr _0003, uint _0005, [MarshalAs(UnmanagedType.U4)] out uint _0008);

	[DllImport("psapi.dll", EntryPoint = "GetModuleBaseName")]
	internal static extern uint _0003(IntPtr _0002, IntPtr _0003, [Out] StringBuilder _0005, [In][MarshalAs(UnmanagedType.U4)] int _0008);

	[DllImport("kernel32", EntryPoint = "LoadLibraryA", SetLastError = true)]
	internal static extern IntPtr _0002([MarshalAs(UnmanagedType.VBByRefStr)] ref string _0002);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr _0002(IntPtr _0002, [MarshalAs(UnmanagedType.VBByRefStr)] ref string _0003);

	[DllImport("kernel32", EntryPoint = "VirtualProtect")]
	internal static extern bool _0002(IntPtr _0002, UIntPtr _0003, uint _0005, out uint _0008);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CopyFile")]
	internal static extern bool _0002(string _0002, string _0003, bool _0005);

	[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
	internal static extern bool _0002(IntPtr _0002, ref bool _0003);
}
internal sealed class _0006_2004 : _000E_2001
{
	private new int m__0002;

	public _0006_2004()
		: base(16)
	{
	}

	public _0006_2004(int _0002)
		: this()
	{
		this.m__0002 = _0002;
	}

	public new int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is long)
		{
			this._0002((int)(long)_0002);
		}
		else if (_0002 is ushort)
		{
			this._0002((ushort)_0002);
		}
		else if (_0002 is uint)
		{
			this._0002((int)(uint)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((int)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((int)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((int)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToInt32(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0006_2004 obj = new _0006_2004();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002(((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002(((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002(((_0008_2005)_0002)._0002());
			break;
		case 26:
			this._0002(Convert.ToInt32(((_000F_2004)_0002)._0002()));
			break;
		case 15:
			this._0002(Convert.ToInt32(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToInt32(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((int)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((int)(uint)((_0005_2007)_0002)._0002());
			break;
		case 0:
			this._0002((int)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((int)((_0003_2003)_0002)._0002());
			break;
		case 23:
			this._0002((int)((_0002_2006)_0002)._0002());
			break;
		case 10:
			this._0002((int)((_000E_2005)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0006_2004_2000
{
	private sealed class _0002
	{
		private readonly string m__0002;

		private volatile Assembly _0003;

		internal _0002(string _0002)
		{
			this.m__0002 = _0002;
		}

		internal Assembly _0002()
		{
			if ((object)_0003 == null)
			{
				lock (this)
				{
					if ((object)_0003 == null)
					{
						_0003 = _0002(this.m__0002);
					}
				}
			}
			return _0003;
		}

		private static Assembly _0002(string _0002)
		{
			return _000E_2004_2000._0002(_0002) ?? Assembly.Load(_0002);
		}
	}

	private static readonly Assembly m__0002;

	private static volatile Dictionary<string, _0002> m__0003;

	[ThreadStatic]
	private static bool _0005;

	static _0006_2004_2000()
	{
		_0006_2004_2000.m__0002 = typeof(_0006_2004_2000).Assembly;
	}

	internal static void _0002()
	{
		AppDomain.CurrentDomain.ResourceResolve += _0002;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0002(object _0002, ResolveEventArgs _0003)
	{
		if ((object)_0003.RequestingAssembly != _0006_2004_2000.m__0002)
		{
			return null;
		}
		if (_0005)
		{
			return null;
		}
		return _0006_2004_2000._0002(_0003.Name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0002(string _0002)
	{
		_0005 = true;
		try
		{
			_0003();
			if (!_0006_2004_2000.m__0003.TryGetValue(_0002, out var value))
			{
				return null;
			}
			return value._0002();
		}
		finally
		{
			_0005 = false;
		}
	}

	private static void _0003()
	{
		if (_0006_2004_2000.m__0003 != null)
		{
			return;
		}
		lock (_0006_2004_2000.m__0002)
		{
			if (_0006_2004_2000.m__0003 != null)
			{
				return;
			}
			string text = _000F_2004_2000._0002(-1506768951);
			string[] array = text.Split(':');
			int num = array.Length;
			Dictionary<string, _0002> dictionary = new Dictionary<string, _0002>(1, StringComparer.Ordinal);
			for (int i = 0; i != num; i++)
			{
				string text2 = array[i];
				string[] array2 = text2.Split('|');
				_0002 value = new _0002(array2[0]);
				int num2 = array2.Length;
				for (int j = 1; j != num2; j++)
				{
					string key = array2[j];
					dictionary.Add(key, value);
				}
			}
			_0006_2004_2000.m__0003 = dictionary;
		}
	}
}
internal static class _0006_2005
{
	private static readonly bool m__0002;

	static _0006_2005()
	{
		_0006_2005.m__0002 = _0002();
	}

	private static bool _0002()
	{
		try
		{
			if (Environment.Version.Major < 4)
			{
				return false;
			}
			Assembly assembly = typeof(_0002_2008).Assembly;
			Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
			bool result = false;
			object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
			foreach (object obj in customAttributes)
			{
				if (obj is AllowPartiallyTrustedCallersAttribute)
				{
					result = true;
					continue;
				}
				Type type = obj.GetType();
				if ((object)type.Assembly == assembly2 && _000F_2004_2000._0002(-1506765174).Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty(_000F_2004_2000._0002(-1506765441)).GetValue(obj, null) != 2)
				{
					return false;
				}
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool _0003()
	{
		return _0006_2005.m__0002;
	}
}
internal sealed class _0006_2006
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct _0002
	{
	}

	internal static readonly _0002 _0002/* Not supported: data(B1 84 1C 03 ED 5E 09 00 39 1C 00 00 55 00 00 00 01 00 00 00) */;
}
internal sealed class _0006_2007 : _0008_2007
{
	public _0006_2007(byte[] _0002, long _0003)
		: base(_0002, _0003)
	{
	}

	public byte[] _0002(_0005_2004 _0002, _000F_2006 _0003)
	{
		byte[] array = new byte[4];
		_0006_2007._0002(_0002, array, 0, array.Length);
		int num = _0008_2007._0002(base._0002(array, _0003: false), 0);
		int num2 = _0008_2007._0003(num);
		int value = num2 - 4;
		byte[] array2 = new byte[num2];
		_0006_2007._0002(_0002, array2, 4, value);
		Buffer.BlockCopy(array, 0, array2, 0, 4);
		byte[] src = base._0002(array2, _0003: false);
		byte[] array3 = new byte[num];
		Buffer.BlockCopy(src, 4, array3, 0, num);
		return array3;
	}

	public byte[] _0002(byte[] _0002)
	{
		byte[] array = base._0002(_0002, _0003: false);
		int num = _0008_2007._0002(array, 0);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, 4, array2, 0, num);
		return array2;
	}

	private static void _0002(_0005_2004 _0002, byte[] _0003, int _0005, int? _0008)
	{
		int num = _0008 ?? (_0003.Length - _0005);
		int num2;
		while ((num2 = _0002._0005_2004_200A_2002_0002(_0003, _0005, num)) > 0)
		{
			_0005 += num2;
			num -= num2;
		}
	}
}
internal sealed class _0006_2008 : _0005_2008
{
	private new _000E_2001 m__0002;

	public _0006_2008()
		: base(13)
	{
	}

	public new _000E_2001 _0002()
	{
		return this.m__0002;
	}

	public void _0002(_000E_2001 _0002)
	{
		this.m__0002 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 13)
		{
			this._0002(((_0006_2008)_0002)._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0006_2008 obj = new _0006_2008();
		obj._0002(_0002());
		obj._0002(base._0002());
		return obj;
	}
}
[_0005_2009]
internal sealed class _0006_2009 : Attribute
{
}
internal sealed class _0006_200A : _000E_2001
{
	private new object m__0002;

	public _0006_200A(object _0002)
		: base(4)
	{
		if (_0002 != null && !(_0002 is ValueType))
		{
			throw new ArgumentException();
		}
		this.m__0002 = _0002;
	}

	public new object _0002()
	{
		return this.m__0002;
	}

	public void _0002(object _0002)
	{
		if (_0002 != null && !(_0002 is ValueType))
		{
			throw new ArgumentException();
		}
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(_0002);
	}

	private new static bool _0002(Type _0002)
	{
		if (_0002.IsGenericType && _0002.Namespace == _000F_2004_2000._0002(-1506763252))
		{
			string name = _0002.Name;
			if (name == _000F_2004_2000._0002(-1506763247) || name == _000F_2004_2000._0002(-1506763034))
			{
				return false;
			}
		}
		return true;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 4:
		{
			object obj = ((_0006_200A)_0002)._0002();
			object obj2 = this._0002();
			if (obj2 != null && obj != null)
			{
				Type type = obj2.GetType();
				if (!type.IsPrimitive && !type.IsEnum && (object)type == obj.GetType() && _0006_200A._0002(type))
				{
					FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					foreach (FieldInfo fieldInfo in fields)
					{
						fieldInfo.SetValue(obj2, fieldInfo.GetValue(obj));
					}
					break;
				}
			}
			this._0002(obj);
			break;
		}
		case 8:
			this._0002(((_000F_2007)_0002)._0002());
			break;
		default:
			this._0002(_0002._000E_2001_200A_2002_0002());
			break;
		}
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0006_200A obj = new _0006_200A(this.m__0002);
		((_000E_2001)obj)._0002(base._0002());
		return obj;
	}
}
internal sealed class _0008 : _0002
{
	private string m__0002;

	private bool m__0003;

	private bool _0005;

	private _0005_2000[] _0008;

	private int _0006 = -1;

	private int _000E = -1;

	public string _0002()
	{
		return this.m__0002;
	}

	public void _0002(string _0002)
	{
		this.m__0002 = _0002;
	}

	public bool _0002()
	{
		return this.m__0003;
	}

	public void _0002(bool _0002)
	{
		this.m__0003 = _0002;
	}

	public bool _0003()
	{
		return _0005;
	}

	public void _0003(bool _0002)
	{
		_0005 = _0002;
	}

	public _0005_2000[] _0002()
	{
		return _0008;
	}

	public void _0002(_0005_2000[] _0002)
	{
		_0008 = _0002;
	}

	public int _0002()
	{
		return _0006;
	}

	public void _0002(int _0002)
	{
		_0006 = _0002;
	}

	public int _0003()
	{
		return _000E;
	}

	public void _0003(int _0002)
	{
		_000E = _0002;
	}

	public override byte _0002_200A_2002_0002()
	{
		return 1;
	}
}
internal sealed class _0008_2000 : _0006, IDisposable
{
	private sealed class _0002
	{
		public bool _0002;

		public _0006 _0003;
	}

	private readonly _000F_2000 m__0002;

	private readonly bool m__0003;

	private readonly bool _0005;

	private readonly int _0008;

	private readonly int _0006;

	private _0002 _000E;

	private bool _000F;

	private readonly object _0002_2000 = new object();

	public _0008_2000(bool _0002, _000F_2000 _0003, bool _0005 = false)
	{
		this.m__0003 = _0002;
		this.m__0002 = _0003;
		this._0005 = _0005;
		this._0005 = true;
		int num = _0003._0002()._0002();
		_0008 = _0008_2000._0002(num, _0002);
		_0006 = _0008_2000._0003(num, _0002);
	}

	public bool _0002()
	{
		return this.m__0003;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0002()
	{
		return _0008;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0003()
	{
		return _0006;
	}

	private static int _0002(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 + 7) / 8;
		}
		return (_0002 - 1) / 8;
	}

	private static int _0003(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 - 1) / 8;
		}
		return (_0002 + 7) / 8;
	}

	public int _0006_200A_2002_0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E)
	{
		this._0003();
		_0002 obj = this._000E;
		try
		{
			return obj._0003._0006_200A_2002_0002(_0002, _0003, _0005, _0008, _0006, _000E);
		}
		catch when (obj._0002)
		{
			this._0002();
			obj = this._000E;
			return obj._0003._0006_200A_2002_0002(_0002, _0003, _0005, _0008, _0006, _000E);
		}
	}

	private void _0002()
	{
		lock (_0002_2000)
		{
			_0002 obj = _000E;
			if (obj._0002)
			{
				try
				{
					(obj._0003 as IDisposable)?.Dispose();
				}
				catch
				{
				}
				_0006 obj3 = _0008_2000_200A_2002_0002(this.m__0003, this.m__0002);
				if (obj3 == null)
				{
					throw new InvalidOperationException();
				}
				_000E = new _0002
				{
					_0002 = false,
					_0003 = obj3
				};
			}
		}
	}

	private void _0003()
	{
		if (_000F)
		{
			return;
		}
		lock (_0002_2000)
		{
			if (_000F)
			{
				return;
			}
			_0006 obj;
			if (!_0005 && (obj = _0008_2000_200A_2002_0003(this.m__0003, this.m__0002)) != null)
			{
				_000E = new _0002
				{
					_0002 = true,
					_0003 = obj
				};
			}
			else
			{
				obj = _0008_2000_200A_2002_0002(this.m__0003, this.m__0002);
				if (obj == null)
				{
					throw new InvalidOperationException();
				}
				_000E = new _0002
				{
					_0002 = false,
					_0003 = obj
				};
			}
			_000F = true;
		}
	}

	protected virtual _0006 _0008_2000_200A_2002_0002(bool _0002, _000F_2000 _0003)
	{
		return new _000E_2000_2000(_0002, _0003);
	}

	protected virtual _0006 _0008_2000_200A_2002_0003(bool _0002, _000F_2000 _0003)
	{
		return global::_000E._0002(_0002, _0003);
	}

	public void Dispose()
	{
		IDisposable disposable = _000E?._0003 as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
			_000E = null;
		}
	}
}
internal sealed class _0008_2000_2000 : _0002
{
	private int m__0002;

	private int m__0003;

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public int _0003()
	{
		return this.m__0003;
	}

	public void _0003(int _0002)
	{
		this.m__0003 = _0002;
	}

	public override byte _0002_200A_2002_0002()
	{
		return 2;
	}
}
internal sealed class _0008_2001
{
	private int m__0002;

	private bool _0003;

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public bool _0002()
	{
		return _0003;
	}

	public void _0002(bool _0002)
	{
		_0003 = _0002;
	}
}
internal interface _0008_2001_2000
{
	_000E_2001_2000 _0008_2001_2000_200A_2002_0002();
}
internal sealed class _0008_2002 : IDisposable
{
	private _0005_2004 m__0002;

	private byte[] m__0003;

	private Decoder m__0005;

	private byte[] m__0008;

	private char[] m__0006;

	private char[] _000E;

	private int _000F;

	private bool _0002_2000;

	private bool _0003_2000;

	private byte[] _0005_2000;

	private MemoryStream _0008_2000;

	private BinaryReader _0006_2000;

	public _0008_2002(_0005_2004 _0002)
		: this(_0002, new UTF8Encoding())
	{
	}

	private _0008_2002(_0005_2004 _0002, Encoding _0003)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0003 == null)
		{
			throw new ArgumentNullException();
		}
		if (!_0002._0005_2004_200A_2002_0002())
		{
			throw new ArgumentException();
		}
		this.m__0002 = _0002;
		this.m__0005 = _0003.GetDecoder();
		_000F = _0003.GetMaxCharCount(128);
		int num = _0003.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this.m__0003 = new byte[num];
		_000E = null;
		this.m__0008 = null;
		_0002_2000 = _0003 is UnicodeEncoding;
		_0003_2000 = this.m__0002 is _0008_2004;
	}

	public _0005_2004 _0002()
	{
		return this.m__0002;
	}

	public void _0002()
	{
		_0002(_0002: true);
	}

	private void _0002(bool _0002)
	{
		if (_0002)
		{
			_0005_2004 obj = this.m__0002;
			this.m__0002 = null;
			obj?._0005_2004_200A_2002_0002();
		}
		this.m__0002 = null;
		this.m__0003 = null;
		this.m__0005 = null;
		this.m__0008 = null;
		this.m__0006 = null;
		_000E = null;
	}

	private void _0008_2002_200A_2002_0003()
	{
		_0002(_0002: true);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in    
		this._0008_2002_200A_2002_0003();
	}

	public int _0002()
	{
		this._0005();
		if (!this.m__0002._0005_2004_200A_2002_0005())
		{
			return -1;
		}
		long num = this.m__0002._0005_2004_200A_2002_0003();
		int result = _0003();
		this.m__0002._0005_2004_200A_2002_0002(num);
		return result;
	}

	public int _0003()
	{
		this._0005();
		return this._0005();
	}

	public bool _0002()
	{
		this._0002(1);
		return this.m__0003[0] != 0;
	}

	public byte _0002()
	{
		this._0005();
		int num = this.m__0002._0005_2004_200A_2002_0002();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	public sbyte _0002()
	{
		this._0002(1);
		return (sbyte)this.m__0003[0];
	}

	public char _0002()
	{
		int num = _0003();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	private static decimal _0002(int _0002, int _0003, int _0005, int _0008)
	{
		bool isNegative = (_0008 & int.MinValue) != 0;
		byte scale = (byte)(_0008 >> 16);
		return new decimal(_0002, _0003, _0005, isNegative, scale);
	}

	internal static decimal _0002(byte[] _0002)
	{
		int num = _0002[0] | (_0002[1] << 8) | (_0002[2] << 16) | (_0002[3] << 24);
		int num2 = _0002[4] | (_0002[5] << 8) | (_0002[6] << 16) | (_0002[7] << 24);
		int num3 = _0002[8] | (_0002[9] << 8) | (_0002[10] << 16) | (_0002[11] << 24);
		int num4 = _0002[12] | (_0002[13] << 8) | (_0002[14] << 16) | (_0002[15] << 24);
		return _0008_2002._0002(num, num2, num3, num4);
	}

	public string _0002()
	{
		int num = 0;
		this._0005();
		int num2 = _0008();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (this.m__0008 == null)
		{
			this.m__0008 = new byte[128];
		}
		if (_000E == null)
		{
			_000E = new char[_000F];
		}
		StringBuilder stringBuilder = null;
		do
		{
			int num3 = ((num2 - num > 128) ? 128 : (num2 - num));
			int num4 = this.m__0002._0005_2004_200A_2002_0002(this.m__0008, 0, num3);
			if (num4 == 0)
			{
				throw new Exception();
			}
			int chars = this.m__0005.GetChars(this.m__0008, 0, num4, _000E, 0);
			if (num == 0 && num4 == num2)
			{
				return new string(_000E, 0, chars);
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num2);
			}
			stringBuilder.Append(_000E, 0, chars);
			num += num4;
		}
		while (num < num2);
		return stringBuilder.ToString();
	}

	public int _0002(char[] _0002, int _0003, int _0005)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764879), _000F_2004_2000._0002(-1506764924));
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		this._0005();
		return this._0003(_0002, _0003, _0005);
	}

	private int _0003(char[] _0002, int _0003, int _0005)
	{
		int num = 0;
		int num2 = 0;
		int num3 = _0005;
		if (this.m__0008 == null)
		{
			this.m__0008 = new byte[128];
		}
		while (num3 > 0)
		{
			num2 = num3;
			if (_0002_2000)
			{
				num2 <<= 1;
			}
			if (num2 > 128)
			{
				num2 = 128;
			}
			if (_0003_2000)
			{
				_0008_2004 obj = (_0008_2004)this.m__0002;
				int byteIndex = obj._0002();
				num2 = obj._0002(num2);
				if (num2 == 0)
				{
					return _0005 - num3;
				}
				num = this.m__0005.GetChars(obj._0002(), byteIndex, num2, _0002, _0003);
			}
			else
			{
				num2 = this.m__0002._0005_2004_200A_2002_0002(this.m__0008, 0, num2);
				if (num2 == 0)
				{
					return _0005 - num3;
				}
				num = this.m__0005.GetChars(this.m__0008, 0, num2, _0002, _0003);
			}
			num3 -= num;
			_0003 += num;
		}
		return _0005;
	}

	private int _0005()
	{
		int num = 0;
		int num2 = 0;
		long num3 = (num3 = 0L);
		if (this.m__0002._0005_2004_200A_2002_0005())
		{
			num3 = this.m__0002._0005_2004_200A_2002_0003();
		}
		if (this.m__0008 == null)
		{
			this.m__0008 = new byte[128];
		}
		if (this.m__0006 == null)
		{
			this.m__0006 = new char[1];
		}
		while (num == 0)
		{
			num2 = ((!_0002_2000) ? 1 : 2);
			int num4 = this.m__0002._0005_2004_200A_2002_0002();
			this.m__0008[0] = (byte)num4;
			if (num4 == -1)
			{
				num2 = 0;
			}
			if (num2 == 2)
			{
				num4 = this.m__0002._0005_2004_200A_2002_0002();
				this.m__0008[1] = (byte)num4;
				if (num4 == -1)
				{
					num2 = 1;
				}
			}
			if (num2 == 0)
			{
				return -1;
			}
			try
			{
				num = this.m__0005.GetChars(this.m__0008, 0, num2, this.m__0006, 0);
			}
			catch
			{
				if (this.m__0002._0005_2004_200A_2002_0005())
				{
					this.m__0002._0005_2004_200A_2002_0002(num3 - this.m__0002._0005_2004_200A_2002_0003(), 1);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return this.m__0006[0];
	}

	public char[] _0002(int _0002)
	{
		this._0005();
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[_0002];
		int num = _0003(array, 0, _0002);
		if (num != _0002)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	public int _0002(byte[] _0002, int _0003, int _0005)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		this._0005();
		return this.m__0002._0005_2004_200A_2002_0002(_0002, _0003, _0005);
	}

	private void _0005()
	{
		if (this.m__0002 == null)
		{
			throw new Exception();
		}
	}

	public byte[] _0002(int _0002)
	{
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this._0005();
		byte[] array = new byte[_0002];
		int num = 0;
		do
		{
			int num2 = this.m__0002._0005_2004_200A_2002_0002(array, num, _0002);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			_0002 -= num2;
		}
		while (_0002 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	private void _0002(int _0002)
	{
		this._0005();
		int num = 0;
		int num2 = 0;
		if (_0002 == 1)
		{
			num2 = this.m__0002._0005_2004_200A_2002_0002();
			if (num2 == -1)
			{
				throw new Exception();
			}
			this.m__0003[0] = (byte)num2;
			return;
		}
		do
		{
			num2 = this.m__0002._0005_2004_200A_2002_0002(this.m__0003, num, _0002 - num);
			if (num2 == 0)
			{
				throw new Exception();
			}
			num += num2;
		}
		while (num < _0002);
	}

	internal int _0008()
	{
		int num = 0;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 == 35)
			{
				throw new FormatException();
			}
			b = this._0002();
			num |= (b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80u) != 0);
		return num;
	}

	public int _0006()
	{
		if (_0003_2000)
		{
			return ((_0008_2004)this.m__0002)._0005();
		}
		this._0002(4);
		return (this.m__0003[1] << 8) | this.m__0003[0] | (this.m__0003[2] << 16) | (this.m__0003[3] << 24);
	}

	public uint _0002()
	{
		this._0002(4);
		return (uint)((this.m__0003[1] << 16) | this.m__0003[0] | (this.m__0003[2] << 24) | (this.m__0003[3] << 8));
	}

	public long _0002()
	{
		this._0002(8);
		byte[] array = this.m__0003;
		return (uint)((array[4] << 16) | (array[5] << 8) | array[3] | (array[0] << 24)) | ((long)((array[7] << 8) | (array[1] << 16) | (array[6] << 24) | array[2]) << 32);
	}

	public ulong _0002()
	{
		this._0002(8);
		byte[] array = this.m__0003;
		return (ulong)((uint)(array[2] | (array[3] << 24) | (array[6] << 8) | (array[0] << 16)) | ((long)((array[1] << 24) | array[7] | (array[4] << 8) | (array[5] << 16)) << 32));
	}

	public short _0002()
	{
		this._0002(2);
		byte[] array = this.m__0003;
		return (short)((array[1] << 8) | array[0]);
	}

	public ushort _0002()
	{
		this._0002(2);
		byte[] array = this.m__0003;
		return (ushort)((array[0] << 8) | array[1]);
	}

	private byte[] _0002()
	{
		byte[] array = _0005_2000;
		if (array == null)
		{
			array = (_0005_2000 = new byte[16]);
		}
		return array;
	}

	public float _0002()
	{
		this._0002(4);
		byte[] array = this.m__0003;
		byte[] array2 = this._0002();
		array2[0] = array[2];
		array2[1] = array[1];
		array2[3] = array[3];
		array2[2] = array[0];
		return this._0002(array2).ReadSingle();
	}

	public double _0002()
	{
		this._0002(8);
		byte[] array = this.m__0003;
		byte[] array2 = this._0002();
		array2[2] = array[3];
		array2[7] = array[2];
		array2[3] = array[0];
		array2[4] = array[7];
		array2[0] = array[1];
		array2[6] = array[4];
		array2[1] = array[6];
		array2[5] = array[5];
		return this._0002(array2).ReadDouble();
	}

	public decimal _0002()
	{
		this._0002(16);
		byte[] array = this.m__0003;
		byte[] array2 = this._0002();
		array2[2] = array[9];
		array2[11] = array[7];
		array2[8] = array[11];
		array2[3] = array[4];
		array2[13] = array[8];
		array2[1] = array[1];
		array2[5] = array[0];
		array2[0] = array[6];
		array2[12] = array[14];
		array2[15] = array[5];
		array2[4] = array[12];
		array2[6] = array[10];
		array2[9] = array[15];
		array2[14] = array[13];
		array2[10] = array[3];
		array2[7] = array[2];
		return _0008_2002._0002(array2);
	}

	private BinaryReader _0002(byte[] _0002)
	{
		MemoryStream memoryStream = _0008_2000;
		BinaryReader binaryReader = _0006_2000;
		if (memoryStream == null)
		{
			memoryStream = (_0008_2000 = new MemoryStream(8));
			binaryReader = (_0006_2000 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(_0002, 0, _0002.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}
}
internal static class _0008_2002_2000
{
	public delegate int _0002(long _0002);

	public delegate bool _0002_2000(IntPtr _0002, int[] _0003);

	public delegate bool _0003(string _0002, string _0003, IntPtr _0005, IntPtr _0008, bool _0006, uint _000E, IntPtr _000F, string _0002_2000, ref _0006_2003_2000._0006 _0003_2000, ref _0006_2003_2000._0008 _0005_2000);

	public delegate bool _0003_2000(IntPtr _0002, int _0003, byte[] _0005, int _0008, ref int _0006);

	public delegate bool _0005(IntPtr _0002, int[] _0003);

	public delegate int _0005_2000(IntPtr _0002, int _0003);

	public delegate int _0006(IntPtr _0002);

	public delegate bool _0008(IntPtr _0002, int _0003, ref int _0005, int _0008, ref int _0006);

	public delegate bool _000E(IntPtr _0002, int[] _0003);

	public delegate int _000F(IntPtr _0002, int _0003, int _0005, int _0008, int _0006);

	internal static readonly _0006 _0002;

	internal static readonly _0002_2000 _0003;

	internal static readonly _000E _0005;

	internal static readonly _0005 _0008;

	internal static readonly _000F _0006;

	internal static readonly _0003_2000 _000E;

	internal static readonly _0005_2000 _000F;

	internal static readonly _0003 _0002_2000;

	internal static readonly _0002 _0003_2000;

	internal static readonly _0008 _0005_2000;

	static _0008_2002_2000()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k?*\"\"jTS", (object[])null);
	}
}
internal sealed class _0008_2003 : _000E_2001
{
	private new float m__0002;

	public _0008_2003()
		: base(0)
	{
	}

	public new float _0002()
	{
		return this.m__0002;
	}

	public void _0002(float _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(Convert.ToSingle(_0002));
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0008_2003 obj = new _0008_2003();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 0:
			this._0002(((_0008_2003)_0002)._0002());
			break;
		case 21:
			this._0002((int)((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002(((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002(((_0006_2004)_0002)._0002());
			break;
		case 26:
			this._0002(((_000F_2004)_0002)._0002());
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002((int)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002(((_000E_2005)_0002)._0002());
			break;
		case 23:
			this._0002(((_0002_2006)_0002)._0002());
			break;
		case 14:
			this._0002((float)((_0003_2003)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToSingle(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002((float)((_000F_2007)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0008_2003_2000
{
	internal static void _0002()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>n!u_1?", (object[])null);
	}
}
internal sealed class _0008_2004 : _0005_2004, IDisposable
{
	private byte[] m__0002;

	private int m__0003;

	private int m__0005;

	private int _0008;

	private int _0006;

	private bool _000E;

	private bool _000F;

	private bool _0002_2000;

	private bool _0003_2000;

	public _0008_2004()
		: this(0)
	{
	}

	public _0008_2004(int _0002)
	{
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.m__0002 = new byte[_0002];
		_0006 = _0002;
		_000E = true;
		_000F = true;
		this.m__0003 = 0;
		_0002_2000 = true;
	}

	public _0008_2004(byte[] _0002)
		: this(_0002, _0003: true)
	{
	}

	public _0008_2004(byte[] _0002, bool _0003)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		this.m__0002 = _0002;
		_0008 = (_0006 = _0002.Length);
		_000F = _0003;
		this.m__0003 = 0;
		_0002_2000 = true;
	}

	public _0008_2004(byte[] _0002, int _0003, int _0005)
		: this(_0002, _0003, _0005, _0008: true)
	{
	}

	public _0008_2004(byte[] _0002, int _0003, int _0005, bool _0008)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		this.m__0002 = _0002;
		this.m__0003 = (this.m__0005 = _0003);
		this._0008 = (_0006 = _0003 + _0005);
		_000F = _0008;
		_000E = false;
		_0002_2000 = true;
	}

	public override bool _0005_2004_200A_2002_0002()
	{
		return _0002_2000;
	}

	public override bool _0005_2004_200A_2002_0005()
	{
		return _0002_2000;
	}

	public override bool _0005_2004_200A_2002_0003()
	{
		return _000F;
	}

	protected override void _0005_2004_200A_2002_0002(bool _0002)
	{
		if (!_0003_2000)
		{
			if (_0002)
			{
				_0002_2000 = false;
				_000F = false;
				_000E = false;
			}
			_0003_2000 = true;
		}
	}

	private bool _0002(int _0002)
	{
		if (_0002 < 0)
		{
			throw new IOException();
		}
		if (_0002 > _0006)
		{
			int num = _0002;
			if (num < 256)
			{
				num = 256;
			}
			if (num < _0006 * 2)
			{
				num = _0006 * 2;
			}
			this._0002(num);
			return true;
		}
		return false;
	}

	public override void _0005_2004_200A_2002_0003()
	{
	}

	internal byte[] _0002()
	{
		return this.m__0002;
	}

	internal void _0002(out int _0002, out int _0003)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		_0002 = this.m__0003;
		_0003 = _0008;
	}

	internal int _0002()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		return this.m__0005;
	}

	public int _0002(int _0002)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		int num = _0008 - this.m__0005;
		if (num > _0002)
		{
			num = _0002;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.m__0005 += num;
		return num;
	}

	public int _0003()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		return _0006 - this.m__0003;
	}

	public void _0002(int _0002)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (_0002 == _0006)
		{
			return;
		}
		if (!_000E)
		{
			throw new Exception();
		}
		if (_0002 < _0008)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002 > 0)
		{
			byte[] array = new byte[_0002];
			if (_0008 > 0)
			{
				Buffer.BlockCopy(this.m__0002, 0, array, 0, _0008);
			}
			this.m__0002 = array;
		}
		else
		{
			this.m__0002 = null;
		}
		_0006 = _0002;
	}

	public override long _0005_2004_200A_2002_0002()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		return _0008 - this.m__0003;
	}

	public override long _0005_2004_200A_2002_0003()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		return this.m__0005 - this.m__0003;
	}

	public override void _0005_2004_200A_2002_0002(long _0002)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.m__0005 = this.m__0003 + (int)_0002;
	}

	public override int _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		int num = _0008 - this.m__0005;
		if (num > _0005)
		{
			num = _0005;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				_0002[_0003 + num2] = this.m__0002[this.m__0005 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.m__0002, this.m__0005, _0002, _0003, num);
		}
		this.m__0005 += num;
		return num;
	}

	public override int _0005_2004_200A_2002_0002()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (this.m__0005 >= _0008)
		{
			return -1;
		}
		return this.m__0002[this.m__0005++];
	}

	public override long _0005_2004_200A_2002_0002(long _0002, int _0003)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (_0002 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (_0003)
		{
		case 0:
			if (_0002 < 0)
			{
				throw new IOException();
			}
			this.m__0005 = this.m__0003 + (int)_0002;
			break;
		case 1:
			if (_0002 + this.m__0005 < this.m__0003)
			{
				throw new IOException();
			}
			this.m__0005 += (int)_0002;
			break;
		case 2:
			if (_0008 + _0002 < this.m__0003)
			{
				throw new IOException();
			}
			this.m__0005 = _0008 + (int)_0002;
			break;
		default:
			throw new ArgumentException();
		}
		return this.m__0005;
	}

	public override void _0005_2004_200A_2002_0003(long _0002)
	{
		if (!_000F)
		{
			throw new Exception();
		}
		if (_0002 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002 < 0 || _0002 > int.MaxValue - this.m__0003)
		{
			throw new ArgumentOutOfRangeException();
		}
		int num = this.m__0003 + (int)_0002;
		if (!this._0002(num) && num > _0008)
		{
			Array.Clear(this.m__0002, _0008, num - _0008);
		}
		_0008 = num;
		if (this.m__0005 > num)
		{
			this.m__0005 = num;
		}
	}

	public byte[] _0003()
	{
		byte[] array = new byte[_0008 - this.m__0003];
		Buffer.BlockCopy(this.m__0002, this.m__0003, array, 0, _0008 - this.m__0003);
		return array;
	}

	public override void _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (!_000F)
		{
			throw new Exception();
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		int num = this.m__0005 + _0005;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > _0008)
		{
			bool flag = this.m__0005 > _0008;
			if (num > _0006 && this._0002(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.m__0002, _0008, num - _0008);
			}
			_0008 = num;
		}
		if (_0005 <= 8)
		{
			int num2 = _0005;
			while (--num2 >= 0)
			{
				this.m__0002[this.m__0005 + num2] = _0002[_0003 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(_0002, _0003, this.m__0002, this.m__0005, _0005);
		}
		this.m__0005 = num;
	}

	public override void _0005_2004_200A_2002_0002(byte _0002)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (!_000F)
		{
			throw new Exception();
		}
		if (this.m__0005 >= _0008)
		{
			int num = this.m__0005 + 1;
			bool flag = this.m__0005 > _0008;
			if (num >= _0006 && this._0002(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.m__0002, _0008, this.m__0005 - _0008);
			}
			_0008 = num;
		}
		this.m__0002[this.m__0005++] = _0002;
	}

	public void _0002(Stream _0002)
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		_0002.Write(this.m__0002, this.m__0003, _0008 - this.m__0003);
	}

	internal int _0005()
	{
		if (!_0002_2000)
		{
			throw new Exception();
		}
		int num = (this.m__0005 += 4);
		if (num > _0008)
		{
			this.m__0005 = _0008;
			throw new Exception();
		}
		return (this.m__0002[num - 1] << 24) | (this.m__0002[num - 2] << 16) | this.m__0002[num - 4] | (this.m__0002[num - 3] << 8);
	}
}
internal sealed class _0008_2004_2000
{
	public delegate bool _0002(int _0002);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private _0002 m__0002;

	private int m__0003;

	private Regex _0005;

	private Regex _0008;

	private Regex _0006;

	private void _0002(_0002 _0002)
	{
		_0002 obj = this.m__0002;
		_0002 obj2;
		do
		{
			obj2 = obj;
			_0002 value = (_0002)Delegate.Combine(obj2, _0002);
			obj = Interlocked.CompareExchange(ref this.m__0002, value, obj2);
		}
		while ((object)obj != obj2);
	}

	private void _0003(_0002 _0002)
	{
		_0002 obj = this.m__0002;
		_0002 obj2;
		do
		{
			obj2 = obj;
			_0002 value = (_0002)Delegate.Remove(obj2, _0002);
			obj = Interlocked.CompareExchange(ref this.m__0002, value, obj2);
		}
		while ((object)obj != obj2);
	}

	public void _0002(int _0002, Regex _0003, Regex _0005, Regex _0008, _0002 _0006)
	{
		object[] array = new object[6] { this, _0002, _0003, _0005, _0008, _0006 };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@t\"+gOR", array);
	}

	private bool _0002(int _0002, int _0003)
	{
		object[] array = new object[3] { this, _0002, _0003 };
		return (bool)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k?+\"+UCP", array);
	}
}
internal sealed class _0008_2005 : _000E_2001
{
	private new ushort m__0002;

	public _0008_2005()
		: base(25)
	{
	}

	public new ushort _0002()
	{
		return this.m__0002;
	}

	public void _0002(ushort _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is short)
		{
			this._0002((ushort)(short)_0002);
		}
		else if (_0002 is int)
		{
			this._0002((ushort)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((ushort)(long)_0002);
		}
		else if (_0002 is uint)
		{
			this._0002((ushort)(uint)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((ushort)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((ushort)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((ushort)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToUInt16(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0008_2005 obj = new _0008_2005();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((ushort)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((ushort)((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002((ushort)((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002(((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((ushort)((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((ushort)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((ushort)((_0002_2006)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToUInt16(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToUInt16(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((ushort)(int)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((ushort)(uint)((_0005_2007)_0002)._0002());
			break;
		case 0:
			this._0002((ushort)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((ushort)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0008_2006
{
	private static readonly _0005_200B m__0002 = _0005_200B._0003(65537uL);

	private static readonly _0005_2003 _0003 = new _0005_2003();

	public static Stream _0002(Stream _0002, byte[] _0003, string _0005)
	{
		byte[] array = Convert.FromBase64String(_0005);
		byte[] array2 = new byte[_0003.Length + array.Length];
		Buffer.BlockCopy(_0003, 0, array2, 0, _0003.Length);
		Buffer.BlockCopy(array, 0, array2, _0003.Length, array.Length);
		_0005_200B obj = new _0005_200B(1, array2);
		_000F_2000 obj2 = new _000F_2000(_0002: false, obj, _0008_2006.m__0002);
		_0002_2000 obj3 = new _0002_2000(new _0008_2000(_0002: false, obj2));
		_0006_2003 obj4 = new _0006_2003();
		obj4._0002(obj3._0006_200A_2002_0003());
		_0006_2003 obj5 = obj4;
		return new _000E_2002(new _0003_2006(_0002, obj3), obj5, _0008_2006._0003);
	}
}
internal abstract class _0008_2007
{
	private readonly SymmetricAlgorithm[] m__0002;

	public _0008_2007(byte[] _0002, long _0003)
		: this(_0002, _0008_2007._0002(_0003))
	{
	}

	public _0008_2007(byte[] _0002, byte[] _0003)
	{
		_0002_2001 obj = new _0002_2001(_0002, _0003, 1);
		SymmetricAlgorithm[] array = new SymmetricAlgorithm[5];
		for (int i = 0; i < 5; i++)
		{
			_000E_200B obj2 = new _000E_200B(new _0006_2001());
			obj2.Key = obj.GetBytes(obj2.KeySize / 8);
			obj2.IV = obj.GetBytes(obj2._0002() / 8);
			array[i] = obj2;
		}
		this.m__0002 = array;
	}

	protected static int _0002(int _0002)
	{
		return (_0002 + 3) / 4 * 4;
	}

	public static int _0003(int _0002)
	{
		return _0008_2007._0002(_0002 + 4);
	}

	protected static byte[] _0002(long _0002)
	{
		byte[] array = new byte[8];
		_0008_2007._0002(_0002, array, 0);
		return array;
	}

	protected static void _0002(long _0002, byte[] _0003, int _0005)
	{
		_0003[_0005] = (byte)_0002;
		_0003[_0005 + 1] = (byte)(_0002 >> 8);
		_0003[_0005 + 2] = (byte)(_0002 >> 16);
		_0003[_0005 + 3] = (byte)(_0002 >> 24);
		_0003[_0005 + 4] = (byte)(_0002 >> 32);
		_0003[_0005 + 5] = (byte)(_0002 >> 40);
		_0003[_0005 + 6] = (byte)(_0002 >> 48);
		_0003[_0005 + 7] = (byte)(_0002 >> 56);
	}

	protected static int _0002(byte[] _0002, int _0003)
	{
		return _0002[_0003] | (_0002[_0003 + 1] << 8) | (_0002[_0003 + 2] << 16) | (_0002[_0003 + 3] << 24);
	}

	protected static void _0002(int _0002, byte[] _0003, int _0005)
	{
		_0003[_0005] = (byte)_0002;
		_0003[_0005 + 1] = (byte)(_0002 >> 8);
		_0003[_0005 + 2] = (byte)(_0002 >> 16);
		_0003[_0005 + 3] = (byte)(_0002 >> 24);
	}

	protected byte[] _0002(byte[] _0002, bool _0003)
	{
		if (_0003)
		{
			SymmetricAlgorithm[] array = this.m__0002;
			foreach (SymmetricAlgorithm symmetricAlgorithm in array)
			{
				if (_0003)
				{
					using ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor();
					_0002 = cryptoTransform.TransformFinalBlock(_0002, 0, _0002.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform2 = symmetricAlgorithm.CreateDecryptor();
					_0002 = cryptoTransform2.TransformFinalBlock(_0002, 0, _0002.Length);
				}
				_0003 = !_0003;
			}
		}
		else
		{
			for (int num = 4; num >= 0; num--)
			{
				SymmetricAlgorithm symmetricAlgorithm2 = this.m__0002[num];
				if (_0003)
				{
					using ICryptoTransform cryptoTransform3 = symmetricAlgorithm2.CreateEncryptor();
					_0002 = cryptoTransform3.TransformFinalBlock(_0002, 0, _0002.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform4 = symmetricAlgorithm2.CreateDecryptor();
					_0002 = cryptoTransform4.TransformFinalBlock(_0002, 0, _0002.Length);
				}
				_0003 = !_0003;
			}
		}
		return _0002;
	}
}
internal static class _0008_2008
{
	public static _000E_2007 _0002()
	{
		return _0003() ?? new _0003_2008();
	}

	private static _000E_2007 _0003()
	{
		try
		{
			_0002_2009 obj = new _0002_2009();
			if (!_0002(obj))
			{
				obj.Dispose();
				return null;
			}
			return obj;
		}
		catch (Exception ex) when (!_0002(ex))
		{
			return null;
		}
	}

	private static bool _0002(Exception _0002)
	{
		if (!(_0002 is ThreadAbortException))
		{
			return _0002 is ThreadInterruptedException;
		}
		return true;
	}

	private static bool _0002(_000E_2007 _0002)
	{
		byte[] array = new byte[3] { 0, 130, 255 };
		for (int i = 0; i < array.Length; i++)
		{
			byte b = array[i];
			_0002._000E_2007_200A_2002_0003(i, ref b);
		}
		if (_0002._000E_2007_200A_2002_0002() != array.Length)
		{
			return false;
		}
		for (int j = 0; j < array.Length; j++)
		{
			_0002._000E_2007_200A_2002_0002(j, out var b2);
			if (b2 != array[j])
			{
				return false;
			}
		}
		_0002._000E_2007_200A_2002_0002();
		if (_0002._000E_2007_200A_2002_0002() != 0)
		{
			return false;
		}
		return true;
	}
}
internal sealed class _0008_2009 : _0005_2008
{
	private new object m__0002;

	private FieldInfo _0003;

	private _0005_2008 _0005;

	public _0008_2009(FieldInfo _0002, object _0003)
		: this()
	{
		this._0002(_0002);
		this._0002(_0003);
	}

	public _0008_2009(FieldInfo _0002, object _0003, _0005_2008 _0005)
		: this(_0002, _0003)
	{
		this._0002(_0005);
	}

	private _0008_2009()
		: base(3)
	{
	}

	public new object _0002()
	{
		return this.m__0002;
	}

	private void _0002(object _0002)
	{
		this.m__0002 = _0002;
	}

	public new FieldInfo _0002()
	{
		return _0003;
	}

	private void _0002(FieldInfo _0002)
	{
		_0003 = _0002;
	}

	public new _0005_2008 _0002()
	{
		return _0005;
	}

	private void _0002(_0005_2008 _0002)
	{
		_0005 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 3)
		{
			_0008_2009 obj = (_0008_2009)_0002;
			this._0002(obj._0002());
			this._0002(obj._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_0008_2009 obj = new _0008_2009();
		obj._0002(this._0002());
		obj._0002(this._0002());
		obj._0002(this._0002());
		((_000E_2001)obj)._0002(base._0002());
		return obj;
	}
}
internal sealed class _0008_200A
{
	private int m__0002;

	private int m__0003;

	private uint m__0005;

	private uint m__0008;

	private uint _0006;

	private uint _000E;

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public int _0003()
	{
		return this.m__0003;
	}

	public void _0003(int _0002)
	{
		this.m__0003 = _0002;
	}

	public uint _0002()
	{
		return this.m__0005;
	}

	public void _0002(uint _0002)
	{
		this.m__0005 = _0002;
	}

	public uint _0003()
	{
		return this.m__0008;
	}

	public void _0003(uint _0002)
	{
		this.m__0008 = _0002;
	}

	public uint _0005()
	{
		return _0006;
	}

	public void _0005(uint _0002)
	{
		_0006 = _0002;
	}

	public uint _0008()
	{
		return _000E;
	}

	public void _0008(uint _0002)
	{
		_000E = _0002;
	}
}
internal sealed class _000E : _0006, IDisposable
{
	private static bool m__0002 = true;

	protected _000F_2000_2000._0005 _0003;

	protected _000F_2000_2000._0003 _0005;

	protected int _0008;

	private int _0006;

	private int m__000E;

	private byte[] _000F;

	private byte[] _0002_2000;

	private bool _0003_2000;

	protected _000E(bool _0002, _000F_2000 _0003)
	{
		if (_0003 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764960));
		}
		int num = _0003._0002()._0002();
		_0008 = global::_000E._0002(num);
		this._0002(global::_000E._0002(num, _0002));
		this._0003(global::_000E._0003(num, _0002));
		_000F_2000_2000._0002(_000F_2000_2000._0002(out this._0003, _000F_2004_2000._0002(-1506764943), 0u));
		string text;
		byte[] array = _000E_200A_2002_0002(_0003, out text);
		_000F_2000_2000._0002(_000F_2000_2000._0002(this._0003, IntPtr.Zero, text, IntPtr.Zero, out _0005, array, array.Length, 64u));
	}

	public static _000E _0002(bool _0002, _000F_2000 _0003)
	{
		if (!global::_000E.m__0002)
		{
			return null;
		}
		if (!global::_0005._0003())
		{
			global::_000E.m__0002 = false;
			return null;
		}
		_000E obj = null;
		try
		{
			obj = new _000E(_0002, _0003);
			return obj;
		}
		catch
		{
			obj?.Dispose();
			global::_000E.m__0002 = false;
			return null;
		}
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0002()
	{
		return _0006;
	}

	private void _0002(int _0002)
	{
		_0006 = _0002;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0003()
	{
		return m__000E;
	}

	private void _0003(int _0002)
	{
		m__000E = _0002;
	}

	private static int _0002(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 + 7) / 8;
		}
		return (_0002 - 1) / 8;
	}

	private static int _0003(int _0002, bool _0003)
	{
		if (!_0003)
		{
			return (_0002 - 1) / 8;
		}
		return (_0002 + 7) / 8;
	}

	private static int _0002(int _0002)
	{
		return (_0002 + 7) / 8;
	}

	private void _0002()
	{
		if (!_0003_2000)
		{
			_000F = new byte[_0008];
			_0002_2000 = new byte[_0008];
			_0003_2000 = true;
		}
	}

	public virtual int _0006_200A_2002_0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E)
	{
		this._0002();
		byte[] array = _000F;
		int num = array.Length - _0005;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(_0002, _0003, array, num, _0005);
		_000F_2000_2000._0002(_000F_2000_2000._0002(this._0005, array, array.Length, IntPtr.Zero, _0002_2000, this._0008, out var num2, 1));
		int num3 = _0006_200A_2002_0003();
		int srcOffset = num2 - num3;
		Buffer.BlockCopy(_0002_2000, srcOffset, _0008, _0006, num3);
		return num3;
	}

	protected virtual byte[] _000E_200A_2002_0002(_000F_2000 _0002, out string _0003)
	{
		_0003 = _000F_2004_2000._0002(-1506765017);
		return global::_000E._0002(_0002);
	}

	protected static byte[] _0002(_000F_2000 _0002)
	{
		int num = Marshal.SizeOf(typeof(_000F_2000_2000._0002));
		byte[] array = new byte[num + _0002._0003()._0008() + _0002._0002()._0008()];
		global::_000E._0002(new _000F_2000_2000._0002
		{
			_0002 = 826364754u,
			_0003 = _0002._0002()._0002(),
			_0005 = _0002._0003()._0008(),
			_0008 = _0002._0002()._0008()
		}, array, 0);
		int num2 = num;
		num2 += _0002._0003()._0002(array, num2);
		num2 += _0002._0002()._0002(array, num2);
		return array;
	}

	protected static void _0002(_000F_2000_2000._0002 _0002, byte[] _0003, int _0005)
	{
		int num = Marshal.SizeOf((object)_0002);
		if (_0005 + num > _0003.Length)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506765005));
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr((object)_0002, intPtr, fDeleteOld: false);
			Marshal.Copy(intPtr, _0003, _0005, num);
			Marshal.DestroyStructure(intPtr, typeof(_000F_2000_2000._0002));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public void Dispose()
	{
		if (this._0003 != null)
		{
			this._0003.Dispose();
			this._0003 = null;
		}
		if (_0005 != null)
		{
			_0005.Dispose();
			_0005 = null;
		}
	}
}
internal sealed class _000E_2000
{
	private int m__0002;

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}
}
internal sealed class _000E_2000_2000 : _0006
{
	private _0006_2000 _0002;

	private readonly int _0003;

	private readonly int _0005;

	public _000E_2000_2000(bool _0002, _000F_2000 _0003)
	{
		this._0002 = new _0006_2000();
		this._0002._0002(_0002, _0003);
		this._0003 = this._0002._0002();
		_0005 = this._0002._0003();
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0002()
	{
		return _0003;
	}

	[CompilerGenerated]
	public int _0006_200A_2002_0003()
	{
		return _0005;
	}

	public int _0006_200A_2002_0002(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006, RandomNumberGenerator _000E)
	{
		_0005_200B obj = this._0002._0002(_0002, _0003, _0005);
		_0005_200B obj2 = this._0002._0002(obj);
		return this._0002._0002(obj2, _0008, _0006);
	}
}
internal abstract class _000E_2001
{
	private readonly int m__0002;

	private Type _0003;

	protected _000E_2001(int _0002)
	{
		this.m__0002 = _0002;
	}

	public static _000E_2001 _0002(object _0002, Type _0003)
	{
		_000E_2001 obj = _0002 as _000E_2001;
		if (obj != null)
		{
			return obj;
		}
		if ((object)_0003 == null)
		{
			if (_0002 == null)
			{
				return new _000F_2007();
			}
			_0003 = _0002.GetType();
		}
		_0003 = _000F_200A._0003(_0003);
		switch (_000F_200A._0002(_0003))
		{
		case 22:
			obj = new _0005_200A();
			break;
		case 14:
			obj = new _0003_2003();
			break;
		case 0:
			obj = new _0008_2003();
			break;
		case 20:
			obj = new _0005_2002();
			break;
		case 11:
			obj = new _0006_2002();
			break;
		case 23:
			obj = new _0002_2006();
			break;
		case 10:
			obj = new _000E_2005();
			break;
		case 25:
			obj = new _0008_2005();
			break;
		case 26:
			obj = new _000F_2004();
			break;
		case 16:
			obj = new _0006_2004();
			break;
		case 6:
			obj = new _0002_2004();
			break;
		case 21:
			obj = new _000E_2003();
			break;
		case 19:
			obj = new _0003_2005();
			break;
		case 24:
			obj = new _000E_2006();
			break;
		case 7:
			obj = new _0005_2007();
			break;
		case 8:
			obj = new _000F_2007();
			if (_0002 != null && (object)_0002.GetType() != _000F_200A._0002)
			{
				obj._0002(_0002.GetType());
			}
			break;
		case 1:
			obj = new _0002_2002();
			break;
		case 15:
		{
			Enum @enum = ((_0002 != null) ? ((Enum)Enum.ToObject(_0003, _0002)) : ((Enum)Activator.CreateInstance(_0003)));
			return new _000F_2002(@enum);
		}
		case 9:
		{
			_000F_2007 obj3 = new _000F_2007();
			((_000E_2001)obj3)._0002(_0003);
			obj = obj3;
			break;
		}
		case 4:
			if (_0002 == null)
			{
				if ((object)_0003 != _000F_200A._0006)
				{
					_0002 = Activator.CreateInstance(_0003);
				}
			}
			else if ((object)_0002.GetType() != _0003)
			{
				try
				{
					_0002 = Convert.ChangeType(_0002, _0003);
				}
				catch
				{
				}
			}
			return new _0006_200A(_0002);
		default:
			obj = new _000F_2007();
			break;
		}
		if (_0002 != null)
		{
			obj._000E_2001_200A_2002_0002(_0002);
		}
		return obj;
	}

	public abstract object _000E_2001_200A_2002_0002();

	public abstract void _000E_2001_200A_2002_0002(object _0002);

	public int _0002()
	{
		return this.m__0002;
	}

	public abstract _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002);

	public abstract _000E_2001 _000E_2001_200A_2002_0002();

	public Type _0002()
	{
		return _0003;
	}

	public void _0002(Type _0002)
	{
		_0003 = _0002;
	}
}
internal interface _000E_2001_2000
{
	bool _000E_2001_2000_200A_2002_0002();

	object _000E_2001_2000_200A_2002_0002();

	void _000E_2001_2000_200A_2002_0002();
}
internal sealed class _000E_2002 : Stream
{
	private bool m__0002;

	private Stream _0003;

	private _000F_2003[] _0005;

	private _0006_2003 _0008;

	private _0005_2003 _0006;

	private _0002_2003 _000E;

	private bool _000F;

	private byte[] _0002_2000;

	private int _0003_2000;

	private int _0005_2000;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length => _0003.Length;

	public override long Position
	{
		get
		{
			return _0003.Position + (_0003_2000 - _0005_2000);
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public _000E_2002(Stream _0002, _0006_2003 _0003 = null, _0005_2003 _0005 = null, bool _0008 = false)
	{
		this._0003 = _0002;
		this.m__0002 = _0008;
		_0006 = _0005;
		this._0008 = _0003;
		if (this._0008 == null)
		{
			this._0008 = _0006_2003._0002();
		}
		if (this._0008._0003() == 0)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506764960));
		}
		if (this._0008._0005() == 0)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506764960));
		}
		if (!this._0003.CanRead)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506764898));
		}
		if (!this._0003.CanSeek)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506764898));
		}
	}

	private void _0002()
	{
		if (!_000F)
		{
			_0005 = new _000F_2003[_0008._0003()];
			for (int i = 0; i < _0008._0003(); i++)
			{
				_0005[i] = new _000F_2003();
			}
			if (_0006 != null)
			{
				_000E = _0006._0002(_0008);
			}
			_000F = true;
		}
	}

	protected override void Dispose(bool _0002)
	{
		try
		{
			if (_0002 && !this.m__0002)
			{
				_0003.Close();
			}
		}
		finally
		{
			base.Dispose(_0002);
		}
	}

	public override void SetLength(long _0002)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] _0002, int _0003, int _0005)
	{
		throw new NotSupportedException();
	}

	public override void Flush()
	{
	}

	private int _0002(byte[] _0002, int _0003, int _0005)
	{
		int num = _0005_2000 - _0003_2000;
		if (num <= 0)
		{
			return 0;
		}
		if (num > _0005)
		{
			num = _0005;
		}
		Buffer.BlockCopy(_0002_2000, _0003_2000, _0002, _0003, num);
		_0003_2000 += num;
		return num;
	}

	private void _0002(int _0002)
	{
		int num = (int)_0003.Position;
		if (num >= _0003.Length)
		{
			return;
		}
		int num2 = num + _0002;
		_000F_2003[] array = _0005;
		foreach (_000F_2003 obj in array)
		{
			if (obj._0003 <= num && obj._0005 >= num2)
			{
				_0002_2000 = obj._0002;
				_0005_2000 = obj._0005 - obj._0003;
				_0003_2000 = num - obj._0003;
				_0003.Position = obj._0005;
				obj._0008 = DateTime.UtcNow;
				return;
			}
		}
		int num3 = 0;
		DateTime dateTime = _0005[0]._0008;
		for (int j = 1; j < _0005.Length; j++)
		{
			if (_0005[j]._0008 < dateTime)
			{
				num3 = j;
			}
		}
		_000F_2003 obj2 = _0005[num3];
		if (obj2._0002 == null)
		{
			obj2._0002 = new byte[_0008._0002()];
		}
		int num4 = num;
		num = this._0002(num);
		if (num < 0)
		{
			num = 0;
		}
		num2 = num + _0008._0002();
		if (_000E == null || !_000E._0002(num, ref obj2))
		{
			obj2._0003 = num;
			obj2._0008 = DateTime.UtcNow;
			_0002_2000 = obj2._0002;
			_0003.Position = num;
			_0005_2000 = _0003.Read(_0002_2000, 0, num2 - num);
			_0003_2000 = num4 - num;
			obj2._0005 = num + _0005_2000;
			if (_000E != null)
			{
				_000E._0002(obj2);
			}
		}
		else
		{
			_0002_2000 = obj2._0002;
			_0005_2000 = obj2._0005 - num;
			_0003.Position = obj2._0005;
			_0003_2000 = num4 - num;
		}
	}

	private int _0002(int _0002)
	{
		return _0002 - _0002 % _0008._0002();
	}

	public override int Read(byte[] _0002, int _0003, int _0005)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506765213));
		}
		if (_0003 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_2004_2000._0002(-1506765194));
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_2004_2000._0002(-1506765191));
		}
		if (_0002.Length - _0003 < _0005)
		{
			throw new ArgumentException();
		}
		int num = _0003;
		int num2 = this._0002(_0002, _0003, _0005);
		if (num2 == _0005)
		{
			return num2;
		}
		int num3 = num2;
		if (num2 > 0)
		{
			_0005 -= num2;
			_0003 += num2;
		}
		_0003_2000 = (_0005_2000 = 0);
		this._0002();
		if (_0005 >= _0008._0002())
		{
			if (_000E == null)
			{
				return this._0003.Read(_0002, _0003, _0005) + num3;
			}
			int num4 = (int)this._0003.Position - num3;
			if (_000E._0002(num4, _0002, num, _0005 + num3, out var num5))
			{
				this._0003.Seek(num5 - num3, SeekOrigin.Current);
				return num5;
			}
			num5 = this._0003.Read(_0002, _0003, _0005);
			if (num5 != 0)
			{
				_000E._0002(num4, _0002, num, num5 + num3, num5 < _0005);
			}
			return num5 + num3;
		}
		this._0002(_0005);
		num2 = this._0002(_0002, _0003, _0005);
		return num2 + num3;
	}

	public override long Seek(long _0002, SeekOrigin _0003)
	{
		if (_0005_2000 - _0003_2000 > 0 && _0003 == SeekOrigin.Current)
		{
			_0002 -= _0005_2000 - _0003_2000;
		}
		long position = Position;
		long num = this._0003.Seek(_0002, _0003);
		_0003_2000 = (int)(num - (position - _0003_2000));
		if (0 <= _0003_2000 && _0003_2000 < _0005_2000)
		{
			this._0003.Seek(_0005_2000 - _0003_2000, SeekOrigin.Current);
		}
		else
		{
			_0003_2000 = (_0005_2000 = 0);
		}
		return num;
	}
}
internal static class _000E_2002_2000
{
	internal static void _0002()
	{
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@E\"#U)Z", (object[])null);
	}
}
internal sealed class _000E_2003 : _000E_2001
{
	private new byte m__0002;

	public _000E_2003()
		: base(21)
	{
	}

	public new byte _0002()
	{
		return this.m__0002;
	}

	public void _0002(byte _0002)
	{
		this.m__0002 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000E_2003 obj = new _000E_2003();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is short)
		{
			this._0002((byte)(short)_0002);
		}
		else if (_0002 is int)
		{
			this._0002((byte)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((byte)(long)_0002);
		}
		else if (_0002 is ushort)
		{
			this._0002((byte)(ushort)_0002);
		}
		else if (_0002 is uint)
		{
			this._0002((byte)(uint)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((byte)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((byte)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((byte)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToByte(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((byte)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((byte)((_0006_2004)_0002)._0002());
			break;
		case 26:
			this._0002((byte)((_000F_2004)_0002)._0002());
			break;
		case 19:
			this._0002((byte)((_0003_2005)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToByte(((_000F_2002)_0002)._0002()));
			break;
		case 14:
			this._0002((byte)((_0003_2003)_0002)._0002());
			break;
		case 0:
			this._0002((byte)((_0008_2003)_0002)._0002());
			break;
		case 24:
			this._0002((byte)(int)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((byte)(uint)((_0005_2007)_0002)._0002());
			break;
		case 25:
			this._0002((byte)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((byte)((_000E_2005)_0002)._0002());
			break;
		case 23:
			this._0002((byte)((_0002_2006)_0002)._0002());
			break;
		case 8:
			this._0002(Convert.ToByte(((_000F_2007)_0002)._0002()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class _000E_2003_2000
{
	private static ResourceManager m__0002;

	private static CultureInfo m__0003;

	internal _000E_2003_2000()
	{
	}

	internal static ResourceManager _0002()
	{
		if (_000E_2003_2000.m__0002 == null)
		{
			ResourceManager resourceManager = (_000E_2003_2000.m__0002 = new ResourceManager(_000F_2004_2000._0002(-1506764431), typeof(_000E_2003_2000).Assembly));
		}
		return _000E_2003_2000.m__0002;
	}

	internal static CultureInfo _0002()
	{
		return _000E_2003_2000.m__0003;
	}

	internal static void _0002(CultureInfo _0002)
	{
		_000E_2003_2000.m__0003 = _0002;
	}

	internal static byte[] _0002()
	{
		object @object = _000E_2003_2000._0002().GetObject(_000F_2004_2000._0002(-1506764476), _000E_2003_2000.m__0003);
		return (byte[])@object;
	}

	internal static byte[] _0003()
	{
		object @object = _000E_2003_2000._0002().GetObject(_000F_2004_2000._0002(-1506764458), _000E_2003_2000.m__0003);
		return (byte[])@object;
	}
}
internal static class _000E_2004
{
	private delegate void _0002(Array _0002, RuntimeFieldHandle _0003);

	private static readonly _0002 m__0002 = RuntimeHelpers.InitializeArray;

	public static void _0002(Array _0002, RuntimeFieldHandle _0003)
	{
		if (_0005_2005._0002())
		{
			_ = FieldInfo.GetFieldFromHandle(_0003).MetadataToken;
		}
		_000E_2004.m__0002(_0002, _0003);
	}
}
internal static class _000E_2004_2000
{
	private struct _0002
	{
		public Version _0002;

		public bool _0003;

		public string _0005;

		public string _0008;

		public bool _0006;

		public string _000E;

		public bool _000F;

		public _0002(string _0002)
		{
			this = default(_0002);
			this._0002 = new Version();
			_0005 = string.Empty;
			string[] array = _0002.Split(',');
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(_000F_2004_2000._0002(-1506768932), StringComparison.OrdinalIgnoreCase))
				{
					this._0002 = new Version(text2.Substring(_000F_2004_2000._0002(-1506768932).Length));
					_0003 = true;
				}
				else if (text2.StartsWith(_000F_2004_2000._0002(-1506768989), StringComparison.OrdinalIgnoreCase))
				{
					_0008 = text2.Substring(_000F_2004_2000._0002(-1506768989).Length);
					if (_0008.Equals(_000F_2004_2000._0002(-1506768974), StringComparison.OrdinalIgnoreCase))
					{
						_0008 = null;
					}
					_0006 = true;
				}
				else if (text2.StartsWith(_000F_2004_2000._0002(-1506769024), StringComparison.OrdinalIgnoreCase))
				{
					_000E = text2.Substring(_000F_2004_2000._0002(-1506769024).Length);
					if (_000E.Equals(_000F_2004_2000._0002(-1506768994), StringComparison.OrdinalIgnoreCase))
					{
						_000E = null;
					}
					_000F = true;
				}
				else
				{
					_0005 = text2;
				}
			}
		}

		public string _0002(bool _0002)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(_0005);
			if (_0002)
			{
				stringBuilder.Append(_000F_2004_2000._0002(-1506769311)).Append(this._0002);
			}
			stringBuilder.Append(_000F_2004_2000._0002(-1506769294)).Append(_0008 ?? _000F_2004_2000._0002(-1506769341)).Append(_000F_2004_2000._0002(-1506769327))
				.Append(_000E ?? _000F_2004_2000._0002(-1506769367));
			return stringBuilder.ToString();
		}
	}

	private static class _0003
	{
		internal static readonly Dictionary<string, Assembly> _0002 = new Dictionary<string, Assembly>(StringComparer.Ordinal);
	}

	private sealed class _0005
	{
		private byte[] m__0002 = new byte[256];

		private int _0003;

		private int m__0005;

		public _0005(byte[] _0002)
		{
			int num = _0002.Length;
			for (_0003 = 0; _0003 < 256; _0003++)
			{
				this.m__0002[_0003] = (byte)_0003;
			}
			for (_0003 = (m__0005 = 0); _0003 < 256; _0003++)
			{
				m__0005 = (m__0005 + _0002[_0003 % num] + this.m__0002[_0003]) & 0xFF;
				this._0002(_0003, m__0005);
			}
		}

		private void _0002(int _0002, int _0003)
		{
			byte b = this.m__0002[_0002];
			this.m__0002[_0002] = this.m__0002[_0003];
			this.m__0002[_0003] = b;
		}

		public byte _0002()
		{
			_0003 = (_0003 + 1) & 0xFF;
			m__0005 = (m__0005 + this.m__0002[_0003]) & 0xFF;
			_0002(_0003, m__0005);
			return this.m__0002[(byte)(this.m__0002[_0003] + this.m__0002[m__0005])];
		}
	}

	private static class _0008
	{
		internal sealed class _0002
		{
			public string _0002;

			private string m__0003;

			public string _0005;

			public bool _0008;

			public bool _0006;

			public bool _000E;

			public bool _000F;

			public bool _0002_2000;

			public string _0003_2000;

			private string _0005_2000;

			public string _0002()
			{
				if (this.m__0003 == null)
				{
					byte[] array = Convert.FromBase64String(this._0002);
					this.m__0003 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return this.m__0003;
			}

			public string _0003()
			{
				if (_0005_2000 == null)
				{
					byte[] array = Convert.FromBase64String(_0003_2000);
					_0005_2000 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return _0005_2000;
			}
		}

		private struct _0003
		{
			private readonly string m__0002;

			private FileStream m__0003;

			public _0003(string _0002)
			{
				this = default(_0003);
				this.m__0002 = _0002;
			}

			public bool _0002()
			{
				try
				{
					if (this.m__0003 != null)
					{
						return false;
					}
					this.m__0003 = new FileStream(this.m__0002, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 128, FileOptions.DeleteOnClose);
				}
				catch
				{
					return false;
				}
				return true;
			}

			public void _0002()
			{
				Stopwatch stopwatch = null;
				int num = 25;
				int num2 = 250;
				while (!this._0002())
				{
					if (stopwatch == null)
					{
						stopwatch = Stopwatch.StartNew();
					}
					else
					{
						if (stopwatch.Elapsed.TotalSeconds > 300.0)
						{
							throw new TimeoutException(string.Format(_000F_2004_2000._0002(-1506769348), this.m__0002));
						}
						if (num < num2)
						{
							num = Math.Min(num * 2, num2);
						}
					}
					Thread.Sleep(num);
				}
			}

			public void _0003()
			{
				if (this.m__0003 != null)
				{
					this.m__0003.Dispose();
					this.m__0003 = null;
				}
			}
		}

		private sealed class _0005 : IEnumerable<_0002>, IEnumerable, IEnumerator<_0002>, IDisposable, IEnumerator
		{
			private int _0002;

			private _0002 _0003;

			private int m__0005;

			private string _0008;

			public string _0006;

			private string[] _000E;

			private int _000F;

			[DebuggerHidden]
			public _0005(int _0002)
			{
				this._0002 = _0002;
				m__0005 = Thread.CurrentThread.ManagedThreadId;
			}

			[DebuggerHidden]
			private void _0005_200A_2002_0002()
			{
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				this._0005_200A_2002_0002();
			}

			private bool _0005_200A_2002_0002()
			{
				int num = _0002;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_0002 = -1;
					goto IL_0121;
				}
				_0002 = -1;
				string text = _000F_2004_2000._0002(-1506769181);
				_000E = text.Split(',');
				if (_0008 == null && !_000E_2004_2000._0002())
				{
					return false;
				}
				_000F = 0;
				goto IL_012f;
				IL_0121:
				_000F += 4;
				goto IL_012f;
				IL_012f:
				if (_000F < _000E.Length)
				{
					string text2 = _000E[_000F];
					if (_0008 == null || text2.Equals(_0008, StringComparison.Ordinal))
					{
						_0002 obj = new _0002();
						obj._0002 = text2;
						string text3 = _000E[_000F + 1];
						int num2 = text3.IndexOf('|');
						if (num2 >= 0)
						{
							string text4 = text3.Substring(0, num2);
							text3 = text3.Substring(num2 + 1);
							obj._0008 = text4.IndexOf('a') != -1;
							obj._000E = text4.IndexOf('c') != -1;
						}
						obj._0005 = text3;
						obj._0003_2000 = _000E[_000F + 2];
						_0003 = obj;
						_0002 = 1;
						return true;
					}
					goto IL_0121;
				}
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				return this._0005_200A_2002_0002();
			}

			[DebuggerHidden]
			private _0002 _0005_200A_2002_0002()
			{
				return _0003;
			}

			_0002 IEnumerator<_0002>.get_Current()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				return this._0005_200A_2002_0002();
			}

			[DebuggerHidden]
			private void _0005_200A_2002_0003()
			{
				throw new NotSupportedException();
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				this._0005_200A_2002_0003();
			}

			[DebuggerHidden]
			private object _0005_200A_2002_0002()
			{
				return _0003;
			}

			object IEnumerator.get_Current()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				return this._0005_200A_2002_0002();
			}

			[DebuggerHidden]
			private IEnumerator<_0002> _0005_200A_2002_0002()
			{
				_0005 obj;
				if (_0002 == -2 && m__0005 == Thread.CurrentThread.ManagedThreadId)
				{
					_0002 = 0;
					obj = this;
				}
				else
				{
					obj = new _0005(0);
				}
				obj._0008 = _0006;
				return obj;
			}

			IEnumerator<_0002> IEnumerable<_0002>.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				return this._0005_200A_2002_0002();
			}

			[DebuggerHidden]
			private IEnumerator _0005_200A_2002_0002()
			{
				return this._0005_200A_2002_0002();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in   
				return this._0005_200A_2002_0002();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<_0002> _0002(string _0002)
		{
			return new _0005(-2)
			{
				_0006 = _0002
			};
		}

		internal static byte[] _0002(_0002 _0002)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0002._0005);
			if (manifestResourceStream == null)
			{
				return null;
			}
			int num = (int)manifestResourceStream.Length;
			byte[] array = new byte[num];
			manifestResourceStream.Read(array, 0, num);
			manifestResourceStream.Dispose();
			if (_0002._0008)
			{
				array = _000E_2004_2000._0002(array);
			}
			return array;
		}

		internal static string _0002(_0002 _0002, bool _0003, byte[] _0005)
		{
			string text = Path.Combine(Path.GetTempPath(), _0002._0005);
			try
			{
				Directory.CreateDirectory(text);
			}
			catch
			{
				text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				text = Path.Combine(text, _000F_2004_2000._0002(-1506769617));
				text = Path.Combine(text, _0002._0005);
				Directory.CreateDirectory(text);
				if (text == null)
				{
					throw;
				}
			}
			string text2 = Path.Combine(text, _0002._0003());
			_0003 obj2 = new _0003(text2 + _000F_2004_2000._0002(-1506769604));
			obj2._0002();
			try
			{
				if (!File.Exists(text2))
				{
					if (_0005 == null)
					{
						_0005 = _0008._0002(_0002);
					}
					File.WriteAllBytes(text2, _0005);
					if (_0003)
					{
						try
						{
							_000E_2004_2000._0002(text2, null, 4);
							_000E_2004_2000._0002(text, null, 4);
							return text2;
						}
						catch
						{
							return text2;
						}
					}
					return text2;
				}
				return text2;
			}
			finally
			{
				obj2._0003();
			}
		}

		internal static void _0002(string _0002, bool _0003)
		{
			bool flag = false;
			try
			{
				File.Delete(_0002);
				flag = true;
			}
			catch
			{
			}
			string directoryName = Path.GetDirectoryName(_0002);
			bool flag2 = false;
			try
			{
				Directory.Delete(directoryName);
				flag = true;
			}
			catch
			{
			}
			if (!_0003)
			{
				return;
			}
			if (!flag)
			{
				try
				{
					_000E_2004_2000._0002(_0002, null, 4);
				}
				catch
				{
				}
			}
			if (!flag2)
			{
				try
				{
					_000E_2004_2000._0002(directoryName, null, 4);
				}
				catch
				{
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_000E_2004_2000).Assembly)
		{
			return false;
		}
		return true;
	}

	internal static void _0002()
	{
		AppDomain.CurrentDomain.AssemblyResolve += _0002;
	}

	internal static Assembly _0002(string _0002)
	{
		return _0003(_0002);
	}

	private static Assembly _0002(object _0002, ResolveEventArgs _0003)
	{
		return _000E_2004_2000._0003(_0003.Name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0003(string _0002)
	{
		_0002 obj = new _0002(_0002.ToUpperInvariant());
		_0008._0002 obj2 = null;
		bool flag = false;
		if (obj2 == null && !flag)
		{
			string s = obj._0002(_0002: false);
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
			using IEnumerator<_0008._0002> enumerator = _0008._0002(text).GetEnumerator();
			if (enumerator.MoveNext())
			{
				_0008._0002 current = enumerator.Current;
				obj2 = current;
			}
		}
		if (obj2 == null)
		{
			return null;
		}
		Dictionary<string, Assembly> dictionary = _000E_2004_2000._0003._0002;
		lock (dictionary)
		{
			if (!dictionary.TryGetValue(obj2._0005, out var value))
			{
				byte[] array = _0008._0002(obj2);
				if (array == null)
				{
					return null;
				}
				bool flag2 = obj2._000E;
				if (!flag2)
				{
					try
					{
						value = Assembly.Load(array);
					}
					catch (FileLoadException)
					{
						flag2 = true;
					}
					catch (BadImageFormatException)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					try
					{
						string assemblyFile = _0008._0002(obj2, _0003: true, array);
						value = Assembly.LoadFrom(assemblyFile);
					}
					catch
					{
					}
				}
				dictionary.Add(obj2._0005, value);
				return value;
			}
			return value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] _0002(byte[] _0002)
	{
		string s = _000F_2004_2000._0002(-1506769664);
		byte[] array = Convert.FromBase64String(s);
		_0003_2005_2000._0002(array);
		_0005 obj = new _0005(array);
		int num = _0002.Length;
		byte b = 0;
		byte b2 = 121;
		byte[] array2 = new byte[8] { 148, 68, 208, 52, 241, 93, 195, 220 };
		for (int i = 0; i != num; i++)
		{
			if (b == 0)
			{
				b2 = obj._0002();
			}
			b = (byte)(b + 1);
			if (b == 32)
			{
				b = 0;
			}
			_0002[i] ^= (byte)(b2 ^ array2[(i >> 2) & 3] ^ array2[b & 3]);
		}
		return _0002;
	}

	[DllImport("kernel32.dll", EntryPoint = "MoveFileEx")]
	private static extern bool _0002(string _0002, string _0003, int _0005);
}
internal sealed class _000E_2005 : _000E_2001
{
	private new uint m__0002;

	public _000E_2005()
		: base(10)
	{
	}

	public new uint _0002()
	{
		return this.m__0002;
	}

	public void _0002(uint _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is short)
		{
			this._0002((uint)(short)_0002);
		}
		else if (_0002 is int)
		{
			this._0002((uint)(int)_0002);
		}
		else if (_0002 is long)
		{
			this._0002((uint)(long)_0002);
		}
		else if (_0002 is ulong)
		{
			this._0002((uint)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((uint)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((uint)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToUInt32(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000E_2005 obj = new _000E_2005();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((uint)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((uint)((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002((uint)((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002(((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002(((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((uint)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((uint)((_0002_2006)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToUInt32(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToUInt32(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((uint)(int)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((uint)((_0005_2007)_0002)._0002());
			break;
		case 0:
			this._0002((uint)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((uint)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _000E_2006 : _000E_2001
{
	private new IntPtr m__0002;

	public _000E_2006()
		: base(24)
	{
	}

	public new IntPtr _0002()
	{
		return this.m__0002;
	}

	public void _0002(IntPtr _0002)
	{
		this.m__0002 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000E_2006 obj = new _000E_2006();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((IntPtr)_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 24:
			this._0002(((_000E_2006)_0002)._0002());
			break;
		case 21:
			this._0002((IntPtr)((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002((IntPtr)((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002((IntPtr)((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002((IntPtr)((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002((IntPtr)((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002((IntPtr)((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002((IntPtr)((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((IntPtr)(long)((_0002_2006)_0002)._0002());
			break;
		case 8:
			this._0002((IntPtr)((_000F_2007)_0002)._0002());
			break;
		case 0:
			this._0002((IntPtr)(long)((_0008_2003)_0002)._0002());
			break;
		case 15:
			this._0002(new IntPtr(Convert.ToInt64(((_000F_2002)_0002)._0002())));
			break;
		case 14:
			this._0002((IntPtr)(long)((_0003_2003)_0002)._0002());
			break;
		case 18:
		{
			_0005_2006 obj = (_0005_2006)_0002;
			this._0002(obj._0002());
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal interface _000E_2007 : IDisposable
{
	int _000E_2007_200A_2002_0002();

	void _000E_2007_200A_2002_0002(int _0002, out byte _0003);

	void _000E_2007_200A_2002_0003(int _0002, ref byte _0003);

	void _000E_2007_200A_2002_0002();

	_000E_2007 _000E_2007_200A_2002_0002();
}
internal static class _000E_2008
{
	private static volatile int m__0002;

	private static volatile int _0003;

	public static void _0002(ref byte _0002)
	{
		_0002 = (byte)_000E_2008.m__0002;
		_0003 = _0002;
	}

	public static void _0002(ref int _0002)
	{
		_0002 = _000E_2008.m__0002;
		_0003 = _0002;
	}

	public static void _0002(ref long _0002)
	{
		_0002 = _000E_2008.m__0002;
		_0003 = (int)_0002;
	}

	public static void _0002(ref char _0002)
	{
		_0002 = (char)_000E_2008.m__0002;
		_0003 = _0002;
	}

	public static void _0002(Array _0002, int _0003, int _0005)
	{
		Array.Clear(_0002, _0003, _0005);
	}

	public static void _0002(Array _0002)
	{
		_000E_2008._0002(_0002, 0, _0002.GetLength(0));
	}
}
internal sealed class _000E_2009 : _0005_2008
{
	private new int m__0002;

	public _000E_2009()
		: base(17)
	{
	}

	public new int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		if (_0002._0002() == 17)
		{
			this._0002(((_000E_2009)_0002)._0002());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000E_2009 obj = new _000E_2009();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal struct _000E_200A
{
	public int _0002;

	public int _0003;
}
internal static class _000F
{
	public static int _0002(int _0002)
	{
		return _0002 & -16777216;
	}
}
internal sealed class _000F_2000
{
	private readonly bool m__0002;

	private readonly _0005_200B m__0003;

	private readonly _0005_200B _0005;

	public _000F_2000(bool _0002, _0005_200B _0003, _0005_200B _0005)
	{
		if (_0003 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764858));
		}
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506764844));
		}
		this.m__0002 = _0002;
		this.m__0003 = _0003;
		this._0005 = _0005;
	}

	public bool _0002()
	{
		return this.m__0002;
	}

	public _0005_200B _0002()
	{
		return this.m__0003;
	}

	public _0005_200B _0003()
	{
		return _0005;
	}
}
internal static class _000F_2000_2000
{
	public struct _0002
	{
		public uint _0002;

		public int _0003;

		public int _0005;

		public int _0008;

		public int _0006;

		public int _000E;
	}

	[SecurityCritical]
	public sealed class _0003 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public _0003()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return _0002(handle) == 0;
		}
	}

	[SecurityCritical]
	public sealed class _0005 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public _0005()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return _0002(handle) == 0;
		}
	}

	public static void _0002(uint _0002)
	{
		if (_0002 != 0)
		{
			uint num = _0002;
			throw new InvalidOperationException(num.ToString());
		}
	}

	[DllImport("ncrypt.dll", EntryPoint = "NCryptFreeObject")]
	public static extern uint _0002(IntPtr _0002);

	[DllImport("ncrypt.dll", EntryPoint = "NCryptEncrypt")]
	public static extern uint _0002(_0003 _0002, [MarshalAs(UnmanagedType.LPArray)] byte[] _0003, int _0005, IntPtr _0008, [MarshalAs(UnmanagedType.LPArray)] byte[] _0006, int _000E, out int _000F, int _0002_2000);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptImportKey")]
	public static extern uint _0002(_0005 _0002, IntPtr _0003, string _0005, IntPtr _0008, out _0003 _0006, [MarshalAs(UnmanagedType.LPArray)] byte[] _000E, int _000F, uint _0002_2000);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptOpenStorageProvider")]
	public static extern uint _0002(out _0005 _0002, string _0003, uint _0005);
}
internal static class _000F_2001
{
	private static uint _0002(uint _0002, uint _0003, uint _0005, int _0008, uint _0006, uint[] _000E)
	{
		return (((_0005 >> 5) ^ (_0003 << 2)) + ((_0003 >> 3) ^ (_0005 << 4))) ^ ((_0002 ^ _0003) + (_000E[(_0008 & 3) ^ _0006] ^ _0005));
	}

	public static void _0002(byte[] _0002, int _0003, int _0005, byte[] _0008)
	{
		if (_0002.Length != 0 && _0002.Length != 0)
		{
			if (_0003 + _0005 > _0002.Length || _0005 % 4 != 0 || _0005 < 8)
			{
				throw new ArgumentException(_000F_2004_2000._0002(-1506764837));
			}
			if (_0008 == null || _0008.Length > 16)
			{
				throw new ArgumentNullException(_000F_2004_2000._0002(-1506764882));
			}
			uint[] array = new uint[_0005 / 4];
			_000F_2001._0002(_0002, _0003, _0005, array, 0);
			uint[] array2 = new uint[4];
			_000F_2001._0002(_0008, 0, _0008.Length, array2, 0);
			_000F_2001._0002(array, array2);
			_000F_2001._0002(array, 0, array.Length, _0002, _0003);
		}
	}

	private static void _0002(uint[] _0002, uint[] _0003)
	{
		int num = _0002.Length - 1;
		if (num < 1)
		{
			return;
		}
		uint num2 = _0002[num];
		uint num3 = 0u;
		int num4 = 6 + 52 / (num + 1);
		while (0 < num4--)
		{
			num3 += 2654435769u;
			uint num5 = (num3 >> 2) & 3u;
			int i;
			uint num6;
			for (i = 0; i < num; i++)
			{
				num6 = _0002[i + 1];
				num2 = (_0002[i] += _000F_2001._0002(num3, num6, num2, i, num5, _0003));
			}
			num6 = _0002[0];
			num2 = (_0002[num] += _000F_2001._0002(num3, num6, num2, i, num5, _0003));
		}
	}

	private static uint[] _0002(byte[] _0002, int _0003, int _0005, uint[] _0008, int _0006)
	{
		if (_0003 + _0005 > _0002.Length)
		{
			throw new ArgumentException();
		}
		int num = _0005 / 4;
		if (_0006 + num > _0008.Length)
		{
			throw new ArgumentException();
		}
		int num2 = _0003 + _0005;
		for (int i = _0003; i < num2; i += 4)
		{
			_0008[_0006 + (i - _0003) / 4] = (uint)(_0002[i] | (_0002[i + 1] << 8) | (_0002[i + 2] << 16) | (_0002[i + 3] << 24));
		}
		return _0008;
	}

	private static void _0002(uint[] _0002, int _0003, int _0005, byte[] _0008, int _0006)
	{
		if (_0003 + _0005 > _0002.Length)
		{
			throw new ArgumentException();
		}
		int num = _0005 * 4;
		if (_0006 + num > _0008.Length)
		{
			throw new ArgumentException();
		}
		int num2 = _0006 + num;
		for (int i = _0006; i < num2; i += 4)
		{
			uint num3 = _0002[(i - _0006) / 4 + _0003];
			_0008[i] = (byte)num3;
			_0008[i + 1] = (byte)(num3 >> 8);
			_0008[i + 2] = (byte)(num3 >> 16);
			_0008[i + 3] = (byte)(num3 >> 24);
		}
	}
}
internal interface _000F_2001_2000
{
	void _000F_2001_2000_200A_2002_0002();
}
internal sealed class _000F_2002 : _000E_2001
{
	private new enum _0002
	{
		Value
	}

	private new Enum m__0002;

	public _000F_2002()
		: base(15)
	{
	}

	public _000F_2002(Enum _0002)
		: this()
	{
		this.m__0002 = (Enum)(_0002 ?? ((object)_000F_2002._0002.Value));
	}

	public new Enum _0002()
	{
		return this.m__0002;
	}

	public void _0002(Enum _0002)
	{
		if (_0002 == null)
		{
			throw new ArgumentException();
		}
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002((Enum)Enum.Parse(this._0002().GetType(), _0002.ToString()));
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 15:
		{
			Type type = this.m__0002.GetType();
			Enum @enum = ((_000F_2002)_0002)._0002();
			if ((object)@enum.GetType() == type)
			{
				this._0002(@enum);
			}
			else
			{
				this._0002((Enum)Enum.ToObject(type, @enum));
			}
			break;
		}
		case 6:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_0002_2004)_0002)._0002()));
			break;
		case 16:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_0006_2004)_0002)._0002()));
			break;
		case 26:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_000F_2004)_0002)._0002()));
			break;
		case 25:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_0008_2005)_0002)._0002()));
			break;
		case 10:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_000E_2005)_0002)._0002()));
			break;
		case 23:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_0002_2006)_0002)._0002()));
			break;
		case 19:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_0003_2005)_0002)._0002()));
			break;
		case 21:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_000E_2003)_0002)._0002()));
			break;
		case 8:
			this._0002((Enum)Enum.ToObject(this.m__0002.GetType(), ((_000F_2007)_0002)._0002()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000F_2002 obj = new _000F_2002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}
}
internal sealed class _000F_2002_2000
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	private struct a1
	{
	}

	internal static a1 a507890657/* Not supported: data(72 DC 32 B3 73 40 06 F8 AA A7 B7 84 0C 0A CE F9 DB D6 47 DD 42 A6 0F 34 3F AE DE A3 78 92 41 1B 3A 09 15 75 67 4E 72 21 D0 34 74 35 FA 3F D9 D3 63 68 7E 5C 9E 79 D2 4E 89 98 95 B8 03 F4 81 37 59 81 1A BC 54 B0 2A 3F 31 CA BF FB 85 29 5B 3A 11 BB F7 12 C8 9D C1 F2 36 74 6D 3D 06 CE AE 22 EE B5 04 59 2F F3 CA 36 29 1A 91 AD 4D DD 92 E8 4A 7B A7 65 E5 65 8D 16 CD BB 54 3C B8 15 23 B9 87 8C C9 D8 1E 13 94 C5 DB 6A 5B DC CF FE 2D B7 4D DC D2 3D BB 92 8B 33 C7 50 D8 64 2A 73 5A D7 30 66 49 C2 35 FE 01 29 0C E5 1D C0 EB 5A F9 84 19 EA 51 C0 BD 8B B2 A1 9D 12 F8 89 27 7D 87 C8 64 94 9C 0C BF AA DB BD 94 CA 5D 42 83 6F 25 F0 B4 BB 8B 40 CD F1 8D 93 92 D7 69 A9 EA CF 88 35 62 DD DF 53 22 0A 75 02 4A 39 E4 CF BB E1 62 B7 21 F1 88 C6 6B 40 A9 CE 78 1B AE C9 48 2D E4 1B) */;

	internal bool _0002()
	{
		object[] array = new object[1] { this };
		return (bool)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>A\"%iRo", array);
	}
}
internal sealed class _000F_2003
{
	public byte[] _0002;

	public int _0003;

	public int _0005;

	public DateTime _0008 = DateTime.UtcNow.AddTicks(1L);
}
internal sealed class _000F_2003_2000
{
	internal _000F_2003_2000()
	{
		_002Ector_2();
	}

	internal void _0002(byte[] _0002)
	{
		object[] array = new object[2] { this, _0002 };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k>5\"(VE4", array);
	}

	internal bool _0002(int _0002)
	{
		object[] array = new object[2] { this, _0002 };
		return (bool)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@b\"*O\\F", array);
	}

	internal void _0002(_0006_2003_2000._0008 _0002)
	{
		object[] array = new object[2] { this, _0002 };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6kA/\"*XbG", array);
	}

	private static IntPtr _0002(IntPtr _0002, int _0003)
	{
		object[] array = new object[2] { _0002, _0003 };
		return (IntPtr)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k@(\"*=PD", array);
	}

	private static IntPtr _0002(int _0002, int _0003)
	{
		object[] array = new object[2] { _0002, _0003 };
		return (IntPtr)_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k?#\"*FVE", array);
	}

	private void _002Ector_2()
	{
		object[] array = new object[1] { this };
		_0005_2005_2000._000E_2005_2000()._0002(_0005_2005_2000._000F_2005_2000(), "#6k?)\"'5L'", array);
	}
}
internal sealed class _000F_2004 : _000E_2001
{
	private new long m__0002;

	public _000F_2004()
		: base(26)
	{
	}

	public _000F_2004(long _0002)
		: this()
	{
		this.m__0002 = _0002;
	}

	public new long _0002()
	{
		return this.m__0002;
	}

	public void _0002(long _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		if (_0002 is ulong)
		{
			this._0002((long)(ulong)_0002);
		}
		else if (_0002 is float)
		{
			this._0002((long)(float)_0002);
		}
		else if (_0002 is double)
		{
			this._0002((long)(double)_0002);
		}
		else
		{
			this._0002(Convert.ToInt64(_0002));
		}
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000F_2004 obj = new _000F_2004();
		obj._0002(this.m__0002);
		obj._0002(base._0002());
		return obj;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		switch (_0002._0002())
		{
		case 20:
			this._0002(Convert.ToByte(((_0005_2002)_0002)._0002()));
			break;
		case 21:
			this._0002(((_000E_2003)_0002)._0002());
			break;
		case 6:
			this._0002(((_0002_2004)_0002)._0002());
			break;
		case 16:
			this._0002(((_0006_2004)_0002)._0002());
			break;
		case 19:
			this._0002(((_0003_2005)_0002)._0002());
			break;
		case 25:
			this._0002(((_0008_2005)_0002)._0002());
			break;
		case 10:
			this._0002(((_000E_2005)_0002)._0002());
			break;
		case 26:
			this._0002(((_000F_2004)_0002)._0002());
			break;
		case 23:
			this._0002((long)((_0002_2006)_0002)._0002());
			break;
		case 15:
			this._0002(Convert.ToInt64(((_000F_2002)_0002)._0002()));
			break;
		case 8:
			this._0002(Convert.ToInt64(((_000F_2007)_0002)._0002()));
			break;
		case 24:
			this._0002((long)((_000E_2006)_0002)._0002());
			break;
		case 7:
			this._0002((long)(ulong)((_0005_2007)_0002)._0002());
			break;
		case 0:
			this._0002((long)((_0008_2003)_0002)._0002());
			break;
		case 14:
			this._0002((long)((_0003_2003)_0002)._0002());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _000F_2004_2000
{
	private enum _0002
	{

	}

	private sealed class _0003
	{
		private Stream m__0002;

		private byte[] m__0003;

		public _0003(Stream _0002)
		{
			this.m__0002 = _0002;
			m__0003 = new byte[4];
		}

		public Stream _0002()
		{
			return this.m__0002;
		}

		public short _0002()
		{
			this._0002(2);
			return (short)(m__0003[0] | (m__0003[1] << 8));
		}

		public int _0002()
		{
			this._0002(4);
			return m__0003[0] | (m__0003[1] << 8) | (m__0003[2] << 16) | (m__0003[3] << 24);
		}

		private static void _0002()
		{
			throw new EndOfStreamException();
		}

		private void _0002(int _0002)
		{
			int num = 0;
			int num2 = 0;
			if (_0002 == 1)
			{
				num2 = this.m__0002.ReadByte();
				if (num2 == -1)
				{
					_000F_2004_2000._0003._0002();
				}
				m__0003[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__0002.Read(m__0003, num, _0002 - num);
				if (num2 == 0)
				{
					_000F_2004_2000._0003._0002();
				}
				num += num2;
			}
			while (num < _0002);
		}

		public void _0002()
		{
			Stream stream = this.m__0002;
			this.m__0002 = null;
			stream?.Close();
			m__0003 = null;
		}

		public byte[] _0002(int _0002)
		{
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0002];
			int num = 0;
			do
			{
				int num2 = this.m__0002.Read(array, num, _0002);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_0002 -= num2;
			}
			while (_0002 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static short _0008;

	private static int _0002_2000;

	private static byte[] _000E;

	private static int _0006;

	private static _0003 m__0003;

	private static byte[] _0005;

	private static _0002 _0003_2000;

	private static ConcurrentDictionary<int, string> m__0002;

	private static int _000F;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _000F_2004_2000()
	{
		int num = 1327879106;
		int num2 = num ^ -1700758963;
		_000F_2004_2000.m__0002 = new ConcurrentDictionary<int, string>();
		_0003_2000 = (_0002)16 | _0003_2000;
		_0002_2000 += ~(-(~(-(~(-(-(~(~(-(~((num + 1734065166) ^ num2)))))))))));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0002(int _0002)
	{
		if (_000F_2004_2000.m__0002.TryGetValue(_0002, out var value))
		{
			return value;
		}
		return _000F_2004_2000._0002(_0002, _0003: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _0002(int _0002, bool _0003)
	{
		int num = -1380993807;
		int num2 = -1611929492 + num;
		string value = null;
		byte[] array;
		int num18;
		int num19;
		int num20;
		int num21;
		byte[] array3;
		byte[] array2;
		int num22;
		while (true)
		{
			lock (_000F_2004_2000.m__0002)
			{
				int num5;
				if (_000F_2004_2000.m__0003 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly = Assembly.GetCallingAssembly();
					_0006 |= (-80558896 - num) ^ num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = (num ^ 0x7FC63659) + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = -1074526091 + num - num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (457863755 - num) ^ num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (num ^ -1073018471) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = num + 616156604 + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					_000F_2004_2000.m__0003 = new _0003(manifestResourceStream);
					short num4 = (short)(_000F_2004_2000.m__0003._0002() ^ (short)(~(-(-(~(~(-(~(-(~((-78933358 - num) ^ num2)))))))))));
					if (num4 == 0)
					{
						_0008 = (short)(_000F_2004_2000.m__0003._0002() ^ (short)(-(~(~(-(-(~(-(~(~((num ^ 0x1FCBCFDC) + num2)))))))))));
					}
					else
					{
						_0005 = _000F_2004_2000.m__0003._0002(num4);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName = _000F_2004_2000._0002(callingAssembly);
					_000E = _000F_2004_2000._0002(assemblyName);
					num5 = _0002_2000;
					_0002_2000 = 0;
					num5 ^= 2018440502 - num - num2;
					long num6 = _0003_2005_2000._0002();
					num5 ^= (int)num6;
					num5 ^= (-2024674591 + num) ^ num2;
					num5 ^= 1470807295 - num - num2;
					int num7 = 0;
					int num8 = num5;
					int num9 = num8;
					int num10 = num9;
					global::_0002_2002_2000<int> enumerator = ((global::_0006_2001_2000<int>)new _0005_2001_2000._0002((78949810 + num) ^ num2)
					{
						_0006 = num10
					}).GetEnumerator();
					try
					{
						while (((_000E_2001_2000)enumerator)._000E_2001_2000_200A_2002_0002())
						{
							int num11 = enumerator._000E_2001_2000_200A_2002_0002();
							num9 ^= num11 - num7;
							num7 += num9 >> 1;
						}
					}
					finally
					{
						enumerator?._000F_2001_2000_200A_2002_0002();
					}
					int num12 = num9;
					int num13 = num12 ^ (1454464176 - num + num2);
					int num14 = ((-533461253 ^ num) - num2) * num13 % ((-101939807 - num) ^ num2);
					num5 ^= 79664868 + num + num2 + ~(-(-(~(~(-(~(-(~(-(~((1611929736 - num) ^ num2)))))))))));
					num5 ^= ~(-(~(-(-(~(~(-(-(~(~((-471091692 ^ num) - num2)))))))))));
					num5 += num14;
					_0006 = (_0006 & (347385124 + num + num2)) ^ ((-78955318 - num) ^ num2);
					_000F = num5;
					if (((uint)_0003_2000 & (uint)(-(~(-(~(~(-(-(~(~((num ^ 0x1FCBD665) + num2))))))))))) == 0)
					{
						_0006 = (-78976040 - num) ^ num2;
					}
				}
				else
				{
					num5 = _000F;
				}
				if (_0006 == 78993772 + num + num2)
				{
					value = new string(new char[3]
					{
						(char)((num ^ -533452476) - num2),
						'0',
						(char)(78949898 + num + num2)
					});
					return value;
				}
				int num15 = _0002 ^ (1649044211 - num - num2) ^ num5;
				num15 ^= (-1035009768 + num) ^ num2;
				_000F_2004_2000.m__0003._0002().Position = num15;
				if (_0005 != null)
				{
					array = _0005;
				}
				else
				{
					short num16 = ((_0008 != -1) ? _0008 : ((short)(_000F_2004_2000.m__0003._0002() ^ ((-533455775 ^ num) - num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = _000F_2004_2000.m__0003._0002(num16);
						for (int num17 = 0; num17 != array.Length; num17 = 1 + num17)
						{
							array[num17] ^= (byte)(_000F >> ((num17 & 3) << 3));
						}
					}
				}
				num18 = _000F_2004_2000.m__0003._0002() ^ num15 ^ ~(-(-(~(~(-(~(-(-(~(~(-1629313742 - num + num2))))))))))) ^ num5;
				if (num18 != (0x1FCBD652 ^ num ^ num2))
				{
					num19 = _0006;
					num20 = (-80557364 - num) ^ num2;
					num21 = num18;
					num22 = num19 - 12;
					num18 &= (num ^ 0x6FCBD653) + num2;
					array2 = _000F_2004_2000.m__0003._0002(num18);
					array3 = _000E;
					break;
				}
				byte[] array4 = _000F_2004_2000.m__0003._0002(4);
				_0002 = (num + 1629313740 - num2) ^ num5;
				_0002 = (array4[2] | (array4[3] << 16) | (array4[0] << 8) | (array4[1] << 24)) ^ -_0002;
			}
			if (_000F_2004_2000.m__0002.TryGetValue(_0002, out value))
			{
				return value;
			}
		}
		bool flag = (num21 & ((-1075058580 + num) ^ num2)) != 0;
		bool flag2 = (num21 & (994792014 - num - num2)) != 0;
		bool flag3 = (num21 & (0x603429AC ^ num ^ num2)) != 0;
		byte[] array5 = array;
		byte[] array6 = array2;
		byte[] array7 = array5;
		byte b = array7[1];
		int num23 = array6.Length;
		byte b2 = (byte)((11 + num23) ^ (b + 7));
		uint num24 = (uint)((array7[0] | (array7[2] << 8)) + (b2 << 3));
		int i = 0;
		ushort num25 = 0;
		for (; i < num23; i++)
		{
			if ((i & 1) == 0)
			{
				num24 = (uint)((int)num24 * (-78735797 - num - num2) + (num ^ -535644305 ^ num2));
				num25 = (ushort)(num24 >> 16);
			}
			byte b3 = (byte)num25;
			num25 = (ushort)(num25 >> 8);
			byte b4 = array6[i];
			array6[i] = (byte)(b ^ b4 ^ (3 + b2) ^ b3);
			b2 = b4;
		}
		array2 = array6;
		if (array3 != null != (num19 != num20))
		{
			for (int j = 0; j < num18; j++)
			{
				byte b5 = array3[j & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array2[j] = (byte)(array2[j] ^ b5);
			}
		}
		int num26;
		byte[] array8;
		if (!flag2)
		{
			num26 = num18;
			array8 = array2;
		}
		else
		{
			num26 = array2[2] | (array2[0] << 16) | (array2[3] << 8) | (array2[1] << 24);
			array8 = new byte[num26];
			_000F_2004_2000._0002(array2, 4, array8);
		}
		if (flag && num22 == num20 - 12)
		{
			char[] array9 = new char[num26];
			for (int k = 0; k < num26; k++)
			{
				array9[k] = (char)array8[k];
			}
			value = new string(array9);
		}
		else
		{
			value = Encoding.Unicode.GetString(array8, 0, array8.Length);
		}
		num22 += 1611929619 - num + num2 + (num22 & 3) << 5;
		if (num22 != num20 - 12 + ((num ^ -533452333 ^ num2) + ((num20 - 12) & 3) << 5))
		{
			int num27 = (num18 + _0002) ^ (num + -1610992924 - num2) ^ (num22 & ((-78951103 - num) ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = (num ^ 0x1FCBD60A) + num2;
			stringBuilder.Append((char)(byte)num3);
			value = num27.ToString(stringBuilder.ToString());
		}
		if (!flag3 && _0003)
		{
			value = string.Intern(value);
			_000F_2004_2000.m__0002[_0002] = value;
			if (_000F_2004_2000.m__0002.Count == ((-78949662 - num) ^ num2))
			{
				lock (_000F_2004_2000.m__0002)
				{
					_000F_2004_2000.m__0003._0002();
					_000F_2004_2000.m__0003 = null;
					_0005 = null;
					_000E = null;
					return value;
				}
			}
		}
		return value;
	}

	private static AssemblyName _0002(Assembly _0002)
	{
		try
		{
			return _0002.GetName();
		}
		catch
		{
			return new AssemblyName(_0002.FullName);
		}
	}

	private static byte[] _0002(AssemblyName _0002)
	{
		byte[] array = _0002.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	private static void _0002(byte[] _0002, int _0003, byte[] _0005)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0005.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0002[_0003++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0002[_0003] >> 2) + 3;
				int num6 = ((_0002[_0003] << 8) | _0002[_0003 + 1]) & 0x3FF;
				_0003 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0005[num++] = _0005[num7++];
				}
			}
			else
			{
				_0005[num++] = _0002[_0003++];
			}
		}
	}
}
internal static class _000F_2005
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	private struct a1
	{
	}

	private static readonly _0005_200B m__0002 = _0005_200B._0003(65537uL);

	private static readonly byte[] _0003 = _000F_2005._0002();

	private static _0008_2000 _0005;

	private static readonly object _0008 = new object();

	private static bool _0006;

	internal static a1 a1/* Not supported: data(BE 52 3B 32 08 6C 59 4F 33 A7 6E 54 9D 5F E9 7F 3A 17 ED ED 0F C5 57 C9 88 2E 93 B9 C3 67 6B DE 76 3B E8 4C 22 BB A8 EE 58 1A 19 5F 4F B1 4B D5 26 B4 45 30 AB B5 68 51 E8 42 00 07 56 DA CC AC 39 9D 5B B5 3C 91 2B 72 FA 20 C0 11 0C BB 39 DB 9C B5 DB 51 C7 2B FC C6 31 30 2A 28 93 40 15 A6 C8 D1 07 B6 8F 5B 7E B6 D2 64 47 26 CD 37 0F A1 34 3D 46 75 64 10 74 D8 A9 D0 C9 C1 21 2A DC 20 A9 31 B7 E7 61 9B 4D 08 A9 11 16 64 71 2B 41 44 26 1F 49 CD 91 E3 61 E6 3D 90 06 49 A2 8C 98 50 AC 81 01 AB 03 60 2B 4A 5F 3B 16 6D 50 E6 0C A3 72 83 DC BB F6 B2 92 B2 3C DF CD 05 BE C6 E3 CE A2 4D 75 B0 6B 70 CD EE C0 51 B3 E1 96 0E A8 24 C3 E5 4F CB EC 7F 2D 1A A8 79 F3 1A AE DA 4D 28 79 2E 93 8E 72 A4 DB 39 C1 9B 55 EA BE DD A7 80 FD 8D 1B 73 C1 FB 08 09 77 9A E1 86 69 5D 45 AD) */;

	private static void _0002()
	{
		if (_0006)
		{
			return;
		}
		lock (_0008)
		{
			if (!_0006)
			{
				_0005_200B obj = new _0005_200B(1, _0003);
				_000F_2000 obj2 = new _000F_2000(_0002: false, obj, _000F_2005.m__0002);
				_0005 = new _0008_2000(_0002: true, obj2);
				_0006 = true;
			}
		}
	}

	private static byte[] _0002()
	{
		return new byte[256]
		{
			190, 82, 59, 50, 8, 108, 89, 79, 51, 167,
			110, 84, 157, 95, 233, 127, 58, 23, 237, 237,
			15, 197, 87, 201, 136, 46, 147, 185, 195, 103,
			107, 222, 118, 59, 232, 76, 34, 187, 168, 238,
			88, 26, 25, 95, 79, 177, 75, 213, 38, 180,
			69, 48, 171, 181, 104, 81, 232, 66, 0, 7,
			86, 218, 204, 172, 57, 157, 91, 181, 60, 145,
			43, 114, 250, 32, 192, 17, 12, 187, 57, 219,
			156, 181, 219, 81, 199, 43, 252, 198, 49, 48,
			42, 40, 147, 64, 21, 166, 200, 209, 7, 182,
			143, 91, 126, 182, 210, 100, 71, 38, 205, 55,
			15, 161, 52, 61, 70, 117, 100, 16, 116, 216,
			169, 208, 201, 193, 33, 42, 220, 32, 169, 49,
			183, 231, 97, 155, 77, 8, 169, 17, 22, 100,
			113, 43, 65, 68, 38, 31, 73, 205, 145, 227,
			97, 230, 61, 144, 6, 73, 162, 140, 152, 80,
			172, 129, 1, 171, 3, 96, 43, 74, 95, 59,
			22, 109, 80, 230, 12, 163, 114, 131, 220, 187,
			246, 178, 146, 178, 60, 223, 205, 5, 190, 198,
			227, 206, 162, 77, 117, 176, 107, 112, 205, 238,
			192, 81, 179, 225, 150, 14, 168, 36, 195, 229,
			79, 203, 236, 127, 45, 26, 168, 121, 243, 26,
			174, 218, 77, 40, 121, 46, 147, 142, 114, 164,
			219, 57, 193, 155, 85, 234, 190, 221, 167, 128,
			253, 141, 27, 115, 193, 251, 8, 9, 119, 154,
			225, 134, 105, 93, 69, 173
		};
	}

	public static bool _0002(object _0002, byte[] _0003, ulong _0005)
	{
		if (_0003 == null)
		{
			return false;
		}
		if (_0002 == null)
		{
			return false;
		}
		_000F_2005._0002();
		byte[] array = _0006_200B._0002(_0002, _0005, _000F_2005._0005, null);
		return _000F_2005._0002(_0003, array);
	}

	private static bool _0002(byte[] _0002, byte[] _0003)
	{
		if (_0002.Length != _0003.Length)
		{
			return false;
		}
		for (int i = 0; i < _0002.Length; i++)
		{
			if (_0002[i] != _0003[i])
			{
				return false;
			}
		}
		return true;
	}

	public static byte[] _0002(object[] _0002, byte[] _0003, ulong _0005)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506765491));
		}
		if (_0003 == null)
		{
			throw new ArgumentNullException(_000F_2004_2000._0002(-1506765488));
		}
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < _0002.Length; i++)
			{
				byte[] array = _0006_200B._0002(_0002[i]);
				memoryStream.Write(array, 0, array.Length);
			}
			array2 = memoryStream.ToArray();
		}
		return new _0006_2007(array2, (long)_0005)._0002(_0003);
	}
}
internal interface _000F_2006
{
	int _000F_2006_200A_2002_0002();

	byte[] _000F_2006_200A_2002_0002();

	long _000F_2006_200A_2002_0002();
}
internal sealed class _000F_2007 : _000E_2001
{
	private new object m__0002;

	public _000F_2007()
		: base(8)
	{
	}

	public new object _0002()
	{
		return this.m__0002;
	}

	public void _0002(object _0002)
	{
		this.m__0002 = _0002;
	}

	public override object _000E_2001_200A_2002_0002()
	{
		return _0002();
	}

	public override void _000E_2001_200A_2002_0002(object _0002)
	{
		this._0002(_0002);
	}

	public override _000E_2001 _000E_2001_200A_2002_0002(_000E_2001 _0002)
	{
		base._0002(_0002._0002());
		this._0002(_0002._000E_2001_200A_2002_0002());
		return this;
	}

	public override _000E_2001 _000E_2001_200A_2002_0002()
	{
		_000F_2007 obj = new _000F_2007();
		obj._0002(this.m__0002);
		((_000E_2001)obj)._0002(base._0002());
		return obj;
	}
}
internal abstract class _000F_2008 : _0005_2008
{
	private new Type m__0002;

	public _000F_2008(int _0002)
		: base(_0002)
	{
	}

	public new Type _0002()
	{
		return this.m__0002;
	}

	public new void _0002(Type _0002)
	{
		this.m__0002 = _0002;
	}

	public abstract object _000F_2008_200A_2002_0002();

	public abstract void _000F_2008_200A_2002_0002(object _0002);

	public abstract bool _000F_2008_200A_2002_0002(_000F_2008 _0002);
}
internal sealed class _000F_2009
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	private struct _0002
	{
	}

	internal static readonly _0002 _0002/* Not supported: data(00 01 02 02 03 03 03 03 04 04 04 04 04 04 04 04 05 05 05 05 05 05 05 05 05 05 05 05 05 05 05 05 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08) */;

	internal static readonly _0002 _0003/* Not supported: data(A3 D7 09 83 F8 48 F6 F4 B3 21 15 78 99 B1 AF F9 E7 2D 4D 8A CE 4C CA 2E 52 95 D9 1E 4E 38 44 28 0A DF 02 A0 17 F1 60 68 12 B7 7A C3 E9 FA 3D 53 96 84 6B BA F2 63 9A 19 7C AE E5 F5 F7 16 6A A2 39 B6 7B 0F C1 93 81 1B EE B4 1A EA D0 91 2F B8 55 B9 DA 85 3F 41 BF E0 5A 58 80 5F 66 0B D8 90 35 D5 C0 A7 33 06 65 69 45 00 94 56 6D 98 9B 76 97 FC B2 C2 B0 FE DB 20 E1 EB D6 E4 DD 47 4A 1D 42 ED 9E 6E 49 3C CD 43 27 D2 07 D4 DE C7 67 18 89 CB 30 1F 8D C6 8F AA C8 74 DC C9 5D 5C 31 A4 70 88 61 2C 9F 0D 2B 87 50 82 54 64 26 7D 03 40 34 4B 1C 73 D1 C4 FD 3B CC FB 7F AB E6 3E 5B A5 AD 04 23 9C 14 51 22 F0 29 79 71 7E FF 8C 0E E2 0C EF BC 72 75 6F 37 A1 EC D3 8E 62 8B 86 10 E8 08 77 11 BE 92 4F 24 C5 32 36 9D CF F3 A6 BB AC 5E 6C A9 13 57 25 B5 E3 BD A8 3A 01 05 59 2A 46) */;
}
internal static class _000F_200A
{
	private static class _0002
	{
		public static readonly Dictionary<Type, int> _0002 = new Dictionary<Type, int>
		{
			{
				typeof(object),
				8
			},
			{
				typeof(byte),
				21
			},
			{
				typeof(sbyte),
				19
			},
			{
				typeof(short),
				6
			},
			{
				typeof(int),
				16
			},
			{
				typeof(long),
				26
			},
			{
				typeof(ushort),
				25
			},
			{
				typeof(uint),
				10
			},
			{
				typeof(ulong),
				23
			},
			{
				typeof(IntPtr),
				24
			},
			{
				typeof(UIntPtr),
				7
			},
			{
				typeof(float),
				0
			},
			{
				typeof(double),
				14
			},
			{
				typeof(bool),
				20
			},
			{
				typeof(char),
				11
			},
			{
				typeof(string),
				22
			}
		};
	}

	public static readonly Type _0002 = typeof(object);

	public static readonly Type _0003 = typeof(ValueType);

	public static readonly Type _0005 = typeof(Enum);

	public static readonly Type _0008 = typeof(Nullable<>);

	public static readonly Type _0006 = typeof(void);

	public static readonly Assembly _000E = typeof(_000F_200A).Assembly;

	public static bool _0002(Type _0002)
	{
		if (_0002.IsGenericType && !_0002.IsGenericTypeDefinition)
		{
			return (object)_0002.GetGenericTypeDefinition() == _0008;
		}
		return false;
	}

	public static Type _0002(Type _0002)
	{
		while (_0002.HasElementType)
		{
			_0002 = _0002.GetElementType();
		}
		return _0002;
	}

	public static Type _0003(Type _0002)
	{
		if (_0002.HasElementType && !_0002.IsArray)
		{
			_0002 = _0002.GetElementType();
		}
		return _0002;
	}

	public static Stack<_000E_200A> _0002(Type _0002)
	{
		Stack<_000E_200A> stack = new Stack<_000E_200A>();
		Type type = _0002;
		while (true)
		{
			_000E_200A item;
			if (type.IsArray)
			{
				item = new _000E_200A
				{
					_0002 = 0,
					_0003 = type.GetArrayRank()
				};
				stack.Push(item);
			}
			else if (type.IsByRef)
			{
				item = new _000E_200A
				{
					_0002 = 2
				};
				stack.Push(item);
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				item = new _000E_200A
				{
					_0002 = 1
				};
				stack.Push(item);
			}
			type = type.GetElementType();
		}
		return stack;
	}

	public static Stack<_000E_200A> _0002(string _0002)
	{
		string text = _0002;
		Stack<_000E_200A> stack = new Stack<_000E_200A>();
		while (true)
		{
			_000E_200A item;
			if (text.EndsWith(_000F_2004_2000._0002(-1506763021), StringComparison.Ordinal))
			{
				item = new _000E_200A
				{
					_0002 = 2
				};
				stack.Push(item);
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			if (text.EndsWith(_000F_2004_2000._0002(-1506763013), StringComparison.Ordinal))
			{
				item = new _000E_200A
				{
					_0002 = 1
				};
				stack.Push(item);
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			if (text.EndsWith(_000F_2004_2000._0002(-1506763069), StringComparison.Ordinal))
			{
				item = new _000E_200A
				{
					_0002 = 0,
					_0003 = 1
				};
				stack.Push(item);
				text = text.Substring(0, text.Length - 2);
				continue;
			}
			if (!text.EndsWith(_000F_2004_2000._0002(-1506763052), StringComparison.Ordinal))
			{
				break;
			}
			int num = 1;
			int num2 = -1;
			for (int num3 = text.Length - 2; num3 >= 0; num3--)
			{
				switch (text[num3])
				{
				case ',':
					num++;
					break;
				case '[':
					num2 = num3;
					num3 = -1;
					break;
				default:
					throw new InvalidOperationException(_000F_2004_2000._0002(-1506763043));
				}
			}
			if (num2 < 0)
			{
				throw new InvalidOperationException(_000F_2004_2000._0002(-1506763101));
			}
			text = text.Substring(0, num2);
			item = new _000E_200A
			{
				_0002 = 0,
				_0003 = num
			};
			stack.Push(item);
		}
		return stack;
	}

	public static Type _0002(Type _0002, Stack<_000E_200A> _0003)
	{
		Type type = _0002;
		while (_0003.Count > 0)
		{
			_000E_200A obj = _0003.Pop();
			switch (obj._0002)
			{
			case 0:
				type = ((obj._0003 != 1) ? type.MakeArrayType(obj._0003) : type.MakeArrayType());
				break;
			case 2:
				type = type.MakeByRefType();
				break;
			case 1:
				type = type.MakePointerType();
				break;
			}
		}
		return type;
	}

	public static int _0002(Type _0002)
	{
		if (_000F_200A._0002._0002.TryGetValue(_0002, out var value))
		{
			return value;
		}
		if (_0002.IsArray)
		{
			return 1;
		}
		if (_0002.IsValueType)
		{
			if (_0002.IsSubclassOf(_0005))
			{
				return 15;
			}
			if (_000F_200A._0002(_0002))
			{
				return 9;
			}
			return 4;
		}
		return 2;
	}
}
