using System;
using System.Collections.Generic;


namespace Statistics
{
    public class LedAlerter : IAlerter
    {
        public bool _ledGlowed = false;
        public void Alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this._ledGlowed = true;
            }
        }
    }
}
