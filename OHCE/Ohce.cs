using System.Text;

namespace OHCE;

public class Ohce
{
    public Ohce() { }

    public string Palindrome(string input)
    {
        var bonjour = new string(DireBonjour());
        var auRevoir = new string(DireAuRevoir());
        var fullString = new StringBuilder(bonjour + '\n');
        var reversed = new string(input.Reverse().ToArray());

        if (reversed.Equals(input)) {
            fullString.Append("Palindrome : " + reversed + "\n" + "Bien dit !\n");
        } else {
            fullString.Append("Mot inversé : " + reversed + "\n");
        }

        fullString.Append(auRevoir);
        return fullString.ToString();
    }

    public string DireBonjour()
    {
        return "Bonjour";
    }

    public string DireAuRevoir()
    {
        return "Au revoir";
    }
}