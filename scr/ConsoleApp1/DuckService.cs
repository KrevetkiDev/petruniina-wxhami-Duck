using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DuckService
    {
        public int Id;
        public List<Duck> Ducks = new List<Duck>();

        public void CreateNewDuck (string name)
        {
            Duck duck = new Duck (name, Id);
            Ducks.Add(duck);
            Id++;
        }
       
        public Duck GetCompetition()
        {
            int winnerId = 0;
            foreach (var duck in Ducks)
            {
               
               bool chekALive = duck.ChekALive();
                if (chekALive)
                {
                    duck.Age++;
                }
            }
        }

    }
}
