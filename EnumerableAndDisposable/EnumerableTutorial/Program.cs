//Your code here (above the PersonName class)

var bond = new PersonName("James", "Bond");
var rock = new PersonName("Dwayne", "Johnson", "Rock");
var bebeto = new PersonName("José", "de Oliveira", "Roberto", "Gama");

foreach (var name in bond)
    Console.Write($"{name}, ");
Console.WriteLine();

foreach (var name in rock)
    Console.Write($"{name}, ");
Console.WriteLine();

foreach (var name in bebeto)
    Console.Write($"{name}, ");
Console.WriteLine();