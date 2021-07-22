using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var StatisticsComputer = new StatisticsComputer();
            var computedStats = StatisticsComputer.CalculateStatistics(
                new List<___>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(StatisticsComputer._avg - 4.525) <= epsilon);
            Assert.True(Math.Abs(StatisticsComputer._max - 8.9) <= epsilon);
            Assert.True(Math.Abs(StatisticsComputer._min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var StatisticsComputer = new StatisticsComputer();
            var computedStats = StatisticsComputer.CalculateStatistics(
                new List<___>{});
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1

	    Assert.True(Double.IsNaN(computedStats._avg));
	    Assert.True(Double.IsNaN(computedStats._max));
	    Assert.True(Double.IsNaN(computedStats._min));

		

        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlerter();
            var ledAlert = new LedAlerter();
            IAlerter[] alerters = {emailAlert, ledAlert};

            const float maxThreshold = 10.2;
            var statsAlerter = new StatisticsAlerter(maxThreshold, alerters);
            statsAlerter.CheckAndAlert(new List<___>{0.2, 11.9, 4.3, 8.5});

            Assert.True(emailAlert._emailSent);
            Assert.True(ledAlert._ledGlowed);
        }
    }
}
