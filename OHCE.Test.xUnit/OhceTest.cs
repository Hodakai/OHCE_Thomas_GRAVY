namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void ReverseTest()
    {
        var ohce = new Ohce();

        var reversed = ohce.Palindrome("test");
        
        Assert.Contains("tset", reversed);
    }

    [Fact(DisplayName = "QUAND on entre un palindrome " +
                          "ALORS il est renvoyé ")]
    public void TestPalindrome()
    {
        var ohce = new Ohce();

        const string palindrome = "kayak";
        var reversed = ohce.Palindrome(palindrome);

        Assert.Contains(palindrome, reversed);
    }

    [Fact(DisplayName = "QUAND l'app démarre " +
                          "ALORS 'Bonjour' est envoyé")]
    public void InitTest()
    {
        var ohce = new Ohce();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.StartsWith("Bonjour", reversed);
    }

    [Fact(DisplayName = "QUAND l'app se ferme " +
                          "ALORS 'Au revoir' est envoyé")]
    public void FermetureTest()
    {
        var ohce = new Ohce();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.EndsWith("Au revoir", reversed);
    }
}