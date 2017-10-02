using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBii.DatenVerarbeitung
{
  static class DateTimes
  {
    static public int GetAlter(DateTime Geburtstag)
    {
      Age age = new Age(Geburtstag);
      
      return age.Years;
    }
    static public int GetAlterAtSchFest(DateTime Geburtstag)
    {
      RBDataVerschiedenesTableAdapters.VerschiedenesTableAdapter adapter = new RBDataVerschiedenesTableAdapters.VerschiedenesTableAdapter();
      DateTime SchFest = (DateTime)adapter.GetSchFest();
      Age age = new Age(Geburtstag, SchFest);

      return age.Years;
    }
  }
}
