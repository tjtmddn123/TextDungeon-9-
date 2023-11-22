using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    internal class Heal
    {
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

        public static void HealStage(Character _player)
        {
            Console.Clear();

            Console.WriteLine("회복샘에 도착하였습니다.");
            Console.WriteLine("");
            Console.WriteLine("\n체력이 회복됩니다.");
            Console.WriteLine("");

            Console.WriteLine($"이전 체력 : {_player.Hp}");     // 체력 회복 전 Hp 표시
            _player.Hp = _player.MaxHp;   // 체력 회복
            Console.WriteLine($"현재 체력 : {_player.Hp}");
            Console.WriteLine("");
            Console.WriteLine("0. 다음 던전으로.");

            switch (CheckValidInput(0, 0))
            {
                case 0:
                    // 연결 스테이지
                    break;
            }
        }// HealStage
    }
}
