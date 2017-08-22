using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqFinalFrontier
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaceships = new List<Spaceship>();
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());

            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());

            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            
            
            Console.WriteLine($"{sumOfEarthShips(spaceships)} spaceships are staying home protecting Mother Earth!");
            sendShipsToFightMonsters(spaceships);
            Console.WriteLine($"{findMostGunsWithSize(spaceships, 5).Name} is the biggest we've got!");
           
            foreach (var item in ExplorationFleet(spaceships))
            {
                Console.WriteLine($"{item.Name} is a valued member of the exploration fleet.");
            }
            
        }
        public static int sumOfEarthShips(List<Spaceship> ships)
        {
            var totalEarthShips = ships.Where(w => w.HasWarpDrive==false).Select(s => s.Name).Count();
            return totalEarthShips;
        } 

        public static void sendShipsToFightMonsters(List<Spaceship> ships)
        {
            var FighterShips = ships.Where(w => w.HasWarpDrive).ToList();
            foreach (Spaceship item in FighterShips)
            {
                item.fightSpaceMonster();
            }
        }

        public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size)
        {
            var FighterShips = ships.Where(s => s.Size == size).OrderByDescending(l => l.NumLasers).First();
            return FighterShips;
        }

        public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships)
        {
            var WimpyShips = ships.Where(w => w.HasWarpDrive).OrderBy(s => s.NumLasers).Take(5).ToList();
            return WimpyShips;
        }
    }
}
