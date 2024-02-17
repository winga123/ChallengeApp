
using ChallengeApp;

Employee employee1 = new ("Alicja", "Rodak", "39");
Employee employee2 = new ("Sylwia", "Rumińska", "32");
Employee employee3 = new ("Marcin", "Krasnal", "46");

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

if (result1 > result2 & result1 > result3)
{
    Console.WriteLine(result1);
    Console.WriteLine(employee1.Name);
    Console.WriteLine(employee1.Surname);
    Console.WriteLine(employee1.Age);
}
else if (result2 > result1 & result2 > result3)
{
    Console.WriteLine(result2);
    Console.WriteLine(employee2.Name);
    Console.WriteLine(employee2.Surname);
    Console.WriteLine(employee2.Age);
}
else if (result3 > result1 & result3 > result2)
{
    Console.WriteLine(result3);
    Console.WriteLine(employee3.Name);
    Console.WriteLine(employee3.Surname);
    Console.WriteLine(employee3.Age);

}


    
    
 



