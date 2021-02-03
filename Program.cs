using System;
using System.Collections.Generic;
namespace Delegates_Continuation_Module_10
{
    class Program
    { 

        public delegate string MyDelegatePointer(int a, int b);

        static void Main(string[] args)
        {
            MyFPSGame fpsgame = new MyFPSGame();

            fpsgame.GameActions();
        }
    }
}

public class MyFPSGame
{
   
    private Action theCharacterAction;
  

    public void GameActions()
    {
        ConsoleKey key = ConsoleKey.Enter;

        while (key != ConsoleKey.E)
        {

            Console.WriteLine("F -> Fire");
            Console.WriteLine("R -> Reload");
            Console.WriteLine("C -> Change Gun");
            Console.WriteLine("L -> Peek Left");
            Console.WriteLine("Z -> Peek Right");
            Console.WriteLine("E -> Quit");

            Console.WriteLine("");
            Console.WriteLine("Select an Action");
            key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.F:
                    theCharacterAction = FireGun;
                    break;
                case ConsoleKey.R:
                    theCharacterAction = ReloadGun;
                    break;
                case ConsoleKey.C:
                    theCharacterAction = ChangeGun;
                    break;
                case ConsoleKey.L:
                    theCharacterAction = PeekLeft;
                    break;
                case ConsoleKey.Z:
                    theCharacterAction = PeekRight;
                    break;
            }

            HandleAction();
        }
    }

    public void FireGun()
    {
        Console.WriteLine("");
        Console.WriteLine("You have fired your Gun");
    }

    public void ReloadGun()
    {
        Console.WriteLine("");
        Console.WriteLine("You Reloaded you Gun");
    }

    public void ChangeGun()
    {
        Console.WriteLine("");
        Console.WriteLine("You have changed Gun");
    }

    public void PeekLeft()
    {
        Console.WriteLine("");
        Console.WriteLine("You are Peeking left");
    }

    public void PeekRight()
    {
        Console.WriteLine("");
        Console.WriteLine("You are Peeking Right");
    }

    public void HandleAction()
    {
        theCharacterAction();   
    }

}
