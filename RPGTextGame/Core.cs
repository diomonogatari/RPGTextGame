using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Drawing;
using static RPGTextGame.EquipableItem;


namespace RPGTextGame
{
    public enum TypesOfStats { HP, AttackDamage, MagicDamage, Armor, MagicResistence, Stamina, Luck, Intelligence, Experience, None, Invalid }


    class Core
    {
        #region Debug Methods
        static void logChanceResults(string path, CharacterHero hero)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(GameMechanics.DetermineChanceLevel(hero));
                tw.Close();
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(GameMechanics.DetermineChanceLevel(hero));
                    tw.Close();
                }
            }
        }
        #endregion

        public static ConsoleColor narratorColor = ConsoleColor.White;
        static string command;
        static string[] commandWords;
        static List<string> commandList = new List<string> { "walk","hike","stroll","march","stride",
            "run","dart","dash","rush","sprint","escape","spurt","flight","jog",
            "talk","chat","communicate","say","speak","tell","articulate","chatter","converse","utter","voice","pronounce","verbalize",
            "sell",
            "buy","get","obtain","purchase","take","acquire",
            "look","glance","notice","see","stare","study","watch","admire","behold","beware","contemplate","focus","gaze","inspect","observe","scan","survey",
            "use","consume","apply","spend","wield","ply","expend",
            "fight","attack","battle","challenge","clash","meet","assault","bicker","brawl","contend","dispute","duel","feud","joust","quarrel","skirmish","spar","war","wrestle","tussle","wrangle",
            "explore","delve into","probe","scout","travel","traverse","reconnoitre",
            "give","award","deliver","donate","grant","hand over","hand out","present","provide","cede","entrust","gift","lease","relinquish",


            "showbag","lookself","lookitem",

        };

        #region Static Methods
        //An overload of Write might be useful for Speed Changing
        public static void Write(String text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                if (c == '\n')
                    Thread.Sleep(150);
                Thread.Sleep(30);
            }
            Console.Write("\n");
        }
        public static void Write(String text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                if (c == '\n')
                    Thread.Sleep(150);
                Thread.Sleep(30);
            }
            Console.Write("\n");
        }

        static string[] splitCommandIntoWords(string UserInput)
        {
            return commandWords = UserInput.Split();
        }

        static bool isInputValidPrimaryCommand(string input) 
        {
            foreach (string i in commandList)
                if (i.Equals(input.ToLower()))
                    return true;
            return false;
        }

        public static void checkUserInput(string input, CharacterHero hero) //call this when you want to read a command from User
        {
            input.ToLower();//lower case
            splitCommandIntoWords(input); //split the words
            if (!isInputValidPrimaryCommand(commandWords[0])) //check 1st word if possible
                Core.Write("That action is not possible");
            else
            {
                if (commandWords.Length > 1)
                    ExecuteCommand(commandWords[0], commandWords[1], hero);
                else
                    ExecuteCommand(commandWords[0],hero);
            }

        }

        #region ExecuteCommand
        static void ExecuteCommand(string command, CharacterHero hero)
        {
            switch (command.ToLower())
            {

                case "showbag":
                    hero.ShowBag();
                    break;
                case "lookself":
                    hero.LookSelf();
                    break;
                case "lookitem":
                    hero.LookItem((UsableItem)hero.bag[2]);
                    break;
                #region Walking
                //Undirectional walking
                case "walk":
                case "hike":
                case "stroll":
                case "march":
                case "stride":
                    //Todo relocate the step and place it in "Step in, Step out" scenarios case //"step":
                    Core.Write("Which way?", narratorColor);
                    string additionalCommand = Core.Read().ToLower();
                    switch (additionalCommand)
                    {
                        #region Absolute directions
                        case "north":
                        case "northward":
                        case "northwards":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        case "south":
                        case "southward":
                        case "southwards":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        case "east":
                        case "eastward":
                        case "eastwards":
                        case "orient":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        case "west":
                        case "westward":
                        case "westwards":
                        case "occident":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        #endregion

                        #region Relative directions
                        //forward
                        case "forwards":
                        case "forward":
                        case "ahead":
                        case "onward":
                        case "forth":
                        case "along":
                        case "in front":
                        case "front":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        //back
                        case "backwards":
                        case "backward":
                        case "rearward":
                        case "rearwards":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        //left
                        case "leftwards":
                        case "leftward":
                        case "left":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        //right
                        case "rightwards":
                        case "rightward":
                        case "right":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        #endregion

                        #region Up Down directions
                        case "up":
                        case "upward":
                        case "upwards":
                        case "skywards":
                        case "skyward":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        case "down":
                        case "downwards":
                        case "downward":
                        case "earthward":
                        case "earthwards":
                            Core.Write("You " + command + " " + additionalCommand);
                            break;
                        #endregion

                        default:
                            Core.Write("What kind of direction is that?", narratorColor);
                            break;
                    }
                    break;

                //Directional walking
                #region Absolute directions
                case "walk north":
                case "walk northward":
                case "walk northwards":
                case "hike north":
                case "hike northward":
                case "hike northwards":
                case "stroll north":
                case "stroll northward":
                case "stroll northwards":
                case "march north":
                case "march northward":
                case "march northwards":
                case "stride north":
                case "stride northward":
                case "stride northwards":
                    Core.Write("You " + command);
                    break;
                case "walk south":
                case "walk southward":
                case "walk southwards":
                case "hike south":
                case "hike southward":
                case "hike southwards":
                case "stroll south":
                case "stroll southward":
                case "stroll southwards":
                case "march south":
                case "march southward":
                case "march southwards":
                case "stride south":
                case "stride southward":
                case "stride southwards":
                    Core.Write("You " + command);
                    break;
                case "walk east":
                case "walk eastward":
                case "walk eastwards":
                case "walk orient":
                case "hike east":
                case "hike eastward":
                case "hike eastwards":
                case "hike orient":
                case "stroll east":
                case "stroll eastward":
                case "stroll eastwards":
                case "stroll orient":
                case "march east":
                case "march eastward":
                case "march eastwards":
                case "march orient":
                case "stride east":
                case "stride eastward":
                case "stride eastwards":
                case "stride orient":
                    Core.Write("You " + command);
                    break;
                case "walk west":
                case "walk westward":
                case "walk westwards":
                case "walk occident":
                case "hike west":
                case "hike westward":
                case "hike westwards":
                case "hike occident":
                case "stroll west":
                case "stroll westward":
                case "stroll westwards":
                case "stroll occident":
                case "march west":
                case "march westward":
                case "march westwards":
                case "march occident":
                case "stride west":
                case "stride westward":
                case "stride westwards":
                case "stride occident":
                    Core.Write("You " + command);
                    break;
                #endregion

                #region Relative directions
                //forward
                case "walk forwards":
                case "walk forward":
                case "walk ahead":
                case "walk onward":
                case "walk forth":
                case "walk along":
                case "walk in front":
                case "walk front":
                case "hike forwards":
                case "hike forward":
                case "hike ahead":
                case "hike onward":
                case "hike forth":
                case "hike along":
                case "hike in front":
                case "hike front":
                case "stroll forwards":
                case "stroll forward":
                case "stroll ahead":
                case "stroll onward":
                case "stroll forth":
                case "stroll along":
                case "stroll in front":
                case "stroll front":
                case "march forwards":
                case "march forward":
                case "march ahead":
                case "march onward":
                case "march forth":
                case "march along":
                case "march in front":
                case "march front":
                case "stride forwards":
                case "stride forward":
                case "stride ahead":
                case "stride onward":
                case "stride forth":
                case "stride along":
                case "stride in front":
                case "stride front":
                    Core.Write("You " + command);
                    break;
                //back
                case "walk backwards":
                case "walk backward":
                case "walk rearward":
                case "walk rearwards":
                case "hike backwards":
                case "hike backward":
                case "hike rearward":
                case "hike rearwards":
                case "stroll backwards":
                case "stroll backward":
                case "stroll rearward":
                case "stroll rearwards":
                case "march backwards":
                case "march backward":
                case "march rearward":
                case "march rearwards":
                case "stride backwards":
                case "stride backward":
                case "stride rearward":
                case "stride rearwards":
                    Core.Write("You " + command);
                    break;
                //left
                case "walk leftwards":
                case "walk leftward":
                case "walk left":
                case "hike leftwards":
                case "hike leftward":
                case "hike left":
                case "stroll leftwards":
                case "stroll leftward":
                case "stroll left":
                case "march leftwards":
                case "march leftward":
                case "march left":
                case "stride leftwards":
                case "stride leftward":
                case "stride left":
                    Core.Write("You " + command);
                    break;
                //right
                case "walk rightwards":
                case "walk rightward":
                case "walk right":
                case "hike rightwards":
                case "hike rightward":
                case "hike right":
                case "stroll rightwards":
                case "stroll rightward":
                case "stroll right":
                case "march rightwards":
                case "march rightward":
                case "march right":
                case "stride rightwards":
                case "stride rightward":
                case "stride right":
                    Core.Write("You " + command);
                    break;
                #endregion

                #region Up Down directions
                case "walk up":
                case "walk upward":
                case "walk upwards":
                case "walk skywards":
                case "walk skyward":
                case "hike up":
                case "hike upward":
                case "hike upwards":
                case "hike skywards":
                case "hike skyward":
                case "stroll up":
                case "stroll upward":
                case "stroll upwards":
                case "stroll skywards":
                case "stroll skyward":
                case "march up":
                case "march upward":
                case "march upwards":
                case "march skywards":
                case "march skyward":
                case "stride up":
                case "stride upward":
                case "stride upwards":
                case "stride skywards":
                case "stride skyward":
                    Core.Write("You " + command);
                    break;
                case "walk down":
                case "walk downwards":
                case "walk downward":
                case "walk earthward":
                case "walk earthwards":
                case "hike down":
                case "hike downwards":
                case "hike downward":
                case "hike earthward":
                case "hike earthwards":
                case "stroll down":
                case "stroll downwards":
                case "stroll downward":
                case "stroll earthward":
                case "stroll earthwards":
                case "march down":
                case "march downwards":
                case "march downward":
                case "march earthward":
                case "march earthwards":
                case "stride down":
                case "stride downwards":
                case "stride downward":
                case "stride earthward":
                case "stride earthwards":
                    Core.Write("You " + command);
                    break;
                #endregion

                #endregion

                #region Running
                case "run":
                case "dart":
                case "dash":
                case "rush":
                case "sprint":
                case "escape":
                case "spurt":
                case "flight":
                case "jog":
                    Core.Write("You started to " + command);
                    break;
                #endregion
                #region Dialog
                case "talk":
                case "chat":
                case "communicate":
                case "say":
                case "speak":
                case "tell":
                case "articulate":
                case "chatter":
                case "converse":
                case "utter":
                case "voice":
                case "pronounce":
                case "verbalize":
                    Core.Write("You decided to " + command);
                    break;
                #endregion

                case "sell":
                    Core.Write("You sold that item");
                    break;

                #region Buying
                case "buy":
                case "get":
                case "obtain":
                case "purchase":
                case "take":
                case "acquire":
                    Core.Write("You decided to" + command + "that item");
                    break;
                #endregion

                #region Environment inspection
                case "look":
                case "glance":
                case "notice":
                case "see":
                case "stare":
                case "study":
                case "watch":
                case "admire":
                case "behold":
                case "beware":
                case "contemplate":
                case "focus":
                case "gaze":
                case "inspect":
                case "observe":
                case "scan":
                case "survey":
                    Core.Write("You " + command);
                    break;
                #endregion

                #region  Use stuff
                case "use":
                case "consume":
                case "apply":
                case "spend":
                case "wield":
                case "ply":
                case "expend":
                    
                    Core.Write("Use what?");
                    hero.UseItem(Core.Read());
                    break;
                #endregion

                #region Engage fight
                case "fight":
                case "attack":
                case "battle":
                case "challenge":
                case "clash":
                case "meet":
                case "assault":
                case "bicker":
                case "brawl":
                case "contend":
                case "dispute":
                case "duel":
                case "feud":
                case "joust":
                case "quarrel":
                case "skirmish":
                case "spar":
                case "war":
                case "wrestle":
                case "tussle":
                case "wrangle":
                    Core.Write("It's time to " + command);
                    break;
                #endregion

                #region Scenario exploration
                case "explore":
                case "delve into":
                case "probe":
                case "scout":
                case "travel":
                case "traverse":
                case "reconnoitre":
                    Core.Write("You " + command + " the vicinities");
                    break;
                #endregion

                #region Give items
                case "give":
                case "award":
                case "deliver":
                case "donate":
                case "grant":
                case "hand over":
                case "hand out":
                case "present":
                case "provide":
                case "cede":
                case "entrust":
                case "gift":
                case "lease":
                case "relinquish":
                    Core.Write("You " + command + "Vanessa the mighty magisword");
                    break;

                    #endregion
            }
        }

        static void ExecuteCommand(string primaryCommand, string secondaryCommand, CharacterHero hero)
        {

            switch (primaryCommand)
            {
                //Todo Cleanup debugs

                case "lookself":
                hero.LookSelf();
                    break;
                case "lookitem":
                    hero.LookItem((UsableItem)hero.bag[2]);
                    break;

                #region Walking

                case "walk":
                case "hike":
                case "stroll":
                case "march":
                case "stride":
                    switch (secondaryCommand)
                    {
                        #region Absolute directions
                        case "north":
                        case "northward":
                        case "northwards":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        case "south":
                        case "southward":
                        case "southwards":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        case "east":
                        case "eastward":
                        case "eastwards":
                        case "orient":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        case "west":
                        case "westward":
                        case "westwards":
                        case "occident":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        #endregion

                        #region Relative directions
                        //forward
                        case "forwards":
                        case "forward":
                        case "ahead":
                        case "onward":
                        case "forth":
                        case "along":
                        case "in front":
                        case "front":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        //back
                        case "backwards":
                        case "backward":
                        case "rearward":
                        case "rearwards":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        //left
                        case "leftwards":
                        case "leftward":
                        case "left":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        //right
                        case "rightwards":
                        case "rightward":
                        case "right":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        #endregion

                        #region Up Down directions
                        case "up":
                        case "upward":
                        case "upwards":
                        case "skywards":
                        case "skyward":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        case "down":
                        case "downwards":
                        case "downward":
                        case "earthward":
                        case "earthwards":
                            Core.Write("You " + primaryCommand + " " + secondaryCommand);
                            break;
                        #endregion

                        default:
                            Core.Write("What kind of direction is that?", narratorColor);
                            break;
                    }
                    break;

                #endregion

                #region Running
                case "run":
                case "dart":
                case "dash":
                case "rush":
                case "sprint":
                case "escape":
                case "spurt":
                case "flight":
                case "jog":
                    Core.Write("Dummy running action");//Todo Decide if run is a 2 step command
                    break;
                #endregion
                #region Dialog
                case "talk":
                case "chat":
                case "communicate":
                case "say":
                case "speak":
                case "tell":
                case "articulate":
                case "chatter":
                case "converse":
                case "utter":
                case "voice":
                case "pronounce":
                case "verbalize":
                    Core.Write("You decided to " + primaryCommand + " with " + secondaryCommand);
                    break;
                #endregion

                case "sell":
                    Core.Write("You sold that item");
                    break;

                #region Buying
                case "buy":
                case "get":
                case "obtain":
                case "purchase":
                case "take":
                case "acquire":
                    Core.Write("You decided to" + primaryCommand + "the " + secondaryCommand);
                    break;
                #endregion

                #region Environment inspection
                case "look":
                case "glance":
                case "notice":
                case "see":
                case "stare":
                case "study":
                case "watch":
                case "admire":
                case "behold":
                case "beware":
                case "contemplate":
                case "focus":
                case "gaze":
                case "inspect":
                case "observe":
                case "scan":
                case "survey":
                    switch (secondaryCommand)
                    {
                        case "bag":
                            hero.ShowBag();
                            break;
                        case "self":
                            hero.LookSelf();
                            break;
                        //This item case has to be fixed has it can be any item
                        default:
                            Core.Write("You couldn't find what you're looking for");
                            break;

                    }
                    Item item;
                    if (hero.bag.Contains((item = hero.findTheItemByName(secondaryCommand))))
                        hero.LookItem(item);
                    break;
                #endregion

                #region  Use stuff
                case "use":
                case "consume":
                case "apply":
                case "spend":
                case "wield":
                case "ply":
                case "expend":
                    hero.UseItem(secondaryCommand);
                    break;
                #endregion

                #region Engage fight
                case "fight":
                case "attack":
                case "battle":
                case "challenge":
                case "clash":
                case "meet":
                case "assault":
                case "bicker":
                case "brawl":
                case "contend":
                case "dispute":
                case "duel":
                case "feud":
                case "joust":
                case "quarrel":
                case "skirmish":
                case "spar":
                case "war":
                case "wrestle":
                case "tussle":
                case "wrangle":
                    Core.Write("It's time to " + primaryCommand + " the " + secondaryCommand);
                    break;
                #endregion

                #region Scenario exploration
                case "explore":
                case "delve into":
                case "probe":
                case "scout":
                case "travel":
                case "traverse":
                case "reconnoitre":
                    Core.Write("You " + primaryCommand + " the " + secondaryCommand);
                    break;
                #endregion

                //Todo Giving is done by "Give {target} the {item}" or "Give the {item} to {target}
                #region Give items
                case "give":
                case "award":
                case "deliver":
                case "donate":
                case "grant":
                case "hand over":
                case "hand out":
                case "present":
                case "provide":
                case "cede":
                case "entrust":
                case "gift":
                case "lease":
                case "relinquish":
                    Core.Write("You " + primaryCommand + "Vanessa " + secondaryCommand);
                    break;

                #endregion
                default:
                    Core.Write("You can't do that", narratorColor);
                    break;

            }
        }
        #endregion

        public static String Read()
        {
            String playerInput = Console.ReadLine();
            return playerInput;
        }

        public static TypesOfStats StatEnumConverter(string statToCheck)
        {
            switch (statToCheck)
            {
                case "AttackDamage":
                    return TypesOfStats.AttackDamage;
                case "HP":
                    return TypesOfStats.HP;
                case "MagicResistence":
                    return TypesOfStats.MagicResistence;
                case "MagicDamage":
                    return TypesOfStats.MagicDamage;
                case "Armor":
                    return TypesOfStats.Armor;
                case "Stamina":
                    return TypesOfStats.Stamina;
                case "Luck":
                    return TypesOfStats.Luck;
                case "Intelligence":
                    return TypesOfStats.Intelligence;
                case "Experience":
                    return TypesOfStats.Experience;
                case "None":
                    return TypesOfStats.None;
                default:
                    Console.WriteLine("You didn't choose a valid Stat");
                    return TypesOfStats.Invalid;

            }
        }

        #endregion
        static string title = @"
                        ██████╗ ███████╗ █████╗ ██████╗ ██████╗  ██████╗ ██╗███╗   ██╗████████╗
                        ██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔═══██╗██║████╗  ██║╚══██╔══╝
                        ██║  ██║█████╗  ███████║██║  ██║██████╔╝██║   ██║██║██╔██╗ ██║   ██║   
                        ██║  ██║██╔══╝  ██╔══██║██║  ██║██╔═══╝ ██║   ██║██║██║╚██╗██║   ██║   
                        ██████╔╝███████╗██║  ██║██████╔╝██║     ╚██████╔╝██║██║ ╚████║   ██║   
                        ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝ ╚═╝      ╚═════╝ ╚═╝╚═╝  ╚═══╝   ╚═╝ 
                                                                       
";
        static void Main(string[] args)
        {
            //Todo using an item with multiple spaces will not be used because of word spliting method that is being used
            List<Item> defaultBag = new List<Item> { new UsableItem("HealthPotion", "Regeneration for the win", TypesOfStats.HP, 100),
                new EquipableItem("BootsOfHercules", "Resist to earthquakes", TypesOfStats.Armor,TypeOfEquip.Boots, 100),
                new UsableItem("Apple", "Yummi", TypesOfStats.Stamina, 100),
                new UsableItem("Banana", "Potassium powers", TypesOfStats.Intelligence, 100),
                new EquipableItem("HermesShoes", "Fast as hell boys", TypesOfStats.Luck, EquipableItem.TypeOfEquip.Boots, 30)
            };
        
            CharacterHero Gervásio = new CharacterHero("Anon", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0, ConsoleColor.Cyan);
            Gervásio.bag = defaultBag;
            ;
            //Woods_1 explore = new Woods_1(hero);
            //explore.Woodsini();

            //OpeningNarrative narrative = new OpeningNarrative(hero);
            //Console.WriteLine("Debug opening narrative complete\n--------------------------------------------------------------------------------------------------\n");
            //Console.Read();
            //Console.Clear();
            //narrative.Chapter1();

            //Console.WriteLine(title);
            //Console.Read();


            while (!Console.KeyAvailable)
            {

                checkUserInput(Core.Read(),Gervásio);




                Thread.Sleep(3);
            }
            //CharacterHero hero = new CharacterHero("Gervásio", 1233, 1332, 1332, 1332, 1332, 12332, /*Luck is here*/ 9, 1233, "Descriçao", 41241412, ConsoleColor.Red);
            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //string path = System.IO.Path.Combine(desktop, $"RNGTestResults_Luck{hero.luck}.txt");


            ////Bitmap bmpSrc = new Bitmap(@"C:\Users\xatna35\Desktop\mona.jpg", true);
            ////ConsoleWriteImage(bmpSrc);
            //while (true)
            //{


            //    logChanceResults(path, hero);

            //    Thread.Sleep(1);
            //}
        }

    }
}
