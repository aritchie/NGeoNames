using System;
using System.Linq;
using NGeoNames.Entities;
using NUnit.Framework;


namespace NGeoNames.Tests
{
    [TestFixture]
    public class CitySearchTests
    {

        [Test]
        public void CitySearch()
        {
            var data = GeoFileReader
                .ReadExtendedGeoNames(@"testdata\cities15000.txt");
                //.Where(x => x.CountryCode.Equals("CA", StringComparison.CurrentCultureIgnoreCase));
            var rgc = new ReverseGeoCode<ExtendedGeoName>(data);
            var results = rgc.NearestNeighbourSearch(43.6479327, -79.36914, 1).ToList();
            Assert.IsNotNull(results != null, "No Results");
            Assert.AreEqual(results[0].CountryCode, "CA");
            Assert.AreEqual(results[0].Name, "North York");
        }
    }
}
