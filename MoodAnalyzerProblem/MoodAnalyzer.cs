namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood(string message)
        {
            try
            {
                if(message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";

            }

        }

    }
}