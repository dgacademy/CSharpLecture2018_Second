using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Thread Id: " + Thread.CurrentThread.ManagedThreadId);
  }
}