namespace ChallengeApp.Tests
{
    public class Tests


    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSum()
        {

            var user = new Employee("Alicja", "Rodak", "39");
            user.AddScore(1);
            user.AddScore(-2);
            user.AddScore(-8);
            user.AddScore(10);
            user.AddScore(2);

            var result = user.Result;

            Assert.AreEqual(3, result);

        }
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSum1()
        {
          
            var user = new Employee("Sylwia", "Rumiñska", "32");
            user.AddScore(7);
            user.AddScore(6);
            user.AddScore(8);
            user.AddScore(6);
            user.AddScore(-7);

            var result = user.Result;
            
            Assert.AreEqual(20, result);

        }

        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSum2()
        {

            var user = new Employee("Marcin", "Krasnal", "46");
            user.AddScore(6);
            user.AddScore(6);
            user.AddScore(4);
            user.AddScore(2);
            user.AddScore(-18);

            var result = user.Result;

            Assert.AreEqual(0, result);
        }
    }
}