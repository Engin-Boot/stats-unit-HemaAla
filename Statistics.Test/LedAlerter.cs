using System;
using System.Collections.Generic;


namespace Statistics
{
    public class LedAlert : IAlerter
    {
        public bool _ledGlowed = false;

        void IAlerter.alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this._ledGlowed = true;
            }
        }
    }
}
