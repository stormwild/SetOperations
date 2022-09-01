// See https://aka.ms/new-console-template for more information
using SetOperations.Console.SolarSystem;

Console.WriteLine("Hello, World!");

Planet[] firstFivePlanetsFromTheSun =
{
    Planet.Mercury,
    Planet.Venus,
    Planet.Earth,
    Planet.Mars,
    Planet.Jupiter
};

Planet[] lastFivePlanetsFromTheSun =
{
    Planet.Mars,
    Planet.Jupiter,
    Planet.Saturn,
    Planet.Uranus,
    Planet.Neptune
};

foreach (Planet planet in
    firstFivePlanetsFromTheSun.UnionBy(
        lastFivePlanetsFromTheSun, planet => planet.OrderFromSun).GroupBy(planet => planet.OrderFromSun).SelectMany(g => g))
{
    Console.WriteLine(planet);
}

// This code produces the following output:
//     Planet { Name = Mercury, Type = Rock, OrderFromSun = 1 }
//     Planet { Name = Venus, Type = Rock, OrderFromSun = 2 }
//     Planet { Name = Earth, Type = Rock, OrderFromSun = 3 }
//     Planet { Name = Mars, Type = Rock, OrderFromSun = 4 }
//     Planet { Name = Jupiter, Type = Gas, OrderFromSun = 5 }
//     Planet { Name = Saturn, Type = Gas, OrderFromSun = 6 }
//     Planet { Name = Uranus, Type = Liquid, OrderFromSun = 7 }
//     Planet { Name = Neptune, Type = Liquid, OrderFromSun = 8 }