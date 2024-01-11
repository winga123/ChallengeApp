var name = "Ewa";
var age = 30;
var sex = "kobieta";

if (age < 30 && sex == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 30 && sex == "kobieta")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
