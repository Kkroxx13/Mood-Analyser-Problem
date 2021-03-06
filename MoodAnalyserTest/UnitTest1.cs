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
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenHappyMood_ShouldReturnHappy()
        {
            string message = "I am very Happy today";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            string expected = "Happy";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}