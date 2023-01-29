namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string Bonjour(PeriodeJournee periode);
        string AuRevoir(PeriodeJournee periode);
        string LangageUtilise { get; }
        string Periode { get; }
        string TexteConvivial { get; }
        string MotInverse { get; }
    }
}
