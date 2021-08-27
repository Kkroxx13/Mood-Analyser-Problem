using NUnit.Framework;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {

            string message = "I am sad today";
            string expected = "Sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expected, mood);
        }
    }
}