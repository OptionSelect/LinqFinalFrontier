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
            Console.WriteLine($"{sumOfEarthShips(spaceships)} spaceships are staying home protecting Mother Earth!");
            sendShipsToFightMonsters(spaceships);
        }
        public static int sumOfEarthShips(List<Spaceship> ships)
        {
            var totalEarthShips = ships.Where(w => w.HasWarpDrive==false).Select(s => s.Name).Count();
            return totalEarthShips;
        } 

        public static void sendShipsToFightMonsters(List<Spaceship> ships)
        {
            var totalFighterShips = ships.Where(w => w.HasWarpDrive).Select(s => s.Name).Count();
            Console.WriteLine($"Sending {totalFighterShips} ships to fight!");
        }

        public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size)
        {
            return null;
        }

        public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships)
        {
            return null;
        }
    }
}
