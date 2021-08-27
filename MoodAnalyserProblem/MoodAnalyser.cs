using System;


namespace MoodAnalyserProblem
{
   public  class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad";
            }
            else
            {
                return "Happy ";
            }
        }
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine("Please enter a string");
            string mood = Console.ReadLine();
            Console.WriteLine(moodAnalyser.AnalyseMood(mood)); 
           // string mood = moodAnalyser.AnalyseMood("I am very happy today");
        }
    }
}
