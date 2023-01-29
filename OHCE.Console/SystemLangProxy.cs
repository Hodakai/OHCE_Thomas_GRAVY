using System.Globalization;
using OHCE.Langues;

namespace OHCE.Console;

public class SystemLangProxy {
    public ILangue Langue;
    public SystemLangProxy()
    {
      var systemLang = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
      if (systemLang == "fr")
      {
          Langue = new LangueFrançaise();
      }
      else
      {
          Langue = new LangueAnglaise();
      }
    }
}