using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    //HashSets work for bigger arrays, in a realistic setting.
    var setB = new HashSet<int>(b);
    return a.Where(x => !setB.Contains(x)).ToArray();
  }
}
