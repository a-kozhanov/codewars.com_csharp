/*
https://www.codewars.com/kata/grasshopper-terminal-game-number-1/train/csharp


8 kyu
Grasshopper - Terminal Game #1

Terminal Game - Create Hero Class
In this first kata in the series, you need to define a Hero class to be used in a terminal game. The hero should have the following attributes:

attribute	type	value
Name	string	user argument or "Hero"
Position	string	"00"
Health	float	100
Damage	float	5
Experience	int	0

*/

namespace CodeWars
{
    public class GrasshopperTerminalGame1
    {
        public class Hero
        {
            public Hero(string name = "Hero", string pos = "00", float health = 100, float damage = 5, int exp = 0)
            {
                Name = name;
                Position = pos;
                Health = health;
                Damage = damage;
                Experience = exp;
            }

            public string Name { get; set; }
            public string Position { get; set; }
            public float Health { get; set; }
            public float Damage { get; set; }
            public int Experience { get; set; }
        }
    }
}

//class Hero
//{
//    public string Name { get; set; }
//    public float Health { get; set; } = 100;
//    public float Damage { get; set; } = 5;
//    public int Experience { get; set; } = 0;
//    public string Position { get; set; } = "00";

//    public Hero(string name = "Hero")
//    {
//        this.Name = name;
//    }
//}


//public class Hero
//{
//    public string Name { get; }
//    public string Position { get; } = "00";
//    public float Health { get; } = 100;
//    public float Damage { get; } = 5;
//    public int Experience { get; } = 0;

//    public Hero(string name = "Hero")
//    {
//        Name = name;
//    }
//}


//public class Hero
//{
//    public string Name { get; }
//    public string Position { get; }
//    public float Health { get; }
//    public float Damage { get; }
//    public int Experience { get; }

//    public Hero(string name = "Hero")
//    {
//        this.Name = name;
//        this.Position = "00";
//        this.Health = 100.0f;
//        this.Damage = 5.0f;
//        this.Experience = 0;
//    }
//}



//public class Hero
//{
//    public string Name { get; set; }
//    public string Position { get; set; } = "00";
//    public float Health { get; set; } = 100;
//    public float Damage { get; set; } = 5;
//    public int Experience { get; set; } = 0;
//    public Hero(string name = "Hero") => Name = name;
//}

