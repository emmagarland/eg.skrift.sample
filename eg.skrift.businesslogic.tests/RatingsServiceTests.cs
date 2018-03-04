using System;
using eg.skrift.businesslogic.Services;
using NUnit.Framework;

namespace eg.skrift.businesslogic.tests
{
    [TestFixture]
    public class RatingsServiceTests
    {
        private const int testEventId = 4047;
        private const int rating = 5;

        [SetUp]
        public void SetUp()
        {
            //TODO: setup code here
        }

        [TearDown]
        public void TearDown()
        {
        }

        public RatingsService CreateSut()
        {
            return new RatingsService();
        }

        [Test]
        public void GetRating_WhenCalledWithEventId_ReturnsCorrectRating()
        {
            var sut = CreateSut();

            var result = sut.GetRating(testEventId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(rating));
        }

        [Test]
        public void SetRating_WhenCalledWithRatingAndEventId_ShouldNotThrowException()
        {
            var sut = CreateSut();

            try
            {
                sut.SetRating(rating, testEventId);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
