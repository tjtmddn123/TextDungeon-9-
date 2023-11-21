
using System;
using System.Numerics;
using System.Threading;
using TectDungeon_Skill;

namespace TextDungeon
{
    //캐릭터 = 플레이어
    //캐릭에 회피 등 확률요소를 넣기, 방어력을 어떤식으로 써먹을지 정하기
    public class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; } // MP 변수 추가
        public int Gold { get; set; }
        public bool IsDead { get; set; }
        public double CritChance { get; set; }  //치확
        public double CritiDamage { get; set; }  //크댐
        public double Evasion { get; set; } // 회피율 

        //캐릭터 클래스에 치명타 확률 및 치명타 공격력의 정보를 추가하고,
        //전투 시에 이를 고려하여 확률에 따라 치명타가 발생
        //캐릭터 클래스에 Evasion 변수를 추가하고 매개변수로 전달

        public Character(string name, string job, int level, int atk, int def, int hp, int mp, int gold, double critChance, double critiDamage, double evasion)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Mp = mp;
            Gold = gold;
            CritChance = critChance;
            CritiDamage = critiDamage;
            Evasion = evasion;
        }
    }

    

    public class Monster
    {
        // 몬스터들을 구현하자 일단 예제에 있는 고블린,드래곤만 만들어둠
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public bool IsDead { get; set; }
    }

    //1스테이지
    public class Slime : Monster
    {
        public Slime()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "슬라임";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class Goblin : Monster
    {
        public Goblin()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "고블린";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class Orc : Monster
    {
        public Orc()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "오크";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class GoblinLord : Monster
    {
        public GoblinLord()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "고블린로드";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }
    //2스테이지
    public class SkeletonWarrior : Monster
    {
        public SkeletonWarrior()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "해골병사";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class SkeletonArcher : Monster
    {
        public SkeletonArcher()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "해골궁수";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class Dullahan : Monster
    {
        public Dullahan()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "듀라한";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public class Lich : Monster
    {
        public Lich()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "리치";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    //3스테이지
    public class Drake : Monster
    {
        public Drake()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "드레이크";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }
    public class Wyvern : Monster
    {
        public Wyvern()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "와이번";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }
    public class Griffin : Monster
    {
        public Griffin()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "그리핀";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }
    public class Dragon : Monster
    {
        public Dragon()
        {
            int randomMonsterHp = new Random().Next(20, 25);
            int randomMonsterAtk = new Random().Next(2, 5);
            Name = "드래곤";
            Hp = randomMonsterHp;
            Atk = randomMonsterAtk;
        }
    }

    public enum ItemType
    {
        weapon,
        helme,
        shirt,
        pants
    }


    public class Item
    {
        public string Name { get; set; }
        public string Description { get; }
        public ItemType Type { get; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Price { get; }
        public bool IsEquiped { get; set; }

        public Item(string name, string description, ItemType type, int atk, int def, int hp, int price, bool isEquiped = false)
        {
            Name = name;
            Description = description;
            Type = type;
            Atk = atk;
            Def = def;
            Hp = hp;
            Price = price;
            IsEquiped = isEquiped;
        }

        // 인벤토리 등 아이템 보이게 하는 부분임니다~!
        //여기 조절하면 배열 깔끔하게 맞출수 있음 대충 맞춰 놨는데 완벽하지 않아요!
        //지금 하지말고 추가 구현 끝나고 다 같이 맞춰 보시죠~
        public void PrintItemStatDescription(bool withNumber = false, int idx = 0)
        {
            Console.Write("- ");
            // 장착관리 전용
            if (withNumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("{0} ", idx);
                Console.ResetColor();
            }
            if (IsEquiped)
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("E");
                Console.ResetColor();
                Console.Write("]");
                Console.Write(PadRightForMixedText(Name, 9));
            }
            else Console.Write(PadRightForMixedText(Name, 12));

            Console.Write(" | ");

            if (Atk != 0) Console.Write($"Atk {(Atk >= 0 ? "+" : "")}{Atk} ");
            if (Def != 0) Console.Write($"Def {(Def >= 0 ? "+" : "")}{Def} ");
            if (Hp != 0) Console.Write($"Hp {(Hp >= 0 ? "+" : "")}{Hp}");

            Console.Write(" |\t ");

            Console.Write(Description + "\t");

            Console.Write(" |\t ");

            Console.WriteLine(Price + "G");
        }

        public static int GetPrintableLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    length += 2; // 한글과 같은 넓은 문자에 대해 길이를 2로 취급
                }
                else
                {
                    length += 1; // 나머지 문자에 대해 길이를 1로 취급
                }
            }

            return length;
        }

        public static string PadRightForMixedText(string str, int totalLength)
        {
            int currentLength = GetPrintableLength(str);
            int padding = totalLength - currentLength;
            return str.PadRight(str.Length + padding);
        }

    }

    internal class Program
    {
        public static Stage newStage = new Stage();
        public static Character _player;
        public static List<Item> _items = new List<Item>();
        public static List<Item> Inventory =  new List<Item>();
        public static List<Monster> monsters = new List<Monster>();
        public bool IsDead = false;

        static void Main(string[] args)
        {
            //캐릭터 정보 및 아이템 불러오기
            GameDataSetting();
            //1번 시작화면 이후 선택창 불러오기
            Intro();
            //2번 메인화면 중 이름 , 직업선택(추가 가능) 설정 받아오기.
            GameStartScene();
            //2번 메인화면 : 상태창,인벤토리,전투 로 구성되어 있음.
            StartMenu();
        }

        static void GameDataSetting()
        {
            //Inventory = new List<Item>();
            Inventory.Add(new Item("나무 몽둥이", "초반 무기로 이거만한게 없지", ItemType.weapon, 2, 0, 0, 50));
            Inventory.Add(new Item("냄비 뚜껑", "엄마한테 혼남 주의", ItemType.weapon, 0, 2, 0, 50));
            // 이름/ 설명/ 타입/ 공격력/ 방어력/ 체력/ 가격  
            //_items = new List<Item>();
            _items.Add(new Item("낡은 검", "쉽게 볼 수 있는 낡은 검입니다.", ItemType.weapon, 2, 0, 0, 50));
            _items.Add(new Item("짱짱 칼", "짱짱 칼이당.", ItemType.weapon, 2, 0, 0, 50));
            _items.Add(new Item("짱짱 모자", "짱짱 모자당.", ItemType.helme, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 자켓", "짱짱 자켓이당.", ItemType.shirt, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 바지", "짱짱 바지당.", ItemType.pants, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 장갑", "짱짱 장갑이당.", ItemType.helme, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 신발", "짱짱 신발이당.", ItemType.helme, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 벨트", "짱짱 벨트당.", ItemType.helme, 0, 5, 0, 50));
            _items.Add(new Item("짱짱 짱돌", "짱짱 짱..돌? 이건좀;", ItemType.weapon, 100, 0, 0, 50));
        }

        static void Intro()
        {
            //1번 시작화면 + 이후 선택창 구현(이어하기 , 새로하기)
            //DB가 아직 구현안됨
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("\t\t\t\t      \\                           |       ");
            Console.WriteLine("\t\t\t\t     _ \\     __|  __|   _` |   _` |   _ \\ ");
            Console.WriteLine("\t\t\t\t    ___ \\   |    (     (   |  (   |   __/ ");
            Console.WriteLine("\t\t\t\t  _/    _\\ _|   \\___| \\__,_| \\__,_| \\___| ");
            Console.WriteLine("\t\t\t\t                                          \n");
            Console.WriteLine("\t\t\t\t\t press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }

        static void GameStartScene()
        {
            // 캐릭터 이름 세팅
            Console.WriteLine("아케이드 마을에 오신 여러분 환영합니다."); //변경사항
            Console.WriteLine("이름을 입력하세요.");
            Console.WriteLine();
            string playerName = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"이름 :{playerName}");
            Console.Clear();


            // 캐릭터 직업 세팅
            Console.WriteLine(" ※원하는 직업을 선택하세요.※");
            Console.WriteLine();
            Console.WriteLine("1. 전사 : 공격과 방어에 밸런스가 좋고 초기 체력이 높습니다.\n");
            Console.WriteLine("2. 궁수 : 공격력이 강한 대신 방어력과 체력이 낮습니다.\n");
            Console.WriteLine("3. 도적 : 초기스텟이 낮은 대신 추가 소지금이 있습니다.\n");

            int input = CheckValidInput(1, 3);

            switch (input)
            //여기에도 크확 크댐 추가. 50   크10  회10
            //회피율도 추가
            {
                case 1:
                    _player = new Character($"{playerName}", "전사", 1,7, 2, 100, 10, 500, 0.2, 2, 0.2);
                    break;
                case 2:
                    _player = new Character($"{playerName}", "궁수", 1, 10, 1, 80, 10, 500, 0.3, 2, 0.1);
                    break;
                case 3:
                    _player = new Character($"{playerName}", "도적", 1, 3, 1, 77, 10, 1000, 0.1, 2, 0.3);
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

        }//GameStartScene()

        public static void StartMenu()
        {
            Console.Clear();

            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("아케이드 마을에 오신 여러분 환영합니다."); //변경사항
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("");
            Console.WriteLine("1. 상태 보기\n");
            Console.WriteLine("2. 인벤토리\n");
            Console.WriteLine("3. 던전 입장\n");

            switch (CheckValidInput(1, 3))
            {
                case 1:
                    StatusMenu();
                    break;
                case 2:
                    InventoryMenu();
                    break;
                case 3:
                    newStage.Stages(_player, monsters,1, 1);//던전입장 1은 임시번호
                    break;
            }
        }

        static int CheckValidInput(int min, int max)
        {
            int keyInput;
            bool result;
            do
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                result = int.TryParse(Console.ReadLine(), out keyInput);
            } while (result == false || CheckIfValid(keyInput, min, max) == false);

            return keyInput;
        }

        static bool CheckIfValid(int checkable, int min, int max)
        {
            if (min <= checkable && checkable <= max) return true;
            return false;
        }

        static void StatusMenu()
        {
            Console.Clear();

            ShowHighlightedText("■ 상태 보기 ■");
            Console.WriteLine("캐릭터의 정보가 표기됩니다.");

            PrintTextWithHighlights("Lv. ", _player.Level.ToString("00"));
            Console.WriteLine("");
            Console.WriteLine("{0} ( {1} )", _player.Name, _player.Job);

            int bonusAtk = getSumBonusAtk();
            PrintTextWithHighlights("공격력 : ", (_player.Atk += bonusAtk).ToString(), bonusAtk > 0 ? string.Format(" (+{0})", bonusAtk) : "");

            int bonusDef = getSumBonusDef();
            PrintTextWithHighlights("방어력 : ", (_player.Def += bonusDef).ToString(), bonusDef > 0 ? string.Format(" (+{0})", bonusDef) : "");

            int bonusHp = getSumBonusHp();
            PrintTextWithHighlights("체 력 : ", (_player.Hp += bonusHp).ToString(), bonusHp > 0 ? string.Format(" (+{0})", bonusHp) : "");
            Console.Write("마나 : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{_player.Mp}");
            Console.ResetColor();
            PrintTextWithHighlights("Gold : ", _player.Gold.ToString(), "  G");
            Console.WriteLine("");
            Console.WriteLine("0. 뒤로가기\n");

            switch (CheckValidInput(0, 0))
            {
                case 0:
                    StartMenu();
                    break;
            }
        }//StatusMenu()

        //아이템 장착시 공격력
        private static int getSumBonusAtk()
        {
            int sum = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i].IsEquiped) sum += Inventory[i].Atk;
            }
            return sum;
        }

        //아이템 장착시 방어력
        private static int getSumBonusDef()
        {
            int sum = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i].IsEquiped) sum += Inventory[i].Def;
            }
            return sum;
        }

        //아이템 장착시 체력
        private static int getSumBonusHp()
        {
            int sum = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i].IsEquiped) sum += Inventory[i].Hp;
            }
            return sum;
        }

        private static void PrintTextWithHighlights(string s1, string s2, string s3 = "")
        {
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s2);
            Console.ResetColor();
            Console.WriteLine(s3);
        }

        static void InventoryMenu()
        {
            Console.Clear();

            ShowHighlightedText("■ 인벤토리 ■");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Inventory[i].PrintItemStatDescription();
            }
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("");
            switch (CheckValidInput(0, 1))
            {
                case 0:
                    StartMenu();
                    break;
                case 1:
                    EquipMenu();
                    break;
            }
        }//InventoryMenu()

        static void EquipMenu()
        {
            Console.Clear();

            ShowHighlightedText("■ 인벤토리 - 장착 관리 ■");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Inventory[i].PrintItemStatDescription(true, i + 1); // 1, 2, 3에 매핑하기 위해 +1
            }
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");

            int keyInput = CheckValidInput(0, Inventory.Count);

            switch (keyInput)
            {
                case 0:
                    InventoryMenu();
                    break;
                default:
                    ToggleEquipStatus(keyInput - 1);
                    EquipMenu();
                    break;
            }
        }//EquipMenu()

        static void ToggleEquipStatus(int idx)
        {
            Inventory[idx].IsEquiped = !Inventory[idx].IsEquiped;

            if (Inventory[idx].Type == ItemType.weapon)
            {
                for(int i = 0; i< Inventory.Count; i++)
                {
                    if(i != idx && Inventory[i] is Item)
                    {
                        Inventory[i].IsEquiped= false;
                    }
                }
            }

            if (Inventory[idx].Type == ItemType.helme)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (i != idx && Inventory[i] is Item)
                    {
                        Inventory[i].IsEquiped = false;
                    }
                }
            }

            if (Inventory[idx].Type == ItemType.shirt)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (i != idx && Inventory[i] is Item)
                    {
                        Inventory[i].IsEquiped = false;
                    }
                }
            }

            if (Inventory[idx].Type == ItemType.pants)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (i != idx && Inventory[i] is Item)
                    {
                        Inventory[i].IsEquiped = false;
                    }
                }
            }
        }//ToggleEquipStatus()

        static void ShowHighlightedText(string title)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title);
            Console.ResetColor();
        }

        static void ShopMenu(Character _player, List<Item> _Items)
        {
            Console.Clear();
            ShowHighlightedText("■ 상점 ■");
            Console.WriteLine($"구매 할 물품을 선택하세요.     {_player.Gold}  G");
            Console.WriteLine("\n");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].PrintItemStatDescription(true, i + 1); // 1, 2, 3에 매핑하기 위해 +1
            }
            Console.WriteLine("");
            Console.WriteLine("구입할 아이템을 선택하세요");
            Console.WriteLine("0. 나가기");

            int.TryParse(Console.ReadLine(), out int choice);
            if (choice >= 0 && choice <= _Items.Count)
            {
                if (choice == 0)
                {
                    // 다음 스테이지 이어서 들어가기
                }

                Item selectedItem = _Items[choice - 1];

                if (_player.Gold >= selectedItem.Price)
                {
                    // 플레이어의 소지금에서 아이템 가격을 차감
                    _player.Gold -= selectedItem.Price;

                    // 아이템을 플레이어의 인벤토리에 추가
                    Inventory.Add(selectedItem);
                    _Items.Remove(selectedItem);

                    Console.WriteLine($"{selectedItem.Name}을(를) 구입했습니다. 남은 골드: {_player.Gold}");
                    Thread.Sleep(600);
                    ShopMenu(_player, _Items);
                }
                else
                {
                    Console.WriteLine("골드가 부족하여 아이템을 구입할 수 없습니다.");
                    Thread.Sleep(600);
                    ShopMenu(_player, _Items);
                }
            }

        }        
    }//~
}