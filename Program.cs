using System;
using System.Collections.Generic;
using System.Linq;

// Входные данные
List<int> numbers = new List<int> { 3, 10, 1, 5, 8 };
Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
// Сортировка по убыванию через LINQ
var sortedDesc = numbers.OrderByDescending(n => n).ToList();

Console.WriteLine("Отсортировано по убыванию: " + string.Join(", ", sortedDesc));
