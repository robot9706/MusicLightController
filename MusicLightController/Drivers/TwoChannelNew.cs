using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController.Drivers
{
    class TwoChannelNew : LedDriver
    {
        public override void Start(SetupScreen src)
        {
            if (src.DriverSerial == null)
                return;

            src.DriverSerial.Write("ccc");
        }

        public override void End(SetupScreen src)
        {
            if (src.DriverSerial == null)
                return;

            src.DriverSerial.Write("eee");
        }

        public override void DoDriver(SetupScreen src, byte bass, byte mid)
        {
            src.DriverSerial.Write(new byte[] { (byte)'v', (byte)(bass * src.Config.Brightness), (byte)(mid * src.Config.Brightness) }, 0, 3);
        }

        public override string GetName()
        {
            return "2 channel (new)";
        }

        public override Form GetSetupForm()
        {
            return null;
        }
    }
}
