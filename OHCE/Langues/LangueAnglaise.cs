namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        public string BienDit => Expressions.Anglais.BienDit;
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Anglais.Bonsoir : Expressions.Anglais.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Anglais.AuRevoirSoir : Expressions.Anglais.AuRevoir;
        }
        public string LangageUtilise => Expressions.Anglais.LangueUtilisee;
        public string Periode => Expressions.Anglais.Periode;
        public string TexteConvivial => Expressions.Anglais.TexteConvivial;
        public string MotInverse => Expressions.Anglais.MotInverse;
    }
}
