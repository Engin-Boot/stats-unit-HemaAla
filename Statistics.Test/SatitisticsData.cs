using System;
using System.Collections.Generic;


namespace Statistics
{
    public class StatisticsData
    {
        public double average;
        public double max;
        public double min;
        public StatisticsData(double avg = Double.NaN, double max = Double.NaN, double min = Double.NaN)
        {
            this.average = avg;
            this.max = max;
            this.min = min;
        }
    }
}



