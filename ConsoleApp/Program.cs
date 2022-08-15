using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;


namespace Program{
    public class MainCLass{
        
        
        public static void Main(){

            //var Pokadex = CurrentParty.ToDictionary(kv => kv.Key, kv => kv.Value);

            

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("would you like too pick a starter pokemon? you have 3 choicse");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {Pokadex["Charmander"]}? (1) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("open your Bag? (2) \n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Flee? (3) \n");
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKey Starter = Console.ReadKey(true).Key;

            if(Starter == ConsoleKey.D1){
                Console.WriteLine($"you choose {Pokadex["Charmander"]}!!");

                CurrentParty.Add("Charmander", Pokadex["Charmander"]);
                //Pokadex.Remove("key");
                


                foreach(var Name in Pokadex){
                    Console.WriteLine(Name.Key + Name.Value.Exp + Name.Value.lvl);
                }

                foreach(var Name in CurrentParty){
                    Console.WriteLine(Name.Key + Name.Value.Exp + Name.Value.lvl);
                }
            }
            
            
            

        }
        
        public static Dictionary<string, (int lvl, int Exp)> Pokadex = new Dictionary<string, (int lvl, int Exp)>{
            { "Charmander", (0, 0)},
            { "Squirtle", (0, 0)},
            { "Bulbasaur", (0, 0)},
            { "Pikachu", (0, 0)}
        };

        //public static Dictionary<string, (int lvl, int Exp)> PlayerPokadex = new Dictionary<string, (int lvl, int Exp)>{};

        public static Dictionary<string, (int lvl, int Exp)> CurrentParty = new Dictionary<string, (int lvl, int Exp)>{};
        
        public static Dictionary<string, (int RestoreAmount, int Amount)> Bag = new Dictionary<string, (int RestoreAmount, int Amount)>{};

        public static Dictionary<string, (int RestoreAmount, int Amount)> Shop = new Dictionary<string, (int RestoreAmount, int Amount)>{};



       /* public static Dictionary<string, (int price, int Amount)>  gints = new Dictionary<string, (int Price, int Amount)>
        {
            {"Attack Points: ", (10, 0)},
            {"Defense Points: ", (10, 0)},
            {"Super Points: ", (10, 0)},
            {"N / A", (10, 0)}
        };
        */
        
    } 

    class Pokemon{
        public string Name;
        public int health;
        public int level;
        public float Exp = 0f;
        ////////////////////////////////////////
        public string Move1_Name;
        public string Move2_Name;
        public string Move3_Name;
        ////////////////////////////////////////
        public int Move1_attack;
        public int Move2_attack;
        public int Move3_attack;

        public static bool PlayerAttack = false;
        public static bool PlayerBag = false;
        public static bool PlayerFlee = false;

        public static void TallGrass(){
            Random Rnd = new Random();
            int FindPokemon = Rnd.Next(1, 5);

            if(FindPokemon == 1){
                //fight_1();
            }
            if(FindPokemon == 2){
                //Fight_2();
            }
            if(FindPokemon == 3){
                //Fight_3();
            }
            if(FindPokemon == 3){
                //Fight_4();
            }
            if(FindPokemon == 3){
                //Fight_5();
            }

        }

        public static void PlayerMove(){
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Would you like too.... press the number to sleact your option \n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("fight? (1) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("open your Bag? (2) \n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Flee? (3) \n");
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKey Move = Console.ReadKey(true).Key;

            if(Move == ConsoleKey.D1){ // for fight
                Console.WriteLine($"you are now fighting with: " /* {pokemons name}*/ );
                PlayerAttack = true;
            }
            if(Move == ConsoleKey.D2){ // for Bag
                Console.WriteLine("");
            }
            if(Move == ConsoleKey.D3){ // for Flee
                Console.WriteLine("");
            }

        }

        public static void SystemMove(){
            if(PlayerFlee == true){
                
            }
        }
    }
}


/* 

lvl system idea #1: at the end of each turn we put a check if the ex went up and if so then check for how much and if its over the amount then incrsce lvl by 1 and add the leftover? somehow? and if its for a pokemin then then if(Pokemon_Name.Exp >= number || == to number) { then do this}

combat turns idea #1: ask the player if they want too do 1 of 3 things and do 3 checks 1 for attacking 2 for bag and 3 for trying to flee. 

flee idea #1: make a new method for fleeing and insitlze a new random and name it flee chance and if its higher then 65 then you flee or if its lower then 65 you have to stay and then the turn moves on too the pokemons turn

bag idea #1: Make a new dict with a thruple with the name, item, amount, discritpion, funition (look up if you can put a funition thruple)

*/