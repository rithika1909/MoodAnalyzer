using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        MoodAnalyzer analyzer = new MoodAnalyzer();
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnTurnSad()
        {
            string message = " I Am In Sad Mood";
            string actual = analyzer.AnalyzeMood(message);
            Assert.AreEqual(actual,"SAD");

        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnTurnHappy()
        {
            string message = " I Am In Any Mood";
            string actual = analyzer.AnalyzeMood(message);
            Assert.AreEqual(actual,"HAPPY");

        }
    }
}