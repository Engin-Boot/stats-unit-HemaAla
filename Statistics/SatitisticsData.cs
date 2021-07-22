using System;
using System.Collections.Generic;


namespace Statistics
{
    public class StatisticsData
    {
        public double average;
        public double max;
        public double min;
        public StatisticsData(double _avg = Double.NaN, double _max = Double.NaN, double _min = Double.NaN)
        {
            this.average = _avg;
            this.max = _max;
            this.min = _min;
        }
    }
}



