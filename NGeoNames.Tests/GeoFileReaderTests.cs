using NUnit.Framework;
using NGeoNames;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace NGeoNames.Tests
{
    [TestFixture]
    public class GeoFileReaderTests
    {
        [Test]
        public void GeoFileReader_ParsesFileCorrectly1()
        {
            var gf = new GeoFileReader();
            var target = gf.ReadRecords<CustomEntity>(@"testdata\test_geofilereadercustom1.txt", new CustomParser(9, 1, new[] { ',' }, Encoding.UTF8, true)).ToArray();
            Assert.AreEqual(2, target.Length);
        }

        [Test]
        public void GeoFileReader_ParsesFileCorrectly2()
        {
            var gf = new GeoFileReader();
            var target = gf.ReadRecords<CustomEntity>(@"testdata\test_geofilereadercustom2.txt", new CustomParser(4, 0, new[] { '!' }, Encoding.UTF8, false)).ToArray();
            Assert.AreEqual(3, target.Length);
        }

        //[Test]
        //[ExpectedException(typeof(NotSupportedException))]
        //public void GeoFileReader_ThrowsOnFailureWhenAutodetectingFileType()
        //{
        //    //When filetype == autodetect and an unknown extension is used an exception should be thrown
        //    var gf = new GeoFileReader();
        //    var target = gf.ReadRecords<CustomEntity>(@"testdata\invalid.ext", new CustomParser(5, 0, new[] { '\t' }, Encoding.UTF8, false)).ToArray();
        //}

        //[Test]
        //public void GeoFileReader_DoesNotThrowOnInvalidExtensionButSpecifiedFileType()
        //{
        //    //When filetype is specified and an unknown extension is used it should be read fine
        //    var gf = new GeoFileReader();
        //    var target = gf.ReadRecords<CustomEntity>(@"testdata\invalid.ext", new CustomParser(5, 0, new[] { '\t' }, Encoding.UTF8, false)).ToArray();
        //}

        //[Test]
        //[ExpectedException(typeof(NotSupportedException))]
        //public void GeoFileReader_ThrowsOnUnknownSpecifiedFileType()
        //{
        //    //When and unknown filetype is specified an exception should be thrown
        //    var gf = new GeoFileReader();
        //    var target = gf.ReadRecords<CustomEntity>(@"testdata\invalid.ext", new CustomParser(5, 0, new[] { '\t' }, Encoding.UTF8, false)).ToArray();
        //}
    }
}
