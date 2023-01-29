using OHCE;
using OHCE.Console;

PeriodeJournee periode = new SystemTimePeriodeJourneeAdapter().PeriodeActuelle;
ILangue langue = new SystemLangProxy().Langue;

var ohce = new Ohce(langue, periode);
Console.WriteLine("//////////////     OHCE - Thomas GRAVY     //////////////");
Console.WriteLine(langue.LangageUtilise + " : " + langue);
Console.WriteLine(langue.Periode + " : " + periode);
Console.WriteLine(langue.TexteConvivial);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));