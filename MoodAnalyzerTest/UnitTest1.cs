using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnTurnSad()
        {
            string message = " I Am In Sad Mood";
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string actual = analyzer.AnalyzeMood(message);
            Assert.AreEqual(actual,"SAD");

        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnTurnHappy()
        {
            string message = " I Am In Any Mood";
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string actual = analyzer.AnalyzeMood(message);
            Assert.AreEqual(actual,"HAPPY");

        }
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string actual = analyzer.AnalyzeMood(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}