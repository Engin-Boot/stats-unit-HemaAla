using System;

namespace Statistics
{
    public interface IAlerter
    {
        void Alert(decimal maxThreshold, decimal max);
    }
}
