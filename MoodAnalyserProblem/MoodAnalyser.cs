using System;


namespace MoodAnalyserProblem
{
   public  class MoodAnalyser
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
            if (this.Message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy mood");
            string mood = moodAnalyser.AnalyseMood();
        }
    }
}
