using NUnit.Framework;
using NGeoNames;

namespace NGeoNames.Tests
{
    
    [TestFixture]
    public class GeoUtilTests
    {
        [Test]
        public void GeoUtil_ConvertsMilesToMetersCorrecly()
        {
            var target = GeoUtil.MilesToMeters(200); //200 mile to meters
            Assert.AreEqual(321868.8, target, float.Epsilon);
        }


        [Test]
        public void GeoUtil_ConvertsMetersToMilesCorrecly()
        {
            var target = GeoUtil.MetersToMiles(500);  //500 meters to miles
            Assert.AreEqual(0.310685596118667, target, float.Epsilon);
        }

        [Test]
        public void GeoUtil_ConvertsYardsToMetersCorrecly()
        {
            var target = GeoUtil.YardsToMeters(200); //200 yards to meters
            Assert.AreEqual(182.88, target, float.Epsilon);
        }


        [Test]
        public void GeoUtil_ConvertsMetersToYardsCorrecly()
        {
            var target = GeoUtil.MetersToYards(500);  //500 meters to yards
            Assert.AreEqual(546.80664916885394, target, float.Epsilon);
        }
       
    }
}
