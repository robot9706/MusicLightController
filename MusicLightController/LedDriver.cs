using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController
{
    abstract class LedDriver
    {
        public abstract string GetName();

        public abstract void Start(SetupScreen src);
        public abstract void End(SetupScreen src);

        public abstract Form GetSetupForm();
        public abstract void DoDriver(SetupScreen src, byte bass, byte mid);
    }
}
