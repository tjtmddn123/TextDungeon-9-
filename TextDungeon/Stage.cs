using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public static class Stage1
    {
        public static void TempleStage(Character _player)
        {
            Console.Clear();

            Console.WriteLine("\n(이계의 )신전을 마주하였습니다.\n");
            Console.WriteLine("   `,.      .   .        *   .    .      .  _    ..          .\r\n     \\,~-.         *           .    .       ))       *    .\r\n          \\ *          .   .   |    *  . .  ~    .      .  .  ,\r\n ,           `-.  .            :               *           ,-\r\n  -             `-.        *._/_\\_.       .       .   ,-'\r\n  -                 `-_.,     |n|     .      .       ;\r\n    -                    \\ ._/_,_\\_.  .          . ,'         ,\r\n     -                    `-.|.n.|      .   ,-.__,'         -\r\n      -                   ._/_,_,_\\_.    ,-'              -\r\n      -                     |..n..|-`'-'                -\r\n       -                 ._/_,_,_,_\\_.                 -\r\n         -               ,-|...n...|                  -\r\n           -         ,-'._/_,_,_,_,_\\_.              -\r\n             -  ,-=-'     |....n....|              -\r\n              -;       ._/_,_,_,_,_,_\\_.         -\r\n             ,-          |.....n.....|          -\r\n           ,;         ._/_,_,_,_,_,_,_\\_.         -\r\n  `,  '.  `.  \".  `,  '.| n   ,-.   n |  \",  `.  `,  '.  `,  ',\r\n,.:;..;;..;;.,:;,.;:,o__|__o !.|.! o__|__o;,.:;.,;;,,:;,.:;,;;:\r\n ][  ][  ][  ][  ][  |_i_i_H_|_|_|_H_i_i_|  ][  ][  ][  ][  ][\r\n                     |     //=====\\\\     |\r\n                     |____//=======\\\\____|\r\n                         //=========\\\\");
            Console.WriteLine("\n원하는 행동을 입력하세요.");
            Console.WriteLine("1. 기도를 올린다.(- 500 G)");
            Console.WriteLine("0. 지나간다.");
            int _playerinput = int.Parse(Console.ReadLine());
            switch (_playerinput)
            {
                case 0:
                    Console.WriteLine("신전을 무시하고 지나갑니다.");
                    //다음 스테이지 연결
                    break;
                case 1:
                    Console.WriteLine("기도를 올렸습니다.");
                    _player.Gold = _player.Gold - 500;
                    Console.WriteLine($"현재 소지금 : {_player.Gold}");
                    //1. 랜덤 스텟 상승 or 감소
                    //2. 랜덤 아이템 획득
                    //다음 스테이지 연결
                    break;
            }
        }//TempleStage()
    }//class Stage
}//~
