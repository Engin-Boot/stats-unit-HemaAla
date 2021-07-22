using System;
using System.Collections.Generic;


namespace Statistics
{
    public class StatisticsData
    {
        public decimal average;
        public decimal max;
        public decimal min;
        public StatisticsData(decimal _avg = Double.NaN, decimal _max = Double.NaN, decimal _min = Double.NaN)
        {
            this.average = _avg;
            this.max = _max;
            this.min = _min;
        }
    }
}



