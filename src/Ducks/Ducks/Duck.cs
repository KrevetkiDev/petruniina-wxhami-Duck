using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Duck
    {
        public double Weight;
        public string Name;
        public double Tonus;
        public int Age;
        public double Sleeping;
        public int Id;
        public bool StatusSuper;

        public Duck(string name, int id)
        {
            Name = name;
            Tonus = 0;
            Sleeping = 0;
            Age = 0;
            Weight = 0;
            Id = id;
        }

        public void ShowDuck()
        {
            if (!ChekALive())
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.Write($"[{Id}]");

            if (StatusSuper)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"[{Name}]");
                Console.ResetColor();
            }
            else
            {
                Console.Write(Name);
            }

            Console.WriteLine($" Sleeping: {Sleeping} Weight: {Weight} Tonus: {Tonus} Age: {Age}");

            Console.ResetColor();
        }

        public void Eat()
        {
            Weight += 0.2;
            Tonus += 1;
            ChekSleeping();
        }
        public void Sleep()
        {
            Tonus += 1;
            ChekSleeping();
        }
        public void Trening()
        {
            Sleeping -= 1;
            Tonus += 1;
            Weight -= 0.1;
            ChekSleeping();
        }
        public void Swimming()
        {
            Tonus += 1;
            Sleeping += 1;
            ChekSleeping();
        }
        public void Competition()
        {
            Tonus -= 2;
            Sleeping -= 2;
            Weight -= 0.2;
            ChekSleeping();
        }
        private void ChekSleeping()
        {
            if (Sleeping < 0)
            {
                Tonus -= 0.5;
            }
        }
        public bool ChekALive()
        {
            if (Age >= 10)
            {
                return false;

            }
            return true;

        }
        public double GetCoefficient()
        {
            int procent = 0;
            if (Age > 7)
            {
                procent += -15;
            }
            if (Weight > 7)
            {
                procent += -30;
            }

            if (StatusSuper)
            {
                procent += 10;
            }

            return Tonus + Tonus * procent;
        }
    }

}