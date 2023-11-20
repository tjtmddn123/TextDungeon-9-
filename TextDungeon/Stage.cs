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
        List<string> stage1mapname = new List<string>() { "들판", "들판안쪽", "평야외곽", "호수로가는길", "호수", "호수안쪽", "호수바닥" };
        List<string> stage2mapname = new List<string>() { "가위", "바위", "보", "가나다", "라마바", "사아자", "차카" };
        List<string> stage3mapname = new List<string>() { "가위", "바위", "보", "가나다", "라마바", "사아자", "차카" };
        public int thisstagenum = 1;

        int CheckValidInput(int min, int max)
        {
            int keyInput;
            bool result;
            do
            {
                result = int.TryParse(Console.ReadLine(), out keyInput);
            } while (result == false || CheckIfValid(keyInput, min, max) == false);

            return keyInput;
        }

        bool CheckIfValid(int checkable, int min, int max)
        {
            if (min <= checkable && checkable <= max) return true;
            return false;
        }

        public void Stage1(Character _player, List<Monster> monsters, int stagenum , int minstage) // 함수의 이름만 바꿔서 큰 스테이지만큼 만들면 댐..
        {
             // 스테이지의 이름 설정을 하기위한 리스트
            int randomRoom = new Random().Next(); // 각 스테이지의 방을 랜덤으로 설정한다. ex) 1 - 1 번방에 몬스터가 나올 수 도 있고 다른 특수한 방이 나올 수 도 있다.

            StageSet(_player, monsters, stagenum, minstage); // 스테이지 1에 맞는 세팅을 해주는 메서드.

            // * 몬스터는 스테이지 고정, 개체수 랜덤, 1 ~ 4 *


            BattleScene(_player, monsters, stage1mapname);

            // 몬스터와 싸우고 나면 몬스터의 피가 -로 되있다. 이 문제 해결해야댐. 


            // 도핑식으로 포션을 먹을지 말지 선택.
            //BattleScene(_player, monster);
            //BattleScene(_player, monster);
            //BattleScene(_player, monster);
            //BattleScene(_player, monster);
            //BattleScene(_player, monster);
            //BattleScene(_player, monster);
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("1 스테이지 보스를 물리쳤습니다!!");
            Console.ReadLine();
        }

        public void StageSet(Character _player, List<Monster> monsters, int stagenum, int minstage) // 스테이지에 따라 몬스터를 다르게 배치할 수 있도록, 여기서 세팅한다.
        {

            int randomIncount = new Random().Next(1, 4); // 각 스테이지의 몬스터 수를 랜덤하게 설정한다.

            switch (stagenum)
            {
                case 1:
                    switch (minstage)
                    {
                        case 0:
                            //만약 1-0 방이라면~ 몬스터 세팅을 어떻게 
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 1: // 1 - 1
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin()); // 슬라임
                            } // 스테이지 마다 분리해서 
                            break;
                        case 2: // 1 - 2
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 3: // 1 - 3                             
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 4: // 1 - 4                        
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } 
                            break;
                        case 5: // 1 - 5                       
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } 
                            break;
                        case 6:// 1 - 6

                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } 
                            break;


                    }
                    break;
                case 2:
                    switch (minstage)
                    {
                        case 0:
                            //만약 1-0 방이라면~ 몬스터 세팅을 어떻게 
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 1: // 1 - 1
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 2: // 1 - 2
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 3: // 1 - 3                             
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 4: // 1 - 4                        
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                        case 5: // 1 - 5                       
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                        case 6:// 1 - 6

                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (minstage)
                    {
                        case 0:
                            //만약 1-0 방이라면~ 몬스터 세팅을 어떻게 
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 1: // 1 - 1
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 2: // 1 - 2
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 3: // 1 - 3                             
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            } // 스테이지 마다 분리해서 
                            break;
                        case 4: // 1 - 4                        
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                        case 5: // 1 - 5                       
                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                        case 6:// 1 - 6

                            for (int i = 0; i < randomIncount; i++)
                            {
                                monsters.Add(new Goblin());
                            }
                            break;
                    }
                    break;

            }
        }


        // 스테이지 별로 만든다. 보상 스테이지, 몬스터 스테이지, 보스 스테이지



        public void BattleScene(Character _player, List<Monster> monsters, List<string> mapList) // 매개변수 로 플레이어와 몬스터의 정보를 가져온다. // 죽지 않고 클리어시 스테이지2로 연결하는거 해야댐   
        {                                                                                // 몬스터 타입을 넣으면 그에 맞는 몬스터가 나옴
            int mapListIndex = 0;
            int monstersIndex = monsters.Count - 1;
            // 어떤 요소가 들어와도 작동 할 수 있게.
            do
            {
                Console.Clear();
                //몬스터한테 방어력을 줘야되나? 아님 행동 랜덤 요소를 넣어줘야되나?

                //stpotion = new StrengthPotion("힘 포션");
                //hppotion = new HealthPotion("힐 포션");
                Console.WriteLine("게임이 시작됩니다!");
                Console.WriteLine(" 1 - {0} 스테이지 (vs {1} 몬수터 수: {2})\n", mapList[mapListIndex], monsters[monstersIndex].Name, monsters.Count); // 스테이지 숫자 변경 해야댐.
                Console.WriteLine(" 플레이어 ");
                Console.WriteLine($"이름 : {_player.Name}, 직업 : {_player.Job} "); //직업을 표시해줘야 될까? 
                Console.WriteLine($"공격력 : {_player.Atk}, 체력 : {_player.Hp}\n ");

                for (int i = 0; i < monsters.Count; i++)
                {
                    Console.WriteLine("{0}: {1} ", i + 1, monsters[i].Name);
                    Console.WriteLine($"공격력 : {monsters[i].Atk}, 체력 : {monsters[i].Hp}\n ");
                }



                Console.WriteLine("플레이어의 턴!!");
                Console.WriteLine("원하는 행동을 골라 보세요!");
                Console.WriteLine("1.공격하기");

                switch (CheckValidInput(1, 1))
                {
                    case 1:
                        Console.WriteLine("원하시는 몬스터를 선택해주세요.");

                        int selectedMonsterIndex = CheckValidInput(1, monsters.Count) - 1; // monsters의 인덱스는 0부터 시작하기 때문에 -1을 했습니다.

                        Console.WriteLine("{0}를 공격합니다!");
                        monsters[selectedMonsterIndex].Hp -= _player.Atk;
                        Console.WriteLine("{0}의 피해를 주었습니다.", _player.Atk);
                        Console.WriteLine("{0}의 남은체력 :{1}", monsters[selectedMonsterIndex].Name, monsters[selectedMonsterIndex].Hp);

                        if (monsters[selectedMonsterIndex].Hp <= 0)
                        {
                            
                            monsters[selectedMonsterIndex].IsDead = true;
                            Console.WriteLine("{0}을 무찔렀습니다!\n", monsters[selectedMonsterIndex].Name);
                            Thread.Sleep(1000);
                        }
                        break;
                }
                Thread.Sleep(1000);

                foreach (Monster monster in monsters)
                {
                    if (monster.Hp > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("{0}의 턴!!", monster.Name);
                        if (!monster.IsDead)
                        {
                            _player.Hp -= monster.Atk;
                            Console.WriteLine($"{monster.Atk}의 피해를 입었습니다\n");
                            Console.WriteLine($"플레이어의 남은 체력 : {_player.Hp}");
                            Thread.Sleep(1000);

                            if (_player.Hp <= 0)
                            {
                                _player.IsDead = true;
                                Console.WriteLine("플레이어가 사망하였습니다.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{monster.Name}은(는) 이미 죽었습니다!");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"{monster.Name}은(는) 이미 죽었습니다!");
                    }

                }


                Thread.Sleep(1000);
                Console.Clear();
            }

            while (!_player.IsDead && monsters.Any(monsters => !monsters.IsDead)); 
            //Any는 LINQ의 기능입니다. 요소가 하나이상이라도 있으면 true을 반환하고, 비어있으면 false를 반환합니다. // monsters의 리스트 에서 isDead가 false인 몬스터가 하나이상 있는지
            // 확인하려는 용도로 사용했습니다. 즉 살아남은 몬스터가 하나이상 존재한다면 true를 다 죽었다면 false를 반환합니다.
        }
    }
}

