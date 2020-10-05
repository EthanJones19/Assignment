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
            Player _player = new Player(name, 100, 20, 100, 10, 4);
            return _player;
        }

        public void ClearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.Write("> ");
            Console.ReadKey();
            Console.Clear();
        }

        public void SwitchWeapons(Player _player)
        {
            Item[] _inventory = _player.InventoryView();

            char input = ' ';
            for (int i = 0; i > _inventory.Length; i++)
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
            /*
            //First fight
            while(_player.PlayerAlive() && _enemy[0].EnemyAlive())
            {
                _player.PlayerStats();
                Console.WriteLine("-----------------------------------------");
                _enemy[0].EnemyStats();
                Console.WriteLine("-----------------------------------------");

                char input;
                GetInput(out input, " Attack", "Switch Weapons", "Save Game", " ");

                if (input == '1')
                {
                    Console.WriteLine("Player dealt " + _player.Attack(enemy));
                    Console.WriteLine("Enemy dealt " + _enemy[0].Attack(_player));
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')
                {
                    SwitchWeapons(_player);
                }
                else
                {
                    Save();
                }

            }
            if (_player.PlayerDead())
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }

            else _player.PrizeMoney();
            {
                Console.WriteLine("You killed him!");
                Console.WriteLine("You gained 50 coins");
            }


            //Second Fight
            while (_player.PlayerAlive() && _enemy[1].EnemyAlive())
            {
                _player.PlayerStats();
                Console.WriteLine("-----------------------------------------");
                _enemy[1].EnemyStats();
                Console.WriteLine("-----------------------------------------");

                char input;
                GetInput(out input, " Attack", "Switch Weapons", "Save Game", " ");

                if (input == '1')
                {
                    Console.WriteLine("Player dealt " + _player.Attack(enemy));
                    Console.WriteLine("Enemy dealt " + _enemy[1].Attack(_player));
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')
                {
                    SwitchWeapons(_player);
                }
                else
                {
                    Save();
                }

            }

            if (_player.PlayerDead())
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }

            else _player.PrizeMoney();
            {
                Console.WriteLine("You gained 50 coins");
            }

            //Third Fight
            while (_player.PlayerAlive() && _enemy[2].EnemyAlive())
            {
                _player.PlayerStats();
                Console.WriteLine("-----------------------------------------");
                _enemy[2].EnemyStats();
                Console.WriteLine("-----------------------------------------");

                char input;
                GetInput(out input, " Attack", "Switch Weapons", "Save Game", " ");

                if (input == '1')
                {
                    Console.WriteLine("Player dealt " + _player.Attack(enemy));
                    Console.WriteLine("Enemy dealt " + _enemy[2].Attack(_player));
                    Console.WriteLine("-----------------------------------------");
                    Console.Clear();
                }
                else if (input == '2')
                {
                    SwitchWeapons(_player);
                }
                else
                {
                    Save();
                }

            }
           */
            if (_player.PlayerDead())
            {
                _gameOver = true;
                Console.WriteLine("Game Over");
            }
            
            //Fourth Fight
            while (_player.PlayerAlive() && _enemy[3].EnemyAlive())
            {
                _player.PlayerStats();
                Console.WriteLine("-----------------------------------------");
                _enemy[3].EnemyStats();
                Console.WriteLine("-----------------------------------------");

                SwitchWeapons(_player);

                if (_player.FasterSpeed())
                {
                    Console.WriteLine("You won");
                    _gameOver = true;
                }
                
                else
                {
                    _enemy[3].EnemySpeed();
                    Console.WriteLine("You lose");
                    _gameOver = true;
                }
               

            }
          

        }

        //public void PlayerIsFaster()
        //{
            //_player.FasterSpeed();
            //Console.WriteLine(" ");
            //_gameOver = true;

        //}




        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _player.Save(writer);
            writer.Close();
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _player.Load(reader);
            reader.Close();
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
        public void OpenMainMenu()
        {
            char input;
            GetInput(out input, "Create new character", "Load Character", "What do you wanna do?");
            if (input == '2')
            {
                _player = new Player();
                Load();
                return;
            }
            _player = CreateCharacter();
        }

       



        public void Start()
        {
            _gameOver = false;
            _enemy = new Enemy[4];
            _player = new Player();
            _enemy[0] = new Drunky("Drunky", 40, 10, 10);
            _enemy[1] = new Bandit("Bandit", 40, 10, 10);
            _enemy[2] = new Chupacabra("Chupacabra", 40, 10, 10);
            _enemy[3] = new BanditLeader("Leader", 40, 0, 70);
        }

        public void Update()
        {
            OpenMainMenu();
            foreach(Enemy enemy in _enemy)
            {
                TheOldTown(enemy);
            }
        }

        public void End()
        {

        }
    }
}
