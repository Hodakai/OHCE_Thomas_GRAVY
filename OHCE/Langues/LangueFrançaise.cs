namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        public string BienDit => Expressions.Français.BienDit;
        public string Bonjour(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.Bonsoir : Expressions.Français.Bonjour;
        }
        public string AuRevoir(PeriodeJournee periode)
        {
            return periode == PeriodeJournee.Soir || periode == PeriodeJournee.Nuit ? Expressions.Français.AuRevoirSoir : Expressions.Français.AuRevoir;
        }
        public string LangageUtilise => Expressions.Français.LangueUtilisee;
        public string Periode => Expressions.Français.Periode;
        public string TexteConvivial => Expressions.Français.TexteConvivial;
        public string MotInverse => Expressions.Français.MotInverse;
    }
}
