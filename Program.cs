using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var setB = new HashSet<int>(b);
    return a.Where(x => !setB.Contains(x)).ToArray();
  }
}
