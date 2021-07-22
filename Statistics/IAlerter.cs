using System;

namespace Statistics
{
    public interface IAlerter
    {
        void Alert(double maxThreshold, double max);
    }
}
