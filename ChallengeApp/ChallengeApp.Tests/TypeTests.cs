
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetReturnShouldDiferrentNumbersUsersInSystem()
        {
            //arrange
            int user1 = 33;
            int user2 = 21;


            //act

            //assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void GetReturnSumPointsUsers()
        {
            //arrange
            int user1 = 45;
            int user2 = -15;
            int result = user1 + user2;


             //act

             //assert
             Assert.Positive(result);
        }
        
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {

             //arrange
             var user1 = GetEmployee("Sylwia", "Rumińska", "32");
             var user2 = GetEmployee("Sylwia", "Bąk", "90");
             //act

             //assert
             Assert.AreEqual(user1.Name, user2.Name);
        }
      
        private Employee GetEmployee(string name, string surname, string age)

        {
            return new Employee("name", "surname", "age");
        }
    }
    
}   

