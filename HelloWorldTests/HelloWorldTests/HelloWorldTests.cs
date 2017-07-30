using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorldTests
{
    [TestFixture]
    class HelloWorldTests
    {
        [Test]
        public void HelloWorld()
        {
            Assert.That(4+5, Is.EqualTo(9));
            //Assert.That(4 + 5, Is.EqualTo(10));
        }
    }
}
