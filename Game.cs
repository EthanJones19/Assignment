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


        //Run the from Start to End
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        
        //Creates a character for player
        public Player CreateCharacter()
        {
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            Player _player = new Player(name, 100, 10, 100, 10, 4);
            return _player;
        }

        //Input to clearscreen for player
        public void ClearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.Write("> ");
            Console.ReadKey();
            Console.Clear();
        }

        //If the player switches weapons
        public void SwitchWeapons(Player _player)
        {
            Item[] _inventory = _player.InventoryView();

            char input = ' ';
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + _inventory[i].name + _inventory[i].statIncrease);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        _player.EquipItem(0);
                        Console.WriteLine("You equipped " + _inventory[0].name);
                        Console.WriteLine(_inventory[0].statIncrease);
                        break;
                    }
                case '2':
                    {
                        _player.EquipItem(1);
                        Console.WriteLine("You equipped " + _inventory[1].name);
                        Console.WriteLine(_inventory[1].statIncrease);
                        break;
                    }
                case '3':
                    {
                        _player.EquipItem(2);
                        Console.WriteLine("You equipped " + _inventory[2].name);
                        Console.WriteLine(_inventory[2].statIncrease);
                        break;
                    }
                default:
                    {
                        _player.EquipItem(3);
                        Console.WriteLine("You equipped " + _inventory[3].name);
                        Console.WriteLine(_inventory[3].statIncrease);
                        break;
                    }
                
            }
        }


        //Gives player inputs
        public void GetInput(out char input, string option1, string option2,string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1[" + option1);
            Console.WriteLine("2[" + option2);
            Console.WriteLine("3[" + option3);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }



        //Starting of the game
        public void TheOldTown()
        {
            Console.WriteLine("A nice little town in the west. Nothing goes bad in this town right execpt one thing.");
            Console.WriteLine();
            Console.WriteLine("You live in this town. " + "Pretty sure you expected to live in a small nice house, uhhh NO!");
            Console.WriteLine("You're a hobo and your life sucks. " + "Don't worry that will be change soon.");
            Console.WriteLine();
            Console.WriteLine("People heard that strange bandits will arrive here." + "The townspeople are scared right now.");
            Console.WriteLine("You could help out, but townspeople treated you like garbage. " + "You refuse to help if they arrive.");
            Console.WriteLine();
            Console.WriteLine("People only respect you if you do something for them.");
            Console.WriteLine("What's the point doing something for them if people don't do it back");
            Console.WriteLine("You sit there behind the saloon. " + "Doing nothing with your life.");
            Console.WriteLine();
            Console.WriteLine("You're bored, so you decided to go look through stuff in the barrels");
            Console.WriteLine("You manage to find some coins in a barrel." + "You decide to buy a drink inside the saloon.");
            ClearScreen();//Clears screen

            Console.WriteLine("While in the saloon. A drunk came up to you and started pushing you around.");
            Console.WriteLine("The amount of rage inside you from the townspeople.");
            Console.WriteLine("You decide to let the rage explode and fight the drunk");
            ClearScreen();//Clears screen

            //First fight
            while (_player.PlayerAlive() && _enemy[0].EnemyAlive()) //If player and enemy is alive
            {
                _player.PlayerStats();//prints stats for player
                Console.WriteLine("-----------------------------------------");
                _enemy[0].EnemyStats();//prints stats for enemy
                Console.WriteLine("-----------------------------------------");

                char input;//Player inputs
                GetInput(out input, "Attack", "Switch Weapons", "Save Game", " ");//Inputs for player during battle

                if (input == '1')//First input
                {
                    Console.WriteLine("Player dealt " + _player.Attack(_enemy[0]));//Player attacks
                    Console.WriteLine("Enemy dealt " + _enemy[0].Attack(_player));//Enemy attacks
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')//Second input
                {
                    SwitchWeapons(_player);//Player switches weapons
                }
                else//Third input
                {
                    Save();//Player saves game
                }

            }
            if (_player.PlayerDead())//If player is dead
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }

            else _player.PrizeMoney();//Player gains money when alive
            {
                Console.WriteLine("You killed him!");
                Console.WriteLine("You gained 100 coins");
            }

            ClearScreen();//Clears screen

            Console.WriteLine("You felt good after that fight. The Bartender doesn't want anymore attention from what happened.");
            Console.WriteLine("You decide to buy something quickly." + "You do get a free healing beer to along with your purchase");
            Console.WriteLine("Note: The beer will fully restore your hp after battle.");
            ClearScreen();//Clears screen

            ShopMenu();//Player enters shop
            ClearScreen();//Clears screen

            Console.WriteLine("Bandits have arrived.");
            Console.WriteLine("You don't care what happens to the town. " +
                "The group of bandits wouldn't leave you alone." + "Annoyed, you decide to challenge the strongest bandit to scare them off.");
            ClearScreen();//Clears screen

            _player.SpecialHealingBeer();//Heals player's health

            //Second Fight
            while (_player.PlayerAlive() && _enemy[1].EnemyAlive())//If player and enemy is alive
            {
                _player.PlayerStats();//prints stats for player
                Console.WriteLine("-----------------------------------------");
                _enemy[1].EnemyStats();//prints stats for enemy
                Console.WriteLine("-----------------------------------------");

                char input;//Player inputs
                GetInput(out input, "Attack", "Switch Weapons", "Save Game", " ");//Inputs for player during battle

                if (input == '1')//First input
                {
                    Console.WriteLine("Player dealt " + _player.Attack(_enemy[1]));//First attacks
                    Console.WriteLine("Enemy dealt " + _enemy[1].Attack(_player));//Enemy attacks
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')//Second input
                {
                    SwitchWeapons(_player);//Player switches weapons
                    Console.Clear();
                }
                else//Third input
                {
                    Save();//Player saves game
                }

            }

            if (_player.PlayerDead())//If player is dead
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }

            else _player.PrizeMoney();//Player gains money when alive
            {
                Console.WriteLine("You killed him!");
                Console.WriteLine("You gained 100 coins");
            }

            ClearScreen();//Clears screen

            Console.WriteLine("Bandits fear and walked back. You talked to the bandits, asking where their leader is.");
            Console.WriteLine("You got directions ,but the bandits asked why.");
            Console.WriteLine("You want to talk to him." + "Bandits told you can ,but you have to get pass his pet.");
            Console.WriteLine("You don't really care along as you get to be alone." + "You decided to buy something first before going.");
            ClearScreen();//Clears screen

            ShopMenu();//Player enters shop
            ClearScreen();//Clears screen

            _player.SpecialHealingBeer();//Heals player's health

            //Third Fight
            while (_player.PlayerAlive() && _enemy[2].EnemyAlive())//If player and enemy is alive
            {
                _player.PlayerStats();//prints stats for player
                Console.WriteLine("-----------------------------------------");
                _enemy[2].EnemyStats();//prints stats for enemy
                Console.WriteLine("-----------------------------------------");

                char input;//Player inputs
                GetInput(out input, "Attack", "Switch Weapons", "Save Game", " ");//Inputs for player during battle

                if (input == '1')//First input
                {
                    Console.WriteLine("Player dealt " + _player.Attack(_enemy[2]));//First attacks
                    Console.WriteLine("Enemy dealt " + _enemy[2].Attack(_player));//Enemy attacks
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')//Second input
                {
                    SwitchWeapons(_player);//Player switches weapons
                    Console.Clear();
                }
                else//Third input
                {
                    Save();//Player saves game
                }

            }
           
            if (_player.PlayerDead())//If player is dead
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }

            else _player.PrizeMoney();//Player gains money when alive
            {
                Console.WriteLine("You killed him!");
                Console.WriteLine("You gained 100 coins");
            }

            ClearScreen();//Clears screen

            Console.WriteLine("The end is near...");
            Console.WriteLine("You challenge the leader to a stand off." + "He gladly accepts your challenge.");
            Console.WriteLine("This will be your last time going to saloon. Buy what you need.");
            ClearScreen();//Clears screen

            ShopMenu();//Player enters shop
            ClearScreen();//Clears screen

            Console.WriteLine("During this fight, choose your weapons wisely.");
            Console.WriteLine("This fight depends on speed than damage.");
            ClearScreen();//Clears screen

            _player.SpecialHealingBeer();//Heals player's health

            //Fourth Fight
            while (!_gameOver && _enemy[3].EnemyAlive())//If player and enemy is alive
            {
                _player.PlayerStats();//prints stats for player
                Console.WriteLine("-----------------------------------------");
                _enemy[3].EnemyStats();//prints stats for enemy
                Console.WriteLine("-----------------------------------------");

                SwitchWeapons(_player);//Player switches weapons

                if (_player.PlayerSpeed() >= _enemy[3].EnemySpeed())//If player is faster
                {
                    ClearScreen();//Clears screen
                    Console.WriteLine("You won!");
                    Console.WriteLine("Before the leader dies, he wants you to be leader of the gang and honors your victory.");
                    Console.WriteLine("You decided to take his place as leader and roam the world.");
                    Console.WriteLine("GameOver");
                    _gameOver = true;
                }
                
                else//If enemy is faster
                {
                    ClearScreen();//Clears screen
                    _enemy[3].EnemySpeed();
                    Console.WriteLine("You lose");
                    Console.WriteLine("gameOver");
                    _gameOver = true;
                }

            }
            

        }
        
       
        
        private void ShopMenu()//Shops Menu
        {
            Item[] shopInventory = _shop.GetShopInventory();//Shop's inventory
            int itemIndex = -1;
            char input;
            while (true)//While player in shop
            {


                Console.WriteLine("Welcome stranger! What can I getcha?");
                Console.WriteLine("Make sure to leave after purchasing one item. I don't want trouble in my place!");
                _player.PlayerStats();

                ShowInventory(shopInventory);//Shows shop inventory


                input = Console.ReadKey().KeyChar;
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
                        //Item action switch
                }

                if (_player.GetMoney() < shopInventory[itemIndex].cost)//if player is low on money
                {
                    Console.WriteLine("You don't have enough.");
                }

                else break;
            }
            Console.WriteLine("Replace slot.");
            ShowInventory(_player.InventoryView());//Shows player inventory
            input = Console.ReadKey().KeyChar;
            int _playerIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        _playerIndex = 0;
                        break;
                    }

                case '2':
                    {
                        _playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        _playerIndex = 2;
                        break;
                    }
                case '4':
                    {
                        _playerIndex = 3;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }//Player action switch
            _player.Buy(shopInventory[itemIndex], _playerIndex);//If player buys item
           
        }

        public void ShowInventory(Item[] inventory)//Shows inventory
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + inventory[i].name + inventory[i].cost);
            }
        }
        


        public void Save()//Saves the game
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _player.Save(writer);
            writer.Close();
        }

        public void Load()//Loads the game
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _player.Load(reader);
            reader.Close();
        }
        
        

        public void GetInput(out char input, string option1, string option2, string query)//If player gives input
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
        public void OpenMainMenu()//Creates main menu
        {
            char input;
            GetInput(out input, "Create new character", "Load Character", "What do you wanna do?");
            if (input == '2')
            {
                _player = new Player();
                Load();
                return;
            }
            _player = CreateCharacter();//If player created character
        }

       



        public void Start()//Starts game
        {
            _gameOver = false;
            _enemy = new Enemy[4];
            _player = new Player();//Player creates new player
            _enemy[0] = new Drunky("Drunky", 40, 10, 10);//Drunky stats
            _enemy[1] = new Bandit("Bandit", 60, 20, 10);//Bandit stats
            _enemy[2] = new Chupacabra("Chupacabra", 80, 30, 10);//Chupacabra stats
            _enemy[3] = new BanditLeader("Leader", 1337, 0, 70);//BanditLeader stats
        }

        public void Update()//Updates the game
        {
            OpenMainMenu();
            TheOldTown();
        }

        public void End()//Ends game
        {
            Console.WriteLine("Thank You for playing!");
        }
    }
}
