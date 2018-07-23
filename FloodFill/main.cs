using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int[][] image = new int[][] {
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0}
    };

    Console.WriteLine( image[0].Stringify() == "0 0 0 0 0 0 0" );
    Console.WriteLine( image[1].Stringify() == "0 0 1 1 1 0 0" );
    Console.WriteLine( image[2].Stringify() == "0 0 1 0 1 0 0" );
    Console.WriteLine( image[3].Stringify() == "0 0 1 0 1 0 0" );
    Console.WriteLine( image[4].Stringify() == "0 0 1 0 1 0 0" );
    Console.WriteLine( image[5].Stringify() == "0 0 1 1 1 0 0" );
    Console.WriteLine( image[6].Stringify() == "0 0 0 0 0 0 0" );  

    FloodFill(image, 2, 3, 7);
    Console.WriteLine( image[0].Stringify() == "0 0 0 0 0 0 0" );
    Console.WriteLine( image[1].Stringify() == "0 0 1 1 1 0 0" );
    Console.WriteLine( image[2].Stringify() == "0 0 1 7 1 0 0" );
    Console.WriteLine( image[3].Stringify() == "0 0 1 7 1 0 0" );
    Console.WriteLine( image[4].Stringify() == "0 0 1 7 1 0 0" );
    Console.WriteLine( image[5].Stringify() == "0 0 1 1 1 0 0" );
    Console.WriteLine( image[6].Stringify() == "0 0 0 0 0 0 0" );    
    
    FloodFill(image, 0, 0, 7);
    Console.WriteLine( image[0].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[1].Stringify() == "7 7 1 1 1 7 7" );
    Console.WriteLine( image[2].Stringify() == "7 7 1 7 1 7 7" );
    Console.WriteLine( image[3].Stringify() == "7 7 1 7 1 7 7" );
    Console.WriteLine( image[4].Stringify() == "7 7 1 7 1 7 7" );
    Console.WriteLine( image[5].Stringify() == "7 7 1 1 1 7 7" );
    Console.WriteLine( image[6].Stringify() == "7 7 7 7 7 7 7" );
    
    FloodFill(image, 1, 2, 7);
    Console.WriteLine( image[0].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[1].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[2].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[3].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[4].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[5].Stringify() == "7 7 7 7 7 7 7" );
    Console.WriteLine( image[6].Stringify() == "7 7 7 7 7 7 7" );
  }