using OHCE;
using OHCE.Langues;

ILangue langue = new LangueAnglaise(); // Ici on instancie une langue à la main vu que ce n'est pas encore automatique

var ohce = new Ohce(langue);
Console.WriteLine("//////////////     OHCE - Thomas GRAVY     //////////////");
Console.WriteLine(langue.TexteConvivial);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));