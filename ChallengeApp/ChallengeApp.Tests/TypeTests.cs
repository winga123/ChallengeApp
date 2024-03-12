
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetReturnShouldDiferrentNumbersUsersInSystem()
        {
            int user1 = 33;
            int user2 = 21;

            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void GetReturnSumPointsUsers()
        { 
            int user1 = 45;
            int user2 = -15;
            int result = user1 + user2;

            Assert.Positive(result);
        }
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            var user1 = GetEmployee("Sylwia", "Rumińska", "32");
            var user2 = GetEmployee("Sylwia", "Bąk", "90");
    
            Assert.AreEqual(user1.Name, user2.Name);
        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee("name", "surname", "age");
        }
    }
    
}   

