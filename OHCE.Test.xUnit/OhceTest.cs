using System.Text;
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

        Assert.Contains(palindrome + "\n" + langue.BienDit, reversed);
    }

    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
    {
        new LangueAnglaise(),
        new LangueFrançaise()
    };

    private static readonly IEnumerable<PeriodeJournee> Périodes = new PeriodeJournee[]
    {
        PeriodeJournee.Defaut,
        PeriodeJournee.Matin,
        PeriodeJournee.AprèsMidi,
        PeriodeJournee.Soir,
        PeriodeJournee.Nuit
    };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);
    public static IEnumerable<object[]> LanguesEtPériodes => new CartesianData(Langues, Périodes);

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la période de la journée est <période>" +
        "QUAND l'app démarre " +
        "ALORS <bonjour> de cette langue à cette période est envoyé")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void DémarrageTest(ILangue langue, PeriodeJournee periode)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPeriodeDeLaJournee(periode)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.StartsWith(langue.Bonjour(periode), reversed);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la période de la journée est <période>" +
        "QUAND l'app se ferme " +
        "ALORS <auRevoir> dans cette langue est envoyé")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void FermetureTest(ILangue langue, PeriodeJournee periode)
    {
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPeriodeDeLaJournee(periode)
            .Build();

        var reversed = ohce.Palindrome(string.Empty);

        Assert.EndsWith(langue.AuRevoir(periode), reversed);
    }
}