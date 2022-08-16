using System;
using System.Collections.Generic;
using System.Collections;

namespace Program{
    public class MainClass{
        
        static Pokemon Charmander = new Pokemon(exp: 0, level: 1, health: 69, name: "Charmander");
        static Pokemon Squirtle = new Pokemon(exp: 0, level: 1, health: 65,name: "Squirtle", move1_name: "Water gun", move2_name: "Rush", move3_name: "scratch", move1_attack: 19, move2_attack: 17, move3_attack: 14);
        
        
        

        
        
        
        public static void Main(){
            
            
            
            

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("would you like too pick a starter pokemon? you have 3 choicse");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Your first choise is {MainClass.Charmander.Name}  (1) \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  (2) \n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" (3) \n");
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKey Starter = Console.ReadKey(true).Key;

           

            if(Starter == ConsoleKey.D1){
                Console.WriteLine("you choose !!");

                
                
                
                
                
            }
         
        }

        

        //public static Dictionary<string, (int lvl, int Exp)> PlayerPokadex = new Dictionary<string, (int lvl, int Exp)>{};

        //public static Dictionary<string, (int lvl, int Exp)> CurrentParty = new Dictionary<string, (int lvl, int Exp)>();
        
        //public static Dictionary<string, (int RestoreAmount, int Amount)> Bag = new Dictionary<string, (int RestoreAmount, int Amount)>();

        //public static Dictionary<string, (int RestoreAmount, int Amount)> Shop = new Dictionary<string, (int RestoreAmount, int Amount)>();

        
    } 

    class Pokemon{


        public int Health { get; set; }
        public float Exp { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Pokemon(float exp, int level, int health, string name, string move1_name,string move2_name, string move3_name, int move1_attack, int move2_attack, int move3_attack)
        {
            this.Health = health;
            this.Exp = exp;
            this.Level = level;
            this.Name = name;

            this.Move1_Name = move1_name;
            this.Move2_Name = move2_name;
            this.Move3_Name = move3_name;

            this.Move1_Attack = move1_attack;
            this.Move2_Attack = move2_attack;
            this.Move3_Attack = move3_attack;
            
        }

        public Pokemon(){
            
        }
        
        ////////////////////////////////////////
        public string Move1_Name { get; set; }
        public string Move2_Name { get; set; }
        public string Move3_Name { get; set; }
        ////////////////////////////////////////
        public int Move1_Attack { get; set; }
        public int Move2_Attack { get; set; }
        public int Move3_Attack { get; set; }

        public static bool PlayerAttack = false;
        public static bool PlayerBag = false;
        public static bool PlayerFlee = false;

        public void TallGrass(){
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

        private List<Pokemon> internalList = new List<Pokemon>();
        public class PokemonParty : IReadOnlyList<Pokemon>{
            
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
    
    

          
}


/* 

lvl system idea #1: at the end of each turn we put a check if the ex went up and if so then check for how much and if its over the amount then incrsce lvl by 1 and add the leftover? somehow? and if its for a pokemin then then if(Pokemon_Name.Exp >= number || == to number) { then do this}

combat turns idea #1: ask the player if they want too do 1 of 3 things and do 3 checks 1 for attacking 2 for bag and 3 for trying to flee. 

flee idea #1: make a new method for fleeing and insitlze a new random and name it flee chance and if its higher then 65 then you flee or if its lower then 65 you have to stay and then the turn moves on too the pokemons turn

bag idea #1: Make a new dict with a thruple with the name, item, amount, discritpion, funition (look up if you can put a funition thruple)

*/