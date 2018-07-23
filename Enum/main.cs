using System;

class MainClass {
  enum Animal { MOUSE, CAT, BIRD, DOG=10, LION };
  
  public static void Main (string[] args) {
    Animal a = Animal.DOG;
    Console.WriteLine(a);
    Console.WriteLine((int)a == 10);
    Console.WriteLine((int)Animal.MOUSE == 0);
    Console.WriteLine((int)Animal.LION == 11);
  }
}