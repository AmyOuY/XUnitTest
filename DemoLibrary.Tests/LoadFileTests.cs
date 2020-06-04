using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class LoadFileTests
    {
        [Fact]
        public void Load_ValidNameShouldWork()
        {
            string actual = LoadFile.Load("It is a valid file name");

            Assert.True(actual.Length > 0);
        }


        //[Fact]
        //public void Load_InvalidNameShouldFail()
        //{
        //    Assert.Throws<FileNotFoundException>(() => LoadFile.Load(" "));
        //}


        [Fact]
        public void Load_InvalidNameShouldFail()
        {
            Assert.Throws<ArgumentException>("file", () => LoadFile.Load(" "));
        }

    }
}
