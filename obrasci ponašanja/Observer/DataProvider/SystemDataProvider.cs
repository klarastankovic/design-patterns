using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DataProvider
{
    public class SystemDataProvider : SimpleSystemDataProvider //konkretan subjekt
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad != this.previousCPULoad)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetRAMAvailable()
        {
            float currentRAMAvailablle = this.AvailableRAM;
            if (currentRAMAvailablle != this.previousRAMAvailable)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentRAMAvailablle;
            return currentRAMAvailablle;
        }
    }
}
