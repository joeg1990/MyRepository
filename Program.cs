using System;

namespace Delegates_Code
{
    class Program
    {

        private delegate void MyMethodPointer(int a, int b);

        static void Main(string[] args)
        {
            MyMethodPointer pointer;

            JoesClass myClass = new JoesClass();

            pointer = myClass.AddingNumbers;
            pointer += myClass.SubtactingNumbers;
           
            pointer += delegate (int g, int h)
           
            {
                Console.WriteLine(g * h);
            };
            
            pointer += (int d, int e) => {
                Console.WriteLine(d / e);
            };
             
            pointer(15, 3);
        }
    }
}

public class JoesClass
{
  public void AddingNumbers(int parameter1, int parameter2)
    {
        Console.WriteLine(parameter1 + parameter2  );
    }
    public void SubtactingNumbers(int x, int y)
    {
        Console.WriteLine(x - y);
    }
}
