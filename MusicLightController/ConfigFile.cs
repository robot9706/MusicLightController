using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace MusicLightController
{
	public class ConfigFile
	{
		public string COMPort = string.Empty;
		
		public uint Baud;
		
		public float Brightness;
		
		public float BassSlopeValue;
		
		public float MidSlopeValue;
		
		public ushort SamplesPerSecond;
		
		public int InputIndex;
		
		public string InputName = string.Empty;
		
		public int OutputIndex;
		
		public string OutputName = string.Empty;
		
		public int OutputDriverIndex;
		
		public string OutputDriverName = string.Empty;
		
		public bool MirrorSound;
		
		public byte MetroTheme;
		
		public byte MetroColor;
		
		public float BassVolume;
		
		public float MidVolume;
		
		public byte LEDDriver;
		
		public string LEDDriverConfig = string.Empty;
		
		
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
					COMPort = br0.ReadString();
					Baud = br0.ReadUInt32();
					Brightness = br0.ReadSingle();
					BassSlopeValue = br0.ReadSingle();
					MidSlopeValue = br0.ReadSingle();
					SamplesPerSecond = br0.ReadUInt16();
					InputIndex = br0.ReadInt32();
					InputName = br0.ReadString();
					OutputIndex = br0.ReadInt32();
					OutputName = br0.ReadString();
					OutputDriverIndex = br0.ReadInt32();
					OutputDriverName = br0.ReadString();
					MirrorSound = br0.ReadBoolean();
					MetroTheme = br0.ReadByte();
					MetroColor = br0.ReadByte();
					BassVolume = br0.ReadSingle();
					MidVolume = br0.ReadSingle();
					LEDDriver = br0.ReadByte();
					LEDDriverConfig = br0.ReadString();
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
					bw0.Write(COMPort);
					bw0.Write(Baud);
					bw0.Write(Brightness);
					bw0.Write(BassSlopeValue);
					bw0.Write(MidSlopeValue);
					bw0.Write(SamplesPerSecond);
					bw0.Write(InputIndex);
					bw0.Write(InputName);
					bw0.Write(OutputIndex);
					bw0.Write(OutputName);
					bw0.Write(OutputDriverIndex);
					bw0.Write(OutputDriverName);
					bw0.Write(MirrorSound);
					bw0.Write(MetroTheme);
					bw0.Write(MetroColor);
					bw0.Write(BassVolume);
					bw0.Write(MidVolume);
					bw0.Write(LEDDriver);
					bw0.Write(LEDDriverConfig);
				}
			}
		}

	}
}
