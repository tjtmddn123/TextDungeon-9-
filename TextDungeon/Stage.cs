using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    // 스테이지의 흐름
    // 1. 각각 해당하는 스테이지 메서드를 만든다. 몬스터 스테이지, 특수 스테이지(보스, 랜덤기도, 회복샘,  상점) 1 - 1, 1 - 2 등 1 - n 에 해당하는 세부 적인 장면 구현
    // 2. 스테이지 (3.)에 세팅할 메서드를 만든다. (세부 구현한 스테이지 들을 어떤식으로 배치할지, 몬스터의 대한 매개변수, 아티템에 대한 매개변수를 어떻게 받아올지)
    // 3. 큰 스테이지를 만든다. ( 세부 스테이지에 스테이지를 세팅하는( 2. ) 메서드를 넣어주고 세부적인 스테이지를 넣어준다. ) 

    

    public class Stage
    {

        

        enum MonsterTypes // 몬스터의 타입을 지정해 같은 값이 나오면 그 타입으로 몬스터를 생성시키기 위해 일단 만들어놨다.
        {
            goblin = 1,
            troll,
            slime,
            werewolf,
            dragon,
        }



        public void Stage1(Character _player, Monster monster) // 함수의 이름만 바꿔서 큰 스테이지만큼 만들면 댐..
        {
            int randomRoom = new Random().Next(); // 각 스테이지의 방을 랜덤으로 설정한다. ex) 1 - 1 번방에 몬스터가 나올 수 도 있고 다른 특수한 방이 나올 수 도 있다.
            int randomIncount = new Random().Next(1, 4); // 여기서 각 스테이지의 몬스터 수를 랜덤하게 설정한다.
            StageSet(monster, randomIncount); // 스테이지 1에 맞는 세팅을 해주는 메서드.

            // * 몬스터는 스테이지 고정, 개체수 랜덤, 1 ~ 4 *


            BattleScene(_player, monster);

            // 몬스터와 싸우고 나면 몬스터의 피가 -로 되있다. 이 문제 해결해야댐. 


            // 도핑식으로 포션을 먹을지 말지 선택.

            BattleScene(_player, monster);
            BattleScene(_player, monster);
            BattleScene(_player, monster);
            BattleScene(_player, monster);
            BattleScene(_player, monster);
            BattleScene(_player, monster);
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("1 스테이지 보스를 물리쳤습니다!!");
            Console.ReadLine();
        }

        public void StageSet(Monster monster, int ranType) // 스테이지에 따라 몬스터를 다르게 배치할 수 있도록, 여기서 세팅한다.
        {
            List<string> mapList1 = new List<string>() {"들판", "들판안쪽", "평야외곽", "호수로가는길", "호수" , "호수안쪽", "호수바닥"};
            


            //switch (randomIncount)
            //{
            //    case 1:
            //        MonseterStage(_player, );
            //        break;
            //    case 2:
            //        MonseterStage();
            //        break;
            //    case 3:
            //        MonseterStage();
            //        break;
            //    case 4:
            //        MonseterStage();
            //        break;
            //}

            //  어떤 스테이지인지, 몇 라운드 인지 List로 구연

        }


        // 스테이지 별로 만든다. 보상 스테이지, 몬스터 스테이지, 보스 스테이지

        public void BattleScene(Character _player, Monster monster) // 매개변수 로 플레이어와 몬스터의 정보를 가져온다. // 죽지 않고 클리어시 스테이지2로 연결하는거 해야댐   
        {                                                                                // 몬스터 타입을 넣으면 그에 맞는 몬스터가 나옴
            // 어떤 요소가 들어와도 작동 할 수 있게.
            do
            {
                Console.Clear();
                //몬스터한테 방어력을 줘야되나? 아님 행동 랜덤 요소를 넣어줘야되나?

                //stpotion = new StrengthPotion("힘 포션");
                //hppotion = new HealthPotion("힐 포션");
                Console.WriteLine("게임이 시작됩니다!");
                Console.WriteLine(" 1 - 1 스테이지 (vs {0})\n", monster.Name); // 스테이지 숫자 변경 해야댐.
                Console.WriteLine(" 플레이어 ");
                Console.WriteLine($"이름 : {_player.Name}, 직업 : {_player.Job} "); //직업을 표시해줘야 될까? 
                Console.WriteLine($"공격력 : {_player.Atk}, 체력 : {_player.Hp}\n ");
                Console.WriteLine(" {0} ", monster.Name);
                Console.WriteLine($"이름 : {monster.Name} ");
                Console.WriteLine($"공격력 : {monster.Atk}, 체력 : {monster.Hp}\n ");
                Console.WriteLine("플레이어의 턴!!");
                Console.WriteLine("원하는 행동을 골라 보세요!");
                Console.WriteLine("1.공격");
                //Console.WriteLine("2.힘 포션 먹기");        인벤 보기를 넣을까 말까, 스킬 창을 따로 만들까 케이스로 구현할까
                //Console.WriteLine("3.힐 포션 먹기");       // 국민님이 만드신 메서드
                int _playerinput = int.Parse(Console.ReadLine());

                switch (_playerinput)
                {
                    case 1:
                        Console.WriteLine("몬스터를 공격합니다.");
                        monster.Hp -= _player.Atk;
                        Console.WriteLine($"{_player.Atk}에 피해를 주었습니다");
                        Console.WriteLine($"{monster.Name} 남은 체력 : {monster.Hp}\n");
                        break;
                    //case 2:
                    //    Console.WriteLine("힘 포션을 먹었습니다.");
                    //    stpotion.Use(__player);
                    //    Console.WriteLine($"현재 공격력 : {__player.Atk}");
                    //    break;
                    //case 3:
                    //    Console.WriteLine("힐 포션을 먹었습니다.");
                    //    hppotion.Use(_player);
                    //    Console.WriteLine($"현재 공격력 : {__player.Health}");
                    //    break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        break;
                }
                Thread.Sleep(1000);

                if (monster.Hp <= 0)
                {
                    Thread.Sleep(1000);
                    monster.IsDead = true;
                    Console.WriteLine("{0}을 무찔렀습니다!\n", monster.Name);
                    Console.WriteLine("보상으로 ?골드와 ?을 휙득했습니다.");

                    Console.WriteLine("다음 스테이지로 이동합니다....");
                }
                else
                {
                    Console.WriteLine("고블린의 턴!!");
                    _player.Hp -= monster.Atk;
                    Console.WriteLine($"{monster.Atk}에 피해를 입었습니다");
                    Console.WriteLine($"플레이어의 남은 체력 : {_player.Hp}");

                    if (_player.Hp <= 0)
                    {
                        _player.IsDead = true;
                        Console.WriteLine("플레이어가 사망하였습니다.");
                    }
                }

                Thread.Sleep(1000);
                Console.Clear();
            }

            while (!_player.IsDead && !monster.IsDead); //조건 정하기
        }
    }
}
