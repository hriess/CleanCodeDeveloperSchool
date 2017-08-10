using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Textumbruch
{
    [TestFixture]
    class TextumbruchTests
    {
        // private int i = 0;
        //[Test]
        public void HelloWorld(int i)
        {
            Assert.That(i, Is.LessThanOrEqualTo(6));
            System.Console.Out.WriteLine("Iteration: " + i);
            //Assert.That(4 + 5, Is.EqualTo(10));
        }

         [Test]
        public void HelloWorld_1_to_6_times()
        {
            for ( var i = 1; i < 8; i++)
            {
                HelloWorld(i);
                
            }
        }
        [Test]
        public void HelloWorld_5_to1_7_times()
        {
            for (var i = 1; i < 7; i++)
            {
                System.Console.Out.WriteLine("-------"+ i);
                HelloWorld(i);
                HelloWorld_1_to_6_times();
                
            }
        }

        te
    }
}