﻿
using ChallengeApp;

var employee = new Employee("Alicja", "Rodak");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();

}







