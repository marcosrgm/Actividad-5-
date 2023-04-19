// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, introduce tu nombre");
var nombre = Console.ReadLine();

var nombreInvertido= "";
Console.Write("Adiós " + nombreInvertido);

for (int i = (nombre.Length-1); i >= 0; i--)
{
    Console.Write(nombre[i]);
}