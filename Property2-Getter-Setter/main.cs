using System;

class MainClass {

  class Book {
    
    // 1
    string title;
    public string GetTitle() { return title; }
    public void SetTitle(string title) {this.title = title};

    // 2
    string title;
    public string Title {
      get {
        return title;
      }
      set {
        title = value;
      }
    }

    // 3
    public string Title { get; private set; }





    public string Title { get; private set; }


    public int Price { get; set; }
    public Book(string title, int price) {
      Title = title;
      Price = price;
    }
    public Book() { Title = "Fun"; }

    // public string Title {
    //   get {
    //     Console.WriteLine("get()"); return title;
    //   }
    //   set {
    //     title = value != "" ? value : "N/A";
    //   }
    // }
  }

  public static void Main (string[] args) {
    Book b = new Book { Title="TLOR", Price=30000 }; // object initializer 구문
    print(b.Title);
    b.Title = "ctim";
    Book c = new Book("TLOR", 30000);
    // c.Title = "Hobbit";
    // var d = new { Title="Hobbit", Price=10000 };
    Book e = new Book();
    Console.WriteLine(e.Title == "Fun");
  }
}