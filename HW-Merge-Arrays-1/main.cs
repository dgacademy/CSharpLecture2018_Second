using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int[] arrayA = { 1, 3, 5, 7, 9 };
    int[] arrayB = { 2, 4, 6, 8 };

    Console.WriteLine (MergeArrays(arrayA, arrayB).Stringify() == "1 2 3 4 5 6 7 8 9");

    int[] arrayC = { 1, 2, 5, 7, 9};
    int[] arrayD = { 2, 4, 6, 8, 10, 11, 12};
    Console.WriteLine( MergeArrays(arrayC, arrayD).Stringify() == "1 2 2 4 5 6 7 8 9 10 11 12");

    Console.WriteLine( MergeArrays(new int[] {}, new int[] {}).Stringify() == "");
    Console.WriteLine( MergeArrays(new int[] {}, new int[] {1, 5, 10}).Stringify() == "1 5 10");

    Console.WriteLine( MergeArrays(new int[] {1, 1, 1}, new int[] {2, 2, 2, 2}).Stringify() == "1 1 1 2 2 2 2");
  }

  public static int[] MergeArrays(int[] arrayA, int[] arrayB) {
    int[] Merge = new int[ arrayA.Length + arrayB.Length ];
    Array.Copy(arrayA, 0, Merge, 0, arrayA.Length);
    Array.Copy(arrayB, 0, Merge, arrayA.Length, arrayB.Length);
    Array.Sort(Merge);    // O(n)   , O(n*logn)
    return Merge;
    // var ss1 = from m in Merge
    //           orderby 1 ascending
    //           select m;
    // return ss1;
  }
}

public static class ExClass {
  public static string Stringify<T>(this IEnumerable<T> list) {
    string s = string.Empty;
    foreach(var v in list)
      s += v.ToString() + " ";
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1);
    return s;
  }
}