using System;
using NUnit.Framework;

namespace todictionary.tests
{
    [TestFixture]
    public class StringUtilitiesTests
    {
        private StringUtilities sut;

        [SetUp]
        public void Setup() {
            sut = new StringUtilities();
        }

        [Test]
        public void Erstes_Beispiel() {
            var result = sut.ToDictionary("a=1;b=2;c=3");

            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result["a"], Is.EqualTo("1"));
            Assert.That(result["b"], Is.EqualTo("2"));
            Assert.That(result["c"], Is.EqualTo("3"));
        }

        [Test]
        public void Zweites_Beispiel() {
            var result = sut.ToDictionary("a=1;a=2");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result["a"], Is.EqualTo("2"));
        }

        [Test]
        public void Drittes_Beispiel() {
            var result = sut.ToDictionary("a=1;;b=2");

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result["a"], Is.EqualTo("1"));
            Assert.That(result["b"], Is.EqualTo("2"));
        }

        [Test]
        public void Viertes_Beispiel() {
            var result = sut.ToDictionary("a=");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result["a"], Is.EqualTo(""));
        }

        [Test]
        public void Fünftes_Beispiel() {
            Assert.Throws<Exception>(() => sut.ToDictionary("=1"));
        }

        [Test]
        public void Sechstes_Beispiel() {
            var result = sut.ToDictionary("");

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Siebstes_Beispiel() {
            var result = sut.ToDictionary("a==1");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result["a"], Is.EqualTo("=1"));
        }
    }
}