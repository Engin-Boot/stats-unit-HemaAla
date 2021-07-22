using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatisticsComputer
    {
        static public StattisticsData CalculateStatistics(List<decimal> numbers) {
            decimal _avg;
            decimal _max;
            decimal _min;

            if (numbers.Count == 0)
                return new StattisticsData();

            _max = numbers[0];
            _min = numbers[0];
            _avg = 0.0m;

            foreach(float number in numbers)
            {
                if (number > _max)
                    _max = number;
                if (number < _min)
                    _min = number;
                _avg += number;
            }
            average /= numbers.Count;

            return ( new StattisticsData(_avg, _max, _min) );
        }
    }
}

