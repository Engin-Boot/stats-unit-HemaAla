using System;
using System.Collections.Generic;



namespace Statistics
{
    public class StatisticsAlerter
    {
        double _maxThreshold;
        List<IAlerter> _alerter = new List<IAlerter>();

        public void AlertStats(double maxThreshold, List<IAlerter> alerters)
        {
            this._maxThreshold = maxThreshold;
            for (int i = 0; i < alerters.Count; ++i)
                AddAlerter(alerters[i]);
        }
        public void AddAlerter(IAlerter alerter)
        {
            _alerter.Add(alerter);
        }
        public void CheckAndAlert(List<double> numbers)
        {
            double max = StatisticsComputer.CalculateStatistics(numbers).max;

            for (int i = 0; i < _alerter.Count; ++i)
                _alerter[i].Alert(_maxThreshold, max);
        }
    }
}
