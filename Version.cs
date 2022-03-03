﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCUtils
{
	public struct Version
	{
		public enum Stage : byte
		{
			Indev = 0,
			Infdev = 1,
			Alpha = 2,
			Beta = 3,
			Release = 4
		}

		public Stage stage;
		public byte major;
		public byte minor;
		public byte patch;

		public static readonly Version FirstVersion = new Version(Stage.Indev, 0, 0, 0);

		public static readonly Version DefaultVersion = Release_1(16);

		public static readonly Dictionary<Version, int> dataVersionAssociations = new Dictionary<Version, int>()
		{
			{Release_1(9,0), 169},
			{Release_1(9,1), 175},
			{Release_1(9,2), 176},
			{Release_1(9,3), 183},
			{Release_1(9,4), 184},

			{Release_1(10,0), 510},
			{Release_1(10,1), 511},
			{Release_1(10,2), 512},

			{Release_1(11,0), 819},
			{Release_1(11,1), 921},
			{Release_1(11,2), 922},

			{Release_1(12,0), 1139},
			{Release_1(12,1), 1240},
			{Release_1(12,2), 1343},

			{Release_1(13,0), 1519},
			{Release_1(13,1), 1628},
			{Release_1(13,2), 1631},

			{Release_1(14,0), 1952},
			{Release_1(14,1), 1957},
			{Release_1(14,2), 1963},
			{Release_1(14,3), 1968},
			{Release_1(14,4), 1976},

			{Release_1(15,0), 2225},
			{Release_1(15,1), 2227},
			{Release_1(15,2), 2230},

			{Release_1(16,0), 2566},
			{Release_1(16,1), 2567},
			{Release_1(16,2), 2578},
			{Release_1(16,3), 2580},
			{Release_1(16,4), 2584},
			{Release_1(16,5), 2586},

			{Release_1(17,0), 2724},
			{Release_1(17,1), 2730},

			{Release_1(18,0), 2860},
			{Release_1(18,1), 2865 }
		};

		public Version(Stage stage, byte major, byte minor, byte patch)
		{
			this.stage = stage;
			this.major = major;
			this.minor = minor;
			this.patch = patch;
		}

		public static Version Alpha_1(byte minor, byte patch = 0)
		{
			return new Version(Stage.Alpha, 1, minor, patch);
		}

		public static Version Beta_1(byte minor, byte patch = 0)
		{
			return new Version(Stage.Beta, 1, minor, patch);
		}

		public static Version Release_1(byte minor, byte patch = 0)
		{
			return new Version(Stage.Release, 1, minor, patch);
		}

		public static Version Parse(string s)
		{
			s = s.Trim().ToLower();
			Stage stage;
			if(char.IsLetter(s[0])) {
				if (s[0] == 'a') stage = Stage.Alpha;
				else if (s[0] == 'b') stage = Stage.Beta;
				else if (s[0] == 'r') stage = Stage.Release;
				else throw new System.FormatException("Unrecognized stage character: " + s[0]);
				s = s.Substring(1);
			}
			else
			{
				stage = Stage.Release;
			}
			string[] split = s.Split('.');
			byte major = byte.Parse(split[0]);
			byte minor = byte.Parse(split[1]);
			byte patch = split.Length >= 3 ? byte.Parse(split[2]) : (byte)0;
			return new Version(stage, major, minor, patch);
		}

		/// <summary>
		/// Returns the game version from the given data version number (if applicable).
		/// </summary>
		public static Version? FromDataVersion(int? dataVersion)
		{
			if (dataVersion == null) return null;
			if(dataVersion >= 100)
			{
				var list = dataVersionAssociations.ToList();
				list.OrderBy(kv => kv.Value);
				foreach(var kv in list)
				{
					if(dataVersion <= kv.Value)
					{
						return kv.Key;
					}
				}
			}
			return null;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			if (stage == Stage.Alpha) sb.Append("a");
			else if (stage == Stage.Beta) sb.Append("b");
			sb.Append($"{major}.{minor}.{patch}");
			return sb.ToString();
		}

		public override int GetHashCode()
		{
			return ((byte)stage << 24) + (major << 16) + (minor << 8) + patch;
		}

		public override bool Equals(object obj)
		{
			if(obj is Version v)
			{
				return this == v;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Gets the data version associated with the given version (Warning: only versions after release 1.9 have a data version)
		/// </summary>
		public int? GetDataVersion()
		{
			int? dv = null;
			if(stage == Stage.Release && dataVersionAssociations.TryGetValue(this, out int i)) dv = i;
			return dv;
		}

		public static bool operator ==(Version l, Version r)
		{
			return l.GetHashCode() == r.GetHashCode();
		}

		public static bool operator !=(Version l, Version r)
		{
			return l.GetHashCode() != r.GetHashCode();
		}

		public static bool operator >(Version l, Version r)
		{
			return l.GetHashCode() > r.GetHashCode();
		}

		public static bool operator <(Version l, Version r)
		{
			return l.GetHashCode() < r.GetHashCode();
		}

		public static bool operator <=(Version l, Version r)
		{
			return l.GetHashCode() <= r.GetHashCode();
		}

		public static bool operator >=(Version l, Version r)
		{
			return l.GetHashCode() >= r.GetHashCode();
		}
	}
}