using System;
class bracket {
  static void Main() {
    string str="[{]}";
    do {
        str=str.Replace("()","").Replace("[]","").Replace("{}","").Replace(" ","");
    }
    while (str.Contains("()") | str.Contains("[]") | str.Contains("{}"));
    if (str=="") {
      Console.WriteLine("Скобочная последовательность корректная");
    }
    else {
      Console.WriteLine("Скобочная последовательность некорректная");
    }
  }
  
}
