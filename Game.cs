﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    struct Item
    {
        public string name;
        public int statIncrease;
    }
    
    
    class Game
    {
        private Item _stick;
        private Item _dustyClothes;
        private Item _club;
        private Item _jar;
        private Item _brokenbeerBottle;
        private Item _oldGun;
        private Item _rifle;
        private Item _chair;
        private Item _thing;
        private Item _knife;
        private Item _brokenGlass;
        private Item _goldenGun;
        private Item _errorCode1337;






        //public virtual void Save(StreamerWriter writer)
        //{
        //StreamWriter writer = new StreamWriter(SaveData.txt);
        //_player.Save(writer);
        //writer.Close();
        //}

        //public void load()
        //{
            //StreamReader reader = new StreamReader("SaveData.txt");
            //Player.Load(reader);
            //reader.Close();
        //}

        //public virtual bool Load(StreamReader reader)
        //{
            //Create variables to loaded data
            //string name = reader.ReadLine();
            //float damage = 0;
            //float health = 0;
            
            //Checks to see if loading was successful
            //if (float.TryParse(reader.ReadLine(), out health) == false);
            //{
                //return false;
            //}
            //if (float.TryParse(reader.ReadLine(), out damage) == false);
            //{

            //}
            //If successful, set update the member variables and return true.
            //return true;
            //_name = name;
            //_damage = damage;
            //_health = health;
            
        //}
        
        public void Run()
        {
           
        }
        public void InitializeItems()
        {

        }
        public void Start()
        {

        }

        public void Update()
        {

        }

        public void End()
        {

        }
    }
}
