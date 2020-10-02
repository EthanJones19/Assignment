using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
   
    
    
    class Game
    {
 
        
        private Shop _shop = new Shop();
        private Player _player;
        private bool _gameOver;
        private Enemy[] _enemy;



        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        public Player CreateCharacter()
        {
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            Player player = new Player(name, 100, 20, 50, 10, 4);
            return player;
        }

        public void ClearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.Write("> ");
            Console.ReadKey();
            Console.Clear();
        }

        public void SwitchWeapons(Player player)
        {
            Item[] inventory = player.InventoryView();
        }


        
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }



        public void TheOldTown(Enemy enemy)
        {
            //Starting of the game
            Console.WriteLine("A nice little town in the west. Nothing goes bad in this town right execpt one thing.");
            Console.WriteLine();
            Console.WriteLine("You live in this town. " + "Pretty sure you expected to live in a small nice house, uhhh NO!");
            Console.WriteLine("You're a hobo and your life sucks. " + "Don't worry that will be change soon.");
            Console.WriteLine();
            Console.WriteLine("People heard that strange bandits will arrive here." + "The towns people are scared right now.");
            Console.WriteLine("You could help out, but townspeople treated you like garbage. " + "You refuse to help if they arrive.");
            Console.WriteLine();
            Console.WriteLine("People only respect you if you do something for them.");
            Console.WriteLine("What's the point doing something for them if people don't do it back");
            Console.WriteLine("You sit there behind the saloon. " + "Doing nothing with your life.");
            Console.WriteLine();
            Console.WriteLine("You're bored, so you decided to go look through stuff in the barrels");
            Console.WriteLine("You manage to find some coins in a barrel." + "You decide to buy a drink inside the saloon.");
            ClearScreen();

            Console.WriteLine("While in the saloon. A drunk came up to you and started pushing you around.");
            Console.WriteLine("The amount of rage inside you from the townspeople.");
            Console.WriteLine("You decide to let the rage explode and fight the drunk");
            ClearScreen();

            while (_player.PlayerAlive() && _enemy[0].EnemyAlive())
            {
                _player.PlayerStats();
                Console.WriteLine("-----------------------------------------");
                _enemy[0].EnemyStats();
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine("Player dealt " + _player.Attack(enemy));
                Console.WriteLine("Enemy dealt " + _enemy[0].Attack(_player));
                Console.WriteLine("-----------------------------------------");

                if (_player.PlayerAlive())
                {
                    Console.WriteLine("Player gain: " + _player.AddPrizeMoney(enemy));

                }
                else
                {
                    _gameOver = true;
                }
                ClearScreen();

            }
        }

        private void ShopMenu()
        {
            Console.WriteLine("Welcome stranger! What can I getcha?");
            ShowInventory(_shop.GetInventory());

            char input = Console.ReadKey().KeyChar;

            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }
                case '4':
                    {
                        itemIndex = 3;
                        break;
                    }

                default:
                    {
                        return;
                    }


            }

            if (_player.ReturnMoney() < _shop.GetInventory()[itemIndex].cost)
            {
                Console.WriteLine("You need more money to buy this item, chief.");
                return;
            }

            Console.WriteLine("Replace slot.");
            ShowInventory(_player.EnterInventory());
            input = Console.ReadKey().KeyChar;


            
        }

        public void Save()
        {
            //Create a new stream writer.
            StreamWriter writer = new StreamWriter("SaveData.txt");
            //Call save for both instances for player.
            _player.Save(writer);
            //Close writer.
            writer.Close();
        }

        public void Load()
        {
            //Create a new stream reader.
            StreamReader reader = new StreamReader("SaveData.txt");
            //Call load for each instance of player to load data.
            _player.Load(reader);
            //Close reader
            reader.Close();
        }

        



        public void ShowInventory(Item[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + "- " + inventory[i].name + inventory[i].cost);
            }
        }


        
        
        
        
        
        
        
        
        public void Start()
        {
            _gameOver = false;
            _player = new Player();
            _enemy = new Enemy[1];
            _enemy[0] = new Drunky("Drunky", 40, 50, 10, 40);
        }

        public void Update()
        {
            CreateCharacter();
            foreach(Enemy enemy in _enemy)
            {
                TheOldTown(enemy);
            }
            ShopMenu();
        }

        public void End()
        {

        }
    }
}
