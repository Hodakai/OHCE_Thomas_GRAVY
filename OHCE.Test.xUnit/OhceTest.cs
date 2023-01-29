using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void ReverseTest()
    {
        var ohce = OhceBuilder.Base;

        var reversed = ohce.Palindrome("test");
        
        Assert.Contains("tset", reversed);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on entre un palindrome " +
        "ALORS il est renvoyé " +
        "ET le <bienDit> de cette langue est envoyé")]
    [MemberData(nameof(LanguesSeules))]
    public void PalindromeTest(ILangue langue)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        const string palindrome = "kayak";
        var reversed = ohce.Palindrome(palindrome);

        Assert.Contains(palindrome + langue.BienDit, reversed);
    }

    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
    {
        new LangueAnglaise(),
        new LangueFrançaise()
    };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND l'app démarre " +
        "ALORS <bonjour> de cette langue à cette période est envoyé")]
    [MemberData(nameof(LanguesSeules))]
    public void DémarrageTest(ILangue langue)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.StartsWith(langue.Bonjour, reversed);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND l'app se ferme " +
        "ALORS <auRevoir> dans cette langue est envoyé")]
    [MemberData(nameof(LanguesSeules))]
    public void FermetureTest(ILangue langue)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.EndsWith(langue.AuRevoir, reversed);
    }
}