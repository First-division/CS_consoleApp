using System;
using System.Collections.Generic;
using System.Collections;

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
        static Pokemon Geodude = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Geodude", Idnumber: 074, XpCase: 60, move1_name: "Rockc Punch", move2_name: "Light Punch", move3_name: "", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Houndour = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Houndour", Idnumber: 228, XpCase: 66, move1_name: "Dark Flare", move2_name: "Dark Bite", move3_name: "howel", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        static Pokemon Torrcat = new Pokemon(exp: 0, level: 1, maxhealth: Pokemon.WildPoekmonHealth(), Ohealth: Pokemon.RndHealth, name: "Torrcat", Idnumber: 726, XpCase: 147, move1_name: "Fire Fang", move2_name: "Claw Slash", move3_name: "FlameThrower", move1_attack: Pokemon.RndAttack(), move2_attack: Pokemon.RndAttack(), move3_attack: Pokemon.RndAttack());
        // Wilds ^
        // Bag
        public static Bag SmllHeal = new Bag(name: "Small Heal", amount: 1, decript: "Heals 20 Health of any 1 pokemon per item");
        public static Bag MedHeal = new Bag(name: "Med Heal", amount: 1, decript: "Heals 40 Health of any 1 pokemon per item");
        public static Bag FullHeal = new Bag(name: "Full Heal", amount: 1, decript: "Heals ALL Health of any 1 pokemon per item");
        public static Bag Revive = new Bag(name: "Reveive", amount: 1, decript: "Brings of 1 any pokemon back from knock out too at least half health");

        //static int o = Pokemon.RndHealth;

        private static Pokemon.PokemonParty party = new Pokemon.PokemonParty();

        public static void Main() {
            
            //var pokemons = Enumerable.Repeat<Func<Pokemon>>(() => new Pokemon()
            // Console.WriteLine();
            // Console.WriteLine(Charmander);            
            // Console.WriteLine(Squirtle);
            // Console.WriteLine(blubasaur);
            // Console.WriteLine();
            // Console.WriteLine(Torrcat);
            // Console.WriteLine(Cterpie);
            // Console.WriteLine(Eevee);
            // Console.WriteLine(Pigy);
            // Console.WriteLine(Geodude);
            // Console.WriteLine(Houndour);
            
            
            //var isInParty = Pokemon.IsPokemonInParty(party, Charmander);     // TRUE
            //Pokemon.IsPokemonInParty(party, Charmander);
            
            //party.Remove(Charmander);
            //party.Add(Squirtle);
            //Pokemon.IsPokemonInParty(party, Squirtle);
            // foreach (var item in Pokemon.PokemonParty.internalList) {
            //     Console.WriteLine(item);
            // }

            //Console.WriteLine(isInParty);
            //Console.WriteLine(party);
            



        

            var UserBag = new Bag.PokemonBag();
            var party = new Pokemon.PokemonParty();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nwould you like too pick a starter pokemon? you have 3 choicse\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your first choice is {Charmander.Name} (1)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Your second choice is {MainClass.Squirtle.Name} (2)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your third choice is {MainClass.blubasaur.Name} (3)");
            Console.ForegroundColor = ConsoleColor.White;
            UserBag.Add(SmllHeal);
            SmllHeal.Amount = 4;
            UserBag.Add(Revive);
            Revive.Amount = 3;
            //Console.WriteLine($"you now have {Bag.PokemonBag.Pokebag[0].Amount} of {Bag.PokemonBag.Pokebag[0].Name}");
            
            var Starter = Console.ReadKey(true).Key;

            switch (Starter) {
                case ConsoleKey.D1 or ConsoleKey.NumPad1: // charmander
                party.Add(Charmander);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"you choose {Charmander.Name}\nand is also now in your party");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Your {Charmander.Name} is level {Charmander.Level} and has {Charmander.Exp} Exp.\nThis pokemon also has 3 moves. {Charmander.Move1_Name} and it does {Charmander.Move1_Attack} damage \n{Charmander.Move2_Name} and it does {Charmander.Move2_Attack} damge \n{Charmander.Move3_Name} and it does {Charmander.Move3_Attack} damage");
                foreach (var item in Pokemon.PokemonParty.internalList) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                break;

                case ConsoleKey.D2 or ConsoleKey.NumPad2: // Squirtle
                party.Add(Squirtle);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"you choose {MainClass.Squirtle.Name}\nand is now in your party");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Your {MainClass.Squirtle.Name} is level {MainClass.Squirtle.Level} and has {MainClass.Squirtle.Exp} Exp. \n This pokemon also has 3 moves. {MainClass.Squirtle.Move1_Name} and it does {MainClass.Squirtle.Move1_Attack} damage \n {MainClass.Squirtle.Move2_Name} and it does {MainClass.Squirtle.Move2_Attack} damge \n {MainClass.Squirtle.Move3_Name} and it does {MainClass.Squirtle.Move3_Attack} damage");
                foreach (var item in Pokemon.PokemonParty.internalList) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                break;

                case ConsoleKey.D3 or ConsoleKey.NumPad3: // blubasaur
                party.Add(blubasaur);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"you choose {MainClass.blubasaur.Name}\nand is now in your party");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Your {MainClass.blubasaur.Name} is level {MainClass.blubasaur.Level} and has {MainClass.blubasaur.Exp} Exp. \n This pokemon also has 3 moves. {MainClass.blubasaur.Move1_Name} and it does {MainClass.blubasaur.Move1_Attack} damage \n {MainClass.blubasaur.Move2_Name} and it does {MainClass.blubasaur.Move2_Attack} damge \n {MainClass.blubasaur.Move3_Name} and it does {MainClass.blubasaur.Move3_Attack} damage");
                foreach (var item in Pokemon.PokemonParty.internalList) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                break;
                
            }

            Console.WriteLine("in your bag you have: ");
            foreach (var item in UserBag) {
                Console.WriteLine(item);
            }
            Console.WriteLine("hit any key to contine");
            Thread.Sleep(150);
            Console.ReadKey(true);

            Console.WriteLine("Now Would you like to go out and look for pokemon too battle and catch? (1)\nor chanllage the gym leader of the first gym? (2)");
            var Game = Console.ReadKey(true).Key;

            switch (Game) {
                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                Console.WriteLine("your now going into some tall grass too look for pokemon to catch");
                TallGrass();
                break;

                case ConsoleKey.D2 or ConsoleKey.NumPad2:
                Console.WriteLine("if you want to fight the first gym leader then you need more then 2 poekmon");
                if (Pokemon.PokemonParty.internalList.Count > 2) {
                    Console.WriteLine("you have more then 2 pokemon so you can fight the first gym leader");
                    GymLeader1();
                }
                else {
                    Console.WriteLine("come back when you have more then 2 pokemon so you cam fight the gym leader");
                    TallGrass();
                }
                break;
                
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
            bool Caught;
            Pokemon.IsWild = true;
            switch (pokemonNumber) {
                case 1:
                Console.WriteLine($"Your now Fighting {MainClass.Pigy.Name}\nand it's level is: {MainClass.Pigy.Level}");

                while (Caught = true || MainClass.Pigy.oHealth <= 0 || Pokemon.PokemonParty.internalList[0].oHealth <= 0 || Pokemon.PokemonParty.internalList[1].oHealth <= 0 || Pokemon.PokemonParty.internalList[2].oHealth <= 0) {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like too.... press the number to sleact your option \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("fight? (1) \n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("open your Bag? (2) \n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Catch the {MainClass.Pigy.Name}? (3) \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Flee? (4) \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    var PMove = Console.ReadKey(true).Key;
                    int PP = 2;
                    //fractem 

                    switch (PMove) {
                        case ConsoleKey.D1 or ConsoleKey.NumPad1: // to fight the pokemon
                        
                        Console.WriteLine(Pokemon.PokemonParty.internalList[0].Name);
                        Console.WriteLine($"you have 3 moves for {Pokemon.PokemonParty.internalList[0]} move 1: {Pokemon.PokemonParty.internalList[0].Move1_Name}\nmove 1: does {Pokemon.PokemonParty.internalList[0].Move1_Attack} damage\nmove 2: {Pokemon.PokemonParty.internalList[0].Move2_Name} and move 2 does {Pokemon.PokemonParty.internalList[0].Move2_Attack} damage\nmove 3: {Pokemon.PokemonParty.internalList[0].Move3_Name} and move 3 does {Pokemon.PokemonParty.internalList[0].Move3_Attack} damage \n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("as a note you can only use each move 2 or 3 times so use them wisly \nso witch move would you like to use? (1) (2) (3)");
                        
                        var Attack = Console.ReadKey(true).Key;

                        switch (Attack) {
                            case ConsoleKey.D1 or ConsoleKey.NumPad1:
                            Pigy.oHealth -= Pokemon.PokemonParty.internalList[0].Move1_Attack;
                            Console.WriteLine($"You used {Pokemon.PokemonParty.internalList[0].Move1_Name} and did {Pokemon.PokemonParty.internalList[0].Move1_Attack}\n the {Pigy.Name} is now at {Pigy.oHealth}");
                            break;
                        }

                        Console.WriteLine($"Now its {Pigy.Name}'s turn");
                        switch (SystemMove) {
                            case 1:
                            //move 1
                            break;

                            case 2:
                            // move 2
                            break;
                            
                            case 3:
                            // move 3
                            break;

                            case 4:
                            // do nothing
                            break;
                        }

                        Pokemon.XPcal();
                        break;

                        case ConsoleKey.D2 or ConsoleKey.NumPad2: // bag
                        
                        
                        Console.WriteLine($"what do you want to do in your bag? you have ");
                        foreach (var item in Bag.PokemonBag.Pokebag) {
                            Console.WriteLine(item);
                            Thread.Sleep(250);
                        }
                        Console.WriteLine("would you like to use a item on your pokemon too heal them? (1) or do nothing (2)");
                        var PlayerBag = Console.ReadKey(true).Key;
                        switch (PlayerBag) {
                            case ConsoleKey.D1 or ConsoleKey.NumPad1:
                            foreach (var item in Pokemon.PokemonParty.internalList) {
                                Console.WriteLine(item);
                                Thread.Sleep(250);
                            }
                            if (Pokemon.PokemonParty.internalList[0].oHealth > Pokemon.PokemonParty.internalList[0].MaxHealth){
                                Console.WriteLine($"what would you like to use on your {Pokemon.PokemonParty.internalList[0]}? you have: (1) {Bag.PokemonBag.Pokebag[1]} or (2) {Bag.PokemonBag.Pokebag[1]} or (3) {Bag.PokemonBag.Pokebag[2]}");
                                var Heal = Console.ReadKey(true).Key;
                                switch (Heal)
                                {
                                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                                    Console.WriteLine("");
                                    Pokemon.PokemonParty.internalList[0].oHealth += 20;
                                    Bag.PokemonBag.Pokebag[0].Amount --;
                                    Console.WriteLine($"you now have {Bag.PokemonBag.Pokebag[0].Amount}");
                                    break;
                                }
                            }
                            break;
                            
                        }
                        break;

                        case ConsoleKey.D3 or ConsoleKey.NumPad3: // catch poekmon
                        Console.WriteLine($"there are {Pokemon.PokemonParty.internalList.Count} in your party as of right now");
                        if (Pokemon.PokemonParty.internalList.Count == 6 && CatchOrNotCatched <= 50f) {
                            Console.WriteLine("you alr have 6 pokemon in your party so you canr cant get anymore");
                        }
                        if (Pokemon.PokemonParty.internalList.Count < 6 && CatchOrNotCatched >= 50f) {
                            Console.WriteLine($"You Catched the {MainClass.Pigy.Name}!! {MainClass.Pigy.Name} is now in your party");
                            party.Add(Pigy);
                            foreach (var item in Pokemon.PokemonParty.internalList)
                            {
                                Console.WriteLine(item);
                                Thread.Sleep(250);
                            }
                            Pokemon.XPcal();
                            
                            Console.WriteLine("Would you like to go back into some tall grass and look for pokmon to battle?");

                        }
                        break;

                        case ConsoleKey.D4 or ConsoleKey.NumPad4: // flee
                        if (FleeOrNotToFlee < 50f) {
                            Console.WriteLine("you got away!");
                            Console.WriteLine(FleeOrNotToFlee);
                        }
                        else if (FleeOrNotToFlee > 50f) {
                            Console.WriteLine("you didin't get away");
                            Console.WriteLine(FleeOrNotToFlee);
                        }

                        break;
                
                
                    }
                    Pokemon.IsWild = false;
                    break;
                }

                //Pokemon.PlayerMove();
                break;

                case 2:
                Console.WriteLine($"Your now Fighting {MainClass.Cterpie.Name} \n and it level {MainClass.Cterpie.Level}");

                //Pokemon.PlayerMove();
                break;

                case 3:
                Console.WriteLine($"Your now Fighting {MainClass.Houndour.Name} \n and it level {MainClass.Houndour.Level}");

                //Pokemon.PlayerMove();
                break;

                case 4:
                Console.WriteLine($"Your now Fighting {MainClass.Geodude.Name} \n and it level {MainClass.Geodude.Level}");

                //Pokemon.PlayerMove();
                break;

                case 5:
                Console.WriteLine($"Your now Fighting {MainClass.Torrcat.Name} \n and it level {MainClass.Torrcat.Level}");

                //Pokemon.PlayerMove();
                break;
            
            }
            

        }
        public static void GymLeader1() {

        } 
    }


    

    class Pokemon {
        public int MaxHealth { get; set; } = Random.Shared.Next(39, 69);
        public int oHealth { get; set; }

        public double Exp { get; set; }
        public int Level { get; }
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
            
        }

        
        
        ////////////////////////////////////////
        public string Move1_Name { get; }
        public string Move2_Name { get; }
        public string Move3_Name { get; }
        ////////////////////////////////////////
        public int Move1_Attack { get; }
        public int Move2_Attack { get; }
        public int Move3_Attack { get; }
        public int IDNumber { get; }
        public int EXpCase { get; set; }
        public static bool PlayerAttack = false;
        public static bool PlayerBag = false;
        public static bool PlayerFlee = false;

        public static int FindPokemon() => Random.Shared.Next(1, 1);
        public static int WildPoekmonHealth() => Random.Shared.Next(39, 69);
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

        public static void XPcal() {

            var A = 0;
            var B = Pokemon.PokemonParty.internalList[0].EXpCase;
            var E = 1;
            var F = (int)1.2;
            var L = 0;
            var L2 = Pokemon.PokemonParty.internalList[0].Level;
            var S = Pokemon.PokemonParty.internalList.Count;
            var P = 0;
            var V = 1;
            var T = (int)1.5;
            var XP = 0;

            var val0 = 0;
            var val1 = 0;


            val0 = B * L;
            val1 = 7 * S;

            XP = val0 / val1 * E * A * T * P * F * V;

            if (IsWild == true) {
                A = 1;
            }
            if(IsWild == false) {
                A = (int)1.5;
            }

            if(PlayerWon == true) {
                P = Pokemon.PokemonParty.internalList[0].Level;
            }

            if (PlayerWon == false) {
                P = (int)1.2;
            }
 
           
            Console.WriteLine(XP);

            Pokemon.PokemonParty.internalList[0].Exp += XP;
            Pokemon.PokemonParty.internalList[1].Exp += XP;
            Pokemon.PokemonParty.internalList[2].Exp += XP;
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
    }

        public class Bag {

            public string Name { get; set;}
            public int Amount { get; set; }
            public string Decript { get; set; }
            public static int amount { get; set;} 
            
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
                return Name + ": " + "descritptoon " + Decript + ". Amount is : " + Amount + " each";
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
        // TODO: Implement the IReadOnlyList interface to let other classes read from your internal list. VS can auto-do this for you. 
        // Why not implement IList directly? You may want to constrain the way pokemon are added to the party in a way that is not expected for a regular list interface. 

        /*Do you see those angle brackets? < and > ? Those are indicating generic type arguments.
        But Generics are a whole big branch and you don't have to start with that just now.
        This lets you have a list of pokemon
        And is a way that you can reference the type of other classes.
        You could do it differently, since there's only up to 6 pokemon in a party.
        */


/* 

lvl system idea #1: at the end of each turn we put a check if the ex went up and if so then check for how much and if its over the amount then incrsce lvl by 1 and add the leftover? somehow? and if its for a pokemin then then if(Pokemon_Name.Exp >= number || == to number) { then do this}

combat turns idea #1: ask the player if they want too do 1 of 3 things and do 3 checks 1 for attacking 2 for bag and 3 for trying to flee. 

flee idea #1: make a new method for fleeing and insitlze a new random and name it flee chance and if its higher then 65 then you flee or if its lower then 65 you have to stay and then the turn moves on too the pokemons turn

bag idea #1: Make a new dict with a thruple with the name, item, amount, discritpion, funition (look up if you can put a funition thruple)

*/