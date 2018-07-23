using System;

class User {
  public string Name { get; set; }
  public int Age { get; set; }
  
  public User(string name, int age) {
    Name = name;
    Age = age;
  }
}

class MainClass {
  public static void Main (string[] args) {
    User[] list = new User[4];
    list[0] = new User("Daniel", 27);    
    list[1] = new User("Outsider", 30);
    list[2] = new User("Wolf", 17);
    list[3] = new User("Song", 20);
    
    Console.WriteLine( FindIndexOf(list, (index, user) => user.Name == "Wolf") == 2 );  // 이름이 Wolf가 들어있는 index 구하기
    Console.WriteLine( FindIndexOf(list, (index, user) => user.Name == "Kim") == -1 );
    Console.WriteLine( CountOf(list, (index, user) => user.Age >= 20) == 3 );           // 나이가 20 이상이 몇 명인가?
    Console.WriteLine( CountOf(list, (index, user) => user.Age >= 10) == 4 );
    Console.WriteLine( CountOf(list, (index, user) => user.Age > 100) == 0 );
  }
}