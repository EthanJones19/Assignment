using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
   
    
    
    class Game
    {
 
        private Item _goldenGun;
        private Item _rifle;
        private Item _gun;
        private Item _steelChair;
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
            Player player = new Player(100, name, 20, 50, 0, 4);
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
            Item[] inventory = player.EnterInventory();

            char input = ' ';

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name );
            }
        }

        public void TheOldTown(Enemy enemy)
        {

            Console.WriteLine("Player dealt " + _player.Attack(enemy));
            Console.ReadKey();

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


        
        
        public void InitializeItems()
        {
            _goldenGun.name = "GoldenGun";
            _goldenGun.cost = 100;
            _goldenGun.statIncrease = 50;
            _gun.name = "Gun";
            _gun.cost = 20;
            _gun.statIncrease = 25;
            _rifle.name = "Rifle";
            _rifle.cost = 30;
            _rifle.statIncrease = 60;
            _steelChair.name = "SteelChair";
            _steelChair.cost = 70;

        }
        public void Start()
        {
            _gameOver = false;
            _player = new Player();
            _enemy = new Enemy[1];
            _enemy[0] = new Drunky("Drunky", 100, 100, 100);
        }

        public void Update()
        {
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
