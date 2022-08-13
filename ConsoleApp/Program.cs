using System;
using System.Collections.Generic;
using System.Threading;


namespace Program{
    class MainCLass{
        public static void Main(){

            Pokemon Charmander = new Pokemon();
            Charmander.Name = "Charmander";
            Charmander.level = 1;
            

        }

        
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

        public static void Rome(){
            Random Rnd = new Random();
            int FindPokemon = Rnd.Next(1, 5);

            if(FindPokemon == 1){
                fight_1();
            }
            if(FindPokemon == 2){
                Fight_2();
            }
            if(FindPokemon == 3){
                Fight_3();
            }
            if(FindPokemon == 3){
                Fight_4();
            }
            if(FindPokemon == 3){
                Fight_5();
            }

        }

        public static void Move(){
            

            

            //Console.WriteLine("would you like too attack?");
        }
    }
}


/* 

lvl system idea #1: at the end of each turn we put a check if the ex went up and if so then check for how much and if its over the amount then incrsce lvl by 1 and add the leftover? somehow? and if its for a pokemin then then if(Pokemon_Name.Exp >= number || == to number) { then do this}

combat turns idea #1: ask the player if they want too do 1 of 3 things and do 3 checks 1 for attacking 2 for bag and 3 for trying to flee. 

flee idea #1: make a new method for fleeing and insitlze a new random and name it flee chance and if its higher then 65 then you flee or if its lower then 65 you have to stay and then the turn moves on too the pokemons turn

bag idea #1: Make a new dict with a thruple with the name, item, amount, discritpion, funition (look up if you can put a funition thruple)

*/