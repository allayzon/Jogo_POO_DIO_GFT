using System;
using Jogo_POO.src.Entities;

namespace Jogo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight", 99, 17);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 65, 29);
            Ninja ninja = new Ninja("Wedge", 24, "Ninja", 87, 24);
            BlackWizard blackWizard = new BlackWizard("Topapa", 29, "Black Wizard", 99, 99);

            System.Console.WriteLine(hero);
            System.Console.WriteLine(wizard);
            System.Console.WriteLine(ninja);
            System.Console.WriteLine(blackWizard);
            
            System.Console.WriteLine(blackWizard.Attack(20));
            System.Console.WriteLine(blackWizard.Attack(2));
            System.Console.WriteLine(blackWizard.Attack());
            System.Console.WriteLine(wizard.Attack(8));
            System.Console.WriteLine(wizard.Attack(2));
            System.Console.WriteLine(wizard.Attack());
            System.Console.WriteLine(ninja.Attack());
            System.Console.WriteLine(ninja.Attack(20));
            System.Console.WriteLine(hero.Attack());
        }
    }
}
