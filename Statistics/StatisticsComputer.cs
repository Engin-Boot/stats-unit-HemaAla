using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatisticsComputer
    {
        public static StatisticsData CalculateStatistics(List<double> numbers) {
            double _avg;
            double _max;
            double _min;

            if (numbers.Count == 0)
                return new StatisticsData();

            _max = numbers[0];
            _min = numbers[0];
            _avg = 0.0;

            foreach(double number in numbers)
            {
                if (number > _max)
                    _max = number;
                if (number < _min)
                    _min = number;
                _avg += number;
            }
            _avg /= numbers.Count;

            return ( new StatisticsData(_avg, _max, _min) );
        }
    }
}

