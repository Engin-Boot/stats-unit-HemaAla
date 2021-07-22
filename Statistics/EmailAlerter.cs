using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlerter : IAlerter
    {
        public bool _emailSent = false;
	
        void IAlerter.Alert(double _maxThreshold, double _max)
        {
            if (_max > _maxThreshold)
            {
                this._emailSent = true;
            }
        }
    }
}
