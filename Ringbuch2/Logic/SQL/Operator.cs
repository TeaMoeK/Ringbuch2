using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ringbuch2
{
  /// <summary>
  /// Die Operatoren werden mit vorangestelltem Leerzeichen zurückgegeben
  /// </summary>
  class Operator
  {
    private vergleichsoperatoren mOperator;
    public Operator(vergleichsoperatoren pOperator)
    {
      mOperator = pOperator;
    }
    public override string ToString()
    {
      string retn = string.Empty;
      switch (mOperator)
      {
        case vergleichsoperatoren.GREATER:
          retn = " > ";
          break;
        case vergleichsoperatoren.LESS:
          retn = " < ";
          break;
        case vergleichsoperatoren.EQUAL:
          retn = " = ";
          break;
        case vergleichsoperatoren.LIKE:
          retn = " LIKE ";
          break;
        case vergleichsoperatoren.GREATER_OR_EQUAL:
          retn = " >= ";
          break;
        case vergleichsoperatoren.LESS_OR_EQUAL:
          retn = " <= ";
          break;
        case vergleichsoperatoren.NOT_EQUAL:
          retn = " != ";
          break;
        default:
          break;
      }


      return retn;
    }
    public enum vergleichsoperatoren
    {
      GREATER,
      LESS,
      EQUAL,
      LIKE,
      GREATER_OR_EQUAL,
      LESS_OR_EQUAL,
      NOT_EQUAL,
      AND,
      OR
    }
  }
}
