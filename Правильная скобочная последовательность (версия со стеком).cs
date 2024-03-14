using System;
using System.Collections.Generic;
using System.Linq;
class bracket {
  static void Main() {
    //Создание словаря
    var dic_brackets = new Dictionary<char, char>()
       {
          { '(', ')'},
          { '[', ']'},
          { '{', '}'}
       };
    // входная строка
    string str="{}[]([)]";
    Stack<char> check_stack = new Stack<char>();
    //переменная для проверки
    bool check = true;
    foreach(char i in str)
       {
        if (dic_brackets.ContainsKey(i)) {
            check_stack.Push(i);
            }
        else {
            if (check_stack.Count==0) {
                check = false;
                break;
            }
            //если верхний символ стека не в паре с текущей закрывающей, послед. некорректная
            char last=check_stack.Pop();
            if (dic_brackets.FirstOrDefault(kv => kv.Key.Equals(last)).Value!=i) {
                check = false;
                break;
            }
            }
       }
       if (check_stack.Count==0 & check == true) {
           Console.WriteLine("Скобочная последовательность корректная");
       }
       else if (check == false) {
           Console.WriteLine("Скобочная последовательность некорректная");
       }
  }
  
}