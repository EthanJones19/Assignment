|Ethan Jones|
|:---|
|s208062|
|Documentation|
|October 8, 2020|

## I. Requirements

1. Description of Problem:
    - **Name**:HoboWesternAdventures

    - **Problem Statement**: Clear the requirements on assignment using C#

    - **Problem Specifications**: The program must be PvP, Shop, or text RPG game.

2. Input Information:
    - Using the numbers on the keyboard for number choices
    - Using the letters on the keyboard for creating a name.

3. Output Information:
    - The program displays the name and options when use.

##II. Design

1. Main Menu:


|![User Interface Gif](https://i.imgur.com/FzHe0hJ.png)

2. Battle/Player Inventory:

|![User Interface Gif](https://i.imgur.com/EoCnZKv.png)

3. Shop Menu:

|![User Interface Gif](https://i.imgur.com/PLt4GpS.png)

4. Object Information:

**File**: Bandit.cs

**Attributes**:
- inherited from Enemy
_______________________________________________

- Name: Bandit(string nameVal, float healthVal, float damageVal, float speedVal) :
            base(healthVal,nameVal,damageVal,speedVal)

- Description: Sets bandit stats to base value. Constructor

- Type: public
_______________________________________________

- Name: Attack()

- Description: Bandit is able to inflict damage

- Type: public override float
_______________________________________________

**File**: BanditLeader.cs
_______________________________________________

**Attributes**:
- inherited from Enemy
_______________________________________________

- Name: BanditLeader(string nameVal, float healthVal, float damageVal, float speedVal) :
            base(healthVal,nameVal,damageVal,speedVal)

- Description: Sets banditleader stats to base value. Constructor

- Type: public
_______________________________________________

- Name: Attack()

- Description: BanditLeader is able to inflict damage

- Type: public override float
_______________________________________________

**File**: Chupacabra.cs

**Attributes**:
- inherited from Enemy
_______________________________________________

- Name: Chupacabra(string nameVal, float healthVal, float damageVal, float speedVal) :
            base(healthVal,nameVal,damageVal,speedVal)

- Description: Sets chupacabra stats to base value. Constructor

- Type: public
_______________________________________________

- Name: Attack()

- Description: Chupacabra is able to inflict damage

- Type: public override float
_______________________________________________

**File**: Drunky.cs

**Attributes**:
- inherited from Enemy

- Name: Drunky(string nameVal, float healthVal, float damageVal, float speedVal) :
            base(healthVal,nameVal,damageVal,speedVal)

- Description: Sets drunky stats to base value. Constructor

- Type: public
_______________________________________________

- Name: Attack()

- Description: Drunky is able to inflict damage

- Type: public override float
_______________________________________________

**File**: Enemy.cs

**Attributes**:

- Name: _enemyHealth

- Description: Sets enemy health value

- Type: protected float
_______________________________________________

- Name: _enemyName

- Description: Sets enemy name value

- Type: protected string
_______________________________________________

- Name: _enemyDamage

- Description: Sets enemy damage value

- Type: protected float
_______________________________________________

- Name: _enemySpeed

- Description: Sets enemy speed value

- Type: protected float
_______________________________________________

- Name: Enemy()

- Description: Sets enemy's stat values

- Type: public
_______________________________________________

- Name: Enemy(float healthVal, string nameVal, float damageVal, float speedVal)

- Description: Sets enemy stats to base value.
Constructor

- Type: public
_______________________________________________

- Name:EnemyStats()

- Description: Displays enemy's stats

- Type: public void
_______________________________________________

- Name: TakenDamage()

- Description: Enemy can take damage

- Type: public virtual float
_______________________________________________

- Name: Attack()

- Description: Enemy is able to inflict damage

- Type: public virtual float
_______________________________________________

- Name: EnemySpeed()

- Description: Returns enemy speed

- Type: public float
_______________________________________________

- Name: EnemyAlive()

- Description: If enemy health is greater than 0

- Type: public bool
_______________________________________________

**File**:Item.cs

**Attributes**:

- Name: name

- Description: Sets item's name value

- Type: public string
_______________________________________________

- Name: statIncrease

- Description: Set to increase stat value

- Type: public int
_______________________________________________

- Name: cost

- Description: Sets item cost value

- Type: public int
_______________________________________________

- Name: Item(string tempName,int tempStatIncrease,int tempCost)

- Description: Sets item stats to base value.
Constructor

- Type: public
_______________________________________________

**File**: Shop.cs

**Attributes**:

- Name: Item[] inventory = new Item[]

- Description: Sets shop inventory with new item

- Type: public
_______________________________________________

- Name: Item _item1 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item2 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item3 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item4 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: Shop()

- Description: Sets items in inventory

- Type: public
_______________________________________________


- Name: Item[] GetShopInventory()

- Description: Gets shop's inventory

- Type:public
_______________________________________________

**File**: Player.cs

**Attributes**:

- Name: _playerHealth

- Description: Sets player health value

- Type: protected float
_______________________________________________

- Name: _playerName

- Description: Sets player name value

- Type: protected string
_______________________________________________

- Name: _playerDamage

- Description: Sets player damage value

- Type: protected float
_______________________________________________

- Name: _playerMoney;

- Description: Sets player money value

- Type: protected int
_______________________________________________

- Name: _playerSpeed

- Description: Sets player speed value

- Type: protected float
_______________________________________________

- Name:Item[] _inventory = new Item[]

- Description: Sets player inventory with new item

- Type: protected
_______________________________________________

- Name: Item _equippedWeapon = new Item()

- Description: Sets player equipped item with new item

- Type: protected
_______________________________________________

- Name: _item1 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item2 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item3 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: _item4 = new Item()

- Description: This item will become new item

- Type: protected
_______________________________________________

- Name: Player()

- Description: Sets player's stat values

- Type: public
_______________________________________________

- Name: Player(string nameVal, float healthVal, float damageVal, float speedVal, int moneyVal, int inventorySize)

- Description: Sets player stats to base value.
Constructor

- Type: public
_______________________________________________

- Name: PlayerStats()

- Description: Displays player's stats

- Type: public void
_______________________________________________

- Name: Item[] InventoryView()

- Description: Shows player's inventory

- Type: public
_______________________________________________

- Name: Contain()

- Description: Contains the item

- Type: public
_______________________________________________

- Name: EquipItem()

- Description: Equipping the item

- Type: public void
_______________________________________________

- Name: SpecialHealingBeer()

- Description: Heals player health at max if player health is greater than max health

- Type: public void
_______________________________________________

- Name: MaxHealth()

- Description: Sets max health

- Type: public float
_______________________________________________

- Name: GetPlayerName()

- Description: Gets player's name

- Type: public string
_______________________________________________

- Name: PlayerAlive()

- Description: If player health is greater than 0

- Type: public bool
_______________________________________________

- Name: PlayerDead()

- Description: If player health is less than 0

- Type: public bool
_______________________________________________

- Name: Attack()

- Description: Player is able to inflict damage

- Type: public virtual float
_______________________________________________

- Name: TakenDamage()

- Description: Player is able to take damage

- Type: public virtual float
_______________________________________________

- Name: PlayerSpeed()

- Description: Returns player speed

- Type: public float
_______________________________________________

- Name: Buy()

- Description: Able to buy if player money is greater or equal to 0

- Type: public void
_______________________________________________

- Name: GetMoney()

- Description: Gets the player's money

- Type: public int
_______________________________________________

- Name: Save()

- Description: Saves player's stats,items,and current fight

- Type: public virtual void
_______________________________________________

- Name: Load()

- Description: Loads player's stats,items, and current fight

- Type: public virtual bool
_______________________________________________

- Name:PrizeMoney()

- Description: Player gains money if player health is greater than 0

- Type: public void
_______________________________________________

**File**: Game.cs

**Attributes**:

- Name: _currentfight

- Description: Sets current fight

- Type: private int
_______________________________________________

- Name: _shop = Shop()

- Description: Sets new shop

- Type: private
_______________________________________________

- Name: _player

- Description: Sets player

- Type: private
_______________________________________________

- Name: _gameOver

- Description: Sets game over

- Type: private bool
_______________________________________________

- Name: Enemy[] _enemy

- Description: Sets new enemy

- Type: private
_______________________________________________

- Name: Run()

- Description: Runs the game by start to end

- Type: public void
_______________________________________________

- Name: CreateCharacter()

- Description: Creates new player

- Type: public
_______________________________________________

- Name: ClearScreen()

- Description: Sets a option to clear the screen

- Type: public void
_______________________________________________

- Name: SwitchWeapons()

- Description: Able to switch weapons in inventory

- Type: public void
_______________________________________________

- Name: GetInput()

- Description: Gets player's input

- Type: public void
_______________________________________________

- Name: TheOldTown()

- Description: Main game that starts up the current fights.

- Type: public void
_______________________________________________

- Name: ShopMenu()

- Description: Starts up shop menu

- Type: private void
_______________________________________________

- Name: ShowInventory()

- Description: Shows inventory for player and shop

- Type: public void
_______________________________________________

- Name: Save()

- Description: Able to save the game

- Type: public void
_______________________________________________

- Name: Load()

- Description: Able to load the game

- Type: public void
_______________________________________________

- Name: GetInput()

- Description: Gets player's input

- Type: public void
_______________________________________________

- Name: OpenMainMenu()

- Description: Starts up main menu

- Type: public void
_______________________________________________

- Name: Start()

- Description: Starts the game

- Type: public void
_______________________________________________

- Name: Update()

- Description: Updates the game

- Type: public void
_______________________________________________

- Name: End()

- Description: Ends the game

- Type: public void
_______________________________________________

**File**: Program.cs

**Attributes**:

- Name: Main()

- Description: Runs the program

- Type: static void
_______________________________________________
