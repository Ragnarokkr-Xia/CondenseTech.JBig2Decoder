using System.Collections.Generic;

namespace CondenseTech.JBig2Decoder.Segments
{
  public abstract class Flags
  {
    protected int flagsAsInt;
    protected Dictionary<string, int> flags = new Dictionary<string, int>();

    public int GetFlagValue(string key)
    {
      int value = flags[key];
      return value;
    }
    public abstract void SetFlags(int flagsAsInt);
  }
}
