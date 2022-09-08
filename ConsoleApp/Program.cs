using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Program {
    public class MainClass {
        
        static Pokemon Charmander = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Charmander", Idnumber: 004, XpCase: 142, move1_name: "Ember", move2_name: "Scratch", move3_name: "Rush", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Squirtle = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Squirtle", Idnumber: 007, XpCase: 63, move1_name: "Water gun", move2_name: "Rush", move3_name: "scratch", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon blubasaur = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Blubasaur", Idnumber: 001, XpCase: 64, move1_name: "Vine wip", move2_name: "Seed bomb", move3_name: "scratch", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        // Starters ^ 
        // Wilds
        static Pokemon Pigy = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Pigy", Idnumber: 000, XpCase: 50, move1_name: "Wind slash", move2_name: "Tackle", move3_name: "kick", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Eevee = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Eevee", Idnumber: 133, XpCase: 65, move1_name: "tackle", move2_name: "Tail Wip", move3_name: "Bite", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Cterpie = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Capterpie", Idnumber: 010, XpCase: 39, move1_name: "Bug Bite", move2_name: "String Shoot", move3_name: "Nap", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Geodude = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Geodude", Idnumber: 074, XpCase: 60, move1_name: "Rockc Punch", move2_name: "Light Punch", move3_name: "Duboble Kick", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Houndour = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Houndour", Idnumber: 228, XpCase: 66, move1_name: "Dark Flare", move2_name: "Dark Bite", move3_name: "howel", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Torrcat = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Torrcat", Idnumber: 726, XpCase: 147, move1_name: "Fire Fang", move2_name: "Claw Slash", move3_name: "FlameThrower", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        // Wilds ^

        static Pokemon Kyogre = new Pokemon(exp: 0, level: 15,maxhealth: Pokemon.GymPoekmonHealth(),Ohealth: Pokemon.RndHealth, "Kyogre", Idnumber: 382, XpCase: 201, "Aqua Storm", "spring tides", "Ocean Cyclone", 120, 90, 125);
        static Pokemon Swampert = new Pokemon(exp: 0, level: 14,maxhealth: Pokemon.GymPoekmonHealth(),Ohealth: Pokemon.RndHealth, "Swampert", Idnumber: 260, XpCase: 150, "Strongrm Impact", "Hdryo Pump", "Waterfall", 100, 85, 110);
        static Pokemon Inteleon = new Pokemon(exp: 0, level: 12,maxhealth: Pokemon.GymPoekmonHealth(),Ohealth: Pokemon.RndHealth, "Inteleon", Idnumber: 818, XpCase: 120, "Aqua Bullet", "Water Disk", "Surf", 110, 90, 75);

        // Gym one pokemon ^ 



        // Bag
        public static Bag SmllHeal = new Bag(name: "Small Heal", amount: 1, decript: "Heals 20 Health of any 1 pokemon per item");
        public static Bag MedHeal = new Bag(name: "Med Heal", amount: 1, decript: "Heals 40 Health of any 1 pokemon per item");
        public static Bag FullHeal = new Bag(name: "Full Heal", amount: 1, decript: "Heals ALL Health of any 1 pokemon per item");
        public static Bag Revive = new Bag(name: "Reveive", amount: 1, decript: "Brings of 1 any pokemon back from knock out too at least half health");

        //static int o = Pokemon.RndHealth;
        static bool GoodValue = false;
        public static Pokemon.WildParty Wild = new Pokemon.WildParty();
        public static Pokemon.PokemonParty party = new Pokemon.PokemonParty();
        public static void Main() {
            // Console.WriteLine("asking for some input please healppp");
            
            
            
            while (!GoodValue) 
            {
                var Test = Console.ReadKey(true).Key;
                switch (Test) {
                    case ConsoleKey.D1:
                    //GoodValue = false;
                    Console.WriteLine("you hit 1");
                    GoodValue = true;
                    break;

                    default:
                    //GoodValue = true;
                    Console.WriteLine("Please try again");
                    //Test = Console.ReadKey(true).Key;
                    //how can i promt to get input again?
                    continue;
                }
            }
            

            /* 
            
            could i run a while loop over a switch with a bool and if the bool ever is true then to break. 
            4but if the when you press something other then the inputs it would be false? and just repeat till you get a valid input?
            */






            //var Wild = new Pokemon.WildParty();
            var UserBag = new Bag.PokemonBag();
            var party = new Pokemon.PokemonParty();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nwould you like too pick a starter pokemon? you have 3 choicse\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine($"Your first choice is {Charmander.Name} (1)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            Console.WriteLine($"Your second choice is {MainClass.Squirtle.Name} (2)");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine($"Your third choice is {MainClass.blubasaur.Name} (3)");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);
            UserBag.Add(SmllHeal);
            SmllHeal.Amount = 4;
            UserBag.Add(Revive);
            Revive.Amount = 3;

            
            var GoodValue1 = false;
            while (!GoodValue1) 
            {
                var Starter = Console.ReadKey(true).Key;
                switch (Starter) {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1: // charmander
                    party.Add(Charmander);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"you choose {Charmander.Name}\nand is also now in your party");
                    Console.ForegroundColor = ConsoleColor.White;
                    if(Pokemon.PokemonParty.internalList[0].MaxHealth <= 54) {
                        Pokemon.PokemonParty.internalList[0].MaxHealth += 12;
                        Pokemon.PokemonParty.internalList[0].oHealth += 12;
                        Pokemon.PokemonParty.internalList[0].oHealth += 12;
                    }
                    Console.WriteLine($"Your {Charmander.Name} is level {Charmander.Level} and has {Charmander.Exp} Exp.\nThis pokemon also has 3 moves. {Charmander.Move1_Name} and it does {Charmander.Move1_Attack} damage \n{Charmander.Move2_Name} and it does {Charmander.Move2_Attack} damge \n{Charmander.Move3_Name} and it does {Charmander.Move3_Attack} damage");
                    foreach (var item in Pokemon.PokemonParty.internalList) {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //Console.WriteLine(Percent5);
                    GoodValue1 = true;
                    break;

                    case ConsoleKey.D2 or ConsoleKey.NumPad2: // Squirtle
                    party.Add(Squirtle);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"you choose {MainClass.Squirtle.Name}\nand is now in your party");
                    Console.ForegroundColor = ConsoleColor.White;
                    if(Pokemon.PokemonParty.internalList[0].MaxHealth <= 54) {
                        Pokemon.PokemonParty.internalList[0].MaxHealth += 11;
                        Pokemon.PokemonParty.internalList[0].oHealth += 11;
                    }
                    Console.WriteLine($"Your {MainClass.Squirtle.Name} is level {MainClass.Squirtle.Level} and has {MainClass.Squirtle.Exp} Exp. \n This pokemon also has 3 moves. {MainClass.Squirtle.Move1_Name} and it does {MainClass.Squirtle.Move1_Attack} damage \n {MainClass.Squirtle.Move2_Name} and it does {MainClass.Squirtle.Move2_Attack} damge \n {MainClass.Squirtle.Move3_Name} and it does {MainClass.Squirtle.Move3_Attack} damage");
                    foreach (var item in Pokemon.PokemonParty.internalList) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    GoodValue1 = true;
                    break;

                    case ConsoleKey.D3 or ConsoleKey.NumPad3: // blubasaur
                    party.Add(blubasaur);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"you choose {MainClass.blubasaur.Name}\nand is now in your party");
                    Console.ForegroundColor = ConsoleColor.White;
                    if(Pokemon.PokemonParty.internalList[0].MaxHealth <= 54) {
                        Pokemon.PokemonParty.internalList[0].MaxHealth += 11;
                        Pokemon.PokemonParty.internalList[0].oHealth += 11;
                    }
                    Console.WriteLine($"Your {MainClass.blubasaur.Name} is level {MainClass.blubasaur.Level} and has {MainClass.blubasaur.Exp} Exp. \n This pokemon also has 3 moves. {MainClass.blubasaur.Move1_Name} and it does {MainClass.blubasaur.Move1_Attack} damage \n {MainClass.blubasaur.Move2_Name} and it does {MainClass.blubasaur.Move2_Attack} damge \n {MainClass.blubasaur.Move3_Name} and it does {MainClass.blubasaur.Move3_Attack} damage");
                    foreach (var item in Pokemon.PokemonParty.internalList) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    GoodValue1 = true;
                    break;

                    default:
                    Console.WriteLine("Please try again");
                    Starter = Console.ReadKey(true).Key;
                    continue;
                
                }
            }
            

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("in your bag you have: ");
            foreach (var item in UserBag) {
                Thread.Sleep(425);
                Console.WriteLine(item);
            }
            Thread.Sleep(500);
            Console.WriteLine("hit any key to contine");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(150);
            Console.ReadKey(true);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("Now Would you like to go out and look for pokemon too battle and catch? (1)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            Console.WriteLine("Or chanllage the gym leader of the first gym? (2)");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            var Game = Console.ReadKey(true).Key;
            var GoodValue2 = false;
            while (!GoodValue) {
                switch (Game) {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("your now going into the wild too look for pokemon to catch / battle");
                    Console.ForegroundColor = ConsoleColor.White;
                    TallGrass();
                    GoodValue2 = true;
                    break;

                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                    Console.WriteLine("if you want to fight the first gym leader then you need more then 2 poekmon");
                    if (Pokemon.PokemonParty.internalList.Count > 2) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you have more then 2 pokemon so you can fight the first gym leader");
                        Console.ForegroundColor = ConsoleColor.White;
                        GymLeader1();
                        GoodValue2 = true;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("come back when you have more then 2 pokemon so you cam fight the gym leader");
                        Console.ForegroundColor = ConsoleColor.White;
                        TallGrass();
                        GoodValue2 = true;
                    }
                    break;

                    default:
                    Console.WriteLine("Please try again");
                    GoodValue2 = false;
                    Game = Console.ReadKey(true).Key;
                    continue;
                
                }
            }
            
            
            
         
        }



        // FOR REFRENCE TOO USE WHEN MAKING THE SHOP. make a stock witch limited too x amount where x is a random num from 4 - 8
        
        //public static Dictionary<string, (int lvl, int Exp)> PlayerPokadex = new Dictionary<string, (int lvl, int Exp)>{};

        //public static Dictionary<string, MainClass.blubasaur()> CurrentParty = new Dictionary (string, MainClass.blubasaur());
        
        //public static Dictionary<string, (int RestoreAmount, int Amount)> Bag = new Dictionary<string, (int RestoreAmount, int Amount)>();

        //public static Dictionary<string, (int RestoreAmount, int Amount)> Shop = new Dictionary<string, (int RestoreAmount, int Amount)>();

        public static float FleeOrNotToFlee => Random.Shared.Next(0, 101);
        public static float CatchOrNotCatched => Random.Shared.Next(0, 101);
        public static int SystemMove => Random.Shared.Next(1, 6);


        //internal static Pokemon.PokemonParty Party { get => party; set => party = value; }

        //internal static Pokemon Charmander1 { get => Charmander; set => Charmander = value; }

        public static void TallGrass() {
            var pokemonNumber = Pokemon.FindPokemon();
            Pokemon.IsWild = true;
            switch (pokemonNumber) {
                case 1:
                Wild.Add(Pigy);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                
                Pokemon.IsWild = true;
                
                //Console.WriteLine($"Now its {Pigy.Name}'s turn");
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                
                Console.WriteLine("the end");
                break;

                case 2:
                Wild.Add(Cterpie);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                Pokemon.IsWild = true;
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                break;

                case 3:
                Wild.Add(MainClass.Eevee);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                
                Pokemon.IsWild = true;
                
                //Console.WriteLine($"Now its {Pigy.Name}'s turn");
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                break;

                case 4:
                Wild.Add(MainClass.Geodude);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                
                Pokemon.IsWild = true;
                
                //Console.WriteLine($"Now its {Pigy.Name}'s turn");
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                break;

                case 5:
                Wild.Add(MainClass.Torrcat);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                
                Pokemon.IsWild = true;
                
                //Console.WriteLine($"Now its {Pigy.Name}'s turn");
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                break;

                case 6:
                Wild.Add(Houndour);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your now Fighting {Pokemon.WildParty.WildList[0].Name}\nand it has {Pokemon.WildParty.WildList[0].oHealth} health it's level is: {Pokemon.WildParty.WildList[0].Level}");
                Console.ForegroundColor = ConsoleColor.White;
                PlayerMove();
                // int PP = 2;
                // fractem 

                
                Pokemon.IsWild = true;
                
                //Console.WriteLine($"Now its {Pigy.Name}'s turn");
                
                
                if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 && Pokemon.PokemonParty.internalList[1].oHealth <= 0 && Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All of your party members has fanited GAME OVER");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                break;

                case 7:
                
                break;
            
            }
            

        }
        static bool Caught = false;
        public static void PlayerMove() {
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);
            Console.WriteLine("Would you like too.... press the number to sleact your option \n");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine("fight? (1) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("open your Bag? (2) \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            Console.WriteLine($"Catch the {Pokemon.WildParty.WildList[0].Name}? (3) \n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            Console.WriteLine("Flee? (4) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("its your turn now");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);
            
            var PlayerMove = Console.ReadKey(true).Key;
            var GoodValue3 = false; // 1 : 47 make trues and nots for Playermove
            while (!GoodValue3) {
                switch (PlayerMove) {
                    
                
                    case ConsoleKey.D1 or ConsoleKey.NumPad1: // to fight the pokemon
                        
                    Console.WriteLine(Pokemon.PokemonParty.internalList[0].Name);
                    Console.WriteLine($"you have 3 moves for {Pokemon.PokemonParty.internalList[0]}\n move 1: {Pokemon.PokemonParty.internalList[0].Move1_Name}\nmove 1: does {Pokemon.PokemonParty.internalList[0].Move1_Attack} damage\nmove 2: {Pokemon.PokemonParty.internalList[0].Move2_Name} and move 2 does {Pokemon.PokemonParty.internalList[0].Move2_Attack} damage\nmove 3: {Pokemon.PokemonParty.internalList[0].Move3_Name} and move 3 does {Pokemon.PokemonParty.internalList[0].Move3_Attack} damage \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(500);
                    Console.WriteLine("as a note you can only use each move 2 or 3 times so use them wisly \nso witch move would you like to use? (1) (2) (3) but the pp is a work in progress so use any move as much as you want");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);

                    var AttackTurn = Console.ReadKey(true).Key;
                    switch (AttackTurn) {
                        case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        Pokemon.WildParty.WildList[0].oHealth -= Pokemon.PokemonParty.internalList[0].Move1_Attack;
                        Console.WriteLine($"You used {Pokemon.PokemonParty.internalList[0].Move1_Name} and did {Pokemon.PokemonParty.internalList[0].Move1_Attack} damage\n the {Pokemon.WildParty.WildList[0].Name} is now at {Pokemon.WildParty.WildList[0].oHealth} health");
                        if (Pokemon.WildParty.WildList[0].oHealth <= 0 || Pokemon.WildParty.WildList[0].oHealth < 0) {
                            Console.WriteLine($"you knocked out {Pokemon.WildParty.WildList[0].Name} and won! and you got :");
                            Pokemon.WildParty.WildList[0].oHealth = 0;
                            Pokemon.WildParty.WildList[0].oHealth += Pokemon.WildParty.WildList[0].MaxHealth;
                            Pokemon.XpLvlCal();
                            something();
                            break;
                        }
                        PokemonMove();
                        GoodValue3 = true;
                        break;

                        case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        Pokemon.WildParty.WildList[0].oHealth -= Pokemon.PokemonParty.internalList[0].Move2_Attack;
                        Console.WriteLine($"You used {Pokemon.PokemonParty.internalList[0].Move1_Name} and did {Pokemon.PokemonParty.internalList[0].Move2_Attack} damage\n the {Pokemon.WildParty.WildList[0].Name} is now at {Pokemon.WildParty.WildList[0].oHealth} health");
                        if (Pokemon.WildParty.WildList[0].oHealth <= 0 || Pokemon.WildParty.WildList[0].oHealth < 0) {
                            Console.WriteLine($"you knocked out {Pokemon.WildParty.WildList[0].Name} and won! and you got :");
                            Pokemon.WildParty.WildList[0].oHealth = 0;
                            Pokemon.WildParty.WildList[0].oHealth += Pokemon.WildParty.WildList[0].MaxHealth;
                            Pokemon.XpLvlCal();
                            something();
                            break;
                        }
                        PokemonMove();
                        break;

                        case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        Pokemon.WildParty.WildList[0].oHealth -= Pokemon.PokemonParty.internalList[0].Move3_Attack;
                        Console.WriteLine($"You used {Pokemon.PokemonParty.internalList[0].Move1_Name} and did {Pokemon.PokemonParty.internalList[0].Move3_Attack} damges\n the {Pokemon.WildParty.WildList[0].Name} is now at {Pokemon.WildParty.WildList[0].oHealth} health");
                        if (Pokemon.WildParty.WildList[0].oHealth <= 0 || Pokemon.WildParty.WildList[0].oHealth < 0) {
                            Console.WriteLine($"you knocked out {Pokemon.WildParty.WildList[0].Name} and won! and you got :");
                            Pokemon.WildParty.WildList[0].oHealth = 0;
                            Pokemon.WildParty.WildList[0].oHealth += Pokemon.WildParty.WildList[0].MaxHealth;
                            Pokemon.XpLvlCal();
                            something();
                            break;
                        }
                        
                        PokemonMove();
                        break;
                    }

                    // if (Pokemon.WildParty.WildList[0].oHealth <= 0 || Pokemon.WildParty.WildList[0].oHealth < 0) {
                    //     Console.WriteLine($"you knocked out {Pokemon.WildParty.WildList[0].Name} and won! and you got :");
                    //     Pokemon.XpLvlCal();
                    //     break;
                    // }

                    
                    GoodValue3 = true;
                    break; // for end of fighting case

                    case ConsoleKey.D2 or ConsoleKey.NumPad2: // bag
                    Console.WriteLine($"what do you want to do in your bag? you have ");
                    foreach (var item in Bag.PokemonBag.Pokebag) {
                        Console.WriteLine(item);
                        Thread.Sleep(250);
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("would you like to use a item on your pokemon too heal them? (1)");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(500);
                    Console.WriteLine("or do nothing (2)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);
                    var PlayerBag = Console.ReadKey(true).Key;
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (PlayerBag) {
                        case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        foreach (var item in Pokemon.PokemonParty.internalList) {
                            Console.WriteLine(item);
                            Thread.Sleep(250);
                        }
                        if (Pokemon.PokemonParty.internalList[0].oHealth > Pokemon.PokemonParty.internalList[0].MaxHealth){
                            Console.WriteLine("Work in progress please come back later");
                            // Console.ForegroundColor = ConsoleColor.Green;
                            // Console.WriteLine($"what would you like to use on your {Pokemon.PokemonParty.internalList[0]}? you have: (1) {Bag.PokemonBag.Pokebag[0]} (2) {Bag.PokemonBag.Pokebag[1]} or (3) {Bag.PokemonBag.Pokebag[2]}");
                            // Console.ForegroundColor = ConsoleColor.Red;
                            // Console.WriteLine($"")
                            // Console.ForegroundColor = ConsoleColor.Red;
                            // Console.WriteLine($"");
                            // Console.ForegroundColor = ConsoleColor.Red;
                            // Console.WriteLine($"");
                            // Console.ForegroundColor = ConsoleColor.White;
                            var Heal = Console.ReadKey(true).Key;
                            switch (Heal)
                            {
                                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                                Console.WriteLine("work in porgress please come back later");
                                Pokemon.PokemonParty.internalList[0].oHealth += 20;
                                Bag.PokemonBag.Pokebag[0].Amount --;
                                Console.WriteLine($"you now have {Bag.PokemonBag.Pokebag[0].Amount}");
                                break;
                            }
                        }
                        break;
                        case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        Console.WriteLine("you did nothing");
                        break;
                        
                    }
                    //PokemonMove();
                    GoodValue3 = true;
                    break; // end of BAG case.

                    case ConsoleKey.D3 or ConsoleKey.NumPad3: // catch poekmon
                    Console.WriteLine($"there are {Pokemon.PokemonParty.internalList.Count} in your party as of right now");
                    if (Pokemon.PokemonParty.internalList.Count == 6 && CatchOrNotCatched <= 50f) {
                        Console.WriteLine("you alr have 6 pokemon in your party so you canr cant get anymore");
                        //Caught = false;
                    }
                    // if (Pokemon.WildParty.WildList[0].oHealth < )
                    // {
                        
                    // }
                    if (Pokemon.PokemonParty.internalList.Count < 6 && CatchOrNotCatched >= 50f) {
                        party.Add(Pokemon.WildParty.WildList[0]);
                        Wild.Remove(Pokemon.WildParty.WildList[0]);
                        Console.WriteLine($"You Catched the {Pokemon.WildParty.WildList[0].Name}!! {Pokemon.WildParty.WildList[0].Name} is now in your party");
                        Console.WriteLine("Your party has now: ");
                        Caught = true;
                        foreach (var item in Pokemon.PokemonParty.internalList)
                        {
                            Console.WriteLine(item);
                            Thread.Sleep(250);
                        }
                        Pokemon.XpLvlCal();
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Would you like to go back into some tall grass and look for pokemon to battle (1)");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("or go challeng the first gym leader (2)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("end the program (3)");
                        Console.ForegroundColor = ConsoleColor.White;

                        var Faild = Console.ReadKey(true).Key;
                        var GoodValue4 = false;
                        while (!GoodValue4) {
                            switch (Faild) {
                                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                                Console.WriteLine("your now going BACK into some tall grass to look for pokmon to battle");
                                TallGrass();
                                GoodValue4 = true;
                                break;

                                case ConsoleKey.D2 or ConsoleKey.NumPad2:
                                GymLeader1();
                                GoodValue4 = true;
                                break;
                                
                                case ConsoleKey.D3 or ConsoleKey.NumPad3:
                                Console.Clear();
                                Environment.Exit(1);
                                GoodValue4 = true;
                                break;

                                default:
                                Console.WriteLine("Please pick again");
                                Faild = Console.ReadKey(true).Key;
                                continue;                         
                            }
                        }
                    }
                    
                    GoodValue3 = true;
                    break; // end of catch case

                    case ConsoleKey.D4 or ConsoleKey.NumPad4: // flee
                    if (FleeOrNotToFlee < 50f) {
                        Console.WriteLine("you got away!");
                        Pokemon.XpLvlCal();
                        
                    }
                    else if (FleeOrNotToFlee > 50f) {
                        Console.WriteLine("you didin't get away");
                        PokemonMove();
                    }
                    break;
                }
            } 
        }

        //public static int Percent5 = Pokemon.WildParty.WildList[0].oHealth / 50 * 100;
        
        public static void PokemonMove() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"its now {Pokemon.WildParty.WildList[0].Name} turn");
            Console.ForegroundColor = ConsoleColor.White;
            switch (SystemMove) {
                case 1: // move 1
                Console.WriteLine($"{Pokemon.WildParty.WildList[0].Name} uses {Pokemon.WildParty.WildList[0].Move1_Name} and it does {Pokemon.WildParty.WildList[0].Move1_Attack} Damage to your {Pokemon.PokemonParty.internalList[0].Name}");
                Pokemon.PokemonParty.internalList[0].oHealth -= Pokemon.WildParty.WildList[0].Move1_Attack;
                Console.WriteLine($"your {Pokemon.PokemonParty.internalList[0]} has {Pokemon.PokemonParty.internalList[0].oHealth} out of {Pokemon.PokemonParty.internalList[0]}");
                PlayerMove();
                break;

                case 2: // move 2 
                Console.WriteLine($"{Pokemon.WildParty.WildList[0].Name} uses {Pokemon.WildParty.WildList[0].Move2_Name} and it does {Pokemon.WildParty.WildList[0].Move2_Attack} Damage to your {Pokemon.PokemonParty.internalList[0].Name}");
                Pokemon.PokemonParty.internalList[0].oHealth -= Pigy.Move2_Attack;
                Console.WriteLine($"your {Pokemon.PokemonParty.internalList[0]} has {Pokemon.PokemonParty.internalList[0].oHealth} out of {Pokemon.PokemonParty.internalList[0]}");
                PlayerMove();
                break;
                
                case 3: // move 3
                Console.WriteLine($"{Pokemon.WildParty.WildList[0].Name} uses {Pokemon.WildParty.WildList[0].Move3_Name} and it does {Pokemon.WildParty.WildList[0].Move3_Attack} Damage to your {Pokemon.PokemonParty.internalList[0].Name}");
                Pokemon.PokemonParty.internalList[0].oHealth -= Pokemon.WildParty.WildList[0].Move3_Attack;
                Console.WriteLine($"your {Pokemon.PokemonParty.internalList[0]} has {Pokemon.PokemonParty.internalList[0].oHealth} out of {Pokemon.PokemonParty.internalList[0]}");
                PlayerMove();
                break;

                case 4: // do nothing
                Console.WriteLine($"{Pokemon.WildParty.WildList[0]} did nothing. its your turn now");
                PlayerMove();
                break;
            }
            
            if (Pokemon.PokemonParty.internalList[0].oHealth <= 0 ) {
                Console.WriteLine("one of your party members has fanited GAME OVER");
                Environment.Exit(1);
            }
        }
        public static void GymLeader1() {
            Pokemon.WildParty.WildList.Add(Kyogre);
            Pokemon.WildParty.WildList.Add(Swampert);
            Pokemon.WildParty.WildList.Add(Inteleon);
            Pokemon.WildParty.WildList.Add(Kyogre);
            Console.WriteLine($"there are {Pokemon.WildParty.WildList.Count}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"You are now battleing the water gym leader has 3 pokemon 1: {Pokemon.WildParty.WildList[0].Name} and is lvl {Pokemon.WildParty.WildList[0].Level} and has {Pokemon.WildParty.WildList[0].oHealth} health");
            Thread.Sleep(420);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You are now battleing the water gym leader has 3 pokemon 2: {Pokemon.WildParty.WildList[1].Name} and is lvl {Pokemon.WildParty.WildList[1].Level} and has {Pokemon.WildParty.WildList[1].oHealth} health");
            Thread.Sleep(420);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"You are now battleing the water gym leader has 3 pokemon 3: {Pokemon.WildParty.WildList[2].Name} and is lvl {Pokemon.WildParty.WildList[2].Level} and has {Pokemon.WildParty.WildList[2].oHealth} health");
            Console.ForegroundColor = ConsoleColor.White;
            // into ^
            // 
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.WriteLine("Would you like too.... press the number to sleact your option \n");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("fight? (1) \n");
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("open your Bag? (2) \n");
            // Console.ForegroundColor = ConsoleColor.Blue;
            // Console.WriteLine("Flee? (4) \n");
            // Console.ForegroundColor = ConsoleColor.Green;
            
            //Console.WriteLine("its your turn now");
            // Console.ForegroundColor = ConsoleColor.White;

            // turn combat start ^

            while (Pokemon.PokemonParty.internalList[0].oHealth <= 0 || Pokemon.WildParty.WildList[1].oHealth < 0 || Pokemon.PokemonParty.internalList[2].oHealth <= 0|| Pokemon.WildParty.WildList[0].oHealth <= 0 || Pokemon.WildParty.WildList[1].oHealth <= 0 || Pokemon.WildParty.WildList[2].oHealth <= 0) {
                
                PlayerMove();
                PokemonMove();
            }
            

            




            // combat
        } 
        public static void something() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Would you like to go back into some tall grass and look for pokemon to battle (1)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("or go challeng the first gym leader (2)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("end the program (3)");
            Console.ForegroundColor = ConsoleColor.White;

            var feild = Console.ReadKey(true).Key;
            switch (feild) {
                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                Console.WriteLine("your now going BACK into some tall grass to look for pokmon to battle");
                TallGrass();
                break;

                case ConsoleKey.D2 or ConsoleKey.NumPad2:
                GymLeader1();
                break;
                
                case ConsoleKey.D3 or ConsoleKey.NumPad3:
                Console.Clear();
                Environment.Exit(1);
                break;                           
            }
        }
    }


    

    public class Pokemon {
        public int MaxHealth { get; set; } = Random.Shared.Next(39, 69);
        public int oHealth { get; set; }
        public double Exp { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Pokemon(float exp, int level, int maxhealth, int Ohealth, string name, int Idnumber, int XpCase, string move1_name,string move2_name, string move3_name, int move1_attack, int move2_attack, int move3_attack) {
            this.MaxHealth = maxhealth;
            this.oHealth = Ohealth;
            this.Exp = exp;
            this.Level = level;
            this.Name = name;
            this.IDNumber = Idnumber;
            this.EXpCase = XpCase;

            this.Move1_Name = move1_name;
            this.Move2_Name = move2_name;
            this.Move3_Name = move3_name;

            this.Move1_Attack = move1_attack;
            this.Move2_Attack = move2_attack;
            this.Move3_Attack = move3_attack;

            oHealth = MaxHealth;
            Ohealth = maxhealth;

            PokemonParty.internalList.Capacity = 6;
            
        }

        
        
        ////////////////////////////////////////
        public string Move1_Name { get; }
        public string Move2_Name { get; }
        public string Move3_Name { get; }
        ////////////////////////////////////////
        public int Move1_Attack { get; set; }
        public int Move2_Attack { get; }
        public int Move3_Attack { get; }
        public int IDNumber { get; }
        public int EXpCase { get; set; }
        public static bool PlayerAttack = false;
        public static bool PlayerBag = false;
        public static bool PlayerFlee = false;

        //public static int FindPokemon = 1;
        public static int FindPokemon() => Random.Shared.Next(1, 8);
        public static int WildPoekmonHealth() => Random.Shared.Next(39, 69);
        public static int GymPoekmonHealth() => Random.Shared.Next(110, 230);
        public static int RndHealth =  Random.Shared.Next(39, 69);
        public static int RndAttack() => Random.Shared.Next(13, 41);

       
        

        public static bool IsPokemonInParty(IReadOnlyList<Pokemon> party, Pokemon pokemon) {
            foreach(var partyMember in party) {
                if (partyMember == pokemon)
                return true;
            }

            return false;
        }

        public override string ToString() {
            return "Party: " + Name + ": Health: " + MaxHealth + " / " + oHealth + " Lvl: " + Level;
        }

        public static void XpLvlCal() {

            double A = 0; 
            double E = 1;
            double F = 2;
            double L = 0;
            double L2 = Pokemon.PokemonParty.internalList[0].Level; 
            double P = 0;
            double V = 1;
            double XP;
            double val0;
            double val1;


            val0 = Pokemon.PokemonParty.internalList[0].EXpCase + 0;
            val1 = 7 * Pokemon.PokemonParty.internalList.Count;

            XP = E + A + 1.6 + P + F + V * 2.1;

            switch (IsWild) {
                case true:
                A = 1;
                break;

                case false:
                A = 1.5;
                break;;
            }
            switch (PlayerWon) {
                case true:
                P = Pokemon.PokemonParty.internalList[0].Level;
                break;

                case false:
                P = 1.2;
                break;
            }
 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"All of your non fainted pokemon got {XP}");


            if (Pokemon.PokemonParty.internalList.Count == 1 && Pokemon.PokemonParty.internalList[0].oHealth > 0 ) {
                Pokemon.PokemonParty.internalList[0].Exp += XP;
            }
            if (Pokemon.PokemonParty.internalList.Count == 2 && Pokemon.PokemonParty.internalList[0].oHealth > 0 && Pokemon.PokemonParty.internalList[1].oHealth > 0) {
                Pokemon.PokemonParty.internalList[0].Exp += XP;
                Pokemon.PokemonParty.internalList[1].Exp += XP;
            }
            if (Pokemon.PokemonParty.internalList.Count == 3 && Pokemon.PokemonParty.internalList[0].oHealth > 0 && Pokemon.PokemonParty.internalList[1].oHealth > 0 && Pokemon.PokemonParty.internalList[2].oHealth > 0) {
                Pokemon.PokemonParty.internalList[0].Exp += XP;
                Pokemon.PokemonParty.internalList[1].Exp += XP;
                Pokemon.PokemonParty.internalList[2].Exp += XP;
            }
            if (Pokemon.PokemonParty.internalList.Count == 4 && Pokemon.PokemonParty.internalList[0].oHealth > 0 && Pokemon.PokemonParty.internalList[1].oHealth > 0 && Pokemon.PokemonParty.internalList[2].oHealth > 0 && Pokemon.PokemonParty.internalList[3].oHealth > 0) {
                Pokemon.PokemonParty.internalList[0].Exp += XP;
                Pokemon.PokemonParty.internalList[1].Exp += XP;
                Pokemon.PokemonParty.internalList[2].Exp += XP;
                Pokemon.PokemonParty.internalList[3].Exp += XP;
            }
            
            
            

            // Xp Cal ^
            // Lvl Cal

            Pokemon.PokemonParty.internalList[0].Exp = XP;
            //double Xp = 0;

            double Min1 = 5;
            double Max1 = 10;
            
            
            if (PokemonParty.internalList[0].Exp > Min1 && PokemonParty.internalList[0].Exp < Max1) {
                PokemonParty.internalList[0].Level ++;
                Min1 *= 2.1 - 3;
                Max1 *= 2.6;
            }
            // if (PokemonParty.internalList[1].Exp > Min1 && PokemonParty.internalList[1].Exp < Max1) {
            //     PokemonParty.internalList[1].Level ++;
            //     Min1 *= 2.1 - 6;
            //     Max1 *= 2.6;

            // }
            // if (PokemonParty.internalList[2].Exp > Min1 && PokemonParty.internalList[2].Exp < Max1) {
            //     PokemonParty.internalList[2].Level ++;
            //     Min1 *= 2.1 - 8;
            //     Max1 *= 2.6;
            // }
            // if (PokemonParty.internalList[3].Exp > Min1 && PokemonParty.internalList[3].Exp < Max1) {
            //     PokemonParty.internalList[3].Level ++;
            //     Min1 *= 2.1 - 10;
            //     Max1 *= 2.6;
            // }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"your {Pokemon.PokemonParty.internalList[0].Name} is now  leavl {Pokemon.PokemonParty.internalList[0].Level}");
            // Console.WriteLine($"your {Pokemon.PokemonParty.internalList[1].Name} is now {Pokemon.PokemonParty.internalList[1].Level}");
            // Console.WriteLine($"your {Pokemon.PokemonParty.internalList[2].Name} is now {Pokemon.PokemonParty.internalList[2].Level}");
            // Console.WriteLine($"your {Pokemon.PokemonParty.internalList[3].Name} is now {Pokemon.PokemonParty.internalList[3].Level}");

            
            /*

            >	Greater than	x > y	
            <	Less than	    x < y
            
            */
            
            
            
            // if (Pokemon.PokemonParty.internalList[0].Exp > 0) {

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static bool IsWild;
        public static bool PlayerWon;

        

         

        public class PokemonParty : IReadOnlyList<Pokemon> {
            
            public static List<Pokemon> internalList = new List<Pokemon>();

            Pokemon IReadOnlyList<Pokemon>.this[int index] => internalList[index];

            public int Count => internalList.Count;

            public IEnumerator GetEnumerator() {
                return internalList.GetEnumerator();
            }

            IEnumerator<Pokemon> IEnumerable<Pokemon>.GetEnumerator() {
                return internalList.GetEnumerator();
            }

            public void Add(Pokemon pokemon) {
                internalList.Add(pokemon);
            }

            public void Remove(Pokemon pokemon) {
                internalList.Remove(pokemon);
            }
        }

        public class WildParty : IReadOnlyList<Pokemon> {
            
            public static List<Pokemon> WildList = new List<Pokemon>();

            Pokemon IReadOnlyList<Pokemon>.this[int index] => WildList[index];

            public int Count => WildList.Count;

            public IEnumerator GetEnumerator() {
                return WildList.GetEnumerator();
            }

            IEnumerator<Pokemon> IEnumerable<Pokemon>.GetEnumerator() {
                return WildList.GetEnumerator();
            }

            public void Add(Pokemon pokemon) {
                WildList.Add(pokemon);
            }

            public void Remove(Pokemon pokemon) {
                WildList.Remove(pokemon);
            }
        }
    }

        public class Bag {

            public string Name { get; set; }
            public int Amount { get; set; }
            public string Decript { get; set; }
            public static int amount { get; set; } 
            
            public Bag(string name, int amount, string decript) {
                this.Name = name;
                this.Amount = amount;
                this.Decript = decript;
            }

            public static bool IsInBag(IReadOnlyList<Bag> bag, Bag Item) {
                foreach(var partyMember in bag) {
                    if (partyMember == Item)
                    return true;
                }

                return false;
            }

            public override string ToString() {
                return Name + ": " + "descritpton " + Decript + ". Amount is : " + Amount + " each";
            }

        public class PokemonBag : IReadOnlyList<Bag>
        {
            private static List<Bag> pokebag = new List<Bag>();

            public Bag this[int index] => throw new NotImplementedException();

            Bag IReadOnlyList<Bag>.this[int index] => pokebag[index];

            internal static List<Bag> Pokebag { get => pokebag; set => pokebag = value; }

            public int Count => throw new NotImplementedException();

            public IEnumerator<Bag> GetEnumerator()
            {
                return Pokebag.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return Pokebag.GetEnumerator();
            }
            public void Add(Bag Item) {
                Pokebag.Add(Item);
            }

            public void Remove(Bag Item) {
                Pokebag.Remove(Item);
            }
        }
    }       
}