using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class LedAlert : IAlerter
    {
        public bool _ledGlowed = false;
        void IAlerter.Alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this._ledGlowed = true;
            }
        }
    }
}
