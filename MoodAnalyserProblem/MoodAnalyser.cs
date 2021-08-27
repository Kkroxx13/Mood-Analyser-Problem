using System;

namespace MoodAnalyserProblem
{
    class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }
        }
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood("I am very happy today");
        }
    }
}
