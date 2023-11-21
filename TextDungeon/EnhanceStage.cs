using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    internal class EnhanceStage
    {
        public static void Enhance(List<Item> Inventory)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("■ 인벤토리 ■");
            Console.ResetColor();
            Console.WriteLine("보유 중인 아이템을 강화할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.Write(i+1);
                Inventory[i].PrintItemStatDescription();
            }
            Console.WriteLine("");
            Console.WriteLine("강화할 아이템의 번호를 입력 해 주세요.");
            Console.WriteLine("");

            int input = CheckValidInput(1, Inventory.Count)-1;
            if (Inventory[input].Type == ItemType.weapon)
            {
                Inventory[input].Atk *= 2;
                Inventory[input].Name += "[강화됨]";
            }
            else
            {
                Inventory[input].Def *= 2;
                Inventory[input].Hp *= 2;
                Inventory[input].Name += "[강화됨]";
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("■ 인벤토리 ■");
            Console.ResetColor();
            Console.WriteLine("보유 중인 아이템을 강화할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.Write(i + 1);
                Inventory[i].PrintItemStatDescription();
            }
            Console.WriteLine("나가기");
            //다음스테이지로 연결
            Console.ReadLine();
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

        
    }
}
