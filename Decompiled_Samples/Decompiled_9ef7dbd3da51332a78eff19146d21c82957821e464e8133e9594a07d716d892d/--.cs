using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

internal sealed class _0002_200B : _0005_2004
{
	private readonly int m__0002;

	private readonly Stream _0003;

	public _0002_200B(Stream _0002, int _0003)
	{
		this._0003 = _0002;
		this.m__0002 = _0003 ^ -559030707;
	}

	public Stream _0002()
	{
		return _0003;
	}

	public override bool _0005_2004_200A_2002_0002()
	{
		return _0002().CanRead;
	}

	public override bool _0005_2004_200A_2002_0005()
	{
		return _0002().CanSeek;
	}

	public override bool _0005_2004_200A_2002_0003()
	{
		return _0002().CanWrite;
	}

	public override void _0005_2004_200A_2002_0003()
	{
		_0002().Flush();
	}

	public override long _0005_2004_200A_2002_0002()
	{
		return _0002().Length;
	}

	public override long _0005_2004_200A_2002_0003()
	{
		return _0002().Position;
	}

	public override void _0005_2004_200A_2002_0002(long _0002)
	{
		this._0002().Position = _0002;
	}

	private byte _0002(byte _0002, uint _0003)
	{
		byte b = (byte)((uint)this.m__0002 ^ _0003);
		return (byte)(_0002 ^ b);
	}

	public override void _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005)
	{
		uint num = (uint)((_0005_2004)this)._0005_2004_200A_2002_0003();
		byte[] array = new byte[_0005];
		for (uint num2 = 0u; num2 < _0005; num2++)
		{
			array[num2] = this._0002(_0002[num2 + _0003], num + num2);
		}
		this._0002().Write(array, 0, _0005);
	}

	public override int _0005_2004_200A_2002_0002(byte[] _0002, int _0003, int _0005)
	{
		uint num = (uint)((_0005_2004)this)._0005_2004_200A_2002_0003();
		int num2 = this._0002().Read(_0002, _0003, _0005);
		int num3 = _0003 + num2;
		for (int i = _0003; i < num3; i++)
		{
			_0002[i] = this._0002(_0002[i], num++);
		}
		return num2;
	}

	public override long _0005_2004_200A_2002_0002(long _0002, int _0003)
	{
		SeekOrigin origin = _0003 switch
		{
			0 => SeekOrigin.Begin, 
			1 => SeekOrigin.Current, 
			2 => SeekOrigin.End, 
			_ => throw new ArgumentException(), 
		};
		return this._0002().Seek(_0002, origin);
	}

	public override void _0005_2004_200A_2002_0003(long _0002)
	{
		this._0002().SetLength(_0002);
	}
}
internal sealed class _0003_200B
{
	public readonly _0008_200B _0005_2002_2000 = new _0008_200B(-457272178, 9);

	public readonly _0008_200B _000F_2008 = new _0008_200B(-1128631859, 12);

	public readonly _0008_200B _0008_2002 = new _0008_200B(-2079309953, 12);

	public readonly _0008_200B _000F_2000_2001 = new _0008_200B(-275605741, 12);

	public readonly _0008_200B _000E_2008 = new _0008_200B(-1779857312, 12);

	public readonly _0008_200B _0006_2002_2000 = new _0008_200B(315949562, 12);

	public readonly _0008_200B _0006_2001 = new _0008_200B(269208340, 3);

	public readonly _0008_200B _0008_2004_2000 = new _0008_200B(-1934041653, 12);

	public readonly _0008_200B _0005_2004_2000 = new _0008_200B(-292633540, 12);

	public readonly _0008_200B _0006_2003_2000 = new _0008_200B(1927308835, 9);

	public readonly _0008_200B _0003_2009_2000 = new _0008_200B(-27682408, 12);

	public readonly _0008_200B _0005_2005 = new _0008_200B(1968985251, 12);

	public readonly _0008_200B _0008_2005_2000 = new _0008_200B(-448626527, 12);

	public readonly _0008_200B _0002_2009 = new _0008_200B(829958644, 12);

	public readonly _0008_200B _0002_2001 = new _0008_200B(-1841312808, 12);

	public readonly _0008_200B _000F_2000 = new _0008_200B(-863011457, 12);

	public readonly _0008_200B _0003_2001_2000 = new _0008_200B(337120127, 12);

	public readonly _0008_200B _0005_2007_2000 = new _0008_200B(1690701096, 12);

	public readonly _0008_200B _0003_2001_2001 = new _0008_200B(759434256, 12);

	public readonly _0008_200B _0002_2004_2001 = new _0008_200B(1883665526, 9);

	public readonly _0008_200B _000F_2004_2001 = new _0008_200B(997596958, 12);

	public readonly _0008_200B _000E_200A = new _0008_200B(-229224310, 9);

	public readonly _0008_200B _0008_200A = new _0008_200B(40092736, 12);

	public readonly _0008_200B _0002_2002_2000 = new _0008_200B(1341463208, 12);

	public readonly _0008_200B _000F_200A_2000 = new _0008_200B(250209302, 9);

	public readonly _0008_200B _000E_2000 = new _0008_200B(267413517, 12);

	public readonly _0008_200B _000E_2003_2000 = new _0008_200B(1035008134, 12);

	public readonly _0008_200B _0003_2003_2000 = new _0008_200B(-578174777, 12);

	public readonly _0008_200B _000E_200A_2000 = new _0008_200B(606657790, 1);

	public readonly _0008_200B _0008_2003_2000 = new _0008_200B(-533916274, 10);

	public readonly _0008_200B _0002_2004 = new _0008_200B(1807158168, 12);

	public readonly _0008_200B _000E_2000_2001 = new _0008_200B(-218048768, 5);

	public readonly _0008_200B _0005_2001_2000 = new _0008_200B(1114334149, 10);

	public readonly _0008_200B _0008_200B_2000 = new _0008_200B(1321938690, 12);

	public readonly _0008_200B _0005_2003_2001 = new _0008_200B(-1756393470, 12);

	public readonly _0008_200B _0003_2001 = new _0008_200B(-952941562, 12);

	public readonly _0008_200B _000F_2002_2000 = new _0008_200B(-1288173049, 9);

	public readonly _0008_200B _0008_2005_2001 = new _0008_200B(602843432, 12);

	public readonly _0008_200B _0002_2000 = new _0008_200B(824176988, 12);

	public readonly _0008_200B _0003 = new _0008_200B(-1544929882, 12);

	public readonly _0008_200B _0003_2009 = new _0008_200B(-1760696722, 9);

	public readonly _0008_200B _000E_2001_2000 = new _0008_200B(-2000055727, 9);

	public readonly _0008_200B _0003_2004_2001 = new _0008_200B(531710305, 9);

	public readonly _0008_200B _0002_2000_2000 = new _0008_200B(-1097650086, 12);

	public readonly _0008_200B _0006_200B = new _0008_200B(1605466604, 12);

	public readonly _0008_200B _000E_2009 = new _0008_200B(-1470579649, 12);

	public readonly _0008_200B _000E = new _0008_200B(1946990849, 12);

	public readonly _0008_200B _0003_2006_2000 = new _0008_200B(-412163820, 10);

	public readonly _0008_200B _000E_2008_2000 = new _0008_200B(-1895992422, 12);

	public readonly _0008_200B _0006_2006_2000 = new _0008_200B(-529976492, 12);

	public readonly _0008_200B _0003_2002_2001 = new _0008_200B(-1669223277, 9);

	public readonly _0008_200B _0002 = new _0008_200B(501643013, 12);

	public readonly _0008_200B _0005_2003 = new _0008_200B(-1612762092, 12);

	public readonly _0008_200B _000E_2002_2000 = new _0008_200B(438414131, 10);

	public readonly _0008_200B _000F_2001_2001 = new _0008_200B(818545048, 12);

	public readonly _0008_200B _0006_2005 = new _0008_200B(-1608201352, 12);

	public readonly _0008_200B _0005_2001 = new _0008_200B(-1733205973, 12);

	public readonly _0008_200B _0002_2003_2001 = new _0008_200B(-1409468299, 9);

	public readonly _0008_200B _0002_2008 = new _0008_200B(-654440495, 7);

	public readonly _0008_200B _0005_2004_2001 = new _0008_200B(-432480248, 12);

	public readonly _0008_200B _0003_2000_2001 = new _0008_200B(1279025420, 10);

	public readonly _0008_200B _0005_2007 = new _0008_200B(1404113189, 12);

	public readonly _0008_200B _000E_2006 = new _0008_200B(-510343864, 9);

	public readonly _0008_200B _0003_2003_2001 = new _0008_200B(-125414199, 12);

	public readonly _0008_200B _0006_200B_2000 = new _0008_200B(-416293340, 12);

	public readonly _0008_200B _000F_2003_2000 = new _0008_200B(-698109478, 12);

	public readonly _0008_200B _000E_2006_2000 = new _0008_200B(-1870463281, 9);

	public readonly _0008_200B _0006_2004_2001 = new _0008_200B(1676959874, 12);

	public readonly _0008_200B _0005_2000_2001 = new _0008_200B(1529948071, 9);

	public readonly _0008_200B _000F_2004 = new _0008_200B(1525360919, 12);

	public readonly _0008_200B _0002_2005_2000 = new _0008_200B(1763103639, 10);

	public readonly _0008_200B _0005_2008_2000 = new _0008_200B(-1565452196, 12);

	public readonly _0008_200B _0008_2003_2001 = new _0008_200B(1421992181, 12);

	public readonly _0008_200B _0002_2001_2001 = new _0008_200B(-13244278, 12);

	public readonly _0008_200B _0002_200B = new _0008_200B(-1729069227, 12);

	public readonly _0008_200B _0008_2004_2001 = new _0008_200B(1390639392, 12);

	public readonly _0008_200B _0005_2002_2001 = new _0008_200B(2070960475, 12);

	public readonly _0008_200B _0003_200A_2000 = new _0008_200B(-226656288, 12);

	public readonly _0008_200B _000F_2002 = new _0008_200B(1797736067, 9);

	public readonly _0008_200B _000E_200B = new _0008_200B(2073304576, 9);

	public readonly _0008_200B _000E_200B_2000 = new _0008_200B(-1141892707, 12);

	public readonly _0008_200B _0002_2004_2000 = new _0008_200B(-1859289398, 3);

	public readonly _0008_200B _0008_2009_2000 = new _0008_200B(-888710377, 12);

	public readonly _0008_200B _0002_2008_2000 = new _0008_200B(293335208, 12);

	public readonly _0008_200B _000F_2000_2000 = new _0008_200B(-771447234, 12);

	public readonly _0008_200B _000E_2003_2001 = new _0008_200B(-82496809, 12);

	public readonly _0008_200B _0003_2006 = new _0008_200B(1106168484, 12);

	public readonly _0008_200B _000E_2007 = new _0008_200B(947541632, 12);

	public readonly _0008_200B _0002_2002 = new _0008_200B(-2133354822, 12);

	public readonly _0008_200B _0002_200B_2000 = new _0008_200B(1999924419, 12);

	public readonly _0008_200B _0008_2001 = new _0008_200B(-1704702094, 12);

	public readonly _0008_200B _0006_2009_2000 = new _0008_200B(491537387, 9);

	public readonly _0008_200B _000F_200B = new _0008_200B(-1820908955, 12);

	public readonly _0008_200B _0006_2000_2001 = new _0008_200B(2020490657, 12);

	public readonly _0008_200B _0008_2002_2000 = new _0008_200B(-1639421099, 9);

	public readonly _0008_200B _0003_2000_2000 = new _0008_200B(-1375545679, 12);

	public readonly _0008_200B _0008_2008 = new _0008_200B(-455785747, 12);

	public readonly _0008_200B _0006_2002 = new _0008_200B(16630305, 12);

	public readonly _0008_200B _000E_2005_2001 = new _0008_200B(-1271436966, 12);

	public readonly _0008_200B _0003_2007 = new _0008_200B(-1099008950, 12);

	public readonly _0008_200B _0008_2001_2000 = new _0008_200B(1427525700, 12);

	public readonly _0008_200B _0002_200A = new _0008_200B(-802792356, 12);

	public readonly _0008_200B _0003_2003 = new _0008_200B(-559056522, 12);

	public readonly _0008_200B _000F_2001 = new _0008_200B(2030847661, 9);

	public readonly _0008_200B _0005_2009 = new _0008_200B(724141251, 12);

	public readonly _0008_200B _0006_2000 = new _0008_200B(-1321428350, 9);

	public readonly _0008_200B _0008_2006 = new _0008_200B(1422751467, 12);

	public readonly _0008_200B _0008_2007 = new _0008_200B(974583377, 12);

	public readonly _0008_200B _0006_2001_2001 = new _0008_200B(-1678072077, 12);

	public readonly _0008_200B _0003_2004 = new _0008_200B(-1868025355, 12);

	public readonly _0008_200B _000F_2005_2000 = new _0008_200B(155665836, 9);

	public readonly _0008_200B _0008_2000_2001 = new _0008_200B(-1152897737, 0);

	public readonly _0008_200B _000E_2003 = new _0008_200B(-1742587450, 1);

	public readonly _0008_200B _000F_200A = new _0008_200B(-1208495970, 12);

	public readonly _0008_200B _0002_2002_2001 = new _0008_200B(-1519091198, 12);

	public readonly _0008_200B _0005_2005_2001 = new _0008_200B(2018739371, 12);

	public readonly _0008_200B _0006_200A = new _0008_200B(-655879482, 12);

	public readonly _0008_200B _0008_2005 = new _0008_200B(1730234995, 9);

	public readonly _0008_200B _000F_2009 = new _0008_200B(2108435091, 12);

	public readonly _0008_200B _0005_2006_2000 = new _0008_200B(273862478, 12);

	public readonly _0008_200B _0002_200A_2000 = new _0008_200B(-481175914, 10);

	public readonly _0008_200B _0003_2005_2000 = new _0008_200B(-79138455, 12);

	public readonly _0008_200B _0003_200A = new _0008_200B(2066650143, 12);

	public readonly _0008_200B _000F_2003 = new _0008_200B(-1474519485, 1);

	public readonly _0008_200B _0006_2000_2000 = new _0008_200B(-1214175959, 12);

	public readonly _0008_200B _0005_2008 = new _0008_200B(-101179618, 12);

	public readonly _0008_200B _0002_2006_2000 = new _0008_200B(79115414, 10);

	public readonly _0008_200B _0008_2002_2001 = new _0008_200B(642714800, 12);

	public readonly _0008_200B _000E_2002_2001 = new _0008_200B(2134049203, 1);

	public readonly _0008_200B _0002_2009_2000 = new _0008_200B(-370132955, 12);

	public readonly _0008_200B _0003_200B = new _0008_200B(-371103253, 12);

	public readonly _0008_200B _0005 = new _0008_200B(145070475, 9);

	public readonly _0008_200B _000F_2007_2000 = new _0008_200B(-41124306, 9);

	public readonly _0008_200B _000E_2004_2001 = new _0008_200B(-772296560, 12);

	public readonly _0008_200B _0005_2002 = new _0008_200B(639072560, 12);

	public readonly _0008_200B _0008_200B = new _0008_200B(-1356030400, 12);

	public readonly _0008_200B _0005_200A_2000 = new _0008_200B(768827467, 12);

	public readonly _0008_200B _0006_2005_2001 = new _0008_200B(1368965796, 9);

	public readonly _0008_200B _0002_2001_2000 = new _0008_200B(-1183379296, 12);

	public readonly _0008_200B _0008_2009 = new _0008_200B(-76403473, 12);

	public readonly _0008_200B _0006_2008_2000 = new _0008_200B(1608212499, 9);

	public readonly _0008_200B _000E_2009_2000 = new _0008_200B(-2044097592, 12);

	public readonly _0008_200B _0005_200B = new _0008_200B(-325687733, 10);

	public readonly _0008_200B _0002_2007_2000 = new _0008_200B(-1049825729, 12);

	public readonly _0008_200B _0005_2006 = new _0008_200B(101592254, 9);

	public readonly _0008_200B _0005_2001_2001 = new _0008_200B(300938022, 12);

	public readonly _0008_200B _000E_2000_2000 = new _0008_200B(-1195910363, 12);

	public readonly _0008_200B _0006_2003 = new _0008_200B(-200713078, 12);

	public readonly _0008_200B _0003_2002 = new _0008_200B(1329222698, 12);

	public readonly _0008_200B _0008 = new _0008_200B(-641035423, 12);

	public readonly _0008_200B _0006_2005_2000 = new _0008_200B(-248057046, 12);

	public readonly _0008_200B _0006_2009 = new _0008_200B(-1309368863, 12);

	public readonly _0008_200B _000E_2005 = new _0008_200B(1683028270, 12);

	public readonly _0008_200B _000F = new _0008_200B(210724025, 12);

	public readonly _0008_200B _0002_2003 = new _0008_200B(1847014184, 12);

	public readonly _0008_200B _000F_2004_2000 = new _0008_200B(-228415522, 10);

	public readonly _0008_200B _0005_2000 = new _0008_200B(1498048711, 12);

	public readonly _0008_200B _0008_200A_2000 = new _0008_200B(1726162211, 3);

	public readonly _0008_200B _0005_2004 = new _0008_200B(-1932304029, 9);

	public readonly _0008_200B _0005_2005_2000 = new _0008_200B(64867856, 12);

	public readonly _0008_200B _000E_2001 = new _0008_200B(-1769457308, 10);

	public readonly _0008_200B _0002_2003_2000 = new _0008_200B(131266117, 12);

	public readonly _0008_200B _0008_2001_2001 = new _0008_200B(-826064038, 12);

	public readonly _0008_200B _0002_2007 = new _0008_200B(1316771421, 12);

	public readonly _0008_200B _000F_200B_2000 = new _0008_200B(1349986515, 12);

	public readonly _0008_200B _0002_2006 = new _0008_200B(-438533639, 12);

	public readonly _0008_200B _0003_2004_2000 = new _0008_200B(-637413371, 12);

	public readonly _0008_200B _0003_2000 = new _0008_200B(-200017264, 12);

	public readonly _0008_200B _0006_2008 = new _0008_200B(-1110190271, 12);

	public readonly _0008_200B _0006_2002_2001 = new _0008_200B(645035587, 12);

	public readonly _0008_200B _0006_2003_2001 = new _0008_200B(-875684315, 12);

	public readonly _0008_200B _000E_2004_2000 = new _0008_200B(-210354477, 12);

	public readonly _0008_200B _0008_2007_2000 = new _0008_200B(1020100784, 3);

	public readonly _0008_200B _0006_200A_2000 = new _0008_200B(-1520046085, 12);

	public readonly _0008_200B _000F_2002_2001 = new _0008_200B(50540823, 3);

	public readonly _0008_200B _0005_2009_2000 = new _0008_200B(1265958017, 12);

	public readonly _0008_200B _0008_2000_2000 = new _0008_200B(80286476, 12);

	public readonly _0008_200B _0003_2005 = new _0008_200B(-866100213, 12);

	public readonly _0008_200B _0003_2005_2001 = new _0008_200B(-1371540535, 12);

	public readonly _0008_200B _000E_2001_2001 = new _0008_200B(488828, 12);

	public readonly _0008_200B _0008_2000 = new _0008_200B(-1312616101, 12);

	public readonly _0008_200B _000F_2006_2000 = new _0008_200B(-122967581, 12);

	public readonly _0008_200B _000F_2006 = new _0008_200B(-819745553, 12);

	public readonly _0008_200B _000E_2007_2000 = new _0008_200B(-16415683, 3);

	public readonly _0008_200B _0005_200B_2000 = new _0008_200B(-25847938, 12);

	public readonly _0008_200B _0008_2008_2000 = new _0008_200B(-1986258764, 12);

	public readonly _0008_200B _0006_2007_2000 = new _0008_200B(-643001081, 10);

	public readonly _0008_200B _000F_2003_2001 = new _0008_200B(1727124034, 12);

	public readonly _0008_200B _000E_2004 = new _0008_200B(-568825377, 12);

	public readonly _0008_200B _0008_2004 = new _0008_200B(967786455, 12);

	public readonly _0008_200B _0006_2001_2000 = new _0008_200B(995340119, 12);

	public readonly _0008_200B _000F_2007 = new _0008_200B(530556437, 12);

	public readonly _0008_200B _000F_2009_2000 = new _0008_200B(-381858728, 9);

	public readonly _0008_200B _0003_2008_2000 = new _0008_200B(-417781882, 12);

	public readonly _0008_200B _0002_2005 = new _0008_200B(-1343092622, 8);

	public readonly _0008_200B _0003_2008 = new _0008_200B(-113651485, 12);

	public readonly _0008_200B _0002_2000_2001 = new _0008_200B(2095621737, 12);

	public readonly _0008_200B _000F_2005 = new _0008_200B(-1131339389, 1);

	public readonly _0008_200B _0006_2004 = new _0008_200B(-1009484405, 10);

	public readonly _0008_200B _0006_2006 = new _0008_200B(1688418899, 9);

	public readonly _0008_200B _0005_2003_2000 = new _0008_200B(1787201061, 12);

	public readonly _0008_200B _000F_2008_2000 = new _0008_200B(134579734, 12);

	private bool _0005_2000_2000;

	public readonly _0008_200B _000E_2002 = new _0008_200B(851902574, 9);

	public readonly _0008_200B _0006_2004_2000 = new _0008_200B(-1197584532, 12);

	public readonly _0008_200B _000F_2001_2000 = new _0008_200B(-2118421432, 1);

	public readonly _0008_200B _0003_2007_2000 = new _0008_200B(-274567195, 0);

	public readonly _0008_200B _0006_2007 = new _0008_200B(-136505100, 12);

	public readonly _0008_200B _0002_2005_2001 = new _0008_200B(664748400, 11);

	public readonly _0008_200B _0008_2003 = new _0008_200B(-1300931531, 2);

	public readonly _0008_200B _0005_200A = new _0008_200B(-1511072809, 12);

	public readonly _0008_200B _0003_2002_2000 = new _0008_200B(1968088130, 12);

	public readonly _0008_200B _000E_2005_2000 = new _0008_200B(-845517594, 11);

	public readonly _0008_200B _0006 = new _0008_200B(1021006544, 9);

	public readonly _0008_200B _0008_2006_2000 = new _0008_200B(-652524276, 10);

	public readonly _0008_200B _0003_200B_2000 = new _0008_200B(238014389, 12);

	public bool _0002()
	{
		return _0005_2000_2000;
	}

	public void _0002(bool _0002)
	{
		_0005_2000_2000 = _0002;
	}
}
internal sealed class _0005_200B
{
	private static readonly int[] m__0002;

	public static readonly _0005_200B _0003;

	public static readonly _0005_200B _0005;

	private static readonly byte[] m__0008;

	private int[] _0006;

	private int _000E;

	private int _000F = -1;

	private int _0002_2000;

	static _0005_200B()
	{
		_0005_200B.m__0002 = new int[0];
		_0005_200B.m__0008 = new byte[256]
		{
			0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
			4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8
		};
		_0005_200B._0003 = new _0005_200B(0, _0005_200B.m__0002, _0005: false);
		_0005_200B._0003._000F = 0;
		_0005_200B._0005 = _0002(1uL);
	}

	public _0005_200B(int _0002, int[] _0003, bool _0005)
	{
		if (_0005)
		{
			int i;
			for (i = 0; i < _0003.Length && _0003[i] == 0; i++)
			{
			}
			if (i == _0003.Length)
			{
				_000E = 0;
				_0006 = _0005_200B.m__0002;
				return;
			}
			_000E = _0002;
			if (i == 0)
			{
				_0006 = _0003;
				return;
			}
			_0006 = new int[_0003.Length - i];
			Array.Copy(_0003, i, _0006, 0, _0006.Length);
		}
		else
		{
			_000E = _0002;
			_0006 = _0003;
		}
	}

	public _0005_200B(int _0002, byte[] _0003)
		: this(_0002, _0003, 0, _0003.Length)
	{
	}

	public _0005_200B(int _0002, byte[] _0003, int _0005, int _0008)
	{
		if (_0002 == 0)
		{
			_000E = 0;
			_0006 = _0005_200B.m__0002;
		}
		else
		{
			_0006 = _0005_200B._0002(_0003, _0005, _0008);
			_000E = ((_0006.Length >= 1) ? _0002 : 0);
		}
	}

	public int[] _0002()
	{
		return _0006;
	}

	private static int _0002(int _0002)
	{
		return (_0002 + 8 - 1) / 8;
	}

	private static int[] _0002(byte[] _0002, int _0003, int _0005)
	{
		int num = _0003 + _0005;
		int i;
		for (i = _0003; i < num && _0002[i] == 0; i++)
		{
		}
		if (i >= num)
		{
			return _0005_200B.m__0002;
		}
		int num2 = (num - i + 3) / 4;
		int num3 = (num - i) % 4;
		if (num3 == 0)
		{
			num3 = 4;
		}
		if (num2 < 1)
		{
			return _0005_200B.m__0002;
		}
		int[] array = new int[num2];
		int num4 = 0;
		int num5 = 0;
		for (int j = i; j < num; j++)
		{
			num4 <<= 8;
			num4 |= _0002[j] & 0xFF;
			num3--;
			if (num3 <= 0)
			{
				array[num5] = num4;
				num5++;
				num3 = 4;
				num4 = 0;
			}
		}
		if (num5 < array.Length)
		{
			array[num5] = num4;
		}
		return array;
	}

	private static int _0002(int _0002, int _0003, int[] _0005)
	{
		while (true)
		{
			if (_0003 >= _0005.Length)
			{
				return 0;
			}
			if (_0005[_0003] != 0)
			{
				break;
			}
			_0003++;
		}
		int num = 32 * (_0005.Length - _0003 - 1);
		int num2 = _0005[_0003];
		return num + _0005_200B._0003(num2);
	}

	public int _0002()
	{
		if (_000F == -1)
		{
			_000F = ((_000E != 0) ? _0002(_000E, 0, _0006) : 0);
		}
		return _000F;
	}

	private static int _0003(int _0002)
	{
		uint num = (uint)_0002 >> 24;
		if (num != 0)
		{
			return 24 + _0005_200B.m__0008[num];
		}
		num = (uint)_0002 >> 16;
		if (num != 0)
		{
			return 16 + _0005_200B.m__0008[num];
		}
		num = (uint)_0002 >> 8;
		if (num != 0)
		{
			return 8 + _0005_200B.m__0008[num];
		}
		return _0005_200B.m__0008[_0002];
	}

	public int _0002(object _0002)
	{
		return this._0002((_0005_200B)_0002);
	}

	private static int _0002(int _0002, int[] _0003, int _0005, int[] _0008)
	{
		while (_0002 != _0003.Length && _0003[_0002] == 0)
		{
			_0002++;
		}
		while (_0005 != _0008.Length && _0008[_0005] == 0)
		{
			_0005++;
		}
		return _0005_200B._0003(_0002, _0003, _0005, _0008);
	}

	private static int _0003(int _0002, int[] _0003, int _0005, int[] _0008)
	{
		int num = _0003.Length - _0008.Length - (_0002 - _0005);
		if (num != 0)
		{
			if (num >= 0)
			{
				return 1;
			}
			return -1;
		}
		while (_0002 < _0003.Length)
		{
			uint num2 = (uint)_0003[_0002++];
			uint num3 = (uint)_0008[_0005++];
			if (num2 != num3)
			{
				if (num2 >= num3)
				{
					return 1;
				}
				return -1;
			}
		}
		return 0;
	}

	public int _0002(_0005_200B _0002)
	{
		if (_000E >= _0002._000E)
		{
			if (_000E <= _0002._000E)
			{
				if (_000E != 0)
				{
					return _000E * _0003(0, _0006, 0, _0002._0006);
				}
				return 0;
			}
			return 1;
		}
		return -1;
	}

	public override bool Equals(object _0002)
	{
		if (_0002 == this)
		{
			return true;
		}
		_0005_200B obj = _0002 as _0005_200B;
		if (obj == null)
		{
			return false;
		}
		if (_000E == obj._000E)
		{
			return this._0002(obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = _0006.Length;
		if (_0006.Length != 0)
		{
			num ^= _0006[0];
			if (_0006.Length > 1)
			{
				num ^= _0006[_0006.Length - 1];
			}
		}
		return num;
	}

	private bool _0002(_0005_200B _0002)
	{
		_ = _0002._0006;
		if (_0006.Length != _0002._0006.Length)
		{
			return false;
		}
		for (int i = 0; i < _0006.Length; i++)
		{
			if (_0006[i] != _0002._0006[i])
			{
				return false;
			}
		}
		return true;
	}

	public _0005_200B _0002(_0005_200B _0002, _0005_200B _0003)
	{
		if (_0003.Equals(_0005_200B._0005))
		{
			return _0005_200B._0003;
		}
		if (_0002._000E == 0)
		{
			return _0005_200B._0005;
		}
		if (_000E == 0)
		{
			return _0005_200B._0003;
		}
		_0005_200B obj = this;
		if (!_0002.Equals(_0005_200B._0005))
		{
			obj = _0005_200B._0002(obj, _0002._0006[0], _0003);
		}
		return obj;
	}

	private static _0005_200B _0002(_0005_200B _0002, int _0003, _0005_200B _0005)
	{
		int num = _0005._0006.Length;
		int num2 = 32 * num;
		bool flag = _0005._0002() + 2 <= num2;
		uint num3 = (uint)_0005._0003();
		_0002 = _0002._0002(num2)._0002(_0005);
		int[] array = new int[num + 1];
		int[] array2 = _0002._0006;
		if (array2.Length < num)
		{
			int[] array3 = new int[num];
			Buffer.BlockCopy(array2, 0, array3, num - array2.Length, array2.Length * 4);
			array2 = array3;
		}
		int[] array4 = _0005_200B._0002(array2);
		_0005_200B._0002(array, array4, _0005._0006, num3, flag);
		int[] array5 = _0005_200B._0002(_0003);
		int num4 = array5[0];
		int num5 = num4 >> 8;
		num5--;
		int num6 = 1;
		while ((num4 = array5[num6++]) != -1)
		{
			int num7 = num5 + 1;
			for (int i = 0; i < num7; i++)
			{
				_0005_200B._0002(array, array4, _0005._0006, num3, flag);
			}
			_0005_200B._0002(array, array4, array2, _0005._0006, num3, flag);
			num5 = num4 >> 8;
		}
		for (int j = 0; j < num5; j++)
		{
			_0005_200B._0002(array, array4, _0005._0006, num3, flag);
		}
		_0005_200B._0002(array4, _0005._0006, num3);
		return new _0005_200B(1, array4, _0005: true);
	}

	private static int _0005(int _0002)
	{
		int num = _0002 + (((_0002 + 1) & 4) << 1);
		num *= 2 - _0002 * num;
		num *= 2 - _0002 * num;
		return num * (2 - _0002 * num);
	}

	private int _0003()
	{
		if (_0002_2000 != 0)
		{
			return _0002_2000;
		}
		int num = -_0006[_0006.Length - 1];
		return _0002_2000 = _0005(num);
	}

	private static void _0002(int[] _0002, int[] _0003, uint _0005)
	{
		int num = _0003.Length;
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			uint num3 = (uint)_0002[num - 1];
			ulong num4 = num3 * _0005;
			ulong num5 = num4 * (uint)_0003[num - 1] + num3;
			num5 >>= 32;
			for (int num6 = num - 2; num6 >= 0; num6--)
			{
				num5 += num4 * (uint)_0003[num6] + (uint)_0002[num6];
				_0002[num6 + 1] = (int)num5;
				num5 >>= 32;
			}
			_0002[0] = (int)num5;
		}
		if (_0005_200B._0002(0, _0002, 0, _0003) >= 0)
		{
			_0005_200B._0002(0, _0002, 0, _0003);
		}
	}

	private static void _0002(int[] _0002, int[] _0003, int[] _0005, int[] _0008, uint _0006, bool _000E)
	{
		int num = _0008.Length;
		if (num == 1)
		{
			_0003[0] = (int)_0005_200B._0002((uint)_0003[0], (uint)_0005[0], (uint)_0008[0], _0006);
			return;
		}
		uint num2 = (uint)_0005[num - 1];
		ulong num3 = (uint)_0003[num - 1];
		ulong num4 = num3 * num2;
		ulong num5 = (uint)(int)num4 * _0006;
		ulong num6 = num5 * (uint)_0008[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)_0005[num7];
			num6 = num5 * (uint)_0008[num7];
			num4 += (num8 & 0xFFFFFFFFu) + (uint)num6;
			_0002[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 32) + (num6 >> 32);
		}
		_0002[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)_0002[num];
			ulong num12 = (uint)_0003[num10];
			ulong num13 = num12 * num2;
			ulong num14 = (num13 & 0xFFFFFFFFu) + num11;
			ulong num15 = (uint)(int)num14 * _0006;
			ulong num16 = num15 * (uint)_0008[num - 1];
			num14 += (uint)num16;
			num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			for (int num17 = num - 2; num17 >= 0; num17--)
			{
				num13 = num12 * (uint)_0005[num17];
				num16 = num15 * (uint)_0008[num17];
				num14 += (num13 & 0xFFFFFFFFu) + (uint)num16 + (uint)_0002[num17 + 1];
				_0002[num17 + 2] = (int)num14;
				num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			}
			num14 += (uint)num9;
			_0002[1] = (int)num14;
			num9 = (int)(num14 >> 32);
		}
		_0002[0] = num9;
		if (!_000E && _0005_200B._0002(0, _0002, 0, _0008) >= 0)
		{
			_0005_200B._0002(0, _0002, 0, _0008);
		}
		Array.Copy(_0002, 1, _0003, 0, num);
	}

	private static void _0002(int[] _0002, int[] _0003, int[] _0005, uint _0008, bool _0006)
	{
		int num = _0005.Length;
		if (num == 1)
		{
			uint num2 = (uint)_0003[0];
			_0003[0] = (int)_0005_200B._0002(num2, num2, (uint)_0005[0], _0008);
			return;
		}
		ulong num3 = (uint)_0003[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (uint)(int)num4 * _0008;
		ulong num6 = num5 * (uint)_0005[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)_0003[num7];
			num6 = num5 * (uint)_0005[num7];
			num4 += (num6 & 0xFFFFFFFFu) + (uint)((int)num8 << 1);
			_0002[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 31) + (num6 >> 32);
		}
		_0002[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)_0002[num];
			ulong num12 = num11 * _0008;
			ulong num13 = num12 * (uint)_0005[num - 1] + num11;
			num13 >>= 32;
			for (int num14 = num - 2; num14 > num10; num14--)
			{
				num13 += num12 * (uint)_0005[num14] + (uint)_0002[num14 + 1];
				_0002[num14 + 2] = (int)num13;
				num13 >>= 32;
			}
			ulong num15 = (uint)_0003[num10];
			ulong num16 = num15 * num15;
			ulong num17 = num12 * (uint)_0005[num10];
			num13 += (num16 & 0xFFFFFFFFu) + (uint)num17 + (uint)_0002[num10 + 1];
			_0002[num10 + 2] = (int)num13;
			num13 = (num13 >> 32) + (num16 >> 32) + (num17 >> 32);
			for (int num18 = num10 - 1; num18 >= 0; num18--)
			{
				ulong num19 = num15 * (uint)_0003[num18];
				ulong num20 = num12 * (uint)_0005[num18];
				num13 += (num20 & 0xFFFFFFFFu) + (uint)((int)num19 << 1) + (uint)_0002[num18 + 1];
				_0002[num18 + 2] = (int)num13;
				num13 = (num13 >> 32) + (num19 >> 31) + (num20 >> 32);
			}
			num13 += (uint)num9;
			_0002[1] = (int)num13;
			num9 = (int)(num13 >> 32);
		}
		_0002[0] = num9;
		if (!_0006 && _0005_200B._0002(0, _0002, 0, _0005) >= 0)
		{
			_0005_200B._0002(0, _0002, 0, _0005);
		}
		Array.Copy(_0002, 1, _0003, 0, num);
	}

	private static uint _0002(uint _0002, uint _0003, uint _0005, uint _0008)
	{
		ulong num = (ulong)_0002 * (ulong)_0003;
		uint num2 = (uint)(int)num * _0008;
		ulong num3 = _0005;
		ulong num4 = num3 * num2;
		num += (uint)num4;
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	private static int[] _0002(int _0002)
	{
		int num = _0003(_0002);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		_0002 <<= i;
		int num3 = 0;
		for (; i < 32; i++)
		{
			if (_0002 < 0)
			{
				array[num2++] = 1 | (num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			_0002 <<= 1;
		}
		array[num2++] = 1 | (num3 << 8);
		array[num2] = -1;
		return array;
	}

	private static int[] _0002(int[] _0002, int _0003)
	{
		int num = (int)((uint)_0003 >> 5);
		int num2 = _0003 & 0x1F;
		int num3 = _0002.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			_0002.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = (int)((uint)_0002[0] >> num5);
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = _0002[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = _0002[i + 1];
				array[num4++] = (num7 << num2) | (int)((uint)num8 >> num5);
				num7 = num8;
			}
			array[num4] = _0002[num3 - 1] << num2;
		}
		return array;
	}

	private _0005_200B _0002(int _0002)
	{
		if (_000E == 0 || _0006.Length == 0)
		{
			return _0005_200B._0003;
		}
		if (_0002 == 0)
		{
			return this;
		}
		_0005_200B obj = new _0005_200B(_000E, _0005_200B._0002(_0006, _0002), _0005: true);
		if (_000F != -1)
		{
			obj._000F = _000F + _0002;
		}
		return obj;
	}

	private static void _0002(int _0002, int[] _0003, int _0005)
	{
		int num = (int)((uint)_0005 >> 5) + _0002;
		int num2 = _0005 & 0x1F;
		int num3 = _0003.Length - 1;
		if (num != _0002)
		{
			int num4 = num - _0002;
			for (int num5 = num3; num5 >= num; num5--)
			{
				_0003[num5] = _0003[num5 - num4];
			}
			for (int num6 = num - 1; num6 >= _0002; num6--)
			{
				_0003[num6] = 0;
			}
		}
		if (num2 != 0)
		{
			int num7 = 32 - num2;
			int num8 = _0003[num3];
			for (int num9 = num3; num9 > num; num9--)
			{
				int num10 = _0003[num9 - 1];
				_0003[num9] = (int)((uint)num8 >> num2) | (num10 << num7);
				num8 = num10;
			}
			_0003[num] = (int)((uint)_0003[num] >> num2);
		}
	}

	private static void _0002(int _0002, int[] _0003)
	{
		int num = _0003.Length;
		int num2 = _0003[num - 1];
		while (--num > _0002)
		{
			int num3 = _0003[num - 1];
			_0003[num] = (int)((uint)num2 >> 1) | (num3 << 31);
			num2 = num3;
		}
		_0003[_0002] = (int)((uint)_0003[_0002] >> 1);
	}

	public int _0005()
	{
		return _000E;
	}

	private static int[] _0002(int _0002, int[] _0003, int _0005, int[] _0008)
	{
		int num = _0003.Length;
		int num2 = _0008.Length;
		int num3 = 0;
		do
		{
			long num4 = (_0003[--num] & 0xFFFFFFFFu) - (_0008[--num2] & 0xFFFFFFFFu) + num3;
			_0003[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > _0005);
		if (num3 != 0)
		{
			while (--_0003[--num] == -1)
			{
			}
		}
		return _0003;
	}

	public byte[] _0002()
	{
		if (_000E == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[_0005_200B._0002(this._0002())];
		_0002(array, 0);
		return array;
	}

	public int _0008()
	{
		return _0002((byte[])null, 0);
	}

	public int _0002(byte[] _0002, int _0003)
	{
		if (_000E == 0)
		{
			return 0;
		}
		int num = _0005_200B._0002(this._0002());
		if (_0002 == null)
		{
			return num;
		}
		int num2 = _0006.Length;
		int num3 = _0003 + num;
		if (num3 > _0002.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (num2 > 1)
		{
			uint num4 = (uint)_0006[--num2];
			_0002[--num3] = (byte)num4;
			_0002[--num3] = (byte)(num4 >> 8);
			_0002[--num3] = (byte)(num4 >> 16);
			_0002[--num3] = (byte)(num4 >> 24);
		}
		uint num5;
		for (num5 = (uint)_0006[0]; num5 > 255; num5 >>= 8)
		{
			_0002[--num3] = (byte)num5;
		}
		_0002[--num3] = (byte)num5;
		return num;
	}

	private static _0005_200B _0002(ulong _0002)
	{
		int num = (int)(_0002 >> 32);
		int num2 = (int)_0002;
		if (num != 0)
		{
			return new _0005_200B(1, new int[2] { num, num2 }, _0005: false);
		}
		if (num2 != 0)
		{
			return new _0005_200B(1, new int[1] { num2 }, _0005: false);
		}
		return _0005_200B._0003;
	}

	public static _0005_200B _0003(ulong _0002)
	{
		return _0005_200B._0002(_0002);
	}

	private static int[] _0002(int[] _0002, int[] _0003)
	{
		int i;
		for (i = 0; i < _0002.Length && _0002[i] == 0; i++)
		{
		}
		int j;
		for (j = 0; j < _0003.Length && _0003[j] == 0; j++)
		{
		}
		int num = _0005_200B._0003(i, _0002, j, _0003);
		if (num > 0)
		{
			int num2 = _0005_200B._0002(1, j, _0003);
			int num3 = _0005_200B._0002(1, i, _0002);
			int num4 = num3 - num2;
			int k = 0;
			int num5 = num2;
			int[] array;
			if (num4 > 0)
			{
				array = _0005_200B._0002(_0003, num4);
				num5 += num4;
			}
			else
			{
				int num6 = _0003.Length - j;
				array = new int[num6];
				Array.Copy(_0003, j, array, 0, num6);
			}
			while (true)
			{
				if (num5 < num3 || _0005_200B._0003(i, _0002, k, array) >= 0)
				{
					_0005_200B._0002(i, _0002, k, array);
					while (_0002[i] == 0)
					{
						if (++i == _0002.Length)
						{
							return _0002;
						}
					}
					num3 = 32 * (_0002.Length - i - 1) + _0005_200B._0003(_0002[i]);
					if (num3 <= num2)
					{
						if (num3 < num2)
						{
							return _0002;
						}
						num = _0005_200B._0003(i, _0002, j, _0003);
						if (num <= 0)
						{
							break;
						}
					}
				}
				num4 = num5 - num3;
				if (num4 == 1)
				{
					uint num7 = (uint)array[k] >> 1;
					uint num8 = (uint)_0002[i];
					if (num7 > num8)
					{
						num4++;
					}
				}
				if (num4 < 2)
				{
					_0005_200B._0002(k, array);
					num5--;
				}
				else
				{
					_0005_200B._0002(k, array, num4);
					num5 -= num4;
				}
				for (; array[k] == 0; k++)
				{
				}
			}
		}
		if (num == 0)
		{
			Array.Clear(_0002, i, _0002.Length - i);
		}
		return _0002;
	}

	private _0005_200B _0002(_0005_200B _0002)
	{
		if (_000E == 0)
		{
			return _0005_200B._0003;
		}
		if (_0003(0, _0006, 0, _0002._0006) < 0)
		{
			return this;
		}
		int[] array = (int[])_0006.Clone();
		array = _0005_200B._0002(array, _0002._0006);
		return new _0005_200B(_000E, array, _0005: true);
	}

	private static int[] _0002(int[] _0002)
	{
		int[] array = new int[_0002.Length];
		Buffer.BlockCopy(_0002, 0, array, 0, _0002.Length * 4);
		return array;
	}
}
internal static class _0006_200B
{
	public static byte[] _0002(object _0002, ulong _0003, _0006 _0005, RandomNumberGenerator _0008)
	{
		return _0006_200B._0002(_0006_200B._0002(_0002), _0006_200B._0002(_0003), _0005, _0008);
	}

	public static byte[] _0002(byte[] _0002, byte[] _0003, _0006 _0005, RandomNumberGenerator _0008)
	{
		int num = _0002.Length;
		if (num == 0)
		{
			throw new ArgumentException();
		}
		int num2 = _0005._0006_200A_2002_0002();
		int num3 = _0005._0006_200A_2002_0003();
		int num4 = num % num2;
		int num5 = (num + (num2 - 1)) / num2;
		byte[] array;
		if (num4 == 0)
		{
			array = new byte[num];
			Buffer.BlockCopy(_0002, 0, array, 0, num);
		}
		else
		{
			int num6 = _0006_200B._0002(num4);
			byte[] bytes = new _0002_2001(_0002, _0003, num6).GetBytes(num2);
			if (num5 == 1)
			{
				array = bytes;
			}
			else
			{
				array = new byte[num2 * num5];
				Buffer.BlockCopy(bytes, 0, array, num2 * (num5 - 1), num2);
			}
			Buffer.BlockCopy(_0002, 0, array, 0, _0002.Length);
		}
		_000F_2001._0002(array, 0, array.Length / 4 * 4, _0003);
		byte[] array2 = new byte[_0005._0006_200A_2002_0003() * num5];
		for (int i = 0; i < num5; i++)
		{
			_0005._0006_200A_2002_0002(array, num2 * i, num2, array2, num3 * i, _0008);
		}
		return array2;
	}

	private static int _0002(int _0002)
	{
		if (_0002 < 8)
		{
			return 200;
		}
		return 1;
	}

	public static byte[] _0002(object _0002)
	{
		if (_0002 is sbyte)
		{
			sbyte b = (sbyte)_0002;
			return new byte[1] { (byte)b };
		}
		if (_0002 is byte)
		{
			byte b2 = (byte)_0002;
			return new byte[1] { b2 };
		}
		if (_0002 is int)
		{
			int num = (int)_0002;
			return _0006_200B._0002(num);
		}
		if (_0002 is uint)
		{
			uint num2 = (uint)_0002;
			return _0006_200B._0002(num2);
		}
		if (_0002 is long)
		{
			long num3 = (long)_0002;
			return _0006_200B._0002(num3);
		}
		if (_0002 is ulong)
		{
			ulong num4 = (ulong)_0002;
			return _0006_200B._0002(num4);
		}
		byte[] array = _0002 as byte[];
		if (array == null)
		{
			Array array2 = _0002 as Array;
			if (array2 != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				foreach (object item in array2)
				{
					byte[] array3 = _0006_200B._0002(item);
					memoryStream.Write(array3, 0, array3.Length);
				}
				return memoryStream.ToArray();
			}
			throw new InvalidOperationException();
		}
		return array;
	}

	private static byte[] _0002(int _0002)
	{
		byte[] array = new byte[4];
		array[3] = (byte)_0002;
		array[2] = (byte)(_0002 >> 8);
		array[1] = (byte)(_0002 >> 16);
		array[0] = (byte)(_0002 >> 24);
		return array;
	}

	private static byte[] _0002(uint _0002)
	{
		byte[] array = new byte[4];
		array[3] = (byte)_0002;
		array[2] = (byte)(_0002 >> 8);
		array[1] = (byte)(_0002 >> 16);
		array[0] = (byte)(_0002 >> 24);
		return array;
	}

	private static byte[] _0002(long _0002)
	{
		byte[] array = new byte[8];
		array[7] = (byte)_0002;
		array[6] = (byte)(_0002 >> 8);
		array[5] = (byte)(_0002 >> 16);
		array[4] = (byte)(_0002 >> 24);
		array[3] = (byte)(_0002 >> 32);
		array[2] = (byte)(_0002 >> 40);
		array[1] = (byte)(_0002 >> 48);
		array[0] = (byte)(_0002 >> 56);
		return array;
	}

	private static byte[] _0002(ulong _0002)
	{
		byte[] array = new byte[8];
		array[7] = (byte)_0002;
		array[6] = (byte)(_0002 >> 8);
		array[5] = (byte)(_0002 >> 16);
		array[4] = (byte)(_0002 >> 24);
		array[3] = (byte)(_0002 >> 32);
		array[2] = (byte)(_0002 >> 40);
		array[1] = (byte)(_0002 >> 48);
		array[0] = (byte)(_0002 >> 56);
		return array;
	}
}
internal struct _0008_200B
{
	private int m__0002;

	private readonly byte _0003;

	public _0008_200B(int _0002, byte _0003)
	{
		this._0002(_0002);
		this._0003 = _0003;
	}

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0002)
	{
		this.m__0002 = _0002;
	}

	public byte _0002()
	{
		return _0003;
	}

	public override bool Equals(object _0002)
	{
		if (_0002 is _0008_200B)
		{
			_0008_200B obj = (_0008_200B)_0002;
			return this._0002(obj);
		}
		return false;
	}

	public bool _0002(_0008_200B _0002)
	{
		return _0002._0002() == this._0002();
	}

	public static bool operator ==(_0008_200B _0002, _0008_200B _0003)
	{
		return _0002._0002(_0003);
	}

	public static bool operator !=(_0008_200B _0002, _0008_200B _0003)
	{
		return !(_0002 == _0003);
	}

	public override int GetHashCode()
	{
		return this._0002().GetHashCode();
	}

	public override string ToString()
	{
		return this._0002().ToString();
	}
}
internal sealed class _000E_200B : SymmetricAlgorithm
{
	[Serializable]
	private sealed class _0002
	{
		public static readonly _0002 _0002 = new _0002();

		public static Comparison<SymmetricAlgorithm> _0003;

		internal int _0002(SymmetricAlgorithm _0002, SymmetricAlgorithm _0003)
		{
			return _0003.BlockSize.CompareTo(_0002.BlockSize);
		}
	}

	private sealed class _0003 : ICryptoTransform, IDisposable
	{
		private readonly byte[] m__0002;

		private readonly byte[] m__0003;

		private readonly SymmetricAlgorithm[] _0005;

		private ICryptoTransform[] _0008;

		private readonly bool _0006;

		private readonly int _000E;

		public int InputBlockSize => _000E;

		public int OutputBlockSize => _000E;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public _0003(SymmetricAlgorithm[] _0002, byte[] _0003, byte[] _0005, bool _0008)
		{
			this.m__0002 = _0003;
			this.m__0003 = _0005;
			this._0005 = _0002;
			_0006 = _0008;
			_000E = _0002[_0002.Length - 1].BlockSize / 8;
		}

		public void Dispose()
		{
			if (_0008 != null)
			{
				ICryptoTransform[] array = _0008;
				for (int i = 0; i < array.Length; i++)
				{
					array[i]?.Dispose();
				}
				_0008 = null;
			}
		}

		private void _0002()
		{
			SymmetricAlgorithm[] array = _0005;
			int num = array.Length;
			if (_0008 == null)
			{
				ICryptoTransform[] array2 = new ICryptoTransform[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					SymmetricAlgorithm symmetricAlgorithm = array[i];
					int num3 = symmetricAlgorithm.KeySize / 8;
					byte[] array3 = new byte[num3];
					Buffer.BlockCopy(this.m__0002, num2, array3, 0, num3);
					num2 += num3;
					byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
					ICryptoTransform cryptoTransform = (array2[i] = (_0006 ? symmetricAlgorithm.CreateEncryptor(array3, rgbIV) : symmetricAlgorithm.CreateDecryptor(array3, rgbIV)));
				}
				_0008 = array2;
			}
		}

		public byte[] TransformFinalBlock(byte[] _0002, int _0003, int _0005)
		{
			byte[] array = new byte[_0005];
			TransformBlock(_0002, _0003, _0005, array, 0);
			return array;
		}

		public int TransformBlock(byte[] _0002, int _0003, int _0005, byte[] _0008, int _0006)
		{
			Buffer.BlockCopy(_0002, _0003, _0008, _0006, _0005);
			this._0002();
			if (this._0006)
			{
				this._0002(_0008, _0006, _0005);
			}
			else
			{
				this._0003(_0008, _0006, _0005);
			}
			return _0005;
		}

		private void _0002(byte[] _0002, int _0003, int _0005)
		{
			byte[] array = new byte[this.m__0003.Length];
			Buffer.BlockCopy(this.m__0003, 0, array, 0, array.Length);
			int num = 0;
			ICryptoTransform[] array2 = _0008;
			foreach (ICryptoTransform cryptoTransform in array2)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (_0005 - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + _0003;
					_000E_200B._0003._0002(_0002, num4, array, 0, inputBlockSize);
					cryptoTransform.TransformBlock(_0002, num4, inputBlockSize, _0002, num4);
					Buffer.BlockCopy(_0002, num4, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == _0005)
				{
					break;
				}
			}
		}

		private void _0003(byte[] _0002, int _0003, int _0005)
		{
			byte[] array = new byte[this.m__0003.Length];
			Buffer.BlockCopy(this.m__0003, 0, array, 0, array.Length);
			byte[] array2 = new byte[array.Length];
			int num = 0;
			ICryptoTransform[] array3 = _0008;
			foreach (ICryptoTransform cryptoTransform in array3)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (_0005 - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + _0003;
					Buffer.BlockCopy(_0002, num4, array2, 0, inputBlockSize);
					cryptoTransform.TransformBlock(_0002, num4, inputBlockSize, _0002, num4);
					_000E_200B._0003._0002(_0002, num4, array, 0, inputBlockSize);
					Buffer.BlockCopy(array2, 0, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == _0005)
				{
					break;
				}
			}
		}

		private static void _0002(byte[] _0002, int _0003, byte[] _0005, int _0008, int _0006)
		{
			for (int i = 0; i < _0006; i++)
			{
				_0002[_0003 + i] ^= _0005[_0008 + i];
			}
		}
	}

	private readonly SymmetricAlgorithm[] m__0002;

	private readonly int m__0003;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			IVValue = (byte[])value.Clone();
		}
	}

	public _000E_200B(params SymmetricAlgorithm[] _0002)
	{
		_0002 = (SymmetricAlgorithm[])_0002.Clone();
		Array.Sort(_0002, _000E_200B._0002._0002._0002);
		this.m__0002 = _0002;
		int num = 0;
		SymmetricAlgorithm[] array = _0002;
		foreach (SymmetricAlgorithm symmetricAlgorithm in array)
		{
			num += symmetricAlgorithm.KeySize;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			symmetricAlgorithm.Padding = PaddingMode.None;
		}
		BlockSizeValue = _0002[_0002.Length - 1].BlockSize;
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(BlockSizeValue, BlockSizeValue, 0)
		};
		KeySizeValue = num;
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(num, num, 0)
		};
		this.m__0003 = _0002[0].BlockSize;
		Mode = CipherMode.ECB;
		Padding = PaddingMode.None;
	}

	public int _0002()
	{
		return this.m__0003;
	}

	public override ICryptoTransform CreateDecryptor(byte[] _0002, byte[] _0003)
	{
		return this._0002(_0002, _0003, _0005: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] _0002, byte[] _0003)
	{
		return this._0002(_0002, _0003, _0005: true);
	}

	private ICryptoTransform _0002(byte[] _0002, byte[] _0003, bool _0005)
	{
		if (_0002.Length * 8 != KeySize)
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506763087), _000F_2004_2000._0002(-1506763127));
		}
		if (_0003.Length * 8 != this._0002())
		{
			throw new ArgumentException(_000F_2004_2000._0002(-1506763108), _000F_2004_2000._0002(-1506763413));
		}
		return new _0003(this.m__0002, _0002, _0003, _0005);
	}

	public override void GenerateIV()
	{
		throw new NotSupportedException();
	}

	public override void GenerateKey()
	{
		throw new NotSupportedException();
	}
}
internal sealed class _000F_200B
{
	[Conditional("DEBUG")]
	public static void _0002(string _0002)
	{
	}
}
