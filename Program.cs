// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("POO-2025-2");

Televisao tv = new Televisao(55f); 

//tv.Tamanho = 22.5f;

Console.WriteLine($"A minha TV tem o tamanho de {tv.Tamanho} polegadas");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");
