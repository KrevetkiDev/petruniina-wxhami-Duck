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

        public void CreateNewDuck(string name)
        {
            Duck duck = new Duck(name, Id);
            Ducks.Add(duck);
            Id++;
        }

        public Duck GetCompetition()
        {
            int winnerId = 0;
            double max = 0;

            foreach (var duck in Ducks)
            {
                if (duck.ChekALive())
                {
                    duck.Age++;
                    double coefficient = duck.GetCoefficient();
                    if (coefficient > max)
                    {
                        max = coefficient;
                        winnerId = duck.Id;
                    }

                    duck.Competition();
                }
            }
            Duck winnerDuck = GetDuckById(winnerId);
            winnerDuck.StatusSuper = true;
            return winnerDuck;

        }

        public Duck GetDuckById(int id)
        {
            var duck = Ducks.FirstOrDefault(duck => duck.Id == id);
            return duck;
        }

    }
}