using System;


namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string _message;

        private string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        public MoodAnalyser() { }
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException exception)
            {

                Console.WriteLine($"Null Message Exception:{exception.Message}");
                return "Happy";
            }
        }
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood();
            Console.WriteLine(mood);
        }
    }
}
