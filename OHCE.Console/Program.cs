using OHCE;

var ohce = new Ohce();
Console.WriteLine("//////////////     OHCE - Thomas GRAVY     //////////////");
Console.WriteLine("Entrez un mot et mon OHCE vous dira si c'est un palindrome ou non");
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));