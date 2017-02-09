using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace MusicLightController
{
	public class ConfigFile
	{
		private string _COMPort = string.Empty;
		public string COMPort
		{
			get { return _COMPort; }
			set { _COMPort = value;  }
		}
		
		private uint _Baud;
		public uint Baud
		{
			get { return _Baud; }
			set { _Baud = value;  }
		}
		
		private float _Brightness;
		public float Brightness
		{
			get { return _Brightness; }
			set { _Brightness = value;  }
		}
		
		private float _BassSlopeValue;
		public float BassSlopeValue
		{
			get { return _BassSlopeValue; }
			set { _BassSlopeValue = value;  }
		}
		
		private float _MidSlopeValue;
		public float MidSlopeValue
		{
			get { return _MidSlopeValue; }
			set { _MidSlopeValue = value;  }
		}
		
		private ushort _SamplesPerSecond;
		public ushort SamplesPerSecond
		{
			get { return _SamplesPerSecond; }
			set { _SamplesPerSecond = value;  }
		}
		
		private int _InputIndex;
		public int InputIndex
		{
			get { return _InputIndex; }
			set { _InputIndex = value;  }
		}
		
		private string _InputName = string.Empty;
		public string InputName
		{
			get { return _InputName; }
			set { _InputName = value;  }
		}
		
		private int _OutputIndex;
		public int OutputIndex
		{
			get { return _OutputIndex; }
			set { _OutputIndex = value;  }
		}
		
		private string _OutputName = string.Empty;
		public string OutputName
		{
			get { return _OutputName; }
			set { _OutputName = value;  }
		}
		
		private int _OutputDriverIndex;
		public int OutputDriverIndex
		{
			get { return _OutputDriverIndex; }
			set { _OutputDriverIndex = value;  }
		}
		
		private string _OutputDriverName = string.Empty;
		public string OutputDriverName
		{
			get { return _OutputDriverName; }
			set { _OutputDriverName = value;  }
		}
		
		private bool _MirrorSound;
		public bool MirrorSound
		{
			get { return _MirrorSound; }
			set { _MirrorSound = value;  }
		}
		
		private byte _MetroTheme;
		public byte MetroTheme
		{
			get { return _MetroTheme; }
			set { _MetroTheme = value;  }
		}
		
		private byte _MetroColor;
		public byte MetroColor
		{
			get { return _MetroColor; }
			set { _MetroColor = value;  }
		}
		
		private float _BassVolume;
		public float BassVolume
		{
			get { return _BassVolume; }
			set { _BassVolume = value;  }
		}
		
		private float _MidVolume;
		public float MidVolume
		{
			get { return _MidVolume; }
			set { _MidVolume = value;  }
		}
		
		
		public static ConfigFile ReadFile(string fileName)
		{
			ConfigFile file = new ConfigFile();
			file.Read(fileName);
			return file;
		}
		
		public static ConfigFile ReadFile(Stream stream)
		{
			ConfigFile file = new ConfigFile();
			file.Read(stream);
			return file;
		}
		
		public static ConfigFile ReadFile(BinaryReader reader)
		{
			ConfigFile file = new ConfigFile();
			file.Read(reader);
			return file;
		}
		
		public void Read(string fileName)
		{
			Read(File.OpenRead(fileName));
		}
		
		public void Read(Stream stream)
		{
			using (BinaryReader br = new BinaryReader(stream, Encoding.UTF8))
			{
				Read(br);
			}
		}
		
		public void Read(BinaryReader br)
		{
			using (GZipStream br0_gz = new GZipStream(br.BaseStream, CompressionMode.Decompress, true))
			{
				using (BinaryReader br0 = new BinaryReader(br0_gz))
				{
					if (br0.ReadString() != "MCC2")
						return;
					_COMPort = br0.ReadString();
					_Baud = br0.ReadUInt32();
					_Brightness = br0.ReadSingle();
					_BassSlopeValue = br0.ReadSingle();
					_MidSlopeValue = br0.ReadSingle();
					_SamplesPerSecond = br0.ReadUInt16();
					_InputIndex = br0.ReadInt32();
					_InputName = br0.ReadString();
					_OutputIndex = br0.ReadInt32();
					_OutputName = br0.ReadString();
					_OutputDriverIndex = br0.ReadInt32();
					_OutputDriverName = br0.ReadString();
					_MirrorSound = br0.ReadBoolean();
					_MetroTheme = br0.ReadByte();
					_MetroColor = br0.ReadByte();
					_BassVolume = br0.ReadSingle();
					_MidVolume = br0.ReadSingle();
				}
			}
		}
		
		public void Write(string fileName)
		{
			Write(new FileStream(fileName, FileMode.Create));
		}
		
		public void Write(Stream stream)
		{
			using (BinaryWriter bw = new BinaryWriter(stream, Encoding.UTF8))
			{
				Write(bw);
			}
		}
		
		public void Write(BinaryWriter bw)
		{
			using (GZipStream bw0_gz = new GZipStream(bw.BaseStream, CompressionMode.Compress, true))
			{
				using (BinaryWriter bw0 = new BinaryWriter(bw0_gz))
				{
					bw0.Write((string)"MCC2");
					bw0.Write(_COMPort);
					bw0.Write(_Baud);
					bw0.Write(_Brightness);
					bw0.Write(_BassSlopeValue);
					bw0.Write(_MidSlopeValue);
					bw0.Write(_SamplesPerSecond);
					bw0.Write(_InputIndex);
					bw0.Write(_InputName);
					bw0.Write(_OutputIndex);
					bw0.Write(_OutputName);
					bw0.Write(_OutputDriverIndex);
					bw0.Write(_OutputDriverName);
					bw0.Write(_MirrorSound);
					bw0.Write(_MetroTheme);
					bw0.Write(_MetroColor);
					bw0.Write(_BassVolume);
					bw0.Write(_MidVolume);
				}
			}
		}

	}
}
