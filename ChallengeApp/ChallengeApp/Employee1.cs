﻿
namespace ChallengeApp
{
    public class Employee1
    {
        private List<int> score = new List<int>();
        public Employee1(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
           
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
         

        }
        public void RemoveScore(int number) 
        {
            this.score.Remove(number);
        }
    }
}
