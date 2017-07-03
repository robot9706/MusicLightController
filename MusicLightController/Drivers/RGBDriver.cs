using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController.Drivers
{
    class RGBDriver : LedDriver
    {
        struct RGBCachedData
        {
            public Color TopLeft;
            public Color TopRight;
            public Color BottomLeft;
            public Color BottomRight;
        }

        public override void Start(SetupScreen src)
        {
        }

        public override void End(SetupScreen src)
        {
        }

        public override Form GetSetupForm()
        {
            return new RGBSetupForm();
        }

        public override void DoDriver(SetupScreen src, byte bass, byte mid)
        {
            if (src.CachedDriverData == null || !(src.CachedDriverData is RGBCachedData))
            {
                if (!string.IsNullOrEmpty(src.Config.LEDDriverConfig))
                {
                    if (src.Config.LEDDriverConfig.StartsWith("cfgRGB"))
                    {
                        string[] data = src.Config.LEDDriverConfig.Split('|');
                        if (data.Length == 5)
                        {
                            RGBCachedData rb = new RGBCachedData();

                            rb.TopLeft = Utils.ParseRGB(data[1]);
                            rb.TopRight = Utils.ParseRGB(data[2]);
                            rb.BottomLeft = Utils.ParseRGB(data[3]);
                            rb.BottomRight = Utils.ParseRGB(data[4]);

                            src.CachedDriverData = rb;
                        }
                    }
                }
            }

            if (src.CachedDriverData != null && src.CachedDriverData is RGBCachedData)
            {
                RGBCachedData rg = (RGBCachedData)src.CachedDriverData;

                float x = (float)Math.Pow(bass / (float)byte.MaxValue, 1.5f);
                float y = (float)Math.Pow((byte.MaxValue - mid) / (float)byte.MaxValue, 1.5f);

                Color c = Utils.BilinearInterpolation(rg.TopLeft, rg.BottomLeft, rg.TopRight, rg.BottomRight, x, y);

                src.DriverSerial.Write(new byte[] { 0x1, (byte)(c.R * src.Config.Brightness), (byte)(c.G * src.Config.Brightness), (byte)(c.B * src.Config.Brightness) }, 0, 4);
            }
        }

        public override string GetName()
        {
            return "RGB";
        }
    }
}
