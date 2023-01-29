using OHCE;
using OHCE.Langues;

ILangue langue = new LangueFrançaise(); // Ici on instancie une langue à la main vu que ce n'est pas encore automatique
PeriodeJournee periode = PeriodeJournee.Matin; // Ici pareil, la période n'est pas encore automatique on l'instancie donc à la main

var ohce = new Ohce(langue, periode);
Console.WriteLine("//////////////     OHCE - Thomas GRAVY     //////////////");
Console.WriteLine(langue.LangageUtilise + " : " + langue);
Console.WriteLine(langue.Periode + " : " + periode);
Console.WriteLine(langue.TexteConvivial);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));