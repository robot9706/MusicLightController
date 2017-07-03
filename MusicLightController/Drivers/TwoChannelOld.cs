using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController.Drivers
{
    class TwoChannelOld : LedDriver
    {
        public override void DoDriver(SetupScreen src, byte bass, byte mid)
        {
            src.DriverSerial.Write(new byte[] { (byte)(bass * src.Config.Brightness), (byte)(mid * src.Config.Brightness) }, 0, 2);
        }

        public override void End(SetupScreen src)
        {
        }

        public override string GetName()
        {
            return "2 channel (old)";
        }

        public override Form GetSetupForm()
        {
            return null;
        }

        public override void Start(SetupScreen src)
        {
        }
    }
}
